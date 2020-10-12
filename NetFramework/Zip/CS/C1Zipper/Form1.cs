using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.C1Zip;

namespace C1Zipper
{
    public partial class Form1 : Form
    {
        // ** fields
        C1ZipFile _zipFile;     // the zip file
        bool _escape;			// user hit escape
        bool _cancel;			// user wants to cancel
        bool _freezeList;       // don't refresh while updating
        bool _ascending;        // list view sort order

        // ** ctor
        public Form1()
        {
            InitializeComponent();

            _zipFile = new C1ZipFile();
            _zipFile.Progress += _zipFile_Progress;
        }

        //---------------------------------------------------------------------------
        #region ** main menu event handlers

        // create a new zip file
        void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show dialog
            var sf = new SaveFileDialog();
            sf.DefaultExt = "zip";
            sf.Filter = "Zip files (*.zip)|*.zip";
            if (sf.ShowDialog(this) == DialogResult.OK)
            {
                // create a new empty zip file
                _zipFile.Create(sf.FileName);

                // update user interface
                UpdateUI();
            }
        }

        // open an existing zip file
        void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // select zip file
            var of = new OpenFileDialog();
            of.DefaultExt = "zip";
            of.Filter = "Zip files (*.zip)|*.zip";
            if (of.ShowDialog(this) == DialogResult.OK)
            {
                // open zip file
                OpenZip(of.FileName);
            }
        }
        void OpenZip(string fn)
        {
            // make sure this is a valid zip file
            if (!File.Exists(fn)) return;
            if (!C1ZipFile.IsZipFile(fn)) return;

            // open zip file
            try
            {
                _zipFile.Open(fn);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Open Zip File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // update user interface
            UpdateUI();
        }

        // close current zip file
        void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _zipFile.Close();
            UpdateUI();
        }

        // exit the application
        void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // select all entries in the current zip file
        void selectAlllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in _list.Items)
            {
                lvi.Selected = true;
            }
        }

        // unselect all entries in the current zip file
        void unselectAlllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in _list.Items)
            {
                lvi.Selected = true;
            }
        }

        // invert selection
        void invertSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in _list.Items)
            {
                lvi.Selected = !lvi.Selected;
            }
        }

        // extract files
        void extractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get a folder name from user
            var dlg = new FolderBrowserDialog();
            dlg.ShowNewFolderButton = false;
            dlg.SelectedPath = Path.GetDirectoryName(_zipFile.FileName);
            if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                var folder = dlg.SelectedPath;
                foreach (ListViewItem lvi in _list.SelectedItems)
                {
                    var ze = (C1ZipEntry)lvi.Tag;
                    try
                    {
                        if ((ze.Attributes & FileAttributes.Directory) != 0)
                        {
                            var newFolder = Path.Combine(folder, ze.FileName);
                            if (!Directory.Exists(newFolder))
                            {
                                Directory.CreateDirectory(newFolder);
                            }
                        }
                        else
                        {
                            var dstFileName = Path.Combine(folder, Path.GetFileName(ze.FileName));
                            _zipFile.Entries.Extract(ze.FileName, dstFileName);
                        }
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message, "Test Zip File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // delete files
        void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // build an array of strings containing the selected file names
            var files = new List<string>();
            foreach (ListViewItem lvi in _list.SelectedItems)
            {
                var ze = (C1ZipEntry)lvi.Tag;
                files.Add(ze.FileName);
            }

            // remove files from the zip
            // (this is a lot quicker than removing the files one by one)
            _zipFile.Entries.Remove(files.ToArray());

            // update user interface
            UpdateUI();
        }

        // add files
        void addFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // select files to add
            var of = new OpenFileDialog();
            of.Multiselect = true;
            if (of.ShowDialog(this) == DialogResult.OK)
            {
                // warn user of encryption 
                if (_zipFile.Password.Length > 0)
                {
                    string msg = "File(s) will be encrypted!\n\r" +
                                 "Current password: " + _zipFile.Password;
                    DialogResult dr = MessageBox.Show(msg, "Add Files", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.Cancel)
                        return;
                }

                // add the files
                AddFileList(of.FileNames, 0);
            }
        }

        // add a whole folder
        void addFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get a folder name from user
            var dlg = new FolderBrowserDialog();
            dlg.ShowNewFolderButton = false;
            dlg.SelectedPath = Path.GetDirectoryName(_zipFile.FileName);
            if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                // warn user of encryption 
                if (_zipFile.Password.Length > 0)
                {
                    string msg = "File(s) will be encrypted using the current password:\n\r" + _zipFile.Password;
                    var dr = MessageBox.Show(msg, "Add Folder", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.Cancel)
                        return;
                }

                // freeze display while adding folders 
                // (if they have many subfolders, there's too much painting going on)
                _freezeList = true;

                // add folder
                _cancel = _escape = false;
                AddFolder(dlg.SelectedPath);

                // display list
                _freezeList = false;
                UpdateUI();
            }
        }

        // test all entries in the zip file
        void testAllFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // just in case
            _zipFile.Refresh();
            UpdateUI();

            // test each entry
            bool bOk = true;
            _cancel = false;
            foreach (C1ZipEntry ze in _zipFile.Entries)
            {
                // update ui
                UpdateStatusBar("Checking " + ze.FileName);
                if (CheckUserCancel()) break;

                // check file
                try
                {
                    if (ze.CheckCRC32() == false)
                    {
                        string msg = "** " + ze.FileName + " failed CRC check. **";
                        MessageBox.Show(msg, "Test Zip File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bOk = false;
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message, "Test Zip File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bOk = false;
                }
            }

            // if everything is cool, tell the user
            UpdateStatusBar();
            if (bOk)
            {
                int cnt = _zipFile.Entries.Count;
                UpdateStatusBar((cnt > 0)
                    ? cnt.ToString() + " files tested OK."
                    : "Nothing to test...");
            }
        }

        // edit zip file comment
        void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_zipFile.FileName))
            {
                var dlg = new UserInputDialog();
                dlg.Font = this.Font;
                var comment = dlg.GetString("Enter new comment for the zip file", _zipFile.Comment);
                if (comment != null)
                {
                    _zipFile.Comment = comment;
                }
                UpdateStatusBar();
            }
        }

        // edit selected entry comment
        void entryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_list.SelectedItems.Count > 0)
            {
                // get current comment, if any
                var ze = (C1ZipEntry)_list.SelectedItems[0].Tag;
                var dlg = new UserInputDialog();
                dlg.Font = this.Font;
                var comment = dlg.GetString("Enter new comment for the zip file", ze.Comment);
                if (comment != null)
                {
                    ze.Comment = comment;
                }
                UpdateStatusBar();
            }
        }

        // set compression level
        void compressionLevelToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // update check marks
            var item = e.ClickedItem as ToolStripMenuItem;
            foreach (ToolStripMenuItem mi in compressionLevelToolStripMenuItem.DropDownItems)
            {
                mi.Checked = mi.Equals(item);
            }

            // update compression level
            if (item.Equals(defaultToolStripMenuItem))
            {
                _zipFile.CompressionLevel = CompressionLevelEnum.DefaultCompression;
            }
            else if (item.Equals(bestCompressionToolStripMenuItem))
            {
                _zipFile.CompressionLevel = CompressionLevelEnum.BestCompression;
            }
            else if (item.Equals(bestSpeedToolStripMenuItem))
            {
                _zipFile.CompressionLevel = CompressionLevelEnum.BestSpeed;
            }
            else if (item.Equals(noCompressionToolStripMenuItem))
            {
                _zipFile.CompressionLevel = CompressionLevelEnum.NoCompression;
            }
            else
            {
                throw new Exception("Should never get here!");
            }
        }

        // set zip file password
        void passwordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show dialog
            var dlg = new UserInputDialog();
            dlg.Font = this.Font;
            string new_password = dlg.GetString("Choose a password", _zipFile.Password);

            // if user provided a new password, use it
            if (new_password != null)
            {
                _zipFile.Password = new_password;
            }
        }

        // select view mode
        void viewModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // adjust checkmarks
            var item = (ToolStripMenuItem)sender;
            foreach (object o in viewToolStripMenuItem.DropDownItems)
            {
                var mi = o as ToolStripMenuItem;
                if (mi != null)
                {
                    mi.Checked = mi.Equals(item);
                }
            }

            // switch view
            if (item.Equals(largeIconsToolStripMenuItem))
            {
                _list.View = View.LargeIcon;
            }
            else if (item.Equals(smallIconsToolStripMenuItem))
            {
                _list.View = View.SmallIcon;
            }
            else if (item.Equals(listToolStripMenuItem))
            {
                _list.View = View.List;
            }
            else if (item.Equals(detailToolStripMenuItem))
            {
                _list.View = View.Details;
            }
            else
            {
                throw new Exception("Should never get here!");
            }
        }

        // show selected entry
        void selectedEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get first selected item that is not a directory
            foreach (ListViewItem lvi in _list.SelectedItems)
            {
                var ze = (C1ZipEntry)lvi.Tag;
                if ((ze.Attributes & FileAttributes.Directory) == 0)
                {
                    // read entry content
                    var entry = ze.OpenReader();
                    var sr = new StreamReader(entry, Encoding.Default);
                    string entryText = sr.ReadToEnd();
                    entry.Close();

                    // show it in dialog
                    var view = new ViewDialog();
                    view.Font = this.Font;
                    view.Text = "View: " + ze.FileName;
                    view.SetContent(entryText);
                    view.ShowDialog(this);

                    // done
                    break;
                }
            }
        }

        // show about box
        void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var caption = string.Format("About {0}",
                Application.ProductName);
            var text = string.Format("{0} {1}\r\nCopyright (c) 2001, {2} ComponentOne LLC",
                Application.ProductName,
                Application.ProductVersion,
                DateTime.Today.Year);
            MessageBox.Show(this, text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        //---------------------------------------------------------------------------
        #region ** drag/drop event handlers (users can drop files into the list)

        // if the data object contains files, copy is allowed
        void _list_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = (e.Data.GetDataPresent(DataFormats.FileDrop))
                ? DragDropEffects.Copy
                : DragDropEffects.None;
        }

        // copy files to an open zip or open a new zip file
        void _list_DragDrop(object sender, DragEventArgs e)
        {
            // check whether data object contains files
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                return;
            }

            // get list of files in data object
            var files = e.Data.GetData(DataFormats.FileDrop) as Array;
            if (files == null || files.Length == 0)
            {
                return;
            }

            // get ready to work
            _cancel = _escape = false;

            // if we have a zip file ready, add the dragged files to it
            if (_zipFile.FileName.Length > 0)
            {
                // freeze display while adding folders 
                // (if they have many sub-folders, there's too much painting going on)
                _freezeList = true;

                // add dropped files and folders
                foreach (string file in files)
                {
                    // if this is a file or folder, add file or folder
                    if (File.Exists(file))
                    {
                        _zipFile.Entries.Add(file);
                    }
                    else if (Directory.Exists(file))
                    {
                        AddFolder(file);
                    }

                    // check user input
                    if (CheckUserCancel()) break;
                }

                // show new list
                _freezeList = false;
                UpdateUI();
            }
            else 
            {
                // if we don't have a zip file ready and the dragged files contain a zip file, open it
                foreach (string file in files)
                {
                    if (Path.GetExtension(file).ToLower() == ".zip")
                    {
                        OpenZip(file);
                        break;
                    }
                }

                // still no zip file open...
                if (_zipFile.FileName.Length == 0)
                {
                    MessageBox.Show("Please open (or create) a zip file first.", "No Zip file");
                }
            }
        }

        #endregion

        //---------------------------------------------------------------------------
        #region ** other event handlers

        // sort entries in the list view
        void listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // toggle order for next time
            _ascending = !_ascending;

            // create EntryComparer for the column that was clicked
            _list.ListViewItemSorter = new EntryComparer(_list.Columns[e.Column], _ascending);

            // sort the list
            _list.Sort();
        }

        // update menus and status bar on selection changes
        void _list_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            UpdateMenus();
            UpdateStatusBar();
        }

        // allow user to cancel the current operation by pressing Escape
        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)27:
                    _escape = true;
                    e.Handled = true;
                    break;
            }
        }

        // show progress
        int _lastProgress = -1;
        void _zipFile_Progress(object sender, ZipProgressEventArgs e)
        {
            var pct = (int)(e.PositionLong * 100 / (e.FileLengthLong + 1));
            if (pct != _lastProgress)
            {
                _progressBar.Value = pct;
                _progressBar.Visible = true;
                _lastProgress = pct;
                Application.DoEvents();
            }
        }

        #endregion

        //---------------------------------------------------------------------------
        #region ** implementation

        // check whether the user really wants to cancel the current operation
        bool CheckUserCancel()
        {
            Application.DoEvents();
            if (_escape)
            {
                _escape = false;
                DialogResult dr = MessageBox.Show("Do you want to Cancel the current operation?", "Cancel",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                _cancel = (dr == DialogResult.Yes);
            }
            return _cancel;
        }

        // add a folder to the zip file
        void AddFolder(string folderName)
        {
            AddFolder(folderName, 0);
        }
        void AddFolder(string folderName, int pathLevels)
        {
            // make sure folder name ends with DirectorySeparatorChar
            if (!folderName.EndsWith(Path.DirectorySeparatorChar.ToString()))
            {
                folderName = folderName + Path.DirectorySeparatorChar;
            }

            // bump up pathLevels to keep the folder name
            pathLevels++;

            // user canceled?
            if (_cancel) return;

            // create an empty entry with the folder name
            _zipFile.Entries.Add(folderName, pathLevels);

            // user canceled?
            if (_cancel) return;

            // add files within this folder
            string[] files = Directory.GetFiles(folderName);
            AddFileList(files, pathLevels);

            // user canceled?
            if (_cancel) return;

            // add sub folders within this folder
            string[] subfolders = Directory.GetDirectories(folderName);
            for (int i = 0; i < subfolders.Length; i++)
                AddFolder(subfolders[i], pathLevels);
        }

        // add a list of files to the Zip file, keeping the specified pathLevels
        void AddFileList(string[] files, int pathLevels)
        {
            // keep track errors and time
            string err = string.Empty;
            long start = DateTime.Now.Ticks;

            // add files
            foreach (string file in files)
            {
                // update UI
                UpdateStatusBar("Adding file " + file);
                if (CheckUserCancel()) break;

                // add the file
                try
                {
                    _zipFile.Entries.Add(file, pathLevels);
                    Application.DoEvents();
                }
                catch (Exception x)
                {
                    err += "\r\n" + x.Message;
                }
            }

            // cancel? we're done
            if (_cancel) return;

            // warn user of any problems
            if (err.Length > 0)
            {
                MessageBox.Show(err, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // update user interface
            UpdateUI();

            // show how long it took
            double sec = (DateTime.Now.Ticks - start) / (double)TimeSpan.TicksPerSecond;
            double meg = 0;
            if (sec > 1)
            {
                foreach (string file in files)
                {
                    C1ZipEntry ze = _zipFile.Entries[Path.GetFileName(file)];
                    if (ze != null)
                        meg += ze.SizeCompressedLong;
                }
                meg /= (1024.0 * 1024.0);
                UpdateStatusBar(string.Format("Compressed in {0:0.00} seconds, {1:0.00} meg/second", sec, meg / sec));
            }
        }

        // update list, status bar, and menus
        void UpdateUI()
        {
            UpdateList();
            UpdateStatusBar();
            UpdateMenus();
        }

        // update list
        void UpdateList()
        {
            if (!_freezeList)
            {
                // clear list
                _list.Items.Clear();

                // if no zip file, we're done
                if (string.IsNullOrEmpty(_zipFile.FileName))
                {
                    UpdateStatusBar();
                    UpdateMenus();
                    return;
                }

                // fill out list
                _list.BeginUpdate();
                foreach (C1ZipEntry ze in _zipFile.Entries)
                {
                    var fa = ze.Attributes;
                    var entry = new string[] 
                    {
                        GetFileNameWithoutExtension(ze.FileName),       // file name, no extension
                        Path.GetExtension(ze.FileName),                 // file extension, no dot
                        ze.Date.ToString("MM/dd/yy  HH:mm"),            // mod date/time
                        ze.SizeUncompressedLong.ToString("#,##0"),      // original size
                        ze.SizeCompressedLong.ToString("#,##0"),        // compressed size
                        AttribString(ze.Attributes),                    // encode as "rahs"
						((uint)ze.CRC32).ToString("X8"),                // CRC32
						ze.Comment                                      // user comment
                    };

                    // create new list item
                    var lvi = new ListViewItem(entry);
                    
                    // save entry in item's Tag
                    lvi.Tag = ze;

                    // set image index: folder=1; encrypted=2; file=0
                    lvi.ImageIndex = 
                        (ze.Attributes & FileAttributes.Directory) != 0 ? 1 :
                        ze.IsEncrypted ? 2 : 
                        0;

                    // add new item to the list
                    _list.Items.Add(lvi);
                }
                _list.EndUpdate();
            }
        }
        string GetFileNameWithoutExtension(string fn)
        {
            int pos = fn.LastIndexOf('.');
            if (pos > -1)
            {
                fn = fn.Substring(0, pos);
            }
            return fn;
        }
        public static string AttribString(FileAttributes fa)
        {
            if ((fa & FileAttributes.Directory) != 0) return "<dir>";

            return string.Format("{0}{1}{2}{3}",
                ((fa & FileAttributes.ReadOnly) != 0) ? "r" : "-",
                ((fa & FileAttributes.Archive)  != 0) ? "a" : "-",
                ((fa & FileAttributes.Hidden)   != 0) ? "h" : "-",
                ((fa & FileAttributes.System)   != 0) ? "s" : "-");
        }

        // update menus (enable/disable options)
        void UpdateMenus()
        {
            // do we have a zip file?
            var bZip = !string.IsNullOrEmpty(_zipFile.FileName);
            closeToolStripMenuItem.Enabled = bZip;
            addFilesToolStripMenuItem.Enabled = bZip;
            addFolderToolStripMenuItem.Enabled = bZip;
            addCommentToolStripMenuItem.Enabled = bZip;
            passwordToolStripMenuItem.Enabled = bZip;
            compressionLevelToolStripMenuItem.Enabled = bZip;

            // do we have any entries?
            var bEntries = _list.Items.Count > 0;
            selectAlllToolStripMenuItem.Enabled = bEntries;
            unselectAlllToolStripMenuItem.Enabled = bEntries;
            invertSelectionToolStripMenuItem.Enabled = bEntries;
            testAllFilesToolStripMenuItem.Enabled = bEntries;

            // do we have any selected entries?
            var bSelected = _list.SelectedItems.Count > 0;
            extractToolStripMenuItem.Enabled = bSelected;
            deleteToolStripMenuItem.Enabled = bSelected;
            addCommentToolStripMenuItem.Enabled = bSelected;
            selectedEntryToolStripMenuItem.Enabled = bSelected;

            // update title bar
            var str = Application.ProductName;
            if (bZip) str += " - " + _zipFile.FileName;
            Text = str;
        }

        // update status bar
        void UpdateStatusBar()
        {
            UpdateStatusBar(string.Empty);
        }
        void UpdateStatusBar(string msg)
        {
            // hide progress bar
            _progressBar.Visible = false;

            // build status string
            if (!string.IsNullOrEmpty(msg))
            {
                _status.Text = msg;
                return;
            }

            // get counts
            long nCnt = _list.Items.Count;
            long nSel = _list.SelectedItems.Count;
            long nSize = 0;

            // calculate total size
            foreach (ListViewItem lvi in _list.SelectedItems)
            {
                var ze = (C1ZipEntry)lvi.Tag;
                nSize += ze.SizeUncompressedLong;
            }

            // build statistics string
            string status = (nCnt == 0)
                ? "Ready"
                : (nSize >= 3 * 1024 * 1024)
                    ? string.Format("{0:n0} files, {1:n0} selected, {2:#,##0}k bytes", nCnt, nSel, nSize / 1024)
                    : string.Format("{0:n0} files, {1:n0} selected, {2:#,##0} bytes", nCnt, nSel, nSize);

            // show it
            _status.Text = status;
        }

        #endregion
    }

    /// <summary>
    /// EntryComparer
    /// used for sorting items in the ListView control
    /// </summary>
    class EntryComparer : System.Collections.IComparer
    {
        ColumnHeader _colHdr;
        bool _ascending;

        public EntryComparer(ColumnHeader colHdr, bool ascending)
        {
            _colHdr = colHdr;
            _ascending = ascending;
        }
        public int Compare(object o1, object o2)
        {
            var z1 = o1 as C1ZipEntry;
            var z2 = o2 as C1ZipEntry;
            int res = 0;
            switch (_colHdr.Name)
            {
                case "chName":
                    res = string.Compare(z1.FileName, z2.FileName, true);
                    break;
                case "chExtension":
                    res = string.Compare(Path.GetExtension(z1.FileName), Path.GetExtension(z2.FileName), true);
                    break;
                case "chDate":
                    res = z1.Date.CompareTo(z2.Date);
                    break;
                case "chSize":
                    res = Math.Sign(z1.SizeUncompressedLong - z2.SizeUncompressedLong);
                    break;
                case "chCompressed":
                    res = Math.Sign(z1.SizeCompressedLong - z2.SizeCompressedLong);
                    break;
                case "chAttrib":
                    res = string.Compare(Form1.AttribString(z1.Attributes), Form1.AttribString(z2.Attributes), true);
                    break;
                case "chCRC":
                    res = z1.CRC32 - z2.CRC32;
                    break;
                case "chComment":
                    res = string.Compare(z1.Comment, z2.Comment, true);
                    break;
            }
            return _ascending ? res : -res;
        }
    }
}
