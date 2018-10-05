using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.IO;
using System.Diagnostics;
using System.Collections;
using System.Text.RegularExpressions;

namespace WSLX
{
	class Launcer
	{
		string xserver_client = "";
		string distro = "";
		string window_manager = "";

		static void Main(string[] args)
		{
			Launcer launcher = new Launcer();

			
			ArrayList file_lines = launcher.GetConfig();
			launcher.AssignConfigs(file_lines, ref launcher.xserver_client, ref launcher.distro, ref launcher.window_manager);
			Console.WriteLine("{0} {1} {2}", launcher.xserver_client, launcher.distro, launcher.window_manager);
			Console.ReadLine();
			/*
			PowerShell ps = PowerShell.Create();
			ps.AddScript("Start-Process "+xserver_client+"; " +
				"Start-Process ubuntu1804 -WindowStyle Hidden -ArgumentList " +
				"\'run \"export DISPLAY=127.0.0.1:0.0 && i3\"\'");
			ps.Invoke();
			*/
		}
		//vcxsrv -nodecoration
		public void AssignConfigs(ArrayList config_lines, ref string xserver_client, ref string distro, ref string window_manager)
		{
			foreach (string s in config_lines)
			{
				int index = s.IndexOf('=') + 1;
				if (s.Contains("xserver_client="))
				{
					xserver_client = s.Substring(index);
				}
				else if (s.Contains("distro="))
				{
					distro = s.Substring(index);
				}
				else if (s.Contains("window_manager="))
				{
					window_manager = s.Substring(index);
				}
			}
		}
		public ArrayList GetConfig()
		{
			string config_file = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\config";
			StreamReader file = new StreamReader(config_file);
			ArrayList lines = new ArrayList();
			Console.WriteLine(config_file);
			string line;
			while ((line = file.ReadLine()) != null)
			{
				line = Regex.Replace(line, @"\s", "");
				lines.Add(line);
			}
			return lines;
		}
	}
	
}
