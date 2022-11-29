Namespace AdvancedFiltering
    Partial Class ComposedFilterEditor
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me._columnFilterEditor = New C1.Win.C1FlexGrid.ColumnFilterEditor()
            Me._weekdayFilterEditor = New AdvancedFiltering.WeekdayFilterEditor()
            Me._btnWeekdayFilter = New System.Windows.Forms.ToolStripButton()
            Me.SuspendLayout()
            '
            '_columnFilterEditor
            '
            Me._columnFilterEditor.AutoSize = True
            Me._columnFilterEditor.Dock = System.Windows.Forms.DockStyle.Fill
            Me._columnFilterEditor.Location = New System.Drawing.Point(0, 0)
            Me._columnFilterEditor.Margin = New System.Windows.Forms.Padding(2)
            Me._columnFilterEditor.Name = "_columnFilterEditor"
            Me._columnFilterEditor.Size = New System.Drawing.Size(434, 234)
            Me._columnFilterEditor.TabIndex = 7
            Me._columnFilterEditor.UseComposedMenu = False
            '
            '_weekdayFilterEditor
            '
            Me._weekdayFilterEditor.Dock = System.Windows.Forms.DockStyle.Fill
            Me._weekdayFilterEditor.Location = New System.Drawing.Point(0, 0)
            Me._weekdayFilterEditor.Name = "_weekdayFilterEditor"
            Me._weekdayFilterEditor.Size = New System.Drawing.Size(434, 234)
            Me._weekdayFilterEditor.TabIndex = 8
            '
            '_btnWeekdayFilter
            '
            Me._btnWeekdayFilter.Name = "_btnWeekdayFilter"
            Me._btnWeekdayFilter.Size = New System.Drawing.Size(23, 23)
            Me._btnWeekdayFilter.Text = "&Weekday Filter"
            '
            'ComposedFilterEditor
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me._weekdayFilterEditor)
            Me.Controls.Add(Me._columnFilterEditor)
            Me.Name = "ComposedFilterEditor"
            Me.Size = New System.Drawing.Size(434, 234)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Private _columnFilterEditor As C1.Win.C1FlexGrid.ColumnFilterEditor
        Private _weekdayFilterEditor As WeekdayFilterEditor
        Private WithEvents _btnWeekdayFilter As System.Windows.Forms.ToolStripButton
    End Class
End Namespace
