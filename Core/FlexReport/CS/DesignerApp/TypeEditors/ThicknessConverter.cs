//----------------------------------------------------------------------------
// ThicknessConverter.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

using NSThickness = C1.Win.Interop;

namespace FlexReportDesignerApp
{
    internal class ThicknessConverter : TypeConverter
    {
        #region Public
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            string content = value as string;
            if (content == null)
                return base.ConvertFrom(context, culture, value);

            content = content.Trim();
            if (content.Length == 0)
                return null;

            if (culture == null)
                culture = CultureInfo.CurrentCulture;
            char separator = culture.TextInfo.ListSeparator[0];
            string[] strArray = content.Split(separator);
            if (strArray.Length != 4 && strArray.Length != 1)
                throw new ArgumentException(
                    string.Format("Text \"{0}\" cannot be parsed. The expected text format is \"Left{1}Top{1}Right{1}Bottom\".",
                        content, separator));

            double[] numArray = new double[strArray.Length];
            for (var index = 0; index < strArray.Length; index++)
            {
                double num;
                if (!double.TryParse(strArray[index], NumberStyles.Any, culture, out num))
                    throw new ArgumentException(string.Format("{0} is not a valid value for Double.", strArray[index]));
                numArray[index] = num;
            }

            return numArray.Length == 1 ? 
                new NSThickness.Thickness(numArray[0]) : 
                new NSThickness.Thickness(numArray[0], numArray[1], numArray[2], numArray[3]);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == null)
                throw new ArgumentNullException("destinationType");
            if (!(value is NSThickness.Size))
                return base.ConvertTo(context, culture, value, destinationType);

            if (destinationType == typeof(string))
            {
                NSThickness.Thickness thickness = (NSThickness.Thickness)value;
                if (culture == null)
                    culture = CultureInfo.CurrentCulture;
                if (thickness.Left == thickness.Right && thickness.Left == thickness.Top && thickness.Left == thickness.Bottom)
                    return thickness.Left.ToString(culture);
                return string.Format("{0}{4} {1}{4} {2}{4} {3}", thickness.Left.ToString(culture), thickness.Top.ToString(culture), thickness.Right.ToString(culture), thickness.Bottom.ToString(culture), culture.TextInfo.ListSeparator);
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }

        public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
        {
            if (propertyValues == null)
                throw new ArgumentNullException("propertyValues");
            object left = propertyValues["Left"];
            object top = propertyValues["Top"];
            object right = propertyValues["Right"];
            object bottom = propertyValues["Bottom"];
            if (left == null || top == null || right == null || bottom == null ||
                !(left is double) || !(top is double) || !(right is double) || !(bottom is double))
                throw new ArgumentException(
                    "IDictionary parameter contains at least one entry that is not valid. Ensure all values are consistent with the object's properties.");

            return new NSThickness.Thickness((double)left, (double)top, (double)right, (double)bottom);
        }

        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            return TypeDescriptor.GetProperties(typeof(NSThickness.Thickness), attributes).Sort(new[] { "Left", "Top", "Right", "Bottom" });
        }
        #endregion
    }
}
