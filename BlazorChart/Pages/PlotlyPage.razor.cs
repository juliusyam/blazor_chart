
using Microsoft.AspNetCore.Components;
using Plotly.Blazor;
using Plotly.Blazor.Traces;
using Plotly.Blazor.Traces.ScatterLib;

namespace BlazorChart.Pages;

public partial class PlotlyPage : ComponentBase
{
    PlotlyChart chart;
    Config config = new Config();
    Plotly.Blazor.Layout layout = new();
    // Using of the interface IList is important for the event callback!
    IList<ITrace> data = new List<ITrace>
    {
        new Scatter
        {
            Name = "ScatterTrace",
            Mode = ModeFlag.Lines | ModeFlag.Markers,
            X = [1, 2, 3],
            Y = [1, 2, 3]
        }
    };
}
