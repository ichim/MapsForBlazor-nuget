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
