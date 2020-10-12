Imports C1.Win.C1Command

Public Class Form1
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents C1OutBar1 As C1.Win.C1Command.C1OutBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents C1OutPage1 As C1.Win.C1Command.C1OutPage
    Friend WithEvents C1OutPage2 As C1.Win.C1Command.C1OutPage
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.C1OutBar1 = New C1.Win.C1Command.C1OutBar
        Me.C1OutPage1 = New C1.Win.C1Command.C1OutPage
        Me.C1OutPage2 = New C1.Win.C1Command.C1OutPage
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.C1OutBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1OutBar1.SuspendLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1OutBar1
        '
        Me.C1OutBar1.Controls.Add(Me.C1OutPage1)
        Me.C1OutBar1.Controls.Add(Me.C1OutPage2)
        Me.C1OutBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1OutBar1.Location = New System.Drawing.Point(0, 0)
        Me.C1OutBar1.Name = "C1OutBar1"
        Me.C1OutBar1.SelectedIndex = 0
        Me.C1OutBar1.Size = New System.Drawing.Size(211, 254)
        Me.C1OutBar1.Text = "C1OutBar1"
        '
        'C1OutPage1
        '
        Me.C1OutPage1.Location = New System.Drawing.Point(0, 18)
        Me.C1OutPage1.Name = "C1OutPage1"
        Me.C1OutPage1.Size = New System.Drawing.Size(211, 218)
        Me.C1OutPage1.TabIndex = 0
        Me.C1OutPage1.Text = "File"
        '
        'C1OutPage2
        '
        Me.C1OutPage2.Location = New System.Drawing.Point(0, 36)
        Me.C1OutPage2.Name = "C1OutPage2"
        Me.C1OutPage2.Size = New System.Drawing.Size(211, 200)
        Me.C1OutPage2.TabIndex = 1
        Me.C1OutPage2.Text = "Navigation"
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.ImageList = Me.ImageList1
        Me.C1CommandHolder1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1CommandHolder1.Owner = Me
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Magenta
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(211, 254)
        Me.Controls.Add(Me.C1OutBar1)
        Me.Name = "Form1"
        Me.Text = "C1OutBar Sample"
        CType(Me.C1OutBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1OutBar1.ResumeLayout(False)
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private m_exit As Object = Nothing

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' create some commands:
        Dim cmdFileNew As C1Command = Me.C1CommandHolder1.CreateCommand()
        cmdFileNew.Text = "New"
        cmdFileNew.ImageIndex = 0
        Dim cmdFileOpen As C1Command = Me.C1CommandHolder1.CreateCommand()
        cmdFileOpen.Text = "Open"
        cmdFileOpen.ImageIndex = 1
        Dim cmdFileSave As C1Command = Me.C1CommandHolder1.CreateCommand()
        cmdFileSave.Text = "Save"
        cmdFileSave.ImageIndex = 2
        Dim cmdFileExit As C1Command = Me.C1CommandHolder1.CreateCommand()
        cmdFileExit.Text = "Exit"
        cmdFileExit.ImageIndex = 3
        ' save exit command for exit handler
        m_exit = cmdFileExit
        Dim cmdGoFirst As C1Command = Me.C1CommandHolder1.CreateCommand()
        cmdGoFirst.Text = "First"
        cmdGoFirst.ImageIndex = 4
        Dim cmdGoPrev As C1Command = Me.C1CommandHolder1.CreateCommand()
        cmdGoPrev.Text = "Previous"
        cmdGoPrev.ImageIndex = 5
        Dim cmdGoNext As C1Command = Me.C1CommandHolder1.CreateCommand()
        cmdGoNext.Text = "Next"
        cmdGoNext.ImageIndex = 6
        Dim cmdGoLast As C1Command = Me.C1CommandHolder1.CreateCommand()
        cmdGoLast.Text = "Last"
        cmdGoLast.ImageIndex = 7

        ' add a common handler for all commands
        ' (alternatively, individual handlers may be assigned
        ' to the Click event of each command)
        AddHandler Me.C1CommandHolder1.CommandClick, New CommandClickEventHandler(AddressOf HandleCommand)

        ' create 2 toolbars, set their properties for nice display in outbar
        Dim tbFile As C1ToolBar = New C1ToolBar
        tbFile.CommandHolder = Me.C1CommandHolder1
        tbFile.Horizontal = False
        tbFile.Dock = DockStyle.Fill
        tbFile.ButtonLayoutVert = ButtonLayoutEnum.TextBelow
        tbFile.ButtonLookVert = ButtonLookFlags.TextAndImage
        Dim tbGo As C1ToolBar = New C1ToolBar
        tbGo.CommandHolder = Me.C1CommandHolder1
        tbGo.Horizontal = False
        tbGo.Dock = DockStyle.Fill
        tbGo.ButtonLayoutVert = ButtonLayoutEnum.TextBelow
        tbGo.ButtonLookVert = ButtonLookFlags.TextAndImage

        ' add command links to toolbars
        tbFile.CommandLinks.Add(New C1CommandLink(cmdFileNew))
        tbFile.CommandLinks.Add(New C1CommandLink(cmdFileOpen))
        tbFile.CommandLinks.Add(New C1CommandLink(cmdFileSave))
        tbFile.CommandLinks.Add(New C1CommandLink(cmdFileExit))
        tbGo.CommandLinks.Add(New C1CommandLink(cmdGoFirst))
        tbGo.CommandLinks.Add(New C1CommandLink(cmdGoPrev))
        tbGo.CommandLinks.Add(New C1CommandLink(cmdGoNext))
        tbGo.CommandLinks.Add(New C1CommandLink(cmdGoLast))

        ' add toolbars to the outbar pages (pages were created at design time)
        Me.C1OutBar1.Pages(0).Controls.Add(tbFile)
        Me.C1OutBar1.Pages(1).Controls.Add(tbGo)
    End Sub

    Private Sub HandleCommand(ByVal sender As Object, ByVal e As CommandClickEventArgs)
        If e.Command Is m_exit Then
            Application.Exit()
        Else
            MessageBox.Show(e.Command.Text + " was clicked.")
        End If
    End Sub

End Class
