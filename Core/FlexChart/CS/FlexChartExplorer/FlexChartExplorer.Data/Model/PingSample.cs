using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlexChartExplorer.Data
{
    public class PingSample
    {
        public DateTime Timestamp { get; set; }
        public double? LatencyMs { get; set; } // null = timeout / packet loss
    }

    public class PingSampleProfile
    {
        public double BaseLatencyMs { get; set; }
        public double JitterMs { get; set; }
        public double SpikeChance { get; set; }
        public double PacketLossChance { get; set; }
    }
}
