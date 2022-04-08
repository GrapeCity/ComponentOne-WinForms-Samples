using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashboardModel;
using System.Data.Entity;
using System.ComponentModel;
using System.Threading;
//using System.Windows.Data;
using System.Windows;
using System.Collections.ObjectModel;
using System.Drawing;

namespace DashboardWinForms
{

    public class ListCollectionView : ObservableCollection<object>
    {
        public ListCollectionView(IEnumerable<object> collection) : base(collection)
        {
        }
    }

    public class DataService
    {
        static DataService dataService;

        string initialPath = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), "InitialData.xml");

        DashboardContext dashboardContext;
        Model model;

        DateRange dateRangeFilter;
        CategoryType categoryFilter;
        CampainTaskType campainFilter;

        List<SaleGoalItem> categorySalesVsGoal;
        List<SaleGoalItem> regionSalesVsGoal;
        List<SaleItem> dateSaleList;
        List<CurrentPriorBudgetItem> budgetItemList;
        List<Opportunity> opportunityList;

        ListCollectionView budgetCollection;
        ListCollectionView saleCollection;
        ListCollectionView productCollection;
        ListCollectionView opportunityCollection;
        ListCollectionView regionSaleGoalCollection;

        ListCollectionView regionWiseSaleCollection;
        ListCollectionView campainTaskCollection;
        ListCollectionView productWiseSaleCollection;
        ListCollectionView customerSaleCollection;
        ListCollectionView productSaleCollection;

        public DataService()
        {
            dashboardContext = new DashboardContext();
        }

        public static DataService GetService()
        {
            if (dataService == null)
                dataService = new DataService();
            return dataService;
        }

        public void InitializeDataService()
        {
            VerifyDatabase();

            dashboardContext.Budget.Load();
            dashboardContext.Sales.Load();
            dashboardContext.Products.Load();
            dashboardContext.RegionWiseSales.Load();
            dashboardContext.Opportunities.Load();
            dashboardContext.RegionSales.Load();

            var budgetList = dashboardContext.Budget.Local.ToList();
            var productList = dashboardContext.Products.Local.ToList();
            var saleList = dashboardContext.Sales.Local.ToList();
            var opportunityList = dashboardContext.Opportunities.Local.ToList();
            var regionWiseSales = dashboardContext.RegionWiseSales.Local.ToList();
            var regionSales = dashboardContext.RegionSales.Local.ToList();

            budgetCollection = new ListCollectionView(budgetList);
            productCollection = new ListCollectionView(productList);
            saleCollection = new ListCollectionView(saleList);
            opportunityCollection = new ListCollectionView(opportunityList);
            regionWiseSaleCollection = new ListCollectionView(regionWiseSales);
            regionSaleGoalCollection = new ListCollectionView(regionSales);

            ///regionWiseSaleCollection.SortDescriptions.Add(new SortDescription("Date", ListSortDirection.Ascending));
            ///saleCollection.SortDescriptions.Add(new SortDescription("Date", ListSortDirection.Ascending));

            var dateSaleMap = new Dictionary<DateTime, SaleItem>();
            var productsWiseSaleItems = new List<ProductsWiseSaleItem>();

            foreach (Sale sale in saleCollection)
            {
                ProductsWiseSaleItem productsWiseSale = new ProductsWiseSaleItem();
                productsWiseSale.Date = sale.Date;
                productsWiseSale.Quantity = sale.Quantity;
                productsWiseSale.Sale = sale.Summ;
                productsWiseSale.ID = sale.ProductId;
                productsWiseSale.Category = sale.Product.Category.Name;
                productsWiseSale.Product = sale.Product.Name;
                productsWiseSale.Region = sale.Customer.Region.Name;
                productsWiseSaleItems.Add(productsWiseSale);

                if (dateSaleMap.ContainsKey(sale.Date))
                    dateSaleMap[sale.Date].Sales += sale.Summ;
                else
                    dateSaleMap.Add(sale.Date, new SaleItem { Sales = sale.Summ, Date = sale.Date });

            }
            dateSaleList = dateSaleMap.Values.ToList();
            productWiseSaleCollection = new ListCollectionView(productsWiseSaleItems);
            var budgetSaleProfitMap = new Dictionary<int, CurrentPriorBudgetItem>();

            foreach (BudgetItem budget in budgetCollection)
            {
                if (budget.Expences > 0)
                {
                    int month = budget.Date.Month;
                    int year = budget.Date.Year;
                    if (budgetSaleProfitMap.ContainsKey(month))
                    {
                        if(year == 2017)
                        {
                            budgetSaleProfitMap[month].Sales += budget.Sales;
                            budgetSaleProfitMap[month].Profit += budget.Profit;
                        }
                        else
                        {
                            budgetSaleProfitMap[month].ProirSales += budget.Sales;
                            budgetSaleProfitMap[month].ProirProfit += budget.Profit;
                        }
                    }
                    else
                    {
                        if (year == 2017)
                            budgetSaleProfitMap.Add(month, new CurrentPriorBudgetItem { Date = budget.Date, Sales = budget.Sales, Profit = budget.Profit } );
                        else
                            budgetSaleProfitMap.Add(month, new CurrentPriorBudgetItem { Date = budget.Date, ProirSales = budget.Sales, ProirProfit = budget.Profit });
                    }
                }
            }

            budgetItemList = budgetSaleProfitMap.Values.ToList();
        }

        void VerifyDatabase()
        {
            bool isExists = dashboardContext.Database.Exists();
            bool isCompatible = isExists && dashboardContext.Database.CompatibleWithModel(false);
            if (!isCompatible)
            {
                if (isExists)
                {
                    dashboardContext.Database.Delete();
                    dashboardContext = new DashboardContext();
                }
                dashboardContext.Database.Create();
                model = Model.GetPopulated(initialPath);
                dashboardContext.Seed(model);
            }
        }

        public DateRange DateRange
        {
            get { return dateRangeFilter; }
            set
            {
                dateRangeFilter = value;
                UpdataDataByDateRange();
            }
        }
        public CampainTaskType CampainTaskType
        {
            get { return campainFilter; }
            set
            {
                if(campainFilter != value)
                {
                    campainFilter = value;
                    ///campainTaskCollection.Filter = new Predicate<object>(FilterByCampainTaskType);
                }
            }
        }

        public ListCollectionView CampainTaskCollction { get { return campainTaskCollection; } }
        public ListCollectionView ProductWiseSaleCollection { get { return productWiseSaleCollection; } }

        public List<CurrentPriorBudgetItem> BudgetItemList { get { return budgetItemList; } }
        public List<SaleItem> DateSaleList { get { return dateSaleList; } }
        public List<Opportunity> OpportunityItemList { get { return opportunityList; } }

        
        public List<RegionSaleItem> GetRegionWiseSales()
        {
            var regionSaleMap = new Dictionary<int, RegionSaleItem>();
            foreach(RegionWiseSale regionWiseSale in regionWiseSaleCollection)
            {
                if (regionSaleMap.ContainsKey(regionWiseSale.RegionId))
                {
                    regionSaleMap[regionWiseSale.RegionId].Sales += regionWiseSale.Sales;
                    regionSaleMap[regionWiseSale.RegionId].Profit += regionWiseSale.Profit;
                }
/*                else
                    regionSaleMap.Add(regionWiseSale.RegionId, new RegionSaleItem { Id = regionWiseSale.RegionId, Locat = new Point(regionWiseSale.X, regionWiseSale.Y), Sales = regionWiseSale.Sales, Profit = regionWiseSale.Profit, Name = regionWiseSale.Region });*/
            }
            return regionSaleMap.Values.ToList();
        }
        public List<ProductItem> GetProductItemList(CategoryType filter)
        {
            categoryFilter = filter;
            ///productCollection.Filter = new Predicate<object>(FilterByCategoryType);
            List<ProductItem> list = new List<ProductItem>();
            foreach (Product product in productCollection)
            {
                ProductItem item = new ProductItem(product);
                list.Add(item);
            }
            return list;
        }

        public List<SaleItem> GetTopSaleProductList(int top)
        {
            var item = new List<SaleItem>();
            foreach (SaleItem productSale in productSaleCollection)
            {
                item.Add(productSale);
                if (item.Count == top)
                    break;
            }
            return item;
        }
        public List<SaleItem> GetTopSaleCustomerList(int top)
        {
            var item = new List<SaleItem>();
            foreach (SaleItem customerSale in customerSaleCollection)
            {
                item.Add(customerSale);
                if (item.Count == top)
                    break;
            }
            return item;
        }

        public List<SaleGoalItem> CategorySalesVsGoal { get { return categorySalesVsGoal; } }
        public List<SaleGoalItem> RegionSalesVsGoal { get { return regionSalesVsGoal; } }

        void UpdataDataByDateRange()
        {
            ///saleCollection.Filter = new Predicate<object>(FilterByDateRange);
            ///saleCollection.SortDescriptions.Add(new SortDescription("Date", ListSortDirection.Ascending));
            ///budgetCollection.Filter = new Predicate<object>(FilterByDateRange);
            ///opportunityCollection.Filter = new Predicate<object>(FilterByDateRange);
            ///regionWiseSaleCollection.Filter = new Predicate<object>(FilterByDateRange);
            ///regionSaleGoalCollection.Filter = new Predicate<object>(FilterByDateRange);

            opportunityList = new List<Opportunity>();
            foreach (OpportunityLevel value in Enum.GetValues(typeof(OpportunityLevel)))
                opportunityList.Add(new Opportunity { Level = value, Sales = 0 });


            var campainTaskItems = new List<CampainTaskItem>();
            var productSaleMap = new Dictionary<int, SaleItem>();
            var customerSaleMap = new Dictionary<int, SaleItem>();

            foreach (Sale sale in saleCollection)
            {
                var profit = DataService.GetService().FindProfitFormCurrentSale(sale);
                if (sale.Campaign.Name != "None")
                    campainTaskItems.Add(new CampainTaskItem(sale));
                if (customerSaleMap.ContainsKey(sale.CustomerId))
                {
                    customerSaleMap[sale.CustomerId].Sales += sale.Summ;
                    customerSaleMap[sale.CustomerId].Profit += profit;
                }
                else
                    customerSaleMap.Add(sale.CustomerId, new SaleItem { Id = sale.CustomerId, Sales = sale.Summ, Profit = profit, Name = sale.Customer.ToString(), Date = sale.Date });
                if(productSaleMap.ContainsKey(sale.ProductId))
                {
                    productSaleMap[sale.ProductId].Sales += sale.Summ;
                    productSaleMap[sale.ProductId].Profit += profit;
                }
                else
                    productSaleMap.Add(sale.ProductId, new SaleItem { Id = sale.ProductId, Sales = sale.Summ, Profit = profit, Name = sale.Product.ToString(), Date = sale.Date });
            }

            var regionSaleMap = new Dictionary<int, SaleGoalItem>();
            var categorySaleMap = new Dictionary<int, SaleGoalItem>();

            foreach (BudgetItem budget in budgetCollection)
            {
                if (categorySaleMap.ContainsKey(budget.CategoryId))
                {
                    categorySaleMap[budget.CategoryId].Sales += budget.Sales;
                    categorySaleMap[budget.CategoryId].Profit += budget.Profit;
                    categorySaleMap[budget.CategoryId].Goal += budget.Goal;
                }
                else
                {
                    SaleGoalItem item = new SaleGoalItem();
                    item.Name = budget.Category.ToString();
                    item.Goal = budget.Goal;
                    item.Sales = budget.Sales;
                    item.Profit = budget.Profit;
                    categorySaleMap.Add(budget.CategoryId, item);
                }
            }
            foreach(RegionSalesGoal region in regionSaleGoalCollection)
            {
                if (regionSaleMap.ContainsKey(region.RegionId))
                {
                    regionSaleMap[region.RegionId].Sales += region.Sales;
                    regionSaleMap[region.RegionId].Profit += region.Profit;
                    regionSaleMap[region.RegionId].Goal += region.Goal;
                }
                else
                {
                    SaleGoalItem item = new SaleGoalItem();
                    item.Name = region.Region.ToString();
                    item.Goal = region.Goal;
                    item.Sales = region.Sales;
                    item.Profit = region.Profit;
                    regionSaleMap.Add(region.RegionId, item);
                }
            }

            campainTaskCollection = new ListCollectionView(campainTaskItems);
            ///campainTaskCollection.Filter = new Predicate<object>(FilterByCampainTaskType);

            productSaleCollection = new ListCollectionView(productSaleMap.Values.ToList());
            ///productSaleCollection.SortDescriptions.Add(new SortDescription("Sales", ListSortDirection.Descending));
            customerSaleCollection = new ListCollectionView(customerSaleMap.Values.ToList());
            ///customerSaleCollection.SortDescriptions.Add(new SortDescription("Sales", ListSortDirection.Descending));

            regionSalesVsGoal = regionSaleMap.Values.ToList();
            categorySalesVsGoal = categorySaleMap.Values.ToList();

            foreach(OpportunityItem opportunity in opportunityCollection)
            {
                OpportunityItemList[opportunity.LevelId].Sales += opportunity.Sales;
            }
        }

        bool FilterByCategoryType(object product)
        {
            Product data = product as Product;
            if (data.Name == "None")
                return false;
            else
                return categoryFilter == CategoryType.All ? true : (product as Product).CategoryId == (int)categoryFilter;
        }
        bool FilterByDateRange(object item)
        {
            if (dateRangeFilter == null)
                return true;
            DateTime date = DateTime.MinValue;
            if (item is Sale)
                date = (item as Sale).Date;
            else if (item is BudgetItem)
                date = (item as BudgetItem).Date;
            else if (item is RegionWiseSale)
                date = (item as RegionWiseSale).Date;
            else if (item is RegionSalesGoal)
                date = (item as RegionSalesGoal).Date;
            else
                date = (item as OpportunityItem).Date;
            return date >= dateRangeFilter.Start && date <= dateRangeFilter.End;
        }
        bool FilterByCampainTaskType(object campainTask)
        {
            var current = campainTask as CampainTaskItem;
            if (current == null)
                return false;
            switch (campainFilter)
            {
                case CampainTaskType.Completed:
                    return current.Complete == 1.0;
                case CampainTaskType.InProgress:
                    return (current.Complete != 1.0 && current.Complete > 0);
                case CampainTaskType.Deferred:
                    return current.Deferred;
                case CampainTaskType.Urgent:
                    return current.Urgent;
            }
            return true;
        }

        double FindProfitFormCurrentSale(Sale sale)
        {
            foreach (BudgetItem budget in budgetCollection)
            {
                if (budget.Date.Year == sale.Date.Year && budget.Date.Month == sale.Date.Month && budget.CategoryId == sale.Product.CategoryId)
                {
                    double precent = sale.Summ / budget.Sales;
                    return budget.Profit * precent;
                }
            }
            return 0;
        }
    }
}
