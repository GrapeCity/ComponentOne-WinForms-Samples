using BaseExplorer.Core;

namespace BaseExplorer.Components
{
    partial class StackTreeControl
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
            pnlMain = new System.Windows.Forms.FlowLayoutPanel();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.AutoScroll = true;
            pnlMain.BackColor = System.Drawing.Color.FromArgb(243, 242, 242);
            pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            pnlMain.Location = new System.Drawing.Point(0, 0);
            pnlMain.Margin = new System.Windows.Forms.Padding(0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new System.Drawing.Size(360, 775);
            pnlMain.TabIndex = 0;
            pnlMain.WrapContents = false;
            // 
            // StackTreeControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(243, 242, 242);
            Controls.Add(pnlMain);
            Margin = new System.Windows.Forms.Padding(0);
            Name = "StackTreeControl";
            Size = new System.Drawing.Size(360, 775);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlMain;

    }
}
