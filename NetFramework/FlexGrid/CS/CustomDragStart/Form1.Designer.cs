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
            this._flex = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:21;}\t";
            this._flex.Cursor = System.Windows.Forms.Cursors.Default;
            this._flex.Location = new System.Drawing.Point(12, 12);
            this._flex.Name = "_flex";
            this._flex.Rows.DefaultSize = 17;
            this._flex.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox;
            this._flex.Size = new System.Drawing.Size(297, 350);
            this._flex.TabIndex = 0;
            this._flex.MouseMove += new System.Windows.Forms.MouseEventHandler(this.c1FlexGrid1_MouseMove);
            this._flex.BeforeMouseDown += new C1.Win.C1FlexGrid.BeforeMouseDownEventHandler(this.c1FlexGrid1_BeforeMouseDown);
            this._flex.MouseUp += new System.Windows.Forms.MouseEventHandler(this.c1FlexGrid1_MouseUp);
            // 
            // richTextBox1
            // 
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Location = new System.Drawing.Point(315, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(314, 349);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 371);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this._flex);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Custom drag/drop mouse behavior ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid _flex;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

