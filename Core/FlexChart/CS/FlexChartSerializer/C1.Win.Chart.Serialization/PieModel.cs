using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

#if WINFORMS
using System.Drawing;
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
    /// The PieModel class is used by the FlexChart serializer to serialize and deserialize
    /// FlexPie based controls.
    /// 
    /// Serialization is performed using the FlexPie core interfaces.
    /// Deserialization is peformed using the platform instances of the FlexPie control.
    /// 
    /// </summary>
    [Serializable]
    [DataContract]
    public class PieModel
    {
        /// <summary>
        /// Simple constructor used to create an instance of the PieModel class during deserialization.
        /// </summary>
        public PieModel()
        {
        }

        /// <summary>
        /// Overloaded constructor used create an instance of the PieModel class during serialization.
        /// The public properties of this class are set by this contructor as they are obtained from the
        /// IPieChart interface object passed as the parameter.
        /// </summary>
        /// <param name="chart"></param>
        public PieModel(IPieChart chart)
        {
            // simple properties
            Header = chart.Header;
            Footer = chart.Footer;

            // styles
            Style = StyleSerializer.StyleToString(chart.GetStyle(), chart as IBrushConverter);
            HeaderStyle = StyleSerializer.StyleToString(chart.GetStyle("Header"), chart as IBrushConverter);
            FooterStyle = StyleSerializer.StyleToString(chart.GetStyle("Footer"), chart as IBrushConverter);
            HeaderBorderStyle = StyleSerializer.StyleToString(chart.GetStyle("HeaderBorder"), chart as IBrushConverter);
            FooterBorderStyle = StyleSerializer.StyleToString(chart.GetStyle("FooterBorder"), chart as IBrushConverter);
            PlotStyle = StyleSerializer.StyleToString(chart.GetStyle("Plot"), chart as IBrushConverter);
            SelectedStyle = StyleSerializer.StyleToString(chart.GetStyle("Selected"), chart as IBrushConverter);

            InnerRadius = chart.InnerRadius;
            Offset = chart.Offset;
            StartAngle = chart.StartAngle;
            Reversed = chart.Reversed;

            // data
            Values = chart.GetValues();
            Names = chart.GetNames();

            Legend = new LegendModel(chart.Legend, chart);
            DataLabel = new PieDataLabelModel(chart.DataLabel, chart);
        }

        #region Serializable properties

        [DataMember]
        public double InnerRadius { get; set; }

        [DataMember]
        public double Offset { get; set; }

        [DataMember]
        public double StartAngle { get; set; }

        [DataMember]
        public double[] Values { get; set; }

        [DataMember]
        public string[] Names { get; set; }

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
        public LegendModel Legend { get; set; }

        [DataMember]
        public PieDataLabelModel DataLabel { get; set; }

        [DataMember]
        public bool Reversed { get; set; }

        [DataMember]
        public string PlotStyle { get; set; }

        [DataMember]
        public string Style { get; set; }

        [DataMember]
        public string SelectedStyle { get; set; }

        #endregion

        /// <summary>
        /// PieModel.Load is used to set the properties of an existing FlexPie object in a FlexPie based control.
        /// The values used are those stored in an existing PieModel class object that is typically created and set by
        /// a standard serializer during deserialization.
        /// </summary>
        /// <param name="chart">Specifies an existing instance of a FlexPie class object.</param>
        /// <param name="model">Specifies an existing instannce of a PieModel class object created by a
        ///                  a standard serializer during deserialization.</param>
        public static void Load(FlexPie chart, PieModel model)
        {
            // simple properties
#if WINFORMS
            chart.Header.Content = model.Header;
            chart.Footer.Content = model.Footer;
#endif

#if WPF
            chart.Header = model.Header;
            chart.Footer = model.Footer;
#endif

            // styles
            ((IStyleProvider)chart).SetStyle(StyleSerializer.StyleFromString(model.Style), null);
            ((IStyleProvider)chart).SetStyle(StyleSerializer.StyleFromString(model.HeaderStyle), "Header");
            ((IStyleProvider)chart).SetStyle(StyleSerializer.StyleFromString(model.FooterStyle), "Footer");
            ((IStyleProvider)chart).SetStyle(StyleSerializer.StyleFromString(model.HeaderBorderStyle), "HeaderBorder");
            ((IStyleProvider)chart).SetStyle(StyleSerializer.StyleFromString(model.FooterBorderStyle), "FooterBorder");
            ((IStyleProvider)chart).SetStyle(StyleSerializer.StyleFromString(model.PlotStyle), "Plot");
            ((IStyleProvider)chart).SetStyle(StyleSerializer.StyleFromString(model.SelectedStyle), "Selected");
            chart.InnerRadius = model.InnerRadius;
            chart.Offset = model.Offset;
            chart.StartAngle = model.StartAngle;
            chart.Reversed = model.Reversed;

            double[] values = model.Values;
            string[] names = model.Names;

            List<FlexPieSlice> slices = new List<FlexPieSlice>();
            for (int ps = 0; ps < values.Length; ps++)
            {
                FlexPieSlice slice = new FlexPieSlice(values[ps], names[ps]);
                slices.Add(slice);
            }
            chart.Binding = "Value";
            chart.BindingName = "Name";

#if WINFORMS
            chart.DataSource = slices;
#endif
#if WPF
            chart.ItemsSource = slices;
#endif

            LegendModel.Load(chart, model.Legend);
            PieDataLabelModel.Load(chart.DataLabel, model.DataLabel);
        }
    }

    /// <summary>
    /// The PieDataLabelModel class is used by the FlexChart serializer to serialize and deserialize labels of
    /// FlexPie based controls.
    /// 
    /// Serialization is performed using the FlexChart core interfaces.
    /// Deserialization is peformed using the platform instances of the FlexPie control.
    /// 
    /// </summary>
    [Serializable]
    [DataContract]
    public class PieDataLabelModel
    {
        /// <summary>
        /// Simple constructor used to create an instance of the PieDataLabelModel class during deserialization.
        /// </summary>
        public PieDataLabelModel() {}

        /// <summary>
        /// Overloaded constructor used create an instance of the PieDataLabelModel class during serialization.
        /// The public properties of this class are set by this contructor as they are obtained from the
        /// IPieDataLabel interface object passed as the parameter.
        /// </summary>
        /// <param name="dataLabel">Specifies the IPieDataLabel interface object to be serialized.</param>
        /// <param name="pieChart">Specifies the IPieChart interface object of the parent IPieChart object being serialized.</param>
        public PieDataLabelModel(IPieDataLabel dataLabel, IPieChart pieChart)
        {
            Border = dataLabel.Border;
            ConnectingLine = dataLabel.ConnectingLine;
            Offset = dataLabel.Offset;
            Content = dataLabel.Content;
            Position = dataLabel.Position;


            Style = StyleSerializer.StyleToString(dataLabel.GetStyle("_"), pieChart as IBrushConverter);
            BorderStyle = StyleSerializer.StyleToString(dataLabel.GetStyle("_Border"), pieChart as IBrushConverter);
        }

        #region Serializable Properties

        [DataMember]
        public bool Border { get; set; }
        
        [DataMember]
        public bool ConnectingLine { get; set; }
        
        [DataMember]
        public string Content { get; set; }
        
        [DataMember]
        public int Offset { get; set; }

        [DataMember]
        public PieLabelPosition Position { get; set; }

        [DataMember]
        public string Style { get; set; }

        [DataMember]
        public string BorderStyle { get; set; }

        #endregion

        /// <summary>
        /// DataLabelModel.Load is used to set the properties of an existing DataLabel object in a FlexChart based control.
        /// The values used are those stored in an existing DataLabelModel class object that is typically created and set by
        /// a standard serializer during deserialization.
        /// </summary>
        /// <param name="pieDataLabel">Specifies an existing instance of a PieDataLabel class object.</param>
        /// <param name="pieDataLabelModel">Specifies an existing instannce of a PieDataLabelModel class object created by a
        ///                  a standard serializer during deserialization.</param>
        public static void Load(PieDataLabel pieDataLabel, PieDataLabelModel pieDataLabelModel)
        {
            if (pieDataLabelModel == null)
                pieDataLabelModel = new PieDataLabelModel();

            pieDataLabel.Border = pieDataLabelModel.Border;
            pieDataLabel.ConnectingLine = pieDataLabelModel.ConnectingLine;
            pieDataLabel.Content = pieDataLabelModel.Content;
            pieDataLabel.Offset = pieDataLabelModel.Offset;
            pieDataLabel.Position = pieDataLabelModel.Position;

            ((IPieDataLabel)pieDataLabel).SetStyle(StyleSerializer.StyleFromString(pieDataLabelModel.Style), "_");
            ((IPieDataLabel)pieDataLabel).SetStyle(StyleSerializer.StyleFromString(pieDataLabelModel.BorderStyle), "_Border");
        }
    }
}
