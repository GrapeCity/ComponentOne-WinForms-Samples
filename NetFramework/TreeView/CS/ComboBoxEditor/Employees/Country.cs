using System.Collections;
using System.Collections.Generic;

namespace SamplesData
{
    public class Country
    {
        public static IDictionary GetCountries()
        {
            var res = new Dictionary<int, string>();
            res.Add(0, "Japan");
            res.Add(1, "USA");
            res.Add(2, "China");
            res.Add(3, "Germany");
            return res;
        }

    }
}
