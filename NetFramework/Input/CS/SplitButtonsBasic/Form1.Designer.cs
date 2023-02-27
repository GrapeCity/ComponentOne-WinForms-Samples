namespace SplitButtonsBasic
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
            this.c1SplitButton1 = new C1.Win.C1Input.C1SplitButton();
            this.dropDownItem1 = new C1.Win.C1Input.DropDownItem();
            this.dropDownItem2 = new C1.Win.C1Input.DropDownItem();
            this.c1Editor1 = new C1.Win.C1Editor.C1Editor();
            ((System.ComponentModel.ISupportInitialize)(this.c1Editor1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1SplitButton1
            // 
            this.c1SplitButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c1SplitButton1.Items.Add(this.dropDownItem1);
            this.c1SplitButton1.Items.Add(this.dropDownItem2);
            this.c1SplitButton1.Location = new System.Drawing.Point(1, 1);
            this.c1SplitButton1.Name = "c1SplitButton1";
            this.c1SplitButton1.Size = new System.Drawing.Size(124, 31);
            this.c1SplitButton1.TabIndex = 0;
            this.c1SplitButton1.Text = "Save";
            this.c1SplitButton1.UseVisualStyleBackColor = true;
            this.c1SplitButton1.DropDownItemClicked += new C1.Win.C1Input.DropDownItemClickedEventHandler(this.c1SplitButton1_DropDownItemClicked);
            // 
            // dropDownItem1
            // 
            this.dropDownItem1.Image = global::SplitButtonsBasic.Properties.Resources.disk_blue;
            this.dropDownItem1.Tag = null;
            this.dropDownItem1.Text = "Save";
            // 
            // dropDownItem2
            // 
            this.dropDownItem2.Tag = null;
            this.dropDownItem2.Text = "Save As...";
            // 
            // c1Editor1
            // 
            this.c1Editor1.Location = new System.Drawing.Point(1, 38);
            this.c1Editor1.Name = "c1Editor1";
            this.c1Editor1.Size = new System.Drawing.Size(726, 385);
            this.c1Editor1.TabIndex = 1;
            this.c1Editor1.Xml = resources.GetString("c1Editor1.Xml");
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 425);
            this.Controls.Add(this.c1Editor1);
            this.Controls.Add(this.c1SplitButton1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Editor1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Input.C1SplitButton c1SplitButton1;
        private C1.Win.C1Input.DropDownItem dropDownItem1;
        private C1.Win.C1Input.DropDownItem dropDownItem2;
        private C1.Win.C1Editor.C1Editor c1Editor1;
    }
}