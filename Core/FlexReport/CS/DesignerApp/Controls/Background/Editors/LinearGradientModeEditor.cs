//----------------------------------------------------------------------------
// LinearGradientModeEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Text;
using System.ComponentModel;

namespace FlexReportDesignerApp.Controls.Background.Editors
{
    internal class LinearGradientModeEditor : EnumEditor
    {
        #region Constructors
        public LinearGradientModeEditor()
        {
            EnumType = typeof(LinearGradientMode);
        }
        #endregion

        #region Protected
        protected override DropDownListBox CreateListBox()
        {
            return new LinearGradientModeListBox();
        }

        #endregion
    }
}
