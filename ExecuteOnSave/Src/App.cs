using EnvDTE;
using Microsoft.VisualStudio;
using EnvDTE80;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Shell;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;

namespace ExecuteOnSave
{
	public class App
	{
		static Dictionary<string, CommandProperty> _properties = new Dictionary<string, CommandProperty>();
		static CommandExecuter _commandOnSaveDocumentExecuter = new CommandExecuter();
		private static DTE _dte;

		public static Dictionary<string, CommandProperty> Properties
		{
			get { return _properties; }
		}

		public static DTE Dte { get => _dte; set => _dte = value; }

		public static void LogError(string msg, Exception ex)
		{
			Log(msg + "wn" + ex.ToString());
		}

		public static void Log(string msg)
		{
			Window window = _dte.Windows.Item(EnvDTE.Constants.vsWindowKindOutput);
			OutputWindow outputWindow = (OutputWindow) window.Object;
			outputWindow.ActivePane.OutputString(msg);
		}
	}
}
