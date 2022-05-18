using System;
using System.IO;
using System.Windows.Forms;

namespace TreeViewExplorer.Samples
{
    public partial class XmlImportExport : UserControl
    {
        public XmlImportExport()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new()
            {
                Filter = "Xml File | *.xml",
                InitialDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Resources"),
                FileName = "SimpleTree.xml"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    c1TreeView1.ReadXml(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "C1TreeView can't import from xml file.");
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using SaveFileDialog saveFileDialog = new()
            {
                Filter = "Xml File | *.xml",
                FileName = "C1TreeView.xml"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    c1TreeView1.WriteXml(saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "C1TreeView can't export to xml file.");
                }
            }
        }
    }
}
