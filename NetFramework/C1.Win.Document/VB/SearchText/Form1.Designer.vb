<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pbFind = New System.Windows.Forms.ProgressBar()
        Me.label3 = New System.Windows.Forms.Label()
        Me.lvFoundPositions = New System.Windows.Forms.ListView()
        Me.chNum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPage = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chBounds = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPosInNearText = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chNearText = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.label2 = New System.Windows.Forms.Label()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.cbxWholeWord = New System.Windows.Forms.CheckBox()
        Me.cbxCaseSensitive = New System.Windows.Forms.CheckBox()
        Me.tbFindText = New System.Windows.Forms.TextBox()
        Me.btnFile = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tbFile = New System.Windows.Forms.TextBox()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.c1PdfDocumentSource1 = New C1.Win.C1Document.C1PdfDocumentSource(Me.components)
        Me.nudPageIndex = New System.Windows.Forms.NumericUpDown()
        Me.rbSinglePage = New System.Windows.Forms.RadioButton()
        Me.label4 = New System.Windows.Forms.Label()
        Me.rbWholeDocument = New System.Windows.Forms.RadioButton()
        CType(Me.nudPageIndex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbFind
        '
        Me.pbFind.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbFind.Location = New System.Drawing.Point(12, 434)
        Me.pbFind.Name = "pbFind"
        Me.pbFind.Size = New System.Drawing.Size(661, 5)
        Me.pbFind.TabIndex = 14
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(12, 135)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(68, 13)
        Me.label3.TabIndex = 12
        Me.label3.Text = "Find Results:"
        '
        'lvFoundPositions
        '
        Me.lvFoundPositions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvFoundPositions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chNum, Me.chPage, Me.chBounds, Me.chPosInNearText, Me.chNearText})
        Me.lvFoundPositions.FullRowSelect = True
        Me.lvFoundPositions.Location = New System.Drawing.Point(12, 151)
        Me.lvFoundPositions.Name = "lvFoundPositions"
        Me.lvFoundPositions.Size = New System.Drawing.Size(661, 277)
        Me.lvFoundPositions.TabIndex = 13
        Me.lvFoundPositions.UseCompatibleStateImageBehavior = False
        Me.lvFoundPositions.View = System.Windows.Forms.View.Details
        '
        'chNum
        '
        Me.chNum.Text = "#"
        Me.chNum.Width = 50
        '
        'chPage
        '
        Me.chPage.Text = "Page"
        '
        'chBounds
        '
        Me.chBounds.Text = "Bounds"
        Me.chBounds.Width = 100
        '
        'chPosInNearText
        '
        Me.chPosInNearText.Text = "Pos In Near Text"
        '
        'chNearText
        '
        Me.chNearText.Text = "Near Text"
        Me.chNearText.Width = 350
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(12, 38)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(100, 20)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Search Params:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(118, 90)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 23)
        Me.btnFind.TabIndex = 11
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'cbxWholeWord
        '
        Me.cbxWholeWord.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxWholeWord.AutoSize = True
        Me.cbxWholeWord.Location = New System.Drawing.Point(587, 40)
        Me.cbxWholeWord.Name = "cbxWholeWord"
        Me.cbxWholeWord.Size = New System.Drawing.Size(86, 17)
        Me.cbxWholeWord.TabIndex = 6
        Me.cbxWholeWord.Text = "Whole Word"
        Me.cbxWholeWord.UseVisualStyleBackColor = True
        '
        'cbxCaseSensitive
        '
        Me.cbxCaseSensitive.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxCaseSensitive.AutoSize = True
        Me.cbxCaseSensitive.Location = New System.Drawing.Point(485, 40)
        Me.cbxCaseSensitive.Name = "cbxCaseSensitive"
        Me.cbxCaseSensitive.Size = New System.Drawing.Size(96, 17)
        Me.cbxCaseSensitive.TabIndex = 5
        Me.cbxCaseSensitive.Text = "Case Sensitive"
        Me.cbxCaseSensitive.UseVisualStyleBackColor = True
        '
        'tbFindText
        '
        Me.tbFindText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFindText.Location = New System.Drawing.Point(118, 38)
        Me.tbFindText.Name = "tbFindText"
        Me.tbFindText.Size = New System.Drawing.Size(361, 20)
        Me.tbFindText.TabIndex = 4
        '
        'btnFile
        '
        Me.btnFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFile.Location = New System.Drawing.Point(647, 12)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(26, 20)
        Me.btnFile.TabIndex = 2
        Me.btnFile.Text = "..."
        Me.btnFile.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(12, 12)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(100, 20)
        Me.label1.TabIndex = 0
        Me.label1.Text = "PDF file:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbFile
        '
        Me.tbFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFile.Location = New System.Drawing.Point(118, 12)
        Me.tbFile.Name = "tbFile"
        Me.tbFile.Size = New System.Drawing.Size(523, 20)
        Me.tbFile.TabIndex = 1
        '
        'openFileDialog1
        '
        Me.openFileDialog1.DefaultExt = "pdf"
        Me.openFileDialog1.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
        '
        'nudPageIndex
        '
        Me.nudPageIndex.Location = New System.Drawing.Point(323, 65)
        Me.nudPageIndex.Maximum = New Decimal(New Integer() {32767, 0, 0, 0})
        Me.nudPageIndex.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPageIndex.Name = "nudPageIndex"
        Me.nudPageIndex.Size = New System.Drawing.Size(75, 20)
        Me.nudPageIndex.TabIndex = 10
        Me.nudPageIndex.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'rbSinglePage
        '
        Me.rbSinglePage.AutoSize = True
        Me.rbSinglePage.Location = New System.Drawing.Point(232, 67)
        Me.rbSinglePage.Name = "rbSinglePage"
        Me.rbSinglePage.Size = New System.Drawing.Size(85, 17)
        Me.rbSinglePage.TabIndex = 9
        Me.rbSinglePage.Text = "Single Page:"
        Me.rbSinglePage.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(12, 65)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(100, 20)
        Me.label4.TabIndex = 7
        Me.label4.Text = "Search Scope:"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rbWholeDocument
        '
        Me.rbWholeDocument.AutoSize = True
        Me.rbWholeDocument.Checked = True
        Me.rbWholeDocument.Location = New System.Drawing.Point(118, 67)
        Me.rbWholeDocument.Name = "rbWholeDocument"
        Me.rbWholeDocument.Size = New System.Drawing.Size(108, 17)
        Me.rbWholeDocument.TabIndex = 8
        Me.rbWholeDocument.TabStop = True
        Me.rbWholeDocument.Text = "Whole Document"
        Me.rbWholeDocument.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 451)
        Me.Controls.Add(Me.nudPageIndex)
        Me.Controls.Add(Me.rbSinglePage)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.rbWholeDocument)
        Me.Controls.Add(Me.pbFind)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.lvFoundPositions)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.cbxWholeWord)
        Me.Controls.Add(Me.cbxCaseSensitive)
        Me.Controls.Add(Me.tbFindText)
        Me.Controls.Add(Me.btnFile)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.tbFile)
        Me.Name = "Form1"
        Me.Text = "Search text in PDF file"
        CType(Me.nudPageIndex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pbFind As ProgressBar
    Private WithEvents label3 As Label
    Private WithEvents lvFoundPositions As ListView
    Private WithEvents chNum As ColumnHeader
    Private WithEvents chPage As ColumnHeader
    Private WithEvents chBounds As ColumnHeader
    Private WithEvents chPosInNearText As ColumnHeader
    Private WithEvents chNearText As ColumnHeader
    Private WithEvents label2 As Label
    Private WithEvents btnFind As Button
    Private WithEvents cbxWholeWord As CheckBox
    Private WithEvents cbxCaseSensitive As CheckBox
    Private WithEvents tbFindText As TextBox
    Private WithEvents btnFile As Button
    Private WithEvents label1 As Label
    Private WithEvents tbFile As TextBox
    Private WithEvents openFileDialog1 As OpenFileDialog
    Private WithEvents c1PdfDocumentSource1 As C1.Win.C1Document.C1PdfDocumentSource
    Private WithEvents nudPageIndex As NumericUpDown
    Private WithEvents rbSinglePage As RadioButton
    Private WithEvents label4 As Label
    Private WithEvents rbWholeDocument As RadioButton
End Class
