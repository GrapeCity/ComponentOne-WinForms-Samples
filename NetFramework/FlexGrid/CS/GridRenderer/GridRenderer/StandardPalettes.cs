using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;

namespace GridRenderer
{
    /// <summary>
    /// Static class that provides the standard Office2007 color palettes.
    /// </summary>
    static class StandardPalletes
    {
        public static Color[] Office2007Blue
        {
            get
            {
                return new Color[]
                {
                    Color.FromArgb(234,236,245), Color.FromArgb(208,215,229),
                    Color.FromArgb(169,196,233), Color.FromArgb(249,250,251), Color.FromArgb(215,218,226),

                    Color.FromArgb(249,252,253), Color.FromArgb(211,219,233), Color.FromArgb(158,182,206),
                    Color.FromArgb(249,217,159), Color.FromArgb(241,193,95),  Color.FromArgb(242,149,53),
                    Color.FromArgb(221,224,227), Color.FromArgb(188,197,210), Color.FromArgb(135,159,183),
                    Color.FromArgb(255,213,141), Color.FromArgb(242,146,59),  Color.FromArgb(242,146,59),

                    Color.FromArgb(228,236,247), Color.FromArgb(158,182,206),
                    Color.FromArgb(255,213,141), Color.FromArgb(242,149,53),
                    Color.FromArgb(187,196,209), Color.FromArgb(135,159,183),
                    Color.FromArgb(241,192,92),  Color.FromArgb(242,149,53)
                };
            }
        }
        public static Color[] Office2007Black
        {
            get
            {
                return new Color[] 
                {
                    Color.FromArgb(234,236,245), Color.FromArgb(208,215,229),
                    Color.FromArgb(201,201,201), Color.FromArgb(173,173,173), Color.FromArgb(103,103,103),

                    Color.FromArgb(248,248,248), Color.FromArgb(222,222,222), Color.FromArgb(182,182,182),
                    Color.FromArgb(249,217,159), Color.FromArgb(241,193,95),  Color.FromArgb(242,149,53),
                    Color.FromArgb(224,224,224), Color.FromArgb(195,195,195), Color.FromArgb(182,182,182),
                    Color.FromArgb(255,213,141), Color.FromArgb(242,146,59),  Color.FromArgb(242,149,53),

                    Color.FromArgb(237,237,237), Color.FromArgb(182,182,182),
                    Color.FromArgb(255,213,141), Color.FromArgb(242,149,53),
                    Color.FromArgb(241,192,92),  Color.FromArgb(182,182,182),
                    Color.FromArgb(241,192,92),  Color.FromArgb(242,149,53)
                };
            }
        }
        public static Color[] Office2007Silver
        {
            get 
            {
                return new Color[]
                {
                    Color.FromArgb(234,236,245), Color.FromArgb(208,215,229),
                    Color.FromArgb(198,198,198), Color.FromArgb(253,253,253), Color.FromArgb(239,239,239),

                    Color.FromArgb(241,243,243), Color.FromArgb(202,203,204), Color.FromArgb(144,145,146),
                    Color.FromArgb(255,204,153), Color.FromArgb(255,155,103), Color.FromArgb(212,118,61),
                    Color.FromArgb(208,208,208), Color.FromArgb(166,166,166), Color.FromArgb(166,166,166),
                    Color.FromArgb(215,215,215), Color.FromArgb(164,164,164), Color.FromArgb(212,118,61),

                    Color.FromArgb(231,231,231), Color.FromArgb(144,145,146),
                    Color.FromArgb(245,199,149), Color.FromArgb(212,118,61),
                    Color.FromArgb(184,191,196), Color.FromArgb(157,163,169),
                    Color.FromArgb(237,139,78),  Color.FromArgb(212,118,61)
                };
            }
        }
    }
}
