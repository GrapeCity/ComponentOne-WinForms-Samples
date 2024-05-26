namespace FlexGridExplorer.Samples.AdvancedFilters
{
    partial class InheritedFilterEditor
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
            _weekdayFilterEditor = new WeekdayFilterEditor();
            _btnWeekdayFilter = new System.Windows.Forms.ToolStripButton();
            SuspendLayout();
            // 
            // ValueFilterEditor
            // 
            ValueFilterEditor.Size = new System.Drawing.Size(378, 129);
            // 
            // _weekdayFilterEditor
            // 
            _weekdayFilterEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            _weekdayFilterEditor.Location = new System.Drawing.Point(0, 0);
            _weekdayFilterEditor.Margin = new System.Windows.Forms.Padding(2);
            _weekdayFilterEditor.Name = "_weekdayFilterEditor";
            _weekdayFilterEditor.Size = new System.Drawing.Size(517, 165);
            _weekdayFilterEditor.TabIndex = 0;
            // 
            // _btnWeekdayFilter
            // 
            _btnWeekdayFilter.Name = "_btnWeekdayFilter";
            _btnWeekdayFilter.Size = new System.Drawing.Size(23, 23);
            _btnWeekdayFilter.Text = "&Weekday Filter";
            _btnWeekdayFilter.Click += _btnWeekdayFilter_Click;
            // 
            // InheritedFilterEditor
            // 
            ActiveEditor = null;
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            Controls.Add(_weekdayFilterEditor);
            Name = "InheritedFilterEditor";
            Size = new System.Drawing.Size(517, 190);
            Controls.SetChildIndex(_weekdayFilterEditor, 0);
            Controls.SetChildIndex(ValueFilterEditor, 0);
            Controls.SetChildIndex(ConditionFilterEditor, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private WeekdayFilterEditor _weekdayFilterEditor;
        private System.Windows.Forms.ToolStripButton _btnWeekdayFilter;
    }
}
