using Microsoft.AspNetCore.Components;
using pax.BlazorChartJs;

namespace BlazorChart.Pages;

public partial class PaxChartJsPage : ComponentBase
{
    ChartJsConfig chartJsConfig = null!;
    ChartComponent? chartComponent;
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

    private void Randomize()
    {
        if (!chartReady)
        {
            return;
        }

        List<ChartJsDataset> updateDatasets = [];

        foreach (var dataset in chartJsConfig.Data.Datasets)
        {
            if (dataset is BarDataset barDataset)
            {
                List<object> newData = new();
                foreach (var data in barDataset.Data)
                {
                    newData.Add(Random.Shared.Next(1, 10));
                }
                barDataset.Data = newData;
                updateDatasets.Add(dataset);
            }
        }
        chartJsConfig.UpdateDatasetsSmooth(updateDatasets);
    }
}
