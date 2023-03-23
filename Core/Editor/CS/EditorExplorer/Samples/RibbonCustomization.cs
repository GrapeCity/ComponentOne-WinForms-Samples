using C1.Win.Editor;
using C1.Win.Ribbon;
using System;
using System.IO;
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
            c1Editor1.C1EditorReady += C1Editor1_C1EditorReady;
        }

        private void C1Editor1_C1EditorReady(object sender, EventArgs e)
        {
            // Load demo text to C1Editor after it is ready.
            string filename = @"Resources\tesla.html";
            if (File.Exists(filename))
            {
                c1Editor1.LoadDocument(Path.GetFullPath(filename));
                c1Editor1.SetDefaultStyles(null, true);
            }
        }

        // Handler for a custom button.
        private void FindAndReplace(object sender, EventArgs e)
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
                            c1Editor1.FindAndDecorate(find, null, "background-color: yellow");
                            break;
                        case Data.FindForm.FindAction.Replace:
                            // Find and replace text.
                            c1Editor1.FindTextReplace(find, form.ReplaceWith);
                            break;
                    }
                }
            }
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
                    _customBtn.Click -= FindAndReplace;

                _customBtn = e.Item as RibbonButton;

                if (_customBtn is not null)
                    _customBtn.Click += FindAndReplace;
            }
        }
    }
}
