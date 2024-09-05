namespace TouchToolkitExplorer.TouchEvent
{
    partial class TouchEventDemo
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
            C1TouchEventProvider1 = new C1.Win.TouchToolKit.C1TouchEventProvider();
            paintPanel1 = new ImagePanel();
            groupBox1 = new System.Windows.Forms.GroupBox();
            rotateRadioButton = new System.Windows.Forms.RadioButton();
            defaultRadioButton = new System.Windows.Forms.RadioButton();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(paintPanel1);
            // 
            // C1TouchEventProvider1
            // 
            C1TouchEventProvider1.Tapped += C1TouchEventProvider1_Tapped;
            C1TouchEventProvider1.ManipulationStarting += C1TouchEventProvider1_ManipulationStarting;
            C1TouchEventProvider1.ManipulationStarted += C1TouchEventProvider1_ManipulationStarted;
            C1TouchEventProvider1.ManipulationDelta += C1TouchEventProvider1_ManipulationDelta;
            C1TouchEventProvider1.ManipulationInertiaStarting += C1TouchEventProvider1_ManipulationInertiaStarting;
            C1TouchEventProvider1.ManipulationCompleted += C1TouchEventProvider1_ManipulationCompleted;
            // 
            // paintPanel1
            // 
            paintPanel1.ActiveImageIndex = -1;
            paintPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            paintPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            C1TouchEventProvider1.SetEnableTouchEvents(paintPanel1, true);
            paintPanel1.Location = new System.Drawing.Point(0, 56);
            paintPanel1.ManipulationPosition = new System.Drawing.Point(0, 0);
            paintPanel1.Name = "paintPanel1";
            paintPanel1.Size = new System.Drawing.Size(724, 443);
            paintPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(rotateRadioButton);
            groupBox1.Controls.Add(defaultRadioButton);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(724, 89);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gesture mode";
            // 
            // rotateRadioButton
            // 
            rotateRadioButton.AutoSize = true;
            rotateRadioButton.Location = new System.Drawing.Point(431, 30);
            rotateRadioButton.Name = "rotateRadioButton";
            rotateRadioButton.Size = new System.Drawing.Size(287, 29);
            rotateRadioButton.TabIndex = 1;
            rotateRadioButton.Text = "Rotate the image by one finger.";
            rotateRadioButton.UseVisualStyleBackColor = true;
            // 
            // defaultRadioButton
            // 
            defaultRadioButton.AutoSize = true;
            defaultRadioButton.Checked = true;
            defaultRadioButton.Location = new System.Drawing.Point(0, 30);
            defaultRadioButton.Name = "defaultRadioButton";
            defaultRadioButton.Size = new System.Drawing.Size(431, 29);
            defaultRadioButton.TabIndex = 0;
            defaultRadioButton.TabStop = true;
            defaultRadioButton.Text = "Move, zoom and rotate the image by two fingers.";
            defaultRadioButton.UseVisualStyleBackColor = true;
            defaultRadioButton.CheckedChanged += ModeRadioButton_CheckedChanged;
            // 
            // TouchEventDemo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Name = "TouchEventDemo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private C1.Win.TouchToolKit.C1TouchEventProvider C1TouchEventProvider1;
        private ImagePanel paintPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rotateRadioButton;
        private System.Windows.Forms.RadioButton defaultRadioButton;
    }
}
