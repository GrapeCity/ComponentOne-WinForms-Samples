
namespace ColumnBandsMultiRow
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
            C1.Win.C1FlexGrid.Band band1 = new C1.Win.C1FlexGrid.Band();
            C1.Win.C1FlexGrid.Band band2 = new C1.Win.C1FlexGrid.Band();
            C1.Win.C1FlexGrid.Band band3 = new C1.Win.C1FlexGrid.Band();
            C1.Win.C1FlexGrid.Band band4 = new C1.Win.C1FlexGrid.Band();
            C1.Win.C1FlexGrid.Band band5 = new C1.Win.C1FlexGrid.Band();
            C1.Win.C1FlexGrid.Band band6 = new C1.Win.C1FlexGrid.Band();
            C1.Win.C1FlexGrid.Band band7 = new C1.Win.C1FlexGrid.Band();
            C1.Win.C1FlexGrid.Band band8 = new C1.Win.C1FlexGrid.Band();
            C1.Win.C1FlexGrid.Band band9 = new C1.Win.C1FlexGrid.Band();
            C1.Win.C1FlexGrid.Band band10 = new C1.Win.C1FlexGrid.Band();
            C1.Win.C1FlexGrid.Band band11 = new C1.Win.C1FlexGrid.Band();
            C1.Win.C1FlexGrid.Band band12 = new C1.Win.C1FlexGrid.Band();
            C1.Win.C1FlexGrid.Band band13 = new C1.Win.C1FlexGrid.Band();
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c1NWindDataSet = new ColumnBandsMultiRow.C1NWindDataSet();
            this.c1FlexGridBandedView1 = new C1.Win.C1FlexGrid.C1FlexGridBandedView();
            this.carsTableAdapter = new ColumnBandsMultiRow.C1NWindDataSetTableAdapters.CarsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NWindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridBandedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.AllowEditing = false;
            this.c1FlexGrid1.ColumnContextMenuEnabled = true;
            this.c1FlexGrid1.ColumnInfo = resources.GetString("c1FlexGrid1.ColumnInfo");
            this.c1FlexGrid1.DataSource = this.carsBindingSource;
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.Count = 4;
            this.c1FlexGrid1.Rows.Fixed = 4;
            this.c1FlexGrid1.Size = new System.Drawing.Size(650, 585);
            this.c1FlexGrid1.StyleInfo = resources.GetString("c1FlexGrid1.StyleInfo");
            this.c1FlexGrid1.TabIndex = 0;
            this.c1FlexGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver;
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
            band1.Name = "ID";
            band3.Name = "Brand";
            band4.Name = "Model";
            band5.Name = "Category";
            band6.ColSpan = 3;
            band6.Name = "Description";
            band6.RowSpan = 2;
            band2.Children.Add(band3);
            band2.Children.Add(band4);
            band2.Children.Add(band5);
            band2.Children.Add(band6);
            band2.ColSpan = 3;
            band2.Name = "Main";
            band8.Name = "HP";
            band9.Name = "Cyl";
            band10.Name = "MPG_City";
            band11.Name = "MPG_Highway";
            band12.Name = "TransmissAutomatic";
            band13.Name = "TransmissSpeedCount";
            band10.Caption = "MPG City";
            band11.Caption = "MPG Highway";
            band12.Caption = "Transmission Automatic";
            band13.Caption = "Transmission Speed Count";
            band7.Children.Add(band8);
            band7.Children.Add(band9);
            band7.Children.Add(band10);
            band7.Children.Add(band11);
            band7.Children.Add(band12);
            band7.Children.Add(band13);
            band7.ColSpan = 2;
            band7.Name = "Performance";
            this.c1FlexGridBandedView1.Bands.Add(band1);
            this.c1FlexGridBandedView1.Bands.Add(band2);
            this.c1FlexGridBandedView1.Bands.Add(band7);
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

        private C1.Win.C1FlexGrid.C1FlexGridBandedView c1FlexGridBandedView1;
        private C1NWindDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private C1NWindDataSet c1NWindDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        public C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
    }
}
