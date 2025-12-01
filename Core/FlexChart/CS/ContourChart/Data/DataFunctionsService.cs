// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

namespace ContourChart.Data
{
    public class DataFunctionsService
    {
        static int width = 100;
        static int height = 100;
        static double[,] data = new double[width, height];
        static double minValue;
        static double maxValue;

        // List of all the data functions as string
        // Button name will be the string, corresponding method should be "<name_without_spaces>Data"
        public static string[] dataFunctions = new string[] { "Monkey Saddle", "Sinx Cosy", "Multi Peak", "Ripples" };

        public static TwoDDataItem MonkeySaddleData()
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    // Center the coordinates
                    double xc = x - width / 2.0;
                    double yc = y - height / 2.0;

                    // Monkey saddle equation: z = x³ - 3xy²
                    data[x, y] = (xc * xc * xc - 3 * xc * yc * yc) * 100;

                    // set initial min and max value, can't be 0.
                    if (x == 0 && y == 0)
                    {
                        maxValue = data[0, 0];
                        minValue = data[0, 0];
                    }

                    // Track min and max values
                    minValue = Math.Min(minValue, data[x, y]);
                    maxValue = Math.Max(maxValue, data[x, y]);
                }
            }

            return new TwoDDataItem
            {
                Values = data,
                Min = minValue,
                Max = maxValue
            };
        }

        public static TwoDDataItem SinxCosyData()
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    // Scale factors to control the frequency of the waves
                    double xScale = 0.2;
                    double yScale = 0.2;

                    // Generate the wave pattern
                    data[x, y] = (Math.Sin(xScale * x) + Math.Cos(yScale * y)) * 10;

                    // set initial min and max value, can't be 0.
                    if (x == 0 && y == 0)
                    {
                        maxValue = data[0, 0];
                        minValue = data[0, 0];
                    }

                    // Track min and max values
                    minValue = Math.Min(minValue, data[x, y]);
                    maxValue = Math.Max(maxValue, data[x, y]);
                }
            }

            return new TwoDDataItem
            {
                Values = data,
                Min = minValue,
                Max = maxValue
            };
        }

        public static TwoDDataItem MultiPeakData()
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    // Generate the peak pattern
                    data[x, y] = Math.Sin(x) + Math.Sin(y) + 0.1 * (Math.Pow(x, 2) + Math.Pow(y, 2));

                    // set initial min and max value, can't be 0.
                    if (x == 0 && y == 0)
                    {
                        maxValue = data[0, 0];
                        minValue = data[0, 0];
                    }

                    // Track min and max values
                    minValue = Math.Min(minValue, data[x, y]);
                    maxValue = Math.Max(maxValue, data[x, y]);
                }
            }

            return new TwoDDataItem
            {
                Values = data,
                Min = minValue,
                Max = maxValue
            };
        }

        public static TwoDDataItem RipplesData()
        {
            // Scale factors to control the frequency of the waves
            double xScale = 0.25;
            double yScale = 0.25;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    // Generate the ripples pattern
                    data[x, y] = Math.Sin((Math.Pow(x * xScale, 2) + Math.Pow(y * yScale, 2)));

                    // set initial min and max value, can't be 0.
                    if (x == 0 && y == 0)
                    {
                        maxValue = data[0, 0];
                        minValue = data[0, 0];
                    }

                    // Track min and max values
                    minValue = Math.Min(minValue, data[x, y]);
                    maxValue = Math.Max(maxValue, data[x, y]);
                }
            }

            return new TwoDDataItem
            {
                Values = data,
                Min = minValue,
                Max = maxValue
            };
        }
    }
}
