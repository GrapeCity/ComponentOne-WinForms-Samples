using System;
using System.Runtime.InteropServices;
namespace ServiceInstaller
{
    /// <summary>
    /// Summary description for ServiceInstaller.
    /// <para>From:
    /// http://www.c-sharpcorner.com/UploadFile/sachin.nigam/InstallingWinServiceProgrammatically11262005061332AM/InstallingWinServiceProgrammatically.aspx
    /// </para>
    /// </summary>
    internal static class InstallService
    {
        #region Win32 API constants
        /// <summary>
        /// Value to indicate no change to an optional parameter
        /// </summary>
        private const int SERVICE_NO_CHANGE = unchecked ((int)0xffffffff);

        /// <summary>
        /// The data area passed to a system call is too small.
        /// </summary>
        private const int ERROR_INSUFFICIENT_BUFFER = 122;

        private class ScManagerAccessRigths
        {
            /// <summary>
            /// Includes STANDARD_RIGHTS_REQUIRED, in addition to all access rights in this table. 
            /// </summary>
            public const int SC_MANAGER_ALL_ACCESS = 0xF003F;
            /// <summary>
            /// Required to call the CreateService function to create a service object and add it to the database. 
            /// </summary>
            public const int SC_MANAGER_CREATE_SERVICE = 0x0002;
            /// <summary>
            /// Required to connect to the service control manager. 
            /// </summary>
            public const int SC_MANAGER_CONNECT = 0x0001;
            /// <summary>
            /// Required to call the EnumServicesStatusEx function to list the services that are in the database. 
            /// </summary>
            public const int SC_MANAGER_ENUMERATE_SERVICE = 0x0004;
            /// <summary>
            /// Required to call the LockServiceDatabase function to acquire a lock on the database. 
            /// </summary>
            public const int SC_MANAGER_LOCK = 0x0008;
            /// <summary>
            /// Required to call the NotifyBootConfigStatus function. 
            /// </summary>
            public const int SC_MANAGER_MODIFY_BOOT_CONFIG = 0x0020;
            /// <summary>
            /// Required to call the QueryServiceLockStatus function to retrieve the lock status information for the database. 
            /// </summary>
            public const int SC_MANAGER_QUERY_LOCK_STATUS = 0x0010;
        }

        private class ScManagerGenericAccessRigths
        {
            /// <summary>
            /// STANDARD_RIGHTS_WRITE SC_MANAGER_CREATE_SERVICE SC_MANAGER_MODIFY_BOOT_CONFIG
            /// </summary>
            public const int GENERIC_WRITE = 0x40000000;
        }

        private class ServiceStandardAccessRigths
        {
            /// <summary>
            /// Required to call the DeleteService function to delete the service.
            /// </summary>
            public const int DELETE = 0x10000;
        }

        private class ServiceType
        {
            /// <summary>
            /// File system driver service.
            /// </summary>
            public const int SERVICE_FILE_SYSTEM_DRIVER = 0x00000002;
            /// <summary>
            /// Driver service.
            /// </summary>
            public const int SERVICE_KERNEL_DRIVER = 0x00000001;
            /// <summary>
            /// Service that runs in its own process.
            /// </summary>
            public const int SERVICE_WIN32_OWN_PROCESS = 0x00000010;
            /// <summary>
            /// Service that shares a process with one or more other services. For more information, see Service Programs.
            /// </summary>
            public const int SERVICE_WIN32_SHARE_PROCESS = 0x00000020;
        }

