namespace ControlExplorer.Input
{
    partial class DateEdit
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
            this.c1DateEdit1 = new C1.Win.Calendar.C1DateEdit();
            this.lblC1DateEdit = new System.Windows.Forms.Label();
            this.tlpLayout = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit1)).BeginInit();
            this.tlpLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1DateEdit1
            // 
            this.c1DateEdit1.Calendar.DayNameLength = 1;
            this.c1DateEdit1.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            this.c1DateEdit1.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1DateEdit1.Location = new System.Drawing.Point(138, 18);
            this.c1DateEdit1.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.c1DateEdit1.Name = "c1DateEdit1";
            this.c1DateEdit1.Size = new System.Drawing.Size(267, 22);
            this.c1DateEdit1.TabIndex = 0;
            this.c1DateEdit1.Tag = null;
            // 
            // lblC1DateEdit
            // 
            this.lblC1DateEdit.AutoSize = true;
            this.lblC1DateEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblC1DateEdit.Location = new System.Drawing.Point(20, 18);
            this.lblC1DateEdit.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.lblC1DateEdit.Name = "lblC1DateEdit";
            this.lblC1DateEdit.Size = new System.Drawing.Size(78, 22);
            this.lblC1DateEdit.TabIndex = 2;
            this.lblC1DateEdit.Text = "C1DateEdit:";
            this.lblC1DateEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tlpLayout
            // 
            this.tlpLayout.ColumnCount = 2;
            this.tlpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpLayout.Controls.Add(this.lblC1DateEdit, 0, 0);
            this.tlpLayout.Controls.Add(this.c1DateEdit1, 1, 0);
            this.tlpLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpLayout.Margin = new System.Windows.Forms.Padding(4);
            this.tlpLayout.Name = "tlpLayout";
            this.tlpLayout.RowCount = 2;
            this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLayout.Size = new System.Drawing.Size(2147, 947);
            this.tlpLayout.TabIndex = 3;
            // 
            // DateEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2576, 1136);
            this.Controls.Add(this.tlpLayout);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DateEdit";
            this.Text = "DateEdit";
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit1)).EndInit();
            this.tlpLayout.ResumeLayout(false);
            this.tlpLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Calendar.C1DateEdit c1DateEdit1;
        private System.Windows.Forms.Label lblC1DateEdit;
        private System.Windows.Forms.TableLayoutPanel tlpLayout;
    }
}