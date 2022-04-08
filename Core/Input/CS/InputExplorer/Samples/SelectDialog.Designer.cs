
namespace InputExplorer.Samples
{
    partial class SelectDialog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.findText = new C1.Win.Input.C1TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancelButton = new C1.Win.Input.C1Button();
            this.okButton = new C1.Win.Input.C1Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sourceGrid = new System.Windows.Forms.DataGridView();
            this.mainSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findText)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.findText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 54);
            this.panel1.TabIndex = 0;
            // 
            // findText
            // 
            this.findText.Location = new System.Drawing.Point(53, 13);
            this.findText.Name = "findText";
            this.findText.Size = new System.Drawing.Size(283, 23);
            this.findText.TabIndex = 1;
            this.findText.ModalButtonClick += new System.EventHandler(this.findText_ModalButtonClick);
            this.findText.DropDownButtonClick += new System.EventHandler(this.findText_DropDownButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.cancelButton);
            this.panel2.Controls.Add(this.okButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 47);
            this.panel2.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(276, 17);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(195, 17);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.sourceGrid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 257);
            this.panel3.TabIndex = 2;
            // 
            // sourceGrid
            // 
            this.sourceGrid.AllowUserToAddRows = false;
            this.sourceGrid.AllowUserToDeleteRows = false;
            this.sourceGrid.AllowUserToResizeColumns = false;
            this.sourceGrid.AllowUserToResizeRows = false;
            this.sourceGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.sourceGrid.Location = new System.Drawing.Point(11, 0);
            this.sourceGrid.MultiSelect = false;
            this.sourceGrid.Name = "sourceGrid";
            this.sourceGrid.ReadOnly = true;
            this.sourceGrid.RowHeadersVisible = false;
            this.sourceGrid.RowTemplate.Height = 25;
            this.sourceGrid.Size = new System.Drawing.Size(340, 257);
            this.sourceGrid.TabIndex = 0;
            this.sourceGrid.DoubleClick += new System.EventHandler(this.sourceGrid_DoubleClick);
            // 
            // mainSource
            // 
            this.mainSource.CurrentChanged += new System.EventHandler(this.mainSource_CurrentChanged);
            // 
            // SelectDialog
            // 
            this.ClientSize = new System.Drawing.Size(363, 358);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "SelectDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select item";
            this.Load += new System.EventHandler(this.SelectDialog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findText)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sourceGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainSource)).EndInit();
            this.ResumeLayout(false);
            this.AutoScaleDimensions = new System.Drawing.SizeF(96, 96);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private C1.Win.Input.C1TextBox findText;
        private System.Windows.Forms.Label label1;
        private C1.Win.Input.C1Button cancelButton;
        private C1.Win.Input.C1Button okButton;
        private System.Windows.Forms.DataGridView sourceGrid;
        private System.Windows.Forms.BindingSource mainSource;
    }
}