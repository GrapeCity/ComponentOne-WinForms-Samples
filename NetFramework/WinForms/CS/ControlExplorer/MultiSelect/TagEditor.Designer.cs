namespace ControlExplorer.MultiSelect
{
    partial class TagEditor
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
            this.c1TagEditor1 = new C1.Win.Input.C1TagEditor();
            this.c1SuperErrorProvider1 = new C1.Win.C1SuperTooltip.C1SuperErrorProvider(this.components);
            this.c1SuperTooltip1 = new C1.Win.C1SuperTooltip.C1SuperTooltip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.c1SuperErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1TagEditor1
            // 
            this.c1TagEditor1.Location = new System.Drawing.Point(12, 23);
            this.c1TagEditor1.Name = "c1TagEditor1";
            this.c1TagEditor1.Placeholder = "Add Tag";
            this.c1TagEditor1.Size = new System.Drawing.Size(260, 60);
            this.c1TagEditor1.TabIndex = 0;
            this.c1TagEditor1.Text = "Add Tag";
            // 
            // c1SuperErrorProvider1
            // 
            this.c1SuperErrorProvider1.ContainerControl = this;
            this.c1SuperErrorProvider1.ToolTip = this.c1SuperTooltip1;
            // 
            // c1SuperTooltip1
            // 
            this.c1SuperTooltip1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.c1SuperTooltip1.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            // 
            // TagEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 652);
            this.Controls.Add(this.c1TagEditor1);
            this.Name = "TagEditor";
            this.Text = "TagEditor";
            ((System.ComponentModel.ISupportInitialize)(this.c1SuperErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Input.C1TagEditor c1TagEditor1;
        private C1.Win.C1SuperTooltip.C1SuperErrorProvider c1SuperErrorProvider1;
        private C1.Win.C1SuperTooltip.C1SuperTooltip c1SuperTooltip1;
    }
}