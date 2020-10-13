namespace C1DataCollection101
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new C1DataCollection101.View.TabControlWithoutMargin();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menu1 = new C1DataCollection101.View.Menu();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sorting1 = new C1DataCollection101.View.Sorting();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.filtering1 = new C1DataCollection101.View.Filtering();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.grouping1 = new C1DataCollection101.View.Grouping();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.virtualMode1 = new C1DataCollection101.View.VirtualMode();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(685, 414);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.menu1);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(677, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // menu1
            // 
            this.menu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Margin = new System.Windows.Forms.Padding(0);
            this.menu1.Name = "menu1";
            this.menu1.SelectedSampleViewType = -2;
            this.menu1.Size = new System.Drawing.Size(677, 405);
            this.menu1.TabIndex = 0;
            this.menu1.SelectionChanged += new System.EventHandler<System.EventArgs>(this.menu1_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sorting1);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(677, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sorting1
            // 
            this.sorting1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sorting1.Location = new System.Drawing.Point(0, 0);
            this.sorting1.Name = "sorting1";
            this.sorting1.Size = new System.Drawing.Size(677, 405);
            this.sorting1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.filtering1);
            this.tabPage3.Location = new System.Drawing.Point(4, 5);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(677, 405);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // filtering1
            // 
            this.filtering1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filtering1.Location = new System.Drawing.Point(0, 0);
            this.filtering1.Name = "filtering1";
            this.filtering1.Size = new System.Drawing.Size(677, 405);
            this.filtering1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.grouping1);
            this.tabPage4.Location = new System.Drawing.Point(4, 5);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(677, 405);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // grouping1
            // 
            this.grouping1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grouping1.Location = new System.Drawing.Point(0, 0);
            this.grouping1.Margin = new System.Windows.Forms.Padding(0);
            this.grouping1.Name = "grouping1";
            this.grouping1.Size = new System.Drawing.Size(677, 405);
            this.grouping1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.virtualMode1);
            this.tabPage5.Location = new System.Drawing.Point(4, 5);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(677, 405);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // virtualMode1
            // 
            this.virtualMode1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.virtualMode1.Location = new System.Drawing.Point(0, 0);
            this.virtualMode1.Name = "virtualMode1";
            this.virtualMode1.Size = new System.Drawing.Size(681, 405);
            this.virtualMode1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(685, 414);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "C1DataCollection101";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private View.Menu menu1;
        private View.Sorting sorting1;
        private View.TabControlWithoutMargin tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private View.Filtering filtering1;
        private System.Windows.Forms.TabPage tabPage4;
        private View.Grouping grouping1;
        private System.Windows.Forms.TabPage tabPage5;
        private View.VirtualMode virtualMode1;
    }
}