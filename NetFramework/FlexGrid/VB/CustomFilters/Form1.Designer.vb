Namespace CustomFilters
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me._flex = New C1.Win.FlexGrid.C1FlexGrid()
			CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' _flex
			' 
			Me._flex.ColumnInfo = "10,1,0,0,0,120,Columns:0{Width:28;}" & vbTab
			Me._flex.Dock = DockStyle.Fill
			Me._flex.Location = New Point(0, 0)
			Me._flex.Margin = New Padding(3, 4, 3, 4)
			Me._flex.Name = "_flex"
			Me._flex.Rows.DefaultSize = 24
			Me._flex.Size = New Size(827, 384)
			Me._flex.StyleInfo = resources.GetString("_flex.StyleInfo")
			Me._flex.TabIndex = 0
			Me._flex.VisualStyle = C1.Win.FlexGrid.VisualStyle.Office2007Blue
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(8F, 20F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(827, 384)
			Me.Controls.Add(Me._flex)
			Me.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.Margin = New Padding(3, 4, 3, 4)
			Me.Name = "Form1"
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "C1FlexGrid: Custom Filters"
			CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private _flex As C1.Win.FlexGrid.C1FlexGrid
	End Class
End Namespace

