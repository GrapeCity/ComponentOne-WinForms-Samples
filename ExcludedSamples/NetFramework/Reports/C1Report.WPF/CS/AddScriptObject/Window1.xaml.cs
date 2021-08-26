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

namespace AddScriptObject
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            C1Report c1r = new C1Report();
            c1r.Load(@"..\..\report.xml", "Alphabetical List of Products");
            CorrectConnectionString(c1r);
            c1r.StartReport += c1r_StartReport;

            // show a report
            Window2 w = new Window2();
            w.c1DocumentViewer1.Document = c1r.C1Document.FixedDocumentSequence;
            w.ShowDialog();
        }

        private void c1r_StartReport(object sender, EventArgs e)
        {
            C1Report c1r = (C1Report)sender;

            // expose TextBox1 control to _c1r scripts
            c1r.AddScriptObject("ExternalControl", this.textBox1);

            // expose a MathHelper object to _c1r scripts
            c1r.AddScriptObject("MathHelper", new MathHelper());
        }
    }

    public class MathHelper
    {
        public int Factorial(double value)
        {
            return (value > 1)
                ? (int)(value * Factorial(value - 1))
                : 1;
        }
    }
}
