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
        private Timer timer1 = null;
        public Scheduler()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            timer1 = new Timer();
            this.timer1.Interval = 30000;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Tick);
            timer1.Enabled = true;
            Library.WriteErrorLog("Test windows service started");

            String applicationName = "\"C:\\Program Files (x86)\\MikeVargas\\TestService\\SystemTrayNotification\\SystemTrayNotification.exe\"";         
            ApplicationLoader.PROCESS_INFORMATION procInfo;
            ApplicationLoader.StartProcessAndBypassUAC(applicationName, out procInfo);

            

        }
        private void timer1_Tick(object sender , ElapsedEventArgs e)
        {
            //write code here to do some job depends on your requirements
            Library.WriteErrorLog("Timer ticked and some job has been done sucessfully");
        }

        protected override void OnStop()
        {
            timer1.Enabled = false;
            Library.WriteErrorLog("Test windows services stopped");
        }

        
    }
}
