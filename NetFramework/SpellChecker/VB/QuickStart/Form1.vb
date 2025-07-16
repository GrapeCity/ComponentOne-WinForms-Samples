Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.FlexGrid
Imports C1.Win.SpellChecker

    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        '------------------------------------------------------------------------------------------------ 
#Region "** Initalize form"

    ' load some text into controls, check that the spell dictionary is loaded 
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Font = SystemInformation.MenuFont

        ' load some text into the text boxes (rich and regular) 
        Me.richTextBox1.Rtf = My.Resources.Mark_Twain


        Me.textBox1.Text = Me.richTextBox1.Text.Replace("" & Chr(10) & "", "" & Chr(13) & "" & Chr(10) & "")

        ' initialize richtextbox zoom 
        cmbZoom.Text = "100%"

        ' initialize FlexGrid 
        Dim sql As String = "select * from employees"
        Dim conn As String = GetConnectionString()

        Dim da As New OleDbDataAdapter(sql, conn)
        Dim dt As New DataTable()
        da.Fill(dt)

        ' initialize grid 
        _flex.Styles.Normal.WordWrap = True
        _flex.DataSource = dt
        Dim c As Column = _flex.Cols("Notes")
        c.Width = 350
        _flex.AutoSizeRows()
        AddHandler _flex.StartEdit, AddressOf _flex_StartEdit

        ' hook up spell-checker when editing starts 

        ' check that the spell-checker is active 
        ' NOTE: the easiest way to ensure the dictionary is deployed properly is to add the dct 
        ' file to the project, and set the following properties: 
        ' BuildAction = None 
        ' CopyToOutputDirectory = CopyIfNewer 
        ' 
        If Not Me._spell.Enabled Then
            ' not enabled, check why 
            Select Case Me._spell.MainDictionary.State
                Case DictionaryState.Empty
                    MessageBox.Show("Dictionary file name not set.")
                    Exit Select
                Case DictionaryState.FileNotFound
                    MessageBox.Show(String.Format("Dictionary file '{0}' not found.", Me._spell.MainDictionary.FileName))
                    Exit Select
                Case DictionaryState.InvalidFileFormat
                    MessageBox.Show(String.Format("Dictionary file '{0}' is invalid.", Me._spell.MainDictionary.FileName))
                    Exit Select
                Case DictionaryState.InvalidPassword
                    MessageBox.Show(String.Format("Wrong password for dictionary file '{0}'.", Me._spell.MainDictionary.FileName))
                    Exit Select
                Case DictionaryState.Loaded
                    MessageBox.Show("Dictionary loaded OK.")
                    Exit Select
            End Select
        End If
    End Sub

    Private Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function


#End Region

        '------------------------------------------------------------------------------------------------ 
#Region "** Apply all spelling modes to a RichTextBox"

        ' mode 1: batch 
        ' check a string and get a list of all spelling mistakes 
    Private Sub btnShowErrorsRich_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShowErrorsRich.Click
        ' get a list with all spelling mistakes 
        Dim errors As CharRangeList = Me._spell.CheckText(Me.richTextBox1.Text)

        ' show the list 
        ShowErrors(errors)
    End Sub

        ' mode 2: modal dialog 
        ' spell-check a text editor showing a dialog 
    Private Sub btnSpellDialogRich_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSpellDialogRich.Click
        ' show dialog 
        Dim errorCount As Integer = Me._spell.CheckControl(Me.richTextBox1)

        ' dialog was canceled by user 
        If errorCount < 0 Then
        Else
            Dim msg As String = String.Format("Spell-checking complete." & Chr(13) & "" & Chr(10) & "{0} error(s) found.", errorCount)
            MessageBox.Show(msg)
        End If
    End Sub

        ' mode 3: active (as-you-type) spell checking 
        ' draws a red wiggly underline under typos, provides a context-sensitive menu 
    Private Sub btnAsYouTypeRich_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnAsYouTypeRich.CheckedChanged
        ' toggle active spelling 
        Me._spell.SetActiveSpellChecking(Me.richTextBox1, Me.btnAsYouTypeRich.Checked)
    End Sub

#End Region

        '------------------------------------------------------------------------------------------------ 
#Region "** Apply all spelling modes to a regular TextBox (exactly the same code as before)"

    Private Sub btnShowErrors_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShowErrors.Click
        Dim errors As CharRangeList = Me._spell.CheckText(Me.textBox1.Text)
        ShowErrors(errors)
    End Sub
    Private Sub btnSpellDialog_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSpellDialog.Click
        Dim errorCount As Integer = Me._spell.CheckControl(Me.textBox1)
        If errorCount > -1 Then
            Dim msg As String = String.Format("Spell-checking complete." & Chr(13) & "" & Chr(10) & "{0} error(s) found.", errorCount)
            MessageBox.Show(msg)
        End If
    End Sub
    Private Sub btnAsYouType_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnAsYouType.CheckedChanged
        Me._spell.SetActiveSpellChecking(Me.textBox1, Me.btnAsYouType.Checked)
    End Sub

#End Region

        '------------------------------------------------------------------------------------------------ 
#Region "** Spell-check a C1FlexGrid"

        ' provide as-you-type spelling in the grid editor 
        Private Sub _flex_StartEdit(ByVal sender As Object, ByVal e As RowColEventArgs)
            Dim tb As TextBoxBase = TryCast(_flex.Editor, TextBoxBase)
            If tb IsNot Nothing Then
                _spell.SetSpellChecking(tb, True)
            End If
        End Sub

        ' spell-check selected columns 
    Private Sub btnSpellDialogGrid_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSpellDialogGrid.Click
        ' create spell-checkable wrapper for C1FlexGrid 
        Dim editor As New FlexGridSpeller(_flex, "Title", "Notes")

        ' spell-check 
        Dim errorCount As Integer = _spell.CheckControl(editor)
        If errorCount > -1 Then
            Dim msg As String = String.Format("Spell-checking complete. {0} error(s) found.", errorCount)
            MessageBox.Show(msg)
        Else
            MessageBox.Show("Spell-checking cancelled.")
        End If
    End Sub

#End Region

        '------------------------------------------------------------------------------------------------ 
#Region "** utility / event handlers"

        Private Sub ShowErrors(ByVal errors As CharRangeList)
            Dim grid As New DataGridView()
            grid.DataSource = errors
            grid.Dock = DockStyle.Fill
            Dim f As New Form()
            f.StartPosition = FormStartPosition.CenterParent
            f.Text = String.Format("{0} Spelling errors detected", errors.Count)
            f.Controls.Add(grid)
            f.ShowDialog()
        End Sub
    Private Sub cmbZoom_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbZoom.SelectedIndexChanged
        Dim zoom As Single = 1.0F
        If Single.TryParse(cmbZoom.Text.Replace("%", ""), zoom) Then
            zoom = zoom / 100.0F
        End If
        Me.richTextBox1.ZoomFactor = zoom
        Me.richTextBox1.Focus()
    End Sub
    Private Sub btnFont_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFont.Click
        Using dlg As New FontDialog()
            dlg.Font = textBox1.Font
            If dlg.ShowDialog() = DialogResult.OK Then
                textBox1.Font = dlg.Font
            End If
        End Using
    End Sub

#End Region


End Class

