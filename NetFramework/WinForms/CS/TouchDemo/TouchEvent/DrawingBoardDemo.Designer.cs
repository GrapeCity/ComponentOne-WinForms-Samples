namespace TouchToolKitDemo.TouchEvent
{
    partial class DrawingBoardDemo
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
            this.paintPanel = new TouchToolKitDemo.TouchEvent.PaintPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.drawSizePanel1 = new TouchToolKitDemo.TouchEvent.DrawSizePanel();
            this.drawModePanel1 = new TouchToolKitDemo.TouchEvent.DrawModePanel();
            this.colorPanel1 = new TouchToolKitDemo.TouchEvent.ColorPanel();
            this.C1TouchEventProvider1 = new C1.Win.TouchToolKit.C1TouchEventProvider();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.paintPanel);
            this.C1TouchEventProvider1.SetEnableTouchEvents(this.panel1, true);
            // 
            // paintPanel
            // 
            this.paintPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paintPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paintPanel.Location = new System.Drawing.Point(1, 73);
            this.paintPanel.Name = "paintPanel";
            this.paintPanel.Owner = null;
            this.paintPanel.Size = new System.Drawing.Size(689, 296);
            this.paintPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.drawSizePanel1);
            this.panel2.Controls.Add(this.drawModePanel1);
            this.panel2.Controls.Add(this.colorPanel1);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 72);
            this.panel2.TabIndex = 0;
            // 
            // drawSizePanel1
            // 
            this.drawSizePanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawSizePanel1.DrawSize = 0;
            this.drawSizePanel1.Location = new System.Drawing.Point(587, -1);
            this.drawSizePanel1.Name = "drawSizePanel1";
            this.drawSizePanel1.Owner = null;
            this.drawSizePanel1.Size = new System.Drawing.Size(101, 72);
            this.drawSizePanel1.TabIndex = 6;
            // 
            // drawModePanel1
            // 
            this.drawModePanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawModePanel1.DrawMode = TouchToolKitDemo.TouchEvent.DrawMode.Draw;
            this.drawModePanel1.Location = new System.Drawing.Point(-1, -1);
            this.drawModePanel1.Name = "drawModePanel1";
            this.drawModePanel1.Owner = null;
            this.drawModePanel1.Size = new System.Drawing.Size(71, 72);
            this.drawModePanel1.TabIndex = 5;
            // 
            // colorPanel1
            // 
            this.colorPanel1.BackgroundColor = System.Drawing.Color.White;
            this.colorPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel1.ForegroundColor = System.Drawing.Color.Black;
            this.colorPanel1.Location = new System.Drawing.Point(69, -1);
            this.colorPanel1.Name = "colorPanel1";
            this.colorPanel1.Size = new System.Drawing.Size(519, 72);
            this.colorPanel1.TabIndex = 3;
            // 
            // C1TouchEventProvider1
            // 
            this.C1TouchEventProvider1.PointerMoved += new System.EventHandler<C1.Win.TouchToolKit.PointerEventArgs>(this.C1TouchEventProvider1_PointerMoved);
            this.C1TouchEventProvider1.PointerPressed += new System.EventHandler<C1.Win.TouchToolKit.PointerEventArgs>(this.C1TouchEventProvider1_PointerPressed);
            this.C1TouchEventProvider1.PointerReleased += new System.EventHandler<C1.Win.TouchToolKit.PointerEventArgs>(this.C1TouchEventProvider1_PointerReleased);
            this.C1TouchEventProvider1.ManipulationStarting += new System.EventHandler<C1.Win.TouchToolKit.ManipulationStartingEventArgs>(this.C1TouchEventProvider1_ManipulationStarting);
            this.C1TouchEventProvider1.ManipulationStarted += new System.EventHandler<C1.Win.TouchToolKit.ManipulationStartedEventArgs>(this.C1TouchEventProvider1_ManipulationStarted);
            this.C1TouchEventProvider1.ManipulationDelta += new System.EventHandler<C1.Win.TouchToolKit.ManipulationDeltaEventArgs>(this.C1TouchEventProvider1_ManipulationDelta);
            this.C1TouchEventProvider1.ManipulationInertiaStarting += new System.EventHandler<C1.Win.TouchToolKit.ManipulationInertiaStartingEventArgs>(this.C1TouchEventProvider1_ManipulationInertiaStarting);
            this.C1TouchEventProvider1.ManipulationCompleted += new System.EventHandler<C1.Win.TouchToolKit.ManipulationCompletedEventArgs>(this.C1TouchEventProvider1_ManipulationCompleted);
            // 
            // DrawingBoardDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "DrawingBoardDemo";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PaintPanel paintPanel;
        private C1.Win.TouchToolKit.C1TouchEventProvider C1TouchEventProvider1;
        private ColorPanel colorPanel1;
        private System.Windows.Forms.Panel panel2;
        private DrawModePanel drawModePanel1;
        private DrawSizePanel drawSizePanel1;
    }
}
