using DashboardModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
//using System.Windows.Media.Imaging;

namespace DashboardWinForms
{
    public class DateRangeChangedEventArgs : EventArgs
    {
        public DateRange NewValue { get; private set; }

        public DateRangeChangedEventArgs(DateRange dateRange):base()
        {
            NewValue = dateRange;
        }
    }

    public delegate void DateRangeChangedEvent(object sender, DateRangeChangedEventArgs e);

    public enum CategoryType
    {
        All,
        City,
        MultiUtility,
        Sports,
        NewEntry,
    }

    public enum CampainTaskType
    {
        All,
        InProgress,
        Completed,
        Deferred,
        Urgent
    }

    public enum OpportunityLevel
    {
        Hight,
        Medium,
        Low,
        Unlikely
    }

    public class DateRange
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }

    public class SaleGoalItem
    {
        public string Name { get; set; }
        public double Sales { get; set; }
        public double Goal { get; set; }
        public double Profit { get; set; }
    }
    public class SaleItem
    {
        public string Name { get; set; }
        public double Sales { get; set; }
        public double Profit { get; set; }
        public double Id { get; set; }

        public DateTime Date { get; set; }

        public string Month { get { return Date.ToString("MM/yyyy"); } }
    }
    public class RegionSaleItem : SaleItem
    {
        public Point Locat { get; set; }
    }
    public class ProductItem
    {

        public string Label { get; set; }

        public Image ImageSource { get; set; }

        public ProductItem(Product product)
        {
            Label = string.Format(" {0} | {1} | {2} ", product.ToString(), product.Category.ToString(), product.Cost.ToString());
            ImageSource = ImageFromBytes(product.Image);
        }

        internal Image ImageFromBytes(byte[] bytes)
        {
            using (var stream = new MemoryStream(bytes))
                return Image.FromStream(stream);
        }
    }
    public class CampainTaskItem
    {
        public string Subject { get; set; }
        public string AssignTo { get; set; }
        public string OwnedBy { get; set; }

        public double Complete { get; set; }

        public DateTime DueDate { get; set; }

        Sale saleData;

        internal bool Deferred
        {
            get { return saleData.Date > DueDate; }
        }
        internal bool Urgent
        {
            get { return Math.Abs((saleData.Date - saleData.Campaign.Start).Days) < 3; }
        }

        public CampainTaskItem(Sale sale)
        {
            saleData = sale;
            Subject = sale.Campaign.Name;
            AssignTo = sale.Customer.Name;
            OwnedBy = sale.Product.Name;
            DueDate = sale.Campaign.Finish;

            DateTime baseTime = new DateTime(2017, 10, 1);

            double total = (sale.Campaign.Finish - sale.Campaign.Start).Days;
            double current = (baseTime - sale.Campaign.Start).Days;
            Complete = Math.Round(Math.Min(1, Math.Max(0, current / total)), 2);
        }
    }
    public class CurrentPriorBudgetItem
    {
        public double Sales { get; set; }
        public double Profit { get; set; }
        public double ProirProfit { get; set; }
        public double ProirSales { get; set; }

        public DateTime Date { get; set; }
    }
    public class ProductsWiseSaleItem
    {
        public int ID { get; set; }

        public double Sale { get; set; }
        public double Quantity { get; set; }

        public string Category { get; set; }
        public string Product { get; set; }
        public string Region { get; set; }

        public DateTime Date { get; set; }
    }
    public class Opportunity
    {
        public OpportunityLevel Level { get; set; }
        public double Sales { get; set; }        
    }
}