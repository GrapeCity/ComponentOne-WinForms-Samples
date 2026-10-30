using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorExplorer.Samples
{
    public partial class SyntaxHighlight : UserControl
    {
        private string _text;
        private List<SyntaxDescriptor> _syntaxDescriptions;
        private Timer _timer = new Timer();
        // To avoid multiple updates running simultaneously
        private bool _isUpdatingSyntax = false; 

        public SyntaxHighlight()
        {
            InitializeComponent();


            c1Editor1.ClientSizeChanged += C1Editor1_Resize;
            c1Editor1.SizeChanged += C1Editor1_Resize;

            _timer.Interval = 500;
            _timer.Tick += async (s, e) => await UpdateSyntaxAsync();

            // Attach the Disposed event handler to c1Editor1
            c1Editor1.Disposed += C1Editor1_Disposed;

        }

        private void C1Editor1_Resize(object sender, EventArgs e)
        {
            c1Editor1.Focus();
        }
        private async void c1Editor1_C1EditorReadyAsync(object sender, EventArgs e)
        {
            const string filename = @"Resources\Syntax.html";
            if (File.Exists(filename))
            {
                await c1Editor1.LoadDocumentAsync(Path.GetFullPath(filename));
                _timer.Start();
            }
        }

        // Updates syntax highlighting.
        private async Task UpdateSyntaxAsync()
        {
            if (_isUpdatingSyntax || c1Editor1.IsDisposed)
                return; // Prevent multiple updates from running at once

            _isUpdatingSyntax = true; // Set the flag before starting the process

            try
            {
                string text = c1Editor1.Text;
                if (_text is null || (_text != text))
                {
                    // Remove old syntax highlighting.
                    await c1Editor1.RemoveElementAsync(null, "span", "comment", false);
                    await c1Editor1.RemoveElementAsync(null, "span", "strings", false);
                    await c1Editor1.RemoveElementAsync(null, "span", "resWord", false);

                    // Apply all syntax descriptors.
                    foreach (SyntaxDescriptor sd in GetSyntaxDescriptors())
                        await c1Editor1.FindAndDecorateAsync(sd.Regex, null, null, sd.ClassName);

                    _text = text;
                }
            }
            finally
            {
                _isUpdatingSyntax = false; // Ensure this flag is always reset
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
        // Handle disposal of c1Editor1
        private void C1Editor1_Disposed(object sender, EventArgs e)
        {
            _timer.Stop();
            _timer.Dispose();
            _timer = null; // Release the reference
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