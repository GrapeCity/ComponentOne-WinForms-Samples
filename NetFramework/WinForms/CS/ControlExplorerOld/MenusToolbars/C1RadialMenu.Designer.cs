namespace ControlExplorer.MenusToolbars
{
    partial class C1RadialMenu
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
            this.c1RadialMenu1 = new C1.Win.C1Command.C1RadialMenu();
            this.radialMenuItem1 = new C1.Win.C1Command.RadialMenuItem();
            this.radialMenuCommandItem1 = new C1.Win.C1Command.RadialMenuCommandItem();
            this.radialMenuCommandItem2 = new C1.Win.C1Command.RadialMenuCommandItem();
            this.radialMenuCommandItem3 = new C1.Win.C1Command.RadialMenuCommandItem();
            this.radialMenuCommandItem4 = new C1.Win.C1Command.RadialMenuCommandItem();
            this.radialMenuCommandItem5 = new C1.Win.C1Command.RadialMenuCommandItem();
            this.radialMenuCommandItem6 = new C1.Win.C1Command.RadialMenuCommandItem();
            this.radialMenuCommandItem7 = new C1.Win.C1Command.RadialMenuCommandItem();
            this.radialMenuCommandItem8 = new C1.Win.C1Command.RadialMenuCommandItem();
            this.c1ThemeController1 = new C1.Win.C1Themes.C1ThemeController();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1RadialMenu1
            // 
            this.c1RadialMenu1.ButtonRadius = 26;
            this.c1RadialMenu1.Image = global::ControlExplorer.Properties.Resources.User;
            this.c1RadialMenu1.Items.Add(this.radialMenuItem1);
            this.c1RadialMenu1.Items.Add(this.radialMenuCommandItem5);
            this.c1RadialMenu1.Items.Add(this.radialMenuCommandItem6);
            this.c1RadialMenu1.Items.Add(this.radialMenuCommandItem7);
            this.c1RadialMenu1.Items.Add(this.radialMenuCommandItem8);
            this.c1ThemeController1.SetTheme(this.c1RadialMenu1, "(default)");
            this.c1RadialMenu1.ItemClick += new C1.Win.C1Command.RadialMenuItemClickEventHandler(this.c1RadialMenu1_ItemClick);
            // 
            // radialMenuItem1
            // 
            this.radialMenuItem1.Image = global::ControlExplorer.Properties.Resources.FontColor;
            this.radialMenuItem1.Items.Add(this.radialMenuCommandItem1);
            this.radialMenuItem1.Items.Add(this.radialMenuCommandItem2);
            this.radialMenuItem1.Items.Add(this.radialMenuCommandItem3);
            this.radialMenuItem1.Items.Add(this.radialMenuCommandItem4);
            this.radialMenuItem1.Name = "radialMenuItem1";
            this.radialMenuItem1.Text = "Fonts";
            // 
            // radialMenuCommandItem1
            // 
            this.radialMenuCommandItem1.Image = global::ControlExplorer.Properties.Resources.Bold;
            this.radialMenuCommandItem1.Text = "Bold";
            // 
            // radialMenuCommandItem2
            // 
            this.radialMenuCommandItem2.Image = global::ControlExplorer.Properties.Resources.Strikethrough;
            this.radialMenuCommandItem2.Text = "Strike Through";
            // 
            // radialMenuCommandItem3
            // 
            this.radialMenuCommandItem3.Image = global::ControlExplorer.Properties.Resources.Italic;
            this.radialMenuCommandItem3.Text = "Itallic";
            // 
            // radialMenuCommandItem4
            // 
            this.radialMenuCommandItem4.Image = global::ControlExplorer.Properties.Resources.Underline;
            this.radialMenuCommandItem4.Text = "Underline";
            // 
            // radialMenuCommandItem5
            // 
            this.radialMenuCommandItem5.Image = global::ControlExplorer.Properties.Resources.FirstRecord;
            this.radialMenuCommandItem5.Text = "First";
            // 
            // radialMenuCommandItem6
            // 
            this.radialMenuCommandItem6.Image = global::ControlExplorer.Properties.Resources.play;
            this.radialMenuCommandItem6.Text = "Play";
            // 
            // radialMenuCommandItem7
            // 
            this.radialMenuCommandItem7.Image = global::ControlExplorer.Properties.Resources.LastRecord;
            this.radialMenuCommandItem7.Text = "Last";
            // 
            // radialMenuCommandItem8
            // 
            this.radialMenuCommandItem8.Image = global::ControlExplorer.Properties.Resources.Close2;
            this.radialMenuCommandItem8.Text = "Close";
            // 
            // c1ThemeController1
            // 
            this.c1ThemeController1.Theme = "ExpressionLight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(664, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Right Click anywhere on the form the open the C1RadialMenu control.";
            this.c1ThemeController1.SetTheme(this.label1, "(default)");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(634, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Left Click anywhere on the form to close the C1RadialMenu control";
            this.c1ThemeController1.SetTheme(this.label2, "(default)");
            // 
            // C1RadialMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 264);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "C1RadialMenu";
            this.Text = "C1RadialMenu";
            this.c1ThemeController1.SetTheme(this, "(default)");
            this.Load += new System.EventHandler(this.C1RadialMenu_Load);
            this.Leave += new System.EventHandler(this.C1RadialMenu_Leave);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.C1RadialMenu_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Command.C1RadialMenu c1RadialMenu1;
        private C1.Win.C1Command.RadialMenuItem radialMenuItem1;
        private C1.Win.C1Command.RadialMenuCommandItem radialMenuCommandItem1;
        private C1.Win.C1Command.RadialMenuCommandItem radialMenuCommandItem2;
        private C1.Win.C1Command.RadialMenuCommandItem radialMenuCommandItem3;
        private C1.Win.C1Command.RadialMenuCommandItem radialMenuCommandItem4;
        private C1.Win.C1Command.RadialMenuCommandItem radialMenuCommandItem5;
        private C1.Win.C1Command.RadialMenuCommandItem radialMenuCommandItem6;
        private C1.Win.C1Command.RadialMenuCommandItem radialMenuCommandItem7;
        private C1.Win.C1Themes.C1ThemeController c1ThemeController1;
        private C1.Win.C1Command.RadialMenuCommandItem radialMenuCommandItem8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}