namespace FlexGridCheckboxSelection.Helper
{
    /// <summary>
    /// Provides helper methods for updating UI elements. 
    /// </summary>
    internal static class UiUpdater
    {
        #region Public Methods

        /// <summary>
        /// Updates the target <see cref="RichTextBox"/> to display the number of selected rows in the grid, with the count rendered in bold.
        /// </summary>
        /// <param name="grid">The <see cref="C1FlexGrid"/> whose selection is being tracked.</param>
        /// <param name="targetTxt">The <see cref="RichTextBox"/> control where the count text will be displayed.</param>
        public static void UpdateSelectedCount(C1FlexGrid grid, RichTextBox targetTxt)
        {
            if (grid == null || targetTxt == null) return;

            int fixedRows = grid.Rows.Fixed;
            int count = 0;

            foreach (Row row in grid.Rows)
            {
                if (!row.IsNode && row.Selected)
                    count++;
            }

            // Build the full sentence from resources
            string template = count == 1 ? Strings.SelectedCountOneTxt : Strings.SelectedCountManyTxt;
            string text = string.Format(template, count);

            // Set text
            targetTxt.Clear();
            targetTxt.AppendText(text);

            // Bold only the number
            string num = count.ToString();
            int start = targetTxt.Text.IndexOf(num, StringComparison.Ordinal);
            if (start >= 0)
            {
                targetTxt.Select(start, num.Length);
                targetTxt.SelectionFont = new Font(targetTxt.Font, FontStyle.Bold);
                targetTxt.Select(targetTxt.TextLength, 0);
            }
        }

        #endregion
    }
}
