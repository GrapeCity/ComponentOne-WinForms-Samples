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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Button));
            this.c1Button1 = new C1.Win.Input.C1Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.c1Button2 = new C1.Win.Input.C1Button();
            this.c1Button3 = new C1.Win.Input.C1Button();
            this.c1Button4 = new C1.Win.Input.C1Button();
            this.SuspendLayout();
            // 
            // c1Button1
            // 
            this.c1Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.c1Button1.Location = new System.Drawing.Point(14, 36);
            this.c1Button1.Name = "c1Button1";
            this.c1Button1.Size = new System.Drawing.Size(138, 32);
            this.c1Button1.TabIndex = 0;
            this.c1Button1.Text = "Text";
            this.c1Button1.UseMnemonic = true;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertyGrid1.Location = new System.Drawing.Point(201, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.c1Button1;
            this.propertyGrid1.Size = new System.Drawing.Size(366, 494);
            this.propertyGrid1.TabIndex = 4;
            // 
            // c1Button2
            // 
            this.c1Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.c1Button2.Icon = new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(100, 20), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("c1Button2.Icon"))));
            this.c1Button2.Location = new System.Drawing.Point(14, 122);
            this.c1Button2.Name = "c1Button2";
            this.c1Button2.Size = new System.Drawing.Size(138, 32);
            this.c1Button2.TabIndex = 1;
            this.c1Button2.UseMnemonic = true;
            // 
            // c1Button3
            // 
            this.c1Button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.c1Button3.Icon = new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("c1Button3.Icon"))));
            this.c1Button3.Location = new System.Drawing.Point(14, 208);
            this.c1Button3.Name = "c1Button3";
            this.c1Button3.Size = new System.Drawing.Size(138, 32);
            this.c1Button3.TabIndex = 2;
            this.c1Button3.Text = "Text and Image";
            this.c1Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c1Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.c1Button3.Trimming = System.Drawing.StringTrimming.Character;
            this.c1Button3.UseMnemonic = true;
            // 
            // c1Button4
            // 
            this.c1Button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.c1Button4.ForeColor = System.Drawing.Color.SeaGreen;
            this.c1Button4.Location = new System.Drawing.Point(14, 294);
            this.c1Button4.Name = "c1Button4";
            this.c1Button4.Size = new System.Drawing.Size(138, 32);
            this.c1Button4.Styles.Default.ForeColor = System.Drawing.Color.SeaGreen;
            this.c1Button4.Styles.Hot.ForeColor = System.Drawing.Color.SeaGreen;
            this.c1Button4.Styles.HotPressed.ForeColor = System.Drawing.Color.SeaGreen;
            this.c1Button4.Styles.Pressed.ForeColor = System.Drawing.Color.SeaGreen;
            this.c1Button4.TabIndex = 3;
            this.c1Button4.Text = "Vector Icon";
            this.c1Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.c1Button4.UseMnemonic = true;
            // 
            // Button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1Button4);
            this.Controls.Add(this.c1Button3);
            this.Controls.Add(this.c1Button2);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.c1Button1);
            this.Name = "Button";
            this.Size = new System.Drawing.Size(567, 494);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Input.C1Button c1Button1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private C1.Win.Input.C1Button c1Button2;
        private C1.Win.Input.C1Button c1Button3;
        private C1.Win.Input.C1Button c1Button4;
    }
}
