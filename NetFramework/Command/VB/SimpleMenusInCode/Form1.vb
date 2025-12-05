Imports C1.Win.Command

Public Class Form1
    Inherits System.Windows.Forms.Form

    Shared s_Forms As New ArrayList

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        s_Forms.Add(Me)

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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(472, 357)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Magenta
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(472, 357)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "Form1"
        Me.Text = "New document"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ch As C1CommandHolder = C1CommandHolder.CreateCommandHolder(Me)
        ' In this sample, we use a single event handler for all commands,
        ' and use a switch statement inside that handler to select the specific
        ' action. Alternatively, each command can be assigned its own Click
        ' event handler. Or, a mix of the two approaches is possible.
        AddHandler ch.CommandClick, New CommandClickEventHandler(AddressOf CommandClickHandler)
        ' use the image list for command images
        ch.ImageList = Me.ImageList1

        Dim mm As New C1MainMenu
        Me.Controls.Add(mm)
        ' For the main menu, its CommandHolder property should be set
        ' (this is not required for builds 1.0.20041.47 or later of C1Command).
        mm.CommandHolder = ch

        ' Main menu - File
        Dim mFile As C1CommandMenu = CType(ch.CreateCommand(GetType(C1CommandMenu)), C1CommandMenu)
        mFile.Text = "&File"
        mm.CommandLinks.Add(New C1CommandLink(mFile))

        ' create commands for file ops
        Dim cNew As C1Command = ch.CreateCommand()
        cNew.Text = "&New"
        ' UserData is arbitrary data associated with commands;
        ' In this example we use text labels to recognize specific commands
        ' in the single command handler. Alternatively, we could have commands
        ' as members of our class, and compare objects to recognize commands.
        cNew.UserData = "file_new"
        cNew.Shortcut = Shortcut.CtrlN
        cNew.ImageIndex = 1
        Dim cOpen As C1Command = ch.CreateCommand()
        cOpen.Text = "&Open"
        cOpen.UserData = "file_open"
        cOpen.Shortcut = Shortcut.CtrlO
        cOpen.ImageIndex = 0
        Dim cExit As C1Command = ch.CreateCommand()
        cExit.Text = "E&xit"
        cExit.UserData = "exit"
        cExit.Shortcut = Shortcut.CtrlX

        mFile.CommandLinks.Add(New C1CommandLink(cNew))
        mFile.CommandLinks.Add(New C1CommandLink(cOpen))
        mFile.CommandLinks.Add(New C1CommandLink)
        mFile.CommandLinks(mFile.CommandLinks.Count - 1).Text = "-"
        mFile.CommandLinks.Add(New C1CommandLink(cExit))

        ' Main menu - Window
        Dim mWindow As C1CommandMenu = CType(ch.CreateCommand(GetType(C1CommandMenu)), C1CommandMenu)
        mWindow.Text = "&Window"
        mm.CommandLinks.Add(New C1CommandLink(mWindow))

        Dim cNewWindow As C1Command = ch.CreateCommand()
        cNewWindow.Text = "New &Window"
        cNewWindow.UserData = "window_new"
        cNewWindow.Shortcut = Shortcut.CtrlW
        cNewWindow.ImageIndex = 2

        mWindow.CommandLinks.Add(New C1CommandLink(cNewWindow))

        ' For toolbars to be dockable/floatable, we must put them
        ' in a C1CommandDock:
        Dim dock As New C1CommandDock
        Me.Controls.Add(dock)
        dock.Dock = DockStyle.Top
        ' Add a toolbar, link it to the (already existing) commands:
        Dim tb As New C1ToolBar
        ' add file commands and the window menu to the toolbar
        tb.CommandLinks.Add(New C1CommandLink(cNew))
        tb.CommandLinks.Add(New C1CommandLink(cOpen))
        Dim cl As C1CommandLink
        cl = New C1CommandLink(mWindow)
        tb.CommandLinks.Add(cl)
        ' because we did not provide an image for the window menu,
        ' make it show as text
        cl.ButtonLook = ButtonLookFlags.Text
        cl = New C1CommandLink(cExit)
        tb.CommandLinks.Add(cl)
        ' ditto for the exit command
        cl.ButtonLook = ButtonLookFlags.Text
        ' add the new toolbar to the dock
        dock.Controls.Add(tb)

    End Sub

    Private Sub CommandClickHandler(ByVal sender As Object, ByVal e As CommandClickEventArgs)
        Dim cmdData As String = CType(e.Command.UserData, String)

        Select Case (cmdData)

            Case "file_new"
                Me.RichTextBox1.Text = String.Empty
                Me.Text = "New document"

            Case "file_open"
                Dim ofd As New OpenFileDialog
                ofd.Filter = "Text files|*.txt|Rich text files|*.rtf|All files|*.*"
                If (ofd.ShowDialog() = DialogResult.OK) Then

                    Select Case (ofd.FilterIndex)
                        Case 1
                            Me.RichTextBox1.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText)
                        Case 2
                            Me.RichTextBox1.LoadFile(ofd.FileName, RichTextBoxStreamType.RichText)
                        Case Else
                            Me.RichTextBox1.LoadFile(ofd.FileName)
                    End Select
                    Me.Text = ofd.FileName
                End If

            Case "exit"
                Dim f As Form
                For Each f In s_forms
                    f.Close()
                Next

            Case "window_new"
                Dim f1 As New Form1
                f1.Show()

            Case Else
                ' unknown command - should not happen
        End Select

    End Sub
End Class
