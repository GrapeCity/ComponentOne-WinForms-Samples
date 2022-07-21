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
            C1.Win.Accordion.C1AccordionPage c1AccordionPage1 = new C1.Win.Accordion.C1AccordionPage();
            C1.Win.Accordion.C1AccordionPage c1AccordionPage2 = new C1.Win.Accordion.C1AccordionPage();
            C1.Win.Accordion.C1AccordionPage c1AccordionPage3 = new C1.Win.Accordion.C1AccordionPage();
            this.c1Accordion1 = new C1.Win.Accordion.C1Accordion();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1Accordion1
            // 
            this.c1Accordion1.Dock = System.Windows.Forms.DockStyle.Left;
            this.c1Accordion1.Location = new System.Drawing.Point(0, 0);
            this.c1Accordion1.Name = "c1Accordion1";
            c1AccordionPage1.ContentHeight = 0;
            c1AccordionPage1.ContentWidth = 0;
            c1AccordionPage1.HeaderText = "Home";
            c1AccordionPage1.IsExpanded = true;
            c1AccordionPage1.Name = "HomePage";
            c1AccordionPage2.ContentHeight = 0;
            c1AccordionPage2.ContentWidth = 0;
            c1AccordionPage2.HeaderText = "Data";
            c1AccordionPage2.Name = "DataPage";
            c1AccordionPage3.ContentHeight = 0;
            c1AccordionPage3.ContentWidth = 0;
            c1AccordionPage3.HeaderText = "Chart";
            c1AccordionPage3.Name = "ChartPage";
            this.c1Accordion1.Pages.Add(c1AccordionPage1);
            this.c1Accordion1.Pages.Add(c1AccordionPage2);
            this.c1Accordion1.Pages.Add(c1AccordionPage3);
            this.c1Accordion1.PageSettings.ShowExpandIcon = false;
            this.c1Accordion1.Size = new System.Drawing.Size(248, 647);
            this.c1Accordion1.Styles.Common.BackColor = System.Drawing.Color.LightSkyBlue;
            this.c1Accordion1.Styles.Common.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.c1Accordion1.Styles.Pages.Default.BorderColor = System.Drawing.Color.LightSalmon;
            this.c1Accordion1.Styles.Pages.Header.Default.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.c1Accordion1.Styles.Pages.Header.Default.ForeColor = System.Drawing.Color.Sienna;
            this.c1Accordion1.Styles.Pages.Header.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.c1Accordion1.Styles.Pages.Header.HeaderText.HorizontalAlignment = C1.Framework.Alignment.Near;
            this.c1Accordion1.Styles.Pages.Header.HeaderText.Padding = new C1.Framework.Thickness(15, 5, 5, 5);
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
            this.panel1.Location = new System.Drawing.Point(248, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 647);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 647);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home Content";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimpleMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.c1Accordion1);
            this.Name = "SimpleMenu";
            this.Size = new System.Drawing.Size(817, 647);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Accordion.C1Accordion c1Accordion1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
