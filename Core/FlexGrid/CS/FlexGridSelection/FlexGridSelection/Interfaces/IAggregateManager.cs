using FlexGridSelection.Helper_Classes;

namespace FlexGridSelection.Interfaces
{
    public interface IAggregateManager
    {
        Task UpdateStatisticsAsync();
        void SetAggregateChecks(bool isChecked);
        event EventHandler<AggregatesEventArgs> AggregatesComputed;
    }
}
