
namespace InputExplorer.Samples
{
    partial class FontPicker
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
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.c1FontPicker1 = new C1.Win.Input.Pickers.C1FontPicker();
            this.c1FontPicker2 = new C1.Win.Input.Pickers.C1FontPicker();
            this.c1Label1 = new C1.Win.Input.C1Label();
            this.c1Label2 = new C1.Win.Input.C1Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // c1Label1
            // 
            this.c1Label1.Location = new System.Drawing.Point(17, 0);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(200, 50);
            this.c1Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c1Label1.Text = "Select FontFamily in FontPicker to alter font of selected text in the RichTextBox";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(17, 53);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(200, 80);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut non sem efficitur, ma" +
    "ttis mauris sit amet, euismod nisi.";
            // 
            // c1FontPicker1
            // 
            this.c1FontPicker1.Location = new System.Drawing.Point(17, 136);
            this.c1FontPicker1.Name = "c1FontPicker1";
            this.c1FontPicker1.Size = new System.Drawing.Size(200, 25);
            this.c1FontPicker1.TabIndex = 9;
            this.c1FontPicker1.SelectedFontFamilyChanged += new System.EventHandler(this.c1FontPicker1_SelectedFontFamilyChanged);
            // 
            // c1Label2
            // 
            this.c1Label2.Location = new System.Drawing.Point(17, 167);
            this.c1Label2.Name = "c1Label1";
            this.c1Label2.Size = new System.Drawing.Size(200, 50);
            this.c1Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c1Label2.Text = "Customise editor's view,\nsize and position of dropdown";
            // 
            // c1FontPicker2
            // 
            this.c1FontPicker2.Location = new System.Drawing.Point(17, 220);
            this.c1FontPicker2.Name = "c1FontPicker2";
            this.c1FontPicker2.Size = new System.Drawing.Size(200, 25);
            this.c1FontPicker2.ButtonsSettings.ModalButton.Visible = true;
            this.c1FontPicker2.ButtonsSettings.UpDownButton.Visible = true;
            this.c1FontPicker2.DropDownAlign = C1.Win.Input.DropDownAlignment.Center;
            this.c1FontPicker2.DropDownWidth = 300;
            this.c1FontPicker2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c1FontPicker2.TabIndex = 9;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertyGrid1.Location = new System.Drawing.Point(320, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.c1FontPicker1;
            this.propertyGrid1.Size = new System.Drawing.Size(350, 454);
            this.propertyGrid1.TabIndex = 10;
            // 
            // FontPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1Label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.c1FontPicker1);
            this.Controls.Add(this.c1Label2);
            this.Controls.Add(this.c1FontPicker2);
            this.Controls.Add(this.propertyGrid1);
            this.Name = "FontPicker";
            this.Size = new System.Drawing.Size(564, 600);
            this.ResumeLayout(false);
        }

        #endregion
        private C1.Win.Input.C1Label c1Label1;
        private C1.Win.Input.C1Label c1Label2;
        private C1.Win.Input.Pickers.C1FontPicker c1FontPicker1;
        private C1.Win.Input.Pickers.C1FontPicker c1FontPicker2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
    }
}
