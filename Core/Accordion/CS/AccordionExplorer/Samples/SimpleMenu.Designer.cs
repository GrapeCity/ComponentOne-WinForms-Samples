namespace AccordionExplorer.Samples
{
    partial class SimpleMenu
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
            this.c1AccordionPage1 = new C1.Win.Accordion.C1AccordionPage();
            this.c1AccordionPage2 = new C1.Win.Accordion.C1AccordionPage();
            this.c1AccordionPage3 = new C1.Win.Accordion.C1AccordionPage();
            this.c1Accordion1 = new C1.Win.Accordion.C1Accordion();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1Accordion1)).BeginInit();
            this.c1Accordion1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1AccordionPage1
            // 
            this.c1AccordionPage1.ContentHeight = 0;
            this.c1AccordionPage1.ContentWidth = 0;
            this.c1AccordionPage1.HeaderText = "Home";
            this.c1AccordionPage1.IsExpanded = true;
            this.c1AccordionPage1.Name = "HomePage";
            // 
            // c1AccordionPage2
            // 
            this.c1AccordionPage2.ContentHeight = 0;
            this.c1AccordionPage2.ContentWidth = 0;
            this.c1AccordionPage2.HeaderText = "Data";
            this.c1AccordionPage2.Name = "DataPage";
            // 
            // c1AccordionPage3
            // 
            this.c1AccordionPage3.ContentHeight = 0;
            this.c1AccordionPage3.ContentWidth = 0;
            this.c1AccordionPage3.HeaderText = "Chart";
            this.c1AccordionPage3.Name = "ChartPage";
            // 
            // c1Accordion1
            // 
            this.c1Accordion1.Dock = System.Windows.Forms.DockStyle.Left;
            this.c1Accordion1.Location = new System.Drawing.Point(0, 0);
            this.c1Accordion1.Name = "c1Accordion1";
            this.c1Accordion1.Pages.Add(this.c1AccordionPage1);
            this.c1Accordion1.Pages.Add(this.c1AccordionPage2);
            this.c1Accordion1.Pages.Add(this.c1AccordionPage3);
            this.c1Accordion1.PageSettings.ShowExpandIcon = false;
            this.c1Accordion1.Size = new System.Drawing.Size(198, 518);
            this.c1Accordion1.Styles.Common.Default.BackColor = System.Drawing.Color.LightSkyBlue;
            this.c1Accordion1.Styles.Common.Default.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.c1Accordion1.Styles.Pages.Default.BorderColor = System.Drawing.Color.LightSalmon;
            this.c1Accordion1.Styles.Pages.Header.Default.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.c1Accordion1.Styles.Pages.Header.Default.ForeColor = System.Drawing.Color.Sienna;
            this.c1Accordion1.Styles.Pages.Header.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.c1Accordion1.Styles.Pages.Header.Hot.BackColor = System.Drawing.Color.LightSalmon;
            this.c1Accordion1.Styles.Pages.Header.Hot.ForeColor = System.Drawing.Color.White;
            this.c1Accordion1.Styles.Pages.Hot.BorderColor = System.Drawing.Color.Coral;
            this.c1Accordion1.TabIndex = 0;
            this.c1Accordion1.PageHeaderClick += new System.EventHandler<C1.Win.Accordion.PageHeaderClickEventArgs>(this.c1Accordion1_PageHeaderClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(198, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 518);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 518);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home Content";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimpleMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.c1Accordion1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SimpleMenu";
            this.Size = new System.Drawing.Size(654, 518);
            ((System.ComponentModel.ISupportInitialize)(this.c1Accordion1)).EndInit();
            this.c1Accordion1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Accordion.C1Accordion c1Accordion1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private C1.Win.Accordion.C1AccordionPage c1AccordionPage1;
        private C1.Win.Accordion.C1AccordionPage c1AccordionPage2;
        private C1.Win.Accordion.C1AccordionPage c1AccordionPage3;
    }
}
