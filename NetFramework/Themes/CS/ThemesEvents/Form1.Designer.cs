namespace ThemesEvents
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
            this.c1Label1 = new C1.Win.C1Input.C1Label();
            this.ctdbgThemes = new C1.Win.TrueDBGrid.C1TrueDBGrid();
            this.c1Label2 = new C1.Win.C1Input.C1Label();
            this.lblApplicationTheme = new C1.Win.C1Input.C1Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctdbgThemes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblApplicationTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1Label1
            // 
            this.c1Label1.AutoSize = true;
            this.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Label1.ForeColor = System.Drawing.Color.Black;
            this.c1Label1.Location = new System.Drawing.Point(10, 50);
            this.c1Label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(326, 13);
            this.c1Label1.TabIndex = 0;
            this.c1Label1.Tag = null;
            this.c1Label1.Text = "Available Themes:";
            this.c1Label1.TextDetached = true;
            this.c1ThemeController1.SetTheme(this.c1Label1, "(default)");
            this.c1Label1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // ctdbgThemes
            // 
            this.ctdbgThemes.AllowUpdate = false;
            this.ctdbgThemes.AlternatingRows = true;
            this.ctdbgThemes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.ctdbgThemes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ctdbgThemes.CaptionHeight = 17;
            this.ctdbgThemes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctdbgThemes.ForeColor = System.Drawing.Color.Black;
            this.ctdbgThemes.GroupByCaption = "Drag a column header here to group by that column";
            this.ctdbgThemes.Images.Add(((System.Drawing.Image)(resources.GetObject("ctdbgThemes.Images"))));
            this.ctdbgThemes.Location = new System.Drawing.Point(10, 66);
            this.ctdbgThemes.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.ctdbgThemes.Name = "ctdbgThemes";
            this.ctdbgThemes.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.ctdbgThemes.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.ctdbgThemes.PreviewInfo.ZoomFactor = 75D;
            this.ctdbgThemes.PrintInfo.MeasurementDevice = C1.Win.TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.ctdbgThemes.PrintInfo.MeasurementPrinterName = null;
            this.ctdbgThemes.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("ctdbgThemes.PrintInfo.PageSettings")));
            this.ctdbgThemes.RowDivider.Color = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.ctdbgThemes.RowDivider.Style = C1.Win.TrueDBGrid.LineStyleEnum.Single;
            this.ctdbgThemes.RowSubDividerColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.ctdbgThemes.Size = new System.Drawing.Size(326, 345);
            this.ctdbgThemes.TabIndex = 1;
            this.ctdbgThemes.Text = "c1TrueDBGrid1";
            this.c1ThemeController1.SetTheme(this.ctdbgThemes, "(default)");
            this.ctdbgThemes.UseCompatibleTextRendering = false;
            this.ctdbgThemes.VisualStyle = C1.Win.TrueDBGrid.VisualStyle.Custom;
            this.ctdbgThemes.DoubleClick += new System.EventHandler(this.ctdbgThemes_DoubleClick);
            this.ctdbgThemes.Resize += new System.EventHandler(this.ctdbgThemes_Resize);
            this.ctdbgThemes.PropBag = resources.GetString("ctdbgThemes.PropBag");
            // 
            // c1Label2
            // 
            this.c1Label2.AutoSize = true;
            this.c1Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Label2.ForeColor = System.Drawing.Color.Black;
            this.c1Label2.Location = new System.Drawing.Point(10, 421);
            this.c1Label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.c1Label2.Name = "c1Label2";
            this.c1Label2.Size = new System.Drawing.Size(326, 13);
            this.c1Label2.TabIndex = 2;
            this.c1Label2.Tag = null;
            this.c1Label2.Text = "Application theme:";
            this.c1Label2.TextDetached = true;
            this.c1ThemeController1.SetTheme(this.c1Label2, "(default)");
            this.c1Label2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // lblApplicationTheme
            // 
            this.lblApplicationTheme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApplicationTheme.AutoEllipsis = true;
            this.lblApplicationTheme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblApplicationTheme.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationTheme.Location = new System.Drawing.Point(10, 434);
            this.lblApplicationTheme.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblApplicationTheme.Name = "lblApplicationTheme";
            this.lblApplicationTheme.Size = new System.Drawing.Size(326, 30);
            this.lblApplicationTheme.TabIndex = 3;
            this.lblApplicationTheme.Tag = null;
            this.lblApplicationTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c1ThemeController1.SetTheme(this.lblApplicationTheme, "(default)");
            this.lblApplicationTheme.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Custom;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(238)))), ((int)(((byte)(194)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(10, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(326, 30);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Using ObjectThemeApplied event  you can restore visual properties which where cha" +
    "nged during theme applying.";
            this.c1ThemeController1.SetTheme(this.textBox1, "(default)");
            // 
            // c1ThemeController1
            // 
            this.c1ThemeController1.ObjectThemeApplied += new C1.Win.Themes.ObjectThemeEventHandler(this.c1ThemeController1_ObjectThemeApplied);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblApplicationTheme, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.c1Label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.c1Label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ctdbgThemes, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(346, 464);
            this.tableLayoutPanel1.TabIndex = 5;
            this.c1ThemeController1.SetTheme(this.tableLayoutPanel1, "(default)");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 464);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(360, 360);
            this.Name = "Form1";
            this.Text = "C1Themes events";
            this.c1ThemeController1.SetTheme(this, "(default)");
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctdbgThemes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblApplicationTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Input.C1Label c1Label1;
        private C1.Win.TrueDBGrid.C1TrueDBGrid ctdbgThemes;
        private C1.Win.C1Input.C1Label c1Label2;
        private C1.Win.C1Input.C1Label lblApplicationTheme;
        private System.Windows.Forms.TextBox textBox1;
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

