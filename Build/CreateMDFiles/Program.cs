using System;
using System.IO;

namespace CreateMDFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Check arguments

            var readmePath = string.Empty;
            var url = string.Empty;

            if (args.Length == 2)
            {
                readmePath = args[0].Trim();
                url = args[1].Trim();
            }
            else // bad arguments
            {
                WriteHelp();
                Environment.Exit(-1);
            }

            if (!File.Exists(readmePath))
            {
                Console.WriteLine($"File '{readmePath}' not available." + Environment.NewLine);
                Environment.Exit(-1);
            }

            #endregion

            var lines = File.ReadAllLines(readmePath);
            var text = "## " + lines[0] + Environment.NewLine; // header
            text += string.Format(@"#### [Download as zip]({0})", url) + Environment.NewLine; // URL
            text += "____" + Environment.NewLine;
            text += lines[2] + Environment.NewLine; // one-line description of the sample 
            text += "____" + Environment.NewLine;
            var isCode = false;
            var isPre = false;

            for (int i = 4; i < lines.Length; i++) // detailed description of the sample
            {
                var line = lines[i].Trim();

                if (line.Contains("<product>") && line.Contains("</product>"))
                {
                    continue;
                }

                if (line == "<code>")
                {
                    isCode = true;
                    text += "```" + Environment.NewLine;
                }
                else if (line == "</code>")
                {
                    isCode = false;
                    text += "```";
                }
                else if (line == "<pre>")
                {
                    isPre = true;
                }
                else if (line == "</pre>")
                {
                    isPre = false;
                }
                else
                {
                    if (isCode || isPre)
                    {
                        text += line + Environment.NewLine;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(line))
                        {
                            text += Environment.NewLine + Environment.NewLine;
                        }
                        else
                        {
                            text += line.TrimEnd() + " ";
                        }
                    }
                }
            }

            var path = Path.GetDirectoryName(readmePath);
            File.WriteAllText(Path.Combine(path, "README.md"), text);
        }

        private static void WriteHelp()
        {
            Console.WriteLine("Usage: CreateMDFiles.exe \"<readme.txt path>\" \"<url>\"" + Environment.NewLine +
            "   <readme.txt path> - the path to readme.txt file, for example: \"D:\\Tfs\\WinForms\\readme.txt" + Environment.NewLine +
            "   <url> - the URL link to zip file." + Environment.NewLine);
        }
    }
}