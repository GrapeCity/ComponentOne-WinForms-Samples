using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.GanttView;

namespace GroupSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Event handlers

        private void Form1_Load(object sender, EventArgs e)
        {
            int modelCount = c1GanttView1.GroupDefinition.Items.Count;
            if (modelCount == 0)
            {
                comboGroupBy.SelectedIndex = 0;
            }
            else if (modelCount == 1)
            {
                BaseGroup groupModel = c1GanttView1.GroupDefinition.Items[0];
                if (groupModel is TaskModeGroup)
                    comboGroupBy.SelectedIndex = 1;
                else if (groupModel is TaskCompleteGroup)
                    comboGroupBy.SelectedIndex = 2;
                else if (groupModel is ConstraintTypeGroup)
                    comboGroupBy.SelectedIndex = 3;
                else if (groupModel is DurationGroup)
                    comboGroupBy.SelectedIndex = 4;
                else if (groupModel is MilestonesGroup)
                    comboGroupBy.SelectedIndex = 5;
                else if (groupModel is ResourceGroup)
                    comboGroupBy.SelectedIndex = 6;
                else if (groupModel is StatusGroup)
                    comboGroupBy.SelectedIndex = 7;
                else
                    comboGroupBy.SelectedIndex = 8;
            }
            else
                comboGroupBy.SelectedIndex = 8;
            if (c1GanttView1.GroupDefinition.Items.Count > 0)
            {
                summaryGroupBox.Enabled = false;
            }
            chkShowProjectSummary.Checked = c1GanttView1.ShowProjectSummary;
            chkMaintainHierarchy.Checked = c1GanttView1.GroupDefinition.MaintainHierarchy;
            comboGroupBy.SelectedIndexChanged += new EventHandler(comboGroupBy_SelectedIndexChanged);
        }

        private void btnOutdent_Click(object sender, EventArgs e)
        {
            c1GanttView1.ClickButton(CommandButton.Outdent);
        }

        private void btnIndent_Click(object sender, EventArgs e)
        {
            c1GanttView1.ClickButton(CommandButton.Indent);
        }

        private void chkShowProjectSummary_CheckedChanged(object sender, EventArgs e)
        {
            c1GanttView1.ShowProjectSummary = chkShowProjectSummary.Checked;
        }

        private void comboGroupBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedText = (string)comboGroupBy.SelectedItem;
            switch (selectedText)
            { 
                case "No Group":
                    c1GanttView1.ClearGroup();
                    break;
                case "Task Mode":
                    c1GanttView1.Group(new TaskModeGroup(true));
                    break;
                case "Task Complete":
                    c1GanttView1.Group(new TaskCompleteGroup(true));
                    break;
                case "Constraint Type":
                    c1GanttView1.Group(new ConstraintTypeGroup(true));
                    break;
                case "Duration":
                    c1GanttView1.Group(new DurationGroup(true));
                    break;
                case "Milestones":
                    c1GanttView1.Group(new MilestonesGroup(true));
                    break;
                case "Resource":
                    c1GanttView1.Group(new ResourceGroup(true));
                    break;
                case "Status":
                    {
                        DateTime statusDate = DateTime.Today;
                        if (c1GanttView1.ProgressLine.StatusDate.HasValue)
                            statusDate = c1GanttView1.ProgressLine.StatusDate.Value;
                        c1GanttView1.Group(new StatusGroup(statusDate, true));
                    }
                    break;
                case "Advance Group":
                    c1GanttView1.ClickButton(CommandButton.Group);
                    break;
                default:
                    break;
            }
            if (c1GanttView1.GroupDefinition.Items.Count == 0)
            {
                comboGroupBy.SelectedIndex = 0;
                summaryGroupBox.Enabled = true;
                chkShowProjectSummary.Checked = c1GanttView1.ShowProjectSummary;
            }
            else 
            {
                summaryGroupBox.Enabled = false;
            }
        }

        private void chkMaintainHierarchy_CheckedChanged(object sender, EventArgs e)
        {
            c1GanttView1.GroupDefinition.MaintainHierarchy = chkMaintainHierarchy.Checked;
        }

        private void btnClearGroup_Click(object sender, EventArgs e)
        {
            c1GanttView1.ClearGroup();
        }

        #endregion


    }

}
