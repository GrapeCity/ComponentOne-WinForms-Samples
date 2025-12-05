namespace RichTextEditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            C1.Win.Themes.C1Office365ThemeSettings c1Office365ThemeSettings1 = new C1.Win.Themes.C1Office365ThemeSettings();
            this.editor = new C1.Win.C1Editor.C1Editor();
            this.editorPnl = new System.Windows.Forms.Panel();
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            ((System.ComponentModel.ISupportInitialize)(this.editor)).BeginInit();
            this.editorPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.SuspendLayout();
            // 
            // editor
            // 
            this.editor.BackColor = System.Drawing.Color.White;
            this.editor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editor.Location = new System.Drawing.Point(7, 7);
            this.editor.Margin = new System.Windows.Forms.Padding(0);
            this.editor.MinimumSize = new System.Drawing.Size(363, 381);
            this.editor.Name = "editor";
            this.editor.Padding = new System.Windows.Forms.Padding(5);
            this.editor.Size = new System.Drawing.Size(1028, 665);
            this.editor.TabIndex = 0;
            this.editor.Text = " ";
            this.editor.Xml = resources.GetString("editor.Xml");
            // 
            // editorPnl
            // 
            this.editorPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.editorPnl.Controls.Add(this.editor);
            this.editorPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorPnl.Location = new System.Drawing.Point(0, 0);
            this.editorPnl.Margin = new System.Windows.Forms.Padding(0);
            this.editorPnl.Name = "editorPnl";
            this.editorPnl.Padding = new System.Windows.Forms.Padding(7);
            this.editorPnl.Size = new System.Drawing.Size(1042, 679);
            this.editorPnl.TabIndex = 3;
            // 
            // c1ThemeController1
            // 
            this.c1ThemeController1.Theme = "Office365White";
            c1Office365ThemeSettings1.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            c1Office365ThemeSettings1.Background = System.Drawing.Color.White;
            c1Office365ThemeSettings1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.c1ThemeController1.ThemeSettings = c1Office365ThemeSettings1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 679);
            this.Controls.Add(this.editorPnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rich Text Editor";
            ((System.ComponentModel.ISupportInitialize)(this.editor)).EndInit();
            this.editorPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private C1.Win.C1Editor.C1Editor editor;
        private System.Windows.Forms.Panel editorPnl;
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
      
    }
}

