namespace CustomDragStart
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
            this._flex = new C1.Win.FlexGrid.C1FlexGrid();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:21;}\t";
            this._flex.Cursor = System.Windows.Forms.Cursors.Default;
            this._flex.Location = new System.Drawing.Point(24, 23);
            this._flex.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._flex.Name = "_flex";
            this._flex.Rows.DefaultSize = 17;
            this._flex.SelectionMode = C1.Win.FlexGrid.SelectionModeEnum.ListBox;
            this._flex.Size = new System.Drawing.Size(590, 669);
            this._flex.TabIndex = 0;
            this._flex.BeforeMouseDown += new C1.Win.FlexGrid.BeforeMouseDownEventHandler(this.c1FlexGrid1_BeforeMouseDown);
            this._flex.MouseMove += new System.Windows.Forms.MouseEventHandler(this.c1FlexGrid1_MouseMove);
            this._flex.MouseUp += new System.Windows.Forms.MouseEventHandler(this.c1FlexGrid1_MouseUp);
            // 
            // richTextBox1
            // 
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Location = new System.Drawing.Point(630, 25);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(624, 667);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 713);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this._flex);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Custom drag/drop mouse behavior ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGrid _flex;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

