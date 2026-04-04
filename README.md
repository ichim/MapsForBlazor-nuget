*Maps for Blazor* is a library that provides components for displaying maps in Blazor applications. It supports various map providers (Esri, Leaflet) and allows developers to easily integrate interactive maps into their Blazor projects. ==One code, one blazor component and many technologies==.


**==KEYWORDS==**: Minimizing Invoke callers to JavaScript, `No JavaScript specific settings`, no script references, no css links. `One code`, one component `many technologies`.


#  Maps for Blazor

You can display the map in the blazor page using one of the provided technologies (Esri, Leaflet providers). Regardless of the technology provider (Esri, Leaflet), the code for implementing the map will be the same. 

# Quick Start


The `@using` directive allows selecting the API for generating the map:

	@using static MapsForBlazor.techs.maps.ArcGIS					//ArcGIS 
	

Or:

	@using static MapsForBlazor.techs.maps.Leaflet  				//Leaflet


|🔵 The **following code is the same (identical)** regardless of the namespace chosen (whether you chose ==MapsForBlazor.techs.maps.ArcGIS== or whether you chose ==MapsForBlazor.techs.maps.Leaflet==).|
|----|


## Map


Adding the map to the blazor page:

	<Map height="calc(100vh - 1rem)" width="calc(100vw - 2rem)"/>


## Load Parameters

The default (loading) parameters of the map can be configured using the loadParameters parameter of the Map component.

### Blazor Page

for ArcGIS:

    @using static MapsForBlazor.techs.maps.ArcGIS //for ArcGIS Maps SDK
    <Map loadParameters="@loadParameters" height="calc(100vh - 1rem)" width="calc(100vw - 2rem)"/> 

for Leaflet:

    @using static MapsForBlazor.techs.maps.Leaflet //for Leaflet
    <Map loadParameters="@loadParameters" height="calc(100vh - 1rem)" width="calc(100vw - 2rem)"/> 

### Code Block

    @code{
       LoadParameters loadParameters = new LoadParameters()
        {
            location = new Location()
            {
                latitude = 50.870847591747186,
                longitude = 4.257255449993001
            },
            zoomLevel = 10
        };
    }

## Points on the map

To optimize rendering, MapsForBlazor operates with a predefined data structure for points.

    public class StreamPoint 
    {
        public Guid guid { get; set; }
        public Coordinates coordinates { get; set; } 
        public object value { get; set; } 
        public DateTime timestamp { get; set; }
        public string? type { get; set; }
    }


|🔵 This structure can be extended, using custom data structures, for the value parameter.|
|----|


### Data addition flow

#### Loaded event

To add points to the map it is important that the map is already initialized. The first event that is triggered after the map is initialized is `OnAfterMapLoaded`.

Event initialization:

🔹Blazor Page:

    <Map height="calc(100vh - 1rem)" width="calc(100vw - 2rem)" OnAfterMapLoaded="@OnAfterMapLoaded"/>

🔹Code Block:

    @code {
            private async Task OnAfterMapLoaded(MapEventArgs args)
            {

            }
        }

#### Adding points

To add points to the map, you can use the `Add` method of the Map component. This method accepts a list of `StreamPoint` objects.

🔹Blazor Page:

    <Map height="calc(100vh - 1rem)" width="calc(100vw - 2rem)" OnAfterMapLoaded="@OnAfterMapLoaded"/>

🔹Code Block:

    @code {
            private async Task OnAfterMapLoaded(MapEventArgs args)
            {
                 await map.Geometric.Points.Add(new List<StreamPoint>(){});
            }
        }

### Removing


    await  map.Geometric.Points.Remove();


### OnClick Event

The points collection provides the `OnClick` event that allows you to return the points near which the click was made on the map. The distance to search for points, from the point where the click was made, is one hundredth of the diagonal of the visible area of ​​the map.

        map.Geometric.Points.OnClick += async (object? sender, StreamPointEventArgs args) =>
       {
           Console.WriteLine($"    Clicked point with count {args.points.Count()}");
       };

Where:

        public class StreamPointEventArgs : EventArgs
        {
           public List<StreamPoint> points { get; set; }    //points near the point where the click was made
           public Coordinates geoid { get; set; }           //geographical coordinates of the point where the click was made
           public Coordinates screen { get; set; }          //screen coordinates of the point where the click was made
        }

### Appearance

`Appearance` is a method that allows filtering and applying properties specific to the display of points on the map. Appearance settings can be cascaded (one after another, on the same Appearance filter):

       await map.Geometric.Points.Appearance(e => e.type == "A" || e.type == "B")
        .SetStyle(new PointStyle() { radius = 14, color = "green", fillColor = "azure", weight = 4 })
        .SetPopup(new Popup() { content = "<h4 style = 'background-color:gray;color:orange'>Text on popup</h4>", title = "titlu"});


Other examples:

1. No filtering (the entire `StreamPoint` collection will have the same Appearance):

       await map.Geometric.Points.Appearance()
        .SetStyle(new PointStyle() { radius = 14, color = "green", fillColor = "azure", weight = 4 })
        .SetPopup(new Popup() { content = "<h4 style = 'background-color:gray;color:orange'>Text on popup</h4>", title = "titlu"});

2. Contained in an Array (Contains clause):

       string[] types = new string[] { "A", "B" };
       await map.Geometric.Points.Appearance(e => types.Contains(e.type))
        .SetStyle(new PointStyle() { radius = 14, color = "green", fillColor = "azure", weight = 4 })
        .SetPopup(new Popup() { content = "<h4 style = 'background-color:gray;color:orange'>Text on popup<</h4>", title = "titlu"});

|ᶜ⁴ˡᵘ⁷ᵘ⁵ᵘᶠˡᵉ⁷⁸ᵘⁿ|
|----|

Laurentiu Ichim, Bucharest
