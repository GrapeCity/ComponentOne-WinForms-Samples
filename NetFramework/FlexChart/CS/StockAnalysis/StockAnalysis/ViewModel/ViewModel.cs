using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Drawing;

namespace StockAnalysis.ViewModel
{
    public struct IndicatorPalettes
    {
        public static Color Red = Color.FromArgb(255, 244, 67, 54);
        public static Color Pink = Color.FromArgb(255, 233, 30, 99);

        public static Color Purple = Color.FromArgb(255, 156, 39, 176);
        public static Color DeepPurple = Color.FromArgb(255, 103, 58, 183);
        public static Color Indigo = Color.FromArgb(255, 64, 82, 180);
        public static Color Blue = Color.FromArgb(255, 34, 150, 243);
        public static Color LightBlue = Color.FromArgb(255, 4, 168, 244);
        public static Color Cyan = Color.FromArgb(255, 2, 188, 212);
        public static Color Teal = Color.FromArgb(255, 0, 149, 136);
        public static Color Green = Color.FromArgb(255, 76, 175, 80);
        public static Color LightGreen = Color.FromArgb(255, 138, 195, 75);
        public static Color Lime = Color.FromArgb(255, 205, 220, 57);

        public static Color Yellow = Color.FromArgb(255, 255, 235, 60);
        public static Color Amber = Color.FromArgb(255, 255, 193, 7);
        public static Color Orange = Color.FromArgb(255, 255, 155, 3);
        public static Color DeepOrange = Color.FromArgb(255, 255, 87, 34);
        public static Color Brown = Color.FromArgb(255, 121, 85, 72);
        public static Color Grey = Color.FromArgb(255, 158, 158, 158);
        public static Color BlueGrey = Color.FromArgb(255, 96, 125, 139);

        ///00B050   ff1d25
        public static Color StockGreen = Color.FromArgb(255, 00, 176, 80);
        public static Color StockRed = Color.FromArgb(255, 255, 29, 37);

        public static Color LogoBlue = Color.FromArgb(255, 66, 133, 244);
        public static Color LogoYellow = Color.FromArgb(255, 251, 188, 5);
        public static Color Red100 = Color.FromArgb(255, 244, 199, 195);
        public static Color Red300 = Color.FromArgb(255, 230, 124, 115);
        public static Color Red500 = Color.FromArgb(255, 219, 68, 55);
        public static Color Red700 = Color.FromArgb(255, 197, 57, 41);
        public static Color Green100 = Color.FromArgb(255, 183, 225, 205);
        public static Color Green300 = Color.FromArgb(255, 87, 187, 138);
        public static Color Green500 = Color.FromArgb(255, 15, 157, 88);
        public static Color Green700 = Color.FromArgb(255, 11, 128, 67);
        public static Color Blue100 = Color.FromArgb(255, 198, 218, 252);
        public static Color Blue300 = Color.FromArgb(255, 123, 170, 247);
        public static Color Blue500 = Color.FromArgb(255, 66, 133, 244);
        public static Color Blue700 = Color.FromArgb(255, 51, 103, 214);
        public static Color Yellow100 = Color.FromArgb(255, 252, 232, 178);
        public static Color Yellow300 = Color.FromArgb(255, 247, 203, 77);
        public static Color Yellow500 = Color.FromArgb(255, 244, 180, 0);
        public static Color Yellow700 = Color.FromArgb(255, 240, 147, 0);
        public static Color Grey100 = Color.FromArgb(255, 245, 245, 245);
        public static Color Grey300 = Color.FromArgb(255, 224, 224, 224);
        public static Color Grey500 = Color.FromArgb(255, 158, 158, 158);
        public static Color Grey700 = Color.FromArgb(255, 97, 97, 97);
        public static Color Grey800 = Color.FromArgb(255, 68, 68, 68);
        public static Color PaperWhite700 = Color.FromArgb(255, 211, 211, 211);
        public static Color PaperWhite800 = Color.FromArgb(255, 227, 227, 227);
        public static Color PaperWhite900 = Color.FromArgb(255, 243, 243, 243);
        public static Color PaperWhite1000 = Color.FromArgb(255, 255, 255, 255);
    }

    public class ViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private ViewModel()
        {
            Data.DataService.GetQuotesAsync(Symbols,
                (o, e) =>
                {
                    Quotes = e.Quotes;
                }
                );
        }
        
