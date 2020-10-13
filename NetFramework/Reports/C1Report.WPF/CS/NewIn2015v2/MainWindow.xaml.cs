using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Threading;
using C1.C1Report;

namespace NewIn2015v2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        C1Report c1Report;

        public MainWindow()
        {
            InitializeComponent();

            //
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 500);
            timer.Tick += timer_Tick;
            c1Report = new C1Report();

            // fill _rbFile with initial list of the files
            // added all files in the ..\..\Reports directory
            string[] files = Directory.GetFiles(@"..\..\Reports", "*.xml");
            if (files != null)
            {
                foreach (string file in files)
                {
                    try
                    {
                        string[] reports = C1Report.GetReportList(file);
                        if ((reports != null) && (reports.Length > 0))
                            rbFile.Items.Add(file);
                    }
                    catch
                    {
                        // eat all exceptions if folder contains "not C1Report xmls"
                    }
                }
                if (rbFile.Items.Count > 0)
                    rbFile.SelectedIndex = 0;
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            // ignore tick if we currently rendering a report
            if (c1Report.IsBusy)
                return;

            //
            timer.Stop();
            // preview current report
            string file = rbFile.SelectedItem == null ? null : (string)rbFile.SelectedItem;
            string report = rbReport.SelectedItem == null ? null : (string)rbReport.SelectedItem;
            if (string.IsNullOrEmpty(report) || string.IsNullOrEmpty(file))
            {
                viewer.Document = null;
                return;
            }

            try
            {
                c1Report.Load(file, report);
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Can not load report [{1}] from file:\r\n{0}\r\n\r\nException:\r\n{2}", file, report, ex.Message), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                viewer.Document = c1Report.C1Document.FixedDocumentSequence;
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Exception during report rendering:\r\n{0}", ex.Message), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void rbFile_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            rbReport.Items.Clear();
            string file = rbFile == null ? "" : (string)rbFile.SelectedItem;
            // load list of the reports from file
            try
            {
                string[] reports = C1Report.GetReportList(file);
                foreach (string report in reports)
                {
                    rbReport.Items.Add(report);
                }
            }
            catch
            {
            }

            if (rbReport.Items.Count > 0)
                rbReport.SelectedIndex = 0;
        }

        private void rbReport_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string report = rbReport.SelectedItem == null ? "" : (string)rbReport.SelectedItem;

            // start timer do not update preview here to prevent too often updates
            timer.Stop();
            if (!String.IsNullOrEmpty(report))
                timer.Start();
        }
    }
}
