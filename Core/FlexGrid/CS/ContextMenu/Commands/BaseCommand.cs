namespace ContextMenu
{
    public interface IGridContextMenuItem
    {
        string Name { get; }
        Image Icon { get; }
        bool Enabled { get; }
        void Execute();
    }

    public abstract class GridContextMenuItemBase : IGridContextMenuItem
    {
        public string Name { get; set; }
        public Image Icon { get; set; }
        public virtual bool Enabled => true;
        public abstract void Execute();
        protected GridContextMenuItemBase(string name, Image icon)
        {
            Name = name;
            Icon = icon;
        }
    }
}
