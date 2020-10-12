using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouchToolKitDemo.C1ApplicationZoomPages
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
            string[] row0 = { "2012/12/22", "✕✕ Bank Loan", "Deposit", "", "10,000", "150,000" };
            string[] row1 = { "2012/12/23", "〇〇 Credit Union", "Deposit", "20,000", "", "170,000" };
            string[] row2 = { "2012/12/23", "BOC Bank", "Deposit", "", "50,000", "120,000" };
            string[] row3 = { "2012/12/24", "Rent Recieved", "Post", "90,000", "", "210,000" };
            string[] row4 = { "2012/12/25", "Operating Income", "Deposit", "40,000", "", "250,000" };
            string[] row5 = { "2012/12/25", "Utility Charges", "Post", "", "20,000", "230,000" };
            string[] row6 = { "2012/12/26", "Studio Rent", "Deposit", "", "22,000", "208,000" };

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
            string[] row0 = { "✕✕ Bank", "2012/12/01", "Carried over from previous month", "", "50,000", "", "50,000" };
            string[] row1 = { "JJJ Credit Association", "2012/12/05", "Deposit in a checking account", "", "80,000", "", "130,000" };
            string[] row2 = { "✕✕ Bank", "2012/12/07", "Collection of receivables from Store A", "G001", "", "45,000", "85,000" };
            string[] row3 = { "✕✕ Bank", "2012/12/11", "Pay Company B for purchase", "G002", "", "20,000", "65,000" };
            string[] row4 = { "〇〇 Credit Union", "2012/12/23", "Collection of receivables from Company C", "", "35,000", "", "100,000" };
            string[] row5 = { "✕✕ Bank", "2012/12/30", "Carried forward to the next month", "", "", "", "100,000" };
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
            listBox1.Items.Add("Small Deposit");
            listBox1.Items.Add("Fixed Deposit");
            listBox1.Items.Add("Current Deposit");
            listBox1.Items.Add("Postal Savings");
            listBox1.Items.Add("Ordinary Deposit");
            listBox1.Items.Add("Periodic Deposit");
            listBox1.Items.Add("Products");

            listBox1.EndUpdate();
        }

        private void InitTreeView()
        {
            treeView1.BeginUpdate();
            treeView1.Nodes.Add("[Assets]");
            treeView1.Nodes[0].Nodes.Add("[Current Assets]");
            treeView1.Nodes[0].Nodes.Add("[Fixed Assets]");

            #region Current Assets
            treeView1.Nodes[0].Nodes[0].Nodes.Add("[Cash]");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("Goods");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("Small Deposit");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("Fixed Deposit");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("Current Deposit");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("Postal Savings");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("Ordinary Deposit");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("Postal Deposit");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("Periodic Deposit");

            treeView1.Nodes[0].Nodes[0].Nodes.Add("[Contract Amount]");
            treeView1.Nodes[0].Nodes[0].Nodes[1].Nodes.Add("Bill");
            treeView1.Nodes[0].Nodes[0].Nodes[1].Nodes.Add("Dishonored Bill");
            treeView1.Nodes[0].Nodes[0].Nodes[1].Nodes.Add("Account Receivable");
            treeView1.Nodes[0].Nodes[0].Nodes[1].Nodes.Add("Bad Debt");
            treeView1.Nodes[0].Nodes[0].Nodes[1].Nodes.Add("Total Contract Amount");
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
