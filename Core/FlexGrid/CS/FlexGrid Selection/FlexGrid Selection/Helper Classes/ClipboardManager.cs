using C1.Win.FlexGrid;
using C1.Win.Ribbon;
using FlexGrid_Selection.Interfaces;

namespace FlexGrid_Selection.Helper_Classes
{
    public class ClipboardManager : IClipboardManager
    {
        private readonly C1FlexGrid _sourceFlexGrid;
        private readonly C1FlexGrid _destinationFlexGrid;
        private readonly RibbonGallery _copyModeGallery;
        private readonly RibbonGalleryItem _dataAndAllHeaders;
        private readonly RibbonGalleryItem _dataOnly;
        private readonly RibbonGalleryItem _dataAndColumnHeaders;
        private readonly RibbonGalleryItem _dataAndRowHeaders;
        private readonly RibbonGalleryItem _disabled;
        private readonly RibbonTextBox _searchTextBox;

        public ClipboardManager(
            C1FlexGrid sourceFlexGrid, C1FlexGrid destinationFlexGrid, RibbonGallery copyModeGallery,
            RibbonGalleryItem dataAndAllHeaders, RibbonGalleryItem dataOnly, RibbonGalleryItem dataAndColumnHeaders, RibbonGalleryItem dataAndRowHeaders,
            RibbonGalleryItem disabled, RibbonTextBox searchTextBox)
        {
            _sourceFlexGrid = sourceFlexGrid;
            _destinationFlexGrid = destinationFlexGrid;
            _copyModeGallery = copyModeGallery;
            _dataAndAllHeaders = dataAndAllHeaders;
            _dataOnly = dataOnly;
            _dataAndColumnHeaders = dataAndColumnHeaders;
            _dataAndRowHeaders = dataAndRowHeaders;
            _disabled = disabled;
            _searchTextBox = searchTextBox;
        }

        public void Copy()
        {
            _sourceFlexGrid.Copy();
        }

        public void Paste()
        {
            AdjustGridForPaste();
            _destinationFlexGrid.Paste();
        }

        public void AdjustGridForPaste()
        {
            if (!Clipboard.ContainsText())
            {
                ShowError("Clipboard does not contain text data.");
                return;
            }

            var clipboardText = Clipboard.GetText();
            var lines = clipboardText.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            if (lines.Length == 0)
            {
                ShowError("Clipboard contains no data to paste.");
                return;
            }
            if (string.IsNullOrWhiteSpace(lines[0]))
            {
                ShowError("The first line of the clipboard data is empty.");
                return;
            }

            var firstLineColumns = lines[0].Split('\t');
            int colCount = firstLineColumns.Length;

            foreach (var line in lines)
            {
                if (line.Split('\t').Length != colCount)
                {
                    ShowError("Clipboard data contains inconsistent column counts.");
                    return;
                }
            }

            int rowCount = lines.Length;
            if (_destinationFlexGrid.Rows.Count < rowCount + 1)
                _destinationFlexGrid.Rows.Count = rowCount + 1;
            if (_destinationFlexGrid.Cols.Count < colCount + 1)
                _destinationFlexGrid.Cols.Count = colCount + 1;
        }

        //Updates the selected ClipboardCopyModeEnum
        public void UpdateCopyMode()
        {
            if (Enum.TryParse(_copyModeGallery.SelectedIndex.ToString(), out ClipboardCopyModeEnum mode))
            {
                _sourceFlexGrid.ClipboardCopyMode = mode;
                _destinationFlexGrid.ClipboardCopyMode = mode;
            }
        }

        public void UpdateClipboardCopyModeText()
        {
            _dataAndAllHeaders.Text = "Data And \nAll Header";
            _dataOnly.Text = "Data Only \n ";
            _dataAndColumnHeaders.Text = "Data And \nColumn Header";
            _dataAndRowHeaders.Text = "Data And \nRow Header";
            _disabled.Text = "Disabled \n ";
        }

        public void ApplySearch()
        {
            _sourceFlexGrid.ApplySearch(_searchTextBox.Text, (SearchHighlightMode)HighLightEnum.Always);
            _destinationFlexGrid.ApplySearch(_searchTextBox.Text, (SearchHighlightMode)HighLightEnum.Always);
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
