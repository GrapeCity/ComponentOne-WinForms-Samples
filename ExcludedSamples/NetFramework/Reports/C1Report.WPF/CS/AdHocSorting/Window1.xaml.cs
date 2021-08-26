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

using C1.C1Report;

namespace AdHocSorting
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private C1Report _c1r;

        public Window1()
        {
            InitializeComponent();
        }

        private void CorrectConnectionString(C1.C1Report.C1Report rep)
        {
            string cs = rep.DataSource.ConnectionString;

            //
            int i = cs.IndexOf("Data Source", 0, StringComparison.OrdinalIgnoreCase);
            if (i < 0)
                return;
            while (i < cs.Length && cs[i] != '=') i++;
            if (i >= cs.Length)
                return;
            int j = i;
            while (i < cs.Length && cs[i] != ';') i++;

            //
            string mdbName = cs.Substring(j + 1, i - j - 1).Trim();
            if (mdbName.Length <= 0)
                return;
            mdbName = System.IO.Path.GetFileName(mdbName);
            if (string.Compare(mdbName, "nwind.mdb", true) == 0)
                mdbName = "c1nwind.mdb";

            //
            cs = cs.Substring(0, j + 1) +
                Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
                @"\ComponentOne Samples\Common\" +
                mdbName +
                cs.Substring(i);

            rep.DataSource.ConnectionString = cs;

            //
            foreach (C1.C1Report.Field field in rep.Fields)
                if (field.Subreport != null)
                    CorrectConnectionString(field.Subreport);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _c1r = new C1Report();
            _c1r.Load(@"..\..\report.xml", "Alphabetical List of Products Report");
            CorrectConnectionString(_c1r);

            // populate list with fields available for sorting
            char[] badChars = new char[] { '&', '(', ')', ' ' };
            foreach (Field f in _c1r.Fields)
            {
                if (f.Calculated && f.Text.IndexOfAny(badChars) < 0)
                    listBox1.Items.Add(f.Text);
            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // apply sorting expression to report's first (and only) group
            _c1r.Groups[0].GroupBy = listBox1.SelectedItem as string;
            if ((bool)rbAscending.IsChecked)
                _c1r.Groups[0].Sort = SortEnum.Ascending;
            else
                _c1r.Groups[0].Sort = SortEnum.Descending;

            // show report
            Window2 w = new Window2();
            w.Title = "Report sorted by " + listBox1.SelectedItem as string;
            w.c1DocumentViewer1.Document = _c1r.C1Document.FixedDocumentSequence;
            w.ShowDialog();
        }
    }
}
