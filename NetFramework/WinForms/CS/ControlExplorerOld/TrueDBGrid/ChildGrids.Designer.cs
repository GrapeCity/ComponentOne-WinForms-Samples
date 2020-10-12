namespace ControlExplorer.TrueDBGrid
{
    partial class ChildGrids
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildGrids));
            this.c1TrueDBGrid1 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.c1TrueDBGrid2 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.c1TrueDBGrid3 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.ordersOrderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c1DemoDataSet = new ControlExplorer.C1DemoDataSet();
            this.customersTableAdapter = new ControlExplorer.C1DemoDataSetTableAdapters.CustomersTableAdapter();
            this.ordersTableAdapter = new ControlExplorer.C1DemoDataSetTableAdapters.OrdersTableAdapter();
            this.order_DetailsTableAdapter = new ControlExplorer.C1DemoDataSetTableAdapters.Order_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersOrderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DemoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.AllowAddNew = true;
            this.c1TrueDBGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1TrueDBGrid1.ChildGrid = this.c1TrueDBGrid2;
            this.c1TrueDBGrid1.DataSource = this.customersBindingSource;
            this.c1TrueDBGrid1.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.c1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TrueDBGrid1.FilterBar = true;
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            this.c1TrueDBGrid1.RecordSelectorWidth = 20;
            this.c1TrueDBGrid1.RowDivider.Color = System.Drawing.Color.LightGray;
            this.c1TrueDBGrid1.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1TrueDBGrid1.RowHeight = 20;
            this.c1TrueDBGrid1.RowSubDividerColor = System.Drawing.Color.LightGray;
            this.c1TrueDBGrid1.ScrollTips = true;
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(592, 446);
            this.c1TrueDBGrid1.TabIndex = 0;
            this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
            // 
            // c1TrueDBGrid2
            // 
            this.c1TrueDBGrid2.AllowAddNew = true;
            this.c1TrueDBGrid2.ChildGrid = this.c1TrueDBGrid3;
            this.c1TrueDBGrid2.DataSource = this.customersOrdersBindingSource;
            this.c1TrueDBGrid2.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid2.Images"))));
            this.c1TrueDBGrid2.Location = new System.Drawing.Point(12, 92);
            this.c1TrueDBGrid2.Name = "c1TrueDBGrid2";
            this.c1TrueDBGrid2.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid2.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid2.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid2.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid2.PrintInfo.PageSettings")));
            this.c1TrueDBGrid2.PropBag = resources.GetString("c1TrueDBGrid2.PropBag");
            this.c1TrueDBGrid2.RecordSelectorWidth = 20;
            this.c1TrueDBGrid2.RowDivider.Color = System.Drawing.Color.LightGray;
            this.c1TrueDBGrid2.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1TrueDBGrid2.RowHeight = 20;
            this.c1TrueDBGrid2.RowSubDividerColor = System.Drawing.Color.LightGray;
            this.c1TrueDBGrid2.Size = new System.Drawing.Size(592, 142);
            this.c1TrueDBGrid2.TabIndex = 1;
            this.c1TrueDBGrid2.TabStop = false;
            this.c1TrueDBGrid2.Text = "c1TrueDBGrid2";
            // 
            // c1TrueDBGrid3
            // 
            this.c1TrueDBGrid3.AllowAddNew = true;
            this.c1TrueDBGrid3.DataSource = this.ordersOrderDetailsBindingSource;
            this.c1TrueDBGrid3.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid3.Images"))));
            this.c1TrueDBGrid3.Location = new System.Drawing.Point(56, 168);
            this.c1TrueDBGrid3.Name = "c1TrueDBGrid3";
            this.c1TrueDBGrid3.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid3.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid3.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid3.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid3.PrintInfo.PageSettings")));
            this.c1TrueDBGrid3.PropBag = resources.GetString("c1TrueDBGrid3.PropBag");
            this.c1TrueDBGrid3.RecordSelectorWidth = 20;
            this.c1TrueDBGrid3.RowDivider.Color = System.Drawing.Color.LightGray;
            this.c1TrueDBGrid3.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1TrueDBGrid3.RowHeight = 20;
            this.c1TrueDBGrid3.RowSubDividerColor = System.Drawing.Color.LightGray;
            this.c1TrueDBGrid3.Size = new System.Drawing.Size(524, 92);
            this.c1TrueDBGrid3.TabIndex = 2;
            this.c1TrueDBGrid3.TabStop = false;
            this.c1TrueDBGrid3.Text = "c1TrueDBGrid3";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.c1DemoDataSet;
            // 
            // customersOrdersBindingSource
            // 
            this.customersOrdersBindingSource.DataMember = "CustomersOrders";
            this.customersOrdersBindingSource.DataSource = this.customersBindingSource;
            // 
            // ordersOrderDetailsBindingSource
            // 
            this.ordersOrderDetailsBindingSource.DataMember = "OrdersOrder Details";
            this.ordersOrderDetailsBindingSource.DataSource = this.customersOrdersBindingSource;
            // 
            // c1DemoDataSet
            // 
            this.c1DemoDataSet.DataSetName = "C1DemoDataSet";
            this.c1DemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // order_DetailsTableAdapter
            // 
            this.order_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // ChildGrids
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this.c1TrueDBGrid3);
            this.Controls.Add(this.c1TrueDBGrid2);
            this.Controls.Add(this.c1TrueDBGrid1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChildGrids";
            this.Text = "ChildGrids";
            this.Load += new System.EventHandler(this.ChildGrids_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersOrderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DemoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid2;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid3;
        private C1DemoDataSet c1DemoDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private ControlExplorer.C1DemoDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource customersOrdersBindingSource;
        private ControlExplorer.C1DemoDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource ordersOrderDetailsBindingSource;
        private ControlExplorer.C1DemoDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter;

    }
}