using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexChartExplorer.Samples
{
    public class DrillDownManager : DrillDownBase
    {
        #region fields
        private Queue<string> _drillDownPathQueue;

        #endregion

        #region Object Model
        public CollectionView CurrentItems
        {
            get;
            set;
        }

        #endregion

        #region C'tor

        public DrillDownManager(IEnumerable<object> orignalSource, string binding, string drilldownPath, AggregateType aggregate = AggregateType.Sum) : base(orignalSource, drilldownPath)
        {
            DrillDownLevel = 0;
            History = new Stack<DrillDownHistory>();
            AggregateOn = binding;
            AggregateType = aggregate;
            GroupNames = new List<string>();
        }

        #endregion

        #region Implementation

        protected override void UpdateAggregate()
        {
            if (CurrentItems != null && _currentPath != null && AggregateOn != null)
            {
                var name = CurrentItems.Name;
                var parent = CurrentItems.Parent;
                CurrentItems = new CollectionView(CurrentItems.SourceCollection, _currentPath, AggregateOn, AggregateType);
                CurrentItems.Name = name;
                CurrentItems.Parent = parent;
            }

        }

        public override void Refresh()
        {
            DrillDownLevel = 0;
            _drillDownPathQueue = new Queue<string>(DrillDownPath.Split(','));
            GroupNames = _drillDownPathQueue.Count > 1 ? DrillDownPath.Split(',').ToList() : GroupNames;
            _currentPath = _drillDownPathQueue.Dequeue();
            this.CurrentItems = new CollectionView(SourceCollection, _currentPath, this.AggregateOn, this.AggregateType, GroupNames[0]);
            History = new Stack<DrillDownHistory>();
            OnAfterDrill(_currentPath, DrillDownLevel, true);
        }

        protected override void PerformDrillDown(int index)
        {
            if (CurrentItems != null && _drillDownPathQueue != null && _drillDownPathQueue.Count > 0)
            {
                //Push CurrentItems to History and then Perform DrillDown
                if (CurrentItems != null)
                {
                    History.Push(
                        new DrillDownHistory()
                        {
                            DrillDownPath = _drillDownPathQueue.ToArray(),
                            Name = CurrentItems.Name,
                            Path = _currentPath,
                            View = CurrentItems,
                        }
                    );
                }

                _currentPath = _drillDownPathQueue.Dequeue();
                CurrentItems = CurrentItems.DrillDown(index, _currentPath, AggregateType);
                DrillDownLevel++;
            }
        }

        protected override void PerformDrillDown(IEnumerable<object> itemsSource)
        {
            if (CurrentItems != null)
            {
                History.Push(
                    new DrillDownHistory()
                    {
                        DrillDownPath = _drillDownPathQueue.ToArray(),
                        Name = CurrentItems.Name,
                        Path = _currentPath,
                        View = CurrentItems,
                    }
                );
            }
            var current = CurrentItems;
            CurrentItems = new CollectionView(itemsSource, _currentPath, AggregateOn)
            {
                Parent = current
            };
            DrillDownLevel++;
        }

        protected override void PerformDrillUp()
        {
            if (DrillDownLevel == 0)
                return;

            var historicalItem = History.Pop();  //Get Previous View
            _currentPath = historicalItem.Path;
            this.CurrentItems = (CollectionView)historicalItem.View;
            _drillDownPathQueue = new Queue<string>(historicalItem.DrillDownPath);
            DrillDownLevel--;
        }

        #endregion
    }
}
