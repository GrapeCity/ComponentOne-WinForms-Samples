namespace GridRenderer
{
    partial class RendererEditor
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Normal");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Selected");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Hot");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Selected Hot");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Column Headers", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Normal");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Selected");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Hot");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Selected Hot");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Row Headers", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Cell");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Image");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Top Left Cell", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Selection");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Automatic");
            this._btnOK = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.office2007BlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.office2007BlackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.office2007SilverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._tree = new System.Windows.Forms.TreeView();
            this._flex = new C1.Win.C1FlexGrid.C1FlexGrid();
            this._panelAuto = new System.Windows.Forms.Panel();
            this._clrHighlights = new ColorPicker();
            this.label4 = new System.Windows.Forms.Label();
            this._clrMain = new ColorPicker();
            this.label6 = new System.Windows.Forms.Label();
            this._panelBorder = new System.Windows.Forms.Panel();
            this._clrBorder = new ColorPicker();
            this.label3 = new System.Windows.Forms.Label();
            this._panelGradient = new System.Windows.Forms.Panel();
            this._clrGradEnd = new ColorPicker();
            this.label2 = new System.Windows.Forms.Label();
            this._clrGradStart = new ColorPicker();
            this.label5 = new System.Windows.Forms.Label();
            this._panelSolid = new System.Windows.Forms.Panel();
            this._clrSolid = new ColorPicker();
            this.label1 = new System.Windows.Forms.Label();
            this._menu.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this._panelAuto.SuspendLayout();
            this._panelBorder.SuspendLayout();
            this._panelGradient.SuspendLayout();
            this._panelSolid.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnOK
            // 
            this._btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnOK.Location = new System.Drawing.Point(278, 279);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(102, 27);
            this._btnOK.TabIndex = 1;
            this._btnOK.Text = "OK";
            this._btnOK.UseVisualStyleBackColor = true;
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(383, 279);
            this._btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(102, 27);
            this._btnCancel.TabIndex = 2;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            // 
            // _menu
            // 
            this._menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this._menu.Location = new System.Drawing.Point(0, 0);
            this._menu.Name = "_menu";
            this._menu.Size = new System.Drawing.Size(494, 24);
            this._menu.TabIndex = 0;
            this._menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.office2007BlueToolStripMenuItem,
            this.office2007BlackToolStripMenuItem,
            this.office2007SilverToolStripMenuItem});
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.standardToolStripMenuItem.Text = "&Default Renderers";
            this.standardToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.standardToolStripMenuItem_DropDownItemClicked);
            // 
            // office2007BlueToolStripMenuItem
            // 
            this.office2007BlueToolStripMenuItem.Name = "office2007BlueToolStripMenuItem";
            this.office2007BlueToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.office2007BlueToolStripMenuItem.Text = "Office 2007 Blue";
            // 
            // office2007BlackToolStripMenuItem
            // 
            this.office2007BlackToolStripMenuItem.Name = "office2007BlackToolStripMenuItem";
            this.office2007BlackToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.office2007BlackToolStripMenuItem.Text = "Office 2007 Black";
            // 
            // office2007SilverToolStripMenuItem
            // 
            this.office2007SilverToolStripMenuItem.Name = "office2007SilverToolStripMenuItem";
            this.office2007SilverToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.office2007SilverToolStripMenuItem.Text = "Office 2007 Silver";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(164, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(164, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._tree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._flex);
            this.splitContainer1.Panel2.Controls.Add(this._panelAuto);
            this.splitContainer1.Panel2.Controls.Add(this._panelBorder);
            this.splitContainer1.Panel2.Controls.Add(this._panelGradient);
            this.splitContainer1.Panel2.Controls.Add(this._panelSolid);
            this.splitContainer1.Size = new System.Drawing.Size(494, 248);
            this.splitContainer1.SplitterDistance = 164;
            this.splitContainer1.TabIndex = 7;
            // 
            // _tree
            // 
            this._tree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tree.HideSelection = false;
            this._tree.Location = new System.Drawing.Point(0, 0);
            this._tree.Name = "_tree";
            treeNode1.Name = "_ndColHdrNormal";
            treeNode1.Text = "Normal";
            treeNode1.ToolTipText = "Column headers in their normal state.";
            treeNode2.Name = "_ndColHdrSelected";
            treeNode2.Text = "Selected";
            treeNode2.ToolTipText = "Column headers when they contain the selection.";
            treeNode3.Name = "_ndColHdrHot";
            treeNode3.Text = "Hot";
            treeNode3.ToolTipText = "Column headers under the mouse .";
            treeNode4.Name = "_ndColHdrSelectedHot";
            treeNode4.Text = "Selected Hot";
            treeNode4.ToolTipText = "Column headers that contain the selection while under the mouse.";
            treeNode5.Name = "_ndColHdr";
            treeNode5.Tag = "*";
            treeNode5.Text = "Column Headers";
            treeNode6.Name = "_ndRowHdrNormal";
            treeNode6.Text = "Normal";
            treeNode6.ToolTipText = "Row headers in their normal state.";
            treeNode7.Name = "_ndRowHdrSelected";
            treeNode7.Text = "Selected";
            treeNode8.Name = "_ndRowHdrHot";
            treeNode8.Text = "Hot";
            treeNode8.ToolTipText = "Row headers under the mouse.";
            treeNode9.Name = "_ndRowHdrSelectedHot";
            treeNode9.Text = "Selected Hot";
            treeNode9.ToolTipText = "Row headers that contain the selection while under the mouse.";
            treeNode10.Name = "_ndRowHdr";
            treeNode10.Tag = "*";
            treeNode10.Text = "Row Headers";
            treeNode10.ToolTipText = "Row headers when they contain the selection.";
            treeNode11.Name = "_ndCell";
            treeNode11.Text = "Cell";
            treeNode11.ToolTipText = "Cell that appears at the top left corner of the grid.";
            treeNode12.Name = "_ndImage";
            treeNode12.Text = "Image";
            treeNode12.ToolTipText = "Colors used to paint the image located in the top left cell of the grid.";
            treeNode13.Name = "_ndTopLeftCell";
            treeNode13.Tag = "*";
            treeNode13.Text = "Top Left Cell";
            treeNode14.Name = "_ndSelection";
            treeNode14.Text = "Selection";
            treeNode14.ToolTipText = "Color used to highlight the selected cells.";
            treeNode15.Name = "_ndAutomatic";
            treeNode15.Text = "Automatic";
            treeNode15.ToolTipText = "Select two colors and generate all others automatically.";
            this._tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode10,
            treeNode13,
            treeNode14,
            treeNode15});
            this._tree.ShowNodeToolTips = true;
            this._tree.Size = new System.Drawing.Size(164, 248);
            this._tree.TabIndex = 2;
            this._tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this._tree_AfterSelect);
            this._tree.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this._tree_BeforeSelect);
            // 
            // _flex
            // 
            this._flex.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.Location = new System.Drawing.Point(0, 220);
            this._flex.Name = "_flex";
            this._flex.Rows.DefaultSize = 17;
            this._flex.Size = new System.Drawing.Size(326, 28);
            this._flex.TabIndex = 1;
            // 
            // _panelAuto
            // 
            this._panelAuto.Controls.Add(this._clrHighlights);
            this._panelAuto.Controls.Add(this.label4);
            this._panelAuto.Controls.Add(this._clrMain);
            this._panelAuto.Controls.Add(this.label6);
            this._panelAuto.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelAuto.Location = new System.Drawing.Point(0, 150);
            this._panelAuto.Name = "_panelAuto";
            this._panelAuto.Padding = new System.Windows.Forms.Padding(4);
            this._panelAuto.Size = new System.Drawing.Size(326, 70);
            this._panelAuto.TabIndex = 6;
            // 
            // _clrHighlights
            // 
            this._clrHighlights.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._clrHighlights.Color = System.Drawing.Color.Empty;
            this._clrHighlights.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this._clrHighlights.DropDownHeight = 1;
            this._clrHighlights.DropDownWidth = 1;
            this._clrHighlights.FormattingEnabled = true;
            this._clrHighlights.IntegralHeight = false;
            this._clrHighlights.Location = new System.Drawing.Point(101, 34);
            this._clrHighlights.Name = "_clrHighlights";
            this._clrHighlights.Size = new System.Drawing.Size(218, 21);
            this._clrHighlights.TabIndex = 3;
            this._clrHighlights.ColorChanged += new System.EventHandler(this._clrAuto_ColorChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "&Highlights:";
            // 
            // _clrMain
            // 
            this._clrMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._clrMain.Color = System.Drawing.Color.Empty;
            this._clrMain.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this._clrMain.DropDownHeight = 1;
            this._clrMain.DropDownWidth = 1;
            this._clrMain.FormattingEnabled = true;
            this._clrMain.IntegralHeight = false;
            this._clrMain.Location = new System.Drawing.Point(101, 7);
            this._clrMain.Name = "_clrMain";
            this._clrMain.Size = new System.Drawing.Size(218, 21);
            this._clrMain.TabIndex = 1;
            this._clrMain.ColorChanged += new System.EventHandler(this._clrAuto_ColorChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "&Main Color:";
            // 
            // _panelBorder
            // 
            this._panelBorder.Controls.Add(this._clrBorder);
            this._panelBorder.Controls.Add(this.label3);
            this._panelBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelBorder.Location = new System.Drawing.Point(0, 110);
            this._panelBorder.Name = "_panelBorder";
            this._panelBorder.Padding = new System.Windows.Forms.Padding(4);
            this._panelBorder.Size = new System.Drawing.Size(326, 40);
            this._panelBorder.TabIndex = 4;
            // 
            // _clrBorder
            // 
            this._clrBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._clrBorder.Color = System.Drawing.Color.Empty;
            this._clrBorder.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this._clrBorder.DropDownHeight = 1;
            this._clrBorder.DropDownWidth = 1;
            this._clrBorder.FormattingEnabled = true;
            this._clrBorder.IntegralHeight = false;
            this._clrBorder.Location = new System.Drawing.Point(101, 7);
            this._clrBorder.Name = "_clrBorder";
            this._clrBorder.Size = new System.Drawing.Size(218, 21);
            this._clrBorder.TabIndex = 1;
            this._clrBorder.ColorChanged += new System.EventHandler(this._clr_ColorChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "&Border:";
            // 
            // _panelGradient
            // 
            this._panelGradient.Controls.Add(this._clrGradEnd);
            this._panelGradient.Controls.Add(this.label2);
            this._panelGradient.Controls.Add(this._clrGradStart);
            this._panelGradient.Controls.Add(this.label5);
            this._panelGradient.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelGradient.Location = new System.Drawing.Point(0, 40);
            this._panelGradient.Name = "_panelGradient";
            this._panelGradient.Padding = new System.Windows.Forms.Padding(4);
            this._panelGradient.Size = new System.Drawing.Size(326, 70);
            this._panelGradient.TabIndex = 3;
            // 
            // _clrGradEnd
            // 
            this._clrGradEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._clrGradEnd.Color = System.Drawing.Color.Empty;
            this._clrGradEnd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this._clrGradEnd.DropDownHeight = 1;
            this._clrGradEnd.DropDownWidth = 1;
            this._clrGradEnd.FormattingEnabled = true;
            this._clrGradEnd.IntegralHeight = false;
            this._clrGradEnd.Location = new System.Drawing.Point(101, 34);
            this._clrGradEnd.Name = "_clrGradEnd";
            this._clrGradEnd.Size = new System.Drawing.Size(218, 21);
            this._clrGradEnd.TabIndex = 3;
            this._clrGradEnd.ColorChanged += new System.EventHandler(this._clr_ColorChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gradient &End:";
            // 
            // _clrGradStart
            // 
            this._clrGradStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._clrGradStart.Color = System.Drawing.Color.Empty;
            this._clrGradStart.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this._clrGradStart.DropDownHeight = 1;
            this._clrGradStart.DropDownWidth = 1;
            this._clrGradStart.FormattingEnabled = true;
            this._clrGradStart.IntegralHeight = false;
            this._clrGradStart.Location = new System.Drawing.Point(101, 7);
            this._clrGradStart.Name = "_clrGradStart";
            this._clrGradStart.Size = new System.Drawing.Size(218, 21);
            this._clrGradStart.TabIndex = 1;
            this._clrGradStart.ColorChanged += new System.EventHandler(this._clr_ColorChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gradient &Start:";
            // 
            // _panelSolid
            // 
            this._panelSolid.Controls.Add(this._clrSolid);
            this._panelSolid.Controls.Add(this.label1);
            this._panelSolid.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelSolid.Location = new System.Drawing.Point(0, 0);
            this._panelSolid.Name = "_panelSolid";
            this._panelSolid.Padding = new System.Windows.Forms.Padding(4);
            this._panelSolid.Size = new System.Drawing.Size(326, 40);
            this._panelSolid.TabIndex = 0;
            // 
            // _clrSolid
            // 
            this._clrSolid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._clrSolid.Color = System.Drawing.Color.Empty;
            this._clrSolid.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this._clrSolid.DropDownHeight = 1;
            this._clrSolid.DropDownWidth = 1;
            this._clrSolid.FormattingEnabled = true;
            this._clrSolid.IntegralHeight = false;
            this._clrSolid.Location = new System.Drawing.Point(101, 7);
            this._clrSolid.Name = "_clrSolid";
            this._clrSolid.Size = new System.Drawing.Size(218, 21);
            this._clrSolid.TabIndex = 1;
            this._clrSolid.ColorChanged += new System.EventHandler(this._clr_ColorChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Color:";
            // 
            // RendererEditor
            // 
            this.AcceptButton = this._btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(494, 314);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this._menu);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnOK);
            this.MainMenuStrip = this._menu;
            this.Name = "RendererEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Renderer";
            this._menu.ResumeLayout(false);
            this._menu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            this._panelAuto.ResumeLayout(false);
            this._panelAuto.PerformLayout();
            this._panelBorder.ResumeLayout(false);
            this._panelBorder.PerformLayout();
            this._panelGradient.ResumeLayout(false);
            this._panelGradient.PerformLayout();
            this._panelSolid.ResumeLayout(false);
            this._panelSolid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnOK;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.MenuStrip _menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem office2007BlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem office2007BlackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem office2007SilverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView _tree;
        private C1.Win.C1FlexGrid.C1FlexGrid _flex;
        private System.Windows.Forms.Panel _panelBorder;
        private ColorPicker _clrBorder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel _panelGradient;
        private ColorPicker _clrGradEnd;
        private System.Windows.Forms.Label label2;
        private ColorPicker _clrGradStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel _panelSolid;
        private ColorPicker _clrSolid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Panel _panelAuto;
        private ColorPicker _clrHighlights;
        private System.Windows.Forms.Label label4;
        private ColorPicker _clrMain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}