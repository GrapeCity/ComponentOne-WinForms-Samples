using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.Win.C1InputPanel;

namespace CustomEditors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formBackColorEditor.SelectedColor = BackColor;
            formForeColorEditor.SelectedColor = ForeColor;
            labelColorEditor.SelectedColor = demoLabel.ForeColor;
            formFontEditor.SelectedFont = Font;
            labelFontEditor.SelectedFont = demoLabel.Font;
        }

        private void formBackColorEditor_SelectedColorChanged(object sender, EventArgs e)
        {
            Color c = formBackColorEditor.SelectedColor;
            if (c != Color.Empty)
            {
                BackColor = c;
            }
        }

        private void formForeColorEditor_SelectedColorChanged(object sender, EventArgs e)
        {
            Color c = formForeColorEditor.SelectedColor;
            if (c != Color.Empty)
            {
                ForeColor = c;
            }
        }

        private void labelColorEditor_SelectedColorChanged(object sender, EventArgs e)
        {
            Color c = labelColorEditor.SelectedColor;
            if (c != Color.Empty)
            {
                demoLabel.ForeColor = c;
            }
        }

        private void formFontEditor_SelectedFontChanged(object sender, EventArgs e)
        {
            Font f = formFontEditor.SelectedFont;
            if (f != null)
            {
                Font = f;
            }
        }

        private void labelFontEditor_SelectedFontChanged(object sender, EventArgs e)
        {
            Font f = labelFontEditor.SelectedFont;
            if (f != null)
            {
                demoLabel.Font = f;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            c1InputPanel1.Items.Clear(true);
        }

        private void btnSaveXml_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.DefaultExt = ".xml";
                dlg.FileName = "inputpanel";
                dlg.Filter = "XML files|*.xml|All files|*.*";
                dlg.Title = "Save As XML File";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    c1InputPanel1.Save(dlg.FileName);
                }
            }
        }

        private void btnLoadXml_Click(object sender, EventArgs e)
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
                        c1InputPanel1.Load(dlg.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Bad Input Panel XML.", dlg.Title);
                    }
                }
            }
        }

        private void c1InputPanel1_ControlHostFromXmlNode(object sender, ControlHostFromXmlNodeEventArgs e)
        {
            switch (e.NodeName)
            {
                case ColorEditorHost.XmlNodeName:
                    e.ControlHost = new ColorEditorHost();
                    break;
                case FontEditorHost.XmlNodeName:
                    e.ControlHost = new FontEditorHost();
                    break;
            }
        }

        private void c1InputPanel1_ItemDeserialized(object sender, ItemDeserializedEventArgs e)
        {
            switch (e.Component.Name)
            {
                case "formBackColorEditor":
                    formBackColorEditor = (ColorEditorHost)e.Component;
                    formBackColorEditor.SelectedColor = BackColor;
                    formBackColorEditor.SelectedColorChanged += formBackColorEditor_SelectedColorChanged;
                    break;
                case "formForeColorEditor":
                    formForeColorEditor = (ColorEditorHost)e.Component;
                    formForeColorEditor.SelectedColor = ForeColor;
                    formForeColorEditor.SelectedColorChanged += formForeColorEditor_SelectedColorChanged;
                    break;
                case "labelColorEditor":
                    labelColorEditor = (ColorEditorHost)e.Component;
                    labelColorEditor.SelectedColor = demoLabel.ForeColor;
                    labelColorEditor.SelectedColorChanged += labelColorEditor_SelectedColorChanged;
                    break;
                case "formFontEditor":
                    formFontEditor = (FontEditorHost)e.Component;
                    formFontEditor.SelectedFont = Font;
                    formFontEditor.SelectedFontChanged += formFontEditor_SelectedFontChanged;
                    break;
                case "labelFontEditor":
                    labelFontEditor = (FontEditorHost)e.Component;
                    labelFontEditor.SelectedFont = demoLabel.Font;
                    labelFontEditor.SelectedFontChanged += labelFontEditor_SelectedFontChanged;
                    break;
            }
        }
    }
}