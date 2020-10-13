//----------------------------------------------------------------------------
// AssemblyInfo.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System.Reflection;
using System.Runtime.CompilerServices;

//
// In order to sign your assembly you must specify a key to use. Refer to the 
// Microsoft .NET Framework documentation for more information on assembly signing.
//
// Use the attributes below to control which key is used for signing. 
//
[assembly: AssemblyDelaySign(false)]
[assembly: AssemblyKeyName("")]
[assembly: AssemblyKeyFile("")]

namespace C1.Util.Licensing
{
    /// <summary>
    /// Specifies assembly name parts, used by AssemblyCommonInfo to generate actual assembly names.
    /// </summary>
    [System.ComponentModel.Browsable(false)]
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    internal static class AssemblyNames
    {
        public const string Title = "FlexReportDesigner App";
        public const string Desc = "FlexReport Designer Application for .NET";
    }
}
