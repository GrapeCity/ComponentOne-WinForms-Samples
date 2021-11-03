using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DashboardNasdaq.Data
{
    class DataService
    {
        public DataService()
        {
        }

        private List<Quote> quotes;

        public List<Quote> GetQuotes()
        {
            if (quotes == null)
            {
                var list = new List<Quote>();
                var asm = Assembly.GetExecutingAssembly();

                using (var stream = asm.GetManifestResourceStream(asm.GetName().Name + ".Resources.data.csv"))
                {
                    using (var sr = new StreamReader(stream))
                    {
                        for (var line = sr.ReadLine(); line != null; line = sr.ReadLine())
                        {
                            if (line.StartsWith("Date"))
                                continue;

                            var fields = line.Split(',');
                            if (fields.Length == 7)
                            {
                                list.Add(new Quote()
                                {
                                    Date = DateTime.Parse(fields[0], CultureInfo.InvariantCulture),
                                    Open = double.Parse(fields[1], CultureInfo.InvariantCulture),
                                    Close = double.Parse(fields[4], CultureInfo.InvariantCulture),
                                    Volume = double.Parse(fields[6], CultureInfo.InvariantCulture)
                                });
                            }
                        }
                    }
                }

                quotes = list;
            }

            return quotes;
        }
    }
}
