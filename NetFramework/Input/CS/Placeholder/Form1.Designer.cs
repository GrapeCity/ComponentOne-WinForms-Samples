namespace Placeholder
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
            this.c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.ribbonTab1 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            this.cmbTheme = new C1.Win.Ribbon.RibbonComboBox();
            this.c1TextBox1 = new C1.Win.C1Input.C1TextBox();
            this.c1ComboBox1 = new C1.Win.C1Input.C1ComboBox();
            this.c1DateEdit1 = new C1.Win.C1Input.C1DateEdit();
            this.c1NumericEdit1 = new C1.Win.C1Input.C1NumericEdit();
            this.c1DropDownControl1 = new C1.Win.C1Input.C1DropDownControl();
            this.c1Label1 = new C1.Win.C1Input.C1Label();
            this.c1Label2 = new C1.Win.C1Input.C1Label();
            this.c1Label3 = new C1.Win.C1Input.C1Label();
            this.c1Label4 = new C1.Win.C1Input.C1Label();
            this.c1Label5 = new C1.Win.C1Input.C1Label();
            this.c1ThemeController1 = new C1.Win.C1Themes.C1ThemeController();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DropDownControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.HideTabHeaderRow = true;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Minimized = true;
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(471, 34);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab1);
            this.c1ThemeController1.SetTheme(this.c1Ribbon1, "(default)");
            this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            this.ribbonApplicationMenu1.Visible = false;
            // 
            // ribbonBottomToolBar1
            // 
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Groups.Add(this.ribbonGroup1);
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Tab";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Name = "ribbonGroup1";
            this.ribbonGroup1.Text = "Group";
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Items.Add(this.cmbTheme);
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // cmbTheme
            // 
            this.cmbTheme.Label = "Theme";
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.TextAreaWidth = 120;
            this.cmbTheme.SelectedIndexChanged += new System.EventHandler(this.cmbTheme_SelectedIndexChanged);
            // 
            // c1TextBox1
            // 
            this.c1TextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.c1TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1TextBox1.Location = new System.Drawing.Point(118, 77);
            this.c1TextBox1.Name = "c1TextBox1";
            this.c1TextBox1.Placeholder = "C1TextBox placeholder";
            this.c1TextBox1.Size = new System.Drawing.Size(200, 18);
            this.c1TextBox1.TabIndex = 1;
            this.c1TextBox1.Tag = null;
            this.c1ThemeController1.SetTheme(this.c1TextBox1, "(default)");
            this.c1TextBox1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // c1ComboBox1
            // 
            this.c1ComboBox1.AllowSpinLoop = false;
            this.c1ComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.c1ComboBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1ComboBox1.GapHeight = 0;
            this.c1ComboBox1.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1ComboBox1.Items.Add("one");
            this.c1ComboBox1.Items.Add("two");
            this.c1ComboBox1.Location = new System.Drawing.Point(118, 119);
            this.c1ComboBox1.Name = "c1ComboBox1";
            this.c1ComboBox1.Placeholder = "C1ComboBox placeholder";
            this.c1ComboBox1.Size = new System.Drawing.Size(200, 18);
            this.c1ComboBox1.TabIndex = 2;
            this.c1ComboBox1.Tag = null;
            this.c1ThemeController1.SetTheme(this.c1ComboBox1, "(default)");
            this.c1ComboBox1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // c1DateEdit1
            // 
            this.c1DateEdit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.c1DateEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.c1DateEdit1.Calendar.Font = new System.Drawing.Font("Tahoma", 8F);
            this.c1DateEdit1.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.c1DateEdit1.GapHeight = 0;
            this.c1DateEdit1.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1DateEdit1.Location = new System.Drawing.Point(118, 165);
            this.c1DateEdit1.Name = "c1DateEdit1";
            this.c1DateEdit1.Placeholder = "C1DateEdit placeholder";
            this.c1DateEdit1.Size = new System.Drawing.Size(200, 18);
            this.c1DateEdit1.TabIndex = 3;
            this.c1DateEdit1.Tag = null;
            this.c1ThemeController1.SetTheme(this.c1DateEdit1, "(default)");
            this.c1DateEdit1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // c1NumericEdit1
            // 
            this.c1NumericEdit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.c1NumericEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.c1NumericEdit1.Calculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.c1NumericEdit1.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.c1NumericEdit1.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.c1NumericEdit1.GapHeight = 0;
            this.c1NumericEdit1.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1NumericEdit1.Location = new System.Drawing.Point(118, 210);
            this.c1NumericEdit1.Name = "c1NumericEdit1";
            this.c1NumericEdit1.Placeholder = "C1NumericEdit placeholder";
            this.c1NumericEdit1.Size = new System.Drawing.Size(200, 18);
            this.c1NumericEdit1.TabIndex = 4;
            this.c1NumericEdit1.Tag = null;
            this.c1ThemeController1.SetTheme(this.c1NumericEdit1, "(default)");
            this.c1NumericEdit1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // c1DropDownControl1
            // 
            this.c1DropDownControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.c1DropDownControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1DropDownControl1.GapHeight = 0;
            this.c1DropDownControl1.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1DropDownControl1.Location = new System.Drawing.Point(118, 256);
            this.c1DropDownControl1.Name = "c1DropDownControl1";
            this.c1DropDownControl1.Placeholder = "C1DropDownControl placeholder";
            this.c1DropDownControl1.Size = new System.Drawing.Size(200, 18);
            this.c1DropDownControl1.TabIndex = 5;
            this.c1DropDownControl1.Tag = null;
            this.c1ThemeController1.SetTheme(this.c1DropDownControl1, "(default)");
            this.c1DropDownControl1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // c1Label1
            // 
            this.c1Label1.AutoSize = true;
            this.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.c1Label1.Location = new System.Drawing.Point(53, 80);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(59, 13);
            this.c1Label1.TabIndex = 6;
            this.c1Label1.Tag = null;
            this.c1Label1.Text = "C1TextBox";
            this.c1Label1.TextDetached = true;
            this.c1ThemeController1.SetTheme(this.c1Label1, "(default)");
            // 
            // c1Label2
            // 
            this.c1Label2.AutoSize = true;
            this.c1Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.c1Label2.Location = new System.Drawing.Point(41, 122);
            this.c1Label2.Name = "c1Label2";
            this.c1Label2.Size = new System.Drawing.Size(71, 13);
            this.c1Label2.TabIndex = 7;
            this.c1Label2.Tag = null;
            this.c1Label2.Text = "C1ComboBox";
            this.c1Label2.TextDetached = true;
            this.c1ThemeController1.SetTheme(this.c1Label2, "(default)");
            // 
            // c1Label3
            // 
            this.c1Label3.AutoSize = true;
            this.c1Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.c1Label3.Location = new System.Drawing.Point(51, 168);
            this.c1Label3.Name = "c1Label3";
            this.c1Label3.Size = new System.Drawing.Size(61, 13);
            this.c1Label3.TabIndex = 8;
            this.c1Label3.Tag = null;
            this.c1Label3.Text = "C1DateEdit";
            this.c1Label3.TextDetached = true;
            this.c1ThemeController1.SetTheme(this.c1Label3, "(default)");
            // 
            // c1Label4
            // 
            this.c1Label4.AutoSize = true;
            this.c1Label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.c1Label4.Location = new System.Drawing.Point(35, 213);
            this.c1Label4.Name = "c1Label4";
            this.c1Label4.Size = new System.Drawing.Size(77, 13);
            this.c1Label4.TabIndex = 9;
            this.c1Label4.Tag = null;
            this.c1Label4.Text = "C1NumericEdit";
            this.c1Label4.TextDetached = true;
            this.c1ThemeController1.SetTheme(this.c1Label4, "(default)");
            // 
            // c1Label5
            // 
            this.c1Label5.AutoSize = true;
            this.c1Label5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.c1Label5.Location = new System.Drawing.Point(8, 259);
            this.c1Label5.Name = "c1Label5";
            this.c1Label5.Size = new System.Drawing.Size(104, 13);
            this.c1Label5.TabIndex = 10;
            this.c1Label5.Tag = null;
            this.c1Label5.Text = "C1DropDownControl";
            this.c1Label5.TextDetached = true;
            this.c1ThemeController1.SetTheme(this.c1Label5, "(default)");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 319);
            this.Controls.Add(this.c1Label5);
            this.Controls.Add(this.c1Label4);
            this.Controls.Add(this.c1Label3);
            this.Controls.Add(this.c1Label2);
            this.Controls.Add(this.c1Label1);
            this.Controls.Add(this.c1DropDownControl1);
            this.Controls.Add(this.c1NumericEdit1);
            this.Controls.Add(this.c1DateEdit1);
            this.Controls.Add(this.c1ComboBox1);
            this.Controls.Add(this.c1TextBox1);
            this.Controls.Add(this.c1Ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "C1Input Placeholder";
            this.c1ThemeController1.SetTheme(this, "(default)");
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DropDownControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.Ribbon.RibbonQat ribbonQat1;
        private C1.Win.Ribbon.RibbonTab ribbonTab1;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.Ribbon.RibbonComboBox cmbTheme;
        private C1.Win.C1Input.C1TextBox c1TextBox1;
        private C1.Win.C1Input.C1ComboBox c1ComboBox1;
        private C1.Win.C1Input.C1DateEdit c1DateEdit1;
        private C1.Win.C1Input.C1NumericEdit c1NumericEdit1;
        private C1.Win.C1Input.C1DropDownControl c1DropDownControl1;
        private C1.Win.C1Input.C1Label c1Label1;
        private C1.Win.C1Input.C1Label c1Label2;
        private C1.Win.C1Input.C1Label c1Label3;
        private C1.Win.C1Input.C1Label c1Label4;
        private C1.Win.C1Input.C1Label c1Label5;
        private C1.Win.C1Themes.C1ThemeController c1ThemeController1;
    }
}

