using C1.Win.Input;
using System.Drawing;
using System.Windows.Forms;

namespace ControlExplorer.Controls
{
    partial class MenuControl
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
            topPnl = new Panel();
            btnInfo = new C1Button();
            btnViewCode = new C1Button();
            lblSelectedMenu = new Label();
            menuPanel = new FlowLayoutPanel();
            topPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnViewCode).BeginInit();
            SuspendLayout();
            // 
            // topPnl
            // 
            topPnl.BackColor = Color.FromArgb(249, 249, 249);
            topPnl.Controls.Add(btnInfo);
            topPnl.Controls.Add(btnViewCode);
            topPnl.Controls.Add(lblSelectedMenu);
            topPnl.Dock = DockStyle.Top;
            topPnl.Location = new Point(0, 0);
            topPnl.Name = "topPnl";
            topPnl.Size = new Size(822, 60);
            topPnl.TabIndex = 0;
            // 
            // btnInfo
            //
            btnInfo.Location = new Point(106, 13);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(31, 29);
            btnInfo.Styles.Border = new C1.Framework.Thickness(0, 0, 0, 0);
            btnInfo.Styles.Default.BackColor = Color.FromArgb(249, 249, 249);
            btnInfo.Styles.Hot.BackColor = Color.Transparent;
            btnInfo.Styles.Hot.BorderColor = Color.Transparent;
            btnInfo.Styles.HotPressed.BackColor = Color.Transparent;
            btnInfo.Styles.HotPressed.BorderColor = Color.Transparent;
            btnInfo.Styles.Pressed.BackColor = Color.Transparent;
            btnInfo.Styles.Pressed.BorderColor = Color.Transparent;
            btnInfo.TabIndex = 1;
            // 
            // btnViewCode
            //
            btnViewCode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnViewCode.Cursor = Cursors.Hand;
            btnViewCode.ImageAlign = ContentAlignment.MiddleLeft;
            btnViewCode.Location = new Point(715, 12);
            btnViewCode.Name = "btnViewCode";
            btnViewCode.Size = new Size(105, 30);
            btnViewCode.Styles.Hot.BackColor = SystemColors.ButtonFace;
            btnViewCode.Styles.Hot.BorderColor = Color.FromArgb(184, 184, 184);
            btnViewCode.Styles.HotPressed.BackColor = Color.FromArgb(253, 253, 253);
            btnViewCode.Styles.HotPressed.BorderColor = Color.FromArgb(184, 184, 184);
            btnViewCode.Styles.Padding = new C1.Framework.Thickness(5, 3, 5, 3);
            btnViewCode.Styles.Pressed.BackColor = Color.FromArgb(253, 253, 253);
            btnViewCode.Styles.Pressed.BorderColor = Color.FromArgb(184, 184, 184);
            btnViewCode.Styles.ShowFocusBorder = true;
            btnViewCode.TabIndex = 0;
            btnViewCode.TabStop = false;
            btnViewCode.Text = "View Code";
            btnViewCode.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSelectedMenu
            // 
            lblSelectedMenu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSelectedMenu.AutoSize = true;
            lblSelectedMenu.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectedMenu.ForeColor = Color.FromArgb(214, 86, 76);
            lblSelectedMenu.Location = new Point(0, 12);
            lblSelectedMenu.Name = "lblSelectedMenu";
            lblSelectedMenu.Size = new Size(51, 20);
            lblSelectedMenu.TabIndex = 0;
            lblSelectedMenu.Text = "label1";
            // 
            // menuPanel
            // 
            menuPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menuPanel.Location = new Point(0, 58);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(819, 60);
            menuPanel.TabIndex = 1;
            menuPanel.WrapContents = false;
            // 
            // MenuControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 249, 249);
            Controls.Add(menuPanel);
            Controls.Add(topPnl);
            Name = "MenuControl";
            Size = new Size(822, 122);
            topPnl.ResumeLayout(false);
            topPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnViewCode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPnl;
        private Label lblSelectedMenu;
        private FlowLayoutPanel menuPanel;
        private C1Button btnViewCode;
        private C1Button btnInfo;
    }
}
