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
using System.Windows.Forms;

namespace WPFReportViewer
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select report definition file";
                ofd.Filter = "Report definition files (*.xml)|*.xml|All files (*.*)|*.*";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        // parse file and select report definitions
                        string[] reports = C1.C1Report.C1Report.GetReportList(ofd.FileName);
                        if (reports == null || reports.Length <= 0)
                            throw new Exception(string.Format("File {0} has no reports definitions.", ofd.FileName));

                        tbFileName.Text = ofd.FileName;
                        c1DocumentViewer.FileName = ofd.FileName;

                        cbReportName.Items.Clear();
                        foreach (string reportName in reports)
                            cbReportName.Items.Add(reportName);
                        cbReportName.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        System.Windows.MessageBox.Show(string.Format("Report definition file can't be opened, error:\r{0}", ex.Message), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        c1DocumentViewer.ReportName = "";
                        c1DocumentViewer.FileName = "";
                    }
                }
            }
        }

        private void cbReportName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            c1DocumentViewer.ReportName = cbReportName.SelectedItem as string;
        }
    }
}
