using C1.Win.FlexGrid;

namespace ContextMenu
{
    public class GridContextMenuItemCut : GridContextMenuItemBase
    {
        private readonly C1FlexGrid _grid;

        public GridContextMenuItemCut(C1FlexGrid grid)
            : base("Cut", Properties.Resources.cut)
        {
            _grid = grid;
        }

        public override void Execute()
        {
            _grid.Cut();
        }
    }

    public class GridContextMenuItemCopy : GridContextMenuItemBase
    {
        private readonly C1FlexGrid _grid;

        public GridContextMenuItemCopy(C1FlexGrid grid)
            : base("Copy", Properties.Resources.copy)
        {
            _grid = grid;
        }

        public override void Execute()
        {
            _grid.ClipboardCopyMode = ClipboardCopyModeEnum.DataOnly;
            _grid.Copy();
        }
    }

    public class GridContextMenuItemPaste : GridContextMenuItemBase
    {
        private readonly C1FlexGrid _grid;

        public GridContextMenuItemPaste(C1FlexGrid grid)
            : base("Paste", Properties.Resources.paste)
        {
            _grid = grid;
        }

        public override void Execute()
        {
            _grid.Paste();
        }
    }
   
}
