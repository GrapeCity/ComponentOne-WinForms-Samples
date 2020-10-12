using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Editor.UICustomization;

namespace CustomDialogs
{
    /// <summary>
    /// Shows custom message box.
    /// </summary>
    internal class ShowMessageBox : IMessageBox
    {
        #region IMessageDialog Members

        /// <summary>
        /// Shows the dialog window.
        /// </summary>
        /// <param name="owner">Any object that implements <see cref="IWin32Window"/> that represents the top-level window that will own the modal dialog box.</param>
        /// <param name="text">The text to display in the message box.</param>
        /// <param name="caption">The text to display in the title bar of the message box.</param>
        /// <param name="buttons">One of the <see cref="MessageBoxButtons"/> values that specifies which buttons to display in the message box.</param>
        /// <param name="icon">One of the <see cref="MessageBoxIcon"/> values that specifies which icon to display in the message box. </param>
        /// <returns>One of the <see cref="DialogResult"/> values.</returns>
        DialogResult IMessageBox.Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return MessageBox.Show(owner, text, caption, buttons, icon);
        }

        #endregion
    }
}
