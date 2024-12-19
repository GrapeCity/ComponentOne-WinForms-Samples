using BaseExplorer.Core;
using System.Windows.Forms;

namespace BaseExplorer.Components
{
    partial class TileGroup
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
            panel1 = new Panel();
            lblGroupName = new Label();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = System.Drawing.Color.FromArgb(243, 242, 242);
            panel1.Controls.Add(lblGroupName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1321, 45);
            panel1.TabIndex = 0;
            // 
            // lblGroupName
            // 
            lblGroupName.AutoSize = true;
            lblGroupName.Dock = DockStyle.Fill;
            lblGroupName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblGroupName.Location = new System.Drawing.Point(0, 0);
            lblGroupName.Margin = new Padding(2, 0, 2, 0);
            lblGroupName.Name = "lblGroupName";
            lblGroupName.Size = new System.Drawing.Size(144, 45);
            lblGroupName.TabIndex = 0;
            lblGroupName.Text = "c1Label1";
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = System.Drawing.Color.FromArgb(243, 242, 242);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 45);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1321, 687);
            panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(1321, 687);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // TileGroup
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.FromArgb(243, 242, 242);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(40, 40, 40, 40);
            Name = "TileGroup";
            Size = new System.Drawing.Size(1321, 732);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Label lblGroupName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
