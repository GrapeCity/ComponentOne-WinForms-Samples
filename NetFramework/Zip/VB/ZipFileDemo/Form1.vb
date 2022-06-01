Imports System
Imports System.IO
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.Text.RegularExpressions

Imports C1.Zip


Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call

    End Sub

    ' Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    Friend WithEvents listView As System.Windows.Forms.ListView
    Friend WithEvents chName As System.Windows.Forms.ColumnHeader
    Friend WithEvents chExtension As System.Windows.Forms.ColumnHeader
    Friend WithEvents chDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents chSize As System.Windows.Forms.ColumnHeader
    Friend WithEvents chSizeCompr As System.Windows.Forms.ColumnHeader
    Friend WithEvents chAttrib As System.Windows.Forms.ColumnHeader
    Friend WithEvents chCRC32 As System.Windows.Forms.ColumnHeader
    Friend WithEvents chComment As System.Windows.Forms.ColumnHeader
    Friend WithEvents statusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuNewZip As System.Windows.Forms.MenuItem
    Friend WithEvents mnuOpenZip As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCloseZip As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep0 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSelect As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSelectAll As System.Windows.Forms.MenuItem
    Friend WithEvents mnuUnselectAll As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInvertSelection As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSelectGroup As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCommand As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExtract As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep3 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAddFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAddFolder As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep4 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTestZipFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep5 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEditComment As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLevel As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPassword As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEditZipComment As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEditEntryComment As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLevelDefault As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLevelBest As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLevelFast As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLevelNone As System.Windows.Forms.MenuItem
    Friend WithEvents mnuView As System.Windows.Forms.MenuItem
    Friend WithEvents mnuViewLarge As System.Windows.Forms.MenuItem
    Friend WithEvents mnuViewSmall As System.Windows.Forms.MenuItem
    Friend WithEvents mnuViewList As System.Windows.Forms.MenuItem
    Friend WithEvents mnuViewDetail As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep6 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuViewEntry As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.MenuItem
    Friend WithEvents imageListLarge As System.Windows.Forms.ImageList
    Friend WithEvents imageListSmall As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.listView = New System.Windows.Forms.ListView()
        Me.chName = New System.Windows.Forms.ColumnHeader()
        Me.chExtension = New System.Windows.Forms.ColumnHeader()
        Me.chDate = New System.Windows.Forms.ColumnHeader()
        Me.chSize = New System.Windows.Forms.ColumnHeader()
        Me.chSizeCompr = New System.Windows.Forms.ColumnHeader()
        Me.chAttrib = New System.Windows.Forms.ColumnHeader()
        Me.chCRC32 = New System.Windows.Forms.ColumnHeader()
        Me.chComment = New System.Windows.Forms.ColumnHeader()
        Me.imageListLarge = New System.Windows.Forms.ImageList(Me.components)
        Me.imageListSmall = New System.Windows.Forms.ImageList(Me.components)
        Me.statusBar1 = New System.Windows.Forms.StatusBar()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuNewZip = New System.Windows.Forms.MenuItem()
        Me.mnuOpenZip = New System.Windows.Forms.MenuItem()
        Me.mnuCloseZip = New System.Windows.Forms.MenuItem()
        Me.mnuSep0 = New System.Windows.Forms.MenuItem()
        Me.mnuExit = New System.Windows.Forms.MenuItem()
        Me.mnuSelect = New System.Windows.Forms.MenuItem()
        Me.mnuSelectAll = New System.Windows.Forms.MenuItem()
        Me.mnuUnselectAll = New System.Windows.Forms.MenuItem()
        Me.mnuSep1 = New System.Windows.Forms.MenuItem()
        Me.mnuInvertSelection = New System.Windows.Forms.MenuItem()
        Me.mnuSelectGroup = New System.Windows.Forms.MenuItem()
        Me.mnuCommand = New System.Windows.Forms.MenuItem()
        Me.mnuExtract = New System.Windows.Forms.MenuItem()
        Me.mnuDelete = New System.Windows.Forms.MenuItem()
        Me.mnuSep3 = New System.Windows.Forms.MenuItem()
        Me.mnuAddFile = New System.Windows.Forms.MenuItem()
        Me.mnuAddFolder = New System.Windows.Forms.MenuItem()
        Me.mnuSep4 = New System.Windows.Forms.MenuItem()
        Me.mnuTestZipFile = New System.Windows.Forms.MenuItem()
        Me.mnuSep5 = New System.Windows.Forms.MenuItem()
        Me.mnuEditComment = New System.Windows.Forms.MenuItem()
        Me.mnuEditZipComment = New System.Windows.Forms.MenuItem()
        Me.mnuEditEntryComment = New System.Windows.Forms.MenuItem()
        Me.mnuLevel = New System.Windows.Forms.MenuItem()
        Me.mnuLevelDefault = New System.Windows.Forms.MenuItem()
        Me.mnuLevelBest = New System.Windows.Forms.MenuItem()
        Me.mnuLevelFast = New System.Windows.Forms.MenuItem()
        Me.mnuLevelNone = New System.Windows.Forms.MenuItem()
        Me.mnuPassword = New System.Windows.Forms.MenuItem()
        Me.mnuView = New System.Windows.Forms.MenuItem()
        Me.mnuViewLarge = New System.Windows.Forms.MenuItem()
        Me.mnuViewSmall = New System.Windows.Forms.MenuItem()
        Me.mnuViewList = New System.Windows.Forms.MenuItem()
        Me.mnuViewDetail = New System.Windows.Forms.MenuItem()
        Me.mnuSep6 = New System.Windows.Forms.MenuItem()
        Me.mnuViewEntry = New System.Windows.Forms.MenuItem()
        Me.mnuHelp = New System.Windows.Forms.MenuItem()
        Me.mnuAbout = New System.Windows.Forms.MenuItem()
        Me.SuspendLayout()
        '
        'listView
        '
        Me.listView.AllowColumnReorder = True
        Me.listView.AllowDrop = True
        Me.listView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chName, Me.chExtension, Me.chDate, Me.chSize, Me.chSizeCompr, Me.chAttrib, Me.chCRC32, Me.chComment})
        Me.listView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listView.FullRowSelect = True
        Me.listView.LargeImageList = Me.imageListLarge
        Me.listView.Name = "listView"
        Me.listView.Size = New System.Drawing.Size(688, 374)
        Me.listView.SmallImageList = Me.imageListSmall
        Me.listView.TabIndex = 1
        Me.listView.View = System.Windows.Forms.View.Details
        '
        'chName
        '
        Me.chName.Text = "Name"
        Me.chName.Width = 150
        '
        'chExtension
        '
        Me.chExtension.Text = "Ext"
        Me.chExtension.Width = 40
        '
        'chDate
        '
        Me.chDate.Text = "Date"
        Me.chDate.Width = 100
        '
        'chSize
        '
        Me.chSize.Text = "Size"
        Me.chSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chSizeCompr
        '
        Me.chSizeCompr.Text = "Compr"
        Me.chSizeCompr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chAttrib
        '
        Me.chAttrib.Text = "Attrib"
        '
        'chCRC32
        '
        Me.chCRC32.Text = "CRC32"
        Me.chCRC32.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chCRC32.Width = 80
        '
        'chComment
        '
        Me.chComment.Text = "Comment"
        Me.chComment.Width = 500
        '
        'imageListLarge
        '
        Me.imageListLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit
        Me.imageListLarge.ImageSize = New System.Drawing.Size(32, 32)
        Me.imageListLarge.ImageStream = CType(resources.GetObject("imageListLarge.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageListLarge.TransparentColor = System.Drawing.Color.Red
        '
        'imageListSmall
        '
        Me.imageListSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit
        Me.imageListSmall.ImageSize = New System.Drawing.Size(16, 16)
        Me.imageListSmall.ImageStream = CType(resources.GetObject("imageListSmall.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageListSmall.TransparentColor = System.Drawing.Color.Red
        '
        'statusBar1
        '
        Me.statusBar1.Location = New System.Drawing.Point(0, 352)
        Me.statusBar1.Name = "statusBar1"
        Me.statusBar1.Size = New System.Drawing.Size(688, 22)
        Me.statusBar1.TabIndex = 2
        Me.statusBar1.Text = "12 Files in Archive, 3 selected, 23k bytes"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuSelect, Me.mnuCommand, Me.mnuView, Me.mnuHelp})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuNewZip, Me.mnuOpenZip, Me.mnuCloseZip, Me.mnuSep0, Me.mnuExit})
        Me.mnuFile.Text = "&File"
        '
        'mnuNewZip
        '
        Me.mnuNewZip.Index = 0
        Me.mnuNewZip.Text = "&New..."
        '
        'mnuOpenZip
        '
        Me.mnuOpenZip.Index = 1
        Me.mnuOpenZip.Text = "&Open..."
        '
        'mnuCloseZip
        '
        Me.mnuCloseZip.Index = 2
        Me.mnuCloseZip.Text = "&Close"
        '
        'mnuSep0
        '
        Me.mnuSep0.Index = 3
        Me.mnuSep0.Text = "-"
        '
        'mnuExit
        '
        Me.mnuExit.Index = 4
        Me.mnuExit.Text = "E&xit"
        '
        'mnuSelect
        '
        Me.mnuSelect.Index = 1
        Me.mnuSelect.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuSelectAll, Me.mnuUnselectAll, Me.mnuSep1, Me.mnuInvertSelection, Me.mnuSelectGroup})
        Me.mnuSelect.Text = "&Select"
        '
        'mnuSelectAll
        '
        Me.mnuSelectAll.Index = 0
        Me.mnuSelectAll.Text = "Select &All"
        '
        'mnuUnselectAll
        '
        Me.mnuUnselectAll.Index = 1
        Me.mnuUnselectAll.Text = "&Unselect All"
        '
        'mnuSep1
        '
        Me.mnuSep1.Index = 2
        Me.mnuSep1.Text = "-"
        '
        'mnuInvertSelection
        '
        Me.mnuInvertSelection.Index = 3
        Me.mnuInvertSelection.Text = "&Invert Selection"
        '
        'mnuSelectGroup
        '
        Me.mnuSelectGroup.Index = 4
        Me.mnuSelectGroup.Text = "Select &Group..."
        '
        'mnuCommand
        '
        Me.mnuCommand.Index = 2
        Me.mnuCommand.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuExtract, Me.mnuDelete, Me.mnuSep3, Me.mnuAddFile, Me.mnuAddFolder, Me.mnuSep4, Me.mnuTestZipFile, Me.mnuSep5, Me.mnuEditComment, Me.mnuLevel, Me.mnuPassword})
        Me.mnuCommand.Text = "&Command"
        '
        'mnuExtract
        '
        Me.mnuExtract.Index = 0
        Me.mnuExtract.Text = "&Extract"
        '
        'mnuDelete
        '
        Me.mnuDelete.Index = 1
        Me.mnuDelete.Text = "&Delete"
        '
        'mnuSep3
        '
        Me.mnuSep3.Index = 2
        Me.mnuSep3.Text = "-"
        '
        'mnuAddFile
        '
        Me.mnuAddFile.Index = 3
        Me.mnuAddFile.Text = "&Add Files..."
        '
        'mnuAddFolder
        '
        Me.mnuAddFolder.Index = 4
        Me.mnuAddFolder.Text = "Add &Folder..."
        '
        'mnuSep4
        '
        Me.mnuSep4.Index = 5
        Me.mnuSep4.Text = "-"
        '
        'mnuTestZipFile
        '
        Me.mnuTestZipFile.Index = 6
        Me.mnuTestZipFile.Text = "&Test All Files"
        '
        'mnuSep5
        '
        Me.mnuSep5.Index = 7
        Me.mnuSep5.Text = "-"
        '
        'mnuEditComment
        '
        Me.mnuEditComment.Index = 8
        Me.mnuEditComment.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuEditZipComment, Me.mnuEditEntryComment})
        Me.mnuEditComment.Text = "Edit &Comment"
        '
        'mnuEditZipComment
        '
        Me.mnuEditZipComment.Index = 0
        Me.mnuEditZipComment.Text = "Zip File"
        '
        'mnuEditEntryComment
        '
        Me.mnuEditEntryComment.Index = 1
        Me.mnuEditEntryComment.Text = "Entries"
        '
        'mnuLevel
        '
        Me.mnuLevel.Index = 9
        Me.mnuLevel.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuLevelDefault, Me.mnuLevelBest, Me.mnuLevelFast, Me.mnuLevelNone})
        Me.mnuLevel.Text = "Compression Level"
        '
        'mnuLevelDefault
        '
        Me.mnuLevelDefault.Checked = True
        Me.mnuLevelDefault.Index = 0
        Me.mnuLevelDefault.Text = "&Default"
        '
        'mnuLevelBest
        '
        Me.mnuLevelBest.Index = 1
        Me.mnuLevelBest.Text = "Best &Compression"
        '
        'mnuLevelFast
        '
        Me.mnuLevelFast.Index = 2
        Me.mnuLevelFast.Text = "Best &Speed"
        '
        'mnuLevelNone
        '
        Me.mnuLevelNone.Index = 3
        Me.mnuLevelNone.Text = "&No Compression"
        '
        'mnuPassword
        '
        Me.mnuPassword.Index = 10
        Me.mnuPassword.Text = "&Password"
        '
        'mnuView
        '
        Me.mnuView.Index = 3
        Me.mnuView.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuViewLarge, Me.mnuViewSmall, Me.mnuViewList, Me.mnuViewDetail, Me.mnuSep6, Me.mnuViewEntry})
        Me.mnuView.Text = "&View"
        '
        'mnuViewLarge
        '
        Me.mnuViewLarge.Index = 0
        Me.mnuViewLarge.Text = "&Large Icons"
        '
        'mnuViewSmall
        '
        Me.mnuViewSmall.Index = 1
        Me.mnuViewSmall.Text = "&Small Icons"
        '
        'mnuViewList
        '
        Me.mnuViewList.Index = 2
        Me.mnuViewList.Text = "&List"
        '
        'mnuViewDetail
        '
        Me.mnuViewDetail.Checked = True
        Me.mnuViewDetail.Index = 3
        Me.mnuViewDetail.Text = "&Detail"
        '
        'mnuSep6
        '
        Me.mnuSep6.Index = 4
        Me.mnuSep6.Text = "-"
        '
        'mnuViewEntry
        '
        Me.mnuViewEntry.Index = 5
        Me.mnuViewEntry.Text = "&Current Entry..."
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 4
        Me.mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAbout})
        Me.mnuHelp.Text = "&Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Index = 0
        Me.mnuAbout.Text = "&About..."
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(688, 374)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.statusBar1, Me.listView})
        Me.KeyPreview = True
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1Zip Demo"
        Me.ResumeLayout(False)

    End Sub

