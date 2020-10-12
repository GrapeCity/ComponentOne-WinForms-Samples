namespace NewIn2015v2
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.c1RibbonPreview1 = new C1.Win.C1RibbonPreview.C1RibbonPreview();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.c1Report1 = new C1.C1Report.C1Report();
            ((System.ComponentModel.ISupportInitialize)(this.c1RibbonPreview1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Report1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1RibbonPreview1
            // 
            this.c1RibbonPreview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1RibbonPreview1.Location = new System.Drawing.Point(0, 0);
            this.c1RibbonPreview1.Name = "c1RibbonPreview1";
            this.c1RibbonPreview1.Size = new System.Drawing.Size(1157, 736);
            this.c1RibbonPreview1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // c1Report1
            // 
            this.c1Report1.DisposeC1Document = true;
            this.c1Report1.EditContext = null;
            this.c1Report1.ReportDefinition = resources.GetString("c1Report1.ReportDefinition");
            this.c1Report1.ReportName = "c1Report1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 736);
            this.Controls.Add(this.c1RibbonPreview1);
            this.Name = "Form1";
            this.Text = "New features of the 2015v2 release";
            this.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Custom;
            ((System.ComponentModel.ISupportInitialize)(this.c1RibbonPreview1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Report1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1RibbonPreview.C1RibbonPreview c1RibbonPreview1;
        private System.Windows.Forms.Timer timer1;
        private C1.C1Report.C1Report c1Report1;
    }
}

