using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.DataCollection.BindingList;
using C1.DataEngine;
using System.Diagnostics;
using C1.Win.FlexGrid;
using System.IO;

namespace ControlExplorer.DataFilter.UI
{
    public partial class FilterEditorView : UserControl
    {
        private Stopwatch _swFiltered;
        private C1DataCollectionBindingList _dataCollection;
        private Workspace _workspace;
        private readonly FilterForm _filterForm;
        private bool _isHotColumn;
        private bool _loading = false;
        private bool _isCanceled = false;
        private string _workspaceName = "workspaceFE-";

        public FilterEditorView()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            _filterForm = new FilterForm();
            _filterForm.FilterChanged += FilterForm_FilterChanged;
            _filterForm.FilterChanging += FilterForm_FilterChanging;

            c1FlexGrid1.SelectionMode = SelectionModeEnum.Cell;
            c1FlexGrid1.DrawMode = DrawModeEnum.OwnerDraw;
            c1FlexGrid1.OwnerDrawCell += C1FlexGrid1_OwnerDrawCell;
            c1FlexGrid1.MouseClick += C1FlexGrid1_MouseClick;
            c1FlexGrid1.MouseMove += C1FlexGrid1_MouseMove;
        }

        public int TotalCount { get; private set; }
        public int FilteredCount { get; private set; }
        public long TotalLoadTime { get; private set; }
        public long FilteredTime { get; private set; }

        public event EventHandler DataUpdated;
        public event EventHandler DataLoaded;
        protected void OnDataLoaded() => DataLoaded?.Invoke(this, EventArgs.Empty);
        internal void ApplyTheme(C1.Win.Themes.C1Theme theme) => Explorer.ApplyTheme(_filterForm);

        public async Task LoadData()
        {
            _loading = true;
            _workspaceName += Guid.NewGuid().ToString();
            _workspace = new Workspace();
            var (collection, count, time) = await DataService.LoadDataCollection(_workspace, _workspaceName);
            TotalLoadTime = time;
            _dataCollection = new C1DataCollectionBindingList(collection);
            TotalCount = count;

            _filterForm.DataSource = collection;
            if (_isCanceled)
            {
                _loading = false;
                ClearWorkspace();
                return;
            }
            // flex grid
            await Task.Run(() => c1FlexGrid1.DataSource = _dataCollection);  
            c1FlexGrid1.Cols["PostId"].Visible = false;
            c1FlexGrid1.Cols["CountryId"].Visible = false;
            c1FlexGrid1.Cols["FirstName"].Caption = "First Name";
            c1FlexGrid1.Cols["LastName"].Caption = "Last Name";
            c1FlexGrid1.Cols["EmploymentDate"].Caption = "Employment Date";
            OnDataLoaded();
            _loading = false;
            if (_isCanceled)
                ClearWorkspace();
        }
        private void ClearWorkspace()
        {
            _workspace.Dispose();
            if (Directory.Exists(_workspaceName))
            {
                try
                {
                    Directory.Delete(_workspaceName, true);
                }
                catch { }
                finally { }
            }
        }
        private void C1FlexGrid1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isHotColumn)
                c1FlexGrid1.Invalidate(0, 0);
            _isHotColumn = false;
            var hitTestType = c1FlexGrid1.HitTest(e.X, e.Y);
            if (hitTestType.Type == HitTestTypeEnum.ColumnHeader && hitTestType.Column == 0)
            {
                var rect = c1FlexGrid1.GetCellRect(0, 0);
                rect.Width = Properties.Resources.FilterHot.Width;
                if (rect.Contains(e.Location))
                {
                    _isHotColumn = true;
                    c1FlexGrid1.Invalidate(0, 0);
                }
            }
        }

        private void C1FlexGrid1_OwnerDrawCell(object sender, OwnerDrawCellEventArgs e)
        {
            if (e.Row == 0 && e.Col == 0)
            {
                var filterImage = _isHotColumn ? Properties.Resources.FilterHot : Properties.Resources.Filter;
                if (_filterForm.IsFilterActive)
                    filterImage = _isHotColumn ? Properties.Resources.AdvancedFilterHot : Properties.Resources.AdvancedFilter;
                e.Style.Render(e.Graphics, e.Bounds, e.Text, filterImage);
                e.Handled = true;
            }
        }

        private void C1FlexGrid1_MouseClick(object sender, MouseEventArgs e)
        {
            var hitTestType = c1FlexGrid1.HitTest(e.X, e.Y);
            if (hitTestType.Type == HitTestTypeEnum.ColumnHeader && _isHotColumn)
            {
                var cellRect = c1FlexGrid1.GetCellRect(0, 0);
                _filterForm.Location = c1FlexGrid1.PointToScreen(new Point(cellRect.Left, cellRect.Bottom));
                _filterForm.UpdateExpression();
                if (_filterForm.ShowDialog() == DialogResult.OK)
                {
                    _filterForm.ApplyFilter();
                }
            }
        }

        private void FilterForm_FilterChanging(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _swFiltered = new Stopwatch();
            _swFiltered.Start();
        }

        private void FilterForm_FilterChanged(object sender, EventArgs e)
        {
            _swFiltered.Stop();
            FilteredTime = _swFiltered.ElapsedMilliseconds;
            FilteredCount = _dataCollection.Count;
            DataUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}
