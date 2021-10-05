using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardNasdaq.Data
{
    public abstract class ModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class Quote
    {
        public DateTime Date { get; set; }
        public double Open { get; set; }
        public double Close { get; set; }
        public double Volume { get; set; }
    }

    public class YearQuote
    {
        public int Year { get; set; }
        public double Open { get; set; }
        public double Close { get; set; }

        public double Delta
        {
            get { return Close - Open; }
        }

        public double DeltaPct
        {
            get { return Delta / Open; }
        }

        public double DeltaPctAbs
        {
            get { return Math.Abs(DeltaPct); }
        }
    }

    public class QuarterVolume : ModelBase
    {
        double volume;
        public string Quarter { get; set; }
        public double Volume 
        {
            get { return volume; }
            set 
            {
                if (value != volume)
                {
                    volume = value;
                    OnPropertyChanged("Volume");
                }
            } 
        }
        public double Percent { get; set; }
    }


    public class DaysOutcome : ModelBase
    {
        int days;
        double percent;
        public string Outcome { get; set; }
        public int Days 
        {
            get { return days; }
            set 
            {
                if (value != days)
                {
                    days = value;
                    OnPropertyChanged("Days");
                }
            } 
        }
        public double Percent
        {
            get { return percent; }
            set
            {
                if (value != percent)
                {
                    percent = value;
                    OnPropertyChanged("Percent");
                }
            }
        }

    }

    public class FluctuationData
    {
        public int Percent { get; set; }
        public int Days { get; set; }
    }
}
