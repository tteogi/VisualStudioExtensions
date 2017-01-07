using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell.Interop;

namespace ExecuteOnSave
{
	class ExecuteOnSaveProvider
	{
		private bool _active = false;

        public ExecuteOnSaveProvider()
        {
        }

        public bool Active
        {
            get { return _active; }
        }

        public int SetActive()
        {
            Debug.WriteLine(string.Format(CultureInfo.CurrentUICulture, "Scc Provider is now active"));

            _active = true;
            return VSConstants.S_OK;
        }

        public int SetInactive()
        {
            Debug.WriteLine(string.Format(CultureInfo.CurrentUICulture, "Scc Provider is now inactive"));

            _active = false;
            //_sccProvider.OnActiveStateChange();

            return VSConstants.S_OK;
        }

        public int AnyItemsUnderSourceControl(out int pfResult)
        {
            pfResult = 0;
            return VSConstants.S_OK;
        }
	}
}
