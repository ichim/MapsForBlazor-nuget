# Drone Dashboard

SigmaDroneChart is a customizable GaugeChart.

This chart allows you to add specific indicators, such as WiFi, Battery or Altimetre.
|    | Image |
|----|----|
| Usage example | <img width="542" height="312" alt="image" src="https://github.com/user-attachments/assets/f2e3e876-f0e2-4bd5-886a-86a55533ab79" /> |


## Indicators on the center panel

WiFi:


           wifiIndicator = new WiFiIndicator()
           {
               paramOrLevel = "${wifiLevel}",                                 //0 to 3
               size = 10
           },

Battery:

            batteryIndicator = new BatteryIndicator()
            {
                paramOrLevel = "${battery}"                                 //0 to 10
            },

Altimeter:

            altitudeIndicator = new AltitudeIndicator()
            {
                paramOrAltitude = "${altitude}",
                maximumAltitude = 300,
            },

## Crown indicators

These are indicators hosted by the circular crown of the Gauge chart. An unlimited number of Crown Indicators can be configured.

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
