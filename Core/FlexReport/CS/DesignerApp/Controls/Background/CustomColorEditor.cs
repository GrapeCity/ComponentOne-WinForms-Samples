//----------------------------------------------------------------------------
// CustomColorEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.Input;
using C1.Win.Input.Validation;

namespace FlexReportDesignerApp.Controls.Background
{
    internal partial class CustomColorEditor : BaseUserControl
    {
        private const bool c_DefAllowTransparent = true;
        private const bool c_DefAllowColorPicker = false;
        private bool _allowTransparent = c_DefAllowTransparent;
        private bool _allColorPicker = c_DefAllowColorPicker;
        private Color _value;
        private Color _oldValue;

        public CustomColorEditor()
        {
            InitializeComponent();

            neAlpha.PostValidation.Intervals.Add(new ValueInterval(0, 255, true, true));
            neRed.PostValidation.Intervals.Add(new ValueInterval(0, 255, true, true));
            neGreen.PostValidation.Intervals.Add(new ValueInterval(0, 255, true, true));
            neBlue.PostValidation.Intervals.Add(new ValueInterval(0, 255, true, true));
            neAlpha.ErrorInfo.ShowErrorMessage = false;
            neAlpha.ErrorInfo.ErrorAction = ErrorAction.ResetValue;
            neRed.ErrorInfo.ShowErrorMessage = false;
            neRed.ErrorInfo.ErrorAction = ErrorAction.ResetValue;
            neGreen.ErrorInfo.ShowErrorMessage = false;
            neGreen.ErrorInfo.ErrorAction = ErrorAction.ResetValue;
            neBlue.ErrorInfo.ShowErrorMessage = false;
            neBlue.ErrorInfo.ErrorAction = ErrorAction.ResetValue;

            // Color swatches panel:
            pnlCustomColors.PostInit();
            pnlCustomColors.CurrentColorChanged += CustomColorChanged;
            pnlCustomColors.ColorPicked += CustomColorPicked;

            // Transparent and empty color buttons:
            cbTransparentColor.Left = pnlCustomColors.Left + pnlCustomColors.ContentRectangle.Left;
            cbTransparentColor.Click += ColorButtonClicked;
            cbEmptyColor.Visible = false;
            cbEmptyColor.Click += ColorButtonClicked;

            btnColorPicker.Left = pnlCustomColors.Left + pnlCustomColors.ContentRectangle.Right - btnColorPicker.Width;
            btnColorPicker.Click += btnColorPicker_Click;
        }

        #region Private
        private int GetInt(
            C1NumericEdit ne)
        {
            if (ne.Value == null || ne.Value is DBNull)
                return 0;
            return (int)Utils.AsNumber(ne.Value);
        }

        void btnColorPicker_Click(object sender, EventArgs e)
        {
            var dlg = new ColorDialog();
            dlg.Color = Value;
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                Value = dlg.Color;
            }
        }

        private void ColorButtonClicked(object sender, EventArgs e)
        {
            Value = ((ColorButton)sender).Color;
            OnColorSelected();
        }

        private void CustomColorPicked(object sender, EventArgs e)
        {
            Value = ((ColorSwatchPanel)sender).CurrentColor;
            OnColorSelected();
        }

        private void CustomColorChanged(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;
            _value = ((ColorSwatchPanel)sender).CurrentColor;
            UpdateControl();
            OnColorChanged();
        }

        private void UpdateControl()
        {
            BeginUpdate();
            try
            {
                neRed.Value = _value.R;
                neGreen.Value = _value.G;
                neBlue.Value = _value.B;
                neAlpha.Value = _value.A;
                cbTransparentColor.Selected = _value == Color.Transparent;
                cbEmptyColor.Selected = _value.IsEmpty;
                pnlCustomColors.CurrentColor = _value;
                pcPreview.Invalidate();
            }
            finally
            {
                EndUpdate();
            }
        }
        #endregion

        #region Protected
        
        protected virtual void OnColorSelected()
        {
            if (ColorSelected != null)
                ColorSelected(this, EventArgs.Empty);
        }

        protected virtual void OnColorChanged()
        {
            if (ColorChanged != null)
                ColorChanged(this, EventArgs.Empty);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (neAlpha.Focused)
                    neAlpha.UpdateValueWithCurrentText();
                else if (neBlue.Focused)
                    neBlue.UpdateValueWithCurrentText();
                else if (neGreen.Focused)
                    neBlue.UpdateValueWithCurrentText();
                else if (neRed.Focused)
                    neRed.UpdateValueWithCurrentText();
            }

            return base.ProcessDialogKey(keyData);
        }

        #endregion

        #region Public properties
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShowEmpty
        {
            get { return cbEmptyColor.Visible; }
            set { cbEmptyColor.Visible = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string EmptyColorAlias
        {
            get { return cbEmptyColor.Text; }
            set { cbEmptyColor.Text = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color Value
        {
            get { return _value; }
            set
            {
                if (_value == value)
                    return;
                _value = value;
                UpdateControl();
                OnColorChanged();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color OldValue
        {
            get { return _oldValue; }
            set { _oldValue = value; }
        }

        [DefaultValue(c_DefAllowTransparent)]
        public bool AllowTransparent
        {
            get { return _allowTransparent; }
            set
            {
                if (_allowTransparent == value)
                    return;
                _allowTransparent = value;
                if (_allowTransparent)
                {
                    cbTransparentColor.Enabled = true;
                    c1Label4.Enabled = true;
                    neAlpha.Enabled = true;
                }
                else
                {
                    cbTransparentColor.Enabled = false;
                    c1Label4.Enabled = false;
                    neAlpha.Enabled = false;
                    neAlpha.Value = 255;
                }
            }
        }

        [DefaultValue(c_DefAllowColorPicker)]
        public bool AllowColorPicker
        {
            get { return _allColorPicker; }
            set
            {
                if (_allColorPicker == value)
                    return;
                _allColorPicker = value;
                btnColorPicker.Visible = _allColorPicker;
            }
        }

        #endregion

        #region Events

        public event EventHandler ColorSelected;

        public event EventHandler ColorChanged;

        public event EventHandler<DrawPreviewEventArgs> DrawInitial;

        public event EventHandler<DrawPreviewEventArgs> DrawCurrent;

        #endregion

        private void neRed_ValueChanged(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;
            _value = Color.FromArgb(
                GetInt(neAlpha),
                GetInt(neRed),
                GetInt(neGreen),
                GetInt(neBlue));
            OnColorChanged();
            pcPreview.Invalidate();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _value = Color.FromArgb(
                GetInt(neAlpha),
                GetInt(neRed),
                GetInt(neGreen),
                GetInt(neBlue));
            OnColorSelected();
        }

        private void pcPreview_DrawCurrent(object sender, DrawPreviewEventArgs e)
        {
            if (DrawCurrent != null)
                DrawCurrent(this, e);
            else
                Utils.DrawColorMark(e.Graphics, _value, false, e.Bounds);
        }

        private void pcPreview_DrawInitial(object sender, DrawPreviewEventArgs e)
        {
            if (DrawInitial != null)
                DrawInitial(sender, e);
            else
                Utils.DrawColorMark(e.Graphics, _oldValue, false, e.Bounds);
        }
    }
}
