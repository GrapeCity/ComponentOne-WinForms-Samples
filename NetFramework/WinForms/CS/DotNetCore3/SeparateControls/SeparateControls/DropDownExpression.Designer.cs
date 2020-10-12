namespace SeparateControls
{
    partial class DropDownExpression
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
                _dialog.Dispose();
                DetachEvents();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.c1ExpressionEditor1 = new C1.Win.ExpressionEditor.C1ExpressionEditor();
            this.c1Button1 = new C1.Win.C1Input.C1Button();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1ExpressionEditor1
            // 
            this.c1ExpressionEditor1.DataSource = null;
            this.c1ExpressionEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1ExpressionEditor1.Location = new System.Drawing.Point(0, 0);
            this.c1ExpressionEditor1.Name = "c1ExpressionEditor1";
            this.c1ExpressionEditor1.ShowErrorBox = false;
            this.c1ExpressionEditor1.Size = new System.Drawing.Size(197, 31);
            this.c1ExpressionEditor1.TabIndex = 0;
            this.c1ExpressionEditor1.Text = "c1ExpressionEditor1";
            // 
            // c1Button1
            // 
            this.c1Button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.c1Button1.Image = global::SeparateControls.Properties.Resources.Arrow;
            this.c1Button1.Location = new System.Drawing.Point(197, 0);
            this.c1Button1.Name = "c1Button1";
            this.c1Button1.Size = new System.Drawing.Size(23, 31);
            this.c1Button1.TabIndex = 1;
            this.c1Button1.UseVisualStyleBackColor = true;
            this.c1Button1.Click += new System.EventHandler(this.c1Button1_Click);
            // 
            // DropDownExpression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1ExpressionEditor1);
            this.Controls.Add(this.c1Button1);
            this.Name = "DropDownExpression";
            this.Size = new System.Drawing.Size(220, 31);
            ((System.ComponentModel.ISupportInitialize)(this.c1Button1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private C1.Win.ExpressionEditor.C1ExpressionEditor c1ExpressionEditor1;
        private C1.Win.C1Input.C1Button c1Button1;
    }
}
