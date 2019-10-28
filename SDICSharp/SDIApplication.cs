using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDICSharp
{
    public class SdiApplication : WindowsFormsApplicationBase
    {
        private static SdiApplication _instance = null;
        
        public SdiApplication()
        {
            IsSingleInstance = true;
            ShutdownStyle = ShutdownMode.AfterAllFormsClose;
        }

        public static SdiApplication Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SdiApplication();
                }

                return _instance;
            }
        }

        protected override void OnCreateMainForm()
        {
            DocForm.CreateForm();
        }

        protected override void OnStartupNextInstance(StartupNextInstanceEventArgs eventArgs)
        {
            DocForm.CreateForm();
        }
    }
}
