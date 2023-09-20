//----------------------------------------------------------------------------
// ModelCollectionEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.UI;
using System.Windows.Forms;
using System.Reflection;

using C1.Win.FlexReport;
using Doc = C1.Win.Document;

namespace FlexReportDesignerApp.TypeEditors
{
    /// <summary>
    /// Advanced version of standard <see cref="CollectionEditor"/>. Supports <see cref="EditableModel"/>
    /// for items, undo operation etc.
    /// If edited collection supports <see cref="Doc.OwnedObject"/> then <see cref="ModelCollectionEditor"/>
    /// tries to go up using <see cref="Doc.OwnedObject.Owner"/> property for <see cref="FieldBase"/> class
    /// and calls its BeginUpdate() / EndUpdate(bool) methods.
    /// </summary>
    internal class ModelCollectionEditor : CollectionEditor
    {
        private bool _canceled;

        #region Constructors
        public ModelCollectionEditor(Type type)
            : base(type)
        {
        }
        #endregion

        #region Private
        void propertyGrid_SelectedObjectsChanged(object sender, EventArgs e)
        {
            PropertyGrid propertyGrid = sender as PropertyGrid;
            object so = propertyGrid.SelectedObject;
            if (so == null)
                return;
            object model = EditorsHelper.CreateInstanceModel(so, MainForm.TheMainForm.DesignerHostServices);
            if (model != so)
                propertyGrid.SelectedObject = model;
        }

        private FieldBase GetField(object obj)
        {
            Doc.IOwnedObject oo = obj as Doc.IOwnedObject;
            while (oo != null && oo.Owner != null && !(oo.Owner is FieldBase))
                oo = oo.Owner as Doc.IOwnedObject;
            return oo == null ? null : oo.Owner as FieldBase;
        }
        #endregion

        #region Protected
        protected override CollectionForm CreateCollectionForm()
        {
            CollectionForm result = base.CreateCollectionForm();

            var controls = result.Controls.Find("propertyBrowser", true);
            if (controls != null && controls.Length > 0)
            {
                PropertyGrid propertyGrid = (PropertyGrid)controls[0];
                propertyGrid.HelpVisible = true;
                propertyGrid.SelectedObjectsChanged += propertyGrid_SelectedObjectsChanged;
            }

            return result;
        }

        protected virtual bool SupportUndo()
        {
            return true;
        }

        protected override void CancelChanges()
        {
            base.CancelChanges();
            _canceled = true;
        }

        protected virtual object SaveState(object value)
        {
            IList list = value as IList;
            if (list == null)
                return null;

            List<object> state = new List<object>();
            foreach (object item in list)
            {
                ICloneable cloneable = item as ICloneable;
                if (cloneable != null)
                {
                    state.Add(cloneable.Clone());
                    continue;
                }
                Doc.ICloneableObject cloneableObject = item as Doc.ICloneableObject;
                if (cloneableObject != null)
                {
                    Doc.ICloneableObject newObject = cloneableObject.CreateSame() as Doc.ICloneableObject;
                    newObject.AssignFrom(cloneableObject);
                    state.Add(newObject);
                    continue;
                }
            }
            return state;
        }

        protected virtual void RestoreState(object value, object state)
        {
            IList stateList = state as IList;
            if (stateList == null)
                return;

            IList list = value as IList;
            list.Clear();
            foreach (var item in stateList)
                list.Add(item);
        }
        #endregion

        #region Public
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            object state = SaveState(value);
            _canceled = false;
            FieldBase field = GetField(value);
            if (field != null)
                field.BeginUpdate();

            object undoState = null;
            if (SupportUndo())
            {
                try
                {
                    undoState = MainForm.TheMainForm.FlexDesigner.Undo_CreateSavedState();
                }
                catch
                {
                    // only one level undo state could be saved.
                }
            }

            object result;
            try
            {
                result = base.EditValue(context, provider, value);
            }
            catch (Exception)
            {
                RestoreState(value, state);
                if (undoState != null)
                    MainForm.TheMainForm.FlexDesigner.Undo_DiscardSavedState(undoState);
                if (field != null)
                    field.EndUpdate(false);
                throw;
            }

            if (_canceled)
            {
                RestoreState(value, state);
                if (undoState != null)
                    MainForm.TheMainForm.FlexDesigner.Undo_DiscardSavedState(undoState);
            }
            else
            {
                if (undoState != null)
                    MainForm.TheMainForm.FlexDesigner.Undo_PushSavedState(undoState);
            }

            if (field != null)
                field.EndUpdate(!_canceled);
            return result;
        }
        #endregion
    }
}
