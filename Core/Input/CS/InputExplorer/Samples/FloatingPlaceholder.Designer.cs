namespace InputExplorer.Samples
{
    partial class FloatingPlaceholder
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
            C1.Win.Input.ComboBoxItem comboBoxItem1 = new C1.Win.Input.ComboBoxItem();
            C1.Win.Input.ComboBoxItem comboBoxItem2 = new C1.Win.Input.ComboBoxItem();
            C1.Win.Input.ComboBoxItem comboBoxItem3 = new C1.Win.Input.ComboBoxItem();
            C1.Win.Input.ComboBoxItem comboBoxItem4 = new C1.Win.Input.ComboBoxItem();
            C1.Win.Input.ComboBoxItem comboBoxItem5 = new C1.Win.Input.ComboBoxItem();
            C1.Win.Input.ComboBoxItem comboBoxItem6 = new C1.Win.Input.ComboBoxItem();
            C1.Win.Input.ComboBoxItem comboBoxItem7 = new C1.Win.Input.ComboBoxItem();
            C1.Win.Input.ComboBoxItem comboBoxItem8 = new C1.Win.Input.ComboBoxItem();
            C1.Win.Input.ComboBoxItem comboBoxItem9 = new C1.Win.Input.ComboBoxItem();
            c1TextBox1 = new C1.Win.Input.C1TextBox();
            c1MaskedTextBox1 = new C1.Win.Input.C1MaskedTextBox();
            c1ComboBox1 = new C1.Win.Input.C1ComboBox();
            c1NumericEdit1 = new C1.Win.Input.C1NumericEdit();
            c1DateEdit1 = new C1.Win.Calendar.C1DateEdit();
            c1TextBox2 = new C1.Win.Input.C1TextBox();
            ((System.ComponentModel.ISupportInitialize)c1TextBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1MaskedTextBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1ComboBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1NumericEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1DateEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1TextBox2).BeginInit();
            SuspendLayout();
            // 
            // c1TextBox1
            // 
            c1TextBox1.AutoSize = false;
            c1TextBox1.FloatingPlaceholderEnabled = true;
            c1TextBox1.Icon = new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, Properties.Resources.User);
            c1TextBox1.Location = new System.Drawing.Point(370, 19);
            c1TextBox1.Name = "c1TextBox1";
            c1TextBox1.Placeholder = "Login";
            c1TextBox1.Size = new System.Drawing.Size(290, 55);
            c1TextBox1.TabIndex = 0;
            c1TextBox1.Value = "";
            // 
            // c1MaskedTextBox1
            // 
            c1MaskedTextBox1.AutoSize = false;
            c1MaskedTextBox1.EditMask = "+0-(000)-000-0000";
            c1MaskedTextBox1.FloatingPlaceholderEnabled = true;
            c1MaskedTextBox1.Location = new System.Drawing.Point(28, 116);
            c1MaskedTextBox1.Name = "c1MaskedTextBox1";
            c1MaskedTextBox1.Placeholder = "Phone number";
            c1MaskedTextBox1.Size = new System.Drawing.Size(290, 55);
            c1MaskedTextBox1.TabIndex = 1;
            c1MaskedTextBox1.Value = "";
            // 
            // c1ComboBox1
            // 
            c1ComboBox1.AutoSize = false;
            c1ComboBox1.FloatingPlaceholderEnabled = true;
            comboBoxItem1.DisplayText = "USA";
            comboBoxItem1.Value = "USA";
            comboBoxItem2.DisplayText = "Austria";
            comboBoxItem2.Value = "Austria";
            comboBoxItem3.DisplayText = "Vietnam";
            comboBoxItem3.Value = "Vietnam";
            comboBoxItem4.DisplayText = "Canada";
            comboBoxItem4.Value = "Canada";
            comboBoxItem5.DisplayText = "Argentina";
            comboBoxItem5.Value = "Argentina";
            comboBoxItem6.DisplayText = "Spain";
            comboBoxItem6.Value = "Spain";
            comboBoxItem7.DisplayText = "France";
            comboBoxItem7.Value = "France";
            comboBoxItem8.DisplayText = "Germany";
            comboBoxItem8.Value = "Germany";
            comboBoxItem9.DisplayText = "Greece";
            comboBoxItem9.Value = "Greece";
            c1ComboBox1.Items.Add(comboBoxItem1);
            c1ComboBox1.Items.Add(comboBoxItem2);
            c1ComboBox1.Items.Add(comboBoxItem3);
            c1ComboBox1.Items.Add(comboBoxItem4);
            c1ComboBox1.Items.Add(comboBoxItem5);
            c1ComboBox1.Items.Add(comboBoxItem6);
            c1ComboBox1.Items.Add(comboBoxItem7);
            c1ComboBox1.Items.Add(comboBoxItem8);
            c1ComboBox1.Items.Add(comboBoxItem9);
            c1ComboBox1.Location = new System.Drawing.Point(370, 116);
            c1ComboBox1.Name = "c1ComboBox1";
            c1ComboBox1.Placeholder = "Country";
            c1ComboBox1.Size = new System.Drawing.Size(290, 55);
            c1ComboBox1.TabIndex = 2;
            // 
            // c1NumericEdit1
            // 
            c1NumericEdit1.AutoSize = false;
            c1NumericEdit1.EmptyAsNull = true;
            c1NumericEdit1.FloatingPlaceholderEnabled = true;
            c1NumericEdit1.Location = new System.Drawing.Point(28, 19);
            c1NumericEdit1.Name = "c1NumericEdit1";
            c1NumericEdit1.Placeholder = "ID";
            c1NumericEdit1.Size = new System.Drawing.Size(290, 55);
            c1NumericEdit1.TabIndex = 3;
            c1NumericEdit1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // c1DateEdit1
            // 
            c1DateEdit1.AutoSize = false;
            c1DateEdit1.FloatingPlaceholderEnabled = true;
            c1DateEdit1.Icon = new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, Properties.Resources.Date);
            c1DateEdit1.Location = new System.Drawing.Point(28, 213);
            c1DateEdit1.Name = "c1DateEdit1";
            c1DateEdit1.Placeholder = "Birthday";
            c1DateEdit1.Size = new System.Drawing.Size(290, 55);
            c1DateEdit1.TabIndex = 4;
            // 
            // c1TextBox2
            // 
            c1TextBox2.AutoSize = false;
            c1TextBox2.FloatingPlaceholderEnabled = true;
            c1TextBox2.Icon = new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, Properties.Resources.Security);
            c1TextBox2.Location = new System.Drawing.Point(370, 213);
            c1TextBox2.Name = "c1TextBox2";
            c1TextBox2.PasswordChar = '●';
            c1TextBox2.Placeholder = "Password";
            c1TextBox2.Size = new System.Drawing.Size(290, 55);
            c1TextBox2.TabIndex = 5;
            c1TextBox2.UseSystemPasswordChar = true;
            c1TextBox2.Value = "";
            // 
            // FloatingPlaceholder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(c1TextBox2);
            Controls.Add(c1DateEdit1);
            Controls.Add(c1NumericEdit1);
            Controls.Add(c1ComboBox1);
            Controls.Add(c1MaskedTextBox1);
            Controls.Add(c1TextBox1);
            Name = "FloatingPlaceholder";
            Size = new System.Drawing.Size(780, 805);
            ((System.ComponentModel.ISupportInitialize)c1TextBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1MaskedTextBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1ComboBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1NumericEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1DateEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1TextBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private C1.Win.Input.C1TextBox c1TextBox1;
        private C1.Win.Input.C1MaskedTextBox c1MaskedTextBox1;
        private C1.Win.Input.C1ComboBox c1ComboBox1;
        private C1.Win.Input.C1NumericEdit c1NumericEdit1;
        private C1.Win.Calendar.C1DateEdit c1DateEdit1;
        private C1.Win.Input.C1TextBox c1TextBox2;
    }
}
