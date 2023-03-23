namespace Tutorial1
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
            C1.Win.C1DynamicHelp.MapItem mapItem1 = new C1.Win.C1DynamicHelp.MapItem();
            C1.Win.C1DynamicHelp.MapItem mapItem2 = new C1.Win.C1DynamicHelp.MapItem();
            C1.Win.C1DynamicHelp.MapItem mapItem3 = new C1.Win.C1DynamicHelp.MapItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.c1DynamicHelp1 = new C1.Win.C1DynamicHelp.C1DynamicHelp();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            mapItem1.HelpTopicTrigger = C1.Win.C1DynamicHelp.HelpTopicTrigger.Enter;
            mapItem1.ItemType = C1.Win.C1DynamicHelp.MapItemType.Static;
            mapItem1.ShowDefaultTopicFirst = true;
            mapItem1.UIElement = this.textBox1;
            mapItem1.Url = "WordDocuments/designtimesupport.htm";
            mapItem1.UseDefaultTrigger = false;
            this.c1DynamicHelp1.SetHelpTopic(this.textBox1, mapItem1);
            this.textBox1.Location = new System.Drawing.Point(4, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Show topic on focus";
            // 
            // button1
            // 
            mapItem2.HelpTopicTrigger = C1.Win.C1DynamicHelp.HelpTopicTrigger.MouseEnter;
            mapItem2.ItemType = C1.Win.C1DynamicHelp.MapItemType.Static;
            mapItem2.ShowDefaultTopicFirst = true;
            mapItem2.UIElement = this.button1;
            mapItem2.Url = "WordDocuments/runtimesupport.htm";
            mapItem2.UseDefaultTrigger = true;
            this.c1DynamicHelp1.SetHelpTopic(this.button1, mapItem2);
            this.button1.Location = new System.Drawing.Point(4, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show topic on mouse hover";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(4, 105);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(160, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Show topic programmatically";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // c1DynamicHelp1
            // 
            this.c1DynamicHelp1.HelpSource = "C1Sample.chm";
            this.c1DynamicHelp1.Location = new System.Drawing.Point(165, 0);
            this.c1DynamicHelp1.Name = "c1DynamicHelp1";
            this.c1DynamicHelp1.Size = new System.Drawing.Size(262, 268);
            this.c1DynamicHelp1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 268);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.c1DynamicHelp1);
            mapItem3.HelpTopicTrigger = C1.Win.C1DynamicHelp.HelpTopicTrigger.None;
            mapItem3.ItemType = C1.Win.C1DynamicHelp.MapItemType.Static;
            mapItem3.ShowDefaultTopicFirst = true;
            mapItem3.UIElement = this;
            mapItem3.Url = "WordDocuments/overview.htm";
            mapItem3.UseDefaultTrigger = true;
            this.c1DynamicHelp1.SetHelpTopic(this, mapItem3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1DynamicHelp.C1DynamicHelp c1DynamicHelp1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

