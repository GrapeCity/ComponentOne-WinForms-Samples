namespace GaugeDemo
{
    partial class PageDataBound
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
            C1.Win.Gauge.C1GaugeLabels c1GaugeLabels1 = new C1.Win.Gauge.C1GaugeLabels();
            C1.Win.Gauge.C1GaugeMarks c1GaugeMarks1 = new C1.Win.Gauge.C1GaugeMarks();
            C1.Win.Gauge.C1GaugeRange c1GaugeRange1 = new C1.Win.Gauge.C1GaugeRange();
            C1.Win.Gauge.C1GaugeRange c1GaugeRange2 = new C1.Win.Gauge.C1GaugeRange();
            C1.Win.Gauge.C1GaugeRange c1GaugeRange3 = new C1.Win.Gauge.C1GaugeRange();
            C1.Win.Gauge.C1GaugeSingleLabel c1GaugeSingleLabel1 = new C1.Win.Gauge.C1GaugeSingleLabel();
            C1.Win.Gauge.C1GaugeSingleLabel c1GaugeSingleLabel2 = new C1.Win.Gauge.C1GaugeSingleLabel();
            C1.Win.Gauge.C1GaugeSingleLabel c1GaugeSingleLabel3 = new C1.Win.Gauge.C1GaugeSingleLabel();
            C1.Win.Gauge.C1GaugeCaption c1GaugeCaption1 = new C1.Win.Gauge.C1GaugeCaption();
            C1.Win.Gauge.C1GaugeCaption c1GaugeCaption2 = new C1.Win.Gauge.C1GaugeCaption();
            C1.Win.Gauge.C1GaugeCaption c1GaugeCaption3 = new C1.Win.Gauge.C1GaugeCaption();
            C1.Win.Gauge.C1GaugeCaption c1GaugeCaption4 = new C1.Win.Gauge.C1GaugeCaption();
            C1.Win.Gauge.C1GaugePointer c1GaugePointer1 = new C1.Win.Gauge.C1GaugePointer();
            C1.Win.Gauge.C1GaugePointer c1GaugePointer2 = new C1.Win.Gauge.C1GaugePointer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.c1Gauge1 = new C1.Win.Gauge.C1Gauge();
            this.c1LinearGauge1 = new C1.Win.Gauge.C1LinearGauge();
            this.gaugePanel.SuspendLayout();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).BeginInit();
            this.SuspendLayout();
            // 
            // gaugePanel
            // 
            this.gaugePanel.Controls.Add(this.c1Gauge1);
            this.gaugePanel.Controls.Add(this.label1);
            this.gaugePanel.Controls.Add(this.dataGridView1);
            // 
            // gaugeGrid
            // 
            this.gaugeGrid.SelectedObject = this.c1LinearGauge1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(371, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Products:";
            // 
            // c1Gauge1
            // 
            this.c1Gauge1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.c1Gauge1.Gauges.AddRange(new C1.Win.Gauge.C1GaugeBase[] {
            this.c1LinearGauge1});
            this.c1Gauge1.Location = new System.Drawing.Point(9, 225);
            this.c1Gauge1.Name = "c1Gauge1";
            this.c1Gauge1.Size = new System.Drawing.Size(371, 204);
            this.c1Gauge1.TabIndex = 2;
            this.c1Gauge1.ViewTag = ((long)(634314462784886300));
            // 
            // c1LinearGauge1
            // 
            this.c1LinearGauge1.AxisStart = 0.04;
            this.c1LinearGauge1.BaseOrigin = 0.07;
            c1GaugeLabels1.FontSize = 7;
            c1GaugeLabels1.Interval = 25;
            c1GaugeLabels1.Location = 0;
            c1GaugeLabels1.ViewTag = ((long)(641069907430065399));
            c1GaugeMarks1.Alignment = C1.Win.Gauge.C1GaugeAlignment.Out;
            c1GaugeMarks1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            c1GaugeMarks1.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.None;
            c1GaugeMarks1.Interval = 25;
            c1GaugeMarks1.Length = 95;
            c1GaugeMarks1.Location = 5;
            c1GaugeMarks1.ViewTag = ((long)(643884661361599274));
            c1GaugeMarks1.Width = 0.01;
            c1GaugeRange1.Alignment = C1.Win.Gauge.C1GaugeAlignment.Out;
            c1GaugeRange1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            c1GaugeRange1.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            c1GaugeRange1.Location = 15;
            c1GaugeRange1.ToPointerIndex = 100;
            c1GaugeRange1.ViewTag = ((long)(638536618060574778));
            c1GaugeRange1.Width = 20;
            c1GaugeRange2.Alignment = C1.Win.Gauge.C1GaugeAlignment.Out;
            c1GaugeRange2.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            c1GaugeRange2.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            c1GaugeRange2.ToPointerIndex = 0;
            c1GaugeRange2.ViewTag = ((long)(639099568095428233));
            c1GaugeRange2.Width = 20;
            c1GaugeRange3.Alignment = C1.Win.Gauge.C1GaugeAlignment.Out;
            c1GaugeRange3.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            c1GaugeRange3.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            c1GaugeRange3.Location = 75;
            c1GaugeRange3.ToPointerIndex = 1;
            c1GaugeRange3.ViewTag = ((long)(638818093102181548));
            c1GaugeRange3.Width = 20;
            c1GaugeSingleLabel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            c1GaugeSingleLabel1.Location = 27;
            c1GaugeSingleLabel1.PointerIndex = 100;
            c1GaugeSingleLabel1.Position = -0.15;
            c1GaugeSingleLabel1.TextAngle = -30;
            c1GaugeSingleLabel1.ViewTag = ((long)(655425141749395310));
            c1GaugeSingleLabel2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            c1GaugeSingleLabel2.Location = 57;
            c1GaugeSingleLabel2.PointerIndex = 0;
            c1GaugeSingleLabel2.Position = -0.15;
            c1GaugeSingleLabel2.TextAngle = -30;
            c1GaugeSingleLabel2.ViewTag = ((long)(655988093219139285));
            c1GaugeSingleLabel3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            c1GaugeSingleLabel3.Location = 87;
            c1GaugeSingleLabel3.PointerIndex = 1;
            c1GaugeSingleLabel3.Position = -0.15;
            c1GaugeSingleLabel3.TextAngle = -30;
            c1GaugeSingleLabel3.ViewTag = ((long)(655706618222616595));
            this.c1LinearGauge1.Decorators.AddRange(new C1.Win.Gauge.C1GaugeDecorator[] {
            c1GaugeLabels1,
            c1GaugeMarks1,
            c1GaugeRange1,
            c1GaugeRange2,
            c1GaugeRange3,
            c1GaugeSingleLabel1,
            c1GaugeSingleLabel2,
            c1GaugeSingleLabel3});
            c1GaugeCaption1.CenterPointY = 0.2;
            c1GaugeCaption1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            c1GaugeCaption1.RotateAngle = -30;
            c1GaugeCaption1.Text = "UnitsInStock";
            c1GaugeCaption1.Viewport.MarginX = -100;
            c1GaugeCaption1.Viewport.TranslateX = -0.04;
            c1GaugeCaption1.Viewport.Width = 100;
            c1GaugeCaption2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            c1GaugeCaption2.RotateAngle = -30;
            c1GaugeCaption2.Text = "ReorderLevel";
            c1GaugeCaption2.Viewport.MarginX = -100;
            c1GaugeCaption2.Viewport.TranslateX = -0.04;
            c1GaugeCaption2.Viewport.Width = 100;
            c1GaugeCaption3.CenterPointY = 0.8;
            c1GaugeCaption3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            c1GaugeCaption3.RotateAngle = -30;
            c1GaugeCaption3.Text = "UnitsOnOrder";
            c1GaugeCaption3.Viewport.MarginX = -100;
            c1GaugeCaption3.Viewport.TranslateX = -0.04;
            c1GaugeCaption3.Viewport.Width = 100;
            c1GaugeCaption4.CenterPointX = 0.8;
            c1GaugeCaption4.CenterPointY = 1.07;
            c1GaugeCaption4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            c1GaugeCaption4.Text = "fixed viewport size";
            this.c1LinearGauge1.FaceShapes.AddRange(new C1.Win.Gauge.C1GaugeBaseShape[] {
            c1GaugeCaption1,
            c1GaugeCaption2,
            c1GaugeCaption3,
            c1GaugeCaption4});
            this.c1LinearGauge1.Maximum = 125;
            c1GaugePointer1.ViewTag = ((long)(635440368798580392));
            c1GaugePointer1.Visible = false;
            c1GaugePointer2.ViewTag = ((long)(635158893673981477));
            c1GaugePointer2.Visible = false;
            this.c1LinearGauge1.MorePointers.AddRange(new C1.Win.Gauge.C1GaugePointer[] {
            c1GaugePointer1,
            c1GaugePointer2});
            this.c1LinearGauge1.Name = "c1LinearGauge1";
            this.c1LinearGauge1.Pointer.Visible = false;
            this.c1LinearGauge1.Viewport.Height = -300;
            this.c1LinearGauge1.Viewport.Width = -370;
            this.c1LinearGauge1.Viewport.X = -420;
            this.c1LinearGauge1.Viewport.Y = -300;
            this.c1LinearGauge1.ViewTag = ((long)(634595937804029030));
            // 
            // PageDataBound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "PageDataBound";
            this.gaugePanel.ResumeLayout(false);
            this.gaugePanel.PerformLayout();
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private C1.Win.Gauge.C1Gauge c1Gauge1;
        private C1.Win.Gauge.C1LinearGauge c1LinearGauge1;
    }
}
