using FlexGrid_Selection.Helper_Classes;

namespace FlexGrid_Selection.Interfaces
{
    public interface IAggregateManager
    {
        Task UpdateStatisticsAsync();
        void SetAggregateChecks(bool isChecked);
        event EventHandler<AggregatesEventArgs> AggregatesComputed;
    }
}
