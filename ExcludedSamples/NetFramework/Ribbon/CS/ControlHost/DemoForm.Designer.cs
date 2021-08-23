namespace ControlHostDemo
{
    partial class DemoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoForm));
            this.c1Ribbon1 = new C1.Win.C1Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.C1Ribbon.RibbonApplicationMenu();
            this.exitButton = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonBottomToolBar1 = new C1.Win.C1Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.C1Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.C1Ribbon.RibbonQat();
            this.ribbonTab1 = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup3 = new C1.Win.C1Ribbon.RibbonGroup();
            this.pictureBoxHost1 = new ControlHostLib.PictureBoxHost();
            this.ribbonGroup1 = new C1.Win.C1Ribbon.RibbonGroup();
            this.numericUpDownHost1 = new ControlHostLib.NumericUpDownHost();
            this.ribbonGroup2 = new C1.Win.C1Ribbon.RibbonGroup();
            this.checkedListBoxHost1 = new ControlHostLib.CheckedListBoxHost();
            this.ribbonTab2 = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup4 = new C1.Win.C1Ribbon.RibbonGroup();
            this.ribbonLabel1 = new C1.Win.C1Ribbon.RibbonLabel();
            this.ribbonLabel2 = new C1.Win.C1Ribbon.RibbonLabel();
            this.ribbonSeparator3 = new C1.Win.C1Ribbon.RibbonSeparator();
            this.backColorEditor = new ControlHostLib.ColorEditorHost();
            this.foreColorEditor = new ControlHostLib.ColorEditorHost();
            this.ribbonGroup5 = new C1.Win.C1Ribbon.RibbonGroup();
            this.fontEditor = new ControlHostLib.FontEditorHost();
            this.ribbonTab3 = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup6 = new C1.Win.C1Ribbon.RibbonGroup();
            this.axWebBrowserHost1 = new ControlHostLib.AxWebBrowserHost();
            this.ribbonTopToolBar1 = new C1.Win.C1Ribbon.RibbonTopToolBar();
            this.c1StatusBar1 = new C1.Win.C1Ribbon.C1StatusBar();
            this.statusLabel = new C1.Win.C1Ribbon.RibbonLabel();
            this.ribbonSeparator1 = new C1.Win.C1Ribbon.RibbonSeparator();
            this.checkStatusLabel = new C1.Win.C1Ribbon.RibbonLabel();
            this.ribbonSeparator2 = new C1.Win.C1Ribbon.RibbonSeparator();
            this.rbLoad = new C1.Win.C1Ribbon.RibbonButton();
            this.rbSave = new C1.Win.C1Ribbon.RibbonButton();
            this.rbClear = new C1.Win.C1Ribbon.RibbonButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.AllowMinimize = false;
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(472, 155);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab1);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab2);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab3);
            this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
            this.c1Ribbon1.ControlHostFromXmlNode += new System.EventHandler<C1.Win.C1Ribbon.ControlHostFromXmlNodeEventArgs>(this.c1Ribbon1_ControlHostFromXmlNode);
            this.c1Ribbon1.RibbonDeserialized += new System.EventHandler<System.EventArgs>(this.c1Ribbon1_RibbonDeserialized);
            this.c1Ribbon1.ItemDeserialized += new System.EventHandler<C1.Win.C1Ribbon.ItemDeserializedEventArgs>(this.c1Ribbon1_ItemDeserialized);
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.BottomPaneItems.Add(this.exitButton);
            this.ribbonApplicationMenu1.DropDownWidth = 60;
            this.ribbonApplicationMenu1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonApplicationMenu1.LargeImage")));
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            this.ribbonApplicationMenu1.DoubleClick += new System.EventHandler(this.exitButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Name = "exitButton";
            this.exitButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("exitButton.SmallImage")));
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
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
            this.ribbonTab1.Groups.Add(this.ribbonGroup3);
            this.ribbonTab1.Groups.Add(this.ribbonGroup1);
            this.ribbonTab1.Groups.Add(this.ribbonGroup2);
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Simple Controls";
            // 
            // ribbonGroup3
            // 
            this.ribbonGroup3.Items.Add(this.pictureBoxHost1);
            this.ribbonGroup3.Name = "ribbonGroup3";
            this.ribbonGroup3.Text = "PictureBox";
            // 
            // pictureBoxHost1
            // 
            this.pictureBoxHost1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHost1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pictureBoxHost1.Image = global::ControlHostDemo.Properties.Resources._1403_Globe;
            this.pictureBoxHost1.Name = "pictureBoxHost1";
            this.pictureBoxHost1.Width = 50;
            this.pictureBoxHost1.Click += new System.EventHandler(this.pictureBoxHost1_Click);
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Items.Add(this.numericUpDownHost1);
            this.ribbonGroup1.Name = "ribbonGroup1";
            this.ribbonGroup1.Text = "NumericUpDown";
            // 
            // numericUpDownHost1
            // 
            this.numericUpDownHost1.BackColor = System.Drawing.SystemColors.Window;
            this.numericUpDownHost1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownHost1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numericUpDownHost1.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownHost1.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.numericUpDownHost1.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownHost1.Name = "numericUpDownHost1";
            this.numericUpDownHost1.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownHost1.Width = 100;
            this.numericUpDownHost1.ValueChanged += new System.EventHandler(this.numericUpDownHost1_ValueChanged);
            // 
            // ribbonGroup2
            // 
            this.ribbonGroup2.Items.Add(this.checkedListBoxHost1);
            this.ribbonGroup2.Name = "ribbonGroup2";
            this.ribbonGroup2.Text = "CheckedListBox";
            // 
            // checkedListBoxHost1
            // 
            this.checkedListBoxHost1.BackColor = System.Drawing.SystemColors.Window;
            this.checkedListBoxHost1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxHost1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkedListBoxHost1.Items.AddRange(new object[] {
            "Apple",
            "Bananas",
            "Bilberry",
            "Cherries",
            "Gooseberry",
            "Grape",
            "Peach",
            "Strawberry"});
            this.checkedListBoxHost1.Name = "checkedListBoxHost1";
            this.checkedListBoxHost1.Width = 140;
            this.checkedListBoxHost1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxHost1_ItemCheck);
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Groups.Add(this.ribbonGroup4);
            this.ribbonTab2.Groups.Add(this.ribbonGroup5);
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "Items Based on UITypeEditor";
            // 
            // ribbonGroup4
            // 
            this.ribbonGroup4.Items.Add(this.ribbonLabel1);
            this.ribbonGroup4.Items.Add(this.ribbonLabel2);
            this.ribbonGroup4.Items.Add(this.ribbonSeparator3);
            this.ribbonGroup4.Items.Add(this.backColorEditor);
            this.ribbonGroup4.Items.Add(this.foreColorEditor);
            this.ribbonGroup4.Name = "ribbonGroup4";
            this.ribbonGroup4.Text = "Color Editors";
            // 
            // ribbonLabel1
            // 
            this.ribbonLabel1.Name = "ribbonLabel1";
            this.ribbonLabel1.Text = "BackColor:";
            // 
            // ribbonLabel2
            // 
            this.ribbonLabel2.Name = "ribbonLabel2";
            this.ribbonLabel2.Text = "ForeColor:";
            // 
            // ribbonSeparator3
            // 
            this.ribbonSeparator3.HiddenMode = true;
            this.ribbonSeparator3.Name = "ribbonSeparator3";
            // 
            // backColorEditor
            // 
            this.backColorEditor.BackColor = System.Drawing.SystemColors.Window;
            this.backColorEditor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backColorEditor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.backColorEditor.Name = "backColorEditor";
            this.backColorEditor.Width = 110;
            this.backColorEditor.SelectedColorChanged += new System.EventHandler(this.backColorEditor_SelectedColorChanged);
            // 
            // foreColorEditor
            // 
            this.foreColorEditor.BackColor = System.Drawing.SystemColors.Window;
            this.foreColorEditor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.foreColorEditor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.foreColorEditor.Name = "foreColorEditor";
            this.foreColorEditor.Width = 110;
            this.foreColorEditor.SelectedColorChanged += new System.EventHandler(this.foreColorEditor_SelectedColorChanged);
            // 
            // ribbonGroup5
            // 
            this.ribbonGroup5.Items.Add(this.fontEditor);
            this.ribbonGroup5.Name = "ribbonGroup5";
            this.ribbonGroup5.Text = "Font Editor";
            // 
            // fontEditor
            // 
            this.fontEditor.BackColor = System.Drawing.SystemColors.Window;
            this.fontEditor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fontEditor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fontEditor.Name = "fontEditor";
            this.fontEditor.Width = 240;
            this.fontEditor.SelectedFontChanged += new System.EventHandler(this.fontEditor_SelectedFontChanged);
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Groups.Add(this.ribbonGroup6);
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Text = "ActiveX Element";
            // 
            // ribbonGroup6
            // 
            this.ribbonGroup6.Items.Add(this.axWebBrowserHost1);
            this.ribbonGroup6.Name = "ribbonGroup6";
            this.ribbonGroup6.Text = "ActiveX Web Browser";
            // 
            // axWebBrowserHost1
            // 
            this.axWebBrowserHost1.BackColor = System.Drawing.SystemColors.Control;
            this.axWebBrowserHost1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.axWebBrowserHost1.Height = 70;
            this.axWebBrowserHost1.Name = "axWebBrowserHost1";
            this.axWebBrowserHost1.Width = 440;
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // c1StatusBar1
            // 
            this.c1StatusBar1.LeftPaneItems.Add(this.statusLabel);
            this.c1StatusBar1.LeftPaneItems.Add(this.ribbonSeparator1);
            this.c1StatusBar1.LeftPaneItems.Add(this.checkStatusLabel);
            this.c1StatusBar1.LeftPaneItems.Add(this.ribbonSeparator2);
            this.c1StatusBar1.Location = new System.Drawing.Point(0, 310);
            this.c1StatusBar1.Name = "c1StatusBar1";
            this.c1StatusBar1.RightPaneItems.Add(this.rbLoad);
            this.c1StatusBar1.RightPaneItems.Add(this.rbSave);
            this.c1StatusBar1.RightPaneItems.Add(this.rbClear);
            this.c1StatusBar1.Size = new System.Drawing.Size(472, 23);
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Text = "Status";
            // 
            // ribbonSeparator1
            // 
            this.ribbonSeparator1.Name = "ribbonSeparator1";
            // 
            // checkStatusLabel
            // 
            this.checkStatusLabel.Name = "checkStatusLabel";
            this.checkStatusLabel.Text = "Checked: <none>";
            // 
            // ribbonSeparator2
            // 
            this.ribbonSeparator2.Name = "ribbonSeparator2";
            // 
            // rbLoad
            // 
            this.rbLoad.Name = "rbLoad";
            this.rbLoad.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbLoad.SmallImage")));
            this.rbLoad.Text = "Load";
            this.rbLoad.Click += new System.EventHandler(this.rbLoad_Click);
            // 
            // rbSave
            // 
            this.rbSave.Name = "rbSave";
            this.rbSave.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbSave.SmallImage")));
            this.rbSave.Text = "Save";
            this.rbSave.Click += new System.EventHandler(this.rbSave_Click);
            // 
            // rbClear
            // 
            this.rbClear.Name = "rbClear";
            this.rbClear.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbClear.SmallImage")));
            this.rbClear.Text = "Clear";
            this.rbClear.Click += new System.EventHandler(this.rbClear_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 124);
            this.label1.TabIndex = 3;
            this.label1.Text = "Demo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c1StatusBar1);
            this.Controls.Add(this.c1Ribbon1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DemoForm";
            this.Text = "Control Host Demo";
            this.Resize += new System.EventHandler(this.DemoForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar1)).EndInit();
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
        private ControlHostLib.NumericUpDownHost numericUpDownHost1;
        private C1.Win.C1Ribbon.C1StatusBar c1StatusBar1;
        private C1.Win.C1Ribbon.RibbonLabel statusLabel;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup2;
        private ControlHostLib.CheckedListBoxHost checkedListBoxHost1;
        private C1.Win.C1Ribbon.RibbonSeparator ribbonSeparator1;
        private C1.Win.C1Ribbon.RibbonLabel checkStatusLabel;
        private C1.Win.C1Ribbon.RibbonSeparator ribbonSeparator2;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup3;
        private ControlHostLib.PictureBoxHost pictureBoxHost1;
        private C1.Win.C1Ribbon.RibbonButton exitButton;
        private C1.Win.C1Ribbon.RibbonTab ribbonTab2;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup4;
        private ControlHostLib.ColorEditorHost backColorEditor;
        private ControlHostLib.ColorEditorHost foreColorEditor;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup5;
        private ControlHostLib.FontEditorHost fontEditor;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1Ribbon.RibbonLabel ribbonLabel1;
        private C1.Win.C1Ribbon.RibbonLabel ribbonLabel2;
        private C1.Win.C1Ribbon.RibbonSeparator ribbonSeparator3;
        private C1.Win.C1Ribbon.RibbonTab ribbonTab3;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup6;
        private ControlHostLib.AxWebBrowserHost axWebBrowserHost1;
        private C1.Win.C1Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.C1Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.C1Ribbon.RibbonButton rbLoad;
        private C1.Win.C1Ribbon.RibbonButton rbSave;
        private C1.Win.C1Ribbon.RibbonButton rbClear;
    }
}

