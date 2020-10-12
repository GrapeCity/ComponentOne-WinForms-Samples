using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using C1.Win.C1Html;
using C1.C1Preview;

namespace C1HTMLSample
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //XmlDocument doc = Loader.Load("tesla.htm");
            //XmlNamespaceManager nsManager = new XmlNamespaceManager(doc.NameTable);
            //nsManager.AddNamespace("xhtml", "http://www.w3.org/1999/xhtml");
            //XmlNodeList paragraphs = doc.SelectNodes(@"//xhtml:p", nsManager);
            //Console.WriteLine("Paragraphs count: {0}", paragraphs.Count);
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }
}
