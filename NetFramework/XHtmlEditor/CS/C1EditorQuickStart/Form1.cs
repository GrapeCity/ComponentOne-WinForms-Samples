using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Editor;

namespace C1EditorQuickStart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // initialize application
            InitializeComponent();
            Text = ProductName;
            Application.Idle += Application_Idle;

            // load a simple document
            this.c1Editor1.LoadXml(Properties.Resources.tesla, null);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            mainToolStrip.UpdateState();
            styleToolStrip.UpdateState();
        }

        // change editor mode
        void _lblDesign_Click(object sender, EventArgs e)
        {
            // set editor mode
            this.c1Editor1.Mode = 
                sender == _lblDesign ? EditorMode.Design :
                sender == _lblSource ? EditorMode.Source :
                EditorMode.Preview;

            // highlight the selected option
            foreach (ToolStripLabel lbl in new ToolStripLabel[] { _lblDesign, _lblSource, _lblPreview })
            {
                lbl.BackColor = object.Equals(sender, lbl)
                    ? Color.Orange
                    : Color.Transparent;
            }
            toolStrip1.Enabled = this.c1Editor1.Mode == EditorMode.Design;
        }

        // utilities
        XmlNodeList SelectNodes(XmlDocument doc, string xpath)
        {
            if (doc.DocumentElement.Attributes["xmlns"] != null)
            {
                // add namespace manager
                string xmlns = doc.DocumentElement.Attributes["xmlns"].Value;
                XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
                nsmgr.AddNamespace("x", xmlns);
                xpath = xpath.Replace("/", "/x:");
                return doc.SelectNodes(xpath, nsmgr);
            }
            else
            {
                return doc.SelectNodes(xpath);
            }
        }
        void ReplaceNodeText(XmlNode node, string search, string replace)
        {
            foreach (XmlNode child in node.ChildNodes)
            {
                ReplaceNodeText(child, search, replace);
            }
            if (node.NodeType == XmlNodeType.Text)
            {
                node.InnerText = node.InnerText.Replace(search, replace);
            }
        }
        int IndexOf(string text, char chr, int count)
        {
            for (int index = 0; index < text.Length; index++)
            {
                if (text[index] == chr)
                {
                    count--;
                    if (count <= 0)
                    {
                        return index;
                    }
                }
            }
            return text.Length;
        }


        //--------------------------------------------------------------------------------
        #region ** how-to's

        // select a paragraph 
        void selectParagraph_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selecting 6th paragaph using Select method.");

            // re-load document
            c1Editor1.LoadXml(Properties.Resources.tesla, null);

            // get text (notice new line handling)
            string txt = this.c1Editor1.Text;
            txt = txt.Replace("\r\n", "\n");

            // find 6th paragraph
            int start = IndexOf(txt, '\n', 6) + 1;
            int len = IndexOf(txt, '\n', 7) - start;

            // select the paragraph
            c1Editor1.Select(start, len);
        }

        // select an XmlNode in the document
        void selectXmlNode_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selecting 6th paragraph using Nodes.");

            // re-load document
            c1Editor1.LoadXml(Properties.Resources.tesla, null);

            // find 6th <p> node in document
            XmlDocument doc = c1Editor1.Document;
            XmlNodeList nodes = SelectNodes(doc, "/html/body/p");
            if (nodes.Count > 5)
            {
                XmlNode node = nodes[5];

                C1TextRange range = c1Editor1.CreateRange();
                range.MoveTo(node);
                range.Select();
            }
        }

        // perform search and replace using Selection properties
        void replaceUsingSelection_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Replacing 'work' with 'labor' using Selection.");

            // re-load document
            this.c1Editor1.LoadXml(Properties.Resources.tesla, null);

            // strings to search and replace
            string search = "work";
            string replace = "labor";

            // do the work
            int count = 0;
            int previousStart = 0;
            C1TextRange range = this.c1Editor1.CreateRange();
            for (int start = 0; ; start += search.Length)
            {
                // get text (notice new line handling)
                string txt = this.c1Editor1.Text;
                txt = txt.Replace("\r\n", "\n");

                // find text, break when done
                start = txt.IndexOf(search, start, StringComparison.OrdinalIgnoreCase);
                if (start < 0)
                {
                    break;
                }

                // select match
                // recommended way (better performance): move range relative to its current position
                range.Move(start - previousStart, search.Length);
                range.Select();

                // not recommended way (slower): using the Select method
                //this.c1Editor1.Select(start, search.Length);

                // tell user we're about to replace
                string msg = string.Format("About to replace instance {0}.", ++count);
                if (MessageBox.Show(msg, "Replace", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    break;
                }

                // second part of the code moving range
                range.Text = replace;
                range.ApplyTag("strong");
                previousStart = start;

                // second part of the code using the Select method
                //this.c1Editor1.Selection.Text = replace;
                //this.c1Editor1.Selection.ApplyTag("strong");
            }

            // done
            MessageBox.Show(string.Format("Done, {0} instances found.", count));
        }

        // perform search and replace using XmlDocument
        void replaceUsingXmlDocument(object sender, EventArgs e)
        {
            MessageBox.Show("Replacing 'work' with 'labor' using Selection.");

            // re-load document
            this.c1Editor1.LoadXml(Properties.Resources.tesla, null);

            XmlDocument doc = this.c1Editor1.Document;
            XmlNodeList nodes = SelectNodes(doc, "/html/body");
            if (nodes.Count > 0)
            {
                ReplaceNodeText(nodes[0], "work", "labor");
            }
        }

        #endregion
    }
}
