using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.Win.C1Ribbon;
using ControlHostLib;

namespace ControlHostDemo
{
    public partial class DemoForm : C1RibbonForm
    {
        private bool _internalFontChange;

        public DemoForm()
        {
            InitializeComponent();

            Font font = label1.Font;
            _internalFontChange = true;
            fontEditor.SelectedFont = font;
            numericUpDownHost1.Value = Convert.ToDecimal(font.SizeInPoints);
            _internalFontChange = false;

            backColorEditor.SelectedColor = label1.BackColor;
            foreColorEditor.SelectedColor = label1.ForeColor;

            axWebBrowserHost1.Navigate(Application.StartupPath +
                @"\..\..\Html\A plea for C++.htm");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxHost1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the Earth.", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void numericUpDownHost1_ValueChanged(object sender, EventArgs e)
        {
            if (!_internalFontChange)
            {
                Font font = label1.Font;
                font = new Font(font.Name, Convert.ToSingle(numericUpDownHost1.Value), font.Style, font.Unit);
                _internalFontChange = true;
                label1.Font = font;
                fontEditor.SelectedFont = font;
                _internalFontChange = false;
            }
            statusLabel.Text = String.Format("Number is {0}", numericUpDownHost1.Value);
        }

        private void checkedListBoxHost1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox.ObjectCollection coll = checkedListBoxHost1.Items;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < coll.Count; i++)
            {
                bool isChecked = false;
                if (i == e.Index)
                    isChecked = e.NewValue == CheckState.Checked;
                else
                    isChecked = checkedListBoxHost1.GetItemChecked(i);
                if (isChecked)
                {
                    sb.Append(coll[i]).Append(", ");
                }
            }
            string res;
            if (sb.Length > 0)
            {
                res = sb.ToString(0, sb.Length - 2);
                label1.Text = res;
            }
            else
            {
                res = "<none>";
                label1.Text = "Demo";
            }
            checkStatusLabel.Text = "Checked: " + res;
        }

        private void backColorEditor_SelectedColorChanged(object sender, EventArgs e)
        {
            label1.BackColor = backColorEditor.SelectedColor;
        }

        private void foreColorEditor_SelectedColorChanged(object sender, EventArgs e)
        {
            label1.ForeColor = foreColorEditor.SelectedColor;
        }

        private void fontEditor_SelectedFontChanged(object sender, EventArgs e)
        {
            if (!_internalFontChange)
            {
                _internalFontChange = true;
                label1.Font = fontEditor.SelectedFont;
                numericUpDownHost1.Value = Convert.ToDecimal(fontEditor.SelectedFont.SizeInPoints);
                _internalFontChange = false;
            }
        }

        private void DemoForm_Resize(object sender, EventArgs e)
        {
            if (c1Ribbon1.Tabs.Count > 0)
            {
                axWebBrowserHost1.Width = Width - 40;
            }
        }

        private void rbClear_Click(object sender, EventArgs e)
        {
            c1Ribbon1.Tabs.ClearAndDisposeTabs();
        }

        private void rbLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.DefaultExt = ".xml";
                dlg.Filter = "XML files|*.xml|All files|*.*";
                dlg.Title = "Load From XML File";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        c1Ribbon1.Load(dlg.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Bad Ribbon XML.", dlg.Title);
                    }
                }
            }
        }

        private void rbSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.DefaultExt = ".xml";
                dlg.FileName = "ribbon";
                dlg.Filter = "XML files|*.xml|All files|*.*";
                dlg.Title = "Save As XML File";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    c1Ribbon1.Save(dlg.FileName);
                }
            }
        }

        private void c1Ribbon1_ControlHostFromXmlNode(object sender, ControlHostFromXmlNodeEventArgs e)
        {
            switch (e.NodeName)
            {
                case PictureBoxHost.XmlNodeName:
                    e.ControlHost = new PictureBoxHost();
                    break;
                case NumericUpDownHost.XmlNodeName:
                    e.ControlHost = new NumericUpDownHost();
                    break;
                case FontEditorHost.XmlNodeName:
                    e.ControlHost = new FontEditorHost();
                    break;
                case ColorEditorHost.XmlNodeName:
                    e.ControlHost = new ColorEditorHost();
                    break;
                case CheckedListBoxHost.XmlNodeName:
                    e.ControlHost = new CheckedListBoxHost();
                    break;
                case AxWebBrowserHost.XmlNodeName:
                    e.ControlHost = new AxWebBrowserHost();
                    break;
            }
        }

        private void c1Ribbon1_ItemDeserialized(object sender, ItemDeserializedEventArgs e)
        {
            switch (e.Item.Name)
            {
                case "exitButton":
                    exitButton = (RibbonButton)e.Item;
                    exitButton.Click += exitButton_Click;
                    break;
                case "ribbonApplicationMenu1":
                    ribbonApplicationMenu1 = (RibbonApplicationMenu)e.Item;
                    ribbonApplicationMenu1.DoubleClick += exitButton_Click;
                    break;
                case "pictureBoxHost1":
                    pictureBoxHost1 = (PictureBoxHost)e.Item;
                    pictureBoxHost1.Click += pictureBoxHost1_Click;
                    break;
                case "numericUpDownHost1":
                    numericUpDownHost1 = (NumericUpDownHost)e.Item;
                    numericUpDownHost1.ValueChanged += numericUpDownHost1_ValueChanged;
                    break;
                case "checkedListBoxHost1":
                    checkedListBoxHost1 = (CheckedListBoxHost)e.Item;
                    checkedListBoxHost1.ItemCheck += checkedListBoxHost1_ItemCheck;
                    break;
                case "backColorEditor":
                    backColorEditor = (ColorEditorHost)e.Item;
                    backColorEditor.SelectedColorChanged += backColorEditor_SelectedColorChanged;
                    break;
                case "foreColorEditor":
                    foreColorEditor = (ColorEditorHost)e.Item;
                    foreColorEditor.SelectedColorChanged += foreColorEditor_SelectedColorChanged;
                    break;
                case "fontEditor":
                    fontEditor = (FontEditorHost)e.Item;
                    fontEditor.SelectedFontChanged += fontEditor_SelectedFontChanged;
                    break;
                case "axWebBrowserHost1":
                    axWebBrowserHost1 = (AxWebBrowserHost)e.Item;
                    axWebBrowserHost1.Navigate(Application.StartupPath +
                        @"\..\..\Html\A plea for C++.htm");
                    break;
            }
        }

        private void c1Ribbon1_RibbonDeserialized(object sender, EventArgs e)
        {
            numericUpDownHost1_ValueChanged(this, EventArgs.Empty);
            backColorEditor_SelectedColorChanged(this, EventArgs.Empty);
            foreColorEditor_SelectedColorChanged(this, EventArgs.Empty);
            fontEditor_SelectedFontChanged(this, EventArgs.Empty);

            checkedListBoxHost1_ItemCheck(this, new ItemCheckEventArgs(-1, CheckState.Indeterminate, CheckState.Indeterminate));
        }
    }
}