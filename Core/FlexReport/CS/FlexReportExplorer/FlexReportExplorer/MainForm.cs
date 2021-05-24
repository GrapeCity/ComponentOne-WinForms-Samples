using C1.C1FlexReportExplorer.Properties;
using C1.Win.TreeView;
//using C1.Win.C1Tile;
using C1.Win.FlexReport;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Reflection;

namespace C1.C1FlexReportExplorer
{
    public partial class MainForm : C1.Win.Ribbon.C1RibbonForm
    {
        #region Private data members
        private static object s_collapseTag = new object();
        private PreviewForm _frmPreview;
        private string _previewName = string.Empty;
        private string _viewName = string.Empty;
        private DateTime _previewDate;
        #endregion

        #region constructor, form load, initialization
        public MainForm()
        {
            InitializeComponent();

            // fill report list for categories:
            AddItemsForCategories();
        }

        private void AddItemsForCategories()
        {
            try
            {
                // read categories
                var xdoc = LoadReportInfos();
                var categories = xdoc.Descendants("Category").ToList();

                // name controlling
                var cache = new Dictionary<string, C1TreeNode>();

                // sorting categories by name makes navigation easier:
                categories.Sort((c1_, c2_) => string.Compare(c1_.Attribute("Text").Value, c2_.Attribute("Text").Value));
                foreach (XElement category in categories)
                {
                    // attributes of the category
                    var name = category.Attribute("Name").Value;
                    var title = category.Attribute("Text").Value;
                    var image = (Image)Resources.ResourceManager.GetObject(category.Attribute("Image").Value);

                    // skip duplicate categories:
                    if (cache.ContainsKey(name))
                    {
                        continue;
                    }

                    // fill node
                    var node = new C1TreeNode($"Node 0.{c1TreeView.Nodes.Count + 1}");
                    c1TreeView.Nodes.Add(node);
                    node.Tag = new TagInfo() { Name = name, Title = title, Image = image };
                    AddItemInCategory(xdoc, node);
                    cache.Add(name, node);
                }

                // set custom nodes
                c1TreeView.Columns[0].CustomContentPresenter = new ImageCustomNode();
                c1TreeView.Columns[1].CustomContentPresenter = new TitleCustomNode();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void AddItemInCategory(XDocument xdoc, C1TreeNode parentNode)
        {
            // get the list of matching categories:
            var categoryName = ((TagInfo)parentNode.Tag).Name;
            var matchingCategories = xdoc.Descendants("Category").Where(c_ => string.Compare(c_.Attribute("Name").Value, categoryName, true) == 0);

            // select all reports within:
            var reportNodes = matchingCategories.SelectMany(c_ => c_.Descendants("Report"));

            // fill children nodes
            foreach (XElement childReport in reportNodes)
            {
                // attributes of the report
                var title = (string)childReport.Element("ReportTitle");
                var fileName = (string)childReport.Element("FileName");
                var reportName = (string)childReport.Element("ReportName");
                var image = GetReportPreviewImage(categoryName, (string)childReport.Element("ImageName"));

                // fill node
                var node = new C1TreeNode($"Node 1.{parentNode.Nodes.Count + 1}");
                parentNode.Nodes.Add(node);
                node.Tag = new TagInfo() { Name = reportName, Title = title, Image = image, Path = fileName };
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            try
            {
                var xdoc = LoadReportInfos();
                var xelem = xdoc.Descendants("SelectedReport").First();
                var selCategory = xelem.Element("CategoryName").Value;
                var selRptName = xelem.Element("ReportName").Value;
                flxViewer.DocumentSource = LoadReport(selCategory, $"{selRptName}.flxr", selRptName);
                _viewName = selRptName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private XDocument LoadReportInfos()
        {
            Assembly thisExe = Assembly.GetExecutingAssembly();
            Stream file = thisExe.GetManifestResourceStream("C1.C1FlexReportExplorer.Resources.ReportInfos.xml");
            return XDocument.Load(file);
        }

        private Image GetReportPreviewImage(string category, string imageName)
        {
            Assembly thisExe = Assembly.GetExecutingAssembly();
            Stream file = thisExe.GetManifestResourceStream("C1.C1FlexReportExplorer.Reports." + category + ".Images." + imageName);
            if (file != null)
            {
                return Image.FromStream(file);
            }
            return null;
        }
        #endregion

        #region Event handling
        private void PbTabShowHide_Click(object sender, EventArgs e)
        {
            dockTabPagePreview.AutoHiding = !dockTabPagePreview.AutoHiding;
            Image img = pbTabShowHide.Image;
            img.RotateFlip(RotateFlipType.Rotate270FlipX);
            pbTabShowHide.Image = img;
        }

        /// <summary>
        /// Selected tree view item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void c1TreeView_SelectionChanged(object sender, C1TreeViewEventArgs e)
        {
            var node = e.Node;
            if (node.Level > 0)
            {
                var parentNode = node.ParentCollection.Parent;
                var category = ((TagInfo)parentNode.Tag).Name;
                var row = (TagInfo)node.Tag;
                flxViewer.DocumentSource = LoadReport(category, row.Path, row.Name);
                _viewName = row.Name;
            }
        }

        private void C1TreeView_MouseMove(object sender, MouseEventArgs e)
        {
            if (dockTabPagePreview.AutoHiding)
            {
                return;
            }

            var node = this.c1TreeView.GetNodeAtPoint(new Point(e.Location.X, e.Location.Y));
            var row = (node != null) ? (TagInfo)node.Tag : null;
            if (node == null || node.Level == 0 || row.Name == _viewName || row.Name == _previewName)
            {
                if (DateTime.Now.Subtract(_previewDate).TotalSeconds > 5)
                {
                    if (_frmPreview != null)
                        _frmPreview.Hide();
                    _previewName = string.Empty;
                }
                return;
            }

            _previewName = row.Name;
            _previewDate = DateTime.Now;

            //node.
            //var bound = this.c1TreeView.Vew,VT.GetBounds(node);
            //this.c1TreeView..GetBounds(.GetNodeAtPoint
            //node.

            //var parentNode = node.ParentCollection.Parent;
            //var category = ((TagInfo)parentNode.Tag).Name;


            // Get Tile:
            //Tile mouseTile = c1tileCntrl.GetTileAt(new Point(e.Location.X, e.Location.Y));
            //// Nothing to do if we are already showing the preview for this tile:
            //if (mouseTile == _previewTile)
            //    return;

            //// If no tile, or a parent (category) tile, or we are on current tile - hide preview and we're done
            //if (mouseTile == null || mouseTile.Tag is CategoryInfo || mouseTile.Template == _reportSelectedTemplate)
            //{
            //    if (_frmPreview != null)
            //    {
            //        _frmPreview.Hide();
            //        _previewTile = null;
            //    }
            //    return;
            //}

            // create preview:
            if (_frmPreview == null)
            {
                _frmPreview = new PreviewForm();
            }

            // set preview orientation to match the screen-shot:
            var w = _frmPreview.Width;
            var h = _frmPreview.Height;
            if ((w > h) != (row.Image.Width > row.Image.Height))
            {
                _frmPreview.Width = h;
                _frmPreview.Height = w;
            }
            _frmPreview.pictureBox1.Image = row.Image;

            // set location:
            Point p = new Point(
                c1TreeView.Location.X - c1TreeView.ScrollPosition.X + 200,
                c1TreeView.Location.Y - c1TreeView.ScrollPosition.Y + e.Location.Y);
            p = c1TreeView.PointToScreen(p);
            //p.X += mouseTile.Width + 10;

            // try to keep the preview within screen bounds:
            p.X = Math.Max(p.X, 0);
            p.Y = Math.Max(p.Y, 0);
            var screen = Screen.FromControl(this);
            p.Y = Math.Min(p.Y, screen.Bounds.Bottom - _frmPreview.Height);
            _frmPreview.Show(p);
        }

        #endregion

        #region Private members

        /// <summary>
        /// Tries to load the specified report from 3 locations, in order:
        /// - from embedded resource;
        /// - from file in Reports folder rel to .exe;
        /// - from file in ..\..\Reports folder rel to .exe.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="reportFile"></param>
        /// <param name="reportName"></param>
        /// <returns></returns>
        private C1FlexReport LoadReport(string category, string reportFile, string reportName)
        {
            try
            {
                Assembly thisExe = Assembly.GetExecutingAssembly();
                Stream file = thisExe.GetManifestResourceStream("C1.C1FlexReportExplorer.Reports." + category + "." + reportFile);
                if (file == null)
                {
                    var exePath = Path.GetDirectoryName(thisExe.Location);
                    var tFile = Path.Combine(exePath, "Reports", category, reportFile);
                    if (File.Exists(tFile))
                        file = new FileStream(tFile, FileMode.Open, FileAccess.Read);
                    else
                        file = new FileStream(Path.Combine(exePath, @"..\..\Reports", category, reportFile), FileMode.Open, FileAccess.Read);
                    if (file == null)
                        return null;
                }
                flxRpt = new C1FlexReport();
                flxRpt.Load(file, reportName);
                //
                FixConnectionStrings(flxRpt);
                //
                return flxRpt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return null;
            }
        }

        private void FixConnectionStrings(C1FlexReport rpt)
        {
            if (rpt == null)
            {
                return;
            }
            foreach (DataSource ds in rpt.DataSources)
            {
                ds.ConnectionString = FixConnectionString(ds.ConnectionString);
            }
            foreach (FieldBase f in rpt.Fields)
            {
                if (f is SubreportField)
                    FixConnectionStrings(((SubreportField)f).Subreport);
                else if (f is Field)
                    FixConnectionStrings(((Field)f).Subreport);
            }
        }

        private string FixConnectionString(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                return connectionString;
            }

            int dsIndexStart = connectionString.IndexOf("Data Source", 0, StringComparison.OrdinalIgnoreCase);
            if (dsIndexStart < 0)
            {
                return connectionString;
            }

            while (dsIndexStart < connectionString.Length && connectionString[dsIndexStart] != '=')
            {
                ++dsIndexStart;
            }
            if (dsIndexStart >= connectionString.Length)
            {
                return connectionString;
            }

            int dsIndexEnd = dsIndexStart;
            while (dsIndexEnd < connectionString.Length && connectionString[dsIndexEnd] != ';')
            {
                ++dsIndexEnd;
            }

            var dbName = connectionString.Substring(dsIndexStart + 1, dsIndexEnd - dsIndexStart - 1).Trim();
            if (dbName.Length == 0)
            {
                return connectionString;
            }

            // Look for the data file in:
            /// - Data folder rel to .exe;
            /// - ..\..\Data folder rel to .exe.
            var exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var tFile = Path.Combine(exePath, "Data", Path.GetFileName(dbName));
            if (!File.Exists(tFile))
            {
                tFile = Path.Combine(exePath, @"..\..\Data", Path.GetFileName(dbName));
            }
            if (File.Exists(tFile))
            {
                dbName = tFile;
            }

            connectionString = connectionString.Substring(0, dsIndexStart + 1) + dbName + connectionString.Substring(dsIndexEnd);
            return connectionString;
        }
#endregion
    }
}
