using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;

#if WINFORMS
using C1.Win.Chart;
#endif
#if WPF
using C1.WPF.Chart;
#endif

namespace C1.Chart.Legacy.Serialization
{
#if WPF
    using FlexChart = C1FlexChart;
    using FlexPie = C1FlexPie;
#endif

    /// <summary>
    /// The ChartModel class is used by the FlexChart serializer to serialize and deserialize
    /// FlexChart based controls.
    /// 
    /// Serialization is performed using the FlexChart core interfaces.
    /// Deserialization is peformed using the platform instances of the FlexChart control.
    /// 
    /// </summary>
    [Serializable]
    [DataContract]
    public class ChartModel
    {
        /// <summary>
        /// Simple constructor used to create an instance of the ChartModel class during deserialization.
        /// </summary>
        public ChartModel()
        {
        }

        /// <summary>
        /// Overloaded constructor used create an instance of the ChartModel class during serialization.
        /// The public properties of this class are set by this contructor as they are obtained from the
        /// IChart interface object passed as the parameter.
        /// </summary>
        /// <param name="chart">Specifies the IChart interface object to be serialized.</param>
        /// <remarks>
        /// The ChartModel class contains as serializable properties all other FlexChart objects appropriate
        /// for serializing the FlexChart control, it is only necessary to request serialization of the
        /// IChart object to store all information about the chart.  Subobjects do need not be serialized separately.
        /// </remarks>
        public ChartModel(IChart chart)
        {
            // simple properties
            ChartType = chart.ChartType;
            Header = chart.Header;
            Footer = chart.Footer;

            Stacking = chart.Stacking;

            {   // capture the XItems used for Axis Labeling.
                List<object> oItems = chart.GetXItems();
                if (oItems != null && oItems.Count > 0 && oItems[0].GetType() == typeof(string))
                {
                    List<string> sItems = new List<string>();
                    foreach (object o in oItems)
                        sItems.Add(o as string);
                    XItems = sItems;
                }
            }

            // styles
            Style = StyleSerializer.StyleToString(chart.GetStyle(), chart as IBrushConverter);
            HeaderStyle = StyleSerializer.StyleToString(chart.GetStyle("Header"), chart as IBrushConverter);
            FooterStyle = StyleSerializer.StyleToString(chart.GetStyle("Footer"), chart as IBrushConverter);
            HeaderBorderStyle = StyleSerializer.StyleToString(chart.GetStyle("HeaderBorder"), chart as IBrushConverter);
            FooterBorderStyle = StyleSerializer.StyleToString(chart.GetStyle("FooterBorder"), chart as IBrushConverter);
            PlotStyle = StyleSerializer.StyleToString(chart.GetStyle("Plot"), chart as IBrushConverter);
            SelectedStyle = StyleSerializer.StyleToString(chart.GetStyle("Selected"), chart as IBrushConverter);

            // data
            Series = new List<SeriesModel>();
            foreach (var ser in chart.Series)
                Series.Add(new SeriesModel(ser));

            // axes
            // 
            Axes = new List<AxisModel>();
            foreach (IAxis ax in chart.GetAxes())
                Axes.Add(new AxisModel(ax));
            // legend
            //
            Legend = new LegendModel(chart.Legend, chart);

            // ChartOptions
            Options = new OptionsModel(chart);

            // DataLabel
            DataLabel = new DataLabelModel(chart.DataLabel, chart);
        }

        #region Serializable properties

        [DataMember]
        public ChartType ChartType { get; set; }
        
        [DataMember]
        public string Footer { get; set; }

        [DataMember]
        public string FooterStyle { get; set; }

        [DataMember]
        public string FooterBorderStyle { get; set; }

        [DataMember]
        public string Header { get; set; }

        [DataMember]
        public string HeaderStyle { get; set; }

        [DataMember]
        public string HeaderBorderStyle { get; set; }

        [DataMember]
        public Stacking Stacking { get; set; }

