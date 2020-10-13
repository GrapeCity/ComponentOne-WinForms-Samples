'#define USE_SQL
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Collections
Imports System.Text

Namespace SqlFilter
	''' <summary>
	''' Extends the <see cref="DataTable"/> class to load and cache data on demand
	''' using a <see cref="Fill"/> method that takes a set of keys as a parameter.
	''' </summary>
	Friend Class CachedDataTable
		Inherits DataTable
		'----------------------------------------------------------------------------
		#Region "** fields"

		Private _values As New Dictionary(Of Object, Boolean)()

		#End Region

		'----------------------------------------------------------------------------
		#Region "** ctors"

		Public Sub New(ByVal sqlTemplate As String, ByVal whereClauseTemplate As String, ByVal connString As String)
			ConnectionString = connString
			Me.SqlTemplate = sqlTemplate
			Me.WhereClauseTemplate = whereClauseTemplate
		End Sub

		#End Region

		'----------------------------------------------------------------------------
		#Region "** object model"

		Private privateConnectionString As String
		Public Property ConnectionString() As String
			Get
				Return privateConnectionString
			End Get
			Set(ByVal value As String)
				privateConnectionString = value
			End Set
		End Property
		Private privateSqlTemplate As String
		Public Property SqlTemplate() As String
			Get
				Return privateSqlTemplate
			End Get
			Set(ByVal value As String)
				privateSqlTemplate = value
			End Set
		End Property
		Private privateWhereClauseTemplate As String
		Public Property WhereClauseTemplate() As String
			Get
				Return privateWhereClauseTemplate
			End Get
			Set(ByVal value As String)
				privateWhereClauseTemplate = value
			End Set
		End Property

		Public Sub Fill(ByVal filterValues As IEnumerable)
			Fill(filterValues, False)
		End Sub
		Public Sub Fill(ByVal filterValues As IEnumerable, ByVal reset As Boolean)
			' reset table if requested
			If reset Then
				_values.Clear()
				Rows.Clear()
			End If

			' get a list with the new values
			Dim newValues As List(Of Object) = GetNewValues(filterValues)
			If newValues.Count > 0 Then
				' get sql statement and data adapter
				Dim sql = GetSqlStatement(newValues)
#If USE_SQL Then
				Using da = New SqlDataAdapter(sql, ConnectionString)
#Else
				Using da = New OleDbDataAdapter(sql, ConnectionString)
#End If
					' add new values to the table
					Try
						BeginLoadData()
						Dim start = Date.Now
						Dim rows As Integer = da.Fill(Me)
						Console.WriteLine("read {0} rows in {1} ms", rows, Date.Now.Subtract(start).TotalMilliseconds)
					Finally
						EndLoadData()
					End Try
				End Using
			End If
		End Sub

		#End Region

		'----------------------------------------------------------------------------
		#Region "** implementation"

		' gets a list with the filter values that are not already in the
		' current values collection; 
		' and add them all to the current values collection.
		Private Function GetNewValues(ByVal filterValues As IEnumerable) As List(Of Object)
			Dim list_Renamed = New List(Of Object)()
			For Each value As Object In filterValues
				If Not _values.ContainsKey(value) Then
					list_Renamed.Add(value)
					_values(value) = True
				End If
			Next value
			Return list_Renamed
		End Function

		' gets a sql statement to add new values to the table
		Private Function GetSqlStatement(ByVal newValues As List(Of Object)) As String
			Return String.Format(SqlTemplate, GetWhereClause(newValues))
		End Function
		Private Function GetWhereClause(ByVal newValues As List(Of Object)) As String
			If newValues.Count = 0 OrElse String.IsNullOrEmpty(WhereClauseTemplate) Then
				Return String.Empty
			End If

			' build list of values
			Dim sb As New StringBuilder()
			For Each value As Object In newValues
				If sb.Length > 0 Then
					sb.Append(", ")
				End If
				If TypeOf value Is String Then
					sb.AppendFormat("'{0}'", (CStr(value)).Replace("'", "''"))
				Else
					sb.Append(value)
				End If
			Next value

			' build where clause
			Return String.Format(WhereClauseTemplate, sb)
		End Function

		#End Region
	End Class
End Namespace
