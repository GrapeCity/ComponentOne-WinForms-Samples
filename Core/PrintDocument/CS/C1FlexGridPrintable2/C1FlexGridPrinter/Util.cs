using System;
using System.Globalization;

namespace C1.Win.FlexGrid
{
    /// <summary>
    /// Static utility methods.
    /// </summary>
    internal static class Utility
    {
        /// <summary>
        /// Checks whether a string contains the representation of a number.
        /// </summary>
        /// <param name="s">The string to test.</param>
        /// <returns>True if the string represents a number, false otherwise.</returns>
        /// <remarks>This is stolen from flex grid code.</remarks>
        public static bool IsNumeric(string s)
        {
            // handle empty strings
            if (s == null || s.Length == 0) return false;

            // handle percentages
            if (s.EndsWith("%")) s = s.Substring(0, s.Length - 1);

            // use TryParse to check whether this is a number
            double value;
            return double.TryParse(s, NumberStyles.Any, null, out value);
        }

        /// <summary>
        /// Checks whether a type is numeric.
        /// </summary>
        /// <param name="type"></param>
        /// <returns>True if the type is numeric, false otherwise.</returns>
        /// <remarks>This is stolen from flex grid code.</remarks>
        public static bool IsNumeric(Type type)
        {
            return
                type == typeof(double) || type == typeof(float) ||
                type == typeof(int) || type == typeof(uint) ||
                type == typeof(long) || type == typeof(ulong) ||
                type == typeof(short) || type == typeof(ushort) ||
                type == typeof(sbyte) || type == typeof(byte) ||
                type == typeof(decimal);
        }

        /// <summary>
        /// Creates a name that is unique within the Dictionary of the passed document.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <param name="nameFmt">The name format. Must contain exactly one "{0}" sequence.</param>
        /// <returns>The created unique name.</returns>
        public static string MakeUniqueDictName(C1.C1Preview.C1PrintDocument doc, string nameFmt)
        {
            if (doc == null)
                throw new Exception("MakeUniqueDictName: doc cannot be null.");
            // todo: this is ugly.
            for (int i = 0; i < 1001; ++i)
            {
                string tstr = string.Format(nameFmt, i);
                if (doc.Dictionary.IndexOfName(tstr) < 0)
                    return tstr;
            }
            throw new Exception("MakeUniqueDictName: failed to create unique dictionary name.");
        }
    }
}
