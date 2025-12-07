using C1.Win.Input;
using FlexGridExplorer.Core;
using System.Drawing;

namespace FlexGridExplorer.Component
{
    partial class SampleViewer
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
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblInfo = new C1Label();
            lblDemo = new C1Label();
            lblTitle = new C1Label();
            pnlViewer = new Panel();
            pnlDemo = new Panel();
            pnlDesc = new Panel();
            sampleDesc = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lblInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblDemo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblTitle).BeginInit();
            pnlViewer.SuspendLayout();
            pnlDesc.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(249, 248, 248);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlViewer, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(18, 4, 18, 4);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1089, 590);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblInfo);
            flowLayoutPanel1.Controls.Add(lblDemo);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(22, 63);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1045, 42);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfo.Location = new Point(3, 3);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(6, 6);
            lblInfo.TabIndex = 0;
            lblInfo.Click += LabelClick;
            lblInfo.Paint += LabelPaint;
            // 
            // lblDemo
            // 
            lblDemo.AutoSize = true;
            lblDemo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDemo.Location = new Point(15, 3);
            lblDemo.Name = "lblDemo";
            lblDemo.Size = new Size(6, 6);
            lblDemo.Styles.Corners = new C1.Framework.Corners(5, 5, 5, 5);
            lblDemo.TabIndex = 1;
            lblDemo.Click += LabelClick;
            lblDemo.Paint += LabelPaint;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI Variable Display", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(21, 7);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1047, 49);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // pnlViewer
            // 
            pnlViewer.Controls.Add(pnlDemo);
            pnlViewer.Controls.Add(pnlDesc);
            pnlViewer.Dock = DockStyle.Fill;
            pnlViewer.Location = new Point(18, 109);
            pnlViewer.Margin = new Padding(0);
            pnlViewer.Name = "pnlViewer";
            pnlViewer.Size = new Size(1053, 477);
            pnlViewer.TabIndex = 2;
            // 
            // pnlDemo
            // 
            pnlDemo.BackColor = Color.FromArgb(243, 242, 242);
            pnlDemo.Dock = DockStyle.Fill;
            pnlDemo.Location = new Point(0, 0);
            pnlDemo.Margin = new Padding(0);
            pnlDemo.Name = "pnlDemo";
            pnlDemo.Padding = new Padding(15);
            pnlDemo.Size = new Size(1053, 477);
            pnlDemo.TabIndex = 2;
            // 
            // pnlDesc
            // 
            pnlDesc.BackColor = Color.FromArgb(249, 248, 248);
            pnlDesc.Controls.Add(sampleDesc);
            pnlDesc.Dock = DockStyle.Fill;
            pnlDesc.Location = new Point(0, 0);
            pnlDesc.Margin = new Padding(0);
            pnlDesc.Name = "pnlDesc";
            pnlDesc.Padding = new Padding(15, 10, 105, 0);
            pnlDesc.Size = new Size(1053, 477);
            pnlDesc.TabIndex = 1;
            // 
            // sampleDesc
            // 
            sampleDesc.BackColor = Color.FromArgb(249, 248, 248);
            sampleDesc.BorderStyle = BorderStyle.None;
            sampleDesc.Dock = DockStyle.Fill;
            sampleDesc.Font = new Font("Segoe UI", 13.8F);
            sampleDesc.Location = new Point(15, 10);
            sampleDesc.Margin = new Padding(4);
            sampleDesc.MaximumSize = new Size(0, 488);
            sampleDesc.MinimumSize = new Size(0, 360);
            sampleDesc.Name = "sampleDesc";
            sampleDesc.ReadOnly = true;
            sampleDesc.Size = new Size(933, 467);
            sampleDesc.TabIndex = 0;
            sampleDesc.Text = "";
            // 
            // SampleHost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 248, 248);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4);
            Name = "SampleHost";
            Size = new Size(1089, 590);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lblInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblDemo).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblTitle).EndInit();
            pnlViewer.ResumeLayout(false);
            pnlDesc.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.Input.C1Label lblTitle;
        private System.Windows.Forms.Panel pnlViewer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlDesc;
        private System.Windows.Forms.Panel pnlDemo;
        private C1.Win.Input.C1Label lblInfo;
        private C1.Win.Input.C1Label lblDemo;
        private System.Windows.Forms.RichTextBox sampleDesc;
    }
}
