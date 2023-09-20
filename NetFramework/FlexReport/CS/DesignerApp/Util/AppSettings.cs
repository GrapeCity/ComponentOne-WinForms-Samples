//----------------------------------------------------------------------------
// AppSettings.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Xml;
using System.Reflection;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Globalization;

namespace FlexReportDesignerApp.Util
{
	/// <summary>
	/// AppSettings
	/// </summary>
	public static class AppSettings
	{
        public const string c_recentFiles = "recentfiles";
        public const string c_lastLoadedFile = "lastloadedfile";
        public const string c_lastLoadedReport = "lastloadedreport";

        private static string _fileName;
		private static XmlDocument _doc;
        private static Encryptor _encryptor;
        private static bool _fips = false;
        // loads version info from the .settings file so that backward incompatibilities can be handled:
        private static string _loadedSettingsVersion = string.Empty;

        #region Constructors
        static AppSettings()
        {
#if CLR40 || CLR45
            _fips = CryptoConfig.AllowOnlyFipsAlgorithms;
            if (!_fips)
                _encryptor = new Encryptor("alksid3u5a8w9qe", "ccsdwweqssawq34");
            else
                _encryptor = null;
#else
            try
            {
                _encryptor = new Encryptor("alksid3u5a8w9qe", "ccsdwweqssawq34");
            }
            catch (InvalidOperationException)
            {
                _fips = true;
                _encryptor = null;
            }
#endif
            // determine filename and load document
            // 1. if exists settings file in ApplicationData folder when use it
            // 2. if file can be created in application folder when use it
            // 3. otherwise use ApplicationData

            string appDataFile = null;
            string appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string localFileName = Application.ExecutablePath + ".settings";
            if (string.IsNullOrEmpty(appDataDir))
            {
                // system directory Application Data simple not defined so we use 
                // file in application dir
                _fileName = localFileName;
            }
            else
            {
                appDataDir = appDataDir + "\\C1Report\\";
                appDataFile = string.Format("{0}{1}.settings", appDataDir, Path.GetFileName(Application.ExecutablePath));
                if (File.Exists(appDataFile))
                {
                    // in Application Data already exists settings file simple use it
                    _fileName = appDataFile;
                }
                else
                {
                    _fileName = localFileName;
                }
            }

            // load document
            _doc = new XmlDocument();
            if (File.Exists(_fileName))
            {
                try
                {
                    _doc.Load(_fileName);
                }
                catch
                {
                    string msg = string.Format(Strings.AppSettings.ErrCannotLoadSettingsFmt, _fileName);
                    // MessageBox.Show(msg, Strings.AppSettings.InvalidSettingsTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageForm.Warn(msg);
                }
            }

            // make sure we have a "settings" node
            XmlNode settings = _doc.DocumentElement;
            if (settings == null || settings.Name != "settings")
            {
                _doc.RemoveAll();
                _doc.AppendChild(_doc.CreateElement("settings"));
            }

            // now try to save file but only if file is not readonly
            if (_fileName == localFileName)
            {
                if (!IsReadOnly(_fileName))
                {
                    try
                    {
                        _doc.Save(_fileName);
                    }
                    catch
                    {
                        // exception occurs
                        if (appDataFile != null)
                            _fileName = appDataFile;
                    }
                }
            }

            //
            if (_fileName == appDataFile)
            {
                // ensure that directory appDataDir exists
                try
                {
                    if (!Directory.Exists(appDataDir))
                        Directory.CreateDirectory(appDataDir);
                }
                catch
                {
                }
            }

            _loadedSettingsVersion = LoadValue("version");
        }
        #endregion

        //-------------------------------------------------------------------
		#region ** public
        public static string GetSettingsVersion()
        {
            return _loadedSettingsVersion;
        }

        public static void GetSettingsVersion(out int major, out int minor, out int build, out int rev)
        {
            major = minor = build = rev = 0;
            AppUtils.ParseVersionString(_loadedSettingsVersion, out major, out minor, out build, out rev);
        }

        public static void SaveValue(string name, string value)
        {
            XmlNode node = GetNode(name, false);
            node.InnerText = value;
            SaveDocument();
        }

