using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1TrueDBGrid;

namespace ControlExplorer.TrueDBGrid
{
    public partial class Exporting : C1DemoForm
    {
        public Exporting()
        {
            InitializeComponent();
           // AddProperty("DataView", c1TrueDBGrid1);
        }

        private void Exporting_Load(object sender, EventArgs e)
        {
            //Fill TrueDBGrid with data but preserve design-time layout (column order, style, etc)
            c1TrueDBGrid1.SetDataBinding(DemoDataSource("Customers_OrderByCountry"), "", false);
            
            //C1DisplayColumnCollection cols = c1TrueDBGrid1.Splits[0].DisplayColumns;
            //cols["Country"].Style.BackColor = ProfessionalColors.ToolStripGradientBegin;
            //cols["City"].Style.BackColor = ProfessionalColors.ToolStripGradientBegin;
            c1TrueDBGrid1.EvenRowStyle.BackColor = ProfessionalColors.ToolStripGradientMiddle;
        }

        private void LoadFile(string s)
        {
            System.Diagnostics.Process.Start(s);
        }

        private void c1CommandHolder1_CommandClick(object sender, C1.Win.C1Command.CommandClickEventArgs e)
        {
            if (e.Command == c1CommandExport)
            {
                c1TrueDBGrid1.ExportTo();
            }
            else if (e.Command == c1CommandExportPDF)
            {
                string pdf = GetTempFileName(".pdf");
                c1TrueDBGrid1.ExportToPDF(pdf);
                LoadFile(pdf);
            }
            else if (e.Command == c1CommandExportHtml)
            {
                string html = GetTempFileName(".htm");
                c1TrueDBGrid1.ExportToHTML(html);
                LoadFile(html);
            }
            else if (e.Command == c1CommandExportRTF)
            {
                string rtf = GetTempFileName(".rtf");
                c1TrueDBGrid1.ExportToRTF(rtf);
                LoadFile(rtf);
            }
            else if (e.Command == c1CommandExportExcel)
            {
                string xls = GetTempFileName(".xls");
                c1TrueDBGrid1.ExportToExcel(xls);
                LoadFile(xls);
            }
            else if (e.Command == c1CommandExportCSV)
            {
                string csv = GetTempFileName(".txt");
                c1TrueDBGrid1.ExportToDelimitedFile(csv, RowSelectorEnum.AllRows, ",");
                LoadFile(csv);
            }
            else if (e.Command == c1CommandPrintPreview)
            {
                c1TrueDBGrid1.PrintInfo.PrintPreview();
            }
        }
    }
}
