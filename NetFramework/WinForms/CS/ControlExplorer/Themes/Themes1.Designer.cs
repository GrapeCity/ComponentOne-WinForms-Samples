namespace ControlExplorer.Themes
{
    partial class Themes1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Themes1));
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c1DemoDataSet = new ControlExplorer.C1DemoDataSet();
            this.employeesTableAdapter = new ControlExplorer.C1DemoDataSetTableAdapters.EmployeesTableAdapter();
            this.c1TrueDBGrid1 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.employeesOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new ControlExplorer.C1DemoDataSetTableAdapters.OrdersTableAdapter();
            this.c1ThemeController1 = new C1.Win.C1Themes.C1ThemeController();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.c1Label11 = new C1.Win.C1Input.C1Label();
            this.c1ComboBox2 = new C1.Win.C1Input.C1ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DemoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.ColumnInfo = resources.GetString("c1FlexGrid1.ColumnInfo");
            this.c1FlexGrid1.DataSource = this.employeesBindingSource;
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.c1FlexGrid1.Location = new System.Drawing.Point(3, 40);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.Count = 1;
            this.c1FlexGrid1.Rows.DefaultSize = 21;
            this.c1FlexGrid1.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None;
            this.c1FlexGrid1.Size = new System.Drawing.Size(855, 306);
            this.c1FlexGrid1.StyleInfo = resources.GetString("c1FlexGrid1.StyleInfo");
            this.c1ThemeController1.SetTheme(this.c1FlexGrid1, "(default)");
            this.c1FlexGrid1.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.c1DemoDataSet;
            // 
            // c1DemoDataSet
            // 
            this.c1DemoDataSet.DataSetName = "C1DemoDataSet";
            this.c1DemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.c1TrueDBGrid1.CaptionHeight = 25;
            this.c1TrueDBGrid1.DataSource = this.employeesOrdersBindingSource;
            this.c1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TrueDBGrid1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.c1TrueDBGrid1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.c1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column";
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(3, 352);
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid1.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.c1TrueDBGrid1.PrintInfo.MeasurementPrinterName = null;
            this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.c1TrueDBGrid1.RowHeight = 20;
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(855, 307);
            this.c1TrueDBGrid1.TabIndex = 1;
            this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
            this.c1ThemeController1.SetTheme(this.c1TrueDBGrid1, "(default)");
            this.c1TrueDBGrid1.UseCompatibleTextRendering = false;
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            // 
            // employeesOrdersBindingSource
            // 
            this.employeesOrdersBindingSource.DataMember = "EmployeesOrders";
            this.employeesOrdersBindingSource.DataSource = this.employeesBindingSource;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.c1TrueDBGrid1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.c1FlexGrid1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(861, 662);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.c1Label11, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.c1ComboBox2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(855, 31);
            this.tableLayoutPanel3.TabIndex = 20;
            // 
            // c1Label11
            // 
            this.c1Label11.AutoSize = true;
            this.c1Label11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1Label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.c1Label11.Location = new System.Drawing.Point(3, 0);
            this.c1Label11.Name = "c1Label11";
            this.c1Label11.Size = new System.Drawing.Size(114, 31);
            this.c1Label11.TabIndex = 17;
            this.c1Label11.Tag = null;
            this.c1Label11.Text = "Choose Theme:";
            this.c1Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.c1Label11.TextDetached = true;
            // 
            // c1ComboBox2
            // 
            this.c1ComboBox2.AllowSpinLoop = false;
            this.c1ComboBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1ComboBox2.GapHeight = 0;
            this.c1ComboBox2.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1ComboBox2.ImageTransparentColor = System.Drawing.Color.Empty;
            this.c1ComboBox2.ItemsDisplayMember = "";
            this.c1ComboBox2.ItemsValueMember = "";
            this.c1ComboBox2.Location = new System.Drawing.Point(125, 5);
            this.c1ComboBox2.Margin = new System.Windows.Forms.Padding(5);
            this.c1ComboBox2.Name = "c1ComboBox2";
            this.c1ComboBox2.Size = new System.Drawing.Size(200, 20);
            this.c1ComboBox2.TabIndex = 16;
            this.c1ComboBox2.Tag = null;
            this.c1ComboBox2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.c1ComboBox2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.c1ComboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Themes1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 662);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Name = "Themes1";
            this.Text = "Themes1";
            this.c1ThemeController1.SetTheme(this, "(default)");
            this.c1ThemeController1.SetThemeSettings(this, null);
            this.Load += new System.EventHandler(this.Themes1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DemoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1DemoDataSet c1DemoDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private C1DemoDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
        private System.Windows.Forms.BindingSource employeesOrdersBindingSource;
        private C1DemoDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private C1.Win.C1Themes.C1ThemeController c1ThemeController1;
        private C1.Win.TouchToolKit.C1Zoom c1Zoom1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private C1.Win.C1Input.C1Label c1Label11;
        private C1.Win.C1Input.C1ComboBox c1ComboBox2;
    }
}