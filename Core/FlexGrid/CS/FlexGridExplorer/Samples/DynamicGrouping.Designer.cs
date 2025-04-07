namespace FlexGridExplorer.Samples
{
    partial class DynamicGrouping
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
            flexGrid = new C1.Win.FlexGrid.C1FlexGrid();
            panel1 = new System.Windows.Forms.Panel();
            c1CheckBox1 = new C1.Win.Input.C1CheckBox();
            cmbGroup = new C1.Win.Input.C1ComboBox();
            Label1 = new C1.Win.Input.C1Label();
            ((System.ComponentModel.ISupportInitialize)flexGrid).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1CheckBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbGroup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Label1).BeginInit();
            SuspendLayout();
            // 
            // flexGrid
            // 
            flexGrid.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            flexGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            flexGrid.Location = new System.Drawing.Point(0, 61);
            flexGrid.Name = "flexGrid";
            flexGrid.Size = new System.Drawing.Size(805, 722);
            flexGrid.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(c1CheckBox1);
            panel1.Controls.Add(cmbGroup);
            panel1.Controls.Add(Label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(805, 61);
            panel1.TabIndex = 1;
            // 
            // c1CheckBox1
            // 
            c1CheckBox1.AutoSize = true;
            c1CheckBox1.Location = new System.Drawing.Point(274, 18);
            c1CheckBox1.Name = "c1CheckBox1";
            c1CheckBox1.Size = new System.Drawing.Size(182, 22);
            c1CheckBox1.TabIndex = 2;
            c1CheckBox1.Text = "Hide Grouped Column";
            c1CheckBox1.CheckedChanged += c1CheckBox1_CheckedChanged;
            // 
            // cmbGroup
            // 
            cmbGroup.Location = new System.Drawing.Point(88, 14);
            cmbGroup.Name = "cmbGroup";
            cmbGroup.Size = new System.Drawing.Size(166, 28);
            cmbGroup.TabIndex = 1;
            cmbGroup.Value = "";
            cmbGroup.SelectedItemChanged += CmbGroup_SelectedItemChanged;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new System.Drawing.Point(3, 14);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(79, 26);
            Label1.TabIndex = 0;
            Label1.Text = "Group By:";
            // 
            // DynamicGrouping
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(flexGrid);
            Controls.Add(panel1);
            Name = "DynamicGrouping";
            Size = new System.Drawing.Size(805, 783);
            ((System.ComponentModel.ISupportInitialize)flexGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)c1CheckBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbGroup).EndInit();
            ((System.ComponentModel.ISupportInitialize)Label1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGrid flexGrid;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.Input.C1ComboBox cmbGroup;
        private C1.Win.Input.C1Label Label1;
        private C1.Win.Input.C1CheckBox c1CheckBox1;
    }
}
