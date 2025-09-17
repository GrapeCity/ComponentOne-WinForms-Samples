namespace ContextMenu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            flexGridEx1 = new FlexGridEx();
            ((System.ComponentModel.ISupportInitialize)flexGridEx1).BeginInit();
            SuspendLayout();
            // 
            // flexGridEx1
            // 
            flexGridEx1.ColumnContextMenuEnabled = true;
            flexGridEx1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            flexGridEx1.Dock = DockStyle.Fill;
            flexGridEx1.KeyActionTab = C1.Win.FlexGrid.KeyActionEnum.MoveAcross;
            flexGridEx1.Location = new Point(0, 0);
            flexGridEx1.Name = "flexGridEx1";
            flexGridEx1.Size = new Size(1436, 976);
            flexGridEx1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1436, 976);
            Controls.Add(flexGridEx1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "FlexGrid Context Menu";
            ((System.ComponentModel.ISupportInitialize)flexGridEx1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlexGridEx flexGridEx1;
    }
}
