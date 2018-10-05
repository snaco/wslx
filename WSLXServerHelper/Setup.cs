using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;

namespace WSLXServerHelper
{
	class Setup
	{
		static void Main(string[] args)
		{
			string xserver_client = "X410";
			PowerShell ps = PowerShell.Create();
			ps.AddScript("Start-Process "+xserver_client+"; " +
				"Start-Process ubuntu1804 -WindowStyle Hidden -ArgumentList " +
				"\'run \"export DISPLAY=127.0.0.1:0.0 && i3\"\'");
			ps.Invoke();
		}
	}
}
