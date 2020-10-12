#if CLR40 || CLR45
#define DYNAMIC_ASMS
#endif

#if DYNAMIC_ASMS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows.Forms;
using System.Globalization;

namespace C1.C1Report.CustomFields
{
    /// <summary>
    /// Provides the ability to dynamically load certain C1 assemblies
    /// and work with types defined in those assemblies, without having
    /// a hard reference to a particular version of the assembly.
    /// <para>Requires C# 4.0/VS 2010 or later.</para>
    /// </summary>
    internal class DynLoader
    {
        #region Nested types
        /// <summary>
        /// Enumerates the supported assemblies.
        /// </summary>
        private enum AsmKeys
        {
            C1Chart,
            C1SuperLabel,
            C1QRCode,
            C1Maps,
        }

        /// <summary>
        /// Describes a supported assembly.
        /// </summary>
        private class CtrlDesc
        {
            #region Private data
            private string AsmName { get; set; }
            private string DefaultNamespace { get; set; }

            private Assembly Asm { get; set; }
            private Dictionary<string, Type> Types { get; set; }
            #endregion

            #region Ctors
            public CtrlDesc(string asmName, string defaultNamespace)
            {
                AsmName = asmName;
                if (!string.IsNullOrEmpty(defaultNamespace))
                    defaultNamespace = defaultNamespace.TrimEnd('.');
                DefaultNamespace = defaultNamespace;
                Types = new Dictionary<string, Type>();
            }

            public CtrlDesc(string asmName)
                : this(asmName, null)
            {
            }
            #endregion

            #region Privates
            private static Assembly TryLoadAssembly(string name)
            {
                // Note: Assembly.Load does not work when the assembly
                // is in the GAC while LoadWithPartialName works.
                try
                {
                    return Assembly.Load(name);
                }
                catch
                {
                    try
                    {
#pragma warning disable 0618
                        return Assembly.LoadWithPartialName(name);
#pragma warning disable 0618
                    }
                    catch
                    {
                        return null;
                    }
                }
            }

            private void Load()
            {
                if (Asm != null)
                    return;

                Asm = TryLoadAssembly(AsmName);
                if (Asm == null)
                    throw new DynException(ErrAsmLoad, AsmName);
            }
            #endregion

            #region Publics
            /// <summary>
            /// Gets the requested type.
            /// </summary>
            /// <param name="typeName"></param>
            /// <returns></returns>
            public Type GetType(string typeName)
            {
                Load();

                if (!typeName.Contains('.') && !string.IsNullOrEmpty(DefaultNamespace))
                    typeName = string.Format(CultureInfo.InvariantCulture, "{0}.{1}", DefaultNamespace, typeName);

                if (Types.ContainsKey(typeName))
                    return Types[typeName];

                var t = Asm.GetType(typeName);
                if (t == null)
                    throw new DynException(ErrTypeLoad, typeName, AsmName);

                Types.Add(t.FullName, t);
                return t;
            }

            /// <summary>
            /// Creates an instance of the specified type.
            /// </summary>
            /// <param name="typeName"></param>
            /// <returns>The newly created instance.</returns>
            public dynamic CreateTypeInstance(string typeName, params object[] args)
            {
                try
                {
                    return Activator.CreateInstance(GetType(typeName), args);
                }
                catch (Exception ex)
                {
                    var err = ex.InnerException != null ?
                        string.Format(CultureInfo.InvariantCulture, "{0}:\n{1}", ex.Message, ex.InnerException.Message) :
                        ex.Message;
                    throw new DynException(string.Format(CultureInfo.InvariantCulture, ErrCannotCreateInst, typeName, err));
                }
            }

            /// <summary>
            /// Returns a value of an enum in the specified namespace.
            /// </summary>
            /// <param name="value">The enum value name, e.g. "Chart2DTypeEnum.Area".</param>
            /// <returns>The requested enum value.</returns>
            public dynamic GetEnumValue(string value)
            {
                var idot = value.LastIndexOf('.');
                if (idot < 0)
                    throw new DynException(ErrEnumParse, value);

                return GetEnumValue(value.Substring(0, idot), value.Substring(idot + 1));
            }

            /// <summary>
            /// Returns a value of an enum in the specified namespace.
            /// </summary>
            /// <param name="enumName">The name of the enum (without namespace), e.g. "Chart2DTypeEnum".</param>
            /// <param name="value">The enum value name, e.g. "Area".</param>
            /// <returns>The requested enum value.</returns>
            public dynamic GetEnumValue(string enumName, string value)
            {
                var type = GetType(enumName);
                if (type == null)
                    throw new DynException(ErrEnumLoad, enumName);

                return Enum.Parse(type, value);
            }
            #endregion
        }
        #endregion

        #region private data
        // supported controls:
        private static readonly Dictionary<AsmKeys, CtrlDesc> _descriptors = new Dictionary<AsmKeys, CtrlDesc>()
        {
#if CLR45
            { AsmKeys.C1Chart, new CtrlDesc("C1.Win.C1Chart.4.5", "C1.Win.C1Chart") },
            { AsmKeys.C1SuperLabel, new CtrlDesc("C1.Win.C1SuperTooltip.4.5") },
            { AsmKeys.C1QRCode, new CtrlDesc("C1.Win.C1BarCode.4.5", "C1.Win.C1BarCode") },
            { AsmKeys.C1Maps, new CtrlDesc("C1.WPF.Maps.4", "C1.WPF.Maps") },
#elif CLR40
            { AsmKeys.C1Chart, new CtrlDesc("C1.Win.C1Chart.4", "C1.Win.C1Chart") },
            { AsmKeys.C1SuperLabel, new CtrlDesc("C1.Win.C1SuperTooltip.4") },
            { AsmKeys.C1QRCode, new CtrlDesc("C1.Win.C1BarCode.4", "C1.Win.C1BarCode") },
            { AsmKeys.C1Maps, new CtrlDesc("C1.WPF.Maps.4", "C1.WPF.Maps") },
#else
#error CLR40 or CLR45 must be defined.
#endif
        };

