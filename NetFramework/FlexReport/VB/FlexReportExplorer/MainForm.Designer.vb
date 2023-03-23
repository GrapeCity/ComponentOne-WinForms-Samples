Imports System.Windows.Forms
Namespace FlexReportExplorer
    Partial Class MainForm
        Inherits C1.Win.Ribbon.C1RibbonForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
            Application.[Exit]()
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Dim panelElement9 As New C1.Win.C1Tile.PanelElement()
            Dim imageElement8 As New C1.Win.C1Tile.ImageElement()
            Dim textElement5 As New C1.Win.C1Tile.TextElement()
            Dim imageElement9 As New C1.Win.C1Tile.ImageElement()
            Dim panelElement10 As New C1.Win.C1Tile.PanelElement()
            Dim panelElement11 As New C1.Win.C1Tile.PanelElement()
            Dim panelElement12 As New C1.Win.C1Tile.PanelElement()
            Dim imageElement10 As New C1.Win.C1Tile.ImageElement()
            Dim textElement6 As New C1.Win.C1Tile.TextElement()
            Dim panelElement13 As New C1.Win.C1Tile.PanelElement()
            Dim panelElement14 As New C1.Win.C1Tile.PanelElement()
            Dim panelElement15 As New C1.Win.C1Tile.PanelElement()
            Dim imageElement11 As New C1.Win.C1Tile.ImageElement()
            Dim textElement7 As New C1.Win.C1Tile.TextElement()
            Dim panelElement16 As New C1.Win.C1Tile.PanelElement()
            Dim imageElement12 As New C1.Win.C1Tile.ImageElement()
            Dim textElement8 As New C1.Win.C1Tile.TextElement()
            Dim imageElement13 As New C1.Win.C1Tile.ImageElement()
            Dim imageElement14 As New C1.Win.C1Tile.ImageElement()
            Me.c1CmdDock = New C1.Win.C1Command.C1CommandDock()
            Me.dockTabPagePreview = New C1.Win.C1Command.C1DockingTab()
            Me.dockTabPageRptList = New C1.Win.C1Command.C1DockingTabPage()
            Me.pnlRpts = New System.Windows.Forms.Panel()
            Me.c1tileCntrl = New C1.Win.C1Tile.C1TileControl()
            Me.tileGrp = New C1.Win.C1Tile.Group()
            Me._reportDefaultTemplate = New C1.Win.C1Tile.Template()
            Me._reportSelectedTemplate = New C1.Win.C1Tile.Template()
            Me._tileSelectedTemplate = New C1.Win.C1Tile.Template()
            Me._tileLineTemplate = New C1.Win.C1Tile.Template()
            Me.pnlTabShowHide = New System.Windows.Forms.Panel()
            Me.pbTabShowHide = New System.Windows.Forms.PictureBox()
            Me.pnlPreviewCtl = New System.Windows.Forms.Panel()
            Me.flxViewer = New C1.Win.FlexViewer.C1FlexViewer()
            DirectCast(Me.c1CmdDock, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.c1CmdDock.SuspendLayout()
            DirectCast(Me.dockTabPagePreview, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockTabPagePreview.SuspendLayout()
            Me.dockTabPageRptList.SuspendLayout()
            Me.pnlRpts.SuspendLayout()
            Me.pnlTabShowHide.SuspendLayout()
            DirectCast(Me.pbTabShowHide, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlPreviewCtl.SuspendLayout()
            DirectCast(Me.flxViewer, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' c1CmdDock
            ' 
            Me.c1CmdDock.Controls.Add(Me.dockTabPagePreview)
            resources.ApplyResources(Me.c1CmdDock, "c1CmdDock")
            Me.c1CmdDock.Id = 0
            Me.c1CmdDock.Name = "c1CmdDock"
            ' 
            ' dockTabPagePreview
            ' 
            Me.dockTabPagePreview.Alignment = System.Windows.Forms.TabAlignment.Bottom
            Me.dockTabPagePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dockTabPagePreview.CanAutoHide = True
            Me.dockTabPagePreview.CloseBox = C1.Win.C1Command.CloseBoxPositionEnum.ActivePage
            Me.dockTabPagePreview.Controls.Add(Me.dockTabPageRptList)
            resources.ApplyResources(Me.dockTabPagePreview, "dockTabPagePreview")
            Me.dockTabPagePreview.Name = "dockTabPagePreview"
            Me.dockTabPagePreview.ShowSingleTab = False
            Me.dockTabPagePreview.TabLook = C1.Win.C1Command.ButtonLookFlags.Text
            Me.dockTabPagePreview.TabsCanFocus = False
            Me.dockTabPagePreview.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit
            Me.dockTabPagePreview.TabsShowFocusCues = False
            Me.dockTabPagePreview.TabsSpacing = 5
            Me.dockTabPagePreview.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2007
            Me.dockTabPagePreview.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Blue
            Me.dockTabPagePreview.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
            ' 
            ' dockTabPageRptList
            ' 
            Me.dockTabPageRptList.BackColor = System.Drawing.Color.White
            Me.dockTabPageRptList.Controls.Add(Me.pnlRpts)
            Me.dockTabPageRptList.Controls.Add(Me.pnlTabShowHide)
            resources.ApplyResources(Me.dockTabPageRptList, "dockTabPageRptList")
            Me.dockTabPageRptList.Name = "dockTabPageRptList"
            Me.dockTabPageRptList.TabBackColor = System.Drawing.Color.Transparent
            ' 
            ' pnlRpts
            ' 
            resources.ApplyResources(Me.pnlRpts, "pnlRpts")
            Me.pnlRpts.BackColor = System.Drawing.Color.Transparent
            Me.pnlRpts.Controls.Add(Me.c1tileCntrl)
            Me.pnlRpts.Name = "pnlRpts"
            ' 
            ' c1tileCntrl
            ' 
            Me.c1tileCntrl.BackColor = System.Drawing.Color.White
            Me.c1tileCntrl.CausesValidation = False
            resources.ApplyResources(Me.c1tileCntrl, "c1tileCntrl")
            Me.c1tileCntrl.Cursor = System.Windows.Forms.Cursors.[Default]
            ' 
            ' 
            ' 
            panelElement9.Alignment = System.Drawing.ContentAlignment.MiddleLeft
            imageElement8.Alignment = System.Drawing.ContentAlignment.TopLeft
            imageElement8.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleLeft
            imageElement8.FixedHeight = 50
            imageElement8.FixedWidth = 30
            resources.ApplyResources(imageElement8, "imageElement8")
            resources.ApplyResources(textElement5, "textElement5")
            panelElement9.Children.Add(imageElement8)
            panelElement9.Children.Add(textElement5)
            panelElement9.Dock = System.Windows.Forms.DockStyle.Fill
            resources.ApplyResources(panelElement9, "panelElement9")
            imageElement9.Alignment = System.Drawing.ContentAlignment.MiddleRight
            imageElement9.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleCenter
            imageElement9.FixedHeight = 20
            imageElement9.FixedWidth = 20
            imageElement9.ImageSelector = C1.Win.C1Tile.ImageSelector.Image1
            resources.ApplyResources(imageElement9, "imageElement9")
            Me.c1tileCntrl.DefaultTemplate.Elements.Add(panelElement9)
            Me.c1tileCntrl.DefaultTemplate.Elements.Add(imageElement9)
            Me.c1tileCntrl.ForeColor = System.Drawing.Color.Gray
            Me.c1tileCntrl.Groups.Add(Me.tileGrp)
            Me.c1tileCntrl.Name = "c1tileCntrl"
            Me.c1tileCntrl.Orientation = C1.Win.C1Tile.LayoutOrientation.Vertical
            Me.c1tileCntrl.Templates.Add(Me._reportDefaultTemplate)
            Me.c1tileCntrl.Templates.Add(Me._reportSelectedTemplate)
            Me.c1tileCntrl.Templates.Add(Me._tileSelectedTemplate)
            Me.c1tileCntrl.Templates.Add(Me._tileLineTemplate)
            Me.c1tileCntrl.UncheckTilesOnClick = False
            AddHandler Me.c1tileCntrl.MouseLeave, AddressOf Me.TileControl_MouseLeave
            AddHandler Me.c1tileCntrl.MouseMove, AddressOf Me.TileControl_MouseMove
            ' 
            ' tileGrp
            ' 
            Me.tileGrp.Name = "tileGrp"
            ' 
            ' _reportDefaultTemplate
            ' 
            resources.ApplyResources(Me._reportDefaultTemplate, "_reportDefaultTemplate")
            Me._reportDefaultTemplate.BackColorSelector = C1.Win.C1Tile.BackColorSelector.Unbound
            Me._reportDefaultTemplate.DefaultVerticalSize = 5
            Me._reportDefaultTemplate.Description = "Report tiles"
            resources.ApplyResources(panelElement10, "panelElement10")
            panelElement11.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleLeft
            resources.ApplyResources(panelElement11, "panelElement11")
            resources.ApplyResources(panelElement12, "panelElement12")
            imageElement10.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleLeft
            imageElement10.ImageLayout = C1.Win.C1Tile.ForeImageLayout.ScaleInner
            panelElement12.Children.Add(imageElement10)
            panelElement12.Description = "Page image fill."
            panelElement12.FixedHeight = 100
            panelElement12.FixedWidth = 100
            textElement6.Alignment = System.Drawing.ContentAlignment.MiddleRight
            resources.ApplyResources(textElement6, "textElement6")
            textElement6.BackColorSelector = C1.Win.C1Tile.BackColorSelector.Unbound
            panelElement11.Children.Add(panelElement12)
            panelElement11.Children.Add(textElement6)
            panelElement11.Dock = System.Windows.Forms.DockStyle.Fill
            panelElement10.Children.Add(panelElement11)
            panelElement10.Description = "Border around tile"
            panelElement10.Dock = System.Windows.Forms.DockStyle.Fill
            Me._reportDefaultTemplate.Elements.Add(panelElement10)
            Me._reportDefaultTemplate.Name = "_reportDefaultTemplate"
            ' 
            ' _reportSelectedTemplate
            ' 
            resources.ApplyResources(Me._reportSelectedTemplate, "_reportSelectedTemplate")
            Me._reportSelectedTemplate.BackColorSelector = C1.Win.C1Tile.BackColorSelector.Unbound
            Me._reportSelectedTemplate.DefaultVerticalSize = 5
            Me._reportSelectedTemplate.Description = "New Template"
            resources.ApplyResources(panelElement13, "panelElement13")
            panelElement14.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleLeft
            resources.ApplyResources(panelElement14, "panelElement14")
            resources.ApplyResources(panelElement15, "panelElement15")
            imageElement11.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleLeft
            imageElement11.ImageLayout = C1.Win.C1Tile.ForeImageLayout.ScaleInner
            panelElement15.Children.Add(imageElement11)
            panelElement15.Description = "Page image fill."
            panelElement15.FixedHeight = 100
            panelElement15.FixedWidth = 100
            textElement7.Alignment = System.Drawing.ContentAlignment.MiddleRight
            resources.ApplyResources(textElement7, "textElement7")
            textElement7.BackColorSelector = C1.Win.C1Tile.BackColorSelector.Unbound
            panelElement14.Children.Add(panelElement15)
            panelElement14.Children.Add(textElement7)
            panelElement14.Dock = System.Windows.Forms.DockStyle.Fill
            panelElement13.Children.Add(panelElement14)
            panelElement13.Dock = System.Windows.Forms.DockStyle.Fill
            Me._reportSelectedTemplate.Elements.Add(panelElement13)
            Me._reportSelectedTemplate.Name = "_reportSelectedTemplate"
            ' 
            ' _tileSelectedTemplate
            ' 
            Me._tileSelectedTemplate.Description = "Selected category"
            resources.ApplyResources(panelElement16, "panelElement16")
            imageElement12.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleLeft
            imageElement12.FixedHeight = 50
            imageElement12.FixedWidth = 30
            resources.ApplyResources(imageElement12, "imageElement12")
            textElement8.Alignment = System.Drawing.ContentAlignment.MiddleLeft
            textElement8.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleLeft
            textElement8.BackColorSelector = C1.Win.C1Tile.BackColorSelector.Unbound
            resources.ApplyResources(textElement8, "textElement8")
            panelElement16.Children.Add(imageElement12)
            panelElement16.Children.Add(textElement8)
            panelElement16.Dock = System.Windows.Forms.DockStyle.Fill
            imageElement13.Alignment = System.Drawing.ContentAlignment.MiddleRight
            imageElement13.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleCenter
            imageElement13.FixedHeight = 20
            imageElement13.FixedWidth = 20
            imageElement13.ImageSelector = C1.Win.C1Tile.ImageSelector.Image1
            resources.ApplyResources(imageElement13, "imageElement13")
            Me._tileSelectedTemplate.Elements.Add(panelElement16)
            Me._tileSelectedTemplate.Elements.Add(imageElement13)
            Me._tileSelectedTemplate.Name = "_tileSelectedTemplate"
            ' 
            ' _tileLineTemplate
            ' 
            resources.ApplyResources(Me._tileLineTemplate, "_tileLineTemplate")
            Me._tileLineTemplate.Description = "Separator"
            imageElement14.Alignment = System.Drawing.ContentAlignment.MiddleLeft
            imageElement14.FixedHeight = 5
            imageElement14.FixedWidth = 202
            imageElement14.Image = DirectCast(resources.GetObject("imageElement14.Image"), System.Drawing.Image)
            imageElement14.ImageLayout = C1.Win.C1Tile.ForeImageLayout.Stretch
            imageElement14.ImageSelector = C1.Win.C1Tile.ImageSelector.Unbound
            Me._tileLineTemplate.Elements.Add(imageElement14)
            Me._tileLineTemplate.Enabled = False
            Me._tileLineTemplate.Name = "_tileLineTemplate"
            ' 
            ' pnlTabShowHide
            ' 
            Me.pnlTabShowHide.Controls.Add(Me.pbTabShowHide)
            resources.ApplyResources(Me.pnlTabShowHide, "pnlTabShowHide")
            Me.pnlTabShowHide.Name = "pnlTabShowHide"
            ' 
            ' pbTabShowHide
            ' 
            Me.pbTabShowHide.BackColor = System.Drawing.Color.Transparent
            resources.ApplyResources(Me.pbTabShowHide, "pbTabShowHide")
            Me.pbTabShowHide.Name = "pbTabShowHide"
            Me.pbTabShowHide.TabStop = False
            AddHandler Me.pbTabShowHide.Click, AddressOf Me.PbTabShowHide_Click
            ' 
            ' pnlPreviewCtl
            ' 
            Me.pnlPreviewCtl.Controls.Add(Me.flxViewer)
            resources.ApplyResources(Me.pnlPreviewCtl, "pnlPreviewCtl")
            Me.pnlPreviewCtl.Name = "pnlPreviewCtl"
            ' 
            ' flxViewer
            ' 
            resources.ApplyResources(Me.flxViewer, "flxViewer")
            Me.flxViewer.Name = "flxViewer"
            Me.flxViewer.ZoomMode = C1.Win.FlexViewer.FlexViewerZoomMode.PageWidth
            ' 
            ' MainForm
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnlPreviewCtl)
            Me.Controls.Add(Me.c1CmdDock)
            Me.KeyPreview = True
            Me.Name = "MainForm"
            DirectCast(Me.c1CmdDock, System.ComponentModel.ISupportInitialize).EndInit()
            Me.c1CmdDock.ResumeLayout(False)
            DirectCast(Me.dockTabPagePreview, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockTabPagePreview.ResumeLayout(False)
            Me.dockTabPageRptList.ResumeLayout(False)
            Me.pnlRpts.ResumeLayout(False)
            Me.pnlTabShowHide.ResumeLayout(False)
            DirectCast(Me.pbTabShowHide, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlPreviewCtl.ResumeLayout(False)
            DirectCast(Me.flxViewer, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private c1CmdDock As C1.Win.C1Command.C1CommandDock
        Private dockTabPagePreview As C1.Win.C1Command.C1DockingTab
        Private dockTabPageRptList As C1.Win.C1Command.C1DockingTabPage
        Private pnlRpts As System.Windows.Forms.Panel
        Private c1tileCntrl As C1.Win.C1Tile.C1TileControl
        Private tileGrp As C1.Win.C1Tile.Group
        Private _reportDefaultTemplate As C1.Win.C1Tile.Template
        Private pnlTabShowHide As System.Windows.Forms.Panel
        Private pbTabShowHide As System.Windows.Forms.PictureBox
        Private _tileSelectedTemplate As C1.Win.C1Tile.Template
        Private pnlPreviewCtl As Panel
        Private flxViewer As C1.Win.FlexViewer.C1FlexViewer
        Private flxRpt As C1.Win.FlexReport.C1FlexReport
        Private _tileLineTemplate As C1.Win.C1Tile.Template
        Private _reportSelectedTemplate As C1.Win.C1Tile.Template
    End Class
End Namespace
