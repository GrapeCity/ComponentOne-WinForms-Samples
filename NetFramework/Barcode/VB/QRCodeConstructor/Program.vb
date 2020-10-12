Public Class Program

    Public Shared _CodeBuilt As Boolean
    Public Shared _CodeToBuild As String = String.Empty
    Public Shared _TextPresent As Boolean
    Public Shared _QRText As String
    <STAThread()> _
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New QrFormatter())
    End Sub
End Class
