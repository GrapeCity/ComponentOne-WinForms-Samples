Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Threading


Namespace C1.Win.FlexGrid
    Public Class C1PrintProgress
        Inherits System.Windows.Forms.Form


        Private WithEvents btnCancel As System.Windows.Forms.Button
        Private WithEvents lblProgress As System.Windows.Forms.Label
        Private _cancelClicked As Boolean = False
        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            components = New System.ComponentModel.Container
            'Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font

            Me.btnCancel = New System.Windows.Forms.Button()
            Me.lblProgress = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            ' 
            ' btnCancel
            ' 
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New System.Drawing.Point(102, 60)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(75, 23)
            Me.btnCancel.TabIndex = 0
            Me.btnCancel.Text = "Cancel"
            ' 
            ' lblProgress
            ' 
            Me.lblProgress.Location = New System.Drawing.Point(32, 20)
            Me.lblProgress.Name = "lblProgress"
            Me.lblProgress.Size = New System.Drawing.Size(219, 23)
            Me.lblProgress.TabIndex = 1
            Me.lblProgress.Text = "Printing has started..."
            Me.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ' 
            ' C1PrintProgress
            ' 
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(277, 99)
            Me.ControlBox = False
            Me.Controls.Add(Me.lblProgress)
            Me.Controls.Add(Me.btnCancel)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "C1PrintProgress"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Printing C1FlexGrid"
            Me.TopMost = True
            Me.ResumeLayout(False)

        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            Me.btnCancel.Enabled = False
            _cancelClicked = True
        End Sub

        ' Gets or sets the text used to display the current progress when the grid is printed/previewed.
        Public Property TxtPrinting() As String
            Get
                Return Me.lblProgress.Text
            End Get
            Set(ByVal value As String)
                Me.lblProgress.Text = value
            End Set
        End Property

        ' Gets or sets the text for the Cancel button.
        Public Property TxtCancel() As String
            Get
                Return Me.btnCancel.Text
            End Get
            Set(ByVal value As String)
                Me.btnCancel.Text = value
            End Set
        End Property

        ' Gets or sets the text for the Windows caption.
        Public Property TxtTitle() As String
            Get
                Return Me.Text
            End Get
            Set(ByVal value As String)
                Me.Text = value
            End Set
        End Property

        ' Gets a value indicating if the print/preview was cancelled.
        Public ReadOnly Property CancelClicked() As Boolean
            Get
                Return _cancelClicked
            End Get
        End Property
    End Class
End Namespace
