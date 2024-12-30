using Microsoft.AspNetCore.Components;
using Radzen;
using System.Globalization;

namespace BlazorChart.Pages;

public partial class RadzenPage : ComponentBase
{
    private readonly bool showDataLabels = false;

    static string FormatAsUSD(object value)
    {
        return ((double)value).ToString("C0", CultureInfo.CreateSpecificCulture("en-US"));
    }

    private static void OnSeriesClick(SeriesClickEventArgs args)
    {
        Console.WriteLine(args);
    }

    private readonly DataItem[] revenue2023 = [
        new DataItem
        {
            Quarter = "Q1",
            Revenue = 234000
        },
        new DataItem
        {
            Quarter = "Q2",
            Revenue = 284000
        },
        new DataItem
        {
            Quarter = "Q3",
            Revenue = 274000
        },
        new DataItem
        {
            Quarter = "Q4",
            Revenue = 294000
        }];

    private readonly DataItem[] revenue2024 = [
        new DataItem
        {
            Quarter = "Q1",
            Revenue = 254000
        },
        new DataItem
        {
            Quarter = "Q2",
            Revenue = 324000
        },
        new DataItem
        {
            Quarter = "Q3",
            Revenue = 354000
        },
        new DataItem
        {
            Quarter = "Q4",
            Revenue = 394000
        }];
}

public class DataItem
{
    public string Quarter { get; set; } = string.Empty;
    public double Revenue { get; set; }
}