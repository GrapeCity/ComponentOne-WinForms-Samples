using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1.Win.Chart.Designer.Data
{
    enum MeasureType
    {
        Number,
        Date
    }

    class Field
    {
        public string Name { get; set; }
    }

    class Measure : Field
    {
        public MeasureType Type { get; set; }
    }

    class Category : Field
    {
    }
}
