using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThemeManager
{
    public partial class Form2 : Form
    {
        // save default font size for scaling
        float _defaultFontSize = 8.25f;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnCloneForm_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();
            f2.SetDesktopLocation(this.DesktopBounds.Left + 20, this.DesktopBounds.Top + 20);
            f2.Show();
        }

        /// <summary>
        /// Event fired when a theme on an object managed by a theme controller has changed.
        /// We use this event to ensure that even if the theme specifies a font for C1Label,
        /// the size of the font on our label stays 12.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void c1ThemeController1_ObjectThemeApplied(C1.Win.C1Themes.C1ThemeController sender, C1.Win.C1Themes.ObjectThemeEventArgs e)
        {           
            ScaleForm();

            if (e.Object == this.c1Label1)
                this.c1Label1.Font = new Font(this.c1Label1.Font.FontFamily, 12);
        }

        /// <summary>
        /// Scales the form and all child controls.        
        /// </summary>
        /// <remarks>
        /// We couldn't use Form.AutoScaleMode = Font, since we may create this form in run-time and
        /// the theme is set in the InitializeComponent method and may contain a different font size.
        /// In this case auto scaling may not work correctly in run-time. So we should scale manually.
        /// </remarks>
        private void ScaleForm()
        {
            float fontSize = Font.Size;
            if (fontSize != _defaultFontSize)
            {
                float factor = fontSize / _defaultFontSize;
                Scale(new SizeF(factor, factor));
                _defaultFontSize = fontSize;
            }
        }
    }
}
