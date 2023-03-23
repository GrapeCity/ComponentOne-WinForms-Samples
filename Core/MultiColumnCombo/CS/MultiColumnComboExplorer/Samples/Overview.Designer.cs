
namespace MultiColumnComboExplorer.Samples
{
    partial class Overview
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
            C1.Win.Input.MultiColumnCombo.DisplayColumn displayColumn1 = new C1.Win.Input.MultiColumnCombo.DisplayColumn();
            C1.Win.Input.MultiColumnCombo.DisplayColumn displayColumn2 = new C1.Win.Input.MultiColumnCombo.DisplayColumn();
            C1.Win.Input.MultiColumnCombo.DisplayColumn displayColumn3 = new C1.Win.Input.MultiColumnCombo.DisplayColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overview));
            this.mccDefault = new C1.Win.Input.MultiColumnCombo.C1MultiColumnCombo();
            this.c1MultiColumnCombo3 = new C1.Win.Input.MultiColumnCombo.C1MultiColumnCombo();
            this.c1Label1 = new C1.Win.Input.C1Label();
            this.c1Label2 = new C1.Win.Input.C1Label();
            this.mccUnboundMode = new C1.Win.Input.MultiColumnCombo.C1MultiColumnCombo();
            this.ilFlags = new System.Windows.Forms.ImageList(this.components);
            this.btnAddItem = new C1.Win.Input.C1Button();
            this.btnClearItems = new C1.Win.Input.C1Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mccSearchWithFiltering = new C1.Win.Input.MultiColumnCombo.C1MultiColumnCombo();
            this.mccSearch = new C1.Win.Input.MultiColumnCombo.C1MultiColumnCombo();
            this.mccCustomStyle = new C1.Win.Input.MultiColumnCombo.C1MultiColumnCombo();
            this.c1MultiColumnCombo2 = new C1.Win.Input.MultiColumnCombo.C1MultiColumnCombo();
            this.c1Label3 = new C1.Win.Input.C1Label();
            this.c1Label4 = new C1.Win.Input.C1Label();
            this.c1Label5 = new C1.Win.Input.C1Label();
            this.btnRemoveLastItem = new C1.Win.Input.C1Button();
            this.c1Label6 = new C1.Win.Input.C1Label();
            this.c1Label7 = new C1.Win.Input.C1Label();
            ((System.ComponentModel.ISupportInitialize)(this.mccDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1MultiColumnCombo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mccUnboundMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearItems)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mccSearchWithFiltering)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mccSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mccCustomStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1MultiColumnCombo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveLastItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label7)).BeginInit();
            this.SuspendLayout();
            // 
            // mccDefault
            // 
            this.mccDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mccDefault.Location = new System.Drawing.Point(106, 13);
            this.mccDefault.MaxDropDownItems = 7;
            this.mccDefault.Name = "mccDefault";
            this.mccDefault.Placeholder = "Bound mode";
            this.mccDefault.Size = new System.Drawing.Size(152, 23);
            this.mccDefault.TabIndex = 0;
            // 
            // c1MultiColumnCombo3
            // 
            this.c1MultiColumnCombo3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1MultiColumnCombo3.Enabled = false;
            this.c1MultiColumnCombo3.Location = new System.Drawing.Point(106, 159);
            this.c1MultiColumnCombo3.Name = "c1MultiColumnCombo3";
            this.c1MultiColumnCombo3.Placeholder = "Disabled mode";
            this.c1MultiColumnCombo3.Size = new System.Drawing.Size(152, 23);
            this.c1MultiColumnCombo3.TabIndex = 2;
            // 
            // c1Label1
            // 
            this.c1Label1.AutoSize = true;
            this.c1Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Label1.Location = new System.Drawing.Point(13, 13);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(87, 23);
            this.c1Label1.TabIndex = 5;
            this.c1Label1.Text = "Bound mode:";
            this.c1Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // c1Label2
            // 
            this.c1Label2.AutoSize = true;
            this.c1Label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Label2.Location = new System.Drawing.Point(264, 13);
            this.c1Label2.Name = "c1Label2";
            this.c1Label2.Size = new System.Drawing.Size(142, 23);
            this.c1Label2.TabIndex = 6;
            this.c1Label2.Text = "Custom style:";
            this.c1Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mccUnboundMode
            // 
            displayColumn1.Caption = "Name";
            displayColumn1.Name = "Name";
            displayColumn2.Caption = "Capital";
            displayColumn2.Name = "Capital";
            displayColumn3.Caption = "Flag";
            displayColumn3.Name = "Flag";
            displayColumn3.Visible = false;
            this.mccUnboundMode.Columns.Add(displayColumn1);
            this.mccUnboundMode.Columns.Add(displayColumn2);
            this.mccUnboundMode.Columns.Add(displayColumn3);
            this.mccUnboundMode.DefaultIconSize = new System.Drawing.Size(20, 15);
            this.mccUnboundMode.Location = new System.Drawing.Point(106, 188);
            this.mccUnboundMode.Name = "mccUnboundMode";
            this.mccUnboundMode.Placeholder = "Unbound mode";
            this.mccUnboundMode.Size = new System.Drawing.Size(152, 23);
            this.mccUnboundMode.TabIndex = 7;
            this.mccUnboundMode.SelectedValueChanged += new System.EventHandler(this.mccUnboundMode_SelectedValueChanged);
            // 
            // ilFlags
            // 
            this.ilFlags.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilFlags.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilFlags.ImageStream")));
            this.ilFlags.TransparentColor = System.Drawing.Color.Transparent;
            this.ilFlags.Images.SetKeyName(0, "CH_Flag.png");
            this.ilFlags.Images.SetKeyName(1, "EN-Flag.png");
            this.ilFlags.Images.SetKeyName(2, "ES-Flag.png");
            this.ilFlags.Images.SetKeyName(3, "FR-Flag.png");
            this.ilFlags.Images.SetKeyName(4, "IN_Flag.png");
            this.ilFlags.Images.SetKeyName(5, "JP_Flag.png");
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(106, 217);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(124, 23);
            this.btnAddItem.TabIndex = 9;
            this.btnAddItem.Text = "Add item";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnClearItems
            // 
            this.btnClearItems.Location = new System.Drawing.Point(412, 217);
            this.btnClearItems.Name = "btnClearItems";
            this.btnClearItems.Size = new System.Drawing.Size(119, 23);
            this.btnClearItems.TabIndex = 11;
            this.btnClearItems.Text = "Clear items";
            this.btnClearItems.Click += new System.EventHandler(this.btnClearItems_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.mccUnboundMode, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.c1Label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mccSearchWithFiltering, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.mccDefault, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.mccSearch, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.c1Label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.mccCustomStyle, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.c1MultiColumnCombo3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.c1MultiColumnCombo2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.c1Label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.c1Label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.c1Label5, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAddItem, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnRemoveLastItem, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnClearItems, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.c1Label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.c1Label7, 2, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1004, 669);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // mccSearchWithFiltering
            // 
            this.mccSearchWithFiltering.AllowSearching = true;
            this.mccSearchWithFiltering.AllowSorting = false;
            this.mccSearchWithFiltering.AutoFiltering = true;
            this.mccSearchWithFiltering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mccSearchWithFiltering.Location = new System.Drawing.Point(412, 246);
            this.mccSearchWithFiltering.Name = "mccSearchWithFiltering";
            this.mccSearchWithFiltering.Placeholder = "Search with filtering mode";
            this.mccSearchWithFiltering.Size = new System.Drawing.Size(199, 23);
            this.mccSearchWithFiltering.TabIndex = 13;
            // 
            // mccSearch
            // 
            this.mccSearch.AllowSearching = true;
            this.mccSearch.AllowSorting = false;
            this.mccSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mccSearch.Location = new System.Drawing.Point(106, 246);
            this.mccSearch.Name = "mccSearch";
            this.mccSearch.Placeholder = "Search";
            this.mccSearch.Size = new System.Drawing.Size(152, 23);
            this.mccSearch.TabIndex = 12;
            // 
            // mccCustomStyle
            // 
            this.mccCustomStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mccCustomStyle.Location = new System.Drawing.Point(412, 13);
            this.mccCustomStyle.Name = "mccCustomStyle";
            this.mccCustomStyle.Placeholder = "Custom style";
            this.mccCustomStyle.Size = new System.Drawing.Size(199, 23);
            this.mccCustomStyle.Styles.Button.Default.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mccCustomStyle.Styles.Button.Default.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.mccCustomStyle.Styles.Button.Default.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.mccCustomStyle.Styles.Button.Hot.BackColor = System.Drawing.SystemColors.HotTrack;
            this.mccCustomStyle.Styles.Button.Hot.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mccCustomStyle.Styles.Button.HotPressed.BackColor = System.Drawing.SystemColors.HotTrack;
            this.mccCustomStyle.Styles.Button.HotPressed.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mccCustomStyle.Styles.Button.Pressed.BackColor = System.Drawing.SystemColors.HotTrack;
            this.mccCustomStyle.Styles.Button.Pressed.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mccCustomStyle.Styles.DropDownView.Alternate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.mccCustomStyle.Styles.DropDownView.Highlight.BackColor = System.Drawing.Color.MediumTurquoise;
            this.mccCustomStyle.TabIndex = 4;
            // 
            // c1MultiColumnCombo2
            // 
            this.c1MultiColumnCombo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1MultiColumnCombo2.Location = new System.Drawing.Point(412, 159);
            this.c1MultiColumnCombo2.Name = "c1MultiColumnCombo2";
            this.c1MultiColumnCombo2.Placeholder = "Readonly mode";
            this.c1MultiColumnCombo2.ReadOnly = true;
            this.c1MultiColumnCombo2.Size = new System.Drawing.Size(199, 23);
            this.c1MultiColumnCombo2.TabIndex = 1;
            // 
            // c1Label3
            // 
            this.c1Label3.AutoSize = true;
            this.c1Label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Label3.Location = new System.Drawing.Point(13, 188);
            this.c1Label3.Name = "c1Label3";
            this.tableLayoutPanel1.SetRowSpan(this.c1Label3, 2);
            this.c1Label3.Size = new System.Drawing.Size(87, 52);
            this.c1Label3.TabIndex = 9;
            this.c1Label3.Text = "Unbound mode:";
            this.c1Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // c1Label4
            // 
            this.c1Label4.AutoSize = true;
            this.c1Label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Label4.Location = new System.Drawing.Point(13, 159);
            this.c1Label4.Name = "c1Label4";
            this.c1Label4.Size = new System.Drawing.Size(87, 23);
            this.c1Label4.TabIndex = 10;
            this.c1Label4.Text = "Disabled mode:";
            this.c1Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // c1Label5
            // 
            this.c1Label5.AutoSize = true;
            this.c1Label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Label5.Location = new System.Drawing.Point(264, 159);
            this.c1Label5.Name = "c1Label5";
            this.c1Label5.Size = new System.Drawing.Size(142, 23);
            this.c1Label5.TabIndex = 11;
            this.c1Label5.Text = "Readonly mode:";
            this.c1Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRemoveLastItem
            // 
            this.btnRemoveLastItem.Location = new System.Drawing.Point(264, 217);
            this.btnRemoveLastItem.Name = "btnRemoveLastItem";
            this.btnRemoveLastItem.Size = new System.Drawing.Size(136, 23);
            this.btnRemoveLastItem.TabIndex = 10;
            this.btnRemoveLastItem.Text = "Remove last item";
            this.btnRemoveLastItem.Click += new System.EventHandler(this.btnRemoveLastItem_Click);
            // 
            // c1Label6
            // 
            this.c1Label6.AutoSize = true;
            this.c1Label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Label6.Location = new System.Drawing.Point(13, 246);
            this.c1Label6.Name = "c1Label6";
            this.c1Label6.Size = new System.Drawing.Size(87, 23);
            this.c1Label6.TabIndex = 14;
            this.c1Label6.Text = "Search:";
            this.c1Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // c1Label7
            // 
            this.c1Label7.AutoSize = true;
            this.c1Label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Label7.Location = new System.Drawing.Point(264, 246);
            this.c1Label7.Name = "c1Label7";
            this.c1Label7.Size = new System.Drawing.Size(142, 23);
            this.c1Label7.TabIndex = 15;
            this.c1Label7.Text = "Search with filtering mode:";
            this.c1Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Overview";
            this.Size = new System.Drawing.Size(1004, 669);
            this.Load += new System.EventHandler(this.Overview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mccDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1MultiColumnCombo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mccUnboundMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearItems)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mccSearchWithFiltering)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mccSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mccCustomStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1MultiColumnCombo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveLastItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label7)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private C1.Win.Input.MultiColumnCombo.C1MultiColumnCombo mccDefault;
        private C1.Win.Input.MultiColumnCombo.C1MultiColumnCombo c1MultiColumnCombo3;
        private C1.Win.Input.C1Label c1Label1;
        private C1.Win.Input.C1Label c1Label2;
        private C1.Win.Input.MultiColumnCombo.C1MultiColumnCombo mccUnboundMode;
        private C1.Win.Input.C1Button btnAddItem;
        private C1.Win.Input.C1Button btnClearItems;
        private System.Windows.Forms.ImageList ilFlags;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.Input.C1Label c1Label3;
        private C1.Win.Input.C1Label c1Label4;
        private C1.Win.Input.C1Label c1Label5;
        private C1.Win.Input.MultiColumnCombo.C1MultiColumnCombo mccSearchWithFiltering;
        private C1.Win.Input.MultiColumnCombo.C1MultiColumnCombo mccSearch;
        private C1.Win.Input.MultiColumnCombo.C1MultiColumnCombo mccCustomStyle;
        private C1.Win.Input.MultiColumnCombo.C1MultiColumnCombo c1MultiColumnCombo2;
        private C1.Win.Input.C1Button btnRemoveLastItem;
        private C1.Win.Input.C1Label c1Label6;
        private C1.Win.Input.C1Label c1Label7;
    }
}
