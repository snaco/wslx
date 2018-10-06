using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WSLXSetup
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			//set tool tips
			get_dep_tip.SetToolTip(get_dep_btn, "Will install the windowmanager on the subsystem.\nOnly do this if you haven't installed the windowmanager yourself.");
			logfile_tip.SetToolTip(set_folder_btn, "Choose where to keep logfile of wsl output.  Default is the current directory.");

			//default values
			log_path_tbox.AppendText(System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName));
		}
		private void generate_config(object sender, EventArgs e)
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
				string distro = wsl_distro.Items[wsl_distro.SelectedIndex].ToString();
				string xserver = xserver_client.Items[xserver_client.SelectedIndex].ToString();
				string win_mgr = window_manager.Items[window_manager.SelectedIndex].ToString();
				string logfile_path = "logfile_path=\""+log_path_tbox.Text+"\\logfile.txt\"";
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
				switch (distro)
				{
					case "Ubuntu 18.04":
						distro = "ubuntu1804.exe";
						break;
					case "Debian GNU/Linux":
						distro = "debian.exe";
						break;
					case "openSUSE Leap 42":
						distro = "openSUSE-42.exe";
						break;
					case "Kali":
						distro = "kali.exe";
						break;
					case "WLinux":
						distro = "WLinux.exe";
						break;
					default:
						break;
				}
				xserver = "xserver_client=" + xserver;
				distro = "distro=" + distro;
				win_mgr = "window_manager=" + win_mgr;
				string[] lines = { xserver, distro, win_mgr, logfile_path };
				string config_file = System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + @"\config";
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
		//TODO: actuall make this do something
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
	}
}
