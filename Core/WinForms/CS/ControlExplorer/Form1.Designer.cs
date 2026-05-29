// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

namespace ControlExplorer
{
    partial class Explorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Explorer));
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            sideBar1 = new ControlExplorer.Controls.SideBar();
            panel1 = new System.Windows.Forms.Panel();
            homePageControl1 = new ControlExplorer.Controls.HomePageControl();
            demoViewer1 = new ControlExplorer.Controls.DemoViewer();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(sideBar1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 5);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1478, 756);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // sideBar1
            // 
            sideBar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            sideBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            sideBar1.Location = new System.Drawing.Point(2, 2);
            sideBar1.Margin = new System.Windows.Forms.Padding(2);
            sideBar1.Name = "sideBar1";
            sideBar1.Size = new System.Drawing.Size(400, 752);
            sideBar1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(homePageControl1);
            panel1.Controls.Add(demoViewer1);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(404, 0);
            panel1.Margin = new System.Windows.Forms.Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1074, 756);
            panel1.TabIndex = 1;
            // 
            // homePageControl1
            // 
            homePageControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            homePageControl1.Location = new System.Drawing.Point(0, 0);
            homePageControl1.Margin = new System.Windows.Forms.Padding(0);
            homePageControl1.Name = "homePageControl1";
            homePageControl1.Padding = new System.Windows.Forms.Padding(26, 22, 26, 22);
            homePageControl1.Size = new System.Drawing.Size(1074, 756);
            homePageControl1.TabIndex = 1;
            // 
            // demoViewer1
            // 
            demoViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            demoViewer1.Location = new System.Drawing.Point(0, 0);
            demoViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            demoViewer1.Name = "demoViewer1";
            demoViewer1.Size = new System.Drawing.Size(1074, 756);
            demoViewer1.TabIndex = 1;
            // 
            // Explorer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonFace;
            ClientSize = new System.Drawing.Size(1484, 766);
            Controls.Add(tableLayoutPanel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MinimumSize = new System.Drawing.Size(1500, 805);
            Name = "Explorer";
            Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controls.SideBar sideBar1;
        private System.Windows.Forms.Panel panel1;
        private Controls.HomePageControl homePageControl1;
        private Controls.DemoViewer demoViewer1;
    }
}