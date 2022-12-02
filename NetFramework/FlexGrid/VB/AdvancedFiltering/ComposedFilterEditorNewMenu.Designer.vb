Namespace AdvancedFiltering
    Partial Class ComposedFilterEditorNewMenu
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
            Me._mnuWeekdayFilter = New C1.Win.C1FlexGrid.ColumnFilterMenuItem()
            Me.SuspendLayout()
            '
            '_columnFilterEditor
            '
            Me._columnFilterEditor.AutoSize = True
            Me._columnFilterEditor.Dock = System.Windows.Forms.DockStyle.Fill
            Me._columnFilterEditor.Location = New System.Drawing.Point(0, 0)
            Me._columnFilterEditor.Margin = New System.Windows.Forms.Padding(2)
            Me._columnFilterEditor.Name = "_columnFilterEditor"
            Me._columnFilterEditor.Size = New System.Drawing.Size(302, 234)
            Me._columnFilterEditor.TabIndex = 7
            Me._columnFilterEditor.UseComposedMenu = False
            '
            '_weekdayFilterEditor
            '
            Me._weekdayFilterEditor.Dock = System.Windows.Forms.DockStyle.Fill
            Me._weekdayFilterEditor.Location = New System.Drawing.Point(0, 0)
            Me._weekdayFilterEditor.Name = "_weekdayFilterEditor"
            Me._weekdayFilterEditor.Size = New System.Drawing.Size(302, 234)
            Me._weekdayFilterEditor.TabIndex = 8
            '
            '_mnuWeekdayFilter
            '
            Me._mnuWeekdayFilter.Highlighted = False
            Me._mnuWeekdayFilter.Name = "_mnuWeekdayFilter"
            Me._mnuWeekdayFilter.Size = New System.Drawing.Size(32, 19)
            Me._mnuWeekdayFilter.Text = "&Weekday Filter"
            '
            'ComposedFilterEditorNewMenu
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me._weekdayFilterEditor)
            Me.Controls.Add(Me._columnFilterEditor)
            Me.Name = "ComposedFilterEditorNewMenu"
            Me.Size = New System.Drawing.Size(302, 234)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Private _columnFilterEditor As C1.Win.C1FlexGrid.ColumnFilterEditor
        Private _weekdayFilterEditor As WeekdayFilterEditor
        Private WithEvents _mnuWeekdayFilter As C1.Win.C1FlexGrid.ColumnFilterMenuItem
    End Class
End Namespace
