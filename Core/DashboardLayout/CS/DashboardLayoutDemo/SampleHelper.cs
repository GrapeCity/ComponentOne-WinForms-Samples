using System;
using System.Linq;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using C1.Win.Themes;

namespace DashboardDemo
{
    public class SampleHelper: IDisposable
    {
        #region Fields
        private DataSet _data = new DataSet();
        private string _layoutsDir = Directory.GetCurrentDirectory() + @"\Layouts";
        #endregion Fields

        #region Model
        public string Theme { get; set; }
        public string DefaultLayoutPath
        {
            get
            {
                var di = new DirectoryInfo(Directory.GetCurrentDirectory() + @"\Resources");
                if (!di.Exists)
                    di.Create();
                return Directory.GetCurrentDirectory() + @"\Resources\DefaultLayout.xml";
            }
        }
        public DataTable GetSourceTable(string tableName, string selectCommandText)
        {
            DataTable dt = new DataTable(tableName);
            using (var da = new OleDbDataAdapter(selectCommandText, GetConnectionString()))
            {
                da.Fill(dt);
                _data.Tables.Add(dt);
            }
            return dt;
        }
        public void CenterPosition(Control owner, Control child)
        {
            if (owner != null && child != null)
            {
                int x = (owner.Width - child.Width) / 2;
                int y = (owner.Height - child.Height) / 2;
                child.Location = new System.Drawing.Point(x > 0 ? x : 0, y > 0 ? y : 0);
            }
        }
        public bool SaveLayoutDialog(out string filePath)
        {
            filePath = null;
            using (var dialog = new SaveLayoutForm())
            {
                if(Theme != null)
                    C1ThemeController.ApplyThemeToControlTree(dialog, C1ThemeController.GetThemeByName(Theme, false));
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if(!Directory.Exists(_layoutsDir))
                        Directory.CreateDirectory(_layoutsDir);
                    filePath = _layoutsDir + @"\" + dialog.FileName + ".xml";
                    return true;
                }
            }
            return false;
        }
        public void ManageLayoutDialog()
        {
            using (var dialog = new ManageLayoutForm(this))
            {
                if (Theme != null)
                    C1ThemeController.ApplyThemeToControlTree(dialog, C1ThemeController.GetThemeByName(Theme, false));
                dialog.ShowDialog();
            }
        }
        public string[] GetLayouts()
        {
            var di = new DirectoryInfo(_layoutsDir);
            if (di.Exists)
            {
                var files = di.GetFiles("*.xml");
                var names = files.Select(x => x.Name);
                var array = names.ToArray();
                return di.GetFiles("*.xml").Select(x => x.Name).ToArray();
            }
            return null;
        }
        public void DeleteLayout(string name)
        {
            if (Directory.Exists(_layoutsDir))
                File.Delete(GetLayoutPath(name));
        }
        public void RenameLayout(string name)
        {
            using (var dialog = new SaveLayoutForm(name))
            {
                dialog.Text = "Rename Layout";
                if (Theme != null)
                    C1ThemeController.ApplyThemeToControlTree(dialog, C1ThemeController.GetThemeByName(Theme, false));
                if (dialog.ShowDialog() == DialogResult.OK && Directory.Exists(_layoutsDir))
                    File.Move(GetLayoutPath(name), GetLayoutPath(dialog.FileName));
            }
        }
        public string GetLayoutPath(string name) => _layoutsDir + @"\" + name;
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
        #endregion

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
        #endregion
    }
}
