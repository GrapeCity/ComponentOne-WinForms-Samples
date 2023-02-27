namespace TouchDemo.TouchEvent
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
            this.C1TouchEventProvider1 = new C1.Win.TouchToolKit.C1TouchEventProvider();
            this.paintPanel1 = new TouchDemo.TouchEvent.ImagePanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rotateRadioButton = new System.Windows.Forms.RadioButton();
            this.defaultRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.paintPanel1);
            this.panel1.Location = new System.Drawing.Point(16, 101);
            this.panel1.Size = new System.Drawing.Size(690, 392);
            // 
            // C1TouchEventProvider1
            // 
            this.C1TouchEventProvider1.Tapped += new System.EventHandler<C1.Win.TouchToolKit.TappedEventArgs>(this.C1TouchEventProvider1_Tapped);
            this.C1TouchEventProvider1.ManipulationStarting += new System.EventHandler<C1.Win.TouchToolKit.ManipulationStartingEventArgs>(this.C1TouchEventProvider1_ManipulationStarting);
            this.C1TouchEventProvider1.ManipulationStarted += new System.EventHandler<C1.Win.TouchToolKit.ManipulationStartedEventArgs>(this.C1TouchEventProvider1_ManipulationStarted);
            this.C1TouchEventProvider1.ManipulationDelta += new System.EventHandler<C1.Win.TouchToolKit.ManipulationDeltaEventArgs>(this.C1TouchEventProvider1_ManipulationDelta);
            this.C1TouchEventProvider1.ManipulationInertiaStarting += new System.EventHandler<C1.Win.TouchToolKit.ManipulationInertiaStartingEventArgs>(this.C1TouchEventProvider1_ManipulationInertiaStarting);
            this.C1TouchEventProvider1.ManipulationCompleted += new System.EventHandler<C1.Win.TouchToolKit.ManipulationCompletedEventArgs>(this.C1TouchEventProvider1_ManipulationCompleted);
            // 
            // paintPanel1
            // 
            this.paintPanel1.ActiveImageIndex = -1;
            this.paintPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paintPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C1TouchEventProvider1.SetEnableTouchEvents(this.paintPanel1, true);
            this.paintPanel1.Location = new System.Drawing.Point(0, 56);
            this.paintPanel1.ManipulationPosition = new System.Drawing.Point(0, 0);
            this.paintPanel1.Name = "paintPanel1";
            this.paintPanel1.Size = new System.Drawing.Size(690, 336);
            this.paintPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rotateRadioButton);
            this.groupBox1.Controls.Add(this.defaultRadioButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 50);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gesture mode";
            // 
            // rotateRadioButton
            // 
            this.rotateRadioButton.AutoSize = true;
            this.rotateRadioButton.Location = new System.Drawing.Point(406, 19);
            this.rotateRadioButton.Name = "rotateRadioButton";
            this.rotateRadioButton.Size = new System.Drawing.Size(263, 27);
            this.rotateRadioButton.TabIndex = 1;
            this.rotateRadioButton.Text = "Rotate the image by one finger.";
            this.rotateRadioButton.UseVisualStyleBackColor = true;
            // 
            // defaultRadioButton
            // 
            this.defaultRadioButton.AutoSize = true;
            this.defaultRadioButton.Checked = true;
            this.defaultRadioButton.Location = new System.Drawing.Point(7, 19);
            this.defaultRadioButton.Name = "defaultRadioButton";
            this.defaultRadioButton.Size = new System.Drawing.Size(393, 27);
            this.defaultRadioButton.TabIndex = 0;
            this.defaultRadioButton.TabStop = true;
            this.defaultRadioButton.Text = "Move, zoom and rotate the image by two fingers.";
            this.defaultRadioButton.UseVisualStyleBackColor = true;
            this.defaultRadioButton.CheckedChanged += new System.EventHandler(this.ModeRadioButton_CheckedChanged);
            // 
            // TouchEventDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TouchEventDemo";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.TouchToolKit.C1TouchEventProvider C1TouchEventProvider1;
        private ImagePanel paintPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rotateRadioButton;
        private System.Windows.Forms.RadioButton defaultRadioButton;
    }
}
