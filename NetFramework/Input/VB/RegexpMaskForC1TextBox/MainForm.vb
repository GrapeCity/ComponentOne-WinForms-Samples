Imports C1.Win.C1Themes
Imports C1.Win.Ribbon

Partial Public Class MainForm
    Inherits C1RibbonForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitThemes()
    End Sub

#Region "Themes"

    Private Sub CmbThemes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbThemes.SelectedIndexChanged
        C1ThemeController1.Theme = cmbThemes.SelectedItem.Text
    End Sub

    Private Sub InitThemes()
        Dim themes = C1ThemeController.GetThemes().Where(Function(x) x.Contains("Office2016"))

        For Each theme In themes
            cmbThemes.Items.Add(theme)
        Next
    End Sub

#End Region
    Private Sub c1Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        c1TextBox1.MaskInfo.RegexpEditMask = c1TextBox3.Text

        If c1TextBox1.MaskInfo.IsRegexpPatternRecognized Then
            c1Label2.Value = c1TextBox1.MaskInfo.RegexpEditMask
            c1Label2.ForeColor = Color.Black
        Else
            c1Label2.Value = "Pattern was not recognized."
            c1Label2.ForeColor = Color.Red
        End If
    End Sub

    Private Sub c1Button2_Click(ByVal sender As Object, ByVal e As EventArgs)
        c1TextBox2.MaskInfo.RegexpEditMask = c1TextBox4.Text

        If c1TextBox2.MaskInfo.IsRegexpPatternRecognized Then
            c1Label7.Value = c1TextBox2.MaskInfo.RegexpEditMask
            c1Label7.ForeColor = Color.Black
        Else
            c1Label7.Value = "Pattern was not recognized."
            c1Label7.ForeColor = Color.Red
        End If
    End Sub

    Private Sub c1Button3_Click(ByVal sender As Object, ByVal e As EventArgs)
        c1TextBox1.MaskInfo.RegexpEditMask = c1TextBox2.MaskInfo.RegexpEditMask
        c1Label2.Value = c1TextBox1.MaskInfo.RegexpEditMask

        If c1TextBox1.MaskInfo.IsRegexpPatternRecognized Then
            c1Label2.Value = c1TextBox1.MaskInfo.RegexpEditMask
            c1Label2.ForeColor = Color.Black
        Else
            c1Label2.Value = "Pattern was not recognized."
            c1Label2.ForeColor = Color.Red
        End If
    End Sub

    Private Sub c1Button4_Click(ByVal sender As Object, ByVal e As EventArgs)
        c1TextBox2.MaskInfo.RegexpEditMask = c1TextBox1.MaskInfo.RegexpEditMask

        If c1TextBox2.MaskInfo.IsRegexpPatternRecognized Then
            c1Label7.Value = c1TextBox2.MaskInfo.RegexpEditMask
            c1Label7.ForeColor = Color.Black
        Else
            c1Label7.Value = "Pattern was not recognized."
            c1Label7.ForeColor = Color.Red
        End If
    End Sub

    Private Sub c1ComboBox1_SelectedItemChanged(ByVal sender As Object, ByVal e As EventArgs) Handles c1ComboBox1.SelectedItemChanged
        c1TextBox1.MaskInfo.RegexpEditMask = c1ComboBox1.SelectedItem.ToString()
        c1Label2.Value = c1TextBox1.MaskInfo.RegexpEditMask
    End Sub

    Private Sub c1ComboBox2_SelectedItemChanged(ByVal sender As Object, ByVal e As EventArgs) Handles c1ComboBox2.SelectedItemChanged
        c1TextBox2.MaskInfo.RegexpEditMask = c1ComboBox2.SelectedItem.ToString()
        c1Label7.Value = c1TextBox2.MaskInfo.RegexpEditMask
    End Sub

    Private Sub linkLabel1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles linkLabel1.Click
        Try
            System.Diagnostics.Process.Start("https://developer.mescius.com/componentone/docs/win/online-input/MaskedInputUsingRegularExpressions.html")
        Catch
            MessageBox.Show("Unable to open link https://developer.mescius.com/componentone/docs/win/online-input/MaskedInputUsingRegularExpressions.html.")
        End Try
    End Sub

End Class
