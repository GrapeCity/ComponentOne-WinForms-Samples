using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EditorExplorer.Samples
{
    public partial class SyntaxHighlight : UserControl
    {
        private string _text;
        private List<SyntaxDescriptor> _syntaxDescriptions;
        private Timer _timer = new Timer();

        public SyntaxHighlight()
        {
            InitializeComponent();

            _timer.Interval = 500;
            _timer.Tick += (s, e) => UpdateSyntax();            
        }

        private async void c1Editor1_C1EditorReady(object sender, EventArgs e)
        {
            const string filename = @"Resources\Syntax.html";
            if (File.Exists(filename))
            {
                await c1Editor1.LoadDocumentAsync(Path.GetFullPath(filename));
                _timer.Start();
            }
        }        

        // Updates syntax highlighting.
        private void UpdateSyntax()
        {
            string text = c1Editor1.Text;
            if (_text is null || (_text != text && _text is not null))
            {
                // Remove old syntax highlighting.
                c1Editor1.RemoveElement(null, "span", "comment", false);
                c1Editor1.RemoveElement(null, "span", "strings", false);
                c1Editor1.RemoveElement(null, "span", "resWord", false);

                // Apply all syntax descriptors.
                foreach (SyntaxDescriptor sd in GetSyntaxDescriptors())
                    c1Editor1.FindAndDecorate(sd.Regex, null, null, sd.ClassName);

                _text = text;
            }
        }

        List<SyntaxDescriptor> GetSyntaxDescriptors()
        {
            if (_syntaxDescriptions is null)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(SyntaxHighlight));
                string resWords = resources.GetString("reservedWords").Replace("\r\n", "|");
                resWords = string.Format(@"(^|\W)(?<match>{0})(?=$|\W)", resWords);

                _syntaxDescriptions = new List<SyntaxDescriptor>()
                {
                    new SyntaxDescriptor(@"(//.*$|/\*[\s\S]*\*/)", "comment"),
                    new SyntaxDescriptor(@"(@?""[^""\n]*""|@?'\\?[^']')", "strings"),
                    new SyntaxDescriptor(resWords, "resWord")
                };
            }
            return _syntaxDescriptions;
        }
    }

    /// <summary>
	/// Class used to associate syntax elements to display styles.
	/// </summary>
	public class SyntaxDescriptor
    {
        public readonly Regex Regex;
        public readonly string ClassName;

        public SyntaxDescriptor(string pattern, string className)
        {
            Regex = new Regex(pattern, RegexOptions.Compiled | RegexOptions.Multiline);
            ClassName = className;
        }
    }
}