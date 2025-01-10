namespace ControlExplorer.Controls
{
    partial class MenuItemControl
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
            pnlIndicatorWrapper = new System.Windows.Forms.Panel();
            pnlIndicator = new System.Windows.Forms.Panel();
            pnlMenuWrapper = new CustomPanel();
            lblMenuItem = new System.Windows.Forms.Label();
            pnlIndicatorWrapper.SuspendLayout();
            pnlMenuWrapper.SuspendLayout();
            SuspendLayout();
            // 
            // pnlIndicatorWrapper
            // 
            pnlIndicatorWrapper.Controls.Add(pnlIndicator);
            pnlIndicatorWrapper.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlIndicatorWrapper.Location = new System.Drawing.Point(0, 105);
            pnlIndicatorWrapper.Name = "pnlIndicatorWrapper";
            pnlIndicatorWrapper.Size = new System.Drawing.Size(365, 55);
            pnlIndicatorWrapper.TabIndex = 0;
            // 
            // pnlIndicator
            // 
            pnlIndicator.Location = new System.Drawing.Point(88, 13);
            pnlIndicator.Name = "pnlIndicator";
            pnlIndicator.Size = new System.Drawing.Size(143, 24);
            pnlIndicator.TabIndex = 0;
            // 
            // pnlMenuWrapper
            // 
            pnlMenuWrapper.Controls.Add(lblMenuItem);
            pnlMenuWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMenuWrapper.Location = new System.Drawing.Point(0, 0);
            pnlMenuWrapper.Name = "pnlMenuWrapper";
            pnlMenuWrapper.Radius = 4;
            pnlMenuWrapper.Size = new System.Drawing.Size(365, 105);
            pnlMenuWrapper.TabIndex = 1;
            // 
            // lblMenuItem
            // 
            lblMenuItem.Dock = System.Windows.Forms.DockStyle.Fill;
            lblMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblMenuItem.Location = new System.Drawing.Point(0, 0);
            lblMenuItem.Name = "lblMenuItem";
            lblMenuItem.Size = new System.Drawing.Size(365, 105);
            lblMenuItem.TabIndex = 0;
            lblMenuItem.Text = "label1";
            lblMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuItemControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(pnlMenuWrapper);
            Controls.Add(pnlIndicatorWrapper);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "MenuItemControl";
            Size = new System.Drawing.Size(365, 160);
            pnlIndicatorWrapper.ResumeLayout(false);
            pnlMenuWrapper.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlIndicatorWrapper;
        private CustomPanel pnlMenuWrapper;
        private System.Windows.Forms.Label lblMenuItem;
        private System.Windows.Forms.Panel pnlIndicator;
    }
}
