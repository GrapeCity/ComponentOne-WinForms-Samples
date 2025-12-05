Imports C1.Win.Ribbon
Imports System.Collections.Specialized
Imports C1.Win.Themes
Imports System.Linq
Imports System.Windows.Forms

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

        _rdlOpened = New RecentDocumentList(My.MySettings.Default.OpenedFiles)
        _rdlSaved = New RecentDocumentList(My.MySettings.Default.SavedFiles)

        ' Load a sample text file into the editor.
        LoadDocument("Readme.rtf")

        Dim openTab = New OpenTab With {
            .Owner = Me,
            .View = C1BackstageView1
        }
        OpenDocumentTab.Control = openTab

        Dim saveAsTab = New SaveAsTab With {
            .Owner = Me,
            .View = C1BackstageView1
        }
        SaveDocumentAsTab.Control = saveAsTab

    End Sub

#Region "Clipboard Group"

    Private Sub richTextBox1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles richTextBox1.SelectionChanged
        UpdateClipboardGroupBasedOnCurrentTextSelection()
        UpdateFontGroupBasedOnCurrentTextSelection()
    End Sub

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

#End Region

#Region "Font Group"

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

#End Region

#Region "Bold, Italic, Underline, and Strikeout Buttons"

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

#End Region

#Region "FontColorPicker"

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
        If dlg.ShowDialog() = DialogResult.OK Then
            richTextBox1.SelectionFont = dlg.Font
        End If
    End Sub

#End Region

#Region "Indent Buttons"

    Private Sub IncreaseIndentButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncreaseIndentButton.Click
        richTextBox1.SelectionIndent += 30
    End Sub

    Private Sub DecreaseIndentButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecreaseIndentButton.Click
        richTextBox1.SelectionIndent -= 30
    End Sub

#End Region

#Region "Alignment Buttons"

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

#End Region

#Region "View Zoom Group"

    Private Sub InitializeViewZoomGroup()
        Dim Percents() As Integer = {10, 30, 50, 80, 100, 120, 150, 200, 250, 300, 400, 700, 1000}
        Dim P As Integer
        For Each P In Percents
            ViewZoomCombobox.Items.Add(New C1.Win.Ribbon.RibbonButton(P.ToString() + "%"))
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

#End Region

#Region "Input Focus Management"

    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        richTextBox1.Focus()
    End Sub

    Private Sub c1Ribbon1_RibbonEvent(ByVal sender As System.Object, ByVal e As C1.Win.Ribbon.RibbonEventArgs) Handles c1Ribbon1.RibbonEvent
        Select Case e.EventType
            Case RibbonEventType.ChangeCanceled,
                 RibbonEventType.ChangeCommitted,
                RibbonEventType.Click,
                RibbonEventType.DialogLauncherClick,
                RibbonEventType.DropDownClosed
                If c1Ribbon1.Focused Then
                    richTextBox1.Focus()
                End If
        End Select
    End Sub

#End Region

#Region "Undo/Redo"

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

#End Region

#Region "Application Menu, Document-level functions (Open, Save, etc)"

    ' Path to the currently open document, no trailing backslash, e.g. "C:\Documents"; 
    ' null if the document has never been saved.

    Private documentPath As String

    ' The file name of the document, such as "Document.rtf"
    Private documentName As String

    Private documentFileType As RichTextBoxStreamType

    Private Sub OpenDocumentButton_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim dlg As New OpenFileDialog()
        dlg.Filter = "Supported files (*.rtf, *.txt)|*.rtf;*.txt|" + "All files (*.*)|*.*"
        If dlg.ShowDialog() = DialogResult.OK Then
            If PromptToSaveDocument() Then
                LoadDocument(dlg.FileName)
            End If
        End If
    End Sub

    Private Sub SaveDocumentAsButton_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        SaveDocument(True)
    End Sub

    Private Sub SaveDocumentAsRtfButton_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim s As String = documentName
        If s.EndsWith(".txt") Then
            documentName = s.Substring(0, s.Length - 3) + "rtf"
        End If
        SaveDocumentAs(RichTextBoxStreamType.RichText)
    End Sub

    Private Sub SaveDocumentAsTextButton_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim s As String = documentName
        If s.EndsWith(".rtf") Then
            documentName = s.Substring(0, s.Length - 3) + "txt"
        End If
        SaveDocumentAs(RichTextBoxStreamType.PlainText)
    End Sub

    Private Sub SaveDocumentAsOtherButton_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        SaveDocument(True)
    End Sub

    Private Sub SetDocumentProperties(ByVal filePathName As String, ByVal fileType As RichTextBoxStreamType)
        Dim fi As New System.IO.FileInfo(filePathName)
        documentName = fi.Name
        documentPath = fi.DirectoryName
        documentFileType = fileType
    End Sub

    Private Sub SaveDocumentAs(ByVal fileType As RichTextBoxStreamType)
        Dim filePathName As String = documentPath + "\\" + documentName
        richTextBox1.SaveFile(filePathName, fileType)
        'recentDocuments.Update(filePathName)
        richTextBox1.Modified = False
    End Sub

