using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouchToolkitDemo.C1ApplicationZoomPages
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
            string[] row0 = { "2012/12/22", "✕✕銀行借入金", "預金", "", "10,000", "150,000" };
            string[] row1 = { "2012/12/23", "〇〇信用組合", "預金", "20,000", "", "170,000" };
            string[] row2 = { "2012/12/23", "BOCバンク", "預金", "", "50,000", "120,000" };
            string[] row3 = { "2012/12/24", "不動産収入", "ゆうちょ", "90,000", "", "210,000" };
            string[] row4 = { "2012/12/25", "営業収入", "預金", "40,000", "", "250,000" };
            string[] row5 = { "2012/12/25", "光熱費", "ゆうちょ", "", "20,000", "230,000" };
            string[] row6 = { "2012/12/26", "スタジオ使用料", "預金", "", "22,000", "208,000" };

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
            string[] row0 = { "✕✕銀行", "2012/12/01", "前月繰越", "", "50,000", "", "50,000" };
            string[] row1 = { "JJJ信用金庫", "2012/12/05", "当座預金口座に預入", "", "80,000", "", "130,000" };
            string[] row2 = { "✕✕銀行", "2012/12/07", "A商店に掛代金支払", "G001", "", "45,000", "85,000" };
            string[] row3 = { "✕✕銀行", "2012/12/11", "B会社に仕入代金支払", "G002", "", "20,000", "65,000" };
            string[] row4 = { "〇〇信用組合", "2012/12/23", "C会社から掛代金回収", "", "35,000", "", "100,000" };
            string[] row5 = { "✕✕銀行", "2012/12/30", "次月繰越", "", "", "", "100,000" };
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

            listBox1.Items.Add("現金");
            listBox1.Items.Add("小口預金");
            listBox1.Items.Add("定期預金");
            listBox1.Items.Add("当座預金");
            listBox1.Items.Add("郵便貯金");
            listBox1.Items.Add("普通預金");
            listBox1.Items.Add("定期積金");
            listBox1.Items.Add("商品");

            listBox1.EndUpdate();
        }

        private void InitTreeView()
        {
            treeView1.BeginUpdate();
            treeView1.Nodes.Add("[資産]");
            treeView1.Nodes[0].Nodes.Add("[流動資産]");
            treeView1.Nodes[0].Nodes.Add("[固定資産]");

            #region Current Assets
            treeView1.Nodes[0].Nodes[0].Nodes.Add("[現金]");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("商品");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("小口預金");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("定期預金");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("当座預金");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("郵便貯金");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("普通預金");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("ゆうちょ預金");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("定期積金");

            treeView1.Nodes[0].Nodes[0].Nodes.Add("[契約量]");
            treeView1.Nodes[0].Nodes[0].Nodes[1].Nodes.Add("手形");
            treeView1.Nodes[0].Nodes[0].Nodes[1].Nodes.Add("不渡り手形");
            treeView1.Nodes[0].Nodes[0].Nodes[1].Nodes.Add("未収金");
            treeView1.Nodes[0].Nodes[0].Nodes[1].Nodes.Add("不良債権");
            treeView1.Nodes[0].Nodes[0].Nodes[1].Nodes.Add("契約量合計");
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
