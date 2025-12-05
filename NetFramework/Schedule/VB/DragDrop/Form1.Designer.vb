<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.C1FlexGrid1 = New C1.Win.FlexGrid.C1FlexGrid
        Me.C1Schedule1 = New C1.Win.Schedule.C1Schedule
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Schedule1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Schedule1.DataStorage.AppointmentStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Schedule1.DataStorage.CategoryStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Schedule1.DataStorage.ContactStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Schedule1.DataStorage.LabelStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Schedule1.DataStorage.ResourceStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Schedule1.DataStorage.StatusStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.AllowDragging = C1.Win.FlexGrid.AllowDraggingEnum.None
        Me.C1FlexGrid1.ColumnInfo = "10,1,0,0,0,95,Columns:"
        Me.C1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Left
        Me.C1FlexGrid1.DragMode = C1.Win.FlexGrid.DragModeEnum.Automatic
        Me.C1FlexGrid1.Location = New System.Drawing.Point(0, 0)
        Me.C1FlexGrid1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.DefaultSize = 19
        Me.C1FlexGrid1.Size = New System.Drawing.Size(186, 426)
        Me.C1FlexGrid1.TabIndex = 0
        '
        'C1Schedule1
        '
        Me.C1Schedule1.AllowDrop = True
        '
        '
        '
        Me.C1Schedule1.CalendarInfo.DateFormatString = "dd.MM.yyyy"
        Me.C1Schedule1.CalendarInfo.EndDayTime = System.TimeSpan.Parse("19:00:00")
        Me.C1Schedule1.CalendarInfo.StartDayTime = System.TimeSpan.Parse("07:00:00")
        Me.C1Schedule1.CalendarInfo.TimeScale = System.TimeSpan.Parse("00:30:00")
        Me.C1Schedule1.CalendarInfo.WeekStart = System.DayOfWeek.Monday
        Me.C1Schedule1.CalendarInfo.WorkDays.AddRange(New System.DayOfWeek() {System.DayOfWeek.Tuesday, System.DayOfWeek.Wednesday, System.DayOfWeek.Thursday, System.DayOfWeek.Friday, System.DayOfWeek.Saturday})
        '
        '
        '
        Me.C1Schedule1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1Schedule1.Location = New System.Drawing.Point(186, 0)
        Me.C1Schedule1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.C1Schedule1.Name = "C1Schedule1"
        Me.C1Schedule1.Size = New System.Drawing.Size(356, 426)
        Me.C1Schedule1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 426)
        Me.Controls.Add(Me.C1Schedule1)
        Me.Controls.Add(Me.C1FlexGrid1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Schedule1.DataStorage.AppointmentStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Schedule1.DataStorage.CategoryStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Schedule1.DataStorage.ContactStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Schedule1.DataStorage.LabelStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Schedule1.DataStorage.ResourceStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Schedule1.DataStorage.StatusStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Schedule1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1FlexGrid1 As C1.Win.FlexGrid.C1FlexGrid
    Friend WithEvents C1Schedule1 As C1.Win.Schedule.C1Schedule

End Class
