using C1.Document.Export;
using C1.Document;
using C1.Report;
using System.Diagnostics;
using System.Reflection;

namespace ExportFromFlexReportAndPdf
{
    public partial class Form1 : Form
    {
        private Point location;
        public Form1()
        {
            InitializeComponent();
            tbFile.Text = GetHomePath();
            tbFile.LostFocus += (s, a) => tbFile_LostFocus(s, a);
            var supportedExportProviders = c1PdfDocumentSource1.SupportedExportProviders;
            foreach (var sep in supportedExportProviders)
                cbAction.Items.Add(new FileAction() { Text = string.Format("Export to {0}...", sep.FormatName), ExportProvider = sep });
            cbAction.SelectedIndex = 0;
            FillReprtNames();
        }

        string GetHomePath()
        {
            var a = Assembly.GetExecutingAssembly();
            var dir = Path.GetDirectoryName(a.Location);
            return Path.Combine(dir ?? string.Empty, "FlexCommonTasks.flxr");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName != string.Empty)
            {
                openFileDialog1.FileName = string.Empty;
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbFile.Text = openFileDialog1.FileName.Trim();
                FillReprtNames();
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

        private void FillReprtNames()
        {
            if (IsFlexReportFile(tbFile.Text))
            {
                cbReportName.Enabled = true;
                panel1.Visible = true;
                cbReportName.Items.Clear();
                cbReportName.Items.AddRange(FlexReport.GetReportList(tbFile.Text));
                cbReportName.SelectedIndex = 0;
            }

            if (!IsFlexReportFile(tbFile.Text))
            {
                panel1.Visible = false;
            }
        }

        private bool IsFlexReportFile(string path)
        {
            return Path.GetExtension(path.Trim().ToLower()) == ".flxr";
        }
        private bool IsImage(string path)
        {
            string extension = Path.GetExtension(path).ToLower();

            if (extension == ".bmp" || extension == ".png" || extension == ".jpg" 
                || extension == ".gif" || extension == ".tiff")
            {
                return true;
            }

            return false;
        }

        private void DoExport(C1DocumentSource pds, ExportProvider ep)
        {
            saveFileDialog1.DefaultExt = "." + ep.DefaultExtension;

            if (!IsFlexReportFile(tbFile.Text))
                saveFileDialog1.FileName = Path.GetFileName(tbFile.Text) + "." + ep.DefaultExtension;

            if (string.IsNullOrEmpty(saveFileDialog1.FileName))
                saveFileDialog1.FileName = Path.GetFileName(tbFile.Text) + "." + ep.DefaultExtension;
            saveFileDialog1.Filter = string.Format("{0} (*.{1})|*.{1}", ep.FormatName, ep.DefaultExtension);
            if (saveFileDialog1.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                var exporter = ep.NewExporter();
                exporter.ShowOptions = false;
                exporter.FileName = saveFileDialog1.FileName;
                pds.Export(exporter);
                MessageBox.Show(this, "Document was successfully exported.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!IsImage(exporter.FileName))
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = saveFileDialog1.FileName,
                        UseShellExecute = true
                    });
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
                MessageBox.Show(this, "Please select a PDF or FlexReport file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!File.Exists(tbFile.Text))
            {
                MessageBox.Show(this, string.Format("File \"{0}\" does not exist.", tbFile.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (IsFlexReportFile(tbFile.Text))
            {
                try
                {
                    var path = tbFile.Text.Trim();
                    FlexReport report = new FlexReport();
                    if (cbReportName.Items.Count == 0)
                    {
                        MessageBox.Show(this, string.Format("There are no reports in '{0}'.", path), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var reportName = cbReportName.SelectedItem.ToString();
                    report.Load(path, reportName);
                    var fileName = Path.GetFileNameWithoutExtension(path) + reportName;
                    saveFileDialog1.FileName = fileName;
                    DoExport(report, ((FileAction)cbAction.SelectedItem).ExportProvider);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, $"For {ex.Source} => {ex.Message} \n {ex.StackTrace}");
                    return;
                }
            }
            else
            {
                //// load document
                while (true)
                {
                    try
                    {
                        c1PdfDocumentSource1.LoadFromFile(tbFile.Text);
                        break;
                    }
                    catch (PdfPasswordException)
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

                DoExport(c1PdfDocumentSource1, ((FileAction)cbAction.SelectedItem).ExportProvider);
            }
        }

        private void tbFile_LostFocus(object sender, EventArgs e)
        {
            if (!File.Exists(tbFile.Text))
            {
                MessageBox.Show(this, string.Format("File \"{0}\" does not exist.", tbFile.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbReportName.Items.Clear();
                cbReportName.Enabled = false;
                return;
            }
            cbReportName.Enabled = true;
            FillReprtNames();

        }
    }
}