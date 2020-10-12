Imports C1.Win.RulesManager

Public Class StylePresets
    Private Shared highlightDictionary As Dictionary(Of Highlight, ItemStyle) = Nothing
    Private Shared gradientDataBarDictionary As Dictionary(Of DataBar, ItemStyle) = Nothing
    Private Shared solidDataBarDictionary As Dictionary(Of DataBar, ItemStyle) = Nothing
    Private Shared colorScaleDictionary As Dictionary(Of ColorScale, ItemStyle) = Nothing
    Private Shared iconSetDictionary As Dictionary(Of IconSet, ItemStyle) = Nothing

    Public Shared ReadOnly Property Highlights As Dictionary(Of Highlight, ItemStyle)
        Get

            If highlightDictionary Is Nothing Then
                highlightDictionary = GetHighlight()
            End If

            Return highlightDictionary
        End Get
    End Property

    Public Shared ReadOnly Property GradientDataBars As Dictionary(Of DataBar, ItemStyle)
        Get

            If gradientDataBarDictionary Is Nothing Then
                gradientDataBarDictionary = GetDataBarGradient()
            End If

            Return gradientDataBarDictionary
        End Get
    End Property

    Public Shared ReadOnly Property SolidDataBars As Dictionary(Of DataBar, ItemStyle)
        Get

            If solidDataBarDictionary Is Nothing Then
                solidDataBarDictionary = GetDataBarSolid()
            End If

            Return solidDataBarDictionary
        End Get
    End Property

    Public Shared ReadOnly Property ColorScales As Dictionary(Of ColorScale, ItemStyle)
        Get

            If colorScaleDictionary Is Nothing Then
                colorScaleDictionary = GetColorScale()
            End If

            Return colorScaleDictionary
        End Get
    End Property

    Public Shared ReadOnly Property IconSets As Dictionary(Of IconSet, ItemStyle)
        Get

            If iconSetDictionary Is Nothing Then
                iconSetDictionary = GetIconSet()
            End If

            Return iconSetDictionary
        End Get
    End Property

    Private Shared Function GetHighlight() As Dictionary(Of Highlight, ItemStyle)
        Dim highlightDictionary = New Dictionary(Of Highlight, ItemStyle)()

        highlightDictionary(Highlight.LightRedFillWithDarkRedText) = New ItemStyle() With {
            .BackColor = Color.FromArgb(255, 199, 206),
            .ForeColor = Color.FromArgb(156, 0, 6)
        }

        highlightDictionary(Highlight.YellowFillWithDarkYellowText) = New ItemStyle() With {
            .BackColor = Color.FromArgb(255, 235, 156),
            .ForeColor = Color.FromArgb(156, 87, 0)
        }

        highlightDictionary(Highlight.GreenFillWithDarkGreenText) = New ItemStyle() With {
            .BackColor = Color.FromArgb(198, 239, 206),
            .ForeColor = Color.FromArgb(0, 97, 0)
        }

        highlightDictionary(Highlight.LightRedFill) = New ItemStyle() With {
            .BackColor = Color.FromArgb(255, 199, 206)
        }

        highlightDictionary(Highlight.RedText) = New ItemStyle() With {
            .ForeColor = Color.FromArgb(156, 0, 6)
        }

        highlightDictionary(Highlight.RedBorder) = New ItemStyle() With {
            .BorderColor = Color.FromArgb(156, 0, 6)
        }

        Return highlightDictionary
    End Function

    Private Shared Function GetDataBarGradient() As Dictionary(Of DataBar, ItemStyle)
        Dim dataBarGradientDictionary = New Dictionary(Of DataBar, ItemStyle)()

        dataBarGradientDictionary(DataBar.Blue) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .HistogramColor = Color.FromArgb(99, 142, 198),
                .HistogramPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue), New GradientPoint(GradientPointType.MaxValue)},
                .IsGradientHistogram = True
            }
        }

        dataBarGradientDictionary(DataBar.Green) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .HistogramColor = Color.FromArgb(99, 195, 132),
                .HistogramPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue), New GradientPoint(GradientPointType.MaxValue)},
                .IsGradientHistogram = True
            }
        }

        dataBarGradientDictionary(DataBar.Red) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .HistogramColor = Color.FromArgb(255, 85, 90),
                .HistogramPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue), New GradientPoint(GradientPointType.MaxValue)},
                .IsGradientHistogram = True
            }
        }

        dataBarGradientDictionary(DataBar.Orange) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .HistogramColor = Color.FromArgb(255, 182, 40),
                .HistogramPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue), New GradientPoint(GradientPointType.MaxValue)},
                .IsGradientHistogram = True
            }
        }

        dataBarGradientDictionary(DataBar.LightBlue) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .HistogramColor = Color.FromArgb(0, 138, 239),
                .HistogramPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue), New GradientPoint(GradientPointType.MaxValue)},
                .IsGradientHistogram = True
            }
        }

        dataBarGradientDictionary(DataBar.Purple) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .HistogramColor = Color.FromArgb(214, 0, 123),
                .HistogramPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue), New GradientPoint(GradientPointType.MaxValue)},
                .IsGradientHistogram = True
            }
        }

        Return dataBarGradientDictionary
    End Function

    Private Shared Function GetDataBarSolid() As Dictionary(Of DataBar, ItemStyle)
        Dim dataBarSolidDictionary = New Dictionary(Of DataBar, ItemStyle)()

        dataBarSolidDictionary(DataBar.Blue) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .HistogramColor = Color.FromArgb(99, 142, 198),
                .HistogramPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue), New GradientPoint(GradientPointType.MaxValue)}
            }
        }

        dataBarSolidDictionary(DataBar.Green) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .HistogramColor = Color.FromArgb(99, 195, 132),
                .HistogramPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue), New GradientPoint(GradientPointType.MaxValue)}
            }
        }

        dataBarSolidDictionary(DataBar.Red) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .HistogramColor = Color.FromArgb(255, 85, 90),
                .HistogramPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue), New GradientPoint(GradientPointType.MaxValue)}
            }
        }

        dataBarSolidDictionary(DataBar.Orange) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .HistogramColor = Color.FromArgb(255, 182, 40),
                .HistogramPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue), New GradientPoint(GradientPointType.MaxValue)}
            }
        }

        dataBarSolidDictionary(DataBar.LightBlue) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .HistogramColor = Color.FromArgb(0, 138, 239),
                .HistogramPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue), New GradientPoint(GradientPointType.MaxValue)}
            }
        }

        dataBarSolidDictionary(DataBar.Purple) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .HistogramColor = Color.FromArgb(214, 0, 123),
                .HistogramPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue), New GradientPoint(GradientPointType.MaxValue)}
            }
        }

        Return dataBarSolidDictionary
    End Function

    Private Shared Function GetColorScale() As Dictionary(Of ColorScale, ItemStyle)
        Dim colorScaleDictionary = New Dictionary(Of ColorScale, ItemStyle)()

        colorScaleDictionary(ColorScale.GreenYellowRed) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .BackgroundPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue) With {
                    .Color = Color.FromArgb(248, 105, 107)
                }, New GradientPoint(GradientPointType.Percent) With {
                    .Color = Color.FromArgb(255, 235, 132),
                    .Value = 50.0F
                }, New GradientPoint(GradientPointType.MaxValue) With {
                    .Color = Color.FromArgb(99, 190, 123)
                }}
            }
        }

        colorScaleDictionary(ColorScale.RedYellowGreen) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .BackgroundPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue) With {
                    .Color = Color.FromArgb(99, 190, 123)
                }, New GradientPoint(GradientPointType.Percent) With {
                    .Color = Color.FromArgb(255, 235, 132),
                    .Value = 50.0F
                }, New GradientPoint(GradientPointType.MaxValue) With {
                    .Color = Color.FromArgb(248, 105, 107)
                }}
            }
        }

        colorScaleDictionary(ColorScale.GreenWhiteRed) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .BackgroundPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue) With {
                    .Color = Color.FromArgb(248, 105, 107)
                }, New GradientPoint(GradientPointType.Percent) With {
                    .Color = Color.FromArgb(252, 252, 255),
                    .Value = 50.0F
                }, New GradientPoint(GradientPointType.MaxValue) With {
                    .Color = Color.FromArgb(99, 190, 123)
                }}
            }
        }

        colorScaleDictionary(ColorScale.GreenWhiteRed) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .BackgroundPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue) With {
                    .Color = Color.FromArgb(248, 105, 107)
                }, New GradientPoint(GradientPointType.Percent) With {
                    .Color = Color.FromArgb(252, 252, 255),
                    .Value = 50.0F
                }, New GradientPoint(GradientPointType.MaxValue) With {
                    .Color = Color.FromArgb(99, 190, 123)
                }}
            }
        }

        colorScaleDictionary(ColorScale.RedWhiteGreen) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .BackgroundPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue) With {
                    .Color = Color.FromArgb(99, 190, 123)
                }, New GradientPoint(GradientPointType.Percent) With {
                    .Color = Color.FromArgb(252, 252, 255),
                    .Value = 50.0F
                }, New GradientPoint(GradientPointType.MaxValue) With {
                    .Color = Color.FromArgb(248, 105, 107)
                }}
            }
        }

        colorScaleDictionary(ColorScale.BlueWhiteRed) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .BackgroundPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue) With {
                    .Color = Color.FromArgb(248, 105, 107)
                }, New GradientPoint(GradientPointType.Percent) With {
                    .Color = Color.FromArgb(252, 252, 255),
                    .Value = 50.0F
                }, New GradientPoint(GradientPointType.MaxValue) With {
                    .Color = Color.FromArgb(90, 138, 198)
                }}
            }
        }

        colorScaleDictionary(ColorScale.RedWhiteBlue) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .BackgroundPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue) With {
                    .Color = Color.FromArgb(90, 138, 198)
                }, New GradientPoint(GradientPointType.Percent) With {
                    .Color = Color.FromArgb(252, 252, 255),
                    .Value = 50.0F
                }, New GradientPoint(GradientPointType.MaxValue) With {
                    .Color = Color.FromArgb(248, 105, 107)
                }}
            }
        }

        colorScaleDictionary(ColorScale.WhiteRed) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .BackgroundPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue) With {
                    .Color = Color.FromArgb(248, 105, 107)
                }, New GradientPoint(GradientPointType.MaxValue) With {
                    .Color = Color.FromArgb(252, 252, 255)
                }}
            }
        }

        colorScaleDictionary(ColorScale.RedWhite) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .BackgroundPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue) With {
                    .Color = Color.FromArgb(252, 252, 255)
                }, New GradientPoint(GradientPointType.MaxValue) With {
                    .Color = Color.FromArgb(248, 105, 107)
                }}
            }
        }

        colorScaleDictionary(ColorScale.GreenWhite) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .BackgroundPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue) With {
                    .Color = Color.FromArgb(252, 252, 255)
                }, New GradientPoint(GradientPointType.MaxValue) With {
                    .Color = Color.FromArgb(99, 190, 123)
                }}
            }
        }

        colorScaleDictionary(ColorScale.WhiteGreen) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .BackgroundPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue) With {
                    .Color = Color.FromArgb(99, 190, 123)
                }, New GradientPoint(GradientPointType.MaxValue) With {
                    .Color = Color.FromArgb(252, 252, 255)
                }}
            }
        }

        colorScaleDictionary(ColorScale.GreenYellow) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .BackgroundPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue) With {
                    .Color = Color.FromArgb(255, 239, 156)
                }, New GradientPoint(GradientPointType.MaxValue) With {
                    .Color = Color.FromArgb(99, 190, 123)
                }}
            }
        }

        colorScaleDictionary(ColorScale.YellowGreen) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .BackgroundPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue) With {
                    .Color = Color.FromArgb(99, 190, 123)
                }, New GradientPoint(GradientPointType.MaxValue) With {
                    .Color = Color.FromArgb(255, 239, 156)
                }}
            }
        }

        Return colorScaleDictionary
    End Function

    Private Shared Function GetIconSet() As Dictionary(Of IconSet, ItemStyle)
        Dim iconSetDictionary = New Dictionary(Of IconSet, ItemStyle)()

        iconSetDictionary(IconSet.ThreeArrows) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .IconList = IconListKey.Arrow3,
                .IconPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue), New GradientPoint(GradientPointType.MaxValue)}
            }
        }

        iconSetDictionary(IconSet.ThreeTriangles) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .IconList = IconListKey.Triangle,
                .IconPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue), New GradientPoint(GradientPointType.MaxValue)}
            }
        }

        iconSetDictionary(IconSet.FourArrows) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .IconList = IconListKey.Arrow4,
                .IconPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue), New GradientPoint(GradientPointType.MaxValue)}
            }
        }

        iconSetDictionary(IconSet.FiveArrows) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .IconList = IconListKey.Arrow5,
                .IconPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue), New GradientPoint(GradientPointType.MaxValue)}
            }
        }

        iconSetDictionary(IconSet.ThreeTrafficLightsUnrimmed) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .IconList = IconListKey.TrafficLight,
                .IconPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue), New GradientPoint(GradientPointType.MaxValue)}
            }
        }

        iconSetDictionary(IconSet.ThreeTrafficLightsRimmed) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .IconList = IconListKey.RimmedTrafficLight,
                .IconPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue), New GradientPoint(GradientPointType.MaxValue)}
            }
        }

        iconSetDictionary(IconSet.ThreeSigns) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .IconList = IconListKey.Sign,
                .IconPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue), New GradientPoint(GradientPointType.MaxValue)}
            }
        }

        iconSetDictionary(IconSet.ThreeSymbolsCircled) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .IconList = IconListKey.Symbol,
                .IconPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue), New GradientPoint(GradientPointType.MaxValue)}
            }
        }

        iconSetDictionary(IconSet.ThreeSymbolsUncircled) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .IconList = IconListKey.UncircledSymbol,
                .IconPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue), New GradientPoint(GradientPointType.MaxValue)}
            }
        }

        iconSetDictionary(IconSet.ThreeFlags) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .IconList = IconListKey.Flag,
                .IconPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue), New GradientPoint(GradientPointType.MaxValue)}
            }
        }

        iconSetDictionary(IconSet.ThreeStars) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .IconList = IconListKey.Star,
                .IconPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue), New GradientPoint(GradientPointType.MaxValue)}
            }
        }

        iconSetDictionary(IconSet.FiveQuarters) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .IconList = IconListKey.Quarter,
                .IconPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue), New GradientPoint(GradientPointType.MaxValue)}
            }
        }

        iconSetDictionary(IconSet.FiveRatings) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .IconList = IconListKey.Rating,
                .IconPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue), New GradientPoint(GradientPointType.MaxValue)}
            }
        }

        iconSetDictionary(IconSet.FiveBoxes) = New ItemStyle() With {
            .Gradient = New GradientSettings() With {
                .IconList = IconListKey.Box,
                .IconPoints = New GradientPoint() {New GradientPoint(GradientPointType.MinValue), New GradientPoint(GradientPointType.MaxValue)}
            }
        }

        Return iconSetDictionary
    End Function
End Class
