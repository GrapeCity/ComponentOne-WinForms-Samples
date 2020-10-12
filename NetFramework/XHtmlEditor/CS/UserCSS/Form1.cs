using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Resources = global::UserCSS.Properties.Resources;

namespace UserCSS
{
    public partial class Form1 : Form
    {
        #region ctor

        public Form1()
        {
            InitializeComponent();
            InitEditor();
        }

        #endregion

        #region implementation

        /// <summary>
        /// Loads content into the editor from the resources
        /// </summary>
        private void InitEditor()
        {
            editor.LoadXml(Resources.sEditorText, null);
        }

        #endregion

        #region event handlers

        /// <summary>
        /// Switches editor to the Design or Preview mode accordingly to the current tab page
        /// </summary>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as TabControl).SelectedIndex == 0)
                editor.Mode = C1.Win.C1Editor.EditorMode.Design;
            else
                editor.Mode = C1.Win.C1Editor.EditorMode.Preview;
        }

        #endregion
    }
}
