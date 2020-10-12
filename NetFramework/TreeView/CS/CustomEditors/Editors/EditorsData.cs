using System;
using System.ComponentModel;
using System.Drawing;

namespace SamplesData.Editors
{
    public class EditorsData
    {
        public string TextValue
        {
            get; set;
        }

        public object ObjectValue
        {
            get; set;
        }

        public Color ColorValue
        {
            get; set;
        }

        public DateTime DateValue
        {
            get; set;
        }

        public BindingList<EditorsData> Collection
        { get; set; }

        public EditorsData()
        {
            Collection = new BindingList<EditorsData>();
        }

        public static BindingList<EditorsData> GetData()
        {
            var data = new BindingList<EditorsData>();
            for (int i = 0; i < 5; i++)
            {
                data.Add(new EditorsData() { TextValue = i.ToString(), ObjectValue = i, ColorValue = Color.Black, DateValue = DateTime.Now });
                for (int j = 0; j < 5; j++)
                {
                    data[i].Collection.Add(new EditorsData() { TextValue = (i + j).ToString(), ObjectValue = i + j, ColorValue = Color.White, DateValue = DateTime.Now });
                }
            }

            return data;
        }
    }
}
