namespace DataBinding
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
            this.components = new System.ComponentModel.Container();
            this.c1DbNavigator1 = new C1.Win.C1Input.C1DbNavigator();
            this.c1ExpressionEditor1 = new C1.Win.ExpressionEditor.C1ExpressionEditor();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.c1ExpressionEditorPanel1 = new C1.Win.ExpressionEditor.C1ExpressionEditorPanel();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c1NWindDataSet = new DataBinding.C1NWindDataSet();
            this.productsTableAdapter = new DataBinding.C1NWindDataSetTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.c1DbNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ExpressionEditor1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NWindDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // c1DbNavigator1
            // 
            this.c1DbNavigator1.DataSource = this.productsBindingSource;
            this.c1DbNavigator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1DbNavigator1.Location = new System.Drawing.Point(0, 0);
            this.c1DbNavigator1.Name = "c1DbNavigator1";
            this.c1DbNavigator1.Size = new System.Drawing.Size(658, 22);
            this.c1DbNavigator1.TabIndex = 0;
            this.c1DbNavigator1.PositionChanged += new System.EventHandler(this.c1DbNavigator1_PositionChanged);
            // 
            // c1ExpressionEditor1
            // 
            this.c1ExpressionEditor1.DataSource = this.productsBindingSource;
            this.c1ExpressionEditor1.ItemContext = this.productsBindingSource;
            this.c1ExpressionEditor1.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1ExpressionEditor1.Expression = "[UnitPrice] * [UnitsInStock]";
            this.c1ExpressionEditor1.Location = new System.Drawing.Point(0, 22);
            this.c1ExpressionEditor1.Name = "c1ExpressionEditor1";
            this.c1ExpressionEditor1.Size = new System.Drawing.Size(658, 60);
            this.c1ExpressionEditor1.TabIndex = 0;
            this.c1ExpressionEditor1.Text = "c1ExpressionEditor1";
            this.c1ExpressionEditor1.ExpressionChanged += new System.EventHandler(this.c1ExpressionEditor1_ExpressionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 41);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result of the Expression for the current row:";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(652, 20);
            this.textBox1.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 82);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(658, 3);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 336);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(658, 3);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // c1ExpressionEditorPanel1
            // 
            this.c1ExpressionEditorPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1ExpressionEditorPanel1.ExpressionEditor = this.c1ExpressionEditor1;
            this.c1ExpressionEditorPanel1.Location = new System.Drawing.Point(0, 85);
            this.c1ExpressionEditorPanel1.Name = "c1ExpressionEditorPanel1";
            this.c1ExpressionEditorPanel1.Size = new System.Drawing.Size(658, 251);
            this.c1ExpressionEditorPanel1.TabIndex = 5;
            this.c1ExpressionEditorPanel1.Text = "c1ExpressionEditorPanel1";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.c1NWindDataSet;
            // 
            // c1NWindDataSet
            // 
            this.c1NWindDataSet.DataSetName = "C1NWindDataSet";
            this.c1NWindDataSet.Locale = new System.Globalization.CultureInfo("en");
            this.c1NWindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 380);
            this.Controls.Add(this.c1ExpressionEditorPanel1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.c1ExpressionEditor1);
            this.Controls.Add(this.c1DbNavigator1);
            this.Name = "Form1";
            this.Text = "ExpressionEditor data binding sample";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1DbNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ExpressionEditor1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NWindDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Input.C1DbNavigator c1DbNavigator1;
        private C1.Win.ExpressionEditor.C1ExpressionEditor c1ExpressionEditor1;
        private C1NWindDataSet c1NWindDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private C1NWindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private C1.Win.ExpressionEditor.C1ExpressionEditorPanel c1ExpressionEditorPanel1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

