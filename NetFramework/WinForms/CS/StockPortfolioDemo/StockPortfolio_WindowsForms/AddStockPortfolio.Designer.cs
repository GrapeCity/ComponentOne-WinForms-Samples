namespace StockPortfolio
{
    partial class AddStockPortfolio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStockPortfolio));
            this.AddStockPortfolioButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.c1FlexGrid = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddStockPortfolioButton
            // 
            this.AddStockPortfolioButton.BackColor = System.Drawing.Color.AliceBlue;
            this.AddStockPortfolioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddStockPortfolioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.AddStockPortfolioButton.Location = new System.Drawing.Point(542, 163);
            this.AddStockPortfolioButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddStockPortfolioButton.Name = "AddStockPortfolioButton";
            this.AddStockPortfolioButton.Size = new System.Drawing.Size(88, 42);
            this.AddStockPortfolioButton.TabIndex = 7;
            this.AddStockPortfolioButton.Text = "Add";
            this.AddStockPortfolioButton.UseVisualStyleBackColor = false;
            this.AddStockPortfolioButton.Visible = false;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(20, 97);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(505, 29);
            this.SearchTextBox.TabIndex = 4;
            this.SearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(542, 88);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 44);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // c1FlexGrid
            // 
            this.c1FlexGrid.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.c1FlexGrid.AllowEditing = false;
            this.c1FlexGrid.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None;
            this.c1FlexGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.c1FlexGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.c1FlexGrid.ColumnInfo = resources.GetString("c1FlexGrid.ColumnInfo");
            this.c1FlexGrid.ExtendLastCol = true;
            this.c1FlexGrid.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.c1FlexGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.c1FlexGrid.Location = new System.Drawing.Point(20, 152);
            this.c1FlexGrid.Margin = new System.Windows.Forms.Padding(4);
            this.c1FlexGrid.Name = "c1FlexGrid";
            this.c1FlexGrid.Rows.DefaultSize = 26;
            this.c1FlexGrid.Rows.MinSize = 30;
            this.c1FlexGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.c1FlexGrid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox;
            this.c1FlexGrid.ShowCursor = true;
            this.c1FlexGrid.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Both;
            this.c1FlexGrid.Size = new System.Drawing.Size(505, 274);
            this.c1FlexGrid.StyleInfo = resources.GetString("c1FlexGrid.StyleInfo");
            this.c1FlexGrid.TabIndex = 11;
            this.c1FlexGrid.Visible = false;
     //       this.c1FlexGrid.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(this.c1FlexGrid_OwnerDrawCell);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Company Name:";
            // 
            // AddStockPortfolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.c1FlexGrid);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.AddStockPortfolioButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddStockPortfolio";
            this.Size = new System.Drawing.Size(725, 718);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddStockPortfolioButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button btnSearch;
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid;
        private System.Windows.Forms.Label label1;
    }
}
