using InputExplorer.Samples.DropDowns;

namespace InputExplorer.Samples

{
    public partial class CustomDropDowns
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
            components = new System.ComponentModel.Container();
            ddCreditCards = new C1.Win.Input.C1DropDownControl();
            ddCheckedListBox = new C1.Win.Input.C1DropDownControl();
            ddTabbedLists = new C1.Win.Input.C1DropDownControl();
            c1DropDownControl1 = new C1.Win.Input.C1DropDownControl();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            categoriesBindingSource = new System.Windows.Forms.BindingSource(components);
            c1DemoDataSet = new C1DemoDataSet();
            categoriesTableAdapter = new InputExplorer.C1DemoDataSetTableAdapters.CategoriesTableAdapter();
            c1DropDownControl2 = new C1.Win.Input.C1DropDownControl();
            label5 = new System.Windows.Forms.Label();
            c1Magnify1 = new C1.Win.TouchToolKit.C1Magnify();
            ((System.ComponentModel.ISupportInitialize)ddCreditCards).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddCheckedListBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddTabbedLists).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1DropDownControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1DemoDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1DropDownControl2).BeginInit();
            SuspendLayout();
            // 
            // ddCreditCards
            // 
            ddCreditCards.DropDownStyle = C1.Win.Input.DropDownStyle.DropDownList;
            ddCreditCards.InitialSelection = C1.Win.Input.InitialSelection.CaretAtStart;
            ddCreditCards.Location = new System.Drawing.Point(211, 29);
            ddCreditCards.Name = "ddCreditCards";
            ddCreditCards.ReadOnly = true;
            ddCreditCards.Size = new System.Drawing.Size(336, 23);
            ddCreditCards.TabIndex = 12;
            // 
            // ddCheckedListBox
            // 
            ddCheckedListBox.DropDownStyle = C1.Win.Input.DropDownStyle.DropDownList;
            ddCheckedListBox.InitialSelection = C1.Win.Input.InitialSelection.CaretAtStart;
            ddCheckedListBox.Location = new System.Drawing.Point(211, 77);
            ddCheckedListBox.Name = "ddCheckedListBox";
            ddCheckedListBox.ReadOnly = true;
            ddCheckedListBox.Size = new System.Drawing.Size(336, 23);
            ddCheckedListBox.TabIndex = 1;
            // 
            // ddTabbedLists
            // 
            ddTabbedLists.DropDownStyle = C1.Win.Input.DropDownStyle.DropDownList;
            ddTabbedLists.InitialSelection = C1.Win.Input.InitialSelection.CaretAtStart;
            ddTabbedLists.Location = new System.Drawing.Point(213, 124);
            ddTabbedLists.Name = "ddTabbedLists";
            ddTabbedLists.ReadOnly = true;
            ddTabbedLists.Size = new System.Drawing.Size(334, 23);
            ddTabbedLists.TabIndex = 2;
            // 
            // c1DropDownControl1
            // 
            c1DropDownControl1.DropDownStyle = C1.Win.Input.DropDownStyle.DropDownList;
            c1DropDownControl1.InitialSelection = C1.Win.Input.InitialSelection.CaretAtStart;
            c1DropDownControl1.Location = new System.Drawing.Point(211, 169);
            c1DropDownControl1.Name = "c1DropDownControl1";
            c1DropDownControl1.ReadOnly = true;
            c1DropDownControl1.Size = new System.Drawing.Size(336, 23);
            c1DropDownControl1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(35, 34);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(70, 15);
            label1.TabIndex = 4;
            label1.Text = "Credit Card:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(35, 79);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(106, 15);
            label2.TabIndex = 5;
            label2.Text = "Insurance Options:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(35, 126);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(129, 15);
            label3.TabIndex = 6;
            label3.Text = "State/Region/Province:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(35, 172);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(53, 15);
            label4.TabIndex = 7;
            label4.Text = "Country:";
            // 
            // categoriesBindingSource
            // 
            categoriesBindingSource.DataMember = "Categories";
            categoriesBindingSource.DataSource = c1DemoDataSet;
            // 
            // c1DemoDataSet
            // 
            c1DemoDataSet.DataSetName = "C1DemoDataSet";
            c1DemoDataSet.Namespace = "http://tempuri.org/C1DemoDataSet.xsd";
            c1DemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesTableAdapter
            // 
            categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // c1DropDownControl2
            // 
            c1DropDownControl2.DropDownStyle = C1.Win.Input.DropDownStyle.DropDownList;
            c1DropDownControl2.ErrorInfo.CanLoseFocus = true;
            c1DropDownControl2.InitialSelection = C1.Win.Input.InitialSelection.CaretAtStart;
            c1DropDownControl2.Location = new System.Drawing.Point(211, 216);
            c1DropDownControl2.Name = "c1DropDownControl2";
            c1DropDownControl2.ReadOnly = true;
            c1DropDownControl2.Size = new System.Drawing.Size(336, 23);
            c1DropDownControl2.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(35, 218);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(58, 15);
            label5.TabIndex = 11;
            label5.Text = "Category:";
            // 
            // c1Magnify1
            // 
            c1Magnify1.Size = new System.Drawing.Size(200, 200);
            c1Magnify1.ZoomFactor = 2.5F;
            // 
            // CustomDropDowns
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.White;
            Controls.Add(ddCreditCards);
            Controls.Add(label5);
            Controls.Add(c1DropDownControl2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(c1DropDownControl1);
            Controls.Add(ddTabbedLists);
            Controls.Add(label3);
            Controls.Add(ddCheckedListBox);
            Controls.Add(label2);
            c1Magnify1.SetEnableMagnifier(this, true);
            Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            Name = "CustomDropDowns";
            Size = new System.Drawing.Size(1009, 510);
            Load += CustomDropDowns_Load;
            ((System.ComponentModel.ISupportInitialize)ddCreditCards).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddCheckedListBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddTabbedLists).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1DropDownControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1DemoDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1DropDownControl2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private C1.Win.Input.C1DropDownControl ddCheckedListBox;
        private C1.Win.Input.C1DropDownControl ddTabbedLists;
        private C1.Win.Input.C1DropDownControl c1DropDownControl1;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        internal C1DemoDataSet c1DemoDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private InputExplorer.C1DemoDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private C1.Win.Input.C1DropDownControl c1DropDownControl2;
        private System.Windows.Forms.Label label5;
        private C1.Win.TouchToolKit.C1Magnify c1Magnify1;
        private C1.Win.Input.C1DropDownControl ddCreditCards;
    }
}