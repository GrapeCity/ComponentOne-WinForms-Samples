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
    /// The OptionsModel class is used by the FlexChart serializer to serialize and deserialize options of
    /// FlexChart based controls.
    /// 
    /// Serialization is performed using the FlexChart core interfaces.
    /// Deserialization is peformed using the platform instances of the FlexChart control.
    /// 
    /// </summary>
    [Serializable]
    [DataContract]
    public class OptionsModel
    {
        /// <summary>
        /// Simple constructor used to create an instance of the OptionsModel class during deserialization.
        /// </summary>
        public OptionsModel()
        {
        }

        /// <summary>
        /// Overloaded constructor used create an instance of the OptionsModel class during serialization.
        /// The public properties of this class are set by this contructor as they are obtained from the
        /// IChart interface object passed as the parameter.
        /// </summary>
        /// <param name="chart">Specifies the IChart interface object of the parent IChart object being serialized.</param>
        public OptionsModel(IChart chart)
        {
            BubbleMinSize = (double)chart.GetOption("BubbleMinSize");
            BubbleMaxSize = (double)chart.GetOption("BubbleMaxSize");

            ElementSize es = chart.GetOption("ClusterSize") as ElementSize;
            ClusterSizeType = es.Equals(null) ? ElementSizeType.Percentage : es.SizeType;
            ClusterSizeValue = es.Equals(null) ? 70.0 : es.Value;

            InterpolateNulls = (bool)chart.GetOption("InterpolateNulls");
        }

        #region Serializable properties

        [DataMember]
        public double BubbleMinSize { get; set; }

        [DataMember]
        public double BubbleMaxSize { get; set; }

        [DataMember]
        public ElementSizeType  ClusterSizeType { get; set; }

        [DataMember]
        public double ClusterSizeValue { get; set; }

        [DataMember]
        public bool InterpolateNulls { get; set; }

        #endregion

        /// <summary>
        /// OptionsModel.Load is used to set the properties of an existing ChartOptions object in a FlexChart based control.
        /// The values used are those stored in an existing OptionsModel class object that is typically created and set by
        /// a standard serializer during deserialization.
        /// </summary>
        /// <param name="options">Specifies an existing instance of a ChartOptions class object.</param>
        /// <param name="optionsModel">Specifies an existing instannce of a ChartOptionsModel class object created by a
        ///                  a standard serializer during deserialization.</param>
        public static void Load(ChartOptions options, OptionsModel optionsModel)
        {
            options.BubbleMinSize = optionsModel.BubbleMinSize;
            options.BubbleMaxSize = optionsModel.BubbleMaxSize;
            options.InterpolateNulls = optionsModel.InterpolateNulls;
            options.ClusterSize.SizeType = optionsModel.ClusterSizeType;
            options.ClusterSize.Value = optionsModel.ClusterSizeValue;
        }
    }
}
