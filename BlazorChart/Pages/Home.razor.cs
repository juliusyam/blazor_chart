using Microsoft.AspNetCore.Components;
using PSC.Blazor.Components.Chartjs.Models.Bar;
using PSC.Blazor.Components.Chartjs.Models.Common;
using System.Collections.Generic;
using System;
using PSC.Blazor.Components.Chartjs.Models.Line;
using PSC.Blazor.Components.Chartjs.Models.Pie;

namespace BlazorChart.Pages;

public partial class Home : ComponentBase
{
    private readonly BarChartConfig _config1 = new()
    {
        Options = new Options()
        {
            Responsive = true,
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

    private readonly LineChartConfig _config2 = new()
    {
        Options = new Options()
        {
            Responsive = true,
            RegisterDataLabels = true,
            Plugins = new Plugins()
            {
                DataLabels = new DataLabels()
                {
                    Align = DatalabelsAlign.Start,
                    Anchor = DatalabelsAnchor.Start,
                }
            }
        },
        Data = new LineData()
        {
            Labels = ["Label 1", "Label 2", "Label 3", "Label 4", "Label 5", "Label 6", "Label 7", "Label 8", "Label 9"],
            Datasets = [
                new LineDataset()
                {
                    Label = "Value",
                    Data = [6, 10, 13, 15, 19, 21, 15, 30, 1],
                    BorderColor = "#7F82FF",
                    BorderWidth = 1
                },
                new LineDataset()
                {
                    Label = "Value 2",
                    Data = [8, 15, 13, 19, 4, 17, 6, 25, 29],
                    BorderColor = "#A9AAF2",
                    BorderWidth = 1
                },
                new LineDataset()
                {
                    Label = "Value 3",
                    Data = [19, 25, 18, 17, 3, 5, 17, 19, 23],
                    BorderColor = "#4749AE",
                    BorderWidth = 1
                }
                ],
        }
    };

    private readonly PieChartConfig _config3 = new()
    {
        Data = new PieData()
        {
            Labels = ["Label 1", "Label 2", "Label 3", "Label 4", "Label 5", "Label 6", "Label 7", "Label 8", "Label 9"],
            Datasets = [
                new PieDataset()
                {
                    Label = "My First Dataset",
                    Data = [6, 10, 13, 15, 19, 21, 15, 30, 1],
                    BackgroundColor = ["#D2D3E4", "#C8C9E8", "#BEBFEB", "#A9AAF2", "#7F82FF", "#5A5CC9", "#4749AE", "#3D40A1", "#343693"],
                    HoverOffset = 4
                },
                new PieDataset()
                {
                    Label = "My Second Dataset",
                    Data = [8, 15, 13, 19, 4, 17, 6, 25, 29],
                    BackgroundColor = ["#D9EDEF", "#A3E5EB", "#6DDCE8", "#36D4E4", "#00CBE0", "#0B8EB8", "#194187", "#0F2954", "#061021"],
                    HoverOffset = 4
                },
                new PieDataset()
                {
                    Label = "My Third Dataset",
                    Data = [19, 25, 18, 17, 3, 5, 17, 19, 23],
                    BackgroundColor = ["#F8F0FA", "#E6B4F1", "#D478E9", "#C23CE1", "#D000FF", "#9F00C5", "#8F00B2", "#670E7F", "#3F1C4C"],
                    HoverOffset = 4
                }
                ]
        }
    };
}
