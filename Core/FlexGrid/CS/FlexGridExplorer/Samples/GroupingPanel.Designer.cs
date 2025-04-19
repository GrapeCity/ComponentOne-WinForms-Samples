namespace FlexGridExplorer.Samples
{
    partial class GroupingPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupingPanel));
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            groupPanel = new C1.Win.FlexGrid.C1FlexGridGroupPanel();
            flexGrid = new C1.Win.FlexGrid.C1FlexGrid();
            panel1 = new System.Windows.Forms.Panel();
            clearCb = new C1.Win.Input.C1CheckBox();
            hideCb = new C1.Win.Input.C1CheckBox();
            expandCb = new C1.Win.Input.C1CheckBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)flexGrid).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clearCb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hideCb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)expandCb).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(groupPanel, 0, 1);
            tableLayoutPanel1.Controls.Add(flexGrid, 0, 2);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(698, 600);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupPanel
            // 
            groupPanel.AutoSize = true;
            groupPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            groupPanel.FlexGrid = flexGrid;
            groupPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            groupPanel.Location = new System.Drawing.Point(3, 38);
            groupPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 7);
            groupPanel.Name = "groupPanel";
            groupPanel.Size = new System.Drawing.Size(692, 29);
            groupPanel.TabIndex = 3;
            groupPanel.Text = "Drag a column here to group by that column";
            // 
            // flexGrid
            // 
            flexGrid.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            flexGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            flexGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            flexGrid.Location = new System.Drawing.Point(3, 77);
            flexGrid.Name = "flexGrid";
            flexGrid.Rows.DefaultSize = 30;
            flexGrid.ShowThemedHeaders = C1.Win.FlexGrid.ShowThemedHeadersEnum.None;
            flexGrid.Size = new System.Drawing.Size(692, 520);
            flexGrid.StyleInfo = resources.GetString("flexGrid.StyleInfo");
            flexGrid.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(clearCb);
            panel1.Controls.Add(hideCb);
            panel1.Controls.Add(expandCb);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(692, 29);
            panel1.TabIndex = 5;
            // 
            // clearCb
            // 
            clearCb.AutoSize = true;
            clearCb.Checked = true;
            clearCb.CheckState = System.Windows.Forms.CheckState.Checked;
            clearCb.Location = new System.Drawing.Point(394, 4);
            clearCb.Name = "clearCb";
            clearCb.Size = new System.Drawing.Size(159, 22);
            clearCb.TabIndex = 2;
            clearCb.Text = "Show Clear  Button";
            clearCb.Value = true;
            clearCb.CheckedChanged += clearCb_CheckedChanged;
            // 
            // hideCb
            // 
            hideCb.AutoSize = true;
            hideCb.Location = new System.Drawing.Point(200, 4);
            hideCb.Name = "hideCb";
            hideCb.Size = new System.Drawing.Size(188, 22);
            hideCb.TabIndex = 1;
            hideCb.Text = "Hide Grouped Columns";
            hideCb.CheckedChanged += HideCb_CheckedChanged;
            // 
            // expandCb
            // 
            expandCb.AutoSize = true;
            expandCb.Checked = true;
            expandCb.CheckState = System.Windows.Forms.CheckState.Checked;
            expandCb.Location = new System.Drawing.Point(3, 4);
            expandCb.Name = "expandCb";
            expandCb.Size = new System.Drawing.Size(191, 22);
            expandCb.TabIndex = 0;
            expandCb.Text = "Auto Expand All Groups";
            expandCb.Value = true;
            expandCb.CheckedChanged += expandCb_CheckedChanged;
            // 
            // GroupingPanel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "GroupingPanel";
            Size = new System.Drawing.Size(698, 600);
            Load += GroupPanel_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)flexGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clearCb).EndInit();
            ((System.ComponentModel.ISupportInitialize)hideCb).EndInit();
            ((System.ComponentModel.ISupportInitialize)expandCb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.FlexGrid.C1FlexGridGroupPanel groupPanel;
        private C1.Win.FlexGrid.C1FlexGrid flexGrid;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.Input.C1CheckBox clearCb;
        private C1.Win.Input.C1CheckBox hideCb;
        private C1.Win.Input.C1CheckBox expandCb;
    }
}
