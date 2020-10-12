using C1.FlexMap;
using C1.Win.Chart;
using C1.Win.Layout;
using C1.Win.Map;
using DashboardModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Forms;
using C1.Win.DataFilter;

namespace DashboardWinForms
{
    public partial class Analysis : UserControl
    {
        private C1.Win.Map.VectorLayer _vectorLayer;
        C1DataFilter dfMap;

        public Analysis()
        {
            InitializeComponent();
            Text = Strings.Resource.AnalysisPage_Title;
            labProdWise.Text = Strings.Resource.ProductWise_Header;
        }

        private void Analysis_Load(object sender, EventArgs e)
        {
            dfOlap.AutoApply = true;
            dfOlap.AutoGenerateFilters = false;
            dfOlap.FilterChanged += DfOlap_FilterChanged;
            dfMap = new C1DataFilter();
            dfMap.AutoApply = true;
            dfMap.AutoGenerateFilters = false;
            dfMap.FilterChanged += DfMap_FilterChanged;

            var dashboardLayout = new C1DashboardLayout();
            _vectorLayer = new C1.Win.Map.VectorLayer() { LabelVisibility = LabelVisibility.Visible };
            _vectorLayer.LabelStyle.Font = new Font(Font.FontFamily, 7);

            Map.TileLayer.TileSource = new VirtualEarthRoadSource();
            Map.Layers.Add(_vectorLayer);

            var engine = OlapPanel.FlexPivotEngine;
            engine.DataSource = DataService.GetService().ProductWiseSaleCollection;
            InitOlap(engine);

            var selector = new ValRangeSelector() { Dock = DockStyle.Bottom };

            ChecklistFilter fCategories = new ChecklistFilter("Category", true);
            fCategories.HeaderText = Strings.Resource.DataFilter_Categories;
            fCategories.ItemsSource = DataService.GetService().ProductWiseSaleCollection;
            fCategories.ValueMemberPath = "Category";
            fCategories.SelectAll();
            dfOlap.Filters.Add(fCategories);
            dfMap.Filters.Add(fCategories);
            ChecklistFilter fModels = new ChecklistFilter("Product", true);
            fModels.HeaderText = Strings.Resource.DataFilter_Products;
            fModels.ItemsSource = fCategories.ItemsSource;
            fModels.ValueMemberPath = "Product";
            fModels.SelectAll();
            dfOlap.Filters.Add(fModels);
            dfMap.Filters.Add(fModels);
            RangeFilter fSales = new RangeFilter("Sales", true);
            fSales.HeaderText = Strings.Resource.DataFilter_Sales;
            var list = from prod in DataService.GetService().ProductWiseSaleCollection.Cast<ProductsWiseSaleItem>() select prod.Sales;
            fSales.Maximum = list.Max();
            fSales.Minimum = list.Min();
            dfOlap.Filters.Add(fSales);
            dfMap.Filters.Add(fSales);

            selector.DateRangeChanged += (s, ev) =>
            {
                dfOlap.DataSource = DataService.GetService().ProductWiseSaleCollection;
                dfMap.DataSource = DataService.GetService().GetRegionWiseSalesWithCategory();

                DataService.GetService().GetRegionWiseSaleCollection = () => dfMap.View.ToList();

                DataService.GetService().DateRange = ev.NewValue;
                UpdataMapMark();

                chartOpportunities.DataSource = DataService.GetService().OpportunityItemList;
                chartOpportunities.Series.Clear();
                var series = new Series();
                series.Binding = series.Name = "Sales";
                chartOpportunities.Series.Add(series);
                chartOpportunities.BindingX = "Level";
                chartOpportunities.DataLabel.Position = C1.Chart.LabelPosition.Center;
                chartOpportunities.DataLabel.Content = "{}{y:C0}";
                chartOpportunities.ChartType = C1.Chart.ChartType.Funnel;


            };
            Controls.Add(selector);
            dashboardLayout.Options.ToolIconAppearance = ToolIconAppearance.UpperRight;
            dashboardLayout.AttachToLayout(new SplitLayout(c1SplitContainerMain));
            IconBox settings = new IconBox() { BackgroundImage = Properties.Resources.settings_work_tool };
            settings.Click += (s, ev) =>
            {
                OlapPanel.Location = PointToClient(settings.PointToScreen(new Point(-2, settings.Height + 2)));
                if (OlapPanel.Right > Right)
                    OlapPanel.Left = Right - OlapPanel.Width - 2;
                OlapPanel.Parent = this;
                OlapPanel.Visible = true;
                OlapPanel.BringToFront();
            };
            OlapPanel.MouseLeave += (s, ev) => OlapPanel.Visible = false;
            IconBox dataFilter = new IconBox() { BackgroundImage = Properties.Resources.C1DataFilter };
            dataFilter.Click += (s, ev) =>
            {
                dfOlap.Location = PointToClient(dataFilter.PointToScreen(new Point(-2, dataFilter.Height + 2)));
                if (dfOlap.Right > Right)
                    dfOlap.Left = Right - dfOlap.Width - 2;
                dfOlap.Parent = this;
                dfOlap.Visible = true;
                dfOlap.BringToFront();
            };
            settings.VisibleChanged += (s, ev) => {
                settings.Visible = dashboardLayout.GetSelectedItem()?.ItemContainer == c1SplitterPanelGrid;
                dataFilter.Visible = settings.Visible;
            };
            dfOlap.MouseLeave += (s, ev) => dfOlap.Visible = false;
            OlapGrid.Resize += (s1, ev1) => { OlapPanel.Visible = false; dfOlap.Visible = false; };
            dashboardLayout.ItemContainerSelected += (s, ev) =>
            {
                settings.Visible = dashboardLayout.GetSelectedItem()?.ItemContainer == c1SplitterPanelGrid;
                dataFilter.Visible = settings.Visible;
            };
            dashboardLayout.Options.HeaderElements.Add(dataFilter);
            dashboardLayout.Options.HeaderElements.Add(settings);
            dashboardLayout.SetCaption(c1SplitterPanelGrid, Strings.Resource.ProductWise_Header);
            dashboardLayout.SetCaption(c1SplitterPanel3, Strings.Resource.RegionWise_Header);
            dashboardLayout.SetCaption(c1SplitterPanel4, Strings.Resource.Opportunities_Header);
            this.c1SplitterPanelGrid.Width = 565;
            selector.SendToBack();
            ScanControls(this);
        }

