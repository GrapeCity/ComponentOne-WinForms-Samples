using RichTextEditor.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RichTextEditor.AppMenuTabs
{
    public partial class PrintTab : UserControl
    {
        #region Ctor
        public PrintTab()
        {
            InitializeComponent();

            lblCaption.Text = GetElementText(Resources.PrintTab_txt);
            SetButtonSettings(btnPrint, "Print");
            SetButtonSettings(btnQPrint, "QuickPrint");

            c1PrintPreviewControl1.TopToolStripPanelVisible = false;            
        }
        #endregion

        #region Properties
        public C1TextEditorRibbon Ribbon
        {
            get;
            set;
        }
        #endregion

        #region Event handlers
        private void btnQPrint_Click(object sender, EventArgs e)
        {
            if (Ribbon != null)
                Ribbon.PrintDocument(false, false);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (Ribbon != null)
                Ribbon.PrintDocument(true, false);
        }

        #endregion

        #region Methods
        private void SetButtonSettings(Button btn, string prefix)
        {
            btn.Image = (Image)Resources.ResourceManager.GetObject(prefix + "_large", Resources.Culture);

            btn.TextImageRelation = TextImageRelation.ImageAboveText;
            btn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // text resources
            string res = (string)Resources.ResourceManager.GetObject(prefix + "_txt", Resources.Culture);
            string[] textParts = res != null
                ? res.Split('\n')
                : new string[] { prefix };

            // Text
            string text = textParts[0].Trim();
            if (!string.IsNullOrEmpty(text))
            {
                btn.Text = text;
            }
            // ToolTip: text and body
            if (textParts.Length > 1)
            {
                if (!textParts[1].StartsWith("*"))
                {
                    var toolTip = new C1.Win.C1SuperTooltip.C1SuperTooltip();
                    string tipTitle = textParts[1].Trim();
                    string tipBody = string.Join("<br/>", textParts, 2, textParts.Length - 2).Trim();
                    toolTip.SetToolTip(btn, string.IsNullOrEmpty(tipBody)
                        ? tipTitle
                        : string.Format(
                            "<b>{0}</b><br/>" +
                            "<div style='margin-left:12'>{1}</div>",
                            tipTitle, tipBody));
                }
            }
        }
        
        private string GetElementText(string text)
        {
            string[] textParts = text != null
                ? text.Split('\n')
                : new string[] { string.Empty };

            return textParts[0].Trim();
        }

        internal void SetDocument()
        {
            c1PrintPreviewControl1.Document = Ribbon.Editor.PrintDocument;
        }

        #endregion
    }
}
