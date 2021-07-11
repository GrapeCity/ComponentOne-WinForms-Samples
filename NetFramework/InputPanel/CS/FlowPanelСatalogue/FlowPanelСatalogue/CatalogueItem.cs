using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowPanelСatalogue
{
    class CatalogueItem
    {
        public string Brand { get; set; }

        public string Model { get; set; }
        public System.Drawing.Bitmap ItemImage { get; set;}
        public string Category { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string Cost { get; set; }

        public CatalogueItem(string brand, string model, System.Drawing.Bitmap itemImage, string category, string description, string details, int cost)
        {
            Brand = brand;
            Model = model;
            ItemImage = itemImage;
            Category = category;
            Description = DescriptionToMultiline(description);
            Details = "<a href=\""+ details+"\">" + details + "</a>";
            Cost = "$" + cost.ToString();
        }

        private string DescriptionToMultiline(string longDescription)
        {
            longDescription = longDescription.Split('\n', '.')[0];
            string multiline = "";
            int spaceInd;
            int rowWidth = 30;
            while (longDescription.Length > rowWidth)
            {
                spaceInd = (longDescription.Substring(0, rowWidth)).LastIndexOf(" ");
                if (spaceInd < 0)
                    spaceInd = rowWidth;
                multiline += longDescription.Substring(0, spaceInd) + "\n\r";
                longDescription = longDescription.Substring(spaceInd + 1);
            }
            multiline += longDescription;
            return multiline;
        }
    }
}
