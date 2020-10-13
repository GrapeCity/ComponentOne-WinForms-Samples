Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Public Class ViewDialog
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
    Friend WithEvents richTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.richTextBox = New System.Windows.Forms.RichTextBox()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'richTextBox
        '
        Me.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.richTextBox.Name = "richTextBox"
        Me.richTextBox.ReadOnly = True
        Me.richTextBox.Size = New System.Drawing.Size(520, 245)
        Me.richTextBox.TabIndex = 1
        Me.richTextBox.Text = ""
        Me.richTextBox.WordWrap = False
        '
        'panel1
        '
        Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1})
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel1.Location = New System.Drawing.Point(0, 213)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(520, 32)
        Me.panel1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(404, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "OK"
        '
        'ViewDialog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(520, 245)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel1, Me.richTextBox})
        Me.KeyPreview = True
        Me.Name = "ViewDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "File Viewer"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Hide()
    End Sub

    Public Sub SetContent(ByVal text As String)
        richTextBox.Text = text
    End Sub

    Private Sub ViewDialog_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(27) Then Hide()

    End Sub
End Class
