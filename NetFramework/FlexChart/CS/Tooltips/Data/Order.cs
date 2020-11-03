using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tooltips.Data
{
    class Order
    {
        public int OrderId
        { get; set; }
        public double Amount
        { get; set; }
        public string ShippedCountry
        { get; set; }
        public DateTime OrderDate
        { get; set; }
    }

    class FlexPoint
    {
        public string XValue
        { get; set; }
        public double YValue
        { get; set; }
    }
}
