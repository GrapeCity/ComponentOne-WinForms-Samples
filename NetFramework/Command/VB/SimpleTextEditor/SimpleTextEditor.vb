Imports C1.Win.C1Command

Public Class SimpleTextEditor
    Inherits System.Windows.Forms.Form

    Private m_fileName As String = ""
    Private m_fileFormat As RichTextBoxStreamType = RichTextBoxStreamType.PlainText

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents C1MainMenu1 As C1.Win.C1Command.C1MainMenu
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents menuFile As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink4 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink6 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdFileClose As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink7 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdExit As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink8 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents menuEdit As C1.Win.C1Command.C1ContextMenu
    Friend WithEvents C1CommandLink9 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink10 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink11 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink12 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink13 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdUndo As C1.Win.C1Command.C1Command
    Friend WithEvents cmdRedo As C1.Win.C1Command.C1Command
    Friend WithEvents cmdCut As C1.Win.C1Command.C1Command
    Friend WithEvents cmdCopy As C1.Win.C1Command.C1Command
    Friend WithEvents cmdPaste As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandDock1 As C1.Win.C1Command.C1CommandDock
    Friend WithEvents tbEdit As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CommandLink15 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink16 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink17 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink18 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink19 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents tbFile As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CommandLink20 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink21 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink22 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdFileSave As C1.Win.C1Command.C1Command
    Friend WithEvents cmdFileNew As C1.Win.C1Command.C1Command
    Friend WithEvents cmdFileOpen As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents C1CommandLink5 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents C1CommandLink23 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink24 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink25 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink26 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink27 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents menuFormat As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents cmdBullet As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink28 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink29 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents menuCharOffset As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink30 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink31 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink32 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdCharOffsetNormal As C1.Win.C1Command.C1Command
    Friend WithEvents cmdCharOffsetSuper As C1.Win.C1Command.C1Command
    Friend WithEvents cmdCharOffsetSub As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink33 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink34 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink35 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdBold As C1.Win.C1Command.C1Command
    Friend WithEvents cmdItalic As C1.Win.C1Command.C1Command
    Friend WithEvents cmdUnderline As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink36 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink37 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink38 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink39 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents menuFont As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink40 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink41 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink42 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink43 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdFont As C1.Win.C1Command.C1Command
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents C1CommandLink14 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents Format As C1.Win.C1Command.C1ToolBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SimpleTextEditor))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.C1MainMenu1 = New C1.Win.C1Command.C1MainMenu()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.menuFile = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdFileNew = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink4 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdFileOpen = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink6 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdFileClose = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink5 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdFileSave = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink7 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdExit = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink8 = New C1.Win.C1Command.C1CommandLink()
        Me.menuEdit = New C1.Win.C1Command.C1ContextMenu()
        Me.C1CommandLink9 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdUndo = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink10 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdRedo = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink11 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdCut = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink12 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdCopy = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink13 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdPaste = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink26 = New C1.Win.C1Command.C1CommandLink()
        Me.menuFormat = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink27 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdBullet = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink29 = New C1.Win.C1Command.C1CommandLink()
        Me.menuCharOffset = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink30 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdCharOffsetNormal = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink31 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdCharOffsetSuper = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink32 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdCharOffsetSub = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink39 = New C1.Win.C1Command.C1CommandLink()
        Me.menuFont = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink40 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdBold = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink41 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdItalic = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink42 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdUnderline = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink43 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdFont = New C1.Win.C1Command.C1Command()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.C1CommandDock1 = New C1.Win.C1Command.C1CommandDock()
        Me.Format = New C1.Win.C1Command.C1ToolBar()
        Me.C1CommandLink28 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink33 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink34 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink35 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink36 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink37 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink38 = New C1.Win.C1Command.C1CommandLink()
        Me.tbFile = New C1.Win.C1Command.C1ToolBar()
        Me.C1CommandLink20 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink21 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink22 = New C1.Win.C1Command.C1CommandLink()
        Me.tbEdit = New C1.Win.C1Command.C1ToolBar()
        Me.C1CommandLink15 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink16 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink17 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink18 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink19 = New C1.Win.C1Command.C1CommandLink()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.C1CommandLink23 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink24 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink25 = New C1.Win.C1Command.C1CommandLink()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.C1CommandLink14 = New C1.Win.C1Command.C1CommandLink()
        CType(Me.C1CommandDock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1CommandDock1.SuspendLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.C1CommandHolder1.SetC1ContextMenu(Me.RichTextBox1, Me.menuEdit)
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 45)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(512, 398)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'C1MainMenu1
        '
        Me.C1MainMenu1.CommandHolder = Nothing
        Me.C1MainMenu1.CommandLinks.Add(Me.C1CommandLink1)
        Me.C1MainMenu1.CommandLinks.Add(Me.C1CommandLink8)
        Me.C1MainMenu1.CommandLinks.Add(Me.C1CommandLink26)
        Me.C1MainMenu1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1MainMenu1.Name = "C1MainMenu1"
        Me.C1MainMenu1.Size = New System.Drawing.Size(512, 21)
        Me.C1MainMenu1.Text = "C1MainMenu1"
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.Command = Me.menuFile
        Me.C1CommandLink1.Text = "&File"
        '
        'menuFile
        '
        Me.menuFile.Category = "File"
        Me.menuFile.CommandLinks.Add(Me.C1CommandLink2)
        Me.menuFile.CommandLinks.Add(Me.C1CommandLink4)
        Me.menuFile.CommandLinks.Add(Me.C1CommandLink6)
        Me.menuFile.CommandLinks.Add(Me.C1CommandLink5)
        Me.menuFile.CommandLinks.Add(Me.C1CommandLink7)
        Me.menuFile.Name = "menuFile"
        Me.menuFile.Text = "&File"
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.Command = Me.cmdFileNew
        Me.C1CommandLink2.Text = "&New"
        '
        'cmdFileNew
        '
        Me.cmdFileNew.Category = "File"
        Me.cmdFileNew.ImageIndex = 4
        Me.cmdFileNew.Name = "cmdFileNew"
        Me.cmdFileNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.cmdFileNew.Text = "&New"
        '
        'C1CommandLink4
        '
        Me.C1CommandLink4.Command = Me.cmdFileOpen
        Me.C1CommandLink4.Text = "&Open"
        '
        'cmdFileOpen
        '
        Me.cmdFileOpen.Category = "File"
        Me.cmdFileOpen.ImageIndex = 0
        Me.cmdFileOpen.Name = "cmdFileOpen"
        Me.cmdFileOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        Me.cmdFileOpen.Text = "&Open"
        '
        'C1CommandLink6
        '
        Me.C1CommandLink6.Command = Me.cmdFileClose
        Me.C1CommandLink6.Text = "&Close"
        '
        'cmdFileClose
        '
        Me.cmdFileClose.Category = "File"
        Me.cmdFileClose.ImageIndex = 12
        Me.cmdFileClose.Name = "cmdFileClose"
        Me.cmdFileClose.Shortcut = System.Windows.Forms.Shortcut.CtrlF4
        Me.cmdFileClose.Text = "&Close"
        '
        'C1CommandLink5
        '
        Me.C1CommandLink5.Command = Me.cmdFileSave
        Me.C1CommandLink5.Delimiter = True
        Me.C1CommandLink5.Text = "&Save"
        '
        'cmdFileSave
        '
        Me.cmdFileSave.Category = "File"
        Me.cmdFileSave.Enabled = False
        Me.cmdFileSave.ImageIndex = 1
        Me.cmdFileSave.Name = "cmdFileSave"
        Me.cmdFileSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.cmdFileSave.Text = "&Save"
        '
        'C1CommandLink7
        '
        Me.C1CommandLink7.Command = Me.cmdExit
        Me.C1CommandLink7.Delimiter = True
        Me.C1CommandLink7.Text = "E&xit"
        '
        'cmdExit
        '
        Me.cmdExit.Category = "File"
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Text = "E&xit"
        '
        'C1CommandLink8
        '
        Me.C1CommandLink8.Command = Me.menuEdit
        Me.C1CommandLink8.Text = "&Edit"
        '
        'menuEdit
        '
        Me.menuEdit.Category = "Edit"
        Me.menuEdit.CommandLinks.Add(Me.C1CommandLink9)
        Me.menuEdit.CommandLinks.Add(Me.C1CommandLink10)
        Me.menuEdit.CommandLinks.Add(Me.C1CommandLink11)
        Me.menuEdit.CommandLinks.Add(Me.C1CommandLink12)
        Me.menuEdit.CommandLinks.Add(Me.C1CommandLink13)
        Me.menuEdit.Name = "menuEdit"
        Me.menuEdit.Text = "&Edit"
        '
        'C1CommandLink9
        '
        Me.C1CommandLink9.Command = Me.cmdUndo
        Me.C1CommandLink9.Text = "&Undo"
        '
        'cmdUndo
        '
        Me.cmdUndo.Category = "Edit"
        Me.cmdUndo.ImageIndex = 10
        Me.cmdUndo.Name = "cmdUndo"
        Me.cmdUndo.Text = "&Undo"
        '
        'C1CommandLink10
        '
        Me.C1CommandLink10.Command = Me.cmdRedo
        Me.C1CommandLink10.Text = "&Redo"
        '
        'cmdRedo
        '
        Me.cmdRedo.Category = "Edit"
        Me.cmdRedo.ImageIndex = 11
        Me.cmdRedo.Name = "cmdRedo"
        Me.cmdRedo.Text = "&Redo"
        '
        'C1CommandLink11
        '
        Me.C1CommandLink11.Command = Me.cmdCut
        Me.C1CommandLink11.Delimiter = True
        Me.C1CommandLink11.Text = "C&ut"
        '
        'cmdCut
        '
        Me.cmdCut.Category = "Edit"
        Me.cmdCut.ImageIndex = 7
        Me.cmdCut.Name = "cmdCut"
        Me.cmdCut.Text = "C&ut"
        '
        'C1CommandLink12
        '
        Me.C1CommandLink12.Command = Me.cmdCopy
        Me.C1CommandLink12.Text = "&Copy"
        '
        'cmdCopy
        '
        Me.cmdCopy.Category = "Edit"
        Me.cmdCopy.ImageIndex = 8
        Me.cmdCopy.Name = "cmdCopy"
        Me.cmdCopy.Text = "&Copy"
        '
        'C1CommandLink13
        '
        Me.C1CommandLink13.Command = Me.cmdPaste
        Me.C1CommandLink13.Text = "&Paste"
        '
        'cmdPaste
        '
        Me.cmdPaste.Category = "Edit"
        Me.cmdPaste.ImageIndex = 9
        Me.cmdPaste.Name = "cmdPaste"
        Me.cmdPaste.Text = "&Paste"
        '
        'C1CommandLink26
        '
        Me.C1CommandLink26.Command = Me.menuFormat
        Me.C1CommandLink26.Text = "Forma&t"
        '
        'menuFormat
        '
        Me.menuFormat.Category = "Format"
        Me.menuFormat.CommandLinks.Add(Me.C1CommandLink27)
        Me.menuFormat.CommandLinks.Add(Me.C1CommandLink29)
        Me.menuFormat.CommandLinks.Add(Me.C1CommandLink39)
        Me.menuFormat.Name = "menuFormat"
        Me.menuFormat.Text = "Forma&t"
        '
        'C1CommandLink27
        '
        Me.C1CommandLink27.Command = Me.cmdBullet
        Me.C1CommandLink27.Text = "&Bullet"
        '
        'cmdBullet
        '
        Me.cmdBullet.Category = "Format"
        Me.cmdBullet.CheckAutoToggle = True
        Me.cmdBullet.ImageIndex = 13
        Me.cmdBullet.Name = "cmdBullet"
        Me.cmdBullet.Text = "&Bullet"
        '
        'C1CommandLink29
        '
        Me.C1CommandLink29.Command = Me.menuCharOffset
        Me.C1CommandLink29.Text = "Char Offset"
        '
        'menuCharOffset
        '
        Me.menuCharOffset.Category = "Format"
        Me.menuCharOffset.CommandLinks.Add(Me.C1CommandLink30)
        Me.menuCharOffset.CommandLinks.Add(Me.C1CommandLink31)
        Me.menuCharOffset.CommandLinks.Add(Me.C1CommandLink32)
        Me.menuCharOffset.Name = "menuCharOffset"
        Me.menuCharOffset.Text = "Char Offset"
        '
        'C1CommandLink30
        '
        Me.C1CommandLink30.Command = Me.cmdCharOffsetNormal
        Me.C1CommandLink30.Text = "Normal"
        '
        'cmdCharOffsetNormal
        '
        Me.cmdCharOffsetNormal.Category = "Format"
        Me.cmdCharOffsetNormal.ImageIndex = 14
        Me.cmdCharOffsetNormal.Name = "cmdCharOffsetNormal"
        Me.cmdCharOffsetNormal.Text = "Normal"
        '
        'C1CommandLink31
        '
        Me.C1CommandLink31.Command = Me.cmdCharOffsetSuper
        Me.C1CommandLink31.Text = "Superscript"
        '
        'cmdCharOffsetSuper
        '
        Me.cmdCharOffsetSuper.Category = "Format"
        Me.cmdCharOffsetSuper.ImageIndex = 16
        Me.cmdCharOffsetSuper.Name = "cmdCharOffsetSuper"
        Me.cmdCharOffsetSuper.Text = "Superscript"
        '
        'C1CommandLink32
        '
        Me.C1CommandLink32.Command = Me.cmdCharOffsetSub
        Me.C1CommandLink32.Text = "Subscript"
        '
        'cmdCharOffsetSub
        '
        Me.cmdCharOffsetSub.Category = "Format"
        Me.cmdCharOffsetSub.ImageIndex = 15
        Me.cmdCharOffsetSub.Name = "cmdCharOffsetSub"
        Me.cmdCharOffsetSub.Text = "Subscript"
        '
        'C1CommandLink39
        '
        Me.C1CommandLink39.Command = Me.menuFont
        Me.C1CommandLink39.Text = "&Font"
        '
        'menuFont
        '
        Me.menuFont.Category = "Format"
        Me.menuFont.CommandLinks.Add(Me.C1CommandLink40)
        Me.menuFont.CommandLinks.Add(Me.C1CommandLink41)
        Me.menuFont.CommandLinks.Add(Me.C1CommandLink42)
        Me.menuFont.CommandLinks.Add(Me.C1CommandLink43)
        Me.menuFont.Name = "menuFont"
        Me.menuFont.Text = "&Font"
        '
        'C1CommandLink40
        '
        Me.C1CommandLink40.Command = Me.cmdBold
        Me.C1CommandLink40.Text = "&Bold"
        '
        'cmdBold
        '
        Me.cmdBold.Category = "Format"
        Me.cmdBold.ImageIndex = 17
        Me.cmdBold.Name = "cmdBold"
        Me.cmdBold.Text = "&Bold"
        '
        'C1CommandLink41
        '
        Me.C1CommandLink41.Command = Me.cmdItalic
        Me.C1CommandLink41.Text = "&Italic"
        '
        'cmdItalic
        '
        Me.cmdItalic.Category = "Format"
        Me.cmdItalic.ImageIndex = 18
        Me.cmdItalic.Name = "cmdItalic"
        Me.cmdItalic.Text = "&Italic"
        '
        'C1CommandLink42
        '
        Me.C1CommandLink42.Command = Me.cmdUnderline
        Me.C1CommandLink42.Text = "&Underline"
        '
        'cmdUnderline
        '
        Me.cmdUnderline.Category = "Format"
        Me.cmdUnderline.ImageIndex = 19
        Me.cmdUnderline.Name = "cmdUnderline"
        Me.cmdUnderline.Text = "&Underline"
        '
        'C1CommandLink43
        '
        Me.C1CommandLink43.Command = Me.cmdFont
        Me.C1CommandLink43.Text = "&Font.."
        '
        'cmdFont
        '
        Me.cmdFont.Category = "Format"
        Me.cmdFont.Name = "cmdFont"
        Me.cmdFont.Text = "&Font.."
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 15)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Magenta
        '
        'C1CommandDock1
        '
        Me.C1CommandDock1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Format, Me.tbFile, Me.tbEdit})
        Me.C1CommandDock1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1CommandDock1.Id = 1
        Me.C1CommandDock1.Location = New System.Drawing.Point(0, 21)
        Me.C1CommandDock1.Name = "C1CommandDock1"
        Me.C1CommandDock1.Size = New System.Drawing.Size(512, 24)
        '
        'Format
        '
        Me.Format.CommandHolder = Nothing
        Me.Format.CommandLinks.Add(Me.C1CommandLink28)
        Me.Format.CommandLinks.Add(Me.C1CommandLink33)
        Me.Format.CommandLinks.Add(Me.C1CommandLink34)
        Me.Format.CommandLinks.Add(Me.C1CommandLink35)
        Me.Format.CommandLinks.Add(Me.C1CommandLink36)
        Me.Format.CommandLinks.Add(Me.C1CommandLink37)
        Me.Format.CommandLinks.Add(Me.C1CommandLink38)
        Me.Format.CustomizeButton = True
        Me.Format.Location = New System.Drawing.Point(272, 0)
        Me.Format.Name = "Format"
        Me.Format.Size = New System.Drawing.Size(195, 24)
        Me.Format.Text = "Format"
        '
        'C1CommandLink28
        '
        Me.C1CommandLink28.Command = Me.cmdBullet
        Me.C1CommandLink28.Text = "&Bullet"
        '
        'C1CommandLink33
        '
        Me.C1CommandLink33.Command = Me.cmdCharOffsetNormal
        Me.C1CommandLink33.Delimiter = True
        Me.C1CommandLink33.Text = "Normal"
        '
        'C1CommandLink34
        '
        Me.C1CommandLink34.Command = Me.cmdCharOffsetSuper
        Me.C1CommandLink34.Text = "Superscript"
        '
        'C1CommandLink35
        '
        Me.C1CommandLink35.Command = Me.cmdCharOffsetSub
        Me.C1CommandLink35.Text = "Subscript"
        '
        'C1CommandLink36
        '
        Me.C1CommandLink36.Command = Me.cmdBold
        Me.C1CommandLink36.Delimiter = True
        Me.C1CommandLink36.Text = "&Bold"
        '
        'C1CommandLink37
        '
        Me.C1CommandLink37.Command = Me.cmdItalic
        Me.C1CommandLink37.Text = "&Italic"
        '
        'C1CommandLink38
        '
        Me.C1CommandLink38.Command = Me.cmdUnderline
        Me.C1CommandLink38.Text = "&Underline"
        '
        'tbFile
        '
        Me.tbFile.CommandHolder = Nothing
        Me.tbFile.CommandLinks.Add(Me.C1CommandLink20)
        Me.tbFile.CommandLinks.Add(Me.C1CommandLink21)
        Me.tbFile.CommandLinks.Add(Me.C1CommandLink3)
        Me.tbFile.CommandLinks.Add(Me.C1CommandLink22)
        Me.tbFile.Name = "tbFile"
        Me.tbFile.Size = New System.Drawing.Size(103, 24)
        Me.tbFile.Text = "File"
        '
        'C1CommandLink20
        '
        Me.C1CommandLink20.Command = Me.cmdFileNew
        Me.C1CommandLink20.Text = "&New"
        '
        'C1CommandLink21
        '
        Me.C1CommandLink21.Command = Me.cmdFileOpen
        Me.C1CommandLink21.Text = "&Open"
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.Command = Me.cmdFileClose
        Me.C1CommandLink3.Text = "&Close"
        '
        'C1CommandLink22
        '
        Me.C1CommandLink22.Command = Me.cmdFileSave
        Me.C1CommandLink22.Text = "&Save"
        '
        'tbEdit
        '
        Me.tbEdit.CommandHolder = Nothing
        Me.tbEdit.CommandLinks.Add(Me.C1CommandLink15)
        Me.tbEdit.CommandLinks.Add(Me.C1CommandLink16)
        Me.tbEdit.CommandLinks.Add(Me.C1CommandLink17)
        Me.tbEdit.CommandLinks.Add(Me.C1CommandLink18)
        Me.tbEdit.CommandLinks.Add(Me.C1CommandLink19)
        Me.tbEdit.Location = New System.Drawing.Point(120, 0)
        Me.tbEdit.Name = "tbEdit"
        Me.tbEdit.Size = New System.Drawing.Size(131, 24)
        Me.tbEdit.Text = "Edit"
        '
        'C1CommandLink15
        '
        Me.C1CommandLink15.Command = Me.cmdUndo
        Me.C1CommandLink15.Text = "&Undo"
        '
        'C1CommandLink16
        '
        Me.C1CommandLink16.Command = Me.cmdRedo
        Me.C1CommandLink16.Text = "&Redo"
        '
        'C1CommandLink17
        '
        Me.C1CommandLink17.Command = Me.cmdCut
        Me.C1CommandLink17.Delimiter = True
        Me.C1CommandLink17.Text = "C&ut"
        '
        'C1CommandLink18
        '
        Me.C1CommandLink18.Command = Me.cmdCopy
        Me.C1CommandLink18.Text = "&Copy"
        '
        'C1CommandLink19
        '
        Me.C1CommandLink19.Command = Me.cmdPaste
        Me.C1CommandLink19.Text = "&Paste"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "txt"
        Me.OpenFileDialog1.Filter = "RTF files|*.rtf|Text files|*.txt|All files|*.*"
        Me.OpenFileDialog1.Title = "Open"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "RTF files|*.rtf|Text files|*.txt|All files|*.*"
        Me.SaveFileDialog1.Title = "Save"
        '
        'C1CommandLink23
        '
        Me.C1CommandLink23.Text = "New Command Link"
        '
        'C1CommandLink24
        '
        Me.C1CommandLink24.Text = "New Command Link"
        '
        'C1CommandLink25
        '
        Me.C1CommandLink25.Text = "New Command Link"
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.menuFile)
        Me.C1CommandHolder1.Commands.Add(Me.cmdFileNew)
        Me.C1CommandHolder1.Commands.Add(Me.cmdFileOpen)
        Me.C1CommandHolder1.Commands.Add(Me.cmdFileClose)
        Me.C1CommandHolder1.Commands.Add(Me.cmdFileSave)
        Me.C1CommandHolder1.Commands.Add(Me.cmdExit)
        Me.C1CommandHolder1.Commands.Add(Me.menuEdit)
        Me.C1CommandHolder1.Commands.Add(Me.cmdUndo)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRedo)
        Me.C1CommandHolder1.Commands.Add(Me.cmdCut)
        Me.C1CommandHolder1.Commands.Add(Me.cmdCopy)
        Me.C1CommandHolder1.Commands.Add(Me.cmdPaste)
        Me.C1CommandHolder1.Commands.Add(Me.menuFormat)
        Me.C1CommandHolder1.Commands.Add(Me.cmdBullet)
        Me.C1CommandHolder1.Commands.Add(Me.menuCharOffset)
        Me.C1CommandHolder1.Commands.Add(Me.cmdCharOffsetNormal)
        Me.C1CommandHolder1.Commands.Add(Me.cmdCharOffsetSuper)
        Me.C1CommandHolder1.Commands.Add(Me.cmdCharOffsetSub)
        Me.C1CommandHolder1.Commands.Add(Me.menuFont)
        Me.C1CommandHolder1.Commands.Add(Me.cmdBold)
        Me.C1CommandHolder1.Commands.Add(Me.cmdItalic)
        Me.C1CommandHolder1.Commands.Add(Me.cmdUnderline)
        Me.C1CommandHolder1.Commands.Add(Me.cmdFont)
        Me.C1CommandHolder1.ImageList = Me.ImageList1
        Me.C1CommandHolder1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1CommandHolder1.Owner = Me
        '
        'C1CommandLink14
        '
        Me.C1CommandLink14.Text = "New Command"
        '
        'SimpleTextEditor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(512, 443)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.RichTextBox1, Me.C1CommandDock1, Me.C1MainMenu1})
        Me.Name = "SimpleTextEditor"
        Me.Text = "Simple Text Editor"
        CType(Me.C1CommandDock1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1CommandDock1.ResumeLayout(False)
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As ClickEventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdUndo_Click(ByVal sender As System.Object, ByVal e As ClickEventArgs) Handles cmdUndo.Click
        Me.RichTextBox1.Undo()
    End Sub

    Private Sub cmdUndo_CommandStateQuery(ByVal sender As Object, ByVal e As C1.Win.C1Command.CommandStateQueryEventArgs) Handles cmdUndo.CommandStateQuery
        e.Enabled = Me.RichTextBox1.CanUndo
    End Sub

    Private Sub cmdRedo_Click(ByVal sender As System.Object, ByVal e As ClickEventArgs) Handles cmdRedo.Click
        Me.RichTextBox1.Redo()
    End Sub

    Private Sub cmdRedo_CommandStateQuery(ByVal sender As Object, ByVal e As C1.Win.C1Command.CommandStateQueryEventArgs) Handles cmdRedo.CommandStateQuery
        e.Enabled = Me.RichTextBox1.CanRedo
    End Sub

    Private Sub cmdCut_Click(ByVal sender As System.Object, ByVal e As ClickEventArgs) Handles cmdCut.Click
        Me.RichTextBox1.Cut()
    End Sub

    Private Sub cmdCut_CommandStateQuery(ByVal sender As Object, ByVal e As C1.Win.C1Command.CommandStateQueryEventArgs) Handles cmdCut.CommandStateQuery
        e.Enabled = Me.RichTextBox1.SelectionType <> RichTextBoxSelectionTypes.Empty
    End Sub

    Private Sub cmdCopy_Click(ByVal sender As System.Object, ByVal e As ClickEventArgs) Handles cmdCopy.Click
        Me.RichTextBox1.Copy()
    End Sub

    Private Sub cmdCopy_CommandStateQuery(ByVal sender As Object, ByVal e As C1.Win.C1Command.CommandStateQueryEventArgs) Handles cmdCopy.CommandStateQuery
        e.Enabled = Me.RichTextBox1.SelectionType <> RichTextBoxSelectionTypes.Empty
    End Sub

    Private Sub cmdPaste_Click(ByVal sender As System.Object, ByVal e As ClickEventArgs) Handles cmdPaste.Click
        Me.RichTextBox1.Paste()
    End Sub

    Private Sub cmdPaste_CommandStateQuery(ByVal sender As Object, ByVal e As C1.Win.C1Command.CommandStateQueryEventArgs) Handles cmdPaste.CommandStateQuery
        Dim fmts As String() = Clipboard.GetDataObject().GetFormats()
        Dim fmt As String
        For Each fmt In fmts
            If Me.RichTextBox1.CanPaste(DataFormats.GetFormat(fmt)) Then
                e.Enabled = True
                Exit Sub
            End If
        Next
        e.Enabled = False
    End Sub

    Private Sub cmdFileNew_Click(ByVal sender As System.Object, ByVal e As ClickEventArgs) Handles cmdFileNew.Click
        If Not FileSaveIfChanged() Then
            Exit Sub
        End If
        Me.RichTextBox1.Clear()
    End Sub

    Private Sub cmdFileOpen_Click(ByVal sender As System.Object, ByVal e As ClickEventArgs) Handles cmdFileOpen.Click
        FileOpen()
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
        Me.cmdFileSave.Enabled = True
        If Me.Text.Length = 0 OrElse Me.Text.Chars(Me.Text.Length - 1) <> "*" Then
            Me.Text = Me.Text & "*"
        End If
    End Sub

    Private Sub FileOpen()
        If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then
            If Not FileSaveIfChanged() Then
                Exit Sub
            End If
            Try
                Me.RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.RichText)
                m_fileFormat = RichTextBoxStreamType.RichText
            Catch
                Try
                    Me.RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
                    m_fileFormat = RichTextBoxStreamType.PlainText
                Catch
                    Try
                        Me.RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText)
                        m_fileFormat = RichTextBoxStreamType.UnicodePlainText
                    Catch
                        MessageBox.Show("Could not load file " & Me.OpenFileDialog1.FileName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End Try
                End Try
            End Try
            Me.cmdFileSave.Enabled = False
            SetFileName(Me.OpenFileDialog1.FileName)
        End If
    End Sub

    Private Function FileSaveAs() As Boolean
        If SaveFileDialog1.ShowDialog(Me) = DialogResult.OK Then
            Try
                If SaveFileDialog1.FilterIndex = 1 Then
                    Me.RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText)
                    m_fileFormat = RichTextBoxStreamType.RichText
                ElseIf SaveFileDialog1.FilterIndex = 2 Then
                    Me.RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
                    m_fileFormat = RichTextBoxStreamType.PlainText
                Else
                    Me.RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText)
                    m_fileFormat = RichTextBoxStreamType.RichText
                End If
            Catch
                MessageBox.Show("Could not save file " & Me.SaveFileDialog1.FileName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
            Me.cmdFileSave.Enabled = False
            SetFileName(Me.SaveFileDialog1.FileName)
            Return True
        End If
    End Function

    Private Function FileSave() As Boolean
        ' use cmdFileSave.Enabled as the "dirty" flag
        If Not Me.cmdFileSave.Enabled Then
            Return True
        End If
        If m_fileName = Nothing Then
            Return FileSaveAs()
        ElseIf m_fileName.Length = 0 Then
            Return FileSaveAs()
        Else
            Me.RichTextBox1.SaveFile(m_fileName, m_fileFormat)
            Me.cmdFileSave.Enabled = False
            Me.SetFileName(Me.m_fileName)
            Return True
        End If
    End Function

    Private Function FileSaveIfChanged() As Boolean
        If Me.cmdFileSave.Enabled Then
            Dim dr As DialogResult
            dr = MessageBox.Show("File has been changed. Save changes?", "Save Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If dr = DialogResult.Cancel Then
                Return False
            ElseIf dr = DialogResult.No Then
                Return True
            ElseIf dr = DialogResult.Yes Then
                Return FileSave()
            End If
        Else
            Return True
        End If
    End Function

    Private Sub SetFileName(ByVal name As String)
        m_fileName = name
        Me.Text = "Simple Text Editor - " & name
    End Sub

    Private Sub cmdFileSave_Click(ByVal sender As System.Object, ByVal e As ClickEventArgs) Handles cmdFileSave.Click
        FileSave()
    End Sub

    Private Sub cmdFileClose_Click(ByVal sender As System.Object, ByVal e As ClickEventArgs) Handles cmdFileClose.Click
        If FileSaveIfChanged() Then
            Me.RichTextBox1.Clear()
            SetFileName("")
            Me.cmdFileSave.Enabled = False
        End If
    End Sub

    Private Sub cmdBullet_CheckedChanged(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.CheckedChangedEventArgs) Handles cmdBullet.CheckedChanged
        Me.RichTextBox1.SelectionBullet = e.NewValue
    End Sub

    Private Sub cmdBullet_CommandStateQuery(ByVal sender As Object, ByVal e As C1.Win.C1Command.CommandStateQueryEventArgs) Handles cmdBullet.CommandStateQuery
        e.Checked = Me.RichTextBox1.SelectionBullet
    End Sub

    Private Sub cmdCharOffsetNormal_Click(ByVal sender As System.Object, ByVal e As ClickEventArgs) Handles cmdCharOffsetNormal.Click
        Me.RichTextBox1.SelectionCharOffset = 0
    End Sub

    Private Sub cmdCharOffsetSuper_Click(ByVal sender As System.Object, ByVal e As ClickEventArgs) Handles cmdCharOffsetSuper.Click
        Me.RichTextBox1.SelectionCharOffset = 6
    End Sub

    Private Sub cmdCharOffsetSub_Click(ByVal sender As System.Object, ByVal e As ClickEventArgs) Handles cmdCharOffsetSub.Click
        Me.RichTextBox1.SelectionCharOffset = -6
    End Sub

    ' NOTE: for char offset items, we use Command.Pressed instead
    ' of Command.Checked, just to show that Pressed can be used as a toggle
    ' in the same manner as Checked, if desired (with slightly different
    ' visual result, more like a radiobutton).
    Private Sub cmdCharOffsetNormal_CommandStateQuery(ByVal sender As Object, ByVal e As C1.Win.C1Command.CommandStateQueryEventArgs) Handles cmdCharOffsetNormal.CommandStateQuery
        e.Pressed = Me.RichTextBox1.SelectionCharOffset = 0
    End Sub

    Private Sub cmdCharOffsetSuper_CommandStateQuery(ByVal sender As Object, ByVal e As C1.Win.C1Command.CommandStateQueryEventArgs) Handles cmdCharOffsetSuper.CommandStateQuery
        e.Pressed = Me.RichTextBox1.SelectionCharOffset > 0
    End Sub

    Private Sub cmdCharOffsetSub_CommandStateQuery(ByVal sender As Object, ByVal e As C1.Win.C1Command.CommandStateQueryEventArgs) Handles cmdCharOffsetSub.CommandStateQuery
        e.Pressed = Me.RichTextBox1.SelectionCharOffset < 0
    End Sub

    Private Sub cmdBold_Click(ByVal sender As System.Object, ByVal e As ClickEventArgs) Handles cmdBold.Click
        Dim fs As FontStyle
        If cmdBold.Checked Then
            fs = Me.RichTextBox1.SelectionFont.Style And Not FontStyle.Bold
        Else
            fs = Me.RichTextBox1.SelectionFont.Style Or FontStyle.Bold
        End If
        Me.RichTextBox1.SelectionFont = New Font(Me.RichTextBox1.SelectionFont, fs)
    End Sub

    Private Sub cmdItalic_Click(ByVal sender As System.Object, ByVal e As ClickEventArgs) Handles cmdItalic.Click
        Dim fs As FontStyle
        If cmdItalic.Checked Then
            fs = Me.RichTextBox1.SelectionFont.Style And Not FontStyle.Italic
        Else
            fs = Me.RichTextBox1.SelectionFont.Style Or FontStyle.Italic
        End If
        Me.RichTextBox1.SelectionFont = New Font(Me.RichTextBox1.SelectionFont, fs)
    End Sub

    Private Sub cmdUnderline_Click(ByVal sender As System.Object, ByVal e As ClickEventArgs) Handles cmdUnderline.Click
        Dim fs As FontStyle
        If cmdUnderline.Checked Then
            fs = Me.RichTextBox1.SelectionFont.Style And Not FontStyle.Underline
        Else
            fs = Me.RichTextBox1.SelectionFont.Style Or FontStyle.Underline
        End If
        Me.RichTextBox1.SelectionFont = New Font(Me.RichTextBox1.SelectionFont, fs)
    End Sub

    Private Sub cmdBold_CommandStateQuery(ByVal sender As Object, ByVal e As C1.Win.C1Command.CommandStateQueryEventArgs) Handles cmdBold.CommandStateQuery
        e.Checked = Not IsNothing(Me.RichTextBox1.SelectionFont) AndAlso Me.RichTextBox1.SelectionFont.Bold
        e.Enabled = Not IsNothing(Me.RichTextBox1.SelectionFont)
    End Sub

    Private Sub cmdItalic_CommandStateQuery(ByVal sender As Object, ByVal e As C1.Win.C1Command.CommandStateQueryEventArgs) Handles cmdItalic.CommandStateQuery
        e.Checked = Not IsNothing(Me.RichTextBox1.SelectionFont) AndAlso Me.RichTextBox1.SelectionFont.Italic
        e.Enabled = Not IsNothing(Me.RichTextBox1.SelectionFont)
    End Sub

    Private Sub cmdUnderline_CommandStateQuery(ByVal sender As Object, ByVal e As C1.Win.C1Command.CommandStateQueryEventArgs) Handles cmdUnderline.CommandStateQuery
        e.Checked = Not IsNothing(Me.RichTextBox1.SelectionFont) AndAlso Me.RichTextBox1.SelectionFont.Underline
        e.Enabled = Not IsNothing(Me.RichTextBox1.SelectionFont)
    End Sub

    Private Sub cmdFont_Click(ByVal sender As System.Object, ByVal e As ClickEventArgs) Handles cmdFont.Click
        If Me.FontDialog1.ShowDialog = DialogResult.OK Then
            Me.RichTextBox1.SelectionFont = Me.FontDialog1.Font
        End If
    End Sub

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Not FileSaveIfChanged() Then
            e.Cancel = True
        End If
    End Sub
End Class

