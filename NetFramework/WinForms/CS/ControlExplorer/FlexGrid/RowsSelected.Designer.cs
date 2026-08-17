
namespace ControlExplorer.FlexGrid
{
    partial class RowsSelected
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RowsSelected));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslSelStats = new System.Windows.Forms.ToolStripLabel();
            this.c1FlexGridRowsSelected = new C1.Win.FlexGrid.C1FlexGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.c1ComboBoxSelMode = new C1.Win.C1Input.C1ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridRowsSelected)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBoxSelMode)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.ColumnInfo = resources.GetString("c1FlexGrid1.ColumnInfo");
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 43);
            this.c1FlexGrid1.Rows.Count = 2156;
            this.c1FlexGrid1.Rows.DefaultSize = 22;
            this.c1FlexGrid1.Size = new System.Drawing.Size(944, 714);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslSelStats});
            this.toolStrip1.Location = new System.Drawing.Point(0, 757);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1113, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslSelStats
            // 
            this.tslSelStats.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslSelStats.Name = "tslSelStats";
            this.tslSelStats.Size = new System.Drawing.Size(59, 22);
            this.tslSelStats.Text = "tslSelStats";
            // 
            // c1FlexGridRowsSelected
            // 
            this.c1FlexGridRowsSelected.BackColor = System.Drawing.Color.White;
            this.c1FlexGridRowsSelected.ColumnInfo = "1,0,0,0,0,-1,Columns:0{Name:\"colRowsSelected\";Caption:\"Rows.Selected:\";AllowDragg" +
    "ing:False;AllowResizing:False;AllowEditing:False;}\t";
            this.c1FlexGridRowsSelected.Dock = System.Windows.Forms.DockStyle.Right;
            this.c1FlexGridRowsSelected.ExtendLastCol = true;
            this.c1FlexGridRowsSelected.FocusRect = C1.Win.FlexGrid.FocusRectEnum.Background;
            this.c1FlexGridRowsSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.c1FlexGridRowsSelected.IconsStyle = C1.Win.FlexGrid.IconsStyle.Office365;
            this.c1FlexGridRowsSelected.Location = new System.Drawing.Point(944, 43);
            this.c1FlexGridRowsSelected.MarqueeStyle.BackgroundPadding = new System.Windows.Forms.Padding(1);
            this.c1FlexGridRowsSelected.MarqueeStyle.BackgroundPaddingColor = System.Drawing.Color.White;
            this.c1FlexGridRowsSelected.MarqueeStyle.BorderAlign = C1.Win.FlexGrid.BorderAlign.Outside;
            this.c1FlexGridRowsSelected.MarqueeStyle.BorderMode = C1.Win.FlexGrid.MarqueeBorderMode.CellRange;
            this.c1FlexGridRowsSelected.MarqueeStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(132)))), ((int)(((byte)(72)))));
            this.c1FlexGridRowsSelected.MarqueeStyle.Width = 2;
            this.c1FlexGridRowsSelected.Name = "c1FlexGridRowsSelected";
            this.c1FlexGridRowsSelected.Rows.Count = 1;
            this.c1FlexGridRowsSelected.Size = new System.Drawing.Size(169, 714);
            this.c1FlexGridRowsSelected.StyleInfo = resources.GetString("c1FlexGridRowsSelected.StyleInfo");
            this.c1FlexGridRowsSelected.TabIndex = 0;
            this.c1FlexGridRowsSelected.Tree.Indent = 25;
            this.c1FlexGridRowsSelected.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.c1ComboBoxSelMode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 43);
            this.panel1.TabIndex = 2;
            // 
            // c1ComboBoxSelMode
            // 
            this.c1ComboBoxSelMode.AllowSpinLoop = false;
            this.c1ComboBoxSelMode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.c1ComboBoxSelMode.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.c1ComboBoxSelMode.GapHeight = 0;
            this.c1ComboBoxSelMode.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1ComboBoxSelMode.Location = new System.Drawing.Point(12, 12);
            this.c1ComboBoxSelMode.Name = "c1ComboBoxSelMode";
            this.c1ComboBoxSelMode.Size = new System.Drawing.Size(105, 18);
            this.c1ComboBoxSelMode.TabIndex = 0;
            this.c1ComboBoxSelMode.Tag = null;
            this.c1ComboBoxSelMode.SelectedIndexChanged += new System.EventHandler(this.c1ComboBoxSelMode_SelectedIndexChanged);
            // 
            // RowsSelected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 782);
            this.Controls.Add(this.c1FlexGridRowsSelected);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "RowsSelected";
            this.Text = "SelectionStatistics";
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.c1FlexGridRowsSelected, 0);
            this.Controls.SetChildIndex(this.c1FlexGrid1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridRowsSelected)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBoxSelMode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslSelStats;
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGridRowsSelected;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1Input.C1ComboBox c1ComboBoxSelMode;
    }
}