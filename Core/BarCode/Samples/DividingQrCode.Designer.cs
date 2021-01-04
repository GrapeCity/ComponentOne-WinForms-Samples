
namespace BarCodeExplorer.Samples
{
    partial class DividingQrCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DividingQrCode));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this._settings = new System.Windows.Forms.PropertyGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this._sourceText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._symbols = new System.Windows.Forms.Label();
            this._range = new System.Windows.Forms.ComboBox();
            this._panel = new System.Windows.Forms.FlowLayoutPanel();
            this.lbGenerate = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._panel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 333);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._settings);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(439, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 333);
            this.panel2.TabIndex = 1;
            // 
            // _settings
            // 
            this._settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this._settings.HelpVisible = false;
            this._settings.Location = new System.Drawing.Point(0, 0);
            this._settings.Name = "_settings";
            this._settings.Size = new System.Drawing.Size(167, 333);
            this._settings.TabIndex = 0;
            this._settings.ToolbarVisible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbGenerate);
            this.panel3.Controls.Add(this._range);
            this.panel3.Controls.Add(this._symbols);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this._sourceText);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 333);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "The long text:";
            // 
            // _sourceText
            // 
            this._sourceText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sourceText.Location = new System.Drawing.Point(10, 28);
            this._sourceText.Multiline = true;
            this._sourceText.Name = "_sourceText";
            this._sourceText.Size = new System.Drawing.Size(153, 226);
            this._sourceText.TabIndex = 1;
            this._sourceText.Text = resources.GetString("_sourceText.Text");
            this._sourceText.TextChanged += new System.EventHandler(this._sourceText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Symbols:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Range:";
            // 
            // _symbols
            // 
            this._symbols.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._symbols.Location = new System.Drawing.Point(87, 282);
            this._symbols.Name = "_symbols";
            this._symbols.Size = new System.Drawing.Size(76, 15);
            this._symbols.TabIndex = 4;
            this._symbols.Text = "0";
            this._symbols.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _range
            // 
            this._range.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._range.FormattingEnabled = true;
            this._range.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this._range.Location = new System.Drawing.Point(87, 303);
            this._range.Name = "_range";
            this._range.Size = new System.Drawing.Size(76, 23);
            this._range.TabIndex = 5;
            this._range.SelectedIndexChanged += new System.EventHandler(this._range_SelectedIndexChanged);
            // 
            // _panel
            // 
            this._panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panel.Location = new System.Drawing.Point(171, 0);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(435, 333);
            this._panel.TabIndex = 1;
            // 
            // lbGenerate
            // 
            this.lbGenerate.AutoSize = true;
            this.lbGenerate.Location = new System.Drawing.Point(10, 260);
            this.lbGenerate.Name = "lbGenerate";
            this.lbGenerate.Size = new System.Drawing.Size(129, 15);
            this.lbGenerate.TabIndex = 6;
            this.lbGenerate.TabStop = true;
            this.lbGenerate.Text = "Generating the QrCode";
            this.lbGenerate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbGenerate_LinkClicked);
            // 
            // DividingQrCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DividingQrCode";
            this.Size = new System.Drawing.Size(606, 333);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PropertyGrid _settings;
        private System.Windows.Forms.FlowLayoutPanel _panel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox _range;
        private System.Windows.Forms.Label _symbols;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _sourceText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lbGenerate;
    }
}
