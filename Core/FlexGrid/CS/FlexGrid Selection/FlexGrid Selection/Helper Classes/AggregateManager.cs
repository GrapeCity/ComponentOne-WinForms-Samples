using C1.Win.FlexGrid;
using C1.Win.Ribbon;
using FlexGrid_Selection.Interfaces;

namespace FlexGrid_Selection.Helper_Classes
{
    // EventArgs class for computed aggregates.
    public class AggregatesEventArgs : EventArgs
    {
        public Dictionary<string, IEnumerable<string>> Aggregates { get; }

        public AggregatesEventArgs(Dictionary<string, IEnumerable<string>> aggregates)
        {
            Aggregates = aggregates;
        }
    }
    public class AggregateManager : IAggregateManager
    {
        private readonly C1FlexGrid _sourceFlexGrid;
        private readonly C1FlexGrid _destinationFlexGrid;
        private readonly C1Ribbon _ribbon;
        private readonly Dictionary<string, (RibbonCheckBox CheckBox, AggregateEnum AggregateType)> _aggregateOperations;
        public event EventHandler<AggregatesEventArgs> AggregatesComputed;

        public AggregateManager(
            C1FlexGrid sourceFlexGrid, C1FlexGrid destinationFlexGrid, C1Ribbon ribbon,
            RibbonCheckBox cbSum, RibbonCheckBox cbCount, RibbonCheckBox cbAverage, RibbonCheckBox cbCountDistinct,
            RibbonCheckBox cbMax, RibbonCheckBox cbMin, RibbonCheckBox cbSampleVariance,
            RibbonCheckBox cbPopulationStandardDeviation, RibbonCheckBox cbPopulationVariance, RibbonCheckBox cbSampleStandardDeviation)
        {
            _sourceFlexGrid = sourceFlexGrid;
            _destinationFlexGrid = destinationFlexGrid;
            _ribbon = ribbon;

            _aggregateOperations = new Dictionary<string, (RibbonCheckBox, AggregateEnum)>
            {
                {"Sum", (cbSum, AggregateEnum.Sum)},
                {"Count", (cbCount, AggregateEnum.Count)},
                {"Average", (cbAverage, AggregateEnum.Average)},
                {"CountDistinct", (cbCountDistinct, AggregateEnum.CountDistinct)},
                {"Max", (cbMax, AggregateEnum.Max)},
                {"Min", (cbMin, AggregateEnum.Min)},
                {"SimpleVariance", (cbSampleVariance, AggregateEnum.Var)},
                {"PopStandardDeviation", (cbPopulationStandardDeviation, AggregateEnum.StdPop)},
                {"PopulationVariance", (cbPopulationVariance, AggregateEnum.VarPop)},
                {"SampleStandardDeviation", (cbSampleStandardDeviation, AggregateEnum.Std)}
            };

            // Subscribe to each aggregate checkbox's CheckedChanged event.
            foreach (var op in _aggregateOperations.Values)
            {
                op.CheckBox.CheckedChanged += async (s, e) => await UpdateStatisticsAsync();
            }
        }

        public async Task UpdateStatisticsAsync()
        {
            // Use a small delay to let pending UI messages process.
            await Task.Yield();

            // If no checkbox is checked, raise the event with an empty dictionary.
            if (!_aggregateOperations.Values.Any(op => op.CheckBox.Checked))
            {
                OnAggregatesComputed(new Dictionary<string, IEnumerable<string>>());
                return;
            }

            var aggregateSections = new Dictionary<string, IEnumerable<string>>();

            if (_sourceFlexGrid.Selection != null)
            {
                var aggregates = GetAggregates(_sourceFlexGrid).ToList();
                if (aggregates.Any())
                    aggregateSections["Source FlexGrid Aggregates:"] = aggregates;
            }

            if (_destinationFlexGrid.Selection != null)
            {
                var aggregates = GetAggregates(_destinationFlexGrid).ToList();
                if (aggregates.Any())
                    aggregateSections["Destination FlexGrid Aggregates:"] = aggregates;
            }

            OnAggregatesComputed(aggregateSections);
        }

        private IEnumerable<string> GetAggregates(C1FlexGrid grid)
        {
            var aggregates = new List<string>();
            foreach (var op in _aggregateOperations)
            {
                if (op.Value.CheckBox.Checked)
                {
                    var result = grid.Aggregate(op.Value.AggregateType);
                    // Format to 5 decimal places for specific aggregates
                    if (op.Key == "Average" || op.Key == "SimpleVariance" || op.Key == "PopStandardDeviation" || op.Key == "PopulationVariance" || op.Key == "SampleStandardDeviation")
                    {
                        aggregates.Add($"{op.Key} = {result:F5}");
                    }
                    else
                    {
                        aggregates.Add($"{op.Key} = {result}");
                    }
                }
            }
            return aggregates;
        }

        protected virtual void OnAggregatesComputed(Dictionary<string, IEnumerable<string>> aggregates)
        {
            AggregatesComputed?.Invoke(this, new AggregatesEventArgs(aggregates));
        }

        public void SetAggregateChecks(bool isChecked)
        {
            foreach (var op in _aggregateOperations.Values)
            {
                op.CheckBox.Checked = isChecked;
            }
        }
    }
}
