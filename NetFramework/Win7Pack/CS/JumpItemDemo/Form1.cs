using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Win7Pack;

namespace JumpItemDemo
{
    public partial class Form1 : Form
    {
        private string _exePath;
        private string _destinationPrefix;

        private ArrayList _jumpPathFiles;
        private ArrayList _jumpLinkFiles;

        public Form1()
        {
            InitializeComponent();

            ArrayList list = new ArrayList();
            list.Add("Athens.txt");
            list.Add("Berlin.txt");
            list.Add("London.txt");
            list.Add("Rome.txt");
            _jumpPathFiles = list;

            list = new ArrayList();
            list.Add("computer.ico");
            list.Add("globe.ico");
            list.Add("messages.ico");
            list.Add("performance.ico");
            list.Add("users.ico");
            _jumpLinkFiles = list;

            string s = Application.ExecutablePath;
            int n = s.LastIndexOf('\\');
            n = s.LastIndexOf('\\', n - 1);
            n = s.LastIndexOf('\\', n - 1);
            _destinationPrefix = s.Substring(0, n + 1) + @"Destinations\";
            _exePath = s;
        }

        private bool CheckFileRegistration()
        {
            if (!registrationDialog.CheckBoxChecked)
            {
                if (!taskbarButton.CheckFileAssociations(".txt"))
                {
                    registrationDialog.Show();
                    if (registrationDialog.DialogResult == TaskDialogResult.Cancel)
                    {
                        return false;
                    }
                    if (registrationDialog.DialogResult == TaskDialogResult.Custom &&
                        registrationDialog.ClickedCustomButton.Name == "registerButton")
                    {
                        Register();
                    }
                }
            }
            return true;
        }

        private bool Register()
        {
            //---------------------------------------------------------------
            // ### requires level="requireAdministrator" in app.manifest ###
            //
            //taskbarButton.RegisterFileAssociations(
            //    "Text Document",
            //    @"%systemroot%\system32\shell32.dll,284",
            //    string.Format("\"{0}\" \"%1\"", _exePath),
            //    ".txt");
            //---------------------------------------------------------------

            //---------------------------------------------------------------
            // ### does not require elevated privileges for the main app ###

            return InternalRegister(false, _exePath);

            //---------------------------------------------------------------
        }

        private void Unregister()
        {
            //---------------------------------------------------------------
            // ### requires level="requireAdministrator" in app.manifest ###
            //
            //taskbarButton.UnregisterFileAssociations(".txt");
            //---------------------------------------------------------------

            //---------------------------------------------------------------
            // ### does not require elevated privileges for the main app ###

            InternalRegister(true, null);

            //---------------------------------------------------------------
        }

        private static bool InternalRegister(bool unregister, string fullPathToExe)
        {
            ProcessStartInfo psi = new ProcessStartInfo("RegistrationHelper.exe");
            if (!unregister)
                psi.Arguments = string.Format("False \"{0}\"", fullPathToExe);
            else
                psi.Arguments = "True";
            psi.UseShellExecute = true;
            psi.Verb = "runas";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            bool result = false;
            try
            {
                Process.Start(psi).WaitForExit();
                result = true;
            }
            catch (Win32Exception)
            {
            }
            return result;
        }

        private string JumpItemToString(C1JumpItem item)
        {
            string result = string.Empty;
            if (item is C1JumpLink)
                result = ((C1JumpLink)item).Title;
            else if (item is C1JumpPath)
                result = Path.GetFileName(((C1JumpPath)item).Path);
            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboKnownCategory.SelectedIndex = 0;
            comboGetKnown.SelectedIndex = 0;
        }

        private void comboKnownCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            taskbarButton.JumpList.KnownCategory = (JumpListKnownCategory)comboKnownCategory.SelectedIndex;
        }

        private void rbKnownBeforeCustom_Click(object sender, EventArgs e)
        {
            taskbarButton.JumpList.KnownCategoryPosition = KnownCategoryPosition.BeforeCustomCategories;
        }

