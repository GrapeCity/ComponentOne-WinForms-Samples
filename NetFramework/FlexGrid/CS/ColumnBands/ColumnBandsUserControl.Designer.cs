
namespace ColumnBands
{
    partial class ColumnBandsUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColumnBandsUserControl));
            C1.Win.FlexGrid.Band band1 = new C1.Win.FlexGrid.Band();
            C1.Win.FlexGrid.Band band2 = new C1.Win.FlexGrid.Band();
            C1.Win.FlexGrid.Band band3 = new C1.Win.FlexGrid.Band();
            C1.Win.FlexGrid.Band band4 = new C1.Win.FlexGrid.Band();
            C1.Win.FlexGrid.Band band5 = new C1.Win.FlexGrid.Band();
            C1.Win.FlexGrid.Band band6 = new C1.Win.FlexGrid.Band();
            C1.Win.FlexGrid.Band band7 = new C1.Win.FlexGrid.Band();
            C1.Win.FlexGrid.Band band8 = new C1.Win.FlexGrid.Band();
            C1.Win.FlexGrid.Band band9 = new C1.Win.FlexGrid.Band();
            C1.Win.FlexGrid.Band band10 = new C1.Win.FlexGrid.Band();
            C1.Win.FlexGrid.Band band11 = new C1.Win.FlexGrid.Band();
            C1.Win.FlexGrid.Band band12 = new C1.Win.FlexGrid.Band();
            C1.Win.FlexGrid.Band band13 = new C1.Win.FlexGrid.Band();
            C1.Win.FlexGrid.Band band14 = new C1.Win.FlexGrid.Band();
            C1.Win.FlexGrid.Band band15 = new C1.Win.FlexGrid.Band();
            C1.Win.FlexGrid.Band band16 = new C1.Win.FlexGrid.Band();
            C1.Win.FlexGrid.Band band17 = new C1.Win.FlexGrid.Band();
            C1.Win.FlexGrid.Band band18 = new C1.Win.FlexGrid.Band();
            this.c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c1NWindDataSet = new ColumnBands.C1NWindDataSet();
            this.c1FlexGridBandedView1 = new C1.Win.FlexGrid.C1FlexGridBandedView();
            this.carsTableAdapter = new ColumnBands.C1NWindDataSetTableAdapters.CarsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NWindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridBandedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.AllowEditing = false;
            this.c1FlexGrid1.AllowMergingFixed = C1.Win.FlexGrid.AllowMergingEnum.Custom;
            this.c1FlexGrid1.ColumnContextMenuEnabled = true;
            this.c1FlexGrid1.ColumnInfo = resources.GetString("c1FlexGrid1.ColumnInfo");
            this.c1FlexGrid1.DataSource = this.carsBindingSource;
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw;
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.Count = 3;
            this.c1FlexGrid1.Rows.Fixed = 3;
            this.c1FlexGrid1.Size = new System.Drawing.Size(650, 585);
            this.c1FlexGrid1.StyleInfo = resources.GetString("c1FlexGrid1.StyleInfo");
            this.c1FlexGrid1.TabIndex = 0;
            this.c1FlexGrid1.VisualStyle = C1.Win.FlexGrid.VisualStyle.Office2010Silver;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.c1NWindDataSet;
            // 
            // c1NWindDataSet
            // 
            this.c1NWindDataSet.DataSetName = "C1NWindDataSet";
            this.c1NWindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // c1FlexGridBandedView1
            // 
            band1.Caption = "ID";
            band1.Name = "ID";
            band2.Caption = "Brand";
            band2.Name = "Brand";
            band3.Caption = "Model";
            band3.Name = "Model";
            band4.Caption = "Specifications";
            band5.Caption = "Engine";
            band6.Caption = "HP";
            band6.Name = "HP";
            band7.Caption = "Liter";
            band7.Name = "Liter";
            band8.Caption = "Cyl";
            band8.Name = "Cyl";
            band5.Children.Add(band6);
            band5.Children.Add(band7);
            band5.Children.Add(band8);
            band5.CollapseTo = "Cyl";
            band5.Name = "Engine";
            band9.Caption = "Transmission";
            band10.Caption = "TransmissSpeedCount";
            band10.IsCollapsed = true;
            band10.Name = "TransmissSpeedCount";
            band11.Caption = "TransmissAutomatic";
            band11.Name = "TransmissAutomatic";
            band9.Children.Add(band10);
            band9.Children.Add(band11);
            band9.CollapseTo = "TransmissAutomatic";
            band9.Name = "Transmission";
            band4.Children.Add(band5);
            band4.Children.Add(band9);
            band4.CollapseTo = "TransmissAutomatic";
            band4.Name = "Specifications";
            band12.Caption = "MPG_City";
            band12.Name = "MPG_City";
            band13.Caption = "MPG_Highway";
            band13.Name = "MPG_Highway";
            band14.Caption = "Category";
            band14.Name = "Category";
            band15.Caption = "Description";
            band15.Name = "Description";
            band16.Caption = "Picture";
            band16.Name = "Picture";
            band17.Caption = "Price";
            band17.Name = "Price";
            band18.Caption = "Hyperlink";
            band18.Name = "Hyperlink";
            this.c1FlexGridBandedView1.Bands.Add(band1);
            this.c1FlexGridBandedView1.Bands.Add(band2);
            this.c1FlexGridBandedView1.Bands.Add(band3);
            this.c1FlexGridBandedView1.Bands.Add(band4);
            this.c1FlexGridBandedView1.Bands.Add(band12);
            this.c1FlexGridBandedView1.Bands.Add(band13);
            this.c1FlexGridBandedView1.Bands.Add(band14);
            this.c1FlexGridBandedView1.Bands.Add(band15);
            this.c1FlexGridBandedView1.Bands.Add(band16);
            this.c1FlexGridBandedView1.Bands.Add(band17);
            this.c1FlexGridBandedView1.Bands.Add(band18);
            this.c1FlexGridBandedView1.ColumnContextMenuEnabled = true;
            this.c1FlexGridBandedView1.FlexGrid = this.c1FlexGrid1;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // ColumnBandsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1FlexGrid1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "ColumnBandsUserControl";
            this.Size = new System.Drawing.Size(650, 585);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NWindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridBandedView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGridBandedView c1FlexGridBandedView1;
        private C1NWindDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private C1NWindDataSet c1NWindDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        public C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
    }
}
