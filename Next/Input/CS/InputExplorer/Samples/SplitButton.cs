using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputExplorer.Samples
{
    public partial class SplitButton : UserControl
    {
        private PropertyGrid propertyGrid1;
        private C1.Win.Input.C1SplitButton c1SplitButton1;

        public SplitButton()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            C1.Win.Input.SplitButtonItem splitButtonItem1 = new C1.Win.Input.SplitButtonItem();
            C1.Win.Input.SplitButtonItem splitButtonItem2 = new C1.Win.Input.SplitButtonItem();
            C1.Win.Input.SplitButtonItem splitButtonItem3 = new C1.Win.Input.SplitButtonItem();
            C1.Win.Input.SplitButtonItem splitButtonItem4 = new C1.Win.Input.SplitButtonItem();
            C1.Win.Input.SplitButtonItem splitButtonItem5 = new C1.Win.Input.SplitButtonItem();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.c1SplitButton1 = new C1.Win.Input.C1SplitButton();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertyGrid1.Location = new System.Drawing.Point(158, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.c1SplitButton1;
            this.propertyGrid1.Size = new System.Drawing.Size(366, 245);
            this.propertyGrid1.TabIndex = 0;
            // 
            // c1SplitButton1
            // 
            this.c1SplitButton1.Location = new System.Drawing.Point(14, 36);
            splitButtonItem1.Text = "Item1";
            splitButtonItem2.Checked = true;
            splitButtonItem2.CheckOnClick = true;
            splitButtonItem2.Text = "Item2";
            splitButtonItem4.Enabled = false;
            splitButtonItem4.Text = "Item31";
            splitButtonItem5.Enabled = false;
            splitButtonItem5.Text = "Item32";
            splitButtonItem3.Items.Add(splitButtonItem4);
            splitButtonItem3.Items.Add(splitButtonItem5);
            splitButtonItem3.Text = "Item3";
            this.c1SplitButton1.Items.Add(splitButtonItem1);
            this.c1SplitButton1.Items.Add(splitButtonItem2);
            this.c1SplitButton1.Items.Add(splitButtonItem3);
            this.c1SplitButton1.Name = "c1SplitButton1";
            this.c1SplitButton1.Size = new System.Drawing.Size(109, 36);
            this.c1SplitButton1.TabIndex = 1;
            this.c1SplitButton1.Text = "c1SplitButton1";
            // 
            // SplitButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1SplitButton1);
            this.Controls.Add(this.propertyGrid1);
            this.Name = "SplitButton";
            this.Size = new System.Drawing.Size(524, 245);
            this.ResumeLayout(false);

        }
    }
}
