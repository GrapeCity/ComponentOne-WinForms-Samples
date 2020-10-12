//----------------------------------------------------------------------------
// AppConfig.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Xml;
using System.IO;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

using FlexReportDesignerApp.Util;

using Flex = C1.Win.FlexReport;

namespace FlexReportDesignerApp
{
	/// <summary>
	/// AppConfig
	/// Save, load, and edit user preferences and application state
	/// </summary>
	public class AppConfig
	{
        public const string c_nodePreferences = "preferences";
        public const string c_nodeEditorPreferences = "editorPreferences";
        public const string c_nodeEditorState = "editorState";
        public const string c_nodeEditorTransState = "editorTransState";


		private MainForm _owner;

        #region Constructors
        public AppConfig(MainForm owner)
		{
			_owner = owner;
        }
        #endregion

        #region Public
        public enum StartTab
        {
            Default,
            General,
            DesignPane,
            SaveLoad,
            Connection,
            ScriptEditor,
            Warnings,
        }

        public DialogResult ShowDialog()
        {
            return ShowDialog(string.Empty);
        }

        // show the dialog
        /// <summary>
        /// Shows the options form, initializing it with current values,
        /// and saving any changes when the form closes on OK.
        /// </summary>
        /// <param name="startTabName"></param>
        /// <returns></returns>
        public DialogResult ShowDialog(string startTabName)
        {
            using (OptionsForm dlg = new OptionsForm())
            {
                dlg.MainForm = _owner;

                // get designer
                var designer = _owner.FlexDesigner;
                dlg.Theme = _owner.Theme;
                // Designer options:
                dlg.LoadDesignerPanePrefs();
                //
                bool assoc = FileAssocHelper.IsAssociated();
                dlg.FileAssociateFLXR = assoc;
                //
                dlg.LoadOnStartup = _owner._loadOnStartUp;
                dlg.RestoreEditorSettings = _owner._restoreEditorSettings;
                dlg.EmbedImages = _owner._embedImages;
                dlg.AutoSave = _owner._autoSave;
                dlg.OpenExportedFile = _owner._openExportedFile;
                dlg.CategorizeProperties = _owner.CategorizeProperties;
                dlg.SortReportList = _owner.SortReportList;
                dlg.SyntaxCheck = _owner._syntaxCheck;
                dlg.SyntaxColoring = _owner._syntaxColoring;
                dlg.ScriptEditorFont = _owner._scriptEditorFont;
                dlg.IsolationLevel = _owner._isolationLevel;
                dlg.InsertLegacyField = _owner._insertLegacyField;
                dlg.InsertLegacyChart = _owner._insertLegacyChart;
                // suppressed messages:
                dlg.WarnImportCrystalRASNotAvailable = !MessageForm.GetMessageSuppressed(MessageForm.MessageKey.WarnImportCrystalRASNotAvailable);
                dlg.WarnAppIn64bitMode = !MessageForm.GetMessageSuppressed(MessageForm.MessageKey.WarnAppIn64bitMode);

                // start tab:
                dlg.StartTabName = string.IsNullOrEmpty(startTabName) ? _owner._optionsStartTabName : startTabName;

                // show dialog
                DialogResult dr = dlg.ShowDialog(_owner);
                if (dr != DialogResult.OK)
                    return dr;

                // apply changes to app
                _owner.Theme = dlg.Theme;
                _owner._optionsStartTabName = dlg.StartTabName;
                //
                dlg.SaveDesignerPanePrefs();
                //
                _owner._loadOnStartUp = dlg.LoadOnStartup;
                _owner._restoreEditorSettings = dlg.RestoreEditorSettings;
                _owner._embedImages = dlg.EmbedImages;
                _owner._autoSave = dlg.AutoSave;
                _owner._openExportedFile = dlg.OpenExportedFile;
                _owner.CategorizeProperties = dlg.CategorizeProperties;
                _owner._syntaxCheck = dlg.SyntaxCheck;
                _owner._syntaxColoring = dlg.SyntaxColoring;
                _owner._scriptEditorFont = dlg.ScriptEditorFont;
                _owner.SortReportList = dlg.SortReportList;
                _owner._isolationLevel = dlg.IsolationLevel;
                _owner._insertLegacyField = dlg.InsertLegacyField;
                _owner._insertLegacyChart = dlg.InsertLegacyChart;
                // suppressed messages:
                MessageForm.SetMessageSuppressed(MessageForm.MessageKey.WarnImportCrystalRASNotAvailable, !dlg.WarnImportCrystalRASNotAvailable);
                MessageForm.SetMessageSuppressed(MessageForm.MessageKey.WarnAppIn64bitMode, !dlg.WarnAppIn64bitMode);

                // save changes
                SaveAppState();

                if (dlg.FileAssociateFLXR != assoc)
                {
                    FileAssocHelper.Associate(dlg.FileAssociateFLXR);
                }

                // done
                return dr;
            }
        }

