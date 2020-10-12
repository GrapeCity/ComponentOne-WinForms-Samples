using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace C1ReportsScheduler
{
    internal static class WinUtil
    {
        /// <summary>
        /// Used as the parent for modal dialogs.
        /// </summary>
        public static Form MainForm = null;
        /// <summary>
        /// Used to suppress showing error dialog (e.g. when disconnecting after an error).
        /// </summary>
        public static bool SuppressErrorDialog = false;

        public const string ServiceExeName = "C1ReportsSchedulerService.exe";

        public static string FindServiceExe()
        {
            string exePath = Path.GetFullPath(Path.GetDirectoryName(Application.ExecutablePath));
            string srvPath = Path.Combine(exePath, ServiceExeName);
            if (File.Exists(srvPath))
                return srvPath;
#if DEBUG
            srvPath = Path.Combine(exePath, @"..\..\..\C1ReportsSchedulerService\bin\Debug");
            srvPath = Path.Combine(srvPath, ServiceExeName);
            if (File.Exists(srvPath))
                return srvPath;
#endif
            string question = string.Format("Could not find the service executable ({0}).\r\nDo you want to specify its location manually?",
                ServiceExeName);
            if (AskQuestion(question, false))
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = string.Format("{0} executable|{1}|Executable files|*.exe|All files|*.*",
                        C1ReportsSchedulerService.Constants.Name, ServiceExeName);
                    ofd.CheckFileExists = ofd.CheckPathExists = true;
                    ofd.Title = "Please select the service executable.";
                    if (ofd.ShowDialog(MainForm) == DialogResult.OK)
                        return ofd.FileName;
                }
            }
            return null;
        }

        public static void PaintFileNameCell(DataGridViewCellPaintingEventArgs e)
        {
            if ((e.State & DataGridViewElementStates.Selected) != 0)
                return;

            string fname = e.Value as string;
            if (fname == null)
                return;

            e.PaintBackground(e.ClipBounds, false);
            Rectangle rect = e.CellBounds;
            rect.Height -= 2; // this is a "heuristic" to get the text in the same position as standard paint
            TextFormatFlags tff = TextFormatFlags.Default | TextFormatFlags.VerticalCenter | TextFormatFlags.PathEllipsis;
            TextRenderer.DrawText(e.Graphics, fname, e.CellStyle.Font, rect, e.CellStyle.ForeColor, tff);
            e.Handled = true;
        }

        private delegate DialogResult ShowMessageDelegate(IWin32Window owner, string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon);

        public static void ShowError(string message)
        {
            if (SuppressErrorDialog)
                return;

            const string caption = "C1ReportsScheduler Error";
            const MessageBoxButtons buttons = MessageBoxButtons.OK;
            const MessageBoxIcon icon = MessageBoxIcon.Error;

            if (MainForm.InvokeRequired)
                MainForm.BeginInvoke(new ShowMessageDelegate(MessageBox.Show), new object[] { MainForm, message, caption, buttons, icon });
            else
                MessageBox.Show(MainForm, message, caption, buttons, icon);
        }

        public static void ShowWarning(string message)
        {
            const string caption = "C1ReportsScheduler Warning";
            const MessageBoxButtons buttons = MessageBoxButtons.OK;
            const MessageBoxIcon icon = MessageBoxIcon.Warning;

            if (MainForm.InvokeRequired)
                MainForm.BeginInvoke(new ShowMessageDelegate(MessageBox.Show), new object[] { MainForm, message, caption, buttons, icon });
            else
                MessageBox.Show(MainForm, message, caption, buttons, icon);
        }

        public static void ShowErrorClientDisconnected()
        {
            ShowError("Disconnected from service unexpectedly.");
        }

        public static bool AskQuestion(string question, bool allowCancel)
        {
            MessageBoxButtons btns = allowCancel ? MessageBoxButtons.YesNoCancel : MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show(MainForm, question, "C1Reports Scheduler", btns, MessageBoxIcon.Question);
            return dr == DialogResult.Yes;
        }
    }
}
