namespace FlexGridCheckboxSelection.Interface
{
    internal interface IMessageBoxService
    {
        void ShowWarning(string message);
        void ShowError(string message);
        void ShowInfo(string message);
    }
}
