using System;
using System.IO;

namespace CreateMDFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ** check arguments

            var readmePath = string.Empty;
            var url = string.Empty;

            if (args.Length == 2)
            {
                readmePath = args[0].Trim();
                url = args[1].Trim();
            }
            else // bad arguments
            {
                PrintHelp();
                Environment.Exit(-1);
            }

            if (!File.Exists(readmePath))
            {
                Console.WriteLine($"File '{readmePath}' not available." + Environment.NewLine);
                Environment.Exit(-1);
            }

            #endregion ** check arguments

            var lines = File.ReadAllLines(readmePath);

            var text = "## " + lines[0] + Environment.NewLine; // header
            text += string.Format(@"#### [Download as zip]({0})", url) + Environment.NewLine; // download link
            text += "____" + Environment.NewLine; // horizontal line
            text += "#### " + lines[2] + Environment.NewLine; // one-line description of the sample
            text += "____" + Environment.NewLine; // horizontal line

            var unorderedList = true;
            var emptyLineAdded = false;

            for (int i = 4; i < lines.Length; i++) // lines of detailed description of the sample
            {
                var line = lines[i];

                if (line.Contains("<product>") || line.Contains("</product>") || line.Contains("<pre>")) // do not add these tags
                {
                    continue;
                }
                else if (line.Contains("</pre>")) // replace tag by line break
                {
                    text += Environment.NewLine;
                }
                else if (line.Contains("<code>")) // begin of code block
                {
                    text += "```" + Environment.NewLine;
                }
                else if (line == "</code>") // end of code block
                {
                    text += "```";
                }
                else
                {
                    var trimmedLine = line.Trim();

                    // if "-" or "*" at the beginning of the line then create an unordered list item
                    if ((trimmedLine.Length > 0 && trimmedLine.IndexOf('-', 0, 1) == 0) ||
                        (trimmedLine.Length > 1 && trimmedLine.IndexOf('*', 0, 1) == 0 && trimmedLine.IndexOf('*', 1, 1) == -1))
                    {
                        unorderedList = true;

                        trimmedLine = trimmedLine.Substring(1).Trim();
                        trimmedLine = "* " + trimmedLine;
                    }
                    else
                    {
                        // reset flags
                        unorderedList = false;
                        emptyLineAdded = false;
                    }

                    if (unorderedList)
                    {
                        if (!emptyLineAdded)
                        {
                            emptyLineAdded = true;
                            text += Environment.NewLine;
                        }

                        text += trimmedLine + Environment.NewLine;
                    }
                    else // add usual line
                    {
                        text += line + Environment.NewLine;
                    }
                }
            }

            var path = Path.GetDirectoryName(readmePath);
            File.WriteAllText(Path.Combine(path, "README.md"), text);
        }

        private static void PrintHelp()
        {
            Console.WriteLine("Usage: CreateMDFiles.exe \"<readme.txt path>\" \"<url>\"" + Environment.NewLine +
            "   <readme.txt path> - the path to readme.txt file, for example: \"D:\\Tfs\\WinForms\\readme.txt" + Environment.NewLine +
            "   <url> - the URL link to zip file." + Environment.NewLine);
        }
    }
}