Namespace AdvancedFiltering
    Partial Class InheritedFilterEditor
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me._weekdayFilterEditor = New AdvancedFiltering.WeekdayFilterEditor()
            Me._btnWeekdayFilter = New System.Windows.Forms.ToolStripButton()
            Me.SuspendLayout()
            Me.ValueFilterEditor.Size = New System.Drawing.Size(428, 213)
            Me._weekdayFilterEditor.Dock = System.Windows.Forms.DockStyle.Fill
            Me._weekdayFilterEditor.Location = New System.Drawing.Point(0, 0)
            Me._weekdayFilterEditor.Margin = New System.Windows.Forms.Padding(2)
            Me._weekdayFilterEditor.Name = "_weekdayFilterEditor"
            Me._weekdayFilterEditor.Size = New System.Drawing.Size(428, 213)
            Me._weekdayFilterEditor.TabIndex = 0
            Me._btnWeekdayFilter.Name = "_btnWeekdayFilter"
            Me._btnWeekdayFilter.Size = New System.Drawing.Size(23, 23)
            Me._btnWeekdayFilter.Text = "&Weekday Filter"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me._weekdayFilterEditor)
            Me.Name = "InheritedFilterEditor"
            Me.Size = New System.Drawing.Size(428, 238)
            Me.Controls.SetChildIndex(Me._weekdayFilterEditor, 0)
            Me.Controls.SetChildIndex(Me.ValueFilterEditor, 0)
            Me.Controls.SetChildIndex(Me.ConditionFilterEditor, 0)
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Private _weekdayFilterEditor As WeekdayFilterEditor
        Private WithEvents _btnWeekdayFilter As System.Windows.Forms.ToolStripButton
    End Class
End Namespace
