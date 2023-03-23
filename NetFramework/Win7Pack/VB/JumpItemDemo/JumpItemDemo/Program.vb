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

    <STAThread()> _
    Shared Sub Main(ByVal args As String())

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        If args.Length > 0 Then
            Dim fileName As String = Path.GetFileName(args(0))
            MessageBox.Show(String.Format("""{0}"" passed as an argument to the application.", fileName), _
                "C1JumpList Destinations", _
                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Application.Run(New Form1())
    End Sub
End Class
