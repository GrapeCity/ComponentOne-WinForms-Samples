Public Class CellNote
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
    Friend WithEvents _txtNote As System.Windows.Forms.TextBox
    Friend WithEvents _lblGrip As System.Windows.Forms.Label
    Friend WithEvents _lblShadow As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me._txtNote = New System.Windows.Forms.TextBox()
        Me._lblGrip = New System.Windows.Forms.Label()
        Me._lblShadow = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        '_txtNote
        '
        Me._txtNote.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me._txtNote.BackColor = System.Drawing.SystemColors.Info
        Me._txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._txtNote.Location = New System.Drawing.Point(36, 0)
        Me._txtNote.Multiline = True
        Me._txtNote.Name = "_txtNote"
        Me._txtNote.Size = New System.Drawing.Size(252, 76)
        Me._txtNote.TabIndex = 2
        Me._txtNote.Text = "** Enter your notes here..."
        '
        '_lblGrip
        '
        Me._lblGrip.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me._lblGrip.BackColor = System.Drawing.Color.Black
        Me._lblGrip.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me._lblGrip.Location = New System.Drawing.Point(280, 68)
        Me._lblGrip.Name = "_lblGrip"
        Me._lblGrip.Size = New System.Drawing.Size(12, 12)
        Me._lblGrip.TabIndex = 4
        '
        '_lblShadow
        '
        Me._lblShadow.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me._lblShadow.BackColor = System.Drawing.Color.DimGray
        Me._lblShadow.Location = New System.Drawing.Point(36, 0)
        Me._lblShadow.Name = "_lblShadow"
        Me._lblShadow.Size = New System.Drawing.Size(256, 80)
        Me._lblShadow.TabIndex = 3
        '
        'CellNote
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(296, 81)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._txtNote, Me._lblGrip, Me._lblShadow})
        Me.Name = "CellNote"
        Me.Text = "CellNote"
        Me.ResumeLayout(False)

    End Sub

#End Region

    '------------------------------------------------------------------------------------------------------

    Dim _ptCell As Point
    Dim _editing As Boolean

    '------------------------------------------------------------------------------------------------------

    ' ctor
    Public Sub New(ByVal noteText As String)
        Me.components = Nothing
        Me.InitializeComponent()
        MyBase.ShowInTaskbar = False
        MyBase.StartPosition = FormStartPosition.Manual
        MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        MyBase.TransparencyKey = Me.BackColor
        Me.NoteText = noteText
    End Sub

    '/ <summary>
    '/ Gets or sets the contents of the note.
    '/ </summary>
    Public Property NoteText() As String
        Get
            Return Me._txtNote.Text
        End Get
        Set(ByVal value As String)
            Me._txtNote.Text = value
        End Set
    End Property


    '/ <summary>
    '/ Show the note with a connector to the cell.
    '/ </summary>
    '/ <param name="r">Position of the cell in screen coordinates.</param>
    Public Sub ShowNote(ByVal r As Rectangle)
        Me.ShowNote(r, False)
    End Sub


    '/ <summary>
    '/ Hide the note if it is visible.
    '/ </summary>
    Public Sub HideNote()
        If Not Me._editing Then
            MyBase.Visible = False
        End If
    End Sub


    '/ <summary>
    '/ Show the note with a connector to the cell and allow the user to edit the note.
    '/ </summary>
    '/ <param name="r">Position of the cell in screen coordinates.</param>
    Public Sub EditNote(ByVal r As Rectangle)
        Me.ShowNote(r, True)
    End Sub

    '------------------------------------------------------------------------------------------------------

    Private Sub ShowNote(ByVal r As Rectangle, ByVal editMode As Boolean)
        If Not MyBase.Visible Then

            ' position form
            MyBase.Left = (r.Right + 1)
            MyBase.Top = (r.Y - 30)

            ' store cell position
            r = MyBase.RectangleToClient(r)
            Me._ptCell = New Point(r.Right, r.Top)

            ' start showing/editing the note
            Me._editing = editMode
            If editMode Then

                ' show the form
                MyBase.Show()

                ' move the cursor over the editor
                Dim pt As New Point((Me._txtNote.Width / 2), (Me._txtNote.Height / 2))
                me.Cursor.Position = Me._txtNote.PointToScreen(pt)

                ' place selection at the end
                Me._txtNote.SelectionStart = 32000
            Else

                ' disable editor so it won't get the focus
                Me._txtNote.Enabled = False

                ' show the form
                MyBase.Show()

                ' re-enable editor so it doesn't look disabled
                Me._txtNote.Enabled = True
            End If
        End If
    End Sub

    '------------------------------------------------------------------------------------------------------

    ' draw connector from cell to editor
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim pt As Point = Me._txtNote.Location
        e.Graphics.DrawLine(Pens.Black, Me._ptCell, pt)
        MyBase.OnPaint(e)
    End Sub

    ' hide form when the editor loses focus
    Protected Overrides Sub OnDeactivate(ByVal e As EventArgs)
        MyBase.Visible = False
    End Sub


    ' handle resizing the editor
    Dim _ptDown As Point
    Dim _szDown As Size

    Private Sub _lblGrip_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        Me._ptDown = Control.MousePosition
        Me._szDown = MyBase.Size
    End Sub

    Private Sub _lblGrip_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
        If ((e.Button And System.Windows.Forms.MouseButtons.Left) <> System.Windows.Forms.MouseButtons.None) Then
            Dim pt As Point = Control.MousePosition
            MyBase.Size = New Size((Me._szDown.Width + (pt.X - Me._ptDown.X)), (Me._szDown.Height + (pt.Y - Me._ptDown.Y)))
        End If
    End Sub

End Class
