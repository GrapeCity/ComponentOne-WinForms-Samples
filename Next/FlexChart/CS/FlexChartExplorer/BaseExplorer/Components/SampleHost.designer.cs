namespace BaseExplorer.Components
{
    partial class SampleHost
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
            this.rootPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelNextNav = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnNextArrow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlViewer = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.panelPrevNav = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnPrevArrow = new System.Windows.Forms.Button();
            this.descPanel = new BaseExplorer.Components.DescriptionPanel();
            this.rootPanel.SuspendLayout();
            this.panelNextNav.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelPrevNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootPanel
            // 
            this.rootPanel.BackColor = System.Drawing.Color.White;
            this.rootPanel.ColumnCount = 2;
            this.rootPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rootPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rootPanel.Controls.Add(this.panelNextNav, 1, 1);
            this.rootPanel.Controls.Add(this.panel1, 0, 0);
            this.rootPanel.Controls.Add(this.panelPrevNav, 0, 1);
            this.rootPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootPanel.Location = new System.Drawing.Point(0, 0);
            this.rootPanel.Margin = new System.Windows.Forms.Padding(0);
            this.rootPanel.Name = "rootPanel";
            this.rootPanel.RowCount = 2;
            this.rootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.rootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.rootPanel.Size = new System.Drawing.Size(815, 551);
            this.rootPanel.TabIndex = 15;
            this.rootPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlViewer_Paint);
            // 
            // panelNextNav
            // 
            this.panelNextNav.Controls.Add(this.btnNext);
            this.panelNextNav.Controls.Add(this.btnNextArrow);
            this.panelNextNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNextNav.Location = new System.Drawing.Point(407, 511);
            this.panelNextNav.Margin = new System.Windows.Forms.Padding(0);
            this.panelNextNav.Name = "panelNextNav";
            this.panelNextNav.Size = new System.Drawing.Size(408, 40);
            this.panelNextNav.TabIndex = 7;
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(0, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(374, 40);
            this.btnNext.TabIndex = 7;
            this.btnNext.Tag = "Next";
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnNextArrow
            // 
            this.btnNextArrow.AutoSize = true;
            this.btnNextArrow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNextArrow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNextArrow.FlatAppearance.BorderSize = 0;
            this.btnNextArrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnNextArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextArrow.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextArrow.Location = new System.Drawing.Point(374, 0);
            this.btnNextArrow.Name = "btnNextArrow";
            this.btnNextArrow.Size = new System.Drawing.Size(34, 40);
            this.btnNextArrow.TabIndex = 6;
            this.btnNextArrow.TabStop = false;
            this.btnNextArrow.Tag = "Next";
            this.btnNextArrow.Text = "";
            this.btnNextArrow.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rootPanel.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.pnlViewer);
            this.panel1.Controls.Add(this.panelInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(815, 511);
            this.panel1.TabIndex = 0;
            // 
            // pnlViewer
            // 
            this.pnlViewer.BackColor = System.Drawing.Color.White;
            this.pnlViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewer.Location = new System.Drawing.Point(10, 42);
            this.pnlViewer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlViewer.Name = "pnlViewer";
            this.pnlViewer.Padding = new System.Windows.Forms.Padding(5);
            this.pnlViewer.Size = new System.Drawing.Size(793, 457);
            this.pnlViewer.TabIndex = 5;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.btnInfo);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(10, 10);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.panelInfo.Size = new System.Drawing.Size(793, 32);
            this.panelInfo.TabIndex = 12;
            this.panelInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaintPanelInfo);
            // 
            // btnInfo
            // 
            this.btnInfo.AutoSize = true;
            this.btnInfo.BackgroundImage = global::BaseExplorer.Properties.Resources.Img_Info;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(741, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(32, 32);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.TabStop = false;
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // panelPrevNav
            // 
            this.panelPrevNav.Controls.Add(this.btnPrevious);
            this.panelPrevNav.Controls.Add(this.btnPrevArrow);
            this.panelPrevNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrevNav.Location = new System.Drawing.Point(0, 511);
            this.panelPrevNav.Margin = new System.Windows.Forms.Padding(0);
            this.panelPrevNav.Name = "panelPrevNav";
            this.panelPrevNav.Size = new System.Drawing.Size(407, 40);
            this.panelPrevNav.TabIndex = 5;
            // 
            // btnPrevious
            // 
            this.btnPrevious.AutoSize = true;
            this.btnPrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(25, 0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(382, 40);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Tag = "Previous";
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnPrevArrow
            // 
            this.btnPrevArrow.AutoSize = true;
            this.btnPrevArrow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrevArrow.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrevArrow.FlatAppearance.BorderSize = 0;
            this.btnPrevArrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnPrevArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevArrow.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevArrow.Location = new System.Drawing.Point(0, 0);
            this.btnPrevArrow.Name = "btnPrevArrow";
            this.btnPrevArrow.Size = new System.Drawing.Size(25, 40);
            this.btnPrevArrow.TabIndex = 8;
            this.btnPrevArrow.TabStop = false;
            this.btnPrevArrow.Tag = "Previous";
            this.btnPrevArrow.Text = "Ä";
            this.btnPrevArrow.UseVisualStyleBackColor = true;
            // 
            // descPanel
            // 
            this.descPanel.AutoSize = true;
            this.descPanel.BackColor = System.Drawing.Color.White;
            this.descPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descPanel.Content = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang16393{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft " +
    "Sans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.descPanel.Location = new System.Drawing.Point(0, 0);
            this.descPanel.Margin = new System.Windows.Forms.Padding(5);
            this.descPanel.Name = "descPanel";
            this.descPanel.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.descPanel.Size = new System.Drawing.Size(815, 280);
            this.descPanel.TabIndex = 14;
            this.descPanel.TabStop = false;
            // 
            // SampleHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rootPanel);
            this.Controls.Add(this.descPanel);
            this.Name = "SampleHost";
            this.Size = new System.Drawing.Size(815, 551);
            this.SizeChanged += new System.EventHandler(this.SampleHost_SizeChanged);
            this.rootPanel.ResumeLayout(false);
            this.panelNextNav.ResumeLayout(false);
            this.panelNextNav.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelPrevNav.ResumeLayout(false);
            this.panelPrevNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DescriptionPanel descPanel;
        private System.Windows.Forms.TableLayoutPanel rootPanel;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel pnlViewer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelNextNav;
        private System.Windows.Forms.Panel panelPrevNav;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnNextArrow;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnPrevArrow;
    }
}
