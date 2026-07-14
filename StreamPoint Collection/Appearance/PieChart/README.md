# PieChart

The structure of a PieChart class is as follows:

    public class PieChart: IChartPoint, IPieStyles
    {
        public string title { get; set; } = "without title";
        public VisibilityZoomLevels visibilityZoomLevels { get; set; } = new VisibilityZoomLevels();
        public int dimension { get; set; }
        public int scaling { get; set; } = 100;
        public int  fontSize { get; set; } = 6;
        public int expandedIndex { get; set; } = -1;    //slice index to be expanded, -1 means no slice is expanded
        public PieStyle? styles { get; set; } = null;
        public object paramOrValues { get; set; }       //values for pie chart or parameter ${parameterValues}
        public object paramOrLabels { get; set; }       //labels for pie chart or parameter ${parameterLabels}
        public object paramOrColors { get; set; }       //colors for pie chart or parameter ${parameterColors}
    }

Where the properties paramOrValues, paramOrLabels, paramOrColors can accept arrays of values ​​(numeric and text) or can accept template literals/templates strings, but without backtick (`) characters.

The "paramOr..." properties are of type object, and their meaning is that they can use either values ​​(numbers, text, array etc.) or parameters of data sources.

## Working with values

One possibility (rarely encountered) is to set parameters by values ​​(numbers, texts, arrays, etc.)

For example:

       await map.Geometric.Points.Appearance(e => e.type == "Industrial").SetStyle(new PieChart()
         {
             dimension = 40,
    
             title = "Park",
             visibilityZoomLevels = new VisibilityZoomLevels() { minZoomLevel = 8, maxZoomLevel = 10 },
             expandedIndex = 0,
             fontSize = 8,
             paramOrValues = new double[4] { 400, 200, 300, 50 },
             paramOrLabels = new string[3] { "Low", "Medium", "High" },
             paramOrColors = new string[4] { "white", "yellow", "red", "gray" }
         });

## Working with parameters

As mentioned, the input data parameterization for Chart is based on template literals/template strings.
In JavaScript the definition of a template literal is given by the following rules:
1. using backtick (`) characters to delimit the string
2. the parameter is passed using the `${parameter}` convention

However, being an implementation made in C#, the first rule is excluded, and the string delimitation will be done with ":

    `${parameter}` becomes "${parameter}"

For example:

       await map.Geometric.Points.Appearance(e => e.type == "Industrial").SetStyle(new PieChart()
         {
             dimension = 40,
    
             title = "Park",
             visibilityZoomLevels = new VisibilityZoomLevels() { minZoomLevel = 8, maxZoomLevel = 10 },
             expandedIndex = 0,
             fontSize = 8,
             paramOrValues = "${production}",
             paramOrLabels = "${texts}",
             paramOrColors = "${classes}"
         });

Where:




    public List<StreamPoint> streamPoints = new List<StreamPoint>()
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
    
                }
    }

and the IndustrialValues class is a custom class (user-defined):

In this example, the custom class is:

     public class  IndustrialValues
     {
         public double[]? production { get; set; }
         public string[]? texts { get; set; }
         public string[]? classes { get; set; }
     }

