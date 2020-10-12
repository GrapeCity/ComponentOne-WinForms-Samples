Imports System.IO
Imports System.Text
Imports C1.Win.C1Tile

Public Class Form1

    Private _activeDir As DirectoryInfo
    Private _folderGroup As Group
    Private _fileGroup As Group

    Private Sub ShowDrives(ByVal keepOffset As Boolean)
        _activeDir = Nothing
        pathLabel.Text = "(Drives)"
        itemTiles.BeginUpdate()
        itemTiles.Groups.Clear(True)
        Try
            For Each drv As DriveInfo In DriveInfo.GetDrives()
                Dim dt As DriveType = drv.DriveType
                Dim grp As Group = GetDriveGroup(dt)
                Dim t As Tile = New Tile()
                Select Case (dt)
                    Case DriveType.CDRom
                        t.Image = Global.FileExplorer.My.Resources.Resources.mediaDrive
                    Case DriveType.Fixed
                        t.Image = Global.FileExplorer.My.Resources.Resources.hardDrive
                    Case DriveType.Network
                        t.Image = Global.FileExplorer.My.Resources.Resources.networkDrive
                    Case Else
                        t.Image = Global.FileExplorer.My.Resources.Resources.otherDrive
                End Select
                t.HorizontalSize = 3
                grp.Tiles.Add(t)
                t.Template = tempDrive
                Dim driveName As String = drv.Name
                Dim dnl As Int32 = driveName.Length
                If dnl > 1 AndAlso driveName.Substring(dnl - 1, 1) = "\\" Then
                    driveName = driveName.Substring(0, dnl - 1)
                End If
                If Not drv.IsReady Or dt = DriveType.NoRootDirectory Then
                    t.Text = String.Format("< Empty > ({0})", driveName)
                    t.BackColor = Color.RosyBrown
                Else
                    t.Text = String.Format("{0} ({1})", drv.VolumeLabel, driveName)
                    t.Text1 = String.Format("{0} free of {1}", ToSizeString(drv.TotalFreeSpace), ToSizeString(drv.TotalSize))
                    t.BackColor = Color.IndianRed
                    t.Tag = drv
                    AddHandler t.Click, AddressOf Drive_Click
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "File Explorer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        If Not keepOffset Then
            itemTiles.ScrollOffset = 0
        End If
        itemTiles.EndUpdate()
    End Sub

    Private Function ToSizeString(ByVal bt As Int64) As String
        If bt < 1024 Then
            Return bt.ToString() + " Bytes"
        End If
        Dim s As String
        Dim sz As Double = Convert.ToDouble(bt)
        If sz < 1048576.0 Then
            s = " KB"
            sz /= 1024.0
        ElseIf sz < 1073741824.0 Then
            s = " MB"
            sz /= 1048576.0
        ElseIf sz < 1099511627776.0 Then
            s = " GB"
            sz /= 1073741824.0
        Else
            s = " TB"
            sz /= 1099511627776.0
        End If
        If sz >= 100.0 Then
            Return Math.Truncate(sz).ToString("0") + s
        End If
        If sz >= 10.0 Then
            Return (Math.Truncate(sz * 10.0) / 10.0).ToString("0.0") + s
        End If
        Return (Math.Truncate(sz * 100.0) / 100.0).ToString("0.00") + s
    End Function

    Private Function GetDriveGroup(ByVal dt As DriveType) As Group
        Dim groupName As String = dt.ToString()
        For Each grp As Group In itemTiles.Groups
            If grp.Name = groupName Then
                Return grp
            End If
            next
        Dim newGroup As New Group()
        Select dt
            Case DriveType.CDRom
                newGroup.Text = "CD/DVD"
            Case DriveType.Fixed
                newGroup.Text = "Fixed Disks"
            Case DriveType.Network
                newGroup.Text = "Network Drives"
            Case DriveType.Ram
                newGroup.Text = "RAM Disks"
            Case DriveType.Removable
                newGroup.Text = "Removable Devices"
            Case Else
                newGroup.Text = "Misc"
        End Select
        itemTiles.Groups.Add(newGroup)
        newGroup.Name = groupName
        Return newGroup
    End Function

    Private Sub ShowDirectory(ByVal dirInfo As DirectoryInfo, ByVal keepOffset As Boolean)
        If Not dirInfo.Exists Then
            Return
        End If
        Dim folderGroup As New Group()
        Dim fileGroup As New Group()
        Try
            folderGroup.Text = "Folders"
            For Each subDir As DirectoryInfo In dirInfo.GetDirectories()
                Dim t As New Tile()
                t.HorizontalSize = 3
                folderGroup.Tiles.Add(t)
                t.Template = tempFolder
                t.Image = Global.FileExplorer.My.Resources.Resources.folder
                t.Text = subDir.Name
                t.Text1 = subDir.LastWriteTime.ToString()
                t.BackColor = Color.SteelBlue
                t.Tag = subDir
                AddHandler t.Click, AddressOf Directory_Click
            Next
            fileGroup.Text = "Files"
            For Each fi As FileInfo In dirInfo.GetFiles()
                Dim t As New Tile()
                t.HorizontalSize = 3
                fileGroup.Tiles.Add(t)
                t.Template = tempFile
                t.Image = Global.FileExplorer.My.Resources.Resources.file
                t.Text = fi.Name
                t.Text1 = "Updated: " + fi.LastWriteTime.ToString()
                t.Text2 = ToSizeString(fi.Length)
                t.BackColor = Color.Green
                t.Tag = fi
                AddHandler t.Click, AddressOf File_Click
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "File Explorer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End Try

        itemTiles.BeginUpdate()
        itemTiles.Groups.Clear(True)
        itemTiles.Groups.Add(folderGroup)
        itemTiles.Groups.Add(fileGroup)
        If Not keepOffset Then
            itemTiles.ScrollOffset = 0
        End If
        itemTiles.EndUpdate()

        _activeDir = dirInfo
        _folderGroup = folderGroup
        _fileGroup = fileGroup
        UpdateStatus()
    End Sub

    Private Sub UpdateStatus()
        If _activeDir Is Nothing Then
            Return
        End If
        Dim sb As New StringBuilder()
        Dim n As Int32 = _folderGroup.Tiles.Count
        If n > 0 Then
            sb.Append("Folders  ")
            sb.Append(n)
        End If
        n = _fileGroup.Tiles.Count
        If n > 0 Then
            If sb.Length > 0 Then
                sb.Append("    ")
            End If
            sb.Append("Files  ")
            sb.Append(n)
        End If
        n = itemTiles.CheckedTiles.Length
        If (n > 0) Then
            If (sb.Length > 0) Then
                sb.Append("    ")
            End If
            sb.Append("Checked  ")
            sb.Append(n)
        End If
        If sb.Length > 0 Then
            sb.Append("       ")
        End If
        sb.Append(_activeDir.FullName)
        pathLabel.Text = sb.ToString()
    End Sub

    Private Sub RefreshTiles()
        If _activeDir IsNot Nothing Then
            ShowDirectory(_activeDir, True)
        Else
            ShowDrives(True)
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ShowDrives(True)
    End Sub

    Private Sub Drive_Click(ByVal sender As Object, ByVal e As EventArgs)
        ShowDirectory(CType(CType(sender, Tile).Tag, DriveInfo).RootDirectory, False)
    End Sub

    Private Sub Directory_Click(ByVal sender As Object, ByVal e As EventArgs)
        ShowDirectory(CType(CType(sender, Tile).Tag, DirectoryInfo), False)
    End Sub

    Private Sub File_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim fi As FileInfo = CType((CType(sender, Tile)).Tag, FileInfo)
        If Not fi.Exists Then
            Return
        End If
        Process.Start(fi.FullName)
    End Sub

    Private Sub upLevelTile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles upLevelTile.Click
        If _activeDir IsNot Nothing Then
            itemTiles.Focus()
            Dim dirInfo As DirectoryInfo = _activeDir.Parent
            If dirInfo IsNot Nothing Then
                ShowDirectory(dirInfo, False)
            Else
                ShowDrives(False)
            End If
        End If
    End Sub

    Private Sub drivesTile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles drivesTile.Click
        itemTiles.Focus()
        ShowDrives(False)
    End Sub

    Private Sub refreshTile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles refreshTile.Click
        itemTiles.Focus()
        RefreshTiles()
    End Sub

    Private Sub itemTiles_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles itemTiles.KeyPress
        If AscW(e.KeyChar) = 8 Then
            upLevelTile_Click(sender, e)
            e.Handled = True
        End If
    End Sub

    Private Sub tempDrive_Paint(ByVal sender As Object, ByVal e As TemplatePaintEventArgs) Handles tempDrive.Paint
        If Not (TypeOf e.Tile.Tag Is DriveInfo) Then
            Return
        End If
        Dim di As DriveInfo = CType(e.Tile.Tag, DriveInfo)
        Dim g As Graphics = e.Graphics
        Dim rc As Rectangle = New Rectangle(50, 28, 170, 12)

        Dim factor As Single = g.DpiY / 96.0!
        rc.X = Convert.ToInt32(rc.X * factor)
        rc.Y = Convert.ToInt32(rc.Y * factor)
        rc.Width = Convert.ToInt32(rc.Width * factor)
        rc.Height = Convert.ToInt32(rc.Height * factor)
        g.DrawRectangle(Pens.Silver, rc)
        rc.X += 1
        rc.Y += 1
        rc.Width -= 1
        rc.Height -= 1
        g.FillRectangle(Brushes.Gainsboro, rc)
        Dim k As Double = Convert.ToDouble(di.TotalSize)
        If k > 0.0 Then
            k = (k - Convert.ToDouble(di.TotalFreeSpace)) / k
            rc.Width = Convert.ToInt32(k * rc.Width)
        End If
        g.FillRectangle(Brushes.SteelBlue, rc)
    End Sub

    Private Sub itemTiles_TileCheckedChanged(ByVal sender As Object, ByVal e As TileEventArgs) Handles itemTiles.TileUnchecked, itemTiles.TileChecked
        UpdateStatus()
    End Sub

    Private Sub newFolderTile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles newFolderTile.Click
        itemTiles.Focus()
        If _activeDir Is Nothing Then
            Return
        End If
        Dim fn As String = NameForm.GetFolderName()
        If fn IsNot Nothing Then
            Try
                _activeDir.CreateSubdirectory(fn)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "File Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            RefreshTiles()
        End If
    End Sub

    Private Sub deleteTile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles deleteTile.Click
        itemTiles.Focus()
        Dim checkedTiles() As Tile = itemTiles.CheckedTiles
        Dim n As Int32 = checkedTiles.Length
        If n = 0 Or _activeDir Is Nothing Then
            Return
        End If
        If n > 1 Then
            Dim hasFolders As Boolean = False
            Dim hasFiles As Boolean = False
            For Each t As Tile In checkedTiles
                If TypeOf t.Tag Is DirectoryInfo Then
                    hasFolders = True
                ElseIf TypeOf t.Tag Is FileInfo Then
                    hasFiles = True
                End If
            Next
            If (Not hasFiles) And (Not hasFolders) Then
                Return
            End If
            Dim s As String
            If hasFiles And hasFolders Then
                s = "files and folders"
            ElseIf hasFiles Then
                s = "files"
            Else
                s = "folders"
            End If
            If MessageBox.Show(String.Format("Are you sure you want to delete {0} {1}?", n, s), "Delete Confirmation", _
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                For Each t As Tile In checkedTiles
                    Try
                        If TypeOf t.Tag Is DirectoryInfo Then
                            CType(t.Tag, DirectoryInfo).Delete(True)
                        ElseIf TypeOf t.Tag Is FileInfo Then
                            CType(t.Tag, FileInfo).Delete()
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "File Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    RefreshTiles()
                Next
            End If
        ElseIf TypeOf checkedTiles(0).Tag Is DirectoryInfo Then
            Dim di As DirectoryInfo = CType(checkedTiles(0).Tag, DirectoryInfo)
            If MessageBox.Show(String.Format("Are you sure you want to delete the selected folder {0}?", di.Name), "Delete Confirmation", _
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                Try
                    di.Delete()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "File Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                RefreshTiles()
            End If
        ElseIf TypeOf checkedTiles(0).Tag Is FileInfo Then
            Dim fi As FileInfo = CType(checkedTiles(0).Tag, FileInfo)
            If MessageBox.Show(String.Format("Are you sure you want to delete the selected file {0}?", fi.Name), "Delete Confirmation", _
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                Try
                    fi.Delete()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "File Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                RefreshTiles()
            End If
        End If
    End Sub

    Private Sub renameTile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles renameTile.Click
        itemTiles.Focus()
        Dim checkedTiles() As Tile = itemTiles.CheckedTiles
        Dim n As Int32 = checkedTiles.Length
        If n = 0 Then
            Return
        End If
        If n > 1 Then
            MessageBox.Show("Can't rename more than one item at a time.", "File Explorer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        Dim t As Tile = checkedTiles(0)
        Dim s As String = Nothing
        If TypeOf t.Tag Is DriveInfo Then
            Dim di As DriveInfo = CType(t.Tag, DriveInfo)
            s = NameForm.RenameItem(di.VolumeLabel, "Rename Drive", "Drive Name:")
            If s IsNot Nothing AndAlso s <> di.VolumeLabel Then
                Try
                    di.VolumeLabel = s
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "File Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        ElseIf TypeOf t.Tag Is DirectoryInfo Then
            Dim dirInfo As DirectoryInfo = CType(t.Tag, DirectoryInfo)
            s = NameForm.RenameItem(dirInfo.Name, "Rename Folder", "Folder Name:")
            If s IsNot Nothing AndAlso s <> dirInfo.Name Then
                Try
                    dirInfo.MoveTo(Path.Combine(dirInfo.Parent.FullName, s))
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "File Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        ElseIf TypeOf t.Tag Is FileInfo Then
            Dim fi As FileInfo = CType(t.Tag, FileInfo)
            s = NameForm.RenameItem(fi.Name, "Rename File", "File Name:")
            If s IsNot Nothing AndAlso s <> fi.Name Then
                Try
                    fi.MoveTo(Path.Combine(fi.Directory.FullName, s))
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "File Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
        If s IsNot Nothing Then
            RefreshTiles()
        End If
    End Sub

End Class