        public static string LoadValue(string name)
        {
            XmlNode node = GetNode(name, true);
            if (node != null)
                return node.InnerText;
            else
                return null;
        }

        public static void SaveList(string listName, IList list, bool encrypt, Action<string> warner)
		{
            if (encrypt && _fips)
            {
                FipsWarning(warner, "list", listName, false);
                return;
            }

			// get empty list node
			XmlNode node = GetNode(listName, false);

			// append all children
			foreach (object value in list)
			{
				AppendElement(node, value.ToString(), null, encrypt);
			}

			// save document just in case
			SaveDocument();
		}

        public static ArrayList LoadList(string listName, Action<string> warner)
		{
			// create new list
			ArrayList list = new ArrayList();

			// get list node
			XmlNode node = GetNode(listName, true);
			if (node == null) return list;

			// load all elements children
            bool fips = false;
			foreach (XmlNode item in node.ChildNodes)
			{
                bool decryptFail;
                string value = GetNodeValue(item, out decryptFail);
                if (decryptFail)
                    fips = true;
                else if (value != null)
                    list.Add(value);
			}

            // report error if any:
            if (fips && warner != null)
                FipsWarning(warner, "list", listName, true);

			// return new list
			return list;
		}

        public static void SaveDictionary(string dictName, IDictionary dict, bool encrypt, Action<string> warner)
		{
            if (encrypt && _fips)
            {
                FipsWarning(warner, "dictionary", dictName, false);
                return;
            }

			// get empty dictionary node
			XmlNode node = GetNode(dictName, false);

			// append all children
            foreach (string key in dict.Keys)
            {
                AppendElement(node, dict[key], key, encrypt);
            }

			// save document just in case
			SaveDocument();
		}

        public static ListDictionary LoadDictionary(string dictName, Action<string> warner)
		{
			// create new dictionary
			ListDictionary dict = new ListDictionary();

			// get dictionary node
			XmlNode node = GetNode(dictName, true);
			if (node == null) return dict;

			// load all elements children
            bool fips = false;
            foreach (XmlNode item in node.ChildNodes)
			{
                if (item.Attributes != null && item.Attributes["key"] != null)
                {
                    string key = item.Attributes["key"].Value;
                    bool decryptFail;
                    string value = GetNodeValue(item, out decryptFail);
                    if (decryptFail)
                        fips = true;
                    else if (key != null && value != null)
                        dict[key] = value;
                }
			}

            // report error if any:
            if (fips && warner != null)
                FipsWarning(warner, "dictionary", dictName, true);

			// return new dictionary
			return dict;
		}

        public static void SaveObject(string name, object obj)
		{
			// get empty object node
			XmlNode node = GetNode(name, false);

			// save all properties
			foreach (PropertyInfo pi in obj.GetType().GetProperties())
			{
				// don't save if we can't read/write
				if (!pi.CanRead || !pi.CanWrite)
				{
					continue;
				}

				// don't save if it's hidden
				object[] visibility = pi.GetCustomAttributes(typeof(DesignerSerializationVisibilityAttribute), true);
				if (visibility.Length == 1 && ((DesignerSerializationVisibilityAttribute)visibility[0]).Visibility == DesignerSerializationVisibility.Hidden)
				{
					continue;
				}

				// don't save if it's null
				object value = pi.GetValue(obj, null);
				if (value == null)
				{
					continue;
				}

				// don't save if this is the default value
				object[] defVal = pi.GetCustomAttributes(typeof(DefaultValueAttribute), true);
                if (defVal.Length == 1 && value.Equals(((DefaultValueAttribute)defVal[0]).Value))
				{
					continue;
				}

				// convert value to string
				TypeConverter tc = TypeDescriptor.GetConverter(pi.PropertyType);
				value = tc.ConvertToInvariantString(value);

				// build node
				XmlNode prop = _doc.CreateElement(pi.Name);
				XmlAttribute attVal = _doc.CreateAttribute("value");
				attVal.Value = value.ToString();
				prop.Attributes.Append(attVal);

				// save node
				node.AppendChild(prop);
			}

			// save document just in case
			SaveDocument();
		}

