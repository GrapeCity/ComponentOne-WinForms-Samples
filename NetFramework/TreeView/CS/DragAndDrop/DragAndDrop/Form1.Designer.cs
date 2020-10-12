namespace DragAndDrop
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
            C1.Win.TreeView.C1TreeColumn c1TreeColumn7 = new C1.Win.TreeView.C1TreeColumn();
            C1.Win.TreeView.C1TreeColumn c1TreeColumn8 = new C1.Win.TreeView.C1TreeColumn();
            this.c1TreeView1 = new C1.Win.TreeView.C1TreeView();
            this.c1TreeView2 = new C1.Win.TreeView.C1TreeView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView2)).BeginInit();
            this.SuspendLayout();
            // 
            // c1TreeView1
            // 
            c1TreeColumn7.DisplayFieldName = null;
            c1TreeColumn7.HeaderText = "Column1";
            c1TreeColumn7.Name = "Column1";
            this.c1TreeView1.Columns.Add(c1TreeColumn7);
            this.c1TreeView1.BindingInfo.DataMember = null;
            this.c1TreeView1.BindingInfo.KeyField = null;
            this.c1TreeView1.Location = new System.Drawing.Point(12, 12);
            this.c1TreeView1.Name = "c1TreeView1";
            this.c1TreeView1.BindingInfo.ParentKeyField = null;
            this.c1TreeView1.Size = new System.Drawing.Size(258, 255);
            this.c1TreeView1.TabIndex = 0;
            // 
            // c1TreeView2
            // 
            c1TreeColumn8.DisplayFieldName = null;
            c1TreeColumn8.HeaderText = "Column1";
            c1TreeColumn8.Name = "Column1";
            this.c1TreeView2.Columns.Add(c1TreeColumn8);
            this.c1TreeView2.BindingInfo.DataMember = null;
            this.c1TreeView2.BindingInfo.KeyField = null;
            this.c1TreeView2.Location = new System.Drawing.Point(302, 12);
            this.c1TreeView2.Name = "c1TreeView2";
            this.c1TreeView2.BindingInfo.ParentKeyField = null;
            this.c1TreeView2.Size = new System.Drawing.Size(263, 255);
            this.c1TreeView2.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Location = new System.Drawing.Point(12, 286);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(553, 96);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 400);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.c1TreeView2);
            this.Controls.Add(this.c1TreeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.TreeView.C1TreeView c1TreeView1;
        private C1.Win.TreeView.C1TreeView c1TreeView2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

