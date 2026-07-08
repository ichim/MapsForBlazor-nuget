# Add/Remove methods

The StreamPoints collection can be updated in two basic ways:
1. Add - adds StreamPoint to the collection
2. Remove - removes StreamPoint from the collection

## Add StreamPoint

    await map.Geometric.Points.Add(new StreamPoints().points);

Where:

    new StreamPoints().points is a new List<StreamPoint>()

A simple code example:

             await map.Geometric.Points.Add( new List<StreamPoint>()
            {
                    new StreamPoint()
                    {
                        coordinates = new Coordinates()
                        {
                            xy = new double[2] { 50.860847591747186,  4.227255449993002 }
                        },
                        guid = new Guid("00000000-0000-0000-0000-000000000001"),
                        type = "Industrial",
                        value = new IndustrialValues()
                        {
                            production = new double[4] { 400, 200, 300, 50 },
                            texts = new string[3] { "Low", "Medium", "High" },
                            classes = new string[4] { "white", "yellow", "red", "gray" }
                        }
                    });

Where:

        <Map @ref="map" />
        @code {
            Map? map;
            }
