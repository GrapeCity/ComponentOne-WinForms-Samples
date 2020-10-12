Imports System
Imports System.Linq
Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports C1.Win.C1Themes
Imports System.Runtime.InteropServices

Namespace DashboardDemo
    Public Class SampleHelper
        Implements IDisposable

        Private _data As DataSet = New DataSet()
        Private _layoutsDir As String = Directory.GetCurrentDirectory() & "\Layouts"
        Public Property Theme As String

        Public ReadOnly Property DefaultLayoutPath As String
            Get
                Dim di = New DirectoryInfo(Directory.GetCurrentDirectory() & "\Resources")
                If Not di.Exists Then di.Create()
                Return Directory.GetCurrentDirectory() & "\Resources\DefaultLayout.xml"
            End Get
        End Property

        Public Function GetSourceTable(ByVal tableName As String, ByVal selectCommandText As String) As DataTable
            Dim dt As DataTable = New DataTable(tableName)

            Using da = New OleDbDataAdapter(selectCommandText, GetConnectionString())
                da.Fill(dt)
                _data.Tables.Add(dt)
            End Using

            Return dt
        End Function

        Public Sub CenterPosition(ByVal owner As Control, ByVal child As Control)
            If owner IsNot Nothing AndAlso child IsNot Nothing Then
                Dim x As Integer = (owner.Width - child.Width) / 2
                Dim y As Integer = (owner.Height - child.Height) / 2
                child.Location = New System.Drawing.Point(If(x > 0, x, 0), If(y > 0, y, 0))
            End If
        End Sub

        Public Function SaveLayoutDialog(<Out> ByRef filePath As String) As Boolean
            filePath = Nothing

            Using dialog = New SaveLayoutForm()
                If Theme IsNot Nothing Then C1ThemeController.ApplyThemeToControlTree(dialog, C1ThemeController.GetThemeByName(Theme, False))

                If dialog.ShowDialog() = DialogResult.OK Then
                    If Not Directory.Exists(_layoutsDir) Then Directory.CreateDirectory(_layoutsDir)
                    filePath = _layoutsDir & "\" & dialog.FileName & ".xml"
                    Return True
                End If
            End Using

            Return False
        End Function

        Public Sub ManageLayoutDialog()
            Using dialog = New ManageLayoutForm(Me)
                If Theme IsNot Nothing Then C1ThemeController.ApplyThemeToControlTree(dialog, C1ThemeController.GetThemeByName(Theme, False))
                dialog.ShowDialog()
            End Using
        End Sub

        Public Function GetLayouts() As String()
            Dim di = New DirectoryInfo(_layoutsDir)

            If di.Exists Then
                Dim files = di.GetFiles("*.xml")
                Dim names = files.[Select](Function(x) x.Name)
                Dim array = names.ToArray()
                Return di.GetFiles("*.xml").[Select](Function(x) x.Name).ToArray()
            End If

            Return Nothing
        End Function

        Public Sub DeleteLayout(ByVal name As String)
            If Directory.Exists(_layoutsDir) Then File.Delete(GetLayoutPath(name))
        End Sub

        Public Sub RenameLayout(ByVal name As String)
            Using dialog = New SaveLayoutForm(name)
                dialog.Text = "Rename Layout"
                If Theme IsNot Nothing Then C1ThemeController.ApplyThemeToControlTree(dialog, C1ThemeController.GetThemeByName(Theme, False))
                If dialog.ShowDialog() = DialogResult.OK AndAlso Directory.Exists(_layoutsDir) Then File.Move(GetLayoutPath(name), GetLayoutPath(dialog.FileName))
            End Using
        End Sub

        Public Function GetLayoutPath(ByVal name As String) As String
            Return _layoutsDir & "\" & name
        End Function

        Private Function GetConnectionString() As String
            Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common"
            Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
            Return String.Format(conn, path)
        End Function

        Public Shared _instance As SampleHelper

        Public Shared ReadOnly Property Instance As SampleHelper
            Get
                Return If(_instance, (CSharpImpl.__Assign(_instance, New SampleHelper())))
            End Get
        End Property

        Public Shared Sub DisposeInstance()
            _instance.Dispose()
            _instance = Nothing
        End Sub

        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If disposing Then

                If _data IsNot Nothing Then

                    For Each table As System.IDisposable In _data.Tables
                        table.Dispose()
                    Next

                    _data.Dispose()
                End If
            End If
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub

        Private Class CSharpImpl
            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
End Namespace
