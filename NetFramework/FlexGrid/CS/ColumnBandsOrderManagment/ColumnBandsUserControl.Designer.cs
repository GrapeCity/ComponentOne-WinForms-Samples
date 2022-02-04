
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
            C1.Win.C1FlexGrid.Band band14 = new C1.Win.C1FlexGrid.Band();
            C1.Win.C1FlexGrid.Band band15 = new C1.Win.C1FlexGrid.Band();
            this.flexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.c1FlexGridBandedView1 = new C1.Win.C1FlexGrid.C1FlexGridBandedView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.c1FlexGridGroupPanel1 = new C1.Win.C1FlexGrid.C1FlexGridGroupPanel();
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridBandedView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flexGrid1
            // 
            this.flexGrid1.AllowEditing = false;
            this.flexGrid1.ColumnContextMenuEnabled = true;
            this.flexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:8{Visible:False;}\t9{Visible:False;}\t";
            this.flexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flexGrid1.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
            this.flexGrid1.Location = new System.Drawing.Point(3, 120);
            this.flexGrid1.Name = "flexGrid1";
            this.flexGrid1.Rows.Count = 3;
            this.flexGrid1.Rows.Fixed = 3;
            this.flexGrid1.Size = new System.Drawing.Size(644, 462);
            this.flexGrid1.StyleInfo = resources.GetString("flexGrid1.StyleInfo");
            this.flexGrid1.TabIndex = 0;
            this.flexGrid1.UseCompatibleTextRendering = false;
            // 
            // c1FlexGridBandedView1
            // 
            band1.Name = "OrderID";
            band3.Name = "ProductID";
            band4.Name = "ProductName";
            band2.Children.Add(band3);
            band2.Children.Add(band4);
            band2.ColSpan = 1;
            band2.Name = "Product";
            band6.Name = "UnitPrice";
            band7.Name = "Quantity";
            band8.Name = "Discount";
            band9.Name = "Amount";
            band10.Name = "OrderDate";
            band11.Name = "CompanyName";
            band12.Name = "ShipCountry";
            band13.Name = "ShipCity";
            band14.Name = "ShipAddress";
            band15.Name = "DeliveryDate";
            band5.Children.Add(band6);
            band5.Children.Add(band7);
            band5.Children.Add(band8);
            band5.Children.Add(band9);
            band5.Children.Add(band10);
            band5.Children.Add(band11);
            band5.Children.Add(band12);
            band5.Children.Add(band13);
            band5.Children.Add(band14);
            band5.Children.Add(band15);
            band5.ColSpan = 5;
            band5.Name = "Details";
            this.c1FlexGridBandedView1.Bands.Add(band1);
            this.c1FlexGridBandedView1.Bands.Add(band2);
            this.c1FlexGridBandedView1.Bands.Add(band5);
            this.c1FlexGridBandedView1.ColumnContextMenuEnabled = true;
            this.c1FlexGridBandedView1.FlexGrid = this.flexGrid1;
            this.c1FlexGridBandedView1.ShowBandHeaders = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flexGrid1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.c1FlexGridGroupPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(650, 585);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // c1FlexGridGroupPanel1
            // 
            this.c1FlexGridGroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGridGroupPanel1.FlexGrid = this.flexGrid1;
            this.c1FlexGridGroupPanel1.Location = new System.Drawing.Point(3, 3);
            this.c1FlexGridGroupPanel1.Name = "c1FlexGridGroupPanel1";
            this.c1FlexGridGroupPanel1.Size = new System.Drawing.Size(644, 111);
            this.c1FlexGridGroupPanel1.TabIndex = 1;
            this.c1FlexGridGroupPanel1.Text = "c1FlexGridGroupPanel1";
            // 
            // ColumnBandsGrouping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ColumnBandsGrouping";
            this.Size = new System.Drawing.Size(650, 585);
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridBandedView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGridBandedView c1FlexGridBandedView1;
        private C1.Win.C1FlexGrid.C1FlexGrid flexGrid1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.C1FlexGrid.C1FlexGridGroupPanel c1FlexGridGroupPanel1;
    }
}
