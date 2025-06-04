using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.Win.Document;
using C1.Document.Export;

namespace PrintAndExport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // set window coordinates and state
            object wl = Properties.Settings.Default["WindowLocation"];
            object ws = Properties.Settings.Default["WindowSize"];
            object wso = Properties.Settings.Default["WindowState"];
            if (wl != null && ws != null && ((Size)ws).Width > 0 && ((Size)ws).Height > 0 && wso != null && (int)wso >= 0)
            {
                this.Location = (Point)wl;
                this.Size = (Size)ws;
                this.WindowState = (FormWindowState)wso;

                // we don't want a minimized window at startup
                if (this.WindowState == FormWindowState.Minimized)
                    this.WindowState = FormWindowState.Normal;
            }

            //
            tbFile.Text = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), @"DefaultDocument.pdf");

            //
            cbAction.Items.Add(new FileAction() { Text = "Print..." });
            var supportedExportProviders = c1PdfDocumentSource1.SupportedExportProviders;
            foreach (var sep in supportedExportProviders)
                cbAction.Items.Add(new FileAction() { Text = string.Format("Export to {0}...", sep.FormatName), ExportProvider = sep });
            cbAction.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                tbFile.Text = openFileDialog1.FileName;
            }
        }

        private class FileAction
        {
            public string Text { get; set; }

            public ExportProvider ExportProvider { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void DoPrint(C1PdfDocumentSource pds)
        {
            if (printDialog1.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                C1PrintOptions po = new C1PrintOptions();
                po.PrinterSettings = printDialog1.PrinterSettings;
                pds.Print(po);
                MessageBox.Show(this, "Document was successfully printed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DoExport(C1PdfDocumentSource pds, ExportProvider ep)
        {
            saveFileDialog1.DefaultExt = "." + ep.DefaultExtension;
            saveFileDialog1.FileName = Path.GetFileName(tbFile.Text) + "." + ep.DefaultExtension;
            saveFileDialog1.Filter = string.Format("{0} (*.{1})|*.{1}|All files (*.*)|*.*", ep.FormatName, ep.DefaultExtension);
            if (saveFileDialog1.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                var exporter = ep.NewExporter();
                exporter.ShowOptions = false;
                exporter.FileName = saveFileDialog1.FileName;
                if (exporter.ShowOptionsDialog())
                {
                    pds.Export(exporter);
                    MessageBox.Show(this, "Document was successfully exported.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFile.Text))
            {
                MessageBox.Show(this, "Please select a PDF file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!File.Exists(tbFile.Text))
            {
                MessageBox.Show(this, string.Format("File \"{0}\" does not exist.", tbFile.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // load document
            while (true)
            {
                try
                {
                    c1PdfDocumentSource1.LoadFromFile(tbFile.Text);
                    break;
                }
                catch (C1.Document.PdfPasswordException)
                {
                    string password = PasswordForm.DoEnterPassword(tbFile.Text);
                    if (password == null)
                        return;
                    c1PdfDocumentSource1.Credential.Password = password;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // execute action
            if (cbAction.SelectedIndex == 0)
                DoPrint(c1PdfDocumentSource1);
            else
                DoExport(c1PdfDocumentSource1, ((FileAction)cbAction.SelectedItem).ExportProvider);
        }

        /// <summary>
        /// Update properties at closing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default["WindowLocation"] = this.Location;
            Properties.Settings.Default["WindowSize"] = this.Size;
            Properties.Settings.Default["WindowState"] = (int)this.WindowState;
            Properties.Settings.Default.Save();
        }
    }
}
