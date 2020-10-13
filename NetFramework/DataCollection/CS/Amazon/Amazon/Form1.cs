using AmazonProducts;
using C1.DataCollection.BindingList;
using System;
using System.Windows.Forms;

namespace Amazon
{
    public partial class Form1 : Form
    {
        private const string AccessKeyId = "AKIAJAF5MJQY46TKG5AA";
        private const string SecretKey = "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";
        private const string AssociateTag = "goxuni";
        // custom CollectionView implements ISupportFiltering interface
        AmazonProductsCollectionView _collectionView = new AmazonProductsCollectionView(AccessKeyId, SecretKey, AssociateTag) { ResponseGroups = new string[] { "Small", "Images" } };

        public Form1()
        {
            InitializeComponent();
            // Use the C1CollectionViewBindingList class from C1.Win.CollectionView assembly
            // C1CollectionViewBindingList uses for binding of C1CollectionView with ms controls.
            dataGridView1.DataSource = new C1DataCollectionBindingList(_collectionView);
        }

        private async void searchBox_TextChanged(object sender, EventArgs e)
        {
            // Note: filtering is async
            await _collectionView.SearchAsync((sender as TextBox).Text);
        }
    }
}
