using C1.Win.Editor;
using C1.Win.Ribbon;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorExplorer.Samples
{
    public partial class RibbonCustomization : UserControl
    {
        private RibbonButton _customBtn;

        public RibbonCustomization()
        {
            InitializeComponent();
            _customBtn = btnFind;

            c1Editor1.C1EditorReady += C1Editor1_C1EditorReadyAsync;
            c1Editor1.ClientSizeChanged += C1Editor1_Resize;
            c1Editor1.SizeChanged += C1Editor1_Resize;
        }
        private void C1Editor1_Resize(object sender, EventArgs e)
        {
            c1Editor1.Focus();
        }

        private async void C1Editor1_C1EditorReadyAsync(object sender, EventArgs e)
        {
            // Load demo text to C1Editor after it is ready.
            string filename = @"Resources\tesla.html";
            if (File.Exists(filename))
            {
                await c1Editor1.LoadDocumentAsync(Path.GetFullPath(filename));
                await c1Editor1.SetDefaultStylesAsync(null, true);
            }
        }

        // Handler for a custom button.
        private async void FindAndReplaceAsync(object sender, EventArgs e)
        {
            // Show Find and Replace form.
            using (var form = new Data.FindForm())
            {
                form.StartPosition = FormStartPosition.Manual;
                form.Location = Cursor.Position;

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    string find = form.FindText;

                    // Nohing to find or replace.
                    if (string.IsNullOrEmpty(find))
                        return;

                    // Hanale actions.
                    switch (form.Action)
                    {
                        case Data.FindForm.FindAction.Find:
                            // Find and highlight text.
                            var count = await c1Editor1.FindAndDecorateAsync(find, null, "background-color: yellow");
                            if (!count.HasValue || count == 0)
                                MessageBox.Show("No results found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case Data.FindForm.FindAction.Replace:
                            // Find and replace text.
                            await c1Editor1.FindTextReplaceAsync(find, form.ReplaceWith);
                            break;
                    }
                }
            }
        }

        private async void OpenDevToolsAsync(object sender, EventArgs e)
        {
            await c1Editor1.ShowDevToolsAsync();
        }

        private void btnCustomize_Click(object sender, EventArgs e)
        {
            // Load the layout with customized ribbon.
            c1EditorRibbon1.Load(@"Resources\CustomizedRibbon.xml");
        }

        private void rtnReset_Click(object sender, EventArgs e)
        {
            // Reset C1EdtiorRibbon to its default appearance.
            c1EditorRibbon1.Reset();
        }

        private void c1EditorRibbon1_ItemDeserialized(object sender, C1.Win.Ribbon.ItemDeserializedEventArgs e)
        {
            if (e.Item.Name == "btnFind")
            {
                if (_customBtn is not null)
                    _customBtn.Click -= FindAndReplaceAsync;

                _customBtn = e.Item as RibbonButton;

                if (_customBtn is not null)
                    _customBtn.Click += FindAndReplaceAsync;
            }
        }
    }
}
