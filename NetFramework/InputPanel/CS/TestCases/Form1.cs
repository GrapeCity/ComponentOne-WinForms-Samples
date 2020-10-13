using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Xml;
using System.IO;

using C1.Win.C1InputPanel;

namespace TestCases
{
    /// <summary>
    /// This is the main form, it shows an input panel that can read several
    /// layouts encoded in Xml and converts them into a functional dynamic panel.
    /// </summary>
    public partial class Form1 : Form
    {
        private List<XmlNode> _items = new List<XmlNode>();
        private XmlNode _currentNode;
        private bool _inUpdateThemeCombo;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadXml();
        }
        private void reloadButton_Click(object sender, EventArgs e)
        {
            LoadXml();
        }
        private void LoadXml()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Application.StartupPath + @"\..\..\TestCases.xml");
            XmlNode rootNode = doc.SelectSingleNode("C1InputPanelTestCases");
            if (rootNode == null)
            {
                MessageBox.Show("Missing root tag: C1InputPanelTestCases");
                return;
            }
            _currentNode = null;
            _items.Clear();
            testCaseCombo.Items.Clear();
            foreach (XmlNode panelNode in rootNode.SelectNodes("C1InputPanel"))
            {
                testCaseCombo.Items.Add(XmlUtil.Read(panelNode, "id", "<no name>"));
                _items.Add(panelNode);
            }
            if (_items.Count > 0)
            {
                testCaseCombo.SelectedIndex = -1;
                testCaseCombo.SelectedIndex = 0;
            }
        }
        private void UpdateThemeCombo()
        {
            _inUpdateThemeCombo = true;
            switch (c1InputPanel1.VisualStyle)
            {
                case VisualStyle.System:
                    themeCombo.SelectedIndex = 0;
                    break;
                case VisualStyle.Office2007Blue:
                    themeCombo.SelectedIndex = 1;
                    break;
                case VisualStyle.Office2007Black:
                    themeCombo.SelectedIndex = 2;
                    break;
                case VisualStyle.Office2007Silver:
                    themeCombo.SelectedIndex = 3;
                    break;
            }
            _inUpdateThemeCombo = false;
        }
        private void UpdatePanel()
        {
            xmlTextBox.Text = String.Empty;
            c1InputPanel1.BeginUpdate();
            c1InputPanel1.Items.Clear(true);
            c1InputPanel1.VisualStyle = VisualStyle.System;
            if (_currentNode != null)
            {
                c1InputPanel1.VisualStyle = (VisualStyle)Enum.Parse(typeof(VisualStyle),
                    XmlUtil.Read(_currentNode, "visualStyle", "System"), true);
                LoadNodes(_currentNode.ChildNodes);

                // display XML in the memo control
                StringBuilder sb = new StringBuilder();
                StringWriter sw = new StringWriter(sb);
                XmlTextWriter writer = new XmlTextWriter(sw);
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 4;
                _currentNode.WriteTo(writer);
                writer.Flush();
                sw.Dispose();
                xmlTextBox.Text = sb.ToString();
            }
            c1InputPanel1.EndUpdate();
            UpdateThemeCombo();
        }
        private void LoadNodes(XmlNodeList nodeList)
        {
            foreach (XmlNode nc in nodeList)
            {
                AddInputComponent(nc);
                if (nc.Name == "C1InputGroup")
                {
                    LoadNodes(nc.ChildNodes);
                }
            }
        }
        private void ReadCommonProperties(XmlNode node, InputComponent c, bool ignoreWidth)
        {
            c.Enabled = XmlUtil.Read(node, "enabled", true);
            c.Visibility = XmlUtil.Read(node, "visible", true) ? Visibility.Visible : Visibility.Collapsed;
            c.Height = XmlUtil.Read(node, "height", -1);
            if (!ignoreWidth)
                c.Width = XmlUtil.Read(node, "width", -1);
            c.ToolTipText = XmlUtil.Read(node, "tooltip", String.Empty);
            c.Break = (BreakType)Enum.Parse(typeof(BreakType),
                XmlUtil.Read(node, "break", "row"), true);
        }
        private void ReadCommonProperties(XmlNode node, InputComponent c)
        {
            ReadCommonProperties(node, c, false);
        }
        private void AddInputComponent(XmlNode node)
        {
            switch (node.Name)
            {
                case "C1InputButton":
                    InputButton button = new InputButton();
                    ReadCommonProperties(node, button);
                    button.Text = XmlUtil.Read(node, "text", String.Empty);
                    button.Image = XmlUtil.ReadImage(node, "image");
                    button.CheckOnClick = XmlUtil.Read(node, "toggle", false);
                    button.Pressed = XmlUtil.Read(node, "pressed", false);
                    c1InputPanel1.Items.Add(button);
                    break;

                case "C1InputCheckBox":
                    InputCheckBox checkBox = new InputCheckBox();
                    ReadCommonProperties(node, checkBox);
                    checkBox.Checked = XmlUtil.Read(node, "checked", false);
                    checkBox.ThreeState = XmlUtil.Read(node, "threeState", false);
                    checkBox.Text = XmlUtil.Read(node, "text", String.Empty);
                    c1InputPanel1.Items.Add(checkBox);
                    break;

                case "C1InputComboBox":
                    InputComboBox comboBox = new InputComboBox();
                    ReadCommonProperties(node, comboBox, true);
                    comboBox.DropDownStyle = XmlUtil.Read(node, "dropDownList", false)
                        ? InputComboBoxStyle.DropDownList : InputComboBoxStyle.DropDown;
                    comboBox.MaxDropDownItems = XmlUtil.Read(node, "maxDropDownItems", 8);
                    comboBox.GripHandleVisible = XmlUtil.Read(node, "gripHandle", false);
                    comboBox.Text = XmlUtil.Read(node, "text", String.Empty);
                    comboBox.Width = XmlUtil.Read(node, "width", 100);
                    comboBox.MaxLength = XmlUtil.Read(node, "maxLength", 250);

                    // parse combobox options
                    string options = XmlUtil.Read(node, "options", String.Empty);
                    string[] optList = options.Split(',');
                    for (int i = 0; i < optList.Length; i++)
                    {
                        InputOption option = new InputOption();
                        option.Text = optList[i];
                        comboBox.Items.Add(option);
                    }

                    c1InputPanel1.Items.Add(comboBox);
                    break;

                case "C1InputDatePicker":
                    InputDatePicker datePicker = new InputDatePicker();
                    ReadCommonProperties(node, datePicker, true);
                    datePicker.Format = XmlUtil.Read(node, "format", String.Empty);
                    datePicker.ShowToday = XmlUtil.Read(node, "showToday", true);
                    datePicker.Width = XmlUtil.Read(node, "width", 100);
                    c1InputPanel1.Items.Add(datePicker);
                    break;

                case "C1InputGroup":
                    InputGroupHeader header = new InputGroupHeader();
                    header.Text = XmlUtil.Read(node, "text", String.Empty);
                    header.Collapsible = XmlUtil.Read(node, "collapsible", false);
                    header.Collapsed = XmlUtil.Read(node, "collapsed", false);
                    header.Height = XmlUtil.Read(node, "height", 24);
                    c1InputPanel1.Items.Add(header);
                    break;

                case "C1InputImage":
                    InputImage image = new InputImage();
                    ReadCommonProperties(node, image);
                    image.Image = XmlUtil.ReadImage(node, "image");
                    c1InputPanel1.Items.Add(image);
                    break;

                case "C1InputLabel":
                    InputLabel label = new InputLabel();
                    ReadCommonProperties(node, label);
                    label.Text = XmlUtil.Read(node, "text", String.Empty);
                    label.WordWrap = XmlUtil.Read(node, "wordwrap", false);
                    c1InputPanel1.Items.Add(label);
                    break;

                case "C1InputRadioButton":
                    InputRadioButton radioButton = new InputRadioButton();
                    ReadCommonProperties(node, radioButton);
                    radioButton.Checked = XmlUtil.Read(node, "checked", false);
                    radioButton.GroupName = XmlUtil.Read(node, "groupName", String.Empty);
                    radioButton.Text = XmlUtil.Read(node, "text", String.Empty);
                    c1InputPanel1.Items.Add(radioButton);
                    break;

                case "C1InputSeparator":
                    InputSeparator separator = new InputSeparator();
                    ReadCommonProperties(node, separator);
                    c1InputPanel1.Items.Add(separator);
                    break;

                case "C1InputTextBox":
                    InputTextBox textBox = new InputTextBox();
                    ReadCommonProperties(node, textBox, true);
                    textBox.Text = XmlUtil.Read(node, "text", String.Empty);
                    textBox.Width = XmlUtil.Read(node, "width", 100);
                    textBox.MaxLength = XmlUtil.Read(node, "maxLength", 250);
                    c1InputPanel1.Items.Add(textBox);
                    break;

                case "C1InputNumericBox":
                    InputNumericBox numBox = new InputNumericBox();
                    ReadCommonProperties(node, numBox, true);
                    numBox.Format = XmlUtil.Read(node, "format", string.Empty);
                    numBox.Text = XmlUtil.Read(node, "value", String.Empty);
                    numBox.Increment = Decimal.Parse(XmlUtil.Read(node, "step", "1"));
                    numBox.Width = XmlUtil.Read(node, "width", 100);
                    c1InputPanel1.Items.Add(numBox);
                    break;

                case "C1InputControlHost":
                    string className = XmlUtil.Read(node, "control", String.Empty);
                    if (!String.IsNullOrEmpty(className))
                    {
                        string qualifiedTypeName = typeof(Control).AssemblyQualifiedName;
                        qualifiedTypeName = qualifiedTypeName.Replace(".Control", "." + className);
                        Type controlType = Type.GetType(qualifiedTypeName, true);
                        if (controlType != null)
                        {
                            ConstructorInfo ci = controlType.GetConstructor(new Type[0]);
                            if (ci != null)
                            {
                                Control control = ci.Invoke(new object[0]) as Control;
                                if (control != null)
                                {
                                    InputControlHost controlHost = new InputControlHost(control);
                                    ReadCommonProperties(node, controlHost);
                                    c1InputPanel1.Items.Add(controlHost);
                                }
                            }
                        }
                    }
                    break;

                case "C1InputLinkLabel":
                    string linkText = XmlUtil.Read(node, "text", String.Empty);
                    if (!String.IsNullOrEmpty(linkText))
                    {
                        InputHtmlLabel htmlLabel = new InputHtmlLabel();
                        ReadCommonProperties(node, htmlLabel);
                        string linkHRef = XmlUtil.Read(node, "href", String.Empty);
                        htmlLabel.Text = "<a href='" + linkHRef + "'>" + linkText + "</a>";
                        htmlLabel.LinkClicked += new C1.Win.C1InputPanel.LinkClickedEventHandler(htmlLabel_LinkClicked);
                        c1InputPanel1.Items.Add(htmlLabel);
                    }
                    break;

                default:
                    InputLabel unknown = new InputLabel();
                    ReadCommonProperties(node, unknown);
                    string text = XmlUtil.Read(node, "text", String.Empty);
                    if (text.Length > 0)
                        unknown.Text = "< " + node.Name + ", Text = \"" + text + "\" >";
                    else
                        unknown.Text = "< " + node.Name + " >";
                    c1InputPanel1.Items.Add(unknown);
                    break;
            }
        }
        private void htmlLabel_LinkClicked(object sender, C1.Win.C1InputPanel.LinkClickedEventArgs e)
        {
            MessageBox.Show("Open URL: '" + e.HRef + "'", "Link Clicked");
        }
        private void testCaseCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_items.Count > 0 && testCaseCombo.SelectedIndex >= 0)
            {
                _currentNode = _items[testCaseCombo.SelectedIndex];
                UpdatePanel();
            }
        }
        private void themeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_inUpdateThemeCombo)
                return;
            switch (themeCombo.SelectedIndex)
            {
                case 0:
                    c1InputPanel1.VisualStyle = VisualStyle.System;
                    break;
                case 1:
                    c1InputPanel1.VisualStyle = VisualStyle.Office2007Blue;
                    break;
                case 2:
                    c1InputPanel1.VisualStyle = VisualStyle.Office2007Black;
                    break;
                case 3:
                    c1InputPanel1.VisualStyle = VisualStyle.Office2007Silver;
                    break;
            }
        }
    }
}