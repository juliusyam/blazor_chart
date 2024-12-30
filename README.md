# Blazor Chart
A Blazor WASM project to determine the best solution for graphical representation of data.

## Selections

### [ChartJS](https://www.chartjs.org/)
Free open source JavaScript library for data visualization. 
A Chart is drawn on an HTML Canvas, where interaction is responsive with animation, speedy rendering and reactive to screen size and data changes.
Community solutions are created to provide Chart.js to Blazor.

#### Community Solution: [PSC Blazor ChartJS](https://www.nuget.org/packages/PSC.Blazor.Components.Chartjs)
**Version as tested: 8.0.8**\
**Total downloads: 64.1K**\
*Last updated 4 months ago and supports .NET 8 onwards*\

> Pro: Bespoke Configuration and Dataset type for each type of chart + Demo site

> Con: Unable to filter entries on click Chart Legend

#### Community Solution: [pax Blazor ChartJS](https://www.nuget.org/packages/pax.BlazorChartJs)
**Version as tested: 0.8.5**\
**Total downloads: 19.6K**\
*Last updated 2 months ago and supports .NET 8 onwards*\

> Pro: Bespoke configuration and Dataset type for each type of chart + Demo site

> Con: Not responsive to screen size increase when max-width is added to a parent

### [Radzen Blazor](https://www.nuget.org/packages/Radzen.Blazor)
**Version as tested: 5.7.2**\
**Total downloads: 9.8M**\
*Last updated 4 days ago and supports .NET 6 onwards*\

> Pro: Identical configuration and dataset for all types of charts. Does not have flaws that come with the Chart.js conversion community solutions.

> Con: Requires installation of bulky CSS and Component library, with many unrelated to Charts. Charts are not animated and responsive / speedy compared to Chart.js
