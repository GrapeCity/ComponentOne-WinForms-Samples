using System.Windows.Forms;

namespace WordPad.BackstageTabs.Items
{
    partial class BackstageTab
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
            this.tablePanel = new TableLayoutPanel();
            this.tabButton1 = new WordPad.BackstageTabs.Items.ItemButton();
            this.lblCaption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tablePanel
            // 
            this.tablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
              | System.Windows.Forms.AnchorStyles.Left)
              | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.tablePanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tablePanel.Location = new System.Drawing.Point(22, 121);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(540, 167);
            this.tablePanel.TabIndex = 2;
            this.tablePanel.ColumnCount = 1;
            // 
            // tabButton1
            // 
            this.tabButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.tabButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tabButton1.ItemImage = null;
            this.tabButton1.ItemText = "label1";
            this.tabButton1.Location = new System.Drawing.Point(32, 75);
            this.tabButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabButton1.Name = "tabButton1";
            this.tabButton1.Size = new System.Drawing.Size(380, 40);
            this.tabButton1.TabIndex = 0;
            this.tabButton1.Click += new System.EventHandler(this.menuButton1_Click);
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.lblCaption.Location = new System.Drawing.Point(21, 7);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(155, 65);
            this.lblCaption.TabIndex = 2;
            this.lblCaption.Text = "label1";
            // 
            // BackstageTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.tabButton1);
            this.Name = "BackstageTab";
            this.Size = new System.Drawing.Size(579, 291);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ItemButton tabButton1;
        private TableLayoutPanel tablePanel;
        private System.Windows.Forms.Label lblCaption;
    }
}
