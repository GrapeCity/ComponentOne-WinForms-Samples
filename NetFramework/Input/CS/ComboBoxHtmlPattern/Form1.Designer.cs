namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbxResult = new C1.Win.C1Input.C1ComboBox();
            this._imageList = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSelectSample = new C1.Win.C1Input.C1ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxHtmlPattern = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cbxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSelectSample)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxResult
            // 
            this.cbxResult.AllowSpinLoop = false;
            this.cbxResult.GapHeight = 0;
            this.cbxResult.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbxResult.ItemsDisplayMember = "";
            this.cbxResult.ItemsValueMember = "";
            this.cbxResult.Location = new System.Drawing.Point(13, 101);
            this.cbxResult.Margin = new System.Windows.Forms.Padding(4);
            this.cbxResult.Name = "cbxResult";
            this.cbxResult.Size = new System.Drawing.Size(286, 20);
            this.cbxResult.TabIndex = 0;
            this.cbxResult.Tag = null;
            // 
            // _imageList
            // 
            this._imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this._imageList.ImageSize = new System.Drawing.Size(16, 16);
            this._imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Open drop-down list to see the result:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select a sample:";
            // 
            // cbxSelectSample
            // 
            this.cbxSelectSample.AllowSpinLoop = false;
            this.cbxSelectSample.GapHeight = 0;
            this.cbxSelectSample.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbxSelectSample.ItemsDisplayMember = "";
            this.cbxSelectSample.ItemsValueMember = "";
            this.cbxSelectSample.Location = new System.Drawing.Point(13, 29);
            this.cbxSelectSample.Name = "cbxSelectSample";
            this.cbxSelectSample.Size = new System.Drawing.Size(286, 20);
            this.cbxSelectSample.TabIndex = 3;
            this.cbxSelectSample.Tag = null;
            this.cbxSelectSample.SelectedIndexChanged += new System.EventHandler(this.cbxSelectSample_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(312, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "HtmlPattern:";
            // 
            // tbxHtmlPattern
            // 
            this.tbxHtmlPattern.BackColor = System.Drawing.Color.White;
            this.tbxHtmlPattern.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHtmlPattern.Location = new System.Drawing.Point(313, 29);
            this.tbxHtmlPattern.Multiline = true;
            this.tbxHtmlPattern.Name = "tbxHtmlPattern";
            this.tbxHtmlPattern.ReadOnly = true;
            this.tbxHtmlPattern.Size = new System.Drawing.Size(556, 283);
            this.tbxHtmlPattern.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 315);
            this.Controls.Add(this.tbxHtmlPattern);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxSelectSample);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxResult);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1ComboBox HtmlPattern property sample";
            ((System.ComponentModel.ISupportInitialize)(this.cbxResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSelectSample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Input.C1ComboBox cbxResult;
        private System.Windows.Forms.ImageList _imageList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private C1.Win.C1Input.C1ComboBox cbxSelectSample;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxHtmlPattern;
    }
}

