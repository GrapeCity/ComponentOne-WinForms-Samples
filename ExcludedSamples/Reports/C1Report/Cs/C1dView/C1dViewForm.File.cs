/*
 * This file is part of C1Report's C1dView sample.
 * 
 * This file contains data members and methods supporting file and window operations,
 * and display of the recent reports/documents in the ribbon application menu.
 * 
 * Copyright GrapeCity, Inc.
 */
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

using C1.C1Preview;
using C1.C1Report;
using C1.Win.C1Preview;
using C1.Win.C1Ribbon;
using C1.Win.C1Command;

namespace C1dView
{
    public partial class C1dViewForm
    {
        /// <summary>
        /// The number of fixed ribbon list items at the top of ribbon application menu's right panel
        /// (the actual caption plus the delimiter).
        /// </summary>
        protected const int NFIXED = 2;
        /// <summary>
        /// The number of recent documents to keep in the recent list.
        /// </summary>
        protected const int MAXRECENT = 10;
        /// <summary>
        /// Offset of a newly opened window relative to the current one.
        /// </summary>
        protected readonly Point NEW_WINDOW_OFFSET = new Point(30, 10);

        /// <summary>
        /// Static list of recently opened file/report name pairs.
        /// </summary>
        static protected List<Pair<string, string>> s_recentDocuments = new List<Pair<string, string>>();

        /// <summary>
        /// Gets the list of recent reports/documents.
        /// In each pair, First is the file name, and Second, if not null, is the report name.
        /// </summary>
        static public List<Pair<string, string>> RecentDocuments { get { return s_recentDocuments; } }

        /// <summary>
        /// Subscribes to the ribbon application menu's DropDown event,
        /// so that the recent documents list can be shown.
        /// </summary>
        protected void InitRecentDocuments()
        {
            ramMain.DropDown += (s, e) => AddRecentDocumentsMenuItems();
        }

        /// <summary>
        /// Creates and shows a new instance of <see cref="C1dViewForm"/>, and loads the specifed file into it.
        /// If the file is the name of a report definition file, the report selection dialog is shown.
        /// If the user cancels the dialog, or the file fails to open, the new window is closed.
        /// </summary>
        /// <param name="fileName">File to open, or null.</param>
        /// <returns>The newly created window, or null if no file was loaded.</returns>
        public C1dViewForm FileNew(string fileName)
        {
            var p = this.Location;
            p.Offset(NEW_WINDOW_OFFSET);
            var window = new C1dViewForm();
            window.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            window.Location = p;
            window.Size = this.Size;
            window.Show();
            if (!string.IsNullOrEmpty(fileName))
                window.cmdFileOpen.UserData = new Pair<string, string>(fileName, null);
            window.cmdFileOpen.PerformClick();
            if (window.Document == null)
            {
                window.cmdFileClose.PerformClick();
                return null;
            }
            else
                return window;
        }

