//----------------------------------------------------------------------------
// BackgroundEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using C1.Win.C1Document;
using FlexReportDesignerApp.Controls.Background.BackgroundEditor;
using FlexReportDesignerApp.Forms;
using NSD = C1.Win.Interop;

namespace FlexReportDesignerApp.TypeEditors
{
    internal class BackgroundEditor : UITypeEditor
    {
        private IWindowsFormsEditorService _editorService;

        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            _editorService = provider.GetService(typeof (IWindowsFormsEditorService)) as IWindowsFormsEditorService;
            if (_editorService == null)
                return base.EditValue(context, provider, value);

            var background = value as C1Brush;
            background = background ?? new C1SolidBrush();

            var editor = new BackgroundEditorControl(_editorService);
            editor.Init(background, true, false, null);
            _editorService.DropDownControl(editor);
            return editor.Background;
        }

        public override bool GetPaintValueSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override void PaintValue(PaintValueEventArgs e)
        {
            var brush = (e.Value as C1Brush) ?? new C1SolidBrush();
            Controls.Background.Utils.DrawBackground(e.Graphics, Color.White, brush, e.Bounds);
        }
    }
}
