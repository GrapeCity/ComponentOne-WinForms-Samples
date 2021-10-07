
namespace ControlExplorer.FlexGrid
{
    partial class ColumnBandsMultiRow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColumnBandsMultiRow));
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
            this.c1FlexGridBandedView1 = new C1.Win.C1FlexGrid.C1FlexGridBandedView();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridBandedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.AllowEditing = false;
            this.c1FlexGrid1.AllowMergingFixed = C1.Win.C1FlexGrid.AllowMergingEnum.Custom;
            this.c1FlexGrid1.ColumnContextMenuEnabled = true;
            this.c1FlexGrid1.ColumnInfo = resources.GetString("c1FlexGrid1.ColumnInfo");
            this.c1FlexGrid1.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
            this.c1FlexGrid1.Rows.Count = 2157;
            this.c1FlexGrid1.Rows.DefaultSize = 22;
            this.c1FlexGrid1.Rows.Fixed = 2;
            this.c1FlexGrid1.Size = new System.Drawing.Size(1561, 809);
            // 
            // c1FlexGridBandedView1
            // 
            band1.Caption = "Order";
            band2.Caption = "Id";
            band2.Name = "OrderID";
            band3.Caption = "Date";
            band3.Name = "OrderDate";
            band1.Children.Add(band2);
            band1.Children.Add(band3);
            band1.CollapseTo = "OrderDate";
            band1.Name = "BandOrder";
            band4.Caption = "CompanyName";
            band4.Name = "CompanyName";
            band5.Caption = "Country";
            band5.Name = "Country";
            band6.Caption = "Salesperson";
            band6.Name = "Salesperson";
            band7.Caption = "Product";
            band8.Caption = "Name";
            band8.Name = "Product";
            band9.Caption = "UnitPrice";
            band9.Name = "UnitPrice";
            band10.Caption = "Quantity";
            band10.Name = "Quantity";
            band11.Caption = "Discount";
            band11.Name = "Discount";
            band7.Children.Add(band8);
            band7.Children.Add(band9);
            band7.Children.Add(band10);
            band7.Children.Add(band11);
            band7.CollapseTo = "Discount";
            band7.Name = "BandProduct";
            band12.Caption = "ExtendedPrice";
            band12.Name = "ExtendedPrice";
            this.c1FlexGridBandedView1.Bands.Add(band1);
            this.c1FlexGridBandedView1.Bands.Add(band4);
            this.c1FlexGridBandedView1.Bands.Add(band5);
            this.c1FlexGridBandedView1.Bands.Add(band6);
            this.c1FlexGridBandedView1.Bands.Add(band7);
            this.c1FlexGridBandedView1.Bands.Add(band12);
            this.c1FlexGridBandedView1.FlexGrid = this.c1FlexGrid1;
            // 
            // ColumnBandsMultiRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 809);
            this.Name = "ColumnBandsMultiRow";
            this.Text = "ColumnBandsMultiRow";
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridBandedView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private C1.Win.C1FlexGrid.C1FlexGridBandedView c1FlexGridBandedView1;
    }
}