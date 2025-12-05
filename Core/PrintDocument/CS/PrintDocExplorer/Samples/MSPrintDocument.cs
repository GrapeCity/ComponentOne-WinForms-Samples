using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintDocExplorer.Samples
{
    public partial class MSPrintDocument : UserControl
    {
        /// <summary>
        /// Allows to select whether to use C1PrintDocument or System.Drawing.Printing.PrintDocument to show file content.
        /// </summary>
        public enum PrintDocType
        {
            MSPrintDocument,
            C1PrintDocument
        }


        TextReader _streamToPrint;
        Font _printFont = new Font("Arial", 10);
        string _fileName;
        private PrintDocType _printDocumentType = PrintDocType.C1PrintDocument;

        public MSPrintDocument()
        {
            InitializeComponent();

            // hide default OpenFile button and use custom one to open file with other parameters
            c1PrintPreviewControl1.ToolBars.File.Open.Visible = false;
            var fileOpen = new ToolStripButton("Open", null, Open_Click);
            c1PrintPreviewControl1.ToolBars.File.ToolStrip.Items.Insert(0, fileOpen);

            var cmbDocType = new ToolStripComboBox();
            cmbDocType.Items.Add("C1PrintDocument");
            cmbDocType.Items.Add("MSPrintDocument");
            c1PrintPreviewControl1.ToolBars.File.ToolStrip.Items.Insert(1, cmbDocType);
            cmbDocType.SelectedIndex = 0;
            cmbDocType.SelectedIndexChanged += CmbDocType_SelectedIndexChanged;

            ShowC1Doc();
        }

        private void CmbDocType_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrintDocumentType = ((ToolStripComboBox)sender).SelectedIndex == 0 ? PrintDocType.C1PrintDocument : PrintDocType.MSPrintDocument;
        }

        [DefaultValue(PrintDocType.C1PrintDocument)]
        public PrintDocType PrintDocumentType
        {
            get => _printDocumentType;
            set
            {
                if (_printDocumentType != value)
                {
                    _printDocumentType = value;
                    if (_printDocumentType == PrintDocType.MSPrintDocument)
                    {
                        ShowMSDoc();
                    }
                    else
                    {
                        ShowC1Doc();
                    }
                }
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _fileName = openFileDialog.FileName;
                    if (PrintDocumentType == PrintDocType.MSPrintDocument)
                    {
                        ShowMSDoc();
                    }
                    else
                    {
                        ShowC1Doc();
                    }
                }
            }
        }

        /// <summary>
        /// Show document via C1PrintDocument - put all the text inside RenderText and let C1PrintDocument to handle the paging, word wrapping, etc..
        /// </summary>
        private void ShowC1Doc()
        {
            string content = string.IsNullOrEmpty(_fileName) ? strings.QUICKSTART : System.IO.File.ReadAllText(_fileName, Encoding.Default);
            var doc = new C1.C1Preview.C1PrintDocument();
            doc.Body.Children.Add(
                new C1.C1Preview.RenderText(doc, content));
            doc.Generate();
            this.c1PrintPreviewControl1.Document = doc;
        }

        /// <summary>
        /// Show document via MS's PrintDocument - generate page content from text lines
        /// </summary>
        private void ShowMSDoc()
        {
            try
            {
                _streamToPrint = string.IsNullOrEmpty(_fileName) ? new StringReader(strings.QUICKSTART)
                    : new StreamReader(File.Open(_fileName, FileMode.Open), Encoding.Default);
                System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
                try
                {
                    pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler
                       (this.pd_PrintPage);

                    this.c1PrintPreviewControl1.Document = pd;
                }
                finally
                {
                    _streamToPrint.Close();
                    pd.PrintPage -= new System.Drawing.Printing.PrintPageEventHandler
                      (this.pd_PrintPage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
               _printFont.GetHeight(ev.Graphics);

            // Print each line of the file.
            while (count < linesPerPage &&
               ((line = _streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                   _printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, _printFont, Brushes.Black,
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
