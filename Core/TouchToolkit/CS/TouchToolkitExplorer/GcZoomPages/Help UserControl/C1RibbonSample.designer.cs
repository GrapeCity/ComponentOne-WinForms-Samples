namespace ClickOnceDemo.GcZoomPages
{
    partial class C1RibbonSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C1RibbonSample));
            this.c1Ribbon1 = new C1.Win.C1Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.C1Ribbon.RibbonApplicationMenu();
            this.ribbonButton1 = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonButton2 = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonButton3 = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonButton4 = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonConfigToolBar1 = new C1.Win.C1Ribbon.RibbonConfigToolBar();
            this.ribbonButton5 = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonQat1 = new C1.Win.C1Ribbon.RibbonQat();
            this.ribbonTab1 = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.C1Ribbon.RibbonGroup();
            this.pictureBoxHost1 = new ControlHosts.PictureBoxHost();
            this.ribbonGroup2 = new C1.Win.C1Ribbon.RibbonGroup();
            this.ribbonLabel1 = new C1.Win.C1Ribbon.RibbonLabel();
            this.textBoxHost1 = new ControlHosts.TextBoxHost();
            this.ribbonGroup4 = new C1.Win.C1Ribbon.RibbonGroup();
            this.ribbonLabel3 = new C1.Win.C1Ribbon.RibbonLabel();
            this.numericUpDownHost1 = new ControlHosts.NumericUpDownHost();
            this.ribbonGroup3 = new C1.Win.C1Ribbon.RibbonGroup();
            this.radioButtonHost1 = new ControlHosts.RadioButtonHost();
            this.radioButtonHost2 = new ControlHosts.RadioButtonHost();
            this.ribbonGroup6 = new C1.Win.C1Ribbon.RibbonGroup();
            this.ribbonLabel4 = new C1.Win.C1Ribbon.RibbonLabel();
            this.checkedListBoxHost1 = new ControlHosts.CheckedListBoxHost();
            this.ribbonTab2 = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup5 = new C1.Win.C1Ribbon.RibbonGroup();
            this.ribbonLabel2 = new C1.Win.C1Ribbon.RibbonLabel();
            this.ribbonLabel5 = new C1.Win.C1Ribbon.RibbonLabel();
            this.ribbonSeparator2 = new C1.Win.C1Ribbon.RibbonSeparator();
            this.backColorEditor = new ControlHosts.ColorEditorHost();
            this.foreColorEditor = new ControlHosts.ColorEditorHost();
            this.ribbonGroup7 = new C1.Win.C1Ribbon.RibbonGroup();
            this.ribbonLabel6 = new C1.Win.C1Ribbon.RibbonLabel();
            this.fontEditorHost1 = new ControlHosts.FontEditorHost();
            this.c1PrintDocument1 = new C1.C1Preview.C1PrintDocument();
            this.c1PreviewPane1 = new C1.Win.C1Preview.C1PreviewPane();
            this.c1StatusBar1 = new C1.Win.C1Ribbon.C1StatusBar();
            this.DocumentModifiedLabel = new C1.Win.C1Ribbon.RibbonLabel();
            this.ZoomTrackBar1 = new C1.Win.C1Ribbon.RibbonTrackBar();
            this.zoomLabel1 = new C1.Win.C1Ribbon.RibbonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PreviewPane1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Tabs.Add(this.ribbonTab1);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab2);
            // 
            // c1StatusBar1
            // 
            this.c1StatusBar1.LeftPaneItems.Add(this.DocumentModifiedLabel);
            this.c1StatusBar1.Name = "c1StatusBar1";
            this.c1StatusBar1.RightPaneItems.Add(this.ZoomTrackBar1);
            this.c1StatusBar1.RightPaneItems.Add(this.zoomLabel1);
            this.c1StatusBar1.RightPaneWidth = 180;
            this.c1StatusBar1.Text = "Ready";
            this.c1StatusBar1.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2010Blue;
            // 
            // DocumentModifiedLabel
            // 
            this.DocumentModifiedLabel.Name = "DocumentModifiedLabel";
            this.DocumentModifiedLabel.Text = "Edit";
            // 
            // ZoomTrackBar1
            // 
            this.ZoomTrackBar1.Maximum = 1000;
            this.ZoomTrackBar1.Minimum = 10;
            this.ZoomTrackBar1.Name = "ZoomTrackBar1";
            this.ZoomTrackBar1.Value = 100;
            // 
            // zoomLabel1
            // 
            this.zoomLabel1.FontPadding = C1.Win.C1Ribbon.FontPadding.Yes;
            this.zoomLabel1.Name = "zoomLabel1";
            this.zoomLabel1.Text = "100%";
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.DropDownWidth = 150;
            this.ribbonApplicationMenu1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonApplicationMenu1.LargeImage")));
            this.ribbonApplicationMenu1.LeftPaneItems.Add(this.ribbonButton1);
            this.ribbonApplicationMenu1.LeftPaneItems.Add(this.ribbonButton2);
            this.ribbonApplicationMenu1.LeftPaneItems.Add(this.ribbonButton3);
            this.ribbonApplicationMenu1.LeftPaneItems.Add(this.ribbonButton4);
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.LargeImage")));
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.Text = "New";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.LargeImage")));
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.Text = "Open";
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.LargeImage")));
            this.ribbonButton3.Name = "ribbonButton3";
            this.ribbonButton3.Text = "Save";
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.LargeImage")));
            this.ribbonButton4.Name = "ribbonButton4";
            this.ribbonButton4.Text = "Print";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Items.Add(this.ribbonButton5);
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonButton5
            // 
            this.ribbonButton5.Name = "ribbonButton5";
            this.ribbonButton5.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.SmallImage")));
            this.ribbonButton5.Text = "Refresh";
            this.ribbonButton5.Click += new System.EventHandler(this.ribbonButton5_Click);
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.ItemLinks.Add(this.ribbonButton3);
            this.ribbonQat1.ItemLinks.Add(this.ribbonButton4);
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Groups.Add(this.ribbonGroup1);
            this.ribbonTab1.Groups.Add(this.ribbonGroup2);
            this.ribbonTab1.Groups.Add(this.ribbonGroup4);
            this.ribbonTab1.Groups.Add(this.ribbonGroup3);
            this.ribbonTab1.Groups.Add(this.ribbonGroup6);
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Profile";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Items.Add(this.pictureBoxHost1);
            this.ribbonGroup1.Name = "ribbonGroup1";
            this.ribbonGroup1.Text = "PictureBox";
            this.ribbonGroup1.ToolTip = "Photo";
            // 
            // pictureBoxHost1
            // 
            this.pictureBoxHost1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHost1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureBoxHost1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHost1.Image")));
            this.pictureBoxHost1.Name = "pictureBoxHost1";
            this.pictureBoxHost1.Click += new System.EventHandler(this.pictureBoxHost1_Click);
            // 
            // ribbonGroup2
            // 
            this.ribbonGroup2.Items.Add(this.ribbonLabel1);
            this.ribbonGroup2.Items.Add(this.textBoxHost1);
            this.ribbonGroup2.Name = "ribbonGroup2";
            this.ribbonGroup2.Text = "TextBox";
            this.ribbonGroup2.ToolTip = "Name";
            // 
            // ribbonLabel1
            // 
            this.ribbonLabel1.Name = "ribbonLabel1";
            this.ribbonLabel1.Text = "Name:";
            // 
            // textBoxHost1
            // 
            this.textBoxHost1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxHost1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHost1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxHost1.Name = "textBoxHost1";
            this.textBoxHost1.TextChanged += new System.EventHandler(this.textBoxHost1_TextChanged);
            // 
            // ribbonGroup4
            // 
            this.ribbonGroup4.Items.Add(this.ribbonLabel3);
            this.ribbonGroup4.Items.Add(this.numericUpDownHost1);
            this.ribbonGroup4.Name = "ribbonGroup4";
            this.ribbonGroup4.Text = "NumericUpDown";
            this.ribbonGroup4.ToolTip = "Age";
            // 
            // ribbonLabel3
            // 
            this.ribbonLabel3.Name = "ribbonLabel3";
            this.ribbonLabel3.Text = "Age:";
            // 
            // numericUpDownHost1
            // 
            this.numericUpDownHost1.BackColor = System.Drawing.SystemColors.Window;
            this.numericUpDownHost1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownHost1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numericUpDownHost1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHost1.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownHost1.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownHost1.Name = "numericUpDownHost1";
            this.numericUpDownHost1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownHost1.Width = 75;
            this.numericUpDownHost1.TextChanged += new System.EventHandler(this.numericUpDownHost1_ValueChanged);
            // 
            // ribbonGroup3
            // 
            this.ribbonGroup3.Items.Add(this.radioButtonHost1);
            this.ribbonGroup3.Items.Add(this.radioButtonHost2);
            this.ribbonGroup3.Name = "ribbonGroup3";
            this.ribbonGroup3.Text = "RadioButton";
            this.ribbonGroup3.ToolTip = "Gender";
            // 
            // radioButtonHost1
            // 
            this.radioButtonHost1.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonHost1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHost1.Name = "radioButtonHost1";
            this.radioButtonHost1.Text = "Male";
            this.radioButtonHost1.Width = 60;
            // 
            // radioButtonHost2
            // 
            this.radioButtonHost2.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonHost2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHost2.Name = "radioButtonHost2";
            this.radioButtonHost2.Text = "Female";
            this.radioButtonHost2.Width = 60;
            // 
            // ribbonGroup6
            // 
            this.ribbonGroup6.Items.Add(this.ribbonLabel4);
            this.ribbonGroup6.Items.Add(this.checkedListBoxHost1);
            this.ribbonGroup6.Name = "ribbonGroup6";
            this.ribbonGroup6.Text = "CheckedListBox";
            this.ribbonGroup6.ToolTip = "Expertise";
            // 
            // ribbonLabel4
            // 
            this.ribbonLabel4.Name = "ribbonLabel4";
            this.ribbonLabel4.Text = "Expertise:";
            // 
            // checkedListBoxHost1
            // 
            this.checkedListBoxHost1.BackColor = System.Drawing.SystemColors.Window;
            this.checkedListBoxHost1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxHost1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkedListBoxHost1.Items.AddRange(new object[] {
            "C1Chart",
            "C1Command",
            "C1Data",
            "C1Excel",
            "C1FlexGrid",
            "C1Input",
            "C1List",
            "C1Preview",
            "C1Report",
            "C1Ribbon",
            "C1Schedule",
            "C1SpellChecker",
            "C1TrueDBGrid"});
            this.checkedListBoxHost1.Name = "checkedListBoxHost1";
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Groups.Add(this.ribbonGroup5);
            this.ribbonTab2.Groups.Add(this.ribbonGroup7);
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "Design";
            // 
            // ribbonGroup5
            // 
            this.ribbonGroup5.Items.Add(this.ribbonLabel2);
            this.ribbonGroup5.Items.Add(this.ribbonLabel5);
            this.ribbonGroup5.Items.Add(this.ribbonSeparator2);
            this.ribbonGroup5.Items.Add(this.backColorEditor);
            this.ribbonGroup5.Items.Add(this.foreColorEditor);
            this.ribbonGroup5.Name = "ribbonGroup5";
            this.ribbonGroup5.Text = "ColorEditorControl";
            this.ribbonGroup5.ToolTip = "Colors";
            // 
            // ribbonLabel2
            // 
            this.ribbonLabel2.Name = "ribbonLabel2";
            this.ribbonLabel2.Text = "Border Color:";
            // 
            // ribbonLabel5
            // 
            this.ribbonLabel5.Name = "ribbonLabel5";
            this.ribbonLabel5.Text = "Text Color:";
            // 
            // ribbonSeparator2
            // 
            this.ribbonSeparator2.HiddenMode = true;
            this.ribbonSeparator2.Name = "ribbonSeparator2";
            // 
            // backColorEditor
            // 
            this.backColorEditor.BackColor = System.Drawing.SystemColors.Window;
            this.backColorEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backColorEditor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.backColorEditor.Name = "backColorEditor";
            this.backColorEditor.SelectedColorChanged += new System.EventHandler(this.backColorEditor_SelectedColorChanged);
            // 
            // foreColorEditor
            // 
            this.foreColorEditor.BackColor = System.Drawing.SystemColors.Window;
            this.foreColorEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreColorEditor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.foreColorEditor.Name = "foreColorEditor";
            this.foreColorEditor.SelectedColorChanged += new System.EventHandler(this.foreColorEditor_SelectedColorChanged);
            // 
            // ribbonGroup7
            // 
            this.ribbonGroup7.Items.Add(this.ribbonLabel6);
            this.ribbonGroup7.Items.Add(this.fontEditorHost1);
            this.ribbonGroup7.Name = "ribbonGroup7";
            this.ribbonGroup7.Text = "FontEditorControl";
            this.ribbonGroup7.ToolTip = "Fonts";
            // 
            // ribbonLabel6
            // 
            this.ribbonLabel6.Name = "ribbonLabel6";
            this.ribbonLabel6.Text = "Font:";
            // 
            // fontEditorHost1
            // 
            this.fontEditorHost1.BackColor = System.Drawing.SystemColors.Window;
            this.fontEditorHost1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontEditorHost1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fontEditorHost1.Name = "fontEditorHost1";
            this.fontEditorHost1.SelectedFontChanged += new System.EventHandler(this.fontEditorHost1_SelectedFontChanged);
            // 
            // c1PrintDocument1
            // 
            this.c1PrintDocument1.DocumentInfo.Creator = "C1Reports Engine version 2.6.20101.54005";
            this.c1PrintDocument1.PageLayouts.Default.PageSettings = new C1.C1Preview.C1PageSettings(false, System.Drawing.Printing.PaperKind.Letter, false, "1in", "1in", "1in", "1in");
            // 
            // c1PreviewPane1
            // 
            this.c1PreviewPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1PreviewPane1.Document = this.c1PrintDocument1;
            this.c1PreviewPane1.Location = new System.Drawing.Point(0, 156);
            this.c1PreviewPane1.Name = "c1PreviewPane1";
            this.c1PreviewPane1.Size = new System.Drawing.Size(657, 290);
            this.c1PreviewPane1.TabIndex = 3;
            // 
            // CustomEditors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(657, 446);
            this.Controls.Add(this.c1PreviewPane1);
            this.Controls.Add(this.c1Ribbon1);
            //this.Controls.Add(this.c1StatusBar1);
            this.Name = "CustomEditors";
            this.Text = "Custom Editors";
            this.Load += new System.EventHandler(this.CustomEditors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PreviewPane1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.C1Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.C1Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.C1Ribbon.RibbonQat ribbonQat1;
        private C1.Win.C1Ribbon.RibbonTab ribbonTab1;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup2;
        private C1.Win.C1Ribbon.RibbonLabel ribbonLabel1;
        private ControlHosts.TextBoxHost textBoxHost1;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup4;
        private C1.Win.C1Ribbon.RibbonLabel ribbonLabel3;
        private ControlHosts.NumericUpDownHost numericUpDownHost1;
        private C1.Win.C1Ribbon.RibbonTab ribbonTab2;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup5;
        private C1.Win.C1Ribbon.RibbonLabel ribbonLabel2;
        private C1.Win.C1Ribbon.RibbonLabel ribbonLabel5;
        private C1.Win.C1Ribbon.RibbonSeparator ribbonSeparator2;
        private ControlHosts.ColorEditorHost backColorEditor;
        private ControlHosts.ColorEditorHost foreColorEditor;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup6;
        private ControlHosts.CheckedListBoxHost checkedListBoxHost1;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup7;
        private C1.Win.C1Ribbon.RibbonLabel ribbonLabel4;
        private C1.Win.C1Ribbon.RibbonLabel ribbonLabel6;
        private ControlHosts.FontEditorHost fontEditorHost1;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton1;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton2;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton3;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton4;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton5;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup3;
        private ControlHosts.RadioButtonHost radioButtonHost1;
        private ControlHosts.RadioButtonHost radioButtonHost2;
        private ControlHosts.PictureBoxHost pictureBoxHost1;
        private C1.C1Preview.C1PrintDocument c1PrintDocument1;
        private C1.Win.C1Preview.C1PreviewPane c1PreviewPane1;
        private C1.Win.C1Ribbon.C1StatusBar c1StatusBar1;
        private C1.Win.C1Ribbon.RibbonLabel DocumentModifiedLabel;
        private C1.Win.C1Ribbon.RibbonLabel zoomLabel1;
        private C1.Win.C1Ribbon.RibbonTrackBar ZoomTrackBar1;
    }
}
