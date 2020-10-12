using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using C1.Data.Entities;

namespace Orders
{
    public partial class NORTHWNDEntities
    {
        EntityClientCache _clientCache;
        public EntityClientCache ClientCache
        {
            get
            {
                if (_clientCache == null)
                    _clientCache = new EntityClientCache(this);
                return _clientCache;
            }
        }

        public IEnumerable<string> Cities
        {
            get { return (from c in Customers select c.City).Distinct(); }
        }

        public IEnumerable<string> Countries
        {
            get { return (from c in Customers select c.Country).Distinct(); }
        }
    }
}
