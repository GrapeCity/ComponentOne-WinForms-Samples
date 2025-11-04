namespace FlexGridExplorer.Core
{
    public interface ITileImageGenerator
    {
        Image GetImage(ItemInfo sample, Size imageSize);
    }
}
