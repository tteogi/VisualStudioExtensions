using System.Diagnostics;
using System.IO;

namespace ExecuteOnSave
{
	class CommandExecuter
	{
		private string _workspace;
		public CommandExecuter(string workspace = "")
		{
			_workspace = workspace;
		}

		public string Execute(CommandProperty.Command command, Placeholder placeholder = null)
		{
			return Execute(command, _workspace, placeholder);
		}

		public static string Execute(CommandProperty.Command command, string workspaceDirectory, Placeholder placeholder = null)
		{
			string cmd = command.Cmd;
			string arg = command.Argument;
			if (placeholder != null)
			{
				cmd = placeholder.ReplacePlaceholder(command.Cmd);
				arg = placeholder.ReplacePlaceholder(command.Argument);
			}

			string absoluteCmdPatch = cmd;//Path.GetFullPath(cmd.Cmd);
			if (GCore.Path.IsAbsolutePatch(absoluteCmdPatch) == false)
			{
				absoluteCmdPatch = Path.Combine(workspaceDirectory, absoluteCmdPatch);
				absoluteCmdPatch = Path.GetFullPath(absoluteCmdPatch);
			}

			var process = new Process();
			process.StartInfo = (new ProcessStartInfo(absoluteCmdPatch, arg)
			{
				WorkingDirectory = workspaceDirectory,
				CreateNoWindow = true,
				UseShellExecute = false,
			});

			process.Start();
			process.WaitForExit();
			process.Close();
			return "";
		}
	}
}
