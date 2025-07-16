namespace GridTips
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._flex = new C1.Win.FlexGrid.C1FlexGrid();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this._flex3 = new C1.Win.FlexGrid.C1FlexGrid();
            this._flex2 = new C1.Win.FlexGrid.C1FlexGrid();
            this._flex4 = new C1.Win.FlexGrid.C1FlexGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.c1SuperTooltip1 = new C1.Win.SuperTooltip.C1SuperTooltip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._flex3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._flex2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._flex4)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:25;}\t";
            this._flex.Location = new System.Drawing.Point(12, 34);
            this._flex.Name = "_flex";
            this._flex.Rows.DefaultSize = 17;
            this._flex.Size = new System.Drawing.Size(389, 191);
            this._flex.TabIndex = 0;
            this.c1SuperTooltip1.SetToolTip(this._flex, resources.GetString("_flex.ToolTip"));
            this._flex.MouseHoverCell += new System.EventHandler(this._flex_MouseHoverCell);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.AutoPopDelay = 500000;
            this.toolTip1.InitialDelay = 0;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 0;
            // 
            // _flex3
            // 
            this._flex3.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:25;}\t";
            this._flex3.Location = new System.Drawing.Point(411, 34);
            this._flex3.Name = "_flex3";
            this._flex3.Rows.DefaultSize = 17;
            this._flex3.Size = new System.Drawing.Size(389, 191);
            this._flex3.TabIndex = 0;
            this._flex3.MouseHoverCell += new System.EventHandler(this._flex3_MouseHoverCell);
            this._flex3.MouseLeave += new System.EventHandler(this._flex3_MouseLeave);
            // 
            // _flex2
            // 
            this._flex2.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:25;}\t";
            this._flex2.Location = new System.Drawing.Point(12, 290);
            this._flex2.Name = "_flex2";
            this._flex2.Rows.DefaultSize = 17;
            this._flex2.Size = new System.Drawing.Size(389, 191);
            this._flex2.TabIndex = 0;
            this._flex2.MouseHoverCell += new System.EventHandler(this._flex2_MouseHoverCell);
            // 
            // _flex4
            // 
            this._flex4.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:25;}\t";
            this._flex4.Location = new System.Drawing.Point(411, 290);
            this._flex4.Name = "_flex4";
            this._flex4.Rows.DefaultSize = 17;
            this._flex4.Size = new System.Drawing.Size(389, 191);
            this._flex4.TabIndex = 0;
            this._flex4.MouseHoverCell += new System.EventHandler(this._flex4_MouseHoverCell);
            this._flex4.MouseLeave += new System.EventHandler(this._flex4_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SuperTooltip associated with each cell";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Regular Tooltip associated with each cell";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(15, 493);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Show tips in balloons";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "SuperTooltip with Show/Hide methods";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Regular Tooltip with Show/Hide methods";
            // 
            // c1SuperTooltip1
            // 
            this.c1SuperTooltip1.BackgroundGradient = C1.Win.SuperTooltip.BackgroundGradient.Gold;
            this.c1SuperTooltip1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.c1SuperTooltip1.Images.Add(new C1.Win.SuperTooltip.ImageEntry("AssocScript.png", ((System.Drawing.Image)(resources.GetObject("c1SuperTooltip1.Images")))));
            this.c1SuperTooltip1.Images.Add(new C1.Win.SuperTooltip.ImageEntry("BookOpen.png", ((System.Drawing.Image)(resources.GetObject("c1SuperTooltip1.Images1")))));
            this.c1SuperTooltip1.Images.Add(new C1.Win.SuperTooltip.ImageEntry("Target.png", ((System.Drawing.Image)(resources.GetObject("c1SuperTooltip1.Images2")))));
            this.c1SuperTooltip1.IsBalloon = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 519);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._flex4);
            this.Controls.Add(this._flex3);
            this.Controls.Add(this._flex2);
            this.Controls.Add(this._flex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1SuperTooltip: Associate tips with grid cells";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._flex3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._flex2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._flex4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGrid _flex;
        private C1.Win.SuperTooltip.C1SuperTooltip c1SuperTooltip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private C1.Win.FlexGrid.C1FlexGrid _flex3;
        private C1.Win.FlexGrid.C1FlexGrid _flex2;
        private C1.Win.FlexGrid.C1FlexGrid _flex4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

