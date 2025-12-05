using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Xml;
using System.Text;
using System.Windows.Forms;
using C1.Win.SpellChecker;
using C1.Win.C1Editor;

using HtmlList = C1.Win.C1Editor.List;

namespace C1EditorQuickStart.ToolStrips
{
    class ToolStripStyles : ToolStripBase
    {
        //----------------------------------------------------------------------------
        #region ** fields

        ToolStripComboBox _cmbStyle;
        ToolStripButton _btnBold, _btnItalic, _btnUnderline, _btnClear;
        ToolStripButton _btnBullets, _btnNumbering, _btnIncreaseIndent, _btnDecreaseIndent;
        bool _selectionChanged;

        #endregion

        //----------------------------------------------------------------------------
        #region ** implementation

        // initialize toolstrip
        protected override void OnInitialize()
        {
            // style combo
            _cmbStyle = AddStyleCombo();
            _cmbStyle.LostFocus += _cmbStyle_LostFocus;
            _cmbStyle.KeyDown += _cmbStyle_KeyDown;
            _cmbStyle.SelectedIndexChanged += _cmbStyle_SelectedIndexChanged;

            Items.Add(new ToolStripSeparator());

            // inline formatting buttons
            _btnBold = AddButton("Bold", Properties.Resources.Bold_small, Bold_Click);
            _btnItalic = AddButton("Italic", Properties.Resources.Italic_small, Italic_Click);
            _btnUnderline = AddButton("Underline", Properties.Resources.Underline_small, Underline_Click);
            _btnClear = AddButton("Clear Formatting", Properties.Resources.ClearFormatting_small, ClearFormatting_Click);

            Items.Add(new ToolStripSeparator());

            _btnBullets = AddButton("Bullets", Properties.Resources.Bullets_small, BulletsClick);
            _btnNumbering = AddButton("Numbering", Properties.Resources.Numbering_small, NumberingClick);
            _btnDecreaseIndent = AddButton("Decrease Indent", Properties.Resources.DecreaseIndent_small, DecreaseIndentClick);
            _btnIncreaseIndent = AddButton("Increase Indent", Properties.Resources.IncreaseIndent_small, IncreaseIndentClick);            
        }
        ToolStripComboBox AddStyleCombo()
        {
            ToolStripComboBox cmb = new ToolStripComboBox();
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb.AutoSize = false;
            cmb.Width = 150;

            cmb.Items.Add("(None)");
            cmb.Items.Add("Paragraph <p>");
            for (int i = 1; i < 7; i++)
            {
                cmb.Items.Add(string.Format("Heading {0} <h{0}>", i));
            }
            cmb.Items.Add("Unordered List <ul>");
            cmb.Items.Add("Ordered List <ol>");
            cmb.Items.Add("Preformatted <pre>");

            Items.Add(cmb);
            return cmb;
        }

        // remember selection has changed, update style later 
        protected override void OnSelectionChanged(EventArgs e)
        {
            _selectionChanged = true;
        }

        // update toolbar
        protected override void OnModeChanged(EventArgs e)
        {
            ShowStyles();
        }

        // show currently selected style
        public override void UpdateState()
        {
            if (_selectionChanged)
            {
                _selectionChanged = false;
                ShowStyles();
            }
        }

