using Microsoft.AspNetCore.Components;

namespace BlazorChart.Pages;

public partial class ApexChartsPage : ComponentBase
{
    private readonly List<ApexDataEntry> _dataEntries = [
        new ApexDataEntry("Jan", 12, 33),
        new ApexDataEntry("Feb", 43, 42),
        new ApexDataEntry("Mar", 112, 23)
        ];
}

public record ApexDataEntry(string Category, int NetProfit, int Revenue);