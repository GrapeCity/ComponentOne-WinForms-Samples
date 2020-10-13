Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.IO

Friend NotInheritable Class Program

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    Private Sub New()
    End Sub

    <STAThread()>
    Shared Sub Main(ByVal args As String())

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        If args.Length = 1 Then
            Dim filePath As String = args(0)
            If File.Exists(filePath) Then
                PreviewForm.SetStartupFilePath(filePath)
            Else
                MessageBox.Show(String.Format("""{0}"" does not exist.", filePath),
                    PreviewForm.FormTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If

        Application.Run(New PreviewForm())
    End Sub

End Class
