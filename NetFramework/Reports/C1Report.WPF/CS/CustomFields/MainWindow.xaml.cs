using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace CustomFields_2010
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string ReportFile = "CustomFieldsDemo.xml";
        private readonly List<Button> _buttons = new List<Button>();

        public MainWindow()
        {
            InitializeComponent();
            
            var top = 40;
            const int left = 10;
            const int height = 40;
            const int width = 180;

            var reportNames = C1.C1Report.C1Report.GetReportList(ReportFile);
            foreach (var reportName in reportNames)
            {
                var button = new Button
                {
                    Margin = new Thickness(left, top, 0, 0),
                    Width = width,
                    Height = height,
                    HorizontalAlignment = HorizontalAlignment.Left,
                    VerticalAlignment = VerticalAlignment.Top,
                    Content = reportName,
                    FontSize = 14f
                };

                gridReports.Children.Add(button);
                button.Click += button_Click;

                _buttons.Add(button);
                top += 45;
            }

            if (_buttons.Count > 0)
            {
                _buttons[0].RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
            }

        }

        void button_Click(object sender, RoutedEventArgs e)
        {
            var buttonSelected = sender as Button;
            if (buttonSelected == null) return;

            foreach (var button in _buttons)
            {
                button.Background = SystemColors.ControlBrush;
            }
            buttonSelected.Background = SystemColors.ControlDarkBrush;
            
            c1DocumentViewer1.Document = null;
            labelStatus.Content = "Generating report, this could take a few minutes...";
            Cursor = Cursors.Wait;

            try
            {
                var report = new C1.C1Report.C1Report();
                var reportName = buttonSelected.Content.ToString();
                report.Load(ReportFile, reportName);

                CorrectConnectionString(report);
                c1DocumentViewer1.Document = report.C1Document.FixedDocumentSequence;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error loading or rendering the report:\n" + ex.Message, "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                labelStatus.Content = "Ready";
                Cursor = Cursors.Arrow;
            }
        }

        private void CorrectConnectionString(C1.C1Report.C1Report rep)
        {
            string connectionString = rep.DataSource.ConnectionString;

            int dsIndexStart = connectionString.IndexOf("Data Source", 0, StringComparison.OrdinalIgnoreCase);
            if (dsIndexStart < 0) return;

            while (dsIndexStart < connectionString.Length && connectionString[dsIndexStart] != '=') dsIndexStart++;
            if (dsIndexStart >= connectionString.Length)
                return;

            int dsIndexEnd = dsIndexStart;
            while (dsIndexEnd < connectionString.Length && connectionString[dsIndexEnd] != ';') dsIndexEnd++;

            string mdbName = connectionString.Substring(dsIndexStart + 1, dsIndexEnd - dsIndexStart - 1).Trim();
            if (mdbName.Length <= 0) return;

            mdbName = System.IO.Path.GetFileName(mdbName);
            if (string.Compare(mdbName, "nwind.mdb", true) == 0)
                mdbName = "c1nwind.mdb";

            connectionString = connectionString.Substring(0, dsIndexStart + 1) +
                               Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
                               @"\ComponentOne Samples\Common\" +
                               mdbName +
                               connectionString.Substring(dsIndexEnd);

            rep.DataSource.ConnectionString = connectionString;

            foreach (C1.C1Report.Field field in rep.Fields)
                if (field.Subreport != null) CorrectConnectionString(field.Subreport);
        }

    }
}