        void ShowStyles()
        {
            bool isDesignMode = Editor.Mode == C1.Win.C1Editor.EditorMode.Design;
            _btnBold.Enabled = isDesignMode;
            _btnItalic.Enabled = isDesignMode;
            _btnUnderline.Enabled = isDesignMode;
            _btnClear.Enabled = isDesignMode;
            _cmbStyle.Enabled = isDesignMode;
            _btnBullets.Enabled = isDesignMode;
            _btnNumbering.Enabled = isDesignMode;
            _btnDecreaseIndent.Enabled = isDesignMode && (!IsSelectionInsideList() || Editor.Selection.List.CanExecute(HtmlList.Action.DecreaseLevel));
            _btnIncreaseIndent.Enabled = isDesignMode && (!IsSelectionInsideList() || Editor.Selection.List.CanExecute(HtmlList.Action.IncreaseLevel));

            // show inline styles
            Selection s = Editor.Selection;
            if (s != null)
            {
                _btnBold.Checked = SelectionFontBold;
                _btnItalic.Checked = SelectionFontItalic;
                _btnUnderline.Checked = SelectionFontUnderline;
                _btnBullets.Checked = s.List.Type == HtmlList.ListType.Bulleted;
                _btnNumbering.Checked = s.List.Type == HtmlList.ListType.Numbered;
            }

            // find selected style
            XmlNode node = GetSelectedNode();
            if (node == null)
            {
                _cmbStyle.SelectedIndex = 0;
            }
            else
            {
                bool found = false;
                while (node != null && !found)
                {
                    string style = string.Format("<{0}>", node.Name);
                    foreach (string item in _cmbStyle.Items)
                    {
                        if (item.IndexOf(style) > -1)
                        {
                            _cmbStyle.SelectedIndexChanged -= _cmbStyle_SelectedIndexChanged;
                            try
                            {
                            _cmbStyle.Text = item;
                            }
                            finally
                            {
                                _cmbStyle.SelectedIndexChanged += _cmbStyle_SelectedIndexChanged;
                            }
                            found = true;
                            break;
                        }
                    }
                    node = node.ParentNode;
                }
            }
        }

        // validate and apply selected style
        void ValidateAndApplyStyle()
        {
            string style = _cmbStyle.Text;
            int start = style.IndexOf('<');
            int end = style.IndexOf('>');
            if (end > -1 && end > start)
            {
                Editor.Selection.ApplyTag(style.Substring(start + 1, end - start - 1));
            }
        }
        XmlNode GetSelectedNode()
        {
            // return node if start and end nodes are the same
            Selection selRange = Editor.Selection;
            if (selRange != null)
            {
                XmlNode startNode = selRange.Start.Node;
                XmlNode endNode = selRange.End.Node;
                return object.Equals(startNode, endNode)
                    ? startNode
                    : null;
            }
            return null;
        }

        private void IncreaseIndent()
        {
            Editor.BeginTransaction("Apply style");
            try
            {
                List<XmlNode> paragraphs = Editor.Selection.GetTags(C1StyleType.Paragraph, true);
                XmlDocument doc = Editor.Document;
                foreach (XmlNode node in paragraphs)
                {
                    XmlNode newNode = doc.CreateElement("blockquote", doc.DocumentElement.NamespaceURI);
                    node.ParentNode.InsertAfter(newNode, node);
                    newNode.AppendChild(node);
                }
                Editor.CommitTransaction();
            }
            catch
            {
                Editor.RollbackTransaction();
            }
        }

        private void DecreaseIndent()
        {
            Editor.BeginTransaction("Remove style");
            try
            {
                List<XmlNode> nodes = Editor.Selection.GetTags(C1StyleType.Paragraph, true);

                XmlDocument doc = Editor.Document;
                for (int i = 0; i < nodes.Count; i++)
                {
                    XmlNode node = nodes[i];
                    while (node != null && !string.Equals(node.Name, "blockquote"))
                        node = node.ParentNode;

                    if (node != null && string.Equals(node.Name, "blockquote"))
                    {
                        while (node.HasChildNodes)
                            node.ParentNode.InsertBefore(node.FirstChild, node);
                        node.ParentNode.RemoveChild(node);
                    }
                }
                Editor.CommitTransaction();
            }
            catch
            {
                Editor.RollbackTransaction();
            }
        }

        private bool IsSelectionInsideList()
        {
            bool res = false;
            XmlNode start = Editor.Selection.Start.Node;
            XmlNode end = Editor.Selection.End.Node;

            while (start != null && !string.Equals(start.Name, "li"))
                start = start.ParentNode;
            while (end != null && !string.Equals(end.Name, "li"))
                end = end.ParentNode;

            if (start != null && end != null)
            {
                if (start == end)
                    res = true;
                else
                {
                    XmlNode parent = GetCommonParent(start, end);
                    if (start == parent || end == parent)
                        parent = parent.ParentNode;
                    res = parent != null && (string.Equals(parent.Name, "ol") || string.Equals(parent.Name, "ul"));
                }
            }

            return res;
        }

