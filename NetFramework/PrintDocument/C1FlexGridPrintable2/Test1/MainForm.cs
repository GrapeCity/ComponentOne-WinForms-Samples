using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win;
using C1.Win.C1FlexGrid;

namespace C1FlexGridPrinterTest
{
    public partial class MainForm : Form
    {
        private SampleWrapper _selectedWrapper = null;
        private C1.Win.C1FlexGrid.C1FlexGridPrintInfo _printInfo = new C1FlexGridPrintInfo();

        public MainForm()
        {
            InitializeComponent();
            FillSamplesCombo();
            pgPrintInfo.SelectedObject = _printInfo;
            btnPreviewSample.Enabled = false;
            comboBox1.SelectedIndex = 0;
        }

        private void FillSamplesCombo()
        {
            // comboBox1.Items.Add(new SampleWrapper(typeof(Test1), "Test1"));
            comboBox1.Items.Add(new SampleWrapper(typeof(Test2.Form1), "Test2"));
            comboBox1.Items.Add(new SampleWrapper(typeof(Analyze.Analyze), "Analyze"));
            comboBox1.Items.Add(new SampleWrapper(typeof(AutoSizeRows.AutoSizeRows), "AutoSizeRows"));
            // comboBox1.Items.Add(new SampleWrapper(typeof(RibbonFlexGridPreview.Form1), "RibbonFlexGridPreview"));
            comboBox1.Items.Add(new SampleWrapper(typeof(BarChart.Form1), "BarChart"));
            comboBox1.Items.Add(new SampleWrapper(typeof(BoundImageMap.Form1), "BoundImageMap"));
            comboBox1.Items.Add(new SampleWrapper(typeof(ColumnFilters.Form1), "ColumnFilters"));
            comboBox1.Items.Add(new SampleWrapper(typeof(ColumnOrder.Form1), "ColumnOrder"));
            comboBox1.Items.Add(new SampleWrapper(typeof(CrossTabs.Form1), "CrossTabs"));
            comboBox1.Items.Add(new SampleWrapper(typeof(CustomAlign.Form1), "CustomAlign"));
            comboBox1.Items.Add(new SampleWrapper(typeof(CustomMerge.Form1), "CustomMerge"));
            comboBox1.Items.Add(new SampleWrapper(typeof(CustomMerge2.Form1), "CustomMerge2"));
            comboBox1.Items.Add(new SampleWrapper(typeof(CustomMergeLogic.Form1), "CustomMerge3"));
            comboBox1.Items.Add(new SampleWrapper(typeof(CustomMerge4.Form1), "CustomMerge4"));
            comboBox1.Items.Add(new SampleWrapper(typeof(CustomPrint.Form1), "CustomPrint"));
            comboBox1.Items.Add(new SampleWrapper(typeof(CustomPrintMultiGrid.Form1), "CustomPrintMultiGrid"));
            comboBox1.Items.Add(new SampleWrapper(typeof(CustomSort.Form1), "CustomSort"));
            comboBox1.Items.Add(new SampleWrapper(typeof(DataIndex.Form1), "DataIndex"));
            comboBox1.Items.Add(new SampleWrapper(typeof(DataTableSample.Form1), "DataTable"));
            comboBox1.Items.Add(new SampleWrapper(typeof(DataTree.Form1), "DataTree"));
            comboBox1.Items.Add(new SampleWrapper(typeof(DynamicStyles.Form1), "DBDynamicStyles"));
            comboBox1.Items.Add(new SampleWrapper(typeof(DBImageField.Form1), "DBImageField"));
            comboBox1.Items.Add(new SampleWrapper(typeof(DBImages.Form1), "DBImages"));
            comboBox1.Items.Add(new SampleWrapper(typeof(HostControls.Form1), "HostControls"));
            comboBox1.Items.Add(new SampleWrapper(typeof(HyperlinkSample.Form1), "Hyperlink"));
            comboBox1.Items.Add(new SampleWrapper(typeof(MergeStyles.Form1), "MergeStyles"));
            comboBox1.Items.Add(new SampleWrapper(typeof(MultiGridDocument.Form1), "MultiGridDocument"));
            comboBox1.Items.Add(new SampleWrapper(typeof(MultiSelection.Form1), "MultiSelection"));
            comboBox1.Items.Add(new SampleWrapper(typeof(NewFeatures20091.Form1), "NewFeatures20091"));
            comboBox1.Items.Add(new SampleWrapper(typeof(Outline.Form1), "Outline"));
            comboBox1.Items.Add(new SampleWrapper(typeof(OwnerDraw.Form1), "OwnerDraw"));
            comboBox1.Items.Add(new SampleWrapper(typeof(OwnerDrawAlpha.Form1), "OwnerDrawAlpha"));
            comboBox1.Items.Add(new SampleWrapper(typeof(PasswordChar.Form1), "PasswordChar"));
            comboBox1.Items.Add(new SampleWrapper(typeof(PdfExport.Form1), "PdfExport"));
            comboBox1.Items.Add(new SampleWrapper(typeof(Renderer.Form1), "Renderer"));
            comboBox1.Items.Add(new SampleWrapper(typeof(RTFGrid.Form1), "RTFGrid"));
            comboBox1.Items.Add(new SampleWrapper(typeof(Splits.Form1), "Splits"));
            comboBox1.Items.Add(new SampleWrapper(typeof(Subtotals.Form1), "Subtotals"));
            comboBox1.Items.Add(new SampleWrapper(typeof(Themes.Form1), "Themes"));
            comboBox1.Items.Add(new SampleWrapper(typeof(TreeCheck.Form1), "TreeCheck"));
            comboBox1.Items.Add(new SampleWrapper(typeof(TreeNode.Form1), "TreeNode"));
            comboBox1.Items.Add(new SampleWrapper(typeof(TriStateBound.Form1), "TriStateBound"));
            comboBox1.Items.Add(new SampleWrapper(typeof(UnboundColumns.Form1), "UnboundColumns"));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedWrapper != null)
                _selectedWrapper.FormChanged -= _selectedWrapper_FormChanged;
            _selectedWrapper = comboBox1.SelectedItem as SampleWrapper;
            if (_selectedWrapper != null)
                _selectedWrapper.FormChanged += _selectedWrapper_FormChanged;
        }

