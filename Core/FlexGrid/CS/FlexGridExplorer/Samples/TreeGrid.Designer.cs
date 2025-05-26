namespace FlexGridExplorer.Samples
{
    partial class TreeGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeGrid));
            flex = new C1.Win.FlexGrid.C1FlexGrid();
            c1ToolBar1 = new C1.Win.Command.C1ToolBar();
            c1CommandHolder1 = new C1.Win.Command.C1CommandHolder();
            c1CommandSortAsc = new C1.Win.Command.C1Command();
            c1CommandSortDesc = new C1.Win.Command.C1Command();
            c1CommandAddChild = new C1.Win.Command.C1Command();
            c1CommandDelete = new C1.Win.Command.C1Command();
            c1CommandInsertItem = new C1.Win.Command.C1Command();
            c1CommandAppendItem = new C1.Win.Command.C1Command();
            c1CommandMoveLeft = new C1.Win.Command.C1Command();
            c1CommandMoveUp = new C1.Win.Command.C1Command();
            c1CommandMoveDown = new C1.Win.Command.C1Command();
            c1CommandMoveRight = new C1.Win.Command.C1Command();
            c1CommandPrint = new C1.Win.Command.C1Command();
            c1CommandInsertBelow = new C1.Win.Command.C1Command();
            c1CommandExpand = new C1.Win.Command.C1Command();
            c1CommandCollapse = new C1.Win.Command.C1Command();
            c1CommandLink8 = new C1.Win.Command.C1CommandLink();
            c1CommandLink9 = new C1.Win.Command.C1CommandLink();
            c1CommandLink7 = new C1.Win.Command.C1CommandLink();
            c1CommandLink10 = new C1.Win.Command.C1CommandLink();
            c1CommandLink3 = new C1.Win.Command.C1CommandLink();
            c1CommandLink5 = new C1.Win.Command.C1CommandLink();
            c1CommandLink12 = new C1.Win.Command.C1CommandLink();
            c1CommandLink6 = new C1.Win.Command.C1CommandLink();
            c1CommandLink4 = new C1.Win.Command.C1CommandLink();
            c1CommandLink1 = new C1.Win.Command.C1CommandLink();
            c1CommandLink2 = new C1.Win.Command.C1CommandLink();
            c1CommandLink13 = new C1.Win.Command.C1CommandLink();
            c1CommandLink14 = new C1.Win.Command.C1CommandLink();
            c1CommandLink11 = new C1.Win.Command.C1CommandLink();
            imageList1 = new System.Windows.Forms.ImageList(components);
            panel1 = new System.Windows.Forms.Panel();
            chbUseCheckBox = new C1.Win.Input.C1CheckBox();
            chbAllowDragging = new C1.Win.Input.C1CheckBox();
            cbFocusRect = new C1.Win.Input.C1ComboBox();
            c1Label3 = new C1.Win.Input.C1Label();
            cbLineStyle = new C1.Win.Input.C1ComboBox();
            c1Label2 = new C1.Win.Input.C1Label();
            cbStyle = new C1.Win.Input.C1ComboBox();
            c1Label1 = new C1.Win.Input.C1Label();
            ((System.ComponentModel.ISupportInitialize)flex).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1CommandHolder1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chbUseCheckBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chbAllowDragging).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbFocusRect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1Label3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbLineStyle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1Label2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbStyle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1Label1).BeginInit();
            SuspendLayout();
            // 
            // flex
            // 
            flex.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            flex.Dock = System.Windows.Forms.DockStyle.Fill;
            flex.Location = new System.Drawing.Point(0, 78);
            flex.Name = "flex";
            flex.Size = new System.Drawing.Size(1100, 664);
            flex.TabIndex = 0;
            flex.DoubleClick += flex_DoubleClick;
            flex.MouseDown += flex_MouseDown;
            flex.MouseMove += flex_MouseMove;
            flex.MouseUp += flex_MouseUp;
            // 
            // c1ToolBar1
            // 
            c1ToolBar1.AccessibleName = "Tool Bar";
            c1ToolBar1.AutoSize = false;
            c1ToolBar1.CommandHolder = c1CommandHolder1;
            c1ToolBar1.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] { c1CommandLink8, c1CommandLink9, c1CommandLink7, c1CommandLink10, c1CommandLink3, c1CommandLink5, c1CommandLink12, c1CommandLink6, c1CommandLink4, c1CommandLink1, c1CommandLink2, c1CommandLink13, c1CommandLink14, c1CommandLink11 });
            c1ToolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            c1ToolBar1.Location = new System.Drawing.Point(0, 0);
            c1ToolBar1.Movable = false;
            c1ToolBar1.Name = "c1ToolBar1";
            c1ToolBar1.Size = new System.Drawing.Size(1100, 36);
            c1ToolBar1.Text = "c1ToolBar1";
            // 
            // c1CommandHolder1
            // 
            c1CommandHolder1.Commands.Add(c1CommandSortAsc);
            c1CommandHolder1.Commands.Add(c1CommandSortDesc);
            c1CommandHolder1.Commands.Add(c1CommandAddChild);
            c1CommandHolder1.Commands.Add(c1CommandDelete);
            c1CommandHolder1.Commands.Add(c1CommandInsertItem);
            c1CommandHolder1.Commands.Add(c1CommandAppendItem);
            c1CommandHolder1.Commands.Add(c1CommandMoveLeft);
            c1CommandHolder1.Commands.Add(c1CommandMoveUp);
            c1CommandHolder1.Commands.Add(c1CommandMoveDown);
            c1CommandHolder1.Commands.Add(c1CommandMoveRight);
            c1CommandHolder1.Commands.Add(c1CommandPrint);
            c1CommandHolder1.Commands.Add(c1CommandInsertBelow);
            c1CommandHolder1.Commands.Add(c1CommandExpand);
            c1CommandHolder1.Commands.Add(c1CommandCollapse);
            c1CommandHolder1.Owner = this;
            c1CommandHolder1.CommandClick += c1CommandHolder1_CommandClick;
            // 
            // c1CommandSortAsc
            // 
            c1CommandSortAsc.Image = (System.Drawing.Image)resources.GetObject("c1CommandSortAsc.Image");
            c1CommandSortAsc.Name = "c1CommandSortAsc";
            c1CommandSortAsc.ShortcutText = "";
            c1CommandSortAsc.Text = "Sort Children Ascending";
            c1CommandSortAsc.Virgin = false;
            // 
            // c1CommandSortDesc
            // 
            c1CommandSortDesc.Image = (System.Drawing.Image)resources.GetObject("c1CommandSortDesc.Image");
            c1CommandSortDesc.Name = "c1CommandSortDesc";
            c1CommandSortDesc.ShortcutText = "";
            c1CommandSortDesc.Text = "Sort Children Descending";
            c1CommandSortDesc.Virgin = false;
            // 
            // c1CommandAddChild
            // 
            c1CommandAddChild.Image = (System.Drawing.Image)resources.GetObject("c1CommandAddChild.Image");
            c1CommandAddChild.Name = "c1CommandAddChild";
            c1CommandAddChild.ShortcutText = "";
            c1CommandAddChild.Text = "Add Child";
            c1CommandAddChild.Virgin = false;
            // 
            // c1CommandDelete
            // 
            c1CommandDelete.Image = (System.Drawing.Image)resources.GetObject("c1CommandDelete.Image");
            c1CommandDelete.Name = "c1CommandDelete";
            c1CommandDelete.ShortcutText = "";
            c1CommandDelete.Text = "Delete";
            c1CommandDelete.Virgin = false;
            // 
            // c1CommandInsertItem
            // 
            c1CommandInsertItem.Image = (System.Drawing.Image)resources.GetObject("c1CommandInsertItem.Image");
            c1CommandInsertItem.Name = "c1CommandInsertItem";
            c1CommandInsertItem.ShortcutText = "";
            c1CommandInsertItem.Text = "Insert Item Above";
            c1CommandInsertItem.Virgin = false;
            // 
            // c1CommandAppendItem
            // 
            c1CommandAppendItem.Image = (System.Drawing.Image)resources.GetObject("c1CommandAppendItem.Image");
            c1CommandAppendItem.Name = "c1CommandAppendItem";
            c1CommandAppendItem.ShortcutText = "";
            c1CommandAppendItem.Text = "Append Item";
            c1CommandAppendItem.Virgin = false;
            // 
            // c1CommandMoveLeft
            // 
            c1CommandMoveLeft.Image = (System.Drawing.Image)resources.GetObject("c1CommandMoveLeft.Image");
            c1CommandMoveLeft.Name = "c1CommandMoveLeft";
            c1CommandMoveLeft.ShortcutText = "";
            c1CommandMoveLeft.Text = "Move Item to Parent";
            c1CommandMoveLeft.Virgin = false;
            // 
            // c1CommandMoveUp
            // 
            c1CommandMoveUp.Image = (System.Drawing.Image)resources.GetObject("c1CommandMoveUp.Image");
            c1CommandMoveUp.Name = "c1CommandMoveUp";
            c1CommandMoveUp.ShortcutText = "";
            c1CommandMoveUp.Text = "Move Item Up";
            c1CommandMoveUp.Virgin = false;
            // 
            // c1CommandMoveDown
            // 
            c1CommandMoveDown.Image = (System.Drawing.Image)resources.GetObject("c1CommandMoveDown.Image");
            c1CommandMoveDown.Name = "c1CommandMoveDown";
            c1CommandMoveDown.ShortcutText = "";
            c1CommandMoveDown.Text = "Move Item Down";
            c1CommandMoveDown.Virgin = false;
            // 
            // c1CommandMoveRight
            // 
            c1CommandMoveRight.Image = (System.Drawing.Image)resources.GetObject("c1CommandMoveRight.Image");
            c1CommandMoveRight.Name = "c1CommandMoveRight";
            c1CommandMoveRight.ShortcutText = "";
            c1CommandMoveRight.Text = "Move Item to Child";
            c1CommandMoveRight.Virgin = false;
            // 
            // c1CommandPrint
            // 
            c1CommandPrint.Image = (System.Drawing.Image)resources.GetObject("c1CommandPrint.Image");
            c1CommandPrint.Name = "c1CommandPrint";
            c1CommandPrint.ShortcutText = "";
            c1CommandPrint.Text = "Print";
            c1CommandPrint.Virgin = false;
            // 
            // c1CommandInsertBelow
            // 
            c1CommandInsertBelow.Image = (System.Drawing.Image)resources.GetObject("c1CommandInsertBelow.Image");
            c1CommandInsertBelow.Name = "c1CommandInsertBelow";
            c1CommandInsertBelow.ShortcutText = "";
            c1CommandInsertBelow.Text = "Insert Item Below";
            c1CommandInsertBelow.Virgin = false;
            // 
            // c1CommandExpand
            // 
            c1CommandExpand.Image = (System.Drawing.Image)resources.GetObject("c1CommandExpand.Image");
            c1CommandExpand.Name = "c1CommandExpand";
            c1CommandExpand.ShortcutText = "";
            c1CommandExpand.Text = "Expand All";
            c1CommandExpand.Virgin = false;
            // 
            // c1CommandCollapse
            // 
            c1CommandCollapse.Image = (System.Drawing.Image)resources.GetObject("c1CommandCollapse.Image");
            c1CommandCollapse.Name = "c1CommandCollapse";
            c1CommandCollapse.ShortcutText = "";
            c1CommandCollapse.Text = "Collapse All";
            c1CommandCollapse.Virgin = false;
            // 
            // c1CommandLink8
            // 
            c1CommandLink8.Command = c1CommandMoveUp;
            // 
            // c1CommandLink9
            // 
            c1CommandLink9.Command = c1CommandMoveDown;
            c1CommandLink9.SortOrder = 1;
            // 
            // c1CommandLink7
            // 
            c1CommandLink7.Command = c1CommandMoveLeft;
            c1CommandLink7.SortOrder = 2;
            // 
            // c1CommandLink10
            // 
            c1CommandLink10.Command = c1CommandMoveRight;
            c1CommandLink10.SortOrder = 3;
            // 
            // c1CommandLink3
            // 
            c1CommandLink3.Command = c1CommandAddChild;
            c1CommandLink3.Delimiter = true;
            c1CommandLink3.SortOrder = 4;
            // 
            // c1CommandLink5
            // 
            c1CommandLink5.Command = c1CommandInsertItem;
            c1CommandLink5.SortOrder = 5;
            // 
            // c1CommandLink12
            // 
            c1CommandLink12.Command = c1CommandInsertBelow;
            c1CommandLink12.SortOrder = 6;
            // 
            // c1CommandLink6
            // 
            c1CommandLink6.Command = c1CommandAppendItem;
            c1CommandLink6.SortOrder = 7;
            // 
            // c1CommandLink4
            // 
            c1CommandLink4.Command = c1CommandDelete;
            c1CommandLink4.SortOrder = 8;
            // 
            // c1CommandLink1
            // 
            c1CommandLink1.Command = c1CommandSortAsc;
            c1CommandLink1.Delimiter = true;
            c1CommandLink1.SortOrder = 9;
            // 
            // c1CommandLink2
            // 
            c1CommandLink2.Command = c1CommandSortDesc;
            c1CommandLink2.SortOrder = 10;
            // 
            // c1CommandLink13
            // 
            c1CommandLink13.Command = c1CommandExpand;
            c1CommandLink13.SortOrder = 11;
            // 
            // c1CommandLink14
            // 
            c1CommandLink14.Command = c1CommandCollapse;
            c1CommandLink14.SortOrder = 12;
            // 
            // c1CommandLink11
            // 
            c1CommandLink11.Command = c1CommandPrint;
            c1CommandLink11.Delimiter = true;
            c1CommandLink11.SortOrder = 13;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "Notepad1.png");
            imageList1.Images.SetKeyName(1, "Folder_closed.png");
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.Window;
            panel1.Controls.Add(chbUseCheckBox);
            panel1.Controls.Add(chbAllowDragging);
            panel1.Controls.Add(cbFocusRect);
            panel1.Controls.Add(c1Label3);
            panel1.Controls.Add(cbLineStyle);
            panel1.Controls.Add(c1Label2);
            panel1.Controls.Add(cbStyle);
            panel1.Controls.Add(c1Label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 36);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1100, 42);
            panel1.TabIndex = 2;
            // 
            // chbUseCheckBox
            // 
            chbUseCheckBox.AutoSize = true;
            chbUseCheckBox.Location = new System.Drawing.Point(754, 12);
            chbUseCheckBox.Name = "chbUseCheckBox";
            chbUseCheckBox.Size = new System.Drawing.Size(129, 22);
            chbUseCheckBox.TabIndex = 7;
            chbUseCheckBox.Text = "Use Check Box";
            chbUseCheckBox.CheckedChanged += chbUseCheckBox_CheckedChanged;
            // 
            // chbAllowDragging
            // 
            chbAllowDragging.AutoSize = true;
            chbAllowDragging.Checked = true;
            chbAllowDragging.CheckState = System.Windows.Forms.CheckState.Checked;
            chbAllowDragging.Location = new System.Drawing.Point(608, 11);
            chbAllowDragging.Name = "chbAllowDragging";
            chbAllowDragging.Size = new System.Drawing.Size(138, 22);
            chbAllowDragging.TabIndex = 6;
            chbAllowDragging.Text = "Allow Dragging";
            chbAllowDragging.Value = true;
            chbAllowDragging.CheckedChanged += chbAllowDragging_CheckedChanged;
            // 
            // cbFocusRect
            // 
            cbFocusRect.Location = new System.Drawing.Point(491, 8);
            cbFocusRect.Name = "cbFocusRect";
            cbFocusRect.Size = new System.Drawing.Size(116, 28);
            cbFocusRect.TabIndex = 5;
            cbFocusRect.Value = "";
            cbFocusRect.SelectedItemChanged += cbFocusRect_SelectedItemChanged;
            // 
            // c1Label3
            // 
            c1Label3.AutoSize = true;
            c1Label3.Location = new System.Drawing.Point(409, 9);
            c1Label3.Name = "c1Label3";
            c1Label3.Size = new System.Drawing.Size(81, 26);
            c1Label3.TabIndex = 4;
            c1Label3.Text = "FocusRect";
            // 
            // cbLineStyle
            // 
            cbLineStyle.Location = new System.Drawing.Point(290, 7);
            cbLineStyle.Name = "cbLineStyle";
            cbLineStyle.Size = new System.Drawing.Size(116, 28);
            cbLineStyle.TabIndex = 3;
            cbLineStyle.Value = "";
            cbLineStyle.SelectedItemChanged += cbLineStyle_SelectedItemChanged;
            // 
            // c1Label2
            // 
            c1Label2.AutoSize = true;
            c1Label2.Location = new System.Drawing.Point(214, 8);
            c1Label2.Name = "c1Label2";
            c1Label2.Size = new System.Drawing.Size(74, 26);
            c1Label2.TabIndex = 2;
            c1Label2.Text = "LineStyle";
            // 
            // cbStyle
            // 
            cbStyle.Location = new System.Drawing.Point(44, 7);
            cbStyle.Name = "cbStyle";
            cbStyle.Size = new System.Drawing.Size(168, 28);
            cbStyle.TabIndex = 1;
            cbStyle.Value = "";
            cbStyle.SelectedItemChanged += cbStyle_SelectedItemChanged;
            // 
            // c1Label1
            // 
            c1Label1.AutoSize = true;
            c1Label1.Location = new System.Drawing.Point(-4, 8);
            c1Label1.Name = "c1Label1";
            c1Label1.Size = new System.Drawing.Size(47, 26);
            c1Label1.TabIndex = 0;
            c1Label1.Text = "Style";
            // 
            // TreeGrid
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(flex);
            Controls.Add(panel1);
            Controls.Add(c1ToolBar1);
            Name = "TreeGrid";
            Size = new System.Drawing.Size(1100, 742);
            Load += NewTreeView_Load;
            ((System.ComponentModel.ISupportInitialize)flex).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1CommandHolder1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chbUseCheckBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)chbAllowDragging).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbFocusRect).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1Label3).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbLineStyle).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1Label2).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbStyle).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1Label1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGrid flex;
        private C1.Win.Command.C1ToolBar c1ToolBar1;
        private C1.Win.Command.C1CommandHolder c1CommandHolder1;
        private C1.Win.Command.C1Command c1CommandSortAsc;
        private C1.Win.Command.C1Command c1CommandSortDesc;
        private C1.Win.Command.C1Command c1CommandAddChild;
        private C1.Win.Command.C1Command c1CommandDelete;
        private C1.Win.Command.C1Command c1CommandInsertItem;
        private C1.Win.Command.C1Command c1CommandAppendItem;
        private C1.Win.Command.C1Command c1CommandMoveLeft;
        private C1.Win.Command.C1Command c1CommandMoveUp;
        private C1.Win.Command.C1Command c1CommandMoveDown;
        private C1.Win.Command.C1Command c1CommandMoveRight;
        private C1.Win.Command.C1Command c1CommandPrint;
        private C1.Win.Command.C1Command c1CommandInsertBelow;
        private C1.Win.Command.C1Command c1CommandExpand;
        private C1.Win.Command.C1Command c1CommandCollapse;
        private C1.Win.Command.C1CommandLink c1CommandLink8;
        private C1.Win.Command.C1CommandLink c1CommandLink9;
        private C1.Win.Command.C1CommandLink c1CommandLink7;
        private C1.Win.Command.C1CommandLink c1CommandLink10;
        private C1.Win.Command.C1CommandLink c1CommandLink3;
        private C1.Win.Command.C1CommandLink c1CommandLink5;
        private C1.Win.Command.C1CommandLink c1CommandLink12;
        private C1.Win.Command.C1CommandLink c1CommandLink6;
        private C1.Win.Command.C1CommandLink c1CommandLink4;
        private C1.Win.Command.C1CommandLink c1CommandLink1;
        private C1.Win.Command.C1CommandLink c1CommandLink2;
        private C1.Win.Command.C1CommandLink c1CommandLink13;
        private C1.Win.Command.C1CommandLink c1CommandLink14;
        private C1.Win.Command.C1CommandLink c1CommandLink11;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.Input.C1ComboBox cbLineStyle;
        private C1.Win.Input.C1Label c1Label2;
        private C1.Win.Input.C1ComboBox cbStyle;
        private C1.Win.Input.C1Label c1Label1;
        private C1.Win.Input.C1CheckBox chbUseCheckBox;
        private C1.Win.Input.C1CheckBox chbAllowDragging;
        private C1.Win.Input.C1ComboBox cbFocusRect;
        private C1.Win.Input.C1Label c1Label3;
    }
}
