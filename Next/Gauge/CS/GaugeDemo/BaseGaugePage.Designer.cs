namespace GaugeDemo
{
    partial class BaseGaugePage
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
            this.components = new System.ComponentModel.Container();
            this.gaugeGrid = new System.Windows.Forms.PropertyGrid();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.gaugePanel = new System.Windows.Forms.Panel();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.objectLabel = new System.Windows.Forms.Label();
            this.captionLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gridPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gaugeGrid
            // 
            this.gaugeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeGrid.Location = new System.Drawing.Point(2, 18);
            this.gaugeGrid.Name = "gaugeGrid";
            this.gaugeGrid.Size = new System.Drawing.Size(216, 441);
            this.gaugeGrid.TabIndex = 0;
            this.gaugeGrid.ToolbarVisible = false;
            this.gaugeGrid.SelectedObjectsChanged += new System.EventHandler(this.gaugeGrid_SelectedObjectsChanged);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(391, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 461);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // gaugePanel
            // 
            this.gaugePanel.BackColor = System.Drawing.SystemColors.Window;
            this.gaugePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugePanel.Location = new System.Drawing.Point(0, 25);
            this.gaugePanel.Name = "gaugePanel";
            this.gaugePanel.Size = new System.Drawing.Size(391, 436);
            this.gaugePanel.TabIndex = 2;
            // 
            // gridPanel
            // 
            this.gridPanel.BackColor = System.Drawing.SystemColors.Control;
            this.gridPanel.Controls.Add(this.gaugeGrid);
            this.gridPanel.Controls.Add(this.objectLabel);
            this.gridPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridPanel.Location = new System.Drawing.Point(395, 0);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Padding = new System.Windows.Forms.Padding(2);
            this.gridPanel.Size = new System.Drawing.Size(220, 461);
            this.gridPanel.TabIndex = 3;
            // 
            // objectLabel
            // 
            this.objectLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.objectLabel.Location = new System.Drawing.Point(2, 2);
            this.objectLabel.Name = "objectLabel";
            this.objectLabel.Size = new System.Drawing.Size(216, 16);
            this.objectLabel.TabIndex = 0;
            this.objectLabel.Text = "object properties:";
            // 
            // captionLabel
            // 
            this.captionLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.captionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.captionLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionLabel.ForeColor = System.Drawing.Color.White;
            this.captionLabel.Location = new System.Drawing.Point(0, 0);
            this.captionLabel.Name = "captionLabel";
            this.captionLabel.Size = new System.Drawing.Size(391, 25);
            this.captionLabel.TabIndex = 0;
            this.captionLabel.Text = "Caption";
            this.captionLabel.Visible = false;
            this.captionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BaseGaugePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.gaugePanel);
            this.Controls.Add(this.captionLabel);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.gridPanel);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BaseGaugePage";
            this.Size = new System.Drawing.Size(615, 461);
            this.gridPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel gaugePanel;
        public System.Windows.Forms.PropertyGrid gaugeGrid;
        private System.Windows.Forms.Label objectLabel;
        public System.Windows.Forms.Label captionLabel;
        public System.Windows.Forms.Panel gridPanel;
        public System.Windows.Forms.Splitter splitter1;
        public System.Windows.Forms.Timer timer1;
    }
}
