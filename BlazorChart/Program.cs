using ApexCharts;
using BlazorChart;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using pax.BlazorChartJs;
using Radzen;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddChartJs(options =>
{
    // default
    options.ChartJsLocation = "https://cdn.jsdelivr.net/npm/chart.js";
    options.ChartJsPluginDatalabelsLocation = "https://cdn.jsdelivr.net/npm/chartjs-plugin-datalabels@2";
});

builder.Services.AddRadzenComponents();

builder.Services.AddApexCharts();

await builder.Build().RunAsync();
