//----------------------------------------------------------------------------
// Utils.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.IO;
using System.Resources;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;
using System.Diagnostics;

using C1.Report;
using C1.Win.FlexReport.FlexDesigner;

namespace FlexReportDesignerApp.Util
{
    internal static class EditableModelHelper
    {
        public static bool GetInstanceAndServices(ITypeDescriptorContext ctx, out object instance, out FlexDesignerHostServices services)
        {
            if (ctx == null)
            {
                instance = null;
                services = null;
                return false;
            }
            else if (ctx.Instance is EditableModel)
            {
                EditableModel model = (EditableModel)ctx.Instance;
                instance = model.Instance;
                services = model.Services;
                return true;
            }
            else
            {
                // worst case. I don't like using static prop but have no better ideas.
                instance = ctx.Instance;
                services = MainForm.TheMainForm.DesignerHostServices;
                return true;
            }
        }
    }

    /// <summary>
    /// Helper class to assit in converting strings to/from script values.
    /// Unlike ScriptValue's own conversion, this mostly treats all strings as expressions.
    /// </summary>
    internal static class ScriptValueHelper
    {
        public static string ObjectToText(object o, out bool? isExpression)
        {
            if (o is string)
            {
                isExpression = null;
                return (string)o;
            }
            else if (o is ScriptStringValue)
            {
                var ssv = (ScriptStringValue)o;
                string str = ssv.IsExpression ? ssv.Expression : ssv.Value;
                if (ssv.IsExpression)
                    isExpression = true;
                else if (!string.IsNullOrEmpty(str))
                    isExpression = false;
                else // for empty/null strings, we cannot really say whether user wants an expression or not
                    isExpression = null;
                return str;
            }
            else if (o is ScriptObjectValue)
            {
                var sov = (ScriptObjectValue)o;
                string str = sov.IsExpression ? sov.Expression : (sov.Value as string);
                if (sov.IsExpression)
                    isExpression = true;
                else if (!string.IsNullOrEmpty(str))
                    isExpression = false;
                else // see above
                    isExpression = null;
                return str;
            }
            else if (o is ScriptEnumValue<SortDirection>)
            {
                var sev = (ScriptEnumValue<SortDirection>)o;
                if (sev.IsExpression)
                {
                    isExpression = true;
                    return sev.Expression;
                }
                else
                {
                    isExpression = false;
                    return sev.Value.ToString();
                }
            }
            else // todo - handle other Script*Value types
            {
                isExpression = null;
                return null;
            }
        }
        public static object TextToObject(string text, Type objectType, bool isExpression)
        {
            if (objectType == typeof(ScriptStringValue))
            {
                if (isExpression)
                    return new ScriptStringValue() { Expression = text };
                else
                    return new ScriptStringValue() { Value = text };
            }
            else if (objectType == typeof(ScriptObjectValue))
            {
                if (isExpression)
                    return new ScriptObjectValue() { Expression = text };
                else
                    return new ScriptObjectValue() { Value = text };
            }
            else if (objectType == typeof(ScriptEnumValue<SortDirection>))
            {
                return EnumFromString<SortDirection>(text);
            }
            else // todo - handle other Script*Value types
            {
                return text;
            }
        }
        public static string ToString(object o)
        {
            if (o == null)
                return string.Empty;
            else
                return o.ToString();
        }
        public static object FromString(string text, Type objectType)
        {
            if (text == null)
                return null;
            else if (objectType == typeof(ScriptStringValue))
                return (ScriptStringValue)text;
            else if (objectType == typeof(ScriptObjectValue))
                return (ScriptObjectValue)text;
            else if (objectType == typeof(ScriptEnumValue<SortDirection>))
                return EnumFromString<SortDirection>(text);
            else // todo - handle other Script*Value types
                return text;
        }