        private void rbKnownAfterCustom_Click(object sender, EventArgs e)
        {
            taskbarButton.JumpList.KnownCategoryPosition = KnownCategoryPosition.AfterCustomCategories;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register();
        }

        private void btnUnregister_Click(object sender, EventArgs e)
        {
            Unregister();
        }

        private void btnAddJumpPath_Click(object sender, EventArgs e)
        {
            string categoryName = "JumpPath Category";
            JumpItemCollection items = taskbarButton.JumpList.Items;
            foreach (string s in _jumpPathFiles)
            {
                C1JumpPath jumpPath = new C1JumpPath();
                jumpPath.CustomCategory = categoryName;
                jumpPath.Path = _destinationPrefix + s;
                items.Add(jumpPath);
            }
            btnAddJumpPath.Enabled = false;
        }

        private void btnAddJumpLink_Click(object sender, EventArgs e)
        {
            string categoryName = "JumpLink Category";
            JumpItemCollection items = taskbarButton.JumpList.Items;
            foreach (string s in _jumpLinkFiles)
            {
                C1JumpLink link = new C1JumpLink();
                link.CustomCategory = categoryName;
                link.ApplicationPath = _exePath;
                link.Arguments = _destinationPrefix + s;
                link.IconPath = link.Arguments;
                link.Title = s;
                link.Tooltip = link.Arguments;
                items.Add(link);
            }
            btnAddJumpLink.Enabled = false;
        }

        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            rejectedListBox.Items.Clear();
            removedListBox.Items.Clear();
            taskbarButton.JumpList.Apply();
        }

        private void taskbarButton_ApplyingJumpListChanges(object sender, CancelEventArgs e)
        {
            bool foundShellItem = false;
            foreach (C1JumpItem item in taskbarButton.JumpList.Items)
            {
                if (item is C1JumpPath)
                {
                    foundShellItem = true;
                    break;
                }
            }
            if (foundShellItem && !CheckFileRegistration())
            {
                e.Cancel = true;
            }
        }

        private void btnClearCustom_Click(object sender, EventArgs e)
        {
            C1JumpList jumpList = taskbarButton.JumpList;
            jumpList.Items.Clear();
            jumpList.ClearTasksAndCustomCategories();
            rejectedListBox.Items.Clear();
            removedListBox.Items.Clear();
            btnAddJumpPath.Enabled = true;
            btnAddJumpLink.Enabled = true;
        }

        private void btnClearKnown_Click(object sender, EventArgs e)
        {
            C1JumpList jumpList = taskbarButton.JumpList;
            jumpList.ClearKnownCategories();
            knownListBox.Items.Clear();
        }

        private void taskbarButton_JumpItemsRejected(object sender, JumpItemsRejectedEventArgs e)
        {
            rejectedListBox.BeginUpdate();
            rejectedListBox.Items.Clear();
            for (int i = 0; i < e.RejectedItems.Count; i++)
            {
                rejectedListBox.Items.Add(string.Format("{0}: {1}",
                    e.RejectionReasons[i], JumpItemToString(e.RejectedItems[i])));
            }
            rejectedListBox.EndUpdate();
        }

        private void taskbarButton_JumpItemsRemovedByUser(object sender, JumpItemsRemovedEventArgs e)
        {
            removedListBox.BeginUpdate();
            removedListBox.Items.Clear();
            foreach (C1JumpItem item in e.RemovedItems)
            {
                removedListBox.Items.Add(JumpItemToString(item));
            }
            removedListBox.EndUpdate();
        }

        private void btnGetKnown_Click(object sender, EventArgs e)
        {
            JumpListKnownCategory category = (JumpListKnownCategory)(comboGetKnown.SelectedIndex + 1);
            knownListBox.BeginUpdate();
            knownListBox.Items.Clear();
            IList<C1JumpItem> list = taskbarButton.JumpList.GetKnownCategoryItems(category);
            foreach (C1JumpItem item in list)
            {
                knownListBox.Items.Add(JumpItemToString(item));
            }
            knownListBox.EndUpdate();
        }
    }
}
