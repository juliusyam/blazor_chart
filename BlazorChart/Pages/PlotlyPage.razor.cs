
using Microsoft.AspNetCore.Components;
using Plotly.Blazor;
using Plotly.Blazor.Traces;
using Plotly.Blazor.Traces.ScatterLib;

namespace BlazorChart.Pages;

public partial class PlotlyPage : ComponentBase
{
    PlotlyChart chart;
    private Config config = new();
    private Plotly.Blazor.Layout layout = new();

    IList<ITrace> data = [
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
}
