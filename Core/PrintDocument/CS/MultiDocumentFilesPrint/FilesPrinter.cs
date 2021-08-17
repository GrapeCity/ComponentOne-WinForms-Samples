using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using C1.C1Preview;

namespace MultiDocumentFilesPrint
{
    /// <summary>
    /// Builds a C1MultiDocument or a C1PrintDocument that prints out files in subdirectories of a specified directory.
    /// If building a multi-document, each subdirectory is represented by a separate C1PrintDocument.
    /// The resulting document includes a TOC at the top, and a word index at the end.
    /// The TOC contains entries for each subdirectory, and for each file within.
    /// The word index contains KnownColor names present in the printed files.
    /// </summary>
    public class FilesPrinter
    {
        // Events used to add TOC and index entries:
        // Return value is the outline node of the most-nested directory:
        private delegate OutlineNode DirAddedHandler(C1PrintDocument doc, RenderObject dirRo, string dirName, int level);
        private delegate void FileAddedHandler(C1PrintDocument doc, OutlineNode dirOutlineNode, RenderObject fileRo, string fileName, int level);
        private delegate void LineAddedHandler(RenderObject lineRo, string fileName, string line, int lineNo);
        private event DirAddedHandler DirAdded;
        private event FileAddedHandler FileAdded;
        private event LineAddedHandler LineAdded;
        // Delimiters used to split lines of code for word index:
        static private readonly char[] s_delims = new char[] { ' ', ',', '.', ';', ':' };

        private string _dir = null;
        private string _mask = "*.*";
        private C1MultiDocument _mdoc = null;
        private C1PrintDocument _sdoc = null;

        public FilesPrinter()
        {
        }

