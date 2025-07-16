namespace RenamingTabs
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.c1DockingTab1 = new C1.Win.Command.C1DockingTab();
            this.c1DockingTabPage1 = new C1.Win.Command.C1DockingTabPage();
            this.c1DockingTabPage3 = new C1.Win.Command.C1DockingTabPage();
            this.c1DockingTabPage4 = new C1.Win.Command.C1DockingTabPage();
            this.c1CommandDock1 = new C1.Win.Command.C1CommandDock();
            this.c1DockingTab2 = new C1.Win.Command.C1DockingTab();
            this.c1DockingTabPage2 = new C1.Win.Command.C1DockingTabPage();
            this.c1DockingTabPage6 = new C1.Win.Command.C1DockingTabPage();
            this.c1DockingTabPage5 = new C1.Win.Command.C1DockingTabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
            this.c1DockingTab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).BeginInit();
            this.c1CommandDock1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab2)).BeginInit();
            this.c1DockingTab2.SuspendLayout();
            this.c1DockingTabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.c1DockingTab1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 261);
            this.panel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(12, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Can rename tabs";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox2_Click);
            // 
            // c1DockingTab1
            // 
            this.c1DockingTab1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.c1DockingTab1.Controls.Add(this.c1DockingTabPage1);
            this.c1DockingTab1.Controls.Add(this.c1DockingTabPage3);
            this.c1DockingTab1.Controls.Add(this.c1DockingTabPage4);
            this.c1DockingTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DockingTab1.Location = new System.Drawing.Point(0, 0);
            this.c1DockingTab1.Name = "c1DockingTab1";
            this.c1DockingTab1.Size = new System.Drawing.Size(865, 261);
            this.c1DockingTab1.TabIndex = 0;
            this.c1DockingTab1.TabStyle = C1.Win.Command.TabStyleEnum.Office2010;
            this.c1DockingTab1.VisualStyle = C1.Win.Command.VisualStyle.Office2010Blue;
            this.c1DockingTab1.VisualStyleBase = C1.Win.Command.VisualStyle.Office2010Blue;
            // 
            // c1DockingTabPage1
            // 
            this.c1DockingTabPage1.Location = new System.Drawing.Point(1, 1);
            this.c1DockingTabPage1.Name = "c1DockingTabPage1";
            this.c1DockingTabPage1.Size = new System.Drawing.Size(863, 236);
            this.c1DockingTabPage1.TabIndex = 0;
            this.c1DockingTabPage1.Text = "Options";
            // 
            // c1DockingTabPage3
            // 
            this.c1DockingTabPage3.Location = new System.Drawing.Point(1, 1);
            this.c1DockingTabPage3.Name = "c1DockingTabPage3";
            this.c1DockingTabPage3.Size = new System.Drawing.Size(863, 236);
            this.c1DockingTabPage3.TabIndex = 1;
            this.c1DockingTabPage3.Text = "Page3";
            // 
            // c1DockingTabPage4
            // 
            this.c1DockingTabPage4.Location = new System.Drawing.Point(1, 1);
            this.c1DockingTabPage4.Name = "c1DockingTabPage4";
            this.c1DockingTabPage4.Size = new System.Drawing.Size(863, 236);
            this.c1DockingTabPage4.TabIndex = 2;
            this.c1DockingTabPage4.Text = "Page4";
            // 
            // c1CommandDock1
            // 
            this.c1CommandDock1.Controls.Add(this.c1DockingTab2);
            this.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left;
            this.c1CommandDock1.Id = 3;
            this.c1CommandDock1.Location = new System.Drawing.Point(0, 0);
            this.c1CommandDock1.Name = "c1CommandDock1";
            this.c1CommandDock1.Size = new System.Drawing.Size(332, 205);
            // 
            // c1DockingTab2
            // 
            this.c1DockingTab2.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.c1DockingTab2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1DockingTab2.CanAutoHide = true;
            this.c1DockingTab2.CanCloseTabs = true;
            this.c1DockingTab2.CanMoveTabs = true;
            this.c1DockingTab2.Controls.Add(this.c1DockingTabPage2);
            this.c1DockingTab2.Controls.Add(this.c1DockingTabPage6);
            this.c1DockingTab2.Controls.Add(this.c1DockingTabPage5);
            this.c1DockingTab2.Location = new System.Drawing.Point(0, 0);
            this.c1DockingTab2.Name = "c1DockingTab2";
            this.c1DockingTab2.SelectedIndex = 1;
            this.c1DockingTab2.ShowCaption = true;
            this.c1DockingTab2.Size = new System.Drawing.Size(332, 205);
            this.c1DockingTab2.TabIndex = 0;
            this.c1DockingTab2.TabSizeMode = C1.Win.Command.TabSizeModeEnum.User;
            this.c1DockingTab2.TabStyle = C1.Win.Command.TabStyleEnum.Office2010;
            this.c1DockingTab2.VisualStyle = C1.Win.Command.VisualStyle.Office2010Blue;
            this.c1DockingTab2.VisualStyleBase = C1.Win.Command.VisualStyle.Office2010Blue;
            // 
            // c1DockingTabPage2
            // 
            this.c1DockingTabPage2.CaptionVisible = true;
            this.c1DockingTabPage2.Location = new System.Drawing.Point(24, 0);
            this.c1DockingTabPage2.Name = "c1DockingTabPage2";
            this.c1DockingTabPage2.Size = new System.Drawing.Size(305, 205);
            this.c1DockingTabPage2.TabIndex = 0;
            this.c1DockingTabPage2.Text = "Page2";
            // 
            // c1DockingTabPage6
            // 
            this.c1DockingTabPage6.CaptionVisible = true;
            this.c1DockingTabPage6.Location = new System.Drawing.Point(24, 0);
            this.c1DockingTabPage6.Name = "c1DockingTabPage6";
            this.c1DockingTabPage6.Size = new System.Drawing.Size(305, 205);
            this.c1DockingTabPage6.TabIndex = 2;
            this.c1DockingTabPage6.Text = "Options ";
            // 
            // c1DockingTabPage5
            // 
            this.c1DockingTabPage5.CaptionVisible = true;
            this.c1DockingTabPage5.Controls.Add(this.textBox1);
            this.c1DockingTabPage5.Location = new System.Drawing.Point(24, 0);
            this.c1DockingTabPage5.Name = "c1DockingTabPage5";
            this.c1DockingTabPage5.Size = new System.Drawing.Size(305, 205);
            this.c1DockingTabPage5.TabIndex = 1;
            this.c1DockingTabPage5.Text = "Page5";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(29, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 0;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(35, 29);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(106, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Can rename tabs";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.checkBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 466);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.c1CommandDock1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
            this.c1DockingTab1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).EndInit();
            this.c1CommandDock1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab2)).EndInit();
            this.c1DockingTab2.ResumeLayout(false);
            this.c1DockingTabPage5.ResumeLayout(false);
            this.c1DockingTabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private C1.Win.Command.C1DockingTab c1DockingTab1;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage1;
        private C1.Win.Command.C1CommandDock c1CommandDock1;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage3;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage4;
        private C1.Win.Command.C1DockingTab c1DockingTab2;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage2;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage5;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

