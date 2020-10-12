namespace ControlExplorer.Chart
{
    partial class TrendLines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrendLines));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbViewLegend = new System.Windows.Forms.CheckBox();
            this.cbViewFormula = new System.Windows.Forms.CheckBox();
            this.cbViewStatistics = new System.Windows.Forms.CheckBox();
            this.udYIntercept = new System.Windows.Forms.NumericUpDown();
            this.cbUseYIntercept = new System.Windows.Forms.CheckBox();
            this.cbTLCursor = new System.Windows.Forms.CheckBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.udOrder = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTrendType = new System.Windows.Forms.ComboBox();
            this.lblErrorData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDataType = new System.Windows.Forms.ComboBox();
            this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
            this.cbAllowDragging = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udYIntercept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.cbAllowDragging);
            this.panel1.Controls.Add(this.cbViewLegend);
            this.panel1.Controls.Add(this.cbViewFormula);
            this.panel1.Controls.Add(this.cbViewStatistics);
            this.panel1.Controls.Add(this.udYIntercept);
            this.panel1.Controls.Add(this.cbUseYIntercept);
            this.panel1.Controls.Add(this.cbTLCursor);
            this.panel1.Controls.Add(this.lblNumber);
            this.panel1.Controls.Add(this.udOrder);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbTrendType);
            this.panel1.Controls.Add(this.lblErrorData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbDataType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 446);
            this.panel1.TabIndex = 0;
            // 
            // cbViewLegend
            // 
            this.cbViewLegend.Checked = true;
            this.cbViewLegend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbViewLegend.Location = new System.Drawing.Point(6, 212);
            this.cbViewLegend.Name = "cbViewLegend";
            this.cbViewLegend.Size = new System.Drawing.Size(144, 24);
            this.cbViewLegend.TabIndex = 19;
            this.cbViewLegend.Text = "View Legend";
            this.cbViewLegend.UseVisualStyleBackColor = true;
            this.cbViewLegend.CheckedChanged += new System.EventHandler(this.cbViewLegend_CheckedChanged);
            // 
            // cbViewFormula
            // 
            this.cbViewFormula.Checked = true;
            this.cbViewFormula.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbViewFormula.Location = new System.Drawing.Point(6, 272);
            this.cbViewFormula.Name = "cbViewFormula";
            this.cbViewFormula.Size = new System.Drawing.Size(144, 24);
            this.cbViewFormula.TabIndex = 18;
            this.cbViewFormula.Text = "View Formula";
            this.cbViewFormula.UseVisualStyleBackColor = true;
            this.cbViewFormula.CheckedChanged += new System.EventHandler(this.cbViewFormula_CheckedChanged);
            // 
            // cbViewStatistics
            // 
            this.cbViewStatistics.Checked = true;
            this.cbViewStatistics.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbViewStatistics.Location = new System.Drawing.Point(6, 242);
            this.cbViewStatistics.Name = "cbViewStatistics";
            this.cbViewStatistics.Size = new System.Drawing.Size(144, 24);
            this.cbViewStatistics.TabIndex = 17;
            this.cbViewStatistics.Text = "View Statistics";
            this.cbViewStatistics.UseVisualStyleBackColor = true;
            this.cbViewStatistics.CheckedChanged += new System.EventHandler(this.cbViewStatistics_CheckedChanged);
            // 
            // udYIntercept
            // 
            this.udYIntercept.DecimalPlaces = 1;
            this.udYIntercept.Location = new System.Drawing.Point(102, 152);
            this.udYIntercept.Name = "udYIntercept";
            this.udYIntercept.Size = new System.Drawing.Size(48, 20);
            this.udYIntercept.TabIndex = 16;
            this.udYIntercept.Visible = false;
            this.udYIntercept.ValueChanged += new System.EventHandler(this.udYIntercept_ValueChanged);
            // 
            // cbUseYIntercept
            // 
            this.cbUseYIntercept.Location = new System.Drawing.Point(6, 152);
            this.cbUseYIntercept.Name = "cbUseYIntercept";
            this.cbUseYIntercept.Size = new System.Drawing.Size(96, 24);
            this.cbUseYIntercept.TabIndex = 15;
            this.cbUseYIntercept.Text = "UseYIntercept";
            this.cbUseYIntercept.CheckedChanged += new System.EventHandler(this.cbUseYIntercept_CheckedChanged);
            // 
            // cbTLCursor
            // 
            this.cbTLCursor.Checked = true;
            this.cbTLCursor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTLCursor.Location = new System.Drawing.Point(6, 182);
            this.cbTLCursor.Name = "cbTLCursor";
            this.cbTLCursor.Size = new System.Drawing.Size(144, 24);
            this.cbTLCursor.TabIndex = 14;
            this.cbTLCursor.Text = "Trend line cursor";
            // 
            // lblNumber
            // 
            this.lblNumber.Location = new System.Drawing.Point(6, 120);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(96, 20);
            this.lblNumber.TabIndex = 13;
            this.lblNumber.Text = "Number of terms:";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // udOrder
            // 
            this.udOrder.Location = new System.Drawing.Point(110, 120);
            this.udOrder.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udOrder.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.udOrder.Name = "udOrder";
            this.udOrder.Size = new System.Drawing.Size(40, 20);
            this.udOrder.TabIndex = 12;
            this.udOrder.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.udOrder.ValueChanged += new System.EventHandler(this.udOrder_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Trend Line:";
            // 
            // cbTrendType
            // 
            this.cbTrendType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrendType.Location = new System.Drawing.Point(9, 85);
            this.cbTrendType.Name = "cbTrendType";
            this.cbTrendType.Size = new System.Drawing.Size(144, 21);
            this.cbTrendType.TabIndex = 9;
            this.cbTrendType.SelectedIndexChanged += new System.EventHandler(this.cbTrendType_SelectedIndexChanged);
            // 
            // lblErrorData
            // 
            this.lblErrorData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblErrorData.ForeColor = System.Drawing.Color.Red;
            this.lblErrorData.Location = new System.Drawing.Point(9, 405);
            this.lblErrorData.Name = "lblErrorData";
            this.lblErrorData.Size = new System.Drawing.Size(144, 32);
            this.lblErrorData.TabIndex = 8;
            this.lblErrorData.Text = "This data does not fit to the selected trend type.";
            this.lblErrorData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data:";
            // 
            // cbDataType
            // 
            this.cbDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataType.Location = new System.Drawing.Point(9, 25);
            this.cbDataType.Name = "cbDataType";
            this.cbDataType.Size = new System.Drawing.Size(144, 21);
            this.cbDataType.TabIndex = 6;
            this.cbDataType.SelectedIndexChanged += new System.EventHandler(this.cbDataType_SelectedIndexChanged);
            // 
            // c1Chart1
            // 
            this.c1Chart1.BackColor = System.Drawing.Color.AliceBlue;
            this.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Chart1.Location = new System.Drawing.Point(159, 0);
            this.c1Chart1.Name = "c1Chart1";
            this.c1Chart1.PropBag = resources.GetString("c1Chart1.PropBag");
            this.c1Chart1.Size = new System.Drawing.Size(433, 446);
            this.c1Chart1.TabIndex = 1;
            this.c1Chart1.Paint += new System.Windows.Forms.PaintEventHandler(this.c1Chart1_Paint);
            this.c1Chart1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.c1Chart1_MouseUp);
            this.c1Chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.c1Chart1_MouseMove);
            this.c1Chart1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.c1Chart1_MouseDown);
            this.c1Chart1.LayoutLabels += new System.EventHandler(this.c1Chart1_LayoutLabels);
            this.c1Chart1.Resize += new System.EventHandler(this.c1Chart1_Resize);
            // 
            // cbAllowDragging
            // 
            this.cbAllowDragging.AutoSize = true;
            this.cbAllowDragging.Location = new System.Drawing.Point(6, 302);
            this.cbAllowDragging.Name = "cbAllowDragging";
            this.cbAllowDragging.Size = new System.Drawing.Size(81, 17);
            this.cbAllowDragging.TabIndex = 20;
            this.cbAllowDragging.Text = "Drag Points";
            this.cbAllowDragging.UseVisualStyleBackColor = true;
            // 
            // TrendLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this.c1Chart1);
            this.Controls.Add(this.panel1);
            this.Name = "TrendLines";
            this.Text = "TrendLines";
            this.Load += new System.EventHandler(this.TrendLines_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udYIntercept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1Chart.C1Chart c1Chart1;
        private System.Windows.Forms.CheckBox cbViewFormula;
        private System.Windows.Forms.CheckBox cbViewStatistics;
        private System.Windows.Forms.NumericUpDown udYIntercept;
        private System.Windows.Forms.CheckBox cbUseYIntercept;
        private System.Windows.Forms.CheckBox cbTLCursor;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.NumericUpDown udOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTrendType;
        private System.Windows.Forms.Label lblErrorData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDataType;
        private System.Windows.Forms.CheckBox cbViewLegend;
        private System.Windows.Forms.CheckBox cbAllowDragging;
    }
}