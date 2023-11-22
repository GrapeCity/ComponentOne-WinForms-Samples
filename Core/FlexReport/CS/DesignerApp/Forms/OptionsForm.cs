//----------------------------------------------------------------------------
// OptionsForm.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Reflection;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Linq;

using C1.Win.Localization;
using C1.Win.Themes;

using Flex = C1.Win.FlexReport;
using FlexDesigner = C1.Win.FlexReport;

namespace FlexReportDesignerApp
{
    /// <summary>
    /// Summary description for OptionsForm.
    /// </summary>
    public partial class OptionsForm : System.Windows.Forms.Form
    {
        // ** ctor
        public OptionsForm()
        {
            // initialize component
            InitializeComponent();
            //
            AutoScaleMode = AutoScaleMode.None;
            Font = MainForm.DefaultAppFont;

            if (IntPtr.Size == 4)
                _chkWarn_AppIn64bitMode.Visible = false;

            // Populate static option lists:

            // Grid units:
            this._cmbGridUnits.Items.Clear();
            this._cmbGridUnits.Items.Add(Strings.OptionsForm.UnitsAuto);
            this._cmbGridUnits.Items.Add(Strings.OptionsForm.UnitsEnglish);
            this._cmbGridUnits.Items.Add(Strings.OptionsForm.UnitsMetric);
            this._cmbGridUnits.Items.Add(Strings.OptionsForm.UnitsCustom);
            // Data isolation level:
            _cmbIsolationLevel.Items.Clear();
            IsolationLevel[] values = (IsolationLevel[])Enum.GetValues(typeof(IsolationLevel));
            for (int i = 0; i < values.Length; i++)
                _cmbIsolationLevel.Items.Add(values[i]);
            // Themes:
            _cmbThemeBuiltIn.Items.AddRange(C1ThemeController.GetThemes());
            _cmbThemeCustom.Items.AddRange(C1ThemeLocator.GetAvailableThemes(C1ThemeLocator.LocationType.ThemesFolder).ToArray());
            if (_cmbThemeCustom.Items.Count == 0)
            {
                _cmbThemeCustom.Enabled = false;
                _rbtThemeCustom.Enabled = false;
            }
            //
            _chkReload_CheckedChanged(_chkReload, EventArgs.Empty);
            //
            _btnResetLayout.Enabled = MainForm.TheMainForm.ReportDesignMode;
        }

