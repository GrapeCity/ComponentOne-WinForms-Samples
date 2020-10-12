using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;
using System.Reflection;
using System.IO;

using C1.AppUtils.Options;

namespace C1Report2Rpx
{
    [Obfuscation(Exclude = true, ApplyToMembers = true)]
    [Serializable]
    public class ProgramOptions : WindowsApplicationOptions
    {
        private static Type[] s_NestedTypes = new Type[] { typeof(MainForm.ResolutionParams), typeof(ArDesigner.ResolutionParams) };

        private static ProgramOptions s_Instance;

        #region Public static
        public static void Load()
        {
            s_Instance = (ProgramOptions)ProgramOptions.Load(GetOptionsFileName(), typeof(ProgramOptions), s_NestedTypes);
        }
        #endregion

        #region Public static properties
        public static ProgramOptions Instance
        {
            get { return s_Instance; }
        }
        #endregion
    }
}
