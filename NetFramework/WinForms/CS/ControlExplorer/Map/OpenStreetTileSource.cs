using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlExplorer.Map
{
    class OpenStreetTileSource : C1.FlexMap.ITileSource
    {
        private const string UrlTemplate = "http://tile.openstreetmap.org/{0}/{1}/{2}.png";

        public void GetTile(int level, int x, int y, out string url, out object image)
        {
            image = null;
            url = string.Format(UrlTemplate, level, x, y);
        }

        public int TileWidth { get { return 256; } }
        public int TileHeight { get { return 256; } }
    }
}
