# Quarter Charts

It represents a set of 1 to 4 Gause graphs that can be used for various purposes. One of the areas of use can be fleet monitoring.
These Gauge charts, hosted by a quarter circle, are configurable and can operate via dynamic parameters.

<img width="988" height="789" alt="image" src="https://github.com/user-attachments/assets/bf8c5450-f20d-42d2-9e1c-434ddd25997d" />


                     await map.Geometric.Points.Appearance(e => e.type == "SigmaDrone").SetStyle(new QuartersCharts() {
                     title = "quarters", 
                     visibilityZoomLevels = new VisibilityZoomLevels() { minZoomLevel = 4,maxZoomLevel = 18 }, 
                     dimension = 62, 
                     quartersCharts = new List<QuarterObject>()
                     {
                            new QuarterGaugeFillChartBase()
                            {
                                fillingColor = "red",
                                fillPanel = "white",
                                paramOrValueStart = 0,
                                paramOrValueStop = 100,
                                paramOrValue = 80,
                                label = "Fuel"

                            } ,
                                 new QuarterGaugeScaleChartBase()
                            {

                                fillPanel = "azure",
                                paramOrValueStart = 10,
                                paramOrValueStop = 200,
                                paramOrValue = 130,
                                label = "Speed"

                            },
                            new QuarterGaugeScaleAndPercentChartBase()
                            {
                               fillingColor="orange",
                               fillPanel = "white",
                               paramOrValueStart = 0,
                               paramOrValueStop = 100,
                               paramOrValue = 80,
                               fontSize = 4,
                               haloText = true,
                               label = "Battery",
                               heightCrownInner = 9,
                               heightCrownInner2 = 8,
                               heightCrownOuter=8,
                               paramOrIndexQuadrant=3,
                               type = QuarterGaugeScalePercentType.HowManyAreLeft
                            },
                        
                         
                        } 
                 });
