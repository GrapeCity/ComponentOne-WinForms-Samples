using C1.Framework.Extension;
 using System.Windows.Forms;

namespace FlexGridExplorer.Component.Input
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
            textBoxExSearch = new TextBoxEx();
            btnSearch = new C1.Win.Input.C1Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSearch).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(textBoxExSearch, 0, 0);
            tableLayoutPanel1.Controls.Add(btnSearch, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(415, 42);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxExSearch
            // 
            textBoxExSearch.BackColor = System.Drawing.Color.White;
            textBoxExSearch.BorderStyle = BorderStyle.None;
            textBoxExSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBoxExSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            textBoxExSearch.Location = new System.Drawing.Point(9, 8);
            textBoxExSearch.Margin = new Padding(9, 8, 2, 2);
            textBoxExSearch.Name = "textBoxExSearch";
            textBoxExSearch.Size = new System.Drawing.Size(364, 22);
            textBoxExSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Location = new System.Drawing.Point(379, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(33, 33);
            btnSearch.Styles.Border = new C1.Framework.Thickness(0, 0, 0, 0);
            btnSearch.Styles.Hot.BackColor = System.Drawing.Color.FromArgb(233, 232, 232);
            btnSearch.Styles.HotPressed.BackColor = System.Drawing.Color.FromArgb(233, 232, 232);
            btnSearch.Styles.Pressed.BackColor = System.Drawing.Color.FromArgb(233, 232, 232);
            btnSearch.TabIndex = 2;
            btnSearch.TabStop = false;
            // 
            // SearchBar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Transparent;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "SearchBar";
            Size = new System.Drawing.Size(415, 42);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnSearch).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FlexGridExplorer.Component.Input.TextBoxEx textBoxExSearch;
        private C1.Win.Input.C1Button btnSearch;
    }
}
