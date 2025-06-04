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
    /// <summary>
    /// The AxisModel class is used by the FlexChart serializer to serialize and deserialize the axes of
    /// FlexChart based controls.
    /// 
    /// Serialization is performed using the FlexChart core interfaces.
    /// Deserialization is peformed using the platform instances of the FlexChart control.
    /// 
    /// </summary>
    [Serializable]
    [DataContract]
    public class AxisModel
    {
        /// <summary>
        /// Simple constructor used to create an instance of the AxisModel class during deserialization.
        /// </summary>
        public AxisModel()
        {
        }

        /// <summary>
        /// Overloaded constructor used create an instance of the AxisModel class during serialization.
        /// The public properties of this class are set by this contructor as they are obtained from the
        /// IAxis interface object passed as the parameter.
        /// </summary>
        /// <param name="ax">Specifies the IAxis interface object to be serialized.</param>
        public AxisModel(IAxis ax)
        {
            Position = ax.Position;
            AxisType = ax.AxisType;
            Origin = ax.Origin;
            Reversed = ax.Reversed;
            Labels = ax.Labels;
            MajorTickMarks = ax.MajorTickMarks;
            MajorGrid = ax.MajorGrid;
            MajorUnit = ax.MajorUnit;
            MinorTickMarks = ax.MinorTickMarks;
            MinorGrid = ax.MinorGrid;
            MinorUnit = ax.MinorUnit;
            LogBase = ax.LogBase;
            AxisLine = ax.AxisLine;
            LabelAlignment = ax.LabelAlignment;
            LabelAngle = ax.LabelAngle;
            Min = ax.Min;
            Max = ax.Max;
            Format = ax.Format;
            Title = ax.Title;
            OverlappingLabels = ax.OverlappingLabels;

            //styles
            Style = StyleSerializer.StyleToString(ax.GetStyle("_"), ax.Chart as IBrushConverter);
            MajorGridStyle = StyleSerializer.StyleToString(ax.GetStyle("_MajorGrid"), ax.Chart as IBrushConverter);
            MinorGridStyle = StyleSerializer.StyleToString(ax.GetStyle("_MinorGrid"), ax.Chart as IBrushConverter);
            TitleStyle = StyleSerializer.StyleToString(ax.GetStyle("_Title"), ax.Chart as IBrushConverter);
        }

        #region Serializable properties

        [DataMember]
        public Position Position { get; set; }

        [DataMember]
        public AxisType AxisType { get; set; }

        [DataMember]
        public double Origin { get; set; }

        [DataMember]
        public bool Reversed { get; set; }

        [DataMember]
        public bool Labels { get; set; }

        [DataMember]
        public TickMark MajorTickMarks { get; set; }

        [DataMember]
        public bool MajorGrid { get; set; }

        [DataMember]
        public double MajorUnit { get; set; }

        [DataMember]
        public string MajorGridStyle { get; set; }

        [DataMember]
        public TickMark MinorTickMarks { get; set; }

        [DataMember]
        public bool MinorGrid { get; set; }

        [DataMember]
        public double MinorUnit { get; set; }

        [DataMember]
        public string MinorGridStyle { get; set; }

        [DataMember]
        public double LogBase { get; set; }

        [DataMember]
        public bool AxisLine { get; set; }

        [DataMember]
        public AxisLabelAlignment LabelAlignment { get; set; }

        [DataMember]
        public double LabelAngle { get; set; }

        [DataMember]
        public double Min { get; set; }

        [DataMember]
        public double Max { get; set; }

        [DataMember]
        public string Format { get; set; }

        [DataMember]
        public string Style { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string TitleStyle { get; set; }

        [DataMember]
        public OverlappingLabels OverlappingLabels { get; set; }

        #endregion

        /// <summary>
        /// AxisModel.Load is used to set the properties of an existing Axis object in a FlexChart based control.
        /// The values used are those stored in an existing AxisModel class object that is typically created and set by
        /// a standard serializer during deserialization.
        /// </summary>
        /// <param name="ax">Specifies an existing instance of an Axis class object.</param>
        /// <param name="am">Specifies an existing instannce of an AxisModel class object created by a
        ///                  a standard serializer during deserialization.</param>
        public static void Load(Axis ax, AxisModel am)
        {
            ax.Position = am.Position;
            ax.Origin = am.Origin;
            ax.Reversed = am.Reversed;
            ax.Labels = am.Labels;
            ax.MajorTickMarks = am.MajorTickMarks;
            ax.MajorGrid = am.MajorGrid;
            ax.MajorUnit = am.MajorUnit;
            ax.MinorTickMarks = am.MinorTickMarks;
            ax.MinorGrid = am.MinorGrid;
            ax.MinorUnit = am.MinorUnit;
            ax.LogBase = am.LogBase;
            ax.AxisLine = am.AxisLine;
            ax.LabelAlignment = am.LabelAlignment;
            ax.LabelAngle = am.LabelAngle;
            ax.Min = am.Min;
            ax.Max = am.Max;
            ax.Format = am.Format;
            ax.Title = am.Title;
            ax.OverlappingLabels = am.OverlappingLabels;

            //// styles
            ((IAxis)ax).SetStyle(StyleSerializer.StyleFromString(am.Style), "_");
            ((IAxis)ax).SetStyle(StyleSerializer.StyleFromString(am.MajorGridStyle), "_MajorGrid");
            ((IAxis)ax).SetStyle(StyleSerializer.StyleFromString(am.MinorGridStyle), "_MinorGrid");
            ((IAxis)ax).SetStyle(StyleSerializer.StyleFromString(am.TitleStyle), "_Title");
        }
    }
}
