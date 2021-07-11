//----------------------------------------------------------------------------
// ScriptSyntaxItem.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Reflection;
using System.ComponentModel;
using System.Xml;
using System.IO;
using C1.Win.FlexReport;
using FlexReportDesignerApp;

namespace FlexReportDesignerApp
{
    public enum ScriptSyntax
    {
        /// <summary>
        /// Regular VBScript syntax.
        /// </summary>
        VBScript,
        /// <summary>
        /// Same as in <see cref="DataView.Filter"/>, used for data source filter expressions.
        /// </summary>
        DataView,
    }

    public enum ScriptSyntaxItemType
    {
        None = 0,
        // C1Report dynamic items:
        C1RepParam,
        C1RepField,
        C1RepGroup,
        C1RepSection,
        C1dbField,
        C1dbCalcField,
        C1GlobalFunc,
        C1GlobalSub,
        // C1Report static items:
        C1RepKeyword,
        C1RepAggregate,
        C1RepFunc,
        // VBS static items:
        VbsKeyword,
        VbsConstant,
        VbsFunction,
        VbsProgram,
        // .NET items:
        DotNetProperty,
        DotNetMethod,
        DotNetField,
        // todo - static props etc?
        // DataFilter static items:
        DataFilterKeyword,
        DataFilterFunction,
    }

    [Flags]
    public enum ScriptSyntaxItemFlags
    {
        None = 0,
        // by default, include all but .NET methods:
        Default = C1ReportParams | C1ReportFields | C1ReportSections | C1ReportDbFields | C1ReportGlobals | C1ReportGroups | C1ReportVBScript | 
            VBScript | DotNetProperties | DotNetFields | DataFilter,
        // C1Report dynamic items:
        C1ReportFields = 1,
        C1ReportSections = 1 << 1,
        C1ReportDbFields = 1 << 2,
        C1ReportGlobals = 1 << 3,
        C1ReportGroups = 1 << 4,
        C1ReportParams = 1 << 5,
        // C1Report VBS enhancements:
        C1ReportVBScript = 1 << 6,
        // Standard VBS:
        VBScript = 1 << 7,
        // .NET:
        DotNetProperties = 1 << 8,
        DotNetFields = 1 << 9,
        DotNetMethods = 1 << 10,
        // DataFilter:
        DataFilter = 1 << 11,
    }

