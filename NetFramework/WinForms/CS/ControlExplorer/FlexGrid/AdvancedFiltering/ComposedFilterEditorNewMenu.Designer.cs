namespace ControlExplorer.FlexGrid.AdvancedFiltering
{
    partial class ComposedFilterEditorNewMenu
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
            this._columnFilterEditor = new C1.Win.C1FlexGrid.ColumnFilterEditor();
            this._weekdayFilterEditor = new WeekdayFilterEditor();
            this._mnuWeekdayFilter = new C1.Win.C1FlexGrid.ColumnFilterMenuItem();
            this.SuspendLayout();
            // 
            // _columnFilterEditor
            // 
            this._columnFilterEditor.AutoSize = true;
            this._columnFilterEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this._columnFilterEditor.Location = new System.Drawing.Point(0, 0);
            this._columnFilterEditor.Margin = new System.Windows.Forms.Padding(2);
            this._columnFilterEditor.Name = "_columnFilterEditor";
            this._columnFilterEditor.Size = new System.Drawing.Size(416, 234);
            this._columnFilterEditor.TabIndex = 7;
            this._columnFilterEditor.UseComposedMenu = false;
            // 
            // _weekdayFilterEditor
            // 
            this._weekdayFilterEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this._weekdayFilterEditor.Location = new System.Drawing.Point(0, 0);
            this._weekdayFilterEditor.Name = "_weekdayFilterEditor";
            this._weekdayFilterEditor.Size = new System.Drawing.Size(416, 234);
            this._weekdayFilterEditor.TabIndex = 8;
            // 
            // _mnuWeekdayFilter
            // 
            this._mnuWeekdayFilter.Highlighted = false;
            this._mnuWeekdayFilter.Name = "_mnuWeekdayFilter";
            this._mnuWeekdayFilter.Size = new System.Drawing.Size(32, 19);
            this._mnuWeekdayFilter.Text = "&Weekday Filter";
            this._mnuWeekdayFilter.Click += new System.EventHandler(this._mnuWeekdayFilter_Click);
            // 
            // ComposedFilterEditorNewMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this._weekdayFilterEditor);
            this.Controls.Add(this._columnFilterEditor);
            this.Name = "ComposedFilterEditorNewMenu";
            this.Size = new System.Drawing.Size(416, 234);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1FlexGrid.ColumnFilterEditor _columnFilterEditor;
        private WeekdayFilterEditor _weekdayFilterEditor;
        private C1.Win.C1FlexGrid.ColumnFilterMenuItem _mnuWeekdayFilter;
    }
}
