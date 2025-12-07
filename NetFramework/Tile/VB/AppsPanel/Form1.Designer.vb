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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim PanelElement1 As C1.Win.Tile.PanelElement = New C1.Win.Tile.PanelElement
        Dim ImageElement1 As C1.Win.Tile.ImageElement = New C1.Win.Tile.ImageElement
        Dim TextElement1 As C1.Win.Tile.TextElement = New C1.Win.Tile.TextElement
        Dim PanelElement2 As C1.Win.Tile.PanelElement = New C1.Win.Tile.PanelElement
        Dim PanelElement3 As C1.Win.Tile.PanelElement = New C1.Win.Tile.PanelElement
        Dim TextElement2 As C1.Win.Tile.TextElement = New C1.Win.Tile.TextElement
        Dim PanelElement4 As C1.Win.Tile.PanelElement = New C1.Win.Tile.PanelElement
        Dim ImageElement2 As C1.Win.Tile.ImageElement = New C1.Win.Tile.ImageElement
        Dim TextElement3 As C1.Win.Tile.TextElement = New C1.Win.Tile.TextElement
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.C1TileControl1 = New C1.Win.Tile.C1TileControl
        Me.group0 = New C1.Win.Tile.Group
        Me.tile5 = New C1.Win.Tile.Tile
        Me.tile17 = New C1.Win.Tile.Tile
        Me.tile6 = New C1.Win.Tile.Tile
        Me.tile10 = New C1.Win.Tile.Tile
        Me.tile8 = New C1.Win.Tile.Tile
        Me.group1 = New C1.Win.Tile.Group
        Me.tile2 = New C1.Win.Tile.Tile
        Me.subgroupTemplate = New C1.Win.Tile.Template
        Me.tile1 = New C1.Win.Tile.Tile
        Me.mapImgTemplate = New C1.Win.Tile.Template
        Me.tile12 = New C1.Win.Tile.Tile
        Me.tile13 = New C1.Win.Tile.Tile
        Me.tile7 = New C1.Win.Tile.Tile
        Me.tile14 = New C1.Win.Tile.Tile
        Me.tile15 = New C1.Win.Tile.Tile
        Me.tile16 = New C1.Win.Tile.Tile
        Me.tile3 = New C1.Win.Tile.Tile
        Me.tile4 = New C1.Win.Tile.Tile
        Me.tile9 = New C1.Win.Tile.Tile
        Me.tile11 = New C1.Win.Tile.Tile
        Me.tile18 = New C1.Win.Tile.Tile
        Me.tile19 = New C1.Win.Tile.Tile
        Me.tile20 = New C1.Win.Tile.Tile
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 417)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(737, 55)
        Me.Panel1.TabIndex = 0
        '
        'C1TileControl1
        '
        Me.C1TileControl1.AllowChecking = True
        Me.C1TileControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.C1TileControl1.CellHeight = 56
        Me.C1TileControl1.CellSpacing = 4
        Me.C1TileControl1.CellWidth = 196
        Me.C1TileControl1.CheckBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.C1TileControl1.CommonImage1.Image = CType(resources.GetObject("C1TileControl1.CommonImage1.Image"), System.Drawing.Image)
        Me.C1TileControl1.CommonImage1.ImageColumns = 25
        Me.C1TileControl1.CommonImage1.ImageRows = 12
        '
        '
        '
        PanelElement1.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        ImageElement1.FixedHeight = 40
        ImageElement1.FixedWidth = 40
        ImageElement1.ImageLayout = C1.Win.Tile.ForeImageLayout.Stretch
        TextElement1.Alignment = System.Drawing.ContentAlignment.TopLeft
        TextElement1.TextTrimming = C1.Win.Tile.TextTrimming.WordEllipsis
        PanelElement1.Children.Add(ImageElement1)
        PanelElement1.Children.Add(TextElement1)
        PanelElement1.ChildSpacing = 10
        PanelElement1.Padding = New System.Windows.Forms.Padding(8, 4, 6, 4)
        Me.C1TileControl1.DefaultTemplate.Elements.Add(PanelElement1)
        Me.C1TileControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1TileControl1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.C1TileControl1.GroupPadding = New System.Windows.Forms.Padding(15)
        Me.C1TileControl1.Groups.Add(Me.group0)
        Me.C1TileControl1.Groups.Add(Me.group1)
        Me.C1TileControl1.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.C1TileControl1.HotCheckBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.C1TileControl1.Location = New System.Drawing.Point(0, 0)
        Me.C1TileControl1.MaximumRowsOrColumns = 5
        Me.C1TileControl1.Name = "C1TileControl1"
        Me.C1TileControl1.Padding = New System.Windows.Forms.Padding(0, 50, 0, 0)
        Me.C1TileControl1.Size = New System.Drawing.Size(737, 417)
        Me.C1TileControl1.SurfacePadding = New System.Windows.Forms.Padding(5, 8, 5, 5)
        Me.C1TileControl1.TabIndex = 1
        Me.C1TileControl1.Templates.Add(Me.subgroupTemplate)
        Me.C1TileControl1.Templates.Add(Me.mapImgTemplate)
        Me.C1TileControl1.Text = "Apps"
        Me.C1TileControl1.TextX = 28
        Me.C1TileControl1.TextY = 12
        Me.C1TileControl1.TileBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.C1TileControl1.TileBorderColor = System.Drawing.Color.Transparent
        '
        'group0
        '
        Me.group0.Name = "group0"
        Me.group0.Tiles.Add(Me.tile5)
        Me.group0.Tiles.Add(Me.tile17)
        Me.group0.Tiles.Add(Me.tile6)
        Me.group0.Tiles.Add(Me.tile10)
        Me.group0.Tiles.Add(Me.tile8)
        '
        'tile5
        '
        Me.tile5.Image = CType(resources.GetObject("tile5.Image"), System.Drawing.Image)
        Me.tile5.Name = "tile5"
        Me.tile5.Text = "Calendar"
        '
        'tile17
        '
        Me.tile17.Image = CType(resources.GetObject("tile17.Image"), System.Drawing.Image)
        Me.tile17.Name = "tile17"
        Me.tile17.Text = "Direct2D composite and blend effects C++ sample"
        '
        'tile6
        '
        Me.tile6.Image = CType(resources.GetObject("tile6.Image"), System.Drawing.Image)
        Me.tile6.Name = "tile6"
        Me.tile6.Text = "Finance"
        '
        'tile10
        '
        Me.tile10.Image = CType(resources.GetObject("tile10.Image"), System.Drawing.Image)
        Me.tile10.Name = "tile10"
        Me.tile10.Text = "OneNote"
        '
        'tile8
        '
        Me.tile8.Image = CType(resources.GetObject("tile8.Image"), System.Drawing.Image)
        Me.tile8.Name = "tile8"
        Me.tile8.Text = "Weather"
        '
        'group1
        '
        Me.group1.Name = "group1"
        Me.group1.Tiles.Add(Me.tile2)
        Me.group1.Tiles.Add(Me.tile1)
        Me.group1.Tiles.Add(Me.tile12)
        Me.group1.Tiles.Add(Me.tile13)
        Me.group1.Tiles.Add(Me.tile7)
        Me.group1.Tiles.Add(Me.tile14)
        Me.group1.Tiles.Add(Me.tile15)
        Me.group1.Tiles.Add(Me.tile16)
        Me.group1.Tiles.Add(Me.tile3)
        Me.group1.Tiles.Add(Me.tile4)
        Me.group1.Tiles.Add(Me.tile9)
        Me.group1.Tiles.Add(Me.tile11)
        Me.group1.Tiles.Add(Me.tile18)
        Me.group1.Tiles.Add(Me.tile19)
        Me.group1.Tiles.Add(Me.tile20)
        '
        'tile2
        '
        Me.tile2.Name = "tile2"
        Me.tile2.Template = Me.subgroupTemplate
        Me.tile2.Text = "Administrative Tools"
        '
        'subgroupTemplate
        '
        Me.subgroupTemplate.Description = "Subgroup"
        PanelElement2.AlignmentOfContents = System.Drawing.ContentAlignment.BottomLeft
        PanelElement3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(92, Byte), Integer))
        PanelElement3.Dock = System.Windows.Forms.DockStyle.Bottom
        PanelElement3.FixedHeight = 2
        TextElement2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        TextElement2.ForeColorSelector = C1.Win.Tile.ForeColorSelector.Unbound
        TextElement2.Margin = New System.Windows.Forms.Padding(0, 0, 0, 6)
        TextElement2.SingleLine = True
        PanelElement2.Children.Add(PanelElement3)
        PanelElement2.Children.Add(TextElement2)
        PanelElement2.Dock = System.Windows.Forms.DockStyle.Fill
        PanelElement2.Padding = New System.Windows.Forms.Padding(8, 0, 8, 8)
        Me.subgroupTemplate.Elements.Add(PanelElement2)
        Me.subgroupTemplate.Enabled = False
        Me.subgroupTemplate.Name = "subgroupTemplate"
        '
        'tile1
        '
        Me.tile1.Name = "tile1"
        Me.tile1.Template = Me.mapImgTemplate
        Me.tile1.Text = "Component Services"
        '
        'mapImgTemplate
        '
        Me.mapImgTemplate.Description = "Win32"
        PanelElement4.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        ImageElement2.ColumnIndex = 10
        ImageElement2.ColumnIndexSelector = C1.Win.Tile.IntValueSelector.Unbound
        ImageElement2.ImageSelector = C1.Win.Tile.ImageSelector.CommonImage1
        TextElement3.Alignment = System.Drawing.ContentAlignment.TopLeft
        TextElement3.TextTrimming = C1.Win.Tile.TextTrimming.WordEllipsis
        PanelElement4.Children.Add(ImageElement2)
        PanelElement4.Children.Add(TextElement3)
        PanelElement4.ChildSpacing = 10
        PanelElement4.Padding = New System.Windows.Forms.Padding(8, 4, 6, 4)
        Me.mapImgTemplate.Elements.Add(PanelElement4)
        Me.mapImgTemplate.Name = "mapImgTemplate"
        '
        'tile12
        '
        Me.tile12.IntValue = 1
        Me.tile12.Name = "tile12"
        Me.tile12.Template = Me.mapImgTemplate
        Me.tile12.Text = "Defragment and Optimize Drives"
        '
        'tile13
        '
        Me.tile13.IntValue = 2
        Me.tile13.Name = "tile13"
        Me.tile13.Template = Me.mapImgTemplate
        Me.tile13.Text = "iSCSI Initiator"
        '
        'tile7
        '
        Me.tile7.IntValue = 3
        Me.tile7.Name = "tile7"
        Me.tile7.Template = Me.mapImgTemplate
        Me.tile7.Text = "Task Scheduler"
        '
        'tile14
        '
        Me.tile14.IntValue = 4
        Me.tile14.Name = "tile14"
        Me.tile14.Template = Me.mapImgTemplate
        Me.tile14.Text = "Windows Firewall with Advanced Security"
        '
        'tile15
        '
        Me.tile15.Checked = True
        Me.tile15.IntValue = 5
        Me.tile15.Name = "tile15"
        Me.tile15.Template = Me.mapImgTemplate
        Me.tile15.Text = "Windows PowerShell (x86)"
        '
        'tile16
        '
        Me.tile16.Name = "tile16"
        Me.tile16.Template = Me.subgroupTemplate
        Me.tile16.Text = "Microsoft Visual Studio 2012"
        '
        'tile3
        '
        Me.tile3.IntValue = 6
        Me.tile3.Name = "tile3"
        Me.tile3.Template = Me.mapImgTemplate
        Me.tile3.Text = "Blend for Visual Studio 2012"
        '
        'tile4
        '
        Me.tile4.IntValue = 7
        Me.tile4.Name = "tile4"
        Me.tile4.Template = Me.mapImgTemplate
        Me.tile4.Text = "Team Foundation Build Notifications"
        '
        'tile9
        '
        Me.tile9.Name = "tile9"
        Me.tile9.Template = Me.subgroupTemplate
        Me.tile9.Text = "Windows Accessories"
        '
        'tile11
        '
        Me.tile11.IntValue = 8
        Me.tile11.Name = "tile11"
        Me.tile11.Template = Me.mapImgTemplate
        Me.tile11.Text = "Calculator"
        '
        'tile18
        '
        Me.tile18.IntValue = 9
        Me.tile18.Name = "tile18"
        Me.tile18.Template = Me.mapImgTemplate
        Me.tile18.Text = "Math Input Panel"
        '
        'tile19
        '
        Me.tile19.IntValue = 10
        Me.tile19.Name = "tile19"
        Me.tile19.Template = Me.mapImgTemplate
        Me.tile19.Text = "Paint"
        '
        'tile20
        '
        Me.tile20.IntValue = 11
        Me.tile20.Name = "tile20"
        Me.tile20.Template = Me.mapImgTemplate
        Me.tile20.Text = "Remote Desktop Connection"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(737, 472)
        Me.Controls.Add(Me.C1TileControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Form1"
        Me.Text = "All Apps Page Modelling"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents C1TileControl1 As C1.Win.Tile.C1TileControl
    Friend WithEvents group0 As C1.Win.Tile.Group
    Friend WithEvents tile5 As C1.Win.Tile.Tile
    Friend WithEvents tile17 As C1.Win.Tile.Tile
    Friend WithEvents tile6 As C1.Win.Tile.Tile
    Friend WithEvents tile10 As C1.Win.Tile.Tile
    Friend WithEvents tile8 As C1.Win.Tile.Tile
    Friend WithEvents group1 As C1.Win.Tile.Group
    Friend WithEvents tile2 As C1.Win.Tile.Tile
    Friend WithEvents subgroupTemplate As C1.Win.Tile.Template
    Friend WithEvents tile1 As C1.Win.Tile.Tile
    Friend WithEvents mapImgTemplate As C1.Win.Tile.Template
    Friend WithEvents tile12 As C1.Win.Tile.Tile
    Friend WithEvents tile13 As C1.Win.Tile.Tile
    Friend WithEvents tile7 As C1.Win.Tile.Tile
    Friend WithEvents tile14 As C1.Win.Tile.Tile
    Friend WithEvents tile15 As C1.Win.Tile.Tile
    Friend WithEvents tile16 As C1.Win.Tile.Tile
    Friend WithEvents tile3 As C1.Win.Tile.Tile
    Friend WithEvents tile4 As C1.Win.Tile.Tile
    Friend WithEvents tile9 As C1.Win.Tile.Tile
    Friend WithEvents tile11 As C1.Win.Tile.Tile
    Friend WithEvents tile18 As C1.Win.Tile.Tile
    Friend WithEvents tile19 As C1.Win.Tile.Tile
    Friend WithEvents tile20 As C1.Win.Tile.Tile

End Class