		// save application state into registry
        public bool SaveAppState()
        {
            try
            {
                AppSettings.SaveObject(c_nodePreferences, new UserPreferences(_owner));
                AppSettings.SaveObject(c_nodeEditorPreferences, _owner.FlexDesigner.Preferences);
                AppSettings.SaveObject(c_nodeEditorState, _owner.FlexDesigner.State);
                AppSettings.SaveObject(c_nodeEditorTransState, _owner.FlexDesigner.TransientState);
                return true;
            }
            catch { }
            return false;
        }

		// restore application state from registry
        public bool LoadAppState()
        {
            try
            {
                AppSettings.LoadObject(c_nodePreferences, new UserPreferences(_owner));
                AppSettings.LoadObject(c_nodeEditorPreferences, _owner.FlexDesigner.Preferences);
                _owner.FlexDesigner.Preferences.Apply();
                AppSettings.LoadObject(c_nodeEditorState, _owner.FlexDesigner.State);
            }
            catch { }
            return false;
        }
        #endregion
    }

    internal class FormState
    {
        private Form _owner;

        #region Constructors
        public FormState(Form owner)
        {
            _owner = owner;
        }
        #endregion

        #region Internal properties
        internal Form Owner
        {
            get { return _owner; }
        }
        #endregion

        #region Public properties
        // window state preferences
        [DefaultValue(FormWindowState.Normal)]
        public FormWindowState WindowState
        {
            get { return _owner.WindowState; }
            set { _owner.WindowState = value; }
        }

        [DefaultValue(typeof(Rectangle), "0,0,0,0")]
        public Rectangle WindowPosition
        {
            get
            {
                return (_owner.WindowState == FormWindowState.Normal)
                    ? _owner.Bounds
                    : Rectangle.Empty;
            }
            set
            {
                if (_owner.WindowState == FormWindowState.Normal && value.Width > 0 && value.Height > 0)
                    _owner.Bounds = value;
            }
        }
        #endregion
    }

    /// <summary>
	/// For internal use.
	/// </summary>
	internal class UserPreferences
	{
		private MainForm _owner;
        private Flex.C1FlexReportDesigner _designer;

        #region Constructors
        internal UserPreferences(MainForm owner)
		{
			_owner = owner;
            _designer = owner.FlexDesigner;
        }
        #endregion

        #region Public properties
        [DefaultValue("")]
        public string DefaultStyleName
        {
            get { return _owner._defaultStyleName; }
            set { _owner._defaultStyleName = value; }
        }

        [DefaultValue("")]
        public string OptionsStartTabName
        {
            get { return _owner._optionsStartTabName; }
            set { _owner._optionsStartTabName = value; }
        }

		// main preferences
        [DefaultValue(true)]
		public bool LoadOnStartUp
		{
			get { return _owner._loadOnStartUp; }
			set { _owner._loadOnStartUp = value; }
		}

        [DefaultValue(true)]
        public bool RestoreEditorSettings
		{
			get { return _owner._restoreEditorSettings; }
            set { _owner._restoreEditorSettings = value; }
		}

		
        [DefaultValue(true)]
		public bool EmbedImages
		{
			get { return _owner._embedImages; }
			set { _owner._embedImages = value; }
		}
		
        [DefaultValue(false)]
		public bool AutoSave
		{
			get { return _owner._autoSave; }
			set { _owner._autoSave = value; }
		}

        [DefaultValue(true)]
        public bool OpenExportedFile
        {
            get { return _owner._openExportedFile; }
            set { _owner._openExportedFile = value; }
        }

        [DefaultValue(false)]
        public bool InsertLegacyField
        {
            get { return _owner._insertLegacyField; }
            set { _owner._insertLegacyField = value; }
        }

        [DefaultValue(false)]
        public bool InsertLegacyChart
        {
            get { return _owner._insertLegacyChart; }
            set { _owner._insertLegacyChart = value; }
        }

        [DefaultValue(true)]
		public bool CategorizeProperties
		{
			get { return _owner.CategorizeProperties; }
			set { _owner.CategorizeProperties = value; }
		}
		
        [DefaultValue(false)]
		public bool UseFieldWrappers
		{
			get { return _owner.UseFieldWrappers; }
			set { _owner.UseFieldWrappers = value; }
		}

		// window state preferences
        [DefaultValue("")]
        public string Theme
        {
            get { return _owner.Theme; }
            set { _owner.Theme = value; }
        }
        
