// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

namespace ContourChart.Data
{
    public class TwoDDataItem
    {
        public double[,] Values { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        public string[] CatXData { get; set; }
        public string[] CatYData { get; set; }
        public TwoDDataItem() { }
        public TwoDDataItem(double[,] values, string[] catX, string[] catY)
        {
            Values = values;
            CatXData = catX;
            CatYData = catY;
        }
    }
}
