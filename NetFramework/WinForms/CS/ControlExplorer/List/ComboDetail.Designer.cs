namespace ControlExplorer.List
{
    partial class ComboDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComboDetail));
            this.c1Combo1 = new C1.Win.C1List.C1Combo();
            this.c1List1 = new C1.Win.C1List.C1List();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1List1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1Combo1
            // 
            this.c1Combo1.AddItemSeparator = ';';
            this.c1Combo1.AutoCompletion = true;
            this.c1Combo1.AutoDropDown = true;
            this.c1Combo1.AutoSelect = true;
            this.c1Combo1.Caption = "C1Combo";
            this.c1Combo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.c1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.c1Combo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Combo1.EditorBackColor = System.Drawing.SystemColors.Window;
            this.c1Combo1.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.c1Combo1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1Combo1.Images"))));
            this.c1Combo1.Location = new System.Drawing.Point(23, 3);
            this.c1Combo1.MatchEntryTimeout = ((long)(2000));
            this.c1Combo1.MaxDropDownItems = ((short)(8));
            this.c1Combo1.MaxLength = 32767;
            this.c1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.c1Combo1.Name = "c1Combo1";
            this.c1Combo1.PropBag = resources.GetString("c1Combo1.PropBag");
            this.c1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1Combo1.Size = new System.Drawing.Size(486, 21);
            this.c1Combo1.TabIndex = 0;
            this.c1Combo1.Text = "c1Combo1";
            this.c1Combo1.Change += new C1.Win.C1List.ChangeEventHandler(this.c1Combo1_Change);
            // 
            // c1List1
            // 
            this.c1List1.AddItemSeparator = ';';
            this.c1List1.Caption = "C1List";
            this.c1List1.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark;
            this.c1List1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1List1.ExtendRightColumn = true;
            this.c1List1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1List1.Images"))));
            this.c1List1.Location = new System.Drawing.Point(535, 3);
            this.c1List1.MatchEntryTimeout = ((long)(2000));
            this.c1List1.Name = "c1List1";
            this.c1List1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1List1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1List1.PreviewInfo.ZoomFactor = 75D;
            this.c1List1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1List1.PrintInfo.PageSettings")));
            this.c1List1.PropBag = resources.GetString("c1List1.PropBag");
            this.c1List1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1List1.ShowHeaderCheckBox = false;
            this.c1List1.Size = new System.Drawing.Size(486, 667);
            this.c1List1.TabIndex = 1;
            this.c1List1.Text = "c1List1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Controls.Add(this.c1List1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.c1Combo1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1045, 673);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ComboDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 673);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ComboDetail";
            this.Text = "ComboDetail";
            this.Load += new System.EventHandler(this.ComboDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1List1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1List.C1Combo c1Combo1;
        private C1.Win.C1List.C1List c1List1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}