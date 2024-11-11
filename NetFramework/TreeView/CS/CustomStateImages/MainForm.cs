using C1.Win.Ribbon;
using C1.Win.C1Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CustomStateImages
{
    public partial class MainForm : C1RibbonForm
    {
        #region ctor
        public MainForm()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            foreach (var theme in C1ThemeController.GetThemes())
                ribbonCmbThemes.Items.Add(theme);
            ribbonCmbThemes.SelectedIndex = ribbonCmbThemes.Items.IndexOf("Office365White");
            c1TreeView1.Nodes[0].CheckState = CheckState.Checked;
            c1TreeView1.Nodes[1].CheckState = CheckState.Indeterminate;
            c1TreeView1.Nodes[0].Expanded = true;
            ribbonCBCheckBoxStates.Checked = true;
            ribbonCBExpandStates.Checked = true;
            ribbonCBEnabledTreeView.Checked = c1TreeView1.Enabled;
        }
        #endregion

        #region themes
        private void ribbonCmbThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThemeName = ribbonCmbThemes.SelectedItem.Text;
            ApplyTheme(this);
        }
        private string ThemeName
        {
            get;
            set;
        }
        private void ApplyTheme(Control control)
        {
            if (!string.IsNullOrEmpty(ThemeName))
            {
                var theme = C1ThemeController.GetThemeByName(ThemeName, false);
                if (theme != null)
                    C1ThemeController.ApplyThemeToControlTree(control, theme);
            }
        }
        #endregion

        #region images
        private void ribbonBtnEditCheckBox_Click(object sender, EventArgs e)
        {
            var imgEditor = new CheckStateImageEditor(c1TreeView1.CheckImageList);
            ApplyTheme(imgEditor);
            if (imgEditor.ShowDialog() == DialogResult.OK)
            {
                imgEditor.FillImageList();
            }
        }

        private void ribbonBtnEditExpand_Click(object sender, EventArgs e)
        {
            var imgEditor = new ButtonStateImageEditor(c1TreeView1.ButtonImageList);
            ApplyTheme(imgEditor);
            if (imgEditor.ShowDialog() == DialogResult.OK)
            {
                imgEditor.FillImageList();
            }
        }

        private void ribbonCBCheckBoxStates_CheckedChanged(object sender, EventArgs e)
        {
            if (ribbonCBCheckBoxStates.Checked)
            {
                c1TreeView1.CheckImageList.Images.Clear();
                c1TreeView1.CheckImageList.Images.Add("Unchecked", Properties.Resources.UncheckedNormal);
                c1TreeView1.CheckImageList.Images.Add("Checked", Properties.Resources.CheckedNormal);
                c1TreeView1.CheckImageList.Images.Add("Mixed", Properties.Resources.MixedNormal);
            }
            else
            {
                c1TreeView1.CheckImageList.Images.Clear();
                foreach (string key in Enum.GetNames(typeof(CheckBoxState)))
                    c1TreeView1.CheckImageList.Images.Add(key, GetImageFromResource(key + ".png"));
            }
            c1TreeView1.Invalidate();
        }

        private void ribbonCBExpandStates_CheckedChanged(object sender, EventArgs e)
        {
            if (ribbonCBExpandStates.Checked)
            {
                c1TreeView1.ButtonImageList.Images.Clear();                
                c1TreeView1.ButtonImageList.Images.Add("Expanded", Properties.Resources.ExpandedNormal);
                c1TreeView1.ButtonImageList.Images.Add("Collapsed", Properties.Resources.CollapsedNormal);
            }
            else
            {
                c1TreeView1.ButtonImageList.Images.Clear();
                c1TreeView1.ButtonImageList.Images.Add("ExpandedNormal", Properties.Resources.ExpandedNormal);
                c1TreeView1.ButtonImageList.Images.Add("ExpandedHot", Properties.Resources.ExpandedHot);
                c1TreeView1.ButtonImageList.Images.Add("ExpandedPressed", Properties.Resources.ExpandedPressed);
                c1TreeView1.ButtonImageList.Images.Add("ExpandedDisabled", Properties.Resources.ExpandedDisabled);
                c1TreeView1.ButtonImageList.Images.Add("CollapsedNormal", Properties.Resources.CollapsedNormal);
                c1TreeView1.ButtonImageList.Images.Add("CollapsedHot", Properties.Resources.CollapsedHot);
                c1TreeView1.ButtonImageList.Images.Add("CollapsedPressed", Properties.Resources.CollapsedPressed);
                c1TreeView1.ButtonImageList.Images.Add("CollapsedDisabled", Properties.Resources.CollapsedDisabled);                
            }
            c1TreeView1.Invalidate();
        }

        private Image GetImageFromResource(string resourceName)
        {
            var fullResourceName = GetFullResourceName(resourceName);
            var asm = Assembly.GetExecutingAssembly();
            Image img;
            using (var stream = asm.GetManifestResourceStream(fullResourceName))
            {
                img = Image.FromStream(stream);
            }
            return img;
        }

        private string GetFullResourceName(string resourceName)
        {
            var asm = Assembly.GetExecutingAssembly();
            resourceName = "." + resourceName;
            string[] names = asm.GetManifestResourceNames();
            string name = string.Empty;
            for (int i = 0; i < names.Length; i++)
            {
                name = names[i];
                if (name.EndsWith(resourceName, StringComparison.OrdinalIgnoreCase))
                {
                    return name;
                }
            }
            return string.Empty;
        }
        #endregion

        private void ribbonCBEnabledTreeView_CheckedChanged(object sender, EventArgs e)
        {
            c1TreeView1.Enabled = ribbonCBEnabledTreeView.Checked;
        }
    }
}
