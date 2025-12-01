using C1.Win.TreeView;
using Custom_Localization.Events;
using Custom_Localization.Models;
using Custom_Localization.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Custom_Localization.Pages
{
    public partial class ViewResourceFilePage : UserControl
    {
        private ObservableCollection<TreeItemModel> _treeData;
        ResourceFileReader dataSource = new ResourceFileReader();

        public ViewResourceFilePage()
        {
            InitializeComponent();
            InitializeFlexGrid();
            InitializeRichTextBox();

            var projTree = new ProjectTreeBuilder();
            _treeData= projTree.GetProjectStructure();

            customTreeView1.Mapper = item => CreateNode((TreeItemModel)item);
            customTreeView1.TreeData = _treeData;
            customTreeView1.TreeNodeSelectedItemChanged += CustomTreeView1_TreeNodeSelectedItemChanged;
            customTreeView1.IsFirstNodeSelected = true;

            CultureManager.CultureChanged += CultureManager_CultureChanged;
        }

        private void CultureManager_CultureChanged(object? sender, EventArgs e)
        {
            RefreshCultures();
            InitializeRichTextBox();
        }

        private void RefreshCultures()
        {
            projectDirectoryViewer.Text = Resources.ViewSourcePage_ProjectDirectoryViewerPane_Label_Text;
            resourceViewer.Text = Resources.ViewSourcePage_ResourceViewerPane_Label_Text;
        }

        private void InitializeRichTextBox()
        {
            richTextBox1.Clear();

            // Title
            richTextBox1.SelectionIndent = 5;
            richTextBox1.SelectionFont = new Font("Segoe UI", 11, FontStyle.Bold);
            richTextBox1.AppendText(Resources.ViewSourcePage_LocalizationGuidePane_Title_Text + "\n\n");

            // Intro
            richTextBox1.SelectionIndent = 10;
            richTextBox1.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            richTextBox1.AppendText(Resources.ViewSourcePage_LocalizationGuidePane_Intro_Description_Text + "\n\n");

            // Resource Files Section
            richTextBox1.SelectionIndent = 5;
            richTextBox1.SelectionFont = new Font("Segoe UI", 10, FontStyle.Bold);
            richTextBox1.AppendText(Resources.ViewSourcePage_LocalizationGuidePane_ResourceFiles_Title_Text + "\n");

            richTextBox1.SelectionIndent = 20;
            richTextBox1.SelectionHangingIndent = 15;
            richTextBox1.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            richTextBox1.AppendText("• " + Resources.ViewSourcePage_LocalizationGuidePane_ResourceFiles_Bullet1_Text + "\n");
            richTextBox1.AppendText("• " + Resources.ViewSourcePage_LocalizationGuidePane_ResourceFiles_Bullet2_Text + "\n");

            richTextBox1.AppendText("  " + Resources.ViewSourcePage_LocalizationGuidePane_ResourceFiles_Example_Label_Text + "\n");

            richTextBox1.SelectionIndent = 40;
            richTextBox1.SelectionHangingIndent = 0;
            richTextBox1.AppendText(Resources.ViewSourcePage_LocalizationGuidePane_ResourceFiles_Example_FileName_Text + "\n\n");

            // Custom Localization Section
            richTextBox1.SelectionIndent = 5;
            richTextBox1.SelectionFont = new Font("Segoe UI", 10, FontStyle.Bold);
            richTextBox1.AppendText(Resources.ViewSourcePage_LocalizationGuidePane_CustomLocalization_Title_Text + "\n");

            richTextBox1.SelectionIndent = 20;
            richTextBox1.SelectionHangingIndent = 15;
            richTextBox1.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            richTextBox1.AppendText("1. " + Resources.ViewSourcePage_LocalizationGuidePane_CustomLocalization_Step1_Text + "\n");
            richTextBox1.AppendText("2. " + Resources.ViewSourcePage_LocalizationGuidePane_CustomLocalization_Step2_Text + "\n");
            richTextBox1.AppendText("   " + Resources.ViewSourcePage_LocalizationGuidePane_CustomLocalization_Example_Label_Text + "\n");

            richTextBox1.SelectionIndent = 40;
            richTextBox1.AppendText(Resources.ViewSourcePage_LocalizationGuidePane_CustomLocalization_Example_FileName_Text + "\n");

            richTextBox1.SelectionIndent = 20;
            richTextBox1.AppendText("3. " + Resources.ViewSourcePage_LocalizationGuidePane_CustomLocalization_Step3_Text + "\n\n");

            // Final Step Section
            richTextBox1.SelectionIndent = 5;
            richTextBox1.SelectionFont = new Font("Segoe UI", 10, FontStyle.Bold);
            richTextBox1.AppendText(Resources.ViewSourcePage_LocalizationGuidePane_FinalStep_Title_Text + "\n");

            richTextBox1.SelectionIndent = 20;
            richTextBox1.SelectionHangingIndent = 15;
            richTextBox1.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            richTextBox1.AppendText("• " + Resources.ViewSourcePage_LocalizationGuidePane_FinalStep_Bullet1_Text + "\n");
            richTextBox1.AppendText("• " + Resources.ViewSourcePage_LocalizationGuidePane_FinalStep_Bullet2_Text + "\n");

        }


        private void CustomTreeView1_TreeNodeSelectedItemChanged(object? sender, UserControls.Events.SelectedItemChangedEventArgs e)
        {
            var modelItem = e.Item.Tag as TreeItemModel;

            if(modelItem != null && modelItem.Name.EndsWith(".resx"))
            {
                var parentItem = e.Item.Parent!.Text;
                c1FlexGrid1.DataSource = dataSource.ReadResourceFiles(parentItem, modelItem.Name);
            }    
        }

        // Important Directory to be displayed containing the Custom Resources files
        private static readonly HashSet<string> validResxFolderDirectory = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "CustomResources",
        };


        private static TreeNode CreateNode(TreeItemModel item)
        {
            var node = new TreeNode(item.Name) { Tag = item };
            string containingFolder = Path.GetFileName(Path.GetDirectoryName(item.FullPath))!;

            if (!item.IsDirectory
                && item.Name.EndsWith(".resx", StringComparison.OrdinalIgnoreCase)
                && validResxFolderDirectory.Contains(containingFolder!))
            {
                node.NodeFont = new Font(SystemFonts.DefaultFont, FontStyle.Bold);
            }

            foreach (var child in item.Children)
            {
                var childNode = CreateNode(child);
                node.Nodes.Add(childNode);
            }

            if (item.IsDirectory
                && item.HasResxFile
                && validResxFolderDirectory.Contains(item.Name))
            {
                node.Expand();
            }

            return node;
        }

        // expand flexgrid to full width
        private void C1FlexGrid1_DataSourceChanged(object? sender, EventArgs e)
        {
            // the index stars from 1 because 0 is for row headers and from 1 are the actual columns
            for (int i = 1; i < c1FlexGrid1.Cols.Count; i++)
            {
                c1FlexGrid1.Cols[i].StarWidth = "*";
            }
        }

        private void InitializeFlexGrid()
        {
            c1FlexGrid1.AutoResize = true;
            c1FlexGrid1.AllowFiltering = true;
            c1FlexGrid1.DataSourceChanged += C1FlexGrid1_DataSourceChanged;

            // passing the default folder and resource file for initial display
            c1FlexGrid1.DataSource = dataSource.ReadResourceFiles("CustomResources", "C1.Win.Schedule.Localization.Strings.dz.resx");
        }
    }
}
