using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using System.ComponentModel;

namespace ExecuteOnSave
{
	public class ExecuteOnSavePropertyPage : IPropertyPage
	{
		public bool IsDirty { get; set; }
		private string myConfigProp;

		[Category("My Category")]
		[DisplayName("My Config Property")]
		[Description("My Description")]
		public string MyConfigProp
		{
			get { return myConfigProp; }
			set { myConfigProp = value; IsDirty = true; }
		}

		public void SetPageSite(IPropertyPageSite pPageSite)
		{
			throw new NotImplementedException();
		}

		public void Activate(IntPtr hWndParent, RECT[] pRect, int bModal)
		{
			throw new NotImplementedException();
		}

		public void Deactivate()
		{
			throw new NotImplementedException();
		}

		public void GetPageInfo(PROPPAGEINFO[] pPageInfo)
		{
			throw new NotImplementedException();
		}

		public void SetObjects(uint cObjects, object[] ppunk)
		{
			throw new NotImplementedException();
		}

		public void Show(uint nCmdShow)
		{
			throw new NotImplementedException();
		}

		public void Move(RECT[] pRect)
		{
			throw new NotImplementedException();
		}

		public int IsPageDirty()
		{
			throw new NotImplementedException();
		}

		public int Apply()
		{
			throw new NotImplementedException();
		}

		public void Help(string pszHelpDir)
		{
			throw new NotImplementedException();
		}

		public int TranslateAccelerator(MSG[] pMsg)
		{
			throw new NotImplementedException();
		}
	}
	//{
	//	private Xwt.CheckBox _cmdOnSave;
	//	private Xwt.SearchTextEntry _cmdFilePath;

	//	public override void ApplyChanges()
	//	{
	//		var project = App.Properties[IdeApp.ProjectOperations.CurrentSelectedSolution.Name]
	//		                 .GetProject(IdeApp.ProjectOperations.CurrentSelectedProject.Name);
	//		project.IsRunOnSave = _cmdOnSave.Active;
	//		project.CommandConfigPath = _cmdFilePath.Text;
	//		project.SaveConfig();
	//		App.Properties[IdeApp.ProjectOperations.CurrentSelectedSolution.Name].SaveProperties(IdeApp.ProjectOperations.CurrentSelectedSolution.BaseDirectory);
	//	}

	//	public override Control CreatePanelWidget()
	//	{
	//		Xwt.VBox box = new Xwt.VBox();
	//		box.Spacing = 6;
	//		box.Margin = 12;

	//		var sol = IdeApp.ProjectOperations.CurrentSelectedSolution;
	//		var pro = IdeApp.ProjectOperations.CurrentSelectedProject;

	//		var project = App.Properties[sol.Name].GetProject(IdeApp.ProjectOperations.CurrentSelectedProject.Name);
	//		_cmdOnSave = new Xwt.CheckBox(GettextCatalog.GetString("run on save"))
	//		{
	//			Active = project == null || project.IsRunOnSave
	//		};

	//		_cmdFilePath = new Xwt.SearchTextEntry()
	//		{
	//			Text = project == null ? "" : project.CommandConfigPath
	//		};

	//		box.PackStart(_cmdOnSave);
	//		box.PackStart(_cmdFilePath);
	//		box.Show();
	//		return box.ToGtkWidget();
	//	}
	//}
}
