namespace ComboBoxDataBinding
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
            this.c1ComboBox1 = new C1.Win.C1Input.C1ComboBox();
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c1NWindDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c1NWindDataSet = new ComboBoxDataBinding.C1NWindDataSet();
            this.deliveryResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c1DbNavigator1 = new C1.Win.C1Input.C1DbNavigator();
            this.deliveryTableAdapter = new ComboBoxDataBinding.C1NWindDataSetTableAdapters.DeliveryTableAdapter();
            this.deliveryResultsTableAdapter = new ComboBoxDataBinding.C1NWindDataSetTableAdapters.DeliveryResultsTableAdapter();
            this.c1TextBox1 = new C1.Win.C1Input.C1TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NWindDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NWindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryResultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DbNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1ComboBox1
            // 
            this.c1ComboBox1.AllowSpinLoop = false;
            this.c1ComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.deliveryBindingSource, "Result", true));
            this.c1ComboBox1.GapHeight = 0;
            this.c1ComboBox1.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1ComboBox1.ItemsDataSource = this.deliveryResultsBindingSource;
            this.c1ComboBox1.ItemsDisplayMember = "Result";
            this.c1ComboBox1.ItemsValueMember = "Result";
            this.c1ComboBox1.Location = new System.Drawing.Point(16, 121);
            this.c1ComboBox1.Name = "c1ComboBox1";
            this.c1ComboBox1.Size = new System.Drawing.Size(316, 18);
            this.c1ComboBox1.TabIndex = 0;
            this.c1ComboBox1.Tag = null;
            // 
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataMember = "Delivery";
            this.deliveryBindingSource.DataSource = this.c1NWindDataSetBindingSource;
            // 
            // c1NWindDataSetBindingSource
            // 
            this.c1NWindDataSetBindingSource.DataSource = this.c1NWindDataSet;
            this.c1NWindDataSetBindingSource.Position = 0;
            // 
            // c1NWindDataSet
            // 
            this.c1NWindDataSet.DataSetName = "C1NWindDataSet";
            this.c1NWindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deliveryResultsBindingSource
            // 
            this.deliveryResultsBindingSource.DataMember = "DeliveryResults";
            this.deliveryResultsBindingSource.DataSource = this.c1NWindDataSetBindingSource;
            // 
            // c1DbNavigator1
            // 
            this.c1DbNavigator1.DataSource = this.deliveryBindingSource;
            this.c1DbNavigator1.Location = new System.Drawing.Point(93, 12);
            this.c1DbNavigator1.Name = "c1DbNavigator1";
            this.c1DbNavigator1.Size = new System.Drawing.Size(239, 22);
            this.c1DbNavigator1.TabIndex = 1;
            // 
            // deliveryTableAdapter
            // 
            this.deliveryTableAdapter.ClearBeforeFill = true;
            // 
            // deliveryResultsTableAdapter
            // 
            this.deliveryResultsTableAdapter.ClearBeforeFill = true;
            // 
            // c1TextBox1
            // 
            this.c1TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.deliveryBindingSource, "Address", true));
            this.c1TextBox1.Location = new System.Drawing.Point(16, 73);
            this.c1TextBox1.Name = "c1TextBox1";
            this.c1TextBox1.ReadOnly = true;
            this.c1TextBox1.Size = new System.Drawing.Size(316, 18);
            this.c1TextBox1.TabIndex = 2;
            this.c1TextBox1.Tag = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 166);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c1TextBox1);
            this.Controls.Add(this.c1DbNavigator1);
            this.Controls.Add(this.c1ComboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery card";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NWindDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NWindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryResultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DbNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Input.C1ComboBox c1ComboBox1;
        private C1NWindDataSet c1NWindDataSet;
        private C1.Win.C1Input.C1DbNavigator c1DbNavigator1;
        private System.Windows.Forms.BindingSource c1NWindDataSetBindingSource;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private C1NWindDataSetTableAdapters.DeliveryTableAdapter deliveryTableAdapter;
        private System.Windows.Forms.BindingSource deliveryResultsBindingSource;
        private C1NWindDataSetTableAdapters.DeliveryResultsTableAdapter deliveryResultsTableAdapter;
        private C1.Win.C1Input.C1TextBox c1TextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

