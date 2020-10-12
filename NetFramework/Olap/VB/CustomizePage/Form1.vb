Imports System.ComponentModel
Imports System.Text

Namespace CustomizePage
	Partial Public Class Form1
		Inherits Form

		Dim collapseAllView As ToolStripButton

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' modify the connection string to make it work for the current user on this machine
			Me.invoicesTableAdapter.Connection.ConnectionString = GetConnectionString()

			' auto-generated:
			' This line of code loads data into the 'nWINDDataSet.Invoices' table.
			Me.invoicesTableAdapter.Fill(Me.nWINDDataSet_Renamed.Invoices)

			' show default view:
			' this assumes an application setting of type string called "DefaultView"
			Dim view = My.Settings.Default.DefaultView
			If Not String.IsNullOrEmpty(view) Then
				c1OlapPage1.ViewDefinition = view
			Else
				' build default view now
				Dim olap = c1OlapPage1.OlapEngine
				olap.BeginUpdate()
				olap.RowFields.Add("ProductName")
				olap.ColumnFields.Add("Country")
				olap.ValueFields.Add("ExtendedPrice")
				olap.EndUpdate()
			End If

			' build menu with predefined views:
			Dim doc = New System.Xml.XmlDocument()
			doc.LoadXml(My.Resources.OlapViews)
			Dim menuView = New ToolStripDropDownButton("&View", My.Resources.Views_small)
			For Each nd As System.Xml.XmlNode In doc.SelectNodes("OlapViews/C1OlapPage")
				Dim tsi = menuView.DropDownItems.Add(nd.Attributes("id").Value)
				tsi.Tag = nd
			Next nd
			AddHandler menuView.DropDownItemClicked, AddressOf menuView_DropDownItemClicked
			AddHandler c1OlapPage1.Updated, AddressOf c1OlapPage1_Updated

			' add new view menu to C1OlapPage toolstrip
			c1OlapPage1.ToolStrip.Items.Insert(3, menuView)

			' add collapseall menu to C1OlapPage toolstrip
			collapseAllView = New ToolStripButton("&CollapseAll", My.Resources.CollapseAll)
			AddHandler collapseAllView.Click, AddressOf collapseAllView_Click
			c1OlapPage1.ToolStrip.Items.Insert(11, collapseAllView)

		End Sub

		Private Sub collapseAllView_Click(ByVal sender As Object, ByVal e As EventArgs)
			c1OlapPage1.OlapGrid.CollapseAllCols()
			c1OlapPage1.OlapGrid.CollapseAllRows()
		End Sub

		' closing form, save current view as default for next time
		Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
			' save current view as new default
			My.Settings.Default.DefaultView = c1OlapPage1.ViewDefinition
			My.Settings.Default.Save()

			' fire event as usual
			MyBase.OnClosing(e)
		End Sub

		' select a predefined view
		Private Sub menuView_DropDownItemClicked(ByVal sender As Object, ByVal e As ToolStripItemClickedEventArgs)
			Dim nd = TryCast(e.ClickedItem.Tag, System.Xml.XmlNode)
			If nd IsNot Nothing Then
				' load view definition from XML
				c1OlapPage1.ViewDefinition = nd.OuterXml

				' show current view name in status bar
				c1OlapPage1.LabelStatus.Text = nd.Attributes("id").Value
			End If
		End Sub
		Private Sub c1OlapPage1_Updated(ByVal sender As Object, ByVal e As EventArgs)
			' clear report name after user made any changes
			c1OlapPage1.LabelStatus.Text = String.Empty

			' update button status of collapseAllView.
			If (c1OlapPage1.ShowTotalsColumns = C1.Olap.ShowTotals.Subtotals Or c1OlapPage1.ShowTotalsRows = C1.Olap.ShowTotals.Subtotals) Then
				collapseAllView.Enabled = True
			Else
				collapseAllView.Enabled = False
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
