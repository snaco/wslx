using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSLXSetup
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			get_dep_tip.SetToolTip(get_dep_btn, "Will install the windowmanager on the subsystem.\nOnly do this if you haven't installed the windowmanager yourself.");
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
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
				Console.WriteLine(xserver);
				switch (xserver)
				{
					case "VcXsrv":
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
				string[] lines = { xserver, distro, win_mgr };
				string config_file = System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + @"\config";
				System.IO.File.WriteAllLines(config_file, lines);
			}
		}

		private void exec_btn_Click(object sender, EventArgs e)
		{
			string wslx_loc = System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + @"\WSLX.exe";
			System.Diagnostics.Process.Start(wslx_loc);
			this.Close();
		}

		private void get_dep_btn_Click(object sender, EventArgs e)
		{
			if (wsl_distro.SelectedIndex == -1 || window_manager.SelectedIndex == -1)
			{
				string selections = "";
				if (wsl_distro.SelectedIndex == -1) selections += " * Linux Distro\n";
				if (xserver_client.SelectedIndex == -1) selections += " * XServer Client\n";
				if (window_manager.SelectedIndex == -1) selections += " * Window Manager";
				MessageBox.Show("Missing selections:\n" + selections, "WSLX Setup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
