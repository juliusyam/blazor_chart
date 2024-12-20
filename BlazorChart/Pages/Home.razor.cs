﻿using Microsoft.AspNetCore.Components;
using PSC.Blazor.Components.Chartjs.Models.Bar;
using PSC.Blazor.Components.Chartjs.Models.Common;
using System.Collections.Generic;
using System;

namespace BlazorChart.Pages;

public partial class Home : ComponentBase
{
    private readonly BarChartConfig _config1 = new()
    {
        Options = new Options()
        {
            Plugins = new Plugins()
            {
                Legend = new Legend()
                {
                    Align = Align.Center,
                    Display = false,
                    Position = LegendPosition.Right
                }
            },
            Scales = new Dictionary<string, Axis>()
            {
                {
                    Scales.XAxisId, new Axis()
                    {
                        Stacked = true,
                        Ticks = new Ticks()
                        {
                            MaxRotation = 0,
                            MinRotation = 0
                        }
                    }
                },
                {
                    Scales.YAxisId, new Axis()
                    {
                        Stacked = true
                    }
                }
            },
        },
        Data = new Data<BarDataset>()
        {
            Labels = ["Label 1", "Label 2", "Label 3", "Label 4", "Label 5", "Label 6", "Label 7", "Label 8", "Label 9"],
            Datasets = [
                new BarDataset()
                {
                    Label = "Value",
                    Data = [6, 10, 13, 15, 19, 21, 15, 30, 1],
                    BackgroundColor = ["#D2D3E4", "#C8C9E8", "#BEBFEB", "#A9AAF2", "#7F82FF", "#5A5CC9", "#4749AE", "#3D40A1", "#343693"],
                    BorderWidth = 1
                }
                ],
        }
    };

    private readonly BarChartConfig _config2 = new()
    {
        Options = new Options()
        {
            Plugins = new Plugins()
            {
                Legend = new Legend()
                {
                    Align = Align.Center,
                    Display = false,
                    Position = LegendPosition.Right
                }
            },
            Scales = new Dictionary<string, Axis>()
            {
                {
                    Scales.XAxisId, new Axis()
                    {
                        Stacked = true,
                        Ticks = new Ticks()
                        {
                            MaxRotation = 0,
                            MinRotation = 0
                        }
                    }
                },
                {
                    Scales.YAxisId, new Axis()
                    {
                        Stacked = true
                    }
                }
            },
        },
        Data = new Data<BarDataset>()
        {
            Labels = ["Label 1", "Label 2", "Label 3", "Label 4", "Label 5", "Label 6", "Label 7", "Label 8", "Label 9"],
            Datasets = [
                new BarDataset()
                {
                    Label = "Value",
                    Data = [6, 10, 13, 15, 19, 21, 15, 30, 1],
                    BackgroundColor = ["#D2D3E4", "#C8C9E8", "#BEBFEB", "#A9AAF2", "#7F82FF", "#5A5CC9", "#4749AE", "#3D40A1", "#343693"],
                    BorderWidth = 1
                }
                ],
        }
    };
}
