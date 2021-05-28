using GrapeCity.Win.BarCode;
using GrapeCity.Win.Bars;
using GrapeCity.Win.Buttons;
using GrapeCity.Win.Calculations;
using GrapeCity.Win.Containers;
using GrapeCity.Win.Pickers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClickOnceDemo.GcZoomPages
{
    public static class PlusPakCreater
    {
        internal static string[] PlusPakPolicies = new string[] 
        {
            "GcBarCodeZoomPolicy",
            "GcCheckBoxZoomPolicy",
            "GcRadioButtonPolicy",
            "GcGroupBoxControlBasePolicy",
            "GcDropDownButtonBasePolicy",
            "GcSplitButtonPolicy",
            "GcShapeButtonPolicy",
            "GcCalculatorPolicy",
            "GcAccordionContainerPolicy",
            "GcComboFramePolicy",
            "GcContainerPolicy",
            "GcHeadingContainerPolicy",
            "GcResizePanelPolicy",
            "GcTabControlPolicy",
            "GcTabPagePolicy",
            "GcTableLayoutContainerPolicy",
            "GcFlowLayoutContainerPolicy",
            "GcFontPickerPolicy",
            "GcFunctionKeyPolicy",
            "GcClassicFunctionKeyPolicy",
        };

        public static Control CreateControl(string zoomPolicy, Font font, Size layoutSize)
        {
            switch (zoomPolicy)
            {
                case "GcBarCodeZoomPolicy":
                    Panel panel1 = new Panel();
                    panel1.BackColor = Color.LightSkyBlue;
                    GcBarCode barCode1 = new GcBarCode();
                    barCode1.AdjustSize = false;
                    barCode1.Value = "123456";
                    barCode1.Location = new Point(10, 10);
                    ZoomPolicyProviderBase.PutControlInCenter(panel1, layoutSize);
                    panel1.Controls.Add(barCode1);
                    panel1.Size = new Size(161, 73);
                    return panel1;
                case "GcCheckBoxZoomPolicy":
                    GcCheckBox checkBox1 = new GcCheckBox();
                    checkBox1.CheckMarkAutoSize = false;
                    checkBox1.Text = "GcCheckBox";
                    checkBox1.StretchSystemCheckMark = true;
                    ZoomPolicyProviderBase.PutControlInCenter(checkBox1, layoutSize);
                    return checkBox1;
                case "GcRadioButtonPolicy":
                    GcRadioButton radioButton1 = new GcRadioButton();
                    radioButton1.CheckMarkAutoSize = false;
                    radioButton1.StretchSystemCheckMark = true;
                    radioButton1.Text = "GcRadioButton";
                    ZoomPolicyProviderBase.PutControlInCenter(radioButton1, layoutSize);
                    return radioButton1;
                case "GcGroupBoxControlBasePolicy":
                    Panel panel2 = new Panel();
                    GcCheckedGroupBox checkedGroup1 = new GcCheckedGroupBox();
                    checkedGroup1.Size = new Size(100, 100);
                    checkedGroup1.Items.Add("aaa");
                    checkedGroup1.Items.Add("bbb");
                    checkedGroup1.Items.Add("ccc");
                    GcRadioGroupBox radioGroup1 = new GcRadioGroupBox();
                    radioGroup1.Location = new Point(0, 106);
                    radioGroup1.Size = new Size(100, 100);
                    radioGroup1.Items.Add("aaa");
                    radioGroup1.Items.Add("bbb");
                    radioGroup1.Items.Add("ccc");
                    panel2.Controls.Add(checkedGroup1);
                    panel2.Controls.Add(radioGroup1);
                    panel2.Size = new Size(100, 210);
                    ZoomPolicyProviderBase.PutControlInCenter(panel2, layoutSize);
                    return panel2;
                case "GcDropDownButtonBasePolicy":
                    GcDropDownButton dropDownButton = new GcDropDownButton();
                    dropDownButton.DropDown = new ToolStripDropDown();
                    dropDownButton.DropDown.Items.Add("aaa");
                    dropDownButton.DropDown.Items.Add("bbb");
                    dropDownButton.DropDown.Items.Add("ccc");
                    ZoomPolicyProviderBase.PutControlInCenter(dropDownButton, layoutSize);
                    return ZoomPolicyProviderBase.AddComments(dropDownButton, "Please zoom in then click DropDownButton to show the DropDown.");
                case "GcSplitButtonPolicy":
                    GcSplitButton splitButton1 = new GcSplitButton();
                    ZoomPolicyProviderBase.PutControlInCenter(splitButton1, layoutSize);                   
                    return splitButton1;
                case "GcShapeButtonPolicy":
                    GcShapeButton shapeButton1 = new GcShapeButton();
                    shapeButton1.NormalImage = Properties.Resources.cube;
                    shapeButton1.DefaultImage = Properties.Resources.cube;
                    shapeButton1.ActiveImage = Properties.Resources.cube;
                    shapeButton1.Size = new Size(74, 74);
                    shapeButton1.Location = new Point(10, 10);
                    shapeButton1.Text = "ShapeButton";
                    ZoomPolicyProviderBase.PutControlInCenter(shapeButton1, layoutSize);
                    return shapeButton1;
                case "GcCalculatorPolicy":
                    GcCalculator calculator1 = new GcCalculator();
                    calculator1.OutputHeight = 20;
                    ZoomPolicyProviderBase.PutControlInCenter(calculator1, layoutSize);
                    return calculator1;
                case "GcAccordionContainerPolicy":
                    GcAccordionContainer accordionContainer1 = new GcAccordionContainer();
                    accordionContainer1.ItemSpace = 20;
                    accordionContainer1.HeaderSettings.Font = new Font(accordionContainer1.Font.FontFamily, 12);
                    accordionContainer1.Items.Add(new GcAccordionItem());
                    accordionContainer1.Items.Add(new GcAccordionItem());
                    accordionContainer1.Items.Add(new GcAccordionItem());
                    accordionContainer1.Items[0].IsExpanded = false;
                    accordionContainer1.Items[1].IsExpanded = false;
                    accordionContainer1.Items[2].IsExpanded = false;
                    accordionContainer1.Items[0].Text = "GcAccordionItem1";
                    accordionContainer1.Items[1].Text = "GcAccordionItem2";
                    accordionContainer1.Items[2].Text = "GcAccordionItem3";
                    ZoomPolicyProviderBase.PutControlInCenter(accordionContainer1, layoutSize);
                    return accordionContainer1;
                case "GcComboFramePolicy":
                    GcComboFrame comboFrame1 = new GcComboFrame();
                    comboFrame1.DropDownSettings.AutoSize = false;
                    return comboFrame1;
                case "GcContainerPolicy":
                    GcContainer container1 = new GcContainer();
                    container1.Controls.Add(new TextBox());
                    container1.Controls.Add(new TextBox());
                    container1.Controls.Add(new TextBox());
                    container1.Controls[0].Bounds = new Rectangle(80, 10, 80, 20);
                    container1.Controls[1].Bounds = new Rectangle(80, 40, 80, 20);
                    container1.Controls[2].Bounds = new Rectangle(80, 70, 80, 20);
                    container1.SetCaptionText(container1.Controls[0], "TextBox1:");
                    container1.SetCaptionText(container1.Controls[1], "TextBox2:");
                    container1.SetCaptionText(container1.Controls[2], "TextBox3:");
                    container1.Size = new Size(170, 110);
                    container1.CaptionFormat.Spacing = 10;
                    container1.CaptionFormat.Font = new Font(container1.Font.FontFamily, 9, FontStyle.Bold);
                    container1.CaptionFormat.TextHAlign = GrapeCity.Win.Common.TextHAlign.Right;
                    ZoomPolicyProviderBase.PutControlInCenter(container1, layoutSize);
                    return container1;
                case "GcHeadingContainerPolicy":
                    GcHeadingContainer headingContainer1 = new GcHeadingContainer();
                    headingContainer1.BackColor = Color.LightSkyBlue;
                    headingContainer1.IsExpanded = false;
                    headingContainer1.Text = "GcHeadingContainer";
                    headingContainer1.Location = new Point(20, 100);
                    headingContainer1.HeaderSettings.Font = new Font(headingContainer1.Font.FontFamily, 10);
                    return ZoomPolicyProviderBase.AddComments(headingContainer1, "Please zoom in then click the expanded button.");;
                case "GcResizePanelPolicy":
                    GcResizePanel resizePanel1 = new GcResizePanel();
                    resizePanel1.Font = new Font(resizePanel1.Font.FontFamily, 12);
                    resizePanel1.Controls.Add(new Label());
                    resizePanel1.Controls.Add(new Label());
                    resizePanel1.Controls.Add(new Label());
                    resizePanel1.Controls.Add(new Label());
                    resizePanel1.Controls[0].Bounds = new Rectangle(10, 10, 60, 20);
                    resizePanel1.Controls[1].Bounds = new Rectangle(80, 10, 60, 20);
                    resizePanel1.Controls[2].Bounds = new Rectangle(10, 40, 60, 20);
                    resizePanel1.Controls[3].Bounds = new Rectangle(80, 40, 60, 20);
                    (resizePanel1.Controls[0] as Label).TextAlign = ContentAlignment.MiddleCenter;
                    (resizePanel1.Controls[1] as Label).TextAlign = ContentAlignment.MiddleCenter;
                    (resizePanel1.Controls[2] as Label).TextAlign = ContentAlignment.MiddleCenter;
                    (resizePanel1.Controls[3] as Label).TextAlign = ContentAlignment.MiddleCenter;
                    resizePanel1.Controls[0].BackColor = Color.LightPink;
                    resizePanel1.Controls[1].BackColor = Color.LightPink;
                    resizePanel1.Controls[2].BackColor = Color.LightPink;
                    resizePanel1.Controls[3].BackColor = Color.LightPink;
                    resizePanel1.Controls[0].Text = "Label";
                    resizePanel1.Controls[1].Text = "Labe2";
                    resizePanel1.Controls[2].Text = "Labe3";
                    resizePanel1.Controls[3].Text = "Labe4";
                    //resizePanel1.Size = new Size(150, 70);
                    resizePanel1.Dock = DockStyle.Fill;
                    resizePanel1.BackColor = Color.LightSkyBlue;
                    //ZoomPolicyProviderBase.PutControlInCenter(resizePanel1, layoutSize);
                    return resizePanel1;
                case "GcTabControlPolicy":
                    GcTabControl tabControl1 = new GcTabControl();
                    tabControl1.TabPages.Add(new GcTabPage("TabPage1"));
                    tabControl1.TabPages.Add(new GcTabPage("TabPage2"));
                    tabControl1.TabPages.Add(new GcTabPage("TabPage3"));
                    tabControl1.TabPages.Add(new GcTabPage("TabPage4"));
                    tabControl1.TabPages.Add(new GcTabPage("TabPage5"));
                    tabControl1.TabPages.Add(new GcTabPage("TabPage6"));
                    tabControl1.NavigatorStyle.Size = new Size(20, 20);
                    tabControl1.TabSpace = 10;
                    tabControl1.TabStyle.Font = new Font(tabControl1.Font.FontFamily, 8);
                    ZoomPolicyProviderBase.PutControlInCenter(tabControl1, layoutSize);
                    return tabControl1;
                case "GcTabPagePolicy":
                    GcTabControl tabControl2 = new GcTabControl();
                    tabControl2.Width = 300;

                    GcTabPage tabPage1 = new GcTabPage("TabPage1");
                    tabPage1.TabStyle = new TabStyle();
                    tabPage1.TabStyle.Font = new Font(tabPage1.Font.FontFamily, 12);
                    tabPage1.TabStyle.ItemSize = new Size(70, 25);

                    tabControl2.TabStyle.Font = new Font(tabControl2.Font.FontFamily, 8);
                    tabControl2.TabStyle.ItemSize = new Size(60, 20);

                    tabControl2.TabPages.Add(tabPage1);
                    tabControl2.TabPages.Add(new GcTabPage("TabPage2"));
                    tabControl2.TabPages.Add(new GcTabPage("TabPage3"));
                    tabControl2.TabPages.Add(new GcTabPage("TabPage4"));
                    ZoomPolicyProviderBase.PutControlInCenter(tabControl2, layoutSize);
                    return tabControl2;
                case "GcTableLayoutContainerPolicy":
                    GcTableLayoutContainer tableLayout1 = new GcTableLayoutContainer();
                    tableLayout1.BackColor = Color.Gray;
                    tableLayout1.RowCount = 3;
                    tableLayout1.ColumnCount = 3;
                    tableLayout1.Rows[0].SizeType = SizeType.Absolute;
                    tableLayout1.Rows[1].SizeType = SizeType.Absolute;
                    tableLayout1.Columns[0].SizeType = SizeType.Absolute;
                    tableLayout1.Columns[1].SizeType = SizeType.Absolute;
                    tableLayout1.Rows[0].Height = 50;
                    tableLayout1.Rows[1].Height = 50;
                    tableLayout1.Columns[0].Width = 50;
                    tableLayout1.Columns[1].Width = 50;
                    tableLayout1.Size = new Size(150, 150);
                    tableLayout1.Controls.Add(new Panel());
                    tableLayout1.Controls.Add(new Panel());
                    tableLayout1.Controls.Add(new Panel());
                    tableLayout1.Controls.Add(new Panel());
                    tableLayout1.Controls[0].BackColor = Color.LightCyan;
                    tableLayout1.Controls[1].BackColor = Color.LightGoldenrodYellow;
                    tableLayout1.Controls[2].BackColor = Color.LightPink;
                    tableLayout1.Controls[3].BackColor = Color.LightSalmon;
                    tableLayout1.SetRow(tableLayout1.Controls[2], 1);
                    tableLayout1.SetRow(tableLayout1.Controls[3], 1);
                    tableLayout1.SetColumn(tableLayout1.Controls[1], 1);
                    tableLayout1.SetColumn(tableLayout1.Controls[2], 1);
                    ZoomPolicyProviderBase.PutControlInCenter(tableLayout1, layoutSize);
                    return tableLayout1;
                case "GcFlowLayoutContainerPolicy":
                    GcFlowLayoutContainer flowLayout1 = new GcFlowLayoutContainer();
                    flowLayout1.BackColor = Color.LightSkyBlue;
                    flowLayout1.Size = new Size(320, 200);
                    flowLayout1.Controls.Add(new TextBox());
                    flowLayout1.Controls.Add(new TextBox());
                    flowLayout1.Controls.Add(new TextBox());
                    flowLayout1.Controls.Add(new TextBox());
                    flowLayout1.Controls.Add(new TextBox());
                    flowLayout1.Controls.Add(new TextBox());
                    flowLayout1.Controls.Add(new TextBox());
                    flowLayout1.Controls[0].Width = 40;
                    flowLayout1.Controls[1].Width = 40;
                    flowLayout1.Controls[2].Width = 40;
                    flowLayout1.Controls[3].Width = 40;
                    flowLayout1.Controls[4].Width = 40;
                    flowLayout1.Controls[5].Width = 40;
                    flowLayout1.Controls[6].Width = 40;
                    flowLayout1.SetCaptionText(flowLayout1.Controls[0], "Text1");
                    flowLayout1.SetCaptionText(flowLayout1.Controls[1], "Text2");
                    flowLayout1.SetCaptionText(flowLayout1.Controls[2], "Text3");
                    flowLayout1.SetCaptionText(flowLayout1.Controls[3], "Text4");
                    flowLayout1.SetCaptionText(flowLayout1.Controls[4], "Text5");
                    flowLayout1.SetCaptionText(flowLayout1.Controls[5], "Text6");
                    flowLayout1.SetCaptionText(flowLayout1.Controls[6], "Text7");
                    flowLayout1.CaptionFormat.TextHAlign = GrapeCity.Win.Common.TextHAlign.Right;
                    flowLayout1.CaptionFormat.Size = 40;
                    return flowLayout1;
                case "GcFontPickerPolicy":
                    GcFontPicker fontPiker = new GcFontPicker();
                    fontPiker.ItemStyle.FontSize = 8;
                    fontPiker.Bounds = new Rectangle(30, 60, 200, 30);
                    fontPiker.Text = fontPiker.Font.Name;
                    return ZoomPolicyProviderBase.AddComments(fontPiker, "Please zoom in then click the DropDown button.");
                case "GcFunctionKeyPolicy":
                    Panel panel4 = new Panel();
                    panel4.Dock = DockStyle.Fill;
                    GcFunctionKey functionKey1 = new GcFunctionKey();
                    functionKey1.FunctionKeyButtons.Add(new FunctionKeyButton(Keys.A, "AAA"));
                    functionKey1.FunctionKeyButtons.Add(new FunctionKeyButton(Keys.B, "BBB"));
                    functionKey1.FunctionKeyButtons.Add(new FunctionKeyButton(Keys.C, "CCC"));;
                    functionKey1.FunctionKeyButtons[0].Font = new Font(functionKey1.Font.FontFamily, 8);
                    functionKey1.FunctionKeyButtons[1].Font = new Font(functionKey1.Font.FontFamily, 10);
                    functionKey1.FunctionKeyButtons[2].Font = new Font(functionKey1.Font.FontFamily, 9);
                    functionKey1.Dock = DockStyle.Top;
                    panel4.Controls.Add(functionKey1);
                    panel4.Controls.Add(new TextBox());
                    panel4.Controls[1].Bounds = new Rectangle(10, 30, 80, 20);
                    return panel4;
                case "GcClassicFunctionKeyPolicy":
                    GcClassicFunctionKey classicFunctionKey1 = new GcClassicFunctionKey();
                    classicFunctionKey1.Dock = DockStyle.Top;
                    classicFunctionKey1.ButtonWidth = 30;
                    classicFunctionKey1.StyleSets.Add("style1", new FlatStyleSet());
                    (classicFunctionKey1.StyleSets[0] as BaseStyleSet).Font = new Font(Control.DefaultFont.FontFamily, 9);
                    classicFunctionKey1.ActiveStyleSet = "style1";
                    return classicFunctionKey1;
                default:
                    break;
            }
            return null;
        }

        internal static string GetDescription(string zoomPolicy)
        {
            switch (zoomPolicy)
            {
                case "GcBarCodeZoomPolicy":
                    return Properties.Resources.ZoomPolicy_PPK_GcBarCode;
                case "GcCheckBoxZoomPolicy":
                    return Properties.Resources.ZoomPolicy_PPK_GcCheckBox;
                case "GcRadioButtonPolicy":
                    return Properties.Resources.ZoomPolicy_PPK_GcRadioButton;
                case "GcGroupBoxControlBasePolicy":
                    return Properties.Resources.ZoomPolicy_PPK_GcGroupBoxBase;
                case "GcDropDownButtonBasePolicy":
                    return Properties.Resources.ZoomPolicy_PPK_GcDropDownButton;
                case "GcSplitButtonPolicy":
                    return Properties.Resources.ZoomPolicy_PPK_GcSplitButton;
                case "GcShapeButtonPolicy":
                    return Properties.Resources.ZoomPolicy_PPK_GcShapeButton;
                case "GcAccordionContainerPolicy":
                    return Properties.Resources.ZoomPolicy_PPK_GcAccordionContainer;
                case "GcCalculatorPolicy":
                    return Properties.Resources.ZoomPolicy_PPK_GcCalculator;
                case "GcComboFramePolicy":
                    return Properties.Resources.ZoomPolicy_PPK_GcComboFrame;
                case "GcContainerPolicy":
                    return Properties.Resources.ZoomPolicy_PPK_GcContainer;
                case "GcHeadingContainerPolicy":
                    return Properties.Resources.ZoomPolicy_PPK_GcHeadingContainer;
                case "GcResizePanelPolicy":
                    return Properties.Resources.ZoomPolicy_PPK_GcResizePanel;
                case "GcTabControlPolicy":
                    return Properties.Resources.ZoomPolicy_PPK_GcTabControl;
                case "GcTableLayoutContainerPolicy":
                    return Properties.Resources.ZoomPolicy_PPK_GcTableLayoutContainer;
                case "GcFlowLayoutContainerPolicy":
                    return Properties.Resources.ZoomPolicy_PPK_GcFlowLayoutContainer;
                case "GcFontPickerPolicy":
                    return Properties.Resources.ZoomPolicy_PPK_GcFontPicker;
                case "GcFunctionKeyPolicy":
                    return Properties.Resources.ZoomPolicy_PPK_GcFunctionKey;
                case "GcClassicFunctionKeyPolicy":
                    return Properties.Resources.ZoomPolicy_PPK_GcClassicFunctionKey;
                case "GcTabPagePolicy" :
                    return Properties.Resources.ZoomPolicy_PPK_GcTabPage;
                default:
                    break;
            }
            return "";
        }
    }
}
