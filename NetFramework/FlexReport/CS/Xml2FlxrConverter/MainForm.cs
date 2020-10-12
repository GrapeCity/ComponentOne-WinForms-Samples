using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using C1.Win.FlexReport;

namespace Xml2FlxrConverter
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Represents a single converted, or about to be converted, report.
        /// </summary>
        private class ConvertReportItem
        {
            public C1FlexReport Report = null;
            public string Error = null;

            public override string ToString()
            {
                if (Report != null)
                    return "\r\n  Successfully converted \"" + Report.ReportName + "\".";
                else if (!string.IsNullOrEmpty(Error))
                    return "\r\n  Error: " + Error;
                else
                    return "  Unexpected error";
            }

            public void Discard()
            {
                if (Report != null)
                {
                    Report.Dispose();
                    Report = null;
                }
                Error = null;
            }
        }
        /// <summary>
        /// Represents a report definition file (which may contain multiple reports),
        /// converted or about to be converted.
        /// </summary>
        private class ConvertFileItem
        {
            public string InputFile = null;
            public string OutputFile = null;
            public string Error = null;
            public List<ConvertReportItem> ConvertReports = new List<ConvertReportItem>();

            public override string ToString()
            {
                if (!string.IsNullOrEmpty(Error))
                {
                    System.Diagnostics.Debug.Assert(ConvertReports.Count == 0);
                    return "\r\nError: " + Error;
                }

                string log = "";
                ConvertReports.ForEach(cri_ => log += cri_.ToString());
                return
                    "\r\nConverted file " + InputFile +
                    "\r\nReports:" + log;
            }

            public void Discard()
            {
                ConvertReports.ForEach(cri => cri.Discard());
            }
        }

        /// <summary>
        /// Specifies whether to embed images into the converted reports.
        /// </summary>
        bool _embedImages = true;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Logs a message.
        /// </summary>
        /// <param name="message"></param>
        private void LogLine(string message)
        {
            _txtLog.AppendText("\r\n");
            _txtLog.AppendText(message);
            Application.DoEvents();
        }

        /// <summary>
        /// Logs an object using its ToString() method.
        /// </summary>
        /// <param name="o"></param>
        private void Log(object o)
        {
            LogLine(o.ToString());
        }

        /// <summary>
        /// Handles the 'Output folder' button,
        /// allows to select a folder for the converted files.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnOutputFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (_lvwXmls.Items.Count > 0)
                    fbd.SelectedPath = Path.GetDirectoryName(_lvwXmls.Items[0].Text);
                if (fbd.ShowDialog(this) == DialogResult.OK)
                {
                    _txtOutputFolder.Text = fbd.SelectedPath;
                }
            }
        }

        /// <summary>
        /// Handles the 'Select files' button.
        /// Adds the selected files to the list view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnSelectFiles_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "C1Report Report Definition Files (*.xml)|*.xml|All Files (*.*)|*.*";
                ofd.Multiselect = true;
                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    foreach (string fn in ofd.FileNames)
                    {
                        if (!_lvwXmls.Items.ContainsKey(fn))
                        {
                            _lvwXmls.Items.Add(fn, fn, -1);
                            _lvwXmls.Items[_lvwXmls.Items.Count - 1].Checked = true;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Handles the 'Convert' button.
        /// Converts checked files, removes successfully converted files from the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnConvert_Click(object sender, EventArgs e)
        {
            bool abort = false;
            try
            {
                _btnConvert.Enabled = _btnOutputFolder.Enabled = _btnSelectFiles.Enabled = _txtOutputFolder.Enabled = false;
                Application.DoEvents();
                //
                _txtLog.Text = string.Empty;
                for (int i = 0; i < _lvwXmls.Items.Count; ++i)
                {
                    ListViewItem item = _lvwXmls.Items[i];
                    if (!item.Checked)
                        continue;
                    var cfi = ConvertFile(item.Text);
                    if (string.IsNullOrEmpty(cfi.Error))
                    {
                        WriteFile(cfi, out abort);
                        if (abort)
                            break;
                        _lvwXmls.Items.RemoveAt(i);
                        --i;
                    }
                    else
                    {
                        item.ImageKey = "Error";
                        item.ToolTipText = cfi.Error;
                        item.Checked = false;
                    }
                    cfi.Discard();
                }
            }
            finally
            {
                _btnConvert.Enabled = _btnOutputFolder.Enabled = _btnSelectFiles.Enabled = _txtOutputFolder.Enabled = true;
                Application.DoEvents();
                _btnSelectFiles.Focus();
                //
                string pad = new string('\u00a0', 20); // add some spacing to make the message box look better
                string msg = string.Format("{0}{1}{0}\t", pad, abort ? "Aborted!" : "Done!");
                MessageBox.Show(this, msg, "Xml2FlxrConverter", MessageBoxButtons.OK, abort ? MessageBoxIcon.Warning : MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Converts a single file which may contain multiple reports.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private ConvertFileItem ConvertFile(string fileName)
        {
            // Create a ConvertFileItem object which will hold the info about the file being converted.
            // If successuflly converted, that object will be passed to the method writing the .flxr file.
            ConvertFileItem convertFile = new ConvertFileItem();
            convertFile.InputFile = fileName;
            convertFile.OutputFile = Path.ChangeExtension(fileName, ".flxr");
            if (!string.IsNullOrEmpty(_txtOutputFolder.Text))
                convertFile.OutputFile = Path.Combine(_txtOutputFolder.Text, Path.GetFileName(convertFile.OutputFile));

            // load XML document
            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            try
            {
                LogLine("Converting " + fileName + "...");
                doc.Load(fileName);
            }
            catch (Exception ex)
            {
                string msg = string.Format("Could not load file: {0}.", ex.Message);
                LogLine(msg);
                convertFile.Error = msg;
                LogLine("Converting " + fileName + " aborted.");
                return convertFile;
            }

            // Get the list of reports in the file.
            string[] reports = C1FlexReport.GetReportList(doc);
            if (reports == null || reports.Length == 0)
            {
                string msg = "No reports found in file.";
                LogLine(msg);
                convertFile.Error = msg;
                LogLine("Converting " + fileName + " aborted.");
                return convertFile;
            }

            // Loop through reports, loading them into C1FlexReport instances, thus performing the conversion.
            int cnt = reports.Length;
            for (int i = 0; i < cnt; ++i)
            {
                ConvertReportItem convertReport = new ConvertReportItem();
                C1FlexReport flexReport = new C1FlexReport();
                try
                {
                    bool converted;
                    flexReport.Load(doc, reports[i], out converted);
                    convertReport.Report = flexReport;
                    LogLine(string.Format("    Converted {0}", flexReport.ReportName));
                }
                catch (Exception x)
                {
                    string msg = string.Format("Failed to convert \"{0}\": {1}", reports[i], x.Message);
                    LogLine("    " + msg);
                    convertReport.Error = msg;
                }
                convertFile.ConvertReports.Add(convertReport);
            }

            // Done. The convertFile object contains the list of converted reports.
            LogLine(fileName + " done.");
            return convertFile;
        }

        /// <summary>
        /// Writes converted reports into a .flxr file.
        /// </summary>
        /// <param name="cfi">The reports to be written.</param>
        /// <param name="abort">OUT: if true, the user aborted operation.</param>
        private void WriteFile(ConvertFileItem cfi, out bool abort)
        {
            abort = false;
        confirm_file:
            // Ask the user if a file with the target name already exists.
            if (File.Exists(cfi.OutputFile))
            {
                string msg = string.Format("File \"{0}\" exists. Overwrite?", cfi.OutputFile);
                switch (MessageBox.Show(this, msg, "Xml2FlxrConverter", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        abort = false;
                        break;
                    case DialogResult.No:
                        using (var sfd = new SaveFileDialog())
                        {
                            sfd.Filter = "FlexReport Report Definition Files (*.flxr)|*.flxr|All Files (*.*)|*.*";
                            sfd.OverwritePrompt = false;
                            sfd.FileName = cfi.OutputFile;
                            if (sfd.ShowDialog(this) == DialogResult.Cancel)
                            {
                                abort = true;
                                return;
                            }
                            cfi.OutputFile = sfd.FileName;
                            goto confirm_file;
                        }
                    case DialogResult.Cancel:
                        abort = true;
                        return;
                    default:
                        System.Diagnostics.Debug.Assert(false);
                        abort = true;
                        return;
                }
            }

            // Write the .flxr file.
            // We first write the reports into a memory stream,
            // then if successfull write the stream into the disk file.
            // This minimizes the chance of corrupted files.
            try
            {
                using (MemoryStream ms = new MemoryStream())
                using (XmlTextWriter w = new XmlTextWriter(ms, null)) // (null encoding uses utf-8 and suppresses it from xml header)
                {
                    w.Formatting = Formatting.Indented;
                    w.Indentation = 2;
                    w.WriteStartDocument();
                    // write all reports to it
                    w.WriteStartElement("Reports");
                    w.WriteStartElement("FormatVersion");
                    w.WriteString(C1FlexReport.FormatVersion.ToString());
                    w.WriteEndElement();
                    foreach (var cr in cfi.ConvertReports)
                    {
                        if (cr.Report != null)
                            cr.Report.Save(w, _embedImages, false);
                        else
                            LogLine(string.Format("Skipped failed conversion."));
                    }
                    w.WriteEndElement();
                    w.Flush();
                    // Copy content from memory stream to physical file:
                    using (FileStream fs = new FileStream(cfi.OutputFile, FileMode.Create))
                    {
                        ms.Seek(0, SeekOrigin.Begin);
                        ms.WriteTo(fs);
                        fs.Flush();
                        fs.Close();
                    }
                    w.Close();
                    ms.Close();
                }
                LogLine(string.Format("Written \"{0}\"", cfi.OutputFile));
            }
            catch (Exception ex)
            {
                string msg = string.Format("Failed to write \"{0}\": {1}", cfi.OutputFile, ex.Message);
                LogLine(msg);
                cfi.Error = msg;
            }
        }
    }
}
