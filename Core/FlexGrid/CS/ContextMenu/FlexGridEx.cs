using C1.Win.FlexGrid;
using System.ComponentModel;

namespace ContextMenu
{
    internal class FlexGridEx : C1FlexGrid
    {
        FlexGridContextMenu _contextMenuStrip;
        private readonly List<IGridContextMenuItem> _extraColumnCommands;

        public FlexGridEx()
        {
            _contextMenuStrip = new FlexGridContextMenu(this);

            ColumnContextMenuEnabled = true;

            KeyActionTab = KeyActionEnum.MoveAcross;

            ContextMenuStrip = _contextMenuStrip;

            var sortGroup = new GridContextMenuItemGroup("Sort")
              .AddCommand(new GridContextMenuItemSortAscending(this))
              .AddCommand(new GridContextMenuItemSortDescending(this));

            _extraColumnCommands = new List<IGridContextMenuItem>
            {
                new GridContextMenuItemRenameHeader(this),
                sortGroup,
            };

            // command for column header context menu
            ColumnContextMenuOpening += (sender, e) =>
            {
                var hit = HitTest();
                Select(-1, hit.Column, -1, hit.Column, false);

                // Remove first two default items if they exist
                if (e.ContextMenuStrip.Items.Count > 1)
                {
                    e.ContextMenuStrip.Items.RemoveAt(1);
                    e.ContextMenuStrip.Items.RemoveAt(0);
                }

                // Insert Sort Group at index 0
                if (_extraColumnCommands[1] is GridContextMenuItemGroup sortGroup)
                {
                    var sortMenuItem = new ToolStripMenuItem(sortGroup.Name);
                    foreach (var cmd in sortGroup.Commands)
                    {
                        sortMenuItem.DropDownItems.Add(
                            new ToolStripMenuItem(
                                cmd.Name,
                                cmd.Icon,
                                (s, args) => cmd.Execute()
                            )
                        );
                    }
                    e.ContextMenuStrip.Items.Insert(0, sortMenuItem);
                }

                // Insert RenameHeaderCommand at index 1
                if (_extraColumnCommands[0] is IGridContextMenuItem renameCommand)
                {
                    e.ContextMenuStrip.Items.Insert(1,
                        new ToolStripMenuItem(
                            renameCommand.Name,
                            renameCommand.Icon,
                            (s, args) => renameCommand.Execute()
                        )
                    );
                }
            };
        }

        protected override void OnDataRefresh(ListChangedEventArgs e)
        {
            base.OnDataRefresh(e);
            for (int i = this.Rows.Fixed; i < this.Rows.Count; i++)
            {
                this.Rows[i].Caption = (i - this.Rows.Fixed + 1).ToString();
            }
        }   
    }
}
