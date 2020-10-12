using System;
using System.Windows;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ControlExplorer.Chart.Data
{
    public class DrillDataPoints
    {
        //-----------------------------------------------------------------
        #region ** ctor

        public DrillDataPoints(int count)
        {
            Temperature = new double[count];
            Pressure = new double[count];
            Conductivity = new double[count];
            Ph = new double[count];
            Depth = new double[count];
        }

        #endregion

        //-----------------------------------------------------------------
        #region ** object model

        public double[] Temperature { get; set; }
        public double[] Pressure { get; set; }
        public double[] Conductivity { get; set; }
        public double[] Ph { get; set; }
        public double[] Depth { get; set; }

        public string[] GetSeriesNames()
        {
            return "Temperature|Pressure|Conductivity|Ph".Split('|');
        }
        public Color GetSeriesColor(string name)
        {
            switch (name)
            {
                case "Temperature": return Color.FromArgb(0xff, 0x9C, 0x00, 0x7F);
                case "Pressure": return Color.FromArgb(0xff, 0x2A, 0x02, 0x99);
                case "Conductivity": return Color.FromArgb(0xff, 0x00, 0x72, 0xA0);
                case "Ph": return Color.FromArgb(0xff, 0x71, 0x9A, 0x0B);
            }
            throw new Exception("Invalid data request");
        }
        public double[] GetSeriesData(string name)
        {
            switch (name)
            {
                case "Temperature": return Temperature;
                case "Pressure": return Pressure;
                case "Conductivity": return Conductivity;
                case "Ph": return Ph;
            }
            throw new Exception("Invalid data request");
        }

        #endregion

        //-----------------------------------------------------------------
        #region ** scale values so they can be seen when plotted together
        
        public void ScaleValues()
        {
            double max, min;
            GetRange(Temperature, out max, out min);
            ScaleValues(Pressure, max, min);
            ScaleValues(Conductivity, max, min);
            ScaleValues(Ph, max, min);
        }
        void GetRange(double[] values, out double max, out double min)
        {
            max = values[0];
            min = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                max = Math.Max(max, values[i]);
                min = Math.Min(min, values[i]);
            }
        }
        void ScaleValues(double[] values, double max, double min)
        {
            double rmax, rmin;
            GetRange(values, out rmax, out rmin);
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = (values[i] - rmin) / (rmax - rmin) * (max - min) + min;
            }
        }

        #endregion
    }
}
