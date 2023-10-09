//----------------------------------------------------------------------------
// SubreportFieldConverter.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Globalization;

using C1.Win.FlexReport;
using C1.Win.FlexReport.FlexDesigner;
using Flex = C1.Win.FlexReport;
using Doc = C1.Win.C1Document;

namespace FlexReportDesignerApp
{
    public class SubreportFieldConverter : StringConverter
    {
        private static string c_strNull = Strings.Common.None;

        /// <summary>
        /// Returns whether this converter can convert an object of one type to the type of this converter.
        /// </summary>
        /// <param name="ctx">An <see cref="ITypeDescriptorContext"/> that can be used to gain additional context information.</param>
        /// <param name="type">A <see cref="Type"/> that represents the type you want to convert from.</param>
        /// <returns>True if <paramref name="type"/> is string, false otherwise.</returns>
        override public bool CanConvertFrom(ITypeDescriptorContext ctx, Type type)
        {
            return (type == typeof(string))
                ? true
                : base.CanConvertFrom(ctx, type);
        }
        /// <summary>
        /// Converts the given value to the type of this converter.
        /// </summary>
        /// <param name="ctx">An <see cref="ITypeDescriptorContext"/> that can be used to gain additional context information.</param>
        /// <param name="ci">The <see cref="CultureInfo"/> to use as the current culture.</param>
        /// <param name="value">The <see cref="Object"/> to convert.</param>
        /// <returns>A <see cref="C1Report"/> object with the specified name, or null if no report by the specified name 
        /// could be found in the report definition file.</returns>
        override public object ConvertFrom(ITypeDescriptorContext ctx, CultureInfo ci, object value)
        {
            // get subreport name
            string name = value as string;
            if (name == null)
                return base.ConvertFrom(ctx, ci, value);

            // none?
            if (name == c_strNull)
                return null;

            object instance;
            FlexDesignerHostServices services;
            if (!Util.EditableModelHelper.GetInstanceAndServices(ctx, out instance, out services))
                return value;

            var grs = services.GetGetReportService();
            if (grs == null)
                return value;

            // get report list from control
            foreach (var rpt in grs.GetReportList())
            {
                if (string.Compare(rpt.ReportName, name, true, CultureInfo.CurrentCulture) == 0)
                    return rpt;
            }

            // not found
            return base.ConvertFrom(ctx, ci, value);
        }
        /// <summary>
        /// Returns whether this converter can convert the object to the specified type.
        /// </summary>
        /// <param name="ctx">An <see cref="ITypeDescriptorContext"/> that can be used to gain additional context information.</param>
        /// <param name="type">A <see cref="Type"/> that represents the type you want to convert to.</param>
        /// <returns>True if <paramref name="type"/> is string, false otherwise.</returns>
        override public bool CanConvertTo(ITypeDescriptorContext ctx, Type type)
        {
            return (type == typeof(string))
                ? true
                : base.CanConvertTo(ctx, type);
        }
        /// <summary>
        /// Converts the given value object to the specified type.
        /// </summary>
        /// <param name="ctx">An <see cref="ITypeDescriptorContext"/> that can be used to gain additional context information.</param>
        /// <param name="ci">The <see cref="CultureInfo"/> to use as the current culture.</param>
        /// <param name="value">The <see cref="Object"/> to convert.</param>
        /// <param name="type">A <see cref="Type"/> that represents the type you want to convert to.</param>
        /// <returns>The name of the report if <paramref name="type"/> is string, null otherwise.</returns>
        override public object ConvertTo(ITypeDescriptorContext ctx, CultureInfo ci, object value, Type type)
        {
            if (type == typeof(string))
            {
                if (value == null)
                    return c_strNull;
                if (value is C1FlexReport)
                    return ((C1FlexReport)value).ReportName;
            }
            return base.ConvertTo(ctx, ci, value, type);
        }
        /// <summary>
        /// Returns whether this object supports properties, using the specified context.
        /// </summary>
        /// <param name="ctx">An <see cref="ITypeDescriptorContext"/> that provides a format context.</param>
        /// <returns>True because <see cref="GetStandardValues"/> should be called to find the properties of this object.</returns>
        override public bool GetStandardValuesSupported(ITypeDescriptorContext ctx)
        {
            return true;
        }
        /// <summary>
        /// Returns whether the collection of standard values returned from 
        /// <see cref="GetStandardValues"/> is an exclusive list of possible values, 
        /// using the specified context.
        /// </summary>
        /// <param name="ctx">An <see cref="ITypeDescriptorContext"/> that provides a format context.</param>
        /// <returns>True because the <see cref="TypeConverter.StandardValuesCollection"/> returned 
        /// from <see cref="GetStandardValues"/> is an exhaustive list of possible values.</returns>
        override public bool GetStandardValuesExclusive(ITypeDescriptorContext ctx)
        {
            return true;
        }
        /// <summary>
        /// Returns a collection of report names.
        /// </summary>
        /// <param name="ctx">An <see cref="ITypeDescriptorContext"/> that provides a format context that can be 
        /// used to extract additional information about the environment from which this converter is invoked. 
        /// This parameter or properties of this parameter can be a null reference (Nothing in Visual Basic).</param>
        /// <returns>A <see cref="TypeConverter.StandardValuesCollection"/> that holds a standard set of valid values.</returns>
        override public StandardValuesCollection GetStandardValues(ITypeDescriptorContext ctx)
        {
            object instance;
            FlexDesignerHostServices services;
            if (!Util.EditableModelHelper.GetInstanceAndServices(ctx, out instance, out services))
                return base.GetStandardValues(ctx);

            var grs = services.GetGetReportService();
            if (grs == null)
                return base.GetStandardValues(ctx);

            C1FlexReport report = grs.Report;
            if (report == null)
                return base.GetStandardValues(ctx);

            // get report list from control
            List<string> reportNames = new List<string>();
            reportNames.Add(c_strNull);
            reportNames.AddRange(grs.GetReportList().Where((rep_) => !report.Equals(rep_)).Select((rep_) => rep_.ReportName));
            return new StandardValuesCollection(reportNames);
        }
    }
}
