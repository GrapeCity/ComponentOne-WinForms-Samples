Imports System.Data.OleDb

Module Util
    Function GetConnectionString() As String
        Dim path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common"
        Dim conn = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function

    Sub FillTable(ByVal ds As DataSet, ByVal tableName As String, ByVal conn As String)
        tableName = tableName.Trim()
        Dim sql As String = String.Format("select * from [{0}]", tableName)
        Dim da = New OleDbDataAdapter(sql, conn)
        da.Fill(ds, tableName)
    End Sub
End Module
