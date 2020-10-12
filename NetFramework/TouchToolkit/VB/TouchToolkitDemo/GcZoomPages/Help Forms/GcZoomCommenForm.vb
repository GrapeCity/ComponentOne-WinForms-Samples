Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace C1ZoomPages.Help_Forms
	Public Partial Class C1ZoomCommenForm
		Inherits Form
		Public Sub New()
			InitializeComponent()

			StartPosition = FormStartPosition.CenterParent

			Me.treeView1.Nodes(0).Expand()

			Me.dataGridView1.RowCount = 10
			For i As Integer = 0 To Me.dataGridView1.RowCount - 1
				For j As Integer = 0 To Me.dataGridView1.ColumnCount - 1
					Me.dataGridView1(j, i).Value = i.ToString() + j
				Next
			Next
		End Sub
	End Class
End Namespace
