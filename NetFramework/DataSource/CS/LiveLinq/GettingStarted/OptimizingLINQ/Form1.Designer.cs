namespace OptimizingLINQ
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

            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this.btnFind = new System.Windows.Forms.Button();
            this.btnFindIndexing = new System.Windows.Forms.Button();
            this.lbxResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFind.Location = new System.Drawing.Point(57, 43);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(347, 28);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "Find all orders for the first customer";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnFindIndexing
            // 
            this.btnFindIndexing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFindIndexing.Location = new System.Drawing.Point(57, 114);
            this.btnFindIndexing.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindIndexing.Name = "btnFindIndexing";
            this.btnFindIndexing.Size = new System.Drawing.Size(347, 28);
            this.btnFindIndexing.TabIndex = 1;
            this.btnFindIndexing.Text = "Find all orders for the first customer (using indexing)";
            this.btnFindIndexing.UseVisualStyleBackColor = true;
            this.btnFindIndexing.Click += new System.EventHandler(this.btnFindIndexing_Click);
            // 
            // lbxResult
            // 
            this.lbxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxResult.HorizontalScrollbar = true;
            this.lbxResult.ItemHeight = 16;
            this.lbxResult.Location = new System.Drawing.Point(7, 186);
            this.lbxResult.Name = "lbxResult";
            this.lbxResult.Size = new System.Drawing.Size(449, 80);
            this.lbxResult.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 273);
            this.Controls.Add(this.lbxResult);
            this.Controls.Add(this.btnFindIndexing);
            this.Controls.Add(this.btnFind);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Improve LINQ performance using indexing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnFindIndexing;
        private System.Windows.Forms.ListBox lbxResult;
    }
}

