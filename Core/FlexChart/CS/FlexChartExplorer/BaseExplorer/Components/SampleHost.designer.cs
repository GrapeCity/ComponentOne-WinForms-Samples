﻿using BaseExplorer.Core;
using System.Drawing;

namespace BaseExplorer.Components
{
    partial class SampleHost
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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            lblInfo = new System.Windows.Forms.Label();
            lblDemo = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            pnlViewer = new System.Windows.Forms.Panel();
            pnlDemo = new System.Windows.Forms.Panel();
            descPnl = new System.Windows.Forms.Panel();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pnlViewer.SuspendLayout();
            descPnl.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(249, 248, 248);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlViewer, 0, 2);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(21, 5, 21, 5);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1245, 787);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblInfo);
            flowLayoutPanel1.Controls.Add(lblDemo);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel1.Location = new Point(26, 63);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1193, 56);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfo.Location = new Point(9, 11);
            lblInfo.Margin = new System.Windows.Forms.Padding(9, 11, 3, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 11);
            lblInfo.Size = new Size(53, 42);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Info";
            lblInfo.Click += LabelClick;
            lblInfo.Paint += LabelPaint;
            // 
            // lblDemo
            // 
            lblDemo.AutoSize = true;
            lblDemo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDemo.Location = new Point(74, 11);
            lblDemo.Margin = new System.Windows.Forms.Padding(9, 11, 3, 0);
            lblDemo.Name = "lblDemo";
            lblDemo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 11);
            lblDemo.Size = new Size(75, 42);
            lblDemo.TabIndex = 1;
            lblDemo.Text = "Demo";
            lblDemo.Click += LabelClick;
            lblDemo.Paint += LabelPaint;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI Variable Display", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(24, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1197, 53);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // pnlViewer
            // 
            pnlViewer.Controls.Add(pnlDemo);
            pnlViewer.Controls.Add(descPnl);
            pnlViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlViewer.Location = new Point(21, 124);
            pnlViewer.Margin = new System.Windows.Forms.Padding(0);
            pnlViewer.Name = "pnlViewer";
            pnlViewer.Size = new Size(1203, 658);
            pnlViewer.TabIndex = 2;
            // 
            // pnlDemo
            // 
            pnlDemo.BackColor = Color.FromArgb(243, 242, 242);
            pnlDemo.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlDemo.Location = new Point(0, 0);
            pnlDemo.Margin = new System.Windows.Forms.Padding(0);
            pnlDemo.Name = "pnlDemo";
            pnlDemo.Size = new Size(1203, 658);
            pnlDemo.TabIndex = 2;
            // 
            // descPnl
            // 
            descPnl.BackColor = Color.FromArgb(249, 248, 248);
            descPnl.Controls.Add(richTextBox1);
            descPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            descPnl.Location = new Point(0, 0);
            descPnl.Margin = new System.Windows.Forms.Padding(0);
            descPnl.Name = "descPnl";
            descPnl.Padding = new System.Windows.Forms.Padding(13, 13, 120, 0);
            descPnl.Size = new Size(1203, 658);
            descPnl.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            richTextBox1.Location = new Point(13, 13);
            richTextBox1.Margin = new System.Windows.Forms.Padding(5);
            richTextBox1.MaximumSize = new Size(0, 650);
            richTextBox1.MinimumSize = new Size(0, 480);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(1070, 645);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // SampleHost
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 248, 248);
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "SampleHost";
            Size = new Size(1245, 787);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            pnlViewer.ResumeLayout(false);
            descPnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlViewer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel descPnl;
        private System.Windows.Forms.Panel pnlDemo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblDemo;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
