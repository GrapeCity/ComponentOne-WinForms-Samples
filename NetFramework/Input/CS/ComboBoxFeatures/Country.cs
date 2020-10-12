using System;
using System.Collections.Generic;
using System.Text;

namespace ComboBoxFeatures
{
    public class Country
    {
        public Country(int code, string name)
        {
            Code = code;
            Name = name;
        }
        public int Code { get; set; }
        public string Name { get; set; }

    }
}
