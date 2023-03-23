namespace JpnEraDateEdit
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
            this.c1Label1 = new C1.Win.C1Input.C1Label();
            this.c1ComboBox1 = new C1.Win.C1Input.C1ComboBox();
            this.c1DateEdit1 = new C1.Win.C1Input.C1DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Label1
            // 
            this.c1Label1.AutoSize = true;
            this.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label1.Location = new System.Drawing.Point(46, 28);
            this.c1Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(95, 17);
            this.c1Label1.TabIndex = 2;
            this.c1Label1.Tag = null;
            this.c1Label1.Text = "Select format:";
            this.c1Label1.TextDetached = true;
            // 
            // c1ComboBox1
            // 
            this.c1ComboBox1.AllowSpinLoop = false;
            this.c1ComboBox1.GapHeight = 0;
            this.c1ComboBox1.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1ComboBox1.ItemsDisplayMember = "";
            this.c1ComboBox1.ItemsValueMember = "";
            this.c1ComboBox1.Location = new System.Drawing.Point(46, 63);
            this.c1ComboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c1ComboBox1.Name = "c1ComboBox1";
            this.c1ComboBox1.Size = new System.Drawing.Size(452, 20);
            this.c1ComboBox1.TabIndex = 1;
            this.c1ComboBox1.Tag = null;
            this.c1ComboBox1.SelectedItemChanged += new System.EventHandler(this.c1ComboBox1_SelectedItemChanged);
            // 
            // c1DateEdit1
            // 
            this.c1DateEdit1.AllowSpinLoop = false;
            // 
            // 
            // 
            this.c1DateEdit1.Calendar.CurrentCulture = new System.Globalization.CultureInfo("ru-RU");
            this.c1DateEdit1.Calendar.DayNameLength = 1;
            this.c1DateEdit1.Calendar.DayNamesFont = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1DateEdit1.Calendar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1DateEdit1.Calendar.TitleFont = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1DateEdit1.CalendarType = C1.Win.C1Input.CalendarType.HijriCalendar;
            this.c1DateEdit1.Culture = 1076;
            this.c1DateEdit1.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1DateEdit1.Location = new System.Drawing.Point(607, 63);
            this.c1DateEdit1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c1DateEdit1.Name = "c1DateEdit1";
            this.c1DateEdit1.Size = new System.Drawing.Size(286, 20);
            this.c1DateEdit1.TabIndex = 0;
            this.c1DateEdit1.Tag = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 145);
            this.Controls.Add(this.c1Label1);
            this.Controls.Add(this.c1ComboBox1);
            this.Controls.Add(this.c1DateEdit1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Input.C1DateEdit c1DateEdit1;
        private C1.Win.C1Input.C1ComboBox c1ComboBox1;
        private C1.Win.C1Input.C1Label c1Label1;
    }
}

