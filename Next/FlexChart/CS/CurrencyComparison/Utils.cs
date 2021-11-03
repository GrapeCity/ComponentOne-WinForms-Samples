using C1.Chart;
using CurrencyComparison.Model;
using System.IO;
using System.Reflection;

namespace CurrencyComparison
{
    class Utils
    {
        public static bool IsVisible(ChartSeries series)
        {
            return (series.Visibility == SeriesVisibility.Plot || series.Visibility == SeriesVisibility.Visible);
        }

        public static string Read(string fileName)
        {
            string text;
            var csv = string.Format("CurrencyComparison.{0}", fileName);
            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(csv);
            if (stream != null)
            {
                using (var reader = new StreamReader(stream))
                {
                    text = reader.ReadToEnd();
                }
            }
            else
            {
                var filePath = string.Format("../../{0}", fileName);
                text = File.ReadAllText(filePath);
            }
            return text;
        }
    }
}
