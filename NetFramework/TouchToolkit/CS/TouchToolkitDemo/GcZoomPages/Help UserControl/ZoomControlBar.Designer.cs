namespace ClickOnceDemo.C1ZoomPages.Help_Forms
{
    partial class ControlBarUserControl02
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.myTrackBar1 = new ClickOnceDemo.C1ZoomPages.Help_Forms.MyTrackBar();
            this.C1ZoomCommandProvider1 = new C1.Win.TouchToolKit.C1ZoomCommandProvider(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(101, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "-";
            this.toolTip1.SetToolTip(this.button1, "ZoomOut");
            this.button1.UseVisualStyleBackColor = false;
            this.C1ZoomCommandProvider1.SetZoomCommands(this.button1, C1.Win.TouchToolKit.ZoomCommands.ZoomOut);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(101, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "+";
            this.toolTip1.SetToolTip(this.button2, "ZoomIn");
            this.button2.UseVisualStyleBackColor = false;
            this.C1ZoomCommandProvider1.SetZoomCommands(this.button2, C1.Win.TouchToolKit.ZoomCommands.ZoomIn);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Wingdings 3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(101, 129);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 37);
            this.button4.TabIndex = 5;
            this.button4.Text = "";
            this.toolTip1.SetToolTip(this.button4, "ScrollDown");
            this.button4.UseVisualStyleBackColor = false;
            this.C1ZoomCommandProvider1.SetZoomCommands(this.button4, C1.Win.TouchToolKit.ZoomCommands.ScrollDown);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 3;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Wingdings 3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(147, 87);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 37);
            this.button5.TabIndex = 6;
            this.button5.Text = "";
            this.toolTip1.SetToolTip(this.button5, "ScrollRight");
            this.button5.UseVisualStyleBackColor = false;
            this.C1ZoomCommandProvider1.SetZoomCommands(this.button5, C1.Win.TouchToolKit.ZoomCommands.ScrollRight);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 3;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Wingdings 3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(55, 87);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 37);
            this.button6.TabIndex = 7;
            this.button6.Text = "";
            this.toolTip1.SetToolTip(this.button6, "ScrollLeft");
            this.button6.UseVisualStyleBackColor = false;
            this.C1ZoomCommandProvider1.SetZoomCommands(this.button6, C1.Win.TouchToolKit.ZoomCommands.ScrollLeft);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 3;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Wingdings 3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(101, 44);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 37);
            this.button7.TabIndex = 8;
            this.button7.Text = "";
            this.toolTip1.SetToolTip(this.button7, "ScrollUp");
            this.button7.UseVisualStyleBackColor = false;
            this.C1ZoomCommandProvider1.SetZoomCommands(this.button7, C1.Win.TouchToolKit.ZoomCommands.ScrollUp);
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // myTrackBar1
            // 
            this.myTrackBar1.Location = new System.Drawing.Point(91, 215);
            this.myTrackBar1.MaxValue = 4F;
            this.myTrackBar1.MinValue = 1F;
            this.myTrackBar1.Name = "myTrackBar1";
            this.myTrackBar1.Size = new System.Drawing.Size(60, 205);
            this.myTrackBar1.TabIndex = 9;
            this.myTrackBar1.Value = 1F;
            // 
            // C1ZoomCommandProvider1
            // 
            this.C1ZoomCommandProvider1.Target = this;
            // 
            // ControlBarUserControl02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myTrackBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Name = "ControlBarUserControl02";
            this.Size = new System.Drawing.Size(238, 494);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private MyTrackBar myTrackBar1;
        private C1.Win.TouchToolKit.C1ZoomCommandProvider C1ZoomCommandProvider1;
    }
}
