
namespace InputExplorer.Samples
{
    partial class DropDownControl
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
            C1.Win.TreeView.C1TreeColumn c1TreeColumn8 = new C1.Win.TreeView.C1TreeColumn();
            C1.Win.TreeView.C1TreeColumn c1TreeColumn1 = new C1.Win.TreeView.C1TreeColumn();
            C1.Win.TreeView.C1TreeColumn c1TreeColumn9 = new C1.Win.TreeView.C1TreeColumn();
            C1.Win.TreeView.C1TreeColumn c1TreeColumn10 = new C1.Win.TreeView.C1TreeColumn();
            C1.Win.TreeView.C1TreeColumn c1TreeColumn11 = new C1.Win.TreeView.C1TreeColumn();
            C1.Win.TreeView.C1TreeColumn c1TreeColumn12 = new C1.Win.TreeView.C1TreeColumn();
            C1.Win.TreeView.C1TreeColumn c1TreeColumn13 = new C1.Win.TreeView.C1TreeColumn();
            this.dropDownTreeList = new C1.Win.Input.C1DropDownControl();
            this.treeList = new C1.Win.TreeView.C1TreeView();
            this.dropDownMultiColumnTreeView = new C1.Win.Input.C1DropDownControl();
            this.c1Label1 = new C1.Win.Input.C1Label();
            this.c1Label2 = new C1.Win.Input.C1Label();
            this.multiColumnTreeView = new C1.Win.TreeView.C1TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownMultiColumnTreeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiColumnTreeView)).BeginInit();
            this.SuspendLayout();
            // 
            // dropDownTreeList
            // 
            this.dropDownTreeList.Control = this.treeList;
            this.dropDownTreeList.DropDownStyle = C1.Win.Input.DropDownStyle.DropDownList;
            this.dropDownTreeList.InitialSelection = C1.Win.Input.InitialSelection.CaretAtStart;
            this.dropDownTreeList.Location = new System.Drawing.Point(170, 25);
            this.dropDownTreeList.Name = "dropDownTreeList";
            this.dropDownTreeList.Size = new System.Drawing.Size(163, 23);
            this.dropDownTreeList.TabIndex = 0;
            // 
            // treeList
            // 
            this.treeList.BackColor = System.Drawing.SystemColors.Window;
            this.treeList.BindingInfo.KeyField = "ID";
            this.treeList.BindingInfo.ParentKeyField = "ChiefID";
            // 
            // 
            // 
            this.treeList.ButtonImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.treeList.ButtonImageList.ImageSize = new System.Drawing.Size(9, 9);
            this.treeList.ButtonImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.treeList.CheckImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.treeList.CheckImageList.ImageSize = new System.Drawing.Size(13, 13);
            this.treeList.CheckImageList.TransparentColor = System.Drawing.Color.Transparent;
            c1TreeColumn8.DisplayFieldName = null;
            c1TreeColumn8.HeaderText = "Column1";
            c1TreeColumn8.Name = "Column1";
            c1TreeColumn8.Styles.Default.BackColor = System.Drawing.SystemColors.Window;
            c1TreeColumn8.Styles.Hot.BackColor = System.Drawing.SystemColors.Highlight;
            this.treeList.Columns.Add(c1TreeColumn8);
            this.treeList.Location = new System.Drawing.Point(50, 152);
            this.treeList.Name = "treeList";
            this.treeList.ShowColumnHeaders = false;
            this.treeList.Size = new System.Drawing.Size(200, 200);
            this.treeList.Styles.Default.BackColor = System.Drawing.SystemColors.Window;
            this.treeList.Styles.Hot.BackColor = System.Drawing.SystemColors.Highlight;
            this.treeList.TabIndex = 4;
            this.treeList.SelectionChanged += new C1.Win.TreeView.C1TreeViewEventHandler(this.treeList_SelectionChanged);
            // 
            // dropDownMultiColumnTreeView
            // 
            this.dropDownMultiColumnTreeView.Control = this.multiColumnTreeView;
            this.dropDownMultiColumnTreeView.DropDownStyle = C1.Win.Input.DropDownStyle.DropDownList;
            this.dropDownMultiColumnTreeView.DropDownWidth = 300;
            this.dropDownMultiColumnTreeView.InitialSelection = C1.Win.Input.InitialSelection.CaretAtStart;
            this.dropDownMultiColumnTreeView.Location = new System.Drawing.Point(170, 97);
            this.dropDownMultiColumnTreeView.Name = "dropDownMultiColumnTreeView";
            this.dropDownMultiColumnTreeView.Size = new System.Drawing.Size(200, 23);
            this.dropDownMultiColumnTreeView.TabIndex = 1;
            // 
            // c1Label1
            // 
            this.c1Label1.AutoSize = true;
            this.c1Label1.Location = new System.Drawing.Point(59, 28);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(105, 15);
            this.c1Label1.TabIndex = 2;
            this.c1Label1.Text = "TreeList ComboBox:";
            // 
            // c1Label2
            // 
            this.c1Label2.AutoSize = true;
            this.c1Label2.Location = new System.Drawing.Point(27, 100);
            this.c1Label2.Name = "c1Label2";
            this.c1Label2.Size = new System.Drawing.Size(137, 15);
            this.c1Label2.TabIndex = 3;
            this.c1Label2.Text = "MultiColumn ComboBox:";
            // 
            // multiColumnTreeView
            // 
            this.multiColumnTreeView.BackColor = System.Drawing.SystemColors.Window;
            this.multiColumnTreeView.BindingInfo.KeyField = "ID";
            this.multiColumnTreeView.BindingInfo.ParentKeyField = "ChiefID";
            // 
            // 
            // 
            this.multiColumnTreeView.ButtonImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.multiColumnTreeView.ButtonImageList.ImageSize = new System.Drawing.Size(9, 9);
            this.multiColumnTreeView.ButtonImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.multiColumnTreeView.CheckImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.multiColumnTreeView.CheckImageList.ImageSize = new System.Drawing.Size(13, 13);
            this.multiColumnTreeView.CheckImageList.TransparentColor = System.Drawing.Color.Transparent;
            c1TreeColumn1.DisplayFieldName = "Post";
            c1TreeColumn1.HeaderText = "Post";
            c1TreeColumn1.Name = "cPost";
            c1TreeColumn1.Styles.Default.BackColor = System.Drawing.SystemColors.Window;
            c1TreeColumn1.Styles.Hot.BackColor = System.Drawing.SystemColors.Highlight;
            c1TreeColumn9.DisplayFieldName = null;
            c1TreeColumn9.HeaderText = "Name";
            c1TreeColumn9.Name = "cName";
            c1TreeColumn9.Styles.Default.BackColor = System.Drawing.SystemColors.Window;
            c1TreeColumn9.Styles.Hot.BackColor = System.Drawing.SystemColors.Highlight;
            c1TreeColumn10.HeaderText = "Country";
            c1TreeColumn10.Name = "cCountry";
            c1TreeColumn10.Styles.Default.BackColor = System.Drawing.SystemColors.Window;
            c1TreeColumn10.Styles.Hot.BackColor = System.Drawing.SystemColors.Highlight;
            c1TreeColumn11.DisplayFieldName = "YearBonus";
            c1TreeColumn11.HeaderText = "Year Bonus";
            c1TreeColumn11.Name = "cBonus";
            c1TreeColumn11.Styles.Default.BackColor = System.Drawing.SystemColors.Window;
            c1TreeColumn11.Styles.Hot.BackColor = System.Drawing.SystemColors.Highlight;
            c1TreeColumn12.DisplayFieldName = "HasSpecialNeeds";
            c1TreeColumn12.HeaderText = "Has Special Needs";
            c1TreeColumn12.Name = "cNeeds";
            c1TreeColumn12.Styles.Default.BackColor = System.Drawing.SystemColors.Window;
            c1TreeColumn12.Styles.Hot.BackColor = System.Drawing.SystemColors.Highlight;
            c1TreeColumn13.DisplayFieldName = "HireDate";
            c1TreeColumn13.HeaderText = "Hire Date";
            c1TreeColumn13.Name = "cHireDate";
            c1TreeColumn13.Styles.Default.BackColor = System.Drawing.SystemColors.Window;
            c1TreeColumn13.Styles.Hot.BackColor = System.Drawing.SystemColors.Highlight;
            this.multiColumnTreeView.Columns.Add(c1TreeColumn1);
            this.multiColumnTreeView.Columns.Add(c1TreeColumn9);
            this.multiColumnTreeView.Columns.Add(c1TreeColumn10);
            this.multiColumnTreeView.Columns.Add(c1TreeColumn11);
            this.multiColumnTreeView.Columns.Add(c1TreeColumn12);
            this.multiColumnTreeView.Columns.Add(c1TreeColumn13);
            this.multiColumnTreeView.Location = new System.Drawing.Point(285, 152);
            this.multiColumnTreeView.Name = "multiColumnTreeView";
            this.multiColumnTreeView.Size = new System.Drawing.Size(200, 200);
            this.multiColumnTreeView.Styles.Default.BackColor = System.Drawing.SystemColors.Window;
            this.multiColumnTreeView.Styles.Hot.BackColor = System.Drawing.SystemColors.Highlight;
            this.multiColumnTreeView.TabIndex = 5;
            this.multiColumnTreeView.SelectionChanged += new C1.Win.TreeView.C1TreeViewEventHandler(this.c1TreeView2_SelectionChanged);
            // 
            // DropDownControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.multiColumnTreeView);
            this.Controls.Add(this.treeList);
            this.Controls.Add(this.c1Label2);
            this.Controls.Add(this.c1Label1);
            this.Controls.Add(this.dropDownMultiColumnTreeView);
            this.Controls.Add(this.dropDownTreeList);
            this.Name = "DropDownControl";
            this.Size = new System.Drawing.Size(732, 352);
            this.Load += new System.EventHandler(this.DropDownControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dropDownTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownMultiColumnTreeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiColumnTreeView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Input.C1DropDownControl dropDownTreeList;
        private C1.Win.Input.C1DropDownControl dropDownMultiColumnTreeView;
        private C1.Win.Input.C1Label c1Label1;
        private C1.Win.Input.C1Label c1Label2;
        private C1.Win.TreeView.C1TreeView treeList;
        private C1.Win.TreeView.C1TreeView multiColumnTreeView;
    }
}
