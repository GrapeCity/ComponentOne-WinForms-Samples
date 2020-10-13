Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace C1ApplicationZoomPages
    Partial Public Class AppZoom_Child2
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub
        Private _selectIndex As Integer

        Public Property _checkParam() As Integer
            Get
                Return _selectIndex
            End Get
            Set(value As Integer)
                _selectIndex = Value
            End Set
        End Property
    End Class
End Namespace
