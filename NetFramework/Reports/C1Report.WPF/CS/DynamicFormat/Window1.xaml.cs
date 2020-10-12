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
using System.Drawing;

using C1.C1Report;

namespace DynamicFormat
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private C1Report _c1r;

        // format with script or events
        private bool _script = false;

        public Window1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // format with script
            _script = true;
            _c1r.PrintSection -= _c1r_PrintSection;

            // create report
            CreateReport("Formatted with Script");

            // render it
            Cursor = Cursors.Wait;
            _c1r.Render();
            Cursor = Cursors.Arrow;

            // and show it to the user
            Window2 w = new Window2();
            w.c1DocumentViewer1.Document = _c1r.C1Document.FixedDocumentSequence;
            w.ShowDialog();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            // format with events
            _script = false;
            _c1r.PrintSection += _c1r_PrintSection;

            // create report
            CreateReport("Formatted with Events");

            // render it
            Cursor = Cursors.Wait;
            _c1r.Render();
            Cursor = Cursors.Arrow;

            // and show it to the user
            Window2 w = new Window2();
            w.c1DocumentViewer1.Document = _c1r.C1Document.FixedDocumentSequence;
            w.ShowDialog();
        }

        // The PrintSection event gets fired after the fields in the section have been 
        // evaluated, and before they are rendered. it's a good place to change colors,
        // fonts, etc. based on values read from the database.
        //
        private void _c1r_PrintSection(object sender, C1.C1Report.ReportEventArgs e)
        {
            if (e.Section == SectionTypeEnum.Detail)
            {
                foreach (Field f in _c1r.Sections[SectionTypeEnum.Detail].Fields)
                {
                    if (f.Value is int)
                    {
                        int i = (int)f.Value;

                        int min = 300;
                        int max = 700;

                        if (i < min) f.ForeColor = Colors.DarkRed;
                        else if (i > max) f.ForeColor = Colors.DarkBlue;
                        else f.ForeColor = Colors.Black;
                    }
                }
            }
        }

        private void CreateReport(string reportTitle)
        {
            // clear any existing reports
            //
            _c1r.Clear();

            // set new report name
            //
            _c1r.ReportName = reportTitle;

            // initialize layout
            //
            _c1r.Layout.Orientation = OrientationEnum.Landscape;

            // create data source object and assign it to new report
            // (in this case, the DataSource is a DataView object)
            //
            System.Data.DataView dv = CreateDataSource(8, 200);
            _c1r.DataSource.Recordset = dv;

            // add a group 
            // (sort data by region)
            //
            _c1r.Groups.Add("Region Group", "Region", SortEnum.Ascending);

            // initialize group header section
            //
            Section ghdr = _c1r.Sections[SectionTypeEnum.GroupHeader1];
            ghdr.Height = 600;					// twips
            ghdr.Visible = true;				// make new section visible
            ghdr.BackColor = Colors.DarkBlue;	// give section a solid background
            ghdr.Repeat = true;					// repeat after page breaks

            // add group header fields
            //
            _c1r.Font = new Font("Arial", 12, System.Drawing.FontStyle.Bold);
            Field f = ghdr.Fields.Add("grpHdr", "Region & \" Region Data\"", new System.Drawing.Rectangle(50, 0, 4000, 600));
            f.Calculated = true;
            f.ForeColor = Colors.White;
            f.Align = FieldAlignEnum.LeftBottom;

            // initialize page header section
            //
            Section shdr = _c1r.Sections[SectionTypeEnum.PageHeader];
            shdr.Height = 1200;					// twips
            shdr.Visible = true;				// make new section visible

            // add page header fields
            //

            // report title
            _c1r.Font = new Font("Arial", 14, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            shdr.Fields.Add("rptName", _c1r.ReportName, new System.Drawing.Rectangle(0, 0, 8000, 400));

            // page number
            _c1r.Font = new Font("Arial", 9, System.Drawing.FontStyle.Bold);
            f = shdr.Fields.Add("pgNum", "\"Page \" & Page", new System.Drawing.Rectangle(9000, 0, 1000, 300));
            f.Calculated = true;

            // initialize detail section
            //
            Section sdtl = _c1r.Sections[SectionTypeEnum.Detail];
            sdtl.Height = 300;
            sdtl.Visible = true;

            // initialize script
            // (data values are between 100 and 1000)
            //
            string script = "", scriptFmt = "";
            if (_script)
            {
                script = "MinVal = 300\nMaxVal = 700\n";
                scriptFmt =
                    "{0}.ForeColor = rgb(50,0,0)\n" +
                    "if {0}.Value < MinVal then {0}.ForeColor = rgb(150,0,0)\n" +
                    "if {0}.Value > MaxVal then {0}.ForeColor = rgb(0,150,0)\n";
            }

            // create report fields
            //
            int fldCtr = 0;
            System.Drawing.Rectangle rc = new System.Drawing.Rectangle(0, 0, 1000, 300);
            foreach (System.Data.DataColumn col in dv.Table.Columns)
            {
                // add page header labels
                rc.Height = (int)shdr.Height;
                _c1r.Font = new Font("Arial", 10, System.Drawing.FontStyle.Bold);
                f = shdr.Fields.Add(col.ColumnName + "Hdr", col.ColumnName, rc);
                f.Calculated = false;
                f.ForeColor = Colors.LightGray;
                f.Align = (col.DataType == typeof(int))
                    ? FieldAlignEnum.RightBottom
                    : FieldAlignEnum.LeftBottom;

                // add detail field (note square brackets since field names have spaces)
                rc.Height = (int)sdtl.Height;
                _c1r.Font = new Font("Arial", 9);
                string fldName = string.Format("fld{0}", fldCtr++);
                f = sdtl.Fields.Add(fldName, "[" + col.ColumnName + "]", rc);
                f.Calculated = true;

                // if this field is numeric, add script
                if (_script)
                {
                    if (col.DataType == typeof(int))
                        script += string.Format(scriptFmt, fldName);
                }

                // move on to the next field
                rc.Offset(rc.Width, 0);
            }

            // assign script to detail section OnPrint event
            // (after fields have been evaluated)
            //
            if (_script)
                sdtl.OnPrint = script;

            // save report definition (for debugging only)
            //
            //_c1r.Save(@"c:\test.xml");
        }

        // create data source for the report
        private System.Data.DataView CreateDataSource(int cols, int rows)
        {
            // create table
            System.Data.DataTable dt = new System.Data.DataTable("test");

            // add region column
            dt.Columns.Add("Region", typeof(string));

            // add data columns
            for (int c = 1; c < cols; c++)
                dt.Columns.Add("Col " + c.ToString(), typeof(int));

            // add rows
            Random rnd = new Random();
            string[] region = { "North", "South", "East", "West" };
            object[] values = (object[])Array.CreateInstance(typeof(object), cols);
            for (int r = 0; r < rows; r++)
            {
                values[0] = region[rnd.Next(3)];
                for (int c = 1; c < cols; c++)
                    values[c] = rnd.Next(100, 1000);
                dt.Rows.Add(values);
            }

            // done
            return dt.DefaultView;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _c1r = new C1Report();
        }
    }
}
