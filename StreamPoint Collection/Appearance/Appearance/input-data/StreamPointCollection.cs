using static MapsForBlazor.Map;

namespace Add_Remove.input_data
{
    public class StreamPointCollection
    {
        public List<StreamPoint> streamPointsCollection = new List<StreamPoint>()
            {
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.860847591747186,  4.227255449993002 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000001"),
                    type = "Entertainment"

                },
                new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.882847591747186,  4.288255449993004 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000002"),
                     type = "Business environment"
                },
                  new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.62847591747186,  4.4255449993004 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000004"),
                     type = "Archaeological site"
                },
                     new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.60847591747186,  4.6255449993004 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000006"),
                     type = "Entertainment"
                },
                             new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] { 50.61840,  4.638040 }
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000008"),
                     type = "Entertainment"
                },
                             new StreamPoint()
                {
                    coordinates = new Coordinates()
                    {
                        xy = new double[2] {  50.960847591747186,  4.327255449993002}
                    },
                    guid = new Guid("00000000-0000-0000-0000-000000000020"),
                     type = "Business environment"
                }
            };


    }
}