        /// <summary>
        /// Fills a C1MultiDocument or a C1PrintDocument passed to it with listings of
        /// all files in the specified directory and its subdirectories matching the specified mask.
        /// </summary>
        /// <param name="theDoc">A C1MultiDocument or a C1PrintDocument.</param>
        /// <param name="dir">Directory containing the files to list.</param>
        /// <param name="mask">The files mask (e.g. "*.cs").</param>
        /// <param name="pf">Progress form.</param>
        public void MakeMultiDocument(object theDoc, string dir, string mask, ProgressForm pf)
        {
            // Find out what kind of document we're creating:
            _mdoc = theDoc as C1MultiDocument;
            _sdoc = theDoc as C1PrintDocument;
            if (_mdoc == null && _sdoc == null)
                throw new Exception("Unsupported document type.");

            _dir = Path.GetFullPath(dir);
            _mask = mask;

            // Set up the document:
            if (_mdoc != null)
            {
                _mdoc.Clear();
                _mdoc.DoEvents = true;
            }
            else
            {
                _sdoc.Clear();
                _sdoc.DoEvents = true;
                SetupDoc(_sdoc);
            }

            // Show initial progress:
            pf.SetProgress(string.Format("Reading {0}...", _dir), 0);

            // For progress indicator only - get the list of all subdirectories:
            // long allDirsCount = Directory.GetDirectories(_dir, "*", SearchOption.AllDirectories).LongLength;
            // long allDirsIdx = 0;

            // Create TOC render object that will list directories and files:
            RenderToc toc = new RenderToc();

            // Add a TOC directory entry in "directory added" event:
            DirAdded += (doc, dirRo, dirName, level) =>
            {
                C1Anchor aDir = new C1Anchor(string.Format("d{0}", dirName.GetHashCode()));
                dirRo.Anchors.Add(aDir);

                // Add a TOC item for the directory (full name for root dir, own name for subdirs):
                string tocName = dirName == _dir ? dirName : Path.GetFileName(dirName);
                RenderTocItem rti = toc.AddItem(tocName, new C1Hyperlink(new C1LinkTargetAnchor(aDir.Name)), level);
                // Bold directory TOC entries:
                rti.Style.FontBold = true;
                // duplicate TOC entry in OUTLINE:
                OutlineNode outlineNode = new OutlineNode(dirName, dirRo);
                doc.Outlines.Add(outlineNode); // in this mode, all directory nodes are top-level

                // update overall progress:
                pf.SetProgress(string.Format("Reading {0}...", dirName));
                if (pf.Cancelled)
                    throw new Exception("Directory scan aborted.");

                return outlineNode;
            };

            // Add a TOC file entry in "file added" event:
            FileAdded += (doc, dirOutlineNode, fileRo, fileName, level) =>
            {
                C1Anchor aFile = new C1Anchor(string.Format("f{0}", fileName.GetHashCode()));
                fileRo.Anchors.Add(aFile);
                string tocItemName = Path.GetFileName(fileName);
                toc.AddItem(tocItemName, new C1Hyperlink(new C1LinkTargetAnchor(aFile.Name)), level);
                // duplicate TOC entry in OUTLINE:
                if (dirOutlineNode == null)
                    doc.Outlines.Add(tocItemName, fileRo); // top-level entry
                else
                    dirOutlineNode.Children.Add(tocItemName, fileRo); // nested entry
            };

            // Create the common index:
            RenderIndex index = new RenderIndex();
            // Init keywords:
            Dictionary<string, IndexEntry> indexEntries = new Dictionary<string, IndexEntry>();

            // For this sample, we will build an index of all KnownColor names:
            string[] colorNames = Enum.GetNames(typeof(KnownColor));
            foreach (string keyword in colorNames)
                indexEntries.Add(keyword, new IndexEntry(keyword));

            // Add an index entry for each key word in line:
            LineAdded += (lineRo, fileName, line, lineNo) =>
            {
                var words = line.Split(s_delims, StringSplitOptions.RemoveEmptyEntries);
                C1Anchor a = null;
                foreach (string word in words)
                {
                    if (indexEntries.ContainsKey(word))
                    {
                        if (a == null)
                        {
                            a = new C1Anchor(string.Format("k{0}{1}", fileName.GetHashCode(), lineNo));
                            lineRo.Anchors.Add(a);
                        }
                        indexEntries[word].Occurrences.Add(new IndexEntryOccurrence(new C1LinkTargetAnchor(a.Name)));
                    }
                }
            };


            // Add listings of files to the document:
            ListDir(_dir, 1);

            // insert TOC at the top:
            RenderText tocHeader = new RenderText("Table of Contents");
            tocHeader.Style.Spacing.Bottom = "3mm";
            tocHeader.Style.TextAlignHorz = AlignHorzEnum.Center;
            tocHeader.Style.FontSize = 12;
            tocHeader.Style.FontBold = true;
            if (_mdoc != null)
            {
                C1PrintDocument docToc = new C1PrintDocument();
                docToc.Body.Children.Add(tocHeader);
                docToc.Body.Children.Add(toc);
                _mdoc.Items.Insert(0, docToc);
                docToc = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            else
            {
                toc.BreakAfter = BreakEnum.Page;
                _sdoc.Body.Children.Insert(0, toc);
                _sdoc.Body.Children.Insert(0, tocHeader);
            }

            // insert word index at the bottom:
            RenderText indexHeader = new RenderText("Index of Known Colors");
            indexHeader.Style.Spacing.Bottom = "3mm";
            indexHeader.Style.TextAlignHorz = AlignHorzEnum.Center;
            indexHeader.Style.FontSize = 12;
            indexHeader.Style.FontBold = true;
            index.HeadingStyle.FontSize += 1;
            index.HeadingStyle.FontBold = true;
            index.HeadingStyle.Padding.All = "2mm";
            // add index entries that have some occurrences:
            foreach (IndexEntry ie in indexEntries.Values)
            {
                if (ie.HasOccurrences)
                    index.Entries.Add(ie);
            }
            if (_mdoc != null)
            {
                C1PrintDocument docIndex = new C1PrintDocument();
                docIndex.Body.Children.Add(indexHeader);
                docIndex.Body.Children.Add(index);
                _mdoc.Items.Add(docIndex);
                docIndex = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            else
            {
                indexHeader.BreakBefore = BreakEnum.Page;
                _sdoc.Body.Children.Add(indexHeader);
                _sdoc.Body.Children.Add(index);
            }

            // we're done!
            pf.SetProgress(string.Format("Reading {0}...", _dir), 1);
        }

        private void SetupDoc(C1PrintDocument doc)
        {
            // Setup document:
            doc.TagOpenParen = "@@@[";
            doc.TagCloseParen = "]@@@";
            doc.TagEscapeString = @"@@@\";
            doc.PageLayout.PageSettings.LeftMargin = "0.5in";
            doc.PageLayout.PageSettings.RightMargin = "0.5in";
            doc.PageLayout.PageSettings.TopMargin = "0.5in";
            doc.PageLayout.PageSettings.BottomMargin = "0.5in";

            // Common page footer:
            RenderText pageFooter = new RenderText();
            pageFooter.Text = "Page @@@[PageNo]@@@ of @@@[PageCount]@@@";
            pageFooter.Style.TextAlignHorz = AlignHorzEnum.Right;
            pageFooter.Style.Spacing.Top = "3mm";
            pageFooter.Style.Borders.Top = LineDef.Default;
            pageFooter.Style.Padding.Top = "2mm";
            doc.PageLayout.PageFooter = pageFooter;
        }

        private void ListDir(string dir, int level)
        {
            if (string.IsNullOrEmpty(dir))
                return;

            // get files first:
            string[] files = Directory.GetFiles(dir, _mask, SearchOption.TopDirectoryOnly);

            // if there are no matching files - we skip the directory as well:
            if (files.Length > 0)
            {
                C1PrintDocument doc;
                if (_sdoc != null)
                    doc = _sdoc;
                else
                {
                    doc = new C1PrintDocument();
                    SetupDoc(doc);
                }

                // directory header:
                RenderText dirHeader = new RenderText(string.Format("Files in {0}", dir));
                dirHeader.Style.FontSize = 12;
                dirHeader.Style.FontBold = true;
                dirHeader.Style.Spacing.Bottom = "3mm";
                dirHeader.Style.BackColor = Color.LemonChiffon;
                // Add a dir TOC/outline entry, keep outline as files' parent:
                OutlineNode dirOutlineNode = this.DirAdded(doc, dirHeader, dir, level);

                // add files:
                for (int nfile = 0; nfile < files.Length; ++nfile)
                {
                    RenderArea file = ListFile(files[nfile], nfile == 0 ? dirHeader : null);
                    doc.Body.Children.Add(file);
                    // Add a file TOC entry:
                    this.FileAdded(doc, dirOutlineNode, file, files[nfile], level + 1);
                }

                if (_mdoc != null)
                {
                    _mdoc.Items.Add(doc);
                    // Make sure all memory used by the added document is released:
                    doc = null;
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
            }

            // recurse into sub-dirs:
            string[] dirs = Directory.GetDirectories(dir, "*", SearchOption.TopDirectoryOnly);
            for (int ndir = 0; ndir < dirs.Length; ++ndir)
                ListDir(dirs[ndir], level + 1);
        }

        private RenderArea ListFile(string fileName, RenderObject dirHeader)
        {
            RenderArea file = new RenderArea();
            PageLayout pl = new PageLayout();
            RenderTable pageHeader = new RenderTable();
            pageHeader.Cells[0, 0].Text = "Dir:";
            pageHeader.Cells[0, 1].Text = Path.GetDirectoryName(fileName);
            pageHeader.Cells[1, 0].Text = "File:";
            pageHeader.Cells[1, 1].Text = Path.GetFileName(fileName);
            pageHeader.Cols[0].SizingMode = TableSizingModeEnum.Auto;
            pageHeader.Cols[1].Stretch = StretchColumnEnum.Yes;
            pageHeader.Style.GridLines.All = new LineDef("1pt", Color.LightGray);
            pageHeader.CellStyle.Padding.All = "1mm";
            pageHeader.Style.Spacing.Bottom = "3mm";
            pl.PageHeader = pageHeader;
            file.LayoutChangeBefore = new LayoutChangeNewPage(pl);

            if (dirHeader != null)
                file.Children.Add(dirHeader);

            RenderText fileHeader = new RenderText(Path.GetFileName(fileName));
            fileHeader.Style.BackColor = Color.AliceBlue;
            fileHeader.Style.FontSize = 12;
            fileHeader.Style.FontItalic = true;
            fileHeader.Style.Spacing.Bottom = "2mm";
            fileHeader.Style.TextAlignHorz = AlignHorzEnum.Right;
            file.Children.Add(fileHeader);

            using (StreamReader sr = new StreamReader(fileName))
            {
                int curLine = 1;
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    RenderText rt = new RenderText(line);
                    // doc.Body.Children.Add(rt);
                    file.Children.Add(rt);
                    this.LineAdded(rt, fileName, line, curLine);
                    curLine++;
                }
                // show total lines in page header:
                pageHeader.Cells[1, 2].Text = string.Format("{0} lines", curLine - 1);
                pageHeader.Cells[0, 1].SpanCols = 2;
                pageHeader.Cols[2].SizingMode = TableSizingModeEnum.Auto;

            }
            return file;
        }
    }
}
