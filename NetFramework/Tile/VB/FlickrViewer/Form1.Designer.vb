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
        Me.components = New System.ComponentModel.Container
        Dim PanelElement21 As C1.Win.Tile.PanelElement = New C1.Win.Tile.PanelElement
        Dim TextElement26 As C1.Win.Tile.TextElement = New C1.Win.Tile.TextElement
        Dim ImageElement16 As C1.Win.Tile.ImageElement = New C1.Win.Tile.ImageElement
        Dim TextElement27 As C1.Win.Tile.TextElement = New C1.Win.Tile.TextElement
        Dim TextElement28 As C1.Win.Tile.TextElement = New C1.Win.Tile.TextElement
        Dim ImageElement17 As C1.Win.Tile.ImageElement = New C1.Win.Tile.ImageElement
        Dim PanelElement22 As C1.Win.Tile.PanelElement = New C1.Win.Tile.PanelElement
        Dim TextElement29 As C1.Win.Tile.TextElement = New C1.Win.Tile.TextElement
        Dim PanelElement23 As C1.Win.Tile.PanelElement = New C1.Win.Tile.PanelElement
        Dim PanelElement24 As C1.Win.Tile.PanelElement = New C1.Win.Tile.PanelElement
        Dim ImageElement18 As C1.Win.Tile.ImageElement = New C1.Win.Tile.ImageElement
        Dim TextElement30 As C1.Win.Tile.TextElement = New C1.Win.Tile.TextElement
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.refreshButton = New System.Windows.Forms.Button
        Me.loadNewButton = New System.Windows.Forms.Button
        Me.backButton = New System.Windows.Forms.Button
        Me.setTagButton = New System.Windows.Forms.Button
        Me.panel1 = New System.Windows.Forms.Panel
        Me.waitLabel = New System.Windows.Forms.Label
        Me.tagBox = New System.Windows.Forms.TextBox
        Me.flickrTiles = New C1.Win.Tile.C1TileControl
        Me.group1 = New C1.Win.Tile.Group
        Me.tile1 = New C1.Win.Tile.Tile
        Me.tempError = New C1.Win.Tile.Template
        Me.tile2 = New C1.Win.Tile.Tile
        Me.tempFlickr = New C1.Win.Tile.Template
        Me.imgPanel = New System.Windows.Forms.Panel
        Me.authorLabel = New System.Windows.Forms.Label
        Me.titleLabel = New System.Windows.Forms.Label
        Me.pictureBox = New System.Windows.Forms.PictureBox
        Me.panel1.SuspendLayout()
        Me.imgPanel.SuspendLayout()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'refreshButton
        '
        Me.refreshButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.refreshButton.FlatAppearance.BorderSize = 0
        Me.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.refreshButton.Image = Global.FlickrViewer.My.Resources.Resources.refresh
        Me.refreshButton.Location = New System.Drawing.Point(648, 2)
        Me.refreshButton.Margin = New System.Windows.Forms.Padding(0)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(44, 39)
        Me.refreshButton.TabIndex = 7
        Me.refreshButton.TabStop = False
        Me.toolTip1.SetToolTip(Me.refreshButton, "Refresh")
        Me.refreshButton.UseVisualStyleBackColor = True
        '
        'loadNewButton
        '
        Me.loadNewButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.loadNewButton.FlatAppearance.BorderSize = 0
        Me.loadNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loadNewButton.Image = Global.FlickrViewer.My.Resources.Resources.loadNew
        Me.loadNewButton.Location = New System.Drawing.Point(692, 2)
        Me.loadNewButton.Margin = New System.Windows.Forms.Padding(0)
        Me.loadNewButton.Name = "loadNewButton"
        Me.loadNewButton.Size = New System.Drawing.Size(44, 39)
        Me.loadNewButton.TabIndex = 6
        Me.loadNewButton.TabStop = False
        Me.toolTip1.SetToolTip(Me.loadNewButton, "Load New Images")
        Me.loadNewButton.UseVisualStyleBackColor = True
        '
        'backButton
        '
        Me.backButton.Enabled = False
        Me.backButton.FlatAppearance.BorderSize = 0
        Me.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backButton.Image = Global.FlickrViewer.My.Resources.Resources.back
        Me.backButton.Location = New System.Drawing.Point(2, 2)
        Me.backButton.Margin = New System.Windows.Forms.Padding(0)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(44, 39)
        Me.backButton.TabIndex = 4
        Me.backButton.TabStop = False
        Me.toolTip1.SetToolTip(Me.backButton, "Back")
        Me.backButton.UseVisualStyleBackColor = True
        '
        'setTagButton
        '
        Me.setTagButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.setTagButton.FlatAppearance.BorderSize = 0
        Me.setTagButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.setTagButton.Image = Global.FlickrViewer.My.Resources.Resources.tag
        Me.setTagButton.Location = New System.Drawing.Point(586, 2)
        Me.setTagButton.Margin = New System.Windows.Forms.Padding(0)
        Me.setTagButton.Name = "setTagButton"
        Me.setTagButton.Size = New System.Drawing.Size(44, 39)
        Me.setTagButton.TabIndex = 3
        Me.setTagButton.TabStop = False
        Me.toolTip1.SetToolTip(Me.setTagButton, "Set Tags")
        Me.setTagButton.UseVisualStyleBackColor = True
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.panel1.Controls.Add(Me.refreshButton)
        Me.panel1.Controls.Add(Me.loadNewButton)
        Me.panel1.Controls.Add(Me.waitLabel)
        Me.panel1.Controls.Add(Me.backButton)
        Me.panel1.Controls.Add(Me.setTagButton)
        Me.panel1.Controls.Add(Me.tagBox)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(739, 44)
        Me.panel1.TabIndex = 1
        '
        'waitLabel
        '
        Me.waitLabel.AutoSize = True
        Me.waitLabel.Location = New System.Drawing.Point(72, 14)
        Me.waitLabel.Name = "waitLabel"
        Me.waitLabel.Size = New System.Drawing.Size(74, 15)
        Me.waitLabel.TabIndex = 5
        Me.waitLabel.Text = "Please wait..."
        Me.waitLabel.Visible = False
        '
        'tagBox
        '
        Me.tagBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tagBox.Location = New System.Drawing.Point(464, 11)
        Me.tagBox.Name = "tagBox"
        Me.tagBox.Size = New System.Drawing.Size(117, 23)
        Me.tagBox.TabIndex = 1
        Me.tagBox.TabStop = False
        '
        'flickrTiles
        '
        Me.flickrTiles.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.flickrTiles.CellHeight = 50
        Me.flickrTiles.CellWidth = 50
        '
        '
        '
        PanelElement21.Alignment = System.Drawing.ContentAlignment.BottomLeft
        PanelElement21.Children.Add(TextElement26)
        PanelElement21.Margin = New System.Windows.Forms.Padding(10, 6, 10, 6)
        ImageElement16.ImageLayout = C1.Win.Tile.ForeImageLayout.ScaleInner
        Me.flickrTiles.DefaultTemplate.Elements.Add(PanelElement21)
        Me.flickrTiles.DefaultTemplate.Elements.Add(ImageElement16)
        Me.flickrTiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flickrTiles.FocusedBorderColor = System.Drawing.Color.Firebrick
        Me.flickrTiles.ForeColor = System.Drawing.Color.SeaGreen
        Me.flickrTiles.GroupPadding = New System.Windows.Forms.Padding(20)
        Me.flickrTiles.Groups.Add(Me.group1)
        Me.flickrTiles.HotBorderColor = System.Drawing.Color.SeaGreen
        Me.flickrTiles.Location = New System.Drawing.Point(0, 44)
        Me.flickrTiles.Name = "flickrTiles"
        Me.flickrTiles.Padding = New System.Windows.Forms.Padding(0)
        Me.flickrTiles.Size = New System.Drawing.Size(739, 409)
        Me.flickrTiles.SurfaceContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.flickrTiles.SurfacePadding = New System.Windows.Forms.Padding(5)
        Me.flickrTiles.TabIndex = 2
        Me.flickrTiles.Templates.Add(Me.tempError)
        Me.flickrTiles.Templates.Add(Me.tempFlickr)
        Me.flickrTiles.TileBackColor = System.Drawing.Color.DarkSeaGreen
        '
        'group1
        '
        Me.group1.Name = "group1"
        Me.group1.Tiles.Add(Me.tile1)
        Me.group1.Tiles.Add(Me.tile2)
        '
        'tile1
        '
        Me.tile1.HorizontalSize = 4
        Me.tile1.Name = "tile1"
        Me.tile1.Template = Me.tempError
        Me.tile1.VerticalSize = 2
        '
        'tempError
        '
        Me.tempError.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tempError.BackColorSelector = C1.Win.Tile.BackColorSelector.Unbound
        TextElement27.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleCenter
        TextElement27.BackColorSelector = C1.Win.Tile.BackColorSelector.Unbound
        TextElement27.FontBold = C1.Win.Tile.ThreeStateBoolean.[True]
        TextElement27.FontSize = 16.0!
        TextElement27.Margin = New System.Windows.Forms.Padding(0, 0, 0, 26)
        TextElement27.Text = "Can't Load Images From Flickr"
        TextElement27.TextSelector = C1.Win.Tile.TextSelector.Unbound
        TextElement28.Alignment = System.Drawing.ContentAlignment.BottomCenter
        TextElement28.BackColorSelector = C1.Win.Tile.BackColorSelector.Unbound
        TextElement28.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        TextElement28.Text = "Click or tap to see the error message"
        TextElement28.TextSelector = C1.Win.Tile.TextSelector.Unbound
        Me.tempError.Elements.Add(TextElement27)
        Me.tempError.Elements.Add(TextElement28)
        Me.tempError.Name = "tempError"
        '
        'tile2
        '
        Me.tile2.HorizontalSize = 4
        Me.tile2.Name = "tile2"
        Me.tile2.Template = Me.tempFlickr
        Me.tile2.Text = "Title"
        Me.tile2.Text1 = "author"
        Me.tile2.VerticalSize = 3
        '
        'tempFlickr
        '
        ImageElement17.ImageLayout = C1.Win.Tile.ForeImageLayout.ScaleOuter
        PanelElement22.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        TextElement29.BackColorSelector = C1.Win.Tile.BackColorSelector.Unbound
        TextElement29.ForeColor = System.Drawing.Color.Black
        TextElement29.ForeColorSelector = C1.Win.Tile.ForeColorSelector.Unbound
        TextElement29.SingleLine = True
        PanelElement22.Children.Add(TextElement29)
        PanelElement22.Dock = System.Windows.Forms.DockStyle.Top
        PanelElement22.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        PanelElement23.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleRight
        PanelElement23.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        ImageElement18.FixedHeight = 32
        ImageElement18.FixedWidth = 32
        ImageElement18.ImageLayout = C1.Win.Tile.ForeImageLayout.ScaleOuter
        ImageElement18.ImageSelector = C1.Win.Tile.ImageSelector.Image1
        PanelElement24.Children.Add(ImageElement18)
        PanelElement24.Dock = System.Windows.Forms.DockStyle.Right
        TextElement30.BackColorSelector = C1.Win.Tile.BackColorSelector.Unbound
        TextElement30.Margin = New System.Windows.Forms.Padding(0, 0, 37, 0)
        TextElement30.TextSelector = C1.Win.Tile.TextSelector.Text1
        PanelElement23.Children.Add(PanelElement24)
        PanelElement23.Children.Add(TextElement30)
        PanelElement23.Dock = System.Windows.Forms.DockStyle.Bottom
        PanelElement23.FixedHeight = 32
        Me.tempFlickr.Elements.Add(ImageElement17)
        Me.tempFlickr.Elements.Add(PanelElement22)
        Me.tempFlickr.Elements.Add(PanelElement23)
        Me.tempFlickr.Name = "tempFlickr"
        '
        'imgPanel
        '
        Me.imgPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.imgPanel.Controls.Add(Me.authorLabel)
        Me.imgPanel.Controls.Add(Me.titleLabel)
        Me.imgPanel.Controls.Add(Me.pictureBox)
        Me.imgPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imgPanel.Location = New System.Drawing.Point(0, 44)
        Me.imgPanel.Name = "imgPanel"
        Me.imgPanel.Padding = New System.Windows.Forms.Padding(20, 35, 20, 35)
        Me.imgPanel.Size = New System.Drawing.Size(739, 409)
        Me.imgPanel.TabIndex = 3
        Me.imgPanel.Visible = False
        '
        'authorLabel
        '
        Me.authorLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.authorLabel.AutoEllipsis = True
        Me.authorLabel.Location = New System.Drawing.Point(20, 380)
        Me.authorLabel.Name = "authorLabel"
        Me.authorLabel.Size = New System.Drawing.Size(699, 18)
        Me.authorLabel.TabIndex = 2
        Me.authorLabel.Text = "author"
        Me.authorLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'titleLabel
        '
        Me.titleLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.titleLabel.AutoEllipsis = True
        Me.titleLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.titleLabel.Location = New System.Drawing.Point(17, 12)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(702, 18)
        Me.titleLabel.TabIndex = 1
        Me.titleLabel.Text = "title"
        Me.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pictureBox
        '
        Me.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureBox.Location = New System.Drawing.Point(20, 35)
        Me.pictureBox.Name = "pictureBox"
        Me.pictureBox.Size = New System.Drawing.Size(699, 339)
        Me.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox.TabIndex = 0
        Me.pictureBox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(739, 453)
        Me.Controls.Add(Me.flickrTiles)
        Me.Controls.Add(Me.imgPanel)
        Me.Controls.Add(Me.panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Flickr Viewer"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.imgPanel.ResumeLayout(False)
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents toolTip1 As System.Windows.Forms.ToolTip
    Private WithEvents refreshButton As System.Windows.Forms.Button
    Private WithEvents loadNewButton As System.Windows.Forms.Button
    Private WithEvents backButton As System.Windows.Forms.Button
    Private WithEvents setTagButton As System.Windows.Forms.Button
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents waitLabel As System.Windows.Forms.Label
    Private WithEvents tagBox As System.Windows.Forms.TextBox
    Private WithEvents flickrTiles As C1.Win.Tile.C1TileControl
    Private WithEvents group1 As C1.Win.Tile.Group
    Private WithEvents tile1 As C1.Win.Tile.Tile
    Private WithEvents tempError As C1.Win.Tile.Template
    Private WithEvents tile2 As C1.Win.Tile.Tile
    Private WithEvents tempFlickr As C1.Win.Tile.Template
    Private WithEvents imgPanel As System.Windows.Forms.Panel
    Private WithEvents authorLabel As System.Windows.Forms.Label
    Private WithEvents titleLabel As System.Windows.Forms.Label
    Private WithEvents pictureBox As System.Windows.Forms.PictureBox

End Class
