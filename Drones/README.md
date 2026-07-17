# Drone Dashboard

SigmaDroneChart is a customizable GaugeChart.

This chart allows you to add specific indicators, such as WiFi, Battery or Altimetre.
|    | Image |
|----|----|
| Usage example | <img width="542" height="312" alt="image" src="https://github.com/user-attachments/assets/f2e3e876-f0e2-4bd5-886a-86a55533ab79" /> |


## Indicators on the center panel

WiFi:

|    | Image |
|----|----|
| WiFiIndicator | <img width="547" height="272" alt="image" src="https://github.com/user-attachments/assets/fd565bbe-1ec2-42a3-a364-976019e6ff9a" /> |

           wifiIndicator = new WiFiIndicator()
           {
               paramOrLevel = "${wifiLevel}",                                 //0 to 3
               size = 10
           },

Battery:

|    | Image |
|----|----|
| BatteryIndicator | <img width="549" height="272" alt="image" src="https://github.com/user-attachments/assets/de2878c7-ce53-40d3-aca0-57808848cc7a" /> |


            batteryIndicator = new BatteryIndicator()
            {
                paramOrLevel = "${battery}"                                 //0 to 10
            },

Altimeter:

|    | Image |
|----|----|
| AltitudeIndicator | <img width="545" height="275" alt="image" src="https://github.com/user-attachments/assets/5af6cf3c-90db-4701-b91f-88b9e4dc485c" /> |

            altitudeIndicator = new AltitudeIndicator()
            {
                paramOrAltitude = "${altitude}",
                maximumAltitude = 300,
            },

## Crown indicators

These are indicators hosted by the circular crown of the Gauge chart. An unlimited number of Crown Indicators can be configured.

             public IEnumerable<SigmaDroneObject> crownIndicators { get; set; }

1. SigmaDroneCrownScale

        public class SigmaDroneCrownScale : SigmaDroneObject
        {
            public string label { get; set; }
            public double valueStart { get; set; }
            public double valueStop { get; set; }
            public object paramOrValue { get; set; }
        }

1. SigmaDroneCrownDiscrete

        public class SigmaDroneCrownDiscrete : SigmaDroneObject
        {
            public string label { get; set; }
            public int[]? percentageValues { get; set; }
            public string[]? colors { get; set; }
            public string[]? labels { get; set; }
            public object? paramOrIndex { get; set; }
            public bool haloText { get; set; }
        }

1. SigmaDroneCrownPercent

        public class SigmaDroneCrownPercent : SigmaDroneObject
        {
            public string label { get; set; }
            public int valueStart { get; set; }
            public int valueStop { get; set; }
            public object? paramOrValue { get; set; }
            public string backgroundColor { get; set; } = "white";
            public string fillColor { get; set; } = "red";
            public bool haloText { get; set; }
        }


### SigmaDroneCrownDiscrete class
|    | Image |
|----|----|
| SigmaDroneCrownDiscrete class | <img width="555" height="267" alt="image" src="https://github.com/user-attachments/assets/d24a2fea-2aa3-43fc-99ff-1d91fd805a1c" /> |

             new SigmaDroneCrownDiscrete()
             {
                 label  = "Fuel",
                 colors = new List<string>() { "red", "orange", "yellow", "green" }.ToArray(),
                 percentageValues = new List<int>() { 33, 33, 33, 33 }.ToArray(),
                 paramOrIndex = "${fuel}",
                 labels = new List<string>() { "critical", "low", "range", "full" }.ToArray(),
                 percentageOfTheEntireCrown = 100,
                 backgroundColor = "lightgray",
                 haloText = true,
             },


### SigmaDroneCrownScale class

|    | Image |
|----|----|
| SigmaDroneCrownScale | <img width="566" height="299" alt="image" src="https://github.com/user-attachments/assets/c0892336-7ecd-4be0-bacf-ab1b72b3eeef" /> |



            new SigmaDroneCrownScale()
            {
                label = "x 1 km/h",
                valueStart = 0,
                valueStop = 120,
                paramOrValue = "${speed}",
                percentageOfTheEntireCrown = 100,
                backgroundColor = "#f8f8ff"
            },


### SigmaDroneCrownPercent class

|    | Image |
|----|----|
| SigmaDroneCrownPercent | <img width="546" height="272" alt="image" src="https://github.com/user-attachments/assets/5a77a9ed-6729-4c77-9143-e3b4f9d6b4a1" /> |




              new SigmaDroneCrownPercent()
             {
                 label = "fuel",
                 valueStart = 0,
                 valueStop = 10,
                 paramOrValue = 3,
                 percentageOfTheEntireCrown = 100,
                 backgroundColor = "lime",
                 fillColor = "orange",
                 haloText = true
             },
