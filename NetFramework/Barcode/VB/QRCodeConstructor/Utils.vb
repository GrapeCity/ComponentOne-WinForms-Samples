Imports System.Text.RegularExpressions

Public Class Utils



    ' <summary>
    ' Regular expression, which is used to validate an E-Mail address.
    '</summary>
    Public Const MatchEmailPattern As String = "^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,6})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$"

    ''' <summary>
    ''' Checks the validity of the Email Address.
    ''' </summary>
    ''' <param name="emailAddress">The email address.</param>
    ''' <returns>True if valid, false if not.</returns>
    Public Shared Function EmailAddressIsValid(ByVal emailAddress As String) As Boolean

        'verifies  the validity of an e mail address.  This pattern will verify as positive addresses that contain
        'an apostrophe. Accepts the e mail address as a parameter and returns a Boolean.

        Dim emailaddressmatch As Match = Regex.Match(emailAddress, MatchEmailPattern)
        If emailaddressmatch.Success Then
            'this returns true as soon as you have one letter after the .  which means its not reall checking the .co.uk for example
            Return True
        Else
            'Dim mymsg As String = "The E Mail address that you have entered does meet validation criteria" & vbCrLf _
            '                    & "Please try again."
            'MessageBox.Show(mymsg, "Invalid E Mail Address", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

    End Function
End Class
