# Working with Appearance

Appearance() is a method of the point collection (StreamPoint), which allows you to customize the display of points on the map. This method implements a Where (LINQ) with which you can filter the points in the collection for which you want to change the appearance:

For example:

    await map.Geometric.Points.Appearance(e => e.type == "Industrial")
        .SetStyle(new PieChart()
        {
            dimension = 40,
  
            title = "Park",
            visibilityZoomLevels = new VisibilityZoomLevels() { minZoomLevel = 8, maxZoomLevel = 10 },
            expandedIndex = 0,
            fontSize = 8,
            paramOrValues = "${production}",
            paramOrLabels = "${texts}",
            paramOrColors = "${classes}"
        })
        .SetLabel(new Label() { text = "Park 4", title = "Label Layer List" });

Chart configuration parameters can be either invariants or dynamic. Invariants are those related to the appearance or configuration of the chart content, e.g. color, height, fontSize etc.
The parameters here are those that change over time and must be updated on the chart when the attributes of a StreamPoint are updated. 
These parameters are denoted by ``paramOr...`` and can be configured with numeric, string or array values ​​or can be configured to retrieve data from the StreamPoint collection.

Example of configuration by values:

           paramOrValue = 9,

Example of configuration by parameter (StreamPoint attribute):

           paramOrValue = "${batteryLevel}"

Where ``batteryLevel`` is an attribute of a StreamPoint element in the StreamPoint collection.

Customizing the appearance displayed on the map is done using the following methods:

- [SetStyle](https://github.com/ichim/MapsForBlazor-nuget/tree/main/StreamPoint%20Collection/Appearance/SetStyle) - the appearance of the point on the map
- SetLabel - a text can be associated
- SetPopup - a popup can be associated

## SetStyle() method

The SetStyle() method allows the use of several predefined classes with which you can change the appearance of points on the map.
The classes that allow customizing the appearance of the point on the map are:

- PointStyle
- DynamicPointSVG
- PieChart
- GaugeChart
- DiscreteGaugeChart
- QuarterGaugeFillChart and QuarterGaugeFillChartBase
- QuarterGaugeScaleAndPercentChart and QuarterGaugeScaleAndPercentChartBase
- QuartersCharts
- SigmaDroneChart



