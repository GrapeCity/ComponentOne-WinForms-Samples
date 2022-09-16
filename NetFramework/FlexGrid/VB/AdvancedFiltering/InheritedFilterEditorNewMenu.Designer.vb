Namespace AdvancedFiltering
    Partial Class InheritedFilterEditorNewMenu
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me._mnuWeekdayFilter = New C1.Win.C1FlexGrid.ColumnFilterMenuItem()
            Me._weekdayFilterEditor = New AdvancedFiltering.WeekdayFilterEditor()
            Me.SuspendLayout()
            Me.ValueFilterEditor.Size = New System.Drawing.Size(309, 222)
            Me._mnuWeekdayFilter.Highlighted = False
            Me._mnuWeekdayFilter.Name = "_mnuWeekdayFilter"
            Me._mnuWeekdayFilter.Size = New System.Drawing.Size(32, 19)
            Me._mnuWeekdayFilter.Text = "&Weekday Filter"
            Me._weekdayFilterEditor.Location = New System.Drawing.Point(0, 0)
            Me._weekdayFilterEditor.Name = "_weekdayFilterEditor"
            Me._weekdayFilterEditor.Size = New System.Drawing.Size(125, 189)
            Me._weekdayFilterEditor.Dock = System.Windows.Forms.DockStyle.Fill
            Me._weekdayFilterEditor.TabIndex = 0
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
            Me.Controls.Add(Me._weekdayFilterEditor)
            Me.Name = "InheritedFilterEditorNewMenu"
            Me.Size = New System.Drawing.Size(309, 247)
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Private WithEvents _mnuWeekdayFilter As C1.Win.C1FlexGrid.ColumnFilterMenuItem
        Private _weekdayFilterEditor As WeekdayFilterEditor
    End Class
End Namespace
