namespace MultigridPage
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
            this.flexCategories = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.flexEmployees = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flexCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flexEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // flexCategories
            // 
            this.flexCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flexCategories.ColumnInfo = "10,1,0,0,0,130,Columns:";
            this.flexCategories.Location = new System.Drawing.Point(12, 36);
            this.flexCategories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flexCategories.Name = "flexCategories";
            this.flexCategories.Rows.DefaultSize = 26;
            this.flexCategories.Size = new System.Drawing.Size(805, 192);
            this.flexCategories.StyleInfo = resources.GetString("flexCategories.StyleInfo");
            this.flexCategories.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categories";
            // 
            // flexEmployees
            // 
            this.flexEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flexEmployees.ColumnInfo = "10,1,0,0,0,130,Columns:";
            this.flexEmployees.Location = new System.Drawing.Point(12, 257);
            this.flexEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flexEmployees.Name = "flexEmployees";
            this.flexEmployees.Rows.DefaultSize = 26;
            this.flexEmployees.Size = new System.Drawing.Size(805, 199);
            this.flexEmployees.StyleInfo = resources.GetString("flexEmployees.StyleInfo");
            this.flexEmployees.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employees";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 464);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 538);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flexEmployees);
            this.Controls.Add(this.flexCategories);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Two Grids on a Page";
            ((System.ComponentModel.ISupportInitialize)(this.flexCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flexEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid flexCategories;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1FlexGrid.C1FlexGrid flexEmployees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

