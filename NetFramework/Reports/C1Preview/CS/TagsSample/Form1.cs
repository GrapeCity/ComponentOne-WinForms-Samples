using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using C1.C1Preview;
using C1.Win.C1Preview;

namespace TagsSample
{
    public partial class Form1 : Form
    {
        private const string RootDir = @"c:\";
        private const int MaxLevel = 4;
        private int _totalDirs = 0;
        private int _totalFiles = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add tags to the document. The first two are constants,
            // while the [TotalDirs] will be updated after the body of the document
            // has been added.
            c1PrintDocument1.Tags.Add(new Tag("RootDir", RootDir));
            c1PrintDocument1.Tags.Add(new Tag("MaxLevel", MaxLevel));
            c1PrintDocument1.Tags.Add(new Tag("TotalDirs", _totalDirs));

            // Create the header and add it to the document.
            // The text of the header includes references to tags some of which
            // ([RootDir], [MaxLevel] and [TotalDirs]) have been already added to the document's Tags collection,
            // while others ([TotalFiles]) will be added later.
            RenderText header = new RenderText();
            header.Text = "There are [TotalDirs] directories in [RootDir], and [TotalFiles] files (recursing [MaxLevel] levels down).";
            header.Style.Spacing.Bottom = "1cm";
            header.Style.FontSize = header.Style.FontSize + 2;
            header.Style.FontBold = true;
            c1PrintDocument1.Body.Children.Add(header);

            // Create the body of the document.
            ListDirectories(RootDir, 0);

            // Update the tag that has been added but the value was a placeholder.
            c1PrintDocument1.Tags["TotalDirs"].Value = _totalDirs;
            
            // The tag for total number of files is added here to demonstrate that
            // a tag can be referenced before it has even been added - just make sure it
            // is there when the document is generated.
            c1PrintDocument1.Tags.Add(new Tag("TotalFiles", _totalFiles));

            // Finally, generate the document.
            c1PrintDocument1.Generate();
        }

        private void ListDirectories(string root, int level)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(root);
                // update totals:
                _totalDirs += dirs.Length;
                _totalFiles += Directory.GetFiles(root).Length;
                // list directories:
                foreach (string s in dirs)
                {
                    RenderText dir = new RenderText(s);
                    dir.Style.Spacing.Left = new Unit(level * 4, UnitTypeEnum.Mm);
                    c1PrintDocument1.Body.Children.Add(dir);
                    if (level < MaxLevel)
                        ListDirectories(s, level + 1);
                }
            }
            catch (Exception ex)
            {
                RenderText err = new RenderText(string.Format("Could not list {0}: {1}.", root, ex.Message));
                err.Style.TextColor = Color.Red;
                c1PrintDocument1.Body.Children.Add(err);
            }
        }
    }
}