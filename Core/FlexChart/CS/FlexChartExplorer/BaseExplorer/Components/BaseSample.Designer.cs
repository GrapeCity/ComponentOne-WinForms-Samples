using BaseExplorer.Core;
using System.Drawing;

namespace BaseExplorer.Components
{
    partial class BaseSample
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
            rootPanel = new System.Windows.Forms.TableLayoutPanel();
            pnlControls = new System.Windows.Forms.FlowLayoutPanel();
            pnlMain = new System.Windows.Forms.Panel();
            rootPanel.SuspendLayout();
            SuspendLayout();
            // 
            // rootPanel
            // 
            rootPanel.ColumnCount = 1;
            rootPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            rootPanel.Controls.Add(pnlControls, 0, 1);
            rootPanel.Controls.Add(pnlMain, 0, 2);
            rootPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            rootPanel.Location = new System.Drawing.Point(0, 0);
            rootPanel.Name = "rootPanel";
            rootPanel.RowCount = 3;
            rootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            rootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            rootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            rootPanel.Size = new System.Drawing.Size(1087, 848);
            rootPanel.TabIndex = 0;
            rootPanel.Paint += RootPanelPaint;
            // 
            // pnlControls
            // 
            pnlControls.AutoSize = true;
            pnlControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            pnlControls.BackColor = SkinManager.BackColor;
            pnlControls.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlControls.Location = new System.Drawing.Point(4, 5);
            pnlControls.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlControls.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            pnlControls.Name = "pnlControls";
            pnlControls.Size = new System.Drawing.Size(1079, 1);
            pnlControls.TabIndex = 10;
            pnlControls.Paint += pnlControls_Paint;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = System.Drawing.Color.White;
            pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Location = new System.Drawing.Point(4, 15);
            pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new System.Drawing.Size(1079, 828);
            pnlMain.TabIndex = 2;
            // 
            // BaseSample
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = SkinManager.BackColor;
            Controls.Add(rootPanel);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "BaseSample";
            Size = new System.Drawing.Size(1087, 848);
            SizeChanged += BaseSample_SizeChanged;
            rootPanel.ResumeLayout(false);
            rootPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel rootPanel;
        protected System.Windows.Forms.FlowLayoutPanel pnlControls;
        protected System.Windows.Forms.Panel pnlMain;
    }
}
