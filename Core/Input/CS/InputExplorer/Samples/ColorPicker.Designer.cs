using System.Drawing;
using System.Collections.Generic;

namespace InputExplorer.Samples
{
    partial class ColorPicker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorPicker));
            this.c1ColorPicker1 = new C1.Win.Input.Pickers.C1ColorPicker();
            this.c1ColorPicker2 = new C1.Win.Input.Pickers.C1ColorPicker();
            this.c1ColorPicker3 = new C1.Win.Input.Pickers.C1ColorPicker();
            this.c1ColorPicker4 = new C1.Win.Input.Pickers.C1ColorPicker();
            this.c1ColorPicker5 = new C1.Win.Input.Pickers.C1ColorPicker();
            this.c1Label1 = new C1.Win.Input.C1Label();
            this.c1Label2 = new C1.Win.Input.C1Label();
            this.c1Label3 = new C1.Win.Input.C1Label();
            this.c1Label4 = new C1.Win.Input.C1Label();
            this.c1Label5 = new C1.Win.Input.C1Label();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();

            // 
            // c1Label1
            // 
            this.c1Label1.Location = new System.Drawing.Point(7, 0);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(200, 25);
            this.c1Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c1Label1.Text = "Default settings";

            // 
            // c1ColorPicker1
            // 
            this.c1ColorPicker1.Location = new System.Drawing.Point(7, 28);
            this.c1ColorPicker1.Name = "c1ColorPicker1";
            this.c1ColorPicker1.Size = new System.Drawing.Size(170, 25);
            this.c1ColorPicker1.TabIndex = 7;

            // 
            // c1Label2
            // 
            this.c1Label2.Location = new System.Drawing.Point(7, 65);
            this.c1Label2.Name = "c1Label2";
            this.c1Label2.Size = new System.Drawing.Size(200, 50);
            this.c1Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c1Label2.Text = "Allow empty color \nand deny transparent colors";
            
            // 
            // c1ColorPicker2
            // 
            this.c1ColorPicker2.Location = new System.Drawing.Point(7, 118);
            this.c1ColorPicker2.Name = "c1ColorPicker2";
            this.c1ColorPicker2.Size = new System.Drawing.Size(170, 25);
            this.c1ColorPicker2.TabIndex = 8;
            this.c1ColorPicker2.EmptyColorCaption = "No color";
            this.c1ColorPicker2.AllowEmpty = true;
            this.c1ColorPicker2.Color = System.Drawing.Color.Empty;
            this.c1ColorPicker3.AllowTransparent = false;
            
            // 
            // c1Label3
            // 
            this.c1Label3.Location = new System.Drawing.Point(7, 155);
            this.c1Label3.Name = "c1Label2";
            this.c1Label3.Size = new System.Drawing.Size(200, 50);
            this.c1Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c1Label3.Text = "Change default position \nof dropdown color palettes";

            // 
            // c1ColorPicker3
            // 
            this.c1ColorPicker3.Location = new System.Drawing.Point(7, 208);
            this.c1ColorPicker3.Name = "c1ColorPicker3";
            this.c1ColorPicker3.Size = new System.Drawing.Size(170, 25);
            this.c1ColorPicker3.TabIndex = 9;
            this.c1ColorPicker3.DropDownAlign = C1.Framework.DropDownAlignment.Center;
            this.c1ColorPicker3.GapHeight = -60;
            this.c1ColorPicker3.Format = C1.Win.Input.Pickers.ColorPicker.ColorFormatType.ARGB;
            this.c1ColorPicker3.Color = System.Drawing.Color.FromArgb(130, 250, 180, 0);

            // 
            // c1Label4
            // 
            this.c1Label4.Location = new System.Drawing.Point(7, 245);
            this.c1Label4.Name = "c1Label4";
            this.c1Label4.Size = new System.Drawing.Size(200, 50);
            this.c1Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c1Label4.Text = "Change alignmenght of text \nand dropdown color palettes";
            
            // 
            // c1ColorPicker4
            // 
            this.c1ColorPicker4.Location = new System.Drawing.Point(7, 298);
            this.c1ColorPicker4.Name = "c1ColorPicker4";
            this.c1ColorPicker4.Size = new System.Drawing.Size(170, 25);
            this.c1ColorPicker4.TabIndex = 10;
            this.c1ColorPicker4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c1ColorPicker4.DropDownAlign = C1.Framework.DropDownAlignment.Right;
            this.c1ColorPicker4.Color = System.Drawing.Color.Violet;
            // 
            // c1Label5
            // 
            this.c1Label5.Location = new System.Drawing.Point(7, 335);
            this.c1Label5.Name = "c1Label5";
            this.c1Label5.Size = new System.Drawing.Size(200, 50);
            this.c1Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c1Label5.Text = "Use hex format representation \n of color";

            // 
            // c1ColorPicker5
            // 
            this.c1ColorPicker5.Location = new System.Drawing.Point(7, 388);
            this.c1ColorPicker5.Name = "c1ColorPicker5";
            this.c1ColorPicker5.Size = new System.Drawing.Size(170, 25);
            this.c1ColorPicker5.TabIndex = 11;
            this.c1ColorPicker5.Format = C1.Win.Input.Pickers.ColorPicker.ColorFormatType.Hex;
            this.c1ColorPicker5.Color = System.Drawing.Color.FromArgb(180, 50, 200, 60);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertyGrid1.Location = new System.Drawing.Point(320, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.c1ColorPicker1;
            this.propertyGrid1.Size = new System.Drawing.Size(350, 454);
            this.propertyGrid1.TabIndex = 6;

            // 
            // ColorPicker
            // 
            this.Controls.Add(this.c1Label1);
            this.Controls.Add(this.c1ColorPicker1);
            this.Controls.Add(this.c1Label2);
            this.Controls.Add(this.c1ColorPicker2);
            this.Controls.Add(this.c1Label3);
            this.Controls.Add(this.c1ColorPicker3);
            this.Controls.Add(this.c1Label4);
            this.Controls.Add(this.c1ColorPicker4);
            this.Controls.Add(this.c1Label5);
            this.Controls.Add(this.c1ColorPicker5);
            this.Controls.Add(this.propertyGrid1);
            this.Name = "ColorPicker";
            this.Size = new System.Drawing.Size(564, 600);
            this.ResumeLayout(false);
            this.AutoScaleDimensions = new System.Drawing.SizeF(96, 96);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        }

        #endregion
        private C1.Win.Input.C1Label c1Label1;
        private C1.Win.Input.Pickers.C1ColorPicker c1ColorPicker1;
        private C1.Win.Input.C1Label c1Label2;
        private C1.Win.Input.Pickers.C1ColorPicker c1ColorPicker2;
        private C1.Win.Input.C1Label c1Label3;
        private C1.Win.Input.Pickers.C1ColorPicker c1ColorPicker3;
        private C1.Win.Input.C1Label c1Label4;
        private C1.Win.Input.Pickers.C1ColorPicker c1ColorPicker4;
        private C1.Win.Input.C1Label c1Label5;
        private C1.Win.Input.Pickers.C1ColorPicker c1ColorPicker5;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
    }
}
