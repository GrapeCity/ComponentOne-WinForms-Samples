using C1.DataCollection;
using C1.DataFilter;
using C1.Win.DataFilter;
using System.Drawing;
using System.Windows.Forms;

namespace DataFilterExplorer.Samples
{
    public class DropDownFilter : ToolStripDropDown
    {
        public DropDownFilter()
        {
            AutoClose = true;
            AutoSize = true;
            Margin = Padding.Empty;
            Padding = Padding.Empty;

            DataFilter = new C1DataFilter
            {
                AutoWidthMode = AutoWidthMode.Grow,
                ShowClearFilterButtons = true,
                ShowHeader = false
            };

            var host = new ToolStripControlHost(DataFilter)
            {
                Margin = Padding.Empty,
                Padding = Padding.Empty,
                AutoSize = true,
                AutoToolTip = false
            };

            Items.Clear();
            Items.Add(host);
        }

        public void ShowFilter(string propertyName, Control control, Point location)
        {
            var isFound = false;
            foreach (var filter in DataFilter.Filters)
            {
                if (filter.PropertyName == propertyName)
                {
                    filter.Expanded = true;
                    isFound = true;
                }
                else
                    filter.Expanded = false;
            }
            if (isFound)
            {
                DataFilter.Height = GetPreferredSize(Size.Empty).Height;
                Show(control, location);
            }
        }

        public void AddFilter(Filter filter) => DataFilter.Filters.Add(filter);

        public void ApplyFilter(ISupportFiltering dataSource) => dataSource.FilterAsync(DataFilter.GetFilterExpression());

        public C1DataFilter DataFilter { get; }

        internal void ApplyTheme(C1.Win.Themes.C1Theme theme) => C1.Win.Themes.C1ThemeController.ApplyThemeToControlTree(DataFilter, theme);
    }
}
