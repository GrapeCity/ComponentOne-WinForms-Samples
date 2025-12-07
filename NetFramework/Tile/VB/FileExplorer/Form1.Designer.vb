<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim PanelElement11 As C1.Win.Tile.PanelElement = New C1.Win.Tile.PanelElement
        Dim ImageElement6 As C1.Win.Tile.ImageElement = New C1.Win.Tile.ImageElement
        Dim TextElement11 As C1.Win.Tile.TextElement = New C1.Win.Tile.TextElement
        Dim PanelElement12 As C1.Win.Tile.PanelElement = New C1.Win.Tile.PanelElement
        Dim ImageElement7 As C1.Win.Tile.ImageElement = New C1.Win.Tile.ImageElement
        Dim TextElement12 As C1.Win.Tile.TextElement = New C1.Win.Tile.TextElement
        Dim PanelElement13 As C1.Win.Tile.PanelElement = New C1.Win.Tile.PanelElement
        Dim ImageElement8 As C1.Win.Tile.ImageElement = New C1.Win.Tile.ImageElement
        Dim PanelElement14 As C1.Win.Tile.PanelElement = New C1.Win.Tile.PanelElement
        Dim TextElement13 As C1.Win.Tile.TextElement = New C1.Win.Tile.TextElement
        Dim TextElement14 As C1.Win.Tile.TextElement = New C1.Win.Tile.TextElement
        Dim PanelElement15 As C1.Win.Tile.PanelElement = New C1.Win.Tile.PanelElement
        Dim ImageElement9 As C1.Win.Tile.ImageElement = New C1.Win.Tile.ImageElement
        Dim PanelElement16 As C1.Win.Tile.PanelElement = New C1.Win.Tile.PanelElement
        Dim TextElement15 As C1.Win.Tile.TextElement = New C1.Win.Tile.TextElement
        Dim PanelElement17 As C1.Win.Tile.PanelElement = New C1.Win.Tile.PanelElement
        Dim TextElement16 As C1.Win.Tile.TextElement = New C1.Win.Tile.TextElement
        Dim TextElement17 As C1.Win.Tile.TextElement = New C1.Win.Tile.TextElement
        Dim PanelElement18 As C1.Win.Tile.PanelElement = New C1.Win.Tile.PanelElement
        Dim ImageElement10 As C1.Win.Tile.ImageElement = New C1.Win.Tile.ImageElement
        Dim PanelElement19 As C1.Win.Tile.PanelElement = New C1.Win.Tile.PanelElement
        Dim TextElement18 As C1.Win.Tile.TextElement = New C1.Win.Tile.TextElement
        Dim PanelElement20 As C1.Win.Tile.PanelElement = New C1.Win.Tile.PanelElement
        Dim TextElement19 As C1.Win.Tile.TextElement = New C1.Win.Tile.TextElement
        Dim TextElement20 As C1.Win.Tile.TextElement = New C1.Win.Tile.TextElement
        Me.topPanel = New System.Windows.Forms.Panel
        Me.topTiles = New C1.Win.Tile.C1TileControl
        Me.group2 = New C1.Win.Tile.Group
        Me.upLevelTile = New C1.Win.Tile.Tile
        Me.drivesTile = New C1.Win.Tile.Tile
        Me.refreshTile = New C1.Win.Tile.Tile
        Me.newFolderTile = New C1.Win.Tile.Tile
        Me.deleteTile = New C1.Win.Tile.Tile
        Me.renameTile = New C1.Win.Tile.Tile
        Me.bottomPanel = New System.Windows.Forms.Panel
        Me.pathLabel = New System.Windows.Forms.Label
        Me.itemTiles = New C1.Win.Tile.C1TileControl
        Me.group1 = New C1.Win.Tile.Group
        Me.tile1 = New C1.Win.Tile.Tile
        Me.tempDrive = New C1.Win.Tile.Template
        Me.tile2 = New C1.Win.Tile.Tile
        Me.tempFolder = New C1.Win.Tile.Template
        Me.tile3 = New C1.Win.Tile.Tile
        Me.tempFile = New C1.Win.Tile.Template
        Me.topPanel.SuspendLayout()
        Me.bottomPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'topPanel
        '
        Me.topPanel.Controls.Add(Me.topTiles)
        Me.topPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.topPanel.Location = New System.Drawing.Point(0, 0)
        Me.topPanel.Name = "topPanel"
        Me.topPanel.Size = New System.Drawing.Size(694, 48)
        Me.topPanel.TabIndex = 0
        '
        'topTiles
        '
        Me.topTiles.AllowPanningFeedback = False
        Me.topTiles.BackColor = System.Drawing.Color.Silver
        Me.topTiles.CellHeight = 40
        Me.topTiles.CellSpacing = 6
        Me.topTiles.CellWidth = 96
        '
        '
        '
        PanelElement11.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        ImageElement6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PanelElement11.Children.Add(ImageElement6)
        PanelElement11.Children.Add(TextElement11)
        PanelElement11.ChildSpacing = 2
        PanelElement11.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.topTiles.DefaultTemplate.Elements.Add(PanelElement11)
        Me.topTiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.topTiles.FocusedBorderColor = System.Drawing.Color.ForestGreen
        Me.topTiles.GroupPadding = New System.Windows.Forms.Padding(4)
        Me.topTiles.Groups.Add(Me.group2)
        Me.topTiles.HotBorderColor = System.Drawing.Color.White
        Me.topTiles.Location = New System.Drawing.Point(0, 0)
        Me.topTiles.Name = "topTiles"
        Me.topTiles.Padding = New System.Windows.Forms.Padding(0)
        Me.topTiles.Size = New System.Drawing.Size(694, 48)
        Me.topTiles.SurfacePadding = New System.Windows.Forms.Padding(0)
        Me.topTiles.TabIndex = 2
        Me.topTiles.TabStop = False
        Me.topTiles.TileBackColor = System.Drawing.Color.DimGray
        '
        'group2
        '
        Me.group2.Name = "group2"
        Me.group2.Tiles.Add(Me.upLevelTile)
        Me.group2.Tiles.Add(Me.drivesTile)
        Me.group2.Tiles.Add(Me.refreshTile)
        Me.group2.Tiles.Add(Me.newFolderTile)
        Me.group2.Tiles.Add(Me.deleteTile)
        Me.group2.Tiles.Add(Me.renameTile)
        '
        'upLevelTile
        '
        Me.upLevelTile.Image = Global.FileExplorer.My.Resources.Resources.upLevel
        Me.upLevelTile.Name = "upLevelTile"
        Me.upLevelTile.Text = "Level Up"
        '
        'drivesTile
        '
        Me.drivesTile.Image = Global.FileExplorer.My.Resources.Resources.drives
        Me.drivesTile.Name = "drivesTile"
        Me.drivesTile.Symbol = C1.Win.Tile.TileSymbol.VerticalDots
        Me.drivesTile.Text = "Drives"
        '
        'refreshTile
        '
        Me.refreshTile.Image = Global.FileExplorer.My.Resources.Resources.refresh
        Me.refreshTile.Name = "refreshTile"
        Me.refreshTile.Text = "Refresh"
        '
        'newFolderTile
        '
        Me.newFolderTile.Image = Global.FileExplorer.My.Resources.Resources.newFolder
        Me.newFolderTile.Name = "newFolderTile"
        Me.newFolderTile.Text = "New Folder"
        '
        'deleteTile
        '
        Me.deleteTile.Image = Global.FileExplorer.My.Resources.Resources.delete
        Me.deleteTile.Name = "deleteTile"
        Me.deleteTile.Text = "Delete"
        '
        'renameTile
        '
        Me.renameTile.Image = Global.FileExplorer.My.Resources.Resources.rename
        Me.renameTile.Name = "renameTile"
        Me.renameTile.Text = "Rename"
        '
        'bottomPanel
        '
        Me.bottomPanel.BackColor = System.Drawing.Color.DimGray
        Me.bottomPanel.Controls.Add(Me.pathLabel)
        Me.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bottomPanel.ForeColor = System.Drawing.Color.White
        Me.bottomPanel.Location = New System.Drawing.Point(0, 374)
        Me.bottomPanel.Name = "bottomPanel"
        Me.bottomPanel.Size = New System.Drawing.Size(694, 34)
        Me.bottomPanel.TabIndex = 2
        '
        'pathLabel
        '
        Me.pathLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pathLabel.Location = New System.Drawing.Point(14, 2)
        Me.pathLabel.Name = "pathLabel"
        Me.pathLabel.Size = New System.Drawing.Size(675, 30)
        Me.pathLabel.TabIndex = 1
        Me.pathLabel.Text = "(Drives)"
        Me.pathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'itemTiles
        '
        Me.itemTiles.AllowChecking = True
        Me.itemTiles.BackColor = System.Drawing.Color.Gainsboro
        Me.itemTiles.CellHeight = 70
        Me.itemTiles.CellWidth = 70
        Me.itemTiles.CheckBorderColor = System.Drawing.Color.Crimson
        '
        '
        '
        PanelElement12.Alignment = System.Drawing.ContentAlignment.BottomLeft
        PanelElement12.Children.Add(ImageElement7)
        PanelElement12.Children.Add(TextElement12)
        PanelElement12.Margin = New System.Windows.Forms.Padding(10, 6, 10, 6)
        Me.itemTiles.DefaultTemplate.Elements.Add(PanelElement12)
        Me.itemTiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.itemTiles.FocusedBorderColor = System.Drawing.Color.RoyalBlue
        Me.itemTiles.GroupPadding = New System.Windows.Forms.Padding(10, 40, 10, 10)
        Me.itemTiles.Groups.Add(Me.group1)
        Me.itemTiles.GroupSpacing = 5
        Me.itemTiles.GroupTextSize = 14.0!
        Me.itemTiles.GroupTextX = 10
        Me.itemTiles.HotBorderColor = System.Drawing.Color.White
        Me.itemTiles.Location = New System.Drawing.Point(0, 48)
        Me.itemTiles.Name = "itemTiles"
        Me.itemTiles.Padding = New System.Windows.Forms.Padding(0)
        Me.itemTiles.Size = New System.Drawing.Size(694, 326)
        Me.itemTiles.SurfacePadding = New System.Windows.Forms.Padding(15, 5, 15, 15)
        Me.itemTiles.TabIndex = 3
        Me.itemTiles.Templates.Add(Me.tempDrive)
        Me.itemTiles.Templates.Add(Me.tempFolder)
        Me.itemTiles.Templates.Add(Me.tempFile)
        Me.itemTiles.TextSize = 16.0!
        Me.itemTiles.TextX = 15
        Me.itemTiles.TextY = 10
        Me.itemTiles.TileBackColor = System.Drawing.Color.IndianRed
        '
        'group1
        '
        Me.group1.Name = "group1"
        Me.group1.Text = "Topic"
        Me.group1.Tiles.Add(Me.tile1)
        Me.group1.Tiles.Add(Me.tile2)
        Me.group1.Tiles.Add(Me.tile3)
        '
        'tile1
        '
        Me.tile1.HorizontalSize = 3
        Me.tile1.Image = Global.FileExplorer.My.Resources.Resources.otherDrive
        Me.tile1.Name = "tile1"
        Me.tile1.Symbol = C1.Win.Tile.TileSymbol.Device
        Me.tile1.Template = Me.tempDrive
        Me.tile1.Text = "WIN7 (C:)"
        Me.tile1.Text1 = "15.3 GB free of 44.0 GB"
        '
        'tempDrive
        '
        PanelElement13.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleCenter
        PanelElement13.Children.Add(ImageElement8)
        PanelElement13.Dock = System.Windows.Forms.DockStyle.Left
        PanelElement13.FixedWidth = 50
        PanelElement14.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleLeft
        TextElement13.Alignment = System.Drawing.ContentAlignment.TopLeft
        TextElement14.Alignment = System.Drawing.ContentAlignment.BottomLeft
        TextElement14.TextSelector = C1.Win.Tile.TextSelector.Text1
        PanelElement14.Children.Add(TextElement13)
        PanelElement14.Children.Add(TextElement14)
        PanelElement14.ChildSpacing = 25
        PanelElement14.Dock = System.Windows.Forms.DockStyle.Fill
        PanelElement14.Orientation = C1.Win.Tile.LayoutOrientation.Vertical
        Me.tempDrive.Elements.Add(PanelElement13)
        Me.tempDrive.Elements.Add(PanelElement14)
        Me.tempDrive.Name = "tempDrive"
        '
        'tile2
        '
        Me.tile2.BackColor = System.Drawing.Color.SteelBlue
        Me.tile2.HorizontalSize = 3
        Me.tile2.Image = Global.FileExplorer.My.Resources.Resources.folder
        Me.tile2.Name = "tile2"
        Me.tile2.Symbol = C1.Win.Tile.TileSymbol.BrowseByAlbum
        Me.tile2.Template = Me.tempFolder
        Me.tile2.Text = "Program Files (x86)"
        Me.tile2.Text1 = "3/24/2013 12:58 PM"
        '
        'tempFolder
        '
        PanelElement15.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleCenter
        PanelElement15.Children.Add(ImageElement9)
        PanelElement15.Dock = System.Windows.Forms.DockStyle.Left
        PanelElement15.FixedWidth = 50
        PanelElement16.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleLeft
        TextElement15.FontBold = C1.Win.Tile.ThreeStateBoolean.[True]
        PanelElement16.Children.Add(TextElement15)
        PanelElement16.Dock = System.Windows.Forms.DockStyle.Top
        PanelElement16.FixedHeight = 33
        PanelElement16.Padding = New System.Windows.Forms.Padding(0, 2, 4, 0)
        PanelElement17.Alignment = System.Drawing.ContentAlignment.TopLeft
        TextElement16.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        TextElement16.Text = "Folder Last Write Time:"
        TextElement16.TextSelector = C1.Win.Tile.TextSelector.Unbound
        TextElement17.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        TextElement17.TextSelector = C1.Win.Tile.TextSelector.Text1
        PanelElement17.Children.Add(TextElement16)
        PanelElement17.Children.Add(TextElement17)
        PanelElement17.ChildSpacing = 2
        PanelElement17.Dock = System.Windows.Forms.DockStyle.Fill
        PanelElement17.Orientation = C1.Win.Tile.LayoutOrientation.Vertical
        Me.tempFolder.Elements.Add(PanelElement15)
        Me.tempFolder.Elements.Add(PanelElement16)
        Me.tempFolder.Elements.Add(PanelElement17)
        Me.tempFolder.Name = "tempFolder"
        '
        'tile3
        '
        Me.tile3.BackColor = System.Drawing.Color.Green
        Me.tile3.HorizontalSize = 3
        Me.tile3.Image = Global.FileExplorer.My.Resources.Resources.file
        Me.tile3.Name = "tile3"
        Me.tile3.Symbol = C1.Win.Tile.TileSymbol.Files
        Me.tile3.Template = Me.tempFile
        Me.tile3.Text = "DSC04278.JPG"
        Me.tile3.Text1 = "Updated: 12/31/2012 12:58 PM"
        Me.tile3.Text2 = "5.96 GB"
        '
        'tempFile
        '
        PanelElement18.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleCenter
        PanelElement18.Children.Add(ImageElement10)
        PanelElement18.Dock = System.Windows.Forms.DockStyle.Left
        PanelElement18.FixedWidth = 50
        PanelElement19.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleLeft
        TextElement18.FontBold = C1.Win.Tile.ThreeStateBoolean.[True]
        PanelElement19.Children.Add(TextElement18)
        PanelElement19.Dock = System.Windows.Forms.DockStyle.Top
        PanelElement19.FixedHeight = 33
        PanelElement19.Padding = New System.Windows.Forms.Padding(0, 2, 4, 0)
        PanelElement20.Alignment = System.Drawing.ContentAlignment.TopLeft
        TextElement19.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        TextElement19.TextSelector = C1.Win.Tile.TextSelector.Text1
        TextElement20.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        TextElement20.TextSelector = C1.Win.Tile.TextSelector.Text2
        PanelElement20.Children.Add(TextElement19)
        PanelElement20.Children.Add(TextElement20)
        PanelElement20.ChildSpacing = 2
        PanelElement20.Dock = System.Windows.Forms.DockStyle.Fill
        PanelElement20.Orientation = C1.Win.Tile.LayoutOrientation.Vertical
        Me.tempFile.Elements.Add(PanelElement18)
        Me.tempFile.Elements.Add(PanelElement19)
        Me.tempFile.Elements.Add(PanelElement20)
        Me.tempFile.Name = "tempFile"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(694, 408)
        Me.Controls.Add(Me.itemTiles)
        Me.Controls.Add(Me.bottomPanel)
        Me.Controls.Add(Me.topPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "Form1"
        Me.Text = "File Explorer"
        Me.topPanel.ResumeLayout(False)
        Me.bottomPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents topPanel As System.Windows.Forms.Panel
    Private WithEvents topTiles As C1.Win.Tile.C1TileControl
    Private WithEvents group2 As C1.Win.Tile.Group
    Private WithEvents upLevelTile As C1.Win.Tile.Tile
    Private WithEvents drivesTile As C1.Win.Tile.Tile
    Private WithEvents refreshTile As C1.Win.Tile.Tile
    Private WithEvents newFolderTile As C1.Win.Tile.Tile
    Private WithEvents deleteTile As C1.Win.Tile.Tile
    Private WithEvents renameTile As C1.Win.Tile.Tile
    Private WithEvents bottomPanel As System.Windows.Forms.Panel
    Private WithEvents pathLabel As System.Windows.Forms.Label
    Private WithEvents itemTiles As C1.Win.Tile.C1TileControl
    Private WithEvents group1 As C1.Win.Tile.Group
    Private WithEvents tile1 As C1.Win.Tile.Tile
    Private WithEvents tempDrive As C1.Win.Tile.Template
    Private WithEvents tile2 As C1.Win.Tile.Tile
    Private WithEvents tempFolder As C1.Win.Tile.Template
    Private WithEvents tile3 As C1.Win.Tile.Tile
    Private WithEvents tempFile As C1.Win.Tile.Template

End Class
