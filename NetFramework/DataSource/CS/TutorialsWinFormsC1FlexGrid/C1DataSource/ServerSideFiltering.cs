using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TutorialsWinFormsC1FlexGrid
{
    public partial class ServerSideFiltering : Form
    {
        public ServerSideFiltering()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            // Update current filter value. It will trigger automatic loading.
            c1DataSource1.ViewSources["Products"].FilterDescriptors[0].Value = comboBox1.SelectedValue;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            c1DataSource1.ClientCache.SaveChanges();
        }
    }
}
