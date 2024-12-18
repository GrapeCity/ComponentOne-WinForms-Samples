using BaseExplorer.Components;
using System.Drawing;

namespace BaseExplorer
{
    partial class BaseForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            sideBarOptions = new SideBar();
            panel1 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            sampleHost21 = new SampleHost();
            tileControl1 = new TileControl();
            panel2 = new System.Windows.Forms.Panel();
            btnToggleTheme = new C1.Win.Input.C1Button();
            imageList1 = new System.Windows.Forms.ImageList(components);
            c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnToggleTheme).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1ThemeController1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(249, 248, 248);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(sideBarOptions, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // sideBarOptions
            // 
            sideBarOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            sideBarOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            sideBarOptions.Location = new Point(0, 0);
            sideBarOptions.Margin = new System.Windows.Forms.Padding(0);
            sideBarOptions.Name = "sideBarOptions";
            sideBarOptions.Samples = null;
            sideBarOptions.Size = new Size(320, 450);
            sideBarOptions.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 248, 248);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new Point(320, 0);
            panel1.Margin = new System.Windows.Forms.Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 450);
            panel1.TabIndex = 1;
            panel1.Paint += PaintPanel;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(249, 248, 248);
            panel4.Controls.Add(sampleHost21);
            panel4.Controls.Add(tileControl1);
            panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            panel4.Location = new Point(0, 80);
            panel4.Margin = new System.Windows.Forms.Padding(40, 40, 40, 40);
            panel4.Name = "panel4";
            panel4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            panel4.Size = new Size(480, 370);
            panel4.TabIndex = 3;
            // 
            // sampleHost21
            // 
            sampleHost21.BackColor = Color.FromArgb(249, 248, 248);
            sampleHost21.Dock = System.Windows.Forms.DockStyle.Fill;
            sampleHost21.Font = new Font("Segoe UI", 14F);
            sampleHost21.ForeColor = Color.FromArgb(32, 32, 32);
            sampleHost21.Location = new Point(2, 2);
            sampleHost21.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            sampleHost21.Name = "sampleHost21";
            sampleHost21.Size = new Size(476, 366);
            sampleHost21.TabIndex = 2;
            // 
            // tileControl1
            // 
            tileControl1.AutoScroll = true;
            tileControl1.BackColor = Color.FromArgb(249, 248, 248);
            tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tileControl1.HoverColor = Color.Empty;
            tileControl1.Location = new Point(2, 2);
            tileControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            tileControl1.Name = "tileControl1";
            tileControl1.Size = new Size(476, 366);
            tileControl1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(249, 248, 248);
            panel2.Controls.Add(btnToggleTheme);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new System.Windows.Forms.Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(480, 80);
            panel2.TabIndex = 0;
            // 
            // btnToggleTheme
            // 
            btnToggleTheme.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnToggleTheme.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnToggleTheme.Icon = new C1.Framework.C1BitmapIcon(null, new Size(16, 16), Color.Transparent, (Image)resources.GetObject("btnToggleTheme.Icon"));
            btnToggleTheme.ImageAlign = ContentAlignment.MiddleLeft;
            btnToggleTheme.Location = new Point(293, 22);
            btnToggleTheme.Name = "btnToggleTheme";
            btnToggleTheme.Size = new Size(151, 42);
            btnToggleTheme.Styles.Padding = new C1.Framework.Thickness(5, 5, 5, 5);
            btnToggleTheme.TabIndex = 4;
            btnToggleTheme.Text = "Toggle Theme";
            btnToggleTheme.Click += _toggleBtn_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "dark_icon.png");
            imageList1.Images.SetKeyName(1, "light_icon.png");
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 242, 242);
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            Name = "BaseForm";
            Text = "BaseForm2";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnToggleTheme).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1ThemeController1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Components.SideBar sideBarOptions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private C1.Win.Input.C1Button btnToggleTheme;
        private System.Windows.Forms.Panel panel4;
        private SampleHost sampleHost21;
        private TileControl tileControl1;
        private System.Windows.Forms.ImageList imageList1;
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
    }
}