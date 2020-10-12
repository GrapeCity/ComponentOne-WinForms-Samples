namespace ControlExplorer.FlexGrid
{
    partial class ColumnCellTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColumnCellTypes));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.c1Combo1 = new C1.Win.C1List.C1Combo();
            this.c1NumericEdit1 = new C1.Win.C1Input.C1NumericEdit();
            this.c1SuperTooltip1 = new C1.Win.C1SuperTooltip.C1SuperTooltip(this.components);
            this.flexTextBox1 = new ControlExplorer.FlexGrid.CustomEditors.FlexTextBox();
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Argentina.png");
            this.imageList1.Images.SetKeyName(1, "Austria.png");
            this.imageList1.Images.SetKeyName(2, "Belgium.png");
            this.imageList1.Images.SetKeyName(3, "Brazil.png");
            this.imageList1.Images.SetKeyName(4, "Canada.png");
            this.imageList1.Images.SetKeyName(5, "Denmark.png");
            this.imageList1.Images.SetKeyName(6, "Finland.png");
            this.imageList1.Images.SetKeyName(7, "France.png");
            this.imageList1.Images.SetKeyName(8, "Germany.png");
            this.imageList1.Images.SetKeyName(9, "Ireland.png");
            this.imageList1.Images.SetKeyName(10, "Italy.png");
            this.imageList1.Images.SetKeyName(11, "Mexico.png");
            this.imageList1.Images.SetKeyName(12, "Norway.png");
            this.imageList1.Images.SetKeyName(13, "Poland.png");
            this.imageList1.Images.SetKeyName(14, "Portugal.png");
            this.imageList1.Images.SetKeyName(15, "Spain.png");
            this.imageList1.Images.SetKeyName(16, "Sweden.png");
            this.imageList1.Images.SetKeyName(17, "Switzerland.png");
            this.imageList1.Images.SetKeyName(18, "UK.png");
            this.imageList1.Images.SetKeyName(19, "USA.png");
            this.imageList1.Images.SetKeyName(20, "progress.png");
            // 
            // c1Combo1
            // 
            this.c1Combo1.AddItemSeparator = ';';
            this.c1Combo1.Caption = "";
            this.c1Combo1.CaptionHeight = 17;
            this.c1Combo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.c1Combo1.ColumnCaptionHeight = 17;
            this.c1Combo1.ColumnFooterHeight = 17;
            this.c1Combo1.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            this.c1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.c1Combo1.EditorBackColor = System.Drawing.SystemColors.Window;
            this.c1Combo1.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Combo1.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.c1Combo1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1Combo1.Images"))));
            this.c1Combo1.ItemHeight = 15;
            this.c1Combo1.Location = new System.Drawing.Point(31, 342);
            this.c1Combo1.MatchEntryTimeout = ((long)(2000));
            this.c1Combo1.MaxDropDownItems = ((short)(5));
            this.c1Combo1.MaxLength = 32767;
            this.c1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.c1Combo1.Name = "c1Combo1";
            this.c1Combo1.PropBag = resources.GetString("c1Combo1.PropBag");
            this.c1Combo1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.c1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1Combo1.Size = new System.Drawing.Size(121, 21);
            this.c1Combo1.TabIndex = 3;
            this.c1Combo1.Text = "c1Combo1";
            // 
            // c1NumericEdit1
            // 
            this.c1NumericEdit1.ImagePadding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.c1NumericEdit1.Location = new System.Drawing.Point(31, 369);
            this.c1NumericEdit1.Name = "c1NumericEdit1";
            this.c1NumericEdit1.Size = new System.Drawing.Size(200, 18);
            this.c1NumericEdit1.TabIndex = 4;
            this.c1NumericEdit1.Tag = null;
            // 
            // c1SuperTooltip1
            // 
            this.c1SuperTooltip1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.c1SuperTooltip1.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            // 
            // flexTextBox1
            // 
            this.flexTextBox1.BackColor = System.Drawing.Color.White;
            this.flexTextBox1.Location = new System.Drawing.Point(31, 307);
            this.flexTextBox1.MinimumSize = new System.Drawing.Size(120, 20);
            this.flexTextBox1.Multiline = true;
            this.flexTextBox1.Name = "flexTextBox1";
            this.flexTextBox1.Size = new System.Drawing.Size(120, 20);
            this.flexTextBox1.TabIndex = 5;
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Rows;
            this.c1FlexGrid1.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.c1FlexGrid1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:28;}\t";
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
            this.c1FlexGrid1.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.NewRowWatermark = "Click to add new row";
            this.c1FlexGrid1.Rows.Count = 1;
            this.c1FlexGrid1.Rows.DefaultSize = 22;
            this.c1FlexGrid1.Rows.MinSize = 21;
            this.c1FlexGrid1.Size = new System.Drawing.Size(592, 446);
            this.c1FlexGrid1.StyleInfo = resources.GetString("c1FlexGrid1.StyleInfo");
            this.c1FlexGrid1.TabIndex = 6;
            // 
            // ColumnCellTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this.c1FlexGrid1);
            this.Controls.Add(this.flexTextBox1);
            this.Controls.Add(this.c1NumericEdit1);
            this.Controls.Add(this.c1Combo1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ColumnCellTypes";
            this.Text = "ColumnCellTypes";
            this.Load += new System.EventHandler(this.ColumnCellTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private C1.Win.C1List.C1Combo c1Combo1;
        private C1.Win.C1Input.C1NumericEdit c1NumericEdit1;
        private C1.Win.C1SuperTooltip.C1SuperTooltip c1SuperTooltip1;
        private ControlExplorer.FlexGrid.CustomEditors.FlexTextBox flexTextBox1;
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
    }
}