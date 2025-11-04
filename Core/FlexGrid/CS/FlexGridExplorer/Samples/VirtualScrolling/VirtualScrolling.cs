using C1.DataCollection.BindingList;
using FlexGridVirtualization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexGridExplorer.Samples.VirtualScrolling
{
    public partial class VirtualScrolling : UserControl
    {
        public VirtualScrolling()
        {
            InitializeComponent();
            c1FlexGrid1.AutoSizeCols();
            var collectionView = new VirtualModeDataCollection();
            c1FlexGrid1.DataSource = new C1DataCollectionBindingList(collectionView);
            c1DbNavigator1.DataSource = c1FlexGrid1.DataSource;
        }
    }
}
