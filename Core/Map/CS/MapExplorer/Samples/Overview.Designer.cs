
namespace MapExplorer.Samples
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
            _panel = new System.Windows.Forms.TableLayoutPanel();
            SuspendLayout();
            // 
            // _panel
            // 
            _panel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            _panel.ColumnCount = 1;
            _panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            _panel.Dock = System.Windows.Forms.DockStyle.Fill;
            _panel.Location = new System.Drawing.Point(0, 0);
            _panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            _panel.Name = "_panel";
            _panel.RowCount = 1;
            _panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            _panel.Size = new System.Drawing.Size(487, 473);
            _panel.TabIndex = 3;
            // 
            // Overview
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            Controls.Add(_panel);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Overview";
            Size = new System.Drawing.Size(487, 473);
            Load += Overview_Load;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _panel;
    }
}
