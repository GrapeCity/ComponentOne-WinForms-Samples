Public Class SmsCode


    ' Fields...
    ' Properties...



    Public Property SmsCode() As String
    
    Public Property SmsBody() As String
    
    Public Property SMSTelephoneNumber() As String


    Public Sub CreateSmsCode()
        SmsCode = String.Format("SMSTO:{0}:{1}", SMSTelephoneNumber, SmsBody)
    End Sub


End Class
