using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClickOnceDemo.C1ZoomPages.Help_Forms;
using C1.Win.TouchToolKit;
using System.ComponentModel.Design;

namespace ClickOnceDemo.C1ZoomPages
{
    public partial class ZoomPolicyDemo : DemoBase
    {
        private ZoomPolicyProvider _provider;
        public ZoomPolicyDemo()
        {
            InitializeComponent();

            this.Title = "Zoom Policy";
            this.Description = @"ZoomPolicy class is used to customize the zoom policy for specific controls.
  - Please select a zoom policy in the listbox, then click the Show Form Button to show a test form.";
            _provider = new ZoomPolicyProvider();

            string[] groups = _provider.PolicyGroups;
            if (groups.Length > 1)
            {
                this.groupBox1.Visible = true;
                foreach (string group in groups)
                {
                    CreateRadioButton(group);
                }
                int y = 23 + groupBox1.ClientRectangle.Y;
                foreach (RadioButton button in this.groupBox1.Controls)
                {
                    button.Location = new Point(6, y);
                    y += button.Height + 3;
                }
                (this.groupBox1.Controls[0] as RadioButton).Checked = true;
            }
            else
            {
                this.tableLayoutPanel1.SetColumnSpan(listBox1, 2);
                listBox1.Tag = groups[0];
                listBox1.DataSource = _provider.GetZoomPolicies(groups[0]);
                listBox1.SelectedIndex = 0;
            }        
        }

        private void CreateRadioButton(string group)
        {
            RadioButton radioButton = new RadioButton();
            radioButton.AutoSize = true;
            radioButton.Text = group;
            radioButton.CheckedChanged += radioButton_CheckedChanged;
            this.groupBox1.Controls.Add(radioButton);
            
        }

