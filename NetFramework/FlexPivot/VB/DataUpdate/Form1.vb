Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Xml
Imports System.Windows.Forms
Imports System.IO
Imports System.Linq
Imports System.Globalization

Public Class Form1
    Inherits Form
    Private conn As SqlConnection
    Private updatingItemIndex As Integer
    Private updateTime As DateTime = DateTime.MinValue
    Private dataPath As String = Path.Combine(System.Windows.Forms.Application.StartupPath, "Data")
    Private initialView As String

    Private tableName As String = "Sales"
    Private dataFromDB As IList(Of Sale)

    Public Sub New()
        ' designer support
        InitializeComponent()

        ' connect to sample data
        conn = New SqlConnection(GetConnectionString())
        conn.Open()

        ' show update log
        AddHandler _c1FlexPivotPage.PivotEngine.StartUpdating, AddressOf FlexPivotEngine_StartUpdating
        AddHandler _c1FlexPivotPage.PivotEngine.CancelUpdating, AddressOf FlexPivotEngine_CancelUpdating
        AddHandler _c1FlexPivotPage.Updated, AddressOf _c1FlexPivotPage_Updated

        ' load predefined FlexPivot views
        Dim doc = New XmlDocument()
        doc.LoadXml(My.Resources.FlexPivotViews)

        ' build menu with FlexPivot views
        Dim menuView = New C1.Win.Command.C1CommandMenu()
        menuView.Text = "&View"
        menuView.Image = My.Resources.Views_small
        For Each nd As XmlNode In doc.SelectNodes("FlexPivotViews/C1FlexPivot")
            If initialView Is Nothing Then
                initialView = nd.OuterXml
            End If
            Dim cmd = New C1.Win.Command.C1Command()
            cmd.Text = nd.Attributes("id").Value
            cmd.UserData = nd
            AddHandler cmd.Click, AddressOf MenuView_DropDownItemClicked
            Dim link = New C1.Win.Command.C1CommandLink(cmd)
            menuView.CommandLinks.Add(link)
        Next

        ' add the new view menu to the toolstrip
        Dim menuLink = New C1.Win.Command.C1CommandLink(menuView)
        menuLink.ButtonLook = C1.Win.Command.ButtonLookFlags.TextAndImage
        _c1FlexPivotPage.ToolBar.CommandLinks.Insert(3, menuLink)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' where DataEngine data is stored
        _c1FlexPivotPage.FlexPivotPanel.Workspace.Init(dataPath)

        ' peek at the data, does it already exist on disk?
        Dim data As ICollection = _c1FlexPivotPage.FlexPivotPanel.Workspace.GetTableData("Sales")
        If data IsNot Nothing AndAlso data.Count <> 0 Then
            ' if there is data already on disk, show default view in the control
            ConnectDataEngine()
        End If
    End Sub

    ' initial data fill
    Private Sub btnFill_Click(sender As Object, e As EventArgs) Handles btnFill.Click
        AddToEngineTable(3000000, True)
    End Sub

    ' adding more data
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddToEngineTable(1000, False)
    End Sub

    ' wipe out all data, including on disk
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        listBox1.Items.Add(String.Format("Clear rows"))
        listBox1.TopIndex = listBox1.Items.Count - 1

        _c1FlexPivotPage.FlexPivotPanel.ConnectDataEngine(Nothing)
        _c1FlexPivotPage.FlexPivotPanel.Workspace.Clear()
    End Sub

    ' select a predefined FlexPivot view
    Private Sub MenuView_DropDownItemClicked(sender As Object, e As C1.Win.Command.ClickEventArgs)
        Dim nd = TryCast(e.CallerLink.Command.UserData, XmlNode)
        If nd IsNot Nothing AndAlso _c1FlexPivotPage.PivotEngine.Fields.Count > 0 Then
            _c1FlexPivotPage.FlexPivotPanel.ViewDefinition = nd.OuterXml
        End If
    End Sub

    ' data row item
    Public Class Sale
        Public Property Sales As Single
        Public Property OrderDate As DateTime
        Public Property Product As Integer
        Public Property Customer As Integer
        Public Property Country As Integer
        Public Property Employee As Integer
        Public Property Category As Integer

        Public Sub New(reader As IDataReader)
            Sales = CSng(reader("Sales"))
            OrderDate = DirectCast(reader("OrderDate"), DateTime)
            Product = CInt(reader("Product"))
            Customer = CInt(reader("Customer"))
            Country = CInt(reader("Country"))
            Employee = CInt(reader("Employee"))
            Category = CInt(reader("Category"))
        End Sub

        Public Shared Iterator Function GetSales(reader As IDataReader) As IEnumerable(Of Sale)
            While reader.Read()
                Yield New Sale(reader)
            End While
        End Function
    End Class

    ' add data to DataEngine table
    Private Sub AddToEngineTable(count As Integer, firstTime As Boolean)
        ' read initial data from database
        Dim command = New SqlCommand(My.Resources.SqlStatement, conn)
        If firstTime OrElse dataFromDB Is Nothing Then
            Using reader = command.ExecuteReader()
                dataFromDB = Sale.GetSales(reader).ToList()
            End Using
        End If

        ' add more rows, just for testing performance  
        Dim connector = New C1.DataEngine.ObjectConnector(Of Sale)(_c1FlexPivotPage.FlexPivotPanel.Workspace, ChangeDataSize(dataFromDB, count))
        Dim dt As DateTime = DateTime.Now
        Dim idx As Integer = StartAddingRows(count)
        If firstTime Then
            connector.GetData(tableName)
        Else
            connector.AppendData(tableName)
        End If
        EndAddingRows(count, dt, idx)

        ' connect C1FlexPivot to DataEngine filled with data
        If firstTime Then
            ConnectDataEngine()
        End If
    End Sub

    ' increasing row count by cloning existing rows multiple times, just for testing performance
    Private Iterator Function ChangeDataSize(data As IEnumerable(Of Sale), size As Integer) As IEnumerable(Of Sale)
        Dim enumerator As IEnumerator(Of Sale) = data.GetEnumerator()
        For i As Integer = 0 To size - 1
            If Not enumerator.MoveNext() Then
                If i = 0 Then
                    Exit For
                End If
                enumerator = data.GetEnumerator()
                enumerator.MoveNext()
            End If
            Yield enumerator.Current
        Next
    End Function

    ' connect C1FlexPivot to DataEngine filled with data
    Private Sub ConnectDataEngine()
        Dim fPanel = _c1FlexPivotPage.FlexPivotPanel
        fPanel.PivotEngine.BeginUpdate()
        fPanel.ConnectDataEngine(tableName)

        ' set initial view
        fPanel.ViewDefinition = initialView

        ' fill lookups
        FillLookup("Country", My.Resources.SqlLookupCountry)
        FillLookup("Product", My.Resources.SqlLookupProduct)
        FillLookup("Customer", My.Resources.SqlLookupCustomer)
        FillLookup("Employee", My.Resources.SqlLookupEmployee)
        FillLookup("Category", My.Resources.SqlLookupCategory)

        fPanel.PivotEngine.EndUpdate()
    End Sub

    ' fill lookup dictionary for the field from the database
    Private Sub FillLookup(fieldName As String, lookupSql As String)
        Dim field As C1.PivotEngine.PivotField = _c1FlexPivotPage.FlexPivotPanel.PivotEngine.Fields(fieldName)
        If field.Lookup Is Nothing Then
            field.Lookup = GetLookup(conn, lookupSql)
        End If
    End Sub

    ' create a dictionary from two data columns
    Private Function GetLookup(conn As SqlConnection, command As String) As Dictionary(Of Object, String)
        Dim dict = New Dictionary(Of Object, String)()
        Dim cmd As New SqlCommand(command, conn)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            dict.Add(reader.GetValue(0), reader.GetString(1))
        End While
        reader.Close()
        Return dict
    End Function

    ' start logging adding rows
    Private Function StartAddingRows(count As Integer) As Integer
        Dim index As Integer = listBox1.Items.Add(String.Format("Adding {0} rows...", count.ToString("n0")))
        listBox1.TopIndex = listBox1.Items.Count - 1
        Application.DoEvents()
        Return index
    End Function

    ' end logging adding rows
    Private Sub EndAddingRows(count As Integer, startTime As DateTime, startItem As Integer)
        Dim time As String = DateTime.Now.Subtract(startTime).TotalSeconds.ToString("n2")
        listBox1.Items(startItem) = String.Format("Added {0} rows: {1} sec.", count.ToString("n0"), time)
        listBox1.TopIndex = listBox1.Items.Count - 1
    End Sub

    ' start log item
    Private Sub FlexPivotEngine_StartUpdating(sender As Object, e As EventArgs)
        updateTime = DateTime.Now
        updatingItemIndex = listBox1.Items.Add(String.Format("Updating..."))
        listBox1.TopIndex = listBox1.Items.Count - 1
    End Sub

    ' complete log item with cancelation information
    ' Update can be cancelled if the user changes fields during update
    Private Sub FlexPivotEngine_CancelUpdating(sender As Object, e As EventArgs)
        Dim time As String = DateTime.Now.Subtract(updateTime).TotalSeconds.ToString("n2")
        listBox1.Items(updatingItemIndex) = String.Format("Updating canceled: {0} sec.", time)
        listBox1.TopIndex = listBox1.Items.Count - 1
    End Sub

    ' complete log item with calculated operation time 
    Private Sub _c1FlexPivotPage_Updated(sender As Object, e As EventArgs)
        Dim time As String = DateTime.Now.Subtract(updateTime).TotalSeconds.ToString("n2")

        ' update log
        listBox1.Items(updatingItemIndex) = String.Format("Updated: {0} sec.", time)
        listBox1.TopIndex = listBox1.Items.Count - 1

        ' allow adding more data if there is data already; otherwise, allow only initial fill
        Dim filled As Boolean = _c1FlexPivotPage.PivotEngine.Fields.Count > 0
        btnFill.Enabled = Not filled
        btnClear.Enabled = filled
        btnAdd.Enabled = filled
    End Sub

    ' get sample DB connection string
    Private Shared Function GetConnectionString() As String
        Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Microsoft SQL Server Local DB\Installed Versions")
        If key Is Nothing Then
            Throw New Exception("Microsoft SQL Server LocalDB is not installed.")
        End If
        Dim version As String = "v11.0"
        For Each subKeyName In key.GetSubKeyNames()
            Dim localDBVersion As Double = 0
            If Double.TryParse(subKeyName, NumberStyles.Number, CultureInfo.InvariantCulture, localDBVersion) And localDBVersion >= 12 Then
                version = "MSSQLLocalDB"
                Exit For
            End If
        Next
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common"
        Return String.Format("Data Source=(LocalDB)\{0};AttachDbFilename={1}\NORTHWND.MDF;Integrated Security=True;Connect Timeout=30", version, path)
    End Function

End Class