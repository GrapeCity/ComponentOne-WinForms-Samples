namespace DataEngineQueries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dgvResult = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.cbQuery = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelUnitPriceRange = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudUnitPriceTo = new System.Windows.Forms.NumericUpDown();
            this.nudUnitPriceFrom = new System.Windows.Forms.NumericUpDown();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelJoin = new System.Windows.Forms.Panel();
            this.gbQuery = new System.Windows.Forms.GroupBox();
            this.panelGroupRange = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nudGroupFilter = new System.Windows.Forms.NumericUpDown();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnExec = new System.Windows.Forms.Button();
            this.panelJoinFlexPivot = new System.Windows.Forms.Panel();
            this.btnFlexPivot = new System.Windows.Forms.Button();
            this.gbDatabase = new System.Windows.Forms.GroupBox();
            this.cbItemsCount = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblItemsCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblResultTotalRows = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageOD = new System.Windows.Forms.TabPage();
            this.lblODRowsTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvOrderDetails = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.tabPageProducts = new System.Windows.Forms.TabPage();
            this.lblProductsRowsTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvProducts = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.lblOrdersTotalRows = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvOrders = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.tabPageResults = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.panelUnitPriceRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPriceTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPriceFrom)).BeginInit();
            this.panelProduct.SuspendLayout();
            this.gbQuery.SuspendLayout();
            this.panelGroupRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGroupFilter)).BeginInit();
            this.panelJoinFlexPivot.SuspendLayout();
            this.gbDatabase.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageOD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.tabPageProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.tabPageOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.tabPageResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWarning
            // 
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(10, 84);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(272, 38);
            this.lblWarning.TabIndex = 0;
            this.lblWarning.Text = "No data is available. Click \"Generate\" button to start working with the sample.";
            this.lblWarning.Visible = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(195, 48);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(87, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dgvResult
            // 
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.ColumnInfo = "10,1,0,0,0,100,Columns:";
            this.dgvResult.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.dgvResult.Location = new System.Drawing.Point(8, 50);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Rows.DefaultSize = 20;
            this.dgvResult.Size = new System.Drawing.Size(630, 289);
            this.dgvResult.StyleInfo = resources.GetString("dgvResult.StyleInfo");
            this.dgvResult.TabIndex = 2;
            // 
            // cbQuery
            // 
            this.cbQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuery.FormattingEnabled = true;
            this.cbQuery.Items.AddRange(new object[] {
            "Join",
            "Join with FlexPivot",
            "Product",
            "UnitPrice Range",
            "Group Filter",
            "Month"});
            this.cbQuery.Location = new System.Drawing.Point(85, 13);
            this.cbQuery.Name = "cbQuery";
            this.cbQuery.Size = new System.Drawing.Size(140, 21);
            this.cbQuery.TabIndex = 3;
            this.cbQuery.SelectedIndexChanged += new System.EventHandler(this.cbQuery_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Query type:";
            // 
            // panelUnitPriceRange
            // 
            this.panelUnitPriceRange.Controls.Add(this.label4);
            this.panelUnitPriceRange.Controls.Add(this.label3);
            this.panelUnitPriceRange.Controls.Add(this.nudUnitPriceTo);
            this.panelUnitPriceRange.Controls.Add(this.nudUnitPriceFrom);
            this.panelUnitPriceRange.Location = new System.Drawing.Point(10, 40);
            this.panelUnitPriceRange.Name = "panelUnitPriceRange";
            this.panelUnitPriceRange.Size = new System.Drawing.Size(216, 59);
            this.panelUnitPriceRange.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "From:";
            // 
            // nudUnitPriceTo
            // 
            this.nudUnitPriceTo.DecimalPlaces = 2;
            this.nudUnitPriceTo.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudUnitPriceTo.Location = new System.Drawing.Point(55, 29);
            this.nudUnitPriceTo.Name = "nudUnitPriceTo";
            this.nudUnitPriceTo.Size = new System.Drawing.Size(75, 21);
            this.nudUnitPriceTo.TabIndex = 1;
            // 
            // nudUnitPriceFrom
            // 
            this.nudUnitPriceFrom.DecimalPlaces = 2;
            this.nudUnitPriceFrom.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudUnitPriceFrom.Location = new System.Drawing.Point(55, 3);
            this.nudUnitPriceFrom.Name = "nudUnitPriceFrom";
            this.nudUnitPriceFrom.Size = new System.Drawing.Size(75, 21);
            this.nudUnitPriceFrom.TabIndex = 0;
            this.nudUnitPriceFrom.ValueChanged += new System.EventHandler(this.nudUnitPriceFrom_ValueChanged);
            // 
            // panelProduct
            // 
            this.panelProduct.Controls.Add(this.cbProduct);
            this.panelProduct.Controls.Add(this.label5);
            this.panelProduct.Location = new System.Drawing.Point(10, 105);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(216, 60);
            this.panelProduct.TabIndex = 6;
            // 
            // cbProduct
            // 
            this.cbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(7, 26);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(205, 21);
            this.cbProduct.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Seclect product:";
            // 
            // panelJoin
            // 
            this.panelJoin.Location = new System.Drawing.Point(10, 171);
            this.panelJoin.Name = "panelJoin";
            this.panelJoin.Size = new System.Drawing.Size(216, 75);
            this.panelJoin.TabIndex = 7;
            // 
            // gbQuery
            // 
            this.gbQuery.Controls.Add(this.panelGroupRange);
            this.gbQuery.Controls.Add(this.lblTime);
            this.gbQuery.Controls.Add(this.btnExec);
            this.gbQuery.Controls.Add(this.label2);
            this.gbQuery.Controls.Add(this.cbQuery);
            this.gbQuery.Controls.Add(this.panelJoin);
            this.gbQuery.Controls.Add(this.panelJoinFlexPivot);
            this.gbQuery.Controls.Add(this.panelUnitPriceRange);
            this.gbQuery.Controls.Add(this.panelProduct);
            this.gbQuery.Location = new System.Drawing.Point(310, 12);
            this.gbQuery.Name = "gbQuery";
            this.gbQuery.Size = new System.Drawing.Size(356, 123);
            this.gbQuery.TabIndex = 8;
            this.gbQuery.TabStop = false;
            this.gbQuery.Text = "Query";
            // 
            // panelGroupRange
            // 
            this.panelGroupRange.Controls.Add(this.label1);
            this.panelGroupRange.Controls.Add(this.nudGroupFilter);
            this.panelGroupRange.Location = new System.Drawing.Point(10, 252);
            this.panelGroupRange.Name = "panelGroupRange";
            this.panelGroupRange.Size = new System.Drawing.Size(216, 75);
            this.panelGroupRange.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "From:";
            // 
            // nudGroupFilter
            // 
            this.nudGroupFilter.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudGroupFilter.Location = new System.Drawing.Point(55, 3);
            this.nudGroupFilter.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudGroupFilter.Name = "nudGroupFilter";
            this.nudGroupFilter.Size = new System.Drawing.Size(75, 21);
            this.nudGroupFilter.TabIndex = 8;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(233, 45);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(40, 13);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Time:";
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(233, 11);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(87, 23);
            this.btnExec.TabIndex = 2;
            this.btnExec.Text = "Execute";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // panelJoinFlexPivot
            // 
            this.panelJoinFlexPivot.Controls.Add(this.btnFlexPivot);
            this.panelJoinFlexPivot.Location = new System.Drawing.Point(10, 171);
            this.panelJoinFlexPivot.Name = "panelJoinFlexPivot";
            this.panelJoinFlexPivot.Size = new System.Drawing.Size(216, 75);
            this.panelJoinFlexPivot.TabIndex = 9;
            // 
            // btnFlexPivot
            // 
            this.btnFlexPivot.Location = new System.Drawing.Point(7, 27);
            this.btnFlexPivot.Name = "btnFlexPivot";
            this.btnFlexPivot.Size = new System.Drawing.Size(201, 23);
            this.btnFlexPivot.TabIndex = 10;
            this.btnFlexPivot.Text = "Analyze in FlexPivot";
            this.btnFlexPivot.UseVisualStyleBackColor = true;
            this.btnFlexPivot.Click += new System.EventHandler(this.btnFlexPivot_Click);
            // 
            // gbDatabase
            // 
            this.gbDatabase.Controls.Add(this.cbItemsCount);
            this.gbDatabase.Controls.Add(this.label7);
            this.gbDatabase.Controls.Add(this.lblItemsCount);
            this.gbDatabase.Controls.Add(this.label6);
            this.gbDatabase.Controls.Add(this.lblWarning);
            this.gbDatabase.Controls.Add(this.btnGenerate);
            this.gbDatabase.Location = new System.Drawing.Point(14, 12);
            this.gbDatabase.Name = "gbDatabase";
            this.gbDatabase.Size = new System.Drawing.Size(289, 123);
            this.gbDatabase.TabIndex = 9;
            this.gbDatabase.TabStop = false;
            this.gbDatabase.Text = "Database";
            // 
            // cbItemsCount
            // 
            this.cbItemsCount.FormattingEnabled = true;
            this.cbItemsCount.Items.AddRange(new object[] {
            "100,000",
            "1,000,000",
            "10,000,000"});
            this.cbItemsCount.Location = new System.Drawing.Point(14, 50);
            this.cbItemsCount.Name = "cbItemsCount";
            this.cbItemsCount.Size = new System.Drawing.Size(170, 21);
            this.cbItemsCount.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Select how many rows to add:";
            // 
            // lblItemsCount
            // 
            this.lblItemsCount.AutoSize = true;
            this.lblItemsCount.Location = new System.Drawing.Point(93, 17);
            this.lblItemsCount.Name = "lblItemsCount";
            this.lblItemsCount.Size = new System.Drawing.Size(14, 13);
            this.lblItemsCount.TabIndex = 3;
            this.lblItemsCount.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Items count:";
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDesc.Location = new System.Drawing.Point(3, 2);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(636, 46);
            this.lblDesc.TabIndex = 9;
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Total rows:";
            // 
            // lblResultTotalRows
            // 
            this.lblResultTotalRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResultTotalRows.AutoSize = true;
            this.lblResultTotalRows.Location = new System.Drawing.Point(76, 343);
            this.lblResultTotalRows.Name = "lblResultTotalRows";
            this.lblResultTotalRows.Size = new System.Drawing.Size(14, 13);
            this.lblResultTotalRows.TabIndex = 10;
            this.lblResultTotalRows.Text = "0";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageOD);
            this.tabControl1.Controls.Add(this.tabPageProducts);
            this.tabControl1.Controls.Add(this.tabPageOrders);
            this.tabControl1.Controls.Add(this.tabPageResults);
            this.tabControl1.Location = new System.Drawing.Point(14, 141);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(652, 387);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPageOD
            // 
            this.tabPageOD.Controls.Add(this.lblODRowsTotal);
            this.tabPageOD.Controls.Add(this.label10);
            this.tabPageOD.Controls.Add(this.dgvOrderDetails);
            this.tabPageOD.Location = new System.Drawing.Point(4, 22);
            this.tabPageOD.Name = "tabPageOD";
            this.tabPageOD.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOD.Size = new System.Drawing.Size(644, 361);
            this.tabPageOD.TabIndex = 0;
            this.tabPageOD.Text = "Order Details";
            this.tabPageOD.UseVisualStyleBackColor = true;
            // 
            // lblODRowsTotal
            // 
            this.lblODRowsTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblODRowsTotal.AutoSize = true;
            this.lblODRowsTotal.Location = new System.Drawing.Point(75, 343);
            this.lblODRowsTotal.Name = "lblODRowsTotal";
            this.lblODRowsTotal.Size = new System.Drawing.Size(14, 13);
            this.lblODRowsTotal.TabIndex = 12;
            this.lblODRowsTotal.Text = "0";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Total rows:";
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderDetails.ColumnInfo = "10,1,0,0,0,100,Columns:";
            this.dgvOrderDetails.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.dgvOrderDetails.Location = new System.Drawing.Point(3, 3);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.Rows.DefaultSize = 20;
            this.dgvOrderDetails.Size = new System.Drawing.Size(635, 332);
            this.dgvOrderDetails.StyleInfo = resources.GetString("dgvOrderDetails.StyleInfo");
            this.dgvOrderDetails.TabIndex = 3;
            // 
            // tabPageProducts
            // 
            this.tabPageProducts.Controls.Add(this.lblProductsRowsTotal);
            this.tabPageProducts.Controls.Add(this.label11);
            this.tabPageProducts.Controls.Add(this.dgvProducts);
            this.tabPageProducts.Location = new System.Drawing.Point(4, 22);
            this.tabPageProducts.Name = "tabPageProducts";
            this.tabPageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducts.Size = new System.Drawing.Size(644, 361);
            this.tabPageProducts.TabIndex = 1;
            this.tabPageProducts.Text = "Products";
            this.tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // lblProductsRowsTotal
            // 
            this.lblProductsRowsTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProductsRowsTotal.AutoSize = true;
            this.lblProductsRowsTotal.Location = new System.Drawing.Point(78, 346);
            this.lblProductsRowsTotal.Name = "lblProductsRowsTotal";
            this.lblProductsRowsTotal.Size = new System.Drawing.Size(14, 13);
            this.lblProductsRowsTotal.TabIndex = 14;
            this.lblProductsRowsTotal.Text = "0";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 345);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Total rows:";
            // 
            // dgvProducts
            // 
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.ColumnInfo = "10,1,0,0,0,100,Columns:";
            this.dgvProducts.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.dgvProducts.Location = new System.Drawing.Point(3, 3);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Rows.DefaultSize = 20;
            this.dgvProducts.Size = new System.Drawing.Size(635, 332);
            this.dgvProducts.StyleInfo = resources.GetString("dgvProducts.StyleInfo");
            this.dgvProducts.TabIndex = 4;
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.Controls.Add(this.lblOrdersTotalRows);
            this.tabPageOrders.Controls.Add(this.label12);
            this.tabPageOrders.Controls.Add(this.dgvOrders);
            this.tabPageOrders.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Size = new System.Drawing.Size(644, 361);
            this.tabPageOrders.TabIndex = 3;
            this.tabPageOrders.Text = "Orders";
            this.tabPageOrders.UseVisualStyleBackColor = true;
            // 
            // lblOrdersTotalRows
            // 
            this.lblOrdersTotalRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOrdersTotalRows.AutoSize = true;
            this.lblOrdersTotalRows.Location = new System.Drawing.Point(77, 344);
            this.lblOrdersTotalRows.Name = "lblOrdersTotalRows";
            this.lblOrdersTotalRows.Size = new System.Drawing.Size(14, 13);
            this.lblOrdersTotalRows.TabIndex = 14;
            this.lblOrdersTotalRows.Text = "0";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 343);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Total rows:";
            // 
            // dgvOrders
            // 
            this.dgvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrders.ColumnInfo = "10,1,0,0,0,100,Columns:";
            this.dgvOrders.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.dgvOrders.Location = new System.Drawing.Point(3, 3);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Rows.DefaultSize = 20;
            this.dgvOrders.Size = new System.Drawing.Size(635, 337);
            this.dgvOrders.StyleInfo = resources.GetString("dgvOrders.StyleInfo");
            this.dgvOrders.TabIndex = 4;
            // 
            // tabPageResults
            // 
            this.tabPageResults.Controls.Add(this.lblDesc);
            this.tabPageResults.Controls.Add(this.lblResultTotalRows);
            this.tabPageResults.Controls.Add(this.dgvResult);
            this.tabPageResults.Controls.Add(this.label8);
            this.tabPageResults.Location = new System.Drawing.Point(4, 22);
            this.tabPageResults.Name = "tabPageResults";
            this.tabPageResults.Size = new System.Drawing.Size(644, 361);
            this.tabPageResults.TabIndex = 2;
            this.tabPageResults.Text = "Results";
            this.tabPageResults.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 529);
            this.Controls.Add(this.gbQuery);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gbDatabase);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.MinimumSize = new System.Drawing.Size(696, 400);
            this.Name = "Form1";
            this.Text = "Queries Sample";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.panelUnitPriceRange.ResumeLayout(false);
            this.panelUnitPriceRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPriceTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPriceFrom)).EndInit();
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            this.gbQuery.ResumeLayout(false);
            this.gbQuery.PerformLayout();
            this.panelGroupRange.ResumeLayout(false);
            this.panelGroupRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGroupFilter)).EndInit();
            this.panelJoinFlexPivot.ResumeLayout(false);
            this.gbDatabase.ResumeLayout(false);
            this.gbDatabase.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageOD.ResumeLayout(false);
            this.tabPageOD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.tabPageProducts.ResumeLayout(false);
            this.tabPageProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.tabPageOrders.ResumeLayout(false);
            this.tabPageOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.tabPageResults.ResumeLayout(false);
            this.tabPageResults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnGenerate;
        private C1.Win.C1FlexGrid.C1FlexGrid dgvResult;
        private System.Windows.Forms.ComboBox cbQuery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelUnitPriceRange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudUnitPriceTo;
        private System.Windows.Forms.NumericUpDown nudUnitPriceFrom;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Panel panelJoin;
        private System.Windows.Forms.GroupBox gbQuery;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.GroupBox gbDatabase;
        private System.Windows.Forms.ComboBox cbItemsCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblItemsCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Panel panelGroupRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudGroupFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblResultTotalRows;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageOD;
        private System.Windows.Forms.TabPage tabPageProducts;
        private System.Windows.Forms.TabPage tabPageResults;
        private C1.Win.C1FlexGrid.C1FlexGrid dgvOrderDetails;
        private C1.Win.C1FlexGrid.C1FlexGrid dgvProducts;
        private System.Windows.Forms.Label lblODRowsTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblProductsRowsTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPageOrders;
        private System.Windows.Forms.Label lblOrdersTotalRows;
        private System.Windows.Forms.Label label12;
        private C1.Win.C1FlexGrid.C1FlexGrid dgvOrders;
        private System.Windows.Forms.Panel panelJoinFlexPivot;
        private System.Windows.Forms.Button btnFlexPivot;
    }
}

