using System.Drawing;
using System.Windows.Forms;

namespace HyperlinksInNodes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // init data
            c1TreeView1.BindingInfo.DataSource = Data.GetData();
            c1TreeView1.BindingInfo.DataMember = "Hyperlinks";
            // set hyperlink styles
            c1TreeView1.Columns[0].Styles.Default.ForeColor = Color.Blue;
            c1TreeView1.Columns[0].Styles.Hot.ForeColor = Color.Blue;
            c1TreeView1.Columns[0].CustomContentPresenter = new HyperLinkPresenter();
            c1TreeView1.ExpandAll();
        }      
    }
}
