using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlexChartExplorer.Data
{
    public class Country
    {
        public string Name { get; set; }
        public double Sales { get; set; }
        public double Downloads { get; set; }
        public double Expenses { get; set; }
    }
    public class CountryPopulation
    {
        public string Name { get; set; }
        public double MalePopulation { get; set; }
        public double FemalePopulation { get; set; }
        public double EducatedMale { get; set; }
        public double EducatedFemale { get; set; }
        public double TotalPopulation
        {
            get
            {
                return MalePopulation + FemalePopulation;
            }
        }

        public double IlliterateMale
        {
            get { return MalePopulation - EducatedMale; }
        }

        public double IlliterateFemale
        {
            get { return FemalePopulation - EducatedFemale; }
        }

        public double EducatedPopulation
        {
            get
            {
                return EducatedMale + EducatedFemale;
            }
        }
    }
    public class CountryGDP
    {
        public string Country { get; set; }
        public string Continent { get; set; }
        public double CurrentPrices { get; set; }
        public double PPPValuation { get; set; }
        public CountryGDP[] Items { get; set; }
        public CountryGDP() { }
        public CountryGDP(string country, string continent, double currentPrices, double pppValuation)
        {
            Country = country;
            Continent = continent;
            CurrentPrices = currentPrices;
            PPPValuation = pppValuation;
        }
    }
    public class CountrySalesOrders
    {
        private List<Order> _orders;
        public string Name { get; set; }
        public double TotalAmount
        {
            get
            {
                return Orders.Sum(x => x.Amount);
            }
        }
        public List<Order> Orders
        {
            get
            {
                if (_orders == null)
                    _orders = new List<Order>();
                return _orders;
            }
        }
    }
    public class Order
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
