Imports C1.Win.C1SuperTooltip

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds.DataSetName = "AuthorsDataSet"
        ds.ReadXml("..\\..\\authors.xml", System.Data.XmlReadMode.Auto)
        bs.DataMember = "authors"

        txtFirstName.DataBindings.Add(New Binding("Text", bs, "FirstName"))
        txtLastName.DataBindings.Add(New Binding("Text", bs, "LastName"))
        txtPhone.DataBindings.Add(New Binding("Text", bs, "Phone"))
        txtAddress.DataBindings.Add(New Binding("Text", bs, "Address"))
        txtCity.DataBindings.Add(New Binding("Text", bs, "City"))
        txtState.DataBindings.Add(New Binding("Text", bs, "State"))
        txtZip.DataBindings.Add(New Binding("Text", bs, "Zip"))

        cbField.SelectedIndex = 2
    End Sub

    Private Sub btnSetError_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetError.Click
        Dim columnName As String = cbField.Text
        If Not String.IsNullOrEmpty(columnName) Then
            CType(bs.Current, DataRowView).Row.SetColumnError(columnName, _
                "<table><tr>" + _
                  "<td><parm><img src='res://Cancel2.png'></parm></td>" + _
                  "<td><b><parm>Wrong value</parm></b></td>" + _
                "</tr></table>" + _
                "<parm><hr noshade size=1 style='margin:2' color=darker></parm>" + _
                "<div style='margin:1 12'><parm>" + _
                  "This field has an associated error." + _
                "</parm></div>" + _
                "<parm></parm>" + _
                "<table><tr>" + _
                  "<td><parm></parm></td>" + _
                  "<td><b><parm></parm></b></td>" + _
                "</tr></table>")
        End If

    End Sub

    Private Sub btnClearError_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearError.Click
        Dim columnName As String = cbField.Text
        If Not String.IsNullOrEmpty(columnName) Then
            CType(bs.Current, DataRowView).Row.SetColumnError(columnName, "")
        End If
    End Sub

    Private Sub epComplete_IconClick(ByVal sender As System.Object, ByVal e As C1.Win.C1SuperTooltip.IconClickEventArgs) Handles epComplete.IconClick
        Dim tb As TextBox = CType(e.Control, TextBox)
        MessageBox.Show("""" + tb.Text + """ is the correct value.", "Information")
    End Sub

    Private Sub SetError1(ByVal ep As C1SuperErrorProvider, ByVal tb As TextBox)
        ep.SetError(tb, _
            "<table><tr>" + _
            "  <td><parm><img src='res://Info2.png'></parm></td>" + _
            "  <td><b><parm></parm></b></td>" + _
            "</tr></table>" + _
            "<parm></parm>" + _
            "<div style='margin:1 12'><parm>" + _
            "  This is a required field." + _
            "</parm></div>" + _
            "<parm></parm>" + _
            "<table><tr>" + _
            "  <td><parm></parm></td>" + _
            "  <td><b><parm></parm></b></td>" + _
            "</tr></table>")
    End Sub

    Private Sub SetError2(ByVal ep As C1SuperErrorProvider, ByVal tb As TextBox)
        ep.SetError(tb, "<b>Too short or too long string.</b><br>The string must consist of 5 - 10 characters.")
    End Sub

    Private Sub textBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textBox3.TextChanged, textBox2.TextChanged, textBox1.TextChanged
        Dim tb As TextBox = CType(sender, TextBox)
        Dim s As String = tb.Text
        If s.Length = 0 Then
            epComplete.SetError(tb, "")
            epWarning.SetError(tb, "")
            SetError1(epInfo, tb)
        Else
            epInfo.SetError(tb, "")
            If s.Length < 5 Or s.Length > 10 Then
                epComplete.SetError(tb, "")
                SetError2(epWarning, tb)
            Else
                epWarning.SetError(tb, "")
                epComplete.SetError(tb, "Click for more info")
            End If
        End If
    End Sub

    Private Sub textBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textBox3.Enter, textBox2.Enter, textBox1.Enter
        Dim tb As TextBox = CType(sender, TextBox)
        Dim s As String = tb.Text
        If s.Length > 0 And (s.Length < 5 Or s.Length > 10) Then
            epError.SetError(tb, "")
            SetError2(epWarning, tb)
        End If
    End Sub

    Private Sub textBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textBox3.Leave, textBox2.Leave, textBox1.Leave
        Dim tb As TextBox = CType(sender, TextBox)
        Dim s As String = tb.Text
        If s.Length > 0 And (s.Length < 5 Or s.Length > 10) Then
            epWarning.SetError(tb, "")
            SetError2(epError, tb)
        End If
    End Sub

End Class
