using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardNasdaq.Data
{
    class DataView
    {
        [Flags]
        public enum FilterType
        {
            None = 0,
            Profit = 1,
            Day = 2,
            Month = 4,
            Quarter = 8,

            Year = 16,

            All = Profit | Day | Month | Quarter |  Year
        }

        List<Quote> quotes;
        
        List<Quote> selectedQuotes = new List<Quote>();
        List<QuarterVolume> quarterVolumes;
        List<DaysOutcome> daysOutcome = new List<DaysOutcome>() { new DaysOutcome() { Outcome = "Loss"}, new DaysOutcome() { Outcome = "Profit"}};

        double min;
        double max;

        double minDeltaPct;
        double maxDeltaPct;

        public DataView(List<Quote> quotes)
        {
            this.quotes = quotes;
        }

        public double MinDeltaPct
        {
            get { return minDeltaPct; }
        }
        public double MaxDeltaPct
        {
            get { return maxDeltaPct; }
        }

        public void SetMinMax(double min, double max)
        {
            this.min = max; this.max = min;

            selectedQuotes.Clear();
            for (var i = 0; i < quotes.Count; i++)
            {
                if (quotes[i].Date.ToOADate() > max)
                    break;
                if (quotes[i].Date.ToOADate() >= min)
                    selectedQuotes.Add(quotes[i]);
            }
        }

        public List<YearQuote> GetYearQuotes(FilterType filterType = FilterType.Quarter | FilterType.Day | FilterType.Month )
        {
            var list = new List<YearQuote>();

            for (var i = 0; i < selectedQuotes.Count; i++)
            {
                var q = selectedQuotes[i];

                if (Filter(q, filterType))
                {
                    var y = list.Find((a) => a.Year == q.Date.Year);

                    if (y != null)
                        y.Close = q.Close;
                    else
                        list.Add(new YearQuote() { Year = q.Date.Year, Open = q.Open });
                }
            }

            if (Profit.HasValue)
                list = list.FindAll((yq) => Profit.Value ? yq.DeltaPct >= 0 : yq.DeltaPct < 0);

            if(minDeltaPct == 0)
                minDeltaPct = list.Min((yq) => yq.DeltaPct);
            if(maxDeltaPct == 0)
                maxDeltaPct = list.Max((yq) => yq.DeltaPct);

            return list;
        }

        public List<FluctuationData> GetFluctuations(FilterType filterType = FilterType.All)
        {
            var list = new List<FluctuationData>();
            for (var p = -15; p <= 15; p += 1)
                list.Add(new FluctuationData() { Percent = p });

            for (var i = 0; i < selectedQuotes.Count; i++)
            {
                var q = selectedQuotes[i];
                if (Filter(q, filterType))
                {
                    var p = Math.Round((q.Close - q.Open) / q.Open * 100);

                    var fl = list.Find((d) => d.Percent == p);

                    if (fl != null)
                        fl.Days++;
                }
            }

            list.RemoveAll((fl) => fl.Days == 0);

            return list;
        }

        public List<QuarterVolume> GetQuarterVolume(FilterType filterType = FilterType.Profit | FilterType.Day | FilterType.Year | FilterType.Month)
        {
            if (quarterVolumes == null)
            {
                quarterVolumes = new List<QuarterVolume>();
                for (var i = 0; i < 4; i++)
                    quarterVolumes.Add(new QuarterVolume() { Quarter = "Q" + (i + 1).ToString() });
            }
            else
                foreach (var qv in quarterVolumes)
                    qv.Volume = 0;

            for (var i = 0; i < selectedQuotes.Count; i++)
            {
                var q = selectedQuotes[i];

                if (Filter(q, filterType))
                    quarterVolumes[q.Date.GetQuarter() - 1].Volume += q.Volume;
            }

            var sum = quarterVolumes.Sum((q) => q.Volume);
            foreach (var qv in quarterVolumes)
                qv.Percent = qv.Volume * 100 / sum;

            return quarterVolumes;
        }

        public List<QuarterVolume> GetMonthsVolume(FilterType filterType = FilterType.Quarter | FilterType.Profit | FilterType.Day | FilterType.Year)
        {
            var list = new List<QuarterVolume>();
            var months = System.Globalization.CultureInfo.CurrentUICulture.DateTimeFormat.AbbreviatedMonthNames;
            for (var i = 0; i < 12; i++)
                list.Add(new QuarterVolume() { Quarter = months[i] });

            for (var i = 0; i < selectedQuotes.Count; i++)
            {
                var q = selectedQuotes[i];

                if (Filter(q, filterType))
                    list[q.Date.Month - 1].Volume += q.Volume;
            }

            return list;
        }


        public List<DaysOutcome> GetOutcomes(FilterType filterType = FilterType.Day | FilterType.Year | FilterType.Quarter | FilterType.Month)
        {
            int nprofit = 0, nloss = 0;

            for (var i = 0; i < selectedQuotes.Count; i++)
            {
                var q = selectedQuotes[i];

                if (Filter(q, filterType))
                {
                    if (q.Close > q.Open)
                        nprofit++;
                    else if (q.Close < q.Open)
                        nloss++;
                }
            }

            daysOutcome[0].Days = nloss;
            daysOutcome[0].Percent = (double)nloss / (nloss + nprofit) * 100;
            daysOutcome[1].Days = nprofit;
            daysOutcome[1].Percent = (double)nprofit / (nloss + nprofit) * 100;
            return daysOutcome;
        }

        public List<DaysOutcome> GetDaysOfWeekData( FilterType filterType = FilterType.Profit | FilterType.Quarter | FilterType.Year | FilterType.Month)
        {
            var list = new List<DaysOutcome>();
            var days = System.Globalization.CultureInfo.CurrentUICulture.DateTimeFormat.AbbreviatedDayNames;
            foreach (var day in days)
                list.Add(new DaysOutcome() { Outcome = day });

            for (var i = 0; i < selectedQuotes.Count; i++)
            {
                var q = selectedQuotes[i];
                if(Filter(q, filterType))
                    list[(int)q.Date.DayOfWeek].Days++;
            }

            list.RemoveAll((o) => o.Days == 0);

            return list;
        }

        public List<Quote> GetMonthlyQuotes()
        {
            var list = new List<Quote>();

            list.Add(quotes[0]);
            for (var i = 1; i < quotes.Count; i++)
            {
                var qlast = list.Last();
                var q = quotes[i];
                if (q.Date.Month == qlast.Date.Month)
                {
                    qlast.Volume += q.Volume;
                    qlast.Close = q.Close;
                }
                else
                    list.Add(q);
            }

            return list;
        }

        public int Quarter { get; set; }
        public bool? Profit { get; set; }

        public DayOfWeek? Day { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        bool Filter(Quote q, FilterType filterType)
        {
            var test = true;
            
            if ((filterType & FilterType.Profit) != 0 && Profit.HasValue)
                test = test && Profit.Value ? q.Open <= q.Close : q.Open > q.Close;

            if ((filterType & FilterType.Quarter) != 0 && Quarter > 0)
                test = test && q.Date.GetQuarter() == Quarter;

            if ((filterType & FilterType.Day) != 0 && Day.HasValue)
                test = test && q.Date.DayOfWeek == Day.Value;

            if ((filterType & FilterType.Year) != 0 && Year > 0)
                test = test && q.Date.Year == Year;

            if ((filterType & FilterType.Month) != 0 && Month > 0)
                test = test && q.Date.Month == Month;

            return test;
        }
    }
}
