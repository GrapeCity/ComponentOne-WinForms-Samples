using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Diagnostics;

namespace C1ReportsSchedulerService
{
    static class Program
    {
        static void Main()
        {
#if DEBUG
            // System.Diagnostics.Debugger.Launch();
#endif  

            C1ReportsSchedulerService.Log("Main", "Service main method starting...");

            // Load the service into memory.
            System.ServiceProcess.ServiceBase.Run(new C1ReportsSchedulerService());

            C1ReportsSchedulerService.Log("Main", "Service main method exiting...");
        }
    }
}
