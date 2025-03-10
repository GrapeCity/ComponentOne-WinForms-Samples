namespace ControlExplorer.Controls
{
    partial class DemoViewer
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
            pnlDemo = new System.Windows.Forms.Panel();
            pnlHeader = new System.Windows.Forms.Panel();
            SuspendLayout();
            // 
            // pnlDemo
            // 
            pnlDemo.BackColor = System.Drawing.Color.White;
            pnlDemo.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlDemo.Location = new System.Drawing.Point(0, 192);
            pnlDemo.Name = "pnlDemo";
            pnlDemo.Padding = new System.Windows.Forms.Padding(5);
            pnlDemo.Size = new System.Drawing.Size(1112, 444);
            pnlDemo.TabIndex = 1;
            // 
            // pnlHeader
            // 
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(1112, 192);
            pnlHeader.TabIndex = 0;
            // 
            // DemoViewer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            Controls.Add(pnlDemo);
            Controls.Add(pnlHeader);
            Name = "DemoViewer";
            Size = new System.Drawing.Size(1112, 636);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel pnlDemo;
        private System.Windows.Forms.Panel pnlHeader;
    }
}
