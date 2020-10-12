using System;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;

namespace SampleCenter
{
	public enum CodeLanguage
	{
		CSharp,
		VB
	}

	public class RtfColor
	{
		static string commentCS = @"//";
		static string commentVB = @"'";

		static string[] keywordsCS = new string[]
			{
				"abstract", "as",
				"base",	"bool", "break", "byte",
				"case", "catch", "char", "checked", "class", "const", "continue",
				"decimal", "default", "delegate", "double", "do",
				"else", "enum", "event", "explicit", "extern",
				"false", "finally", "fixed", "float", "for", "foreach",
				"goto",
				"if", "implicit", "in", "int", "interface", "internal", "is",
				"lock", "long",
				"namespace", "new", "null",
				"object", "operator", "out", "override",
				"params", "private", "protected", "public",
				"readonly", "ref", "return",
				"sbyte", "sealed", "short", "sizeof", "stackalloc", "static", "string",	"struct", "switch",
				"this",	"throw", "true", "try",	"typeof",
        "uint", "ulong", "unchecked", "unsafe", "ushort", "using",
				"virtual", "volatile", "void", "while"
			};

		static string[] keywordsVB = new string[]
			{
				"AddHandler", "AddressOf", "Alias", "And", "AndAlso", "Ansi", "As", "Assembly",	"Auto",
				"Boolean", "ByRef", "Byte", "ByVal",
				"Call", "Case", "Catch", "CBool", "CByte", "CChar", "CDate", "CDec", "CDbl", "Char", "CInt", "Class", "CLng", "CObj", "Const", "CShort", "CSng", "CStr", "CType",
				"Date", "Decimal", "Declare", "Default", "Delegate", "Dim", "DirectCast", "Do", "Double",
				"Each", "Else", "ElseIf", "End", "Enum", "Erase", "Error", "Event", "Exit",
				"False", "Finally", "For", "Friend", "Function", 
				"Get", "GetType", "GoTo",
				"Handles",
        "If", "Implements", "Imports", "In", "Inherits", "Integer", "Interface", "Is", 
				"Let", "Lib", "Like", "Long", "Loop",
				"Me", "Mod", "Module", "MustInherit", "MustOverride", "MyBase", "MyClass", 
				"Namespace", "New", "Next", "Not", "Nothing", "NotInheritable", "NotOverridable",
				"Object", "On", "Option", "Optional", "Or", "OrElse", "Overloads", "Overridable", "Overrides", 
				"ParamArray", "Preserve", "Private", "Property", "Protected", "Public",
				"RaiseEvent", "ReadOnly", "ReDim", "REM", "RemoveHandler", "Resume", "Return",
				"Select", "Set", "Shadows", "Shared", "Short", "Single", "Static", "Step", "Stop", "String", "Structure", "Sub", "SyncLock",
				"Then", "Throw", "To", "True", "Try", "TypeOf",
				"Unicode", "Until", 
				"When", "While", "With", "WithEvents", "WriteOnly",
				"Xor" 
		};

		static Regex _regexCS = null;
		static Regex _regexVB = null;

		public static void Init()
		{
			_regexVB = CreateRegex( keywordsVB, RegexOptions.Compiled);
			_regexCS = CreateRegex( keywordsCS, RegexOptions.IgnoreCase|RegexOptions.Compiled);
		}

		static string curfont = @"\cf1";

		public static string Format( string code, CodeLanguage lang)
		{
			curfont = @"\cf1";

			string cmts = (lang == CodeLanguage.CSharp) ? commentCS : commentVB;
			Regex r = (lang == CodeLanguage.CSharp) ? RegexCS : RegexVB;

			string[] lines = code.Split( new char[]{ '\n'});

			StringBuilder sb = new StringBuilder();

			sb.Append( CreateRtfHeader( Color.Black, Color.Green, Color.Blue, Color.Gray));

			for( int i=0; i<lines.Length; i++)
			{
				string line = lines[i];

				string linews = line.Trim();
				
				if( linews.StartsWith( cmts))
				{
					string comment = linews.Remove( 0, cmts.Length);

					if( comment.StartsWith("RtfGray"))
					{
						curfont = @"\cf4";
						continue;
					}
					else if( comment.StartsWith("RtfNormal"))
					{
						curfont = @"\cf1";
						continue;
					}

					sb.Append( @"\cf2");
				}
				else
				{
					sb.Append( curfont);

					line = FormatKeywords( line, r);
				}

				line = line.Replace( "{", @"\{");
				line = line.Replace( "}", @"\}");

				line = line.Replace( "\t", "   ");

				sb.Append( line);
				sb.Append( "\\par\n");
			}

			sb.Append( "}");

			string s = sb.ToString();

			return s;
		}

		static Regex CreateRegex( string[] keywords, RegexOptions opts)
		{
			StringBuilder sb = new StringBuilder(@"\b(");

			for( int i=0; i<keywords.Length; i++)
			{
				sb.Append( keywords[i]);
				if( i!=keywords.Length-1)
					sb.Append( '|');
				else
					sb.Append( @")\b");
			}

			return new Regex( sb.ToString(), opts);
		}

		static Regex RegexVB
		{
			get
			{
				if( _regexVB == null)
					_regexVB = CreateRegex( keywordsVB, RegexOptions.Compiled);

				return _regexVB;
			}
		}

		static Regex RegexCS
		{
			get
			{
				if( _regexCS == null)
					_regexCS = CreateRegex( keywordsCS, RegexOptions.IgnoreCase|RegexOptions.Compiled);

				return _regexCS;
			}
		}

		static string FormatKeywords( string line, Regex r)
		{
			return r.Replace( line, new MatchEvaluator(KeywordMatchEvaluator));
		}

		static string KeywordMatchEvaluator(Match m)
		{
			return @"\cf3 " + m.Value + curfont + " ";
		}
								
		static string CreateRtfHeader( Color defClr, Color cmntClr, Color keyClr, Color grayClr)
		{
			return string.Format( @"{0}\rtf1\ansi {1}", '{', CreateColorTable( new Color[] {defClr, cmntClr, keyClr, grayClr}));
		}

		static string CreateColorTable( Color[] clrs)
		{
			string s = @"{\colortbl;";

			for( int i=0; i<clrs.Length; i++)
				s += CreateColorTableEntry( clrs[i]);

			s += "}";

			return s;
		}

		static string CreateColorTableEntry( Color clr)
		{
			return string.Format( @"\red{0}\green{1}\blue{2};", clr.R, clr.G, clr.B);
		}
	}
}