#End Region
    ' Private Fields
    ' 
    Private _zipfile As C1ZipFile = New C1ZipFile() ' The Zipfile
    Private _appTitle As String = "C1Zip Demo"      ' the caption
    Private _escape As Boolean = False              ' user hit escape
    Private _cancel As Boolean = False              ' user wants to cancel

    ' create a new zip file
    Private Sub mnuNewZip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNewZip.Click

        ' show file open dialog
        Dim sf As SaveFileDialog = New SaveFileDialog()
        sf.DefaultExt = "zip"
        sf.Filter = "Zip Files (*.zip)|*.zip"
        If sf.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then Return

        ' create a new empty zip file
        _zipfile.Create(sf.FileName)

        ' update user interface
        UpdateUI()

    End Sub

    ' open an existing Zip File
    Private Sub mnuOpenZip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpenZip.Click

        ' select zip file
        Dim [of] As OpenFileDialog = New OpenFileDialog()
        [of].DefaultExt = "zip"
        [of].Filter = "Zip Files (*.zip)|*.zip"
        If [of].ShowDialog <> System.Windows.Forms.DialogResult.OK Then Return

        ' open zip file
        OpenZip([of].FileName)

    End Sub

    Private Sub OpenZip(ByVal fn As String)

        ' make sure this is a valid zip file
        If Not File.Exists(fn) Then Return
        If Path.GetExtension(fn).ToLower() <> ".zip" Then Return

        ' open zip file
        _zipfile.Open(fn)

        ' update user interface
        UpdateUI()

    End Sub

    ' close zip file
    Private Sub mnuCloseZip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCloseZip.Click
        _zipfile.Close()
        UpdateUI()
    End Sub

    ' exit application
    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub

    ' select all files in the current zip file
    Private Sub mnuSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSelectAll.Click
        Dim lvi As ListViewItem
        For Each lvi In listView.Items
            lvi.Selected = True
        Next
    End Sub

    ' unselect all files in the current zip file
    Private Sub mnuUnselectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUnselectAll.Click
        Dim lvi As ListViewItem
        For Each lvi In listView.Items
            lvi.Selected = False
        Next
    End Sub

    ' invert selection
    Private Sub mnuInvertSelection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInvertSelection.Click
        Dim lvi As ListViewItem
        For Each lvi In listView.Items
            lvi.Selected = Not lvi.Selected
        Next
    End Sub

    ' select a group of files in the current zip file
    Private Sub mnuSelectGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSelectGroup.Click

        ' make sure we have some files...
        If listView.Items.Count = 0 Then Return

        ' get mask for expanding selection
        Dim dlg As UserInputDialog = New UserInputDialog()
        Dim mask As String = dlg.GetString("Expand Selection", "*.*")
        If mask Is Nothing Then Return

        ' add an extension if we don' t have one
        If (mask.IndexOf(".") < 0) Then mask = mask + "."

        ' escape/replace reserved regexp characters
        Dim rxchars As String = "\\.$()"
        Dim i As Integer
        For i = 0 To rxchars.Length - 1
            mask = mask.Replace(rxchars.Chars(i).ToString(), "\\" + rxchars.Chars(i))
        Next
        mask = mask.Replace("*", ".*")
        mask = mask.Replace("?", ".")

        ' build regexp object
        mask = "^" + mask + "$"
        Dim rx As Regex = New Regex(mask, RegexOptions.IgnoreCase)

        ' remove single selection, if any
        If listView.SelectedItems.Count = 1 Then
            Me.mnuUnselectAll_Click(Nothing, Nothing)
        End If

        ' select files
        Dim lvi As ListViewItem
        For Each lvi In listView.Items
            Dim ze As C1ZipEntry = CType(lvi.Tag, C1ZipEntry)
            If rx.IsMatch(ze.FileName) Then
                lvi.Selected = True
            End If
        Next
    End Sub


    Dim zip As C1ZipFile = New C1ZipFile()
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' hook up menu
        Me.Menu = Me.MainMenu1

        ' hook up event handler to show progress while compressing/expanding files
        AddHandler zip.Progress, AddressOf Me._zip_Progress

        ' initialize UI
        UpdateUI()
    End Sub

    ' c1Zip progress event handler, shows progress while compressing/expanding files
    Private Sub _zip_Progress(ByVal sender As System.Object, ByVal e As C1.Zip.ZipProgressEventArgs)

        Dim pct As Integer = (100 * e.Position) / e.FileLength
        Console.WriteLine("{0}: {1}%", e.FileName, pct)

    End Sub

    ' handle keyboard to select files and cancel zip operation
    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Select Case e.KeyChar
            Case "+"
                Me.mnuSelectGroup_Click(Nothing, Nothing)
                e.Handled = True
            Case Chr(27)
                _escape = True
                e.Handled = True
        End Select

    End Sub

    ' check whether the user really wants to cancel the current operation
    Private Function CheckUserCancel() As Boolean

        Application.DoEvents()
        If _escape Then
            _escape = False
            Dim dr As DialogResult = MessageBox.Show("Do you want to Cancel the current operation?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            _cancel = (dr = System.Windows.Forms.DialogResult.Yes)
        End If
        Return _cancel

    End Function

    ' extract files from zip file
    Private Sub mnuExtract_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuExtract.Click
        Dim defFolder As String = Path.GetDirectoryName(_zipfile.FileName)
        Dim folder As String = String.Empty

        While True

            ' show dialog 
            Dim dlg As UserInputDialog = New UserInputDialog()
            folder = dlg.GetString("Choose a destination folder", defFolder)

            ' if canceled, we' re done
            If folder Is Nothing Then Return

            ' if folder is empty, use default
            If folder = "" Then folder = defFolder

            ' if folder is valid, break out of loop
            If Directory.Exists(folder) Then Exit While

            ' warn user about invalid folder
            Dim dr As DialogResult
            dr = MessageBox.Show("Sorry, this is not a valid folder", "Extract Files", MessageBoxButtons.RetryCancel)
            If dr = System.Windows.Forms.DialogResult.Cancel Then Return
        End While

        ' make sure folder name ends with a directory separator
        If Not folder.EndsWith(Path.DirectorySeparatorChar.ToString()) Then
            folder = folder + Path.DirectorySeparatorChar
        End If

        ' extract files
        Dim lvi As ListViewItem
        For Each lvi In listView.SelectedItems
            Dim ze As C1ZipEntry = CType(lvi.Tag, C1ZipEntry)
            Dim dstFileName As String = folder + Path.GetFileName(ze.FileName)
            _zipfile.Entries.Extract(ze.FileName, dstFileName)
        Next

    End Sub

    ' delete files from the current zip file
    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click

        ' build an array of strings containing the selected file names
        Dim files As ArrayList = New ArrayList()
        Dim lvi As ListViewItem
        For Each lvi In listView.SelectedItems
            Dim ze As C1ZipEntry = CType(lvi.Tag, C1ZipEntry)
            files.Add(ze.FileName)
        Next

        ' remove entries from the zip file
        ' (this is a lot quicker than removing the file one by one)
        Dim arr() As String = CType(files.ToArray(GetType(String)), String())
        _zipfile.Entries.Remove(arr)

        ' update user interface
        UpdateUI()

    End Sub

    ' add files to zip file
    Private Sub mnuAddFile_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuAddFile.Click

        ' show file picker dialog 
        Dim [of] As OpenFileDialog = New OpenFileDialog()
        [of].Multiselect = True
        If [of].ShowDialog <> System.Windows.Forms.DialogResult.OK Then Return

        ' if encryption is to be used, warn user
        If _zipfile.Password.Length > 0 Then

            Dim msg As String = "File(s) will be encrypted" + vbCrLf + _
                                "Current password: " + _zipfile.Password
            Dim dr As DialogResult = MessageBox.Show(msg, "Add Files", MessageBoxButtons.OKCancel)
            If dr = System.Windows.Forms.DialogResult.Cancel Then Return
        End If

        ' add the files
        AddFileList([of].FileNames, 0)

    End Sub

    ' add a whole folder to the current zip file
    Private Sub mnuAddFolder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuAddFolder.Click
        Dim defFolder As String = Path.GetDirectoryName(_zipfile.FileName)
        Dim folder As String = String.Empty

        ' get a folder name from user
        While True

            ' show dialog 
            Dim dlg As UserInputDialog = New UserInputDialog()
            folder = dlg.GetString("Add Folder", defFolder)

            ' if canceled, we' re done
            If folder Is Nothing Then Return

            ' if folder is valid, break out of the loop
            If Directory.Exists(folder) Then Exit While

            ' warn user about invalid folder
            Dim dr As DialogResult
            dr = MessageBox.Show("Sorry, this is not a valid folder", "Add Folder", MessageBoxButtons.RetryCancel)
            If dr = System.Windows.Forms.DialogResult.Cancel Then Return
        End While

        ' if encryption is to be used, warn user
        If _zipfile.Password.Length > 0 Then
            Dim msg As String = "File(s) will be encrypted! " + vbCrLf + _
                                "Current password: " + _zipfile.Password
            Dim dr As DialogResult = MessageBox.Show(msg, "Add Folder", MessageBoxButtons.OKCancel)
            If dr = System.Windows.Forms.DialogResult.Cancel Then Return
        End If

        ' freeze display while adding folders
        ' (if they have many subfolders, there' s too much painting going on
        _freezelist = True

        ' add folder
        _cancel = False
        _escape = False
        AddFolder(folder)

        ' display list
        _freezelist = False
        UpdateUI()
    End Sub

    ' add a folder to the zip file
    Private Sub AddFolder(ByVal folderName As String)
        AddFolder(folderName, 0)
    End Sub
    Private Sub AddFolder(ByVal folderName As String, ByVal pathLevels As Integer)

        ' make sure folder name ends with DirectorySeparatorChar
        If Not folderName.EndsWith(Path.DirectorySeparatorChar.ToString()) Then
            folderName = folderName + Path.DirectorySeparatorChar
        End If

        ' bump up pathLevels to keep the folder name
        pathLevels = pathLevels + 1

        ' user cancelled?
        If _cancel Then Return

        ' create an empty entry with the folder name
        _zipfile.Entries.Add(folderName, pathLevels)

        ' user cancelled?
        If _cancel Then Return

        ' add files within this folder
        Dim files() As String = Directory.GetFiles(folderName)
        AddFileList(files, pathLevels)

        ' user cancelled?
        If _cancel Then Return

        ' add sub folders within this folder
        Dim subfolders() As String = Directory.GetDirectories(folderName)
        Dim i As Integer
        For i = 0 To subfolders.Length - 1
            AddFolder(subfolders(i), pathLevels)
        Next
    End Sub

    ' add a list of files to the zip file, keeping the specified pathLevels
    Private Sub AddFileList(ByVal files() As String, ByVal pathLevels As Integer)

        ' keep track of errors and time execution 
        Dim err As String = ""
        Dim start As Long = DateTime.Now.Ticks

        ' add files
        Dim file As String
        For Each file In files

            ' update UI
            UpdateStatusBar("Adding file " + file)
            If CheckUserCancel() Then Exit For

            ' add the file 
            Dim x As Exception
            Try
                _zipfile.Entries.Add(file, pathLevels)
                Application.DoEvents()
            Catch x
                err = err + vbCrLf + x.Message
            End Try
        Next

        ' cancel? we' re done
        If _cancel Then Return

        ' warn user of any problems
        If err.Length > 0 Then
            MessageBox.Show(err, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        ' update user interface
        UpdateUI()

        ' show how long it took
        Dim sec As Double = (DateTime.Now.Ticks - start) / CType(TimeSpan.TicksPerSecond, Double)
        Dim meg As Double = 0
        If sec > 1 Then
            For Each file In files
                Dim ze As C1ZipEntry = _zipfile.Entries(Path.GetFileName(file))
                If Not ze Is Nothing Then
                    meg = meg + ze.SizeCompressed
                End If
            Next
            meg = meg \ (1024.0 * 1024.0)
            UpdateStatusBar(String.Format("Compressed in {0:0.00}seconds, {1:0.00} meg/second", sec, meg / sec))

        End If
    End Sub

    ' show the about box
    Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click

        MessageBox.Show("C1Zip Demo " + vbCrLf + "Copyright (c) 2003 ComponentOne LLC", "About C1ZipDemo", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' just to show how to add directly into the zip file:
        If _zipfile.FileName <> "" Then

            ' open compressed stream writer into the zip file
            Dim s As Stream = _zipfile.Entries.OpenWriter("About", True)

            ' write stuff into it
            Dim i As Integer
            Dim count As Integer = 1000
            Dim sw As StreamWriter = New StreamWriter(s)
            For i = 1 To count
                sw.WriteLine("({0}/{1}) this is being written to a compressed stream.", i, count)
            Next
            sw.Flush()
            s.Close()

            ' test adding streams
            Dim ms As MemoryStream = New MemoryStream()
            Dim msw As StreamWriter = New StreamWriter(ms)
            For i = 1 To count
                msw.WriteLine("({0}/{1}) This is being written to a memory stream.", i, count)
            Next
            msw.Flush()
            ms.Position = 0
            _zipfile.Entries.Add(ms, "MemStream")
            ms.Close()

            ' show what we got
            UpdateUI()

        End If
    End Sub

    ' drag over
    Private Sub listView_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles listView.DragOver

        ' if the data object contains files, allow copy
        If e.Data.GetDataPresent("FileDrop") Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If

    End Sub

    ' drag and drop
    Private Sub listView_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles listView.DragDrop

        ' check whether data object contains files
        Dim fmt As String = "FileDrop"
        If Not e.Data.GetDataPresent(fmt) Then Return

        ' get list of files in data object
        Dim files As Array = CType(e.Data.GetData(fmt), Array)
        If files Is Nothing Then Return

        ' get ready to work
        _cancel = _escape = False

        ' if we have a zip file ready, add the dragged files to it
        If _zipfile.FileName.Length > 0 Then

            ' freeze display while adding folders
            ' if there are many subfolders, there's a lot of painting going on
            _freezelist = True

            ' add dropped files and folders
            Dim file As String
            For Each file In files
                If System.IO.File.Exists(file) Then ' add file
                    _zipfile.Entries.Add(file)
                ElseIf Directory.Exists(file) Then ' add folder
                    AddFolder(file)
                End If

                ' check user 
                If CheckUserCancel() Then Return
            Next

            ' show new list 
            _freezelist = False
            UpdateUI()

        Else  ' if we don' t have a zip file ready, and the dragged files contain a zip file, open it

            Dim file As String
            For Each file In files
                If Path.GetExtension(file.ToLower() = ".zip") Then
                    OpenZip(file)
                    Return
                End If
            Next

            If _zipfile.FileName.Length = 0 Then
                MessageBox.Show("Please open (or create) a zip file first.", "No Zip file")
            End If
        End If

    End Sub

    ' sort list of files in the list view
    Dim _ascending As Boolean = True
    Private Sub listView_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles listView.ColumnClick

        ' create EntryComparer for the column that was clicked
        Dim colName As String = listView.Columns(e.Column).Text
        listView.ListViewItemSorter = New EntryComparer(colName, _ascending)

        ' sort the list
        listView.Sort()

        ' toggle order for next time
        _ascending = Not _ascending

    End Sub

    ' switch view mode
    Private Sub mnuView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuView.Click, mnuViewList.Click, mnuViewDetail.Click, mnuViewLarge.Click, mnuViewSmall.Click

        ' adjust checkmarks
        Dim item As MenuItem = CType(sender, MenuItem)
        Dim mi As MenuItem
        For Each mi In mnuView.MenuItems
            mi.Checked = mi.Equals(item)
        Next

        ' switch view
        If item.Equals(mnuViewLarge) Then
            listView.View = View.LargeIcon
        End If
        If item.Equals(mnuViewSmall) Then
            listView.View = View.SmallIcon
        End If
        If item.Equals(mnuViewList) Then
            listView.View = View.List
        End If
        If item.Equals(mnuViewDetail) Then
            listView.View = View.Details
        End If

    End Sub

    ' show current entry in read-only editor
    Private Sub mnuViewEntry_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuViewEntry.Click

        ' get first selected item that is not a directory
        Dim ze As C1ZipEntry = Nothing
        Dim lvi As ListViewItem
        For Each lvi In listView.SelectedItems
            Dim zeItem As C1ZipEntry = CType(lvi.Tag, C1ZipEntry)
            If (zeItem.Attributes And FileAttributes.Directory) = 0 Then
                ze = zeItem
                Exit For
            End If
        Next

        If ze Is Nothing Then Return

        ' read entry content 
        Dim entry As Stream = ze.OpenReader()
        Dim sr As StreamReader = New StreamReader(entry)
        Dim entrytext As String = sr.ReadToEnd()
        entry.Close()

        ' show it in dialog
        Dim view As ViewDialog = New ViewDialog()
        view.Text = "view: " + ze.FileName
        view.SetContent(entrytext)
        view.ShowDialog()
    End Sub

    ' edit comment for the zip file
    Private Sub mnuEditZipComment_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuEditZipComment.Click

        ' make sure we have a zip file
        If _zipfile.FileName = "" Then Return

        ' get new comment from the user
        Dim dlg As UserInputDialog = New UserInputDialog()
        Dim comment As String = dlg.GetString("Enter new comment for the zip file", _zipfile.Comment)
        If comment Is Nothing Then Return

        ' set new comment
        _zipfile.Comment = comment

        ' update status bar
        UpdateStatusBar()
    End Sub

    ' edit comment for the selected files within the zip file
    Private Sub mnuEditEntryComment_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuEditEntryComment.Click

        ' we need a selection
        If listView.SelectedItems.Count = 0 Then Return

        ' get current comment if any
        Dim ze As C1ZipEntry = CType(listView.SelectedItems(0).Tag, C1ZipEntry)
        Dim comment As String = ze.Comment

        ' get new comment from the user
        Dim dlg As UserInputDialog = New UserInputDialog()
        comment = dlg.GetString("Enter new comment for selected entries", comment)
        If comment Is Nothing Then Return

        ' update the comments
        Dim lvi As ListViewItem
        For Each lvi In listView.SelectedItems
            ze = CType(lvi.Tag, C1ZipEntry)
            ze.Comment = comment
        Next

        ' update the user interface
        UpdateUI()

    End Sub

    ' update status bar and menus whenever the selection changes
    Private Sub listView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles listView.SelectedIndexChanged
        UpdateStatusBar()
        UpdateMenus()
    End Sub


    ' ** updating routines

    ' update list, status bar, and menus
    Private Sub UpdateUI()
        UpdateList()
        UpdateStatusBar()
        UpdateMenus()
    End Sub

    ' update file list
    Dim _freezelist As Boolean = False
    Private Sub UpdateList()

        ' if the list is frozen, exit now
        If _freezelist Then Return

        ' clear list
        listView.Items.Clear()

        ' if no zip file, we' re done
        If _zipfile.FileName = "" Then
            UpdateStatusBar()
            UpdateMenus()
            Return
        End If

        ' fill out list
        Dim zec As C1ZipEntryCollection = _zipfile.Entries
        Dim ze As C1ZipEntry
        For Each ze In zec
            Dim fa As FileAttributes = ze.Attributes
            Dim entry() As String = New String() {FileName(ze.FileName), FileExtension(ze.FileName), ze.Date.ToString("MM/dd/yy  HH:mm"), ze.SizeUncompressed.ToString("#,##0"), ze.SizeCompressed.ToString("#,##0"), AttribString(ze.Attributes), ze.CRC32.ToString(), ze.Comment}
            Dim lvi As ListViewItem = New ListViewItem(entry)
            lvi.Tag = ze
            lvi.ImageIndex = 0 ' folder
            If (ze.Attributes And FileAttributes.Directory) = 0 Then lvi.ImageIndex = 1 ' file
            If ze.IsEncrypted Then lvi.ImageIndex = 3 ' encrypted file
            listView.Items.Add(lvi)
        Next
    End Sub

    ' update statusbar
    Private Sub UpdateStatusBar()
        UpdateStatusBar("")
    End Sub
    Private Sub UpdateStatusBar(ByVal msg As String)

        ' build status string
        If msg.Length > 0 Then
            statusBar1.Text = msg
            Return
        End If

        ' get counts
        Dim nCnt As Integer = listView.Items.Count
        Dim nSel As Integer = listView.SelectedItems.Count
        Dim nSize As Integer = 0

        ' calculate total size
        Dim lvi As ListViewItem
        For Each lvi In listView.SelectedItems
            Dim ze As C1ZipEntry = CType(lvi.Tag, C1ZipEntry)
            nSize = nSize + ze.SizeUncompressed
        Next

        ' build statistics string
        Dim status As String
        If nCnt = 0 Then
            status = "Ready"
        ElseIf nSize >= (3 * 1024 * 1024) Then
            status = String.Format("{0} files, {1} selected, {2:#,##0}k bytes", nCnt, nSel, nSize / 1024)
        Else
            status = String.Format("{0} files, {1} selected, {2:#,##0} bytes", nCnt, nSel, nSize)
        End If

        ' show it 
        Me.statusBar1.Text = status
    End Sub

    ' update menus (enable/disable options)
    Private Sub UpdateMenus()
        Dim bZip As Boolean = (_zipfile.FileName.Length > 0)
        mnuCloseZip.Enabled = bZip
        mnuAddFolder.Enabled = bZip
        mnuAddFile.Enabled = bZip
        mnuEditComment.Enabled = bZip
        mnuPassword.Enabled = bZip
        mnuLevel.Enabled = bZip

        Dim bEntries As Boolean = (listView.Items.Count > 0)
        mnuSelectAll.Enabled = bEntries
        mnuUnselectAll.Enabled = bEntries
        mnuInvertSelection.Enabled = bEntries
        mnuSelectGroup.Enabled = bEntries
        mnuTestZipFile.Enabled = bEntries

        Dim bSelected As Boolean = (listView.SelectedItems.Count > 0)
        mnuExtract.Enabled = bSelected
        mnuDelete.Enabled = bSelected
        mnuEditEntryComment.Enabled = bSelected
        mnuViewEntry.Enabled = bSelected

        ' update title bar
        Dim str As String = _appTitle
        If _zipfile.FileName <> "" Then
            str = str + " - " + _zipfile.FileName
        End If
        Text = str

    End Sub


    ' ** utilities

    Friend Shared Function FileName(ByVal fn As String) As String
        Dim extLen As Integer = Path.GetExtension(fn).Length
        Return fn.Remove(fn.Length - extLen, extLen)
    End Function

    Friend Shared Function FileExtension(ByVal fn As String) As String
        Dim ext As String = Path.GetExtension(fn).ToLower()
        Return ext.Replace(".", "")
    End Function

    Friend Shared Function AttribString(ByVal fa As FileAttributes) As String

        If (fa And FileAttributes.Directory) <> 0 Then
            Return "<dir>"
        End If

        Dim atts As String = String.Empty
        If (fa And FileAttributes.ReadOnly) <> 0 Then
            atts = atts + "r"
        Else
            atts = atts + "-"
        End If
        If (fa And FileAttributes.Archive) <> 0 Then
            atts = atts + "a"
        Else
            atts = atts + "-"
        End If
        If (fa And FileAttributes.Hidden) <> 0 Then
            atts = atts + "h"
        Else
            atts = atts + "-"
        End If
        If (fa And FileAttributes.System) <> 0 Then
            atts = atts + "s"
        Else
            atts = atts + "-"
        End If

        Return atts
    End Function


    Private Sub mnuTestZipFile_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuTestZipFile.Click

        ' just in case
        _zipfile.Refresh()
        UpdateUI()

        ' test each entry
        Dim bOk As Boolean = True
        _cancel = False
        Dim ze As C1ZipEntry
        For Each ze In _zipfile.Entries

            ' update ui
            UpdateStatusBar("Checking " + ze.FileName)
            If CheckUserCancel() Then Exit For

            ' check file
            If Not ze.CheckCRC32() Then
                Dim msg As String = "** " + ze.FileName + " failed CRC check. **"
                MessageBox.Show(msg, "Test Zip File", MessageBoxButtons.OK, MessageBoxIcon.Error)
                bOk = False
            End If
        Next

        ' if everything is cool tell the user
        If bOk Then
            Dim cnt As Integer = _zipfile.Entries.Count
            If cnt > 0 Then
                UpdateStatusBar(cnt.ToString() + " files tested OK")
            Else
                UpdateStatusBar("Nothing to test")
            End If

        End If
    End Sub

    ' set compression level
    Private Sub mnuLevel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuLevel.Click, mnuLevelDefault.Click, mnuLevelBest.Click, mnuLevelFast.Click, mnuLevelNone.Click

        ' adjust checkmarks
        Dim item As MenuItem = CType(sender, MenuItem)
        Dim mi As MenuItem
        For Each mi In mnuLevel.MenuItems
            mi.Checked = mi.Equals(item)
        Next
        If (item.Equals(mnuLevelDefault)) Then _zipfile.CompressionLevel = CompressionLevelEnum.DefaultCompression
        If (item.Equals(mnuLevelBest)) Then _zipfile.CompressionLevel = CompressionLevelEnum.BestCompression
        If (item.Equals(mnuLevelFast)) Then _zipfile.CompressionLevel = CompressionLevelEnum.BestSpeed
        If (item.Equals(mnuLevelNone)) Then _zipfile.CompressionLevel = CompressionLevelEnum.NoCompression
    End Sub

    ' select password
    Private Sub mnuPassword_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuPassword.Click

        ' show dialog 
        Dim dlg As UserInputDialog = New UserInputDialog()
        Dim new_password As String = String.Empty
        new_password = dlg.GetString("Choose a password", new_password)

        ' if user provided a new password, use it
        If Not new_password Is Nothing Then _zipfile.Password = new_password

    End Sub


    ' ** Entry Comparer class
    ' used for sorting items in the ListView control

    Friend Class EntryComparer
        Implements IComparer
        Dim _colName As String
        Dim _ascending As Boolean

        Friend Sub New(ByVal colName As String, ByVal ascending As Boolean)
            _colName = colName
            _ascending = ascending
        End Sub

        Public Function Compare(ByVal o1 As Object, ByVal o2 As Object) As Integer Implements IComparer.Compare
            Dim z1 As C1ZipEntry = CType((CType(o1, ListViewItem)).Tag, C1ZipEntry)
            Dim z2 As C1ZipEntry = CType((CType(o2, ListViewItem)).Tag, C1ZipEntry)

            Dim res As Integer = 0
            Select Case _colName
                Case "Name"
                    res = String.Compare(z1.FileName, z2.FileName, True)
                Case "Ext"
                    res = String.Compare(Path.GetExtension(z1.FileName), Path.GetExtension(z2.FileName), True)
                Case "Date"
                    res = z1.Date.CompareTo(z2.Date)
                Case "Size"
                    res = z1.SizeUncompressed - z2.SizeUncompressed
                Case "Compr"
                    res = z1.SizeCompressed - z2.SizeCompressed
                Case "Attrib"
                    res = String.Compare(Form1.AttribString(z1.Attributes), Form1.AttribString(z2.Attributes), True)
                Case "CRC32"
                    If z1.CRC32 > z2.CRC32 Then res = 1 Else res = -1
                Case "Comment"
                    res = String.Compare(z1.Comment, z2.Comment, True)
                Case Else
                    Debug.Assert(False, _colName + " not mapped in sort routine.")
            End Select

            If _ascending Then
                Return res
            Else
                Return -res
            End If

        End Function
    End Class

    Private Sub mnuViewList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewList.Click

    End Sub

    Private Sub mnuViewDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewDetail.Click

    End Sub

    Private Sub mnuViewLarge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewLarge.Click

    End Sub

    Private Sub mnuViewSmall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewSmall.Click

    End Sub
End Class
