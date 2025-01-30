# Customize RadialBar Chart in .NET MAUI CircularCharts

The [Radial Bar Chart](https://help.syncfusion.com/maui/circular-charts/radialbarchart) in .NET MAUI offers extensive customization options to tailor its appearance to your specific needs. This repository showcases a sample project for personalizing RadialBar Chart within .NET MAUI [SfCircularChart](https://help.syncfusion.com/maui/circular-charts/getting-started).

## Customization

[Radius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_Radius): You can use the radius property to change the radial bar chart size. The default value of the radius is `0.8`.

[InnerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RadialBarSeries.html#Syncfusion_Maui_Charts_RadialBarSeries_InnerRadius): The InnerRadius property of radial bar series is used to define the inner circle. The default value of this property is `0.4`.

[Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_Stroke): To customize the outer layer of the chart segments.

[StrokeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_StrokeWidth): To customize the width of the stroke in chart segments.

[MaximumValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RadialBarSeries.html#Syncfusion_Maui_Charts_RadialBarSeries_MaximumValue): To represent the span of the segment-filled area in the radial bar track. The default value of this property is `double.NaN`.

[GapRatio](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RadialBarSeries.html#Syncfusion_Maui_Charts_RadialBarSeries_GapRatio): To customize the spacing between each chart segments.

[CapStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RadialBarSeries.html#Syncfusion_Maui_Charts_RadialBarSeries_CapStyle): The CapStyle property of the radial bar series is used to specify the shape of the start and end points of the circular segment. The default value of this property is `BothFlat`.

[PaletteBrushes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_PaletteBrushes): Applies custom colors to the RadialBar chart.

[Center View](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RadialBarSeries.html#Syncfusion_Maui_Charts_RadialBarSeries_CenterView): Adds custom content, like an image, inside the center of the RadialBar chart.

## Troubleshooting
### Path too long exception
If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.