namespace ControlExplorer.FlexGrid.AdvancedFiltering
{
    partial class InheritedFilterEditorNewMenu
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
            this._mnuWeekdayFilter = new C1.Win.C1FlexGrid.ColumnFilterMenuItem();
            this._weekdayFilterEditor = new WeekdayFilterEditor();
            this.SuspendLayout();
            // 
            // ValueFilterEditor
            // 
            this.ValueFilterEditor.Size = new System.Drawing.Size(309, 222);
            // 
            // _mnuWeekdayFilter
            // 
            this._mnuWeekdayFilter.Highlighted = false;
            this._mnuWeekdayFilter.Name = "_mnuWeekdayFilter";
            this._mnuWeekdayFilter.Size = new System.Drawing.Size(32, 19);
            this._mnuWeekdayFilter.Text = "&Weekday Filter";
            this._mnuWeekdayFilter.Click += new System.EventHandler(this._mnuWeekdayFilter_Click);
            // 
            // _weekdayFilterEditor
            // 
            this._weekdayFilterEditor.Location = new System.Drawing.Point(0, 0);
            this._weekdayFilterEditor.Name = "_weekdayFilterEditor";
            this._weekdayFilterEditor.Size = new System.Drawing.Size(125, 189);
            this._weekdayFilterEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this._weekdayFilterEditor.TabIndex = 0;
            // 
            // InheritedFilterEditorNewMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this._weekdayFilterEditor);
            this.Name = "InheritedFilterEditorNewMenu";
            this.Size = new System.Drawing.Size(309, 247);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1FlexGrid.ColumnFilterMenuItem _mnuWeekdayFilter;
        private WeekdayFilterEditor _weekdayFilterEditor;
    }
}
