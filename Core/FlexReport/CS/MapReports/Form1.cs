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
        private readonly string _reportFile = Application.StartupPath + @"\Maps.flxr";

        public Form1()
        {
            InitializeComponent();

            // set window coordinates and state
            object wl = Properties.Settings.Default["WindowLocation"];
            object ws = Properties.Settings.Default["WindowSize"];
            object wso = Properties.Settings.Default["WindowState"];
            if (wl != null && ws != null && ((Size)ws).Width > 0 && ((Size)ws).Height > 0 && wso != null && (int)wso >= 0)
            {
                this.Location = (Point)wl;
                this.Size = (Size)ws;
                this.WindowState = (FormWindowState)wso;

                // we don't want a minimized window at startup
                if (this.WindowState == FormWindowState.Minimized)
                    this.WindowState = FormWindowState.Normal;
            }

            // report list
            _reportList.Items.AddRange(C1.Win.FlexReport.C1FlexReport.GetReportList(_reportFile));
        }

        private void _btnGo_Click(object sender, EventArgs e)
        {
            c1FlexViewer1.Pane.StatusText = "Generating report, this could take a few minutes...";
            Cursor = Cursors.WaitCursor;
            _btnGo.Enabled = false;
            c1FlexViewer1.DocumentSource = null;
            Application.DoEvents();
            try
            {
                var repName = _reportList.SelectedItem as string;
                if (!string.IsNullOrEmpty(repName))
                {
                    var rep = new C1.Win.FlexReport.C1FlexReport();
                    rep.Load(_reportFile, repName);
                    if (rep.DataSource != null)
                    {
                        string locn = Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
                                      @"\ComponentOne Samples\Common";
                        string Conn =
                            String.Format(
                                @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}\C1NWind.mdb;Persist Security Info=True",
                                locn);
                        rep.DataSource.ConnectionString = Conn;
                    }

                    c1FlexViewer1.DocumentSource = rep;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error loading or rendering the report:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                c1FlexViewer1.Pane.StatusText = "Ready";
                Cursor = Cursors.Default;
                _btnGo.Enabled = true;
            }
        }

        /// <summary>
        /// Update properties at closing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default["WindowLocation"] = this.Location;
            Properties.Settings.Default["WindowSize"] = this.Size;
            Properties.Settings.Default["WindowState"] = (int)this.WindowState;
            Properties.Settings.Default.Save();
        }
    }
}
