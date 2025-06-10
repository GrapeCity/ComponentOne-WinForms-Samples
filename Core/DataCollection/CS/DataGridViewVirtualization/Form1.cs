using C1.DataCollection.BindingList;

namespace DataGridViewVirtualization
{
    public partial class Form1 : Form
    {
        private VirtualModeDataCollection collectionView;
        private C1DataCollectionBindingList bindingList;

        public Form1()
        {
            InitializeComponent();

            collectionView = new VirtualModeDataCollection();
            bindingList = new C1DataCollectionBindingList(collectionView);
            dataGridView1.DataSource = bindingList;
            c1DbNavigator1.DataSource = bindingList;

            this.HandleDestroyed += Form1_HandleDestroyed;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CleanupResources();
        }

        private void Form1_HandleDestroyed(object sender, EventArgs e)
        {
            CleanupResources();
        }

        private void CleanupResources()
        {
            try
            {
                // Disconnect the data sources 
                if (dataGridView1.DataSource != null)
                {
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                // Log the exception if needed but don't throw
                System.Diagnostics.Debug.WriteLine($"Error during cleanup: {ex.Message}");
            }
        }
    }
}
