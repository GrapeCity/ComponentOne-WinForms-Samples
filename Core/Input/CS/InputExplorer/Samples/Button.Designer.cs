namespace InputExplorer.Samples
{
    partial class Button
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
            C1.Framework.C1BitmapIcon c1BitmapIcon1 = new C1.Framework.C1BitmapIcon();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Button));
            c1Button1 = new C1.Win.Input.C1Button();
            propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            c1Button2 = new C1.Win.Input.C1Button();
            c1Button3 = new C1.Win.Input.C1Button();
            c1Button4 = new C1.Win.Input.C1Button();
            ((System.ComponentModel.ISupportInitialize)c1Button1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1Button2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1Button3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1Button4).BeginInit();
            SuspendLayout();
            // 
            // c1Button1
            // 
            c1Button1.Location = new System.Drawing.Point(14, 36);
            c1Button1.Name = "c1Button1";
            c1Button1.Size = new System.Drawing.Size(138, 32);
            c1Button1.TabIndex = 0;
            c1Button1.Text = "Text";
            // 
            // propertyGrid1
            // 
            propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
            propertyGrid1.Location = new System.Drawing.Point(201, 0);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.SelectedObject = c1Button1;
            propertyGrid1.Size = new System.Drawing.Size(366, 494);
            propertyGrid1.TabIndex = 4;
            // 
            // c1Button2
            // 
            c1BitmapIcon1.Size = new System.Drawing.Size(130, 32);
            c1BitmapIcon1.Source = Properties.Resources.lorem_lorem_logo;
            c1BitmapIcon1.Stretch = C1.Framework.Stretch.Uniform;
            c1Button2.Icon = c1BitmapIcon1;
            c1Button2.Location = new System.Drawing.Point(14, 122);
            c1Button2.Name = "c1Button2";
            c1Button2.Size = new System.Drawing.Size(138, 32);
            c1Button2.TabIndex = 1;
            // 
            // c1Button3
            // 
            c1Button3.Icon = new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, (System.Drawing.Image)resources.GetObject("c1Button3.Icon"));
            c1Button3.Location = new System.Drawing.Point(14, 208);
            c1Button3.Name = "c1Button3";
            c1Button3.Size = new System.Drawing.Size(138, 32);
            c1Button3.TabIndex = 2;
            c1Button3.Text = "Text and Image";
            c1Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            c1Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            c1Button3.Trimming = System.Drawing.StringTrimming.Character;
            // 
            // c1Button4
            // 
            c1Button4.Location = new System.Drawing.Point(14, 294);
            c1Button4.Name = "c1Button4";
            c1Button4.Size = new System.Drawing.Size(138, 32);
            c1Button4.Styles.Default.ForeColor = System.Drawing.Color.SeaGreen;
            c1Button4.Styles.Hot.ForeColor = System.Drawing.Color.SeaGreen;
            c1Button4.Styles.HotPressed.ForeColor = System.Drawing.Color.SeaGreen;
            c1Button4.Styles.Pressed.ForeColor = System.Drawing.Color.SeaGreen;
            c1Button4.TabIndex = 3;
            c1Button4.Text = "Vector Icon";
            c1Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // Button
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            Controls.Add(c1Button4);
            Controls.Add(c1Button3);
            Controls.Add(c1Button2);
            Controls.Add(propertyGrid1);
            Controls.Add(c1Button1);
            Name = "Button";
            Size = new System.Drawing.Size(567, 494);
            ((System.ComponentModel.ISupportInitialize)c1Button1).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1Button2).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1Button3).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1Button4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private C1.Win.Input.C1Button c1Button1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private C1.Win.Input.C1Button c1Button2;
        private C1.Win.Input.C1Button c1Button3;
        private C1.Win.Input.C1Button c1Button4;
    }
}