        // error messages:
        private const string ErrAsmLoad = "Cannot load assembly {0}.\nMake sure that assembly is available either in the application directory or in the GAC.";
        private const string ErrTypeLoad = "Cannot load type {0} from assembly {1}.";
        private const string ErrEnumParse = "Cannot parse enum {0}.";
        private const string ErrEnumLoad = "Cannot create enum type {0}.";
        private const string ErrCannotCreateInst = "Cannot create instance of type {0}, error was:\n{1}.";
        #endregion

        #region publics
        /// <summary>
        /// Creates an instance of C1.Win.C1Chart.C1Chart class.
        /// </summary>
        /// <returns>The newly created instance.</returns>
        public static dynamic CreateC1Chart()
        {
            return _descriptors[AsmKeys.C1Chart].CreateTypeInstance("C1.Win.C1Chart.C1Chart");
        }

        /// <summary>
        /// Returns a value of an enum in the C1.Win.C1Chart namespace.
        /// </summary>
        /// <param name="value">The enum value name, e.g. "Chart2DTypeEnum.Area".</param>
        /// <returns>The requested enum value.</returns>
        public static dynamic GetC1ChartEnumValue(string value)
        {
            return _descriptors[AsmKeys.C1Chart].GetEnumValue(value);
        }

        /// <summary>
        /// Creates an instance of C1.Win.C1SuperTooltip.C1SuperLabel class.
        /// </summary>
        /// <returns>The newly created instance.</returns>
        public static dynamic CreateC1SuperLabel()
        {
            return _descriptors[AsmKeys.C1SuperLabel].CreateTypeInstance("C1.Win.C1SuperTooltip.C1SuperLabel");
        }

        /// <summary>
        /// Creates an instance of C1.Win.C1BarCode.C1QRCode class.
        /// </summary>
        /// <returns>The newly created instance.</returns>
        public static dynamic CreateC1QRCode()
        {
            return _descriptors[AsmKeys.C1QRCode].CreateTypeInstance("C1.Win.C1BarCode.C1QRCode");
        }

        /// <summary>
        /// Converts a string representing a <b>C1.Win.C1BarCode.Encoding</b> value
        /// to a value of that type.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>The converted value.</returns>
        public static dynamic GetC1QRCode_Encoding(string value)
        {
            return _descriptors[AsmKeys.C1QRCode].GetEnumValue("Encoding", value);
        }

        /// <summary>
        /// Converts a string representing a <b>C1.Win.C1BarCode.ErrorCorrectionLevel</b> value
        /// to a value of that type.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>The converted value.</returns>
        public static dynamic GetC1QRCode_ErrorCorrectionLevel(string value)
        {
            return _descriptors[AsmKeys.C1QRCode].GetEnumValue("ErrorCorrectionLevel", value);
        }

        /// <summary>
        /// Creates an instance of a type defined in the C1.WPF.Maps assembly.
        /// </summary>
        /// <returns>The newly created instance.</returns>
        public static dynamic CreateC1MapsInstance(string typeName, params object[] args)
        {
            return _descriptors[AsmKeys.C1Maps].CreateTypeInstance(typeName, args);
        }

        /// <summary>
        /// Gets a type defined in the C1.WPF.Maps assembly.
        /// </summary>
        /// <returns>The newly created type.</returns>
        public static dynamic GetC1MapsType(string typeName)
        {
            return _descriptors[AsmKeys.C1Maps].GetType(typeName);
        }

        /// <summary>
        /// Returns a value of an enum in the C1.WPF.Maps namespace.
        /// </summary>
        /// <param name="value">The enum value name, e.g. "LabelVisibility.Visible".</param>
        /// <returns>The requested enum value.</returns>
        public static dynamic GetC1MapsEnumValue(string value)
        {
            return _descriptors[AsmKeys.C1Maps].GetEnumValue(value);
        }

        /// <summary>
        /// Returns the value of a specified public static field of the C1Maps class.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <returns>The field's value.</returns>
        public static object GetC1MapsStaticFieldValue(string fieldName)
        {
            var t = DynLoader.GetC1MapsType("C1Maps");
            return t.GetField(fieldName, BindingFlags.Static | BindingFlags.Public).GetValue(null);
        }

        /// <summary>
        /// Returns the specified static C1Maps class.
        /// </summary>
        /// <param name="fieldName">The class name.</param>
        /// <returns>The class.</returns>
        public static object CallC1MapsStaticMethod(string className, string methodName, params object[] args)
        {
            Type t = DynLoader.GetC1MapsType(className);
            Type[] types;
            if (args != null)
            {
                types = new Type[args.Length];
                for (int i = 0; i < args.Length; ++i)
                    types[i] = args[i].GetType(); // NOTE: this won't work if one of the arguments is null
            }
            else
                types = null;
            MethodInfo mi = t.GetMethod(methodName, BindingFlags.FlattenHierarchy | BindingFlags.Static | BindingFlags.Public, null, types, null);
            return mi.Invoke(null, args);
        }
        #endregion

        #region privates
        private class DynException : Exception
        {
            public DynException(string message, params object[] args)
                : base(string.Format(CultureInfo.InvariantCulture, message, args))
            {
                if (Environment.UserInteractive)
                    MessageBox.Show(Message, "CustomFields Dynamic Loader Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
#endif
