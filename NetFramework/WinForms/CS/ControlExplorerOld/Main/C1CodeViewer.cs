using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.C1Preview;

namespace ControlExplorer.Main
{
    public partial class C1CodeViewer : UserControl
    {
        string[] reservedWords = new string[] { "if", "public", "int", "double", "string", "bool", "using", "class", "object", "public", "private", "partial", "void", "namespace", "for", "foreach" };
        
        public C1CodeViewer()
        {
            InitializeComponent();
            c1PreviewPane1.IntegrateExternalTools = true;
        }

        public string Code
        {
            set
            {
                RenderCode(value);
            }
        }

        private void RenderCode(string code)
        {
            // reinitialize
            c1PrintDocument1.Clear();
            c1PrintDocument1.Style.Font = new Font("Calibri", 10);
            c1PrintDocument1.PageLayout.PageSettings.TopMargin = new Unit(.2, UnitTypeEnum.Inch);
            c1PrintDocument1.PageLayout.PageSettings.RightMargin = new Unit(.2, UnitTypeEnum.Inch);
            c1PrintDocument1.PageLayout.PageSettings.BottomMargin = new Unit(.2, UnitTypeEnum.Inch);
            c1PrintDocument1.PageLayout.PageSettings.LeftMargin = new Unit(.2, UnitTypeEnum.Inch);

            string[] lines = code.Split('\n');

            RenderParagraph par = new RenderParagraph();
            foreach (string line in lines)
            {
                //check for comments
                if (line.Contains("//") && !line.Contains("http"))
                {
                    string[] words = line.Split(new string[] { "//" }, 2, StringSplitOptions.None);
                    //string comment = line.Substring(line.LastIndexOf("//"));
                    if (words.Length >= 2)
                    {
                        RenderLine(par, words[0]);
                        words[1] = "//" + words[1];
                        par.Content.AddText(words[1], Color.Green);
                    }
                    else if (words.Length == 1)
                    {
                        words[0] = "//" + words[0];
                        par.Content.AddText(words[0], Color.Green);
                    }
                }
                //check for strings
                else if (line.Contains("\""))
                {
                    string[] words = line.Split('"');
                    if (words.Length >= 2)
                    {
                        for (int i = 0; i < words.Length; i += 2)
                        {
                            RenderLine(par, words[i]);
                            if ((i + 1) <= words.Length - 1)
                            {
                                words[i + 1] = "\"" + words[i + 1] + "\"";
                                par.Content.AddText(words[i + 1], Color.Maroon);
                            }
                        }
                    }

                }
                //check for reserved words
                else if (ContainsRWord(line))
                {
                    RenderLineWithRWords(par, line);
                }
                else
                {
                    par.Content.AddText(line);
                }
                //if (line == lines[31])
                   // break;
            }
            c1PrintDocument1.Body.Children.Add(par);
            c1PrintDocument1.Generate();
            c1PrintDocument1.Save(@"Test.c1d");
        }

        private void RenderLine(RenderParagraph par, string line)
        {
            if (ContainsRWord(line))
            {
                RenderLineWithRWords(par, line);
            }
            else
            {
                par.Content.AddText(line);
            }
        }
        private void RenderLineWithRWords(RenderParagraph par, string line)
        {
            string[] words = line.Split(' ');
            foreach (string word in words)
            {
                if (reservedWords.Contains(word))
                {
                    par.Content.AddText(word, Color.Blue);
                }
                else
                {
                    par.Content.AddText(word);
                }
                par.Content.AddText(" ");
            }
            if (par.Content.Count > 0)
            {
                //remove trailing space
                par.Content.RemoveAt(par.Content.Count - 1);
            }
        }

        private bool ContainsRWord(string line)
        {
            foreach (string rword in reservedWords)
            {
                if (line.Contains(rword))
                {
                    return true;
                }
            }
            return false;
        }

        private void c1PreviewTextSearchPanel1_DesiredVisibleChanged(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
        }
    }
}