        void _selectedWrapper_FormChanged(object sender, EventArgs e)
        {
            btnPreviewSample.Enabled = _selectedWrapper != null && _selectedWrapper.Form != null;
        }

        private void btnShowSample_Click(object sender, EventArgs e)
        {
            if (_selectedWrapper != null)
            {
                _selectedWrapper.Show();
            }
        }

        private void btnPreviewSample_Click(object sender, EventArgs e)
        {
            C1.C1Preview.C1PrintDocument doc = null;
            if (_selectedWrapper != null)
            {
                doc = _selectedWrapper.MakeDoc(_printInfo, printer_LongOperation);
                if (doc == null)
                {
                    C1FlexGrid flex = _selectedWrapper.Flex;
                    if (flex != null)
                    {
                        C1.Win.C1FlexGrid.C1FlexGridPrinter printer = new C1.Win.C1FlexGrid.C1FlexGridPrinter(flex);
                        printer.LongOperation += new LongOperationEventHandler(printer_LongOperation);

                        doc = new C1.C1Preview.C1PrintDocument();
                        printer.PrintInfo = _printInfo;
                        C1.C1Preview.RenderObject gridRO = printer.MakeGridTable(doc);
                        // if flex grid borders are not printed, provide our own:
                        if (!_printInfo.PrintBorders && chkOverrideBorders.Checked)
                            gridRO.Style.GridLines.All = new C1.C1Preview.LineDef("0.5pt", Color.LightGray);
                        doc.Body.Children.Add(gridRO);
                        doc.PageLayout.PageHeader = printer.MakePageHeader(doc);
                        doc.PageLayout.PageFooter = printer.MakePageFooter(doc);
                    }
                }
            }

            if (doc != null)
            {
                doc.PageLayout.PageSettings.Landscape = chkLandscape.Checked;
                C1.Win.C1Preview.C1PrintPreviewDialog pview = new C1.Win.C1Preview.C1PrintPreviewDialog();
                // Assign document after showing the dialog - this delays generation
                // and improves user experience for long documents:
                // pview.Document = doc;
                pview.Shown += (o, ev) => { pview.Document = doc; };
                pview.ShowDialog();
                progressBar1.Value = 0;
                label2.Text = string.Format((string)label2.Tag, 0);
            }
            else
            {
                MessageBox.Show("Could not load the selected sample.");
            }
        }

        void printer_LongOperation(object sender, LongOperationEventArgs e)
        {
            progressBar1.Value = (int)(e.Complete * 100);
            label2.Text = string.Format((string)label2.Tag, e.Complete);
            Application.DoEvents();
        }
    }
}
