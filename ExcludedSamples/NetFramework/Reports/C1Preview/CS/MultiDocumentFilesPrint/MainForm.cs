using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using C1.C1Preview;

namespace MultiDocumentFilesPrint
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MultiDocument_Click(object sender, EventArgs e)
        {
            C1MultiDocument mdoc = new C1MultiDocument();
            // make sure we can cancel the generation:
            mdoc.DoEvents = true;
            // Attach a handler to ItemGenerated to make sure all memory used by a multi-doc
            // item's generation is released when that generation is complete:
            mdoc.ItemGenerated += (ss, ee) =>
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
            };

            this._pview.Document = mdoc;

            ProgressForm pf = new ProgressForm();
            pf.Show();

            // Build the multi-document:
            try
            {
                FilesPrinter fp = new FilesPrinter();
                fp.MakeMultiDocument(mdoc, tbDir.Text, tbMask.Text, pf);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Reset cancel state of the progress form:
            pf.DialogResult = System.Windows.Forms.DialogResult.None;

            // Set up event handlers for better UI:
            this.FormClosing += (ss, ee) =>
            {
                if (mdoc.BusyState == BusyStateEnum.Generating)
                    mdoc.Cancel = true;
            };

            mdoc.LongOperation += (ss, ee) =>
            {
                pf.SetProgress(string.Format("Generating C1MultiDocument, {0:P} complete...", ee.Complete), (float)ee.Complete);
                if (pf.Cancelled && mdoc.BusyState == BusyStateEnum.Generating)
                    mdoc.Cancel = true;
            };

            mdoc.DocumentEnded += (ss, ee) =>
            {
                pf.Hide();
                this.Activate();
            };

            // Generate the multi-document:
            mdoc.Generate();
        }

        private void SingleDocument_Click(object sender, EventArgs e)
        {
            C1PrintDocument doc = new C1PrintDocument();
            // ensure document can be cancelled:
            doc.DoEvents = true;

            // load into preview:
            this._pview.Document = doc;

            ProgressForm pf = new ProgressForm();
            pf.Show();

            // Build the document:
            try
            {
                FilesPrinter fp = new FilesPrinter();
                fp.MakeMultiDocument(doc, tbDir.Text, tbMask.Text, pf);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Reset cancel state of the progress form:
            pf.DialogResult = System.Windows.Forms.DialogResult.None;

            // Set up event handlers for better UI:
            this.FormClosing += (ss, ee) =>
            {
                if (doc.BusyState == BusyStateEnum.Generating)
                    doc.Cancel = true;
            };

            doc.LongOperation += (ss, ee) =>
            {
                pf.SetProgress(string.Format("Generating C1MultiDocument, {0:P} complete...", ee.Complete), (float)ee.Complete);
                if (pf.Cancelled && doc.BusyState == BusyStateEnum.Generating)
                    doc.Cancel = true;
            };

            doc.DocumentEnded += (ss, ee) =>
            {
                pf.Hide();
                this.Activate();
            };

            // Generate the document:
            doc.Generate();
        }

        private void btnChooseDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Please select the root folder to search:";
            fbd.ShowNewFolderButton = false;
            fbd.SelectedPath = tbDir.Text;
            if (fbd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                tbDir.Text = fbd.SelectedPath;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            C1PrintDocument readme = new C1PrintDocument();
            readme.Style.FontName = "Courier New";
            readme.PageLayout.PageSettings.LeftMargin = "0.5in";
            readme.PageLayout.PageSettings.RightMargin = "0.5in";
            Assembly asm = Assembly.GetExecutingAssembly();
            using (Stream stream = asm.GetManifestResourceStream("MultiDocumentFilesPrint.readme.txt"))
            using (StreamReader sr = new StreamReader(stream))
            {
                while (!sr.EndOfStream)
                {
                    var rt = new RenderText(sr.ReadLine());
                    if (!rt.HasText)
                        rt.Height = "3mm";
                    readme.Body.Children.Add(rt);
                }
            }
            this._pview.Document = readme;
        }
    }
}
