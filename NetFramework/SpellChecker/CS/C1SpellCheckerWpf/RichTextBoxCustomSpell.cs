using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Threading;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using C1.Win.C1SpellChecker;

namespace C1SpellCheckerWpf
{
    class RichTextBoxCustomSpell : RichTextBox
    {
        DispatcherTimer _timer;
        C1SpellChecker _spell;
        List<TextRange> _errorRanges;
        TextDecorationCollection _errorUnderline;
        TextDecorationCollection _noUnderline;
        bool _pendingCheck;
        bool _checking;

        const int SPELLCHECK_DELAY = 200;
        const string MENU_IGNOREALL = "Ignore All";
        const string MENU_ADDTODICTIONARY = "Add to Dictionary";
        const string MENU_NOSUGGESTIONS = "(no suggestions)";

        // ctor
        public RichTextBoxCustomSpell()
        {
            // initialize error markers
            _errorUnderline = CreateErrorUnderline();
            _noUnderline = new TextDecorationCollection();
            _errorRanges = new List<TextRange>();

            // initialize timer used to perform the spell-checking
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromMilliseconds(SPELLCHECK_DELAY);
            _timer.Tick += new EventHandler(_timer_Tick);

            // initialize the spell checker
            _spell = new C1SpellChecker();
            _spell.DictionaryChanged += _spell_DictionaryChanged;
        }

        // create red underline used to mark misspelled words
        TextDecorationCollection CreateErrorUnderline()
        {
            var u = new TextDecoration();
            u.Pen = new Pen(new SolidColorBrush(Colors.Red), 1.5);
            u.Pen.DashStyle = new DashStyle(new double[] { 1.5, 2 }, 0);
            u.PenOffsetUnit = TextDecorationUnit.Pixel;
            u.PenThicknessUnit = TextDecorationUnit.Pixel;

            var tdc = new TextDecorationCollection();
            tdc.Add(u);
            return tdc;
        }

        // restart spell-checker timer when text changes
        protected override void OnTextChanged(TextChangedEventArgs e)
        {
            // restart storyboard to check within a few ms
            _timer.Stop();
            _timer.Start();

            // fire event as usual
            base.OnTextChanged(e);
        }

        // highlight errors when lost focus and there are pending changes
        protected override void OnLostFocus(RoutedEventArgs e)
        {
            if (_pendingCheck)
            {
                PerformSpellCheck();
            }

            // fire event as usual
            base.OnLostFocus(e);
        }

        // highlight errors when selection changes and there are pending changes
        protected override void OnSelectionChanged(RoutedEventArgs e)
        {
            if (_pendingCheck)
            {
                PerformSpellCheck();
            }

            // fire event as usual
            base.OnSelectionChanged(e);
        }

        // spell-check when timer elapses
        void _timer_Tick(object sender, EventArgs e)
        {
            _timer.Stop();
            PerformSpellCheck();
        }

        // spell-check now
        void PerformSpellCheck()
        {
            // build error list
            _errorRanges.Clear();
            TextPointer start = Document.ContentStart;
            while (start.CompareTo(Document.ContentEnd) < 0)
            {
                TextPointerContext context = start.GetPointerContext(LogicalDirection.Backward);
                if (context == TextPointerContext.ElementStart && start.Parent is Run)
                {
                    PerformSpellCheck((Run)start.Parent);
                }
                start = start.GetNextContextPosition(LogicalDirection.Forward);
            }

            // highlight errors
            HighlightErrors();
        }

        // spell-check a Run object, add errors to list
        void PerformSpellCheck(Run run)
        {
            foreach (var error in _spell.CheckText(run.Text))
            {
                var errorRange = new TextRange(
                    run.ContentStart.GetPositionAtOffset(error.Start),
                    run.ContentStart.GetPositionAtOffset(error.Start + error.Length));
                _errorRanges.Add(errorRange);
            }
        }

        // highlight errors on the list
        void HighlightErrors()
        {
            if (!_checking)
            {
                // disconnect while highlighting
                _checking = true;

                // don't check words until the user finishes typing them
                _pendingCheck = false;
                var caret = Selection.Text.Length == 0
                    ? Selection.End
                    : null;

                // enumerate errors in _errorRanges
                TextRange range = null;
                TextPointer start = Document.ContentStart;
                foreach (var error in _errorRanges)
                {
                    // clear up to here
                    range = new TextRange(start, error.Start);
                    range.ApplyPropertyValue(Inline.TextDecorationsProperty, _noUnderline);

                    // skip this one if it contains the selection
                    if (caret != null && error.End.GetOffsetToPosition(caret) == 0)
                    {
                        _pendingCheck = true;
                        continue;
                    }

                    // underline this
                    error.ApplyPropertyValue(Inline.TextDecorationsProperty, _errorUnderline);

                    // update start for next
                    start = error.End;
                }

                // clear to the end
                range = new TextRange(start, Document.ContentEnd);
                range.ApplyPropertyValue(Inline.TextDecorationsProperty, _noUnderline);

                // done
                _checking = false;
            }
        }

        // show suggestions when user clicks an error
        protected override void OnContextMenuOpening(System.Windows.Controls.ContextMenuEventArgs e)
        {
            // get item that was clicked
            Point p = new Point(e.CursorLeft, e.CursorTop);
            var pointer = GetPositionFromPoint(p, true);
            if (pointer == null)
            {
                e.Handled = true;
                return;
            }

            // get error at position
            foreach (var error in _errorRanges)
            {
                if (error.Contains(pointer))
                {
                    // get context menu
                    if (ContextMenu == null)
                    {
                        ContextMenu = new ContextMenu();
                    }
                    var ctx = ContextMenu;
                    ctx.Tag = error;

                    // update context menu with suggestions
                    ctx.Items.Clear();
                    foreach (var suggestion in _spell.GetSuggestions(error.Text))
                    {
                        var item = new MenuItem();
                        item.Header = suggestion;
                        item.FontWeight = FontWeights.Bold;
                        item.Click += suggestion_Click;
                        ctx.Items.Add(item);
                    }
                    if (ctx.Items.Count == 0)
                    {
                        var item = new MenuItem();
                        item.Header = MENU_NOSUGGESTIONS;
                        item.IsEnabled = false;
                        ctx.Items.Add(item);
                    }

                    // update context menu with spell commands
                    ctx.Items.Add(new Separator());
                    foreach (string s in new string[] { MENU_IGNOREALL, MENU_ADDTODICTIONARY })
                    {
                        var item = new MenuItem();
                        item.Header = s;
                        item.Click += item_Click;
                        ctx.Items.Add(item);
                    }

                    // done
                    break;
                }
            }

            // fire event as usual
            base.OnContextMenuOpening(e);
        }

        // apply spelling suggestion
        void suggestion_Click(object sender, RoutedEventArgs e)
        {
            var item = (MenuItem)sender;
            var menu = (ContextMenu)item.Parent;
            var error = (TextRange)menu.Tag;
            error.Text = (string)item.Header;
        }

        // execute spelling command
        void item_Click(object sender, RoutedEventArgs e)
        {
            var item = (MenuItem)sender;
            var menu = (ContextMenu)item.Parent;
            var error = (TextRange)menu.Tag;

            switch ((string)item.Header)
            {
                case MENU_IGNOREALL:
                    _spell.IgnoreList.Add(error.Text);
                    break;
                case MENU_ADDTODICTIONARY:
                    _spell.UserDictionary.AddWord(error.Text);
                    break;
            }
        }

        // spell-check when the dictionaries change
        void _spell_DictionaryChanged(object sender, EventArgs e)
        {
            PerformSpellCheck();
        }
    }
}
