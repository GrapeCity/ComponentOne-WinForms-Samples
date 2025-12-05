
namespace ControlExplorer.FlexGrid
{
    partial class ColumnBandsLayout
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
            C1.Win.FlexGrid.Band band19 = new C1.Win.FlexGrid.Band();
            C1.Win.FlexGrid.Band band20 = new C1.Win.FlexGrid.Band();
            C1.Win.FlexGrid.Band band21 = new C1.Win.FlexGrid.Band();
            C1.Win.FlexGrid.Band band22 = new C1.Win.FlexGrid.Band();
            C1.Win.FlexGrid.Band band23 = new C1.Win.FlexGrid.Band();
            C1.Win.FlexGrid.Band band24 = new C1.Win.FlexGrid.Band();
            C1.Win.FlexGrid.Band band25 = new C1.Win.FlexGrid.Band();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColumnBandsLayout));
            this.flexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            this.c1FlexGridBandedView1 = new C1.Win.FlexGrid.C1FlexGridBandedView();
            this.c1FlexGridBandedView2 = new C1.Win.FlexGrid.C1FlexGridBandedView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridBandedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridBandedView2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flexGrid1
            // 
            this.flexGrid1.AllowEditing = false;
            this.flexGrid1.ColumnContextMenuEnabled = true;
            this.flexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.flexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flexGrid1.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw;
            this.flexGrid1.Location = new System.Drawing.Point(3, 45);
            this.flexGrid1.Name = "flexGrid1";
            this.flexGrid1.Rows.Count = 1;
            this.flexGrid1.Size = new System.Drawing.Size(644, 537);
            this.flexGrid1.StyleInfo = resources.GetString("flexGrid1.StyleInfo");
            this.flexGrid1.TabIndex = 0;
            this.flexGrid1.UseCompatibleTextRendering = false;
            // 
            // c1FlexGridBandedView1
            // 
            band2.Name = "OrderID";
            band3.Name = "Saler";
            band4.ColSpan = 2;
            band4.Name = "OrderDate";
            band1.Children.Add(band2);
            band1.Children.Add(band3);
            band1.Children.Add(band4);
            band1.ColSpan = 2;
            band1.Name = "Order";
            band6.Name = "CompanyName";
            band7.Name = "Country";
            band5.Children.Add(band6);
            band5.Children.Add(band7);
            band5.ColSpan = 1;
            band5.Name = "Buyer";
            band9.ColSpan = 4;
            band9.Name = "Product";
            band10.Name = "UnitPrice";
            band11.Name = "Quantity";
            band12.Name = "Discount";
            band13.Name = "ExtendedPrice";
            band8.Children.Add(band9);
            band8.Children.Add(band10);
            band8.Children.Add(band11);
            band8.Children.Add(band12);
            band8.Children.Add(band13);
            band8.ColSpan = 4;
            band8.Name = "Article";
            this.c1FlexGridBandedView1.Bands.Add(band1);
            this.c1FlexGridBandedView1.Bands.Add(band5);
            this.c1FlexGridBandedView1.Bands.Add(band8);
            this.c1FlexGridBandedView1.ColumnContextMenuEnabled = true;
            this.c1FlexGridBandedView1.ShowBandHeaders = false;
            // 
            // c1FlexGridBandedView2
            // 
            band15.Name = "OrderID";
            band16.Name = "OrderDate";
            band17.ColSpan = 2;
            band17.Name = "Saler";
            band18.Name = "CompanyName";
            band19.Name = "Country";
            band14.Children.Add(band15);
            band14.Children.Add(band16);
            band14.Children.Add(band17);
            band14.Children.Add(band18);
            band14.Children.Add(band19);
            band14.ColSpan = 2;
            band14.Name = "Order";
            band21.ColSpan = 2;
            band21.Name = "Product";
            band22.Name = "UnitPrice";
            band23.Name = "Discount";
            band24.Name = "Quantity";
            band25.Name = "ExtendedPrice";
            band20.Children.Add(band21);
            band20.Children.Add(band22);
            band20.Children.Add(band23);
            band20.Children.Add(band24);
            band20.Children.Add(band25);
            band20.ColSpan = 2;
            band20.Name = "Article";
            this.c1FlexGridBandedView2.Bands.Add(band14);
            this.c1FlexGridBandedView2.Bands.Add(band20);
            this.c1FlexGridBandedView2.ColumnContextMenuEnabled = true;
            this.c1FlexGridBandedView2.ShowBandHeaders = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flexGrid1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(650, 585);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 36);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ColumnBandsLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ColumnBandsLayout";
            this.Size = new System.Drawing.Size(650, 585);
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridBandedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridBandedView2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGridBandedView c1FlexGridBandedView1;
        private C1.Win.FlexGrid.C1FlexGridBandedView c1FlexGridBandedView2;
        private C1.Win.FlexGrid.C1FlexGrid flexGrid1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
