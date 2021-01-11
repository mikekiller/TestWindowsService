using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TestWindowsService
{
    public partial class Scheduler : ServiceBase
    {
        
        public Scheduler()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {

            String applicationName = "\"C:\\Program Files (x86)\\MikeVargas\\A2O Dev\\SystemTrayNotification.exe\"";         
            ApplicationLoader.PROCESS_INFORMATION procInfo;
            ApplicationLoader.StartProcessAndBypassUAC(applicationName, out procInfo);
            Library.WriteErrorLog("My A20Dev service running");
             

        }

        protected override void OnStop()
        {
            
            Library.WriteErrorLog("My A20Dev service stopped");
        }

        
    }
}
