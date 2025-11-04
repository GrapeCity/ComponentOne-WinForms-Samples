namespace FlexGridExplorer.Core
{
    public interface ISampleNavigator
    {
        void ShowSample(ItemInfo sample);
        void ShowTiles(ItemInfo sample);
        void ChangeView(bool showTiles);
    }
}
