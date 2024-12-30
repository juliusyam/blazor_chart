using Microsoft.AspNetCore.Components;
using PSC.Blazor.Components.Chartjs.Models.Bar;
using PSC.Blazor.Components.Chartjs.Models.Common;
using PSC.Blazor.Components.Chartjs.Models.Line;
using PSC.Blazor.Components.Chartjs.Models.Pie;
using PSC.Blazor.Components.Chartjs.Models.Scatter;

namespace BlazorChart.Pages;

public partial class ChartJsPage : ComponentBase
{
    private readonly BarChartConfig _config1 = new()
    {
        Options = new Options()
        {
            Responsive = true,
            MaintainAspectRatio = true,
        },
        Data = new Data<BarDataset>()
        {
            Labels = ["Label 1", "Label 2", "Label 3", "Label 4", "Label 5", "Label 6", "Label 7", "Label 8", "Label 9"],
            Datasets = [
                new BarDataset()
                {
                    Label = "Dataset 1",
                    Data = [6, 10, 13, 15, 19, 21, 15, 30, 1],
                    BackgroundColor = ["#69aaac"]
                },
                new BarDataset()
                {
                    Label = "Dataset 2",
                    Data = [8, 15, 3, 7, 20, 23, 18, 33, 27],
                    BackgroundColor = ["#4e15ac"]
                }
                ],
        }
    };

    private readonly LineChartConfig _config2 = new()
    {
        Options = new Options()
        {
            Responsive = true,
            MaintainAspectRatio = true,
        },
        Data = new LineData()
        {
            Labels = ["Label 1", "Label 2", "Label 3", "Label 4", "Label 5", "Label 6", "Label 7", "Label 8", "Label 9"],
            Datasets = [
                new LineDataset()
                {
                    Label = "Dataset 1",
                    Data = [6, 10, 13, 15, 19, 21, 15, 30, 1],
                    BorderColor = "#7F82FF",
                    BorderWidth = 1
                },
                new LineDataset()
                {
                    Label = "Dataset 2",
                    Data = [8, 15, 13, 19, 4, 17, 6, 25, 29],
                    BorderColor = "#A9AAF2",
                    BorderWidth = 2
                },
                new LineDataset()
                {
                    Label = "Dataset 3",
                    Data = [19, 25, 18, 17, 3, 5, 17, 19, 23],
                    BorderColor = "#4749AE",
                    BorderWidth = 3
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
                    Label = "Dataset 1",
                    Data = [6, 10, 13, 15, 19, 21, 15, 30, 1],
                    BackgroundColor = ["#D2D3E4", "#C8C9E8", "#BEBFEB", "#A9AAF2", "#7F82FF", "#5A5CC9", "#4749AE", "#3D40A1", "#343693"],
                    HoverOffset = 4
                },
                new PieDataset()
                {
                    Label = "Dataset 2",
                    Data = [8, 15, 13, 19, 4, 17, 6, 25, 29],
                    BackgroundColor = ["#D9EDEF", "#A3E5EB", "#6DDCE8", "#36D4E4", "#00CBE0", "#0B8EB8", "#194187", "#0F2954", "#061021"],
                    HoverOffset = 4
                },
                new PieDataset()
                {
                    Label = "Dataset 3",
                    Data = [19, 25, 18, 17, 3, 5, 17, 19, 23],
                    BackgroundColor = ["#F8F0FA", "#E6B4F1", "#D478E9", "#C23CE1", "#D000FF", "#9F00C5", "#8F00B2", "#670E7F", "#3F1C4C"],
                    HoverOffset = 4
                }
                ]
        }
    };

    private readonly PieChartConfig _config4 = new()
    {
        Options = new PieOptions()
        {
            Responsive = true,
            MaintainAspectRatio = true,
            Rotation = -90,
            Circumference = 180
        },
        Data = new PieData()
        {
            Labels = ["Label 1", "Label 2", "Label 3", "Label 4", "Label 5", "Label 6", "Label 7", "Label 8", "Label 9"],
            Datasets = [
                new PieDataset()
                {
                    Label = "Dataset 1",
                    Data = [6, 10, 13, 15, 19, 21, 15, 30, 1],
                    BackgroundColor = ["#D9EDEF", "#A3E5EB", "#6DDCE8", "#36D4E4", "#00CBE0", "#0B8EB8", "#194187", "#0F2954", "#061021"],
                    HoverOffset = 4
                },
                ]
        }
    };

    private readonly ScatterChartConfig _config5 = new()
    {
        Data = new ScatterData()
        {
            Labels = ["Label 1, Label 2, Label 3, Label 4"],
            Datasets = [
                new ScatterDataset() {
                    Label = "Dataset 1",
                    BackgroundColor = "#00CBE0",
                    Data = [
                        new() { X = -8, Y = 2 },
                        new() { X = 5, Y = 6 },
                        new() { X = 4, Y = 7 },
                        new() { X = 3.5M, Y = 3.5M }
                    ],
                },
                new ScatterDataset() {
                    Label = "Dataset 2",
                    BackgroundColor = "#C23CE1",
                    Data = [
                        new() { X = -7, Y = 7 },
                        new() { X = 5, Y = 6 },
                        new() { X = 3, Y = 7 },
                        new() { X = 6.5M, Y = 2.5M }
                    ],
                }
                ]
        }
    };

    private readonly BarChartConfig _config6 = new()
    {
        Options = new Options()
        {
            Responsive = true,
            MaintainAspectRatio = true,
        },
        Data = new Data<BarDataset>()
        {
            Labels = ["Label 1", "Label 2", "Label 3", "Label 4", "Label 5", "Label 6", "Label 7", "Label 8", "Label 9"],
            Datasets = [
                new BarDataset()
                {
                    Label = "Dataset 1",
                    Data = [6, 10, 13, 15, 19, 21, 15, 30, 1],
                    BackgroundColor = ["#69aaac"],
                    Type = "line"
                },
                new BarDataset()
                {
                    Label = "Dataset 1",
                    Data = [6, 10, 13, 15, 19, 21, 15, 30, 1],
                    BackgroundColor = ["#69aaac"]
                },
                ],
        }
    };
}
