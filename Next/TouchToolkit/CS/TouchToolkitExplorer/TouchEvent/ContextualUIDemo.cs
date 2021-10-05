using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TouchToolkitExplorer.TouchEvent
{
    public partial class ContextualUIDemo : DemoBase
    {
        #region Field
        bool _disposeFont;
        ToolStripDropDown colorDropDown = new ToolStripDropDown();
        ColorUserControl colorPicker = new ColorUserControl();
        ToolStripDropDown fontFamilyDropDown = new ToolStripDropDown();
        ToolStripDropDown fontSizeDropDown = new ToolStripDropDown();
        ListBox fontFamilyListobx = new ListBox();
        ListBox fontSizeListbox = new ListBox();
        Font bigFont;
        Font normalFont;
        int fontSize = 9;
        string[] fontSizeList = new string[] { "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72" };
        bool _isTouch = false;
        #endregion

        #region Init

        public ContextualUIDemo()
        {
            InitializeComponent();
            InitializeControls();
        }
        
        private void InitializeControls()
        {
            this.Title = "Contextual UI";
            this.Description = @"Provide a normal contextual UI for Mouse click. For tap, user can show a larger UI by Touch event of C1TouchEventProvider. 
  - Try to change preview string's font.";
            
            bigFont = new System.Drawing.Font(this.Font.FontFamily, 18);
            normalFont = new System.Drawing.Font(this.Font.FontFamily, 9);

            fontSizeListbox.Font = normalFont;
            fontSizeListbox.MaximumSize = new System.Drawing.Size(fontSizeButtonForTouch.Width, 200);
            fontSizeListbox.MinimumSize = new System.Drawing.Size(fontSizeButtonForTouch.Width, 200);
            fontSizeListbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            fontSizeListbox.SelectedIndexChanged += fontSizeListbox_SelectedIndexChanged;
            for (int i = 0; i < fontSizeList.Length; i++)
            {
                fontSizeListbox.Items.Add(fontSizeList[i]);
            }
            fontSizeListbox.SelectedIndex = 1;
            fontSizeDropDown.Items.Add(new ToolStripControlHost(fontSizeListbox));

            System.Drawing.Text.InstalledFontCollection fonts =
                      new System.Drawing.Text.InstalledFontCollection();
            fontFamilyListobx.Font = normalFont;
            fontFamilyListobx.MaximumSize = new System.Drawing.Size(500, 200);
            fontFamilyListobx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            fontFamilyListobx.SelectedIndexChanged += listobx_SelectedIndexChanged;
            fontFamilyTextBoxForTouch.Validated += fontFamilyTextBox_Validated;
            fontFamilyTextBoxNormal.Validated += fontFamilyTextBox_Validated;
            foreach (System.Drawing.FontFamily family in fonts.Families)
            {
                fontFamilyListobx.Items.Add(family.Name);
            }
            fontFamilyListobx.SelectedItem = preViewLabel.Font.FontFamily.Name.ToString();
            fontFamilyButtonForTouch.Tag = fontFamilyTextBoxForTouch;
            fontFamilyButtonNormal.Tag = fontFamilyTextBoxNormal;
            fontFamilyDropDown.Items.Add(new ToolStripControlHost(fontFamilyListobx));

            colorPicker.ValueChanged += colorPicker_ValueChanged;
            colorDropDown.Items.Add(new ToolStripControlHost(colorPicker));

            colorDropDown.Closing += contextMenuStrip1_Closing;
            fontFamilyDropDown.Closing += contextMenuStrip1_Closing;
            fontSizeDropDown.Closing += contextMenuStrip1_Closing;

            colorButtonForTouch.Click += colorButton_Click;
            fontSizeButtonForTouch.Click += fontSizeButton_Click;
            fontFamilyButtonForTouch.Click += fontFamilyButton_Click;
            fontFamilyButtonForTouch.Paint += DropDownButton_Paint;
            fontSizeButtonForTouch.Paint += DropDownButton_Paint;

            colorButtonNormal .Click += colorButton_Click;
            fontSizeButtonNormal.Click += fontSizeButton_Click;
            fontFamilyButtonNormal.Click += fontFamilyButton_Click;
            fontFamilyButtonNormal.Paint += DropDownButton_Paint;
            fontSizeButtonNormal.Paint += DropDownButton_Paint;
        }

        #endregion

        #region forecolor

        void colorPicker_ValueChanged(object sender, EventArgs e)
        {
            preViewLabel.ForeColor = colorPicker.Color;
            colorButtonForTouch.BackColor = colorPicker.Color;
            colorButtonNormal.BackColor = colorPicker.Color;
            colorDropDown.Close();
        }

        void colorButton_Click(object sender, EventArgs e)
        {
            colorPicker.IsNormalSize = !_isTouch;
            _isTouch = false;

            if (colorDropDown.Visible)
            {
                colorDropDown.Close();
            }
            else
            {
                colorDropDown.Size = colorPicker.Size;
                Control control = sender as Control;
                colorDropDown.Tag = control;
                colorDropDown.Show(control, new Point(0, control.Height));
            }
        }

        #endregion

        #region fontsize

        void fontSizeButton_Click(object sender, EventArgs e)
        {
            if (_isTouch)
            {
                fontSizeListbox.Font = bigFont;
            }
            else
            {
                fontSizeListbox.Font = normalFont;
            }
            _isTouch = false;


            if (fontSizeDropDown.Visible)
            {
                fontSizeDropDown.Close();
            }
            else
            {
                var control = sender as Control;
                fontSizeDropDown.Tag = control;
                int selectedIndex = fontSizeListbox.SelectedIndex;
                fontSizeListbox.SelectedIndex = -1;
                fontSizeListbox.SelectedIndex = selectedIndex;
                fontSizeDropDown.Show(control, new Point(0, control.Height));
            }
        }

        void fontSizeListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fontSizeListbox.SelectedItem != null)
            {
                fontSizeDropDown.Close();
                fontSize = Convert.ToInt32(fontSizeListbox.SelectedItem);
                fontSizeButtonNormal.Text = fontSize.ToString();
                fontSizeButtonForTouch.Text = fontSize.ToString();
                FreshPreviewFont();
            }
        }

        #endregion

        #region fontfamily

        void fontFamilyButton_Click(object sender, EventArgs e)
        {
            if (_isTouch)
            {
                fontFamilyListobx.Font = bigFont;
            }
            else
            {
                fontFamilyListobx.Font = normalFont;
            }
            _isTouch = false;

            if (fontFamilyDropDown.Visible)
            {
                fontFamilyDropDown.Close();
            }
            else
            {
                Control textControl = (sender as Control).Tag as Control;
                Control control = sender as Control;
                fontFamilyDropDown.Tag = control;
                fontFamilyDropDown.Show(textControl, new Point(0, textControl.Height));
            }
        }

        void listobx_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontFamilyDropDown.Close();
            fontFamilyTextBoxForTouch.Text = fontFamilyListobx.SelectedItem.ToString();
            fontFamilyTextBoxNormal.Text = fontFamilyTextBoxForTouch.Text;
            FreshPreviewFont();
        }

        void fontFamilyTextBox_Validated(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                fontFamilyListobx.SelectedItem = textBox.Text;
                fontFamilyTextBoxForTouch.Text = fontFamilyListobx.SelectedItem.ToString();
                fontFamilyTextBoxNormal.Text = fontFamilyTextBoxForTouch.Text;
                FreshPreviewFont();
            }
        }

        #endregion

        #region Other

        void DropDownButton_Paint(object sender, PaintEventArgs e)
        {
            int start = (sender as Button).ClientSize.Width - 25;
            e.Graphics.DrawLine(SystemPens.ControlText, new Point(start + 9, 11), new Point(start + 9, 13));
            e.Graphics.DrawLine(SystemPens.ControlText, new Point(start+10, 12), new Point(start+10, 14));
            e.Graphics.DrawLine(SystemPens.ControlText, new Point(start+11, 13), new Point(start+11, 15));
            e.Graphics.DrawLine(SystemPens.ControlText, new Point(start+12, 14), new Point(start+12, 16));
            e.Graphics.DrawLine(SystemPens.ControlText, new Point(start+13, 13), new Point(start+13, 15));
            e.Graphics.DrawLine(SystemPens.ControlText, new Point(start+14, 12), new Point(start+14, 14));
            e.Graphics.DrawLine(SystemPens.ControlText, new Point(start+15, 11), new Point(start+15, 13));
        }

        void contextMenuStrip1_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            if (e.CloseReason == ToolStripDropDownCloseReason.AppClicked)
            {
                Control owner = (sender as ToolStripDropDown).Tag as Control;
                if (owner != null)
                {
                    Point point = owner.PointToClient(Control.MousePosition);
                    if (owner.ClientRectangle.Contains(owner.PointToClient(Control.MousePosition)))
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void FreshPreviewFont()
        {
            if (fontFamilyListobx.SelectedItem != null)
            {
                if (preViewLabel.Font != null && _disposeFont)
                {
                    _disposeFont = false;
                    preViewLabel.Font.Dispose();
                    preViewLabel.Font = null;
                }
                preViewLabel.Font = new Font(fontFamilyListobx.SelectedItem.ToString(), fontSize);
                _disposeFont = true;
            }
        }

        private void C1TouchEventProvider1_Tapped(object sender, C1.Win.TouchToolKit.TappedEventArgs e)
        {
            if (e.PointerDeviceType == C1.Win.TouchToolKit.PointerDeviceType.Touch)
            {
                if (e.TargetControl == colorButtonForTouch || e.TargetControl == fontSizeButtonForTouch || e.TargetControl == fontFamilyButtonForTouch)
                {
                    _isTouch = true;
                }
            }
        }

        #endregion
    }
}
