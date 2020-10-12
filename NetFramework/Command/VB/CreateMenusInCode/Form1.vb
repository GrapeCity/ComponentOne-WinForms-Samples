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
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents textBox1 As System.Windows.Forms.TextBox
    Friend WithEvents imageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.label1 = New System.Windows.Forms.Label
        Me.button1 = New System.Windows.Forms.Button
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(8, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(264, 80)
        Me.label1.TabIndex = 3
        Me.label1.Text = "On form load, the text box below has default system context menu. Press the ""C1 M" & _
        "enu"" button to create a C1ContextMenu and associate it with the text box."
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(280, 8)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 4
        Me.button1.Text = "C1 Menu"
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(8, 96)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(344, 20)
        Me.textBox1.TabIndex = 5
        Me.textBox1.Text = "textBox1"
        '
        'imageList1
        '
        Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(360, 125)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub clickCut(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs)
        textBox1.Cut()
    End Sub

    ' The query methods are automatically called to provide the current state of
    ' corresponding commnads.
    Private Sub queryCut(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.CommandStateQueryEventArgs)
        e.Enabled = textBox1.SelectionLength > 0
    End Sub

    Private Sub clickCopy(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs)
        textBox1.Copy()
    End Sub

    Private Sub queryCopy(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.CommandStateQueryEventArgs)
        e.Enabled = textBox1.SelectionLength > 0
    End Sub

    Private Sub clickPaste(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs)
        textBox1.Paste()
    End Sub

    Private Sub queryPaste(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.CommandStateQueryEventArgs)
        e.Enabled = Clipboard.GetDataObject().GetDataPresent(DataFormats.Text)
    End Sub

    Private Sub clickUndo(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs)
        textBox1.Undo()
    End Sub

    Private Sub queryUndo(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.CommandStateQueryEventArgs)
        e.Enabled = textBox1.CanUndo
    End Sub


    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Try
            ' Create the command holder. This is essential for all C1Command operation
            Dim ch As C1CommandHolder = C1CommandHolder.CreateCommandHolder(Me)
            ' Use the pre-built image list
            ch.ImageList = Me.imageList1

            ' Create and set up the Cut command
            Dim cmdCut As C1Command = ch.CreateCommand()
            cmdCut.Text = "C&ut"
            cmdCut.Shortcut = Shortcut.CtrlX
            cmdCut.ImageIndex = 0
            AddHandler cmdCut.Click, AddressOf clickCut
            AddHandler cmdCut.CommandStateQuery, AddressOf queryCut

            ' Create and set up the Copy command
            Dim cmdCopy As C1Command = ch.CreateCommand()
            cmdCopy.Text = "&Copy"
            cmdCopy.Shortcut = Shortcut.CtrlC
            cmdCopy.ImageIndex = 1
            AddHandler cmdCopy.Click, AddressOf clickCopy
            AddHandler cmdCopy.CommandStateQuery, AddressOf queryCopy

            ' Create and set up the Paste command
            Dim cmdPaste As C1Command = ch.CreateCommand()
            cmdPaste.Text = "&Paste"
            cmdPaste.Shortcut = Shortcut.CtrlV
            cmdPaste.ImageIndex = 2
            AddHandler cmdPaste.Click, AddressOf clickPaste
            AddHandler cmdPaste.CommandStateQuery, AddressOf queryPaste

            ' Create and set up the Undo command
            Dim cmdUndo As C1Command = ch.CreateCommand()
            cmdUndo.Text = "&Undo"
            cmdUndo.Shortcut = Shortcut.CtrlZ
            cmdUndo.ImageIndex = -1
            AddHandler cmdUndo.Click, AddressOf clickUndo
            AddHandler cmdUndo.CommandStateQuery, AddressOf queryUndo

            ' Create the context menu to hold other commands
            Dim cm As C1ContextMenu = CType(ch.CreateCommand(GetType(C1ContextMenu)), C1ContextMenu)
            ' Fill it with the links to the commands
            cm.CommandLinks.Add(New C1CommandLink(cmdCut))
            cm.CommandLinks.Add(New C1CommandLink(cmdCopy))
            cm.CommandLinks.Add(New C1CommandLink(cmdPaste))
            Dim cl As C1CommandLink = New C1CommandLink(cmdUndo)
            ' This will show a delimiter before the Undo link.
            ' Another option is to create a separate empty link with the text "-".
            cl.Delimiter = True
            cm.CommandLinks.Add(cl)

            ' Assign the new context menu to the text box
            ch.SetC1ContextMenu(textBox1, cm)
        Catch ex As Exception
            ' Not the best way to code, but used here to illustrate a point:
            ' It is impossible to create more than one command holder for a form.
            ' The 2nd attempt will fail with an exception. Here we catch and ignore
            ' it...
        End Try

    End Sub
End Class