        private class ServiceAccessRigths
        {
            public const int STANDARD_RIGHTS_REQUIRED = 0xF0000;
            /// <summary>
            /// Includes STANDARD_RIGHTS_REQUIRED in addition to all access rights in this table. 
            /// </summary>
            public const int SERVICE_ALL_ACCESS = 0xF01FF;
            /// <summary>
            /// Required to call the ChangeServiceConfig or ChangeServiceConfig2 function to change the service configuration.
            /// Because this grants the caller the right to change the executable file that the system runs, it should be granted only to administrators.  
            /// </summary>
            public const int SERVICE_CHANGE_CONFIG = 0x0002;
            /// <summary>
            /// Required to call the EnumDependentServices function to enumerate all the services dependent on the service. 
            /// </summary>
            public const int SERVICE_ENUMERATE_DEPENDENTS = 0x0008;
            /// <summary>
            /// Required to call the ControlService function to ask the service to report its status immediately. 
            /// </summary>
            public const int SERVICE_INTERROGATE = 0x0080;
            /// <summary>
            /// Required to call the ControlService function to pause or continue the service. 
            /// </summary>
            public const int SERVICE_PAUSE_CONTINUE = 0x0040;
            /// <summary>
            /// Required to call the QueryServiceConfig and QueryServiceConfig2 functions to query the service configuration. 
            /// </summary>
            public const int SERVICE_QUERY_CONFIG = 0x0001;
            /// <summary>
            /// Required to call the QueryServiceStatusEx function to ask the service control manager about the status of the service. 
            /// </summary>
            public const int SERVICE_QUERY_STATUS = 0x0004;
            /// <summary>
            /// Required to call the StartService function to start the service. 
            /// </summary>
            public const int SERVICE_START = 0x0010;
            /// <summary>
            /// Required to call the ControlService function to stop the service. 
            /// </summary>
            public const int SERVICE_STOP = 0x0020;
            /// <summary>
            /// Required to call the ControlService function to specify a user-defined control code. 
            /// </summary>
            public const int SERVICE_USER_DEFINED_CONTROL = 0x0100;
        }

        private class ServiceStartType
        {
            /// <summary>
            /// A service started automatically by the service control manager during system startup.
            /// For more information, see Automatically Starting Services.
            /// </summary>
            public const int SERVICE_AUTO_START = 0x00000002;
            /// <summary>
            /// A device driver started by the system loader. This value is valid only for driver services.
            /// </summary>
            public const int SERVICE_BOOT_START = 0x00000000;
            /// <summary>
            /// A service started by the service control manager when a process calls the StartService function.
            /// For more information, see Starting Services on Demand.
            /// </summary>
            public const int SERVICE_DEMAND_START = 0x00000003;
            /// <summary>
            /// A service that cannot be started. Attempts to start the service result in the error code ERROR_SERVICE_DISABLED.
            /// </summary>
            public const int SERVICE_DISABLED = 0x00000004;
            /// <summary>
            /// A device driver started by the IoInitSystem function. This value is valid only for driver services.
            /// </summary>
            public const int SERVICE_SYSTEM_START = 0x00000001;
        }

        private class ServiceErrorControl
        {
            /// <summary>
            /// The startup program logs the error in the event log, if possible.
            /// If the last-known-good configuration is being started, the startup operation fails.
            /// Otherwise, the system is restarted with the last-known good configuration.
            /// </summary>
            public const int SERVICE_ERROR_CRITICAL = 0x00000003;
            /// <summary>
            /// The startup program ignores the error and continues the startup operation.
            /// </summary> 
            public const int SERVICE_ERROR_IGNORE = 0x00000000;
            /// <summary>
            /// The startup program logs the error in the event log but continues the startup operation.
            /// </summary>
            public const int SERVICE_ERROR_NORMAL = 0x00000001;
            /// <summary>
            /// The startup program logs the error in the event log.
            /// If the last-known-good configuration is being started, the startup operation continues.
            /// Otherwise, the system is restarted with the last-known-good configuration.
            /// </summary>
            public const int SERVICE_ERROR_SEVERE = 0x00000002;
        }

        private class ServiceConfig2InfoLevel
        {
            /// <summary>
            /// The lpInfo parameter is a pointer to a SERVICE_DESCRIPTION structure.
            /// </summary>
            public const int SERVICE_CONFIG_DESCRIPTION = 1;
        }
        #endregion Win32 API constants

        #region Win32 API functions
        [DllImport("advapi32.dll")]
        private static extern IntPtr OpenSCManager(string lpMachineName, string lpSCDB, int scParameter);

        [DllImport("Advapi32.dll")]
        private static extern IntPtr CreateService(IntPtr SC_HANDLE, string lpSvcName, string lpDisplayName,
            int dwDesiredAccess, int dwServiceType, int dwStartType, int dwErrorControl, string lpPathName,
            string lpLoadOrderGroup, int lpdwTagId, string lpDependencies, string lpServiceStartName, string lpPassword);

        [DllImport("advapi32.dll")]
        private static extern void CloseServiceHandle(IntPtr SCHANDLE);

        [DllImport("advapi32.dll")]
        private static extern int StartService(IntPtr SVHANDLE, int dwNumServiceArgs, string lpServiceArgVectors);