#End Region

#Region "Ribbon Style Menu"

    Private Sub InitializeRibbonStyleMenu()
        ribbonStyleCombo.Items.Clear()
        ribbonStyleCombo.Items.Add("(No Theme)")
        Dim themes As String() = C1ThemeController.GetThemes()
        For Each theme As String In themes
            ribbonStyleCombo.Items.Add(theme)
        Next
        ribbonStyleCombo.SelectedIndex = ribbonStyleCombo.Items.IndexOf("Office365White")
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
        End If
        Me.ResumePainting()
        Me.Activate()
    End Sub

#End Region

#Region "InitializeQatPosition"

    Private Sub InitializeQatPosition()
        Dim settings As My.MySettings = My.MySettings.Default

        ' Initialize QAT position from application settings.
        RibbonQat1.BelowRibbon = settings.QatBelowRibbon
    End Sub

    Private Sub RibbonQat1_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RibbonQat1.PositionChanged
        Dim settings As My.MySettings = My.MySettings.Default
        settings.QatBelowRibbon = RibbonQat1.BelowRibbon
    End Sub

#End Region

#Region "Backstage Menu, Document-level functions (Open, Save, etc)"

    Private _rdlOpened As RecentDocumentList
    Private _rdlSaved As RecentDocumentList

    Private _documentName As String = "Readme.rtf"

    Private Sub NewDocumentButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewDocumentButton.Click
        If PromptToSaveDocument() Then
            CreateNewDocument()
        End If
    End Sub

    Private Sub SaveDocumentButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveDocumentButton.Click
        SaveDocument()
    End Sub

    Private Sub ExitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Close()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not PromptToSaveDocument() Then
            e.Cancel = True
        End If
    End Sub

    ' If necessary, promts the user if they want to save the current document;
    ' if the user says yes, saves the document.
    ' Returns False if the user cancelled saving either at the promt or the save file dialog.
    Private Function PromptToSaveDocument() As Boolean
        If Not richTextBox1.Modified Then
            Return True
        End If
        Dim dr As DialogResult
        dr = MessageBox.Show("Do you want to save '" + documentName + "'?",
            "WordPad Sample", MessageBoxButtons.YesNoCancel)
        If dr = DialogResult.Yes Then
            Return SaveDocument()
        End If
        Return (dr = DialogResult.No)
    End Function

    Private Sub CreateNewDocument()
        richTextBox1.Clear()
        documentName = "Document"

        RaiseRichTextBoxSelectionChanged()
    End Sub

    Private Sub LoadDocument(ByVal filePathName As String)
        Dim streamType As RichTextBoxStreamType = RichTextBoxStreamType.PlainText
        If filePathName.EndsWith(".rtf") Then
            streamType = RichTextBoxStreamType.RichText
        End If
        Try
            richTextBox1.LoadFile(filePathName, streamType)
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

    Private Function SaveDocument() As Boolean
        Return SaveDocument(_documentName)
    End Function

    Public Function SaveDocument(ByVal fileName As String) As Boolean
        If String.IsNullOrEmpty(fileName) Then
            Return SaveDocumentAs()
        End If

        richTextBox1.SaveFile(fileName)
        richTextBox1.Modified = False
        Return True
    End Function

    Public Function SaveDocumentAs() As Boolean
        Using dlg As SaveFileDialog = New SaveFileDialog()
            dlg.FileName = _documentName
            dlg.Filter = "Rich text file (*.rtf)|*.rtf|" & "Rich text file, no OLE objects (*.rtf)|*.rtf|" & "Plain text file, no OLE objects (*.txt)|*.txt|" & "Plain text file, OLE objects replaced with text (*.txt)|*.txt|" & "Unicode text file, no OLE objects (*.txt)|*.txt"

            If dlg.ShowDialog() = DialogResult.OK Then
                _documentName = dlg.FileName
                _rdlSaved.AddDocument(_documentName)
                Return SaveDocument()
            End If
        End Using

        Return False
    End Function

    Public Sub OpenDocument()
        If Not PromptToSaveDocument() Then Return

        Using dlg = New OpenFileDialog()
            dlg.Filter = "Supported files (*.rtf, *.txt)|*.rtf;*.txt|" & "All files (*.*)|*.*"

            If dlg.ShowDialog() = DialogResult.OK Then
                OpenDocument(dlg.FileName)
            End If
        End Using
    End Sub

    Public Sub OpenDocument(ByVal fileName As String)
        If Not PromptToSaveDocument() Then Return
        richTextBox1.LoadFile(fileName)
        _documentName = fileName
        _rdlOpened.AddDocument(fileName)
    End Sub

    Private Sub C1BackstageView1_DropDown(sender As Object, e As EventArgs) Handles C1BackstageView1.DropDown
        CType(OpenDocumentTab.Control, BackstageTab).LoadItems(_rdlOpened.RecentDocuments)
        CType(SaveDocumentAsTab.Control, BackstageTab).LoadItems(_rdlSaved.RecentDocuments)
    End Sub

