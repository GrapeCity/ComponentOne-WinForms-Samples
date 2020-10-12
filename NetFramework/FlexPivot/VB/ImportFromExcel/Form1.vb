Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.IO
Imports C1.DataEngine
Imports System.Collections.Generic
Imports System.Net

Public Class Form1
    Inherits Form
    Private dataPath As String = Path.Combine(System.Windows.Forms.Application.StartupPath, "Data")
    Private samplePath As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common\TorontoParkingTickets.xlsx"

    Public Sub New()
        ' designer support
        InitializeComponent()

        ' where DataEngine data is stored
        _c1FlexPivotPage.FlexPivotPanel.Workspace.Init(dataPath)
    End Sub

    Private Sub buttonGetData_Click(sender As Object, e As EventArgs) Handles buttonGetData.Click
        ' download sample data
        If Not File.Exists(samplePath) AndAlso Not DownloadSample() Then
            Return
        End If

        ' connect to sample data
        Dim tableName As String = GetFirstWorkbookTable()
        _c1FlexPivotPage.FlexPivotPanel.ConnectDataEngine(tableName)

        ' show default view
        Dim engine = _c1FlexPivotPage.FlexPivotPanel.FlexPivotEngine
        engine.BeginUpdate()
        engine.RowFields.Add("infraction_description")
        engine.ValueFields.Add("tag_number_masked")
        engine.EndUpdate()
    End Sub

    ' data row item
    Public Class Ticket
        Public Property tag_number_masked As String
        Public Property date_of_infraction As DateTime
        Public Property infraction_code As Double
        Public Property infraction_description As String
        Public Property set_fine_amount As Double
        Public Property time_of_infraction As Double
        Public Property location1 As String
        Public Property location2 As String
        Public Property province As String

        ' create item from a reader
        Public Sub New(reader As IDataReader)
            tag_number_masked = If(reader.IsDBNull(0), Nothing, reader.GetString(0))
            date_of_infraction = ConverDateOfInfraction(If(reader.IsDBNull(1), Nothing, reader.GetDouble(1)))
            infraction_code = If(reader.IsDBNull(2), Nothing, reader.GetDouble(2))
            infraction_description = If(reader.IsDBNull(3), Nothing, reader.GetString(3))
            set_fine_amount = If(reader.IsDBNull(4), Nothing, reader.GetDouble(4))
            time_of_infraction = If(reader.IsDBNull(5), Nothing, reader.GetDouble(5))
            location1 = If(reader.IsDBNull(6), Nothing, reader.GetString(6))
            location2 = If(reader.IsDBNull(7), Nothing, reader.GetString(7))
            province = If(reader.IsDBNull(8), Nothing, reader.GetString(8))
        End Sub

        ' convert date format into a real date
        Private Function ConverDateOfInfraction(data As Double?) As DateTime
            If (data Is Nothing Or Not data.HasValue) Then
                Return Nothing
            End If
            Dim [date] As String = data.ToString()
            Return New DateTime(Integer.Parse([date].Substring(0, 4)), Integer.Parse([date].Substring(4, 2)), Integer.Parse([date].Substring(6)))
        End Function

        Public Shared Iterator Function GetTicletsInfo(reader As IDataReader) As IEnumerable(Of Ticket)
            While reader.Read()
                Yield New Ticket(reader)
            End While
        End Function
    End Class

    ' download sample workbook
    Private Function DownloadSample() As Boolean
        Try
            Cursor = Cursors.WaitCursor
            label1.Text = "Downloading sample data file..."
            Application.DoEvents()

            ' create folder
            If Not Directory.Exists(Path.GetDirectoryName(samplePath)) Then
                Directory.CreateDirectory(Path.GetDirectoryName(samplePath))
            End If

            Dim read As Integer = 0
            Dim buffer As Byte() = New Byte(2047) {}

            ' create ftp request
            Dim request = DirectCast(WebRequest.Create("ftp://publicfiles.componentone.com/FlexPivot/TorontoParkingTickets.xlsx"), FtpWebRequest)
            request.Proxy = Nothing
            request.KeepAlive = True
            request.UseBinary = True
            request.Method = WebRequestMethods.Ftp.DownloadFile
            request.Credentials = New NetworkCredential("anonymous", "*")
            Using response = DirectCast(request.GetResponse(), FtpWebResponse)
                Using stream = response.GetResponseStream()
                    Using writer = New FileStream(samplePath, FileMode.OpenOrCreate)
                        'write recieved data to a file
                        While True
                            read = stream.Read(buffer, 0, buffer.Length)
                            If read = 0 Then
                                Exit While
                            End If
                            writer.Write(buffer, 0, read)
                        End While
                    End Using
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Try
                ' delete the corrupted file
                If File.Exists(samplePath) Then
                    File.Delete(samplePath)
                End If
            Catch
            End Try
            Return False
        Finally
            label1.Text = String.Empty
            Cursor = Cursors.[Default]
        End Try
    End Function

    ' get data from the sample workbook
    Private Function GetFirstWorkbookTable() As String
        Using conn As New OleDbConnection(GetConnectionString())
            Cursor = Cursors.WaitCursor
            label1.Text = "Getting data from the sample workbook..."
            Application.DoEvents()

            conn.Open()

            ' get workbook table list
            Dim tables = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})

            ' get the name of the first table
            Dim name As String = tables.Rows(0)("TABLE_NAME").ToString()

            ' get data from the first table
            Dim command = New OleDbCommand((Convert.ToString("select * from [") & name) + "]", conn)
            Using reader = command.ExecuteReader()
                Dim connector = New ObjectConnector(Of Ticket)(_c1FlexPivotPage.FlexPivotPanel.Workspace, Ticket.GetTicletsInfo(reader))
                connector.GetData(name)
            End Using

            label1.Text = String.Empty
            Cursor = Cursors.[Default]
            Return name
        End Using
    End Function


    ' remove data generated by C1 DataEngine
    Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)
        _c1FlexPivotPage.FlexPivotPanel.Workspace.Clear()
        MyBase.OnFormClosed(e)
    End Sub

    ' get sample Excel file connection string
    Private Function GetConnectionString(Optional firstRowHasNames As Boolean = True, Optional mixedTypesAsText As Boolean = True) As String
        Dim conn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0;HDR={1};IMEX={2};ReadOnly=true"""
        Return String.Format(conn, samplePath, firstRowHasNames, mixedTypesAsText)
    End Function

End Class
