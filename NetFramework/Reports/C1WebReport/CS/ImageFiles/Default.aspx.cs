using System;
using System.Drawing;
using System.IO;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using C1.C1Report;

namespace ImageFiles
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BuildReport();
        }

        DataTable _dtImages = null;

        private void BuildReport()
        {
            C1Report c1r = this.C1WebReport1.Report;
            c1r.Clear();

            // create header section
            Section s = c1r.Sections.Header;
            s.Visible = true;
            s.Height = 600;
            Field f = s.Fields.Add("fTitle", "Images from Files", 0, 0, 6000, s.Height);
            f.Font = new Font("Tahoma", 24, FontStyle.Bold);

            // create detail section
            s = c1r.Sections.Detail;
            s.Visible = true;
            s.Height = 3500;
            f = s.Fields.Add("fFileName", "filename", 0, 0, 5000, 300);
            f.Calculated = true;
            f.Font = new Font("Tahoma", 9);
            f = s.Fields.Add("fImage", "", 5500, 0, s.Height - 100, s.Height - 100);
            f.PictureAlign = PictureAlignEnum.Zoom;
            f.BorderStyle = BorderStyleEnum.Solid;

            // assign each filename to Picture property of the fImage field.
            // this will cause C1WebReport to load the picture.
            s.OnFormat = "fImage.Picture = filename";

            // create data source
            if (_dtImages == null)
            {
                _dtImages = CreateDataSource();
            }

            // assign data source to report
            c1r.DataSource.Recordset = _dtImages;
        }
        private DataTable CreateDataSource()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("filename", typeof(string));

            // populate data source
            string url = Request.Url.ToString();
            int i = url.LastIndexOf("/");
            url = url.Substring(0, i);
            foreach (string path in Directory.GetFiles(MapPath("Images"), "*.*"))
            {
                string fileName = Path.GetFileName(path);
                fileName = url + "/Images/" + fileName;
                dt.Rows.Add(new object[] { fileName });
            }

            // done
            return dt;
        }
    }
}