#End Region

#Region "'#####"

    Private Sub styleGallery_HighlightedItemChanged(sender As Object, e As GalleryEventArgs) Handles styleGallery.HighlightedItemChanged
        If e.GalleryItem Is Nothing Then

            If Not styleGallery.DroppedDown Then
                UpdateStyle(styleGallery.SelectedIndex)
            End If
        Else
            UpdateStyle(styleGallery.Items.IndexOf(e.GalleryItem))
        End If
    End Sub

    Private Sub StyleGallery_SelectedIndexChanged(sender As Object, e As EventArgs) Handles styleGallery.SelectedIndexChanged
        UpdateStyle(styleGallery.SelectedIndex)
    End Sub

    Private Sub UpdateStyle(ByVal index As Integer)
        ClearFormatting()
        Me.richTextBox1.SelectionBackColor = SystemColors.Window
        Dim c As Integer = richTextBox1.SelectionStart
        Dim parStart As Integer = richTextBox1.Text.LastIndexOf(vbLf, c)
        parStart = If(parStart < 0, 0, parStart + 1)
        Dim parEnd As Integer = If(richTextBox1.SelectedText.EndsWith(vbLf), c + richTextBox1.SelectionLength, richTextBox1.Text.IndexOf(vbLf, c + richTextBox1.SelectionLength))
        parEnd = If(parEnd < 0, richTextBox1.Text.Length - 1, parEnd)
        richTextBox1.[Select](parStart, parEnd - parStart)

        Select Case index
            Case 0
                Me.richTextBox1.SelectionFont = New Font("Calibri", 11, FontStyle.Regular)
                Me.richTextBox1.SelectionColor = SystemColors.WindowText
            Case 1
                Me.richTextBox1.SelectionFont = New Font("Calibri Light", 16, FontStyle.Bold)
                Me.richTextBox1.SelectionColor = Color.FromArgb(0, 68, 114, 196)
            Case 2
                Me.richTextBox1.SelectionFont = New Font("Calibri Light", 14, FontStyle.Bold)
                Me.richTextBox1.SelectionColor = Color.FromArgb(0, 68, 114, 196)
            Case 3
                Me.richTextBox1.SelectionFont = New Font("Calibri Light", 16, FontStyle.Bold)
                Me.richTextBox1.SelectionColor = SystemColors.WindowText
                Me.richTextBox1.SelectionAlignment = HorizontalAlignment.Center
            Case 4
                Me.richTextBox1.SelectionFont = New Font("Calibri Light", 12, FontStyle.Regular)
                Me.richTextBox1.SelectionColor = Color.FromArgb(0, 90, 90, 90)
                Me.richTextBox1.SelectionAlignment = HorizontalAlignment.Center
            Case 5
                Me.richTextBox1.SelectionFont = New Font("Calibri", 11, FontStyle.Italic)
                Me.richTextBox1.SelectionColor = Color.FromArgb(0, 90, 90, 90)
            Case 6
                Me.richTextBox1.SelectionFont = New Font("Calibri", 11, FontStyle.Italic)
                Me.richTextBox1.SelectionColor = Color.FromArgb(0, 68, 114, 196)
            Case 7
                Me.richTextBox1.SelectionFont = New Font("Calibri", 11, FontStyle.Bold)
                Me.richTextBox1.SelectionColor = SystemColors.WindowText
            Case 8
                Me.richTextBox1.SelectionFont = New Font("Calibri", 11, FontStyle.Italic)
                Me.richTextBox1.SelectionColor = SystemColors.WindowText
                Me.richTextBox1.SelectionAlignment = HorizontalAlignment.Center
            Case 9
                Me.richTextBox1.SelectionFont = New Font("Calibri", 11, FontStyle.Italic)
                Me.richTextBox1.SelectionColor = Color.FromArgb(0, 68, 114, 196)
                Me.richTextBox1.SelectionAlignment = HorizontalAlignment.Center
            Case 10
                Me.richTextBox1.SelectionBullet = True
                Me.richTextBox1.SelectionColor = SystemColors.WindowText
        End Select

        UpdateParagraphGroupBasedOnCurrentTextSelection()
        UpdateFontGroupBasedOnCurrentTextSelection()
    End Sub

    Private Sub ClearFormatButton_Click(sender As Object, e As EventArgs) Handles clearFormatButton.Click
        ClearFormatting()
    End Sub

    Private Sub C1Ribbon1_ViewChanged(sender As Object, e As EventArgs) Handles c1Ribbon1.ViewChanged
        styleGallery.Expanded = c1Ribbon1.ViewMode = ViewMode.Full
    End Sub

    Private Sub UpdateParagraphGroupBasedOnCurrentTextSelection()
        Me.UpdateParagraphAlignmentButtons()
    End Sub

    Private Sub ClearFormatting()
        Me.richTextBox1.SelectionIndent = 0
        Me.richTextBox1.SelectionHangingIndent = 0
        Me.richTextBox1.SelectionColor = Me.richTextBox1.ForeColor
        Me.richTextBox1.SelectionBackColor = Color.Transparent
        Me.richTextBox1.SelectionFont = Me.richTextBox1.Font
        Me.richTextBox1.SelectionBullet = False
        Me.richTextBox1.SelectionAlignment = HorizontalAlignment.Left
        UpdateParagraphGroupBasedOnCurrentTextSelection()
        UpdateFontGroupBasedOnCurrentTextSelection()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        My.MySettings.Default.Save()
    End Sub

