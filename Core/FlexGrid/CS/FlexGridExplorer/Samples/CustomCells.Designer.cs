namespace FlexGridExplorer.Samples
{
    partial class CustomCells
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
            components = new System.ComponentModel.Container();
            _timer = new System.Windows.Forms.Timer(components);
            _flex = new C1.Win.FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)_flex).BeginInit();
            SuspendLayout();
            // 
            // _timer
            // 
            _timer.Enabled = true;
            _timer.Tick += _timer_Tick;
            // 
            // _flex
            // 
            _flex.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            _flex.Dock = System.Windows.Forms.DockStyle.Fill;
            _flex.Location = new System.Drawing.Point(0, 0);
            _flex.Name = "_flex";
            _flex.Size = new System.Drawing.Size(441, 468);
            _flex.TabIndex = 0;
            _flex.OwnerDrawCell += _flex_OwnerDrawCell;
            _flex.DoubleClick += _flex_DoubleClick;
            // 
            // CustomCells
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(_flex);
            Name = "CustomCells";
            Size = new System.Drawing.Size(441, 468);
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)_flex).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer _timer;
        private C1.Win.FlexGrid.C1FlexGrid _flex;
    }
}
