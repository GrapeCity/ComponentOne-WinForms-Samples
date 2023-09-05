//----------------------------------------------------------------------------
// NullableColorEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) Mescius, Inc.
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
using C1.Win.Document;
using FlexReportDesignerApp.Controls.Background.BackgroundEditor;
using FlexReportDesignerApp.Forms;
using NSD = C1.Win.Interop;

namespace FlexReportDesignerApp.TypeEditors
{
    internal class NullableColorEditor : UITypeEditor
    {
        private IWindowsFormsEditorService _editorService;

        public virtual string NullValueAlias
        {
            get { return Strings.BackgroundEditor.EmptyColor; }
        }

        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            _editorService = provider.GetService(typeof (IWindowsFormsEditorService)) as IWindowsFormsEditorService;
            if (_editorService == null)
                return base.EditValue(context, provider, value);

            if (value != null && !(value is Color?))
                return base.EditValue(context, provider, value);

            Color? c = (Color?)value;
            C1SolidBrush brush = new C1SolidBrush(c.HasValue ? c.Value : Color.Empty);

            var editor = new BackgroundEditorControl(_editorService);
            editor.Init(brush, false, true, NullValueAlias);
            _editorService.DropDownControl(editor);
            brush = editor.Background as C1SolidBrush;
            if (brush == null || brush.Color.IsEmpty)
                return null;
            else
                return brush.Color;
        }

        public override bool GetPaintValueSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override void PaintValue(PaintValueEventArgs e)
        {
            Color? c = e.Value is Color? ? (Color?)e.Value : (Color?)null;
            Controls.Background.Utils.DrawColorMark(e.Graphics, c.HasValue ? c.Value : Color.Empty, true, e.Bounds);
        }
    }
}
