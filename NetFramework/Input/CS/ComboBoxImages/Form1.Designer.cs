namespace ComboBoxImages
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.c1ComboBox1 = new C1.Win.C1Input.C1ComboBox();
            this.c1ComboBox2 = new C1.Win.C1Input.C1ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(415, 261);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.c1ComboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(407, 235);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Design Time";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Add items to C1ComboBox.Items collection\r\n2. Add images to the imageList1\r\n3. " +
    "Set keys (Name) of the images equal to the items in C1ComboBox.Items";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Blue");
            this.imageList1.Images.SetKeyName(1, "Green");
            this.imageList1.Images.SetKeyName(2, "Grey");
            this.imageList1.Images.SetKeyName(3, "Red");
            this.imageList1.Images.SetKeyName(4, "Yellow");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.c1ComboBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(407, 235);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Run Time";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // c1ComboBox1
            // 
            this.c1ComboBox1.AutoOpen = false;
            this.c1ComboBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.c1ComboBox1.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.c1ComboBox1.GapHeight = 0;
            this.c1ComboBox1.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1ComboBox1.InitialSelectedIndex = 0;
            this.c1ComboBox1.Items.Add("Blue");
            this.c1ComboBox1.Items.Add("Red");
            this.c1ComboBox1.Items.Add("Green");
            this.c1ComboBox1.Items.Add("Grey");
            this.c1ComboBox1.Items.Add("Yellow");
            this.c1ComboBox1.Items.Add("Transparent");
            this.c1ComboBox1.ItemsDisplayMember = "";
            this.c1ComboBox1.ItemsImageList = this.imageList1;
            this.c1ComboBox1.ItemsValueMember = "";
            this.c1ComboBox1.Location = new System.Drawing.Point(20, 25);
            this.c1ComboBox1.Name = "c1ComboBox1";
            this.c1ComboBox1.Size = new System.Drawing.Size(175, 18);
            this.c1ComboBox1.TabIndex = 0;
            this.c1ComboBox1.Tag = null;
            this.c1ComboBox1.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // c1ComboBox2
            // 
            this.c1ComboBox2.AutoOpen = false;
            this.c1ComboBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.c1ComboBox2.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.c1ComboBox2.GapHeight = 0;
            this.c1ComboBox2.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1ComboBox2.InitialSelectedIndex = 0;
            this.c1ComboBox2.ItemsDisplayMember = "";
            this.c1ComboBox2.ItemsValueMember = "";
            this.c1ComboBox2.Location = new System.Drawing.Point(20, 25);
            this.c1ComboBox2.Name = "c1ComboBox2";
            this.c1ComboBox2.Size = new System.Drawing.Size(175, 18);
            this.c1ComboBox2.TabIndex = 0;
            this.c1ComboBox2.Tag = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "See Form_Load code";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 261);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1Input.C1ComboBox c1ComboBox1;
        private System.Windows.Forms.ImageList imageList1;
        private C1.Win.C1Input.C1ComboBox c1ComboBox2;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label label2;

    }
}

