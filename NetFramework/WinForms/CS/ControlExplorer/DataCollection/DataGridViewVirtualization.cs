using C1.DataCollection.BindingList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.DataCollection
{
    public partial class DataGridViewVirtualization : ControlExplorer.C1DemoForm
    {
        public DataGridViewVirtualization()
        {
            InitializeComponent();

            var collectionView = new VirtualModeDataCollection();
            dataGridView1.DataSource = new C1DataCollectionBindingList(collectionView);
            c1DbNavigator1.PageSize = 20;
            c1DbNavigator1.DataSource = dataGridView1.DataSource;
        }
    }

    // * Virtual collection should inherit from C1VirtualDataCollection and implement GetPageAsync method with custom logic of getting data from the remote server.
    //public class VirtualModeDataCollection : C1VirtualDataCollection<Customer>
    //{
    //    public int TotalCount { get; set; } = 1_000;

    //    protected override async Task<Tuple<int, IReadOnlyList<Customer>>> GetPageAsync(int pageIndex, int startingIndex, int count, IReadOnlyList<C1.DataCollection.SortDescription> sortDescriptions = null, FilterExpression filterExpression = null, CancellationToken cancellationToken = default(CancellationToken))
    //    {
    //        await Task.Delay(500, cancellationToken);//Simulates network traffic.
    //        return new Tuple<int, IReadOnlyList<Customer>>(TotalCount, Enumerable.Range(startingIndex, count).Select(i => new Customer(i)).ToList());
    //    }
    //}

}
