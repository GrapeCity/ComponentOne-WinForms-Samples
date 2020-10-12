using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Editor;

using Resources = global::UserCSS.Properties.Resources;

namespace UserCSS.Controls
{
    /// <summary>
    /// Allows a user either to select an existing CSS file or enter CSS style rules into the textbox
    /// </summary>
    public partial class CSSChooser : UserControl
    {
        #region public enums

        /// <summary>
        /// Editor mode that CSS will be applied to: design or preview
        /// </summary>
        public enum Mode
        {
            Design,
            Preview
        }

        #endregion

        #region declarations

        private Mode _mode;
        private C1Editor _editor;
        private string _css;

        #endregion

        #region ctors

        public CSSChooser()
        {
            InitializeComponent();
            InitCSS();
        }

        #endregion

        #region object model

        /// <summary>
        /// Gets or sets editor mode that CSS will be applied to
        /// </summary>
        [Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Mode CSSMode
        {
            get 
            { 
                return _mode; 
            }
            set 
            { 
                _mode = value; 
                InitCSS(); 
            }
        }

        /// <summary>
        /// Gets or sets active editor
        /// </summary>
        [Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public C1Editor Editor
        {
            get 
            { 
                return _editor; 
            }
            set 
            { 
                _editor = value; 
            }
        }

        #endregion

        #region implementation

        /// <summary>
        /// Initializes controls for work with CSS
        /// </summary>
        private void InitCSS()
        {
            tbCustomDesignCSS.Text = (_mode == Mode.Design ? Resources.sDesignCSS : Resources.sPreviewCSS);
            _css = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + (_mode == Mode.Design ? "\\CSS1.css" : "\\CSS2.css");
            lblFileName.Text = _css;
        }

        /// <summary>
        /// Loads Design or Preview CSS from the file
        /// </summary>
        /// <param name="value"></param>
        private void LoadCSS(string value)
        {
            switch (_mode)
            {
                case Mode.Design:
                    _editor.LoadDesignCSS(value);
                    break;
                case Mode.Preview:
                    _editor.LoadPreviewCSS(value);
                    break;
            }
        }

        /// <summary>
        /// Loads Design or Preview CSS from the string
        /// </summary>
        /// <param name="value"></param>
        private void LoadCSSValue(string value)
        {
            //Only UTF-8 string can be used for the Stream
            Stream stream = new MemoryStream(Encoding.UTF8.GetBytes(value));
            switch (_mode)
            {
                case Mode.Design:
                    _editor.LoadDesignCSS(stream);
                    break;
                case Mode.Preview:
                    _editor.LoadPreviewCSS(stream);
                    break;
            }
        }

        #endregion

        #region event handlers

        /// <summary>
        /// Removes using CSS from the editor
        /// </summary>
        private void rbNoDesignCSS_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                LoadCSS(null);
        }

        /// <summary>
        /// Loads a CSS from the previously saved file name
        /// </summary>
        private void rbFileDesignCSS_CheckedChanged(object sender, EventArgs e)
        {
            btnBrowse.Enabled = (sender as RadioButton).Checked;
            if ((sender as RadioButton).Checked)
                LoadCSS(_css);
        }

        /// <summary>
        /// Displays the Open File dialog to select a CSS file. 
        /// Selected CSS is loaded into the editor as Design/Preview CSS.
        /// </summary>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "CSS Files (*.css)|*.css";
                dialog.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _css = dialog.FileName;
                    lblFileName.Text = _css;
                    LoadCSS(_css);
                }
            }
        }

        /// <summary>
        /// Loads text from the Textbox into the editor as Design/Preview CSS
        /// </summary>
        private void rbCustomDesignCSS_CheckedChanged(object sender, EventArgs e)
        {
            tbCustomDesignCSS.Enabled = (sender as RadioButton).Checked;
            btnApplyCSS.Enabled = (sender as RadioButton).Checked;
            if ((sender as RadioButton).Checked)
                LoadCSSValue(tbCustomDesignCSS.Text);
        }

        /// <summary>
        /// Loads text from the Textbox into the editor as Design/Preview CSS
        /// </summary>
        private void btnApplyCSS_Click(object sender, EventArgs e)
        {
            LoadCSSValue(tbCustomDesignCSS.Text);
        }

        #endregion
    }
}
