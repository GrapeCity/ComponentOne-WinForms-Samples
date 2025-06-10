namespace DataGridViewVirtualization
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            C1.Win.Input.DbNavigator.Items.NavLabel navLabel1 = new C1.Win.Input.DbNavigator.Items.NavLabel();
            C1.Win.Input.DbNavigator.Items.NavFirstButton navFirstButton1 = new C1.Win.Input.DbNavigator.Items.NavFirstButton();
            C1.Win.Input.DbNavigator.Items.NavPrevButton navPrevButton1 = new C1.Win.Input.DbNavigator.Items.NavPrevButton();
            C1.Win.Input.DbNavigator.Items.NavEditor navEditor1 = new C1.Win.Input.DbNavigator.Items.NavEditor();
            C1.Win.Input.DbNavigator.Items.NavNextButton navNextButton1 = new C1.Win.Input.DbNavigator.Items.NavNextButton();
            C1.Win.Input.DbNavigator.Items.NavLastButton navLastButton1 = new C1.Win.Input.DbNavigator.Items.NavLastButton();
            C1.Win.Input.DbNavigator.Items.NavLabel navLabel2 = new C1.Win.Input.DbNavigator.Items.NavLabel();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            c1DbNavigator1 = new C1.Win.Input.DbNavigator.C1DbNavigator();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1DbNavigator1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1047, 735);
            dataGridView1.TabIndex = 1;
            // 
            // c1DbNavigator1
            // 
            c1DbNavigator1.Dock = DockStyle.Top;
            navLabel1.Text = "Row: ";
            navLabel2.Size = 100;
            c1DbNavigator1.Items.Add(navLabel1);
            c1DbNavigator1.Items.Add(navFirstButton1);
            c1DbNavigator1.Items.Add(navPrevButton1);
            c1DbNavigator1.Items.Add(navEditor1);
            c1DbNavigator1.Items.Add(navNextButton1);
            c1DbNavigator1.Items.Add(navLastButton1);
            c1DbNavigator1.Items.Add(navLabel2);
            c1DbNavigator1.Location = new Point(0, 0);
            c1DbNavigator1.Name = "c1DbNavigator1";
            c1DbNavigator1.Size = new Size(1047, 29);
            c1DbNavigator1.TabIndex = 2;
            c1DbNavigator1.Text = "c1DbNavigator1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 764);
            Controls.Add(dataGridView1);
            Controls.Add(c1DbNavigator1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "DataGridView Virtualization";
            FormClosed += Form1_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1DbNavigator1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private C1.Win.Input.DbNavigator.C1DbNavigator c1DbNavigator1;
    }
}
