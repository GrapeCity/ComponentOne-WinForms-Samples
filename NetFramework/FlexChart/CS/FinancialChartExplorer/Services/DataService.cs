using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;

namespace FinancialChartExplorer.Services
{
    public class DataService
    {
        List<Company> _companies = new List<Company>();

        public DataService()
        {
            _companies.Add(new Company() { Symbol = "box", Name = "Box Inc" });
            _companies.Add(new Company() { Symbol = "fb", Name = "Facebook Inc" });
            _companies.Add(new Company() { Symbol = "goog", Name = "Google Inc" });
            _companies.Add(new Company() { Symbol = "twtr", Name = "Twitter Inc" });
            _companies.Add(new Company() { Symbol = "wix", Name = "Wix.Com Ltd" });
            _companies.Add(new Company() { Symbol = "zen", Name = "Zendesk Inc" });
        }

        public List<Company> GetCompanies()
        {
            return _companies;
        }

        public List<Quote> GetSymbolData(string symbol, int nitems = 0)
        {
            string path = string.Format("FinancialChartExplorer.Resources.{0}.json", symbol);
            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(path);
            var ser = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(Quote[]));
            var data = (Quote[])ser.ReadObject(stream);
            return data.ToList();
        }

        public List<Annotation> GetAnnotations(string symbol)
        {
            string path = string.Format("FinancialChartExplorer.Resources.{0}.json", symbol);
            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(path);
            var ser = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(Annotation[]));
            var data = (Annotation[])ser.ReadObject(stream);
            return data.ToList();
        }

        public Range FindRenderedYRange(List<Quote> data, double xmin, double xmax)
        {
            Quote item;
            double ymin = double.NaN;
            double ymax = double.NaN;

            for (int i = 0; i < data.Count; i++)
            {
                item = data[i];
                if (xmin > i || i > xmax)
                {
                    continue;
                }
                if (double.IsNaN(ymax) || item.high > ymax)
                {
                    ymax = item.high;
                }
                if (double.IsNaN(ymin) || item.low < ymin)
                {
                    ymin = item.low;
                }
            }

            return new Range() { Min = ymin, Max = ymax };
        }

        public Range FindApproxRange(double min, double max, double percent)
        {
            var range = new Range();
            range.Max = max;
            range.Min = (max - min) * (1 - percent) + min;
            return range;
        }

        static DataService _ds;
        public static DataService GetService()
        {
            if (_ds == null)
                _ds = new DataService();
            return _ds;
        }
    }

    public class Quote
    {
        public string date { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public double open { get; set; }
        public double close { get; set; }
        public double volume { get; set; }

        public DateTime Date 
        {
            get { return DateTime.ParseExact(date.ToString(), "MM/dd/yy", System.Globalization.CultureInfo.InvariantCulture); }
        }
    }

    public class Company
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
    }

    [DataContract]
    public class Annotation
    {
        [DataMember(Name = "title")]
        public string Title
        {
            get; set;
        }

        [DataMember(Name = "description")]
        public string Description
        {
            get; set;
        }

        [DataMember(Name = "publicationDate")]
        public string PublicationDate
        {
            get; set;
        }

        [DataMember(Name = "dataIndex")]
        public int DataIndex
        {
            get; set;
        }
    }

    public class Range
    {
        public double Min { get; set; }
        public double Max { get; set; }
    }
}
