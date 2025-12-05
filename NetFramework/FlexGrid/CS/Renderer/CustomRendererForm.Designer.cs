namespace Renderer
{
    partial class CustomRendererForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomRendererForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._btnOK = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnHighlight = new System.Windows.Forms.Button();
            this._btnHeaders = new System.Windows.Forms.Button();
            this._btnSelection = new System.Windows.Forms.Button();
            this._btnHot = new System.Windows.Forms.Button();
            this.c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Highlight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Headers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selection";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hot";
            // 
            // _btnOK
            // 
            this._btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnOK.Location = new System.Drawing.Point(821, 595);
            this._btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(112, 42);
            this._btnOK.TabIndex = 8;
            this._btnOK.Text = "OK";
            this._btnOK.UseVisualStyleBackColor = true;
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(942, 595);
            this._btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(112, 42);
            this._btnCancel.TabIndex = 9;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            // 
            // _btnHighlight
            // 
            this._btnHighlight.Location = new System.Drawing.Point(108, 17);
            this._btnHighlight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnHighlight.Name = "_btnHighlight";
            this._btnHighlight.Size = new System.Drawing.Size(52, 41);
            this._btnHighlight.TabIndex = 1;
            this._btnHighlight.Text = "...";
            this._btnHighlight.UseVisualStyleBackColor = true;
            this._btnHighlight.Click += new System.EventHandler(this._btnHighlight_Click);
            // 
            // _btnHeaders
            // 
            this._btnHeaders.Location = new System.Drawing.Point(108, 67);
            this._btnHeaders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnHeaders.Name = "_btnHeaders";
            this._btnHeaders.Size = new System.Drawing.Size(52, 41);
            this._btnHeaders.TabIndex = 3;
            this._btnHeaders.Text = "...";
            this._btnHeaders.UseVisualStyleBackColor = true;
            this._btnHeaders.Click += new System.EventHandler(this._btnHighlight_Click);
            // 
            // _btnSelection
            // 
            this._btnSelection.Location = new System.Drawing.Point(108, 117);
            this._btnSelection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnSelection.Name = "_btnSelection";
            this._btnSelection.Size = new System.Drawing.Size(52, 41);
            this._btnSelection.TabIndex = 5;
            this._btnSelection.Text = "...";
            this._btnSelection.UseVisualStyleBackColor = true;
            this._btnSelection.Click += new System.EventHandler(this._btnHighlight_Click);
            // 
            // _btnHot
            // 
            this._btnHot.Location = new System.Drawing.Point(108, 167);
            this._btnHot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnHot.Name = "_btnHot";
            this._btnHot.Size = new System.Drawing.Size(52, 41);
            this._btnHot.TabIndex = 7;
            this._btnHot.Text = "...";
            this._btnHot.UseVisualStyleBackColor = true;
            this._btnHot.Click += new System.EventHandler(this._btnHighlight_Click);
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1FlexGrid1.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,95,Columns:0{Width:38;}\t";
            this.c1FlexGrid1.Location = new System.Drawing.Point(170, 17);
            this.c1FlexGrid1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.DefaultSize = 19;
            this.c1FlexGrid1.Size = new System.Drawing.Size(883, 555);
            this.c1FlexGrid1.TabIndex = 10;
            // 
            // CustomRendererForm
            // 
            this.AcceptButton = this._btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(1073, 651);
            this.Controls.Add(this.c1FlexGrid1);
            this.Controls.Add(this._btnHot);
            this.Controls.Add(this._btnSelection);
            this.Controls.Add(this._btnHeaders);
            this.Controls.Add(this._btnHighlight);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomRendererForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Build Renderer";
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _btnOK;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnHighlight;
        private System.Windows.Forms.Button _btnHeaders;
        private System.Windows.Forms.Button _btnSelection;
        private System.Windows.Forms.Button _btnHot;
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
    }
}