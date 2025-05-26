namespace FlexGridSelection.Interfaces
{
    public interface IClipboardManager
    {
        void Copy();
        void Paste();
        void AdjustGridForPaste();
        void UpdateCopyMode();
        void UpdateClipboardCopyModeText();
        void ApplySearch();
    }
}
