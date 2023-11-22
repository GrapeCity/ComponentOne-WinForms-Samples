//----------------------------------------------------------------------------
// IC1ReportImportFilter.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using C1.Win.FlexReport;

namespace FlexReportDesignerApp.Util
{
	/// <summary>
    /// Interface used by import filters in the C1ReportDesigner app.
	/// </summary>
	internal interface IC1ReportImportFilter
	{
		// main method
        // populates reportList with imported reports, returns true to
        // clear existing reports or false to add new reports to the list
        bool Import(string fileName, List<C1FlexReport> reportList);

		// for UI updates
		event EventHandler Loading;
	}
}
