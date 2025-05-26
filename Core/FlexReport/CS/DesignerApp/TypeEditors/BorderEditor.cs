//----------------------------------------------------------------------------
// BorderEditor.cs
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
using Doc = C1.Document;
using C1.Win.FlexReport.FlexDesigner;

namespace FlexReportDesignerApp.TypeEditors
{
    internal class BorderEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            var editorService = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
            if (editorService == null)
                return base.EditValue(context, provider, value);

            object instance;
            FlexDesignerHostServices services;
            if (!Util.EditableModelHelper.GetInstanceAndServices(context, out instance, out services))
                return base.EditValue(context, provider, value);

            var border = value as Doc.Border;
            using (var bordersForm = new BordersForm(border))
            {
                var undo = MainForm.TheMainForm.FlexDesigner.Undo_CreateSavedState();
                if (editorService.ShowDialog(bordersForm) == DialogResult.OK)
                {
                    MainForm.TheMainForm.FlexDesigner.Undo_PushSavedState(undo);
                    border = bordersForm.Border;
                }
                else
                    MainForm.TheMainForm.FlexDesigner.Undo_DiscardSavedState(undo);
            }
            return border;
        }
    }
}
