using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;
using System.Reflection;

namespace C1.AppUtils.Options
{
    [Obfuscation(Exclude = true, ApplyToMembers = true)]
    [Serializable]
    public class Options
    {
        private Type[] _nestedTypes;
        protected string m_FileName;

        #region Protected static
        protected static Options Load(
            string fileName,
            Type optionsType,
            Type[] nestedTypes)
        {
            object result = null;
            try
            {
                XmlSerializer s = new XmlSerializer(optionsType, null, nestedTypes, null, null);
                using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                    result = s.Deserialize(fs);

                if (result != null && !typeof(Options).IsAssignableFrom(result.GetType()))
                    result = null;
            }
            catch
            {
                result = null;
            }

            if (result == null)
                result = Activator.CreateInstance(optionsType);

            ((Options)result)._nestedTypes = nestedTypes;
            ((Options)result).m_FileName = fileName;
            return (Options)result;
        }

        protected static string GetOptionsFileName()
        {
            string appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string localFileName = Application.ExecutablePath + ".settings";
            if (string.IsNullOrEmpty(appDataDir))
                return localFileName;
            appDataDir = string.Format("{0}\\{1}\\", appDataDir, Path.GetFileNameWithoutExtension(Application.ExecutablePath));
            string appDataFile = string.Format("{0}{1}.settings", appDataDir, Path.GetFileName(Application.ExecutablePath));
            if (File.Exists(appDataFile))
                return appDataFile;
            return localFileName;
        }
        #endregion

        #region Public
        public Exception Save()
        {
            return Save(null);
        }

        public Exception Save(
            string fileName)
        {
            if (fileName == null)
                fileName = m_FileName;
            else
                m_FileName = fileName;
            if (string.IsNullOrEmpty(fileName))
                throw new ArgumentNullException("fileName");

            // directory where file is saved should exists
            string dirName = Path.GetDirectoryName(fileName);
            try
            {
                if (!Directory.Exists(dirName))
                    Directory.CreateDirectory(dirName);

                XmlSerializer s = new XmlSerializer(this.GetType(), null, _nestedTypes, null, null);
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                    s.Serialize(fs, this);

                return null;
            }
            catch (Exception e)
            {
                return e;
            }
        }
        #endregion

        #region Public properties
        /// <summary>
        /// Gets the file name where Options was serialized or deserialized last time.
        /// </summary>
        [XmlIgnore]
        public string FileName
        {
            get { return m_FileName; }
        }
        #endregion
    }

    [Obfuscation(Exclude = true, ApplyToMembers = true)]
    [Serializable]
    public class FormResolutionParams
    {
        private int _screenWidth;
        private int _screenHeight;
        private int _x;
        private int _y;
        private int _width;
        private int _height;
        private FormWindowState _windowState;

        #region Constructors
        public FormResolutionParams()
        {
            _screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            _screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
        }
        #endregion

        #region Public properties
        [XmlAttribute]
        public int ScreenWidth
        {
            get { return _screenWidth; }
            set { _screenWidth = value; }
        }

        [XmlAttribute]
        public int ScreenHeight
        {
            get { return _screenHeight; }
            set { _screenHeight = value; }
        }

        [XmlAttribute]
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        [XmlAttribute]
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        [XmlAttribute]
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        [XmlAttribute]
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        [XmlAttribute]
        public FormWindowState WindowState
        {
            get { return _windowState; }
            set { _windowState = value; }
        }
        #endregion
    }

    [Obfuscation(Exclude = true, ApplyToMembers = true)]
    [Serializable]
    public class FormParams
    {
        private string _formKey;
        private List<FormResolutionParams> _resolutionParams = new List<FormResolutionParams>();

        #region Public
        public FormResolutionParams GetCurrentResolutionParams()
        {
            Size sz = Screen.PrimaryScreen.WorkingArea.Size;
            foreach (FormResolutionParams frp in _resolutionParams)
                if (frp.ScreenWidth == sz.Width && frp.ScreenHeight == sz.Height)
                    return frp;
            return null;
        }
        #endregion

        #region Public properties
        [XmlAttribute]
        public string FormKey
        {
            get { return _formKey; }
            set { _formKey = value; }
        }

        [XmlElement]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public List<FormResolutionParams> ResolutionParams
        {
            get { return _resolutionParams; }
        }
        #endregion
    }

    [Obfuscation(Exclude = true, ApplyToMembers = true)]
    [Serializable]
    public class WindowsApplicationOptions : Options
    {
        private List<FormParams> _forms = new List<FormParams>();

        #region Public
        public FormParams GetFormParams(
            string formKey)
        {
            foreach (FormParams fp in _forms)
                if (fp.FormKey == formKey)
                    return fp;
            return null;
        }
        #endregion

        #region Public properties
        [XmlElement]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public List<FormParams> Forms
        {
            get { return _forms; }
        }
        #endregion
    }
}
