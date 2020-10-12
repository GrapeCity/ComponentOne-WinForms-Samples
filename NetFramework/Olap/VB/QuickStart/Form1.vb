Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Xml
Imports System.Text
Imports C1.Win.Olap

Namespace QuickStart
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			' designer support
			InitializeComponent()

			' get data
			Dim da = New OleDbDataAdapter(My.Resources.SqlStatement, GetConnectionString())
			Dim dt = New DataTable("NorthWind Sales Data")
			da.Fill(dt)

			' assign data to C1OlapPage control
			_c1OlapPage.DataSource = dt

			' show default view
			Dim olap = _c1OlapPage.OlapPanel.OlapEngine
			olap.BeginUpdate()
			olap.RowFields.Add("Country")
			olap.ColumnFields.Add("Category")
			olap.ValueFields.Add("Sales")
			olap.EndUpdate()

			' load predefined olap views
			Dim doc = New XmlDocument()
			doc.LoadXml(My.Resources.OlapViews)

			' build menu with default olap views
			Dim menuView = New ToolStripDropDownButton("&View", My.Resources.Views_small)
			For Each nd As XmlNode In doc.SelectNodes("OlapViews/C1Olap")
				Dim tsi = menuView.DropDownItems.Add(nd.Attributes("id").Value)
				tsi.Tag = nd
			Next nd
			AddHandler menuView.DropDownItemClicked, AddressOf MenuView_DropDownItemClicked

			' add the new view menu to the toolstrip
			_c1OlapPage.ToolStrip.Items.Insert(3, menuView)
		End Sub

		' select a predefined Olap view
		Private Sub MenuView_DropDownItemClicked(ByVal sender As Object, ByVal e As ToolStripItemClickedEventArgs)
			Dim nd = TryCast(e.ClickedItem.Tag, XmlNode)
			If nd IsNot Nothing Then
				_c1OlapPage.OlapPanel.ViewDefinition = nd.OuterXml
			End If
		End Sub

		' get standard nwind mdb connection string
		Private Shared Function GetConnectionString() As String
			Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common"
			Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
			Return String.Format(conn, path)
		End Function
	End Class
End Namespace
