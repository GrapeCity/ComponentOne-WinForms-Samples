namespace TouchDemo.C1ZoomPages.Help_Forms
{
    partial class ControlBarUserControl03
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
            this.components = new System.ComponentModel.Container();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.C1ZoomCommandProvider1 = new C1.Win.TouchToolKit.C1ZoomCommandProvider(this.components);
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(143, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 33);
            this.button4.TabIndex = 1;
            this.button4.Text = "Close Form";
            this.toolTip1.SetToolTip(this.button4, "SelectPreviousControl");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(8, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 33);
            this.button5.TabIndex = 2;
            this.button5.Text = "Full screen";
            this.toolTip1.SetToolTip(this.button5, "FullScreen");
            this.button5.UseVisualStyleBackColor = true;
            this.C1ZoomCommandProvider1.SetZoomCommands(this.button5, C1.Win.TouchToolKit.ZoomCommands.SwitchFullScreen);
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // C1ZoomCommandProvider1
            // 
            this.C1ZoomCommandProvider1.Target = this;
            // 
            // ControlBarUserControl03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Name = "ControlBarUserControl03";
            this.Size = new System.Drawing.Size(272, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolTip toolTip1;
        private C1.Win.TouchToolKit.C1ZoomCommandProvider C1ZoomCommandProvider1;
    }
}
