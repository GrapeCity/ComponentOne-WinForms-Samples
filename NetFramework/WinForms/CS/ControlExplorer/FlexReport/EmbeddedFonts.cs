using C1.Word;
using C1.Win.C1Document;
using C1.Win.FlexReport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using C1.Win.Input;
using System.Diagnostics;
using C1.Report;

namespace ControlExplorer.FlexReport
{
    public partial class EmbeddedFonts : C1DemoForm
    {
        int _selectedIndex = 0;
        bool loading = false;

        public EmbeddedFonts()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RenderReport(@"FlexReport\FlexReportDemo.flxr");
        }

        private void RenderReport(string reportPath)
        {
            LoadReports(reportPath);
            if (c1ComboBox1.Items.Count > 0)
            {
                var reportName = c1ComboBox1.Items[0].ToString();
                if (!string.IsNullOrEmpty(reportName))
                {
                    c1ComboBox1.SelectedIndex = _selectedIndex;
                    RenderReport(reportPath, reportName);
                }
            }
        }
        private void RenderReport(string reportPath, string reportName)
        {
            loading = true;
            c1FlexReport1.Load(reportPath, reportName);
            c1FlexReport1.Render();
            c1FlexViewer1.DocumentSource = c1FlexReport1;

            var list = new List<string>();
            foreach (var fontData in c1FlexReport1.Fonts)
            {
                list.Add(fontData.Name);
            }
            c1MultiSelect1.BindingInfo.DataSource = list;
            for (int i = 0; i < c1MultiSelect1.Items.Count; i++)
            {
                c1MultiSelect1.Items[i].Selected = (c1FlexReport1.Fonts[i].Embed != FontEmbedType.None);
            }
            loading = false;
        }

        private void LoadReports(string path)
        {
            var startReport = false;
            var startReportName = false;
            c1ComboBox1.Items.Clear();

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (XmlReader reader = XmlReader.Create(fs))
            {
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            switch (reader.Name)
                            {
                                case "Report":
                                    startReport = true;
                                    break;
                                case "Name":
                                    if (startReport)
                                    {
                                        startReportName = true;
                                        startReport = false;
                                    }
                                    break;
                            }
                            break;
                        case XmlNodeType.Text:
                            if (startReportName)
                            {
                                c1ComboBox1.Items.Add(reader.Value);
                                startReportName = false;
                            }
                            break;
                        case XmlNodeType.EndElement:
                        default:
                            break;
                    }
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "FlexReport files (*.flxr)|*.flxr"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RenderReport(openFileDialog.FileName);
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "FlexReport files (*.flxr)|*.flxr"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                c1FlexReport1.Save(saveFileDialog.FileName, true);
            }
        }

        private void c1ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = c1ComboBox1.SelectedIndex;
            if (idx >= 0 && idx != _selectedIndex)
            {
                var reportName = c1ComboBox1.Items[idx].ToString();
                c1FlexReport1.Load(reportName);
                c1FlexReport1.Render();
                _selectedIndex = idx;
            }
        }

        private void c1MultiSelect1_SelectionChanged(object sender, EventArgs e)
        {
            if (loading) return;
            for (int i = 0; i < c1MultiSelect1.Items.Count; i++)
            {
                c1FlexReport1.Fonts[i].Embed = c1MultiSelect1.Items[i].Selected ? FontEmbedType.Auto : FontEmbedType.None;
            }
        }
    }
}
