namespace FlexGridExplorer.Samples
{
    partial class ColumnEditor
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColumnEditor));
            imageList1 = new System.Windows.Forms.ImageList(components);
            c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            c1Combo1 = new C1.Win.List.C1Combo();
            flexTextBox1 = new FlexGridExplorer.Samples.ColumnEditors.FlexTextBox();
            c1SuperTooltip1 = new C1.Win.SuperTooltip.C1SuperTooltip(components);
            c1NumericEdit1 = new C1.Win.Input.C1NumericEdit();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tsProperties = new System.Windows.Forms.ToolStrip();
            addNewLb = new System.Windows.Forms.ToolStripLabel();
            addNewBtn = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            keyActionLb = new System.Windows.Forms.ToolStripLabel();
            keyActionCb = new System.Windows.Forms.ToolStripComboBox();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            showBtnsLb = new System.Windows.Forms.ToolStripLabel();
            showBtnsCb = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1Combo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1NumericEdit1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tsProperties.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "Argentina.png");
            imageList1.Images.SetKeyName(1, "Austria.png");
            imageList1.Images.SetKeyName(2, "Belgium.png");
            imageList1.Images.SetKeyName(3, "Brazil.png");
            imageList1.Images.SetKeyName(4, "Canada.png");
            imageList1.Images.SetKeyName(5, "Denmark.png");
            imageList1.Images.SetKeyName(6, "Finland.png");
            imageList1.Images.SetKeyName(7, "France.png");
            imageList1.Images.SetKeyName(8, "Germany.png");
            imageList1.Images.SetKeyName(9, "Ireland.png");
            imageList1.Images.SetKeyName(10, "Italy.png");
            imageList1.Images.SetKeyName(11, "Mexico.png");
            imageList1.Images.SetKeyName(12, "Norway.png");
            imageList1.Images.SetKeyName(13, "Poland.png");
            imageList1.Images.SetKeyName(14, "Portugal.png");
            imageList1.Images.SetKeyName(15, "Spain.png");
            imageList1.Images.SetKeyName(16, "Sweden.png");
            imageList1.Images.SetKeyName(17, "Switzerland.png");
            imageList1.Images.SetKeyName(18, "UK.png");
            imageList1.Images.SetKeyName(19, "USA.png");
            imageList1.Images.SetKeyName(20, "progress.png");
            // 
            // c1FlexGrid1
            // 
            c1FlexGrid1.AllowDragging = C1.Win.FlexGrid.AllowDraggingEnum.Rows;
            c1FlexGrid1.AllowResizing = C1.Win.FlexGrid.AllowResizingEnum.Both;
            c1FlexGrid1.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:28;}\t";
            c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            c1FlexGrid1.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw;
            c1FlexGrid1.KeyActionTab = C1.Win.FlexGrid.KeyActionEnum.MoveAcrossOut;
            c1FlexGrid1.Location = new System.Drawing.Point(5, 63);
            c1FlexGrid1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            c1FlexGrid1.Name = "c1FlexGrid1";
            c1FlexGrid1.NewRowWatermark = "Click to add new row";
            c1FlexGrid1.Size = new System.Drawing.Size(1406, 928);
            c1FlexGrid1.TabIndex = 6;
            c1FlexGrid1.SetupEditor += c1FlexGrid1_SetupEditor;
            c1FlexGrid1.OwnerDrawCell += c1FlexGrid1_OwnerDrawCell;
            c1FlexGrid1.MouseDown += c1FlexGrid1_MouseDown;
            c1FlexGrid1.MouseMove += c1FlexGrid1_MouseMove;
            // 
            // c1Combo1
            // 
            c1Combo1.Caption = "";
            c1Combo1.CaptionHeight = 17;
            c1Combo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            c1Combo1.ColumnCaptionHeight = 17;
            c1Combo1.ColumnFooterHeight = 17;
            c1Combo1.DataMode = C1.Win.List.DataModeEnum.AddItem;
            c1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty;
            c1Combo1.EditorBorderColor = System.Drawing.SystemColors.ControlDarkDark;
            c1Combo1.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            c1Combo1.ItemHeight = 25;
            c1Combo1.Location = new System.Drawing.Point(52, 658);
            c1Combo1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            c1Combo1.MatchEntryTimeout = 2000L;
            c1Combo1.MaxDropDownItems = 5;
            c1Combo1.MaxLength = 32767;
            c1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default;
            c1Combo1.Name = "c1Combo1";
            c1Combo1.PropBag = resources.GetString("c1Combo1.PropBag");
            c1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            c1Combo1.Size = new System.Drawing.Size(202, 26);
            c1Combo1.TabIndex = 3;
            c1Combo1.Text = "c1Combo1";
            // 
            // flexTextBox1
            // 
            flexTextBox1.BackColor = System.Drawing.Color.White;
            flexTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            flexTextBox1.Location = new System.Drawing.Point(52, 590);
            flexTextBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            flexTextBox1.MinimumSize = new System.Drawing.Size(197, 35);
            flexTextBox1.Multiline = true;
            flexTextBox1.Name = "flexTextBox1";
            flexTextBox1.Size = new System.Drawing.Size(197, 35);
            flexTextBox1.TabIndex = 5;
            // 
            // c1SuperTooltip1
            // 
            c1SuperTooltip1.Font = new System.Drawing.Font("Tahoma", 8F);
            c1SuperTooltip1.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            // 
            // c1NumericEdit1
            // 
            c1NumericEdit1.Location = new System.Drawing.Point(52, 710);
            c1NumericEdit1.Name = "c1NumericEdit1";
            c1NumericEdit1.Size = new System.Drawing.Size(333, 33);
            c1NumericEdit1.TabIndex = 4;
            c1NumericEdit1.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tsProperties, 0, 0);
            tableLayoutPanel1.Controls.Add(c1FlexGrid1, 0, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1416, 997);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // tsProperties
            // 
            tsProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            tsProperties.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            tsProperties.ImageScalingSize = new System.Drawing.Size(24, 24);
            tsProperties.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { addNewLb, addNewBtn, toolStripSeparator1, keyActionLb, keyActionCb, toolStripSeparator2, showBtnsLb, showBtnsCb });
            tsProperties.Location = new System.Drawing.Point(0, 0);
            tsProperties.Name = "tsProperties";
            tsProperties.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            tsProperties.Size = new System.Drawing.Size(1416, 57);
            tsProperties.TabIndex = 7;
            tsProperties.Text = "Properties";
            // 
            // addNewLb
            // 
            addNewLb.Name = "addNewLb";
            addNewLb.Size = new System.Drawing.Size(135, 52);
            addNewLb.Text = "Allow Add New";
            // 
            // addNewBtn
            // 
            addNewBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            addNewBtn.Image = (System.Drawing.Image)resources.GetObject("addNewBtn.Image");
            addNewBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            addNewBtn.Name = "addNewBtn";
            addNewBtn.Size = new System.Drawing.Size(34, 52);
            addNewBtn.Text = "toolStripButton1";
            addNewBtn.Click += addNewBtn_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // keyActionLb
            // 
            keyActionLb.Name = "keyActionLb";
            keyActionLb.Size = new System.Drawing.Size(128, 52);
            keyActionLb.Text = "Key Action Tab";
            // 
            // keyActionCb
            // 
            keyActionCb.Name = "keyActionCb";
            keyActionCb.Size = new System.Drawing.Size(171, 57);
            keyActionCb.SelectedIndexChanged += KeyActionCb_SelectedIndexChanged;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 57);
            // 
            // showBtnsLb
            // 
            showBtnsLb.Name = "showBtnsLb";
            showBtnsLb.Size = new System.Drawing.Size(122, 52);
            showBtnsLb.Text = "Show Buttons";
            // 
            // showBtnsCb
            // 
            showBtnsCb.Name = "showBtnsCb";
            showBtnsCb.Size = new System.Drawing.Size(171, 57);
            showBtnsCb.SelectedIndexChanged += ShowBtnsCb_SelectedIndexChanged;
            // 
            // ColumnEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flexTextBox1);
            Controls.Add(c1NumericEdit1);
            Controls.Add(c1Combo1);
            Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            Name = "ColumnEditor";
            Size = new System.Drawing.Size(1416, 997);
            Load += ColumnEditor_Load;
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1Combo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1NumericEdit1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tsProperties.ResumeLayout(false);
            tsProperties.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        private FlexGridExplorer.Samples.ColumnEditors.FlexTextBox flexTextBox1;
        private C1.Win.SuperTooltip.C1SuperTooltip c1SuperTooltip1;
        private C1.Win.Input.C1NumericEdit c1NumericEdit1;
        private C1.Win.List.C1Combo c1Combo1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip tsProperties;
        private System.Windows.Forms.ToolStripLabel addNewLb;
        private System.Windows.Forms.ToolStripButton addNewBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel keyActionLb;
        private System.Windows.Forms.ToolStripComboBox keyActionCb;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel showBtnsLb;
        private System.Windows.Forms.ToolStripComboBox showBtnsCb;
    }
}
