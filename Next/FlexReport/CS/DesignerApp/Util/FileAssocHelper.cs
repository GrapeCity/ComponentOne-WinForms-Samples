//----------------------------------------------------------------------------
// FileAssocHelper.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace FlexReportDesignerApp
{
    internal static class FileAssocHelper
    {
        // NOTE: using Registry.ClassesRoot requires admin rights, but HKCU\Software\Classes seems to work just as well:
        // RegistryKey classesRoot = Registry.ClassesRoot;
        // thanks to: http://stackoverflow.com/questions/9705188/programmatically-add-file-association-without-admin-rights-in-c-sharp

        private const string appID = "C1FlexReportDesigner";
        private const string progID = "C1FlexReportDesignerApp";
        private const string ext1 = ".flxr";
        private const string friendlyName = "ComponentOne FlexReport Definition";

        public static bool IsAssociated()
        {
            try
            {
                return CheckFileAssociations(progID, ext1);
            }
            catch
            {
                return false;
            }
        }

        public static void Associate(bool on)
        {
            try
            {
                if (on)
                {
                    string defaultIcon = Application.ExecutablePath;
                    string openWithCommand = OpenWithCommand();
                    RegisterFileAssociations(progID, appID, friendlyName, defaultIcon, openWithCommand, ext1);
                }
                else
                {
                    UnregisterFileAssociations(progID, ext1);
                }
            }
            catch (Exception e)
            {
                MessageForm.Error(string.Format(Strings.AppSettings.ErrorSettingFileAssocFmt, e.Message));
            }
        }

        private static string OpenWithCommand()
        {
            return string.Format("\"{0}\" \"%1\"", Application.ExecutablePath);
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
        private static void RegisterFileAssociations(string progID, string appID, string friendlyName,
            string defaultIcon, string openWithCommand, params string[] extensions)
        {
            if (string.IsNullOrWhiteSpace(progID))
                throw new ArgumentException("The 'progID' argument must not be an empty string.", "progID");
            if (string.IsNullOrWhiteSpace(openWithCommand))
                throw new ArgumentException("The 'openWithCommand' argument must not be an empty string.", "openWithCmd");

            RegistryKey userRoot = Registry.CurrentUser;
            RegistryKey classesRoot = userRoot.OpenSubKey("Software\\Classes", true);

            RegistryKey progKey = classesRoot.CreateSubKey(progID);
            if (!string.IsNullOrWhiteSpace(friendlyName))
            {
                progKey.SetValue(string.Empty, friendlyName);
            }
            if (!string.IsNullOrWhiteSpace(appID))
            {
                progKey.SetValue("AppUserModelID", appID);
            }
            if (!string.IsNullOrWhiteSpace(defaultIcon))
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
                if (!string.IsNullOrWhiteSpace(ex))
                {
                    RegistryKey openWithKey = classesRoot.CreateSubKey(ex + @"\OpenWithProgids");
                    openWithKey.SetValue(progID, String.Empty);
                    openWithKey.Close();
                }
            }
            classesRoot.Close();
        }

        /// <summary>
        /// Unregisters file associations for the application.
        /// </summary>
        /// <param name="progID">Name of the Registry key that is currently associated with the application.</param>
        /// <param name="extensions">The extensions to unregister.</param>
        private static void UnregisterFileAssociations(string progID, params string[] extensions)
        {
            if (string.IsNullOrWhiteSpace(progID))
                throw new ArgumentException("The 'progID' argument must not be an empty string.", "progID");
            RegistryKey userRoot = Registry.CurrentUser;
            RegistryKey classesRoot = userRoot.OpenSubKey("Software\\Classes", true);
            for (int i = 0; i < extensions.Length; i++)
            {
                string ex = extensions[i];
                if (!string.IsNullOrWhiteSpace(ex))
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
            classesRoot.Close();
        }

        private static bool CheckFileAssociations(string progID, params string[] extensions)
        {
            if (string.IsNullOrWhiteSpace(progID))
                throw new ArgumentException("The 'progID' argument must not be an empty string.", "progID");
            RegistryKey userRoot = Registry.CurrentUser;
            RegistryKey classesRoot = userRoot.OpenSubKey("Software\\Classes");
            for (int i = 0; i < extensions.Length; i++)
            {
                string ex = extensions[i];
                if (!string.IsNullOrWhiteSpace(ex))
                {
                    string value = null;
                    RegistryKey openWithKey = Registry.ClassesRoot.OpenSubKey(ex + @"\OpenWithProgids");
                    if (openWithKey != null)
                    {
                        value = openWithKey.GetValue(progID, null) as string;
                        openWithKey.Close();
                    }
                    if (value == null)
                    {
                        classesRoot.Close();
                        return false;
                    }
                }
            }
            // make sure that it's us who is registered:
            RegistryKey progKey = classesRoot.OpenSubKey(progID);
            RegistryKey shellKey = progKey.OpenSubKey(@"shell\Open\Command");
            string openCommand = shellKey.GetValue(string.Empty) as string;
            bool ret;
            if (openCommand == null || !openCommand.Equals(OpenWithCommand(), StringComparison.Ordinal))
                ret = false;
            else
                ret = true;

            shellKey.Close();
            progKey.Close();
            classesRoot.Close();
            return ret;
        }
    }
}