        #region Event handlers
        private void _btnOK_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        private void _btnCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void _btnFont_Click(object sender, System.EventArgs e)
        {
            using (FontDialog dlg = new FontDialog())
            {
                dlg.Font = _scriptEditorFont;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    ScriptEditorFont = dlg.Font;
                }
            }
        }
        private void _cmbUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            _numSpacing.Enabled = _cmbGridUnits.SelectedIndex == 3; // Custom
        }
        private void _btnDesignerPaneColorsReset_Click(object sender, EventArgs e)
        {
            MainForm.FlexDesigner.Preferences.ResetColors();
            LoadDesignerPanePrefs();
        }
        private void _chkSnapToPadding_CheckedChanged(object sender, EventArgs e)
        {
            _numSnapPaddingX.Enabled = _chkSnapToPadding.Checked;
            _numSnapPaddingY.Enabled = _chkSnapToPadding.Checked;
        }
        private void _chkReload_CheckedChanged(object sender, EventArgs e)
        {
            _chkRestoreEditorSettings.Enabled = _chkReload.Checked;
        }
        private void _btnResetLayout_Click(object sender, EventArgs e)
        {
            MainForm.TheMainForm.ResetDesignerLayout();
        }
        #endregion

        #region Public methods
        public void LoadDesignerPanePrefs()
        {
            var editorPrefs = MainForm.FlexDesigner.Preferences;
            //
            RubberBandBaseColor = editorPrefs.RubberBandColor;
            SelectionBaseColor = editorPrefs.SelectionColor;
            MouseGuidesBaseColor = editorPrefs.MouseSizingGuidesColor;
            BrickBoundsBaseColor = editorPrefs.BrickBoundsColor;
            GridBaseColor = editorPrefs.GridColor;
            RulerBaseColor = editorPrefs.RulerColor;
            ControlBaseColor = editorPrefs.ControlColor;
            CaptionBaseColor = editorPrefs.CaptionColor;
            HighlightBaseColor = editorPrefs.HighlightColor;
            IndicatorBaseColor = editorPrefs.IndicatorColor;
            //
            GridUnits = editorPrefs.GridUnits;
            GridSpacing = editorPrefs.GridCustomSpacing;
            ShowGrid = editorPrefs.GridVisible;
            SnapToGrid = editorPrefs.GridSnap;
            SnapToSides = editorPrefs.SnapToSides;
            SnapToPadding = editorPrefs.SnapToPadding;
            SnapPaddingX = editorPrefs.SnapPaddingX;
            SnapPaddingY = editorPrefs.SnapPaddingY;
            UseInPlaceFixedFont = editorPrefs.UseInPlaceFixedFont;
            IndicatorStripVisibility = editorPrefs.IndicatorStripVisibility;
        }
        public void SaveDesignerPanePrefs()
        {
            var editorPrefs = MainForm.FlexDesigner.Preferences;
            //
            editorPrefs.RubberBandColor = RubberBandBaseColor;
            editorPrefs.SelectionColor = SelectionBaseColor;
            editorPrefs.MouseSizingGuidesColor = MouseGuidesBaseColor;
            editorPrefs.BrickBoundsColor = BrickBoundsBaseColor;
            editorPrefs.GridColor = GridBaseColor;
            editorPrefs.RulerColor = RulerBaseColor;
            editorPrefs.ControlColor = ControlBaseColor;
            editorPrefs.CaptionColor = CaptionBaseColor;
            editorPrefs.HighlightColor = HighlightBaseColor;
            editorPrefs.IndicatorColor = IndicatorBaseColor;
            //
            editorPrefs.GridUnits = GridUnits;
            editorPrefs.GridCustomSpacing = GridSpacing;
            editorPrefs.GridVisible = ShowGrid;
            editorPrefs.GridSnap = SnapToGrid;
            editorPrefs.SnapToSides = SnapToSides;
            editorPrefs.SnapToPadding = SnapToPadding;
            editorPrefs.SnapPaddingX = SnapPaddingX;
            editorPrefs.SnapPaddingY = SnapPaddingY;
            editorPrefs.UseInPlaceFixedFont = UseInPlaceFixedFont;
            if (UseInPlaceFixedFont)
                editorPrefs.InPlaceEditorFont = ScriptEditorFont;
            editorPrefs.IndicatorStripVisibility = IndicatorStripVisibility;
            //
            editorPrefs.Apply();
        }
        #endregion

        #region Public properties
        public MainForm MainForm { get; set; }
        public string StartTabName
        {
            get { return tabControl1.SelectedTab.Name; }
            set
            {
                try
                {
                    tabControl1.SelectedTab = tabControl1.TabPages[value];
                }
                catch
                {
                    tabControl1.SelectedIndex = 0;
                }
            }
        }
        public string Theme
        {
            get
            {
                if (_rbtThemeCustom.Checked)
                    return new C1ThemeLocator(C1ThemeLocator.LocationType.ThemesFolder, _cmbThemeCustom.Text);
                else
                    return new C1ThemeLocator(C1ThemeLocator.LocationType.Builtin, _cmbThemeBuiltIn.Text);
            }
            set
            {
                C1ThemeLocator.LocationType locType;
                string themeName = new C1ThemeLocator(value).GetThemeName(out locType);
                bool custom = locType == C1ThemeLocator.LocationType.ThemesFolder;

                // try to set custom theme
                if (custom)
                {
                    _cmbThemeCustom.SelectedItem = themeName;
                    custom = _cmbThemeCustom.SelectedIndex != -1;
                }
                // set theme for good:
                if (custom)
                {
                    _rbtThemeCustom.Checked = true;
                    _cmbThemeBuiltIn.SelectedIndex = -1;
                }
                else
                {
                    _rbtThemeBuiltIn.Checked = true;
                    _cmbThemeBuiltIn.SelectedItem = themeName;
                    _cmbThemeCustom.SelectedIndex = -1;
                }
            }
        }
        public FlexDesigner.GridUnits GridUnits
        {
            get
            {
                switch (_cmbGridUnits.SelectedIndex)
                {
                    case 0:
                        return FlexDesigner.GridUnits.Auto;
                    case 1:
                        return FlexDesigner.GridUnits.English;
                    case 2:
                        return FlexDesigner.GridUnits.Metric;
                    case 3:
                        return FlexDesigner.GridUnits.Custom;
                    default:
                        return FlexDesigner.GridUnits.Auto;
                }
            }
            set
            {
                if (value == FlexDesigner.GridUnits.Auto)
                    _cmbGridUnits.SelectedIndex = 0;
                else if (value == FlexDesigner.GridUnits.English)
                    _cmbGridUnits.SelectedIndex = 1;
                else if (value == FlexDesigner.GridUnits.Metric)
                    _cmbGridUnits.SelectedIndex = 2;
                else if (value == FlexDesigner.GridUnits.Custom)
                    _cmbGridUnits.SelectedIndex = 3;
            }
        }
        #region Designer control colors
        public Color RubberBandBaseColor
        {
            get { return _cpRubberBandBase.Color; }
            set { _cpRubberBandBase.Color = (Color)value; }
        }
        public Color SelectionBaseColor
        {
            get { return _cpSelectionBase.Color; }
            set { _cpSelectionBase.Color = (Color)value; }
        }
        public Color MouseGuidesBaseColor
        {
            get { return _cpMouseGuidesBase.Color; }
            set { _cpMouseGuidesBase.Color = (Color)value; }
        }
        public Color BrickBoundsBaseColor
        {
            get { return _cpBrickBoundsBase.Color; }
            set { _cpBrickBoundsBase.Color = (Color)value; }
        }
        public Color GridBaseColor
        {
            get { return _cpGridBase.Color; }
            set { _cpGridBase.Color = (Color)value; }
        }
        public Color RulerBaseColor
        {
            get { return _cpRulerBase.Color; }
            set { _cpRulerBase.Color = (Color)value; }
        }
        public Color ControlBaseColor
        {
            get { return _cpControlBase.Color; }
            set { _cpControlBase.Color = (Color)value; }
        }
        public Color CaptionBaseColor
        {
            get { return _cpCaptionBase.Color; }
            set { _cpCaptionBase.Color = (Color)value; }
        }
        public Color IndicatorBaseColor
        {
            get { return _cpIndicatorBase.Color; }
            set { _cpIndicatorBase.Color = (Color)value; }
        }
        public Color HighlightBaseColor
        {
            get { return _cpHighlightBase.Color; }
            set { _cpHighlightBase.Color = (Color)value; }
        }
        #endregion

        #region Grid
        public int GridSpacing
        {
            get { return (int)_numSpacing.Value; }
            set { _numSpacing.Value = value; }
        }
        public bool ShowGrid
        {
            get { return _chkShowGrid.Checked; }
            set { _chkShowGrid.Checked = value; }
        }
        public bool SnapToGrid
        {
            get { return _chkSnapToGrid.Checked; }
            set { _chkSnapToGrid.Checked = value; }
        }
        #endregion

        #region More designer options
        public bool SnapToSides
        {
            get { return _chkSnapToSides.Checked; }
            set { _chkSnapToSides.Checked = value; }
        }
        public bool SnapToPadding
        {
            get { return _chkSnapToPadding.Checked; }
            set { _chkSnapToPadding.Checked = value; }
        }
        public int SnapPaddingX
        {
            get { return (int)_numSnapPaddingX.Value; }
            set { _numSnapPaddingX.Value = value; }
        }
        public int SnapPaddingY
        {
            get { return (int)_numSnapPaddingY.Value; }
            set { _numSnapPaddingY.Value = value; }
        }
        public bool UseInPlaceFixedFont
        {
            get { return _cbUseInPlaceFixedFont.Checked; }
            set { _cbUseInPlaceFixedFont.Checked = value; }
        }
        public C1.Win.FlexReport.FlexDesigner.AutoOnOff IndicatorStripVisibility
        {
            get
            {
                switch (_cbIndicatorShow.CheckState)
                {
                    case CheckState.Checked:
                        return FlexDesigner.FlexDesigner.AutoOnOff.On;
                    case CheckState.Unchecked:
                        return FlexDesigner.FlexDesigner.AutoOnOff.Off;
                    case CheckState.Indeterminate:
                    default: // to satisfy the compiler
                        return FlexDesigner.FlexDesigner.AutoOnOff.Auto;
                }
            }
            set
            {
                switch (value)
                {
                    case FlexDesigner.FlexDesigner.AutoOnOff.Auto:
                        _cbIndicatorShow.CheckState = CheckState.Indeterminate;
                        break;
                    case FlexDesigner.FlexDesigner.AutoOnOff.On:
                        _cbIndicatorShow.CheckState = CheckState.Checked;
                        break;
                    case FlexDesigner.FlexDesigner.AutoOnOff.Off:
                        _cbIndicatorShow.CheckState = CheckState.Unchecked;
                        break;
                }
            }
        }
        #endregion

        public bool LoadOnStartup
        {
            get { return _chkReload.Checked; }
            set { _chkReload.Checked = value; }
        }
        public bool RestoreEditorSettings
        {
            get { return _chkRestoreEditorSettings.Checked; }
            set { _chkRestoreEditorSettings.Checked = value; }
        }
        public bool EmbedImages
        {
            get { return _chkEmbed.Checked; }
            set { _chkEmbed.Checked = value; }
        }
        public bool SortReportList
        {
            get { return _chkSortReportList.Checked; }
            set { _chkSortReportList.Checked = value; }
        }
        public bool AutoSave
        {
            get { return _chkAutoSave.Checked; }
            set { _chkAutoSave.Checked = value; }
        }
        public bool OpenExportedFile
        {
            get { return _chkOpenExportedFile.Checked; }
            set { _chkOpenExportedFile.Checked = value; }
        }
        public bool CategorizeProperties
        {
            get { return _chkCategorize.Checked; }
            set { _chkCategorize.Checked = value; }
        }
        public bool InsertLegacyField
        {
            get { return _chkInsertLegacyField.Checked; }
            set { _chkInsertLegacyField.Checked = value; }
        }
        public bool InsertLegacyChart
        {
            get { return _chkInsertLegacyChart.Checked; }
            set { _chkInsertLegacyChart.Checked = value; }
        }
        public bool FileAssociateFLXR
        {
            get { return _chkFileAssociateFLXR.Checked; }
            set { _chkFileAssociateFLXR.Checked = value; }
        }
        public bool SyntaxCheck
        {
            get { return _chkSyntaxCheck.Checked; }
            set { _chkSyntaxCheck.Checked = value; }
        }
        public bool SyntaxColoring
        {
            get { return _chkSyntaxColoring.Checked; }
            set { _chkSyntaxColoring.Checked = value; }
        }
        public Font ScriptEditorFont
        {
            get { return _scriptEditorFont; }
            set
            {
                if (value != null)
                {
                    _scriptEditorFont = value;
                    _btnFont.Text = string.Format(Strings.OptionsForm.FontFmt, value.Name, Math.Round(value.Size));
                }
            }
        }
        public IsolationLevel IsolationLevel
        {
            get { return (IsolationLevel)_cmbIsolationLevel.SelectedItem; }
            set { _cmbIsolationLevel.SelectedItem = value; }
        }
        public bool WarnImportCrystalRASNotAvailable
        {
            get { return _chkWarn_ImportCrystalRASNotAvailable.Checked; }
            set { _chkWarn_ImportCrystalRASNotAvailable.Checked = value; }
        }
        public bool WarnAppIn64bitMode
        {
            get { return _chkWarn_AppIn64bitMode.Checked; }
            set { _chkWarn_AppIn64bitMode.Checked = value; }
        }
        #endregion

        #region Theme handling
        private void _cmbThemeBuiltIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cmbThemeBuiltIn.SelectedIndex != -1)
            {
                _rbtThemeBuiltIn.Checked = true;
                _cmbThemeCustom.SelectedIndex = -1;
            }
        }
        private void _cmbThemeCustom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cmbThemeCustom.SelectedIndex != -1)
            {
                _rbtThemeCustom.Checked = true;
                _cmbThemeBuiltIn.SelectedIndex = -1;
            }
        }
        private void _btnThemeApply_Click(object sender, EventArgs e)
        {
            if (MainForm != null)
            {
                // NOTE: when switching between "modern" and "visual style" based themes, C1RibbonForm
                // recreates its handle, which leads to MainForm starting to react to mouse input etc
                // while the modal options form is still on. To avoid this, we use HandleCreated event
                // to disable MainForm via EnableWindow - which does not visually disables the controls
                // on it.
                MainForm.HandleCreated += MainForm_HandleCreated;
                MainForm.Theme = this.Theme;
                this.BringToFront();
                MainForm.HandleCreated -= MainForm_HandleCreated;
            }
        }
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        public static extern int EnableWindow(IntPtr hWnd, int bEnable);

        private void MainForm_HandleCreated(object sender, EventArgs e)
        {
            // SetWindowLong(this.Handle, -8, MainForm.Handle);
            EnableWindow(MainForm.Handle, 0);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (!e.Cancel)
                EnableWindow(MainForm.Handle, 1);
        }
        #endregion
    }
}
