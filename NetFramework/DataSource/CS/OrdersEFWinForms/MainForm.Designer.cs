namespace OrdersEFWinForms
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.linkLabelEditOrders = new System.Windows.Forms.LinkLabel();
            this.linkLabelOrdersCountry = new System.Windows.Forms.LinkLabel();
            this.linkLabelProducts = new System.Windows.Forms.LinkLabel();
            this.linkLabelCancelChanges = new System.Windows.Forms.LinkLabel();
            this.linkLabelAllOrders = new System.Windows.Forms.LinkLabel();
            this.linkLabelSaveChanges = new System.Windows.Forms.LinkLabel();
            this.c1DataSource1 = new C1.Win.Data.Entities.C1DataSource();
            ((System.ComponentModel.ISupportInitialize)(this.c1DataSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Location = new System.Drawing.Point(173, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(672, 535);
            this.tabControl1.TabIndex = 7;
            // 
            // linkLabelEditOrders
            // 
            this.linkLabelEditOrders.AutoSize = true;
            this.linkLabelEditOrders.Location = new System.Drawing.Point(22, 18);
            this.linkLabelEditOrders.Name = "linkLabelEditOrders";
            this.linkLabelEditOrders.Size = new System.Drawing.Size(59, 13);
            this.linkLabelEditOrders.TabIndex = 1;
            this.linkLabelEditOrders.TabStop = true;
            this.linkLabelEditOrders.Text = "Edit Orders";
            this.linkLabelEditOrders.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEditOrders_LinkClicked);
            // 
            // linkLabelOrdersCountry
            // 
            this.linkLabelOrdersCountry.AutoSize = true;
            this.linkLabelOrdersCountry.Location = new System.Drawing.Point(22, 48);
            this.linkLabelOrdersCountry.Name = "linkLabelOrdersCountry";
            this.linkLabelOrdersCountry.Size = new System.Drawing.Size(91, 13);
            this.linkLabelOrdersCountry.TabIndex = 2;
            this.linkLabelOrdersCountry.TabStop = true;
            this.linkLabelOrdersCountry.Text = "Orders by Country";
            this.linkLabelOrdersCountry.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelOrdersCountry_LinkClicked);
            // 
            // linkLabelProducts
            // 
            this.linkLabelProducts.AutoSize = true;
            this.linkLabelProducts.Location = new System.Drawing.Point(22, 108);
            this.linkLabelProducts.Name = "linkLabelProducts";
            this.linkLabelProducts.Size = new System.Drawing.Size(49, 13);
            this.linkLabelProducts.TabIndex = 4;
            this.linkLabelProducts.TabStop = true;
            this.linkLabelProducts.Text = "Products";
            this.linkLabelProducts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelProducts_LinkClicked);
            // 
            // linkLabelCancelChanges
            // 
            this.linkLabelCancelChanges.AutoSize = true;
            this.linkLabelCancelChanges.Location = new System.Drawing.Point(22, 168);
            this.linkLabelCancelChanges.Name = "linkLabelCancelChanges";
            this.linkLabelCancelChanges.Size = new System.Drawing.Size(99, 13);
            this.linkLabelCancelChanges.TabIndex = 6;
            this.linkLabelCancelChanges.TabStop = true;
            this.linkLabelCancelChanges.Text = "Cancel All Changes";
            this.linkLabelCancelChanges.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCancelChanges_LinkClicked);
            // 
            // linkLabelAllOrders
            // 
            this.linkLabelAllOrders.AutoSize = true;
            this.linkLabelAllOrders.Location = new System.Drawing.Point(22, 78);
            this.linkLabelAllOrders.Name = "linkLabelAllOrders";
            this.linkLabelAllOrders.Size = new System.Drawing.Size(52, 13);
            this.linkLabelAllOrders.TabIndex = 3;
            this.linkLabelAllOrders.TabStop = true;
            this.linkLabelAllOrders.Text = "All Orders";
            this.linkLabelAllOrders.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAllOrders_LinkClicked);
            // 
            // linkLabelSaveChanges
            // 
            this.linkLabelSaveChanges.AutoSize = true;
            this.linkLabelSaveChanges.Location = new System.Drawing.Point(22, 138);
            this.linkLabelSaveChanges.Name = "linkLabelSaveChanges";
            this.linkLabelSaveChanges.Size = new System.Drawing.Size(77, 13);
            this.linkLabelSaveChanges.TabIndex = 5;
            this.linkLabelSaveChanges.TabStop = true;
            this.linkLabelSaveChanges.Text = "Save Changes";
            this.linkLabelSaveChanges.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSaveChanges_LinkClicked);
            // 
            // c1DataSource1
            // 
            this.c1DataSource1.ContextType = typeof(OrdersEFWinForms.NORTHWNDEntities);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 534);
            this.Controls.Add(this.linkLabelSaveChanges);
            this.Controls.Add(this.linkLabelAllOrders);
            this.Controls.Add(this.linkLabelCancelChanges);
            this.Controls.Add(this.linkLabelProducts);
            this.Controls.Add(this.linkLabelOrdersCountry);
            this.Controls.Add(this.linkLabelEditOrders);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.c1DataSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.LinkLabel linkLabelEditOrders;
        private System.Windows.Forms.LinkLabel linkLabelOrdersCountry;
        private System.Windows.Forms.LinkLabel linkLabelProducts;
        private System.Windows.Forms.LinkLabel linkLabelCancelChanges;
        private System.Windows.Forms.LinkLabel linkLabelAllOrders;
        private System.Windows.Forms.LinkLabel linkLabelSaveChanges;
        private C1.Win.Data.Entities.C1DataSource c1DataSource1;
    }
}

