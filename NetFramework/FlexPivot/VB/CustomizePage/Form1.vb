Imports System.ComponentModel
Imports System.Text

Namespace CustomizePage
	Partial Public Class Form1
		Inherits Form

        Dim collapseAllView As C1.Win.C1Command.C1Command

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
            Dim view = Settings.Default.DefaultView
			If Not String.IsNullOrEmpty(view) Then
                c1FlexPivotPage1.ViewDefinition = view
			Else
                ' build default view now
                Dim fp = c1FlexPivotPage1.PivotEngine
                fp.BeginUpdate()
                fp.RowFields.Add("ProductName")
                fp.ColumnFields.Add("Country")
                fp.ValueFields.Add("ExtendedPrice")
                fp.EndUpdate()
			End If

			' build menu with predefined views:
			Dim doc = New System.Xml.XmlDocument()
            doc.LoadXml(My.Resources.FlexPivotViews)
            Dim menuView = New C1.Win.C1Command.C1CommandMenu()
            menuView.Text = "&View"
            menuView.Image = My.Resources.Views_small
            For Each nd As System.Xml.XmlNode In doc.SelectNodes("FlexPivotViews/C1FlexPivotPage")
                Dim cmd = New C1.Win.C1Command.C1Command()
                cmd.Text = nd.Attributes("id").Value
                cmd.UserData = nd
                AddHandler cmd.Click, AddressOf menuView_DropDownItemClicked
                Dim link = New C1.Win.C1Command.C1CommandLink(cmd)
                menuView.CommandLinks.Add(link)
            Next nd

            AddHandler c1FlexPivotPage1.Updated, AddressOf c1FlexPivotPage1_Updated

            ' add new view menu to C1FlexPivotPage toolstrip
            Dim menuLink = New C1.Win.C1Command.C1CommandLink(menuView)
            c1FlexPivotPage1.ToolBar.CommandLinks.Insert(3, menuLink)

            ' add collapseall menu to C1FlexPivotPage toolstrip
            collapseAllView = New C1.Win.C1Command.C1Command()
            collapseAllView.Text = "&CollapseAll"
            collapseAllView.Image = My.Resources.CollapseAll
            AddHandler collapseAllView.Click, AddressOf collapseAllView_Click
            Dim collapseAllViewLink = New C1.Win.C1Command.C1CommandLink(collapseAllView)
            c1FlexPivotPage1.ToolBar.CommandLinks.Add(collapseAllViewLink)

        End Sub

		Private Sub collapseAllView_Click(ByVal sender As Object, ByVal e As EventArgs)
            c1FlexPivotPage1.FlexPivotGrid.CollapseAllCols()
            c1FlexPivotPage1.FlexPivotGrid.CollapseAllRows()
		End Sub

		' closing form, save current view as default for next time
		Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
			' save current view as new default
            Settings.Default.DefaultView = c1FlexPivotPage1.ViewDefinition
            Settings.Default.Save()

			' fire event as usual
			MyBase.OnClosing(e)
		End Sub

		' select a predefined view
        Private Sub menuView_DropDownItemClicked(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs)
            Dim nd = TryCast(e.CallerLink.Command.UserData, System.Xml.XmlNode)
            If nd IsNot Nothing Then
                ' load view definition from XML
                c1FlexPivotPage1.ViewDefinition = nd.OuterXml

                ' show current view name in status bar
                c1FlexPivotPage1.LabelStatus.Text = nd.Attributes("id").Value
            End If
        End Sub
        Private Sub c1FlexPivotPage1_Updated(ByVal sender As Object, ByVal e As EventArgs)
            ' clear report name after user made any changes
            c1FlexPivotPage1.LabelStatus.Text = String.Empty

            ' update button status of collapseAllView.
            If (c1FlexPivotPage1.ShowTotalsForColumns = C1.PivotEngine.ShowTotals.Subtotals Or c1FlexPivotPage1.ShowTotalsForRows = C1.PivotEngine.ShowTotals.Subtotals) Then
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
