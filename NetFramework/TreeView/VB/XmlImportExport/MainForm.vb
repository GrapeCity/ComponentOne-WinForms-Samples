Imports System.IO
Imports C1.Win.C1Themes
Imports C1.Win.Ribbon

Partial Public Class MainForm
    Inherits C1RibbonForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitThemes()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Using saveFileDialog As SaveFileDialog = New SaveFileDialog() With {
            .Filter = "Xml File | *.xml",
            .FileName = "C1TreeView.xml"
        }

            If saveFileDialog.ShowDialog() = DialogResult.OK Then

                Try
                    c1TreeView1.WriteXml(saveFileDialog.FileName)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "C1TreeView can't export to xml file.")
                End Try
            End If
        End Using
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Using openFileDialog As OpenFileDialog = New OpenFileDialog() With {
            .Filter = "Xml File | *.xml",
            .InitialDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Resources"),
            .FileName = "SimpleTree.xml"
        }

            If openFileDialog.ShowDialog() = DialogResult.OK Then

                Try
                    c1TreeView1.ReadXml(openFileDialog.FileName)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "C1TreeView can't import from xml file.")
                End Try
            End If
        End Using
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
