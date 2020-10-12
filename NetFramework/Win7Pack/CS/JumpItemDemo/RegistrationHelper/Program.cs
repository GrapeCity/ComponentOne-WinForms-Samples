using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace RegistrationHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string progID = "C1TaskbarDemo";
                string extension = ".txt";
                if (args.Length > 0 && bool.Parse(args[0]))
                {
                    UnregisterFileAssociations(progID, extension);
                }
                else if (args.Length < 2)
                {
                    Console.WriteLine("Usage: <Unregister: true|false> <FullPathToExeFile>");
                    Console.ReadLine();
                }
                else
                {
                    string appID = "JumpItemDemo";
                    string friendlyName = "Text Document";
                    string defaultIcon = @"%systemroot%\system32\shell32.dll,284";
                    string openWithCommand = string.Format("\"{0}\" \"%1\"", args[1]);
                    RegisterFileAssociations(progID, appID, friendlyName, defaultIcon, openWithCommand, extension);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Registers file associations for the current application.
        /// </summary>
        /// <param name="progID">Name of the Registry key to be associated with the application.</param>
        /// <param name="appID">The application user model ID.</param>
        /// <param name="friendlyName">A friendly name for the data format, suitable to display to a user.</param>
        /// <param name="defaultIcon">The path to the default icon, such as, "%systemroot%\system32\imageres.dll,15".</param>
        /// <param name="openWithCommand">The command and arguments to be used when opening a shortcut to a document, such as,
        /// '"C:\Program Files\Paint.NET\PaintDotNet.exe" "%1"'.</param>
        /// <param name="extensions">The extensions to register, such as '.png'.</param>
        public static void RegisterFileAssociations(string progID, string appID, string friendlyName,
            string defaultIcon, string openWithCommand, params string[] extensions)
        {
            if (IsNullOrWhiteSpace(progID))
            {
                throw new ArgumentException("The 'progID' argument must not be an empty string.", "progID");
            }
            if (IsNullOrWhiteSpace(openWithCommand))
            {
                throw new ArgumentException("The 'openWithCmd' argument must not be an empty string.", "openWithCmd");
            }
            RegistryKey classesRoot = Registry.ClassesRoot;
            RegistryKey progKey = classesRoot.CreateSubKey(progID);
            if (!IsNullOrWhiteSpace(friendlyName))
            {
                progKey.SetValue(string.Empty, friendlyName);
            }
            if (!IsNullOrWhiteSpace(appID))
            {
                progKey.SetValue("AppUserModelID", appID);
            }
            if (!IsNullOrWhiteSpace(defaultIcon))
            {
                RegistryKey diKey = progKey.CreateSubKey("DefaultIcon");
                diKey.SetValue(string.Empty, defaultIcon);
                diKey.Close();
            }
            RegistryKey shellKey = progKey.CreateSubKey("shell");
            shellKey = shellKey.CreateSubKey("Open");
            shellKey = shellKey.CreateSubKey("Command");
            shellKey.SetValue(string.Empty, openWithCommand);

            shellKey.Close();
            progKey.Close();

            for (int i = 0; i < extensions.Length; i++)
            {
                string ex = extensions[i];
                if (!IsNullOrWhiteSpace(ex))
                {
                    RegistryKey openWithKey = classesRoot.CreateSubKey(ex + @"\OpenWithProgids");
                    openWithKey.SetValue(progID, String.Empty);
                    openWithKey.Close();
                }
            }
        }

        /// <summary>
        /// Unregisters file associations for the application.
        /// </summary>
        /// <param name="progID">Name of the Registry key that is currently associated with the application.</param>
        /// <param name="extensions">The extensions to unregister.</param>
        public static void UnregisterFileAssociations(string progID, params string[] extensions)
        {
            if (IsNullOrWhiteSpace(progID))
            {
                throw new ArgumentException("The 'progID' argument must not be an empty string.", "progID");
            }
            RegistryKey classesRoot = Registry.ClassesRoot;
            for (int i = 0; i < extensions.Length; i++)
            {
                string ex = extensions[i];
                if (!IsNullOrWhiteSpace(ex))
                {
                    RegistryKey openWithKey = classesRoot.CreateSubKey(ex + @"\OpenWithProgids");
                    openWithKey.DeleteValue(progID, false);
                    openWithKey.Close();
                }
            }
            RegistryKey key = classesRoot.OpenSubKey(progID);
            if (key != null)
            {
                classesRoot.DeleteSubKeyTree(progID);
            }
        }

        private static bool IsNullOrWhiteSpace(string s)
        {
            if (s != null)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (!char.IsWhiteSpace(s[i]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
