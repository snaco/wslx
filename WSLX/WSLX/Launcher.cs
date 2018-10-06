using System.Management.Automation;
using System.IO;
using System.Diagnostics;
using System.Collections;
using System.Windows.Forms;

namespace WSLX
{
	class Launcher
	{
		static void Main(string[] args)
		{
			Launcher launcher = new Launcher();			
			launcher.GetConfig();
			PowerShell ps = PowerShell.Create();
			string script;
			if ((script = launcher.GenerateScript()) != null)
			{
				ps.AddScript(script);
				ps.Invoke();
			}
			else
			{
				MessageBox.Show("Could not generate config file!\n" +
					"Check config file for errors or run the WSLX Setup again to reconfigure.", 
					"WSLX",
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		string xserver_client = "";
		string distro = "";
		string window_manager = "";
		string logfile_path = "";

		//Builds the script from the gathered config information
		public string GenerateScript()
		{
			switch (xserver_client)
			{
				case "X410":
					return "Start-Process "
							+ xserver_client
							+ "; "
							+ "Start-Process "
							+ distro
							+ " -WindowStyle Hidden -ArgumentList "
							+ "\'run \"export DISPLAY=127.0.0.1:0.0 && "
							+ window_manager
							+ " &> "
							+ TranslatePathToLinux(logfile_path)
							+ "\"\'";
					//Start-Process ubt -WS H -AL 'run "export D=123 && i3 &> pth"'
				case "\"C:\\Program Files\\VcXsrv\\vcxsrv.exe\"":
					return "Start-Process "
							+ xserver_client 
							+ " -ArgumentList \"-nodecoration -winkill\"; "
							+ "Start-Process "
							+ distro
							+ " -WindowStyle Hidden -ArgumentList "
							+ "\'run \"export DISPLAY=127.0.0.1:0.0 && "
							+ window_manager
							+ " &> "
							+ TranslatePathToLinux(logfile_path)
							+ "\"\'";
				default:
					return null;
			}
		}
		//translate the Windows directory path to one the linux subsystem can understand
		public string TranslatePathToLinux(string path)
		{
			string new_path = "/mnt/c/";
			path = path.Replace('\\', '/');
			path = path.Replace(" ", "\\ ");
			path = path.Replace('"', '\0');
			new_path += path.Substring(4);
			return new_path;
		}
		//Reads the config file stored in the same location as the .exe and stores the values
		public void GetConfig()
		{
			string config_file = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\config";
			try
			{
				StreamReader file = new StreamReader(config_file);
				ArrayList lines = new ArrayList();
				string line;
				while ((line = file.ReadLine()) != null)
				{
					//line = Regex.Replace(line, @"\s", "");
					int index = line.IndexOf('=') + 1;
					if (line.Contains("xserver_client="))
					{
						xserver_client = line.Substring(index);
					}
					else if (line.Contains("distro="))
					{
						distro = line.Substring(index);
					}
					else if (line.Contains("window_manager="))
					{
						window_manager = line.Substring(index);
					}
					else if (line.Contains("logfile_path="))
					{
						logfile_path = line.Substring(index);
					}
				}
			}
			catch (FileNotFoundException)
			{
				MessageBox.Show("No config file found! Did you run the WSLXSetup?", "WSLX", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
	
}
