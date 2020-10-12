Imports System.IO
Imports C1.C1Zip

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents btnExtract As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnNew As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.btnExtract = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(8, 32)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(128, 24)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "Open Zip File..."
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(8, 96)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(128, 24)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add Files..."
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(8, 144)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(128, 24)
        Me.btnRemove.TabIndex = 0
        Me.btnRemove.Text = "Remove Files"
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(8, 208)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(128, 24)
        Me.btnView.TabIndex = 0
        Me.btnView.Text = "View File"
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(8, 232)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(128, 24)
        Me.btnTest.TabIndex = 0
        Me.btnTest.Text = "Test Zip File"
        '
        'btnExtract
        '
        Me.btnExtract.Location = New System.Drawing.Point(8, 120)
        Me.btnExtract.Name = "btnExtract"
        Me.btnExtract.Size = New System.Drawing.Size(128, 24)
        Me.btnExtract.TabIndex = 0
        Me.btnExtract.Text = "Extract Files"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(144, 8)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(384, 288)
        Me.ListView1.TabIndex = 1
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "File"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Date"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Size"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Compr"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 80
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Amount"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(8, 8)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(128, 24)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "Create Zip File..."
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(538, 303)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.ListView1, Me.btnOpen, Me.btnAdd, Me.btnRemove, Me.btnView, Me.btnTest, Me.btnExtract, Me.btnNew})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1Zip: Quick Zip"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private m_Zip As C1ZipFile

    Private Sub UpdateDisplay()

        ' update ListView control to show Zip file contents
        With ListView1

            ' remove eny existing items
            .Items.Clear()

            ' add each entry
            Dim ze As C1ZipEntry
            For Each ze In m_Zip.Entries

                ' calculate compression amount
                Dim pct As Double = 0
                If ze.SizeUncompressed > 0 Then
                    pct = 1 - ze.SizeCompressed / ze.SizeUncompressed
                End If

                ' build listview item
                Dim items(4) As String
                items(0) = ze.FileName
                items(1) = Format(ze.Date, "MM/dd/yy")
                items(2) = Format(ze.SizeUncompressed, "#,##0")
                items(3) = Format(ze.SizeCompressed, "#,##0")
                items(4) = Format(pct, "00 %")
                Dim lvi As ListViewItem = New ListViewItem(items)

                ' save ZipEntry into item tag
                lvi.Tag = ze

                ' add item to listview
                .Items.Add(lvi)
            Next

            ' update UI
            Dim hasEntries As Boolean = (.Items.Count > 0)
            btnExtract.Enabled = hasEntries
            btnRemove.Enabled = hasEntries
            btnTest.Enabled = hasEntries
            btnView.Enabled = hasEntries
            btnAdd.Enabled = m_Zip.FileName.Length > 0

        End With
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' create C1ZipFile member
        m_Zip = New C1ZipFile()

        ' update UI
        UpdateDisplay()

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click

        ' show open file dialog
        Dim fo As SaveFileDialog = New SaveFileDialog()
        fo.FileName = "*.zip"
        If fo.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        ' open zip file
        Try
            m_Zip.Create(fo.FileName)
        Catch
            MessageBox.Show("Can't create ZIP file, please try again.", "C1Zip")
        End Try

        ' update display
        UpdateDisplay()

    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click

        ' show open file dialog
        Dim fo As OpenFileDialog = New OpenFileDialog()
        fo.FileName = "*.zip"
        If fo.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        ' open zip file
        Try
            m_Zip.Open(fo.FileName)
        Catch
            MessageBox.Show("Invalid ZIP file, please try again.", "C1Zip")
        End Try

        ' update display
        UpdateDisplay()
    End Sub

    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click

        ' test each entry
        Dim ze As C1ZipEntry
        For Each ze In m_Zip.Entries
            If Not ze.CheckCRC32() Then
                MessageBox.Show("** Entry " + ze.FileName + " has errors.", "C1Zip", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Next

        ' if we got here, everything is OK
        MessageBox.Show("All entries passed CRC check", "C1Zip")
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click

        ' get first selected item that is not a directory
        Dim ze As C1ZipEntry = Nothing
        Dim lvi As ListViewItem
        For Each lvi In ListView1.SelectedItems
            Dim zeItem As C1ZipEntry = lvi.Tag
            If (zeItem.Attributes And FileAttributes.Directory) = 0 Then
                ze = zeItem
                Exit For
            End If
        Next

        ' make sure we got something
        If ze Is Nothing Then
            MessageBox.Show("Please select a file from the list first.", "C1Zip")
            Exit Sub
        End If

        ' read entry content
        Dim entry As Stream = ze.OpenReader()
        Dim sr As StreamReader = New StreamReader(entry)
        Dim entryText As String = sr.ReadToEnd()
        entry.Close()

        ' make sure entry is not too big for MessageBox
        If entryText.Length > 16000 Then
            entryText = entryText.Substring(0, 16000)
        End If

        ' show entry in message box 
        MessageBox.Show(entryText, ze.FileName)

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        ' get list of files to add
        Dim fo As OpenFileDialog = New OpenFileDialog()
        fo.Multiselect = True
        fo.FileName = "*.*"
        If fo.ShowDialog <> System.Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        ' add files in the list
        Dim file As String
        For Each file In fo.FileNames()
            m_Zip.Entries.Add(file)
        Next

        ' done
        UpdateDisplay()
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click

        ' confirm with user
        Dim cnt As Integer = ListView1.SelectedIndices.Count
        If cnt = 0 Then
            MessageBox.Show("Sorry, no files to remove...", "C1Zip")
            Exit Sub
        End If
        Dim dr As DialogResult
        Dim msg As String = "Please confirm that you want to delete " + cnt.ToString() + " entries."
        dr = MessageBox.Show(msg, "C1Zip", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If dr <> System.Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        ' delete all selected entries
        Dim lvi As ListViewItem
        Dim ze As C1ZipEntry
        For Each lvi In ListView1.SelectedItems
            ze = lvi.Tag
            m_Zip.Entries.Remove(ze.FileName)
        Next

        ' done
        UpdateDisplay()
    End Sub

    Private Sub btnExtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtract.Click

        ' confirm with user
        Dim cnt As Integer = ListView1.SelectedIndices.Count
        If cnt = 0 Then
            MessageBox.Show("Sorry, no files to extract...", "C1Zip")
            Exit Sub
        End If
        Dim dr As DialogResult
        Dim msg As String = "Please confirm that you want to extract " + cnt.ToString() + " entries."
        dr = MessageBox.Show(msg, "C1Zip", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If dr <> System.Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        ' extract all selected entries
        Dim lvi As ListViewItem
        Dim ze As C1ZipEntry
        For Each lvi In ListView1.SelectedItems
            ze = lvi.Tag
            If ze.SizeCompressed > 0 Then
                m_Zip.Entries.Extract(ze.FileName)
            End If
        Next

        ' done
        UpdateDisplay()
    End Sub
End Class