        [DefaultValue(FormWindowState.Normal)]
		public FormWindowState WindowState
		{
			get { return _owner.WindowState; }
			set { _owner.WindowState = value; }
		}
		
        [DefaultValue(typeof(Rectangle), "0,0,0,0")]
		public Rectangle WindowPosition
		{
			get 
			{
				return (_owner.WindowState == FormWindowState.Normal)
					? _owner.Bounds
					: Rectangle.Empty;
			}
			set 
			{
				if (_owner.WindowState == FormWindowState.Normal && value.Width > 0 && value.Height > 0)
					_owner.Bounds = value;
			}
		}

		// script editor preferences
		[DefaultValue(true)]
		public bool AutoSyntaxCheck
		{
			get { return _owner._syntaxCheck; }
			set { _owner._syntaxCheck = value; }
		}
		
        [DefaultValue(true)]
		public bool SyntaxColoring
		{
			get { return _owner._syntaxColoring; }
			set { _owner._syntaxColoring = value; }
		}
		
        [DefaultValue(typeof(Font), "Courier New, 9pt")]
		public Font ScriptEditorFont
		{
			get { return _owner._scriptEditorFont; }
			set { _owner._scriptEditorFont = value; }
        }

        [DefaultValue(typeof(Color), "White")]
        public Color ScriptEditorBackColor
        {
            get { return _owner._scriptEditorBackColor; }
            set { _owner._scriptEditorBackColor = value; }
        }

        [DefaultValue(typeof(Color), "Black")]
        public Color ScriptEditorForeColor
        {
            get { return _owner._scriptEditorForeColor; }
            set { _owner._scriptEditorForeColor = value; }
        }

        [DefaultValue(false)]
        public bool ScriptEditorAutoSave
        {
            get { return _owner._scriptEditorAutoSave; }
            set { _owner._scriptEditorAutoSave = value; }
        }

        [DefaultValue(false)]
        public bool ScriptEditorDataSourceFilterWarning
        {
            get { return _owner._scriptEditorDataSourceFilterWarning; }
            set { _owner._scriptEditorDataSourceFilterWarning = value; }
        }

        [DefaultValue(0)]
        public int ScriptEditorSplitWindowDistance
        {
            get { return _owner._scriptEditorSplitWindowDistance; }
            set { _owner._scriptEditorSplitWindowDistance = value; }
        }

        [DefaultValue("")]
        public string ScriptEditorLastItemKey0
        {
            get { return _owner._scriptEditorLastItemKey0; }
            set { _owner._scriptEditorLastItemKey0 = value; }
        }

        [DefaultValue("")]
        public string ScriptEditorLastItemKey1
        {
            get { return _owner._scriptEditorLastItemKey1; }
            set { _owner._scriptEditorLastItemKey1 = value; }
        }

        public string DockPanelsState
        {
            get
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    C1.Win.C1Command.C1DockingTab.SaveLayout(_owner, ms);
                    return System.Convert.ToBase64String(ms.ToArray());
                }
            }
            set
            {
                // In 2016v1, Error List window was added to the designer.
                // To make sure it gets shown, we ignore older configs.
                int major, minor, build, rev;
                AppSettings.GetSettingsVersion(out major, out minor, out build, out rev);
                if (build >= 20161 && rev >= 134)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        byte[] data = System.Convert.FromBase64String(value);
                        ms.Write(data, 0, data.Length);
                        ms.Seek(0, SeekOrigin.Begin);
                        C1.Win.C1Command.C1DockingTab.RestoreLayout(_owner, ms);
                    }
                }
            }
        }

        public bool QatBelowRibbon
        {
            get { return _owner.Ribbon.Qat.BelowRibbon; }
            set { _owner.Ribbon.Qat.BelowRibbon = value; }
        }

        public string QatItems
        {
            get { return _owner.Ribbon.QatItemIDs; }
            set { _owner.Ribbon.QatItemIDs = value; }
        }

        [DefaultValue(C1.Win.FlexReport.DataSource.c_DefIsolationLevel)]
        public IsolationLevel IsolationLevel
        {
            get { return _owner._isolationLevel; }
            set { _owner._isolationLevel = value; }
        }

        [DefaultValue(true)]
        public bool UseCreationGraphicsToRenderFields
        {
            get ;set;
        }

        [DefaultValue(false)]
        public bool FieldsLocked
        {
            get { return _designer.Locked; }
            set { _designer.Locked = value; }
        }

        public string ErrorListSettings
        {
            get { return _owner.ErrorListSettings; }
            set { _owner.ErrorListSettings = value; }
        }
        #endregion
    }
}
