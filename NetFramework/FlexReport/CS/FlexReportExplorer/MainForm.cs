using FlexReportExplorer.Properties;
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
using GrapeCity.DataVisualization.TypeScript;

namespace FlexReportExplorer
{
    public partial class MainForm : C1.Win.Ribbon.C1RibbonForm
    {

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
        Dictionary<string, List<string>> _sideMenuText = new Dictionary<string, List<string>>();
        #endregion 

        #region ctor, form load, initialization
        public MainForm()
        {
            InitializeComponent();
            AddTilesForCategories();
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
                    var parentName = category.Attribute("Name").Value;
                    if (!_sideMenuText.ContainsKey(parentName))
                    {
                        _sideMenuText.Add(parentName, new List<string>());
                    }
                    foreach (XElement collection in category.Elements())
                    {
                        var childName = collection.Elements().First().Value;
                        _sideMenuText[parentName].Add(childName);
                    }
                }

                foreach (var item in _sideMenuText)
                {
                    AccordionNode parent = new AccordionNode()
                    {
                        Role = Helper.Roles.parent,
                        Text = item.Key,
                    };

                    foreach (string subItem in item.Value)
                    {
                        AccordionNode child = new AccordionNode()
                        {
                            Role = Helper.Roles.child,
                            Text = subItem,
                            Tag = $"{item.Key},{subItem}",
                        };
                        parent.Controls.Add(child);
                    }
                    accordionArea1.Controls.Add(parent);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // load default report
            try
            {
                var xdoc = LoadReportInfos();
                var xelem = xdoc.Descendants("SelectedReport").First();
                var selCategory = xelem.Element("CategoryName").Value;
                var selRptName = xelem.Element("ReportName").Value;
                flxViewer.DocumentSource = LoadReport(selCategory, $"{selRptName}.flxr", selRptName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private XDocument LoadReportInfos()
        {
            Assembly thisExe = Assembly.GetExecutingAssembly();
            Stream file = thisExe.GetManifestResourceStream("FlexReportExplorer.Resources.ReportInfos.xml");
            return XDocument.Load(file);
        }

        private Image GetReportPreviewImage(string category, string imageName)
        {
            Assembly thisExe = Assembly.GetExecutingAssembly();
            Stream file = thisExe.GetManifestResourceStream("FlexReportExplorer.Reports." + category + ".Images." + imageName);
            if (file != null)
                return Image.FromStream(file);
            return null;
        }

        private string GetFileName(string name)
        {
            var xdoc = LoadReportInfos();
            var categories = xdoc.Descendants("Category").ToList();
            foreach (XElement category in categories)
            {
                foreach (XElement collection in category.Elements())
                {
                    var childName = collection.Elements().First().Value;
                    if (childName == name)
                    {
                        var fileName = collection.Elements().ToArray()[1].Value;
                        return fileName;
                    }
                }
            }
            return "";
        }
        #endregion

        #region Event handling

        private void Accordion_Child_Clicked(object sender, EventArgs e)
        {
            AccordionNode node = (AccordionNode)sender;

            string parentName = (sender as AccordionNode).Tag.ToString().Split(',')[0];
            string childName = (sender as AccordionNode).Tag.ToString().Split(',')[1];
            string fileName = GetFileName(childName);

            if (fileName != "")
            {
                flxViewer.DocumentSource = LoadReport(parentName, fileName, childName);
            }
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
        /// Tries to load the specified report from 3 locations, in order:
        /// - from embedded resource;
        /// - from file in Reports folder rel to .exe;
        /// - from file in ..\..\..\Reports folder rel to .exe.
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
                Stream file = thisExe.GetManifestResourceStream("FlexReportExplorer.Reports." + category + "." + reportFile);
                if (file == null)
                {
                    var exePath = Path.GetDirectoryName(thisExe.Location);
                    var tFile = Path.Combine(exePath, "Reports", category, reportFile);
                    if (File.Exists(tFile))
                        file = new FileStream(tFile, FileMode.Open, FileAccess.Read);
                    else
                        file = new FileStream(Path.Combine(exePath, @"..\..\..\Reports", category, reportFile), FileMode.Open, FileAccess.Read);
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
            /// - ..\..\..\Data folder rel to .exe.
            var exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var tFile = Path.Combine(exePath, "Data", Path.GetFileName(dbName));
            if (!File.Exists(tFile))
                tFile = Path.Combine(exePath, @"..\..\..\Data", Path.GetFileName(dbName));
            if (File.Exists(tFile))
                dbName = tFile;

            connectionString = connectionString.Substring(0, dsIndexStart + 1) + dbName + connectionString.Substring(dsIndexEnd);
            return connectionString;
        }
#endregion
    }
}
