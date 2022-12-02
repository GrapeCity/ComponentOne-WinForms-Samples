
namespace MultiSelectExplorer.Samples
{
    partial class Overview
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
            C1.Win.TreeView.C1CheckListItem c1CheckListItem1 = new C1.Win.TreeView.C1CheckListItem();
            C1.Win.TreeView.C1CheckListItem c1CheckListItem2 = new C1.Win.TreeView.C1CheckListItem();
            C1.Win.TreeView.C1CheckListItem c1CheckListItem3 = new C1.Win.TreeView.C1CheckListItem();
            C1.Win.TreeView.C1CheckListItem c1CheckListItem4 = new C1.Win.TreeView.C1CheckListItem();
            C1.Win.TreeView.C1CheckListItem c1CheckListItem5 = new C1.Win.TreeView.C1CheckListItem();
            C1.Win.TreeView.C1CheckListItem c1CheckListItem6 = new C1.Win.TreeView.C1CheckListItem();
            C1.Win.TreeView.C1CheckListItem c1CheckListItem7 = new C1.Win.TreeView.C1CheckListItem();
            C1.Win.TreeView.C1CheckListItem c1CheckListItem8 = new C1.Win.TreeView.C1CheckListItem();
            C1.Win.TreeView.C1CheckListItem c1CheckListItem9 = new C1.Win.TreeView.C1CheckListItem();
            C1.Win.TreeView.C1CheckListItem c1CheckListItem10 = new C1.Win.TreeView.C1CheckListItem();
            C1.Win.TreeView.C1CheckListItem c1CheckListItem11 = new C1.Win.TreeView.C1CheckListItem();
            C1.Win.TreeView.C1CheckListItem c1CheckListItem12 = new C1.Win.TreeView.C1CheckListItem();
            this.c1MultiSelect1 = new C1.Win.Input.C1MultiSelect();
            this.c1TagEditor1 = new C1.Win.Input.C1TagEditor();
            this.c1MultiSelect2 = new C1.Win.Input.C1MultiSelect();
            this.c1MultiSelect3 = new C1.Win.Input.C1MultiSelect();
            this.c1TagEditor2 = new C1.Win.Input.C1TagEditor();
            this.SuspendLayout();
            // 
            // c1MultiSelect1
            // 
            c1CheckListItem1.Value = "Apple";
            c1CheckListItem2.Value = "Pear";
            c1CheckListItem3.Value = "Pineapple";
            c1CheckListItem4.Value = "Watermelon";
            this.c1MultiSelect1.Items.Add(c1CheckListItem1);
            this.c1MultiSelect1.Items.Add(c1CheckListItem2);
            this.c1MultiSelect1.Items.Add(c1CheckListItem3);
            this.c1MultiSelect1.Items.Add(c1CheckListItem4);
            this.c1MultiSelect1.Location = new System.Drawing.Point(25, 20);
            this.c1MultiSelect1.Name = "c1MultiSelect1";
            this.c1MultiSelect1.Placeholder = "Multiple selection mode";
            this.c1MultiSelect1.Size = new System.Drawing.Size(271, 37);
            this.c1MultiSelect1.TabIndex = 0;
            // 
            // c1TagEditor1
            // 
            this.c1TagEditor1.BackColor = System.Drawing.SystemColors.Window;
            this.c1TagEditor1.Location = new System.Drawing.Point(309, 20);
            this.c1TagEditor1.Name = "c1TagEditor1";
            this.c1TagEditor1.Size = new System.Drawing.Size(301, 37);
            this.c1TagEditor1.TabIndex = 1;
            this.c1TagEditor1.Text = "Apple,Pear,Pineapple,Watermelon,";
            // 
            // c1MultiSelect2
            // 
            c1CheckListItem5.Value = "Apple";
            c1CheckListItem6.Value = "Pear";
            c1CheckListItem7.Value = "Pineapple";
            c1CheckListItem8.Value = "Watermelon";
            this.c1MultiSelect2.Items.Add(c1CheckListItem5);
            this.c1MultiSelect2.Items.Add(c1CheckListItem6);
            this.c1MultiSelect2.Items.Add(c1CheckListItem7);
            this.c1MultiSelect2.Items.Add(c1CheckListItem8);
            this.c1MultiSelect2.Location = new System.Drawing.Point(25, 77);
            this.c1MultiSelect2.Name = "c1MultiSelect2";
            this.c1MultiSelect2.Placeholder = "Single selection mode";
            this.c1MultiSelect2.SelectionMode = C1.Win.TreeView.SelectionMode.Single;
            this.c1MultiSelect2.Size = new System.Drawing.Size(271, 37);
            this.c1MultiSelect2.TabIndex = 2;
            // 
            // c1MultiSelect3
            // 
            c1CheckListItem9.Value = "Apple";
            c1CheckListItem10.Value = "Pear";
            c1CheckListItem11.Value = "Pineapple";
            c1CheckListItem12.Value = "Watermelon";
            this.c1MultiSelect3.Items.Add(c1CheckListItem9);
            this.c1MultiSelect3.Items.Add(c1CheckListItem10);
            this.c1MultiSelect3.Items.Add(c1CheckListItem11);
            this.c1MultiSelect3.Items.Add(c1CheckListItem12);
            this.c1MultiSelect3.Location = new System.Drawing.Point(25, 135);
            this.c1MultiSelect3.Name = "c1MultiSelect3";
            this.c1MultiSelect3.Placeholder = "Radio selection mode";
            this.c1MultiSelect3.SelectionMode = C1.Win.TreeView.SelectionMode.Radio;
            this.c1MultiSelect3.Size = new System.Drawing.Size(271, 37);
            this.c1MultiSelect3.TabIndex = 3;
            // 
            // c1TagEditor2
            // 
            this.c1TagEditor2.BackColor = System.Drawing.SystemColors.Window;
            this.c1TagEditor2.DisplayMode = C1.Win.Input.DisplayMode.Text;
            this.c1TagEditor2.Location = new System.Drawing.Point(309, 77);
            this.c1TagEditor2.Name = "c1TagEditor2";
            this.c1TagEditor2.Size = new System.Drawing.Size(301, 37);
            this.c1TagEditor2.TabIndex = 4;
            this.c1TagEditor2.Text = "Apple,Pear,Pineapple,Watermelon,";
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1TagEditor2);
            this.Controls.Add(this.c1MultiSelect3);
            this.Controls.Add(this.c1MultiSelect2);
            this.Controls.Add(this.c1TagEditor1);
            this.Controls.Add(this.c1MultiSelect1);
            this.Name = "Overview";
            this.Size = new System.Drawing.Size(641, 308);
            this.ResumeLayout(false);

        }


        #endregion

        private C1.Win.Input.C1MultiSelect c1MultiSelect1;
        private C1.Win.Input.C1TagEditor c1TagEditor1;
        private C1.Win.Input.C1MultiSelect c1MultiSelect2;
        private C1.Win.Input.C1MultiSelect c1MultiSelect3;
        private C1.Win.Input.C1TagEditor c1TagEditor2;
    }
}
