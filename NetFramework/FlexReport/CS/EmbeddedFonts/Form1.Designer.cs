
namespace EmbeddedFonts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.c1ComboBox1 = new C1.Win.Input.C1ComboBox();
            this.c1FlexReport1 = new C1.Win.FlexReport.C1FlexReport();
            this.c1MultiSelect1 = new C1.Win.Input.C1MultiSelect();
            this.c1FlexViewer1 = new C1.Win.FlexViewer.C1FlexViewer();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(18, 0);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(92, 28);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load...";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(117, 1);
            this.btnSaveAs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(97, 28);
            this.btnSaveAs.TabIndex = 2;
            this.btnSaveAs.Text = "Save as...";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // c1ComboBox1
            // 
            this.c1ComboBox1.AllowSpinLoop = false;
            this.c1ComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1ComboBox1.GapHeight = 0;
            this.c1ComboBox1.Location = new System.Drawing.Point(220, 3);
            this.c1ComboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.c1ComboBox1.Name = "c1ComboBox1";
            this.c1ComboBox1.Size = new System.Drawing.Size(249, 26);
            this.c1ComboBox1.TabIndex = 4;
            this.c1ComboBox1.Tag = null;
            this.c1ComboBox1.SelectedIndexChanged += new System.EventHandler(this.c1ComboBox1_SelectedIndexChanged);
            // 
            // c1FlexReport1
            // 
            this.c1FlexReport1.ReportDefinition = resources.GetString("c1FlexReport1.ReportDefinition");
            this.c1FlexReport1.ReportName = "c1FlexReport1";
            // 
            // c1MultiSelect1
            // 
            this.c1MultiSelect1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1MultiSelect1.Location = new System.Drawing.Point(475, 3);
            this.c1MultiSelect1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.c1MultiSelect1.Name = "c1MultiSelect1";
            this.c1MultiSelect1.Size = new System.Drawing.Size(581, 26);
            this.c1MultiSelect1.TabIndex = 5;
            this.c1MultiSelect1.SelectionChanged += new System.EventHandler(this.c1MultiSelect1_SelectionChanged);
            // 
            // c1FlexViewer1
            // 
            this.c1FlexViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1FlexViewer1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.c1FlexViewer1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.c1FlexViewer1.Location = new System.Drawing.Point(0, 36);
            this.c1FlexViewer1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.c1FlexViewer1.Name = "c1FlexViewer1";
            this.c1FlexViewer1.Size = new System.Drawing.Size(1068, 517);
            this.c1FlexViewer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.c1MultiSelect1);
            this.Controls.Add(this.c1ComboBox1);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.c1FlexViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Embedded fonts (you can choose any font from the second list to embed)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexViewer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.FlexViewer.C1FlexViewer c1FlexViewer1;
        private C1.Win.FlexReport.C1FlexReport c1FlexReport1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSaveAs;
        private C1.Win.Input.C1ComboBox c1ComboBox1;
        private C1.Win.Input.C1MultiSelect c1MultiSelect1;
    }
}

