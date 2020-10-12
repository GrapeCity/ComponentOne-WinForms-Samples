using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

using C1.Win.C1Tile;

namespace ControlExplorer.Tiles
{
    public partial class FileExplorer : C1DemoForm
    {
        DirectoryInfo _activeDir;
        Group _folderGroup;
        Group _fileGroup;

        public FileExplorer()
        {
            InitializeComponent();
        }

        void ShowDrives(bool keepOffset)
        {
            _activeDir = null;
            pathLabel.Text = "(Drives)";

            itemTiles.BeginUpdate();
            itemTiles.Groups.Clear(true);

            try
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    DriveType dt = drive.DriveType;
                    Group group = GetDriveGroup(dt);

                    Tile tile = new Tile();
                    switch (dt)
                    {
                        case DriveType.CDRom:
                            tile.Image = ControlExplorer.Properties.Resources.mediaDrive;
                            break;
                        case DriveType.Fixed:
                            tile.Image = ControlExplorer.Properties.Resources.hardDrive;
                            break;
                        case DriveType.Network:
                            tile.Image = ControlExplorer.Properties.Resources.networkDrive;
                            break;
                        default:
                            tile.Image = ControlExplorer.Properties.Resources.otherDrive;
                            break;
                    }
                    tile.HorizontalSize = 3;
                    group.Tiles.Add(tile);
                    tile.Template = tempDrive;

                    string driveName = drive.Name;
                    int dnl = driveName.Length;
                    if (dnl > 1 && driveName[dnl - 1] == '\\')
                    {
                        driveName = driveName.Substring(0, dnl - 1);
                    }
                    if (!drive.IsReady || dt == DriveType.NoRootDirectory)
                    {
                        tile.Text = string.Format("< Empty > ({0})", driveName);
                        tile.BackColor = Color.RosyBrown;
                    }
                    else
                    {
                        tile.Text = string.Format("{0} ({1})", drive.VolumeLabel, driveName);
                        tile.Text1 = string.Format("{0} free of {1}", ToSizeString(drive.TotalFreeSpace), ToSizeString(drive.TotalSize));

                        tile.BackColor = Color.IndianRed;
                        tile.Tag = drive;
                        tile.Click += Drive_Click;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File Explorer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (!keepOffset)
            {
                itemTiles.ScrollOffset = 0;
            }
            itemTiles.EndUpdate();
        }

        string ToSizeString(long bt)
        {
            if (bt < 1024)
            {
                return bt.ToString() + " Bytes";
            }
            string s;
            double size = Convert.ToDouble(bt);
            if (size < 1048576.0)
            {
                s = " KB";
                size /= 1024.0;
            }
            else if (size < 1073741824.0)
            {
                s = " MB";
                size /= 1048576.0;
            }
            else if (size < 1099511627776.0)
            {
                s = " GB";
                size /= 1073741824.0;
            }
            else
            {
                s = " TB";
                size /= 1099511627776.0;
            }
            if (size >= 100.0)
                return Math.Truncate(size).ToString("0") + s;
            if (size >= 10.0)
                return (Math.Truncate(size * 10.0) / 10.0).ToString("0.0") + s;
            return (Math.Truncate(size * 100.0) / 100.0).ToString("0.00") + s;
        }

        Group GetDriveGroup(DriveType driveType)
        {
            string groupName = driveType.ToString();
            foreach (Group group in itemTiles.Groups)
            {
                if (group.Name == groupName)
                {
                    return group;
                }
            }
            Group newGroup = new Group();
            switch (driveType)
            {
                case DriveType.CDRom:
                    newGroup.Text = "CD/DVD";
                    break;
                case DriveType.Fixed:
                    newGroup.Text = "Fixed Disks";
                    break;
                case DriveType.Network:
                    newGroup.Text = "Network Drives";
                    break;
                case DriveType.Ram:
                    newGroup.Text = "RAM Disks";
                    break;
                case DriveType.Removable:
                    newGroup.Text = "Removable Devices";
                    break;
                default:
                    newGroup.Text = "Misc";
                    break;
            }
            itemTiles.Groups.Add(newGroup);
            newGroup.Name = groupName;
            return newGroup;
        }

        void ShowDirectory(DirectoryInfo dirInfo, bool keepOffset)
        {
            if (!dirInfo.Exists)
            {
                return;
            }
            Group folderGroup = new Group();
            Group fileGroup = new Group();
            try
            {
                folderGroup.Text = "Folders";
                foreach (DirectoryInfo subDir in dirInfo.GetDirectories())
                {
                    Tile tile = new Tile();
                    tile.HorizontalSize = 3;
                    folderGroup.Tiles.Add(tile);
                    tile.Template = tempFolder;
                    tile.Image = ControlExplorer.Properties.Resources.folder;
                    tile.Text = subDir.Name;
                    tile.Text1 = subDir.LastWriteTime.ToString();
                    tile.BackColor = Color.SteelBlue;
                    tile.Tag = subDir;
                    tile.Click += Directory_Click;
                }
                fileGroup.Text = "Files";
                foreach (FileInfo file in dirInfo.GetFiles())
                {
                    Tile tile = new Tile();
                    tile.HorizontalSize = 3;
                    fileGroup.Tiles.Add(tile);
                    tile.Template = tempFile;
                    tile.Image = ControlExplorer.Properties.Resources.file;
                    tile.Text = file.Name;
                    tile.Text1 = "Updated: " + file.LastWriteTime.ToString();
                    tile.Text2 = ToSizeString(file.Length);
                    tile.BackColor = Color.Green;
                    tile.Tag = file;
                    tile.Click += File_Click;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File Explorer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            itemTiles.BeginUpdate();
            itemTiles.Groups.Clear(true);
            itemTiles.Groups.Add(folderGroup);
            itemTiles.Groups.Add(fileGroup);
            if (!keepOffset)
            {
                itemTiles.ScrollOffset = 0;
            }
            itemTiles.EndUpdate();

            _activeDir = dirInfo;
            _folderGroup = folderGroup;
            _fileGroup = fileGroup;
            UpdateStatus();
        }

        void UpdateStatus()
        {
            if (_activeDir == null)
            {
                return;
            }
            StringBuilder sb = new StringBuilder();
            int n = _folderGroup.Tiles.Count;
            if (n > 0)
            {
                sb.Append("Folders  ");
                sb.Append(n);
            }
            n = _fileGroup.Tiles.Count;
            if (n > 0)
            {
                if (sb.Length > 0)
                {
                    sb.Append("    ");
                }
                sb.Append("Files  ");
                sb.Append(n);
            }
            n = itemTiles.CheckedTiles.Length;
            if (n > 0)
            {
                if (sb.Length > 0)
                {
                    sb.Append("    ");
                }
                sb.Append("Checked  ");
                sb.Append(n);
            }
            if (sb.Length > 0)
            {
                sb.Append("       ");
            }
            sb.Append(_activeDir.FullName);
            pathLabel.Text = sb.ToString();
        }

        void RefreshTiles()
        {
            if (_activeDir != null)
                ShowDirectory(_activeDir, true);
            else
                ShowDrives(true);
        }

        void Form1_Load(object sender, EventArgs e)
        {
            ShowDrives(true);
        }

        void Drive_Click(object sender, EventArgs e)
        {
            ShowDirectory(((DriveInfo)((Tile)sender).Tag).RootDirectory, false);
        }

        void Directory_Click(object sender, EventArgs e)
        {
            ShowDirectory((DirectoryInfo)((Tile)sender).Tag, false);
        }

        void File_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = (FileInfo)((Tile)sender).Tag;
            if (!fileInfo.Exists)
            {
                return;
            }
            Process.Start(fileInfo.FullName);
        }

        void upLevelTile_Click(object sender, EventArgs e)
        {
            if (_activeDir != null)
            {
                itemTiles.Focus();
                DirectoryInfo dirInfo = _activeDir.Parent;
                if (dirInfo != null)
                    ShowDirectory(dirInfo, false);
                else
                    ShowDrives(false);
            }
        }

        void drivesTile_Click(object sender, EventArgs e)
        {
            itemTiles.Focus();
            ShowDrives(false);
        }

        void refreshTile_Click(object sender, EventArgs e)
        {
            itemTiles.Focus();
            RefreshTiles();
        }

        void itemTiles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8)
            {
                upLevelTile_Click(sender, e);
                e.Handled = true;
            }
        }

