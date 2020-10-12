using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Xml;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using C1.Win.C1Editor;

namespace SyntaxHighlight
{
    public partial class Form1 : Form
    {
        // keep track of time to update syntax coloring efficiently
        DateTime _lastChange;
        const int MINIMUM_UPDATE_DELAY = 500;

        public Form1()
        {
            // designer support
            InitializeComponent();

            // load document
            c1Editor1.LoadXml(Properties.Resources.Syntax, null);

            // update syntax when document changes
            c1Editor1.DocumentChanged += c1Editor1_DocumentChanged;
            Application.Idle += Application_Idle;
        }

        //-------------------------------------------------------------------------------------
        #region ** event handlers

        // keep track of the time when the document was modified
        void c1Editor1_DocumentChanged(object sender, EventArgs e)
        {
            _lastChange = DateTime.Now;
        }

        // if the document was modified and some time has elapsed, update syntax
        void Application_Idle(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now.Subtract(_lastChange);

            double t = ts.TotalMilliseconds;
            if (t > MINIMUM_UPDATE_DELAY)
            {
                c1Editor1.BeginTransaction("Highlight document");
                try
                {
                    UpdateSyntax();
                    c1Editor1.CommitTransaction();
                }
                catch
                {
                    c1Editor1.RollbackTransaction();
                }

                // wait for the next change
                _lastChange = DateTime.MaxValue;
            }
        }

        #endregion

        //-------------------------------------------------------------------------------------
        #region ** implementation

        void UpdateSyntax()
        {
            // get text
            string text = c1Editor1.Text;

            // remove formatting
            C1TextRange rng = c1Editor1.CreateRange(0, text.Length);
            rng.RemoveTag("span");

            // apply all syntax descriptors
            foreach (SyntaxDescriptor sd in GetSyntaxDescriptors())
            {
                // initialize
                int start = 0;
                rng.Start.Move(MoveUnit.Character, -50000000);
                rng.End.MoveTo(rng.Start);

                // if there's a group called 'match', use it;
                // otherwise, use the first one
                int gIndex = sd.Regex.GroupNumberFromName("match");
                if (gIndex < 0) gIndex = 0;

                // find all matches for this descriptor
                for (Match match = sd.Regex.Match(text); match.Success; match = match.NextMatch())
                {
                    // apply descriptor style for this match
                    Group g = match.Groups[gIndex];
                    foreach (Capture c in g.Captures)
                    {
                        rng.Move(c.Index - start, c.Length);

                        // avoid nested spans (e.g. reserved words in comments, etc)
                        if (rng.Node.ParentNode.Name != "span")
                        {
                            rng.ApplyClass(sd.ClassName, C1StyleType.Character);
                        }

                        start = c.Index;
                    }
                }
            }
        }

        List<SyntaxDescriptor> _sd;
        List<SyntaxDescriptor> GetSyntaxDescriptors()
        {
            if (_sd == null)
            {
                _sd = new List<SyntaxDescriptor>();

                // comments
                _sd.Add(new SyntaxDescriptor(@"(?m)//.*$", "comment"));
                _sd.Add(new SyntaxDescriptor(@"/\*[\s\S]*\*/", "comment"));

                // strings and chars
                _sd.Add(new SyntaxDescriptor(@"@?""[^""\n]*""", "string"));
                _sd.Add(new SyntaxDescriptor(@"@?'\\?[^']'", "string"));

                // reserved words
                string resWords = Properties.Resources.reservedWords.Replace("\r\n", "|");
                resWords = string.Format(@"(^|\W)(?<match>{0})(?=$|\W)", resWords);
                _sd.Add(new SyntaxDescriptor(resWords, "resWord"));
            }
            return _sd;
        }

        #endregion
    }

    /// <summary>
	/// Class used to associate syntax elements to display styles.
	/// </summary>
	public class SyntaxDescriptor
	{
		//------------------------------------------------------------------------
		#region ** fields

		public readonly Regex	Regex;
		public readonly string  ClassName;

		#endregion

		//------------------------------------------------------------------------
		#region ** ctors

        public SyntaxDescriptor(string pattern, string className)
		{
            Regex = new Regex(pattern, RegexOptions.Compiled | RegexOptions.Multiline);
            ClassName = className;
		}

		#endregion
	}
}
