namespace DataManipulation
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelLinks = new System.Windows.Forms.Panel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            panelMain = new System.Windows.Forms.Panel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelLinks
            // 
            panelLinks.BackColor = System.Drawing.Color.White;
            panelLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            panelLinks.Font = new System.Drawing.Font("Calibri", 10F);
            panelLinks.Location = new System.Drawing.Point(0, 0);
            panelLinks.Margin = new System.Windows.Forms.Padding(0);
            panelLinks.Name = "panelLinks";
            panelLinks.Size = new System.Drawing.Size(233, 602);
            panelLinks.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel1.Controls.Add(panelMain, 1, 0);
            tableLayoutPanel1.Controls.Add(panelLinks, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(994, 602);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panelMain
            // 
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Font = new System.Drawing.Font("Calibri", 10F);
            panelMain.Location = new System.Drawing.Point(233, 0);
            panelMain.Margin = new System.Windows.Forms.Padding(0);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(761, 602);
            panelMain.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(994, 602);
            Controls.Add(tableLayoutPanel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Data Manipulation";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLinks;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelMain;

    }
}