        void tempDrive_Paint(object sender, TemplatePaintEventArgs e)
        {
            DriveInfo di = e.Tile.Tag as DriveInfo;
            if (di != null)
            {
                Graphics g = e.Graphics;

                Rectangle rc = new Rectangle(50, 28, 170, 12);
                float zf = c1Zoom1.ZoomFactor;
                rc.X = (int)(rc.X * zf + 0.5f);
                rc.Y = (int)(rc.Y * zf + 0.5f);
                rc.Width = (int)(rc.Width * zf + 0.5f);
                rc.Height = (int)(rc.Height * zf + 0.5f);

                g.DrawRectangle(Pens.Silver, rc);
                rc.X += 1;
                rc.Y += 1;
                rc.Width -= 1;
                rc.Height -= 1;
                g.FillRectangle(Brushes.Gainsboro, rc);
                double k = Convert.ToDouble(di.TotalSize);
                if (k > 0.0)
                {
                    k = (k - Convert.ToDouble(di.TotalFreeSpace)) / k;
                    rc.Width = Convert.ToInt32(k * rc.Width);
                }
                g.FillRectangle(Brushes.SteelBlue, rc);
            }
        }

        void itemTiles_TileCheckedChanged(object sender, TileEventArgs e)
        {
            UpdateStatus();
        }

