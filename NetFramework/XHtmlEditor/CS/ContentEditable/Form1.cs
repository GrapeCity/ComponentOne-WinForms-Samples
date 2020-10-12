using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ContentEditable
{
    public partial class Form1 : Form
    {
        private List<string> _fieldIDs = null;

        public Form1()
        {
            InitializeComponent();

            _fieldIDs = new List<string>(new string[] { "f01", "f02", "f03", "f04", "f05", "f06", "f07", "f08" });
            
            c1Editor1.KeyDown += new KeyEventHandler(c1Editor1_KeyDown);
            c1Editor1.KeyUp += new KeyEventHandler(c1Editor1_KeyUp);

            c1Editor1.XmlExtensions = "<customization><attributes><attribute name=\"contenteditable\" /></attributes></customization>";
        }

        protected override void OnLoad(EventArgs e)
        {
            c1Editor1.LoadXml(Properties.Resources.Document, null);

            //select first input field
            XmlNode node = c1Editor1.Document.GetElementById(_fieldIDs[0]);
            if (node != null)
                c1Editor1.CreateRange(node).Select();

            base.OnLoad(e);
        }

        private void c1Editor1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
                e.Handled = true;
        }

        private void c1Editor1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                //searching current focused field
                XmlNode node = c1Editor1.Selection.Start.Node;
                XmlNode currentField = null;
                while (node != null)
                {
                    XmlAttribute id = node.Attributes != null ? node.Attributes["id"] : null;
                    if (id != null && _fieldIDs.Contains(id.Value))
                    {
                        currentField = node;
                        break;
                    }
                    node = node.ParentNode;
                }

                //move focus to the next input field
                if (currentField != null)
                {
                    string currentId = currentField.Attributes["id"].Value;
                    int idIndex = _fieldIDs.IndexOf(currentId);
                    int nextIdIndex;
                    if (e.Shift)
                        nextIdIndex = idIndex > 0 ? idIndex - 1 : _fieldIDs.Count - 1;
                    else
                        nextIdIndex = idIndex < _fieldIDs.Count - 1 ? idIndex + 1 : 0;
                    XmlNode nextField = c1Editor1.Document.SelectSingleNode(string.Format("//*[@id='{0}']", _fieldIDs[nextIdIndex]));
                    if (nextField != null)
                    {
                        C1.Win.C1Editor.C1TextRange range = c1Editor1.CreateRange(nextField);
                        range.Normalize();
                        range.Select();
                    }
                }

                //cancel internal handling of the 'Tab' pressing 
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c1Editor1.Mode = C1.Win.C1Editor.EditorMode.Design;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c1Editor1.Mode = C1.Win.C1Editor.EditorMode.Source;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //show publication data
            StringBuilder sb = new StringBuilder();
            sb.Append("Publication data:\n\n");
            foreach (string id in _fieldIDs)
            {
                //find node with data
                XmlNode node = c1Editor1.Document.GetElementById(id);
                if (node != null)
                {
                    //also find description for this node, it is the previous text node
                    XmlNode previousNode = node.PreviousSibling;
                    while (previousNode != null && previousNode.NodeType != XmlNodeType.Text)
                        previousNode = previousNode.PreviousSibling;
                    sb.Append((previousNode != null ? previousNode.Value : "") + node.InnerText + "\n");
                }
            }
            MessageBox.Show(sb.ToString());
        }
    }
}