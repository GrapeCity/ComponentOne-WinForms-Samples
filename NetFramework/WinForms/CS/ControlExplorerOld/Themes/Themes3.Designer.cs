namespace ControlExplorer.Themes
{
    partial class Themes3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Themes3));
            this.c1ThemeController1 = new C1.Win.C1Themes.C1ThemeController();
            this.c1Ribbon1 = new C1.Win.C1Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.C1Ribbon.RibbonApplicationMenu();
            this.ribbonConfigToolBar1 = new C1.Win.C1Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.C1Ribbon.RibbonQat();
            this.tab1 = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.C1Ribbon.RibbonGroup();
            this.ribbonButton1 = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonGroup3 = new C1.Win.C1Ribbon.RibbonGroup();
            this.ribbonComboBox1 = new C1.Win.C1Ribbon.RibbonComboBox();
            this.ribbonGroup4 = new C1.Win.C1Ribbon.RibbonGroup();
            this.ribbonTimePicker1 = new C1.Win.C1Ribbon.RibbonTimePicker();
            this.ribbonTab2 = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup2 = new C1.Win.C1Ribbon.RibbonGroup();
            this.ribbonColorPicker1 = new C1.Win.C1Ribbon.RibbonColorPicker();
            this.ribbonFontComboBox1 = new C1.Win.C1Ribbon.RibbonFontComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1ThemeController1
            // 
            this.c1ThemeController1.Theme = "(none)";
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(624, 146);
            this.c1Ribbon1.Tabs.Add(this.tab1);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab2);
            this.c1Ribbon1.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Custom;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // tab1
            // 
            this.tab1.Groups.Add(this.ribbonGroup1);
            this.tab1.Groups.Add(this.ribbonGroup3);
            this.tab1.Groups.Add(this.ribbonGroup4);
            this.tab1.Name = "tab1";
            this.tab1.Text = "Tab1";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Items.Add(this.ribbonButton1);
            this.ribbonGroup1.Name = "ribbonGroup1";
            this.ribbonGroup1.Text = "Group1";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "Button";
            // 
            // ribbonGroup3
            // 
            this.ribbonGroup3.Items.Add(this.ribbonComboBox1);
            this.ribbonGroup3.Name = "ribbonGroup3";
            this.ribbonGroup3.Text = "Group2";
            // 
            // ribbonComboBox1
            // 
            this.ribbonComboBox1.Label = "Choose Theme";
            this.ribbonComboBox1.Name = "ribbonComboBox1";
            this.ribbonComboBox1.TextAreaWidth = 200;
            this.ribbonComboBox1.SelectedIndexChanged += new System.EventHandler(this.ribbonComboBox1_SelectedIndexChanged);
            // 
            // ribbonGroup4
            // 
            this.ribbonGroup4.Items.Add(this.ribbonTimePicker1);
            this.ribbonGroup4.Name = "ribbonGroup4";
            this.ribbonGroup4.Text = "Group3";
            // 
            // ribbonTimePicker1
            // 
            this.ribbonTimePicker1.Label = "Time Picker";
            this.ribbonTimePicker1.Name = "ribbonTimePicker1";
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Groups.Add(this.ribbonGroup2);
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "Tab2";
            // 
            // ribbonGroup2
            // 
            this.ribbonGroup2.Items.Add(this.ribbonColorPicker1);
            this.ribbonGroup2.Items.Add(this.ribbonFontComboBox1);
            this.ribbonGroup2.Name = "ribbonGroup2";
            this.ribbonGroup2.Text = "Group1";
            // 
            // ribbonColorPicker1
            // 
            this.ribbonColorPicker1.Name = "ribbonColorPicker1";
            this.ribbonColorPicker1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorPicker1.SmallImage")));
            // 
            // ribbonFontComboBox1
            // 
            this.ribbonFontComboBox1.Name = "ribbonFontComboBox1";
            // 
            // Themes3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 444);
            this.Controls.Add(this.c1Ribbon1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Name = "Themes3";
            this.Text = "Themes3";
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Themes.C1ThemeController c1ThemeController1;
        private C1.Win.C1Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.C1Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.C1Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.C1Ribbon.RibbonQat ribbonQat1;
        private C1.Win.C1Ribbon.RibbonTab tab1;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.C1Ribbon.RibbonTab ribbonTab2;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup2;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton1;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup3;
        private C1.Win.C1Ribbon.RibbonComboBox ribbonComboBox1;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup4;
        private C1.Win.C1Ribbon.RibbonTimePicker ribbonTimePicker1;
        private C1.Win.C1Ribbon.RibbonColorPicker ribbonColorPicker1;
        private C1.Win.C1Ribbon.RibbonFontComboBox ribbonFontComboBox1;
    }
}