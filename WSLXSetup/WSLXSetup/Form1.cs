using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Management.Automation;
using System.Collections;
using System.Collections.ObjectModel;

namespace WSLXSetup
{
	public partial class Form1 : Form
	{
		private string pwd = System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
		public Form1()
		{
			InitializeComponent();
			//set tool tips
			get_dep_tip.SetToolTip(get_dep_btn, "Will install the windowmanager on the subsystem.\nOnly do this if you haven't installed the windowmanager yourself.");
			logfile_tip.SetToolTip(set_folder_btn, "Choose where to keep logfile of wsl output.  Default is the current directory.");

			//default values
			log_path_tbox.AppendText(pwd);
		}
		private void generate_config(object sender, EventArgs e)
		{
			GenerateConfig();	
		}
		private void GenerateConfig()
		{
			//make sure there are selections for each part of config
			//and keep track of which ones arent selected so they display in the error message
			if (wsl_distro.SelectedIndex == -1 || xserver_client.SelectedIndex == -1 || window_manager.SelectedIndex == -1)
			{
				string selections = "";
				if (wsl_distro.SelectedIndex == -1) selections += " * Linux Distro\n";
				if (xserver_client.SelectedIndex == -1) selections += " * XServer Client\n";
				if (window_manager.SelectedIndex == -1) selections += " * Window Manager";
				MessageBox.Show("Missing selections:\n" + selections, "WSLX Setup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				string xserver = xserver_client.Items[xserver_client.SelectedIndex].ToString();
				string distro = GetLinuxDistro();
				string win_mgr = GetWindowManager();
				string logfile_path = "logfile_path=\"" + log_path_tbox.Text + "\\logfile.txt\"";
				switch (xserver)
				{
					case "VcXsrv":
						//assumes default install location of vcxsrv
						//TODO: have setup find installation location 
						//or have user define install location
						xserver = "\"C:\\Program Files\\VcXsrv\\vcxsrv.exe\"";
						break;
					default:
						break;
				}
				xserver = "xserver_client=" + xserver;
				distro = "distro=" + distro;
				win_mgr = "window_manager=" + win_mgr;
				string[] lines = { xserver, distro, win_mgr, logfile_path };
				string config_file = pwd + @"\config";
				System.IO.File.WriteAllLines(config_file, lines);
			}
		}
		//Exit and Run button
		private void exec_btn_Click(object sender, EventArgs e)
		{
			string wslx_loc = System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + @"\WSLX.exe";
			System.Diagnostics.Process.Start(wslx_loc);
			this.Close();
		}
		//Runs setup script to install desktop environment or window manager in the WSL
		private void get_dep_btn_Click(object sender, EventArgs e)
		{
			//Checks to make sure a distro and window manager/desktop environment is selected
			if (wsl_distro.SelectedIndex == -1 || window_manager.SelectedIndex == -1)
			{
				string selections = "";
				if (wsl_distro.SelectedIndex == -1) selections += " * Linux Distro\n";
				if (xserver_client.SelectedIndex == -1) selections += " * XServer Client\n";
				if (window_manager.SelectedIndex == -1) selections += " * Window Manager";
				MessageBox.Show("Missing selections:\n" + selections, "WSLX Setup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				PowerShell ps = PowerShell.Create();
				string distro = GetLinuxDistro();
				string win_mgr = GetWindowManager();
				if (distro.Equals("ubuntu.exe") || distro.Equals("ubuntu1604.exe") || distro.Equals("ubuntu1804.exe") || distro.Equals("debian.exe") || distro.Equals("kali.exe"))
				{
					Process p = new Process();
					p.StartInfo.FileName = "PowerShell.exe";
					string term = GetTerminalEmulator();
					switch (GetWindowManager())
					{
						case "i3":
							switch (term)
							{
								case "urxvt":
									p.StartInfo.Arguments = "-Command \"Start-Process " + distro + " -ArgumentList " +
										"'run sudo apt update " +
										"&& sudo apt upgrade -y " +
										"&& sudo apt-get install -y " + win_mgr +
										//"&& sudo apt-get install -y feh " +
										//"&& cat Defaults/i3Config > ~/.config/i3/config " +
										//"&& mkdir ~/Pictures " +
										//"&& cp Defaults/Plane.jpg ~/Pictures/Plane.jpg" +
										"'\"";
									break;
								case "terminator":
									p.StartInfo.Arguments = "-Command \"Start-Process " + distro + " -ArgumentList " +
										"'run sudo apt update " +
										"&& sudo apt upgrade -y " +
										"&& sudo apt-get install -y " + win_mgr + " " +
										//"&& sudo apt-get install -y feh " +
										//"&& cat Defaults/i3Config > ~/.config/i3/config " +
										//"&& mkdir ~/Pictures " +
										//"&& cp Defaults/Plane.jpg ~/Pictures/Plane.jpg " +
										"&& sudo apt-get install -y terminator " +
										"&& mkdir ~/.config/terminator" +
										//"&& cat Defaults/terminatorConfig > ~/.config/terminator/config" +
										"'\"";
									break;
							}
							break;
						case "xfce4-session":
							p.StartInfo.Arguments = "-Command \"Start-Process " + distro + " -ArgumentList " +
										"'run sudo apt update " +
										"&& sudo apt upgrade -y " +
										"&& sudo apt-get install -y xfce4" +
										//"&& cp Defaults/Plane.jpg ~/Pictures/Plane.jpg " +
										//"&& xfconf-query --channel xfce4-desktop --property /backdrop/screen0/monitor0/image-path --set ~/Plane.jpg" +
										"'\"";
							break;
						case "mate-session":
							p.StartInfo.Arguments = "-Command \"Start-Process " + distro + " -ArgumentList " +
										"'run sudo apt update " +
										"&& sudo apt upgrade -y " +
										"&& sudo apt-get install -y mate" +
										//"&& cp Defaults/Plane.jpg ~/Pictures/Plane.jpg " +
										//"&& xfconf-query --channel xfce4-desktop --property /backdrop/screen0/monitor0/image-path --set ~/Plane.jpg" +
										"'\"";
							break;
						default:
							break;
					}
					p.Start();
					p.WaitForExit();
				}
			}
			GenerateConfig();
		}
		//Returns the window manager in script/config ready format
		private string GetWindowManager()
		{
			if (window_manager.SelectedIndex == -1)
			{
				MessageBox.Show("Missing Window Manager Selection!", "WSLX Setup", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return "";
			}
			else
			{
				string win_mgr = window_manager.Items[window_manager.SelectedIndex].ToString();
				switch (win_mgr)
				{
					case "i3":
						return "i3";
					case "xfce":
						return "xfce4-session";
					case "MATE":
						return "mate-session";
					default:
						return "";
				}
			}		
		}
		//Returns the selected distro in the script/config ready format
		private string GetLinuxDistro()
		{
			if (wsl_distro.SelectedIndex == -1)
			{
				MessageBox.Show("Missing Distro Selection!", "WSLX Setup", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return "";
			}
			else
			{
				string distro = wsl_distro.Items[wsl_distro.SelectedIndex].ToString();
				switch (distro)
				{
					case "Ubuntu 16.04":
						return "ubuntu1604.exe";
                    case "Ubuntu":
                        return "ubuntu.exe";
					case "Ubuntu 18.04":
						return "ubuntu1804.exe";
					case "Debian GNU/Linux":
						return "debian.exe";
					case "openSUSE Leap 42":
						return "openSUSE-42.exe";
					case "Kali":
						return "kali.exe";
					case "WLinux":
						return "WLinux.exe";
					default:
						return "";
				}
			}
		}
		//get the terminal emulator selection, this is just to clean up code
		private string GetTerminalEmulator()
		{
				return term_list.Items[term_list.SelectedIndex].ToString();
		}
		//Set the folder for the log file
		private void set_folder_btn_Click(object sender, EventArgs e)
		{
			DialogResult result = set_logfie_output.ShowDialog();
			if (result == DialogResult.OK)
			{
				log_path_tbox.Clear();
				log_path_tbox.AppendText(set_logfie_output.SelectedPath);
			}
		}
		private void set_logfie_output_HelpRequest(object sender, EventArgs e)
		{

		}
		//Update supported terminal emulators based on distro selection
		private void wsl_distro_SelectedIndexChanged(object sender, EventArgs e)
		{
			term_list.Items.Clear();
			window_manager.Items.Clear();
			string distro = GetLinuxDistro();
			switch (distro)
			{
				case "ubuntu1804.exe":
					term_list.Items.Add("urxvt");
					term_list.Items.Add("terminator");
					window_manager.Items.Add("i3");
					window_manager.Items.Add("xfce");
					window_manager.Items.Add("MATE");
					break;
                case "ubuntu.exe":
					term_list.Items.Add("urxvt");
					term_list.Items.Add("terminator");
					window_manager.Items.Add("i3");
					window_manager.Items.Add("xfce");
					break;
				case "ubuntu1604.exe":
					term_list.Items.Add("urxvt");
					term_list.Items.Add("terminator");
					window_manager.Items.Add("i3");
					window_manager.Items.Add("xfce");
					window_manager.Items.Add("MATE");
					break;
				case "debian.exe":
					//no terminator support due to a dbus issue.
					term_list.Items.Add("urxvt");
					window_manager.Items.Add("xfce");
					window_manager.Items.Add("MATE");
					break;
				case "kali.exe":
					term_list.Items.Add("urxvt");
					term_list.Items.Add("terminator");
					window_manager.Items.Add("xfce");
					window_manager.Items.Add("MATE");
					break;

			}
			term_list.SelectedIndex = 0;
		}
		//convert windows path to linux path
		public string TranslatePathToLinux(string path)
		{
			string new_path = "/mnt/c/";
			path = path.Replace('\\', '/');
			path = path.Replace(" ", "\\ ");
			path = path.Replace('"', '\0');
			new_path += path.Substring(4);
			return new_path;
		}

		private void window_manager_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			string win_mgr = GetWindowManager();
			switch (win_mgr)
			{
				case "i3":
					break;
				case "xfce4-session":
					term_list.Items.Clear();
					term_list.Items.Add("default");
					term_list.SelectedIndex = 0;
					break;
			}
			term_list.SelectedIndex = 0;
		}
	}
}
