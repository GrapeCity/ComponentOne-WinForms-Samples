using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RichTextEditor
{
    public partial class WordCount : Form
    {
        public WordCount()
        {
            InitializeComponent();
        }
        public WordCount(string text)
        {
            InitializeComponent();

            int chars = 0;
            int nonSpaceChars = 0;
            int words = 0;
            int paragraphs = 0;
            int sentences = 0;

            int length = text.Length;

            // calculate statistics
            for (int i = 0; i < length; i++)
            {
                char c = text[i];

                // count chars
                chars++;

                // count non-space chars
                if (!char.IsWhiteSpace(c))
                {
                    nonSpaceChars++;
                }

                // count paragraphs
                if (c == '\n' || i == length - 1)
                {
                    if (i == length - 1 || text[i + 1] != '\n')
                    {
                        paragraphs++;
                    }
                }

                // count sentences
                if (c == '.' || c == '!' || c == '?' || i == length - 1)
                {
                    if (i == length - 1 || char.IsWhiteSpace(text, i + 1))
                    {
                        sentences++;
                    }
                }

                // count words
                if (char.IsLetterOrDigit(c))
                {
                    if (i == length - 1 || !char.IsLetterOrDigit(text, i + 1))
                    {
                        words++;
                    }
                }
            }

            // show statistics
            _lblWords.Text = words.ToString("n0");
            _lblChars.Text = chars.ToString("n0");
            _lblCharsNoSpace.Text = nonSpaceChars.ToString("n0");
            _lblParagraphs.Text = paragraphs.ToString("n0");
            _lblSentences.Text = sentences.ToString("n0");
            _lblWordLength.Text = string.Format("{0:n1}", words > 0 ? nonSpaceChars / (float)words : 0f);
            _lblSentenceLength.Text = string.Format("{0:n1}", sentences > 0 ? nonSpaceChars / (float)sentences : 0f);
            _lblParagraphLength.Text = string.Format("{0:n1}", paragraphs > 0 ? nonSpaceChars / (float)paragraphs : 0f);
        }
    }
}
