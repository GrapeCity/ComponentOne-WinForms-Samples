
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
            btnLoad = new Button();
            btnSaveAs = new Button();
            c1ComboBox1 = new C1.Win.Input.C1ComboBox();
            c1FlexReport1 = new C1.Win.FlexReport.C1FlexReport();
            c1MultiSelect1 = new C1.Win.Input.C1MultiSelect();
            c1FlexViewer1 = new C1.Win.FlexViewer.C1FlexViewer();
            ((System.ComponentModel.ISupportInitialize)c1ComboBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1MultiSelect1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1FlexViewer1).BeginInit();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(16, 0);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(81, 26);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load...";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSaveAs
            // 
            btnSaveAs.Location = new Point(103, 1);
            btnSaveAs.Margin = new Padding(3, 4, 3, 4);
            btnSaveAs.Name = "btnSaveAs";
            btnSaveAs.Size = new Size(85, 26);
            btnSaveAs.TabIndex = 2;
            btnSaveAs.Text = "Save as...";
            btnSaveAs.UseVisualStyleBackColor = true;
            btnSaveAs.Click += btnSaveAs_Click;
            // 
            // c1ComboBox1
            // 
            c1ComboBox1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            c1ComboBox1.Location = new Point(193, 3);
            c1ComboBox1.Name = "c1ComboBox1";
            c1ComboBox1.Size = new Size(218, 25);
            c1ComboBox1.TabIndex = 4;
            c1ComboBox1.SelectedIndexChanged += c1ComboBox1_SelectedIndexChanged;
            // 
            // c1FlexReport1
            // 
            c1FlexReport1.ReportDefinition = resources.GetString("c1FlexReport1.ReportDefinition");
            c1FlexReport1.ReportName = "c1FlexReport1";
            // 
            // c1MultiSelect1
            // 
            c1MultiSelect1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            c1MultiSelect1.Location = new Point(415, 3);
            c1MultiSelect1.Name = "c1MultiSelect1";
            c1MultiSelect1.Size = new Size(509, 26);
            c1MultiSelect1.TabIndex = 5;
            c1MultiSelect1.SelectionChanged += c1MultiSelect1_SelectionChanged;
            // 
            // c1FlexViewer1
            // 
            c1FlexViewer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            c1FlexViewer1.AutoScrollMargin = new Size(0, 0);
            c1FlexViewer1.AutoScrollMinSize = new Size(0, 0);
            c1FlexViewer1.Location = new Point(0, 34);
            c1FlexViewer1.Margin = new Padding(5, 4, 5, 4);
            c1FlexViewer1.Name = "c1FlexViewer1";
            c1FlexViewer1.Size = new Size(935, 484);
            c1FlexViewer1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(c1MultiSelect1);
            Controls.Add(c1ComboBox1);
            Controls.Add(btnSaveAs);
            Controls.Add(btnLoad);
            Controls.Add(c1FlexViewer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Embedded fonts (you can choose any font from the second list to embed)";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)c1ComboBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1MultiSelect1).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1FlexViewer1).EndInit();
            ResumeLayout(false);
            PerformLayout();

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

