using GrapeCity.Win.Editors;
using GrapeCity.Win.Editors.Fields;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClickOnceDemo.GcZoomPages
{
    public static class InputManCreater
    {
        internal static string[] InputManPolicies = new string[] 
        {
            "GcTextBoxZoomPolicy",
            "GcMaskZoomPolicy",
            "GcNumberZoomPolicy",
            "GcCharMaskZoomPolicy",
            "GcTimeSpanZoomPolicy",
            "GcDateTimeZoomPolicy",
            "GcComboBoxZoomPolicy",
            "GcListBoxZoomPolicy"
        };

        public static Control CreateControl(string zoomPolicy, Font font, Size layoutSize)
        {
            switch (zoomPolicy)
            {
                case "GcTextBoxZoomPolicy":
                    GcTextBox textBox1 = new GcTextBox();
                    textBox1.SideButtons.Add(new DropDownButton());
                    textBox1.DropDown.Size = new Size(100, 100);
                    ZoomPolicyProviderBase.PutControlInCenter(textBox1, layoutSize);
                    return ZoomPolicyProviderBase.AddComments(textBox1, "Please zoom in then pay attention to the width of the DropDownButton and the size of the DropDownEditor.");
                case "GcMaskZoomPolicy":
                    GcMask mask = new GcMask();
                    mask.Height = 30;
                    MaskPatternField maskPatternField1 = new MaskPatternField();
                    MaskLiteralField maskLiteralField1 = new MaskLiteralField();
                    MaskPatternField maskPatternField2 = new MaskPatternField();
                    maskPatternField1.MaxLength = 3;
                    maskPatternField1.MinLength = 3;
                    maskPatternField1.Pattern = "\\D";
                    maskPatternField1.Font = new Font(mask.Font.FontFamily, 15);
                    maskLiteralField1.Text = "-";
                    maskPatternField2.MaxLength = 4;
                    maskPatternField2.MinLength = 4;
                    maskPatternField2.Pattern = "\\D";
                    maskPatternField2.Font = new Font(mask.Font.FontFamily, 7);
                    mask.Fields.AddRange(new GrapeCity.Win.Editors.Fields.MaskField[] {
                        maskPatternField1,
                        maskLiteralField1,
                        maskPatternField2});
                    mask.SideButtons.Add(new DropDownButton());
                    mask.Value = "123456";
                    ZoomPolicyProviderBase.PutControlInCenter(mask, layoutSize);
                    return mask;
                case "GcNumberZoomPolicy":
                    GcNumber number1 = new GcNumber();
                    number1.TouchDropDownScale = 1;
                    number1.DropDownCalculator.Font = new Font(number1.Font.FontFamily, 12);
                    ZoomPolicyProviderBase.PutControlInCenter(number1, layoutSize);
                    return ZoomPolicyProviderBase.AddComments(number1, "Please zoom in then pay attention to the size and font of the DropDownCalculator.");
                case "GcCharMaskZoomPolicy":
                    GcCharMask charMask1 = new GcCharMask();
                    charMask1.Height = 33;
                    charMask1.CharBoxes.Clear();
                    charMask1.CharBoxes.AddRange(new GrapeCity.Win.Editors.CharBox[] {
                        new InputBox(true, new Size(27, 27), Color.Transparent, Color.Empty, CharBoxStyle.Normal, new Padding(0), new Padding(1), new CharBoxBorder(), new Font(charMask1.Font.FontFamily, 12), ContentAlignment.MiddleCenter),
                        new InputBox(true, new Size(17, 17), Color.Transparent, Color.Empty, CharBoxStyle.Normal, new Padding(0), new Padding(1), new CharBoxBorder(), new Font(charMask1.Font.FontFamily, 7), ContentAlignment.MiddleCenter),
                        new InputBox(true, new Size(27, 17), Color.Transparent, Color.Empty, CharBoxStyle.Normal, new Padding(0), new Padding(1), new CharBoxBorder(), null, ContentAlignment.MiddleCenter)
                    });
                    charMask1.Value = "ABC";
                    ZoomPolicyProviderBase.PutControlInCenter(charMask1, layoutSize);
                    return charMask1;
                case "GcTimeSpanZoomPolicy":
                    GcTimeSpan gcTimeSpan1 = new GcTimeSpan();
                    gcTimeSpan1.Height = 30;
                    TimeSpanHourField timeSpanHourField1 = new TimeSpanHourField();
                    TimeSpanLiteralField timeSpanLiteralField2 = new TimeSpanLiteralField();
                    TimeSpanMinuteField timeSpanMinuteField1 = new TimeSpanMinuteField();
                    TimeSpanLiteralField timeSpanLiteralField3 = new TimeSpanLiteralField();
                    TimeSpanSecondField timeSpanSecondField1 = new TimeSpanSecondField();
                    timeSpanHourField1.Digits = 2;
                    timeSpanHourField1.Font = new Font(gcTimeSpan1.Font.FontFamily, 12);
                    timeSpanLiteralField2.Text = ":";
                    timeSpanMinuteField1.Digits = 2;
                    timeSpanMinuteField1.Font = new Font(gcTimeSpan1.Font.FontFamily, 7);
                    timeSpanLiteralField3.Text = ":";
                    timeSpanSecondField1.Digits = 2;
                    gcTimeSpan1.Fields.Clear();
                    gcTimeSpan1.Fields.AddRange(new GrapeCity.Win.Editors.Fields.TimeSpanField[] {
                        timeSpanHourField1,
                        timeSpanLiteralField2,
                        timeSpanMinuteField1,
                        timeSpanLiteralField3,
                        timeSpanSecondField1});
                    ZoomPolicyProviderBase.PutControlInCenter(gcTimeSpan1, layoutSize);
                    gcTimeSpan1.Value = new TimeSpan(11, 26, 34);
                    return gcTimeSpan1;
                case "GcDateTimeZoomPolicy":
                    GcDateTime gcDateTime1 = new GcDateTime();
                    gcDateTime1.Size = new Size(160, 30);
                    gcDateTime1.Fields[0].Font = new Font(gcDateTime1.Font.FontFamily, 12);
                    gcDateTime1.Fields[2].Font = new Font(gcDateTime1.Font.FontFamily, 7);
                    gcDateTime1.DropDownCalendar.ItemStyle.Font = new Font(gcDateTime1.Font.FontFamily, 12);
                    ZoomPolicyProviderBase.PutControlInCenter(gcDateTime1, layoutSize);
                    return ZoomPolicyProviderBase.AddComments(gcDateTime1, "Please zoom in then pay attention to the size and font of the DropDownCalendar.");
                case "GcComboBoxZoomPolicy":
                    GcComboBox comboBox1 = new GcComboBox();
                    comboBox1.DropDown.Height = 160;
                    comboBox1.DropDown.Width = 100;
                    comboBox1.Items.Add("aaa");
                    ListItem item1 = new ListItem();
                    item1.Text = "bbb";
                    item1.Font = new Font(comboBox1.Font.FontFamily, 12);
                    comboBox1.Items.Add(item1);
                    comboBox1.Items.Add("ccc");
                    comboBox1.Items.Add("ddd");
                    ZoomPolicyProviderBase.PutControlInCenter(comboBox1, layoutSize);
                    return ZoomPolicyProviderBase.AddComments(comboBox1, "Please zoom in then pay attention to the size and font of the DropDownList.");
                case "GcListBoxZoomPolicy":
                    GcListBox listBox1 = new GcListBox();
                    listBox1.Items.Add("aaa");
                    ListItem item2 = new ListItem();
                    item2.Text = "bbb";
                    item2.Font = new Font(listBox1.Font.FontFamily, 12);
                    ListItem item3 = new ListItem();
                    item3.Text = "ccc";
                    item3.Font = new Font(listBox1.Font.FontFamily, 7);
                    listBox1.Items.Add(item3);
                    listBox1.Items.Add("ddd");
                    listBox1.Items.Add("eee");
                    ZoomPolicyProviderBase.PutControlInCenter(listBox1, layoutSize);
                    return listBox1;
                default:
                    break;
            }
            return null;
        }


        internal static string GetDescription(string zoomPolicy)
        {
            switch (zoomPolicy)
            {
                case"GcTextBoxZoomPolicy":
                    return Properties.Resources.ZoomPolicy_IM_GcTextBox;
                case"GcMaskZoomPolicy":
                    return Properties.Resources.ZoomPolicy_IM_GcMask;
                case"GcNumberZoomPolicy":
                    return Properties.Resources.ZoomPolicy_IM_GcNumber;
                case"GcCharMaskZoomPolicy":
                    return Properties.Resources.ZoomPolicy_IM_GcCharMask;
                case"GcTimeSpanZoomPolicy":
                    return Properties.Resources.ZoomPolicy_IM_GcTimeSpan;
                case"GcDateTimeZoomPolicy":
                    return Properties.Resources.ZoomPolicy_IM_GcDateTime;
                case"GcComboBoxZoomPolicy":
                    return Properties.Resources.ZoomPolicy_IM_GcComboBox;
                case"GcListBoxZoomPolicy":
                    return Properties.Resources.ZoomPolicy_IM_GcListBox;
                default:
                    break;
            }
            return "";
        }
    }
}
