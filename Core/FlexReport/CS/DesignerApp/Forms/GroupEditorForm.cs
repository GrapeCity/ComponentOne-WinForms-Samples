//----------------------------------------------------------------------------
// GroupEditorForm.cs
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

using C1.Win.FlexReport;
using C1.Win.Localization;

namespace FlexReportDesignerApp.Util
{
	/// <summary>
	/// Summary description for GroupEditorForm.
	/// </summary>
	public partial class GroupEditorForm : System.Windows.Forms.Form
	{
        private C1FlexReport _report;
        private C1FlexReport _edit;
        
        public GroupEditorForm()
		{
			InitializeComponent();
            _propGrid.PropertyValueChanged += _propGrid_PropertyValueChanged;
		}

        private static string GroupBy2Name(string groupBy)
        {
            return "Group_" + (groupBy ?? "");
        }

        private string NewGroupName()
        {
            var baseName = Strings.GroupEditorForm.NewGroupName;
            for (int i = _edit.Groups.Count; i < int.MaxValue; ++i)
            {
                var name = baseName + i.ToString();
                if (!_edit.Groups.Contains(name))
                    return name;
            }
            throw new InvalidOperationException("Cannot make unique name. Too many groups?");
        }

        private void SetGroupSectionNames(Group g, string oldGroupName = null)
        {
            oldGroupName = oldGroupName ?? string.Empty;
            if (string.IsNullOrEmpty(g.SectionHeader.Name) || g.SectionHeader.Name == oldGroupName + "_Header")
                g.SectionHeader.Name = g.Name + "_Header";
            if (string.IsNullOrEmpty(g.SectionFooter.Name) || g.SectionFooter.Name == oldGroupName + "_Footer")
                g.SectionFooter.Name = g.Name + "_Footer";
        }

        private void _propGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            Group g;
            string oldGroupName;
            switch (e.ChangedItem.PropertyDescriptor.Name)
            {
                case "Name":
                    g = ((GroupItem)_lstGroups.SelectedItem)._group;
                    oldGroupName = e.OldValue as string;
                    if (string.IsNullOrEmpty(g.Name))
                        g.Name = GroupBy2Name(g.GroupBy);
                    SetGroupSectionNames(g, oldGroupName);
                    PopulateList(_lstGroups.SelectedIndex);
                    break;
                case "GroupBy":
                    g = ((GroupItem)_lstGroups.SelectedItem)._group;
                    if (string.IsNullOrEmpty(g.Name) || g.Name.StartsWith(Strings.GroupEditorForm.NewGroupName) || g.Name == GroupBy2Name(e.OldValue as string))
                    {
                        oldGroupName = g.Name;
                        g.Name = GroupBy2Name(g.GroupBy);
                        SetGroupSectionNames(g, oldGroupName);
                        PopulateList(_lstGroups.SelectedIndex);
                    }
                    break;
            }
        }

        // bind dialog to a report and show it
        public DialogResult ShowDialog(C1FlexReport report)
		{
			// create a copy of the report, this is the one we'll edit with the dialog
			_report = report;
            _edit = new C1FlexReport();
            _edit.CopyDefinitionFrom(_report);

			// set text on graphical buttons
			_btnUp.Text   = ((char)0xe9).ToString();
			_btnDown.Text = ((char)0xea).ToString();

			// ready to go
			return base.ShowDialog();
		}

		// save results and dismiss dialog
		private void _btnOK_Click(object sender, System.EventArgs e)
		{
			// apply changes
            _report.CopyDefinitionFrom(_edit);

			// done
			DialogResult = DialogResult.OK;
		}

		// populate list and edit controls
		private void GroupEditorForm_Load(object sender, System.EventArgs e)
		{
			PopulateList(0);
		}

		// populate group list, initialize edit controls
		private void PopulateList(int index)
		{
            _lstGroups.BeginUpdate();
			_lstGroups.Items.Clear();
			foreach (Group g in _edit.Groups)
				_lstGroups.Items.Add(new GroupItem(g));

			// select first item
			int cnt = _lstGroups.Items.Count;
			if (index > cnt - 1)
                index = cnt - 1;
			if (index > -1 && index < cnt)
				_lstGroups.SelectedIndex = index;
            // _lstGroups_SelectedIndexChanged(this, EventArgs.Empty);// make sure we update the selection
            _lstGroups.EndUpdate();
			// update UI
			UpdateUI();
		}

		// update controls with group info
		private void _lstGroups_SelectedIndexChanged(object sender, System.EventArgs e)
		{
            var item = _lstGroups.SelectedItem;
            if (item == null)
                _propGrid.SelectedObject = null;
            else
            {
                Group g = ((GroupItem)item)._group;
                _propGrid.SelectedObject = g != null ? EditorsHelper.CreateInstanceModel(g, MainForm.TheMainForm.DesignerHostServices) : null;
            }
			UpdateUI();
		}
		private void UpdateUI()
		{
			// udpate up/down buttons
			int cnt = _lstGroups.Items.Count;
			_btnUp.Enabled	 = _lstGroups.SelectedIndex > 0;
			_btnDown.Enabled = (cnt > 0 && _lstGroups.SelectedIndex < cnt-1);
		}

		// move group up/down in list
		private void _btnUp_Click(object sender, System.EventArgs e)
		{
			Group g = ((GroupItem)_lstGroups.SelectedItem)._group;
            System.Diagnostics.Debug.Assert(g.ParentReport == _edit);
            int index = _lstGroups.SelectedIndex;
            // System.Diagnostics.Debug.WriteLine("==========before move up: header: " + g.SectionHeader.Visible.ToString() + " footer: " + g.SectionFooter.Visible.ToString());
            g.ParentReport.Groups.Move(index, index - 1);
            // System.Diagnostics.Debug.WriteLine("==========after move up: header: " + g.SectionHeader.Visible.ToString() + " footer: " + g.SectionFooter.Visible.ToString());
            PopulateList(index - 1);
		}
		private void _btnDown_Click(object sender, System.EventArgs e)
		{
			Group g = ((GroupItem)_lstGroups.SelectedItem)._group;
            System.Diagnostics.Debug.Assert(g.ParentReport == _edit);
            int index = _lstGroups.SelectedIndex;
            g.ParentReport.Groups.Move(index, index + 1);
            PopulateList(index + 1);
		}

		// add/delete groups
		private void _btnAdd_Click(object sender, System.EventArgs e)
		{
			// add new group
			Group g = _edit.Groups.Add(NewGroupName(), string.Empty, SortEnum.NoSort);

            // set our own header/footer names:
			g.SectionHeader.Name = string.Empty;
			g.SectionFooter.Name = string.Empty;
            SetGroupSectionNames(g);

			// refresh the display
			int cnt = _lstGroups.Items.Count;
			PopulateList(cnt);
		}
		private void _btnDelete_Click(object sender, System.EventArgs e)
		{
			// get selected group
			int index = _lstGroups.SelectedIndex;

			// remove it from the list
			if (_lstGroups.SelectedIndex >= 0)
				_edit.Groups.RemoveAt(_lstGroups.SelectedIndex);

			// refresh the display
			PopulateList(index);
		}
	}

	/// <summary>
	/// GroupItem
	/// helper class used to populate listbox
	/// </summary>
	internal class GroupItem
	{
		internal Group _group;

		internal GroupItem(Group group)
		{
			_group = group;
		}

        public override string ToString()
		{
            // Note: returning null here results in out of memory crash:
			return _group.Name ?? string.Empty;
		}
	}
}
