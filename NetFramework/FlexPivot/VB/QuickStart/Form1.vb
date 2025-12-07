
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Xml
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports System.Globalization

Namespace QuickStart
    Partial Public Class Form1
        Inherits Form
        Private updating As Boolean
        Private sel As RadioButton
        Private conn As SqlConnection
        Private addTime As DateTime = DateTime.MinValue
        Private updateTime As DateTime = DateTime.MinValue
        Private dataPath As String = Path.Combine(System.Windows.Forms.Application.StartupPath, "Data")
        Private stream As MemoryStream
        Private initialView As String


        Public Sub New()
            ' designer support
            InitializeComponent()

            ' handle standard data table controls
            For Each ctl As Control In groupBox1.Controls
                If TypeOf ctl Is RadioButton Then
                    AddHandler ctl.Click, AddressOf DataTable_Click
                End If
            Next

            ' handle DataEngine table controls
            For Each ctl As Control In groupBox2.Controls
                If TypeOf ctl Is RadioButton Then
                    AddHandler ctl.Click, AddressOf EngineTable_Click
                End If
            Next

            ' connect to sample data
            conn = New SqlConnection(GetConnectionString())
            conn.Open()

            ' where DataEngine data is stored
            _c1FlexPivotPage.FlexPivotPanel.Workspace.Init(dataPath)

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

        ' create and connect to DataTable
        Private Sub DataTable_Click(sender As Object, e As EventArgs)
            If updating Then
                Return
            End If

            ' add data
            Dim count As Integer = StartAddingRows(sender)
            Dim dt = GetDataTable()
            AddToDataTable(dt, count)
            EndAddingRows(count)

            ' set data
            _c1FlexPivotPage.FlexPivotPanel.PivotEngine.BeginUpdate()
            _c1FlexPivotPage.DataSource = dt
            OnSetData()
            _c1FlexPivotPage.FlexPivotPanel.PivotEngine.EndUpdate()
        End Sub

        ' create and connect to a C1 DataEngine table
        Private Sub EngineTable_Click(sender As Object, e As EventArgs)
            If updating Then
                Return
            End If

            ' add data to DataEngine
            Dim count As Integer = StartAddingRows(sender)
            Dim dt As DataTable = GetDataTable()
            AddToEngineTable(dt, count)
            EndAddingRows(count)

            ' connect to DataEngine filled with data
            Dim fPanel = _c1FlexPivotPage.FlexPivotPanel
            fPanel.PivotEngine.BeginUpdate()
            fPanel.ConnectDataEngine(dt.TableName)
            OnSetData()
            fPanel.PivotEngine.EndUpdate()
        End Sub

        ' select a predefined FlexPivot view
        Private Sub MenuView_DropDownItemClicked(sender As Object, e As C1.Win.Command.ClickEventArgs)
            If updating OrElse sel Is Nothing Then
                Return
            End If

            Dim nd = TryCast(e.CallerLink.Command.UserData, XmlNode)
            If nd IsNot Nothing Then
                _c1FlexPivotPage.FlexPivotPanel.ViewDefinition = nd.OuterXml
            End If
        End Sub

        ' create DataTable
        Private Function GetDataTable() As DataTable
            Dim da = New SqlDataAdapter(My.Resources.SqlStatement, conn)
            Dim dt = New DataTable("NorthWind Sales Data")
            da.Fill(dt)
            Return dt
        End Function

        ' generate new rows in DataTable
        Private Sub AddToDataTable(table As DataTable, count As Integer)
            ' remove column protection
            For Each col As DataColumn In table.Columns
                col.[ReadOnly] = False
            Next

            ' read data from first rows
            Dim c As Integer = table.Rows.Count
            Dim max As Integer = Math.Min(c, 5000)
            Dim rd As Object() = New Object(max - 1) {}
            Dim n As Integer
            For n = 0 To max - 1
                rd(n) = table.Rows(n).ItemArray
            Next

            ' add data to the end of the table
            Dim i As Integer = 0
            While i < count
                Dim k As Integer = 0
                While k < max AndAlso (k + i) < count
                    Dim r As DataRow = table.NewRow()
                    r.ItemArray = DirectCast(rd(k), Object())
                    table.Rows.Add(r)
                    k += 1
                End While
                i += max
            End While
        End Sub

        ' generate new rows in the C1 DataEngine table
        Private Sub AddToEngineTable(table As DataTable, count As Integer)
            ' clean previously generated data
            _c1FlexPivotPage.FlexPivotPanel.Workspace.Clear()

            AddToDataTable(table, count)
            C1.DataEngine.DbConnector.GetData(_c1FlexPivotPage.FlexPivotPanel.Workspace, table, table.TableName)
        End Sub

        ' initialize or restore pivot view
        Private Sub OnSetData()
            If Not (initialView Is Nothing) Then
                _c1FlexPivotPage.FlexPivotPanel.ViewDefinition = initialView
            Else
                ' restore the view
                Using xr As System.Xml.XmlReader = System.Xml.XmlReader.Create(stream)
                    _c1FlexPivotPage.ReadXml(xr)
                End Using
                stream.Dispose()
                stream = Nothing
            End If
            initialView = Nothing

            ' fill lookups
            FillLookup("Country", My.Resources.SqlLookupCountry)
            FillLookup("Product", My.Resources.SqlLookupProduct)
            FillLookup("Customer", My.Resources.SqlLookupCustomer)
            FillLookup("Employee", My.Resources.SqlLookupEmployee)
            FillLookup("Category", My.Resources.SqlLookupCategory)
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
            Dim reader As SqlDataReader = cmd.ExecuteReader(CommandBehavior.SequentialAccess)
            While reader.Read()
                dict.Add(reader.GetValue(0), reader.GetString(1))
            End While
            reader.Close()
            Return dict
        End Function

        ' start logging adding rows
        Private Function StartAddingRows(sender As Object) As Integer
            updating = True
            ' uncheck other radio buttons
            For Each ctl As Control In groupBox1.Controls
                If TypeOf ctl Is RadioButton AndAlso Not ctl.Equals(sender) Then
                    DirectCast(ctl, RadioButton).Checked = False
                End If
            Next
            For Each ctl As Control In groupBox2.Controls
                If TypeOf ctl Is RadioButton AndAlso Not ctl.Equals(sender) Then
                    DirectCast(ctl, RadioButton).Checked = False
                End If
            Next

            ' save current view
            stream = New MemoryStream()
            Using xw As System.Xml.XmlWriter = System.Xml.XmlWriter.Create(stream)
                _c1FlexPivotPage.PivotEngine.WriteXml(xw)
                xw.Flush()
                stream.Position = 0
            End Using

            ' check selected button
            sel = DirectCast(sender, RadioButton)
            sel.Checked = True

            ' disconnect from data
            Dim fPanel = _c1FlexPivotPage.FlexPivotPanel
            fPanel.DataSource = Nothing
            fPanel.ConnectDataEngine(Nothing)

            ' start log
            Dim count As Integer = Integer.Parse(sel.Tag.ToString())
            addTime = DateTime.Now
            listBox1.Items.Add(String.Format("Creating {0} rows...", count.ToString("n0")))
            listBox1.TopIndex = listBox1.Items.Count - 1
            Application.DoEvents()
            Return count
        End Function

        ' end logging adding rows
        Private Sub EndAddingRows(count As Integer)
            Dim time As String = DateTime.Now.Subtract(addTime).TotalSeconds.ToString("n2")
            Dim idx As Integer = listBox1.Items.Count - 1
            listBox1.Items(idx) = String.Format("Created {0} rows: {1} sec.", count.ToString("n0"), time)
            listBox1.TopIndex = idx
        End Sub

        ' start log item
        Private Sub FlexPivotEngine_StartUpdating(sender As Object, e As EventArgs)
            Dim type As String = GetDataType()
            If (type Is Nothing) Then Return

            updateTime = DateTime.Now
            listBox1.Items.Add(String.Format("Updating {0}...", type))
            listBox1.TopIndex = listBox1.Items.Count - 1
        End Sub

        ' complete log item with cancelation information
        ' Update can be cancelled if the user changes fields during update
        Private Sub FlexPivotEngine_CancelUpdating(sender As Object, e As EventArgs)
            Dim time As String = DateTime.Now.Subtract(updateTime).TotalSeconds.ToString("n2")
            Dim idx As Integer = listBox1.Items.Count - 1
            listBox1.Items(idx) = String.Format("Updating {0} canceled: {1} sec.", GetDataType(), time)
            listBox1.TopIndex = idx
        End Sub

        ' complete log item with calculated operation time 
        Private Sub _c1FlexPivotPage_Updated(sender As Object, e As EventArgs)
            Dim type As String = GetDataType()
            If (type Is Nothing) Then Return

            Dim time As String = DateTime.Now.Subtract(updateTime).TotalSeconds.ToString("n2")

            ' update label
            Dim label As Control = sel.Parent.GetNextControl(sel, True)
            label.Text = String.Format("{0} sec.", time)

            ' update log
            Dim idx As Integer = listBox1.Items.Count - 1
            listBox1.Items(idx) = String.Format("Updated {0}: {1} sec.", type, time)
            listBox1.TopIndex = idx
            updating = False
        End Sub

        ' get current connected table type
        Private Function GetDataType() As String
            If _c1FlexPivotPage.DataSource IsNot Nothing Then
                Return _c1FlexPivotPage.DataSource.[GetType]().FullName
            ElseIf (_c1FlexPivotPage.PivotEngine.Fields.Count <> 0) Then
                Return "C1.DataEngine.Table"
            Else
                Return Nothing
            End If
        End Function

        ' remove data generated by the C1 DataEngine
        Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)
            _c1FlexPivotPage.FlexPivotPanel.Workspace.Clear()
            Try
                conn.Close()
            Catch
            End Try
            MyBase.OnFormClosed(e)
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
End Namespace
