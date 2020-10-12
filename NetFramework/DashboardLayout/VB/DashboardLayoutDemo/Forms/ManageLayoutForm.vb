Imports C1.Win.C1Ribbon

Namespace DashboardDemo
    Public Partial Class ManageLayoutForm
        Inherits C1RibbonForm

        Private _helper As SampleHelper

        Public Sub New(ByVal helper As SampleHelper)
            _helper = helper
            InitializeComponent()
            Reset()
        End Sub

        Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            Close()
        End Sub

        Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            _helper.DeleteLayout(c1List1.SelectedText)
            Reset()
        End Sub

        Private Sub btnRename_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            _helper.RenameLayout(c1List1.SelectedText)
            Reset()
        End Sub

        Private Sub c1List1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            AllowButtons(True)
        End Sub

        Private Sub Reset()
            c1List1.DataSource = _helper.GetLayouts()
            AllowButtons(False)
        End Sub

        Private Sub AllowButtons(ByVal allow As Boolean)
            btnRename.Enabled = allow
            btnDelete.Enabled = allow
        End Sub
    End Class
End Namespace
