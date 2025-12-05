
using FlexGridExplorer.Component.Input;

namespace FlexGridExplorer.Utility
{
    /// <summary>
    /// Implements a global message filter that dismisses focus from an active <see cref="SearchBar"/>
    /// when the user clicks outside of it.
    /// </summary>
    public class FocusDismissalFilter : IMessageFilter
    {
        #region Private Variables
        const int WM_LBUTTONDOWN = 0x201;//left mouse button is pressed
        const int WM_RBUTTONDOWN = 0x204;//right mouse button is pressed
        const int WM_MBUTTONDOWN = 0x207;//middle mouse button is pressed
        readonly Control _parentControl; 
        #endregion

        public FocusDismissalFilter(Control parentControl)
        {
            _parentControl = parentControl;
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDOWN || m.Msg == WM_RBUTTONDOWN || m.Msg == WM_MBUTTONDOWN)
            {
                var cursorPos = Control.MousePosition;
                if (FindFocusedSearchBar(_parentControl) is SearchBar focusedSearchBar &&
                    !focusedSearchBar.Bounds.Contains(focusedSearchBar.PointToClient(cursorPos)))
                {
                    focusedSearchBar.ClearFocus();
                }
            }
            return false;
        }

        private Control FindFocusedSearchBar(Control parent)
        {
            foreach (Control child in parent.Controls)
            {
                if (child is SearchBar searchBar && searchBar.Focused)
                    return searchBar;

                if (child.HasChildren)
                {
                    var nestedFocused = FindFocusedSearchBar(child);
                    if (nestedFocused != null)
                        return nestedFocused;
                }
            }
            return null;
        }
    }
}
