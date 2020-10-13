using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MapReports
{
    public partial class Form1 : Form
    {
        private readonly string _reportFile = Application.StartupPath + @"\Maps.xml";

        public Form1()
        {
            InitializeComponent();
            //
            _reportList.Items.AddRange(C1.C1Report.C1Report.GetReportList(_reportFile));
        }

        private void Go()
        {
            c1PrintPreviewControl1.PreviewPane.StatusText = "Generating report, this could take a few minutes...";
            Cursor = Cursors.WaitCursor;
            _btnGo.Enabled = false;
            Application.DoEvents();
            try
            {
                var repName = _reportList.SelectedItem as string;
                if (!string.IsNullOrEmpty(repName))
                {
                    _rep.Load(_reportFile, repName);
                    string locn = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
                    string Conn = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}\C1NWind.mdb;Persist Security Info=True", locn);
                    _rep.DataSource.ConnectionString = Conn;
                    _rep.Render();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error loading or rendering the report:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                c1PrintPreviewControl1.PreviewPane.StatusText = "Ready";
                Cursor = Cursors.Default;
                _btnGo.Enabled = true;
            }
        }

        private void _btnGo_Click(object sender, EventArgs e)
        {
            Go();
        }
    }
}
