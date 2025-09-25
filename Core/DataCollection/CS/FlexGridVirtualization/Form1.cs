using C1.DataCollection.BindingList;

namespace FlexGridVirtualization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            c1FlexGrid1.AutoSizeCols();
            var collectionView = new VirtualModeDataCollection();
            c1FlexGrid1.DataSource = new C1DataCollectionBindingList(collectionView);
            c1DbNavigator1.DataSource = c1FlexGrid1.DataSource;
        }
    }
}
