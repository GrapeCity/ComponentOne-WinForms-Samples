/*
 * This file is part of C1Report's C1dView sample.
 * 
 * This file contains settings persistence code.
 * 
 * Copyright GrapeCity, Inc.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using C1.C1Preview;
using C1.Win.C1Preview;

namespace C1dView
{
    /// <summary>
    /// Encapsulates preview settings which can be persisted together
    /// as a single Settings.settings variable of type C1dView.C1dViewSettings.
    /// </summary>
    public class C1dViewSettings
    {
        #region Defaults and limits
        public static readonly Size MinMainWindowSize = new Size(200, 200);
        #endregion

        #region Settings
        public Rectangle MainWindowBounds { get; set; }
        public List<Pair<string, string>> RecentDocuments { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Loads the last saved settings into the preview.
        /// </summary>
        /// <param name="previewForm">The preview form.</param>
        public static void Load(C1dViewForm previewForm)
        {
            try
            {
                var settings = Properties.Settings.Default;
                if (settings == null)
                    return;
                if (settings.C1dViewSettings == null)
                {
                    Save(previewForm);
                    return;
                }
                var vs = settings.C1dViewSettings;
                // main window position:
                if (vs.MainWindowBounds.Width >= MinMainWindowSize.Width &&
                    vs.MainWindowBounds.Height >= MinMainWindowSize.Height &&
                    vs.MainWindowBounds.X >= 0 && vs.MainWindowBounds.Y >= 0)
                {
                    previewForm.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                    previewForm.Bounds = vs.MainWindowBounds;
                }
                // recent documents:
                C1dViewForm.RecentDocuments.Clear();
                if (vs.RecentDocuments != null)
                    C1dViewForm.RecentDocuments.AddRange(vs.RecentDocuments);
            }
            catch
            {
                // ignore settings errors, not much to do here.
            }
        }

        /// <summary>
        /// Saves current settings.
        /// </summary>
        /// <param name="previewForm">The preview form.</param>
        public static void Save(C1dViewForm previewForm)
        {
            try
            {
                var settings = Properties.Settings.Default;
                if (settings == null)
                    return;
                if (settings.C1dViewSettings == null)
                    settings.C1dViewSettings = new C1dViewSettings();
                var vs = settings.C1dViewSettings;
                // main window position:
                vs.MainWindowBounds = previewForm.Bounds;
                // recent documents:
                vs.RecentDocuments = new List<Pair<string, string>>();
                vs.RecentDocuments.AddRange(C1dViewForm.RecentDocuments);
                //
                settings.Save();
            }
            catch
            {
                // ignore settings errors, not much to do here.
            }
        }
        #endregion
    }
}