        private static ScriptEnumValue<T> EnumFromString<T>(string @string) where T : struct
        {
            T res;
            if (Enum.TryParse<T>(@string, out res))
                return new ScriptEnumValue<T>() { Value = res };
            else
                return new ScriptEnumValue<T>() { Expression = @string };
        }
    }

    internal static class AppUtils
    {
        #region Public static
        // http://stackoverflow.com/questions/7162834/determine-if-current-application-is-activated-has-focus
        /// <summary>Returns true if the current application has focus, false otherwise</summary>
        public static bool ApplicationIsActive()
        {
            var activatedHandle = C1.Util.Win.Win32.GetForegroundWindow();
            if (activatedHandle == IntPtr.Zero)
            {
                return false;       // No window is currently activated
            }

            var procId = Process.GetCurrentProcess().Id;
            int activeProcId = 0;
            C1.Util.Win.Win32.GetWindowThreadProcessId(activatedHandle, ref activeProcId);

            return activeProcId == procId;
        }

        public static bool Contains(this ReportParameterCollection coll, string name)
        {
            foreach (var par in coll)
                if (par.Name == name)
                    return true;
            return false;
        }

        public static string GetDescription(MemberInfo info)
        {
            var desc = GetAttribute<DescriptionAttribute>(info);
            return desc != null ? desc.Description : null;
        }

        public static TAttr GetAttribute<TAttr>(Type type) where TAttr: Attribute
        {
            object[] attrs = type.GetCustomAttributes(typeof(TAttr), true);
            return attrs.Length == 0 ? null : (TAttr)attrs[0];
        }
        
        public static TAttr GetAttribute<TAttr>(MemberInfo info) where TAttr : Attribute
        {
            var attrs = info.GetCustomAttributes(typeof(TAttr), true);
            return attrs.Length == 0 ? null : (TAttr)attrs[0];
        }

        public static Image LoadResourceImage(
            Assembly assembly,
            string resourceName)
        {
            foreach (string res in assembly.GetManifestResourceNames())
            {
                if (res.EndsWith(resourceName))
                {
                    System.IO.Stream stream = assembly.GetManifestResourceStream(res);
                    return Image.FromStream(stream);
                }
            }
            return null;
        }

        public static Image LoadResourceImage(
            string resourceName)
        {
            return LoadResourceImage(Assembly.GetExecutingAssembly(), resourceName);
        }

        public static void ParseVersionString(
            string version,
            out int major,
            out int minor,
            out int build,
            out int rev)
        {
            major = minor = build = rev = 0;
            if (!string.IsNullOrEmpty(version))
            {
                var vs = version.Split(new char[] { '.' });
                if (vs.Length > 0)
                    int.TryParse(vs[0], out major);
                if (vs.Length > 1)
                    int.TryParse(vs[1], out minor);
                if (vs.Length > 2)
                    int.TryParse(vs[2], out build);
                if (vs.Length > 3)
                    int.TryParse(vs[3], out rev);
            }
        }

        public static TreeNode FindNodeByTag(
            TreeNodeCollection nodes,
            object tagValue)
        {
            foreach (TreeNode tn in nodes)
            {
                if (tn.Tag == tagValue)
                    return tn;
                TreeNode result = FindNodeByTag(tn.Nodes, tagValue);
                if (result != null)
                    return result;
            }
            return null;
        }

        public static TreeNode FindNodeByText(
            TreeNodeCollection nodes,
            string text,
            bool ignoreCase)
        {
            foreach (TreeNode tn in nodes)
            {
                if (string.Compare(tn.Text, text, ignoreCase) == 0)
                    return tn;
                TreeNode result = FindNodeByText(tn.Nodes, text, ignoreCase);
                if (result != null)
                    return result;
            }
            return null;
        }

        public static void DeleteFile(string fileName)
        {
            if (string.IsNullOrEmpty(fileName) || !File.Exists(fileName))
                return;
            try
            {
                File.Delete(fileName);
            }
            catch
            {
            }
        }
        #endregion
    }
}
