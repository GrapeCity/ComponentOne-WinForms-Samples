using System;
using System.Windows.Forms;

namespace EditorExplorer.Data
{
    public partial class EmojiForm : Form
    {
        public EmojiForm()
        {
            InitializeComponent();
        }

        public string EmojiCode { get; private set; }

        private void Cancel()
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OnEmojiClick(object sender, EventArgs e)
        {
            EmojiCode = ((Control)sender).Tag as string;
            DialogResult = DialogResult.OK;
            Close();
        }

        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
            if (DialogResult != DialogResult.OK)
                Cancel();
        }

        protected override void WndProc(ref Message m)
        {
            // WM_NCACTIVATE
            if (m.Msg == 0x86 && m.WParam.ToInt32() == 0 && DialogResult != DialogResult.OK)
            {
                // The user is trying to change the window. Cancel
                Cancel();
            }
            base.WndProc(ref m);
        }
    }
}