        private XmlNode GetCommonParent(XmlNode node1, XmlNode node2)
        {
            if (node1 == null)
                return node2;
            if (node2 == null)
                return node1;
            XmlNode commonNode = null;
            if (node1 != node2)
            {
                XmlNode documentElement = node1.OwnerDocument.DocumentElement;
                XmlNode node = null;
                List<XmlNode> node1Parents = new List<XmlNode>();
                node = node1;
                while (node != null && node != documentElement)
                {
                    node1Parents.Insert(0, node);
                    node = node.ParentNode;
                }

                List<XmlNode> node2Parents = new List<XmlNode>();
                node = node2;
                while (node != null && node != documentElement)
                {
                    node2Parents.Insert(0, node);
                    node = node.ParentNode;
                }

                int length = Math.Min(node1Parents.Count, node2Parents.Count);
                for (int i = 0; i < length; i++)
                {
                    if (node1Parents[i] != node2Parents[i])
                        break;
                    else
                        commonNode = node1Parents[i];
                }
            }
            else
            {
                commonNode = node1;
            }

            return commonNode;
        }

        #endregion

        //----------------------------------------------------------------------------
        #region ** event handlers

        void _cmbStyle_LostFocus(object sender, EventArgs e)
        {
            //ValidateAndApplyStyle();
        }
        void _cmbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateAndApplyStyle();
        }
        void _cmbStyle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateAndApplyStyle();
            }
        }
        void Bold_Click(object sender, EventArgs e)
        {
            _btnBold.Checked = SelectionFontBold = !SelectionFontBold;
        }
        void Italic_Click(object sender, EventArgs e)
        {
            _btnItalic.Checked = SelectionFontItalic = !SelectionFontItalic;
        }
        void Underline_Click(object sender, EventArgs e)
        {
            _btnUnderline.Checked = SelectionFontUnderline = !SelectionFontUnderline;
        }
        void ClearFormatting_Click(object sender, EventArgs e)
        {
            Selection s = Editor.Selection;
            s.ClearFormatting();
        }
        void BulletsClick(object sender, EventArgs e)
        {
            List list = Editor.Selection.List;
            bool applied = _btnBullets.Checked;
            list.Type = applied ? HtmlList.ListType.None : HtmlList.ListType.Bulleted;
            _selectionChanged = true;
            UpdateState();
        }
        void NumberingClick(object sender, EventArgs e)
        {
            List list = Editor.Selection.List;
            bool applied = _btnNumbering.Checked;
            list.Type = applied ? HtmlList.ListType.None : HtmlList.ListType.Numbered;
            _selectionChanged = true;
            UpdateState();
        }
        void IncreaseIndentClick(object sender, EventArgs e)
        {
            if (IsSelectionInsideList())
                Editor.Selection.List.Execute(HtmlList.Action.IncreaseLevel);
            else
                IncreaseIndent();
        }
        void DecreaseIndentClick(object sender, EventArgs e)
        {
            if (IsSelectionInsideList())
                Editor.Selection.List.Execute(HtmlList.Action.DecreaseLevel);
            else
                DecreaseIndent();
        }

        #endregion

        #region ** formatting properties

        private bool SelectionFontBold
        {
            get { return Editor.Mode == EditorMode.Design ? Editor.Selection.IsTagApplied("strong") : false; }
            set
            {
                if (value)
                    Editor.Selection.ApplyTag("strong");
                else
                    Editor.Selection.RemoveTag("strong");
            }
        }

        bool SelectionFontItalic
        {
            get { return Editor.Mode == EditorMode.Design ? Editor.Selection.IsTagApplied("em") : false; }
            set
            {
                if (value)
                    Editor.Selection.ApplyTag("em");
                else
                    Editor.Selection.RemoveTag("em");
            }
        }

        bool SelectionFontUnderline
        {
            get
            {
                if (Editor.Mode == EditorMode.Design)
                {
                    bool res = false;
                    if (Editor.Selection.IsStyleApplied("text-decoration"))
                        res = string.Compare(Editor.Selection.GetStyleValue("text-decoration", C1StyleType.Character), "underline", true) == 0;
                    return res;
                }
                else
                    return false;
            }
            set
            {
                if (value)
                    Editor.Selection.ApplyStyle("text-decoration", "underline", C1StyleType.Character);
                else
                    Editor.Selection.RemoveStyle("text-decoration", null);
            }
        }

        #endregion
    }
}
