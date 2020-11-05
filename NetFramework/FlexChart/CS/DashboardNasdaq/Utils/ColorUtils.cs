using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices.ComTypes;

namespace DashboardNasdaq.Utils
{
    class ColorUtils
    {
        public static Color Interpolate(Color c1, Color c2, float pct)
        {
            if (pct < 0)
                pct = 0;
            else if (pct > 1)
                pct = 1;

            var qct = 1 - pct;
            var h = c1.GetHue() * qct + c2.GetHue() * pct;
            var s = c1.GetSaturation() * qct + c2.GetSaturation() * pct;
            var l = c1.GetBrightness() * qct + c2.GetBrightness() * pct;
            var a = c1.A * qct + c2.A * pct;

            return hslToColor(h / 360f, s, l, a);
        }

        public static Color InterpolateRgb(Color c1, Color c2, float pct)
        {
            if (pct < 0)
                pct = 0;
            else if (pct > 1)
                pct = 1;

            var qct = 1 - pct;
            var r = c1.R * qct + c2.R * pct;
            var g = c1.G * qct + c2.G * pct;
            var b = c1.B * qct + c2.B * pct;
            var a = c1.A * qct + c2.A * pct;

            return Color.FromArgb((int)a, (int)Math.Round(r), (int)Math.Round(g), (int)Math.Round(b));
        }


        static Color hslToColor(double h, double s, double l, double a)
        {
            double r, g, b;
            if (s == 0)
            {
                r = g = b = l; // achromatic
            }
            else
            {
                var q = l < 0.5 ? l * (1 + s) : l + s - l * s;
                var p = 2 * l - q;
                r = hue2rgb(p, q, h + 1.0 / 3);
                g = hue2rgb(p, q, h);
                b = hue2rgb(p, q, h - 1.0 / 3);
            }

            return Color.FromArgb( (int)a, (int)Math.Round(r * 255), (int)Math.Round(g * 255), (int)Math.Round(b * 255));
        }

        static double hue2rgb(double p, double q, double t)
        {
            if (t < 0) t += 1;
            if (t > 1) t -= 1;
            if (t < 1.0 / 6) return p + (q - p) * 6 * t;
            if (t < 1.0 / 2) return q;
            if (t < 2.0 / 3) return p + (q - p) * (2.0 / 3 - t) * 6;
            return p;
        }


        public static Color HSL_to_RGB(float h, float s, float l, float a)
        {

            double r = 0, g = 0, b = 0;
            double temp1, temp2;



            if (l == 0)

            {

                r = g = b = 0;

            }

            else

            {

                if (s == 0)

                {

                    r = g = b = l;

                }

                else

                {

                    temp2 = ((l <= 0.5) ? l * (1.0 + s) : l + s - (l * s));

                    temp1 = 2.0 * l - temp2;



                    double[] t3 = new double[] { h + 1.0 / 3.0, h, h - 1.0 / 3.0 };

                    double[] clr = new double[] { 0, 0, 0 };

                    for (int i = 0; i < 3; i++)

                    {

                        if (t3[i] < 0)

                            t3[i] += 1.0;

                        if (t3[i] > 1)

                            t3[i] -= 1.0;



                        if (6.0 * t3[i] < 1.0)

                            clr[i] = temp1 + (temp2 - temp1) * t3[i] * 6.0;

                        else if (2.0 * t3[i] < 1.0)

                            clr[i] = temp2;

                        else if (3.0 * t3[i] < 2.0)

                            clr[i] = (temp1 + (temp2 - temp1) * ((2.0 / 3.0) - t3[i]) * 6.0);

                        else

                            clr[i] = temp1;

                    }

                    r = clr[0];

                    g = clr[1];

                    b = clr[2];

                }

            }

            return Color.FromArgb((int)a, (int)(255 * r), (int)(255 * g), (int)(255 * b));

        }
    }
}
