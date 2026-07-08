# Add/Remove methods

The StreamPoints collection can be updated in two basic ways:
1. Add - adds StreamPoint to the collection
2. Remove - removes StreamPoint from the collection

## Add StreamPoint

    await map.Geometric.Points.Add(new StreamPoints().points);

Where new StreamPoints().points is a new List<StreamPoint>()