		public static void LoadObject(string name, object obj)
		{
			// get object node
			XmlNode node = GetNode(name, true);
			if (node == null) 
			{
				Debug.WriteLine(string.Format("object '{0}' not found in settings file.", name));
				return;
			}

			// load all properties
			foreach (PropertyInfo pi in obj.GetType().GetProperties())
			{
				// don't load if we can't write
				if (!pi.CanWrite) continue;

				// get the node
				XmlNode prop = node.SelectSingleNode(pi.Name);
				if (prop == null) continue;
				if (prop.Attributes == null || prop.Attributes["value"] == null)
				{
					continue;
				}

				// set the property value
				string str = prop.Attributes["value"].Value;
				try
				{
					TypeConverter tc = TypeDescriptor.GetConverter(pi.PropertyType);
					object value = tc.ConvertFromInvariantString(str);
					if (value != null)
					{
						pi.SetValue(obj, value, null);
					}
				}
				catch
				{
					Debug.WriteLine("failed to load property: " + pi.Name);
				}
			}
		}
		#endregion

		//-------------------------------------------------------------------
		#region ** private
        private static bool IsReadOnly(string fileName)
        {
            return File.Exists(fileName) && ((File.GetAttributes(_fileName) & FileAttributes.ReadOnly) != 0);
        }
		
        private static void SaveDocument()
		{
            // check that the file is not read-only
            if (IsReadOnly(_fileName))
                return;

            XmlNode node = GetNode("version", false);
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            node.InnerText = fvi.FileVersion;

            _doc.Save(_fileName);
		}
		
        private static XmlNode GetNode(string listName, bool loading)
		{
			// use lower-case
			listName = listName.ToLower();

			// get document, settings
			XmlDocument doc = _doc;
			XmlNode settings = doc.DocumentElement;

			// get list node
			XmlNode node = settings.SelectSingleNode(listName);

			// if loading, we're done
			if (loading)
			{
				return node;
			}

			// saving, create node or empty it
			if (node == null)
			{
				node = settings.AppendChild(doc.CreateElement(listName));
			}
			else
			{
				node.RemoveAll();
			}

			// done
			return node;
		}

        /// <summary>
        /// Gets the value of a node, decrypting it if needed.
        /// </summary>
        /// <param name="item">The item to get the value of.</param>
        /// <param name="noEncryptor">OUT: if true, decryption was required but unavailable (i.e. user should be warned).</param>
        /// <returns>The item's value (null if decryption was needed but unavailable).</returns>
        private static string GetNodeValue(XmlNode item, out bool noEncryptor)
        {
            noEncryptor = false;
            string value = null;
            if (item.Attributes != null && item.Attributes["value"] != null)
            {
                value = item.Attributes["value"].Value;
                XmlAttribute att = item.Attributes["encrypt"];
                if (att != null && att.Value == "true")
                {
                    if (!_fips)
                        value = _encryptor.Decrypt(value);
                    else
                    {
                        noEncryptor = true;
                        value = null;
                    }
                }
            }
            return value;
        }
		
        private static void AppendElement(XmlNode node, object value, object key, bool encrypt)
		{
            Debug.Assert(!encrypt || _encryptor != null, "caller should have checked availability of encryption");

			// create element
			XmlElement item = _doc.CreateElement("item");

            // add key attribute
            if (key != null)
            {
                XmlAttribute att = _doc.CreateAttribute("key");
                att.Value = key.ToString();
                item.Attributes.Append(att);
            }

            // add encryption attribute
            if (encrypt)
            {
                XmlAttribute att = _doc.CreateAttribute("encrypt");
                att.Value = "true";
                item.Attributes.Append(att);
            }

            // add value attribute
			XmlAttribute attVal = _doc.CreateAttribute("value");
            attVal.Value = encrypt
                ? _encryptor.Encrypt(value.ToString())
                : value.ToString();
			item.Attributes.Append(attVal);

			// add the new item to the list
			node.AppendChild(item);
		}

        private static void FipsWarning(Action<string> warner, string collType, string collName, bool loading)
        {
            string wrn;
            if (loading)
                wrn = string.Format(Strings.AppSettings.WarnEncryptedInFipsLoadingFmt, collType, collName);
            else
                wrn = string.Format(Strings.AppSettings.WarnEncryptedInFipsSavingFmt, collType, collName);
            warner(wrn);
        }
		#endregion
	}
}
