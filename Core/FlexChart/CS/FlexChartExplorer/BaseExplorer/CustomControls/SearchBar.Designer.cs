using C1.Framework.Extension;
using System.Drawing;
using System.Windows.Forms;

namespace BaseExplorer.CustomControls
{
    partial class SearchBar
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSearch = new PictureBox();
            textBoxExSearch = new TextBoxEx();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSearch).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(btnSearch, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxExSearch, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(360, 70);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = System.Drawing.Color.White;
            btnSearch.Image = Properties.Resources.Search_black;
            btnSearch.Location = new System.Drawing.Point(324, 17);
            btnSearch.Margin = new Padding(7, 17, 7, 7);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(29, 33);
            btnSearch.SizeMode = PictureBoxSizeMode.Zoom;
            btnSearch.TabIndex = 0;
            btnSearch.TabStop = false;
            btnSearch.Text = " ";
            // 
            // textBoxExSearch
            // 
            textBoxExSearch.BackColor = System.Drawing.Color.White;
            textBoxExSearch.BorderStyle = BorderStyle.None;
            textBoxExSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBoxExSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            textBoxExSearch.Location = new System.Drawing.Point(13, 13);
            textBoxExSearch.Margin = new Padding(13, 13, 3, 3);
            textBoxExSearch.Name = "textBoxExSearch";
            textBoxExSearch.Placeholder = "Search";
            textBoxExSearch.Size = new System.Drawing.Size(301, 32);
            textBoxExSearch.TabIndex = 1;
            // 
            // SearchBar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "SearchBar";
            Size = new System.Drawing.Size(360, 70);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnSearch).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TextBoxEx textBoxExSearch;
        private PictureBox btnSearch;
    }
}
