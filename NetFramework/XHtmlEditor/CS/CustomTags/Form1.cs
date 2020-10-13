using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Xml;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomTags
{
    public partial class Form1 : Form
    {
        #region ctor

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region event handlers

        /// <summary>
        /// Switches mode between design, source and preview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMode_Click(object sender, EventArgs e)
        {
            string strMode = ((Button)sender).Text;
            lblMode.Text = strMode;
            if (strMode.Equals("Design"))
                editor.Mode = C1.Win.C1Editor.EditorMode.Design;
            else if (strMode.Equals("Source"))
                editor.Mode = C1.Win.C1Editor.EditorMode.Source;
            else
                editor.Mode = C1.Win.C1Editor.EditorMode.Preview;
        }

        /// <summary>
        /// Loads document, custom tag specification, design and preview CSS
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            //Load xml extension from file
            editor.XmlExtensions = System.IO.File.ReadAllText("CustomTags.xml");
            //Load xml document from file
            editor.LoadXml("doc.xml");
            //Load design css from file
            editor.LoadDesignCSS("design.css");
            //Load preview css from file
            editor.LoadPreviewCSS("preview.css");
        }

        /// <summary>
        /// Shows document statistics, accordingly with its structure
        /// </summary>
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            editor.Selection.ApplyClass("className", C1.Win.C1Editor.C1StyleType.Paragraph);

            XmlDocument document = editor.Document;
            StringBuilder statistics = new StringBuilder();
            //Add statistic info from document to string builder
            AddStatistics(document as XmlNode, statistics);
            //Show statistics in message box
            MessageBox.Show(statistics.ToString());
        }

        /// <summary>
        /// Collects document statistics from custom tags
        /// </summary>
        /// <param name="node">Current node</param>
        /// <param name="statistics">collected statistics in StringBuilder</param>
        private void AddStatistics(XmlNode node, StringBuilder statistics)
        {
            XmlElement element = node as XmlElement;
            if (element != null)
            {
                if (element.Name == "topic")
                {
                    if (statistics.Length > 0)
                        statistics.Append("\n");
                    statistics.Append("Topic: " + (element.HasAttribute("name") ? element.GetAttribute("name") : "(unknown)") + "\n");
                    if (element.HasAttribute("author"))
                        statistics.Append("    Author: " + element.GetAttribute("author") + "\n");
                    if (element.HasAttribute("date"))
                        statistics.Append("    Date: " + element.GetAttribute("date") + "\n");
                    if (element.HasAttribute("category"))
                        statistics.Append("    Category: " + element.GetAttribute("category") + "\n");
                }
                else if (element.Name == "comment")
                    statistics.Append("    Comment: " + element.InnerText + "\n");
                else if (element.Name == "header")
                    statistics.Append("    Header: " + element.InnerText + "\n");
                else if (element.Name == "pointer")
                    statistics.Append("    Link to: " + (element.HasAttribute("to") ? element.GetAttribute("to") : "(unknown)") + "\n");
            }
            foreach (XmlNode childNode in node)
                AddStatistics(childNode, statistics);
        }

        #endregion
    }
}
