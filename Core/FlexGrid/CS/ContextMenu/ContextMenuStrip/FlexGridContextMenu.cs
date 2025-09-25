using C1.Win.FlexGrid;

namespace ContextMenu
{
    internal class FlexGridContextMenu : ContextMenuStrip
    {
        private FlexGridEx _flexGrid;
        private readonly List<IGridContextMenuItem> _rowCommands;
        private readonly List<IGridContextMenuItem> _cellCommands;

        public FlexGridContextMenu(FlexGridEx grid)
        {
            _flexGrid = grid;

            var addNewRowGroup = new GridContextMenuItemGroup("Add Row")
              .AddCommand(new GridContextMenuItemAddRowAbove(_flexGrid))
              .AddCommand(new GridContextMenuItemAddRowBelow(_flexGrid));

            var filterGroup = new GridContextMenuItemGroup("Filter", Properties.Resources.filter)
              .AddCommand(new GridContextMenuItemFilterByValue(_flexGrid))
              .AddCommand(new GridContextMenuItemClearFilter(_flexGrid));

            var sortGroup = new GridContextMenuItemGroup("Sort")
              .AddCommand(new GridContextMenuItemSortAscending(_flexGrid))
              .AddCommand(new GridContextMenuItemSortDescending(_flexGrid));

            _rowCommands = new List<IGridContextMenuItem>
            {
                new GridContextMenuItemDeleteRow(_flexGrid),
                addNewRowGroup,
            };

            _cellCommands = new List<IGridContextMenuItem>
            {
                new GridContextMenuItemCut(_flexGrid),
                new GridContextMenuItemCopy(_flexGrid),
                new GridContextMenuItemPaste(_flexGrid),
                new GridContextMenuItemDeleteRow(_flexGrid),

                new GridContextMenuItemSelectAll(_flexGrid),
                new GridContextMenuItemClearContent(_flexGrid),
                new GridContextMenuItemEditCellValue(_flexGrid),

                addNewRowGroup,
                filterGroup,
                sortGroup,
            };

            _flexGrid.MouseDown += OnFlexGridMouseDown;
        }

        private void OnFlexGridMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            var hit = _flexGrid.HitTest(e.X, e.Y);
            if (hit.Row < 0 || hit.Column < 0)
                return;

            var selection = _flexGrid.Selection;
            bool isInSelection = hit.Row >= selection.TopRow && hit.Row <= selection.BottomRow &&
                                 hit.Column >= selection.LeftCol && hit.Column <= selection.RightCol;

            if (hit.Type == HitTestTypeEnum.Cell)
            {
                if (!isInSelection)
                    _flexGrid.Select(hit.Row, hit.Column);

                BuildMenu(_cellCommands);
            }
            else
            {
                if (!(hit.Row >= selection.TopRow && hit.Row <= selection.BottomRow))
                    _flexGrid.Select(hit.Row, 0, hit.Row, _flexGrid.Cols.Count - 1, false);

                BuildMenu(_rowCommands);
            }
        }

        public void BuildMenu(IEnumerable<IGridContextMenuItem> commands)
        {
            Items.Clear();

            foreach (var command in commands)
            {
                if (command is GridContextMenuItemGroup group)
                {
                    var parentItem = CreateMenuItem(group);
                    parentItem.DropDownItems.AddRange(group.Commands.Select(CreateMenuItem).ToArray());
                    Items.Add(parentItem);
                }
                else
                {
                    Items.Add(CreateMenuItem(command));
                }
            }
        }

        private ToolStripMenuItem CreateMenuItem(IGridContextMenuItem command)
        {
            var item = new ToolStripMenuItem(command.Name, command.Icon)
            {
                Enabled = command.Enabled,
                BackColor = Color.White
            };

            item.Click += (_, _) => command.Execute();
            return item;
        }
    }
}
