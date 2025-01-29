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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuControl));
            topPnl = new Panel();
            btnViewCode = new C1Button();
            pictureBox1 = new PictureBox();
            lblSelectedMenu = new Label();
            menuPanel = new FlowLayoutPanel();
            topPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnViewCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // topPnl
            // 
            topPnl.BackColor = Color.FromArgb(249, 249, 249);
            topPnl.Controls.Add(btnViewCode);
            topPnl.Controls.Add(pictureBox1);
            topPnl.Controls.Add(lblSelectedMenu);
            topPnl.Dock = DockStyle.Top;
            topPnl.Location = new Point(0, 0);
            topPnl.Margin = new Padding(4, 5, 4, 5);
            topPnl.Name = "topPnl";
            topPnl.Size = new Size(1174, 100);
            topPnl.TabIndex = 0;
            // 
            // btnViewCode
            // 
            btnViewCode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnViewCode.Cursor = Cursors.Hand;
            btnViewCode.ImageAlign = ContentAlignment.MiddleLeft;
            btnViewCode.Location = new Point(1022, 20);
            btnViewCode.Name = "btnViewCode";
            btnViewCode.Size = new Size(150, 50);
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
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(106, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblSelectedMenu
            // 
            lblSelectedMenu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSelectedMenu.AutoSize = true;
            lblSelectedMenu.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectedMenu.ForeColor = Color.FromArgb(214, 86, 76);
            lblSelectedMenu.Location = new Point(0, 20);
            lblSelectedMenu.Margin = new Padding(4, 0, 4, 0);
            lblSelectedMenu.Name = "lblSelectedMenu";
            lblSelectedMenu.Size = new Size(79, 31);
            lblSelectedMenu.TabIndex = 0;
            lblSelectedMenu.Text = "label1";
            // 
            // menuPanel
            // 
            menuPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menuPanel.Location = new Point(0, 97);
            menuPanel.Margin = new Padding(4, 5, 4, 5);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(1170, 100);
            menuPanel.TabIndex = 1;
            menuPanel.WrapContents = false;
            // 
            // MenuControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 249, 249);
            Controls.Add(menuPanel);
            Controls.Add(topPnl);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MenuControl";
            Size = new Size(1174, 203);
            topPnl.ResumeLayout(false);
            topPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnViewCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPnl;
        private Label lblSelectedMenu;
        private FlowLayoutPanel menuPanel;
        private PictureBox pictureBox1;
        private C1Button btnViewCode;
    }
}
