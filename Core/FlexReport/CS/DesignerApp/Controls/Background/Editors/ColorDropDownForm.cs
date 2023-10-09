//----------------------------------------------------------------------------
// ColorDropDownForm.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.Input;
using C1.Win.Input.Base;

namespace FlexReportDesignerApp.Controls.Background.Editors
{
    internal partial class ColorDropDownForm : DropDownFormBase
    {
        private Color _value;

        public ColorDropDownForm(C1DropDownControlBase dropDownOwner)
            : base(dropDownOwner)
        {
            InitializeComponent();

            //Options = DropDownFormOptionsFlags.Focusable | DropDownFormOptionsFlags.FixedSize;
            clbWebColors.ShowColors = ShowColors.Web;
            clbSystemColors.ShowColors = ShowColors.SystemColors;
        }

        #region Private
        private void UpdateControl(
            Editors updateEditors)
        {
            BeginUpdate();
            try
            {
                if ((updateEditors & Editors.WebColors) != 0)
                    clbWebColors.SelectedColor = _value;
                if ((updateEditors & Editors.SystemColors) != 0)
                    clbSystemColors.SelectedColor = _value;
                if ((updateEditors & Editors.Custom) != 0)
                    customColorEditor1.Value = _value;
            }
            finally
            {
                EndUpdate();
            }
        }
        #endregion

        #region Protected

        //protected override void OnPostChanges(EventArgs e)
        //{
        //    base.OnPostChanges(e);
        //    OwnerControl.EditorValue = Value;
        //}

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                if (OwnerControl.AllowTransparent)
                    clbWebColors.HiddenColors = null;
                else
                    clbWebColors.HiddenColors = new Color[] {Color.Transparent};
                customColorEditor1.AllowTransparent = OwnerControl.AllowTransparent;

                try
                {
                    // access to OwnerControl.Value can cause an exception
                    // if entered string cannot be parsed
                    Color v = OwnerControl.ColorValue;
                    Value = v;
                }
                catch
                {
                    Value = Color.Transparent;
                }
                customColorEditor1.OldValue = Value;

                if (clbSystemColors.SelectedIndex >= 0)
                {
                    dtMain.SelectedTab = dtpSystemColors;
                    //this.FocusControl = clbSystemColors;
                }
                else if (clbWebColors.SelectedIndex >= 0)
                {
                    dtMain.SelectedTab = dtpWebColors;
                    //FocusControl = clbWebColors;
                }
                else
                {
                    dtMain.SelectedTab = dtpCustom;
                    //FocusControl = customColorEditor1;
                }
            }
        }
        #endregion

        #region Protected properties
        protected override C1.Win.Command.C1DockingTab DockingTab
        {
            get { return dtMain; }
        }
        #endregion

        #region Public
        public void OnValueChanged()
        {
        }
        #endregion

        #region Public properties
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
                UpdateControl(Editors.All);
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new ColorEditor OwnerControl
        {
            get { return (ColorEditor)base.OwnerControl; }
        }
        #endregion

        #region Nested types
        [Flags]
        private enum Editors
        {
            None = 0x00,
            All = WebColors | SystemColors | Custom,
            WebColors = 0x01,
            SystemColors = 0x02,
            Custom = 0x04,
        }
        #endregion

        #region Event handlers
        private void clbWebColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;
            _value = clbWebColors.SelectedColor;
            UpdateControl(Editors.Custom | Editors.SystemColors);
        }

        private void clbSystemColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;
            _value = clbSystemColors.SelectedColor;
            UpdateControl(Editors.Custom | Editors.WebColors);
        }

        private void customColorEditor1_ColorChanged(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;
            _value = customColorEditor1.Value;
            UpdateControl(Editors.WebColors | Editors.SystemColors);
        }

        private void clbWebColors_MouseUp(object sender, MouseEventArgs e)
        {
            //CloseDropDown(true);
        }

        private void clbSystemColors_MouseUp(object sender, MouseEventArgs e)
        {
            //CloseDropDown(true);
        }

        private void customColorEditor1_ColorSelected(object sender, EventArgs e)
        {
            if (UpdateLocked)
                return;
            _value = customColorEditor1.Value;
            UpdateControl(Editors.WebColors | Editors.SystemColors);
            //CloseDropDown(true);
        }
        #endregion
    }
}
