using System;
using System.IO;
using System.Resources;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Animation;
using C1.Win.C1SpellChecker;

namespace C1SpellCheckerWpf
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            // assign some text to the RichTextBox
            var textRange = new TextRange(_rtb.Document.ContentStart, _rtb.Document.ContentEnd);
            MemoryStream ms = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(Properties.Resources.C1SpellChecker));
            textRange.Load(ms, DataFormats.Rtf);
        }
    }
}
