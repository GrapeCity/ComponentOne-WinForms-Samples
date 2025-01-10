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
            pnlDemo.Location = new System.Drawing.Point(0, 230);
            pnlDemo.Margin = new System.Windows.Forms.Padding(4);
            pnlDemo.Name = "pnlDemo";
            pnlDemo.Padding = new System.Windows.Forms.Padding(6);
            pnlDemo.Size = new System.Drawing.Size(1334, 529);
            pnlDemo.TabIndex = 1;
            // 
            // pnlHeader
            // 
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(1334, 230);
            pnlHeader.TabIndex = 0;
            // 
            // DemoViewer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            Controls.Add(pnlDemo);
            Controls.Add(pnlHeader);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "DemoViewer";
            Size = new System.Drawing.Size(1334, 759);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel pnlDemo;
        private System.Windows.Forms.Panel pnlHeader;
    }
}
