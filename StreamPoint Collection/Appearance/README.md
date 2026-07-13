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

Customizing the appearance displayed on the map is done using the following methods:

- [SetStyle](https://github.com/ichim/MapsForBlazor-nuget/tree/main/StreamPoint%20Collection/Appearance/SetStyle) - the appearance of the point on the map
- SetLabel - a text can be associated
- SetPopup - a popup can be associated

## SetStyle() method

The SetStyle() method allows the use of several predefined classes with which you can change the appearance of points on the map.
The classes that allow customizing the appearance of the point on the map are:

- PointStyle
- PieChart
- GaugeChart
- DiscreteGaugeChart


