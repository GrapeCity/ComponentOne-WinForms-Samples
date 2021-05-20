using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlExplorer.Printing
{
    public partial class MSPrintDocument : C1DemoForm
    {
        StreamReader streamToPrint;
        Font printFont;
        public MSPrintDocument()
        {
            InitializeComponent();

            c1PrintPreviewControl1.ToolBars.File.Open.Visible = false;

            var fileOpen = new ToolStripButton("Open", global::ControlExplorer.Properties.Resources.FolderOpen, Open_Click);
            c1PrintPreviewControl1.ToolBars.File.ToolStrip.Items.Insert(0, fileOpen);

            try
            {
                streamToPrint = new StreamReader(File.Open(AppDomain.CurrentDomain.BaseDirectory + "Printing\\Files\\quickstart.txt", FileMode.Open));
                System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
                try
                {
                    printFont = new Font("Arial", 10);
                    pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler
                       (this.pd_PrintPage);

                    this.c1PrintPreviewControl1.Document = pd;
                }
                finally
                {
                    streamToPrint.Close();
                    pd.PrintPage -= new System.Drawing.Printing.PrintPageEventHandler
                      (this.pd_PrintPage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                    streamToPrint = new StreamReader(fileStream, Encoding.Default);
                    System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
                    try
                    {
                        pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler
                           (this.pd_PrintPage);

                        this.c1PrintPreviewControl1.Document = pd;
                    }
                    finally
                    {
                        streamToPrint.Close();
                        pd.PrintPage -= new System.Drawing.Printing.PrintPageEventHandler
                          (this.pd_PrintPage);
                    }
                }
            }
        }

        // The PrintPage event is raised for each page to be printed.
        private void pd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            // Print each line of the file.
            while (count < linesPerPage &&
               ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                   printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }
    }
}
