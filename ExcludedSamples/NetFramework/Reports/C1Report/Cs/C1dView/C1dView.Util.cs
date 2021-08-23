/*
 * This file is part of C1Report's C1dView sample.
 * 
 * This file contains miscellaneous utility types.
 * 
 * Copyright GrapeCity, Inc.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using C1.C1Preview;
using C1.Win.C1Preview;

namespace C1dView
{
    /// <summary>
    /// General purpose "pair" class.
    /// </summary>
    /// <typeparam name="T1">First type.</typeparam>
    /// <typeparam name="T2">Second type.</typeparam>
    [Serializable]
    public class Pair<T1, T2>
    {
        public T1 First { get; set; }
        public T2 Second { get; set; }
        public Pair()
        {
            First = default(T1);
            Second = default(T2);
        }
        public Pair(T1 first, T2 second)
        {
            First = first;
            Second = second;
        }
    }

    /// <summary>
    /// Utility class implementing find text functionality.
    /// This class maintains a current state so that operations such as "find next"
    /// can be supported.
    /// </summary>
    public class FindHelper
    {
        #region private data
        private C1TextSearchArgs _findArgs = null;
        private C1TextFragment[] _finds = null;
        private int _findCurrent = -1;
        #endregion

        #region public properties
        /// <summary>
        /// Gets the preview pane associated with this find helper.
        /// </summary>
        public C1PreviewPane PreviewPane { get; private set; }

        /// <summary>
        /// Gets a value indicating whether an occurrence of the current search text
        /// can be found below the current occurrence.
        /// </summary>
        public bool HasNext
        {
            get { return _finds != null && _findCurrent + 1 < _finds.Length; }
        }

        /// <summary>
        /// Gets a value indicating whether an occurrence of the current search text
        /// can be found above the current occurrence.
        /// </summary>
        public bool HasPrev
        {
            get { return _finds != null && _findCurrent > 0; }
        }
        #endregion

        #region ctor
        /// <summary>
        /// Initializes a new instance of the find helper.
        /// </summary>
        /// <param name="previewPane">The preview pane associated with this instance.</param>
        public FindHelper(C1PreviewPane previewPane)
        {
            PreviewPane = previewPane;
        }
        #endregion

        #region public methods
        /// <summary>
        /// Searches for all occurrences of a text in the preview pane.
        /// Highlights the first occurrence and ensures that it is shown in the preview.
        /// </summary>
        /// <param name="text">The search text.</param>
        /// <param name="matchCase">Indicates whether to perform a case-sensitive search.</param>
        /// <returns>True if at least one occurrence was found, false otherwise.</returns>
        public bool Find(string text, bool matchCase)
        {
            if (string.IsNullOrEmpty(text))
                return false;

            _findArgs = new C1TextSearchArgs();
            _findArgs.Text = text;
            _findArgs.IgnoreCase = !matchCase;
            _finds = PreviewPane.TextSearchAll(_findArgs);
            _findCurrent = _finds != null && _finds.Length > 0 ? 0 : -1;
            if (_findCurrent != -1)
            {
                PreviewPane.SelectTextFragment(_finds[_findCurrent]);
                PreviewPane.GoToSelection();
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Searches for the next occurrence of a text in the preview pane.
        /// Highlights the found occurrence and ensures that it is shown in the preview.
        /// If there are no more occurrences of the search text in the specified direction,
        /// wraps to the beginning or end of the document.
        /// </summary>
        /// <param name="text">The search text.</param>
        /// <param name="matchCase">Indicates whether to perform a case-sensitive search.</param>
        /// <param name="up">Indicates whether to search up or down in the document.</param>
        /// <returns>True if the next occurrence was found, false otherwise.</returns>
        public bool FindNext(string text, bool matchCase, bool up)
        {
            if (_finds == null || _finds.Length == 0)
                return Find(text, matchCase);
            else
            {
                if (!up)
                {
                    ++_findCurrent;
                    if (_findCurrent >= _finds.Length)
                        _findCurrent = 0;
                }
                else
                {
                    --_findCurrent;
                    if (_findCurrent < 0)
                        _findCurrent = _finds.Length - 1;
                }
                if (_findCurrent >= 0 && _findCurrent < _finds.Length)
                {
                    PreviewPane.SelectTextFragment(_finds[_findCurrent]);
                    PreviewPane.GoToSelection();
                    return true;
                }
                else
                    return false;
            }
        }
        #endregion
    }
}
