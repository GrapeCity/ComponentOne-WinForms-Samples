Imports System.ComponentModel
Imports System.Text

Namespace NoCode
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' modify the connection string to make it work for the current user on this machine
			Me.invoicesTableAdapter.Connection.ConnectionString = GetConnectionString()

			' TODO: This line of code loads data into the 'nWINDDataSet.Invoices' table. You can move, or remove it, as needed.
			Me.invoicesTableAdapter.Fill(Me.nWINDDataSet_Renamed.Invoices)

		End Sub

		' get standard nwind mdb connection string
		Private Shared Function GetConnectionString() As String
			Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common"
			Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
			Return String.Format(conn, path)
		End Function
	End Class
End Namespace
