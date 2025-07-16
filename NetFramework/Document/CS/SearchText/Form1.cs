using System;
using System.Windows.Forms;
using System.IO;

using C1.Win.Document;
using C1.Document;

namespace SearchText
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// File name of the currently loaded document.
        /// </summary>
        private string _loadedFile = null;
        /// <summary>
        /// C1TextSearchManager instance used by the search.
        /// </summary>
        private C1TextSearchManager _textSearchManager;

        public Form1()
        {
            InitializeComponent();

            // Use sample file:
            tbFile.Text = Path.GetFullPath("DefaultDocument.pdf");

            // Create and initialize the C1TextSearchManager:
            _textSearchManager = new C1TextSearchManager(c1PdfDocumentSource1);
            _textSearchManager.FindActionCompleted += _textSearchManager_FindActionCompleted;
            _textSearchManager.FoundPositionsChanged += _textSearchManager_FoundPositionsChanged;
            _textSearchManager.LongOperation += _textSearchManager_LongOperation;

            //
            UpdateControls();
        }

        /// <summary>
        /// Long operation handler is periodically called by C1TextSearchManager.
        /// Use it to update progress bar with an approximate progress value.
        /// Note that because we use async methods on C1TextSearchManager,
        /// its event handlers run in a non-UI worker thread,
        /// so we need to use the Invoke mechanism to update the UI.
        /// </summary>
        /// <param name="sender">The event sender (C1TextSearchManager).</param>
        /// <param name="e">Event arguments.</param>
        private void _textSearchManager_LongOperation(object sender, LongOperationEventArgs e)
        {
            Invoke((MethodInvoker)(() =>
            {
                pbFind.Value = (int)Math.Round(e.Complete * pbFind.Maximum);
            }));
        }

        /// <summary>
        /// Called when the FoundPositions collection on the C1TextSearchManager has changed
        /// (i.e. some new instances of the search text were found).
        /// Use this to update the list of the found positions in our UI (via invoke).
        /// </summary>
        /// <param name="sender">The event sender (C1TextSearchManager).</param>
        /// <param name="e">Event arguments.</param>
        private void _textSearchManager_FoundPositionsChanged(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)(() =>
            {
                int n = _textSearchManager.FoundPositions.Count;
                for (int i = lvFoundPositions.Items.Count; i < n; i++)
                {
                    C1FoundPosition fp = _textSearchManager.FoundPositions[i];
                    var bounds = fp.GetBounds();
                    ListViewItem lvi = new ListViewItem(new string[]
                        {
                        (i + 1).ToString(),
                        fp.GetPage().PageNo.ToString(),
                        string.Format("{0}, {1}, {2}, {3}", (int)Math.Round(bounds.Left), (int)Math.Round(bounds.Top), (int)Math.Round(bounds.Width), (int)Math.Round(bounds.Height)),
                        fp.PositionInNearText.ToString(),
                        fp.NearText,
                        });
                    lvFoundPositions.Items.Add(lvi);
                }
            }));
        }

        /// <summary>
        /// Called when the search is finished.
        /// Update controls (via invoke), hide the progress bar.
        /// </summary>
        /// <param name="sender">The event sender (C1TextSearchManager).</param>
        /// <param name="e">Event arguments.</param>
        private void _textSearchManager_FindActionCompleted(object sender, FindActionCompletedEventArgs e)
        {
            Invoke((MethodInvoker)(() =>
            {
                UpdateControls();
                pbFind.Visible = false;
            }));
        }

        /// <summary>
        /// Disable the 'Find' button when searching, enable when done.
        /// </summary>
        private void UpdateControls()
        {
            bool enabled = !string.IsNullOrEmpty(tbFindText.Text) && !_textSearchManager.IsSearching();
            btnFind.Enabled = enabled;
        }

        /// <summary>
        /// Allow the user to choose a PDF file to search.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
                tbFile.Text = openFileDialog1.FileName;
        }

        /// <summary>
        /// Start the text search asynchronously.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFile.Text))
            {
                MessageBox.Show(this, "Please select a PDF file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(tbFile.Text))
            {
                MessageBox.Show(this, string.Format("File \"{0}\" does not exist.", tbFile.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.Compare(_loadedFile, tbFile.Text, true) != 0)
            {
                // Load the specified PDF file into c1PdfDocumentSource1.
                // The loop allows the user to specify a password for an encrypted file.
                while (true)
                {
                    try
                    {
                        c1PdfDocumentSource1.LoadFromFile(tbFile.Text);
                        _loadedFile = tbFile.Text;
                        break;
                    }
                    catch (C1.Document.PdfPasswordException)
                    {
                        string password = PasswordForm.DoEnterPassword(tbFile.Text);
                        if (password == null)
                            return;
                        c1PdfDocumentSource1.Credential.Password = password;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            // Clear the previously found positions, if any, and start the search.
            // Note the use of the FindStartAsync version of the FindStart method (a synchronous version is also available):
            lvFoundPositions.Items.Clear();
            C1FindTextParams ftp = new C1FindTextParams(tbFindText.Text, cbxWholeWord.Checked, cbxCaseSensitive.Checked);
            if (rbWholeDocument.Checked)
                _textSearchManager.FindStartAsync(0, SearchScope.WholeDocument, ftp, false);
            else
            {
                int pageNum = (int)nudPageIndex.Value;
                if (pageNum < 1 || pageNum > c1PdfDocumentSource1.PageCount)
                    MessageBox.Show(string.Format("Page should be from 0 to {0}.", c1PdfDocumentSource1.PageCount), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    _textSearchManager.FindStartAsync(pageNum - 1, SearchScope.SinglePage, ftp, false);
            }

            // Update controls and show the progress bar:
            UpdateControls();
            pbFind.Value = 0;
            pbFind.Visible = true;
        }

        /// <summary>
        /// Update controls when the search text changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbFindText_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }
    }
}