        private static ViewModel instance;
        public static ViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ViewModel();
                }
                return instance;
            }
        }

        private Dictionary<string, string> symbols;
        public Dictionary<string, string> Symbols
        {
            get
            {
                if (symbols == null)
                {
                    symbols = new Dictionary<string, string>();
                    symbols.Add("AAPL", "Apple");
                    symbols.Add("MSFT", "Microsoft");
                    symbols.Add("INTC", "Intel");
                    symbols.Add("CSCO", "Cisco");
                    symbols.Add("GOOG", "Google");
                    symbols.Add("AMZN", "Amazon");
                    symbols.Add("EBAY", "eBay");
                    symbols.Add("DVMT", "Dell");
                    symbols.Add("ORCL", "Oracle");
                    symbols.Add("VOD", "Vodafone");
                }
                return symbols;
            }
        }

        private IEnumerable<Object.Quote> quotes;
        public IEnumerable<Object.Quote> Quotes
        {
            get
            {
                return quotes;
            }
            private set
            {
                quotes = value;
                OnPropertyChanged("Quotes");
            }
        }

        private bool isLoaded = false;
        public bool IsLoaded
        {
            get
            {
                return isLoaded;
            }
            private set
            {
                isLoaded = value;
                OnPropertyChanged("IsLoaded");
            }
        }

        private Object.Quote _currentQuote;
        public Object.Quote CurrentQuote
        {
            get
            {
                return _currentQuote;
            }
            set
            {
                _currentQuote = value;

                if ((LowerValue == 0 && UpperValue == 0) || (LowerValue == null && UpperValue == null))
                {
                    UpperValue = this.CurrentQuote.Data.Count() - 1;
                    LowerValue = (UpperValue > 60) ? UpperValue - 60 : 0;
                    IsLoaded = true;
                }

                OnPropertyChanged("CurrentQuote");
            }

        }
        
        private double? _lowValue = null;
        public double? LowerValue
        {
            get
            {
                return _lowValue;
            }
            set
            {
                _lowValue = value;
                OnPropertyChanged("LowerValue");
            }
        }

        private double? _upperValue = null;
        public double? UpperValue
        {
            get
            {
                return _upperValue;
            }
            set
            {
                _upperValue = value;
                OnPropertyChanged("UpperValue");
            }
        }

        private C1.Chart.Finance.FinancialChartType chartType = C1.Chart.Finance.FinancialChartType.Candlestick;
        public C1.Chart.Finance.FinancialChartType ChartType
        {
            get { return this.chartType; }
            set
            {
                if (this.chartType != value)
                {
                    this.chartType = value;
                    OnPropertyChanged("ChartType");
                }
            }
        }

        private System.Collections.ObjectModel.ObservableCollection<Type> indicatorCharts;
        public System.Collections.ObjectModel.ObservableCollection<Type> IndicatorCharts
        {
            get
            {
                if (indicatorCharts == null)
                {
                    indicatorCharts = new System.Collections.ObjectModel.ObservableCollection<Type>();
                    indicatorCharts.CollectionChanged += (o, e)=>
                    {
                        OnPropertyChanged("IndicatorCharts");
                    };
                }
                return this.indicatorCharts;
            }
        }

        private System.Collections.ObjectModel.ObservableCollection<Type> overlayTypes;
        public System.Collections.ObjectModel.ObservableCollection<Type> OverlayTypes
        {
            get
            {
                if (overlayTypes == null)
                {
                    overlayTypes = new System.Collections.ObjectModel.ObservableCollection<Type>();
                    overlayTypes.CollectionChanged += (o, e) =>
                    {
                        OnPropertyChanged("OverlayTypes");
                    };
                }
                return overlayTypes;
            }
        }

        private System.Collections.ObjectModel.ObservableCollection<Type> customIndicators;
        public System.Collections.ObjectModel.ObservableCollection<Type> CustomIndicators
        {
            get
            {
                if (customIndicators == null)
                {
                    customIndicators = new System.Collections.ObjectModel.ObservableCollection<Type>();
                    customIndicators.CollectionChanged += (o, e) =>
                    {
                        OnPropertyChanged("CustomIndicators");
                    };
                }
                return customIndicators;
            }
        }

    }
}
