using C1.C1FlexReportExplorer.Properties;
using C1.Win.C1Tile;
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
        // C1TileControl is used to navigate between reports.
        // It has two 'levels' of files: 
        // - top level tiles correspond to report categories, while
        // - 2nd level tiles correspond to individual reports.
        //
        // The wiring of tiles and categories/reports:
        // Correspondence of tiles' properties and ReportInfos.xml elements/attributes:
        // - 'Top-level' tiles -> Category elements:
        // -- tile.Name: category.Name
        // -- tile.Text: category.Text
        // -- tile.Image: image loaded from category.Image resource
        // -- tile.Tag: instance of CategoryInfo, with child count.
        // 
        // - 'Child tiles' -> Report elements:
        // -- tile.Text: ReportTitle
        // -- tile.Tag: parent category.Name
        // -- tile.Text1: FileName
        // -- tile.Text2: ReportName
        // -- tile.Image: image loaded from ImageName resource
        //

        /// <summary>
        /// This is used to:
        /// - keep the count of 'child' tiles (there is no built in notion of parent-child in C1TileControl);
        /// - recognize that the current tile is a 'top-level' category tile.
        /// </summary>
        private class CategoryInfo
        {
            public int ReportCount { get; set; }
        }

        #region Private data members
        private PreviewForm _frmPreview = null;
        private Tile _previewTile = null;
        private static object s_collapseTag = new object();
        #endregion 

        #region ctor, form load, initialization
        public MainForm()
        {
            InitializeComponent();

            // Add 'top-level' tiles for categories:
            AddTilesForCategories();
            // Copy the list of category tiles and loop over it, 
            // as we are going to modify the tile collection (add report tiles):
            var categoryTiles = c1tileCntrl.Groups[0].Tiles.ToList();
            // Add report tiles:
            foreach (Tile tile in categoryTiles)
            {
                Image tempImg = (Image)Resources.ResourceManager.GetObject("expand");
                tile.Image1 = tempImg;
                tile.Image1.Tag = s_collapseTag;
                AddTilesInCategory(tile);
                HideShowTile(tile);
            }
        }

        private void AddTilesForCategories()
        {
            try
            {
                XDocument xdoc = LoadReportInfos();
                var categories = xdoc.Descendants("Category").ToList();
                // Sortinig categories by name makes navigation easier:
                categories.Sort((c1_, c2_) => string.Compare(c1_.Attribute("Text").Value, c2_.Attribute("Text").Value));
                foreach (XElement category in categories)
                {
                    string name = category.Attribute("Name").Value;
                    // Skip duplicate categories:
                    if (tileGrp.Tiles.Contains(name))
                        continue;
                    Tile tile = new Tile();
                    tile.Name = name;
                    tile.Text = category.Attribute("Text").Value;
                    tile.Image = (Image)Resources.ResourceManager.GetObject(category.Attribute("Image").Value);
                    if (!tile.Name.Equals("Separator"))
                    {
                        tile.VerticalSize = 5;
                        tile.Click += new System.EventHandler(this.Tile_Click);
                    }
                    else
                    {
                        tile.Template = _tileLineTemplate;
                    }
                    this.tileGrp.Tiles.Add(tile);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void AddTilesInCategory(Tile categoryTile)
        {
            string categoryName = categoryTile.Name;
            XDocument xdoc = LoadReportInfos();
            // Get the list of matching categories:
            var matchingCategories = xdoc.Descendants("Category").Where(c_ => string.Compare(c_.Attribute("Name").Value, categoryName, true) == 0);
            // Select all reports within:
            var reportNodes = matchingCategories.SelectMany(c_ => c_.Descendants("Report"));
            // Add CategoryInfo on the category tile now that we have all children:
            categoryTile.Tag = new CategoryInfo() { ReportCount = reportNodes.Count() };
            //
            foreach (XElement childReport in reportNodes)
            {
                Tile reportTile = new Tile();
                reportTile.Text = (string)childReport.Element("ReportTitle");
                reportTile.Tag = categoryName;
                reportTile.VerticalSize = 10;
                reportTile.Text1 = (string)childReport.Element("FileName");
                reportTile.Text2 = (string)childReport.Element("ReportName");
                reportTile.Image = GetReportPreviewImage(categoryName, (string)childReport.Element("ImageName"));
                reportTile.Template = _reportDefaultTemplate;
                reportTile.Click += ChldTile_Click;
                categoryTile.Group.Tiles.Insert(categoryTile.Index + 1, reportTile);
#if regenerate_screenshots
                // This code can be used to create the screenshots:
                var fileName = reportTile.Text1;
                var reportName = reportTile.Text2;
                var rptFile = Path.Combine(@"..\..\Reports", categoryName, fileName);
                try
                {
                    var flxRpt = LoadReport(categoryName, fileName, reportName);
                    flxRpt.Render();
                    Metafile mf = flxRpt.GetPageImage(0);
                    var imagePath = Path.Combine(@"..\..\Reports", categoryName, "Images", Path.GetFileNameWithoutExtension(fileName) + ".emf");
                    C1.Win.C1Document.Utils.WriteMetafileToFile(mf, imagePath);
                    System.Diagnostics.Debug.WriteLine("Screenshot " + imagePath + " written.");
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Error writing " + rptFile + ": " + ex.Message);
                }
#endif
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            try
            {
                XDocument xdoc = LoadReportInfos();
                XElement xelem = xdoc.Descendants("SelectedReport").First();
                string selCategory = xelem.Element("CategoryName").Value;
                string selRptName = xelem.Element("ReportName").Value;
                Tile tileCatSelected = this.tileGrp.Tiles.First(t => t.Name.ToLower() == selCategory.ToLower());
                if (tileCatSelected != null)
                {
                    Tile_Click(tileCatSelected, EventArgs.Empty);
                    Tile tileRptSelected = tileCatSelected.Group.Tiles.First(t => t.Text2.ToLower() == selRptName.ToLower() && t.Index > tileCatSelected.Index);
                    ChldTile_Click(tileRptSelected, EventArgs.Empty);
                    c1tileCntrl.ScrollToTile(tileRptSelected, true);
                }
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
                return Image.FromStream(file);
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
        /// Click Event 
        /// Hide And show child tiles based on tile clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tile_Click(object sender, EventArgs e)
        {
            HideShowTile((Tile)sender);
        }

        /// <summary>
        /// Click Event
        /// create Tle fo each report(s) preview in the below the parent tile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ChldTile_Click(object sender, EventArgs e)
        {
            var tile = (Tile)sender;
            flxViewer.DocumentSource = LoadReport(tile.Tag as string, tile.Text1, tile.Text2);
            HighlightSelectedTile(tile);
        }

        /// <summary>
        /// MouseMove Event
        /// Set location of Preview Form
        /// </summary>
        private void TileControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (dockTabPagePreview.AutoHiding)
                return;

            // Get Tile:
            Tile mouseTile = c1tileCntrl.GetTileAt(new Point(e.Location.X, e.Location.Y));
            // Nothing to do if we are already showing the preview for this tile:
            if (mouseTile == _previewTile)
                return;

            // If no tile, or a parent (category) tile, or we are on current tile - hide preview and we're done
            if (mouseTile == null || mouseTile.Tag is CategoryInfo || mouseTile.Template == _reportSelectedTemplate)
            {
                if (_frmPreview != null)
                {
                    _frmPreview.Hide();
                    _previewTile = null;
                }
                return;
            }

            if (_frmPreview == null)
                _frmPreview = new PreviewForm();

            // Get the image:
            Image img = mouseTile.Image;
            // Set preview orientation to match the screenshot:
            var w = _frmPreview.Width;
            var h = _frmPreview.Height;
            if ((w > h) != (img.Width > img.Height))
            {
                _frmPreview.Width = h;
                _frmPreview.Height = w;
            }
            _frmPreview.pictureBox1.Image = img;

            // Set Location:
            Point p = new Point(
                c1tileCntrl.Location.X + mouseTile.Group.X + mouseTile.X,
                c1tileCntrl.Location.Y + c1tileCntrl.ScrollOffset + mouseTile.Group.Y + mouseTile.Y);
            p = c1tileCntrl.PointToScreen(p);
            p.X += mouseTile.Width + 10;
            // Try to keep the preview within screen bounds:
            p.X = Math.Max(p.X, 0);
            p.Y = Math.Max(p.Y, 0);
            var screen = Screen.FromControl(this);
            p.Y = Math.Min(p.Y, screen.Bounds.Bottom - _frmPreview.Height);
            _frmPreview.Show(p);
            _previewTile = mouseTile;
        }

        /// <summary>
        /// MouseLeave Event
        /// Dispose preview form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TileControl_MouseLeave(object sender, EventArgs e)
        {
            if (_frmPreview != null)
                _frmPreview.Hide();
        }
        #endregion

        #region Private members
        private void HideShowTile(Tile tile)
        {
            int count = ((CategoryInfo)tile.Tag).ReportCount;
            if (tile.Image1.Tag == s_collapseTag)
            {
                for (int i = 0; i < count; i++)
                {
                    tile.Group.Tiles[tile.Index + i + 1].Visible = false;
                }
                Image _timg = tile.Image1;
                _timg.RotateFlip(RotateFlipType.Rotate180FlipX);
                tile.Image1 = null;
                tile.Image1 = _timg;
                tile.Image1.Tag = null; // "Expand";
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    tile.Group.Tiles[tile.Index + i + 1].Visible = true;
                }
                Image _timg = tile.Image1;
                _timg.RotateFlip(RotateFlipType.Rotate180FlipX);
                tile.Image1 = null;
                tile.Image1 = _timg;
                tile.Image1.Tag = s_collapseTag;
            }
        }

        /// <summary>
        /// Highlights the selected tile and its parent.
        /// </summary>
        /// <param name="tile"></param>
        private void HighlightSelectedTile(Tile tile)
        {
            var tiles = c1tileCntrl.Groups[0].Tiles;
            // Find old selected child/parent, reset their templates:
            var oldParent = tiles.FirstOrDefault(t_ => t_.Template == _tileSelectedTemplate);
            if (oldParent != null)
                oldParent.Template = null;
            var oldTile = tiles.FirstOrDefault(t_ => t_.Template == _reportSelectedTemplate);
            if (oldTile != null)
                oldTile.Template = _reportDefaultTemplate;
            // Set new selected tile/parent templates:
            var newParent = tiles.FirstOrDefault(t_ => string.Compare(t_.Name, tile.Tag as string, true) == 0);
            if (newParent != null)
                newParent.Template = _tileSelectedTemplate;
            tile.Template = _reportSelectedTemplate;
            // No point in previewing the current report, so hide preview:
            if (_frmPreview != null && tile == _previewTile)
                _frmPreview.Hide();
        }

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
                return;
            foreach (DataSource ds in rpt.DataSources)
                ds.ConnectionString = FixConnectionString(ds.ConnectionString);
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
                return connectionString;

            int dsIndexStart = connectionString.IndexOf("Data Source", 0, StringComparison.OrdinalIgnoreCase);
            if (dsIndexStart < 0)
                return connectionString;

            while (dsIndexStart < connectionString.Length && connectionString[dsIndexStart] != '=')
                ++dsIndexStart;
            if (dsIndexStart >= connectionString.Length)
                return connectionString;

            int dsIndexEnd = dsIndexStart;
            while (dsIndexEnd < connectionString.Length && connectionString[dsIndexEnd] != ';')
                ++dsIndexEnd;

            string dbName = connectionString.Substring(dsIndexStart + 1, dsIndexEnd - dsIndexStart - 1).Trim();
            if (dbName.Length == 0)
                return connectionString;

            // Look for the data file in:
            /// - Data folder rel to .exe;
            /// - ..\..\Data folder rel to .exe.
            var exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var tFile = Path.Combine(exePath, "Data", Path.GetFileName(dbName));
            if (!File.Exists(tFile))
                tFile = Path.Combine(exePath, @"..\..\Data", Path.GetFileName(dbName));
            if (File.Exists(tFile))
                dbName = tFile;

            connectionString = connectionString.Substring(0, dsIndexStart + 1) + dbName + connectionString.Substring(dsIndexEnd);
            return connectionString;
        }
#endregion
    }
}
