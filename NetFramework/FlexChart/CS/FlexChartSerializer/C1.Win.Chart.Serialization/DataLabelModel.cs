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
    /// The DataLabelModel class is used by the FlexChart serializer to serialize and deserialize labels of
    /// FlexChart based controls.
    /// 
    /// Serialization is performed using the FlexChart core interfaces.
    /// Deserialization is peformed using the platform instances of the FlexChart control.
    /// 
    /// </summary>
    [Serializable]
    [DataContract]
    public class DataLabelModel
    {
        /// <summary>
        /// Simple constructor used to create an instance of the DataLabelModel class during deserialization.
        /// </summary>
        public DataLabelModel()
        {
        }

        /// <summary>
        /// Overloaded constructor used create an instance of the DataLabelModel class during serialization.
        /// The public properties of this class are set by this contructor as they are obtained from the
        /// IDataLabel interface object passed as the parameter.
        /// </summary>
        /// <param name="dataLabel">Specifies the IDataLabel interface object to be serialized.</param>
        /// <param name="chart">Specifies the IChart interface object of the parent IChart object being serialized.</param>
        public DataLabelModel(IDataLabel dataLabel, IChart chart)
        {
            Border = dataLabel.Border;
            ConnectingLine = dataLabel.ConnectingLine;
            Content = dataLabel.Content;
            Offset = dataLabel.Offset;
            Position = dataLabel.Position;

            Style = StyleSerializer.StyleToString(dataLabel.GetStyle("_"), chart as IBrushConverter);
            BorderStyle =  StyleSerializer.StyleToString(dataLabel.GetStyle("_Border"), chart as IBrushConverter);
        }

        #region Serializable properties

        [DataMember]
        public bool Border { get; set; }

        [DataMember]
        public string Content { get; set; }

        [DataMember]
        public bool ConnectingLine { get; set; }

        [DataMember]
        public int Offset { get; set; }

        [DataMember]
        public LabelPosition Position { get; set; }

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
        /// <param name="dataLabel">Specifies an existing instance of a DataLabel class object.</param>
        /// <param name="dataLabelModel">Specifies an existing instannce of a DataLabelModel class object created by a
        ///                  a standard serializer during deserialization.</param>
        public static void Load(DataLabel dataLabel, DataLabelModel dataLabelModel)
        {
            if (dataLabelModel == null)
                dataLabelModel = new DataLabelModel();

            dataLabel.Border = dataLabelModel.Border;
            dataLabel.ConnectingLine = dataLabelModel.ConnectingLine;
            dataLabel.Content = dataLabelModel.Content;
            dataLabel.Offset = dataLabelModel.Offset;
            dataLabel.Position = dataLabelModel.Position;

            ((IDataLabel)dataLabel).SetStyle(StyleSerializer.StyleFromString(dataLabelModel.Style), "_");
            ((IDataLabel)dataLabel).SetStyle(StyleSerializer.StyleFromString(dataLabelModel.BorderStyle), "_Border");
        }
    }
}