        void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                listBox1.DataSource = _provider.GetZoomPolicies(radioButton.Text);
                listBox1.Tag = radioButton.Text;
                if (listBox1.Items.Count > 0)
                {
                    listBox1.SelectedIndex = 0;
                }
            }
            listBox1_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void formButton_Click(object sender, EventArgs e)
        {
            ZoomPolicyForm form = new ZoomPolicyForm(this._provider, listBox1.Tag as string, listBox1.SelectedItem.ToString());
            form.ShowDialog(this);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                this.description1.Text = "";
            }
            else
            {
                this.description1.Text = _provider.GetDescription(listBox1.Tag as string, listBox1.SelectedItem.ToString());
            }
        }
    }

    public interface IZoomPolicyProvider
    {
        string[] PolicyGroups { get; }
        string[] GetZoomPolicies(string policyGroup);
        Control GetControl(string policyGroup, string zoomPolicy, Font font, Size layoutSize);
        ZoomPolicy GetZoomPolicy(string policyGroup, string zoomPolicy);
        Size? GetDemoSize(string policyGroup, string zoomPolicy);
    }

    public abstract class ZoomPolicyProviderBase : IZoomPolicyProvider
    {
        internal const string Standard = "Standard";
        private string[] builtInZoomPolicy = new string[] {
            "ComboBoxZoomPolicy",
            "DataGridViewZoomPolicy",
            "FlowLayoutPanelZoomPolicy",
            "ListBoxZoomPolicy",
            "ListViewZoomPolicy",
            "MonthCalendarZoomPolicy",
            "PictureBoxZoomPolicy",
            "PropertyGridZoomPolicy",
            "SplitContainerZoomPolicy",
            "TableLayoutPanelZoomPolicy",
            "ToolStripZoomPolicy",
            "TreeViewZoomPolicy",
        };

        public abstract string[] PolicyGroups { get; }

        public virtual string[] GetZoomPolicies(string policyGroup)
        {
            return builtInZoomPolicy;
        }

        public virtual ZoomPolicy GetZoomPolicy(string policyGroup, string zoomPolicy)
        {
            return null;
        }

        public virtual string GetDescription(string policyGroup, string zoomPolicy) 
        {
            switch (zoomPolicy)
            {
                case "ComboBoxZoomPolicy":
                    return Properties.Resources.ZoomPolicy_Strd_ComboBox;
                case "DataGridViewZoomPolicy":
                    return Properties.Resources.ZoomPolicy_Strd_DataGridView;
                case "FlowLayoutPanelZoomPolicy":
                    return Properties.Resources.ZoomPolicy_Strd_FlowLayoutPanel;
                case "ListBoxZoomPolicy":
                    return Properties.Resources.ZoomPolicy_Strd_ListBox;
                case "ListViewZoomPolicy":
                    return Properties.Resources.ZoomPolicy_Strd_ListView;
                case "MonthCalendarZoomPolicy":
                    return Properties.Resources.ZoomPolicy_Strd_MonthCalendar;
                case "PictureBoxZoomPolicy":
                    return Properties.Resources.ZoomPolicy_Strd_PictureBox;
                case "PropertyGridZoomPolicy":
                    return Properties.Resources.ZoomPolicy_Strd_PropertyGrid;
                case "SplitContainerZoomPolicy":
                    return Properties.Resources.ZoomPolicy_Strd_SplitContainer;
                case "TableLayoutPanelZoomPolicy":
                    return Properties.Resources.ZoomPolicy_Strd_TableLayoutPanel;
                case "ToolStripZoomPolicy":
                    return Properties.Resources.ZoomPolicy_Strd_ToolStrip;
                case "TreeViewZoomPolicy":
                    return Properties.Resources.ZoomPolicy_Strd_TreeView;
                default:
                    break;
            }
            return "";
        }

        public virtual Size? GetDemoSize(string policyGroup, string zoomPolicy)
        {
            return null;
        }

        protected Font _font;
        protected Size _layoutSize;
        public virtual Control GetControl(string policyGroup, string zoomPolicy, Font font, Size layoutSize)
        {
            _font = font;
            _layoutSize = layoutSize;
            switch (zoomPolicy)
            {
                case "ComboBoxZoomPolicy":
                    return CreateComboBox();
                case "DataGridViewZoomPolicy":
                    return CreateDataGridView();
                case "ListBoxZoomPolicy":
                    return CreateListBox();
                case "TreeViewZoomPolicy":
                    return CreateTreeView();
                case "ListViewZoomPolicy":
                    return CreateListView();
                case "MonthCalendarZoomPolicy":
                    return CreateMonthCalendar();
                case "TableLayoutPanelZoomPolicy":
                    return CreateTableLayoutPanel();
                case "SplitContainerZoomPolicy":
                    return CreateSplitContainer();
                case "PictureBoxZoomPolicy":
                    return CreatePictureBox();
                case "ToolStripZoomPolicy":
                    return CreateToolStrip();
                case "PropertyGridZoomPolicy":
                    return CreatePropertyGrid();
                case "FlowLayoutPanelZoomPolicy":
                    return CreateFlowLayoutPanel();
            }
            return null;
        }
        
        internal static void PutControlInCenter(Control c, Size layoutSize)
        {
            c.Location = new Point(layoutSize.Width / 2 - c.Size.Width / 2, layoutSize.Height / 2 - c.Size.Height / 2);
        }


        internal static Control AddComments(Control control, string comments)
        {
            Panel panel = new Panel();
            panel.Dock = DockStyle.Fill;
            Label label = new Label();
            label.Text = comments;
            label.AutoSize = false;
            label.Location = new Point(10, 10);
            label.Size = new Size(panel.ClientSize.Width - 15, 50);
            label.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            panel.Controls.Add(label);
            panel.Controls.Add(control);
            return panel;

        }

        private Control CreateComboBox()
        {
            Panel panel = new Panel();
            panel.Dock = DockStyle.Fill;
            Label label = new Label() { Text = "Please select a part of text in combobox, then do zoom." };
            label.AutoSize = true;
            label.Location = new Point(10, 10);
            ComboBox comboBox = new ComboBox();
            PutControlInCenter(comboBox, _layoutSize);
            comboBox.DataSource = Enum.GetValues(typeof(DockStyle));
            panel.Controls.Add(label);
            panel.Controls.Add(comboBox);
            return panel;
        }

        private DataGridView CreateDataGridView()
        {
            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.RowCount = 10;
            dataGridView.ColumnCount = 5;
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    dataGridView[j, i].Value = i.ToString() + j;
                }
            }
            return dataGridView;
        }

        private ListBox CreateListBox()
        {
            ListBox listBox = new ListBox();
            listBox.FormattingEnabled = true;
            listBox.HorizontalScrollbar = true;
            listBox.Items.AddRange(new object[] {
            " column 1",
            " column 1",
            " column 1",
            " column 1",
            " column 1",
            " column 1",
            " column 1",
            " column 1",
            " column 1",
            " column 1",
            " column 1",
            " column 1",
            " column 1",
            " column 1",
            " column 1",
            " column 1",
            " column 1",
            " column 1",
            " column 1",
            " column 1",
            " column 1",
            " column 1",
            " column 1",
            " column 1",
            " column 2",
            " column 2",
            " column 2",
            " column 2",
            " column 2",
            " column 2",
            " column 2",
            " column 2",
            " column 2",
            " column 2",
            " column 2",
            });
            listBox.ColumnWidth = 50;
            listBox.MultiColumn = true;
            listBox.Dock = DockStyle.Fill;
            return listBox;
        }

        private TreeView CreateTreeView()
        {
            TreeView treeView = new TreeView();
            treeView.Size = new System.Drawing.Size(200, 150);
            PutControlInCenter(treeView, _layoutSize);
            treeView.ItemHeight = 20;
            treeView.Nodes.Add("Node1");
            treeView.Nodes.Add("Node2");
            treeView.Nodes.Add("Node3");
            treeView.Nodes.Add("Node4");
            treeView.Nodes.Add("Node5");
            return treeView;
        }

        private ListView CreateListView()
        {
            ListView listView = new ListView();
            listView.Dock = DockStyle.Fill;
            listView.View = View.Details;
            listView.GridLines = true;
            ListViewItem item1 = new ListViewItem("item1", 0);
            item1.Checked = true;
            item1.SubItems.Add("1");
            item1.SubItems.Add("2");
            item1.SubItems.Add("3");
            ListViewItem item2 = new ListViewItem("item2", 1);
            item2.SubItems.Add("4");
            item2.SubItems.Add("5");
            item2.SubItems.Add("6");
            ListViewItem item3 = new ListViewItem("item3", 0);
            item3.Font = _font;
            item3.Checked = true;
            item3.SubItems.Add("7");
            item3.SubItems.Add("8");
            item3.SubItems.Add("9");
            listView.Columns.Add("Item Column", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Column 2", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Column 3", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Column 4", -2, HorizontalAlignment.Center);
            listView.Items.AddRange(new ListViewItem[] { item1, item2, item3 });
            return listView;
        }

        private Control CreateMonthCalendar()
        {
            Panel panel = new Panel();
            panel.Location = new Point(43, 48);
            panel.BackColor = SystemColors.GradientActiveCaption;
            panel.Size = new System.Drawing.Size(245, 200);
            MonthCalendar monthCalendar = new MonthCalendar();
            monthCalendar.Location = new Point(13, 19);
            panel.Controls.Add(monthCalendar);
            return panel;
        }

        private TableLayoutPanel CreateTableLayoutPanel()
        {
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Size = new System.Drawing.Size(200, 150);
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle() { SizeType = SizeType.Absolute, Width = 100 });
            tableLayoutPanel.RowStyles.Add(new RowStyle() { SizeType = SizeType.Absolute, Height = 100 });
            tableLayoutPanel.Controls.Add(new Label() { Text = "If SizeType is Absolute, Styles' width and height will not change after disable default zoom policy.", AutoSize = true });
            PutControlInCenter(tableLayoutPanel, _layoutSize);
            return tableLayoutPanel;
        }

        private FlowLayoutPanel CreateFlowLayoutPanel()
        {
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Size = new System.Drawing.Size(253, 267);
            flowLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Controls.Add(new Button() { Size = new System.Drawing.Size(224, 93), Text = "Please zoom in then zoom out." });
            flowLayoutPanel.Controls.Add(new Button() { Size = new System.Drawing.Size(109, 93), Text = "Button2" });
            flowLayoutPanel.Controls.Add(new Button() { Size = new System.Drawing.Size(109, 93), Text = "Button3" });
            flowLayoutPanel.Controls.Add(new Button() { Size = new System.Drawing.Size(109, 93), Text = "Button4" });
            PutControlInCenter(flowLayoutPanel, _layoutSize);
            return flowLayoutPanel;
        }

        private SplitContainer CreateSplitContainer()
        {
            SplitContainer splitContainer = new SplitContainer();
            splitContainer.Orientation = Orientation.Horizontal;
            splitContainer.Size = new System.Drawing.Size(200, 150);
            PutControlInCenter(splitContainer, _layoutSize);
            splitContainer.SplitterDistance = 60;
            splitContainer.SplitterWidth = 5;
            splitContainer.BorderStyle = BorderStyle.FixedSingle;
            splitContainer.FixedPanel = FixedPanel.Panel1;
            Label label = new Label() { Text = "FixedPanel", };
            label.Location = new Point(3, 3);
            splitContainer.Panel1.Controls.Add(label);
            splitContainer.Panel1.BackColor = SystemColors.GradientActiveCaption;
            splitContainer.Panel2.BackColor = SystemColors.GradientInactiveCaption;
            return splitContainer;
        }

        private Control CreatePictureBox()
        {
            Panel panel = new Panel();
            panel.Dock = DockStyle.Fill;
            Label label = new Label() { Text = "PictureBox.SizeMode is Normal." };
            label.AutoSize = true;
            label.Location = new Point(10, 10);
            PictureBox pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox.Size = new Size(245, 147);
            PutControlInCenter(pictureBox, _layoutSize);
            pictureBox.Image = Properties.Resources.airplane1;
            panel.Controls.Add(label);
            panel.Controls.Add(pictureBox);
            return panel;
        }

        private ToolStrip CreateToolStrip()
        {
            ToolStrip toolStrip = new ToolStrip();

            ToolStripDropDownButton fileToolStripDropDownButton = new ToolStripDropDownButton();
            fileToolStripDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            fileToolStripDropDownButton.Text = "File";
            fileToolStripDropDownButton.Font = _font;
            fileToolStripDropDownButton.DropDownItems.Add("New");
            fileToolStripDropDownButton.DropDownItems.Add("Open");
            fileToolStripDropDownButton.DropDownItems.Add("Save");
            toolStrip.Items.Add(fileToolStripDropDownButton);
            toolStrip.Items.Add(new ToolStripLabel("Edit") { Font = _font });
            toolStrip.Items.Add(new ToolStripLabel("View") { Font = _font });
            toolStrip.Items.Add(new ToolStripLabel("Format") { Font = _font });
            toolStrip.Items.Add(new ToolStripLabel("Help") { Font = _font });
            toolStrip.Items.Add(new ToolStripLabel("Exit") { Font = _font });
            return toolStrip;
        }

        private Control CreatePropertyGrid()
        {
            Panel panel = new Panel();
            panel.Dock = DockStyle.Fill;
            Label label = new Label() { Text = "After zoom, you can try to click toolstrip's buttons in propertyGrid." };
            label.AutoSize = false;
            label.Height = 50;
            label.Width = 300;
            label.Location = new Point(10, 10);
            PropertyGrid propertyGrid = new PropertyGrid();
            propertyGrid.Size = new Size(150, 200);
            PutControlInCenter(propertyGrid, _layoutSize);
            //propertyGrid.SelectedObject = label1;
            panel.Controls.Add(label);
            panel.Controls.Add(propertyGrid);
            return panel;
        }
    }
}
