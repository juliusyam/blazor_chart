using ApexCharts;
using Microsoft.AspNetCore.Components;

namespace BlazorChart.Pages;

public partial class ApexChartsPage : ComponentBase
{
    private readonly ApexChartOptions<ApexDataEntry> _options = new()
    {
        Tooltip = new Tooltip { Shared = false, Intersect = true },
        Markers = new Markers { Size = 6 },
    };

    private readonly List<ApexDataEntry> _dataEntries = [
        new ApexDataEntry("Jan", 12, 33),
        new ApexDataEntry("Feb", 43, 42),
        new ApexDataEntry("Mar", 112, 23)
        ];

    private readonly List<ApexDataEntry> _dataEntries2 = [
        new ApexDataEntry("Jan", 17, 46),
        new ApexDataEntry("Feb", 25, 78),
        new ApexDataEntry("Mar", 107, 37)
        ];

    private readonly List<BoxPlotEntry> _boxPlotEntries = [
        new BoxPlotEntry("Jan", 17, 25, 35, 40, 42),
        new BoxPlotEntry("Feb", 3, 21, 23, 29, 37),
        new BoxPlotEntry("Mar", 9, 10, 11, 12, 35)
    ];
}

public record ApexDataEntry(string Category, int NetProfit, int Revenue);

public record BoxPlotEntry(string Name, int Min, int Q1, int Median, int Q3, int Max);