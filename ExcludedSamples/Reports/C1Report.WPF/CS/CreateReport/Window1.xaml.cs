using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Xml;

using C1.C1Report;

namespace CreateReport
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private C1Report c1r;

        public Window1()
        {
            InitializeComponent();
        }

        private void RenderEmployees()
        {
            Field f;

            // prevent reentrant calls
            if (c1r.IsBusy) return;

            // initialize control
            c1r.Clear();                // clear any existing fields
            c1r.Font.Name = "Tahoma";   // set default font for all controls
            c1r.Font.Size = 9;
            c1r.ReportName = "Employees";

            // initialize DataSource
            DataSource ds = c1r.DataSource;
            ds.ConnectionString = 
                @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                Environment.GetFolderPath(Environment.SpecialFolder.Personal) + 
                @"\ComponentOne Samples\Common\c1nwind.mdb";
            ds.RecordSource = "Employees";

            // initialize Layout
            Layout l = c1r.Layout;
            l.Orientation = OrientationEnum.Portrait;
            l.Width = 6.5 * 1440; // 8.5 - margins

            // create a report header
            Section s = c1r.Sections[SectionTypeEnum.Header];
            s.Height = 1440;
            s.Visible = true;
            s.BackColor = Color.FromArgb(255, 200, 200, 200);
            f = s.Fields.Add("FldTitle", "Employees Report", 0, 0, 8000, 1440);
            f.Font.Size = 24;
            f.Font.Bold = true;
            f.ForeColor = Color.FromArgb(255, 0, 0, 100);

            // create a page footer
            s = c1r.Sections[SectionTypeEnum.PageFooter];
            s.Height = 500;
            s.Visible = true;
            f = s.Fields.Add("FldFtrLeft", @"""Employees: Printed on "" & Now", 0, 0, 4000, 300);
            f.Calculated = true;
            f = s.Fields.Add("FldFtrRight", @"""Page "" & Page & "" of "" & Pages", 4000, 0, 4000, 300);
            f.Calculated = true;
            f.Align = FieldAlignEnum.RightTop;
            f.Width = c1r.Layout.Width - f.Left;
            f = s.Fields.Add("FldLine", "", 0, 0, c1r.Layout.Width, 20);
            f.LineSlant = LineSlantEnum.NoSlant;
            f.BorderStyle = BorderStyleEnum.Solid;
            f.BorderColor = Color.FromArgb(255, 0, 0, 100);

            // create a page header with field labels
            s = c1r.Sections[SectionTypeEnum.PageHeader];
            s.Height = 500;
            s.Visible = true;
            c1r.Font.Bold = true;
            f = s.Fields.Add("LblID", "ID", 0, 50, 400, 300);
            f.Align = FieldAlignEnum.RightTop;
            f = s.Fields.Add("LblFirstName", "First", 500, 50, 900, 300);
            f = s.Fields.Add("LblLastName", "Last", 1500, 50, 900, 300);
            f = s.Fields.Add("LblTitle", "Title", 2500, 50, 2400, 300);
            f = s.Fields.Add("LblTitle", "Notes", 5000, 50, 8000, 300);
            c1r.Font.Bold = false;
            f = s.Fields.Add("FldLine", "", 0, 400, c1r.Layout.Width, 20);
            f.LineSlant = LineSlantEnum.NoSlant;
            f.LineWidth = 50;
            f.BorderStyle = BorderStyleEnum.Solid;
            f.BorderColor = Color.FromArgb(255, 100, 100, 100);

            // create the detail section
            s = c1r.Sections[SectionTypeEnum.Detail];
            s.Height = 330;
            s.Visible = true;
            f = s.Fields.Add("FldID", "EmployeeID", 0, 0, 400, 300);
            f.Calculated = true;
            f = s.Fields.Add("FldFirstName", "FirstName", 500, 0, 900, 300);
            f.Calculated = true;
            f = s.Fields.Add("FldLastName", "LastName", 1500, 0, 900, 300);
            f.Calculated = true;
            f = s.Fields.Add("FldTitle", "Title", 2500, 0, 2400, 300);
            f.Calculated = true;
            f = s.Fields.Add("FldNotes", "Notes", 5000, 0, 8000, 300);
            f.Width = c1r.Layout.Width - f.Left;
            f.Calculated = true;
            f.CanGrow = true;
            f.Font.Size = 6;
            f.Align = FieldAlignEnum.JustTop;
            f = s.Fields.Add("FldLine", "", 0, 310, c1r.Layout.Width, 20);
            f.LineSlant = LineSlantEnum.NoSlant;
            f.BorderStyle = BorderStyleEnum.Solid;
            f.BorderColor = Color.FromArgb(255, 100, 100, 100);

            if ((bool)chkGroup.IsChecked)
            {
                // group employees by country, in ascending order
                Group grp = c1r.Groups.Add("GrpCountry", "Country", SortEnum.Ascending);
                s = grp.SectionHeader;
                s.Height = 500;
                s.Visible = true;
                f = s.Fields.Add("CtlCountry", "Country", 0, 0, c1r.Layout.Width, 500);
                f.Calculated = true;
                f.Align = FieldAlignEnum.LeftMiddle;
                f.Font.Bold = true;
                f.Font.Size = 12;
                f.BorderStyle = BorderStyleEnum.Solid;
                f.BorderColor = Color.FromArgb(255, 0, 0, 150);
                f.BackStyle = BackStyleEnum.Opaque;
                f.BackColor = Color.FromArgb(255, 150, 150, 220);
                f.MarginLeft = 100;

                // sort employees by first name within each country
                c1r.Groups.Add("GrpName", "FirstName", SortEnum.Ascending);
            }

            // render the report into the PrintPreviewControl
            c1DocumentViewer1.Document = c1r.C1Document.FixedDocumentSequence;
        }

        private void RenderCustomers()
        {
            Field f;

            // prevent reentrant calls
            if (c1r.IsBusy) return;

            // initialize control
            c1r.Clear();                 // clear any existing fields
            c1r.Font.Name = "Tahoma";    // set default font for all controls
            c1r.Font.Size = 8;
            c1r.ReportName = "Customers";

            // initialize DataSource
            DataSource ds = c1r.DataSource;
            ds.ConnectionString =
                @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
                @"\ComponentOne Samples\Common\c1nwind.mdb";
            ds.RecordSource = "Customers";

            // initialize Layout
            Layout l = c1r.Layout;
            l.Orientation = OrientationEnum.Portrait;
            l.Width = 6.5 * 1440; // 8.5 - margins

            // create a report header
            Section s = c1r.Sections[SectionTypeEnum.Header];
            s.Height = 1440;
            s.Visible = true;
            s.BackColor = Color.FromArgb(255, 200, 200, 200);
            f = s.Fields.Add("FldTitle", "Customer Report", 0, 0, 8000, 1440);
            f.Font.Size = 24;
            f.Font.Bold = true;
            f.ForeColor = Color.FromArgb(255, 100, 0, 0);

            // create a page footer
            s = c1r.Sections[SectionTypeEnum.PageFooter];
            s.Height = 500;
            s.Visible = true;
            f = s.Fields.Add("FldFtrLeft", @"""Customers: Printed on "" & Now", 0, 0, 4000, 300);
            f.Calculated = true;
            f = s.Fields.Add("FldFtrRight", @"""Page "" & Page & "" of "" & Pages", 4000, 0, 4000, 300);
            f.Calculated = true;
            f.Align = FieldAlignEnum.RightTop;
            f.Width = c1r.Layout.Width - f.Left;
            f = s.Fields.Add("FldLine", "", 0, 0, c1r.Layout.Width, 20);
            f.LineSlant = LineSlantEnum.NoSlant;
            f.BorderStyle = BorderStyleEnum.Solid;
            f.BorderColor = Color.FromArgb(255, 0, 0, 100);

            // create a page header with field labels
            s = c1r.Sections[SectionTypeEnum.PageHeader];
            s.Height = 500;
            s.Visible = true;
            c1r.Font.Bold = true;
            f = s.Fields.Add("LblID", "Company", 0, 100, 3400, 300);
            f = s.Fields.Add("LblFirstName", "Contact", 3500, 100, 1900, 300);
            f = s.Fields.Add("LblFirstName", "Contact Title", 5500, 100, 1900, 300);
            f = s.Fields.Add("LblLastName", "Phone", 7500, 100, 1200, 300);
            c1r.Font.Bold = false;
            f = s.Fields.Add("FldLine", "", 0, 400, c1r.Layout.Width, 20);
            f.LineSlant = LineSlantEnum.NoSlant;
            f.LineWidth = 50;
            f.BorderStyle = BorderStyleEnum.Solid;
            f.BorderColor = Color.FromArgb(255, 100, 100, 100);

            // create the detail section
            s = c1r.Sections[SectionTypeEnum.Detail];
            s.Height = 250;
            s.Visible = true;
            f = s.Fields.Add("FldID", "CompanyName", 0, 0, 3400, 250);
            f.Calculated = true;
            f = s.Fields.Add("FldFirstName", "ContactName", 3500, 0, 1900, 250);
            f.Calculated = true;
            f = s.Fields.Add("FldFirstName", "ContactTitle", 5500, 0, 1900, 250);
            f.Calculated = true;
            f = s.Fields.Add("FldLastName", "Phone", 7500, 0, 1200, 250);
            f.Calculated = true;

            if ((bool)chkGroup.IsChecked)
            {
                // group customers by country, in ascending order
                Group grp = c1r.Groups.Add("GrpCountry", "Country", SortEnum.Ascending);
                s = grp.SectionHeader;
                s.Height = 500;
                s.Visible = true;
                f = s.Fields.Add("CtlCountry", "Country", 0, 0, c1r.Layout.Width, 500);
                f.Calculated = true;
                f.Align = FieldAlignEnum.LeftMiddle;
                f.Font.Bold = true;
                f.Font.Size = 12;
                f.BorderStyle = BorderStyleEnum.Solid;
                f.BorderColor = Color.FromArgb(255, 0, 0, 150);
                f.BackStyle = BackStyleEnum.Opaque;
                f.BackColor = Color.FromArgb(255, 150, 150, 220);
                f.MarginLeft = 100;

                // sort customers by name within each country
                c1r.Groups.Add("GrpName", "CompanyName", SortEnum.Ascending);
            }

            // render the report into the PrintPreviewControl
            c1DocumentViewer1.Document = c1r.C1Document.FixedDocumentSequence;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            c1r = new C1Report();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cursor = Cursors.Wait;
                RenderEmployees();
            }
            finally
            {
                Cursor = Cursors.Arrow;
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cursor = Cursors.Wait;
                RenderCustomers();
            }
            finally
            {
                Cursor = Cursors.Arrow;
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            // open xml file
            string fileName = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\MyReports.xml";
            XmlTextWriter writer = new XmlTextWriter(fileName, System.Text.Encoding.Default);

            // initialize xml file
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartDocument();
            writer.WriteStartElement("Reports");

            // save Customers report
            RenderCustomers();
            c1r.ReportName = "Customers";
            c1r.Save(writer);

            // save Employees report
            RenderEmployees();
            c1r.ReportName = "Employees";
            c1r.Save(writer);

            // close xml file
            writer.WriteEndElement();
            writer.Close();
        }
    }
}
