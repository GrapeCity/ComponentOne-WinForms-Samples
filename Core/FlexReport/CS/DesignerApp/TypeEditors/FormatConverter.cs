//----------------------------------------------------------------------------
// FormatConverter.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) Mescius, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace FlexReportDesignerApp
{
    /// <summary>
    /// <see cref="TypeConverter"/> used to edit formatting strings.
    /// </summary>
    /// <remarks>
    /// <para><see cref="FormatConverter"/> provides a list of commonly used formatting strings.
    /// The user can select one or type his own.</para>
    /// <para>You can use this <see cref="TypeConverter"/> in classes that derive from
    /// <see cref="Field"/> to provide properties that represent formatting strings.</para>
    /// </remarks>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class FormatConverter : StringConverter
    {
        private static StandardValuesCollection _commonFormats =
            new StandardValuesCollection(new string[]
			{
				"#,##0", "#,##0.00", "Currency", "Percent",
				"Date", "Short Date", "Long Date",
				"Time", "Long Time",
				"Yes/No"
			});
        /// <summary>
        /// Returns true to indicate that this object supports a standard set of values that can be picked from a list.
        /// </summary>
        /// <param name="ctx">An <see cref="ITypeDescriptorContext"/> that can be used to gain additional context information.</param>
        /// <returns>Always returns true.</returns>
        override public bool GetStandardValuesSupported(ITypeDescriptorContext ctx)
        {
            return true;
        }
        /// <summary>
        /// Returns false to indicate that the collection of standard values returned from <see cref="GetStandardValues"/> 
        /// is not an exclusive list (the user can type custom formats that are not on the list).
        /// </summary>
        /// <param name="ctx">An <see cref="ITypeDescriptorContext"/> that can be used to gain additional context information.</param>
        /// <returns>Always returns false.</returns>
        override public bool GetStandardValuesExclusive(ITypeDescriptorContext ctx)
        {
            return false;
        }
        /// <summary>
        /// Returns a collection of standard formats.
        /// </summary>
        /// <param name="ctx">An <see cref="ITypeDescriptorContext"/> that can be used to gain additional context information.</param>
        /// <returns>A list containing the most common formatting strings.</returns>
        override public StandardValuesCollection GetStandardValues(ITypeDescriptorContext ctx)
        {
            return _commonFormats;
        }
    }
}
