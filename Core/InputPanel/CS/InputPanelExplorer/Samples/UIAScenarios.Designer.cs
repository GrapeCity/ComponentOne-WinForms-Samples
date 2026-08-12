// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

namespace InputPanelExplorer.Samples
{
    partial class UIAScenarios
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
            c1InputPanel1 = new C1.Win.InputPanel.C1InputPanel();
            inputGroupHeader1 = new C1.Win.InputPanel.InputGroupHeader();
            inputLabel1 = new C1.Win.InputPanel.InputLabel();
            cmbScenario = new C1.Win.InputPanel.InputComboBox();
            btnRunScenario = new C1.Win.InputPanel.InputButton();
            inputLabel2 = new C1.Win.InputPanel.InputLabel();
            this.lblDescription = new C1.Win.InputPanel.InputLabel();
            inputGroupHeader2 = new C1.Win.InputPanel.InputGroupHeader();
            ((System.ComponentModel.ISupportInitialize)c1InputPanel1).BeginInit();
            SuspendLayout();
            // 
            // c1InputPanel1
            // 
            c1InputPanel1.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            c1InputPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            c1InputPanel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            c1InputPanel1.Items.Add(inputGroupHeader1);
            c1InputPanel1.Items.Add(inputLabel1);
            c1InputPanel1.Items.Add(cmbScenario);
            c1InputPanel1.Items.Add(btnRunScenario);
            c1InputPanel1.Items.Add(inputLabel2);
            this.c1InputPanel1.Items.Add(this.lblDescription);
            c1InputPanel1.Items.Add(inputGroupHeader2);
            c1InputPanel1.Location = new System.Drawing.Point(0, 0);
            c1InputPanel1.Name = "c1InputPanel1";
            c1InputPanel1.Size = new System.Drawing.Size(576, 360);
            c1InputPanel1.TabIndex = 0;
            // 
            // inputGroupHeader1
            // 
            inputGroupHeader1.Text = "Test scenario";
            // 
            // inputLabel1
            // 
            this.inputLabel1.HorizontalAlign = C1.Win.InputPanel.InputContentAlignment.Far;
            this.inputLabel1.Name = "inputLabel1";
            this.inputLabel1.Text = "Scenario:";
            this.inputLabel1.Width = 80;
            // 
            // cmbScenario
            // 
            cmbScenario.Break = C1.Win.InputPanel.BreakType.None;
            cmbScenario.DropDownStyle = C1.Win.InputPanel.InputComboBoxStyle.DropDownList;
            cmbScenario.Width = 215;
            // 
            // btnRunScenario
            // 
            btnRunScenario.Image = Resource1.Run;
            btnRunScenario.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            btnRunScenario.Text = "Run";
            btnRunScenario.Click += BtnRunScenario_Click;
            // 
            // inputLabel2
            // 
            this.inputLabel2.HorizontalAlign = C1.Win.InputPanel.InputContentAlignment.Far;
            this.inputLabel2.Name = "inputLabel2";
            this.inputLabel2.Text = "Description:";
            this.inputLabel2.Width = 80;
            // 
            // lblDescription
            // 
            this.lblDescription.Height = 80;
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Width = 500;
            // 
            // inputGroupHeader2
            // 
            inputGroupHeader2.Text = "Sample for selected scenario";
            // 
            // UIAScenarios
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(c1InputPanel1);
            Name = "UIAScenarios";
            Size = new System.Drawing.Size(576, 360);
            ((System.ComponentModel.ISupportInitialize)c1InputPanel1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private C1.Win.InputPanel.C1InputPanel c1InputPanel1;
        private C1.Win.InputPanel.InputGroupHeader inputGroupHeader1;
        private C1.Win.InputPanel.InputButton btnRunScenario;
        private C1.Win.InputPanel.InputComboBox cmbScenario;
        private C1.Win.InputPanel.InputGroupHeader inputGroupHeader2;
        private C1.Win.InputPanel.InputLabel inputLabel1;
        private C1.Win.InputPanel.InputLabel inputLabel2;
        private C1.Win.InputPanel.InputLabel lblDescription;
    }
}
