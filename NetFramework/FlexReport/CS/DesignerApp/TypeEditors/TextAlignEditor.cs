//----------------------------------------------------------------------------
// TextAlignEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Globalization;

using C1.Win.FlexReport;
using Flex = C1.Win.FlexReport;
using Doc = C1.Win.C1Document;

namespace FlexReportDesignerApp
{
    /// <summary>
    /// <see cref="UITypeEditor"/> used to edit text alignment properties 
    /// (properties of type <see cref="FieldAlignEnum"/>).
    /// </summary>
    /// <remarks>
    /// <para>This editor shows a drop-down control that allows users to visually select text alignment options.</para>
    /// <para>You can use this <see cref="UITypeEditor"/> in classes that derive from <see cref="Field"/> to provide 
    /// text alignment editing.</para>
    /// </remarks>
    public class TextAlignEditor : UITypeEditor
    {
        private IWindowsFormsEditorService _edSvc;
        private TextAlignControl _ctl;

        /// <summary>
        /// Initializes a new instance of the <see cref="TextAlignEditor"/> class.
        /// </summary>
        public TextAlignEditor()
        {
            if (_ctl == null)
            {
                _ctl = new TextAlignControl();
                _ctl.VisibleChanged += new System.EventHandler(_ctl_VisibleChanged);
            }
        }
        /// <summary>
        /// Gets the editor style used by the <see cref="EditValue"/> method.
        /// </summary>
        /// <param name="ctx">An <see cref="ITypeDescriptorContext"/> that can be used to gain additional context information.</param>
        /// <returns>Always returns <b>UITypeEditorEditStyle.DropDown</b>.</returns>
        override public UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext ctx)
        {
            return UITypeEditorEditStyle.DropDown;
        }
        /// <summary>
        /// Edits the value of the specified object.
        /// </summary>
        /// <param name="ctx">An <see cref="ITypeDescriptorContext"/> that can be used to gain additional context information.</param>
        /// <param name="provider">An <see cref="IServiceProvider"/> through which editing services may be obtained.</param>
        /// <param name="value">An instance of the value being edited.</param>
        /// <returns>A <see cref="FieldAlignEnum"/> value containing the new value of the object.</returns>
        override public object EditValue(ITypeDescriptorContext ctx, IServiceProvider provider, object value)
        {
            _edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            if (_edSvc != null)
            {
                // show drop down
                if (value == null) value = -2;
                _ctl.Value = (int)value;
                _edSvc.DropDownControl(_ctl);
                _edSvc = null;

                // return selected value
                if (_ctl.Value <= -2) return null;
                return (FieldAlignEnum)_ctl.Value;
            }

            // return whatever we got
            return value;
        }
        private void _ctl_VisibleChanged(object sender, System.EventArgs e)
        {
            if (_ctl.Visible == false && _edSvc != null)
                _edSvc.CloseDropDown();
        }
    }
}
