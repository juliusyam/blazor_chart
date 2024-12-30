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
                Datasets = new List<ChartJsDataset>()
                    {
                        new BarDataset()
                        {
                            Label = "Dataset 1",
                            Data = [ 1, 2, 3 ]
                        }
                    }
            },
            Options = new()
            {
                Responsive = true,
            }
        };

        chartJs2Config = new ChartJsConfig()
        {
            Type = ChartType.line,
            Data = new ChartJsData()
            {
                Labels = ["Jan", "Feb", "Mar"],
                Datasets = new List<ChartJsDataset>()
                {
                    new LineDataset()
                    {
                        BorderColor = "#69aaac",
                        Label = "Dataset 1",
                        Data = [2, 5, 7]
                    },
                    new LineDataset()
                    {
                        BorderColor = "#451369",
                        Label = "Dataset 2",
                        Data = [5, 8, 3]
                    }
                }
            },
            Options = new()
            {
                Responsive = true,
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
