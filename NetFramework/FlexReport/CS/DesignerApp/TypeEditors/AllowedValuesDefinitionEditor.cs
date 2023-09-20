//----------------------------------------------------------------------------
// AllowedValuesDefinitionEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using C1.Win.C1Document;
using C1.Win.FlexReport;
using C1.Win.FlexReport.FlexDesigner;
using FlexReportDesignerApp.Forms;

namespace FlexReportDesignerApp.TypeEditors
{
    internal class AllowedValuesDefinitionEditor : UITypeEditor
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

            var allowedValues = value as AllowedValuesDefinition;
            if (allowedValues == null || allowedValues.Owner == null)
                return base.EditValue(context, provider, value);
            
            var undo = MainForm.TheMainForm.FlexDesigner.Undo_CreateSavedState();
            using (var editor = new AllowedValuesDefinitionEditorForm())
            {
                editor.Init(services, allowedValues.Owner);
                if (editorService.ShowDialog(editor) == DialogResult.OK)
                    MainForm.TheMainForm.FlexDesigner.Undo_PushSavedState(undo);
                else
                    MainForm.TheMainForm.FlexDesigner.Undo_DiscardSavedState(undo);
            }
            return allowedValues;
        }
    }
}
