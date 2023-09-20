//----------------------------------------------------------------------------
// BackgroundEditorControl.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using C1.Win.C1Command;
using C1.Win.C1Document;
using C1.Win.Localization;
using C1.Win.C1Themes;

namespace FlexReportDesignerApp.Controls.Background.BackgroundEditor
{
    internal partial class BackgroundEditorControl : BaseUserControl
    {
        private ColorListBox _webColorsEditor;
        private ColorListBox _systemColorsEditor;
        private CustomColorEditor _customColorEditor;
        private GradientBackgroundEditor _gradientEditor;

        private C1Brush _background;
        private readonly IWindowsFormsEditorService _edSvc;

        #region Constructors
        public BackgroundEditorControl()
        {
            InitializeComponent();
            C1ThemeController.ApplyThemeToControlTree(this, MainForm.TheMainForm.CachedTheme);
        }

        public BackgroundEditorControl(IWindowsFormsEditorService edSvc)
            : this()
        {
            _edSvc = edSvc;
        }
        #endregion

        #region Private
        private void EnsureEditorAdded(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0:
                    if (dtpWebColors.Controls.IndexOf(_webColorsEditor) < 0)
                    {
                        dtpWebColors.Controls.Add(_webColorsEditor);
                        C1ThemeController.ApplyThemeToControlTree(_webColorsEditor, MainForm.TheMainForm.CachedTheme);
                    }
                    break;
                case 1:
                    if (dtpSystemColors.Controls.IndexOf(_systemColorsEditor) < 0)
                    {
                        dtpSystemColors.Controls.Add(_systemColorsEditor);
                        C1ThemeController.ApplyThemeToControlTree(_systemColorsEditor, MainForm.TheMainForm.CachedTheme);
                    }
                    break;
                case 2:
                    if (dtpCustom.Controls.IndexOf(_customColorEditor) < 0)
                    {
                        dtpCustom.Controls.Add(_customColorEditor);
                        C1ThemeController.ApplyThemeToControlTree(_customColorEditor, MainForm.TheMainForm.CachedTheme);
                    }
                    break;
                case 3:
                    if (dtpGradient.Controls.IndexOf(_gradientEditor) < 0)
                    {
                        dtpGradient.Controls.Add(_gradientEditor);
                        C1ThemeController.ApplyThemeToControlTree(_gradientEditor, MainForm.TheMainForm.CachedTheme);
                    }
                    break;
            }
        }

        private void CloseDropDown()
        {
            if (_edSvc != null)
                _edSvc.CloseDropDown();
        }

        private C1SolidBrush ConvertToSolidBrush(C1Brush brush)
        {
            if (brush == null) return new C1SolidBrush();

            var solidBrush = brush as C1SolidBrush;
            if (solidBrush != null) return solidBrush;

            var gradientBrush = brush as C1GradientBrush;
            if (gradientBrush != null)
            {
                return new C1SolidBrush(gradientBrush.Color1);
            }

            return new C1SolidBrush();
        }
        #endregion

