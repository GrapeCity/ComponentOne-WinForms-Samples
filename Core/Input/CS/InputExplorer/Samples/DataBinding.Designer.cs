
namespace InputExplorer.Samples
{
    partial class DataBinding
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
            this.editFormPanel = new System.Windows.Forms.TableLayoutPanel();
            this.picturePhoto = new C1.Win.Input.C1PictureBox();
            this.c1Label1 = new C1.Win.Input.C1Label();
            this.c1Label2 = new C1.Win.Input.C1Label();
            this.c1Label3 = new C1.Win.Input.C1Label();
            this.c1Label4 = new C1.Win.Input.C1Label();
            this.c1Label5 = new C1.Win.Input.C1Label();
            this.c1Label6 = new C1.Win.Input.C1Label();
            this.c1Label7 = new C1.Win.Input.C1Label();
            this.labelEmploeeID = new C1.Win.Input.C1Label();
            this.FirstName = new C1.Win.Input.C1TextBox();
            this.LastName = new C1.Win.Input.C1TextBox();
            this.Extension = new C1.Win.Input.C1NumericEdit();
            this.HomePhone = new C1.Win.Input.C1TextBox();
            this.BirthDate = new C1.Win.Calendar.C1DateEdit();
            this.Country = new C1.Win.Input.C1ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.c1Button2 = new C1.Win.Input.C1Button();
            this.c1Button1 = new C1.Win.Input.C1Button();
            this.editFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Extension)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Country)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // editFormPanel
            // 
            this.editFormPanel.ColumnCount = 3;
            this.editFormPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.editFormPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.editFormPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.editFormPanel.Controls.Add(this.picturePhoto, 0, 0);
            this.editFormPanel.Controls.Add(this.c1Label1, 1, 0);
            this.editFormPanel.Controls.Add(this.c1Label2, 1, 1);
            this.editFormPanel.Controls.Add(this.c1Label3, 1, 2);
            this.editFormPanel.Controls.Add(this.c1Label4, 1, 3);
            this.editFormPanel.Controls.Add(this.c1Label5, 1, 4);
            this.editFormPanel.Controls.Add(this.c1Label6, 1, 5);
            this.editFormPanel.Controls.Add(this.c1Label7, 1, 6);
            this.editFormPanel.Controls.Add(this.labelEmploeeID, 2, 0);
            this.editFormPanel.Controls.Add(this.FirstName, 2, 1);
            this.editFormPanel.Controls.Add(this.LastName, 2, 2);
            this.editFormPanel.Controls.Add(this.Extension, 2, 5);
            this.editFormPanel.Controls.Add(this.HomePhone, 2, 3);
            this.editFormPanel.Controls.Add(this.BirthDate, 2, 4);
            this.editFormPanel.Controls.Add(this.Country, 2, 6);
            this.editFormPanel.Controls.Add(this.panel1, 2, 7);
            this.editFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editFormPanel.Location = new System.Drawing.Point(0, 0);
            this.editFormPanel.Name = "editFormPanel";
            this.editFormPanel.RowCount = 8;
            this.editFormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.editFormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.editFormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.editFormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.editFormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.editFormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.editFormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.editFormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.editFormPanel.Size = new System.Drawing.Size(582, 436);
            this.editFormPanel.TabIndex = 0;
            // 
            // picturePhoto
            // 
            this.picturePhoto.Location = new System.Drawing.Point(3, 3);
            this.picturePhoto.Name = "picturePhoto";
            this.editFormPanel.SetRowSpan(this.picturePhoto, 7);
            this.picturePhoto.Size = new System.Drawing.Size(180, 190);
            this.picturePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePhoto.TabIndex = 0;
            this.picturePhoto.TabStop = false;
            // 
            // c1Label1
            // 
            this.c1Label1.Location = new System.Drawing.Point(200, 3);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(77, 22);
            this.c1Label1.TabIndex = 1;
            this.c1Label1.Text = "ID:";
            // 
            // c1Label2
            // 
            this.c1Label2.Location = new System.Drawing.Point(200, 31);
            this.c1Label2.Name = "c1Label2";
            this.c1Label2.Size = new System.Drawing.Size(77, 22);
            this.c1Label2.TabIndex = 2;
            this.c1Label2.Text = "First Name:";
            // 
            // c1Label3
            // 
            this.c1Label3.Location = new System.Drawing.Point(200, 59);
            this.c1Label3.Name = "c1Label3";
            this.c1Label3.Size = new System.Drawing.Size(77, 22);
            this.c1Label3.TabIndex = 3;
            this.c1Label3.Text = "Last Name:";
            // 
            // c1Label4
            // 
            this.c1Label4.Location = new System.Drawing.Point(200, 87);
            this.c1Label4.Name = "c1Label4";
            this.c1Label4.Size = new System.Drawing.Size(77, 22);
            this.c1Label4.TabIndex = 4;
            this.c1Label4.Text = "Phone Number:";
            // 
            // c1Label5
            // 
            this.c1Label5.Location = new System.Drawing.Point(200, 115);
            this.c1Label5.Name = "c1Label5";
            this.c1Label5.Size = new System.Drawing.Size(77, 22);
            this.c1Label5.TabIndex = 5;
            this.c1Label5.Text = "Birth Date:";
            // 
            // c1Label6
            // 
            this.c1Label6.Location = new System.Drawing.Point(200, 143);
            this.c1Label6.Name = "c1Label6";
            this.c1Label6.Size = new System.Drawing.Size(77, 22);
            this.c1Label6.TabIndex = 6;
            this.c1Label6.Text = "Extension:";
            // 
            // c1Label7
            // 
            this.c1Label7.Location = new System.Drawing.Point(200, 171);
            this.c1Label7.Name = "c1Label7";
            this.c1Label7.Size = new System.Drawing.Size(77, 22);
            this.c1Label7.TabIndex = 7;
            this.c1Label7.Text = "Country:";
            // 
            // labelEmploeeID
            // 
            this.labelEmploeeID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEmploeeID.Location = new System.Drawing.Point(283, 3);
            this.labelEmploeeID.Name = "labelEmploeeID";
            this.labelEmploeeID.Size = new System.Drawing.Size(296, 22);
            this.labelEmploeeID.TabIndex = 8;
            this.labelEmploeeID.Text = "c1Label8";
            // 
            // FirstName
            // 
            this.FirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstName.Location = new System.Drawing.Point(283, 31);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(296, 22);
            this.FirstName.TabIndex = 9;
            // 
            // LastName
            // 
            this.LastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LastName.Location = new System.Drawing.Point(283, 59);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(296, 22);
            this.LastName.TabIndex = 10;
            // 
            // Extension
            // 
            this.Extension.Location = new System.Drawing.Point(283, 143);
            this.Extension.Name = "Extension";
            this.Extension.NullText = "0";
            this.Extension.Size = new System.Drawing.Size(100, 22);
            this.Extension.TabIndex = 11;
            this.Extension.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // HomePhone
            // 
            this.HomePhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePhone.Location = new System.Drawing.Point(283, 87);
            this.HomePhone.Name = "HomePhone";
            this.HomePhone.Size = new System.Drawing.Size(296, 22);
            this.HomePhone.TabIndex = 12;
            // 
            // BirthDate
            // 
            this.BirthDate.CustomFormat = "MM/dd/yyyy";
            this.BirthDate.DisplayFormat.FormatType = C1.Win.Input.FormatType.CustomFormat;
            this.BirthDate.DisplayFormat.Inherit = ((C1.Win.Input.FormatInfoInheritProperties)((((((C1.Win.Input.FormatInfoInheritProperties.CustomFormat | C1.Win.Input.FormatInfoInheritProperties.NullText) 
            | C1.Win.Input.FormatInfoInheritProperties.EmptyAsNull) 
            | C1.Win.Input.FormatInfoInheritProperties.TrimStart) 
            | C1.Win.Input.FormatInfoInheritProperties.TrimEnd) 
            | C1.Win.Input.FormatInfoInheritProperties.CalendarType)));
            this.BirthDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BirthDate.EditFormat.Inherit = ((C1.Win.Input.FormatInfoInheritProperties)(((((C1.Win.Input.FormatInfoInheritProperties.NullText | C1.Win.Input.FormatInfoInheritProperties.EmptyAsNull) 
            | C1.Win.Input.FormatInfoInheritProperties.TrimStart) 
            | C1.Win.Input.FormatInfoInheritProperties.TrimEnd) 
            | C1.Win.Input.FormatInfoInheritProperties.CalendarType)));
            this.BirthDate.Location = new System.Drawing.Point(283, 115);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(296, 22);
            this.BirthDate.TabIndex = 13;
            // 
            // Country
            // 
            this.Country.AcceptsEscape = false;
            this.Country.DisableOnNoData = false;
            this.Country.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Country.Location = new System.Drawing.Point(283, 171);
            this.Country.MaxDropDownItems = 10;
            this.Country.Name = "Country";
            this.Country.Placeholder = null;
            this.Country.Size = new System.Drawing.Size(296, 22);
            this.Country.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.c1Button2);
            this.panel1.Controls.Add(this.c1Button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(283, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 38);
            this.panel1.TabIndex = 15;
            // 
            // c1Button2
            // 
            this.c1Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Button2.Location = new System.Drawing.Point(221, 14);
            this.c1Button2.Name = "c1Button2";
            this.c1Button2.Size = new System.Drawing.Size(75, 23);
            this.c1Button2.TabIndex = 1;
            this.c1Button2.Text = "Next";
            this.c1Button2.Click += new System.EventHandler(this.c1Button2_Click);
            // 
            // c1Button1
            // 
            this.c1Button1.Location = new System.Drawing.Point(0, 14);
            this.c1Button1.Name = "c1Button1";
            this.c1Button1.Size = new System.Drawing.Size(75, 23);
            this.c1Button1.TabIndex = 0;
            this.c1Button1.Text = "Prev";
            this.c1Button1.Click += new System.EventHandler(this.c1Button1_Click);
            // 
            // DataBinding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editFormPanel);
            this.Name = "DataBinding";
            this.Size = new System.Drawing.Size(582, 436);
            this.Load += new System.EventHandler(this.DataBinding_Load);
            this.editFormPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturePhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Extension)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Country)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel editFormPanel;
        private C1.Win.Input.C1PictureBox picturePhoto;
        private C1.Win.Input.C1Label c1Label1;
        private C1.Win.Input.C1Label c1Label2;
        private C1.Win.Input.C1Label c1Label3;
        private C1.Win.Input.C1Label c1Label4;
        private C1.Win.Input.C1Label c1Label5;
        private C1.Win.Input.C1Label c1Label6;
        private C1.Win.Input.C1Label c1Label7;
        private C1.Win.Input.C1Label labelEmploeeID;
        private C1.Win.Input.C1TextBox FirstName;
        private C1.Win.Input.C1TextBox LastName;
        private C1.Win.Input.C1NumericEdit Extension;
        private C1.Win.Input.C1TextBox HomePhone;
        private C1.Win.Calendar.C1DateEdit BirthDate;
        private C1.Win.Input.C1ComboBox Country;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.Input.C1Button c1Button2;
        private C1.Win.Input.C1Button c1Button1;
    }
}
