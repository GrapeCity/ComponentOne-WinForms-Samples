Imports System.ComponentModel
Imports C1.Win.C1Themes
Imports C1.Win.Ribbon

Partial Public Class MainForm
    Inherits C1RibbonForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitThemes()
        Dim datalist As BindingList(Of SaleInfo) = New BindingList(Of SaleInfo)()
        Dim t1 As Transactor = New Transactor("Alice Smit", "Wonderland", "Tinytown", "S1", "89182", "222222", "987654321021", "ABC", New DateTime(2021, 4, 10))
        Dim t2 As Transactor = New Transactor("Bob Bill", "Oz", "Largetown", "S2", "98064", "333333", "123456789012", "Technology inc", New DateTime(2021, 4, 10))
        datalist.Add(New SaleInfo(New DateTime(2021, 4, 10), t1, t2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin vel tortor dolor. Fusce vulputate facilisis tortor commodo luctus. Praesent ligula ante, convallis eget lacus ut, ultrices semper enim. Morbi ac scelerisque metus. Integer finibus malesuada fermentum. Donec pulvinar nisl nec felis ornare, eu egestas augue molestie. Donec sed dui sit amet enim pulvinar blandit. In ac dui bibendum, maximus diam eu, tempus nulla. Aliquam pellentesque viverra felis hendrerit dictum. Sed pharetra nisl non leo tincidunt feugiat.", 300, "cash"))
        billOfSaleBindingSource.DataSource = datalist(0)

    End Sub

#Region "Themes"

    Private Sub CmbThemes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbThemes.SelectedIndexChanged
        C1ThemeController1.Theme = cmbThemes.SelectedItem.Text
    End Sub

    Private Sub InitThemes()
        Dim themes = C1ThemeController.GetThemes().Where(Function(x) x.Contains("Office365"))

        For Each theme In themes
            cmbThemes.Items.Add(theme)
        Next

        cmbThemes.SelectedIndex = cmbThemes.Items.IndexOf("Office365White")
    End Sub

#End Region


End Class
Public Class RichTextBoxHost
    Inherits C1.Win.C1InputPanel.InputControlHost

    Public Sub New()
        MyBase.New(New System.Windows.Forms.RichTextBox())
    End Sub
End Class
