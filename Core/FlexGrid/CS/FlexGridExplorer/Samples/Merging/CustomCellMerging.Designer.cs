using System.Drawing;
using System.Windows.Forms;

namespace FlexGridExplorer.Samples
{
    partial class CustomCellMerging
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
            _flex = new FlexTVGuide();
            ((System.ComponentModel.ISupportInitialize)_flex).BeginInit();
            SuspendLayout();
            // 
            // _flex
            // 
            _flex.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            _flex.ColumnInfo = "10,1,0,0,0,85,Columns:";
            _flex.Dock = DockStyle.Fill;
            _flex.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw;
            _flex.Location = new Point(0, 0);
            _flex.Name = "_flex";
            _flex.Rows.DefaultSize = 22;
            _flex.Size = new Size(1258, 842);
            _flex.TabIndex = 0;
            _flex.OwnerDrawCell += _flex_OwnerDrawCell;
            // 
            // CustomCellMerging
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_flex);
            Name = "CustomCellMerging";
            Size = new Size(1258, 842);
            Load += CustomCellMerging_Load;
            ((System.ComponentModel.ISupportInitialize)_flex).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlexTVGuide _flex;
    }
}
