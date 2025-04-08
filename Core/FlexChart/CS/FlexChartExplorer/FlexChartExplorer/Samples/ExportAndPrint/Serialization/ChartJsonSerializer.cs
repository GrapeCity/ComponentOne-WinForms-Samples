using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using C1.Win.Chart;
using C1.Chart.Serialization;
using C1.Chart;

namespace FlexChartExplorer.Samples.ExportAndPrint.Serialization
{
    static class ChartJsonSerializer
    {
        public static string SerializeToJson(this IChartBase chart, bool serializeData = true)
        {
            var options = new JsonSerializerOptions
            {
                NumberHandling = JsonNumberHandling.AllowNamedFloatingPointLiterals, // handle NaN
                WriteIndented = true, // nice formatting
            };
            if (chart is FlexChart)
                return JsonSerializer.Serialize(new ChartModel(chart as FlexChart), options);
            else
                return JsonSerializer.Serialize(new PieModel(chart as FlexPie), options);
        }

        public static void DeserializeFromJson(this IChartBase chart, string chartString)
        {
            var opts = new JsonSerializerOptions
            {
                NumberHandling = JsonNumberHandling.AllowNamedFloatingPointLiterals, // handle NaN
            };

            if (chart is FlexChart)
            {
                ChartModel model = JsonSerializer.Deserialize(chartString, typeof(ChartModel), opts) as ChartModel;
                ChartModel.Load(chart, model);
            }
            else
            {
                PieModel model = JsonSerializer.Deserialize(chartString, typeof(PieModel), opts) as PieModel;
                PieModel.Load(chart, model);
            }
        }
    }
}
