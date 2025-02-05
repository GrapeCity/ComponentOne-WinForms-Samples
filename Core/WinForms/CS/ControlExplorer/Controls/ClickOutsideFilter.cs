using System.Windows.Forms;

namespace ControlExplorer.Controls
{
    public class ClickOutsideFilter : IMessageFilter
    {
        private const int WM_LBUTTONDOWN = 0x201;
        private const int WM_RBUTTONDOWN = 0x204;
        private const int WM_MBUTTONDOWN = 0x207;

        private readonly Control _parentControl;

        public ClickOutsideFilter(Control parentControl)
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
