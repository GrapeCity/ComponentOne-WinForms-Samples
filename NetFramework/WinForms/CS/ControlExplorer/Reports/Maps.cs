using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ControlExplorer.Reports
{
    public partial class Maps : C1DemoForm
    {
        public Maps()
        {
            InitializeComponent();
        }

        private void Maps_Load(object sender, EventArgs e)
        {
            // Set report to first option
            reportsCombo.SelectedIndex = 0;
        }

        private void reportsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Open pre-generated report file from disk
            switch (reportsCombo.SelectedIndex)
            {
                case 0:
                    c1PrintPreviewControl1.PreviewPane.FileOpen(AppDomain.CurrentDomain.BaseDirectory + "Reports\\Files\\CustomersSuppliersByCity.c1dx");
                    break;
                case 1:
                    c1PrintPreviewControl1.PreviewPane.FileOpen(AppDomain.CurrentDomain.BaseDirectory + "Reports\\Files\\EmployeeTerritories.c1dx");
                    break;
                case 2:
                    c1PrintPreviewControl1.PreviewPane.FileOpen(AppDomain.CurrentDomain.BaseDirectory + "Reports\\Files\\OrderTotalsByCountry.c1dx");
                    break;
                case 3:
                    c1PrintPreviewControl1.PreviewPane.FileOpen(AppDomain.CurrentDomain.BaseDirectory + "Reports\\Files\\CustomersSuppliersByCountry1.c1dx");
                    break;
                case 4:
                    c1PrintPreviewControl1.PreviewPane.FileOpen(AppDomain.CurrentDomain.BaseDirectory + "Reports\\Files\\CustomersSuppliersByCountry2.c1dx");
                    break;
                case 5:
                    c1PrintPreviewControl1.PreviewPane.FileOpen(AppDomain.CurrentDomain.BaseDirectory + "Reports\\Files\\OrderTotalsByState.c1dx");
                    break;
            }
        }
    }
}
