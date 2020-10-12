Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Public Partial Class Form1
	Inherits Form
	Public Sub New()
		InitializeComponent()
		InitCustomDialogs()
	End Sub

	''' <summary>
	''' Initializes custom forms for using in the control
	''' </summary>
	Private Sub InitCustomDialogs()
		editor.CustomDialogs.BookmarkDialog = New BookmarkEditorForm()
		editor.CustomDialogs.FindReplaceDialog = New FindReplaceForm()
		editor.CustomDialogs.FormattingDialog = New FormattingForm()
		editor.CustomDialogs.HyperlinkDialog = New HyperlinkEditorForm()
		editor.CustomDialogs.ImageDialog = New ImageEditorForm()
        editor.CustomDialogs.FlashMovieDialog = New FlashMovieEditorForm()
        editor.CustomDialogs.TableCellDialog = New CellEditorForm()
		editor.CustomDialogs.TableColumnDialog = New ColumnEditorForm()
		editor.CustomDialogs.TableDialog = New TableEditorForm()
        editor.CustomDialogs.TableRowDialog = New RowEditorForm()
        editor.CustomDialogs.MessageBox = New ShowMessageBox()
	End Sub

	''' <summary>
	''' Displays a dialog of the appropriate type
	''' </summary>
	''' <param name="sender">The source of the event.</param>
	''' <param name="e">A <see cref="ToolStripItemClickedEventArgs"/> that contains the event data.</param>
	Private Sub toolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)
		If e.ClickedItem Is tsBookmark Then
            editor.ShowDialog(C1.Win.C1Editor.DialogType.Bookmark)
        ElseIf e.ClickedItem Is tsFind Then
            editor.ShowDialog(C1.Win.C1Editor.DialogType.Find)
        ElseIf e.ClickedItem Is tsFormatting Then
            editor.ShowDialog(C1.Win.C1Editor.DialogType.Format)
        ElseIf e.ClickedItem Is tsHyperlink Then
            editor.ShowDialog(C1.Win.C1Editor.DialogType.Hyperlink)
        ElseIf e.ClickedItem Is tsPicture Then
            editor.ShowDialog(C1.Win.C1Editor.DialogType.Image)
        ElseIf e.ClickedItem Is tsTable Then
            editor.ShowDialog(C1.Win.C1Editor.DialogType.NewTable)
        ElseIf e.ClickedItem Is Me.tsFlash Then
            editor.ShowDialog(C1.Win.C1Editor.DialogType.FlashMovie)
        ElseIf e.ClickedItem Is tsReplace Then
            editor.ShowDialog(C1.Win.C1Editor.DialogType.Replace)
		End If
    End Sub
End Class
