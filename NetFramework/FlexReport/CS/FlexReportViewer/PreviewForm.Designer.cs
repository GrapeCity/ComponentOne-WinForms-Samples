namespace FlexReportViewer
{
    partial class PreviewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            C1.Win.C1Win7Pack.C1CustomButton c1CustomButton1 = new C1.Win.C1Win7Pack.C1CustomButton();
            C1.Win.C1Win7Pack.C1CustomButton c1CustomButton2 = new C1.Win.C1Win7Pack.C1CustomButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewForm));
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this.fv = new C1.Win.FlexViewer.C1FlexViewer();
            this.atb = new C1.Win.C1Win7Pack.C1TaskbarButton(this.components);
            this.extRegDlg = new C1.Win.C1Win7Pack.C1TaskDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fv)).BeginInit();
            this.SuspendLayout();
            // 
            // fv
            // 
            this.fv.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.fv.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.fv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fv.Location = new System.Drawing.Point(0, 0);
            this.fv.Name = "fv";
            this.fv.Size = new System.Drawing.Size(902, 545);
            this.fv.TabIndex = 0;
            // 
            // atb
            // 
            this.atb.ContainerForm = this;
            this.atb.RegistryProgID = "FlexReportViewer";
            this.atb.WindowAppID = "FlexReportViewer";
            // 
            // extRegDlg
            // 
            this.extRegDlg.CheckBoxText = "Don\'t ask me again";
            this.extRegDlg.Content = "\'.flxr\' file type is not registered.";
            c1CustomButton1.ID = 9;
            c1CustomButton1.Name = "registerButton";
            c1CustomButton1.Note = "Register .flxr files with this application to use the Recent Documents list.";
            c1CustomButton1.Text = "Register file type for this application";
            c1CustomButton2.ID = 10;
            c1CustomButton2.Name = "ignoreButton";
            c1CustomButton2.Note = "You can work without the registration, with empty Recent Documents list.";
            c1CustomButton2.Text = "Do not register the file types";
            this.extRegDlg.CustomButtons.AddRange(new C1.Win.C1Win7Pack.C1CustomButton[] {
            c1CustomButton1,
            c1CustomButton2});
            this.extRegDlg.MainCommonIcon = C1.Win.C1Win7Pack.TaskDialogCommonIcon.Information;
            this.extRegDlg.MainInstruction = "This application needs to register .flxr files as associated files to apply chang" +
    "es to the Jump List.";
            this.extRegDlg.NextID = 11;
            this.extRegDlg.WindowTitle = "FlexReport Viewer Destinations";
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(902, 545);
            this.Controls.Add(this.fv);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "PreviewForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PreviewForm_FormClosing);
            this.Shown += new System.EventHandler(this.PreviewForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.fv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.FlexViewer.C1FlexViewer fv;
        private C1.Win.C1Win7Pack.C1TaskbarButton atb;
        private C1.Win.C1Win7Pack.C1TaskDialog extRegDlg;
    }
}

