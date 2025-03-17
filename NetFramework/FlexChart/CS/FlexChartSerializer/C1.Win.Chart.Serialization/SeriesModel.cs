using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;

namespace C1.Chart.Legacy.Serialization
{
    /// <summary>
    /// The OptionsModel class is used by the FlexChart serializer to serialize and deserialize series of
    /// FlexChart based controls.
    /// 
    /// Serialization is performed using the FlexChart core interfaces.
    /// Deserialization is peformed using the platform instances of the FlexChart control.
    /// 
    /// </summary>
    [Serializable]
    [DataContract]
    public class SeriesModel
    {
        /// <summary>
        /// Simple constructor used to create an instance of the SeriesModel class during deserialization.
        /// </summary>
        public SeriesModel()
        { 
        }

        /// <summary>
        /// Overloaded constructor used create an instance of the SeriesModel class during serialization.
        /// The public properties of this class are set by this contructor as they are obtained from the
        /// IChart interface object passed as the parameter.
        /// </summary>
        /// <param name="series">Specifies the ISeries interface object to be serialized.</param>
        public SeriesModel(ISeries series)
        {
            // simple properties
            ChartType = series.ChartType;
            Name = series.Name;
            SymbolSize = series.SymbolSize;
            SymbolMarker = series.SymbolMarker;
            Visiblity = series.Visibility;

            XAxisIndex = (series.AxisX != null) ? series.Chart.GetAxes().IndexOf(series.AxisX) : 0;
            YAxisIndex = (series.AxisY != null) ? series.Chart.GetAxes().IndexOf(series.AxisY) : 0;

            // data
            X = series.GetValues(1);
            Y = series.GetValues(0);
            Y2 = series.GetValues(2);
            Y3 = series.GetValues(3);
            Y4 = series.GetValues(4);

            // styles
            Style = StyleSerializer.StyleToString(series.GetStyle(), series.Chart as IBrushConverter);
        }

        #region Serializable properties

        [DataMember]
        public ChartType? ChartType { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Style { get; set; }

        [DataMember]
        public SymbolMarker SymbolMarker { get; set; }

        [DataMember]
        public int SymbolSize { get; set; }

        [DataMember]
        public SeriesVisibility Visiblity { get; set; }

        [DataMember]
        public int XAxisIndex { get; set; }
        [DataMember]
        public int YAxisIndex { get; set; }

        [DataMember]
        public double[] X { get; set; }
        [DataMember]
        public double[] Y { get; set; }
        [DataMember]
        public double[] Y2 { get; set; }
        [DataMember]
        public double[] Y3 { get; set; }
        [DataMember]
        public double[] Y4 { get; set; }

        [DataMember]
        public string[] XItems { get; set; }

        #endregion

        /// <summary>
        /// SeriesModel.Load is used to set the properties of an existing Series object in a FlexChart based control.
        /// The values used are those stored in an existing SeriesModel class object that is typically created and set by
        /// a standard serializer during deserialization.
        /// </summary>
        /// <param name="ser">Specifies an existing instance of a ISeries class object.</param>
        /// <param name="sm">Specifies an existing instannce of a SeriesModel class object created by a
        ///                  a standard serializer during deserialization.</param>
        public static void Load(ISeries ser, SeriesModel sm)
        {
            // simple properties
            ser.ChartType = sm.ChartType;
            ser.Name = sm.Name;
            ser.SymbolMarker = sm.SymbolMarker;
            ser.SymbolSize = sm.SymbolSize;
            ser.Visibility = sm.Visiblity;

            // data
            var ds = new List<object>();

            var len = sm.Y != null ? sm.Y.Length : 0;

            for (var i = 0; i < len; i++)
            {
                object o;

                if (sm.X != null)
                {
                    o = new { X = sm.X[i], Y = sm.Y[i] };
                }
                else
                {
                    o = new { Y = sm.Y[i] };
                }

                ds.Add( o);
            }
            ser.BindingX = sm.X != null ? "X" : null;
            ser.Binding = "Y";
            ser.DataSource = ds;

            // styles
            ser.SetStyle(StyleSerializer.StyleFromString(sm.Style), null);
        }
    }
}
