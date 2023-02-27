Imports System.IO
Imports System.ComponentModel
Imports C1.Win.C1Win7Pack

Public Class Form1

    Private _exePath As String
    Private _destinationPrefix As String

    Private _jumpPathFiles As ArrayList
    Private _jumpLinkFiles As ArrayList

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Dim list As New ArrayList()
        list.Add("Athens.txt")
        list.Add("Berlin.txt")
        list.Add("London.txt")
        list.Add("Rome.txt")
        _jumpPathFiles = list

        list = New ArrayList()
        list.Add("computer.ico")
        list.Add("globe.ico")
        list.Add("messages.ico")
        list.Add("performance.ico")
        list.Add("users.ico")
        _jumpLinkFiles = list

        Dim s As String = Application.ExecutablePath
        Dim n As Int32 = s.LastIndexOf("\")
        n = s.LastIndexOf("\", n - 1)
        n = s.LastIndexOf("\", n - 1)
        _destinationPrefix = s.Substring(0, n + 1) + "Destinations\"
        _exePath = s

    End Sub

    Private Function CheckFileRegistration() As Boolean
        If Not registrationDialog.CheckBoxChecked Then
            If Not taskbarButton.CheckFileAssociations(".txt") Then
                registrationDialog.Show()
                If registrationDialog.DialogResult = TaskDialogResult.Cancel Then
                    Return False
                End If
                If registrationDialog.DialogResult = TaskDialogResult.Custom AndAlso _
                    registrationDialog.ClickedCustomButton.Name = "registerButton" Then
                    Return Register()
                End If
            End If
        End If
        Return True
    End Function

    Private Function Register() As Boolean
        '---------------------------------------------------------------
        ' ### requires level="requireAdministrator" in app.manifest ###
        '
        'taskbarButton.RegisterFileAssociations( _
        '    "Text Document", _
        '    "%systemroot%\system32\shell32.dll,284", _
        '    String.Format("""{0}"" ""%1""", _exePath), _
        '    ".txt")
        '---------------------------------------------------------------

        '---------------------------------------------------------------
        ' ### does not require elevated privileges for the main app ###

        Return InternalRegister(False, _exePath)

        '---------------------------------------------------------------
    End Function

    Private Sub Unregister()
        '---------------------------------------------------------------
        ' ### requires level="requireAdministrator" in app.manifest ###
        '
        'taskbarButton.UnregisterFileAssociations(".txt")
        '---------------------------------------------------------------

        '---------------------------------------------------------------
        ' ### does not require elevated privileges for the main app ###

        InternalRegister(True, Nothing)

        '---------------------------------------------------------------
    End Sub

    Private Shared Function InternalRegister(ByVal unregister As Boolean, ByVal fullPathToExe As String) As Boolean
        Dim psi As ProcessStartInfo = New ProcessStartInfo("RegistrationHelper.exe")
        If Not unregister Then
            psi.Arguments = String.Format("False ""{0}""", fullPathToExe)
        Else
            psi.Arguments = "True"
        End If
        psi.UseShellExecute = True
        psi.Verb = "runas"
        psi.WindowStyle = ProcessWindowStyle.Hidden
        Dim result As Boolean = False
        Try
            Process.Start(psi).WaitForExit()
            result = True
        Catch e As Win32Exception
        End Try
        Return result
    End Function

    Private Function JumpItemToString(ByVal item As C1JumpItem) As String
        Dim result As String = String.Empty
        If TypeOf item Is C1JumpLink Then
            result = CType(item, C1JumpLink).Title
        ElseIf TypeOf item Is C1JumpPath Then
            result = Path.GetFileName(CType(item, C1JumpPath).Path)
        End If
        Return result
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        comboKnownCategory.SelectedIndex = 0
        comboGetKnown.SelectedIndex = 0
    End Sub

    Private Sub comboKnownCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboKnownCategory.SelectedIndexChanged
        taskbarButton.JumpList.KnownCategory = CType(comboKnownCategory.SelectedIndex, JumpListKnownCategory)
    End Sub

    Private Sub rbKnownBeforeCustom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbKnownBeforeCustom.Click
        taskbarButton.JumpList.KnownCategoryPosition = KnownCategoryPosition.BeforeCustomCategories
    End Sub

    Private Sub rbKnownAfterCustom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbKnownAfterCustom.Click
        taskbarButton.JumpList.KnownCategoryPosition = KnownCategoryPosition.AfterCustomCategories
    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        Register()
    End Sub

    Private Sub btnUnregister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnregister.Click
        Unregister()
    End Sub

    Private Sub btnAddJumpPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddJumpPath.Click
        Dim categoryName As String = "JumpPath Category"
        Dim items As JumpItemCollection = taskbarButton.JumpList.Items
        For Each s As String In _jumpPathFiles
            Dim jumpPath As New C1JumpPath()
            jumpPath.CustomCategory = categoryName
            jumpPath.Path = _destinationPrefix + s
            items.Add(jumpPath)
        Next
        btnAddJumpPath.Enabled = False
    End Sub

    Private Sub btnAddJumpLink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddJumpLink.Click
        Dim categoryName As String = "JumpLink Category"
        Dim items As JumpItemCollection = taskbarButton.JumpList.Items
        For Each s As String In _jumpLinkFiles
            Dim link As C1JumpLink = New C1JumpLink()
            link.CustomCategory = categoryName
            link.ApplicationPath = _exePath
            link.Arguments = _destinationPrefix + s
            link.IconPath = link.Arguments
            link.Title = s
            link.Tooltip = link.Arguments
            items.Add(link)
        Next
        btnAddJumpLink.Enabled = False
    End Sub

    Private Sub btnApplyChanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApplyChanges.Click
        rejectedListBox.Items.Clear()
        removedListBox.Items.Clear()
        taskbarButton.JumpList.Apply()
    End Sub

    Private Sub taskbarButton_ApplyingJumpListChanges(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles taskbarButton.ApplyingJumpListChanges
        Dim foundShellItem As Boolean = False
        For Each item As C1JumpItem In taskbarButton.JumpList.Items
            If TypeOf item Is C1JumpPath Then
                foundShellItem = True
                Exit For
            End If
        Next
        If foundShellItem AndAlso Not CheckFileRegistration() Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnClearCustom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearCustom.Click
        Dim jumpList As C1JumpList = taskbarButton.JumpList
        jumpList.Items.Clear()
        jumpList.ClearTasksAndCustomCategories()
        rejectedListBox.Items.Clear()
        removedListBox.Items.Clear()
        btnAddJumpPath.Enabled = True
        btnAddJumpLink.Enabled = True
    End Sub

    Private Sub btnClearKnown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearKnown.Click
        Dim jumpList As C1JumpList = taskbarButton.JumpList
        jumpList.ClearKnownCategories()
        knownListBox.Items.Clear()
    End Sub

    Private Sub taskbarButton_JumpItemsRejected(ByVal sender As System.Object, ByVal e As C1.Win.C1Win7Pack.JumpItemsRejectedEventArgs) Handles taskbarButton.JumpItemsRejected
        rejectedListBox.BeginUpdate()
        rejectedListBox.Items.Clear()
        For i As Int32 = 0 To e.RejectedItems.Count - 1
            rejectedListBox.Items.Add(String.Format("{0}: {1}", _
                e.RejectionReasons(i), JumpItemToString(e.RejectedItems(i))))
        Next
        rejectedListBox.EndUpdate()
    End Sub

    Private Sub taskbarButton_JumpItemsRemovedByUser(ByVal sender As System.Object, ByVal e As C1.Win.C1Win7Pack.JumpItemsRemovedEventArgs) Handles taskbarButton.JumpItemsRemovedByUser
        removedListBox.BeginUpdate()
        removedListBox.Items.Clear()
        For Each item As C1JumpItem In e.RemovedItems
            removedListBox.Items.Add(JumpItemToString(item))
        Next
        removedListBox.EndUpdate()
    End Sub

    Private Sub btnGetKnown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetKnown.Click
        Dim category As JumpListKnownCategory = CType(comboGetKnown.SelectedIndex + 1, JumpListKnownCategory)
        knownListBox.BeginUpdate()
        knownListBox.Items.Clear()
        For Each item As C1JumpItem In taskbarButton.JumpList.GetKnownCategoryItems(category)
            knownListBox.Items.Add(JumpItemToString(item))
        Next
        knownListBox.EndUpdate()
    End Sub
End Class
