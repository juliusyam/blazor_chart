using Microsoft.AspNetCore.Components;
using pax.BlazorChartJs;

namespace BlazorChart.Pages;

public partial class PaxChartJsPage : ComponentBase
{
    ChartJsConfig chartJsConfig = null!;
    ChartJsConfig chartJs2Config = null!;
    ChartComponent? chartComponent;
    ChartComponent? chartComponent2;
    private bool chartReady;

    protected override void OnInitialized()
    {
        chartJsConfig = new ChartJsConfig()
        {
            Type = ChartType.bar,
            Data = new ChartJsData()
            {
                Labels = ["Jan", "Feb", "Mar"],
                Datasets = [
                    new BarDataset()
                    {
                        Label = "Dataset 1",
                        Data = [3, 5, 1],
                        BackgroundColor = "#7F82FF",
                    },
                    new BarDataset()
                    {
                        Label = "Dataset 2",
                        Data = [15, 13, 3],
                        BackgroundColor = "#00CBE0",
                    },
                    new BarDataset()
                    {
                        Label = "Dataset 3",
                        Data = [8, 7, 19],
                        BackgroundColor = "#D000FF",
                    },
                    new BarDataset()
                    {
                        Label = "Dataset 4",
                        Data = [3, 1, 7],
                        BackgroundColor = "#D478E9",
                    }
                ]
            },
            Options = new()
            {
                Responsive = true,
                MaintainAspectRatio = true,
            }
        };

        chartJs2Config = new ChartJsConfig()
        {
            Type = ChartType.line,
            Data = new ChartJsData()
            {
                Labels = ["Jan", "Feb", "Mar", "Apr", "May"],
                Datasets = [
                    new LineDataset()
                    {
                        BorderColor = "#00CBE0",
                        Label = "Dataset 1",
                        Data = [2, 5, 7, 9, 15]
                    },
                    new LineDataset()
                    {
                        BorderColor = "#D000FF",
                        Label = "Dataset 2",
                        Data = [5, 8, 3, 9, 10]
                    }
                ]
            },
            Options = new()
            {
                Responsive = true,
                MaintainAspectRatio = true,
            }
        };

        base.OnInitialized();
    }

    private void ChartEventTriggered(ChartJsEvent chartJsEvent)
    {
        if (chartJsEvent is ChartJsInitEvent initEvent)
        {
            chartReady = true;
        }
    }
}