        void newFolderTile_Click(object sender, EventArgs e)
        {
            itemTiles.Focus();
            if (_activeDir == null)
            {
                return;
            }
            string fn = NameForm.GetFolderName();
            if (fn != null)
            {
                try
                {
                    _activeDir.CreateSubdirectory(fn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "File Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                RefreshTiles();
            }
        }

        void deleteTile_Click(object sender, EventArgs e)
        {
            itemTiles.Focus();
            Tile[] checkedTiles = itemTiles.CheckedTiles;
            int n = checkedTiles.Length;
            if (n == 0 || _activeDir == null)
            {
                return;
            }
            if (n > 1)
            {
                bool hasFolders = false;
                bool hasFiles = false;
                foreach (Tile tile in checkedTiles)
                {
                    if (tile.Tag is DirectoryInfo)
                        hasFolders = true;
                    else if (tile.Tag is FileInfo)
                        hasFiles = true;
                }
                if (!hasFiles && !hasFolders)
                {
                    return;
                }
                string s;
                if (hasFiles && hasFolders)
                    s = "files and folders";
                else
                    s = hasFiles ? "files" : "folders";
                if (MessageBox.Show(string.Format("Are you sure you want to delete {0} {1}?", n, s), "Delete Confirmation",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (Tile tile in checkedTiles)
                    {
                        DirectoryInfo di = tile.Tag as DirectoryInfo;
                        FileInfo fi = tile.Tag as FileInfo;
                        try
                        {
                            if (di != null)
                            {
                                di.Delete(true);
                            }
                            else if (fi != null)
                            {
                                fi.Delete();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "File Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        RefreshTiles();
                    }
                }
            }
            else
            {
                DirectoryInfo di = checkedTiles[0].Tag as DirectoryInfo;
                FileInfo fi = checkedTiles[0].Tag as FileInfo;
                if (di != null)
                {
                    if (MessageBox.Show(string.Format("Are you sure you want to delete the selected folder {0}?", di.Name), "Delete Confirmation",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        try
                        {
                            di.Delete();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "File Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        RefreshTiles();
                    }
                }
                else if (fi != null)
                {
                    if (MessageBox.Show(string.Format("Are you sure you want to delete the selected file {0}?", fi.Name), "Delete Confirmation",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        try
                        {
                            fi.Delete();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "File Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        RefreshTiles();
                    }
                }
            }
        }

        void renameTile_Click(object sender, EventArgs e)
        {
            itemTiles.Focus();
            Tile[] checkedTiles = itemTiles.CheckedTiles;
            int n = checkedTiles.Length;
            if (n == 0)
            {
                return;
            }
            if (n > 1)
            {
                MessageBox.Show("Can't rename more than one item at a time.", "File Explorer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Tile tile = checkedTiles[0];
            DriveInfo driveInfo = tile.Tag as DriveInfo;
            DirectoryInfo dirInfo = tile.Tag as DirectoryInfo;
            FileInfo fileInfo = tile.Tag as FileInfo;
            string s = null;
            if (driveInfo != null)
            {
                s = NameForm.RenameItem(driveInfo.VolumeLabel, "Rename Drive", "Drive Name:");
                if (s != null && s != driveInfo.VolumeLabel)
                {
                    try
                    {
                        driveInfo.VolumeLabel = s;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "File Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (dirInfo != null)
            {
                s = NameForm.RenameItem(dirInfo.Name, "Rename Folder", "Folder Name:");
                if (s != null && s != dirInfo.Name)
                {
                    try
                    {
                        dirInfo.MoveTo(Path.Combine(dirInfo.Parent.FullName, s));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "File Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (fileInfo != null)
            {
                s = NameForm.RenameItem(fileInfo.Name, "Rename File", "File Name:");
                if (s != null && s != fileInfo.Name)
                {
                    try
                    {
                        fileInfo.MoveTo(Path.Combine(fileInfo.Directory.FullName, s));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "File Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (s != null)
            {
                RefreshTiles();
            }
        }
    }
}
