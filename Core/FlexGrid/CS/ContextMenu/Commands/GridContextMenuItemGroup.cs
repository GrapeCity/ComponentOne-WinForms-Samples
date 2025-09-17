namespace ContextMenu
{
    public class GridContextMenuItemGroup : IGridContextMenuItem
    {
        public string Name { get; }
        public Image Icon { get; set; }
        public bool Enabled => true;

        public List<IGridContextMenuItem> Commands { get; } = new List<IGridContextMenuItem>();

        public GridContextMenuItemGroup(string name, Image icon = null)
        {
            Name = name;
            Icon = icon;
        }

        public void Execute()
        {
            // Group commands don't execute, they contain subcommands
        }

        public GridContextMenuItemGroup AddCommand(IGridContextMenuItem command)
        {
            Commands.Add(command);
            return this;
        }
    }
}
