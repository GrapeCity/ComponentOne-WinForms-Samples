namespace AddingUICommands
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            C1.Win.C1DynamicHelp.MapItem mapItem4 = new C1.Win.C1DynamicHelp.MapItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.c1DynamicHelp1 = new C1.Win.C1DynamicHelp.C1DynamicHelp();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.btnForward = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnContents = new System.Windows.Forms.ToolStripButton();
            this.btnIndex = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPin = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            mapItem1.HelpTopicTrigger = C1.Win.C1DynamicHelp.HelpTopicTrigger.MouseEnter;
            mapItem1.ItemType = C1.Win.C1DynamicHelp.MapItemType.Static;
            mapItem1.ShowDefaultTopicFirst = true;
            mapItem1.UIElement = this.checkBox1;
            mapItem1.Url = "WordDocuments/designtimesupport.htm";
            mapItem1.UseDefaultTrigger = true;
            this.c1DynamicHelp1.SetHelpTopic(this.checkBox1, mapItem1);
            this.checkBox1.Location = new System.Drawing.Point(72, 273);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            mapItem2.HelpTopicTrigger = C1.Win.C1DynamicHelp.HelpTopicTrigger.Enter;
            mapItem2.ItemType = C1.Win.C1DynamicHelp.MapItemType.Static;
            mapItem2.ShowDefaultTopicFirst = true;
            mapItem2.UIElement = this.textBox1;
            mapItem2.Url = "WordDocuments/howtousec1dynamichelp.htm";
            mapItem2.UseDefaultTrigger = true;
            this.c1DynamicHelp1.SetHelpTopic(this.textBox1, mapItem2);
            this.textBox1.Location = new System.Drawing.Point(72, 246);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "textBox1";
            // 
            // button1
            // 
            mapItem3.HelpTopicTrigger = C1.Win.C1DynamicHelp.HelpTopicTrigger.MouseEnter;
            mapItem3.ItemType = C1.Win.C1DynamicHelp.MapItemType.Static;
            mapItem3.ShowDefaultTopicFirst = true;
            mapItem3.UIElement = this.button1;
            mapItem3.Url = "WordDocuments/runtimesupport.htm";
            mapItem3.UseDefaultTrigger = true;
            this.c1DynamicHelp1.SetHelpTopic(this.button1, mapItem3);
            this.button1.Location = new System.Drawing.Point(208, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.checkBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.c1DynamicHelp1);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(850, 372);
            this.splitContainer1.SplitterDistance = 378;
            this.splitContainer1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sample controls showing help topics when the mouse hovers over them:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 74);
            this.label3.TabIndex = 3;
            this.label3.Text = "3. Use the Pin button to pin down the currently displayed topic. If the Pin butto" +
                "n is pressed, current topic won\'t change regardless of mouse movement and focus " +
                "changes.";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "2. Use the Contents/Index/Search buttons to open help in an external window on a " +
                "specific tab.";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Use the Back/Forward buttons to navigate to the previous/next help topic in th" +
                "e navigation history.";
            // 
            // c1DynamicHelp1
            // 
            this.c1DynamicHelp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DynamicHelp1.HelpSource = "C1Sample.chm";
            this.c1DynamicHelp1.Location = new System.Drawing.Point(0, 25);
            this.c1DynamicHelp1.Name = "c1DynamicHelp1";
            this.c1DynamicHelp1.Size = new System.Drawing.Size(468, 347);
            this.c1DynamicHelp1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.btnForward,
            this.toolStripSeparator3,
            this.btnContents,
            this.btnIndex,
            this.btnSearch,
            this.toolStripSeparator4,
            this.btnPin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(468, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnBack
            // 
            this.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBack.Enabled = false;
            this.btnBack.Image = global::AddingUICommands.Properties.Resources.prev;
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(23, 22);
            this.btnBack.Text = "Back";
            // 
            // btnForward
            // 
            this.btnForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnForward.Enabled = false;
            this.btnForward.Image = global::AddingUICommands.Properties.Resources.next;
            this.btnForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(23, 22);
            this.btnForward.Text = "Forward";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnContents
            // 
            this.btnContents.Image = global::AddingUICommands.Properties.Resources.contents;
            this.btnContents.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnContents.Name = "btnContents";
            this.btnContents.Size = new System.Drawing.Size(71, 22);
            this.btnContents.Text = "Contents";
            // 
            // btnIndex
            // 
            this.btnIndex.Image = global::AddingUICommands.Properties.Resources.index;
            this.btnIndex.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(55, 22);
            this.btnIndex.Text = "Index";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::AddingUICommands.Properties.Resources.search;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 22);
            this.btnSearch.Text = "Search";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPin
            // 
            this.btnPin.CheckOnClick = true;
            this.btnPin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPin.Image = global::AddingUICommands.Properties.Resources.unpinned;
            this.btnPin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPin.Name = "btnPin";
            this.btnPin.Size = new System.Drawing.Size(23, 22);
            this.btnPin.Text = "Fix topic";
            this.btnPin.CheckedChanged += new System.EventHandler(this.btnPin_CheckedChanged);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::AddingUICommands.Properties.Resources.unpinned;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::AddingUICommands.Properties.Resources.unpinned;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 372);
            this.Controls.Add(this.splitContainer1);
            mapItem4.HelpTopicTrigger = C1.Win.C1DynamicHelp.HelpTopicTrigger.None;
            mapItem4.ItemType = C1.Win.C1DynamicHelp.MapItemType.Static;
            mapItem4.ShowDefaultTopicFirst = true;
            mapItem4.UIElement = this;
            mapItem4.Url = "WordDocuments/overview.htm";
            mapItem4.UseDefaultTrigger = true;
            this.c1DynamicHelp1.SetHelpTopic(this, mapItem4);
            this.Name = "Form1";
            this.Text = "Adding a toolbar to C1DynamicHelp";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private C1.Win.C1DynamicHelp.C1DynamicHelp c1DynamicHelp1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.ToolStripButton btnForward;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnContents;
        private System.Windows.Forms.ToolStripButton btnIndex;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnPin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

