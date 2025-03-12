namespace ControlExplorer.InputPanel
{
    partial class QueryBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryBuilder));
            this.c1InputPanel1 = new C1.Win.C1InputPanel.C1InputPanel();
            this.hdrQueryBuilder = new C1.Win.C1InputPanel.InputGroupHeader();
            this.btnAddNew = new C1.Win.C1InputPanel.InputButton();
            this.btnSubmit = new C1.Win.C1InputPanel.InputButton();
            this.inputSeparator1 = new C1.Win.C1InputPanel.InputSeparator();
            this.lblAndOr = new C1.Win.C1InputPanel.InputLabel();
            this.lblPropertyName = new C1.Win.C1InputPanel.InputLabel();
            this.lblOperator = new C1.Win.C1InputPanel.InputLabel();
            this.lblValue = new C1.Win.C1InputPanel.InputLabel();
            this.lblPlaceHolder = new C1.Win.C1InputPanel.InputLabel();
            this.hdrSqlText = new C1.Win.C1InputPanel.InputGroupHeader();
            this.txtSqlText = new C1.Win.C1InputPanel.InputTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1InputPanel1
            // 
            this.c1InputPanel1.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            this.c1InputPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1InputPanel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1InputPanel1.Items.Add(this.hdrQueryBuilder);
            this.c1InputPanel1.Items.Add(this.btnAddNew);
            this.c1InputPanel1.Items.Add(this.btnSubmit);
            this.c1InputPanel1.Items.Add(this.inputSeparator1);
            this.c1InputPanel1.Items.Add(this.lblAndOr);
            this.c1InputPanel1.Items.Add(this.lblPropertyName);
            this.c1InputPanel1.Items.Add(this.lblOperator);
            this.c1InputPanel1.Items.Add(this.lblValue);
            this.c1InputPanel1.Items.Add(this.lblPlaceHolder);
            this.c1InputPanel1.Items.Add(this.hdrSqlText);
            this.c1InputPanel1.Items.Add(this.txtSqlText);
            this.c1InputPanel1.Location = new System.Drawing.Point(0, 0);
            this.c1InputPanel1.Name = "c1InputPanel1";
            this.c1InputPanel1.Size = new System.Drawing.Size(1142, 279);
            this.c1InputPanel1.TabIndex = 0;
            // 
            // hdrQueryBuilder
            // 
            this.hdrQueryBuilder.Collapsible = true;
            this.hdrQueryBuilder.Name = "hdrQueryBuilder";
            this.hdrQueryBuilder.Text = "Query Builder";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Break = C1.Win.C1InputPanel.BreakType.None;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Text = "Add Condition";
            this.btnAddNew.ToolTipText = "Add New Condition Row";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Text = "Execute Query";
            this.btnSubmit.Width = 115;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // inputSeparator1
            // 
            this.inputSeparator1.Name = "inputSeparator1";
            this.inputSeparator1.Width = 357;
            // 
            // lblAndOr
            // 
            this.lblAndOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAndOr.FontPadding = true;
            this.lblAndOr.Name = "lblAndOr";
            this.lblAndOr.Text = "And/Or";
            this.lblAndOr.Width = 50;
            // 
            // lblPropertyName
            // 
            this.lblPropertyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropertyName.FontPadding = true;
            this.lblPropertyName.Name = "lblPropertyName";
            this.lblPropertyName.Text = "Field Name";
            this.lblPropertyName.Width = 100;
            // 
            // lblOperator
            // 
            this.lblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.FontPadding = true;
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Text = "Operator";
            this.lblOperator.Width = 100;
            // 
            // lblValue
            // 
            this.lblValue.Break = C1.Win.C1InputPanel.BreakType.Row;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.FontPadding = true;
            this.lblValue.Name = "lblValue";
            this.lblValue.Text = "Value";
            this.lblValue.Width = 100;
            // 
            // lblPlaceHolder
            // 
            this.lblPlaceHolder.Name = "lblPlaceHolder";
            this.lblPlaceHolder.Width = 50;
            // 
            // hdrSqlText
            // 
            this.hdrSqlText.Collapsible = true;
            this.hdrSqlText.Name = "hdrSqlText";
            this.hdrSqlText.Text = "SQL Text";
            // 
            // txtSqlText
            // 
            this.txtSqlText.Height = 63;
            this.txtSqlText.Multiline = true;
            this.txtSqlText.Name = "txtSqlText";
            this.txtSqlText.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread;
            this.txtSqlText.Width = 365;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Remove_2.gif");
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.ColumnInfo = resources.GetString("c1FlexGrid1.ColumnInfo");
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.DefaultSize = -1;
            this.c1FlexGrid1.Size = new System.Drawing.Size(1142, 343);
            this.c1FlexGrid1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.c1InputPanel1);
            this.splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.c1FlexGrid1);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(1142, 626);
            this.splitContainer1.SplitterDistance = 279;
            this.splitContainer1.TabIndex = 3;
            // 
            // QueryBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 626);
            this.Controls.Add(this.splitContainer1);
            this.Name = "QueryBuilder";
            this.Text = "QueryBuilder";
            this.Load += new System.EventHandler(this.QueryBuilder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1InputPanel.C1InputPanel c1InputPanel1;
        private C1.Win.C1InputPanel.InputGroupHeader hdrQueryBuilder;
        private C1.Win.C1InputPanel.InputLabel lblAndOr;
        private C1.Win.C1InputPanel.InputLabel lblPropertyName;
        private C1.Win.C1InputPanel.InputLabel lblOperator;
        private C1.Win.C1InputPanel.InputLabel lblValue;
        private C1.Win.C1InputPanel.InputSeparator inputSeparator1;
        private C1.Win.C1InputPanel.InputButton btnSubmit;
        private C1.Win.C1InputPanel.InputButton btnAddNew;
        private C1.Win.C1InputPanel.InputLabel lblPlaceHolder;
        private System.Windows.Forms.ImageList imageList1;
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1.Win.C1InputPanel.InputGroupHeader hdrSqlText;
        private C1.Win.C1InputPanel.InputTextBox txtSqlText;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}