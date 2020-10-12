using System;
using System.Collections;
using System.Configuration.Install;
using System.ServiceProcess;
using System.ComponentModel;
using Microsoft.Win32;

namespace C1ReportsSchedulerService
{
    [RunInstallerAttribute(true)]
    public class C1ReportsSchedulerProjectInstaller : Installer
    {
        private ServiceInstaller serviceInstaller;
        private ServiceProcessInstaller processInstaller;

        public C1ReportsSchedulerProjectInstaller()
        {
            // Instantiate installers for process and services.
            processInstaller = new ServiceProcessInstaller();
            serviceInstaller = new C1ReportsSchedulerServiceInstaller();

            // The services run under the system account.
            processInstaller.Account = ServiceAccount.LocalSystem;

            // The services are started manually.
            serviceInstaller.StartType = ServiceStartMode.Manual;

            // ServiceName must equal those on ServiceBase derived classes.            
            serviceInstaller.ServiceName = Constants.Name;

            // Add installers to collection. Order is not important.
            Installers.Add(serviceInstaller);
            Installers.Add(processInstaller);
        }
    }

    public class C1ReportsSchedulerServiceInstaller : ServiceInstaller
    {
        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);

#if not_yet // add reg keys and do other post-install stuff here...
            string keyName = Constants.RegKey_Root;
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(keyName, true))
            {
                key.SetValue(Constants.RegKey_WcfEndpointAddress,
                    // todo: what is a good default?
                    "http://localhost:8002/C1ReportsSchedulerService/ReportsSchedulerWcf/ReportsSchedulerWcfService",
                    RegistryValueKind.String);
            }
#endif
        }
    }
}
