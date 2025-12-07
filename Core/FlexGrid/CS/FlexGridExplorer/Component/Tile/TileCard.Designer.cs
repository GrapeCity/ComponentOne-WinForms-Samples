using System.Drawing;
using System.Windows.Forms;

namespace FlexGridExplorer.Component.Tile
{
    partial class TileCard
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
            panel1 = new Panel();
            picBox = new C1.Win.Input.C1PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblCardName = new C1.Win.Input.C1Label();
            lblDesc = new C1.Win.Input.C1TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lblCardName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblDesc).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(picBox);
            panel1.Location = new Point(14, 6);
            panel1.Margin = new Padding(14, 6, 0, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(77, 116);
            panel1.TabIndex = 0;
            // 
            // picBox
            // 
            picBox.Location = new Point(4, 34);
            picBox.Margin = new Padding(0);
            picBox.Name = "picBox";
            picBox.Size = new Size(70, 48);
            picBox.TabIndex = 0;
            picBox.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblCardName);
            flowLayoutPanel1.Controls.Add(lblDesc);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(101, 9);
            flowLayoutPanel1.Margin = new Padding(10, 9, 10, 9);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(323, 112);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // lblCardName
            // 
            lblCardName.AutoSize = true;
            lblCardName.Dock = DockStyle.Fill;
            lblCardName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCardName.Location = new Point(3, 3);
            lblCardName.Name = "lblCardName";
            lblCardName.Size = new Size(307, 41);
            lblCardName.Styles.Default.BackColor = Color.White;
            lblCardName.Styles.Default.BorderColor = Color.White;
            lblCardName.Styles.Margins = new C1.Framework.Thickness(0, 5, 5, 5);
            lblCardName.TabIndex = 0;
            lblCardName.Text = "c1Label1";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = false;
            lblDesc.BorderStyle = BorderStyle.None;
            lblDesc.Enabled = false;
            lblDesc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesc.Location = new Point(5, 52);
            lblDesc.MaxLength = 80;
            lblDesc.MaxLineCount = 2;
            lblDesc.Multiline = true;
            lblDesc.Name = "lblDesc";
            lblDesc.ReadOnly = true;
            lblDesc.Size = new Size(303, 50);
            lblDesc.Styles.Border = new C1.Framework.Thickness(0, 0, 0, 0);
            lblDesc.Styles.Corners = new C1.Framework.Corners(0, 0, 0, 0);
            lblDesc.Styles.Default.BackColor = Color.White;
            lblDesc.Styles.Default.BorderColor = Color.White;
            lblDesc.Styles.Disabled.BackColor = Color.White;
            lblDesc.Styles.Disabled.BorderColor = Color.White;
            lblDesc.Styles.Disabled.ForeColor = SystemColors.ControlText;
            lblDesc.Styles.Focused.BorderColor = Color.White;
            lblDesc.Styles.Hot.BorderColor = Color.White;
            lblDesc.Styles.Margins = new C1.Framework.Thickness(5, 5, 5, 5);
            lblDesc.Styles.Padding = new C1.Framework.Thickness(5, 3, 3, 3);
            lblDesc.Styles.Readonly.BackColor = Color.White;
            lblDesc.Styles.Readonly.BorderColor = Color.White;
            lblDesc.TabIndex = 1;
            lblDesc.TrimStart = true;
            lblDesc.Value = "";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(434, 130);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += TableLayoutPanel1_Paint;
            // 
            // TileCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(7, 6, 7, 6);
            Name = "TileCard";
            Size = new Size(434, 130);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lblCardName).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblDesc).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private C1.Win.Input.C1PictureBox picBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private C1.Win.Input.C1Label lblCardName;
        private TableLayoutPanel tableLayoutPanel1;
        private C1.Win.Input.C1TextBox lblDesc;
    }
}
