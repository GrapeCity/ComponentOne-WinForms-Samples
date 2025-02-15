﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RulesManagerExplorer.Samples.Presets
{
    using C1.Win.RulesManager;
    
    #region "Enums"
    public enum ColorScale
    {
        GreenYellowRed,
        RedYellowGreen,
        GreenWhiteRed,
        RedWhiteGreen,
        BlueWhiteRed,
        RedWhiteBlue,
        WhiteRed,
        RedWhite,
        GreenWhite,
        WhiteGreen,
        GreenYellow,
        YellowGreen
    }
    public enum DataBar
    {
        Blue,
        Green,
        Red,
        Orange,
        LightBlue,
        Purple
    }
    public enum Highlight
    {
        LightRedFillWithDarkRedText,
        YellowFillWithDarkYellowText,
        GreenFillWithDarkGreenText,
        LightRedFill,
        RedText,
        RedBorder
    }

    public enum IconSetMode
    {
        ThreeArrows,
        ThreeTriangles,
        FourArrows,
        FiveArrows,
        ThreeTrafficLightsUnrimmed,
        ThreeTrafficLightsRimmed,
        ThreeSigns,
        ThreeSymbolsCircled,
        ThreeSymbolsUncircled,
        ThreeFlags,
        ThreeStars,
        FiveQuarters,
        FiveRatings,
        FiveBoxes
    }

    #endregion

    public class StylePresets
    {
        private static Dictionary<Highlight, ItemStyle> highlightDictionary = null;
        private static Dictionary<DataBar, ItemStyle> gradientDataBarDictionary = null;
        private static Dictionary<DataBar, ItemStyle> solidDataBarDictionary = null;
        private static Dictionary<ColorScale, ItemStyle> colorScaleDictionary = null;
        private static Dictionary<IconSetMode, ItemStyle> iconSetDictionary = null;

        public static Dictionary<Highlight, ItemStyle> Highlights
        {
            get
            {
                if (highlightDictionary == null)
                {
                    highlightDictionary = GetHighlight();
                }

                return highlightDictionary;
            }
        }

        public static Dictionary<DataBar, ItemStyle> GradientDataBars
        {
            get
            {
                if (gradientDataBarDictionary == null)
                {
                    gradientDataBarDictionary = GetDataBarGradient();
                }

                return gradientDataBarDictionary;
            }
        }

        public static Dictionary<DataBar, ItemStyle> SolidDataBars
        {
            get
            {
                if (solidDataBarDictionary == null)
                {
                    solidDataBarDictionary = GetDataBarSolid();
                }

                return solidDataBarDictionary;
            }
        }

        public static Dictionary<ColorScale, ItemStyle> ColorScales
        {
            get
            {
                if (colorScaleDictionary == null)
                {
                    colorScaleDictionary = GetColorScale();
                }

                return colorScaleDictionary;
            }
        }

        public static Dictionary<IconSetMode, ItemStyle> IconSets
        {
            get
            {
                if (iconSetDictionary == null)
                {
                    iconSetDictionary = GetIconSet();
                }

                return iconSetDictionary;
            }
        }

        private static Dictionary<Highlight, ItemStyle> GetHighlight()
        {
            var highlightDictionary = new Dictionary<Highlight, ItemStyle>();

            highlightDictionary[Highlight.LightRedFillWithDarkRedText] = new ItemStyle()
            {
                BackColor = Color.FromArgb(255, 199, 206),
                ForeColor = Color.FromArgb(156, 0, 6)
            };

            highlightDictionary[Highlight.YellowFillWithDarkYellowText] = new ItemStyle()
            {
                BackColor = Color.FromArgb(255, 235, 156),
                ForeColor = Color.FromArgb(156, 87, 0)
            };

            highlightDictionary[Highlight.GreenFillWithDarkGreenText] = new ItemStyle()
            {
                BackColor = Color.FromArgb(198, 239, 206),
                ForeColor = Color.FromArgb(0, 97, 0)
            };

            highlightDictionary[Highlight.LightRedFill] = new ItemStyle()
            {
                BackColor = Color.FromArgb(255, 199, 206)
            };

            highlightDictionary[Highlight.RedText] = new ItemStyle()
            {
                ForeColor = Color.FromArgb(156, 0, 6)
            };

            highlightDictionary[Highlight.RedBorder] = new ItemStyle()
            {
                BorderColor = Color.FromArgb(156, 0, 6)
            };

            return highlightDictionary;
        }

        private static Dictionary<DataBar, ItemStyle> GetDataBarGradient()
        {
            var dataBarGradientDictionary = new Dictionary<DataBar, ItemStyle>();

            dataBarGradientDictionary[DataBar.Blue] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    HistogramColor = Color.FromArgb(99, 142, 198),
                    HistogramPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue),
                        new GradientPoint(GradientPointType.MaxValue)
                    },
                    IsGradientHistogram = true
                }
            };

            dataBarGradientDictionary[DataBar.Green] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    HistogramColor = Color.FromArgb(99, 195, 132),
                    HistogramPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue),
                        new GradientPoint(GradientPointType.MaxValue)
                    },
                    IsGradientHistogram = true
                }
            };

            dataBarGradientDictionary[DataBar.Red] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    HistogramColor = Color.FromArgb(255, 85, 90),
                    HistogramPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue),
                        new GradientPoint(GradientPointType.MaxValue)
                    },
                    IsGradientHistogram = true
                }
            };

            dataBarGradientDictionary[DataBar.Orange] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    HistogramColor = Color.FromArgb(255, 182, 40),
                    HistogramPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue),
                        new GradientPoint(GradientPointType.MaxValue)
                    },
                    IsGradientHistogram = true
                }
            };

            dataBarGradientDictionary[DataBar.LightBlue] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    HistogramColor = Color.FromArgb(0, 138, 239),
                    HistogramPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue),
                        new GradientPoint(GradientPointType.MaxValue)
                    },
                    IsGradientHistogram = true
                }
            };

            dataBarGradientDictionary[DataBar.Purple] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    HistogramColor = Color.FromArgb(214, 0, 123),
                    HistogramPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue),
                        new GradientPoint(GradientPointType.MaxValue)
                    },
                    IsGradientHistogram = true
                }
            };

            return dataBarGradientDictionary;
        }

        private static Dictionary<DataBar, ItemStyle> GetDataBarSolid()
        {
            var dataBarSolidDictionary = new Dictionary<DataBar, ItemStyle>();

            dataBarSolidDictionary[DataBar.Blue] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    HistogramColor = Color.FromArgb(99, 142, 198),
                    HistogramPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue),
                        new GradientPoint(GradientPointType.MaxValue)
                    }
                }
            };

            dataBarSolidDictionary[DataBar.Green] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    HistogramColor = Color.FromArgb(99, 195, 132),
                    HistogramPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue),
                        new GradientPoint(GradientPointType.MaxValue)
                    }
                }
            };

            dataBarSolidDictionary[DataBar.Red] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    HistogramColor = Color.FromArgb(255, 85, 90),
                    HistogramPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue),
                        new GradientPoint(GradientPointType.MaxValue)
                    }
                }
            };

            dataBarSolidDictionary[DataBar.Orange] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    HistogramColor = Color.FromArgb(255, 182, 40),
                    HistogramPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue),
                        new GradientPoint(GradientPointType.MaxValue)
                    }
                }
            };

            dataBarSolidDictionary[DataBar.LightBlue] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    HistogramColor = Color.FromArgb(0, 138, 239),
                    HistogramPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue),
                        new GradientPoint(GradientPointType.MaxValue)
                    }
                }
            };

            dataBarSolidDictionary[DataBar.Purple] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    HistogramColor = Color.FromArgb(214, 0, 123),
                    HistogramPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue),
                        new GradientPoint(GradientPointType.MaxValue)
                    }
                }
            };

            return dataBarSolidDictionary;
        }

        private static Dictionary<ColorScale, ItemStyle> GetColorScale()
        {
            var colorScaleDictionary = new Dictionary<ColorScale, ItemStyle>();

            colorScaleDictionary[ColorScale.GreenYellowRed] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    BackgroundPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue)
                        {
                            Color = Color.FromArgb(248, 105, 107)
                        },
                        new GradientPoint(GradientPointType.Percent)
                        {
                            Color = Color.FromArgb(255, 235, 132),
                            Value = 50.0f
                        },
                        new GradientPoint(GradientPointType.MaxValue)
                        {
                            Color = Color.FromArgb(99, 190, 123)
                        }
                    }
                }
            };

            colorScaleDictionary[ColorScale.RedYellowGreen] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    BackgroundPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue)
                        {
                            Color = Color.FromArgb(99, 190, 123)
                        },
                        new GradientPoint(GradientPointType.Percent)
                        {
                            Color = Color.FromArgb(255, 235, 132),
                            Value = 50.0f
                        },
                        new GradientPoint(GradientPointType.MaxValue)
                        {
                            Color = Color.FromArgb(248, 105, 107)
                        }
                    }
                }
            };

            colorScaleDictionary[ColorScale.GreenWhiteRed] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    BackgroundPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue)
                        {
                            Color = Color.FromArgb(248, 105, 107)
                        },
                        new GradientPoint(GradientPointType.Percent)
                        {
                            Color = Color.FromArgb(252, 252, 255),
                            Value = 50.0f
                        },
                        new GradientPoint(GradientPointType.MaxValue)
                        {
                            Color = Color.FromArgb(99, 190, 123)
                        }
                    }
                }
            };

            colorScaleDictionary[ColorScale.GreenWhiteRed] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    BackgroundPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue)
                        {
                            Color = Color.FromArgb(248, 105, 107)
                        },
                        new GradientPoint(GradientPointType.Percent)
                        {
                            Color = Color.FromArgb(252, 252, 255),
                            Value = 50.0f
                        },
                        new GradientPoint(GradientPointType.MaxValue)
                        {
                            Color = Color.FromArgb(99, 190, 123)
                        }
                    }
                }
            };

            colorScaleDictionary[ColorScale.RedWhiteGreen] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    BackgroundPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue)
                        {
                            Color = Color.FromArgb(99, 190, 123)
                        },
                        new GradientPoint(GradientPointType.Percent)
                        {
                            Color = Color.FromArgb(252, 252, 255),
                            Value = 50.0f
                        },
                        new GradientPoint(GradientPointType.MaxValue)
                        {
                            Color = Color.FromArgb(248, 105, 107)
                        }
                    }
                }
            };

            colorScaleDictionary[ColorScale.BlueWhiteRed] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    BackgroundPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue)
                        {
                            Color = Color.FromArgb(248, 105, 107)
                        },
                        new GradientPoint(GradientPointType.Percent)
                        {
                            Color = Color.FromArgb(252, 252, 255),
                            Value = 50.0f
                        },
                        new GradientPoint(GradientPointType.MaxValue)
                        {
                            Color = Color.FromArgb(90, 138, 198)
                        }
                    }
                }
            };

            colorScaleDictionary[ColorScale.RedWhiteBlue] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    BackgroundPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue)
                        {
                            Color = Color.FromArgb(90, 138, 198)
                        },
                        new GradientPoint(GradientPointType.Percent)
                        {
                            Color = Color.FromArgb(252, 252, 255),
                            Value = 50.0f
                        },
                        new GradientPoint(GradientPointType.MaxValue)
                        {
                            Color = Color.FromArgb(248, 105, 107)
                        }
                    }
                }
            };

            colorScaleDictionary[ColorScale.WhiteRed] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    BackgroundPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue)
                        {
                            Color = Color.FromArgb(248, 105, 107)
                        },
                        new GradientPoint(GradientPointType.MaxValue)
                        {
                            Color = Color.FromArgb(252, 252, 255)
                        }
                    }
                }
            };

            colorScaleDictionary[ColorScale.RedWhite] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    BackgroundPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue)
                        {
                            Color = Color.FromArgb(252, 252, 255)
                        },
                        new GradientPoint(GradientPointType.MaxValue)
                        {
                            Color = Color.FromArgb(248, 105, 107)
                        }
                    }
                }
            };

            colorScaleDictionary[ColorScale.GreenWhite] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    BackgroundPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue)
                        {
                            Color = Color.FromArgb(252, 252, 255)
                        },
                        new GradientPoint(GradientPointType.MaxValue)
                        {
                            Color = Color.FromArgb(99, 190, 123)
                        }
                    }
                }
            };

            colorScaleDictionary[ColorScale.WhiteGreen] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    BackgroundPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue)
                        {
                            Color = Color.FromArgb(99, 190, 123)
                        },
                        new GradientPoint(GradientPointType.MaxValue)
                        {
                            Color = Color.FromArgb(252, 252, 255)
                        }
                    }
                }
            };

            colorScaleDictionary[ColorScale.GreenYellow] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    BackgroundPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue)
                        {
                            Color = Color.FromArgb(255, 239, 156)
                        },
                        new GradientPoint(GradientPointType.MaxValue)
                        {
                            Color = Color.FromArgb(99, 190, 123)
                        }
                    }
                }
            };

            colorScaleDictionary[ColorScale.YellowGreen] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    BackgroundPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue)
                        {
                            Color = Color.FromArgb(99, 190, 123)
                        },
                        new GradientPoint(GradientPointType.MaxValue)
                        {
                            Color = Color.FromArgb(255, 239, 156)
                        }
                    }
                }
            };

            return colorScaleDictionary;
        }

        private static Dictionary<IconSetMode, ItemStyle> GetIconSet()
        {
            var iconSetDictionary = new Dictionary<IconSetMode, ItemStyle>();

            iconSetDictionary[IconSetMode.ThreeArrows] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    IconList = IconListKey.Arrow3,
                    IconPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue),
                        new GradientPoint(GradientPointType.MaxValue)
                    },
                }
            };

            iconSetDictionary[IconSetMode.ThreeTriangles] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    IconList = IconListKey.Triangle,
                    IconPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue),
                        new GradientPoint(GradientPointType.MaxValue)
                    },
                }
            };

            iconSetDictionary[IconSetMode.FourArrows] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    IconList = IconListKey.Arrow4,
                    IconPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue),
                        new GradientPoint(GradientPointType.MaxValue)
                    },
                }
            };

            iconSetDictionary[IconSetMode.FiveArrows] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    IconList = IconListKey.Arrow5,
                    IconPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue),
                        new GradientPoint(GradientPointType.MaxValue)
                    },
                }
            };

            iconSetDictionary[IconSetMode.ThreeTrafficLightsUnrimmed] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    IconList = IconListKey.TrafficLight,
                    IconPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue),
                        new GradientPoint(GradientPointType.MaxValue)
                    },
                }
            };

            iconSetDictionary[IconSetMode.ThreeTrafficLightsRimmed] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    IconList = IconListKey.RimmedTrafficLight,
                    IconPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue),
                        new GradientPoint(GradientPointType.MaxValue)
                    },
                }
            };

            iconSetDictionary[IconSetMode.ThreeSigns] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    IconList = IconListKey.Sign,
                    IconPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue),
                        new GradientPoint(GradientPointType.MaxValue)
                    },
                }
            };

            iconSetDictionary[IconSetMode.ThreeSymbolsCircled] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    IconList = IconListKey.Symbol,
                    IconPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue),
                        new GradientPoint(GradientPointType.MaxValue)
                    },
                }
            };

            iconSetDictionary[IconSetMode.ThreeSymbolsUncircled] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    IconList = IconListKey.UncircledSymbol,
                    IconPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue),
                        new GradientPoint(GradientPointType.MaxValue)
                    },
                }
            };

            iconSetDictionary[IconSetMode.ThreeFlags] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    IconList = IconListKey.Flag,
                    IconPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue),
                        new GradientPoint(GradientPointType.MaxValue)
                    },
                }
            };

            iconSetDictionary[IconSetMode.ThreeStars] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    IconList = IconListKey.Star,
                    IconPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue),
                        new GradientPoint(GradientPointType.MaxValue)
                    },
                }
            };

            iconSetDictionary[IconSetMode.FiveQuarters] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    IconList = IconListKey.Quarter,
                    IconPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue),
                        new GradientPoint(GradientPointType.MaxValue)
                    },
                }
            };

            iconSetDictionary[IconSetMode.FiveRatings] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    IconList = IconListKey.Rating,
                    IconPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue),
                        new GradientPoint(GradientPointType.MaxValue)
                    },
                }
            };

            iconSetDictionary[IconSetMode.FiveBoxes] = new ItemStyle()
            {
                Gradient = new GradientSettings()
                {
                    IconList = IconListKey.Box,
                    IconPoints = new GradientPoint[]
                    {
                        new GradientPoint(GradientPointType.MinValue),
                        new GradientPoint(GradientPointType.MaxValue)
                    },
                }
            };

            return iconSetDictionary;
        }
    }
}
