//----------------------------------------------------------------------------
// BaseUserControl.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace FlexReportDesignerApp.Controls.Background
{
    internal partial class BaseUserControl : UserControl
    {
        private int _updateCount;

        public BaseUserControl()
        {
            InitializeComponent();
        }

        protected void BeginUpdate()
        {
            _updateCount++;
        }

        protected void EndUpdate()
        {
            _updateCount--;
        }

        protected bool UpdateLocked
        {
            get { return _updateCount != 0; }
        }
    }
}
