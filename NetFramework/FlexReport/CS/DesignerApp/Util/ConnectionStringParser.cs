//----------------------------------------------------------------------------
// ConnectionStringParser.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace FlexReportDesignerApp.Util
{
    /// <summary>
    /// Splits connection string to values pairs.
    /// Contains methods for case insensitive searching.
    /// </summary>
    public class ConnectionStringParser
    {
        private List<string> _keys = new List<string>();
        private List<string> _values = new List<string>();

        #region Constructors
        public ConnectionStringParser()
        {
        }
        #endregion

        #region Public static
        public static ConnectionStringParser Parse(
            string connectionString)
        {
            if (connectionString == null || connectionString.Trim().Length == 0)
                return null;
            string[] subStrings = connectionString.Split(';');
            ConnectionStringParser result = new ConnectionStringParser();
            foreach (string s in subStrings)
            {
                if (s.Trim().Length == 0)
                    continue;
                int i = s.IndexOf('=');
                if (i <= 0)
                    return null;
                result._keys.Add(s.Substring(0, i).Trim());
                result._values.Add(s.Substring(i + 1));
            }
            return result;
        }
        #endregion

        #region Public
        /// <summary>
        /// Returns location of data used by connection string. For example, for string like:
        /// Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AdventureWorks2008R2;Data Source=localhost
        /// This method returns:
        /// localhost\\AdventureWorks2008R2
        /// </summary>
        /// <returns></returns>
        public string GetDataLocation()
        {
            string dataSource = this["data source"];
            if (string.IsNullOrEmpty(dataSource))
                dataSource = this["dsn"];
            string path = this["Initial Catalog"];
            if (string.IsNullOrEmpty(path))
                path = this["Initial File Name"];
            if (string.IsNullOrEmpty(path))
                path = this["dbq"];
            if (string.IsNullOrEmpty(dataSource))
                return path;
            else if (string.IsNullOrEmpty(path))
                return dataSource;
            else
                return dataSource + "\\\\" + path;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < _keys.Count; i++)
                if (!string.IsNullOrEmpty(_values[i]))
                    result.Append(string.Format("{0}={1};", _keys[i], _values[i]));
            if (result.Length > 0)
                result.Remove(result.Length - 1, 1);
            return result.ToString();
        }
        #endregion

        #region Public properties
        public int Count
        {
            get { return _keys.Count; }
        }

        public List<string> Keys
        {
            get { return _keys; }
        }

        public List<string> Values
        {
            get { return _values; }
        }

        public string this[string key]
        {
            get
            {
                for (int i = 0; i < _keys.Count; i++)
                    if (string.Compare(_keys[i], key, true) == 0)
                        return _values[i];
                return null;
            }
            set
            {
                for (int i = 0; i < _keys.Count; i++)
                    if (string.Compare(_keys[i], key, true) == 0)
                    {
                        if (value == null)
                        {
                            _keys.RemoveAt(i);
                            _values.RemoveAt(i);
                        }
                        else
                            _values[i] = value;
                        return;
                    }
                _keys.Add(key);
                _values.Add(value);
            }
        }
        #endregion
    }
}
