using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;

using C1.Chart;

#if WINFORMS
using C1.Win.Chart;
#endif
#if WPF
using C1.WPF.Chart;
#endif

namespace C1.Chart.Serialization
{
    /// <summary>
    /// The LegendModel class is used by the FlexChart serializer to serialize and deserialize legends of
    /// FlexChart based controls.
    /// 
    /// Serialization is performed using the FlexChart core interfaces.
    /// Deserialization is peformed using the platform instances of the FlexChart control.
    /// 
    /// </summary>
    [Serializable]
    [DataContract]
    public class LegendModel
    {
        /// <summary>
        /// Simple constructor used to create an instance of the LegendModel class during deserialization.
        /// </summary>
        public LegendModel()
        {
        }

        /// <summary>
        /// Overloaded constructor used create an instance of the LegendModel class during serialization.
        /// The public properties of this class are set by this contructor as they are obtained from the
        /// ILegend interface object passed as the parameter.
        /// </summary>
        /// <param name="legend">Specifies the ILegend interface object to be serialized.</param>
        /// <param name="chart">Specifies the IChart interface object of the parent IChart object being serialized.</param>
        public LegendModel(ILegend legend, IChartBase chart)
        {
            Position = legend.Position;
            Orientation = legend.Orientation;
            Title = legend.Title;
            Reversed = legend.Reversed;

#if WINFORMS
            Style = StyleSerializer.StyleToString(legend.GetStyle("_"), chart as IBrushConverter);
            TitleStyle = StyleSerializer.StyleToString(legend.GetStyle("_Title"), chart as IBrushConverter);
#endif
#if WPF
            Style = StyleSerializer.StyleToString(legend.GetStyle(), chart as IBrushConverter);
            TitleStyle = StyleSerializer.StyleToString(legend.GetStyle("Title"), chart as IBrushConverter);
#endif
        }

        #region Serializable properties

        [DataMember]
        public Position Position { get; set; }

        [DataMember]
        public Orientation Orientation { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Style { get; set; }

        [DataMember]
        public string TitleStyle { get; set; }

        [DataMember]
        public bool Reversed { get; set; }

        #endregion

        /// <summary>
        /// LegendModel.Load is used to set the properties of an existing Legend object in a FlexChart based control.
        /// The values used are those stored in an existing LegendModel class object that is typically created and set by
        /// a standard serializer during deserialization.
        /// </summary>
        /// <param name="legend">Specifies an existing instance of a Legend class object.</param>
        /// <param name="legendModel">Specifies an existing instannce of a LegendModel class object created by a
        ///                  a standard serializer during deserialization.</param>
        public static void Load(FlexChartBase chart, LegendModel legendModel)
        {
#if WINFORMS
            chart.Legend.Position = legendModel.Position;
            chart.Legend.Orientation = legendModel.Orientation;
            chart.Legend.Title = legendModel.Title;
            chart.Legend.Reversed = legendModel.Reversed;

            ((ILegend)chart.Legend).SetStyle(StyleSerializer.StyleFromString(legendModel.Style), "_");
            ((ILegend)chart.Legend).SetStyle(StyleSerializer.StyleFromString(legendModel.TitleStyle), "_TitleStyle");
#endif
#if WPF
            chart.LegendPosition = legendModel.Position;
            chart.LegendOrientation = legendModel.Orientation;
            chart.LegendTitle = legendModel.Title;
            chart.LegendReversed = legendModel.Reversed;

            // Legend styles are actually part of the chart object model and must be set there.
            chart.LegendStyle = new ChartStyle(StyleSerializer.StyleFromString(legendModel.Style));
            chart.LegendTitleStyle = new ChartStyle(StyleSerializer.StyleFromString(legendModel.TitleStyle));
#endif
        }
    }

}
