using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.SpellChecker;

namespace SpellCheckerExplorer.Samples.CustomParser
{
    public partial class Form1 : UserControl
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // hook up our custom spell-checking parser
            this.c1SpellChecker1.CustomParser = new MyCSharpSpellParser();
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // spell-check text when user hits f7.
            if (e.KeyCode == Keys.F7)
            {
                this.c1SpellChecker1.CheckControl(this.richTextBox1);
            }
        }
    }

    /// <summary>
    /// Class that parses c# files and retrieves words in comments for spell-checking.
    /// </summary>
    public class MyCSharpSpellParser : ISpellParser
    {
        // ** fields
        string _text;
        CharRangeList _commentRanges = new CharRangeList();

        // ** ctor
        public MyCSharpSpellParser()
        {
        }

        // ** ISpellParser
        public CharRange GetNextWord(string text, int start, IgnoreOptions ignore, string previousWord)
        {
            // refresh list of comment ranges to check
            if (text != _text)
            {
                _text = text;
                BuildCommentRangeList();
            }

            // use CharRange implementation by default
            CharRange range = CharRange.GetNextWord(text, start, ignore, previousWord);
            if (range == null)
            {
                return null;
            }

            // check that the returned range is in the comment list
            foreach (CharRange r in _commentRanges)
            {
                // range is in the list, use it
                if (r.Start <= range.Start && r.End >= range.End)
                {
                    return range;
                }

                // range is not in the list, continue with next comment
                if (r.Start > range.End)
                {
                    return GetNextWord(text, r.Start, ignore, previousWord);
                }
            }

            // done...
            return null;
        }
        public string FilterWord(string word)
        {
            return word;
        }

        // ** private
        private void BuildCommentRangeList()
        {
            // clear old list
            _commentRanges.Clear();

            // scan the string and save comments
            for (int index = 0; index < _text.Length; index++)
            {
                if (_text[index] == '/' && index < _text.Length - 1)
                {
                    if (_text[index + 1] == '*')
                    {
                        // comments /* xxxx */
                        int end = _text.IndexOf("*/", index + 2);
                        if (end > -1)
                        {
                            CharRange range = new CharRange(_text.Substring(index, end - index + 1), index, false);
                            _commentRanges.Add(range);
                            index = end + 1;
                        }
                    }
                    else if (_text[index + 1] == '/')
                    {
                        // comments // xxxx \n
                        int end = _text.IndexOf("\n", index + 2);
                        if (end > -1)
                        {
                            CharRange range = new CharRange(_text.Substring(index, end - index + 1), index, false);
                            _commentRanges.Add(range);
                            index = end + 1;
                        }
                    }
                }

                // skip over strings in case they contain comment chars: "xxx // foo /* yyy */"
                if (_text[index] == '\"' && IsRealQuote(index))
                {
                    int end = FindNextQuote(index);
                    if (end > -1)
                    {
                        index = end;
                    }
                }
            }
        }
        private bool IsRealQuote(int index)
        {
            if (index > -1 && _text[index] == '\"')
            {
                return index > 0 && (_text[index - 1] == '\\' || _text[index - 1] == '\'')
                    ? false
                    : true;
            }
            return false;
        }
        private int FindNextQuote(int index)
        {
            int pos = _text.IndexOf('\"', index + 1);
            while (pos > -1 && !IsRealQuote(pos))
            {
                pos = _text.IndexOf('\"', pos + 1);
            }
            return pos;
        }
    }
}