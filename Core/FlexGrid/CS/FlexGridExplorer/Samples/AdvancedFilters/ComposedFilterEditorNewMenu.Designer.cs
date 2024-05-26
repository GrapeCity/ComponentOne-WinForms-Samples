namespace FlexGridExplorer.Samples.AdvancedFilters
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
            _columnFilterEditor = new C1.Win.FlexGrid.ColumnFilterEditor();
            _weekdayFilterEditor = new WeekdayFilterEditor();
            _mnuWeekdayFilter = new C1.Win.FlexGrid.ColumnFilterMenuItem();
            SuspendLayout();
            // 
            // _columnFilterEditor
            // 
            _columnFilterEditor.AutoSize = true;
            _columnFilterEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            _columnFilterEditor.Location = new System.Drawing.Point(0, 0);
            _columnFilterEditor.Margin = new System.Windows.Forms.Padding(2);
            _columnFilterEditor.Name = "_columnFilterEditor";
            _columnFilterEditor.Size = new System.Drawing.Size(395, 187);
            _columnFilterEditor.TabIndex = 7;
            // 
            // _weekdayFilterEditor
            // 
            _weekdayFilterEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            _weekdayFilterEditor.Location = new System.Drawing.Point(0, 0);
            _weekdayFilterEditor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            _weekdayFilterEditor.Name = "_weekdayFilterEditor";
            _weekdayFilterEditor.Size = new System.Drawing.Size(395, 187);
            _weekdayFilterEditor.TabIndex = 8;
            // 
            // _mnuWeekdayFilter
            // 
            _mnuWeekdayFilter.Highlighted = false;
            _mnuWeekdayFilter.Name = "_mnuWeekdayFilter";
            _mnuWeekdayFilter.Size = new System.Drawing.Size(32, 19);
            _mnuWeekdayFilter.Text = "&Weekday Filter";
            _mnuWeekdayFilter.Click += _mnuWeekdayFilter_Click;
            // 
            // ComposedFilterEditorNewMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            Controls.Add(_weekdayFilterEditor);
            Controls.Add(_columnFilterEditor);
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "ComposedFilterEditorNewMenu";
            Size = new System.Drawing.Size(395, 187);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private C1.Win.FlexGrid.ColumnFilterEditor _columnFilterEditor;
        private WeekdayFilterEditor _weekdayFilterEditor;
        private C1.Win.FlexGrid.ColumnFilterMenuItem _mnuWeekdayFilter;
    }
}
