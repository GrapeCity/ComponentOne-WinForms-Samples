using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouchToolkitExplorer.C1ApplicationZoomPages
{
    public partial class AppZoom_Child1 : Form
    {
        public AppZoom_Child1()
        {
            InitializeComponent();
            PopulateDateGridView1();
            dataGridView1.RowCount = 100;
            PopulateDateGridView2();
            dataGridView2.RowCount = 100;

            InitRecentlyUsedSubjects();

            InitTreeView();
        }

        #region DataGridView
        private void PopulateDateGridView1()
        {
            string[] row0 = { "2012/12/22", "✕✕Bank borrowings", "Deposits", "", "10,000", "150,000" };
            string[] row1 = { "2012/12/23", "Credit Union", "Deposit", "20,000", "", "170,000" };
            string[] row2 = { "2012/12/23", "BOC bank", "Deposit", "", "50,000", "120,000" };
            string[] row3 = { "2012/12/24", "Real Estate Income", "Japan Post", "90,000", "", "210,000" };
            string[] row4 = { "2012/12/25", "Operating income", "Deposits", "40,000", "", "250,000" };
            string[] row5 = { "2012/12/25", "Utilities", "Japan Post", "", "20,000", "230,000" };
            string[] row6 = { "2012/12/26", "Studio Usage", "Deposit", "", "22,000", "208,000" };

            {
                DataGridViewRowCollection rows = this.dataGridView1.Rows;
                rows.Add(row0);
                rows.Add(row1);
                rows.Add(row2);
                rows.Add(row3);
                rows.Add(row4);
                rows.Add(row5);
                rows.Add(row6);

            }
        }

        private void PopulateDateGridView2()
        {
            string[] row0 = { "✕✕ Bank", " 2012/12/01", "Previous month", "", "50,000", "", "50,000" };
            string[] row1 = { "JJJ Credit vault", "2012/12/05", "When the seat pre-opening seat is pre-entered", "", "80,000", "", "130,000" };
            string[] row2 = { "✕✕ Bank", "2012/12/07", "A store-linked debit payment", "G001", "", "45,000", "85,000" };
            string[] row3 = { "✕✕ Bank", " 2012/12/11", "B-company in lieu of payment", "G002", "", "20,000", "65,000" };
            string[] row4 = { "〇〇 Credit mix", "2012/12/23", "C-company-linked payment", "", "35,000", "", "100,000" };
            string[] row5 = { "✕✕ Bank", " 2012/12/30", "Next month", "", "", "", "100,000" };

            {
                DataGridViewRowCollection rows = this.dataGridView2.Rows;
                rows.Add(row0);
                rows.Add(row1);
                rows.Add(row2);
                rows.Add(row3);
                rows.Add(row4);
                rows.Add(row5);

            }
        }
        #endregion

        private void InitRecentlyUsedSubjects()
        {
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.BeginUpdate();

            listBox1.Items.Add("Cash");
            listBox1.Items.Add("Small deposit");
            listBox1.Items.Add("Regular Advance");
            listBox1.Items.Add("When the seat is pre-paid");
            listBox1.Items.Add("Postal Savings");
            listBox1.Items.Add("Ordinary Advance");
            listBox1.Items.Add("Regular MPF");
            listBox1.Items.Add("Goods");

            listBox1.EndUpdate();
        }

        private void InitTreeView()
        {
            treeView1.BeginUpdate();
            treeView1.Nodes.Add("[Assets]");
            treeView1.Nodes[0].Nodes.Add("[Liquid Assets]");
            treeView1.Nodes[0].Nodes.Add("[Fixed Assets]");

            #region Current Assets
            treeView1.Nodes[0].Nodes[0].Nodes.Add("[Cash]");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("Goods");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("Small deposit");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("Regular Advance");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("When the seat is pre-paid");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("Postal Savings");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("Ordinary Advance");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("Misc");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("Regular MPF");

            treeView1.Nodes[0].Nodes[0].Nodes.Add("[Contract quantity]");
            treeView1.Nodes[0].Nodes[0].Nodes[1].Nodes.Add("Hand shape");
            treeView1.Nodes[0].Nodes[0].Nodes[1].Nodes.Add("Do not cross the hand shape");
            treeView1.Nodes[0].Nodes[0].Nodes[1].Nodes.Add("Non-payment");
            treeView1.Nodes[0].Nodes[0].Nodes[1].Nodes.Add("Bad Debt");
            treeView1.Nodes[0].Nodes[0].Nodes[1].Nodes.Add("Total contract quantity");
            #endregion

            treeView1.Nodes[0].Nodes[1].Nodes.Add("......");

            treeView1.EndUpdate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppZoom_Child3 form = new AppZoom_Child3();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

    }
}
