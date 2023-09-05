//----------------------------------------------------------------------------
// DropDownFormBase.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) Mescius, Inc.
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
using C1.Win.Command;

namespace FlexReportDesignerApp.Controls.Background.Editors
{
    internal partial class DropDownFormBase : DropDownForm
    {
        private const bool c_DefAllowReference = true;

        private int _updateCount;
        private C1DropDownControlBase _dropDownOwner;

        public DropDownFormBase(C1DropDownControlBase dropDownOwner)
            : base(dropDownOwner)
        {
            InitializeComponent();
            _dropDownOwner = dropDownOwner;
        }

        #region Protected

        protected void BeginUpdate()
        {
            _updateCount++;
        }

        protected void EndUpdate()
        {
            _updateCount--;
        }

        #endregion

        #region Protected properties
        protected bool UpdateLocked
        {
            get { return _updateCount != 0; }
        }

        protected virtual C1DockingTab DockingTab
        {
            get { return null; }
        }

        #endregion

        #region Public properties
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool AllowReference
        {
            get { return false; }
            set
            {
                
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DropDownEditorBase OwnerControl
        {
            get { return (DropDownEditorBase)base.Control; }
        }


        public C1DropDownControlBase DropDownForm
        {
            get { return _dropDownOwner; }
        }

        #endregion
    }
}
