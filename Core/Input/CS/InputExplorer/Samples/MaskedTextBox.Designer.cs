
namespace InputExplorer.Samples
{
    partial class MaskedTextBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextBox));
            this.c1MaskedTextBox1 = new C1.Win.Input.C1MaskedTextBox();
            this.c1MaskedTextBox2 = new C1.Win.Input.C1MaskedTextBox();
            this.c1MaskedTextBox3 = new C1.Win.Input.C1MaskedTextBox();
            this.c1MaskedTextBox4 = new C1.Win.Input.C1MaskedTextBox();
            this.c1MaskedTextBox5 = new C1.Win.Input.C1MaskedTextBox();
            this.c1MaskedTextBox6 = new C1.Win.Input.C1MaskedTextBox();
            this.c1MaskedTextBox7 = new C1.Win.Input.C1MaskedTextBox();
            this.c1Label1 = new C1.Win.Input.C1Label();
            this.c1Label2 = new C1.Win.Input.C1Label();
            this.c1Label3 = new C1.Win.Input.C1Label();
            this.c1Label4 = new C1.Win.Input.C1Label();
            this.c1Label5 = new C1.Win.Input.C1Label();
            this.c1Label6 = new C1.Win.Input.C1Label();
            this.c1Label7 = new C1.Win.Input.C1Label();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            
            ((System.ComponentModel.ISupportInitialize)(this.c1MaskedTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1MaskedTextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1MaskedTextBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1MaskedTextBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1MaskedTextBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1MaskedTextBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1MaskedTextBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Label1
            // 
            this.c1Label1.Location = new System.Drawing.Point(7, 0);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(200, 25);
            this.c1Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c1Label1.Text = "Phone number";
            // 
            // c1MaskedTextBox1
            // 
            this.c1MaskedTextBox1.AcceptsEscape = false;
            this.c1MaskedTextBox1.AcceptsReturn = true;
            this.c1MaskedTextBox1.DisableOnNoData = false;
            
            this.c1MaskedTextBox1.Location = new System.Drawing.Point(7, 26);
            this.c1MaskedTextBox1.Name = "c1MaskedTextBox1";
            this.c1MaskedTextBox1.Size = new System.Drawing.Size(100, 25);
            this.c1MaskedTextBox1.TabIndex = 7;
            //this.c1MaskedTextBox1.Value = "7777777777";
            this.c1MaskedTextBox1.EditMask = "+0-(000)-000-0000";
            this.c1MaskedTextBox1.DisplayFormat.FormatType = C1.Win.Input.FormatType.CustomFormat;
            // 
            // c1Label2
            // 
            this.c1Label2.Location = new System.Drawing.Point(7, 59);
            this.c1Label2.Name = "c1Label2";
            this.c1Label2.Size = new System.Drawing.Size(230, 25);
            this.c1Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c1Label2.Text = "Japan zip code with custom prompt char";

            // 
            // c1MaskedTextBox2
            // 
            this.c1MaskedTextBox2.AcceptsEscape = false;
            this.c1MaskedTextBox2.AcceptsReturn = true;
            this.c1MaskedTextBox2.DisableOnNoData = false;

            this.c1MaskedTextBox2.Location = new System.Drawing.Point(7, 85);
            this.c1MaskedTextBox2.Name = "c1MaskedTextBox2";
            this.c1MaskedTextBox2.Size = new System.Drawing.Size(100, 25);
            this.c1MaskedTextBox2.TabIndex = 8;
            this.c1MaskedTextBox2.EditMask = "000-0000";
            this.c1MaskedTextBox2.MaskInfo.PromptChar = '#';
            // 
            // c1Label3
            // 
            this.c1Label3.Location = new System.Drawing.Point(7, 118);
            this.c1Label3.Name = "c1Label3";
            this.c1Label3.Size = new System.Drawing.Size(230, 25);
            this.c1Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c1Label3.Text = "Number with 2 digits after decimal point";
            // 
            // c1MaskedTextBox3
            // 
            this.c1MaskedTextBox3.AcceptsEscape = false;
            this.c1MaskedTextBox3.AcceptsReturn = true;
            this.c1MaskedTextBox3.DisableOnNoData = false;

            this.c1MaskedTextBox3.Location = new System.Drawing.Point(7, 144);
            this.c1MaskedTextBox3.Name = "c1MaskedTextBox3";
            this.c1MaskedTextBox3.Size = new System.Drawing.Size(100, 25);
            this.c1MaskedTextBox3.TabIndex = 9;
            this.c1MaskedTextBox3.EditMask = "000,000.00";
            // 
            // c1Label4
            // 
            this.c1Label4.Location = new System.Drawing.Point(7, 177);
            this.c1Label4.Name = "c1Label4";
            this.c1Label4.Size = new System.Drawing.Size(230, 25);
            this.c1Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c1Label4.Text = "Password of 8-12 digits or letters";
            
            // 
            // c1MaskedTextBox4
            // 
            this.c1MaskedTextBox4.AcceptsEscape = false;
            this.c1MaskedTextBox4.AcceptsReturn = true;
            this.c1MaskedTextBox4.DisableOnNoData = false;

            this.c1MaskedTextBox4.Location = new System.Drawing.Point(7, 203);
            this.c1MaskedTextBox4.Name = "c1MaskedTextBox4";
            this.c1MaskedTextBox4.Size = new System.Drawing.Size(100, 25);
            this.c1MaskedTextBox4.TabIndex = 10;
            this.c1MaskedTextBox4.UseSystemPasswordChar = true;
            this.c1MaskedTextBox4.MaskInfo.EditMask = "AAAAAAAAaaaa";
            // 
            // c1Label5
            // 
            this.c1Label5.Location = new System.Drawing.Point(7, 236);
            this.c1Label5.Name = "c1Label5";
            this.c1Label5.Size = new System.Drawing.Size(200, 25);
            this.c1Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c1Label5.Text = "Make text uppercase or lowercase";
            // 
            // c1MaskedTextBox5
            // 
            this.c1MaskedTextBox5.AcceptsEscape = false;
            this.c1MaskedTextBox5.AcceptsReturn = true;
            this.c1MaskedTextBox5.DisableOnNoData = false;

            this.c1MaskedTextBox5.Location = new System.Drawing.Point(7, 262);
            this.c1MaskedTextBox5.Name = "c1MaskedTextBox5";
            this.c1MaskedTextBox5.Size = new System.Drawing.Size(100, 25);
            this.c1MaskedTextBox5.TabIndex = 11;
            this.c1MaskedTextBox5.EditMask = ">LCCCCCC<CCCCCCCC";
            // 
            // c1Label6
            // 
            this.c1Label6.Location = new System.Drawing.Point(7, 295);
            this.c1Label6.Name = "c1Label6";
            this.c1Label6.Size = new System.Drawing.Size(230, 25);
            this.c1Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c1Label6.Text = "Multiple strings with fixed length";
            // 
            // c1MaskedTextBox6
            // 
            this.c1MaskedTextBox6.AcceptsEscape = false;
            this.c1MaskedTextBox6.AcceptsReturn = true;
            this.c1MaskedTextBox6.DisableOnNoData = false;

            this.c1MaskedTextBox6.Location = new System.Drawing.Point(7, 321);
            this.c1MaskedTextBox6.Name = "c1MaskedTextBox6";
            this.c1MaskedTextBox6.Size = new System.Drawing.Size(100, 75);
            this.c1MaskedTextBox6.TabIndex = 11;
            this.c1MaskedTextBox6.Multiline = true;
            this.c1MaskedTextBox6.MaskInfo.EditMask = "CCCCCCCCCC\nCCCCCCCCCC\nCCCCCCCCCC\nCCCCCCCCCC\nCCCCCCCCCC\n";

            // 
            // c1Label7
            // 
            this.c1Label7.Location = new System.Drawing.Point(7, 404);
            this.c1Label7.Name = "c1Label7";
            this.c1Label7.Size = new System.Drawing.Size(230, 25);
            this.c1Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c1Label7.Text = "Regular expression mask: lowercase letters";
            // 
            // c1MaskedTextBox7
            // 
            this.c1MaskedTextBox7.AcceptsEscape = false;
            this.c1MaskedTextBox7.AcceptsReturn = true;
            this.c1MaskedTextBox7.DisableOnNoData = false;
                                
            this.c1MaskedTextBox7.Location = new System.Drawing.Point(7, 430);
            this.c1MaskedTextBox7.Name = "c1MaskedTextBox7";
            this.c1MaskedTextBox7.Size = new System.Drawing.Size(100, 25);
            this.c1MaskedTextBox7.TabIndex = 12;
            this.c1MaskedTextBox7.MaskInfo.RegexpEditMask = "^[a-z]{8}$";

            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertyGrid1.Location = new System.Drawing.Point(320, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.c1MaskedTextBox1;
            this.propertyGrid1.Size = new System.Drawing.Size(350, 454);
            this.propertyGrid1.TabIndex = 6;

            // 
            // MaskedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            
            this.Controls.Add(this.c1Label1);
            this.Controls.Add(this.c1MaskedTextBox1);
            this.Controls.Add(this.c1Label2);
            this.Controls.Add(this.c1MaskedTextBox2);
            this.Controls.Add(this.c1Label3);
            this.Controls.Add(this.c1MaskedTextBox3);
            this.Controls.Add(this.c1Label4);
            this.Controls.Add(this.c1MaskedTextBox4);
            this.Controls.Add(this.c1Label5);
            this.Controls.Add(this.c1MaskedTextBox5);
            this.Controls.Add(this.c1Label6);
            this.Controls.Add(this.c1MaskedTextBox6);
            this.Controls.Add(this.c1Label7);
            this.Controls.Add(this.c1MaskedTextBox7);
            this.Controls.Add(this.propertyGrid1);
            this.Name = "MaskedTextBox";
            this.Size = new System.Drawing.Size(564, 600);
            ((System.ComponentModel.ISupportInitialize)(this.c1MaskedTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1MaskedTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1MaskedTextBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1MaskedTextBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1MaskedTextBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1MaskedTextBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1MaskedTextBox7)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        private C1.Win.Input.C1Label c1Label1;
        private C1.Win.Input.C1MaskedTextBox c1MaskedTextBox1;
        private C1.Win.Input.C1Label c1Label2;
        private C1.Win.Input.C1MaskedTextBox c1MaskedTextBox2;
        private C1.Win.Input.C1Label c1Label3;
        private C1.Win.Input.C1MaskedTextBox c1MaskedTextBox3;
        private C1.Win.Input.C1Label c1Label4;
        private C1.Win.Input.C1MaskedTextBox c1MaskedTextBox4;
        private C1.Win.Input.C1Label c1Label5;
        private C1.Win.Input.C1MaskedTextBox c1MaskedTextBox5;
        private C1.Win.Input.C1Label c1Label6;
        private C1.Win.Input.C1MaskedTextBox c1MaskedTextBox6;
        private C1.Win.Input.C1Label c1Label7;
        private C1.Win.Input.C1MaskedTextBox c1MaskedTextBox7;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
    }
}
