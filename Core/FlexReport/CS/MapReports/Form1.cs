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

            // set window coordinates
            object xo = Properties.Settings.Default["WindowX"];
            object yo = Properties.Settings.Default["WindowY"];
            object wo = Properties.Settings.Default["WindowWidth"];
            object ho = Properties.Settings.Default["WindowHeight"];
            if (xo != null && yo != null && wo != null && ho != null && (int)wo > 0 && (int)ho > 0)
            {
                Location = new Point((int)xo, (int)yo);
                Size = new Size((int)wo, (int)ho);
            }

            // set window state
            object wso = Properties.Settings.Default["WindowState"];
            if (wso != null && (int)wso >= 0 && (int)wso < 3)
            {
                WindowState = (FormWindowState)wso;
            }

            // report list
            _reportList.Items.AddRange(C1.Win.FlexReport.C1FlexReport.GetReportList(_reportFile));
        }

        private void _btnGo_Click(object sender, EventArgs e)
        {
            c1FlexViewer1.Pane.StatusText = "Generating report, this could take a few minutes...";
            Cursor = Cursors.WaitCursor;
            _btnGo.Enabled = false;
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
            Properties.Settings.Default["WindowX"] = Location.X;
            Properties.Settings.Default["WindowY"] = Location.Y;
            Properties.Settings.Default["WindowWidth"] = Size.Width;
            Properties.Settings.Default["WindowHeight"] = Size.Height;
            Properties.Settings.Default["WindowState"] = (int)WindowState;
            Properties.Settings.Default.Save();
        }
    }
}
