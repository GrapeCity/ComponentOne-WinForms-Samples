using System;
using System.Drawing;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using C1.Win.Themes;

namespace MaterialDesign
{
    public class SampleHelper : IDisposable
    {
        #region Fields
        private DataSet _data = new DataSet();
        #endregion Fields

        #region Events
        public event EventHandler ThemeChanged;
        protected internal void OnThemeChanged() => ThemeChanged?.Invoke(this, EventArgs.Empty);
        #endregion Events

        #region Model
        // Gets current C1Theme
        public C1Theme C1Theme { get; private set; }
        // Sets or gets current C1Theme name
        public string Theme
        {
            get { return C1Theme?.Name; }
            set
            {
                if (C1Theme == null || value != C1Theme.Name)
                {
                    C1Theme = C1ThemeController.GetThemeByName(value, true);
                    OnThemeChanged();
                }
            }
        }
        // Sets current C1Theme
        public void SetTheme(C1Theme theme)
        {
            C1Theme = theme;
            OnThemeChanged();
        }
        public DataTable GetSourceTable(string tableName, string selectCommandText)
        {
            if (_data.Tables.Contains(tableName))
                return _data.Tables[tableName];
            DataTable dt = new DataTable(tableName);
            using (var da = new OleDbDataAdapter(selectCommandText, GetConnectionString()))
            {
                da.Fill(dt);
                _data.Tables.Add(dt);
            }
            return dt;
        }
        // load bitmap image stored in blob DB field
        // this assumes the image was stored as an OLE "package"
        // (this is the format used by Access)
        public Image LoadImage(byte[] picData)
        {
            // make sure this is an embedded object
            const int bmData = 78;
            if (picData == null || picData.Length < bmData + 2) return null;
            if (picData[0] != 0x15 || picData[1] != 0x1c) return null;

            // we only handle bitmaps for now
            if (picData[bmData] != 'B' || picData[bmData + 1] != 'M') return null;

            // load the picture
            Image img = null;
            try
            {
                MemoryStream ms = new MemoryStream(picData, bmData, picData.Length - bmData);
                img = Image.FromStream(ms);
            }
            catch { }

            // return what we got
            return img;
        }
        #endregion Model

        #region Private
        private string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
        #endregion Private

        #region Singleton 
        public static SampleHelper _instance;

        public static SampleHelper Instance => _instance ?? (_instance = new SampleHelper());

        public static void DisposeInstance()
        {
            _instance.Dispose();
            _instance = null;
        }
        #endregion Singleton

        #region IDisposable
        /// <summary>
        /// Releases all unmanaged resources.
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_data != null)
                {
                    foreach (System.IDisposable table in _data.Tables)
                        table.Dispose();
                    _data.Dispose();
                }
            }
        }
        /// <summary>
		/// Releases all unmanaged resources.
		/// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion IDisposable
    }
}
