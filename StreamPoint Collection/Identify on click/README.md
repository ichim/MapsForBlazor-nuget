# StreamPoint collection events

The StreamPoint collection of points (map.Geometric.Points) provides the event: OnClick


       map.Geometric.Points.OnClick += async (object? sender, StreamPointEventArgs args) =>
      {
          Console.WriteLine($"    Clicked point with count {args.points.Count()}");
      };

where:

    <Map @ref="map" />
    @code {
        Map? map;
        }