        [DllImport("advapi32.dll", SetLastError = true)]
        private static extern IntPtr OpenService(IntPtr SCHANDLE, string lpSvcName, int dwNumServiceArgs);

        [DllImport("advapi32.dll")]
        private static extern bool DeleteService(IntPtr SVHANDLE);

        [StructLayout(LayoutKind.Sequential)]
        private struct SERVICE_DESCRIPTION
        {
            public string lpDescription;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct QUERY_SERVICE_CONFIG
        {
            public int dwServiceType;
            public int dwStartType;
            public int dwErrorControl;
            public string lpBinaryPathName;
            public string lpLoadOrderGroup;
            public int dwTagId;
            public string lpDependencies;
            public string lpServiceStartName;
            public string lpDisplayName;
        }

        [DllImport("advapi32.dll")]
        private static extern bool QueryServiceConfig(
            IntPtr hService,
            IntPtr lpServiceConfig,
            int cbBufSize,
            ref int pcbBytesNeeded);

        [DllImport("advapi32.dll")]
        private static extern bool ChangeServiceConfig(
            IntPtr hService,
            int dwServiceType,
            int dwStartType,
            int dwErrorControl,
            string lpBinaryPathName,
            string lpLoadOrderGroup,
            IntPtr lpdwTagId,
            string lpDependencies,
            string lpServiceStartName,
            string lpPassword,
            string lpDisplayName);

        // We use this to set description only, hence 3rd param is of a fixed type:
        [DllImport("advapi32.dll")]
        private static extern bool ChangeServiceConfig2(IntPtr hService, int dwInfoLevel, ref SERVICE_DESCRIPTION lpDescription);

        [DllImport("kernel32.dll")]
        private static extern int GetLastError();
        #endregion Win32 API functions

        /// <summary>
        /// This method installs and runs the service in the service control manager.
        /// </summary>
        /// <param name="svcPath">The complete path of the service.</param>
        /// <param name="svcName">Name of the service.</param>
        /// <param name="svcDispName">Display name of the service.</param>
        /// <returns>True if the process went through successfully. False if there was any error.</returns>
        public static bool Install(string svcPath, string svcName, string svcDispName, bool autoStart)
        {
            bool ok = false;
            IntPtr hSCManager = IntPtr.Zero;
            IntPtr hService = IntPtr.Zero;
            try
            {
                hSCManager = OpenSCManager(null, null, ScManagerAccessRigths.SC_MANAGER_CREATE_SERVICE);
                if (hSCManager != IntPtr.Zero)
                {
                    hService = CreateService(hSCManager, svcName, svcDispName,
                        ServiceAccessRigths.SERVICE_ALL_ACCESS, ServiceType.SERVICE_WIN32_OWN_PROCESS,
                        autoStart ? ServiceStartType.SERVICE_AUTO_START : ServiceStartType.SERVICE_DEMAND_START,
                        ServiceErrorControl.SERVICE_ERROR_NORMAL,
                        svcPath, null, 0, null, null, null);
                    ok = hService != IntPtr.Zero;
                }
            }
            finally
            {
                if (hService != IntPtr.Zero)
                    CloseServiceHandle(hService);
                if (hSCManager != IntPtr.Zero)
                    CloseServiceHandle(hSCManager);
            }
            return ok;
        }

        /// <summary>
        /// This method uninstalls the service from the service conrol manager.
        /// </summary>
        /// <param name="svcName">Name of the service to uninstall.</param>
        public static bool Uninstall(string svcName)
        {
            bool ok = false;
            IntPtr hSCManager = IntPtr.Zero;
            IntPtr hService = IntPtr.Zero;
            try
            {
                hSCManager = OpenSCManager(null, null, ScManagerGenericAccessRigths.GENERIC_WRITE);
                if (hSCManager != IntPtr.Zero)
                {
                    hService = OpenService(hSCManager, svcName, ServiceStandardAccessRigths.DELETE);
                    if (hService != IntPtr.Zero)
                        ok = DeleteService(hService);
                }
            }
            finally
            {
                if (hService != IntPtr.Zero)
                    CloseServiceHandle(hService);
                if (hSCManager != IntPtr.Zero)
                    CloseServiceHandle(hSCManager);
            }
            return ok;
        }

