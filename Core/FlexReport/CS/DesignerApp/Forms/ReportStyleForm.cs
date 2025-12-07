//----------------------------------------------------------------------------
// ReportStyleForm.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using C1.Win.FlexReport;
using FlexReportDesignerApp.Util;

namespace FlexReportDesignerApp
{
	/// <summary>
	/// Summary description for ReportStyleForm.
	/// </summary>
	public partial class ReportStyleForm : System.Windows.Forms.Form
	{
        MainForm _owner;

        public ReportStyleForm()
        {
            //
            InitializeComponent();
        }

		public ReportStyleForm(
            MainForm owner)
            : this()
		{
            // localized tooltips:
            this.toolTip1.SetToolTip(this._btnApply, Strings.ReportStyleForm.TtipBtnApply);
            this.toolTip1.SetToolTip(this._btnRemove, Strings.ReportStyleForm.TtipBtnRemove);
            this.toolTip1.SetToolTip(this._btnAdd, Strings.ReportStyleForm.TtipBtnAdd);

            //
            AutoScaleMode = AutoScaleMode.None;
            Font = MainForm.DefaultAppFont;
            _owner = owner;
        }

		// object model
		private C1FlexReportDesigner _designer;

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public C1FlexReportDesigner Designer
		{
			get { return _designer; }
			set { _designer = value; }
		}
		private bool _dirty = false;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // populate style list on start-up:
            foreach (ReportStyle style in ReportStyle.StyleList)
            {
                _list.Items.Add(style);
                if (string.Compare(style.Name, _owner._defaultStyleName, true) == 0)
                {
                    _list.SelectedIndex = _list.Items.Count - 1;
                }
            }
            if (_list.SelectedIndex < 0)
            {
                _list.SelectedIndex = 0;
            }
            _dirty = false;

            // load last used form state:
            AppSettings.LoadObject("ReportStyleForm", new FormState(this));
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            AppSettings.SaveObject("ReportStyleForm", new FormState(this));
        }

		// update style preview
		private void _list_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// get current style
			ReportStyle style = _list.SelectedItem as ReportStyle;
			if (style == null) return;

			// update preview
			_preview.Image = style.GetPreview(false);

            // we add a readonly attribute to predefined styles so that the grid can be used
            // to explore it but cannot change it:
            _propGrid.Enabled = true;
            if (!style.IsCustom)
            {
                var roAttribute = new ReadOnlyAttribute(true);
                if (!TypeDescriptor.GetAttributes(style).Matches(roAttribute))
                    TypeDescriptor.AddAttributes(style, roAttribute);
            }

            // update property grid
            _propGrid.SelectedObject = style;

			_propGrid.Refresh();

            // only custom styles can be edited:
            _lblPropGrid.Text = style.IsCustom ? Strings.ReportStyleForm.CustomStyleCaption : Strings.ReportStyleForm.BuiltInStyleCaption;

			// update buttons
			_btnRemove.Enabled = style.IsCustom;
		}

        // apply style when user double-clicks it on the list
        private void _list_DoubleClick(object sender, EventArgs e)
        {
            _btnApply_Click(this, e);
        }

		// update preview when properties change
		private void _propGrid_PropertyValueChanged(object s, System.Windows.Forms.PropertyValueChangedEventArgs e)
		{
			// update preview
			ReportStyle style = _list.SelectedItem as ReportStyle;
			_preview.Image = style.GetPreview(true);

			// update list
			if (e.ChangedItem.PropertyDescriptor.Name == "Name")
			{
				int index = _list.SelectedIndex;
				_list.Items[index] = style;
			}

			// remember we're dirty
			_dirty = true;
		}

		// handle buttons
		private void _btnOK_Click(object sender, System.EventArgs e)
		{
			// apply current style
			_btnApply_Click(sender, e);

			// save any changes to settings file
			if (_dirty)
			{
                DialogResult dr = MessageForm.Ask(Strings.ReportStyleForm.ConfirmSaveStyle, MessageBoxButtons.YesNoCancel);
                switch (dr)
				{
					// cancel and keep dialog open
					case DialogResult.Cancel:
						return;

					// save all custom styles into app settings file
					case DialogResult.Yes:

						// build new custom style list
						ArrayList al = new ArrayList();
						foreach (ReportStyle s in _list.Items)
							if (s.IsCustom) al.Add(s.StyleDefinition);

						// save new list
						AppSettings.SaveList("customstyles", al, false, null);

						// done
						break;
				}
			}

			// done with dialog
			DialogResult = DialogResult.OK;
		}
		private void _btnCancel_Click(object sender, System.EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
		private void _btnApply_Click(object sender, System.EventArgs e)
		{
			// get selected style
			ReportStyle style = _list.SelectedItem as ReportStyle;
			if (style != null && _designer != null && _designer.Report != null)
			{
				// save state, apply to report, repaint
				_designer.UndoSaveState();
				style.Apply(_designer.Report);
				_designer.Invalidate();

                // this is the new 'current' style
                _owner._defaultStyleName = style.Name;
			}
		}
        private void _btnAdd_Click(object sender, System.EventArgs e)
		{
			// clone current style
			ReportStyle style = _list.SelectedItem as ReportStyle;
			ReportStyle clone = style.Clone() as ReportStyle;

			// ensure that new name is unique
			clone.Name = CreateUniqueName(clone.Name);

			// add it to list control
			_list.Items.Add(clone);
			_list.SelectedItem = clone;

			// remember we're dirty
			_dirty = true;
		}
		private string CreateUniqueName(string name)
		{
			// already unique? no work
			if (!ListContains(name))
				return name;

			// make sure we have some kind of name
			if (name == null || name.Length == 0)
				name = "New Style";

			// strip trailing digits
			string baseName = Regex.Replace(name, "(.+) [0-9]+$", "$1");

			// and append counter until unique
			for (int i = 1;; i++)
			{
				string newName = string.Format("{0} {1}", baseName, i);
				if (!ListContains(newName))
				{
					return newName;
				}
			}
		}
		private bool ListContains(string name)
		{
			foreach (ReportStyle s in _list.Items)
			{
				if (string.Compare(s.Name, name, true) == 0)
					return true;
			}
			return false;
		}
		private void _btnRemove_Click(object sender, System.EventArgs e)
		{
			// get current style, index
			ReportStyle style = _list.SelectedItem as ReportStyle;
			int index = _list.SelectedIndex;

			// remove current style
			_list.Items.Remove(style);

			// restore index
			if (index >= _list.Items.Count)
				index = _list.Items.Count - 1;
			_list.SelectedIndex = index;

			// remember we're dirty
			_dirty = true;
		}
	}
}
