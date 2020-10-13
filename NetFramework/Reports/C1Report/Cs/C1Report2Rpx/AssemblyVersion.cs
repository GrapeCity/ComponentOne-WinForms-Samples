using System.ComponentModel;
using System.Reflection;


[assembly: AssemblyVersion(C1LiveUI.AssemblyVersion.Version)]
[assembly: AssemblyFileVersion(C1LiveUI.AssemblyVersion.FileVersion)]

namespace C1LiveUI
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal static class AssemblyVersion
    {
        private const string c_Version = "4.6.20131";
        private const string c_BuildNum = "2";

#if DEBUG
        public const string Version = c_Version + ".*";
        public const string FileVersion = c_Version + ".0";
#else
        public const string Version = c_Version + "." + c_BuildNum;
        public const string FileVersion = c_Version + "." + c_BuildNum;
#endif
    }
}