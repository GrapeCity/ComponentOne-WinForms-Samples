namespace RibbonPreviewControlDemo
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
            this.rpc = new C1.Win.RibbonPreview.C1RibbonPreview();
            this.atb = new C1.Win.C1Win7Pack.C1TaskbarButton(this.components);
            this.extRegDlg = new C1.Win.C1Win7Pack.C1TaskDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rpc)).BeginInit();
            this.SuspendLayout();
            // 
            // rpc
            // 
            this.rpc.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.rpc.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.rpc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpc.Location = new System.Drawing.Point(0, 0);
            this.rpc.Name = "rpc";
            this.rpc.Size = new System.Drawing.Size(735, 442);
            this.rpc.TabIndex = 0;
            this.rpc.TextSearchStyle = C1.Win.C1Preview.TextSearchUIStyle.ToolBar;
            this.rpc.UserAction += new System.EventHandler<C1.Win.RibbonPreview.UserRibbonPreviewActionEventArgs>(this.rpc_UserAction);
            // 
            // atb
            // 
            this.atb.ContainerForm = this;
            this.atb.RegistryProgID = "RibbonPreviewControlDemo";
            this.atb.WindowAppID = "C1PrintDocViewer";
            // 
            // extRegDlg
            // 
            this.extRegDlg.CheckBoxText = "Don\'t ask me again";
            this.extRegDlg.Content = "\'.c1dx\', \'.c1d\', \'.c1mdx\' file types are not registered.";
            c1CustomButton1.ID = 9;
            c1CustomButton1.Name = "registerButton";
            c1CustomButton1.Note = "Register .c1dx, .c1d, and .c1mdx files with this application to use the Recent Do" +
    "cuments list.";
            c1CustomButton1.Text = "Register file types for this application";
            c1CustomButton2.ID = 10;
            c1CustomButton2.Name = "ignoreButton";
            c1CustomButton2.Note = "You can work without the registration, with empty Recent Documents list.";
            c1CustomButton2.Text = "Do not register the file types";
            this.extRegDlg.CustomButtons.AddRange(new C1.Win.C1Win7Pack.C1CustomButton[] {
            c1CustomButton1,
            c1CustomButton2});
            this.extRegDlg.MainCommonIcon = C1.Win.C1Win7Pack.TaskDialogCommonIcon.Information;
            this.extRegDlg.MainInstruction = "This application needs to register .c1dx, .c1d, .c1mdx files as associated files " +
    "to apply changes to the Jump List.";
            this.extRegDlg.NextID = 11;
            this.extRegDlg.WindowTitle = "C1PrintDocument Viewer Destinations";
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(735, 442);
            this.Controls.Add(this.rpc);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "PreviewForm";
            this.Text = "C1PrintDocument Viewer";
            this.Shown += new System.EventHandler(this.PreviewForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.rpc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.RibbonPreview.C1RibbonPreview rpc;
        private C1.Win.C1Win7Pack.C1TaskbarButton atb;
        private C1.Win.C1Win7Pack.C1TaskDialog extRegDlg;
    }
}

