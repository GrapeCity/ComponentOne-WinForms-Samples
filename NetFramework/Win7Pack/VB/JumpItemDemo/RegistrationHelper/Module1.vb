Imports Microsoft.Win32

Module Module1

    Sub Main(ByVal cmdArgs() As String)

        Try
            Dim progID As String = "C1TaskbarDemo"
            Dim extension As String = ".txt"
            If cmdArgs.Length > 0 AndAlso System.Boolean.Parse(cmdArgs(0)) Then
                UnregisterFileAssociations(progID, extension)
            ElseIf cmdArgs.Length < 2 Then
                Console.WriteLine("Usage: <Unregister: true|false> <FullPathToExeFile>")
                Console.ReadLine()
            Else
                Dim appID As String = "JumpItemDemo"
                Dim friendlyName As String = "Text Document"
                Dim defaultIcon As String = "%systemroot%\\system32\\shell32.dll,284"
                Dim openWithCommand As String = String.Format("""{0}"" ""%1""", cmdArgs(1))
                RegisterFileAssociations(progID, appID, friendlyName, defaultIcon, openWithCommand, extension)
            End If
        Catch e As Exception
            Console.WriteLine(e.ToString())
            Console.ReadLine()
        End Try

    End Sub

    ''' <summary>
    ''' Registers file associations for the current application.
    ''' </summary>
    ''' <param name="progID">Name of the Registry key to be associated with the application.</param>
    ''' <param name="appID">The application user model ID.</param>
    ''' <param name="friendlyName">A friendly name for the data format, suitable to display to a user.</param>
    ''' <param name="defaultIcon">The path to the default icon, such as, "%systemroot%\system32\imageres.dll,15".</param>
    ''' <param name="openWithCommand">The command and arguments to be used when opening a shortcut to a document, such as,
    ''' '"C:\Program Files\Paint.NET\PaintDotNet.exe" "%1"'.</param>
    ''' <param name="extension">The extensions to register, such as '.png'.</param>
    Public Sub RegisterFileAssociations(ByVal progID As String, ByVal appID As String, _
                                        ByVal friendlyName As String, ByVal defaultIcon As String, _
                                        ByVal openWithCommand As String, ByVal extension As String)
        If IsNullOrWhiteSpace(progID) Then
            Throw New ArgumentException("The 'progID' argument must not be an empty string.", "progID")
        End If
        If IsNullOrWhiteSpace(openWithCommand) Then
            Throw New ArgumentException("The 'openWithCmd' argument must not be an empty string.", "openWithCmd")
        End If
        Dim classesRoot As RegistryKey = Registry.ClassesRoot
        Dim progKey As RegistryKey = classesRoot.CreateSubKey(progID)
        If Not IsNullOrWhiteSpace(friendlyName) Then
            progKey.SetValue(String.Empty, friendlyName)
        End If
        If Not IsNullOrWhiteSpace(appID) Then
            progKey.SetValue("AppUserModelID", appID)
        End If
        If Not IsNullOrWhiteSpace(defaultIcon) Then
            Dim diKey As RegistryKey = progKey.CreateSubKey("DefaultIcon")
            diKey.SetValue(String.Empty, defaultIcon)
            diKey.Close()
        End If
        Dim shellKey As RegistryKey = progKey.CreateSubKey("shell")
        shellKey = shellKey.CreateSubKey("Open")
        shellKey = shellKey.CreateSubKey("Command")
        shellKey.SetValue(String.Empty, openWithCommand)
        shellKey.Close()
        progKey.Close()
        If Not IsNullOrWhiteSpace(extension) Then
            Dim openWithKey As RegistryKey = classesRoot.CreateSubKey(extension + "\\OpenWithProgids")
            openWithKey.SetValue(progID, String.Empty)
            openWithKey.Close()
        End If
    End Sub

    ''' <summary>
    ''' Unregisters file associations for the application.
    ''' </summary>
    ''' <param name="progID">Name of the Registry key that is currently associated with the application.</param>
    ''' <param name="extension">The extensions to unregister.</param>
    Public Sub UnregisterFileAssociations(ByVal progID As String, ByVal extension As String)
        If IsNullOrWhiteSpace(progID) Then
            Throw New ArgumentException("The 'progID' argument must not be an empty string.", "progID")
        End If
        Dim classesRoot As RegistryKey = Registry.ClassesRoot
        If Not IsNullOrWhiteSpace(extension) Then
            Dim openWithKey As RegistryKey = classesRoot.CreateSubKey(extension + "\\OpenWithProgids")
            openWithKey.DeleteValue(progID, False)
            openWithKey.Close()
        End If
        Dim key As RegistryKey = classesRoot.OpenSubKey(progID)
        If key IsNot Nothing Then
            classesRoot.DeleteSubKeyTree(progID)
        End If
    End Sub

    Private Function IsNullOrWhiteSpace(ByVal s As String) As Boolean
        If s IsNot Nothing Then
            For i As Int32 = 0 To s.Length - 1
                If Not Char.IsWhiteSpace(s(i)) Then
                    Return False
                End If
            Next
        End If
        Return True
    End Function

End Module