    public class ScriptSyntaxItem : IComparable
    {
        public static ScriptSyntaxItem MakeC1FieldItem(FieldBase field, C1FlexReportDesigner designer)
        {
            return new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepField,
                Prototype = field.Name,
                Description = string.Format("{0}: {1}", field.GetType().Name, designer.GetReportObjectDescription(field)),
                // Description = string.Format("{0}{1}: {2}", field is Field ? "Legacy " : string.Empty, field.GetType().Name, designer.ReportObjectDescription(field)),
            };
        }
        public static ScriptSyntaxItem MakeC1SectionItem(Section section)
        {
            return new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepSection,
                Prototype = section.Name,
                Description = string.Format(CodeCompleteStrings.ScriptSyntaxItem.C1SectionDescFmt, section.Type),
            };
        }
        public static ScriptSyntaxItem MakeC1RepGroupItem(string group)
        {
            return new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepGroup,
                Prototype = group,
                // Description = string.Format("Section type={0}", section.Type.ToString()),
            };
        }
        public static ScriptSyntaxItem MakeC1RepParamItem(string param)
        {
            return new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepParam,
                Prototype = param,
                // Description = string.Format("Section type={0}", section.Type.ToString()),
            };
        }
        public static ScriptSyntaxItem MakeDbFieldItem(string field)
        {
            return new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1dbField,
                Prototype = field,
                // Description = string.Format("Section type={0}", section.Type.ToString()),
            };
        }
        public static ScriptSyntaxItem MakeC1dbCalcFieldItem(string field)
        {
            return new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1dbCalcField,
                Prototype = field,
                // Description = string.Format("Section type={0}", section.Type.ToString()),
            };
        }
        public static ScriptSyntaxItem MakeC1GlobalFuncItem(string func)
        {
            return new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1GlobalFunc,
                Prototype = func,
                // Description = string.Format("Section type={0}", section.Type.ToString()),
            };
        }
        public static ScriptSyntaxItem MakeC1GlobalSubItem(string sub)
        {
            return new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1GlobalSub,
                Prototype = sub,
                // Description = string.Format("Section type={0}", section.Type.ToString()),
            };
        }
        private static string GetDescription(MemberInfo info)
        {
            // We try to get hold of xml comments first, only if unavailable use description:
            var summary = XmlCommentsHelper.GetXmlCommentSummary(info);
            if (!string.IsNullOrEmpty(summary))
                return summary;

            var attrs = info.GetCustomAttributes(typeof(DescriptionAttribute), true);
            DescriptionAttribute desc = attrs.Length == 0 ? null : (DescriptionAttribute)attrs[0];
            return desc != null ? desc.Description : null;
        }
        public static ScriptSyntaxItem MakeDotNetPropertyItem(PropertyInfo info)
        {


            string gs = string.Format("{{{0}{1} }}", info.CanRead ? " get;" : "", info.CanWrite ? " set;" : "");
            string tooltipProto = string.Format("{0} {1}.{2} {3}", info.PropertyType.Name, info.DeclaringType.Name, info.Name, gs);
            return new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.DotNetProperty,
                Prototype = info.Name,
                Description = GetDescription(info),
                TooltipProto = tooltipProto,
            };
        }
        public static ScriptSyntaxItem MakeDotNetMethodItem(MethodInfo info)
        {
            var pars = info.GetParameters();
            string parsDispProto = "(";
            string parsProto = "(";
            for (int i = 0; i < pars.Length; ++i)
            {
                parsDispProto += string.Concat(pars[i].ParameterType.Name, "&nbsp;", pars[i].Name);
                if (i < pars.Length - 1)
                {
                    parsDispProto += ", ";
                    parsProto += ",";
                }
            }
            parsDispProto += ")";
            parsProto += ")";
            string displayProto = info.Name + parsProto;
            string proto;
            if (pars.Length == 0)
                proto = displayProto + "~";
            else
                proto = displayProto;

            string tooltipProto = string.Format("{0} {1}.{2}{3}", info.ReturnType.Name, info.DeclaringType.Name, info.Name, parsDispProto);
            return new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.DotNetMethod,
                Prototype = proto,
                DisplayProto = displayProto,
                TooltipProto = tooltipProto,
                Description = GetDescription(info),
            };
        }

        // ( ) , .. *
        private static Regex s_keywordsRegex = new Regex("\\W+", RegexOptions.Compiled);
        private static Regex s_firstKeywordRegex = new Regex("\\w+", RegexOptions.Compiled);

        public static readonly Dictionary<ScriptSyntaxItemType, System.Drawing.Image> ItemTypeImages = null;
        public static readonly Dictionary<ScriptSyntaxItemType, string> ItemTypeDescriptions = null;

        public override string ToString()
        {
            return DisplayProto;
        }

        private string _displayProto;
        private string _tooltipProto;

        public ScriptSyntaxItemType ItemType { get; set; }
        /// <summary>
        /// Gets/sets the keyword together with adornments such as parentheses etc, e.g. "Iif(,,)" or "If * Then * Else *".
        /// This is what is inserted into the editor when the entry is selected.
        /// </summary>
        public string Prototype { get; set; }
        /// <summary>
        /// The string shown in the listbox. If unspecified, returns Prototype.
        /// </summary>
        public string DisplayProto
        {
            get { return string.IsNullOrEmpty(_displayProto) ? Prototype : _displayProto; }
            set { _displayProto = value; }
        }
        /// <summary>
        /// The string shown in the tooltip as the prototype. If unspecified, returns Prototype.
        /// </summary>
        public string TooltipProto
        {
            get { return string.IsNullOrEmpty(_tooltipProto) ? Prototype : _tooltipProto; }
            set { _tooltipProto = value; }
        }
        /// <summary>
        /// Description. If item is retrieved via reflection, this is the Description attribute.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Gets vertical bar-delimited list of keywords for syntax highlighting, e.g. "Iif" or "If|Then|Else".
        /// </summary>
        public string Keywords { get { return s_keywordsRegex.Replace(Prototype, "|"); } }
        /// <summary>
        /// Gets the first keyword.
        /// </summary>
        public string FirstKeyword
        {
            get
            {
                return s_firstKeywordRegex.Match(Prototype).Value;
            }
        }

        public int CompareTo(object obj)
        {
            return Prototype.CompareTo(((ScriptSyntaxItem)obj).Prototype);
        }

        static ScriptSyntaxItem()
        {
            ItemTypeImages = new Dictionary<ScriptSyntaxItemType, System.Drawing.Image>()
            {
                { ScriptSyntaxItemType.None, null },
                // C1Report dynamic items:
                { ScriptSyntaxItemType.C1RepParam, global::FlexReportDesignerApp.Img_ScriptEditorCC.ReportParam_14x14 },
                { ScriptSyntaxItemType.C1RepField, global::FlexReportDesignerApp.Img_ScriptEditorCC.C1RepField_14x14 },
                { ScriptSyntaxItemType.C1RepGroup, global::FlexReportDesignerApp.Img_ScriptEditorCC.C1RepGroup_14x14 },
                { ScriptSyntaxItemType.C1RepSection, global::FlexReportDesignerApp.Img_ScriptEditorCC.C1RepSection_14x14 },
                { ScriptSyntaxItemType.C1dbField, global::FlexReportDesignerApp.Img_ScriptEditorCC.DbField_14x14 },
                { ScriptSyntaxItemType.C1dbCalcField, global::FlexReportDesignerApp.Img_ScriptEditorCC.DbCalcField_14x14 },
                { ScriptSyntaxItemType.C1GlobalFunc, global::FlexReportDesignerApp.Img_ScriptEditorCC.C1GlobalFunc_14x14 },
                { ScriptSyntaxItemType.C1GlobalSub, global::FlexReportDesignerApp.Img_ScriptEditorCC.C1GlobalSub_14x14 },
                // C1Report static items:
                { ScriptSyntaxItemType.C1RepKeyword, global::FlexReportDesignerApp.Img_ScriptEditorCC.C1RepKeyword_14x14 },
                { ScriptSyntaxItemType.C1RepAggregate, global::FlexReportDesignerApp.Img_ScriptEditorCC.C1RepAggregate_14x14 },
                { ScriptSyntaxItemType.C1RepFunc, global::FlexReportDesignerApp.Img_ScriptEditorCC.C1RepFunction_14x14 },
                // VBS static items:
                { ScriptSyntaxItemType.VbsKeyword, global::FlexReportDesignerApp.Img_ScriptEditorCC.VbsKeyword_14x14 },
                { ScriptSyntaxItemType.VbsConstant, global::FlexReportDesignerApp.Img_ScriptEditorCC.VbsConstant_14x14 },
                { ScriptSyntaxItemType.VbsFunction, global::FlexReportDesignerApp.Img_ScriptEditorCC.VbsFunction_14x14 },
                { ScriptSyntaxItemType.VbsProgram, global::FlexReportDesignerApp.Img_ScriptEditorCC.VbsProgram_14x14 },
                // .NET items:
                { ScriptSyntaxItemType.DotNetProperty, global::FlexReportDesignerApp.Img_ScriptEditorCC.DotNetProperty_14x14 },
                { ScriptSyntaxItemType.DotNetMethod, global::FlexReportDesignerApp.Img_ScriptEditorCC.DotNetMethod_14x14 },
                { ScriptSyntaxItemType.DotNetField, null},//global::ReportDesignerApp.Properties.Resources.Cc_VbsProgram_14x14 },
                // DataFilter:
                { ScriptSyntaxItemType.DataFilterKeyword, global::FlexReportDesignerApp.Img_ScriptEditorCC.DataFilterKeyword_14x14 },
                { ScriptSyntaxItemType.DataFilterFunction, global::FlexReportDesignerApp.Img_ScriptEditorCC.DataFilterFunction_14x14 },
            };

            ItemTypeDescriptions = new Dictionary<ScriptSyntaxItemType, string>()
            {
                { ScriptSyntaxItemType.None, null },
                // C1Report dynamic items:
                { ScriptSyntaxItemType.C1RepParam, CodeCompleteStrings.ItemTypeDescriptions.C1RepParam },
                { ScriptSyntaxItemType.C1RepField, CodeCompleteStrings.ItemTypeDescriptions.C1RepField },
                { ScriptSyntaxItemType.C1RepGroup, CodeCompleteStrings.ItemTypeDescriptions.C1RepGroup },
                { ScriptSyntaxItemType.C1RepSection, CodeCompleteStrings.ItemTypeDescriptions.C1RepSection },
                { ScriptSyntaxItemType.C1dbField, CodeCompleteStrings.ItemTypeDescriptions.C1dbField },
                { ScriptSyntaxItemType.C1dbCalcField, CodeCompleteStrings.ItemTypeDescriptions.C1dbCalcField },
                { ScriptSyntaxItemType.C1GlobalFunc, CodeCompleteStrings.ItemTypeDescriptions.C1GlobalFunc },
                { ScriptSyntaxItemType.C1GlobalSub, CodeCompleteStrings.ItemTypeDescriptions.C1GlobalSub },
                // C1Report static items:
                { ScriptSyntaxItemType.C1RepKeyword, CodeCompleteStrings.ItemTypeDescriptions.C1RepKeyword },
                { ScriptSyntaxItemType.C1RepAggregate, CodeCompleteStrings.ItemTypeDescriptions.C1RepAggregate },
                { ScriptSyntaxItemType.C1RepFunc, CodeCompleteStrings.ItemTypeDescriptions.C1RepFunc },
                // VBS static items:
                { ScriptSyntaxItemType.VbsKeyword, CodeCompleteStrings.ItemTypeDescriptions.VbsKeyword },
                { ScriptSyntaxItemType.VbsConstant, CodeCompleteStrings.ItemTypeDescriptions.VbsConstant },
                { ScriptSyntaxItemType.VbsFunction, CodeCompleteStrings.ItemTypeDescriptions.VbsFunction },
                { ScriptSyntaxItemType.VbsProgram, CodeCompleteStrings.ItemTypeDescriptions.VbsProgram },
                // .NET items:
                { ScriptSyntaxItemType.DotNetProperty, CodeCompleteStrings.ItemTypeDescriptions.DotNetProperty },
                { ScriptSyntaxItemType.DotNetMethod, CodeCompleteStrings.ItemTypeDescriptions.DotNetMethod },
                { ScriptSyntaxItemType.DotNetField, CodeCompleteStrings.ItemTypeDescriptions.DotNetField },
                // DataFilter:
                { ScriptSyntaxItemType.DataFilterKeyword, CodeCompleteStrings.ItemTypeDescriptions.DataFilterKeyword },
                { ScriptSyntaxItemType.DataFilterFunction, CodeCompleteStrings.ItemTypeDescriptions.DataFilterFunction },
            };
        }
    }

    public class ScriptSyntaxItemCollection
    {
        private List<ScriptSyntaxItem> _items = new List<ScriptSyntaxItem>();
        // used to cache the regex-ready descriptors string:
        private string _regexWords = null;

        /// <summary>
        /// Parses a string like "Iif(,,)|If * Then *|If * Then * Else *|If * Then .. Else .. End If|And|Or|Not|True|False"
        /// </summary>
        /// <param name="descriptors"></param>
        public void AddDescriptors(ScriptSyntaxItemType itemsType, string descriptors)
        {
            if (string.IsNullOrEmpty(descriptors))
                return;
            _regexWords = null;
            var ds = descriptors.Split('|');
            foreach (string d in ds)
                _items.Add(new ScriptSyntaxItem() { ItemType = itemsType, Prototype = d });
        }
        public void AddDescriptor(ScriptSyntaxItem item)
        {
            System.Diagnostics.Debug.Assert(item != null);
            _regexWords = null;
            _items.Add(item);
        }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<ScriptSyntaxItem> Items { get { return _items; } }
        /// <summary>
        /// Gets a regex-ready string of words delimited by '|'.
        /// </summary>
        public string RegexWords
        {
            get
            {
                if (_regexWords == null)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < _items.Count - 1; ++i)
                    {
                        sb.Append(_items[i].Keywords);
                        sb.Append('|');
                    }
                    if (_items.Count > 0)
                        sb.Append(_items[_items.Count - 1].Keywords);
                    _regexWords = sb.ToString();
                }
                return _regexWords;
            }
        }
        /// <summary>
        /// Gets the collection of syntax prototypes that can be inserted in a script.
        /// </summary>
        public string[] Prototypes
        {
            get
            {
                string[] ret = new string[_items.Count];
                int i = 0;
                foreach (var d in _items)
                    ret[i++] = d.Prototype;
                return ret;
            }
        }
    }

    public static class ScriptSyntaxVBScript
    {
        public static readonly ScriptSyntaxItemCollection Keywords = null;
        public static readonly ScriptSyntaxItemCollection Constants = null;

        public static readonly ScriptSyntaxItemCollection StringFunctions = null;
        public static readonly ScriptSyntaxItemCollection ConversionFunctions = null;
        public static readonly ScriptSyntaxItemCollection MathFunctions = null;
        public static readonly ScriptSyntaxItemCollection DateTimeFunctions = null;
        public static readonly ScriptSyntaxItemCollection MiscFunctions = null;

        public static readonly ScriptSyntaxItemCollection Logic = null;
        public static readonly ScriptSyntaxItemCollection Program = null;

        public static readonly IList<ScriptSyntaxItem> AllVBScriptSyntaxItems = null;

        static ScriptSyntaxVBScript()
        {
            Keywords = new ScriptSyntaxItemCollection();
            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "True",
                Description = CodeCompleteStrings.VBKeywords.True
            });

            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "False",
                Description = CodeCompleteStrings.VBKeywords.False
            });

            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "Nothing",
                Description = CodeCompleteStrings.VBKeywords.Nothing
            });

            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "Null",
                Description = CodeCompleteStrings.VBKeywords.Null
            });

            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "And",
                Description = CodeCompleteStrings.VBKeywords.And
            });

            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "Or",
                Description = CodeCompleteStrings.VBKeywords.Or
            });

            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "Not",
                Description = CodeCompleteStrings.VBKeywords.Not
            });

            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "Mod",
                Description = CodeCompleteStrings.VBKeywords.Mod
            });

            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "Const",
                Description = CodeCompleteStrings.VBKeywords.Const
            });

            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "Dim",
                Description = CodeCompleteStrings.VBKeywords.Dim
            });

            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "Redim",
                Description = CodeCompleteStrings.VBKeywords.Redim
            });

            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "Then",
                Description = CodeCompleteStrings.VBKeywords.Then
            });

            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "ElseIf",
                Description = CodeCompleteStrings.VBKeywords.ElseIf
            });

            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "Else",
                Description = CodeCompleteStrings.VBKeywords.Else
            });

            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "EndIf",
                Description = CodeCompleteStrings.VBKeywords.EndIf
            });

            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "End Function",
                Description = CodeCompleteStrings.VBKeywords.EndFunction
            });

            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "End Sub",
                Description = CodeCompleteStrings.VBKeywords.EndSub
            });

            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "For",
                Description = CodeCompleteStrings.VBKeywords.For
            });

            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "To",
                Description = CodeCompleteStrings.VBKeywords.To
            });

            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "Next",
                Description = CodeCompleteStrings.VBKeywords.Next
            });

            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "Step",
                Description = CodeCompleteStrings.VBKeywords.Step
            });

            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "While",
                Description = CodeCompleteStrings.VBKeywords.While
            });

            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "Wend",
                Description = CodeCompleteStrings.VBKeywords.Wend
            });

            Constants = new ScriptSyntaxItemCollection();

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbCR",
                Description = CodeCompleteStrings.VBConstants.vbCr
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbCrLf",
                Description = CodeCompleteStrings.VBConstants.vbCrLf
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbLf",
                Description = CodeCompleteStrings.VBConstants.vbLf
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbFormFeed",
                Description = CodeCompleteStrings.VBConstants.vbFormFeed
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbNewLine",
                Description = CodeCompleteStrings.VBConstants.vbNewLine
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbNullChar",
                Description = CodeCompleteStrings.VBConstants.vbNullChar
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbTab",
                Description = CodeCompleteStrings.VBConstants.vbTab
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbVerticalTab",
                Description = CodeCompleteStrings.VBConstants.vbVerticalTab
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbBlack",
                Description = CodeCompleteStrings.VBConstants.vbBlack
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbRed",
                Description = CodeCompleteStrings.VBConstants.vbRed
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbGreen",
                Description = CodeCompleteStrings.VBConstants.vbGreen
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbYellow",
                Description = CodeCompleteStrings.VBConstants.vbYellow
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbBlue",
                Description = CodeCompleteStrings.VBConstants.vbBlue
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbMagenta",
                Description = CodeCompleteStrings.VBConstants.vbMagenta
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbCyan",
                Description = CodeCompleteStrings.VBConstants.vbCyan
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbWhite",
                Description = CodeCompleteStrings.VBConstants.vbWhite
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbWhite",
                Description = CodeCompleteStrings.VBConstants.vbWhite
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbEmpty",
                Description = CodeCompleteStrings.VBConstants.vbEmpty
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbNull",
                Description = CodeCompleteStrings.VBConstants.vbNull
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbInteger",
                Description = CodeCompleteStrings.VBConstants.vbInteger
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbLong",
                Description = CodeCompleteStrings.VBConstants.vbLong
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbSingle",
                Description = CodeCompleteStrings.VBConstants.vbSingle
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbDouble",
                Description = CodeCompleteStrings.VBConstants.vbDouble
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbCurrency",
                Description = CodeCompleteStrings.VBConstants.vbCurrency
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbDate",
                Description = CodeCompleteStrings.VBConstants.vbDate
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbString",
                Description = CodeCompleteStrings.VBConstants.vbString
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbObject",
                Description = CodeCompleteStrings.VBConstants.vbObject
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbError",
                Description = CodeCompleteStrings.VBConstants.vbError
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbBoolean",
                Description = CodeCompleteStrings.VBConstants.vbBoolean
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbVariant",
                Description = CodeCompleteStrings.VBConstants.vbVariant
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbDataObject",
                Description = CodeCompleteStrings.VBConstants.vbDataObject
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbDecimal",
                Description = CodeCompleteStrings.VBConstants.vbDecimal
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbByte",
                Description = CodeCompleteStrings.VBConstants.vbByte
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbArray",
                Description = CodeCompleteStrings.VBConstants.vbArray
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbOKOnly",
                Description = CodeCompleteStrings.VBConstants.vbOKOnly
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbOKCancel",
                Description = CodeCompleteStrings.VBConstants.vbOKCancel
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbAbortRetryIgnore",
                Description = CodeCompleteStrings.VBConstants.vbAbortRetryIgnore
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbYesNoCancel",
                Description = CodeCompleteStrings.VBConstants.vbYesNoCancel
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbYesNo",
                Description = CodeCompleteStrings.VBConstants.vbYesNo
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbRetryCancel",
                Description = CodeCompleteStrings.VBConstants.vbRetryCancel
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbCritical",
                Description = CodeCompleteStrings.VBConstants.vbCritical
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbExclamation",
                Description = CodeCompleteStrings.VBConstants.vbExclamation
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbInformation",
                Description = CodeCompleteStrings.VBConstants.vbInformation
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbDefaultButton1",
                Description = CodeCompleteStrings.VBConstants.vbDefaultButton1
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbDefaultButton2",
                Description = CodeCompleteStrings.VBConstants.vbDefaultButton2
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbDefaultButton3",
                Description = CodeCompleteStrings.VBConstants.vbDefaultButton3
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbDefaultButton4",
                Description = CodeCompleteStrings.VBConstants.vbDefaultButton4
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbApplicationModal",
                Description = CodeCompleteStrings.VBConstants.vbApplicationModal
            });

            Constants.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsConstant,
                Prototype = "vbSystemModal",
                Description = CodeCompleteStrings.VBConstants.vbSystemModal
            });

            StringFunctions = new ScriptSyntaxItemCollection();

            StringFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Asc()",
                Description = CodeCompleteStrings.VBStringFunctions.Asc
            });

            StringFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Chr()",
                Description = CodeCompleteStrings.VBStringFunctions.Chr
            });

            StringFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "ChrW()",
                Description = CodeCompleteStrings.VBStringFunctions.ChrW
            });

            StringFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "CStr()",
                Description = CodeCompleteStrings.VBStringFunctions.CStr
            });

            StringFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "FormatCurrency(,)",
                Description = CodeCompleteStrings.VBStringFunctions.FormatCurrency
            });

            StringFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "FormatDateTime(,)",
                Description = CodeCompleteStrings.VBStringFunctions.FormatDateTime
            });

            StringFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "FormatNumber(,)",
                Description = CodeCompleteStrings.VBStringFunctions.FormatNumber
            });

            StringFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "FormatPercent(,)",
                Description = CodeCompleteStrings.VBStringFunctions.FormatPercent
            });

            StringFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Instr(,)",
                Description = CodeCompleteStrings.VBStringFunctions.Instr
            });

            StringFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "LCase()",
                Description = CodeCompleteStrings.VBStringFunctions.LCase
            });

            StringFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Left()",
                Description = CodeCompleteStrings.VBStringFunctions.Left
            });

            StringFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Len()",
                Description = CodeCompleteStrings.VBStringFunctions.Len
            });

            StringFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "LTrim()",
                Description = CodeCompleteStrings.VBStringFunctions.LTrim
            });

            StringFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Mid()",
                Description = CodeCompleteStrings.VBStringFunctions.Mid
            });

            StringFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Replace(,)",
                Description = CodeCompleteStrings.VBStringFunctions.Replace
            });

            StringFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Right()",
                Description = CodeCompleteStrings.VBStringFunctions.Right
            });

            StringFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Space()",
                Description = CodeCompleteStrings.VBStringFunctions.Space
            });

            StringFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Asc()",
                Description = CodeCompleteStrings.VBStringFunctions.Asc
            });

            StringFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "AscW()",
                Description = CodeCompleteStrings.VBStringFunctions.AscW
            });

            StringFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Trim()",
                Description = CodeCompleteStrings.VBStringFunctions.Trim
            });

            StringFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "UCase()",
                Description = CodeCompleteStrings.VBStringFunctions.UCase
            });

            StringFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Hex()",
                Description = CodeCompleteStrings.VBStringFunctions.Hex
            });

            ConversionFunctions = new ScriptSyntaxItemCollection();
            
            ConversionFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "CBool()",
                Description = CodeCompleteStrings.VBConversionFunctions.CBool
            });

            ConversionFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "CByte()",
                Description = CodeCompleteStrings.VBConversionFunctions.CByte
            });

            ConversionFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "CCur()",
                Description = CodeCompleteStrings.VBConversionFunctions.CCur
            });

            ConversionFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "CDate()",
                Description = CodeCompleteStrings.VBConversionFunctions.CDate
            });

            ConversionFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "CDbl()",
                Description = CodeCompleteStrings.VBConversionFunctions.CDbl
            });

            ConversionFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "CInt()",
                Description = CodeCompleteStrings.VBConversionFunctions.CInt
            });

            ConversionFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "CLng()",
                Description = CodeCompleteStrings.VBConversionFunctions.CLng
            });

            ConversionFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "CSng()",
                Description = CodeCompleteStrings.VBConversionFunctions.CSng
            });

            ConversionFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "CStr()",
                Description = CodeCompleteStrings.VBConversionFunctions.CStr
            });

            ConversionFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "IsEmpty()",
                Description = CodeCompleteStrings.VBConversionFunctions.IsEmpty
            });

            ConversionFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "TypeName()",
                Description = CodeCompleteStrings.VBConversionFunctions.TypeName
            });

            ConversionFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "VarType()",
                Description = CodeCompleteStrings.VBConversionFunctions.VarType
            });

            ConversionFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "CBoolInvariant()",
                Description = CodeCompleteStrings.VBConversionFunctions.CBoolInvariant
            });

            ConversionFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "CByteInvariant()",
                Description = CodeCompleteStrings.VBConversionFunctions.CByteInvariant
            });

            ConversionFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "CCurInvariant()",
                Description = CodeCompleteStrings.VBConversionFunctions.CCurInvariant
            });

            ConversionFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "CDateInvariant()",
                Description = CodeCompleteStrings.VBConversionFunctions.CDateInvariant
            });

            ConversionFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "CDblInvariant()",
                Description = CodeCompleteStrings.VBConversionFunctions.CDblInvariant
            });

            ConversionFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "CIntInvariant()",
                Description = CodeCompleteStrings.VBConversionFunctions.CIntInvariant
            });

            ConversionFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "CLngInvariant()",
                Description = CodeCompleteStrings.VBConversionFunctions.CLngInvariant
            });

            ConversionFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "CSngInvariant()",
                Description = CodeCompleteStrings.VBConversionFunctions.CSngInvariant
            });

            ConversionFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "CStrInvariant()",
                Description = CodeCompleteStrings.VBConversionFunctions.CStrInvariant
            });

            MathFunctions = new ScriptSyntaxItemCollection();

            MathFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Abs()",
                Description = CodeCompleteStrings.VBMathFunctions.Abs
            });

            MathFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Acos()",
                Description = CodeCompleteStrings.VBMathFunctions.Acos
            });

            MathFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Asin()",
                Description = CodeCompleteStrings.VBMathFunctions.Asin
            });

            MathFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Atn()",
                Description = CodeCompleteStrings.VBMathFunctions.Atn
            });

            MathFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Cos()",
                Description = CodeCompleteStrings.VBMathFunctions.Cos
            });

            MathFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Exp()",
                Description = CodeCompleteStrings.VBMathFunctions.Exp
            });

            MathFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Fix()",
                Description = CodeCompleteStrings.VBMathFunctions.Fix
            });

            MathFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Int()",
                Description = CodeCompleteStrings.VBMathFunctions.Int
            });

            MathFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "IsNull()",
                Description = CodeCompleteStrings.VBMathFunctions.IsNull
            });

            MathFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "IsNumeric()",
                Description = CodeCompleteStrings.VBMathFunctions.IsNumeric
            });

            MathFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "IsObject()",
                Description = CodeCompleteStrings.VBMathFunctions.IsObject
            });

            MathFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Pi()",
                Description = CodeCompleteStrings.VBMathFunctions.Pi
            });

            MathFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Oct()",
                Description = CodeCompleteStrings.VBMathFunctions.Oct
            });

            MathFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Rnd()",
                Description = CodeCompleteStrings.VBMathFunctions.Rnd
            });

            MathFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Round()",
                Description = CodeCompleteStrings.VBMathFunctions.Round
            });

            MathFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Sgn()",
                Description = CodeCompleteStrings.VBMathFunctions.Sgn
            });

            MathFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Sin()",
                Description = CodeCompleteStrings.VBMathFunctions.Sin
            });

            MathFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Sign()",
                Description = CodeCompleteStrings.VBMathFunctions.Sign
            });

            MathFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Sqr()",
                Description = CodeCompleteStrings.VBMathFunctions.Sqr
            });

            MathFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Tan()",
                Description = CodeCompleteStrings.VBMathFunctions.Tan
            });

            DateTimeFunctions = new ScriptSyntaxItemCollection();

            DateTimeFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "CDate()",
                Description = CodeCompleteStrings.VBDateTimeFunctions.CDate
            });

            DateTimeFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "DateAdd()",
                Description = CodeCompleteStrings.VBDateTimeFunctions.DateAdd
            });

            DateTimeFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "DateDiff()",
                Description = CodeCompleteStrings.VBDateTimeFunctions.DateDiff
            });

            DateTimeFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "DatePart()",
                Description = CodeCompleteStrings.VBDateTimeFunctions.DatePart
            });

            DateTimeFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "DateSerial()",
                Description = CodeCompleteStrings.VBDateTimeFunctions.DateSerial
            });

            DateTimeFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Day()",
                Description = CodeCompleteStrings.VBDateTimeFunctions.Day
            });

            DateTimeFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Hour()",
                Description = CodeCompleteStrings.VBDateTimeFunctions.Hour
            });

            DateTimeFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "IsDate()",
                Description = CodeCompleteStrings.VBDateTimeFunctions.IsDate
            });

            DateTimeFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Minute()",
                Description = CodeCompleteStrings.VBDateTimeFunctions.Minute
            });

            DateTimeFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Month()",
                Description = CodeCompleteStrings.VBDateTimeFunctions.Month
            });

            DateTimeFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "MonthName()",
                Description = CodeCompleteStrings.VBDateTimeFunctions.MonthName
            });

            DateTimeFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Now()",
                Description = CodeCompleteStrings.VBDateTimeFunctions.Now
            });

            DateTimeFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Second()",
                Description = CodeCompleteStrings.VBDateTimeFunctions.Second
            });

            DateTimeFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Weekday()",
                Description = CodeCompleteStrings.VBDateTimeFunctions.Weekday
            });

            DateTimeFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "WeekdayName()",
                Description = CodeCompleteStrings.VBDateTimeFunctions.WeekdayName
            });

            DateTimeFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Year()",
                Description = CodeCompleteStrings.VBDateTimeFunctions.Year
            });

            DateTimeFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Date()",
                Description = CodeCompleteStrings.VBDateTimeFunctions.Date
            });

            DateTimeFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Timer()",
                Description = CodeCompleteStrings.VBDateTimeFunctions.Timer
            });

            DateTimeFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "TimeSerial()",
                Description = CodeCompleteStrings.VBDateTimeFunctions.TimeSerial
            });

            DateTimeFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "TimeValue()",
                Description = CodeCompleteStrings.VBDateTimeFunctions.TimeValue
            });

            MiscFunctions = new ScriptSyntaxItemCollection();

            MiscFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "InputBox()",
                Description = CodeCompleteStrings.VBMiscFunctions.InputBox
            });

            MiscFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "MsgBox()",
                Description = CodeCompleteStrings.VBMiscFunctions.MsgBox
            });

            MiscFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Rgb()",
                Description = CodeCompleteStrings.VBMiscFunctions.Rgb
            });

            MiscFunctions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "Argb()",
                Description = CodeCompleteStrings.VBMiscFunctions.Argb
            });

            Logic = new ScriptSyntaxItemCollection();

            Logic.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "If * Then *",
                Description = CodeCompleteStrings.VBKeywords.IfThen
            });

            Logic.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "If * Then * Else *",
                Description = CodeCompleteStrings.VBKeywords.IfThenElse
            });

            Logic.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsFunction,
                Prototype = "If * Then .. Else .. EndIf",
                Description = CodeCompleteStrings.VBKeywords.IfThenElseEndIf
            });

            Program = new ScriptSyntaxItemCollection();

            Program.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "As",
                Description = CodeCompleteStrings.VBKeywords.As
            });

            Program.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "Call",
                Description = CodeCompleteStrings.VBKeywords.Call
            });

            Program.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "ByRef",
                Description = CodeCompleteStrings.VBKeywords.ByRef
            });

            Program.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "ByVal",
                Description = CodeCompleteStrings.VBKeywords.ByVal
            });

            Program.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "Sub *() .. End Sub",
                Description = CodeCompleteStrings.VBKeywords.Sub
            });

            Program.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.VbsKeyword,
                Prototype = "Function *() .. End Function",
                Description = CodeCompleteStrings.VBKeywords.Function
            });

            var all = new List<ScriptSyntaxItem>();
            all.AddRange(Keywords.Items);
            all.AddRange(Constants.Items);
            all.AddRange(StringFunctions.Items);
            all.AddRange(ConversionFunctions.Items);
            all.AddRange(MathFunctions.Items);
            all.AddRange(DateTimeFunctions.Items);
            all.AddRange(MiscFunctions.Items);
            all.AddRange(Logic.Items);
            all.AddRange(Program.Items);
            //
            all.Sort();
            // Remove duplicates
            for (int i = all.Count - 2; i > 0; --i)
            {
                if (all[i].Prototype == all[i + 1].Prototype)
                    all.RemoveAt(i);
                else if (all[i].Prototype == all[i + 1].FirstKeyword) // Remove "If" if it is followed by "If * Then *".
                    all.RemoveAt(i);
            }
            //
            AllVBScriptSyntaxItems = all;

            /*
                "Argb|Abs|Acos|Asc|Asin|Atn|CBool|CByte|CCur|CDate|CDbl|Chr|CInt|CLng|Cos|CSng|CStr|" +
                "Date|DateAdd|DateDiff|DatePart|DateSerial|DateValue|Day|Exp|Fix|" +
                "FormatCurrency|FormatDateTime|FormatNumber|FormatPercent|Hex|Hour|" +
                "InputBox|InStr|InStrRev|Int|IsDate|IsEmpty|IsNull|IsNumeric|IsObject|LCase|" +
                "Left|Len|Log|LTrim|Mid|Minute|Month|MonthName|MsgBox|Now|Oct|Pi|Replace|" +
                "RGB|Right|Rnd|Round|RTrim|Second|Sgn|Sin|Sign|Space|Sqr|StrComp|String|" +
                "Tan|Time|Timer|TimeSerial|TimeValue|Trim|TypeName|UCase|VarType|WeekDay|WeekDayName|Year|" +
                "CBoolInvariant|CByteInvariant|CCurInvariant|CDateInvariant|CDblInvariant|" +
                "CIntInvariant|CLngInvariant|CSngInvariant|CStrInvariant");
             */
        }


        public static string RegexAllFunctions
        {
            get 
            {
                return StringFunctions.RegexWords + '|' + ConversionFunctions.RegexWords + '|' + MathFunctions.RegexWords + '|' + DateTimeFunctions.RegexWords + '|' + MiscFunctions.RegexWords;
            }
        }
    }

    public static class ScriptSyntaxC1Report
    {
        public static readonly ScriptSyntaxItemCollection Keywords = null;
        public static readonly ScriptSyntaxItemCollection Aggregates = null;
        public static readonly ScriptSyntaxItemCollection Functions = null;

        public static readonly IList<ScriptSyntaxItem> AllC1ReportSyntaxItems = null;

        static ScriptSyntaxC1Report()
        {
            // C1Report built-in keywords:
            Keywords = new ScriptSyntaxItemCollection();
            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepKeyword, 
                Prototype = "Page",
                Description = CodeCompleteStrings.C1RepScriptItems.Page,
            });
            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepKeyword,
                Prototype = "Pages",
                Description = CodeCompleteStrings.C1RepScriptItems.Pages,
            });
            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepKeyword,
                Prototype = "Report",
                Description = CodeCompleteStrings.C1RepScriptItems.Report,
            });
            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepKeyword,
                Prototype = "Parameters",
                Description = CodeCompleteStrings.C1RepScriptItems.Parameters,
            });
            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepKeyword,
                Prototype = "DataSources",
                Description = CodeCompleteStrings.C1RepScriptItems.DataSources,
            });

            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepKeyword,
                Prototype = "Cancel",
                Description = CodeCompleteStrings.C1RepScriptItems.Cancel,
            });

            // C1Report built-in aggregates:
            Aggregates = new ScriptSyntaxItemCollection();
            // the help string appended to all c1report aggregate funcs' descriptions, explains the scope of aggregates:
            string cAggrScopeDesc = CodeCompleteStrings.C1RepScriptItems.AggrScopeDesc;


            Aggregates.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepAggregate,
                Prototype = "Sum()",
                TooltipProto = "Sum(expression[, filterExpression])",
                Description = CodeCompleteStrings.C1RepScriptItems.AggrSumDesc + cAggrScopeDesc,
            });
            Aggregates.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepAggregate,
                Prototype = "Min()",
                TooltipProto = "Min(expression[, filterExpression])",
                Description = CodeCompleteStrings.C1RepScriptItems.AggrMinDesc + cAggrScopeDesc,
            });
            Aggregates.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepAggregate,
                Prototype = "Max()",
                TooltipProto = "Max(expression[, filterExpression])",
                Description = CodeCompleteStrings.C1RepScriptItems.AggrMaxDesc + cAggrScopeDesc,
            });
            Aggregates.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepAggregate,
                Prototype = "Avg()",
                TooltipProto = "Avg(expression[, filterExpression])",
                Description = CodeCompleteStrings.C1RepScriptItems.AggrAvgDesc + cAggrScopeDesc + CodeCompleteStrings.C1RepScriptItems.AggrAvgSamples,
            });
            Aggregates.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepAggregate,
                Prototype = "Count()",
                TooltipProto = "Count(expression[, filterExpression])",
                Description = CodeCompleteStrings.C1RepScriptItems.AggrCountDesc + cAggrScopeDesc + CodeCompleteStrings.C1RepScriptItems.AggrCountSamples,
            });
            Aggregates.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepAggregate,
                Prototype = "CountDistinct()",
                TooltipProto = "CountDistinct(expression[, filterExpression])",
                Description = CodeCompleteStrings.C1RepScriptItems.AggrCountDistinctDesc + cAggrScopeDesc,
            });
            Aggregates.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepAggregate,
                Prototype = "Range()",
                TooltipProto = "Range(expression[, filterExpression])",
                Description = CodeCompleteStrings.C1RepScriptItems.AggrRangeDesc + cAggrScopeDesc,
            });
            Aggregates.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepAggregate,
                Prototype = "Var()",
                TooltipProto = "Var(expression[, filterExpression])",
                Description = CodeCompleteStrings.C1RepScriptItems.AggrVarDesc + cAggrScopeDesc,
            });
            Aggregates.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepAggregate,
                Prototype = "VarP()",
                TooltipProto = "VarP(expression[, filterExpression])",
                Description = CodeCompleteStrings.C1RepScriptItems.AggrVarPDesc + cAggrScopeDesc,
            });
            Aggregates.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepAggregate,
                Prototype = "StDev()",
                TooltipProto = "StDev(expression[, filterExpression])",
                Description = CodeCompleteStrings.C1RepScriptItems.AggrStDevDesc + cAggrScopeDesc,
            });
            Aggregates.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepAggregate,
                Prototype = "StDevP()",
                TooltipProto = "StDevP(expression[, filterExpression])",
                Description = CodeCompleteStrings.C1RepScriptItems.AggrStDevPDesc + cAggrScopeDesc,
            });
            Aggregates.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepAggregate,
                Prototype = "Median()",
                TooltipProto = "Median(expression[, filterExpression])",
                Description = CodeCompleteStrings.C1RepScriptItems.AggrMedianDesc + cAggrScopeDesc,
            });
            Aggregates.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepAggregate,
                Prototype = "Mode()",
                TooltipProto = "Mode(expression[, filterExpression])",
                Description = CodeCompleteStrings.C1RepScriptItems.AggrModeDesc + cAggrScopeDesc,
            });

            /* TODO: two aggregate parameters:
                NthLargest
                NthSmallest
                NthMostFrequent
                Percentile
                Covariance
                Correlation
                WeightedAvg
            */

            // C1Report built-in functions:
            Functions = new ScriptSyntaxItemCollection();
            Functions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepFunc,
                Prototype = "Like(,)",
                TooltipProto = "Like(str, template)",
                Description = CodeCompleteStrings.C1RepScriptItems.LikeDesc,
            });
            Functions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepFunc,
                Prototype = "In(,,,)",
                TooltipProto = "In(obj, obj1, ..., objN)",
                Description = CodeCompleteStrings.C1RepScriptItems.InDesc,
            });
            Functions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepFunc,
                Prototype = "Iif(,,)",
                TooltipProto = "Iif(condition, trueValue, falseValue)",
                Description = CodeCompleteStrings.C1RepScriptItems.IifDesc,
            });
            Functions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepFunc,
                Prototype = "Format(,)",
                TooltipProto = "Format(value, formatStr)",
                Description = CodeCompleteStrings.C1RepScriptItems.FormatDesc,
            });
            Functions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepKeyword,
                Prototype = "GroupPage()",
                TooltipProto = "GroupPage([groupId])",
                Description = CodeCompleteStrings.C1RepScriptItems.GroupPageDesc,
            });
            Functions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.C1RepKeyword,
                Prototype = "GroupPages()",
                TooltipProto = "GroupPages([groupId])",
                Description = CodeCompleteStrings.C1RepScriptItems.GroupPagesDesc,
            });

            var all = new List<ScriptSyntaxItem>();
            all.AddRange(Keywords.Items);
            all.AddRange(Aggregates.Items);
            all.AddRange(Functions.Items);
            //
            all.Sort();
            //
            AllC1ReportSyntaxItems = all;
        }
    }

    public static class ScriptSyntaxDataFilter
    {
        public static readonly ScriptSyntaxItemCollection Keywords = null;
        public static readonly ScriptSyntaxItemCollection Functions = null;

        public static readonly IList<ScriptSyntaxItem> AllDataFilterSyntaxItems = null;

        static ScriptSyntaxDataFilter()
        {
            Keywords = new ScriptSyntaxItemCollection();
            Keywords.AddDescriptors(ScriptSyntaxItemType.DataFilterKeyword, "And|Between|Child|False|Is|Not|Null|Or|Parent|True");
            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.DataFilterKeyword,
                Prototype = "LIKE",
                TooltipProto = "column LIKE pattern",
                Description = CodeCompleteStrings.DataFilterScriptItems.LikeDesc,
            });
            Keywords.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.DataFilterKeyword,
                Prototype = "IN",
                TooltipProto = "column IN (val1, val2, ..., valN)",
                Description = CodeCompleteStrings.DataFilterScriptItems.InDesc,
            });
            Functions = new ScriptSyntaxItemCollection();
            Functions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.DataFilterFunction,
                Prototype = "Sum()",
                TooltipProto = "Sum(expression)",
                Description = CodeCompleteStrings.DataFilterScriptItems.SumDesc,
            });
            Functions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.DataFilterFunction,
                Prototype = "Avg()",
                TooltipProto = "Avg(expression)",
                Description = CodeCompleteStrings.DataFilterScriptItems.AvgDesc,
            });
            Functions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.DataFilterFunction,
                Prototype = "Min()",
                TooltipProto = "Min(expression)",
                Description = CodeCompleteStrings.DataFilterScriptItems.MinDesc,
            });
            Functions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.DataFilterFunction,
                Prototype = "Max()",
                TooltipProto = "Max(expression)",
                Description = CodeCompleteStrings.DataFilterScriptItems.MaxDesc,
            });
            Functions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.DataFilterFunction,
                Prototype = "Count()",
                TooltipProto = "Count(expression)",
                Description = CodeCompleteStrings.DataFilterScriptItems.CountDesc,
            });
            Functions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.DataFilterFunction,
                Prototype = "StDev()",
                TooltipProto = "StDev(expression)",
                Description = CodeCompleteStrings.DataFilterScriptItems.StDevDesc,
            });
            Functions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.DataFilterFunction,
                Prototype = "Var()",
                TooltipProto = "Var(expression)",
                Description = CodeCompleteStrings.DataFilterScriptItems.VarDesc,
            });
            //            
            Functions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.DataFilterFunction,
                Prototype = "CONVERT(,)",
                TooltipProto = "CONVERT(expression, type)",
                Description = CodeCompleteStrings.DataFilterScriptItems.ConvertDesc,
            });
            Functions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.DataFilterFunction,
                Prototype = "LEN()",
                TooltipProto = "LEN(expression)",
                Description = CodeCompleteStrings.DataFilterScriptItems.LenDesc,
            });
            Functions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.DataFilterFunction,
                Prototype = "ISNULL(,)",
                TooltipProto = "ISNULL(expression, replacementvalue)",
                Description = CodeCompleteStrings.DataFilterScriptItems.IsNullDesc,
            });
            Functions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.DataFilterFunction,
                Prototype = "IIF(,,)",
                TooltipProto = "IIF(expression, truepart, falsepart)",
                Description = CodeCompleteStrings.DataFilterScriptItems.IifDesc,
            });
            Functions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.DataFilterFunction,
                Prototype = "TRIM()",
                TooltipProto = "TRIM(expression)",
                Description = CodeCompleteStrings.DataFilterScriptItems.TrimDesc,
            });
            Functions.AddDescriptor(new ScriptSyntaxItem()
            {
                ItemType = ScriptSyntaxItemType.DataFilterFunction,
                Prototype = "SUBSTRING(,,)",
                TooltipProto = "SUBSTRING(expression, start, length)",
                Description = CodeCompleteStrings.DataFilterScriptItems.SubStringDesc,
            });

            var all = new List<ScriptSyntaxItem>();
            all.AddRange(Keywords.Items);
            all.AddRange(Functions.Items);
            //
            all.Sort();
            //
            AllDataFilterSyntaxItems = all;
        }
    }

    public static class XmlCommentsHelper
    {
        /// <summary>
        /// 
        /// </summary>
        // private static Regex s_htmlizer = new Regex("<[^>]+\".:(?<name>[^\">]+)\".*?>", RegexOptions.Compiled | RegexOptions.Multiline);
        private static Regex s_htmlizer = new Regex("<[^>]+\"[A-Z]:[^>]+\\.(?<name>\\w+)\".*?>", RegexOptions.Compiled | RegexOptions.Multiline);

        private class MruEntry
        {
            public string Name { get; set; }
            public XmlDocument Doc { get; set; }
            public System.Xml.XPath.XPathNavigator Navigator { get; set; }
        }
        // Simple MRU cache for XML docs:
        // - s_cache contains up to s_cacheCap entries/documents, keyed by full XML file name;
        // - new items are added at the back, when item count reaches s_cacheCap, old items are removed from the front;
        // - requested but non-existing XML files are added to the s_deads list, to avoid trying them again.
        private static List<MruEntry> s_cache = new List<MruEntry>();
        private static List<string> s_deads = new List<string>();
        private const int s_cacheCap = 10;

        public static string GetXmlCommentSummary(MemberInfo info)
        {
            string fname = Path.ChangeExtension(info.Module.FullyQualifiedName, ".xml");

            if (s_deads.Contains(fname))
                return null;

            MruEntry mru = s_cache.Find((mm) => mm.Name == fname);
            if (mru == null)
            {
                if (!File.Exists(fname))
                {
                    s_deads.Add(fname);
                    return null;
                }
                else
                {
                    XmlDocument xdoc = new XmlDocument();
                    xdoc.Load(fname);
                    var xpnav = xdoc.CreateNavigator();
                    mru = new MruEntry() { Name = fname, Doc = xdoc, Navigator = xpnav };
                    if (s_cache.Count >= s_cacheCap)
                        s_cache.RemoveAt(0);
                    s_cache.Add(mru);
                }
            }
            try
            {
                string elName = ElementName(info);
                var node = mru.Navigator.SelectSingleNode(string.Format("/doc/members/member[@name='{0}']/summary", elName));
                if (node == null)
                    return null;
                var tstr = node.InnerXml.Trim();
                tstr = s_htmlizer.Replace(tstr, "<b>${name}</b>");
                return tstr;
            }
            catch
            {
                return null;
            }
        }

        private static string ElementName(MemberInfo member)
        {
            // Code from: http://www.brad-smith.info/blog/archives/220
            char prefixCode;
            string memberName = (member is Type)
                ? ((Type)member).FullName // member is a Type
                : (member.DeclaringType.FullName + "." + member.Name); // member belongs to a Type

            switch (member.MemberType)
            {
                case MemberTypes.Constructor:
                    memberName = memberName.Replace(".ctor", "#ctor");
                    goto case MemberTypes.Method;
                case MemberTypes.Method:
                    prefixCode = 'M';
                    string paramTypesList = string.Empty;
                    foreach (ParameterInfo pi in ((MethodBase)member).GetParameters())
                        paramTypesList += pi.ParameterType.FullName + ",";
                    if (!string.IsNullOrEmpty(paramTypesList))
                        memberName += "(" + paramTypesList.Substring(0, paramTypesList.Length - 1) + ")";
                    break;
                case MemberTypes.Event: prefixCode = 'E';
                    break;
                case MemberTypes.Field: prefixCode = 'F';
                    break;
                case MemberTypes.NestedType:
                    memberName = memberName.Replace('+', '.');
                    goto case MemberTypes.TypeInfo;
                case MemberTypes.TypeInfo:
                    prefixCode = 'T';
                    break;
                case MemberTypes.Property: prefixCode = 'P';
                    break;
                default:
                    throw new ArgumentException("Unknown member type", "member");
            }
            return String.Format("{0}:{1}", prefixCode, memberName);
        }
    }
}
