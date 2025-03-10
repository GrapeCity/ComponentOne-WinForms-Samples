using C1.Win.FlexGrid;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FlexGridExplorer.Samples
{
    partial class MergingControl
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
            tsMenu = new ToolStrip();
            mergingFlexGrid = new C1FlexGrid();
            propertiesTsLb = new ToolStripLabel();
            propertiesTsCbox = new ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)mergingFlexGrid).BeginInit();
            tsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // tsMenu
            // 
            tsMenu.GripStyle = ToolStripGripStyle.Hidden;
            tsMenu.Items.AddRange(new ToolStripItem[] { propertiesTsLb, propertiesTsCbox });
            tsMenu.Location = new Point(0, 0);
            tsMenu.Name = "tsMenu";
            tsMenu.Size = new Size(952, 25);
            tsMenu.TabIndex = 2;
            tsMenu.Text = "Properties";
            // 
            // propertiesTsLb
            // 
            propertiesTsLb.Name = "propertiesTsLb";
            propertiesTsLb.Size = new Size(88, 22);
            propertiesTsLb.Text = "Allow Merging:";
            // 
            // propertiesTsCbox
            // 
            propertiesTsCbox.Name = "propertiesTsCbox";
            propertiesTsCbox.Size = new Size(121, 25);
            propertiesTsCbox.SelectedIndexChanged += propertiesTsCbox_SelectedIndexChanged;
            // 
            // mergingFlexGrid
            // 
            mergingFlexGrid.ColumnInfo = "10,1,0,0,0,100,Columns:";
            mergingFlexGrid.Dock = DockStyle.Fill;
            mergingFlexGrid.Location = new Point(0, 0);
            mergingFlexGrid.Margin = new Padding(2);
            mergingFlexGrid.Name = "mergingFlexGrid";
            mergingFlexGrid.Size = new Size(952, 567);
            mergingFlexGrid.TabIndex = 0;
            // 
            // MergingControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mergingFlexGrid);
            Controls.Add(tsMenu);
            Margin = new Padding(2);
            Name = "MergingControl";
            Size = new Size(952, 567);
            ((System.ComponentModel.ISupportInitialize)mergingFlexGrid).EndInit();
            tsMenu.ResumeLayout(false);
            tsMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tsMenu;
        private ToolStripLabel propertiesTsLb;
        protected ToolStripComboBox propertiesTsCbox;
        protected C1.Win.FlexGrid.C1FlexGrid mergingFlexGrid;
    }
}
