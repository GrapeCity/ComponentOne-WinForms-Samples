namespace ControlExplorer.FlexGrid
{
    partial class TreeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeView));
            this.flex = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.c1ToolBar1 = new C1.Win.C1Command.C1ToolBar();
            this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
            this.c1CommandSortAsc = new C1.Win.C1Command.C1Command();
            this.c1CommandSortDesc = new C1.Win.C1Command.C1Command();
            this.c1CommandAddChild = new C1.Win.C1Command.C1Command();
            this.c1CommandDelete = new C1.Win.C1Command.C1Command();
            this.c1CommandInsertItem = new C1.Win.C1Command.C1Command();
            this.c1CommandAppendItem = new C1.Win.C1Command.C1Command();
            this.c1CommandMoveLeft = new C1.Win.C1Command.C1Command();
            this.c1CommandMoveUp = new C1.Win.C1Command.C1Command();
            this.c1CommandMoveDown = new C1.Win.C1Command.C1Command();
            this.c1CommandMoveRight = new C1.Win.C1Command.C1Command();
            this.c1CommandPrint = new C1.Win.C1Command.C1Command();
            this.c1CommandInsertBelow = new C1.Win.C1Command.C1Command();
            this.c1CommandExpand = new C1.Win.C1Command.C1Command();
            this.c1CommandCollapse = new C1.Win.C1Command.C1Command();
            this.c1CommandLink8 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink9 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink7 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink10 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink3 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink5 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink12 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink6 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink4 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink1 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink2 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink13 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink14 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink11 = new C1.Win.C1Command.C1CommandLink();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.flex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.SuspendLayout();
            // 
            // flex
            // 
            this.flex.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.flex.ColumnInfo = "4,1,0,0,0,85,Columns:";
            this.flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flex.Location = new System.Drawing.Point(0, 26);
            this.flex.Name = "flex";
            this.flex.Rows.DefaultSize = 17;
            this.flex.Size = new System.Drawing.Size(592, 420);
            this.flex.StyleInfo = resources.GetString("flex.StyleInfo");
            this.flex.TabIndex = 0;
            this.flex.DoubleClick += new System.EventHandler(this.flex_DoubleClick);
            this.flex.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flex_MouseDown);
            this.flex.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flex_MouseMove);
            this.flex.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flex_MouseUp);
            // 
            // c1ToolBar1
            // 
            this.c1ToolBar1.AccessibleName = "Tool Bar";
            this.c1ToolBar1.AutoSize = false;
            this.c1ToolBar1.CommandHolder = this.c1CommandHolder1;
            this.c1ToolBar1.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink8,
            this.c1CommandLink9,
            this.c1CommandLink7,
            this.c1CommandLink10,
            this.c1CommandLink3,
            this.c1CommandLink5,
            this.c1CommandLink12,
            this.c1CommandLink6,
            this.c1CommandLink4,
            this.c1CommandLink1,
            this.c1CommandLink2,
            this.c1CommandLink13,
            this.c1CommandLink14,
            this.c1CommandLink11});
            this.c1ToolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1ToolBar1.Location = new System.Drawing.Point(0, 0);
            this.c1ToolBar1.Movable = false;
            this.c1ToolBar1.Name = "c1ToolBar1";
            this.c1ToolBar1.Size = new System.Drawing.Size(592, 26);
            this.c1ToolBar1.Text = "c1ToolBar1";
            this.c1ToolBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP;
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.c1CommandSortAsc);
            this.c1CommandHolder1.Commands.Add(this.c1CommandSortDesc);
            this.c1CommandHolder1.Commands.Add(this.c1CommandAddChild);
            this.c1CommandHolder1.Commands.Add(this.c1CommandDelete);
            this.c1CommandHolder1.Commands.Add(this.c1CommandInsertItem);
            this.c1CommandHolder1.Commands.Add(this.c1CommandAppendItem);
            this.c1CommandHolder1.Commands.Add(this.c1CommandMoveLeft);
            this.c1CommandHolder1.Commands.Add(this.c1CommandMoveUp);
            this.c1CommandHolder1.Commands.Add(this.c1CommandMoveDown);
            this.c1CommandHolder1.Commands.Add(this.c1CommandMoveRight);
            this.c1CommandHolder1.Commands.Add(this.c1CommandPrint);
            this.c1CommandHolder1.Commands.Add(this.c1CommandInsertBelow);
            this.c1CommandHolder1.Commands.Add(this.c1CommandExpand);
            this.c1CommandHolder1.Commands.Add(this.c1CommandCollapse);
            this.c1CommandHolder1.Owner = this;
            this.c1CommandHolder1.CommandClick += new C1.Win.C1Command.CommandClickEventHandler(this.c1CommandHolder1_CommandClick);
            // 
            // c1CommandSortAsc
            // 
            this.c1CommandSortAsc.Image = ((System.Drawing.Image)(resources.GetObject("c1CommandSortAsc.Image")));
            this.c1CommandSortAsc.Name = "c1CommandSortAsc";
            this.c1CommandSortAsc.Text = "Sort Children Ascending";
            // 
            // c1CommandSortDesc
            // 
            this.c1CommandSortDesc.Image = ((System.Drawing.Image)(resources.GetObject("c1CommandSortDesc.Image")));
            this.c1CommandSortDesc.Name = "c1CommandSortDesc";
            this.c1CommandSortDesc.Text = "Sort Children Descending";
            // 
            // c1CommandAddChild
            // 
            this.c1CommandAddChild.Image = ((System.Drawing.Image)(resources.GetObject("c1CommandAddChild.Image")));
            this.c1CommandAddChild.Name = "c1CommandAddChild";
            this.c1CommandAddChild.Text = "Add Child";
            // 
            // c1CommandDelete
            // 
            this.c1CommandDelete.Image = ((System.Drawing.Image)(resources.GetObject("c1CommandDelete.Image")));
            this.c1CommandDelete.Name = "c1CommandDelete";
            this.c1CommandDelete.Text = "Delete";
            // 
            // c1CommandInsertItem
            // 
            this.c1CommandInsertItem.Image = ((System.Drawing.Image)(resources.GetObject("c1CommandInsertItem.Image")));
            this.c1CommandInsertItem.Name = "c1CommandInsertItem";
            this.c1CommandInsertItem.Text = "Insert Item Above";
            // 
            // c1CommandAppendItem
            // 
            this.c1CommandAppendItem.Image = ((System.Drawing.Image)(resources.GetObject("c1CommandAppendItem.Image")));
            this.c1CommandAppendItem.Name = "c1CommandAppendItem";
            this.c1CommandAppendItem.Text = "Append Item";
            // 
            // c1CommandMoveLeft
            // 
            this.c1CommandMoveLeft.Image = ((System.Drawing.Image)(resources.GetObject("c1CommandMoveLeft.Image")));
            this.c1CommandMoveLeft.Name = "c1CommandMoveLeft";
            this.c1CommandMoveLeft.Text = "Move Item to Parent";
            // 
            // c1CommandMoveUp
            // 
            this.c1CommandMoveUp.Image = ((System.Drawing.Image)(resources.GetObject("c1CommandMoveUp.Image")));
            this.c1CommandMoveUp.Name = "c1CommandMoveUp";
            this.c1CommandMoveUp.Text = "Move Item Up";
            // 
            // c1CommandMoveDown
            // 
            this.c1CommandMoveDown.Image = ((System.Drawing.Image)(resources.GetObject("c1CommandMoveDown.Image")));
            this.c1CommandMoveDown.Name = "c1CommandMoveDown";
            this.c1CommandMoveDown.Text = "Move Item Down";
            // 
            // c1CommandMoveRight
            // 
            this.c1CommandMoveRight.Image = ((System.Drawing.Image)(resources.GetObject("c1CommandMoveRight.Image")));
            this.c1CommandMoveRight.Name = "c1CommandMoveRight";
            this.c1CommandMoveRight.Text = "Move Item to Child";
            // 
            // c1CommandPrint
            // 
            this.c1CommandPrint.Image = ((System.Drawing.Image)(resources.GetObject("c1CommandPrint.Image")));
            this.c1CommandPrint.Name = "c1CommandPrint";
            this.c1CommandPrint.Text = "Print";
            // 
            // c1CommandInsertBelow
            // 
            this.c1CommandInsertBelow.Image = ((System.Drawing.Image)(resources.GetObject("c1CommandInsertBelow.Image")));
            this.c1CommandInsertBelow.Name = "c1CommandInsertBelow";
            this.c1CommandInsertBelow.Text = "Insert Item Below";
            // 
            // c1CommandExpand
            // 
            this.c1CommandExpand.Image = ((System.Drawing.Image)(resources.GetObject("c1CommandExpand.Image")));
            this.c1CommandExpand.Name = "c1CommandExpand";
            this.c1CommandExpand.Text = "Expand All";
            // 
            // c1CommandCollapse
            // 
            this.c1CommandCollapse.Image = ((System.Drawing.Image)(resources.GetObject("c1CommandCollapse.Image")));
            this.c1CommandCollapse.Name = "c1CommandCollapse";
            this.c1CommandCollapse.Text = "Collapse All";
            // 
            // c1CommandLink8
            // 
            this.c1CommandLink8.Command = this.c1CommandMoveUp;
            // 
            // c1CommandLink9
            // 
            this.c1CommandLink9.Command = this.c1CommandMoveDown;
            this.c1CommandLink9.SortOrder = 1;
            // 
            // c1CommandLink7
            // 
            this.c1CommandLink7.Command = this.c1CommandMoveLeft;
            this.c1CommandLink7.SortOrder = 2;
            // 
            // c1CommandLink10
            // 
            this.c1CommandLink10.Command = this.c1CommandMoveRight;
            this.c1CommandLink10.SortOrder = 3;
            // 
            // c1CommandLink3
            // 
            this.c1CommandLink3.Command = this.c1CommandAddChild;
            this.c1CommandLink3.Delimiter = true;
            this.c1CommandLink3.SortOrder = 4;
            this.c1CommandLink3.Text = "Add Child";
            // 
            // c1CommandLink5
            // 
            this.c1CommandLink5.Command = this.c1CommandInsertItem;
            this.c1CommandLink5.SortOrder = 5;
            this.c1CommandLink5.Text = "Insert Item Above";
            // 
            // c1CommandLink12
            // 
            this.c1CommandLink12.Command = this.c1CommandInsertBelow;
            this.c1CommandLink12.SortOrder = 6;
            // 
            // c1CommandLink6
            // 
            this.c1CommandLink6.Command = this.c1CommandAppendItem;
            this.c1CommandLink6.SortOrder = 7;
            // 
            // c1CommandLink4
            // 
            this.c1CommandLink4.Command = this.c1CommandDelete;
            this.c1CommandLink4.SortOrder = 8;
            this.c1CommandLink4.Text = "Delete";
            // 
            // c1CommandLink1
            // 
            this.c1CommandLink1.Command = this.c1CommandSortAsc;
            this.c1CommandLink1.Delimiter = true;
            this.c1CommandLink1.SortOrder = 9;
            this.c1CommandLink1.Text = "Sort Children Ascending";
            // 
            // c1CommandLink2
            // 
            this.c1CommandLink2.Command = this.c1CommandSortDesc;
            this.c1CommandLink2.SortOrder = 10;
            this.c1CommandLink2.Text = "Sort Children Descending";
            // 
            // c1CommandLink13
            // 
            this.c1CommandLink13.Command = this.c1CommandExpand;
            this.c1CommandLink13.SortOrder = 11;
            // 
            // c1CommandLink14
            // 
            this.c1CommandLink14.Command = this.c1CommandCollapse;
            this.c1CommandLink14.SortOrder = 12;
            // 
            // c1CommandLink11
            // 
            this.c1CommandLink11.Command = this.c1CommandPrint;
            this.c1CommandLink11.Delimiter = true;
            this.c1CommandLink11.SortOrder = 13;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Notepad1.png");
            this.imageList1.Images.SetKeyName(1, "Folder_Closed.gif");
            // 
            // TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this.flex);
            this.Controls.Add(this.c1ToolBar1);
            this.Name = "TreeView";
            this.Text = "NewTreeView";
            this.Load += new System.EventHandler(this.NewTreeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid flex;
        private C1.Win.C1Command.C1ToolBar c1ToolBar1;
        private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
        private C1.Win.C1Command.C1Command c1CommandSortAsc;
        private C1.Win.C1Command.C1Command c1CommandSortDesc;
        private C1.Win.C1Command.C1Command c1CommandAddChild;
        private C1.Win.C1Command.C1CommandLink c1CommandLink1;
        private C1.Win.C1Command.C1CommandLink c1CommandLink2;
        private C1.Win.C1Command.C1CommandLink c1CommandLink3;
        private C1.Win.C1Command.C1CommandLink c1CommandLink4;
        private C1.Win.C1Command.C1Command c1CommandDelete;
        private C1.Win.C1Command.C1Command c1CommandInsertItem;
        private C1.Win.C1Command.C1Command c1CommandAppendItem;
        private C1.Win.C1Command.C1Command c1CommandMoveLeft;
        private C1.Win.C1Command.C1CommandLink c1CommandLink5;
        private C1.Win.C1Command.C1CommandLink c1CommandLink6;
        private C1.Win.C1Command.C1CommandLink c1CommandLink7;
        private C1.Win.C1Command.C1CommandLink c1CommandLink8;
        private C1.Win.C1Command.C1Command c1CommandMoveUp;
        private C1.Win.C1Command.C1Command c1CommandMoveDown;
        private C1.Win.C1Command.C1CommandLink c1CommandLink9;
        private C1.Win.C1Command.C1CommandLink c1CommandLink10;
        private C1.Win.C1Command.C1Command c1CommandMoveRight;
        private C1.Win.C1Command.C1Command c1CommandPrint;
        private C1.Win.C1Command.C1CommandLink c1CommandLink11;
        private C1.Win.C1Command.C1Command c1CommandInsertBelow;
        private C1.Win.C1Command.C1CommandLink c1CommandLink12;
        private C1.Win.C1Command.C1Command c1CommandExpand;
        private C1.Win.C1Command.C1CommandLink c1CommandLink13;
        private C1.Win.C1Command.C1Command c1CommandCollapse;
        private C1.Win.C1Command.C1CommandLink c1CommandLink14;
        private System.Windows.Forms.ImageList imageList1;
    }
}