#End Region

#Region "Custom Context Menu"

    Private _selectedItem As RibbonItem

    Private Sub c1Ribbon1_ContextMenuPopup(sender As Object, e As ContextMenuPopupEventArgs) Handles c1Ribbon1.ContextMenuPopup
        _selectedItem = Nothing
        rbAddToQAT.Text = "&Add to Quick Access Toolbar"
        rbMinimizeRibbon.Text = "Mi&nimize the Ribbon"
        Dim ribbonItem As RibbonItem = TryCast(e.Component, RibbonItem)
        If ribbonItem IsNot Nothing AndAlso ribbonItem.Group IsNot Nothing Then

            If TypeOf ribbonItem Is RibbonGallery OrElse TypeOf ribbonItem Is RibbonMenu OrElse TypeOf ribbonItem Is RibbonSplitButton OrElse TypeOf ribbonItem Is RibbonButton Then
                _selectedItem = ribbonItem

                If RibbonQat1.Items.Contains(ribbonItem) OrElse RibbonQat1.MenuItems.Contains(ribbonItem) Then
                    rbAddToQAT.Enabled = False
                End If

                If ribbonItem.ShowInSimplified Then
                    rbShowInSimplified.Text = "Can't be shown in a simplified view."
                Else
                    rbShowInSimplified.Text = "Can be shown in a simplified view."
                End If

                e.UseCustomMenu = True
            End If
        End If
    End Sub

    Private Sub rbAddToQAT_Click(sender As Object, e As EventArgs) Handles rbAddToQAT.Click
        If _selectedItem IsNot Nothing Then RibbonQat1.Items.Add(_selectedItem)
    End Sub

    Private Sub rbMinimizeRibbon_Click(sender As Object, e As EventArgs) Handles rbMinimizeRibbon.Click
        Ribbon.Minimized = True
    End Sub

    Private Sub rbShowInSimplified_Click(sender As Object, e As EventArgs) Handles rbShowInSimplified.Click
        If _selectedItem IsNot Nothing Then _selectedItem.ShowInSimplified = Not _selectedItem.ShowInSimplified
    End Sub

#End Region

End Class
