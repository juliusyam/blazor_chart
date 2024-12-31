
using Microsoft.AspNetCore.Components;
using Plotly.Blazor;
using Plotly.Blazor.LayoutLib;
using Plotly.Blazor.Traces;
using Plotly.Blazor.Traces.BoxLib;
using Plotly.Blazor.Traces.ScatterLib;

namespace BlazorChart.Pages;

public partial class PlotlyPage : ComponentBase
{
    PlotlyChart chart;
    private Config config = new()
    {
        Responsive = true,
    };
    private Plotly.Blazor.Layout layout = new();
    private Plotly.Blazor.Layout barLayout = new()
    {
        BarMode = BarModeEnum.Group
    };

    private IList<ITrace> scatterData = [
        new Scatter
        {
            Name = "Dataset 1",
            Mode = ModeFlag.Lines | ModeFlag.Markers,
            X = [1, 2, 3, 4, 5, 6, 7, 8, 9],
            Y = [1, 2, 3, 6, 7, 11, 6, 7, 5]
        },
        new Scatter
        {
            Name = "Dataset 2",
            Mode = ModeFlag.Lines | ModeFlag.Markers,
            X = [1, 2, 3, 4, 5, 6, 7, 8, 9],
            Y = [5, 8, 4, 7, 3, 10, 12, 1, 37]
        }
        ];

    private IList<ITrace> barData = [
        new Bar
        {
            Name = "Dataset 1",
            X = ["Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sep"],
            Y = [1, 2, 3, 6, 7, 11, 6, 7, 5]
        },
        new Bar
        {
            Name = "Dataset 2",
            X = ["Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sep"],
            Y = [5, 8, 4, 7, 3, 10, 12, 1, 37]
        }
        ];

    private IList<ITrace> pieData = [
        new Pie
        {
            Values = [19, 26, 55 ],
            Labels = ["Residential", "Non-Residential", "Utility"]
        }
        ];

    private IList<ITrace> boxPlotData = [
        new Box
        {
            Y = [86, 92, 77, 81, 70, 71, 72, 39, 48, 38, 6, 23, 69, 84, 60, 96, 75, 84, 84, 92, 75, 80, 47, 32, 16],
            Name = "trace 0"
        },
        new Box
        {
            Y = [79, 65, 58, 49, 95, 29, 81, 38, 27, 21, 96, 68, 58, 40, 62, 30, 45, 53, 80, 83, 41, 39, 54, 50, 34],
            Name = "trace 1",
            BoxMean = BoxMeanEnum.SD
        },
        new Box
        {
            Name = "trace 2",
            Y = [31, 50, 4, 6, 54, 58, 69, 32, 40, 24, 20, 17, 33, 8, 12, 97, 0, 4, 75, 10, 43, 70, 88, 0, 17],
            BoxMean = BoxMeanEnum.True,
            BoxPoints = BoxPointsEnum.All
        }
        ];

    private IList<ITrace> areaPolarData = GenerateScatterPolarData();

    private static IList<ITrace> GenerateScatterPolarData()
    {
        var trace1 = new ScatterPolar()
        {
            R = new[] { 0, 1.5, 1.5, 0, 2.5, 2.5, 0 }.OfType<object>().ToList(),
            Theta = new[] { 0, 10, 25, 0, 205, 215, 0 }.OfType<object>().ToList(),
            Mode = Plotly.Blazor.Traces.ScatterPolarLib.ModeFlag.Lines,
            Fill = Plotly.Blazor.Traces.ScatterPolarLib.FillEnum.ToSelf,
            FillColor = "#709BFF",
            Line = new Plotly.Blazor.Traces.ScatterPolarLib.Line() { Color = "black" }
        };
        var trace2 = new ScatterPolar()
        {
            R = new[] { 0, 3.5, 3.5, 0 }.OfType<object>().ToList(),
            Theta = new[] { 0, 55, 75, 0 }.OfType<object>().ToList(),
            Mode = Plotly.Blazor.Traces.ScatterPolarLib.ModeFlag.Lines,
            Fill = Plotly.Blazor.Traces.ScatterPolarLib.FillEnum.ToSelf,
            FillColor = "#E4FF87",
            Line = new Plotly.Blazor.Traces.ScatterPolarLib.Line() { Color = "black" }
        };
        var trace3 = new ScatterPolar()
        {
            R = new[] { 0, 4.5, 4.5, 0, 4.5, 4.5, 0 }.OfType<object>().ToList(),
            Theta = new[] { 0, 100, 120, 0, 305, 320, 0 }.OfType<object>().ToList(),
            Mode = Plotly.Blazor.Traces.ScatterPolarLib.ModeFlag.Lines,
            Fill = Plotly.Blazor.Traces.ScatterPolarLib.FillEnum.ToSelf,
            FillColor = "#FFAA70",
            Line = new Plotly.Blazor.Traces.ScatterPolarLib.Line() { Color = "black" }
        };
        var trace4 = new ScatterPolar()
        {
            R = new[] { 0, 4, 4, 0 }.OfType<object>().ToList(),
            Theta = new[] { 0, 165, 195, 0 }.OfType<object>().ToList(),
            Mode = Plotly.Blazor.Traces.ScatterPolarLib.ModeFlag.Lines,
            Fill = Plotly.Blazor.Traces.ScatterPolarLib.FillEnum.ToSelf,
            FillColor = "#FFDF70",
            Line = new Plotly.Blazor.Traces.ScatterPolarLib.Line() { Color = "black" }
        };
        var trace5 = new ScatterPolar()
        {
            R = new[] { 0, 3, 3, 0 }.OfType<object>().ToList(),
            Theta = new[] { 0, 3, 3, 0 }.OfType<object>().ToList(),
            Mode = Plotly.Blazor.Traces.ScatterPolarLib.ModeFlag.Lines,
            Fill = Plotly.Blazor.Traces.ScatterPolarLib.FillEnum.ToSelf,
            FillColor = "#B6FFB4",
            Line = new Plotly.Blazor.Traces.ScatterPolarLib.Line() { Color = "black" }
        };

        return [trace1, trace2, trace3, trace4, trace5];
    }
}
