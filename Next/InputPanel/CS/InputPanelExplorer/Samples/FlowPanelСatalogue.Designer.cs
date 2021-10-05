
namespace InputPanelExplorer.Samples
{
    partial class FlowPanelСatalogue
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.c1InputPanel1 = new C1.Win.InputPanel.C1InputPanel();
            this.inputFlowPanel1 = new C1.Win.InputPanel.InputFlowPanel();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1InputPanel1
            // 
            this.c1InputPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1InputPanel1.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            this.c1InputPanel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1InputPanel1.Items.Add(this.inputFlowPanel1);
            this.c1InputPanel1.Name = "c1InputPanel1";
            this.c1InputPanel1.Size = new System.Drawing.Size(890, 500);
            this.c1InputPanel1.TabIndex = 4;
            // 
            // inputFlowPanel1
            // 
            this.inputFlowPanel1.ChildSpacing = new System.Drawing.Size(15, 15);
            this.inputFlowPanel1.Height = -1;
            this.inputFlowPanel1.Name = "inputFlowPanel1";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(892, 592);
            this.Controls.Add(this.c1InputPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private C1.Win.InputPanel.C1InputPanel c1InputPanel1;
        private C1.Win.InputPanel.InputFlowPanel inputFlowPanel1;

    }
}
