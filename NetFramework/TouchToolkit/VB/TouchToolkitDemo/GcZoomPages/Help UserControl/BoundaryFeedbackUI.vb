Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.TouchToolKit

Namespace C1ZoomPages
    Partial Public Class BoundaryFeedbackUI
        Inherits UserControl
        Public Sub New()
            InitializeComponent()
        End Sub

        Public Property BoundaryFeedbackMode() As BoundaryFeedbackMode
            Get
                Return If(radioButton1.Checked, BoundaryFeedbackMode.Split, BoundaryFeedbackMode.Standard)
            End Get
            Set
                radioButton1.Checked = (Value = BoundaryFeedbackMode.Split)
            End Set
        End Property

        Private Sub radioButton_CheckedChanged(sender As Object, e As EventArgs)
            Me.OnBoundaryFeedbackModeChanged(e)
        End Sub

        Public Event BoundaryFeedbackModeChanged As EventHandler(Of EventArgs)

        Protected Overridable Sub OnBoundaryFeedbackModeChanged(e As EventArgs)
            RaiseEvent BoundaryFeedbackModeChanged(Me, e)
        End Sub
    End Class
End Namespace
