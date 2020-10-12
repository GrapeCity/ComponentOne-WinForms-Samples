Imports C1.Win.C1Ribbon
Imports System.Collections.Specialized
Imports C1.Win.C1Themes
Imports System.Linq

Public Class Form1

    Public Sub New()
        InitializeComponent()

        UpdateClipboardGroupBasedOnCurrentTextSelection()
        InitializeFontFaceComboBox()
        UpdateFontGroupBasedOnCurrentTextSelection()
        UpdateParagraphAlignmentButtons()
        InitializeViewZoomGroup()
        InitializeRibbonStyleMenu()
        UpdateUndoRedoButtons()
        UpdateModifiedIcon()
        InitializeQatPosition()

        InitializeRecentDocumentList()

        ' Load a sample text file into the editor.
        LoadDocument("Readme.rtf")

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not PromptToSaveDocument() Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ExitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitButton.Click, RibbonApplicationMenu1.DoubleClick
        Close()
    End Sub

    Private Sub richTextBox1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles richTextBox1.SelectionChanged
        UpdateClipboardGroupBasedOnCurrentTextSelection()
        UpdateFontGroupBasedOnCurrentTextSelection()
        UpdateParagraphAlignmentButtons()
    End Sub

    ' Clipboard Group

    Private Sub PasteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteButton.Click, PasteSplitButton.Click
        richTextBox1.Paste()
    End Sub

    Private Sub PasteAsTextButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteAsTextButton.Click
        richTextBox1.SelectedText = Clipboard.GetText()
    End Sub

    Private Sub CutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutButton.Click
        richTextBox1.Cut()
    End Sub

    Private Sub CopyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyButton.Click
        richTextBox1.Copy()
    End Sub

    Private Sub UpdateClipboardGroupBasedOnCurrentTextSelection()
        Dim isEnabled As Boolean = Not String.IsNullOrEmpty(richTextBox1.SelectedText)
        CutButton.Enabled = isEnabled
        CopyButton.Enabled = isEnabled
    End Sub

    ' Font Group

    Private Sub InitializeFontFaceComboBox()
        ' Populate the Font Face combobox with font names.
        Dim family As FontFamily
        For Each family In FontFamily.Families
            Me.FontFaceComboBox.Items.Add(New RibbonButton(family.Name))
        Next
    End Sub

    Private Sub UpdateFontGroupBasedOnCurrentTextSelection()
        Dim F As Font = richTextBox1.SelectionFont
        If F Is Nothing Then
            FontBoldButton.Pressed = False
            FontItalicButton.Pressed = False
            FontUnderlineButton.Pressed = False
            FontStrikeoutButton.Pressed = False
            FontFaceComboBox.Text = ""
            FontSizeComboBox.Text = ""
        Else
            FontBoldButton.Pressed = F.Bold
            FontItalicButton.Pressed = F.Italic
            FontUnderlineButton.Pressed = F.Underline
            FontStrikeoutButton.Pressed = F.Strikeout
            FontFaceComboBox.Text = F.FontFamily.Name
            FontSizeComboBox.Text = F.Size.ToString()
        End If
    End Sub

    Private Sub FontFaceComboBox_ChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontFaceComboBox.ChangeCommitted
        Dim F As Font = richTextBox1.SelectionFont
        If F Is Nothing Then
            MessageBox.Show("Cannot change font family while selected text has more than one font.")
        Else
            richTextBox1.SelectionFont = New Font(FontFaceComboBox.Text, F.Size, F.Style, F.Unit)
        End If
    End Sub

    Private Sub FontSizeComboBox_ChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontSizeComboBox.ChangeCommitted
        Dim F As Font = richTextBox1.SelectionFont
        If F Is Nothing Then
            MessageBox.Show("Cannot change font size while selected text has more than one font.")
        Else
            richTextBox1.SelectionFont = New Font(F.FontFamily, Single.Parse(FontSizeComboBox.Text), F.Style, F.Unit)
        End If
    End Sub

    ' Bold, Italic, Underline, and Strikeout Buttons

    Private Sub FontBoldButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontBoldButton.Click
        ToggleSelectionFontStyle(FontStyle.Bold)
    End Sub

    Private Sub FontItalicButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontItalicButton.Click
        ToggleSelectionFontStyle(FontStyle.Italic)
    End Sub

    Private Sub FontUnderlineButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontUnderlineButton.Click
        ToggleSelectionFontStyle(FontStyle.Underline)
    End Sub

    Private Sub FontStrikeoutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontStrikeoutButton.Click
        ToggleSelectionFontStyle(FontStyle.Strikeout)
    End Sub

    Private Sub ToggleSelectionFontStyle(ByVal toggledFontStyle As FontStyle)
        Dim F As Font = richTextBox1.SelectionFont
        If F Is Nothing Then
            MessageBox.Show("Cannot change font style while selected text has more than one font.")
        Else
            richTextBox1.SelectionFont = New Font(F, F.Style Xor toggledFontStyle)
        End If
    End Sub

    ' FontColorPicker

    Private Sub FontColorPicker_SelectedColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontColorPicker.SelectedColorChanged, FontColorPicker.Click
        richTextBox1.SelectionColor = FontColorPicker.Color
    End Sub

    Private Sub BackColorPicker_SelectedColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackColorPicker.SelectedColorChanged
        richTextBox1.SelectionBackColor = BackColorPicker.Color
    End Sub

    Private Sub FontGroup_DialogLauncherClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontGroup.DialogLauncherClick
        Dim dlg As New FontDialog()
        Dim F As Font = richTextBox1.SelectionFont
        If Not F Is Nothing Then
            dlg.Font = F
        End If
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            richTextBox1.SelectionFont = dlg.Font
        End If
    End Sub

    ' Indent Buttons

    Private Sub IncreaseIndentButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncreaseIndentButton.Click
        richTextBox1.SelectionIndent += 30
    End Sub

    Private Sub DecreaseIndentButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecreaseIndentButton.Click
        richTextBox1.SelectionIndent -= 30
    End Sub

    ' Alignment Buttons

    Private Sub ParagraphAlignLeftButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParagraphAlignLeftButton.Click
        SetParagraphAlignment(HorizontalAlignment.Left)
    End Sub

    Private Sub ParagraphAlignCenterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParagraphAlignCenterButton.Click
        SetParagraphAlignment(HorizontalAlignment.Center)
    End Sub

    Private Sub ParagraphAlignRightButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParagraphAlignRightButton.Click
        SetParagraphAlignment(HorizontalAlignment.Right)
    End Sub

    Private Sub SetParagraphAlignment(ByVal alignment As HorizontalAlignment)
        richTextBox1.SelectionAlignment = alignment

        ' If the user clicks the same button twice, it will get unpressed.
        ' We want 1 button to be pressed at all times, so we just set 
        ' the buttons' states based on current text alignment.
        UpdateParagraphAlignmentButtons()
    End Sub

    Private Sub UpdateParagraphAlignmentButtons()
        Dim A As HorizontalAlignment = richTextBox1.SelectionAlignment
        ParagraphAlignLeftButton.Pressed = (A = HorizontalAlignment.Left)
        ParagraphAlignCenterButton.Pressed = (A = HorizontalAlignment.Center)
        ParagraphAlignRightButton.Pressed = (A = HorizontalAlignment.Right)
    End Sub

    ' View Zoom Group

    Private Sub InitializeViewZoomGroup()
        Dim Percents() As Integer = {10, 30, 50, 80, 100, 120, 150, 200, 250, 300, 400, 700, 1000}
        Dim P As Integer
        For Each P In Percents
            ViewZoomCombobox.Items.Add(New C1.Win.C1Ribbon.RibbonButton(P.ToString() + "%"))
        Next
        UpdateViewZoomComboBox()
    End Sub

    Private Sub richTextBox1_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles richTextBox1.MouseWheel
        UpdateViewZoomComboBox()
    End Sub

    Private Sub UpdateViewZoomComboBox()
        ViewZoomCombobox.Text = (richTextBox1.ZoomFactor * 100).ToString() + "%"
    End Sub

    Private Sub ViewZoomCombobox_ChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewZoomCombobox.ChangeCommitted
        Dim S As String = ViewZoomCombobox.Text
        If Not String.IsNullOrEmpty(S) Then
            If S.EndsWith("%") Then
                S = S.Substring(0, S.Length - 1)
            End If
            Dim P As Single
            If Single.TryParse(S, P) Then
                SetZoomFactor(P / 100)
            End If
        End If
    End Sub

    Private Sub NormalSizeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NormalSizeButton.Click
        SetZoomFactor(1)
    End Sub

    Private Sub SetZoomFactor(ByVal zoomFactor As Single)
        richTextBox1.ZoomFactor = zoomFactor
        UpdateViewZoomComboBox()
    End Sub

    ' Input Focus Management

    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        richTextBox1.Focus()
    End Sub

    Private Sub c1Ribbon1_RibbonEvent(ByVal sender As System.Object, ByVal e As C1.Win.C1Ribbon.RibbonEventArgs) Handles c1Ribbon1.RibbonEvent
        Select Case e.EventType
            Case C1.Win.C1Ribbon.RibbonEventType.ChangeCanceled,
                C1.Win.C1Ribbon.RibbonEventType.ChangeCommitted,
                C1.Win.C1Ribbon.RibbonEventType.Click,
                C1.Win.C1Ribbon.RibbonEventType.DialogLauncherClick,
                C1.Win.C1Ribbon.RibbonEventType.DropDownClosed
                If c1Ribbon1.Focused Then
                    richTextBox1.Focus()
                End If
        End Select
    End Sub

    ' Undo/Redo

    Private Sub richTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles richTextBox1.TextChanged
        UpdateUndoRedoButtons()
    End Sub

    Private Sub UpdateUndoRedoButtons()
        UndoButton.Enabled = richTextBox1.CanUndo
        RedoButton.Enabled = richTextBox1.CanRedo
    End Sub

    Private Sub UndoButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UndoButton.Click
        richTextBox1.Undo()
        UpdateUndoRedoButtons()
    End Sub

    Private Sub RedoButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RedoButton.Click
        richTextBox1.Redo()
        UpdateUndoRedoButtons()
    End Sub

    Private Sub richTextBox1_ModifiedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles richTextBox1.ModifiedChanged
        UpdateModifiedIcon()
    End Sub

    Private Sub UpdateModifiedIcon()
        If richTextBox1.Modified Then
            DocumentModifiedLabel.Enabled = True
            DocumentModifiedLabel.ToolTip = "Document modified"
        Else
            DocumentModifiedLabel.Enabled = False
            DocumentModifiedLabel.ToolTip = "Document not modified"
        End If
    End Sub

    ' Application Menu, Document-level functions (Open, Save, etc)

    ' Path to the currently open document, no trailing backslash, e.g. "C:\Documents"; 
    ' null if the document has never been saved.
    Private documentPath As String

    ' The file name of the document, such as "Document.rtf"
    Private documentName As String

    Private documentFileType As RichTextBoxStreamType

    ' Replaces the current document with a new empty document.
    Private Sub CreateNewDocument()
        richTextBox1.Clear()
        documentName = "Document"
        documentPath = Nothing
        documentFileType = RichTextBoxStreamType.RichText
        RaiseRichTextBoxSelectionChanged()
    End Sub

    Private Sub LoadDocument(ByVal filePathName As String)
        Dim streamType As RichTextBoxStreamType = RichTextBoxStreamType.PlainText
        If filePathName.EndsWith(".rtf") Then
            streamType = RichTextBoxStreamType.RichText
        End If
        Try
            richTextBox1.LoadFile(filePathName, streamType)
            SetDocumentProperties(filePathName, streamType)
            recentDocuments.Update(filePathName)
            RaiseRichTextBoxSelectionChanged()
        Catch e As IO.IOException
            ' there Is no such file
            MessageBox.Show(e.Message)
        End Try

    End Sub

    Private Sub RaiseRichTextBoxSelectionChanged()
        ' Force a SelectionChanged event to update the state of Ribbon items 
        ' that depend on current text selection.
        richTextBox1.SelectAll()
        richTextBox1.Select(0, 0)

        richTextBox1.Modified = False
    End Sub

    ' If necessary, promts the user if they want to save the current document;
    ' if the user says yes, saves the document.
    ' Returns False if the user cancelled saving either at the promt or the save file dialog.
    Private Function PromptToSaveDocument() As Boolean
        If Not richTextBox1.Modified Then
            Return True
        End If
        Dim dr As System.Windows.Forms.DialogResult
        dr = MessageBox.Show("Do you want to save '" + documentName + "'?",
            "WordPad Sample", MessageBoxButtons.YesNoCancel)
        If dr = Windows.Forms.DialogResult.Yes Then
            Return SaveDocument()
        End If
        Return (dr = Windows.Forms.DialogResult.No)
    End Function

    Private Sub NewDocumentButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewDocumentButton.Click
        If PromptToSaveDocument() Then
            CreateNewDocument()
        End If
    End Sub

    Private Sub OpenDocumentButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OpenDocumentButton.Click
        Dim dlg As New OpenFileDialog()
        dlg.Filter = "Supported files (*.rtf, *.txt)|*.rtf;*.txt|" + "All files (*.*)|*.*"
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If PromptToSaveDocument() Then
                LoadDocument(dlg.FileName)
            End If
        End If
    End Sub

    Private Sub SaveDocumentButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveDocumentButton.Click
        SaveDocument()
    End Sub

    Private Sub SaveDocumentAsButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveDocumentAsButton.Click
        SaveDocument(True)
    End Sub

    Private Sub SaveDocumentAsRtfButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveDocumentAsRtfButton.Click
        Dim s As String = documentName
        If s.EndsWith(".txt") Then
            documentName = s.Substring(0, s.Length - 3) + "rtf"
        End If
        SaveDocumentAs(RichTextBoxStreamType.RichText)
    End Sub

    Private Sub SaveDocumentAsTextButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveDocumentAsTextButton.Click
        Dim s As String = documentName
        If s.EndsWith(".rtf") Then
            documentName = s.Substring(0, s.Length - 3) + "txt"
        End If
        SaveDocumentAs(RichTextBoxStreamType.PlainText)
    End Sub

    Private Sub SaveDocumentAsOtherButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveDocumentAsOtherButton.Click
        SaveDocument(True)
    End Sub

    Private Sub SetDocumentProperties(ByVal filePathName As String, ByVal fileType As RichTextBoxStreamType)
        Dim fi As New System.IO.FileInfo(filePathName)
        documentName = fi.Name
        documentPath = fi.DirectoryName
        documentFileType = fileType
    End Sub

    Private Function SaveDocument() As Boolean
        Return SaveDocument(documentPath Is Nothing)
    End Function

    Private Function SaveDocument(ByVal showDialog As Boolean) As Boolean
        If showDialog Then
            Dim dlg As New SaveFileDialog()
            dlg.FileName = documentName
            If Not documentPath Is Nothing Then
                dlg.InitialDirectory = documentPath
            End If
            dlg.Filter = "Rich text file (*.rtf)|*.rtf|" +
                    "Rich text file, no OLE objects (*.rtf)|*.rtf|" +
                    "Plain text file, no OLE objects (*.txt)|*.txt|" +
                    "Plain text file, OLE objects replaced with text (*.txt)|*.txt|" +
                    "Unicode text file, no OLE objects (*.txt)|*.txt"
            If dlg.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                Return False
            End If
            Dim fileType As RichTextBoxStreamType
            Select Case dlg.FilterIndex
                Case 1
                    fileType = RichTextBoxStreamType.RichText
                Case 2
                    fileType = RichTextBoxStreamType.RichNoOleObjs
                Case 3
                    fileType = RichTextBoxStreamType.PlainText
                Case 4
                    fileType = RichTextBoxStreamType.TextTextOleObjs
                Case Else
                    fileType = RichTextBoxStreamType.UnicodePlainText
            End Select
            SetDocumentProperties(dlg.FileName, fileType)
        End If
        SaveDocumentAs(documentFileType)
        Return True
    End Function

    Private Sub SaveDocumentAs(ByVal fileType As RichTextBoxStreamType)
        Dim filePathName As String = documentPath + "\\" + documentName
        richTextBox1.SaveFile(filePathName, fileType)
        recentDocuments.Update(filePathName)
        richTextBox1.Modified = False
    End Sub

    ' Ribbon Style Menu
    Private Sub InitializeRibbonStyleMenu()
        ribbonStyleCombo.Items.Clear()
        ribbonStyleCombo.Items.Add("(No Theme)")
        Dim themes As String() = C1ThemeController.GetThemes()
        For Each theme As String In themes.Where(Function(w) Not w.ToString.ToLower().Contains("visualstyle"))
            ribbonStyleCombo.Items.Add(theme)
        Next
        ribbonStyleCombo.SelectedIndex = 0
    End Sub

    Private Sub ribbonStyleCombo_ChangeCommitted(sender As Object, e As EventArgs) Handles ribbonStyleCombo.ChangeCommitted
        Dim theme As C1Theme = Nothing
        Try
            theme = C1ThemeController.GetThemeByName(ribbonStyleCombo.Text, False)
        Catch
        End Try

        Me.SuspendPainting()
        If theme IsNot Nothing Then
            C1ThemeController.ApplyThemeToControlTree(Me, theme)
        Else
            Me.ResetVisualStyle()
        End If
        Me.ResumePainting()
        Me.Activate()
    End Sub

    ' InitializeQatPosition

    Private Sub InitializeQatPosition()
        Dim settings As My.MySettings = My.MySettings.Default

        ' Initialize QAT position from application settings.
        RibbonQat1.BelowRibbon = settings.QatBelowRibbon
    End Sub

    Private Sub RibbonQat1_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RibbonQat1.PositionChanged
        Dim settings As My.MySettings = My.MySettings.Default
        settings.QatBelowRibbon = RibbonQat1.BelowRibbon
    End Sub

    ' Recent Document List

    Private recentDocuments As RecentDocumentList

    Private Sub InitializeRecentDocumentList()
        ' Create a new collection if it was not serialized before.
        If My.MySettings.Default.RecentDocuments Is Nothing Then
            My.MySettings.Default.RecentDocuments = New StringCollection()
        End If

        recentDocuments = New RecentDocumentList(c1Ribbon1.ApplicationMenu.RightPaneItems,
            My.MySettings.Default.RecentDocuments, AddressOf LoadRecentDocument)
    End Sub

    Private Sub LoadRecentDocument(ByVal filename As String)
        If Not System.IO.File.Exists(filename) Then
            MessageBox.Show("File does not exist: " + filename)
        ElseIf PromptToSaveDocument() Then
            LoadDocument(filename)
        End If
    End Sub

    Private Class RecentDocumentList

        Public Delegate Sub LoadDocumentDelegate(ByVal filename As String)

        Private ReadOnly rightPaneItems As RibbonItemCollection
        Private ReadOnly files As StringCollection
        Private ReadOnly loadDocument As LoadDocumentDelegate
        Private ReadOnly listTopIndex As Integer

        Public Sub New(ByVal rightPaneItems As RibbonItemCollection, ByVal files As StringCollection, ByVal loadDocument As LoadDocumentDelegate)
            Me.rightPaneItems = rightPaneItems
            Me.files = files
            Me.loadDocument = loadDocument

            ' first create a header and make sure it's not selectable
            Dim listItem As RibbonListItem = New RibbonListItem(New RibbonLabel("Recent Documents"))
            listItem.AllowSelection = False
            rightPaneItems.Add(listItem)
            rightPaneItems.Add(New RibbonListItem(New RibbonSeparator()))

            Me.listTopIndex = rightPaneItems.Count

            ' create the recently used document list
            For Each document As String In Me.files
                Dim item As RecentDocumentItem = New RecentDocumentItem(document, False, loadDocument)
                rightPaneItems.Add(item)
            Next
        End Sub

        Public Class RecentDocumentItem
            Inherits RibbonListItem

            Private ReadOnly label As RibbonLabel
            Private WithEvents pin As RibbonToggleButton
            Private ReadOnly fullFileName_Renamed As String
            Private ReadOnly loadDocument As LoadDocumentDelegate

            Public Sub New(ByVal fullFileName_Renamed As String, ByVal pinned As Boolean, ByVal loadDocument As LoadDocumentDelegate)
                Me.fullFileName_Renamed = fullFileName_Renamed
                Me.loadDocument = loadDocument

                Dim documentName As String = New System.IO.FileInfo(fullFileName_Renamed).Name

                ' each item consists of the name of the document and a push pin
                Me.label = New RibbonLabel(documentName)
                Me.pin = New RibbonToggleButton()

                ' allow the button to be selectable so we can toggle it
                Me.pin.AllowSelection = True

                Me.pin.Pressed = pinned
                Me.SetPinImage()

                Me.Items.Add(Me.label)
                Me.Items.Add(Me.pin)

                Me.ToolTip = fullFileName_Renamed
            End Sub

            Private Sub Pin_PressedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pin.PressedChanged
                Me.SetPinImage()
            End Sub

            Private Sub Me_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Click
                Me.loadDocument(Me.FullFileName)
            End Sub

            Private Sub SetPinImage()
                If Me.pin.Pressed Then
                    Me.pin.SmallImage = My.Resources.Pinned
                Else
                    Me.pin.SmallImage = My.Resources.Unpinned
                End If
            End Sub

            Public ReadOnly Property FullFileName() As String
                Get
                    Return Me.fullFileName_Renamed
                End Get
            End Property

            Public ReadOnly Property Pinned() As Boolean
                Get
                    Return Me.pin.Pressed
                End Get
            End Property
        End Class

        ' Adds or moves the file to the top of the list.
        Public Sub Update(ByVal filename As String)
            Dim fullFileName As String = New System.IO.FileInfo(filename).FullName

            Dim i As Integer = Me.IndexOf(fullFileName)
            If i >= 0 Then
                If Me(i).Pinned Then ' do not move pinned items
                    Return
                End If

                Me.RemoveAt(i)
            End If

            Me.Insert(0, New RecentDocumentItem(fullFileName, False, Me.loadDocument))
        End Sub

        Private ReadOnly Property Count() As Integer
            Get
                Return Me.rightPaneItems.Count - Me.listTopIndex
            End Get
        End Property

        Default Public ReadOnly Property Item(ByVal i As Integer) As RecentDocumentItem
            Get
                Return CType(Me.rightPaneItems(Me.listTopIndex + i), RecentDocumentItem)
            End Get
        End Property

        Private Function IndexOf(ByVal fullFileName As String) As Integer
            For i As Integer = 0 To Me.Count - 1
                If Me(i).FullFileName = fullFileName Then
                    Return i
                End If
            Next
            Return -1
        End Function

        Private Sub RemoveAt(ByVal i As Integer)
            Me.rightPaneItems.RemoveAt(Me.listTopIndex + i)
            Me.files.RemoveAt(i)
        End Sub

        Private Sub Insert(ByVal i As Integer, ByVal item As RecentDocumentItem)
            Me.rightPaneItems.Insert(Me.listTopIndex + i, item)
            Me.files.Insert(i, item.FullFileName)
        End Sub
    End Class

End Class
