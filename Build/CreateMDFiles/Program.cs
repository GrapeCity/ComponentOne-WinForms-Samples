using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace CreateMDFiles
{
    class Program
    {
        // initial part of the download URL
        // example of download URL: "https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/NetFramework\C1.Win.Ribbon\CS\AddQatItems"
        private const string InitialUrl = @"https://grapecity.github.io/DownGit/#/home?url=https://github.com/GrapeCity/ComponentOne-WinForms-Samples/tree/master/";

        // how many directory levels will be skipped in the download URL path
        // for example, in the path "d:\Git\grapecity\c1-winforms-samples\Core\Input\CS\InputExplorer\readme.txt"
        // the repository directory is "d:\Git\grapecity\c1-winforms-samples", it`s means that 4 directory levels will be excluded in download URL path
        private const int SkipDirLevels = 4;

        // screenshot file name which will be searched in the directory with the "readme.txt" file
        private const string ScreensotFileName = "screenshot.PNG";

        static void Main(string[] args)
        {
            #region ** check arguments

            // the directory in which to search for 'readme.txt' and screenshot files
            var directory = string.Empty;

            if (args.Length == 1)
            {
                directory = args[0].Trim();
            }
            else // bad arguments
            {
                PrintHelp();
                Environment.Exit(-1);
            }

            if (!Directory.Exists(directory))
            {
                Console.WriteLine($"Directory '{directory}' not available." + Environment.NewLine);
                Environment.Exit(-1);
            }

            #endregion ** check arguments

            string[] files = Directory.GetFiles(directory);

            foreach (string readmePath in files)
            {
                // when "readme.txt" file is found
                if (Path.GetFileName(readmePath) == "readme.txt")
                {
                    var readmeDir = Path.GetDirectoryName(readmePath);

                    var lines = File.ReadAllLines(readmePath);

                    // add header
                    var text = "## " + lines[0] + Environment.NewLine;

                    // create and add download link
                    string[] directoriesArray = readmeDir.Split('\\');
                    var directoriesList = new List<string>(directoriesArray);
                    directoriesList.RemoveRange(0, SkipDirLevels);
                    text += string.Format(@"#### [Download as zip]({0}{1})", InitialUrl, string.Join("\\", directoriesList.ToArray())) + Environment.NewLine;

                    // add horizontal line
                    text += "____" + Environment.NewLine;

                    // add one-line description of the sample
                    text += "#### " + lines[2] + Environment.NewLine;

                    // horizontal line
                    text += "____" + Environment.NewLine;

                    var unorderedList = true;
                    var emptyLineAdded = false;

                    // lines of detailed description of the sample
                    for (int i = 4; i < lines.Length; i++)
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

                    // add screenshot link
                    var screenshot = new DirectoryInfo(readmeDir).EnumerateFiles("screenshot.png", SearchOption.AllDirectories).FirstOrDefault(name => name.Name == "screenshot.png");

                    if (screenshot != null)
                    {
                        text += Environment.NewLine + "![screenshot](screenshot.png)" + Environment.NewLine;
                    }

                    File.WriteAllText(Path.Combine(readmeDir, "README.md"), text);
                }
            }
        }


            /*
            
            // OLD VARIANT

            #region ** check arguments

            var readmePath = string.Empty;
            var url = string.Empty;
            var screenshot = string.Empty;

            if (args.Length == 2)
            {
                readmePath = args[0].Trim();
                url = args[1].Trim();
            }
            else if (args.Length == 3) // if screenshot specified
            {
                readmePath = args[0].Trim();
                url = args[1].Trim();
                screenshot = args[2].Trim();
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

            var path = Path.GetDirectoryName(readmePath);

            if (args.Length == 3 && !File.Exists(Path.Combine(path, screenshot)))
            {
                Console.WriteLine($"File '{screenshot}' not available." + Environment.NewLine);
                Environment.Exit(-1);
            }

            #endregion ** check arguments

            var lines = File.ReadAllLines(readmePath);

            var text = "## " + lines[0] + Environment.NewLine; // header
            text += string.Format(@"#### [Download as zip]{0}", url) + Environment.NewLine; // download link
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

            // add screenshot link
            if (!string.IsNullOrEmpty(screenshot))
            {
                text += Environment.NewLine + string.Format("![screenshot]({0})", screenshot) + Environment.NewLine;
            }

            File.WriteAllText(Path.Combine(path, "README.md"), text);

            */


        /*
        
        // OLD VARIANT

        private static void PrintHelp()
        {
            Console.WriteLine("Usage: CreateMDFiles.exe \"<readme.txt path>\" \"<url>\" \"<screenshot file>\"" + Environment.NewLine +
            "   <readme.txt path> - the path to readme.txt file, for example: \"D:\\Tfs\\WinForms\\readme.txt" + Environment.NewLine +
            "   <url> - the URL link to zip file." + Environment.NewLine +
            "   <screenshot file> - screenshot file name without path. Add screenshot at the md file`s end. The file must be located in the folder with the 'readme.txt' file." + Environment.NewLine);
        }
        */

        private static void PrintHelp()
        {
            Console.WriteLine(@"Usage: CreateMDFiles.exe ""<work path>""" + Environment.NewLine +
            "   <work path> - the path to directory with projects contains 'readme.txt' files, for example: d:\\Git\\grapecity\\c1-winforms-samples\\Core" + Environment.NewLine +
            "   <url> - the common part of the download URL link." + Environment.NewLine);
        }
    }
}