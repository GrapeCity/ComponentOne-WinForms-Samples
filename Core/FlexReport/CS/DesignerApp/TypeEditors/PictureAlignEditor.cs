//----------------------------------------------------------------------------
// PictureAlignEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
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
using Doc = C1.Win.Document;

namespace FlexReportDesignerApp
{
    /// <summary>
    /// <see cref="UITypeEditor"/> used to edit image alignment properties 
    /// (properties of type <see cref="PictureAlignEnum"/>).
    /// </summary>
    /// <remarks>
    /// <para><see cref="PictureAlignEditor"/> shows a drop-down control that allows users to visually select 
    /// image alignment options.</para>
    /// <para>You can use this <see cref="UITypeEditor"/> in classes that derive from <see cref="Field"/> to 
    /// provide image alignment editing.</para>
    /// </remarks>
    public class PictureAlignEditor : UITypeEditor
    {
        private IWindowsFormsEditorService _edSvc;
        private PictureAlignControl _ctl;
        /// <summary>
        /// Initializes a new instance of the <see cref="PictureAlignEditor"/> class.
        /// </summary>
        public PictureAlignEditor()
        {
            if (_ctl == null)
            {
                _ctl = new PictureAlignControl();
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
        /// <returns>A <see cref="PictureAlignEnum"/> value containing the new value of the object.</returns>
        override public object EditValue(ITypeDescriptorContext ctx, IServiceProvider provider, object value)
        {
            _edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            if (_edSvc != null)
            {
                // show drop down
                if (value == null)
                    value = -2;

                var inValue = (int)value;
                _ctl.Value = inValue;
                _edSvc.DropDownControl(_ctl);
                _edSvc = null;

                // return selected value
                if (_ctl.Value <= -2)
                    return null;
                else if (_ctl.Value == inValue)
                    return value; // this is needed in order not to fire property changed if there was no change
                return (PictureAlignEnum)_ctl.Value;
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
