using System;
using System.Collections.Generic;
using System.Text;

namespace GanttViewScheduler
{
    public static class IdGenerator
    {
        private static HashSet<int> _ids = new HashSet<int>();
        public static int NewId
        {
            get
            {
                int id; Random rnd = new Random();
                do id = rnd.Next();
                while (_ids.Contains(id));
                NewId = id;
                return id;
            }
            set
            {
                if (!_ids.Contains(value))
                    _ids.Add(value);
            }
        }
    }
}
