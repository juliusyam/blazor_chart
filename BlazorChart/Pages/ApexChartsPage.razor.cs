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
}

public record ApexDataEntry(string Category, int NetProfit, int Revenue);