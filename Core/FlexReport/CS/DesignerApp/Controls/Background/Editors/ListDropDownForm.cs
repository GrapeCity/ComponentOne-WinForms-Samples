//----------------------------------------------------------------------------
// ListDropDownForm.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
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
    internal partial class ListDropDownForm : DropDownFormBase
    {
        private DropDownListBox _listBox;
        private int _maxDropDownItem = 8;

        public ListDropDownForm(C1DropDownControlBase dropDownOwner)
            : base(dropDownOwner)
        {
            InitializeComponent();
            //Options = DropDownFormOptionsFlags.Focusable | DropDownFormOptionsFlags.FixedSize;
        }

        #region Protected
        protected virtual void ListBoxMouseUp(object sender, MouseEventArgs e)
        {
            //CloseDropDown(true);
        }

        //protected override void OnPostChanges(EventArgs e)
        //{
        //    base.OnPostChanges(e);
        //    OwnerControl.SetEditorValue(Value);
        //}

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                Value = OwnerControl.EditorValue;
                //if (_listBox != null)
                //    FocusControl = _listBox;
            }
        }

        #endregion

        #region Public properties
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DropDownListBox ListBox
        {
            get { return _listBox; }
            set
            {
                if (_listBox == value)
                    return;

                if (_listBox != null)
                {
                    _listBox.MouseUp -= ListBoxMouseUp;
                    _listBox.Dispose();
                }
                _listBox = value;
                if (_listBox != null)
                {
                    _listBox.MouseUp += ListBoxMouseUp;
                    _listBox.Dock = DockStyle.Fill;
                    _listBox.Visible = true;
                    _listBox.Parent = this;
                }
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object Value
        {
            get { return _listBox == null ? null : _listBox.Value; }
            set
            {
                if (_listBox != null)
                    _listBox.Value = value;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ListBox.ObjectCollection Items
        {
            get { return _listBox == null ? null : _listBox.Items; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int MaxDropDownHeight
        {
            get { return _maxDropDownItem; }
            set { _maxDropDownItem = value; }
        }

        #endregion

        #region public methods

        public void UpdatePerferedSize(Size ownerSize)
        {
            var size = _listBox.GetPreferredSize(Size);
            var maxHeight = _listBox.ItemHeight*_maxDropDownItem;
            var width = Math.Max(size.Width, ownerSize.Width);
            var height = Math.Min(size.Height, maxHeight);
            Size = new Size(width, height);
        }

        #endregion
    }
}
