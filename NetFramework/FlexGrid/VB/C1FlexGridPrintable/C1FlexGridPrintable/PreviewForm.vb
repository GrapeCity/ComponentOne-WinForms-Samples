Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Threading

Namespace C1.Win.FlexGrid
    Public Class PreviewForm
        Inherits System.Windows.Forms.Form

        Private _grid As Global.C1.Win.FlexGrid.C1FlexGrid

        ''' <summary>
        ''' Creates a new instance of the PrintFrom class.
        ''' </summary>
        Public Sub New(ByVal grid As Global.C1.Win.FlexGrid.C1FlexGrid)
            _grid = grid
            Init()
        End Sub

        ''' <summary>
        ''' Additional initialization of the form.
        ''' </summary>
        Private Sub Init()
            Dim scrn As Rectangle = Screen.GetWorkingArea(Me)
            Size = new Size(Math.Round(scrn.Height * 0.75, 0), Math.Round(scrn.Height * 0.75, 0))
            Location = New Point((scrn.Width - Width) / 2, (scrn.Height - Height) / 2)
            'FormBorderStyle = FormBorderStyle.FixedToolWindow
            ResumeLayout(False)
        End Sub

        Friend Property Grid() As Global.C1.Win.FlexGrid.C1FlexGrid
            Get
                Return _grid
            End Get
            Set(ByVal value As Global.C1.Win.FlexGrid.C1FlexGrid)
                _grid = value
            End Set
        End Property

        Private Sub InitializeComponent()
            Me.SuspendLayout()
            '
            'PreviewForm
            '
            Me.ClientSize = New System.Drawing.Size(292, 266)
            Me.Name = "PreviewForm"
            Me.Text = "C1FlexGrid preview"
            Me.ResumeLayout(False)

        End Sub

    End Class
End Namespace
