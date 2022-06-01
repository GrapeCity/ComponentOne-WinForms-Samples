using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;

using C1.Zip;

namespace C1ZipDemo
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem mnuOpenZip;
        private System.Windows.Forms.MenuItem mnuNewZip;
        private System.Windows.Forms.MenuItem mnuCloseZip;
        private System.Windows.Forms.MenuItem mnuExit;
        private System.Windows.Forms.MenuItem mnuSelectAll;
        private System.Windows.Forms.MenuItem mnuUnselectAll;
        private System.Windows.Forms.MenuItem mnuSelectGroup;
        private System.Windows.Forms.MenuItem mnuExtract;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ColumnHeader chSize;
        private System.Windows.Forms.ColumnHeader chSizeCompr;
        private System.Windows.Forms.ColumnHeader chAttrib;
        private System.Windows.Forms.ColumnHeader chExtension;
        private System.Windows.Forms.ColumnHeader chCRC32;
        private System.Windows.Forms.ColumnHeader chComment;
        private System.Windows.Forms.MenuItem mnuFile;
        private System.Windows.Forms.MenuItem mnuSep0;
        private System.Windows.Forms.MenuItem mnuSelect;
        private System.Windows.Forms.MenuItem mnuSep1;
        private System.Windows.Forms.MenuItem mnuCommand;
        private System.Windows.Forms.MenuItem mnuDelete;
        private System.Windows.Forms.MenuItem mnuAddFile;
        private System.Windows.Forms.MenuItem mnuAddFolder;
        private System.Windows.Forms.MenuItem mnuHelp;
        private System.Windows.Forms.MenuItem mnuAbout;
        private System.Windows.Forms.MenuItem mnuInvertSelection;
        private System.Windows.Forms.MenuItem mnuViewLarge;
        private System.Windows.Forms.MenuItem mnuViewSmall;
        private System.Windows.Forms.MenuItem mnuViewList;
        private System.Windows.Forms.MenuItem mnuViewDetail;
        private System.Windows.Forms.MenuItem mnuView;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.ImageList imageListLarge;
        private System.Windows.Forms.MenuItem mnuSep3;
        private System.Windows.Forms.MenuItem mnuSep2;
        private System.Windows.Forms.MenuItem mnuEditComment;
        private System.Windows.Forms.MenuItem mnuEditZipComment;
        private System.Windows.Forms.MenuItem mnuEditEntryComment;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem mnuViewEntry;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem mnuLevel;
        private System.Windows.Forms.MenuItem mnuLevelDefault;
        private System.Windows.Forms.MenuItem mnuLevelBest;
        private System.Windows.Forms.MenuItem mnuLevelFast;
        private System.Windows.Forms.MenuItem mnuLevelNone;
        private System.Windows.Forms.MenuItem mnuPassword;
        private StatusStrip _statusStrip;
        private ToolStripStatusLabel _lblStatus;
        private ToolStripProgressBar _progressBar;
        private System.Windows.Forms.MenuItem mnuTestZipFile;
        
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
			_zipFile.OverwriteHidden = true;
			_zipFile.OverwriteReadOnly = true;
			_zipFile.OverwriteSystem = false;
            _zipFile.Progress += new C1.Zip.ZipProgressEventHandler(this.zip_Progress);
            UpdateUI();
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing )
        {
            if( disposing )
            {
                if (components != null) 
                {
                    components.Dispose();
                }
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chExtension = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSizeCompr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAttrib = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCRC32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuNewZip = new System.Windows.Forms.MenuItem();
            this.mnuOpenZip = new System.Windows.Forms.MenuItem();
            this.mnuCloseZip = new System.Windows.Forms.MenuItem();
            this.mnuSep0 = new System.Windows.Forms.MenuItem();
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.mnuSelect = new System.Windows.Forms.MenuItem();
            this.mnuSelectAll = new System.Windows.Forms.MenuItem();
            this.mnuUnselectAll = new System.Windows.Forms.MenuItem();
            this.mnuSep1 = new System.Windows.Forms.MenuItem();
            this.mnuInvertSelection = new System.Windows.Forms.MenuItem();
            this.mnuSelectGroup = new System.Windows.Forms.MenuItem();
            this.mnuCommand = new System.Windows.Forms.MenuItem();
            this.mnuExtract = new System.Windows.Forms.MenuItem();
            this.mnuDelete = new System.Windows.Forms.MenuItem();
            this.mnuSep3 = new System.Windows.Forms.MenuItem();
            this.mnuAddFile = new System.Windows.Forms.MenuItem();
            this.mnuAddFolder = new System.Windows.Forms.MenuItem();
            this.mnuSep2 = new System.Windows.Forms.MenuItem();
            this.mnuTestZipFile = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuEditComment = new System.Windows.Forms.MenuItem();
            this.mnuEditZipComment = new System.Windows.Forms.MenuItem();
            this.mnuEditEntryComment = new System.Windows.Forms.MenuItem();
            this.mnuLevel = new System.Windows.Forms.MenuItem();
            this.mnuLevelDefault = new System.Windows.Forms.MenuItem();
            this.mnuLevelBest = new System.Windows.Forms.MenuItem();
            this.mnuLevelFast = new System.Windows.Forms.MenuItem();
            this.mnuLevelNone = new System.Windows.Forms.MenuItem();
            this.mnuPassword = new System.Windows.Forms.MenuItem();
            this.mnuView = new System.Windows.Forms.MenuItem();
            this.mnuViewLarge = new System.Windows.Forms.MenuItem();
            this.mnuViewSmall = new System.Windows.Forms.MenuItem();
            this.mnuViewList = new System.Windows.Forms.MenuItem();
            this.mnuViewDetail = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mnuViewEntry = new System.Windows.Forms.MenuItem();
            this.mnuHelp = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this._statusStrip = new System.Windows.Forms.StatusStrip();
            this._lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this._progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this._statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.AllowColumnReorder = true;
            this.listView.AllowDrop = true;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chExtension,
            this.chDate,
            this.chSize,
            this.chSizeCompr,
            this.chAttrib,
            this.chCRC32,
            this.chComment});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.FullRowSelect = true;
            this.listView.LargeImageList = this.imageListLarge;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(532, 277);
            this.listView.SmallImageList = this.imageListSmall;
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listView.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView_DragDrop);
            this.listView.DragOver += new System.Windows.Forms.DragEventHandler(this.listView_DragOver);
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 150;
            // 
            // chExtension
            // 
            this.chExtension.Text = "Ext";
            this.chExtension.Width = 40;
            // 
            // chDate
            // 
            this.chDate.Text = "Date";
            this.chDate.Width = 100;
            // 
            // chSize
            // 
            this.chSize.Text = "Size";
            this.chSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chSizeCompr
            // 
            this.chSizeCompr.Text = "Compr";
            this.chSizeCompr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chAttrib
            // 
            this.chAttrib.Text = "Attrib";
            // 
            // chCRC32
            // 
            this.chCRC32.Text = "CRC32";
            this.chCRC32.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chCRC32.Width = 80;
            // 
            // chComment
            // 
            this.chComment.Text = "Comment";
            this.chComment.Width = 500;
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Red;
            this.imageListLarge.Images.SetKeyName(0, "");
            this.imageListLarge.Images.SetKeyName(1, "");
            this.imageListLarge.Images.SetKeyName(2, "");
            this.imageListLarge.Images.SetKeyName(3, "");
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Red;
            this.imageListSmall.Images.SetKeyName(0, "");
            this.imageListSmall.Images.SetKeyName(1, "");
            this.imageListSmall.Images.SetKeyName(2, "");
            this.imageListSmall.Images.SetKeyName(3, "");
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFile,
            this.mnuSelect,
            this.mnuCommand,
            this.mnuView,
            this.mnuHelp});
            // 
            // mnuFile
            // 
            this.mnuFile.Index = 0;
            this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuNewZip,
            this.mnuOpenZip,
            this.mnuCloseZip,
            this.mnuSep0,
            this.mnuExit});
            this.mnuFile.Text = "&File";
            // 
            // mnuNewZip
            // 
            this.mnuNewZip.Index = 0;
            this.mnuNewZip.Text = "&New...";
            this.mnuNewZip.Click += new System.EventHandler(this.mnuNewZip_Click);
            // 
            // mnuOpenZip
            // 
            this.mnuOpenZip.Index = 1;
            this.mnuOpenZip.Text = "&Open...";
            this.mnuOpenZip.Click += new System.EventHandler(this.mnuOpenZip_Click);
            // 
            // mnuCloseZip
            // 
            this.mnuCloseZip.Index = 2;
            this.mnuCloseZip.Text = "&Close";
            this.mnuCloseZip.Click += new System.EventHandler(this.mnuCloseZip_Click);
            // 
            // mnuSep0
            // 
            this.mnuSep0.Index = 3;
            this.mnuSep0.Text = "-";
            // 
            // mnuExit
            // 
            this.mnuExit.Index = 4;
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuSelect
            // 
            this.mnuSelect.Index = 1;
            this.mnuSelect.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuSelectAll,
            this.mnuUnselectAll,
            this.mnuSep1,
            this.mnuInvertSelection,
            this.mnuSelectGroup});
            this.mnuSelect.Text = "&Select";
            // 
            // mnuSelectAll
            // 
            this.mnuSelectAll.Index = 0;
            this.mnuSelectAll.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.mnuSelectAll.Text = "Select &All";
            this.mnuSelectAll.Click += new System.EventHandler(this.mnuSelectAll_Click);
            // 
            // mnuUnselectAll
            // 
            this.mnuUnselectAll.Index = 1;
            this.mnuUnselectAll.Text = "&Unselect All";
            this.mnuUnselectAll.Click += new System.EventHandler(this.mnuUnselectAll_Click);
            // 
            // mnuSep1
            // 
            this.mnuSep1.Index = 2;
            this.mnuSep1.Text = "-";
            // 
            // mnuInvertSelection
            // 
            this.mnuInvertSelection.Index = 3;
            this.mnuInvertSelection.Text = "&Invert selection";
            this.mnuInvertSelection.Click += new System.EventHandler(this.mnuInvertSelection_Click);
            // 
            // mnuSelectGroup
            // 
            this.mnuSelectGroup.Index = 4;
            this.mnuSelectGroup.Text = "Select &Group...";
            this.mnuSelectGroup.Click += new System.EventHandler(this.mnuSelectGroup_Click);
            // 
            // mnuCommand
            // 
            this.mnuCommand.Index = 2;
            this.mnuCommand.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuExtract,
            this.mnuDelete,
            this.mnuSep3,
            this.mnuAddFile,
            this.mnuAddFolder,
            this.mnuSep2,
            this.mnuTestZipFile,
            this.menuItem1,
            this.mnuEditComment,
            this.mnuLevel,
            this.mnuPassword});
            this.mnuCommand.Text = "&Command";
            // 
            // mnuExtract
            // 
            this.mnuExtract.Index = 0;
            this.mnuExtract.Text = "&Extract";
            this.mnuExtract.Click += new System.EventHandler(this.mnuExtract_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Index = 1;
            this.mnuDelete.Shortcut = System.Windows.Forms.Shortcut.Del;
            this.mnuDelete.Text = "&Delete";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // mnuSep3
            // 
            this.mnuSep3.Index = 2;
            this.mnuSep3.Text = "-";
            // 
            // mnuAddFile
            // 
            this.mnuAddFile.Index = 3;
            this.mnuAddFile.Shortcut = System.Windows.Forms.Shortcut.Ins;
            this.mnuAddFile.Text = "&Add Files...";
            this.mnuAddFile.Click += new System.EventHandler(this.mnuAddFile_Click);
            // 
            // mnuAddFolder
            // 
            this.mnuAddFolder.Index = 4;
            this.mnuAddFolder.Shortcut = System.Windows.Forms.Shortcut.ShiftIns;
            this.mnuAddFolder.Text = "Add &Folder...";
            this.mnuAddFolder.Click += new System.EventHandler(this.mnuAddFolder_Click);
            // 
            // mnuSep2
            // 
            this.mnuSep2.Index = 5;
            this.mnuSep2.Text = "-";
            // 
            // mnuTestZipFile
            // 
            this.mnuTestZipFile.Index = 6;
            this.mnuTestZipFile.Text = "&Test All Files";
            this.mnuTestZipFile.Click += new System.EventHandler(this.mnuTestZipFile_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 7;
            this.menuItem1.Text = "-";
            // 
            // mnuEditComment
            // 
            this.mnuEditComment.Index = 8;
            this.mnuEditComment.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuEditZipComment,
            this.mnuEditEntryComment});
            this.mnuEditComment.Text = "&Edit Comment";
            // 
            // mnuEditZipComment
            // 
            this.mnuEditZipComment.Index = 0;
            this.mnuEditZipComment.Text = "Zip File";
            this.mnuEditZipComment.Click += new System.EventHandler(this.mnuEditZipComment_Click_1);
            // 
            // mnuEditEntryComment
            // 
            this.mnuEditEntryComment.Index = 1;
            this.mnuEditEntryComment.Text = "Entries";
            this.mnuEditEntryComment.Click += new System.EventHandler(this.mnuEditEntryComment_Click);
            // 
            // mnuLevel
            // 
            this.mnuLevel.Index = 9;
            this.mnuLevel.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuLevelDefault,
            this.mnuLevelBest,
            this.mnuLevelFast,
            this.mnuLevelNone});
            this.mnuLevel.Text = "Compression Level";
            // 
            // mnuLevelDefault
            // 
            this.mnuLevelDefault.Checked = true;
            this.mnuLevelDefault.Index = 0;
            this.mnuLevelDefault.Text = "&Default";
            this.mnuLevelDefault.Click += new System.EventHandler(this.mnuLevel_Click);
            // 
            // mnuLevelBest
            // 
            this.mnuLevelBest.Index = 1;
            this.mnuLevelBest.Text = "Best &Compression";
            this.mnuLevelBest.Click += new System.EventHandler(this.mnuLevel_Click);
            // 
            // mnuLevelFast
            // 
            this.mnuLevelFast.Index = 2;
            this.mnuLevelFast.Text = "Best &Speed";
            this.mnuLevelFast.Click += new System.EventHandler(this.mnuLevel_Click);
            // 
            // mnuLevelNone
            // 
            this.mnuLevelNone.Index = 3;
            this.mnuLevelNone.Text = "&No Compression";
            this.mnuLevelNone.Click += new System.EventHandler(this.mnuLevel_Click);
            // 
            // mnuPassword
            // 
            this.mnuPassword.Index = 10;
            this.mnuPassword.Text = "Password";
            this.mnuPassword.Click += new System.EventHandler(this.mnuPassword_Click);
            // 
            // mnuView
            // 
            this.mnuView.Index = 3;
            this.mnuView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuViewLarge,
            this.mnuViewSmall,
            this.mnuViewList,
            this.mnuViewDetail,
            this.menuItem3,
            this.mnuViewEntry});
            this.mnuView.Text = "&View";
            // 
            // mnuViewLarge
            // 
            this.mnuViewLarge.Index = 0;
            this.mnuViewLarge.Text = "&Large Icons";
            this.mnuViewLarge.Click += new System.EventHandler(this.mnuView_Click);
            // 
            // mnuViewSmall
            // 
            this.mnuViewSmall.Index = 1;
            this.mnuViewSmall.Text = "&Small Icons";
            this.mnuViewSmall.Click += new System.EventHandler(this.mnuView_Click);
            // 
            // mnuViewList
            // 
            this.mnuViewList.Index = 2;
            this.mnuViewList.Text = "&List";
            this.mnuViewList.Click += new System.EventHandler(this.mnuView_Click);
            // 
            // mnuViewDetail
            // 
            this.mnuViewDetail.Checked = true;
            this.mnuViewDetail.Index = 3;
            this.mnuViewDetail.Text = "&Detail";
            this.mnuViewDetail.Click += new System.EventHandler(this.mnuView_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 4;
            this.menuItem3.Text = "-";
            // 
            // mnuViewEntry
            // 
            this.mnuViewEntry.Index = 5;
            this.mnuViewEntry.Shortcut = System.Windows.Forms.Shortcut.F3;
            this.mnuViewEntry.Text = "Current Entry...";
            this.mnuViewEntry.Click += new System.EventHandler(this.mnuViewEntry_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Index = 4;
            this.mnuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuAbout});
            this.mnuHelp.Text = "&Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Index = 0;
            this.mnuAbout.Text = "&About...";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // _statusStrip
            // 
            this._statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._lblStatus,
            this._progressBar});
            this._statusStrip.Location = new System.Drawing.Point(0, 252);
            this._statusStrip.Name = "_statusStrip";
            this._statusStrip.Size = new System.Drawing.Size(532, 25);
            this._statusStrip.TabIndex = 2;
            this._statusStrip.Text = "statusStrip1";
            // 
            // _lblStatus
            // 
            this._lblStatus.Name = "_lblStatus";
            this._lblStatus.Size = new System.Drawing.Size(384, 20);
            this._lblStatus.Spring = true;
            this._lblStatus.Text = "Ready";
            this._lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _progressBar
            // 
            this._progressBar.Name = "_progressBar";
            this._progressBar.Size = new System.Drawing.Size(100, 19);
            this._progressBar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 19);
            this.ClientSize = new System.Drawing.Size(532, 277);
            this.Controls.Add(this._statusStrip);
            this.Controls.Add(this.listView);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1Zip Demo";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this._statusStrip.ResumeLayout(false);
            this._statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        #endregion

		// private fields
		//
        C1ZipFile _zipFile  = new C1ZipFile();	// the zip file
        string    _appTitle = "C1Zip Demo";		// the caption
		bool	  _escape = false;				// user hit escape
		bool	  _cancel  = false;				// user wants to cancel
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() 
        {
            Application.Run(new Form1());
        }

        // create a new zip file
        void mnuNewZip_Click(object sender, System.EventArgs e)
        {
            // show dialog
            SaveFileDialog sf = new SaveFileDialog();
            sf.DefaultExt = "zip";
            sf.Filter = "Zip files (*.zip)|*.zip";
            if (sf.ShowDialog() != DialogResult.OK)
                return;

            // create a new empty zip file
            _zipFile.Create(sf.FileName);

            // update user interface
            UpdateUI();
        }
        
        // open an existing zip file
        void mnuOpenZip_Click(object sender, System.EventArgs e)
        {
            // select zip file
            OpenFileDialog of = new OpenFileDialog();
            of.DefaultExt = "zip";
            of.Filter = "Zip files (*.zip)|*.zip";
            if (of.ShowDialog() != DialogResult.OK)
                return;
            
            // open zip file
            OpenZip(of.FileName);
        }
        void OpenZip(string fn)
        {
            // make sure this is a valid zip file
            if (!File.Exists(fn)) return;
            if (Path.GetExtension(fn).ToLower() != ".zip") return;

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
        void mnuCloseZip_Click(object sender, System.EventArgs e)
        {
            _zipFile.Close();
            UpdateUI();
        }

        // exit the application
        void mnuExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        // select all files in the current zip file
        void mnuSelectAll_Click(object sender, System.EventArgs e)
        {
            foreach (ListViewItem lvi in listView.Items)
            {
                lvi.Selected = true;
            }
        }
       
        // unselect all files in the current zip file
        void mnuUnselectAll_Click(object sender, System.EventArgs e)
        {
            foreach (ListViewItem lvi in listView.Items)
            {
                lvi.Selected = false;
            }
        }
        
        // invert selection
        void mnuInvertSelection_Click(object sender, System.EventArgs e)
        {
            foreach (ListViewItem lvi in listView.Items)
            {
                lvi.Selected = !lvi.Selected;
            }
        }

        // select a group of files in the current zip file
        void mnuSelectGroup_Click(object sender, System.EventArgs e)
        {
            // make sure we have some files...
            if (listView.Items.Count == 0)
            {
                return;
            }

            // get mask for expanding selection
            UserInputDialog dlg = new UserInputDialog();
            string mask = dlg.GetString("Expand Selection", "*.*");
            if (mask == null)
            {
                return;
            }

            // add an extension if we don't have one
            if (mask.IndexOf(".") < 0)
            {
                mask += "*.*";
            }

            // escape/replace reserved regexp characters
            string rxchars = "\\.$()";
            for (int i = 0; i < rxchars.Length; i++)
            {
                mask = mask.Replace(rxchars[i].ToString(), "\\" + rxchars[i]);
            }
            mask = mask.Replace("*", ".*");
            mask = mask.Replace("?", ".");

            // build regexp object
            mask = "^" + mask + "$";
            Regex rx = new Regex(mask, RegexOptions.IgnoreCase);

            // remove single selection, if any
            if (listView.SelectedItems.Count == 1)
            {
                mnuUnselectAll_Click(null, null);
            }

            // select files
            foreach (ListViewItem lvi in listView.Items)
            {
                var ze = (C1ZipEntry)lvi.Tag;
                if (rx.IsMatch(ze.FileName))
                    lvi.Selected = true;
            }
        }

        // show progress while adding/extracting files
        void zip_Progress(object sender, C1.Zip.ZipProgressEventArgs e)
        {
            if (e.FileLengthLong > 0)
            {
                var pct = (int)((100 * e.PositionLong) / e.FileLengthLong);
                if (pct != _pctLast)
                {
                    var status = string.Format("{0}: {1}%", e.FileName, pct);
                    _lblStatus.Text = status;
                    _progressBar.Value = pct;
                    _progressBar.Visible = true;
                    _pctLast = pct;
                    Application.DoEvents();
                }
            }
        }
        int _pctLast;

        // handle keys
        void Form1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            switch (e.KeyChar)
			{
				case '+':
	                mnuSelectGroup_Click(null, null);
		            e.Handled = true;
					break;
				case (char)27:
					_escape = true;
					e.Handled = true;
					break;
			}
        }

		// check whether the user really wants to cancel the current operation
		bool CheckUserCancel()
		{
			Application.DoEvents();
			if (_escape)
			{
				_escape = false;
				var dr = MessageBox.Show("Do you want to Cancel the current operation?", "Cancel", 
					MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				_cancel = (dr == DialogResult.Yes);
			}
			return _cancel;
		}

        // extract files
        void mnuExtract_Click(object sender, System.EventArgs e)
        {
            string defFolder = Path.GetDirectoryName(_zipFile.FileName);
            string folder;

            while (true)
            {
                // show dialog
                var dlg = new UserInputDialog();
                folder = dlg.GetString("Choose a destination folder", defFolder);

                // if canceled, we're done
                if (folder == null)
                {
                    return;
                }
                
                // if folder is empty, use default
                if (folder == string.Empty)
                {
                    folder = defFolder;
                }

                // if folder is valid, break out of the loop
                if (Directory.Exists(folder))
                {
                    break;
                }
                
                // warn user about invalid folder
                var dr = MessageBox.Show("Sorry, this is not a valid folder.", "Extract Files", MessageBoxButtons.RetryCancel);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
            }

            // make sure folder name ends with a directory separator char
            if (!folder.EndsWith(Path.DirectorySeparatorChar.ToString()))
            {
                folder = folder + Path.DirectorySeparatorChar;
            }

            // extract
            foreach (ListViewItem lvi in listView.SelectedItems)
            {
                var ze = (C1ZipEntry)lvi.Tag;
                try
                {
                    if ((ze.Attributes & FileAttributes.Directory) != 0)
                    {
                        var newFolder = Path.Combine(folder, ze.FileName);
                        Directory.CreateDirectory(newFolder);
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

        // delete files from the current zip file
        void mnuDelete_Click(object sender, System.EventArgs e)
        {
            // build an array of strings containing the selected file names
            var files = new ArrayList();
            foreach (ListViewItem lvi in listView.SelectedItems)
            {
                var ze = (C1ZipEntry)lvi.Tag;
                files.Add(ze.FileName);
            }
            
            // remove files from the zip
            // (this is a lot quicker than removing the files one by one)
            var arr = (string[])files.ToArray(typeof(string));
            _zipFile.Entries.Remove(arr);

            // update user interface
            UpdateUI();
        }
        
        // add files to the zip file
        void mnuAddFile_Click(object sender, System.EventArgs e)
        {
            // show dialog
            var of = new OpenFileDialog();
            of.Multiselect = true;
            if (of.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            // warn user of encryption 
            if (_zipFile.Password.Length > 0)
            {
                string msg = "File(s) will be encrypted!\n\r" +
                             "Current password: " + _zipFile.Password;
                var dr = MessageBox.Show(msg, "Add Files", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
            }

            // add the files
            AddFileList(of.FileNames, 0);
        }

        // add a folder to the current zip file
        void mnuAddFolder_Click(object sender, System.EventArgs e)
        {
            var defFolder = Path.GetDirectoryName(_zipFile.FileName);
            var folder = string.Empty;

            // get a folder name from user
            while (true)
            {
                // show dialog
                var dlg = new UserInputDialog();
                folder = dlg.GetString("Add Folder", defFolder);

                // if canceled, we're done
                if (folder == null)
                {
                    return;
                }

                // if folder is valid, break out loop
                if (Directory.Exists(folder))
                {
                    break;
                }

                // warn user about invalid folder
                var dr = MessageBox.Show("Sorry, this is not a valid folder.", "Add Folder", MessageBoxButtons.RetryCancel);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
            }

			// warn user of encryption 
			if (_zipFile.Password.Length > 0)
            {
                var msg = "File(s) will be encrypted!\n\r" +
                             "Current password: " + _zipFile.Password;
                var dr = MessageBox.Show(msg, "Add Folder", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.Cancel)
                    return;
            }

            // freeze display while adding folders 
            // (if they have many subfolders, there's too much painting going on)
            _freezeList = true;
            
            // add folder
			_cancel = _escape = false;
			AddFolder(folder);

            // display list
            _freezeList = false;
            UpdateUI();
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
            var files = Directory.GetFiles(folderName);
            AddFileList(files, pathLevels);

			// user canceled?
			if (_cancel) return;

			// add sub folders within this folder
            var subfolders = Directory.GetDirectories(folderName);
            for (int i = 0; i < subfolders.Length; i++)
            {
                AddFolder(subfolders[i], pathLevels);
            }
        }

        // add a list of files to the Zip file, keeping the specified pathLevels
        void AddFileList(string[] files, int pathLevels)
        {
            // keep track errors and time
            var err = string.Empty;
            var start = DateTime.Now.Ticks;

            // add files
            foreach (string file in files)
            {
				// update UI
                UpdateStatusBar("Adding file "+ file);
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
            string msg = null;
            double sec = (DateTime.Now.Ticks - start) / (double)TimeSpan.TicksPerSecond;
            double meg = 0;
            if (sec > 1)
            {
                foreach (string file in files)
                {
                    var ze = _zipFile.Entries[Path.GetFileName(file)];
                    if (ze != null)
                    {
                        meg += ze.SizeUncompressedLong;
                    }
                }
                meg /= (1024.0 * 1024.0);
                msg = string.Format("Compressed in {0:0.00} seconds, {1:0.00} meg/second", sec, meg / sec);
            }
            UpdateStatusBar(msg);
        }

        // show the about box
        void mnuAbout_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("C1Zip Demo\r\nCopyright (c) 2001, 2003 ComponentOne LLC", "About C1ZipDemo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

//			// just to show how to add directly into the zip file:
//          if (_zipFile.FileName != "")
//          {
//                // open compressed stream writer into zip file
//                Stream s = _zipFile.Entries.OpenWriter("About", true);
//
//                // write some stuff into it
//                int i, count = 1000;
//                StreamWriter sw = new StreamWriter(s);
//                for (i = 1; i <= count; i++)
//                    sw.WriteLine("{0}/{1}) This is being written to a compressed stream.", i, count);
//                sw.Flush();
//                s.Close();
//
//                // test adding streams
//                MemoryStream ms = new MemoryStream();
//                StreamWriter msw = new StreamWriter(ms);
//                for (i = 1; i <= count; i++)
//                    msw.WriteLine("{0}/{1}) This is being written to a memory stream.", i, count);
//                msw.Flush();
//                ms.Position = 0;
//                _zipFile.Entries.Add(ms, "MemStream");
//                ms.Close();
//
//                // show what we got
//                UpdateUI();
//            }
        }

        // Drag over
        void listView_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
        {
            // if the data object contains files, allow copy
            e.Effect = (e.Data.GetDataPresent("FileDrop"))
                ? DragDropEffects.Copy
                : DragDropEffects.None;
        }

        // Drag and drop
        void listView_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            // check whether data object contains files
            var fmt = "FileDrop";
            if (!e.Data.GetDataPresent(fmt))
            {
                return;
            }

            // get list of files in data object
            var files = e.Data.GetData(fmt) as Array;
            if (files == null)
            {
                return;
            }

			// get ready to work
			_cancel = _escape = false;
			
			// if we have a zip file ready, add the dragged files to it
            if (_zipFile.FileName.Length > 0)
            {
                // freeze display while adding folders 
                // (if they have many subfolders, there's too much painting going on)
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
            else // if we don't have a zip file ready, and the dragged files contain a zip file, open it
            {
                foreach (string file in files)
                {
                    if (Path.GetExtension(file).ToLower() == ".zip")
                    {
                        OpenZip(file);
                        break;
                    }
                }
                if (_zipFile.FileName.Length == 0)
                {
                    MessageBox.Show("Please open (or create) a zip file first.", "No Zip file");
                }
            }
        }

        // sort list of files on the list view
        bool _ascending = true;
        void listView_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {
            // create EntryComparer for the column that was clicked
            string colName = listView.Columns[e.Column].Text;
            listView.ListViewItemSorter = new EntryComparer(colName, _ascending);

            // sort the list
            listView.Sort();

            // toggle order for next time
            _ascending = !_ascending;
        }

        // switch view mode
        void mnuView_Click(object sender, System.EventArgs e)
        {
            // adjust checkmarks
            var item = (MenuItem)sender;
            foreach (MenuItem mi in mnuView.MenuItems)
            {
                mi.Checked = mi.Equals(item);
            }

            // switch view
            if (item.Equals(mnuViewLarge))  listView.View = View.LargeIcon;
            if (item.Equals(mnuViewSmall))  listView.View = View.SmallIcon;
            if (item.Equals(mnuViewList))   listView.View = View.List;
            if (item.Equals(mnuViewDetail)) listView.View = View.Details;
        }

        // show current entry in read-only editor
        void mnuViewEntry_Click(object sender, System.EventArgs e)
        {
            // get first selected item that is not a directory
            C1ZipEntry ze = null;
            foreach (ListViewItem lvi in listView.SelectedItems)
            {
                var zeItem = (C1ZipEntry)lvi.Tag;
                if ((zeItem.Attributes & FileAttributes.Directory) != 0)
                {
                    continue;
                }
                ze = zeItem;
                break;
            }
            if (ze == null) return;

            // read entry content
            var sb = new StringBuilder();
            using (var entry = ze.OpenReader())
            {
                var sr = new StreamReader(entry, Encoding.Default);
                while (!sr.EndOfStream && sb.Length < 1000000)
                {
                    sb.AppendLine(sr.ReadLine());
                }
            }

            // show it in dialog
            var view = new ViewDialog();
            view.Text = "View: " + ze.FileName;
            view.SetContent(sb.ToString());
            view.ShowDialog();
        }
        
        // edit comment for the zip file
        void mnuEditZipComment_Click_1(object sender, System.EventArgs e)
        {
            // make sure we have a zip file
            if (_zipFile.FileName == string.Empty)
            {
                return;
            }
            
            // get new comment from the user
            var dlg = new UserInputDialog();
            string comment = dlg.GetString("Enter new comment for the zip file", _zipFile.Comment);
            if (comment == null)
            {
                return;
            }

            // set new comment
            _zipFile.Comment = comment;

            // update status bar
            UpdateStatusBar();
        }
        
        // edit comment for the selected files within the zip file
        void mnuEditEntryComment_Click(object sender, System.EventArgs e)
        {
            // we need a selection
            if (listView.SelectedItems.Count == 0)
            {
                return;
            }

            // get current comment, if any
            var ze = (C1ZipEntry)listView.SelectedItems[0].Tag;
            var comment = ze.Comment;

            // get new comment from the user
            var dlg = new UserInputDialog();
            comment = dlg.GetString("Enter new comment for selected entries", comment);
            if (comment == null)
            {
                return;
            }

            // update the comments
            foreach (ListViewItem lvi in listView.SelectedItems)
            {
                ze = (C1ZipEntry)lvi.Tag;
                ze.Comment = comment;
            }

            // update the user interface
            UpdateUI();
        }

        // update status bar and menus whenever the selection changes
        void listView_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            UpdateStatusBar();
            UpdateMenus();
        }

        //--------------------------------------------------------------------------------
        // updating routines

        // update list, status bar, and menus
        void UpdateUI()
        {
            UpdateList();
            UpdateStatusBar();
            UpdateMenus();
        }

        // update file list
        bool _freezeList = false;
        void UpdateList()
        {
            // if the list is frozen, bail now
            if (_freezeList)
            {
                return;
            }

            // clear list
            listView.Items.Clear();
            
            // if no zip file, we're done
            if (_zipFile.FileName == string.Empty) 
            {
                UpdateStatusBar();
                UpdateMenus();
                return;
            }

            // fill out list
            var zec = _zipFile.Entries;
            listView.BeginUpdate();
            foreach (C1ZipEntry ze in zec)
            {
                var fa = ze.Attributes;
                var entry = new String[] 
                    {
                        FileName(ze.FileName),                      // file name, no extension
                        FileExtension(ze.FileName),                 // file extension, no dot
                        ze.Date.ToString("MM/dd/yy  HH:mm"),        // mod date/time
                        ze.SizeUncompressedLong.ToString("#,##0"),  // original size
                        ze.SizeCompressedLong.ToString("#,##0"),    // compressed size
                        AttribString(ze.Attributes),                // encode as "rahs"
						((uint)ze.CRC32).ToString(),                // CRC32 (unsigned looks better)
						ze.Comment                                  // user comment
                    };
                var lvi = new ListViewItem(entry);
                lvi.Tag = ze;
                lvi.ImageIndex = ((ze.Attributes & FileAttributes.Directory) != 0)? 0: 1;
                if (ze.IsEncrypted) lvi.ImageIndex = 3;
                listView.Items.Add(lvi);
            }
            listView.EndUpdate();
        }

        // update statusbar
        void UpdateStatusBar()
        {
            UpdateStatusBar(string.Empty);
        }
        void UpdateStatusBar(string msg)
        {
            // build status string
            if (!string.IsNullOrEmpty(msg))
            {
                // get counts
                long nCnt = listView.Items.Count;
                long nSel = listView.SelectedItems.Count;
                long nSize = 0;

                // calculate total size
                foreach (ListViewItem lvi in listView.SelectedItems)
                {
                    var ze = (C1ZipEntry)lvi.Tag;
                    nSize += ze.SizeUncompressedLong;
                }

                // build statistics string
                msg = (nCnt == 0)
                    ? "Ready"
                    : (nSize >= 3 * 1024 * 1024)
                        ? string.Format("{0} files, {1} selected, {2:#,##0}k bytes", nCnt, nSel, nSize / 1024)
                        : string.Format("{0} files, {1} selected, {2:#,##0} bytes", nCnt, nSel, nSize);
            }

            // show text, hide progress bar
            _lblStatus.Text = msg;
            _progressBar.Visible = false;
        }

        // update menus (enable/disable options)
        void UpdateMenus()
        {
            bool bZip = (_zipFile.FileName.Length > 0)? true: false;
            mnuCloseZip.Enabled         = bZip;
            mnuAddFolder.Enabled        = bZip;
            mnuAddFile.Enabled          = bZip;
            mnuEditComment.Enabled      = bZip;
            mnuPassword.Enabled         = bZip;
            mnuLevel.Enabled            = bZip;

            bool bEntries = (listView.Items.Count > 0)? true: false;
            mnuSelectAll.Enabled        = bEntries;
            mnuUnselectAll.Enabled      = bEntries;
            mnuInvertSelection.Enabled  = bEntries;
            mnuSelectGroup.Enabled      = bEntries;
            mnuTestZipFile.Enabled      = bEntries;

            bool bSelected = (listView.SelectedItems.Count > 0)? true: false;
            mnuExtract.Enabled          = bSelected;
            mnuDelete.Enabled           = bSelected;
            mnuEditEntryComment.Enabled = bSelected;
            mnuViewEntry.Enabled        = bSelected;

            // update title bar
            string str = _appTitle;
            if (_zipFile.FileName != string.Empty)
            {
                str = str + " - " + _zipFile.FileName;
            }
            Text = str;
        }

        //--------------------------------------------------------------------------------
        // utilities

        internal static string FileName(string fn)
        {
            int extLen = Path.GetExtension(fn).Length;
            return fn.Remove(fn.Length - extLen, extLen);
        }

        internal static string FileExtension(string fn)
        {
            string ext = Path.GetExtension(fn).ToLower();
            return ext.Replace(".", string.Empty);
        }

        internal static string AttribString(FileAttributes fa)
        {
            if ((fa & FileAttributes.Directory) != 0)
                return "<dir>";

            var atts = string.Empty;
            atts += ((fa & FileAttributes.ReadOnly) != 0)? "r": "-";
            atts += ((fa & FileAttributes.Archive)  != 0)? "a": "-";
            atts += ((fa & FileAttributes.Hidden)   != 0)? "h": "-";
            atts += ((fa & FileAttributes.System)   != 0)? "s": "-";
            return atts;
        }

        void mnuTestZipFile_Click(object sender, System.EventArgs e)
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
						var msg = "** " + ze.FileName + " failed CRC check. **";
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
			UpdateStatusBar(string.Empty);
            if (bOk)
            {
                var cnt = _zipFile.Entries.Count;
                UpdateStatusBar((cnt > 0)
                    ? cnt.ToString() + " files tested OK."
                    : "Nothing to test...");
            }
        }

        void mnuLevel_Click(object sender, System.EventArgs e)
        {
            // adjust checkmarks
            var item = (MenuItem)sender;
            foreach (MenuItem mi in mnuLevel.MenuItems)
            {
                mi.Checked = mi.Equals(item);
            }

            // switch view
            if (item.Equals(mnuLevelDefault)) _zipFile.CompressionLevel = CompressionLevelEnum.DefaultCompression;
            if (item.Equals(mnuLevelBest))    _zipFile.CompressionLevel = CompressionLevelEnum.BestCompression;
            if (item.Equals(mnuLevelFast))    _zipFile.CompressionLevel = CompressionLevelEnum.BestSpeed;
            if (item.Equals(mnuLevelNone))    _zipFile.CompressionLevel = CompressionLevelEnum.NoCompression;
        }

        void mnuPassword_Click(object sender, System.EventArgs e)
        {
            // show dialog
            var dlg = new UserInputDialog();
            var new_password = dlg.GetString("Choose a password", _zipFile.Password);
            
            // if user provided a new password, use it
            if (new_password != null)
            {
                _zipFile.Password = new_password;
            }
        }
    }


    //--------------------------------------------------------------------------------

    /// <summary>
    /// EntryComparer
    /// used for sorting items in the ListView control
    /// </summary>
    internal class EntryComparer : IComparer
    {
        string _colName;
        bool   _ascending;

        internal EntryComparer(string colName, bool ascending)
        {
            _colName = colName;
            _ascending = ascending;
        }
        public int Compare(object o1, object o2)
        {
            var z1 = (C1ZipEntry)((ListViewItem)o1).Tag;
            var z2 = (C1ZipEntry)((ListViewItem)o2).Tag;

            int res = 0;
            switch (_colName)
            {
                case "Name":
                    res = string.Compare(z1.FileName, z2.FileName, true);
                    break;
                case "Ext":
                    res = string.Compare(Path.GetExtension(z1.FileName), Path.GetExtension(z2.FileName), true);
                    break;
                case "Date":
                    res = z1.Date.CompareTo(z2.Date);
                    break;
                case "Size":
                    res = (int)(z1.SizeUncompressedLong - z2.SizeUncompressedLong);
                    break;
                case "Compr":
                    res = (int)(z1.SizeCompressedLong - z2.SizeCompressedLong);
                    break;
                case "Attrib":
                    res = string.Compare(Form1.AttribString(z1.Attributes), Form1.AttribString(z2.Attributes), true);
                    break;
                case "CRC32":
                    res = z1.CRC32 - z2.CRC32;
                    break;
                case "Comment":
                    res = string.Compare(z1.Comment, z2.Comment, true);
                    break;
                default:
                    Debug.Assert(false, _colName + " not mapped in sort routine.");
                    break;
            }
            return (_ascending)? res: -res;
        }
    }
}
