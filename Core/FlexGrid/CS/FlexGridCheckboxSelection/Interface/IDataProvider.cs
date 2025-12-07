namespace FlexGridCheckboxSelection.Interface
{
    internal interface IDataProvider
    {
        bool GetRowsSafe(string sql, out DataTable dt, out string? error);
    }
}
