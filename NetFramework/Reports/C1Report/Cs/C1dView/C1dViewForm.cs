/*
 * This file is part of C1Report's C1dView sample.
 * 
 * This file contains the C1dViewForm class initialization and public properties.
 * 
 * NOTES:
 * 
 * - C1DVIEW_APP conditional compilation symbol indicates that code is build as part
 *   of standalone C1dView application. If that symbol is defined, certain parts of code
 *   are included that are excluded when the code is used as a template in another app.
 *   (For instance settings handling code is used in C1dView but excluded in template.)
 * 
 * Copyright GrapeCity, Inc.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Linq;

using C1.C1Preview;
using C1.Win.C1Preview;
using C1.Win.C1Ribbon;
using C1.Win.C1Command;

namespace C1dView
{
    public partial class C1dViewForm : C1RibbonForm
    {
        /// <summary>
        /// Window caption when no file is loaded.
        /// </summary>
        protected static string WindowTitle { get; private set; }
        /// <summary>
        /// Window caption format showing file/report name.
        /// </summary>
        protected static string WindowTitleFormat { get; private set; }

        /// <summary>
        /// Static list of the currently open C1dViewForm forms.
        /// </summary>
        static protected List<C1dViewForm> s_openWindows = new List<C1dViewForm>();

        static C1dViewForm()
        {
            // we want to show 32/64 bit environment as many data providers depend on it:
            if (IntPtr.Size == 4)
            {
                WindowTitle = "C1dView32";
                WindowTitleFormat = "{0} - C1dView32";
            }
            else if (IntPtr.Size == 8)
            {
                WindowTitle = "C1dView64";
                WindowTitleFormat = "{0} - C1dView64";
            }
            else
            {
                System.Diagnostics.Debug.Assert(false, "We are not in Kansas anymore, Toto");
            }
        }

        public C1dViewForm()
        {
            InitializeComponent();
            //
            // Set up window title:
            this.Text = WindowTitle;
            //
            // Most of preview commands are wired up here:
            InitPreviewCommands();
            //
            // Initialize text find bar and related commands:
            InitFind();
            //
            // Initialize recent files list:
            InitRecentDocuments();
            //
            // Keep track of open C1dViewForm's:
            s_openWindows.Add(this);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Show thumbnails panel initially, focus in preview pane, and ensure consistent UI state:
            dtpPages.Show();
            PreviewPane.Focus();
            RefreshUI();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            s_openWindows.Remove(this);
#if C1DVIEW_APP
            if (s_openWindows.Count == 0)
            {
                C1dViewSettings.Save(this);
                Application.Exit();
            }
#endif
        }

        #region Public properties
        /// <summary>
        /// Gets or sets the document shown by the preview.
        /// This is just a shortcut to PreviewPane.Document.
        /// </summary>
        [Browsable(false)]
        public object Document
        {
            get { return _pview.Document; }
            set { _pview.Document = value; }
        }

        /// <summary>
        /// Gets the C1PreviewPane control.
        /// </summary>
        public C1PreviewPane PreviewPane { get { return _pview; } }

        /// <summary>
        /// Gets the name of the currently loaded file, or null.
        /// </summary>
        public string FileName { get; private set; }

        /// <summary>
        /// Gets the name of the currently loaded report, or null.
        /// </summary>
        public string ReportName { get; private set; }
        #endregion
    }
}
