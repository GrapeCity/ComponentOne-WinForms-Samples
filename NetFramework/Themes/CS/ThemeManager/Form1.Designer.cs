namespace ThemeManager
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
            this.ctdbgThemes = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.btnAdd = new C1.Win.C1Input.C1Button();
            this.btnRemove = new C1.Win.C1Input.C1Button();
            this.btnSetAsApplicationTheme = new C1.Win.C1Input.C1Button();
            this.c1ThemeController1 = new C1.Win.C1Themes.C1ThemeController();
            this.c1Label1 = new C1.Win.C1Input.C1Label();
            this.tbApplicationTheme = new C1.Win.C1Input.C1TextBox();
            this.c1Label2 = new C1.Win.C1Input.C1Label();
            this.c1Label3 = new C1.Win.C1Input.C1Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ctdbgThemes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetAsApplicationTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbApplicationTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctdbgThemes
            // 
            this.ctdbgThemes.AllowColMove = false;
            this.ctdbgThemes.AllowUpdate = false;
            this.ctdbgThemes.AlternatingRows = true;
            this.ctdbgThemes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctdbgThemes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.ctdbgThemes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ctdbgThemes.CaptionHeight = 17;
            this.ctdbgThemes.ForeColor = System.Drawing.Color.Black;
            this.ctdbgThemes.GroupByCaption = "Drag a column header here to group by that column";
            this.ctdbgThemes.Images.Add(((System.Drawing.Image)(resources.GetObject("ctdbgThemes.Images"))));
            this.ctdbgThemes.Location = new System.Drawing.Point(12, 3);
            this.ctdbgThemes.Name = "ctdbgThemes";
            this.ctdbgThemes.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.ctdbgThemes.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.ctdbgThemes.PreviewInfo.ZoomFactor = 75D;
            this.ctdbgThemes.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.ctdbgThemes.PrintInfo.MeasurementPrinterName = null;
            this.ctdbgThemes.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("ctdbgThemes.PrintInfo.PageSettings")));
            this.ctdbgThemes.RowDivider.Color = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.ctdbgThemes.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.ctdbgThemes.RowHeight = 15;
            this.ctdbgThemes.RowSubDividerColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.ctdbgThemes.Size = new System.Drawing.Size(300, 276);
            this.ctdbgThemes.TabIndex = 3;
            this.ctdbgThemes.Text = "c1TrueDBGrid1";
            this.c1ThemeController1.SetTheme(this.ctdbgThemes, "(default)");
            this.c1ThemeController1.SetThemeSettings(this.ctdbgThemes, null);
            this.ctdbgThemes.UseCompatibleTextRendering = false;
            this.ctdbgThemes.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Custom;
            this.ctdbgThemes.DoubleClick += new System.EventHandler(this.ctdbgThemes_DoubleClick);
            this.ctdbgThemes.Resize += new System.EventHandler(this.ctdbgThemes_Resize);
            this.ctdbgThemes.PropBag = resources.GetString("ctdbgThemes.PropBag");
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnAdd.Location = new System.Drawing.Point(118, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add...";
            this.c1ThemeController1.SetTheme(this.btnAdd, "(default)");
            this.c1ThemeController1.SetThemeSettings(this.btnAdd, null);
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnRemove.Location = new System.Drawing.Point(118, 64);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.c1ThemeController1.SetTheme(this.btnRemove, "(default)");
            this.c1ThemeController1.SetThemeSettings(this.btnRemove, null);
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSetAsApplicationTheme
            // 
            this.btnSetAsApplicationTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetAsApplicationTheme.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnSetAsApplicationTheme.Location = new System.Drawing.Point(118, 6);
            this.btnSetAsApplicationTheme.Name = "btnSetAsApplicationTheme";
            this.btnSetAsApplicationTheme.Size = new System.Drawing.Size(75, 23);
            this.btnSetAsApplicationTheme.TabIndex = 5;
            this.btnSetAsApplicationTheme.Text = "Apply";
            this.c1ThemeController1.SetTheme(this.btnSetAsApplicationTheme, "(default)");
            this.c1ThemeController1.SetThemeSettings(this.btnSetAsApplicationTheme, null);
            this.btnSetAsApplicationTheme.UseVisualStyleBackColor = true;
            this.btnSetAsApplicationTheme.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnSetAsApplicationTheme.Click += new System.EventHandler(this.btnSetAsApplicationTheme_Click);
            // 
            // c1Label1
            // 
            this.c1Label1.AutoSize = true;
            this.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.c1Label1.ForeColor = System.Drawing.Color.Black;
            this.c1Label1.Location = new System.Drawing.Point(12, 9);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(77, 19);
            this.c1Label1.TabIndex = 0;
            this.c1Label1.Tag = null;
            this.c1Label1.Text = "Current theme:";
            this.c1Label1.TextDetached = true;
            this.c1ThemeController1.SetTheme(this.c1Label1, "(default)");
            this.c1ThemeController1.SetThemeSettings(this.c1Label1, null);
            this.c1Label1.UseCompatibleTextRendering = true;
            this.c1Label1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // tbApplicationTheme
            // 
            this.tbApplicationTheme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbApplicationTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(200)))));
            this.tbApplicationTheme.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbApplicationTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbApplicationTheme.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbApplicationTheme.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.tbApplicationTheme.Location = new System.Drawing.Point(118, 7);
            this.tbApplicationTheme.Name = "tbApplicationTheme";
            this.tbApplicationTheme.ReadOnly = true;
            this.tbApplicationTheme.Size = new System.Drawing.Size(194, 20);
            this.tbApplicationTheme.TabIndex = 1;
            this.tbApplicationTheme.Tag = null;
            this.c1ThemeController1.SetTheme(this.tbApplicationTheme, "(default)");
            this.c1ThemeController1.SetThemeSettings(this.tbApplicationTheme, null);
            this.tbApplicationTheme.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // c1Label2
            // 
            this.c1Label2.AutoSize = true;
            this.c1Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.c1Label2.ForeColor = System.Drawing.Color.Black;
            this.c1Label2.Location = new System.Drawing.Point(12, 30);
            this.c1Label2.Name = "c1Label2";
            this.c1Label2.Size = new System.Drawing.Size(89, 19);
            this.c1Label2.TabIndex = 2;
            this.c1Label2.Tag = null;
            this.c1Label2.Text = "Available themes:";
            this.c1Label2.TextDetached = true;
            this.c1ThemeController1.SetTheme(this.c1Label2, "(default)");
            this.c1ThemeController1.SetThemeSettings(this.c1Label2, null);
            this.c1Label2.UseCompatibleTextRendering = true;
            this.c1Label2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // c1Label3
            // 
            this.c1Label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.c1Label3.AutoSize = true;
            this.c1Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.c1Label3.ForeColor = System.Drawing.Color.Black;
            this.c1Label3.Location = new System.Drawing.Point(12, 11);
            this.c1Label3.Name = "c1Label3";
            this.c1Label3.Size = new System.Drawing.Size(77, 19);
            this.c1Label3.TabIndex = 4;
            this.c1Label3.Tag = null;
            this.c1Label3.Text = "Theme actions:";
            this.c1Label3.TextDetached = true;
            this.c1ThemeController1.SetTheme(this.c1Label3, "(default)");
            this.c1ThemeController1.SetThemeSettings(this.c1Label3, null);
            this.c1Label3.UseCompatibleTextRendering = true;
            this.c1Label3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "c1theme";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "C1Theme files (*.c1theme)|*.c1theme|All files (*.*)|*.*";
            this.openFileDialog1.Title = "Select Theme";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.c1Label1);
            this.panel1.Controls.Add(this.tbApplicationTheme);
            this.panel1.Controls.Add(this.c1Label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 47);
            this.panel1.TabIndex = 8;
            this.c1ThemeController1.SetTheme(this.panel1, "(default)");
            this.c1ThemeController1.SetThemeSettings(this.panel1, null);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.c1Label3);
            this.panel2.Controls.Add(this.btnSetAsApplicationTheme);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 94);
            this.panel2.TabIndex = 9;
            this.c1ThemeController1.SetTheme(this.panel2, "(default)");
            this.c1ThemeController1.SetThemeSettings(this.panel2, null);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.ctdbgThemes);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 285);
            this.panel3.TabIndex = 10;
            this.c1ThemeController1.SetTheme(this.panel3, "(default)");
            this.c1ThemeController1.SetThemeSettings(this.panel3, null);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 426);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Theme Manager";
            this.c1ThemeController1.SetTheme(this, "(default)");
            this.c1ThemeController1.SetThemeSettings(this, null);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctdbgThemes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetAsApplicationTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbApplicationTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid ctdbgThemes;
        private C1.Win.C1Input.C1Button btnAdd;
        private C1.Win.C1Input.C1Button btnRemove;
        private C1.Win.C1Input.C1Button btnSetAsApplicationTheme;
        private C1.Win.C1Themes.C1ThemeController c1ThemeController1;
        private C1.Win.C1Input.C1Label c1Label1;
        private C1.Win.C1Input.C1TextBox tbApplicationTheme;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private C1.Win.C1Input.C1Label c1Label2;
        private C1.Win.C1Input.C1Label c1Label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