        #region Public
        /// <summary>
        /// Initializes a control, should be called before using the control.
        /// </summary>
        /// <param name="background">The initial value to edit.</param>
        /// <param name="allowGradient">Indicates whether the gradient brush editor is visible.</param>
        /// <param name="allowEmpty">Indicates whether the solid brush with Color.Empty can be specified, this value showed as "Auto" in editor.</param>
        /// <param name="emptyAlias">The text for Color.Empty color, typically it is displayed as "Auto".</param>
        public void Init(C1Brush background, bool allowGradient, bool allowEmpty, string emptyAlias)
        {
            _background = background ?? new C1SolidBrush();
            Color solidColor = ConvertToSolidBrush(_background).Color;
            
            //
            BeginUpdate();

            // initialize editors
            _webColorsEditor = new ColorListBox
            {
                BorderStyle = BorderStyle.None,
                Dock = DockStyle.Fill,
                FormattingEnabled = true,
                Name = "clbWebColors",
                TabIndex = 0,
                ShowColors = ShowColors.Web,
                ShowEmpty = allowEmpty,
                EmptyColorAlias = emptyAlias,
            };
            _webColorsEditor.SelectedIndexChanged += WebColorsEditor_SelectedIndexChanged;
            _webColorsEditor.MouseUp += WebColorsEditor_MouseUp;

            _systemColorsEditor = new ColorListBox
            {
                BorderStyle = BorderStyle.None,
                Dock = DockStyle.Fill,
                FormattingEnabled = true,
                Name = "clbSystemColors",
                TabIndex = 0,
                ShowColors = ShowColors.SystemColors,
                ShowEmpty = allowEmpty,
                EmptyColorAlias = emptyAlias,
            };
            _systemColorsEditor.SelectedIndexChanged += SystemColorsEditor_SelectedIndexChanged;
            _systemColorsEditor.MouseUp += SystemColorsEditor_MouseUp;

            _customColorEditor = new CustomColorEditor
            {
                Dock = DockStyle.Fill,
                Name = "customColorEditor1",
                TabIndex = 0,
                AllowColorPicker = true,
                ShowEmpty = allowEmpty,
                EmptyColorAlias = emptyAlias,
            };
            _customColorEditor.ColorSelected += CustomColorEditor_ColorSelected;
            _customColorEditor.ColorChanged += CustomColorEditor_ColorChanged;

            _webColorsEditor.SelectedColor = solidColor;
            _systemColorsEditor.SelectedColor = solidColor;
            _customColorEditor.OldValue = solidColor;
            _customColorEditor.Value = solidColor;

            //
            dtpGradient.TabVisible = allowGradient;
            if (!allowGradient)
            {
                if (!(_background is C1SolidBrush))
                {
                    _background = new C1SolidBrush(solidColor);
                }
            }
            else
            {
                _gradientEditor = new GradientBackgroundEditor
                {
                    Dock = DockStyle.Fill,
                    Name = "gbeEditor",
                    TabIndex = 0
                };
                _gradientEditor.BackgroundSelected += GradientEditor_BackgroundSelected;
                _gradientEditor.Changed += GradientEditor_Changed;
                _gradientEditor.Init(_background);
            }

            //
            if (_background is C1SolidBrush)
            {
                if (_systemColorsEditor.SelectedIndex >= 0)
                {
                    dtMain.SelectedTab = dtpSystemColors;
                }
                else if (_webColorsEditor.SelectedIndex >= 0)
                {
                    dtMain.SelectedTab = dtpWebColors;
                }
                else
                {
                    dtMain.SelectedTab = dtpCustom;
                }
            }
            else
            {
                dtMain.SelectedTab = dtpGradient;
            }

            //
            EnsureEditorAdded(dtMain.SelectedIndex);
            dtMain.SelectedIndexChanging += (s, e) => EnsureEditorAdded(e.NewIndex);

            //
            EndUpdate();
        }
        #endregion

        #region Public properties
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public C1Brush Background
        {
            get { return _background; }
        }
        #endregion

        private void WebColorsEditor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;
            _background = new C1SolidBrush(_webColorsEditor.SelectedColor);
        }

        private void SystemColorsEditor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;
            _background =  new C1SolidBrush(_systemColorsEditor.SelectedColor);
        }

        private void CustomColorEditor_ColorChanged(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;
            _background = new C1SolidBrush(_customColorEditor.Value);
        }

        private void WebColorsEditor_MouseUp(object sender, MouseEventArgs e)
        {
            CloseDropDown();
        }

        private void SystemColorsEditor_MouseUp(object sender, MouseEventArgs e)
        {
            CloseDropDown();
        }

        private void CustomColorEditor_ColorSelected(object sender, EventArgs e)
        {
            CloseDropDown();
        }

        private void GradientEditor_BackgroundSelected(object sender, EventArgs e)
        {
            _background = _gradientEditor.Background;
            CloseDropDown();
        }

        private void GradientEditor_Changed(object sender, EventArgs e)
        {
            _background = _gradientEditor.Background;
        }
    }
}