        /// <summary>
        /// Loads the specified file into the current window.
        /// If <paramref name="fileName"/> is null or empty, file selection dialog is shown.
        /// If <paramref name="reportName"/> is null or empty, report selection dialog is shown
        /// if the file contains any report definitions.
        /// Updates the recent file list.
        /// </summary>
        /// <param name="fileName">The file name (can be a report definition file, or a C1 document file).</param>
        /// <param name="reportName">The report name (if <paramref name="fileName"/> is a report definition file).</param>
        public void FileOpen(string fileName = null, string reportName = null)
        {
            // get a file name:
            if (string.IsNullOrEmpty(fileName))
            {
                // Prepare file open dialog:
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.CheckFileExists = true;
                // Get the standard filter that handles .c1dx, .c1d, .c1db, .c1mdx extensions,
                // add (at the top) .xml for opening reports:
                ofd.Filter =
                    "C1 Reports and Documents (*.xml;*.c1dx;*.c1d;*.c1db;*.c1mdx)|*.xml;*.c1dx;*.c1d;*.c1db;*.c1mdx" +
                    "|C1 Reports (*.xml)|*.xml" +
                    // Types below are from C1.Win.C1Preview.Strings.PreviewFileActions.C1dFileFilter:
                    "|C1 Documents (*.c1dx;*.c1d;*.c1db;*.c1mdx)|*.c1dx;*.c1d;*.c1db;*.c1mdx" +
                    "|C1 Open XML Documents (*.c1dx)|*.c1dx" +
                    "|C1 Documents (*.c1d)|*.c1d" +
                    "|C1 Binary Documents (*.c1db)|*.c1db" +
                    "|C1 Open XML Multi Documents (*.c1mdx)|*.c1mdx" +
                    "|All Files (*.*)|*.*";
                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                fileName = ofd.FileName;
            }

            // get a report name if any (if the specified/selected file contains no reports,
            // just pass it to the standard preview pane's FileOpen method to handle:
            if (string.IsNullOrEmpty(reportName))
            {
                using (var rsd = new ReportSelectDialog())
                {
                    rsd.FileName = fileName;
                    if (rsd.HasReports)
                    {
                        if (rsd.ShowDialog(this) != DialogResult.OK)
                            return;

                        fileName = rsd.FileName;
                        reportName = rsd.ReportName;
                    }
                }
            }

            // Open the report or document:
            bool ok;

#if C1DVIEW_APP
            var openWindow = s_openWindows.Find((f_) => f_.FileName == fileName && f_.ReportName == reportName);
            if (openWindow != null)
            {
                Action focus = () => openWindow.Activate();
                openWindow.BeginInvoke(focus);
                return;
            }
#endif

            if (!string.IsNullOrEmpty(reportName))
            {
                try
                {
                    var rep = new C1Report();
                    rep.Load(fileName, reportName);
                    this.Document = rep;
                    this.Text = string.Format(WindowTitleFormat, reportName);
                    ok = true;
                }
                catch (Exception ex)
                {
                    // the next line should not be needed starting with C1Report 54625:
                    this.Document = null;
                    // show error (todo: make a dedicated method for error reporting):
                    string err = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                    string msg = string.Format("Cannot open '{1}' (file '{0}')\r\nError:\r\n{2}", fileName, reportName, err);
                    MessageBox.Show(this, msg, WindowTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ok = false;
                }
            }
            else
            {
                // C1PreviewPane.FileOpen shows error messages itself:
                ok = this.PreviewPane.FileOpen(fileName);
                if (ok)
                    this.Text = string.Format(WindowTitleFormat, fileName);
            }
            if (ok)
            {
                this.FileName = fileName;
                this.ReportName = reportName;
                // add the report/document to the recent list:
                AddRecentDocument(fileName, reportName);
            }
            else
                // remove junk:
                RemoveRecentDocument(fileName, reportName);
        }

        /// <summary>
        /// Handles the close command.
        /// If there are currently more than one C1dView windows open, closes the current window.
        /// Otherwise (if the current window is the last one), just closes the loaded report or document, if any.
        /// (This behavior is similar to MS Word and some other products.)
        /// </summary>
        protected void FileClose()
        {
            if (s_openWindows.Count > 1)
                this.Close();
            else
            {
                this.FileName = this.ReportName = null;
                this.Document = null;
                this.Text = WindowTitle;
                RefreshUI();
                this.Invalidate(true);
            }
        }

        /// <summary>
        /// Closes all open windows.
        /// </summary>
        protected void FileExit()
        {
            while (s_openWindows.Count > 0)
                s_openWindows.Last().Close();
        }

        /// <summary>
        /// Handles the file open command.
        /// <para>
        /// The passed C1Command can be used to pass parameters:
        /// If command.UserData is a pair of strings, the pair.First
        /// is considered to be the file name, and pair.Second,
        /// if not null, is considered to be the name of a report in that file.
        /// If report name is specified, that report is loaded from the file.
        /// Otherwise (if no report name given), the file is opened as a
        /// previously saved C1 document or multi-document.
        /// </para>
        /// <para>
        /// If command.UserData is null or not a pair, the method
        /// shows a file open dialog and allows the user to choose a file to open.
        /// </para>
        /// <para>
        /// The opened report or document is added to the recent documents' list.
        /// The window title is updated.
        /// </para>
        /// </summary>
        /// <param name="command">The command that can be used to pass parameters.</param>
        protected void FileOpen(C1Command command)
        {
            // check whether we were called with parameters (from the recent docs list):
            var pair = command.UserData as Pair<string, string>;
            // reset user data for future calls:
            command.UserData = null;
            if (pair != null)
                FileOpen(pair.First, pair.Second);
            else
                FileOpen();
        }

        /// <summary>
        /// Builds the recent documents menu items (buttons) on the ribbon application menu.
        /// Should be called from the ribbon application menu's DropDown event.
        /// </summary>
        protected void AddRecentDocumentsMenuItems()
        {
            // Clear any old items:
            while (ramMain.RightPaneItems.Count > NFIXED)
                ramMain.RightPaneItems.RemoveAt(NFIXED);

            // add all recent docs to the menu:
            foreach (Pair<string, string> pair in RecentDocuments)
            {
                // button for the new item:
                var rbtn = new RibbonButton();
                if (!string.IsNullOrEmpty(pair.Second))
                {
                    rbtn.Text = pair.Second;
                    rbtn.ToolTip = string.Format(
                        "<table><tr><td>Report:</td><td><b>{1}</b></td></tr><tr><td>File:</td><td><b>{0}</b></td></tr></table>",
                        pair.First, pair.Second);
                }
                else
                {
                    rbtn.Text = System.IO.Path.GetFileName(pair.First);
                    rbtn.ToolTip = string.Format(
                        "<table><tr><td>File:</td><td><b>{0}</b></td></tr></table>",
                        pair.First);
                }
                // the list item:
                var rli = new RibbonListItem(rbtn);
                rli.Tag = pair;
                rli.Click += (s, e) =>
                {
                    cmdFileOpen.UserData = ((RibbonListItem)s).Tag;
                    cmdFileOpen.PerformClick();
                    cmdFileOpen.UserData = null; // cleanup
                };
                // done, add the new item:
                ramMain.RightPaneItems.Add(rli);
            }
        }

        /// <summary>
        /// Removes the specified report or document from <see cref="RecentDocuments"/>.
        /// </summary>
        /// <param name="fileName">The document or report file name.</param>
        /// <param name="reportName">The report name.</param>
        protected static void RemoveRecentDocument(string fileName, string reportName)
        {
            // avoid adding duplicates to the recent file list:
            RecentDocuments.RemoveAll((p_) => p_.First == fileName && p_.Second == reportName);
        }

        /// <summary>
        /// Adds the specified report or document to <see cref="RecentDocuments"/>.
        /// </summary>
        /// <param name="fileName">The document or report file name.</param>
        /// <param name="reportName">The report name.</param>
        protected static void AddRecentDocument(string fileName, string reportName)
        {
            // avoid adding duplicates to the recent file list:
            RecentDocuments.RemoveAll((p_) => p_.First == fileName && p_.Second == reportName);

            // Make room for the new item:
            if (RecentDocuments.Count >= MAXRECENT)
                RecentDocuments.RemoveRange(MAXRECENT - 1, RecentDocuments.Count - MAXRECENT + 1);

            // Insert the new item at the top:
            RecentDocuments.Insert(0, new Pair<string, string>(fileName, reportName));
        }
    }
}
