//----------------------------------------------------------------------------
// DropDownFormBase.cs
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
using C1.Win.C1Input;
using C1.Win.C1Command;

namespace FlexReportDesignerApp.Controls.Background.Editors
{
    internal partial class DropDownFormBase : DropDownForm
    {
        private const bool c_DefAllowReference = true;

        private int _updateCount;

        public DropDownFormBase()
        {
            InitializeComponent();
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
        public C1.Win.C1Input.VisualStyle VisualStyle
        {
            get
            {
                if (DockingTab == null)
                    return C1.Win.C1Input.VisualStyle.Custom;
                return (C1.Win.C1Input.VisualStyle)Enum.Parse(typeof(C1.Win.C1Input.VisualStyle), DockingTab.VisualStyle.ToString());
            }
            set
            {
                if (DockingTab == null)
                    return;
                DockingTab.VisualStyle = (C1.Win.C1Command.VisualStyle)Enum.Parse(typeof(C1.Win.C1Command.VisualStyle), value.ToString());
            }
        }

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
        public new DropDownEditorBase OwnerControl
        {
            get { return (DropDownEditorBase)base.OwnerControl; }
        }

        #endregion
    }
}
