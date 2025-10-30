namespace FlexGridCheckboxSelection.Service
{
    /// <summary>
    /// Provides a concrete implementation of <see cref="IMessageBoxService"/> for displaying standard Windows message boxes.  
    /// </summary>
    internal sealed class MessageBoxService : IMessageBoxService
    {
        #region Public Methods

        /// <summary>
        /// Displays a warning message box with an OK button and a warning icon.
        /// </summary>
        /// <param name="message">The text message to display.</param>
        public void ShowWarning(string message)
            => MessageBox.Show(message, Strings.WarningTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

        /// <summary>
        /// Displays an error message box with an OK button and an error icon.
        /// </summary>
        /// <param name="message">The text message to display.</param>
        public void ShowError(string message)
            => MessageBox.Show(message, Strings.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);

        /// <summary>
        /// Displays an informational message box with an OK button and an information icon.
        /// </summary>
        /// <param name="message">The text message to display.</param>
        public void ShowInfo(string message)
            => MessageBox.Show(message, Strings.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Information); 
       
        #endregion
    }
}
