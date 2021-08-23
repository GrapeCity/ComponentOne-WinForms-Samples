Imports C1.DataEngine
Imports System.Net
Imports System.IO
Imports Office = Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel
Imports AddIn = C1.DataEngine.ExcelAddIn

Public Class Form1

    Private dataPath As String = Path.Combine(System.Windows.Forms.Application.StartupPath, "Data")
    Private samplePath As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common\TorontoParkingTickets.xlsx"
    Private _workspaceInitialized = False

    Public Sub New()
        InitializeComponent()
    End Sub

    ' get data from the sample workbook
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

    ' get data model from the sample workbook
    Private Function GetFirstWorkbookTable() As String
        Dim excel As Excel.Application = Nothing
        Dim workbook As Excel.Workbook = Nothing
        Dim addin As Office.COMAddIn = Nothing
        Dim dataModel As AddIn.IDataModel = Nothing
        Dim tables As AddIn.IDataTable() = Nothing
        Try
            ' open the sample workbook
            Me.Cursor = Cursors.WaitCursor
            label1.Text = "Getting Data Model..."
            excel = New Excel.Application()
            workbook = excel.Workbooks.Open(samplePath)
            ' get Excel add-in COM object
            addin = excel.COMAddIns.Item("C1.DataEngine.ExcelAddIn")
            dataModel = DirectCast(addin.[Object], AddIn.IDataModel)
            ' get data model tables
            tables = dataModel.GetModelTables(excel.ActiveWorkbook)
            ' import data model tables to C1 DataEngine tables
            label1.Text = "Importing Data Model..."
            dataModel.ExportToDataEngine(tables, dataPath)
            ' initialize C1 DataEngine workspace
            AddHandler _c1FlexPivotPage.FlexPivotEngine.Workspace.Initialize, AddressOf Workspace_Initialized
            ' that must be done after export since export works in Excel process
            _c1FlexPivotPage.FlexPivotPanel.Workspace.Init(dataPath)
            ' returns the first imported table name
            Return tables(0).[Alias]
        Catch ex As Exception
            Me.Cursor = Cursors.[Default]
            MessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return Nothing
        Finally
            ' release COM objects
            ReleaseObject(tables)
            ReleaseObject(dataModel)
            ReleaseObject(addin)

            If workbook IsNot Nothing Then
                workbook.Close(False)
                ReleaseObject(workbook)
                workbook = Nothing
            End If
            If excel IsNot Nothing Then
                excel.Quit()
                ReleaseObject(excel)
                excel = Nothing
            End If
            Me.Cursor = Cursors.[Default]
            label1.Text = String.Empty
        End Try
    End Function

    Private Sub Workspace_Initialized(sender As Object, e As EventArgs)
        _workspaceInitialized = True
    End Sub

    ' release a COM object
    Private Sub ReleaseObject(obj As Object)
        Try
            Dim refs As Integer = 0
            Do
                refs = System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            Loop While refs > 0
        Catch
        Finally
            obj = Nothing
            GC.Collect()
        End Try
    End Sub

    ' remove data generated by C1 DataEngine
    Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)
        RemoveHandler _c1FlexPivotPage.FlexPivotEngine.Workspace.Initialize, AddressOf Workspace_Initialized
        If _workspaceInitialized Then
            _c1FlexPivotPage.FlexPivotPanel.Workspace.Clear()
        End If
        MyBase.OnFormClosed(e)
    End Sub

End Class