        public static void SetDescription(string svcName, string description)
        {
            IntPtr hSCManager = IntPtr.Zero;
            IntPtr hService = IntPtr.Zero;
            try
            {
                hSCManager = OpenSCManager(null, null, ScManagerGenericAccessRigths.GENERIC_WRITE);
                if (hSCManager != IntPtr.Zero)
                {
                    hService = OpenService(hSCManager, svcName, ServiceAccessRigths.SERVICE_CHANGE_CONFIG);
                    if (hService != IntPtr.Zero)
                    {
                        SERVICE_DESCRIPTION sd = new SERVICE_DESCRIPTION();
                        sd.lpDescription = description;
                        if (ChangeServiceConfig2(hService, ServiceConfig2InfoLevel.SERVICE_CONFIG_DESCRIPTION, ref sd))
                            return;
                    }
                }
            }
            finally
            {
                if (hService != IntPtr.Zero)
                    CloseServiceHandle(hService);
                if (hSCManager != IntPtr.Zero)
                    CloseServiceHandle(hSCManager);
            }
            throw new Exception(string.Format("Could not set service description, error 0x{0:X8}.", GetLastError()));
        }

        public static bool GetAutoStartValue(string svcName)
        {
            IntPtr hSCManager = IntPtr.Zero;
            IntPtr hService = IntPtr.Zero;
            try
            {
                hSCManager = OpenSCManager(null, null, ScManagerGenericAccessRigths.GENERIC_WRITE);
                if (hSCManager != IntPtr.Zero)
                {
                    hService = OpenService(hSCManager, svcName, ServiceAccessRigths.SERVICE_QUERY_CONFIG);
                    if (hService != IntPtr.Zero)
                    {
                        int bufLen = 0;
                        if (QueryServiceConfig(hService, IntPtr.Zero, 0, ref bufLen))
                            throw new Exception("Unexpected result from QueryServiceConfig API.");
                        int err = GetLastError();
                        if (err != ERROR_INSUFFICIENT_BUFFER)
                            throw new Exception(string.Format("Could not get service configuration, error 0x{0:X8}.", err));
                        IntPtr pBuf = Marshal.AllocHGlobal(bufLen);
                        try
                        {
                            if (!QueryServiceConfig(hService, pBuf, bufLen, ref bufLen))
                                throw new Exception(string.Format("Could not get service configuration, error 0x{0:X8}.", GetLastError()));
                            QUERY_SERVICE_CONFIG qsc = (QUERY_SERVICE_CONFIG)Marshal.PtrToStructure(pBuf, typeof(QUERY_SERVICE_CONFIG));
                            return qsc.dwStartType == ServiceStartType.SERVICE_AUTO_START;
                        }
                        finally
                        {
                            Marshal.FreeHGlobal(pBuf);
                        }
                    }
                }
            }
            finally
            {
                if (hService != IntPtr.Zero)
                    CloseServiceHandle(hService);
                if (hSCManager != IntPtr.Zero)
                    CloseServiceHandle(hSCManager);
            }
            throw new Exception(string.Format("Could not get service configuration, error 0x{0:X8}.", GetLastError()));
        }

        public static void SetAutoStartValue(string svcName, bool autoStart)
        {
            IntPtr hSCManager = IntPtr.Zero;
            IntPtr hService = IntPtr.Zero;
            try
            {
                hSCManager = OpenSCManager(null, null, ScManagerGenericAccessRigths.GENERIC_WRITE);
                if (hSCManager != IntPtr.Zero)
                {
                    hService = OpenService(hSCManager, svcName, ServiceAccessRigths.SERVICE_CHANGE_CONFIG);
                    if (hService != IntPtr.Zero)
                    {
                        if (ChangeServiceConfig(hService, SERVICE_NO_CHANGE,
                            autoStart ? ServiceStartType.SERVICE_AUTO_START : ServiceStartType.SERVICE_DEMAND_START,
                            SERVICE_NO_CHANGE, null, null, IntPtr.Zero, null, null, null, null))
                            return;
                    }
                }
            }
            finally
            {
                if (hService != IntPtr.Zero)
                    CloseServiceHandle(hService);
                if (hSCManager != IntPtr.Zero)
                    CloseServiceHandle(hSCManager);
            }
            throw new Exception(string.Format("Could not change service configuration, error 0x{0:X8}.", GetLastError()));
        }
    }
}