        private void InitOlap(C1.FlexPivot.C1FlexPivotEngine engine)
        {
            OlapGrid.DataSource = OlapPanel;
            engine.RowFields.Add("Category");
            engine.RowFields.Add("Product");
            engine.Fields["Category"].Width = 70;
            engine.Fields["Product"].Width = 120;
            engine.ColumnFields.Add("Region");
            engine.ValueFields.Add("Sales");
            engine.ValueField.Format = "C";
        }

        private void DfMap_FilterChanged(object sender, EventArgs e)
        {
            UpdataMapMark();
        }

        private void DfOlap_FilterChanged(object sender, EventArgs e)
        {
            OlapPanel.FlexPivotEngine.DataSource = null;
            var engine = OlapPanel.FlexPivotEngine;
            engine.DataSource = dfOlap.View;
            if (engine.Fields.Count > 0)
                InitOlap(engine);
        }

        private void ScanControls(Control ctrl)
        {
            foreach (Control control in ctrl.Controls)
            {
                control.MouseMove += Control_MouseMove;
                ScanControls(control);
            }
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (OlapPanel.Visible && GetChildAtPoint(MousePosition) != OlapPanel)
                OlapPanel.Visible = false;
        }

        private void UpdataMapMark()
        {
            _vectorLayer.Items.Clear();
            var regionSalesCollection = new ListCollectionView(DataService.GetService().GetRegionWiseSales());
            if (regionSalesCollection.Count == 0)
                return;
            regionSalesCollection.SortDescriptions.Add(new SortDescription("Sales", ListSortDirection.Descending));
            double maxValue = (regionSalesCollection.GetItemAt(0) as RegionSaleItem).Sales;
            foreach (RegionSaleItem sales in regionSalesCollection)
            {
                C1.Win.Map.VectorPlacemark mark = new C1.Win.Map.VectorPlacemark();
                mark.Geometry = new GeoPoint(sales.Locat.X, sales.Locat.Y);
                mark.Marker.Size = CreateMarkBySale(sales.Sales, maxValue);
                mark.Marker.Shape = MarkerShape.Circle;
                mark.Marker.Caption = string.Format("{0:C}", sales.Sales);
                mark.Marker.LabelPosition = LabelPosition.Center;
                mark.Style.Stroke.Color = sales.Profit > 0 ? Color.Orange : Color.RoyalBlue;
                mark.Style.BackColor = mark.Style.Stroke.Color;
                _vectorLayer.Items.Add(mark);
            }
        }

        SizeF CreateMarkBySale(double sales, double maxValue)
        {
            float delta = (float)(30 * sales / maxValue);
            return new SizeF(delta, delta);
        }

    }
}
