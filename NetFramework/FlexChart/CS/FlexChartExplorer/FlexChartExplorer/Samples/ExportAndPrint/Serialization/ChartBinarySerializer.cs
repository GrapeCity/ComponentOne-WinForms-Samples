using System;
using System.Text.Json.Serialization;
using System.Text.Json;
using C1.Chart;
using C1.Win.Chart;
using C1.Chart.Serialization;
using MessagePack;

namespace FlexChartExplorer.Samples.ExportAndPrint.Serialization
{
    static class ChartBinarySerializer
    {
        public static byte[] SerializeToBinary(this IChartBase chart, bool serializeData = true)
        {
            if (chart is FlexChart)
                return MessagePackSerializer.Serialize(new ChartModel(chart as FlexChart, serializeData));
            else
                return MessagePackSerializer.Serialize(new PieModel(chart as FlexPie, serializeData));
        }

        public static void DeserializeFromBinary(this IChartBase chart, byte[] bytes)
        {
            if (chart is FlexChart)
            {
                var model = MessagePackSerializer.Deserialize<ChartModel>(bytes);
                ChartModel.Load(chart, model);
            }
            else
            {
                var model = MessagePackSerializer.Deserialize<PieModel>(bytes);
                PieModel.Load(chart, model);
            }
        }
    }
}
