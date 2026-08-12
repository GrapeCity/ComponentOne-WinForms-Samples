namespace UIAScenarios
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
            this.c1InputPanel1 = new C1.Win.InputPanel.C1InputPanel();
            this.inputGroupHeader1 = new C1.Win.InputPanel.InputGroupHeader();
            this.inputLabel1 = new C1.Win.InputPanel.InputLabel();
            this.cmbScenario = new C1.Win.InputPanel.InputComboBox();
            this.btnRunScenario = new C1.Win.InputPanel.InputButton();
            this.inputLabel2 = new C1.Win.InputPanel.InputLabel();
            this.lblDescription = new C1.Win.InputPanel.InputLabel();
            this.inputGroupHeader2 = new C1.Win.InputPanel.InputGroupHeader();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1InputPanel1
            // 
            this.c1InputPanel1.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            this.c1InputPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1InputPanel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1InputPanel1.Items.Add(this.inputGroupHeader1);
            this.c1InputPanel1.Items.Add(this.inputLabel1);
            this.c1InputPanel1.Items.Add(this.cmbScenario);
            this.c1InputPanel1.Items.Add(this.btnRunScenario);
            this.c1InputPanel1.Items.Add(this.inputLabel2);
            this.c1InputPanel1.Items.Add(this.lblDescription);
            this.c1InputPanel1.Items.Add(this.inputGroupHeader2);
            this.c1InputPanel1.Location = new System.Drawing.Point(0, 0);
            this.c1InputPanel1.Name = "c1InputPanel1";
            this.c1InputPanel1.Size = new System.Drawing.Size(920, 548);
            this.c1InputPanel1.TabIndex = 1;
            // 
            // inputGroupHeader1
            // 
            this.inputGroupHeader1.Text = "Test scenario";
            // 
            // inputLabel1
            // 
            this.inputLabel1.HorizontalAlign = C1.Win.InputPanel.InputContentAlignment.Far;
            this.inputLabel1.Text = "Scenario:";
            this.inputLabel1.Width = 80;
            // 
            // cmbScenario
            // 
            this.cmbScenario.Break = C1.Win.InputPanel.BreakType.None;
            this.cmbScenario.DropDownStyle = C1.Win.InputPanel.InputComboBoxStyle.DropDownList;
            this.cmbScenario.Width = 215;
            // 
            // btnRunScenario
            // 
            this.btnRunScenario.Image = ((System.Drawing.Image)(resources.GetObject("btnRunScenario.Image")));
            this.btnRunScenario.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnRunScenario.Text = "Run";
            this.btnRunScenario.Click += new System.EventHandler(this.BtnRunScenario_Click);
            // 
            // inputLabel2
            // 
            this.inputLabel2.Height = 80;
            this.inputLabel2.HorizontalAlign = C1.Win.InputPanel.InputContentAlignment.Far;
            this.inputLabel2.Text = "Description:";
            this.inputLabel2.Width = 80;
            // 
            // lblDescription
            // 
            this.lblDescription.Height = 80;
            this.lblDescription.Width = 500;
            // 
            // inputGroupHeader2
            // 
            this.inputGroupHeader2.Text = "Sample for selected scenario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 548);
            this.Controls.Add(this.c1InputPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "UI Automation scenarios";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.InputPanel.C1InputPanel c1InputPanel1;
        private C1.Win.InputPanel.InputGroupHeader inputGroupHeader1;
        private C1.Win.InputPanel.InputLabel inputLabel1;
        private C1.Win.InputPanel.InputComboBox cmbScenario;
        private C1.Win.InputPanel.InputButton btnRunScenario;
        private C1.Win.InputPanel.InputLabel inputLabel2;
        private C1.Win.InputPanel.InputLabel lblDescription;
        private C1.Win.InputPanel.InputGroupHeader inputGroupHeader2;
    }
}

