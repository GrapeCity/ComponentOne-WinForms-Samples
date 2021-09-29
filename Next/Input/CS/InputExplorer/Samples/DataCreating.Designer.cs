
namespace InputExplorer.Samples
{
    partial class DataCreating
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
            this.c1Label1 = new C1.Win.Input.C1Label();
            this.c1Label2 = new C1.Win.Input.C1Label();
            this.c1Label3 = new C1.Win.Input.C1Label();
            this.c1Label4 = new C1.Win.Input.C1Label();
            this.c1Label5 = new C1.Win.Input.C1Label();
            this.c1Label6 = new C1.Win.Input.C1Label();
            this.c1Label7 = new C1.Win.Input.C1Label();
            this.FirstName = new C1.Win.Input.C1TextBox();
            this.LastName = new C1.Win.Input.C1TextBox();
            this.Extension = new C1.Win.Input.C1NumericEdit();
            this.PhoneNumber = new C1.Win.Input.C1TextBox();
            this.BirthDate = new C1.Win.Input.C1TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnkClear = new System.Windows.Forms.LinkLabel();
            this.pictureSuccess = new C1.Win.Input.C1PictureBox();
            this.btnSaveRecord = new System.Windows.Forms.Button();
            this.picturePhoto = new C1.Win.Input.C1PictureBox();
            this.editFormPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Country = new C1.Win.Input.C1TextBox();
            this.lnkSelectFile = new System.Windows.Forms.LinkLabel();
            this.errorInfo = new C1.Win.Input.C1TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Extension)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthDate)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSuccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePhoto)).BeginInit();
            this.editFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Country)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Label1
            // 
            this.c1Label1.Location = new System.Drawing.Point(199, 3);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(78, 22);
            this.c1Label1.TabIndex = 1;
            this.c1Label1.Text = "Photo:";
            // 
            // c1Label2
            // 
            this.c1Label2.Location = new System.Drawing.Point(199, 31);
            this.c1Label2.Name = "c1Label2";
            this.c1Label2.Size = new System.Drawing.Size(78, 22);
            this.c1Label2.TabIndex = 2;
            this.c1Label2.Text = "First Name:";
            // 
            // c1Label3
            // 
            this.c1Label3.Location = new System.Drawing.Point(199, 59);
            this.c1Label3.Name = "c1Label3";
            this.c1Label3.Size = new System.Drawing.Size(78, 22);
            this.c1Label3.TabIndex = 3;
            this.c1Label3.Text = "Last Name:";
            // 
            // c1Label4
            // 
            this.c1Label4.Location = new System.Drawing.Point(199, 87);
            this.c1Label4.Name = "c1Label4";
            this.c1Label4.Size = new System.Drawing.Size(78, 22);
            this.c1Label4.TabIndex = 4;
            this.c1Label4.Text = "Phone Number:";
            // 
            // c1Label5
            // 
            this.c1Label5.Location = new System.Drawing.Point(199, 115);
            this.c1Label5.Name = "c1Label5";
            this.c1Label5.Size = new System.Drawing.Size(78, 22);
            this.c1Label5.TabIndex = 5;
            this.c1Label5.Text = "Birth Date:";
            // 
            // c1Label6
            // 
            this.c1Label6.Location = new System.Drawing.Point(199, 143);
            this.c1Label6.Name = "c1Label6";
            this.c1Label6.Size = new System.Drawing.Size(78, 22);
            this.c1Label6.TabIndex = 6;
            this.c1Label6.Text = "Extension:";
            // 
            // c1Label7
            // 
            this.c1Label7.Location = new System.Drawing.Point(199, 171);
            this.c1Label7.Name = "c1Label7";
            this.c1Label7.Size = new System.Drawing.Size(78, 22);
            this.c1Label7.TabIndex = 7;
            this.c1Label7.Text = "Country:";
            // 
            // FirstName
            // 
            this.FirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstName.ErrorInfo.ErrorAction = C1.Win.Input.ErrorAction.SetValueOnError;
            this.FirstName.Location = new System.Drawing.Point(283, 31);
            this.FirstName.Name = "FirstName";
            this.FirstName.PreValidation.PatternString = "[a-zA-Z]";
            this.FirstName.PreValidation.Validation = C1.Win.Input.PreValidationType.RegexPattern;
            this.FirstName.Size = new System.Drawing.Size(381, 22);
            this.FirstName.TabIndex = 1;
            // 
            // LastName
            // 
            this.LastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LastName.ErrorInfo.ErrorAction = C1.Win.Input.ErrorAction.SetValueOnError;
            this.LastName.Location = new System.Drawing.Point(283, 59);
            this.LastName.Name = "LastName";
            this.LastName.PreValidation.PatternString = "[a-zA-Z]";
            this.LastName.PreValidation.Validation = C1.Win.Input.PreValidationType.RegexPattern;
            this.LastName.Size = new System.Drawing.Size(381, 22);
            this.LastName.TabIndex = 2;
            // 
            // Extension
            // 
            this.Extension.Location = new System.Drawing.Point(283, 143);
            this.Extension.Name = "Extension";
            this.Extension.NullText = "0";
            this.Extension.PreValidation.Validation = C1.Win.Input.PreValidationType.PreValidatingEvent;
            this.Extension.Size = new System.Drawing.Size(100, 22);
            this.Extension.TabIndex = 5;
            this.Extension.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Extension.UpDownButtonClick += new System.EventHandler<C1.Win.Input.UpDownButtonClickEventArgs>(this.Extension_UpDownButtonClick);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhoneNumber.ErrorInfo.ErrorAction = C1.Win.Input.ErrorAction.SetValueOnError;
            this.PhoneNumber.Location = new System.Drawing.Point(283, 87);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.PreValidation.PatternString = "[0-9+()]";
            this.PhoneNumber.PreValidation.Validation = C1.Win.Input.PreValidationType.RegexPattern;
            this.PhoneNumber.Size = new System.Drawing.Size(381, 22);
            this.PhoneNumber.TabIndex = 3;
            // 
            // BirthDate
            // 
            this.BirthDate.DataType = typeof(System.DateTime);
            this.BirthDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BirthDate.Location = new System.Drawing.Point(283, 115);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(381, 22);
            this.BirthDate.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lnkClear);
            this.panel1.Controls.Add(this.pictureSuccess);
            this.panel1.Controls.Add(this.btnSaveRecord);
            this.panel1.Location = new System.Drawing.Point(283, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 25);
            this.panel1.TabIndex = 15;
            // 
            // lnkClear
            // 
            this.lnkClear.AutoSize = true;
            this.lnkClear.Location = new System.Drawing.Point(120, 8);
            this.lnkClear.Name = "lnkClear";
            this.lnkClear.Size = new System.Drawing.Size(34, 15);
            this.lnkClear.TabIndex = 8;
            this.lnkClear.TabStop = true;
            this.lnkClear.Text = "Clear";
            this.lnkClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClear_LinkClicked);
            // 
            // pictureSuccess
            // 
            this.pictureSuccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureSuccess.Location = new System.Drawing.Point(352, 1);
            this.pictureSuccess.Name = "pictureSuccess";
            this.pictureSuccess.Size = new System.Drawing.Size(29, 22);
            this.pictureSuccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureSuccess.TabIndex = 2;
            this.pictureSuccess.TabStop = false;
            this.pictureSuccess.Visible = false;
            // 
            // btnSaveRecord
            // 
            this.btnSaveRecord.Location = new System.Drawing.Point(0, 1);
            this.btnSaveRecord.Name = "btnSaveRecord";
            this.btnSaveRecord.Size = new System.Drawing.Size(113, 23);
            this.btnSaveRecord.TabIndex = 8;
            this.btnSaveRecord.Text = "Save record";
            this.btnSaveRecord.UseVisualStyleBackColor = true;
            this.btnSaveRecord.Click += new System.EventHandler(this.btnSaveRecord_Click);
            // 
            // picturePhoto
            // 
            this.picturePhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturePhoto.Location = new System.Drawing.Point(3, 3);
            this.picturePhoto.Name = "picturePhoto";
            this.editFormPanel.SetRowSpan(this.picturePhoto, 7);
            this.picturePhoto.Size = new System.Drawing.Size(179, 190);
            this.picturePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePhoto.TabIndex = 0;
            this.picturePhoto.TabStop = false;
            this.picturePhoto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // editFormPanel
            // 
            this.editFormPanel.ColumnCount = 3;
            this.editFormPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.editFormPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.editFormPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.editFormPanel.Controls.Add(this.picturePhoto, 0, 0);
            this.editFormPanel.Controls.Add(this.c1Label1, 1, 0);
            this.editFormPanel.Controls.Add(this.c1Label2, 1, 1);
            this.editFormPanel.Controls.Add(this.c1Label3, 1, 2);
            this.editFormPanel.Controls.Add(this.c1Label4, 1, 3);
            this.editFormPanel.Controls.Add(this.c1Label5, 1, 4);
            this.editFormPanel.Controls.Add(this.c1Label6, 1, 5);
            this.editFormPanel.Controls.Add(this.c1Label7, 1, 6);
            this.editFormPanel.Controls.Add(this.FirstName, 2, 1);
            this.editFormPanel.Controls.Add(this.LastName, 2, 2);
            this.editFormPanel.Controls.Add(this.Extension, 2, 5);
            this.editFormPanel.Controls.Add(this.PhoneNumber, 2, 3);
            this.editFormPanel.Controls.Add(this.BirthDate, 2, 4);
            this.editFormPanel.Controls.Add(this.panel1, 2, 7);
            this.editFormPanel.Controls.Add(this.Country, 2, 6);
            this.editFormPanel.Controls.Add(this.lnkSelectFile, 2, 0);
            this.editFormPanel.Controls.Add(this.errorInfo, 1, 8);
            this.editFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editFormPanel.Location = new System.Drawing.Point(0, 0);
            this.editFormPanel.Name = "editFormPanel";
            this.editFormPanel.RowCount = 9;
            this.editFormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.editFormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.editFormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.editFormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.editFormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.editFormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.editFormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.editFormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.editFormPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.editFormPanel.Size = new System.Drawing.Size(667, 394);
            this.editFormPanel.TabIndex = 1;
            // 
            // Country
            // 
            this.Country.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Country.ErrorInfo.ErrorAction = C1.Win.Input.ErrorAction.SetValueOnError;
            this.Country.Location = new System.Drawing.Point(283, 171);
            this.Country.Name = "Country";
            this.Country.Placeholder = "Please, select value";
            this.Country.PreValidation.PatternString = "[a-zA-Z]";
            this.Country.PreValidation.Validation = C1.Win.Input.PreValidationType.RegexPattern;
            this.Country.Size = new System.Drawing.Size(381, 22);
            this.Country.TabIndex = 6;
            // 
            // lnkSelectFile
            // 
            this.lnkSelectFile.AutoSize = true;
            this.lnkSelectFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkSelectFile.Location = new System.Drawing.Point(283, 0);
            this.lnkSelectFile.Name = "lnkSelectFile";
            this.lnkSelectFile.Size = new System.Drawing.Size(381, 28);
            this.lnkSelectFile.TabIndex = 0;
            this.lnkSelectFile.TabStop = true;
            this.lnkSelectFile.Text = "Select a file";
            this.lnkSelectFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkSelectFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSelectFile_LinkClicked);
            // 
            // errorInfo
            // 
            this.errorInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editFormPanel.SetColumnSpan(this.errorInfo, 2);
            this.errorInfo.Location = new System.Drawing.Point(199, 239);
            this.errorInfo.Multiline = true;
            this.errorInfo.Name = "errorInfo";
            this.errorInfo.ReadOnly = true;
            this.errorInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.errorInfo.Size = new System.Drawing.Size(465, 152);
            this.errorInfo.TabIndex = 15;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "png";
            this.openFileDialog1.Filter = "Png files|*.PNG|All files|*.*";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DataCreating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editFormPanel);
            this.Name = "DataCreating";
            this.Size = new System.Drawing.Size(667, 394);
            this.Load += new System.EventHandler(this.DataCreating_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Extension)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthDate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSuccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePhoto)).EndInit();
            this.editFormPanel.ResumeLayout(false);
            this.editFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Country)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel editFormPanel;
        private C1.Win.Input.C1Label c1Label1;
        private C1.Win.Input.C1Label c1Label2;
        private C1.Win.Input.C1Label c1Label3;
        private C1.Win.Input.C1Label c1Label4;
        private C1.Win.Input.C1Label c1Label5;
        private C1.Win.Input.C1Label c1Label6;
        private C1.Win.Input.C1Label c1Label7;
        private C1.Win.Input.C1TextBox FirstName;
        private C1.Win.Input.C1TextBox LastName;
        private C1.Win.Input.C1NumericEdit Extension;
        private C1.Win.Input.C1TextBox PhoneNumber;
        private C1.Win.Input.C1TextBox BirthDate;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.Input.C1TextBox Country;
        private System.Windows.Forms.LinkLabel lnkSelectFile;
        private C1.Win.Input.C1PictureBox picturePhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private C1.Win.Input.C1PictureBox pictureSuccess;
        private System.Windows.Forms.Button btnSaveRecord;
        private System.Windows.Forms.Timer timer1;
        private C1.Win.Input.C1TextBox errorInfo;
        private System.Windows.Forms.LinkLabel lnkClear;
    }
}
