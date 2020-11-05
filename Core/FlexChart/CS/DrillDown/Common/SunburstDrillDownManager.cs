using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillDown
{
    class SunburstDrillDownManager
    {
        public event EventHandler OnDrillDownChanged;
        IEnumerable<DataItem> Orignal { get; set; }

        public IEnumerable<DataItem> CurrentItems { get; set; }

        public System.Collections.Concurrent.ConcurrentStack<SunburstDrillDownHistory> History { get; set; }
        
        public string[] DrillDownPath
        {
            get
            {
                string[] paths = new string[] { "Year", "Quarter", "Month" };
                if (CurrentItems != null)
                {
                    if (CurrentItems.First().Items.Count > 0 && !string.IsNullOrEmpty(CurrentItems.First().Month))
                        paths = new string[] { "Month" };
                    else if (CurrentItems.First().Items.Count > 0 && !string.IsNullOrEmpty(CurrentItems.First().Quarter))
                        paths = new string[] { "Quarter", "Month" };
                }
                return paths;
            }
        }

        public SunburstDrillDownManager(IEnumerable<DataItem> orignal)
        {
            this.Orignal = orignal.ToArray();
            this.CurrentItems = this.Orignal;
            
            History = new System.Collections.Concurrent.ConcurrentStack<SunburstDrillDownHistory>();
            History.Push(
                new SunburstDrillDownHistory()
                {
                    Items = this.CurrentItems,
                }
            );
            if (OnDrillDownChanged != null)
            {
                this.OnDrillDownChanged(this, new EventArgs());
            }
        }

        public void DrillDown(DataItem item)
        {
            if (CurrentItems != null)
            {
                if (!item.Items.Any())
                {
                    return;
                }


                this.CurrentItems = new DataItem[] { item};
                History.Push(
                     new SunburstDrillDownHistory()
                     {
                         Items = this.CurrentItems,
                     }
                 );
                if (OnDrillDownChanged != null)
                {
                    this.OnDrillDownChanged(this, new EventArgs());
                }
            }
        }

        public void GoBack()
        {
            if (History.Count == 0)
            {
                CurrentItems = Orignal;
            }
            else
            {


                SunburstDrillDownHistory history = null;

                do
                {
                    History.TryPop(out history);

                } while (history != null && history.Items.Count() == 1 && history.Items.First() == CurrentItems.First());


                CurrentItems = history==null ? Orignal: history.Items;
            }

            if (OnDrillDownChanged != null)
            {
                this.OnDrillDownChanged(this, new EventArgs());
            }
        }


    }

    public class SunburstDrillDownHistory
    {
        public IEnumerable<DataItem> Items { get; set; }
    }
}
