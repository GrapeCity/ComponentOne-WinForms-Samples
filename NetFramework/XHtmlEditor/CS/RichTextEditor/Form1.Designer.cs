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
            this.c1TextEditorRibbon1 = new RichTextEditor.C1TextEditorRibbon();
            this.textEditor1 = new C1.Win.C1Editor.C1Editor();
            this.ribbonApplicationMenu1 = new C1.Win.C1Ribbon.RibbonApplicationMenu();
            this.ribbonQat1 = new C1.Win.C1Ribbon.RibbonQat();
            this.ribbonConfigToolBar1 = new C1.Win.C1Ribbon.RibbonConfigToolBar();
            this.c1StatusBar1 = new C1.Win.C1Ribbon.C1StatusBar();
            this.c1ThemeController1 = new C1.Win.C1Themes.C1ThemeController();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextEditorRibbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1TextEditorRibbon1
            // 
            this.c1TextEditorRibbon1.AutoSizeElement = C1.Framework.AutoSizeElement.Width;
            this.c1TextEditorRibbon1.C1Editor = this.textEditor1;
            this.c1TextEditorRibbon1.Location = new System.Drawing.Point(0, 0);
            this.c1TextEditorRibbon1.Margin = new System.Windows.Forms.Padding(2);
            this.c1TextEditorRibbon1.Name = "c1TextEditorRibbon1";
            this.c1TextEditorRibbon1.Size = new System.Drawing.Size(800, 143);
            this.c1TextEditorRibbon1.ToolTipSettings.MaximumWidth = 240;
            // 
            // textEditor1
            // 
            this.textEditor1.BackColor = System.Drawing.Color.White;
            this.textEditor1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditor1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditor1.Location = new System.Drawing.Point(0, 143);
            this.textEditor1.Margin = new System.Windows.Forms.Padding(2);
            this.textEditor1.MinimumSize = new System.Drawing.Size(0, 0);
            this.textEditor1.Name = "textEditor1";
            this.textEditor1.Size = new System.Drawing.Size(800, 435);
            this.textEditor1.TabIndex = 1;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Appearance = C1.Win.C1Ribbon.AppMenuAppearance.DropDown;
            this.ribbonApplicationMenu1.DropDownWidth = 370;
            this.ribbonApplicationMenu1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonApplicationMenu1.LargeImage")));
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // c1StatusBar1
            // 
            this.c1StatusBar1.AutoSizeElement = C1.Framework.AutoSizeElement.Width;
            this.c1StatusBar1.Location = new System.Drawing.Point(0, 578);
            this.c1StatusBar1.Margin = new System.Windows.Forms.Padding(2);
            this.c1StatusBar1.Name = "c1StatusBar1";
            this.c1StatusBar1.Size = new System.Drawing.Size(800, 22);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.textEditor1);
            this.Controls.Add(this.c1StatusBar1);
            this.Controls.Add(this.c1TextEditorRibbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rich Text Editor";
            this.c1ThemeController1.SetTheme(this, "Office2016Colorful");
            ((System.ComponentModel.ISupportInitialize)(this.c1TextEditorRibbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextEditor.C1TextEditorRibbon c1TextEditorRibbon1;
        private C1.Win.C1Ribbon.C1StatusBar c1StatusBar1;
        private C1.Win.C1Editor.C1Editor textEditor1;
        private C1.Win.C1Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.C1Ribbon.RibbonQat ribbonQat1;
        private C1.Win.C1Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.C1Themes.C1ThemeController c1ThemeController1;        
    }
}

