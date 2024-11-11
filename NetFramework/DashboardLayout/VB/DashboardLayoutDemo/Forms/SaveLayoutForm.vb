Imports System
Imports System.Windows.Forms
Imports C1.Win.Ribbon

Namespace DashboardDemo
    Public Partial Class SaveLayoutForm
        Inherits C1RibbonForm

        Public Sub New(ByVal Optional name As String = Nothing)
            InitializeComponent()
            If name IsNot Nothing Then c1TextBox1.Value = name
        End Sub

        Public ReadOnly Property FileName As String
            Get
                Return c1TextBox1.Text
            End Get
        End Property

        Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs)
            DialogResult = DialogResult.OK
            Close()
        End Sub
    End Class
End Namespace
