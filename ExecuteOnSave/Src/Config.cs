using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteOnSave
{
	public class Config
	{
		public class ProjectOption
		{
			public string Name;
			public bool IsRunOnSave = false;
			public string CommandConfigPath = "";
		}
		public int Port;
		public List<ProjectOption> ProjectOptions = new List<ProjectOption>();
	}
}
