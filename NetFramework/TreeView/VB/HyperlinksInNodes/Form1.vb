Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' init data
        C1TreeView1.BindingInfo.DataSource = Data.GetData()
        C1TreeView1.BindingInfo.DataMember = "Hyperlinks"
        ' set hyperlink styles
        C1TreeView1.Columns(0).Styles.Default.ForeColor = Color.Blue
        C1TreeView1.Columns(0).Styles.Hot.ForeColor = Color.Blue
        C1TreeView1.Columns(0).CustomContentPresenter = New HyperLinkPresenter()
        C1TreeView1.ExpandAll()
    End Sub
End Class
