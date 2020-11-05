using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DashboardNasdaq.Data
{
    static class Extensions
    {
        public static int GetQuarter(this DateTime date)
        {
            if (date.Month <= 3)
                return 1;
            else if (date.Month <= 6)
                return 2;
            else if (date.Month <= 9)
                return 3;
            else
                return 4;
        }
    }
}
