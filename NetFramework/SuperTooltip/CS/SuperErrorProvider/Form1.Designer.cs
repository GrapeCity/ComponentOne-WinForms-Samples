namespace SuperErrorProvider
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.c1SuperTooltip1 = new C1.Win.SuperTooltip.C1SuperTooltip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClearError = new System.Windows.Forms.Button();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbField = new System.Windows.Forms.ComboBox();
            this.navigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new System.Data.DataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSetError = new System.Windows.Forms.Button();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.epError = new C1.Win.SuperTooltip.C1SuperErrorProvider(this.components);
            this.epWarning = new C1.Win.SuperTooltip.C1SuperErrorProvider(this.components);
            this.epInfo = new C1.Win.SuperTooltip.C1SuperErrorProvider(this.components);
            this.epComplete = new C1.Win.SuperTooltip.C1SuperErrorProvider(this.components);
            this.epDataBound = new C1.Win.SuperTooltip.C1SuperErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigator)).BeginInit();
            this.navigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epComplete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDataBound)).BeginInit();
            this.SuspendLayout();
            // 
            // c1SuperTooltip1
            // 
            this.c1SuperTooltip1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.c1SuperTooltip1.Images.Add(new C1.Win.SuperTooltip.ImageEntry("Info2.png", ((System.Drawing.Image)(resources.GetObject("c1SuperTooltip1.Images")))));
            this.c1SuperTooltip1.Images.Add(new C1.Win.SuperTooltip.ImageEntry("Cancel2.png", ((System.Drawing.Image)(resources.GetObject("c1SuperTooltip1.Images1")))));
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(471, 317);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnClearError);
            this.tabPage1.Controls.Add(this.txtZip);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.cbField);
            this.tabPage1.Controls.Add(this.navigator);
            this.tabPage1.Controls.Add(this.btnSetError);
            this.tabPage1.Controls.Add(this.txtState);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtCity);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtPhone);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtLastName);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtFirstName);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(463, 291);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Data Bound Errors";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnClearError
            // 
            this.btnClearError.Location = new System.Drawing.Point(318, 23);
            this.btnClearError.Name = "btnClearError";
            this.btnClearError.Size = new System.Drawing.Size(87, 21);
            this.btnClearError.TabIndex = 17;
            this.btnClearError.Text = "Clear Error";
            this.btnClearError.UseVisualStyleBackColor = true;
            this.btnClearError.Click += new System.EventHandler(this.btnClearError_Click);
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(133, 220);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(167, 21);
            this.txtZip.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Zip:";
            // 
            // cbField
            // 
            this.cbField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbField.FormattingEnabled = true;
            this.cbField.Items.AddRange(new object[] {
            "FirstName",
            "LastName",
            "Phone",
            "Address",
            "City",
            "State",
            "Zip"});
            this.cbField.Location = new System.Drawing.Point(39, 23);
            this.cbField.Name = "cbField";
            this.cbField.Size = new System.Drawing.Size(153, 21);
            this.cbField.TabIndex = 0;
            // 
            // navigator
            // 
            this.navigator.AddNewItem = null;
            this.navigator.BindingSource = this.bs;
            this.navigator.CountItem = this.bindingNavigatorCountItem;
            this.navigator.DeleteItem = null;
            this.navigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.navigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.navigator.Location = new System.Drawing.Point(3, 263);
            this.navigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.navigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.navigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.navigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.navigator.Name = "navigator";
            this.navigator.PositionItem = this.bindingNavigatorPositionItem;
            this.navigator.Size = new System.Drawing.Size(457, 25);
            this.navigator.TabIndex = 16;
            this.navigator.Text = "bindingNavigator1";
            // 
            // bs
            // 
            this.bs.DataSource = this.ds;
            this.bs.Position = 0;
            // 
            // ds
            // 
            this.ds.DataSetName = "NewDataSet";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "1";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSetError
            // 
            this.btnSetError.Location = new System.Drawing.Point(230, 23);
            this.btnSetError.Name = "btnSetError";
            this.btnSetError.Size = new System.Drawing.Size(82, 21);
            this.btnSetError.TabIndex = 1;
            this.btnSetError.Text = "Set Error";
            this.btnSetError.UseVisualStyleBackColor = true;
            this.btnSetError.Click += new System.EventHandler(this.btnSetError_Click);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(133, 193);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(238, 21);
            this.txtState.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "State:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(133, 166);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(238, 21);
            this.txtCity.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "City:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(133, 139);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(238, 21);
            this.txtAddress.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Address:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(133, 112);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(167, 21);
            this.txtPhone.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Phone:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(133, 85);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(238, 21);
            this.txtLastName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(133, 58);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(238, 21);
            this.txtFirstName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "First Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(463, 291);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Informational Tips";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.epInfo.SetError(this.textBox3, resources.GetString("textBox3.Error"));
            this.epWarning.SetIconPadding(this.textBox3, 5);
            this.epError.SetIconPadding(this.textBox3, 5);
            this.epInfo.SetIconPadding(this.textBox3, 5);
            this.epComplete.SetIconPadding(this.textBox3, 5);
            this.textBox3.Location = new System.Drawing.Point(126, 173);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(249, 21);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox3.Leave += new System.EventHandler(this.textBox_Leave);
            this.textBox3.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Third:";
            // 
            // textBox2
            // 
            this.epInfo.SetError(this.textBox2, resources.GetString("textBox2.Error"));
            this.epWarning.SetIconPadding(this.textBox2, 5);
            this.epError.SetIconPadding(this.textBox2, 5);
            this.epInfo.SetIconPadding(this.textBox2, 5);
            this.epComplete.SetIconPadding(this.textBox2, 5);
            this.textBox2.Location = new System.Drawing.Point(126, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 21);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox2.Leave += new System.EventHandler(this.textBox_Leave);
            this.textBox2.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Second:";
            // 
            // textBox1
            // 
            this.epInfo.SetError(this.textBox1, resources.GetString("textBox1.Error"));
            this.epWarning.SetIconPadding(this.textBox1, 5);
            this.epError.SetIconPadding(this.textBox1, 5);
            this.epInfo.SetIconPadding(this.textBox1, 5);
            this.epComplete.SetIconPadding(this.textBox1, 5);
            this.textBox1.Location = new System.Drawing.Point(126, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox1.Leave += new System.EventHandler(this.textBox_Leave);
            this.textBox1.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First:";
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            this.epError.ToolTip = this.c1SuperTooltip1;
            // 
            // epWarning
            // 
            this.epWarning.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epWarning.ContainerControl = this;
            this.epWarning.Image = ((System.Drawing.Image)(resources.GetObject("epWarning.Image")));
            this.epWarning.ToolTip = this.c1SuperTooltip1;
            // 
            // epInfo
            // 
            this.epInfo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epInfo.ContainerControl = this;
            this.epInfo.Image = ((System.Drawing.Image)(resources.GetObject("epInfo.Image")));
            this.epInfo.ToolTip = this.c1SuperTooltip1;
            // 
            // epComplete
            // 
            this.epComplete.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epComplete.ContainerControl = this;
            this.epComplete.Image = ((System.Drawing.Image)(resources.GetObject("epComplete.Image")));
            this.epComplete.ImageHot = ((System.Drawing.Image)(resources.GetObject("epComplete.ImageHot")));
            this.epComplete.ToolTip = this.c1SuperTooltip1;
            this.epComplete.IconClick += new C1.Win.SuperTooltip.IconClickEventHandler(this.epComplete_IconClick);
            // 
            // epDataBound
            // 
            this.epDataBound.Antiphased = false;
            this.epDataBound.ContainerControl = this;
            this.epDataBound.DataSource = this.bs;
            this.epDataBound.ToolTip = this.c1SuperTooltip1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 317);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "C1SuperErrorProvider";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigator)).EndInit();
            this.navigator.ResumeLayout(false);
            this.navigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epComplete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDataBound)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.SuperTooltip.C1SuperTooltip c1SuperTooltip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private C1.Win.SuperTooltip.C1SuperErrorProvider epError;
        private C1.Win.SuperTooltip.C1SuperErrorProvider epWarning;
        private C1.Win.SuperTooltip.C1SuperErrorProvider epInfo;
        private C1.Win.SuperTooltip.C1SuperErrorProvider epComplete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Button btnSetError;
        private System.Windows.Forms.BindingNavigator navigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ComboBox cbField;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource bs;
        private System.Data.DataSet ds;
        private C1.Win.SuperTooltip.C1SuperErrorProvider epDataBound;
        private System.Windows.Forms.Button btnClearError;
    }
}

