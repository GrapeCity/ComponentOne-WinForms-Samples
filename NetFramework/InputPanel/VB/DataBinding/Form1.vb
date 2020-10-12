Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.IO

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Switch to C1NWind.mdb database
        Dim dbPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + _
            "\ComponentOne Samples\Common\C1NWind.mdb"
        If File.Exists(dbPath) Then
            Dim conn As OleDbConnection = EmployeesTableAdapter.Connection
            Dim csb As New OleDbConnectionStringBuilder(conn.ConnectionString)
            csb.DataSource = dbPath
            conn.ConnectionString = csb.ToString()
        End If

        EmployeesTableAdapter.Fill(NWINDDataSet.Employees)
    End Sub

    Private Sub InputDataNavigator1_SaveData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputDataNavigator1.SaveData
        EmployeesTableAdapter.Update(NWINDDataSet.Employees)
    End Sub

    Private Sub InputDataNavigator1_ReloadData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputDataNavigator1.ReloadData
        EmployeesTableAdapter.Fill(NWINDDataSet.Employees)
    End Sub

    Private Sub inputComboBox1_Format(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ListControlConvertEventArgs) Handles inputComboBox1.Format
        Dim pd As PropertyDescriptor = TypeDescriptor.GetProperties(e.ListItem)("FirstName")
        If pd IsNot Nothing Then
            Dim firstName As Object = pd.GetValue(e.ListItem)
            If TypeOf firstName Is String And TypeOf e.Value Is String Then
                e.Value = CType(firstName, String) + " " + CType(e.Value, String)
            End If
        End If
    End Sub

End Class
