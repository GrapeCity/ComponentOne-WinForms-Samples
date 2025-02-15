﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexChartExplorer.Data
{
    public static class Countries
    {
        class Country
        {
            public string Name { get; set; }
            public string Code { get; set; }
        }

        static List<string> _countries;

        public static List<string> GetCountries()
        {
            if (_countries == null)
            {
                var asm = System.Reflection.Assembly.GetExecutingAssembly();
                var stream = asm.GetManifestResourceStream(asm.GetName().Name + ".Resources.countries.json");
                using (var sr = new System.IO.StreamReader(stream))
                {
                    var s = sr.ReadToEnd();
                    var ser = new System.Web.Script.Serialization.JavaScriptSerializer();
                    _countries = ser.Deserialize<Country[]>(s).Select((i) => i.Name).ToList();
                }

            }
            return _countries;
        }
    }
}
