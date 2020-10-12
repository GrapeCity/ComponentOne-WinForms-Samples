namespace ControlExplorer.Input
{
    partial class DropDownControls
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DropDownControls));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.c1FontPicker1 = new C1.Win.C1Input.C1FontPicker();
            this.c1ColorPicker1 = new C1.Win.C1Input.C1ColorPicker();
            this.c1SplitButtonSpell = new C1.Win.C1Input.C1SplitButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dropDownItemEnglish = new C1.Win.C1Input.DropDownItem();
            this.dropDownItemGerman = new C1.Win.C1Input.DropDownItem();
            this.dropDownItemSpanish = new C1.Win.C1Input.DropDownItem();
            this.dropDownItemRussian = new C1.Win.C1Input.DropDownItem();
            this.dropDownItemSeparator = new C1.Win.C1Input.DropDownItem();
            this.dropDownItemMenu = new C1.Win.C1Input.DropDownItem();
            this.dropDownItemMed = new C1.Win.C1Input.DropDownItem();
            this.dropDownItemBusiness = new C1.Win.C1Input.DropDownItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FontPicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ColorPicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitButtonSpell)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.c1FontPicker1);
            this.panel1.Controls.Add(this.c1ColorPicker1);
            this.panel1.Controls.Add(this.c1SplitButtonSpell);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 96);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Font:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Text Color:";
            // 
            // c1FontPicker1
            // 
            this.c1FontPicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1FontPicker1.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1FontPicker1.Location = new System.Drawing.Point(233, 56);
            this.c1FontPicker1.Name = "c1FontPicker1";
            this.c1FontPicker1.Size = new System.Drawing.Size(200, 24);
            this.c1FontPicker1.TabIndex = 7;
            this.c1FontPicker1.Tag = null;
            this.c1FontPicker1.ValueChanged += new System.EventHandler(this.c1FontPicker1_ValueChanged);
            // 
            // c1ColorPicker1
            // 
            this.c1ColorPicker1.AllowEmpty = false;
            this.c1ColorPicker1.EmptyColorCaption = null;
            this.c1ColorPicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1ColorPicker1.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1ColorPicker1.Location = new System.Drawing.Point(233, 15);
            this.c1ColorPicker1.Name = "c1ColorPicker1";
            this.c1ColorPicker1.Size = new System.Drawing.Size(200, 24);
            this.c1ColorPicker1.TabIndex = 6;
            this.c1ColorPicker1.Tag = null;
            this.c1ColorPicker1.Value = System.Drawing.Color.Transparent;
            this.c1ColorPicker1.ValueChanged += new System.EventHandler(this.c1ColorPicker1_ValueChanged);
            // 
            // c1SplitButtonSpell
            // 
            this.c1SplitButtonSpell.DropDownImageList = this.imageList1;
            this.c1SplitButtonSpell.Image = global::ControlExplorer.Properties.Resources.Action_spellcheck_icon_1_1;
            this.c1SplitButtonSpell.Items.Add(this.dropDownItemEnglish);
            this.c1SplitButtonSpell.Items.Add(this.dropDownItemGerman);
            this.c1SplitButtonSpell.Items.Add(this.dropDownItemSpanish);
            this.c1SplitButtonSpell.Items.Add(this.dropDownItemRussian);
            this.c1SplitButtonSpell.Items.Add(this.dropDownItemSeparator);
            this.c1SplitButtonSpell.Items.Add(this.dropDownItemMenu);
            this.c1SplitButtonSpell.Location = new System.Drawing.Point(12, 12);
            this.c1SplitButtonSpell.Name = "c1SplitButtonSpell";
            this.c1SplitButtonSpell.Size = new System.Drawing.Size(135, 70);
            this.c1SplitButtonSpell.TabIndex = 1;
            this.c1SplitButtonSpell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.c1SplitButtonSpell.UseVisualStyleBackColor = true;
            this.c1SplitButtonSpell.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.c1SplitButtonSpell.DropDownItemClicked += new C1.Win.C1Input.DropDownItemClickedEventHandler(this.c1SplitButtonSpell_DropDownItemClicked);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "flag_great_britain.png");
            this.imageList1.Images.SetKeyName(1, "flag_spain.png");
            this.imageList1.Images.SetKeyName(2, "flag_france.png");
            this.imageList1.Images.SetKeyName(3, "flag_russia.png");
            this.imageList1.Images.SetKeyName(4, "flag_germany.png");
            this.imageList1.Images.SetKeyName(5, "tiny_1286011416_meditsina[1].gif");
            this.imageList1.Images.SetKeyName(6, "user_business_boss[1].png");
            // 
            // dropDownItemEnglish
            // 
            this.dropDownItemEnglish.ImageIndex = 0;
            this.dropDownItemEnglish.ImageKey = "flag_great_britain.png";
            this.dropDownItemEnglish.Text = "English";
            // 
            // dropDownItemGerman
            // 
            this.dropDownItemGerman.ImageKey = "flag_germany.png";
            this.dropDownItemGerman.Text = "German";
            // 
            // dropDownItemSpanish
            // 
            this.dropDownItemSpanish.ImageKey = "flag_spain.png";
            this.dropDownItemSpanish.Text = "Spanish";
            // 
            // dropDownItemRussian
            // 
            this.dropDownItemRussian.ImageKey = "flag_russia.png";
            this.dropDownItemRussian.Text = "Russian";
            // 
            // dropDownItemSeparator
            // 
            this.dropDownItemSeparator.Text = "-";
            // 
            // dropDownItemMenu
            // 
            this.dropDownItemMenu.Items.Add(this.dropDownItemMed);
            this.dropDownItemMenu.Items.Add(this.dropDownItemBusiness);
            this.dropDownItemMenu.Text = "Special";
            // 
            // dropDownItemMed
            // 
            this.dropDownItemMed.ImageKey = "tiny_1286011416_meditsina[1].gif";
            this.dropDownItemMed.Text = "Medical";
            // 
            // dropDownItemBusiness
            // 
            this.dropDownItemBusiness.Enabled = false;
            this.dropDownItemBusiness.ImageKey = "user_business_boss[1].png";
            this.dropDownItemBusiness.Text = "Business";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.richTextBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 96);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2);
            this.panel3.Size = new System.Drawing.Size(835, 531);
            this.panel3.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(831, 527);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // SplitButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 627);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "SplitButton";
            this.Text = "C1SpiltButton Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FontPicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ColorPicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitButtonSpell)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private C1.Win.C1Input.C1SplitButton c1SplitButtonSpell;
        private C1.Win.C1Input.DropDownItem dropDownItemEnglish;
        private C1.Win.C1Input.DropDownItem dropDownItemGerman;
        private C1.Win.C1Input.DropDownItem dropDownItemSpanish;
        private C1.Win.C1Input.DropDownItem dropDownItemRussian;
        private C1.Win.C1Input.DropDownItem dropDownItemSeparator;
        private C1.Win.C1Input.DropDownItem dropDownItemMenu;
        private C1.Win.C1Input.DropDownItem dropDownItemMed;
        private System.Windows.Forms.ImageList imageList1;
        private C1.Win.C1Input.DropDownItem dropDownItemBusiness;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1Input.C1FontPicker c1FontPicker1;
        private C1.Win.C1Input.C1ColorPicker c1ColorPicker1;

    }
}

