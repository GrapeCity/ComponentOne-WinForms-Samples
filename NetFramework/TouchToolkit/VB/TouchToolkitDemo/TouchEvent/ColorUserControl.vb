Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace TouchEvent
    Partial Public Class ColorUserControl
        Inherits UserControl
#Region "Filed"

        Private _color As Color
        Private _isNormalSize As Boolean = True

#End Region

#Region "Init"

        Public Sub New()
            InitializeComponent()
            For Each button As Button In tableLayoutPanel1.Controls
                AddHandler button.Click, AddressOf button_Click
            Next
        End Sub

#End Region

#Region "Property"

        Public ReadOnly Property Color() As Color
            Get
                Return _color
            End Get
        End Property

        Public Property IsNormalSize() As Boolean
            Get
                Return _isNormalSize
            End Get
            Set(value As Boolean)
                If _isNormalSize <> value Then
                    _isNormalSize = value
                    If _isNormalSize Then
                        tableLayoutPanel1.Size = New Size(200, 150)
                        Me.Size = New Size(200, 150)
                    Else
                        Me.Size = New Size(400, 300)
                        tableLayoutPanel1.Size = New Size(400, 300)
                    End If
                End If
            End Set
        End Property

#End Region

#Region "Methods and Events"

        Public Event ValueChanged As EventHandler(Of EventArgs)

        Protected Overridable Sub OnValueChanged(e As EventArgs)
            RaiseEvent ValueChanged(Me, e)
        End Sub

        Private Sub button_Click(sender As Object, e As EventArgs)
            _color = TryCast(sender, Button).BackColor
            OnValueChanged(EventArgs.Empty)
        End Sub

#End Region
    End Class
End Namespace
