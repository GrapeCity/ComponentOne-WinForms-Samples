//----------------------------------------------------------------------------
// ReportParameterValuesEditors.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using C1.Report;
using C1.Win.FlexReport.FlexDesigner;
using FlexReportDesignerApp.Forms;

namespace FlexReportDesignerApp.TypeEditors
{
    internal class ReportParameterValuesEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            var editorService = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
            if (editorService == null) return base.EditValue(context, provider, value);

            object instance;
            FlexDesignerHostServices services;
            if (!Util.EditableModelHelper.GetInstanceAndServices(context, out instance, out services))
                return base.EditValue(context, provider, value);

            var parameterValues = value as ReportParameterValues;
            if (parameterValues == null)
                return base.EditValue(context, provider, value);

            object undo = null;
            try
            {
                undo = MainForm.TheMainForm.FlexDesigner.Undo_CreateSavedState();
            }
            catch
            {
            }
            using (ParameterValuesEditorForm editor = new ParameterValuesEditorForm())
            {
                editor.Init(services, parameterValues);
                if (editorService.ShowDialog(editor) == DialogResult.OK)
                {
                    editor.ApplyChanges(parameterValues);
                    if (undo != null)
                        MainForm.TheMainForm.FlexDesigner.Undo_PushSavedState(undo);
                }
                else
                {
                    if (undo != null)
                        MainForm.TheMainForm.FlexDesigner.Undo_DiscardSavedState(undo);
                }
            }

            return parameterValues;
        }
    }
}
