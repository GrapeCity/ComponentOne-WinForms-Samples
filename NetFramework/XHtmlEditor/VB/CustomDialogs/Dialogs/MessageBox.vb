Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1Editor.UICustomization

''' <summary>
''' Shows custom message box.
''' </summary>
Friend Class ShowMessageBox
    Implements IMessageBox

#Region "IMessageBox Members"

    ''' <summary>
    ''' Shows the dialog window.
    ''' </summary>
    ''' <param name="owner">Any object that implements <see cref="IWin32Window"/> that represents the top-level window that will own the modal dialog box.</param>
    ''' <param name="text">The text to display in the message box.</param>
    ''' <param name="caption">The text to display in the title bar of the message box.</param>
    ''' <param name="buttons">One of the <see cref="MessageBoxButtons"/> values that specifies which buttons to display in the message box.</param>
    ''' <param name="icon">One of the <see cref="MessageBoxIcon"/> values that specifies which icon to display in the message box. </param>
    ''' <returns>One of the <see cref="DialogResult"/> values.</returns>
    Public Function IMessageBox_Show(ByVal owner As IWin32Window, ByVal text As String, ByVal caption As String, ByVal buttons As MessageBoxButtons, ByVal icon As MessageBoxIcon) As DialogResult Implements IMessageBox.Show
        IMessageBox_Show = MessageBox.Show(owner, text, caption, buttons, icon)
    End Function

#End Region

End Class