        [DataMember]
        public List<SeriesModel> Series { get; set; }

        [DataMember]
        public List<AxisModel> Axes { get; set; }
        [DataMember]
        public LegendModel Legend { get; set; }

        [DataMember]
        public DataLabelModel DataLabel { get; set; }

        [DataMember]
        public List<string> XItems { get; set; }

        [DataMember]
        public string BindingX { get; set; }

        [DataMember]
        public string Style { get; set; }

        [DataMember]
        public string PlotStyle { get; set; }

        [DataMember]
        public string SelectedStyle { get; set; }

        [DataMember]
        public OptionsModel Options { get; set; }

        #endregion

        /// <summary>
        /// ChartModel.Load is used to set the properties of an existing FlexChart object in a FlexChart based control.
        /// The values used are those stored in an existing ChartModel class object that is typically created and set by
        /// a standard serializer during deserialization.
        /// </summary>
        /// <param name="chart">Specifies an existing instance of a FlexChart class object.</param>
        /// <param name="model">Specifies an existing instannce of a ChartModel class object created by a
        ///                  a standard serializer during deserialization.</param>
        public static void Load(FlexChart chart, ChartModel model)
        {
            // simple properties
            chart.ChartType = model.ChartType;
#if WINFORMS
            chart.Header.Content = model.Header;
            chart.Footer.Content = model.Footer;
#endif

#if WPF
            chart.Header = model.Header;
            chart.Footer = model.Footer;
#endif
            chart.Stacking = model.Stacking;

            if (model.XItems != null && model.XItems.Count > 0)
            {
                chart.BindingX = "X";
                List<object> ds = new List<object>();
                foreach (string s in model.XItems)
                    ds.Add( new { X = s } );
#if WINFORMS
                chart.DataSource = ds;
#endif
#if WPF
                chart.ItemsSource = ds;
#endif

            }

            // Load Axes before series so they are available.
            List<Axis> axes = new List<Axis>() { chart.AxisX, chart.AxisY };
            for (int iax = 2; iax < model.Axes.Count; iax++)
                axes.Add(new Axis());

            for (int iax = 0; iax < model.Axes.Count; iax++)
                AxisModel.Load(axes[iax], model.Axes[iax]);

            // data
            var series = chart.Series;
            series.Clear();
            foreach (var sm in model.Series)
            {
                var ser = new Series();
                series.Add(ser);
                SeriesModel.Load(ser, sm);

                if (sm.XAxisIndex > 0 && sm.XAxisIndex < axes.Count)
                    ser.AxisX = axes[sm.XAxisIndex];

                if (sm.YAxisIndex > 0 && sm.YAxisIndex < axes.Count)
                    ser.AxisY = axes[sm.YAxisIndex];
            }

            // styles
            ((IStyleProvider)chart).SetStyle(StyleSerializer.StyleFromString(model.Style), null);
            ((IStyleProvider)chart).SetStyle(StyleSerializer.StyleFromString(model.HeaderStyle), "Header");
            ((IStyleProvider)chart).SetStyle(StyleSerializer.StyleFromString(model.FooterStyle), "Footer");
            ((IStyleProvider)chart).SetStyle(StyleSerializer.StyleFromString(model.HeaderBorderStyle), "HeaderBorder");
            ((IStyleProvider)chart).SetStyle(StyleSerializer.StyleFromString(model.FooterBorderStyle), "FooterBorder");
            ((IStyleProvider)chart).SetStyle(StyleSerializer.StyleFromString(model.PlotStyle), "Plot");
            ((IStyleProvider)chart).SetStyle(StyleSerializer.StyleFromString(model.SelectedStyle), "Selected");

            // legend
            LegendModel.Load(chart, model.Legend);

            // ChartOptions
            OptionsModel.Load(chart.Options, model.Options);

            // DataLabel
            DataLabelModel.Load(chart.DataLabel, model.DataLabel);
        }
    }
}
