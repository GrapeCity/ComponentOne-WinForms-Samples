namespace SchemaExtenderAndColumnStyles
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
            C1.C1DataExtender.C1DataView c1DataView1 = new C1.C1DataExtender.C1DataView();
            C1.C1DataExtender.C1ViewColumn c1ViewColumn1 = new C1.C1DataExtender.C1ViewColumn();
            C1.C1DataExtender.C1ViewColumn c1ViewColumn2 = new C1.C1DataExtender.C1ViewColumn();
            C1.C1DataExtender.C1ViewColumn c1ViewColumn3 = new C1.C1DataExtender.C1ViewColumn();
            C1.C1DataExtender.C1ViewColumn c1ViewColumn4 = new C1.C1DataExtender.C1ViewColumn();
            C1.C1DataExtender.C1ViewColumn c1ViewColumn5 = new C1.C1DataExtender.C1ViewColumn();
            C1.C1DataExtender.C1ViewColumn c1ViewColumn6 = new C1.C1DataExtender.C1ViewColumn();
            C1.C1DataExtender.C1ViewColumn c1ViewColumn7 = new C1.C1DataExtender.C1ViewColumn();
            C1.C1DataExtender.C1ViewColumn c1ViewColumn8 = new C1.C1DataExtender.C1ViewColumn();
            C1.C1DataExtender.C1ViewColumn c1ViewColumn9 = new C1.C1DataExtender.C1ViewColumn();
            C1.C1DataExtender.C1ViewColumn c1ViewColumn10 = new C1.C1DataExtender.C1ViewColumn();
            C1.C1DataExtender.C1ViewColumn c1ViewColumn11 = new C1.C1DataExtender.C1ViewColumn();
            C1.C1DataExtender.C1ViewColumn c1ViewColumn12 = new C1.C1DataExtender.C1ViewColumn();
            C1.C1DataExtender.C1ViewColumn c1ViewColumn13 = new C1.C1DataExtender.C1ViewColumn();
            C1.C1DataExtender.C1ViewColumn c1ViewColumn14 = new C1.C1DataExtender.C1ViewColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nwindDataSet1 = new SchemaExtenderAndColumnStyles.NwindDataSet();
            this.c1DataViewSet1 = new C1.C1DataExtender.C1DataViewSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DataViewSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // nwindDataSet1
            // 
            this.nwindDataSet1.DataSetName = "NwindDataSet";
            this.nwindDataSet1.EnforceConstraints = false;
            this.nwindDataSet1.Locale = new System.Globalization.CultureInfo("ru-RU");
            this.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // c1DataViewSet1
            // 
            this.c1DataViewSet1.DataSet = this.nwindDataSet1;
            this.c1DataViewSet1.DiagramXML = "<C1Diagram><Nodes><Node DesigningObjectName=\"DataView\"><Location X=\"10\" Y=\"10\" />" +
                "<Size Width=\"164\" Height=\"124\" /></Node></Nodes></C1Diagram>";
            this.c1DataViewSet1.SchemaExtenderName = "NWindDataSetExtender";
            c1ViewColumn1.ColumnNameSerialized = "OrderID";
            c1ViewColumn2.Caption = "Customer";
            c1ViewColumn2.ColumnNameSerialized = "CustomerID";
            c1ViewColumn3.ColumnNameSerialized = "EmployeeID";
            c1ViewColumn4.ColumnNameSerialized = "OrderDate";
            c1ViewColumn5.ColumnNameSerialized = "RequiredDate";
            c1ViewColumn6.ColumnNameSerialized = "ShippedDate";
            c1ViewColumn7.ColumnNameSerialized = "ShipVia";
            c1ViewColumn8.ColumnNameSerialized = "Freight";
            c1ViewColumn9.ColumnNameSerialized = "ShipName";
            c1ViewColumn10.ColumnNameSerialized = "ShipAddress";
            c1ViewColumn11.ColumnNameSerialized = "ShipCity";
            c1ViewColumn12.ColumnNameSerialized = "ShipRegion";
            c1ViewColumn13.ColumnNameSerialized = "ShipPostalCode";
            c1ViewColumn14.ColumnNameSerialized = "ShipCountry";
            c1DataView1.ColumnDefs.Add(c1ViewColumn1);
            c1DataView1.ColumnDefs.Add(c1ViewColumn2);
            c1DataView1.ColumnDefs.Add(c1ViewColumn3);
            c1DataView1.ColumnDefs.Add(c1ViewColumn4);
            c1DataView1.ColumnDefs.Add(c1ViewColumn5);
            c1DataView1.ColumnDefs.Add(c1ViewColumn6);
            c1DataView1.ColumnDefs.Add(c1ViewColumn7);
            c1DataView1.ColumnDefs.Add(c1ViewColumn8);
            c1DataView1.ColumnDefs.Add(c1ViewColumn9);
            c1DataView1.ColumnDefs.Add(c1ViewColumn10);
            c1DataView1.ColumnDefs.Add(c1ViewColumn11);
            c1DataView1.ColumnDefs.Add(c1ViewColumn12);
            c1DataView1.ColumnDefs.Add(c1ViewColumn13);
            c1DataView1.ColumnDefs.Add(c1ViewColumn14);
            c1DataView1.Definition = "Select * From Orders";
            c1DataView1.DefinitionDiagramXML = "";
            c1DataView1.ViewName = "DataView";
            this.c1DataViewSet1.Views.Add(c1DataView1);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(617, 62);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Set";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1FlexGrid1.ColumnInfo = resources.GetString("c1FlexGrid1.ColumnInfo");
            this.c1FlexGrid1.DataMember = "DataView";
            this.c1FlexGrid1.DataSource = this.c1DataViewSet1;
            this.c1FlexGrid1.Location = new System.Drawing.Point(12, 130);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.Count = 1;
            this.c1FlexGrid1.Rows.DefaultSize = 17;
            this.c1FlexGrid1.Size = new System.Drawing.Size(617, 209);
            this.c1FlexGrid1.TabIndex = 5;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(641, 351);
            this.Controls.Add(this.c1FlexGrid1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Column Styles";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DataViewSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NwindDataSet nwindDataSet1;
        private C1.C1DataExtender.C1DataViewSet c1DataViewSet1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
    }
}