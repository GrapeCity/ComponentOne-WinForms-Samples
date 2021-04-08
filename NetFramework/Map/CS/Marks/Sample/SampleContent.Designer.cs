
namespace Marks
{
    partial class SampleContent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleContent));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCreateMarks = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddMark = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteMark = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnZoomArea = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this._grid = new System.Windows.Forms.DataGridView();
            this._contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuContextAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuContextZoomInItems = new System.Windows.Forms.ToolStripMenuItem();
            this._panel = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
            this._contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreateMarks,
            this.toolStripSeparator1,
            this.btnAddMark,
            this.btnDeleteMark,
            this.toolStripSeparator2,
            this.btnZoomArea});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(571, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCreateMarks
            // 
            this.btnCreateMarks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCreateMarks.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateMarks.Image")));
            this.btnCreateMarks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreateMarks.Name = "btnCreateMarks";
            this.btnCreateMarks.Size = new System.Drawing.Size(125, 22);
            this.btnCreateMarks.Text = "Create the new marks";
            this.btnCreateMarks.Click += new System.EventHandler(this.btnCreateMarks_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddMark
            // 
            this.btnAddMark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddMark.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddMark.Name = "btnAddMark";
            this.btnAddMark.Size = new System.Drawing.Size(23, 22);
            this.btnAddMark.Text = "btnAddMark";
            this.btnAddMark.ToolTipText = "Add the new mark";
            this.btnAddMark.Click += new System.EventHandler(this.btnAddMark_Click);
            // 
            // btnDeleteMark
            // 
            this.btnDeleteMark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteMark.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteMark.Name = "btnDeleteMark";
            this.btnDeleteMark.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteMark.Text = "btnDeleteMark";
            this.btnDeleteMark.ToolTipText = "Delete current mark";
            this.btnDeleteMark.Click += new System.EventHandler(this.btnDeleteMark_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnZoomArea
            // 
            this.btnZoomArea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnZoomArea.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomArea.Image")));
            this.btnZoomArea.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomArea.Name = "btnZoomArea";
            this.btnZoomArea.Size = new System.Drawing.Size(88, 22);
            this.btnZoomArea.Text = "Zoom in Selection";
            this.btnZoomArea.ToolTipText = "Zoom in Selection";
            this.btnZoomArea.Click += new System.EventHandler(this.btnZoomArea_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._grid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(371, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 362);
            this.panel1.TabIndex = 1;
            // 
            // _grid
            // 
            this._grid.AllowUserToAddRows = false;
            this._grid.AllowUserToDeleteRows = false;
            this._grid.AllowUserToResizeColumns = false;
            this._grid.AllowUserToResizeRows = false;
            this._grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._grid.BackgroundColor = System.Drawing.SystemColors.Control;
            this._grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._grid.ContextMenuStrip = this._contextMenu;
            this._grid.Location = new System.Drawing.Point(5, 5);
            this._grid.Name = "_grid";
            this._grid.ReadOnly = true;
            this._grid.RowHeadersVisible = false;
            this._grid.RowTemplate.Height = 25;
            this._grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._grid.Size = new System.Drawing.Size(189, 351);
            this._grid.TabIndex = 0;
            this._grid.SelectionChanged += new System.EventHandler(this._grid_SelectionChanged);
            // 
            // _contextMenu
            // 
            this._contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContextAdd,
            this.mnuContextDelete,
            this.toolStripSeparator3,
            this.mnuContextZoomInItems});
            this._contextMenu.Name = "_contextMenu";
            this._contextMenu.Size = new System.Drawing.Size(154, 76);
            // 
            // mnuContextAdd
            // 
            this.mnuContextAdd.Name = "mnuContextAdd";
            this.mnuContextAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.mnuContextAdd.Size = new System.Drawing.Size(153, 22);
            this.mnuContextAdd.Text = "Add";
            this.mnuContextAdd.Click += new System.EventHandler(this.mnuContextAdd_Click);
            // 
            // mnuContextDelete
            // 
            this.mnuContextDelete.Name = "mnuContextDelete";
            this.mnuContextDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mnuContextDelete.Size = new System.Drawing.Size(153, 22);
            this.mnuContextDelete.Text = "Delete";
            this.mnuContextDelete.Click += new System.EventHandler(this.mnuContextDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(150, 6);
            // 
            // mnuContextZoomInItems
            // 
            this.mnuContextZoomInItems.Name = "mnuContextZoomInItems";
            this.mnuContextZoomInItems.Size = new System.Drawing.Size(153, 22);
            this.mnuContextZoomInItems.Text = "Zoom in Selection";
            this.mnuContextZoomInItems.Click += new System.EventHandler(this.mnuContextZoomInItems_Click);
            // 
            // _panel
            // 
            this._panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panel.Location = new System.Drawing.Point(0, 25);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(371, 362);
            this._panel.TabIndex = 2;
            // 
            // MarkControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MarkControl";
            this.Size = new System.Drawing.Size(571, 387);
            this.Load += new System.EventHandler(this.MarkControl_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            this._contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCreateMarks;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAddMark;
        private System.Windows.Forms.ToolStripButton btnDeleteMark;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnZoomArea;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView _grid;
        private System.Windows.Forms.Panel _panel;
        private System.Windows.Forms.ContextMenuStrip _contextMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuContextDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuContextAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuContextZoomInItems;
    }
}
