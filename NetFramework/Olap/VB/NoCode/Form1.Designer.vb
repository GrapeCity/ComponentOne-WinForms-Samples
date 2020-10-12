Namespace NoCode
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
			Me.components = New System.ComponentModel.Container()
			Me.c1OlapPage1 = New C1.Win.Olap.C1OlapPage()
			Me.nWINDDataSet_Renamed = New NoCode.NWINDDataSet()
			Me.invoicesBindingSource = New BindingSource(Me.components)
			Me.invoicesTableAdapter = New NoCode.NWINDDataSetTableAdapters.InvoicesTableAdapter()
			CType(Me.c1OlapPage1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nWINDDataSet_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.invoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' c1OlapPage1
			' 
			Me.c1OlapPage1.DataSource = Me.invoicesBindingSource
			Me.c1OlapPage1.Dock = DockStyle.Fill
			Me.c1OlapPage1.Location = New Point(0, 0)
			Me.c1OlapPage1.Margin = New Padding(3, 2, 3, 2)
			Me.c1OlapPage1.Name = "c1OlapPage1"
			Me.c1OlapPage1.Size = New Size(692, 410)
			Me.c1OlapPage1.TabIndex = 0
			' 
			' nWINDDataSet
			' 
			Me.nWINDDataSet_Renamed.DataSetName = "NWINDDataSet"
			Me.nWINDDataSet_Renamed.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			' 
			' invoicesBindingSource
			' 
			Me.invoicesBindingSource.DataMember = "Invoices"
			Me.invoicesBindingSource.DataSource = Me.nWINDDataSet_Renamed
			' 
			' invoicesTableAdapter
			' 
			Me.invoicesTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(8F, 20F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(692, 410)
			Me.Controls.Add(Me.c1OlapPage1)
			Me.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.Margin = New Padding(3, 4, 3, 4)
			Me.Name = "Form1"
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "C1Olap: No Code"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			CType(Me.c1OlapPage1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nWINDDataSet_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.invoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private c1OlapPage1 As C1.Win.Olap.C1OlapPage
'INSTANT VB NOTE: The variable nWINDDataSet was renamed since Visual Basic does not handle variables named the same as their type well:
		Private nWINDDataSet_Renamed As NWINDDataSet
		Private invoicesBindingSource As BindingSource
		Private invoicesTableAdapter As NoCode.NWINDDataSetTableAdapters.InvoicesTableAdapter
	End Class
End Namespace

