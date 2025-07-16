namespace AnalyzeNew
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
            C1.Win.FlexGrid.FooterDescription footerDescription1 = new C1.Win.FlexGrid.FooterDescription();
            C1.Win.FlexGrid.AggregateDefinition aggregateDefinition1 = new C1.Win.FlexGrid.AggregateDefinition();
            C1.Win.FlexGrid.AggregateDefinition aggregateDefinition2 = new C1.Win.FlexGrid.AggregateDefinition();
            this._btnNameCountryCat = new System.Windows.Forms.Button();
            this._btnCatCountryName = new System.Windows.Forms.Button();
            this._btnCountryCat = new System.Windows.Forms.Button();
            this._chkCollapseDataTable = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this._flexDataTable = new C1.Win.FlexGrid.C1FlexGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this._chkHideDataTable = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._flexObjectList = new C1.Win.FlexGrid.C1FlexGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this._btnProdCountryActive = new System.Windows.Forms.Button();
            this._chkHideObjectList = new System.Windows.Forms.CheckBox();
            this._chkCollapseObjectList = new System.Windows.Forms.CheckBox();
            this._btnCountryProdActive = new System.Windows.Forms.Button();
            this._btnProdCountry = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flexDataTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flexObjectList)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnNameCountryCat
            // 
            this._btnNameCountryCat.Location = new System.Drawing.Point(13, 11);
            this._btnNameCountryCat.Name = "_btnNameCountryCat";
            this._btnNameCountryCat.Size = new System.Drawing.Size(184, 37);
            this._btnNameCountryCat.TabIndex = 1;
            this._btnNameCountryCat.Text = "Name/Country/Cat";
            this._btnNameCountryCat.UseVisualStyleBackColor = true;
            this._btnNameCountryCat.Click += new System.EventHandler(this._btnNameCountryCat_Click);
            // 
            // _btnCatCountryName
            // 
            this._btnCatCountryName.Location = new System.Drawing.Point(203, 11);
            this._btnCatCountryName.Name = "_btnCatCountryName";
            this._btnCatCountryName.Size = new System.Drawing.Size(184, 37);
            this._btnCatCountryName.TabIndex = 1;
            this._btnCatCountryName.Text = "Cat/Country/Name";
            this._btnCatCountryName.UseVisualStyleBackColor = true;
            this._btnCatCountryName.Click += new System.EventHandler(this._btnCatCountryName_Click);
            // 
            // _btnCountryCat
            // 
            this._btnCountryCat.Location = new System.Drawing.Point(393, 11);
            this._btnCountryCat.Name = "_btnCountryCat";
            this._btnCountryCat.Size = new System.Drawing.Size(184, 37);
            this._btnCountryCat.TabIndex = 1;
            this._btnCountryCat.Text = "Country/Cat";
            this._btnCountryCat.UseVisualStyleBackColor = true;
            this._btnCountryCat.Click += new System.EventHandler(this._btnCountryCat_Click);
            // 
            // _chkCollapseDataTable
            // 
            this._chkCollapseDataTable.AutoSize = true;
            this._chkCollapseDataTable.Location = new System.Drawing.Point(783, 18);
            this._chkCollapseDataTable.Name = "_chkCollapseDataTable";
            this._chkCollapseDataTable.Size = new System.Drawing.Size(88, 24);
            this._chkCollapseDataTable.TabIndex = 2;
            this._chkCollapseDataTable.Text = "Collapse";
            this._chkCollapseDataTable.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(12, 8);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(921, 455);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this._flexDataTable);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(913, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DataTable";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // _flexDataTable
            // 
            this._flexDataTable.ColumnInfo = "10,1,0,0,0,130,Columns:";
            this._flexDataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flexDataTable.Location = new System.Drawing.Point(3, 62);
            this._flexDataTable.Name = "_flexDataTable";
            this._flexDataTable.Rows.DefaultSize = 26;
            this._flexDataTable.Size = new System.Drawing.Size(907, 347);
            this._flexDataTable.TabIndex = 0;
            aggregateDefinition1.Aggregate = C1.Win.FlexGrid.AggregateEnum.Sum;
            aggregateDefinition1.Caption = "{0:C2}";
            aggregateDefinition1.PropertyName = "Sale Amount";
            aggregateDefinition2.Caption = "Total:";
            aggregateDefinition2.Column = 4;
            footerDescription1.Aggregates.Add(aggregateDefinition1);
            footerDescription1.Aggregates.Add(aggregateDefinition2);
            this._flexDataTable.Footers.Descriptions.Add(footerDescription1);
            this._flexDataTable.Footers.Fixed = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._chkHideDataTable);
            this.panel1.Controls.Add(this._btnNameCountryCat);
            this.panel1.Controls.Add(this._chkCollapseDataTable);
            this.panel1.Controls.Add(this._btnCatCountryName);
            this.panel1.Controls.Add(this._btnCountryCat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 59);
            this.panel1.TabIndex = 0;
            // 
            // _chkHideDataTable
            // 
            this._chkHideDataTable.AutoSize = true;
            this._chkHideDataTable.Location = new System.Drawing.Point(591, 18);
            this._chkHideDataTable.Name = "_chkHideDataTable";
            this._chkHideDataTable.Size = new System.Drawing.Size(186, 24);
            this._chkHideDataTable.TabIndex = 3;
            this._chkHideDataTable.Text = "Hide Grouped Columns";
            this._chkHideDataTable.UseVisualStyleBackColor = true;
            this._chkHideDataTable.CheckedChanged += new System.EventHandler(this._chkHideDataTable_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this._flexObjectList);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(913, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Object List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _flexObjectList
            // 
            this._flexObjectList.ColumnInfo = "10,1,0,0,0,130,Columns:";
            this._flexObjectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flexObjectList.Location = new System.Drawing.Point(3, 62);
            this._flexObjectList.Name = "_flexObjectList";
            this._flexObjectList.Rows.DefaultSize = 26;
            this._flexObjectList.Size = new System.Drawing.Size(907, 347);
            this._flexObjectList.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._btnProdCountryActive);
            this.panel2.Controls.Add(this._chkHideObjectList);
            this.panel2.Controls.Add(this._chkCollapseObjectList);
            this.panel2.Controls.Add(this._btnCountryProdActive);
            this.panel2.Controls.Add(this._btnProdCountry);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(907, 59);
            this.panel2.TabIndex = 2;
            // 
            // _btnProdCountryActive
            // 
            this._btnProdCountryActive.Location = new System.Drawing.Point(13, 11);
            this._btnProdCountryActive.Name = "_btnProdCountryActive";
            this._btnProdCountryActive.Size = new System.Drawing.Size(184, 37);
            this._btnProdCountryActive.TabIndex = 1;
            this._btnProdCountryActive.Text = "Prod/Country/Active";
            this._btnProdCountryActive.UseVisualStyleBackColor = true;
            this._btnProdCountryActive.Click += new System.EventHandler(this._btnProdCountryActive_Click);
            // 
            // _chkHideObjectList
            // 
            this._chkHideObjectList.AutoSize = true;
            this._chkHideObjectList.Location = new System.Drawing.Point(583, 18);
            this._chkHideObjectList.Name = "_chkHideObjectList";
            this._chkHideObjectList.Size = new System.Drawing.Size(186, 24);
            this._chkHideObjectList.TabIndex = 2;
            this._chkHideObjectList.Text = "Hide Grouped Columns";
            this._chkHideObjectList.UseVisualStyleBackColor = true;
            this._chkHideObjectList.CheckedChanged += new System.EventHandler(this._chkHideObjectList_CheckedChanged);
            // 
            // _chkCollapseObjectList
            // 
            this._chkCollapseObjectList.AutoSize = true;
            this._chkCollapseObjectList.Location = new System.Drawing.Point(775, 18);
            this._chkCollapseObjectList.Name = "_chkCollapseObjectList";
            this._chkCollapseObjectList.Size = new System.Drawing.Size(88, 24);
            this._chkCollapseObjectList.TabIndex = 2;
            this._chkCollapseObjectList.Text = "Collapse";
            this._chkCollapseObjectList.UseVisualStyleBackColor = true;
            // 
            // _btnCountryProdActive
            // 
            this._btnCountryProdActive.Location = new System.Drawing.Point(203, 11);
            this._btnCountryProdActive.Name = "_btnCountryProdActive";
            this._btnCountryProdActive.Size = new System.Drawing.Size(184, 37);
            this._btnCountryProdActive.TabIndex = 1;
            this._btnCountryProdActive.Text = "Country/Prod/Active";
            this._btnCountryProdActive.UseVisualStyleBackColor = true;
            this._btnCountryProdActive.Click += new System.EventHandler(this._btnCountryProdActive_Click);
            // 
            // _btnProdCountry
            // 
            this._btnProdCountry.Location = new System.Drawing.Point(393, 11);
            this._btnProdCountry.Name = "_btnProdCountry";
            this._btnProdCountry.Size = new System.Drawing.Size(184, 37);
            this._btnProdCountry.TabIndex = 1;
            this._btnProdCountry.Text = "Product/Country";
            this._btnProdCountry.UseVisualStyleBackColor = true;
            this._btnProdCountry.Click += new System.EventHandler(this._btnProdCountry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 455);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "C1FlexGrid: New Analyze";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._flexDataTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._flexObjectList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGrid _flexDataTable;
        private System.Windows.Forms.Button _btnNameCountryCat;
        private System.Windows.Forms.Button _btnCatCountryName;
        private System.Windows.Forms.Button _btnCountryCat;
        private System.Windows.Forms.CheckBox _chkCollapseDataTable;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private C1.Win.FlexGrid.C1FlexGrid _flexObjectList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button _btnProdCountryActive;
        private System.Windows.Forms.CheckBox _chkCollapseObjectList;
        private System.Windows.Forms.Button _btnCountryProdActive;
        private System.Windows.Forms.Button _btnProdCountry;
        private System.Windows.Forms.CheckBox _chkHideObjectList;
        private System.Windows.Forms.CheckBox _chkHideDataTable;
    }
}

