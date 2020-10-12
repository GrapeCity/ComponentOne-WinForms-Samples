namespace ComboBoxCases._2010
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.c1ComboBox3 = new C1.Win.C1Input.C1ComboBox();
            this.c1ComboBox2 = new C1.Win.C1Input.C1ComboBox();
            this.c1ComboBox1 = new C1.Win.C1Input.C1ComboBox();
            this.c1ComboBox4 = new C1.Win.C1Input.C1ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Canada");
            this.imageList1.Images.SetKeyName(1, "Finland");
            this.imageList1.Images.SetKeyName(2, "France");
            this.imageList1.Images.SetKeyName(3, "Great Britain");
            this.imageList1.Images.SetKeyName(4, "India");
            this.imageList1.Images.SetKeyName(5, "Ireland");
            this.imageList1.Images.SetKeyName(6, "Japan");
            this.imageList1.Images.SetKeyName(7, "Spain");
            this.imageList1.Images.SetKeyName(8, "USA");
            this.imageList1.Images.SetKeyName(9, "EU");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Default:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Html Pattern:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Html:";
            // 
            // c1ComboBox3
            // 
            this.c1ComboBox3.AllowSpinLoop = false;
            this.c1ComboBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1ComboBox3.GapHeight = 0;
            this.c1ComboBox3.HtmlPattern = "";
            this.c1ComboBox3.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1ComboBox3.ItemMode = C1.Win.C1Input.ComboItemMode.Html;
            this.c1ComboBox3.Items.Add("<table><tr><td><b>America</b></td></tr><tr><td><img src=\"USA\" /><img src=\"Canada\"" +
        " /></td></tr></table>");
            this.c1ComboBox3.Items.Add("<table><tr><td><b>Europe</b></td></tr><tr><td><img src=\"EU\" /> <img src=\"Finland\"" +
        " /><img src=\"France\" /><img src=\"Great Britain\" /><img src=\"Ireland\" /><img src=" +
        "\"Spain\" /></td></tr></table>");
            this.c1ComboBox3.Items.Add("<table><tr><td><b>Asia</b></td></tr><tr><td><img src=\"India\" /><img src=\"Japan\" /" +
        "></td></tr></table>");
            this.c1ComboBox3.ItemsDisplayMember = "";
            this.c1ComboBox3.ItemsImageList = this.imageList1;
            this.c1ComboBox3.ItemsValueMember = "";
            this.c1ComboBox3.Location = new System.Drawing.Point(339, 48);
            this.c1ComboBox3.Name = "c1ComboBox3";
            this.c1ComboBox3.Size = new System.Drawing.Size(114, 18);
            this.c1ComboBox3.TabIndex = 4;
            this.c1ComboBox3.Tag = null;
            this.c1ComboBox3.UseItemsBindingSource = false;
            this.c1ComboBox3.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
            this.c1ComboBox3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
            // 
            // c1ComboBox2
            // 
            this.c1ComboBox2.AllowSpinLoop = false;
            this.c1ComboBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1ComboBox2.GapHeight = 0;
            this.c1ComboBox2.HtmlPattern = "<table><tr><td>Country:</td><td><b>{Text}</b></td></tr><tr><td align=\"right\">Flag" +
    ":</td><td><img src=\'{Text}\'></td></tr></table>";
            this.c1ComboBox2.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1ComboBox2.ItemMode = C1.Win.C1Input.ComboItemMode.HtmlPattern;
            this.c1ComboBox2.Items.Add("Canada");
            this.c1ComboBox2.Items.Add("Finland");
            this.c1ComboBox2.Items.Add("France");
            this.c1ComboBox2.Items.Add("Great Britain");
            this.c1ComboBox2.Items.Add("India");
            this.c1ComboBox2.Items.Add("Ireland");
            this.c1ComboBox2.Items.Add("Japan");
            this.c1ComboBox2.Items.Add("Spain");
            this.c1ComboBox2.Items.Add("USA");
            this.c1ComboBox2.ItemsDisplayMember = "";
            this.c1ComboBox2.ItemsImageList = this.imageList1;
            this.c1ComboBox2.ItemsValueMember = "";
            this.c1ComboBox2.Location = new System.Drawing.Point(175, 48);
            this.c1ComboBox2.Name = "c1ComboBox2";
            this.c1ComboBox2.Size = new System.Drawing.Size(114, 18);
            this.c1ComboBox2.TabIndex = 3;
            this.c1ComboBox2.Tag = null;
            this.c1ComboBox2.UseItemsBindingSource = false;
            this.c1ComboBox2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
            this.c1ComboBox2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
            // 
            // c1ComboBox1
            // 
            this.c1ComboBox1.AllowSpinLoop = false;
            this.c1ComboBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1ComboBox1.GapHeight = 0;
            this.c1ComboBox1.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1ComboBox1.Items.Add("Canada");
            this.c1ComboBox1.Items.Add("Finland");
            this.c1ComboBox1.Items.Add("France");
            this.c1ComboBox1.Items.Add("Great Britain");
            this.c1ComboBox1.Items.Add("India");
            this.c1ComboBox1.Items.Add("Ireland");
            this.c1ComboBox1.Items.Add("Japan");
            this.c1ComboBox1.Items.Add("Spain");
            this.c1ComboBox1.Items.Add("USA");
            this.c1ComboBox1.ItemsDisplayMember = "";
            this.c1ComboBox1.ItemsImageList = this.imageList1;
            this.c1ComboBox1.ItemsValueMember = "";
            this.c1ComboBox1.Location = new System.Drawing.Point(12, 48);
            this.c1ComboBox1.Name = "c1ComboBox1";
            this.c1ComboBox1.Size = new System.Drawing.Size(114, 18);
            this.c1ComboBox1.TabIndex = 0;
            this.c1ComboBox1.Tag = null;
            this.c1ComboBox1.UseItemsBindingSource = false;
            this.c1ComboBox1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
            this.c1ComboBox1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
            // 
            // c1ComboBox4
            // 
            this.c1ComboBox4.AllowSpinLoop = true;
            this.c1ComboBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1ComboBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.c1ComboBox4.GapHeight = 0;
            this.c1ComboBox4.HtmlPattern = "<table><tr><td width=80 align=left>{Box}</td><td width=100>{Address}</td><td width=70><b>{City}</b></td><td>{Country}</td></tr><table>";
            this.c1ComboBox4.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1ComboBox4.ItemMode = C1.Win.C1Input.ComboItemMode.HtmlPattern;
            this.c1ComboBox4.ItemsDisplayMember = "Box";
            this.c1ComboBox4.ItemsImageList = this.imageList1;
            this.c1ComboBox4.ItemsValueMember = "Box";
            this.c1ComboBox4.Location = new System.Drawing.Point(175, 129);
            this.c1ComboBox4.Name = "c1ComboBox4";
            this.c1ComboBox4.Size = new System.Drawing.Size(278, 18);
            this.c1ComboBox4.TabIndex = 7;
            this.c1ComboBox4.Tag = null;
            this.c1ComboBox4.UseItemsBindingSource = false;
            //this.c1ComboBox4.VisibleButtons = ((C1.Win.C1Input.DropDownControlButtonFlags)((C1.Win.C1Input.DropDownControlButtonFlags.UpDown | C1.Win.C1Input.DropDownControlButtonFlags.DropDown)));
            this.c1ComboBox4.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
            this.c1ComboBox4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Multi column Html Pattern:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 194);
            this.Controls.Add(this.c1ComboBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.c1ComboBox3);
            this.Controls.Add(this.c1ComboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c1ComboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Input.C1ComboBox c1ComboBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private C1.Win.C1Input.C1ComboBox c1ComboBox2;
        private C1.Win.C1Input.C1ComboBox c1ComboBox3;
        private System.Windows.Forms.Label label3;
        private C1.Win.C1Input.C1ComboBox c1ComboBox4;
        private System.Windows.Forms.Label label4;
    }
}

