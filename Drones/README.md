# Drone Dashboard

SigmaDroneChart is a customizable GaugeChart.

This chart allows you to add specific indicators, such as WiFi, Battery or Altimetre.

<img width="542" height="312" alt="image" src="https://github.com/user-attachments/assets/f2e3e876-f0e2-4bd5-886a-86a55533ab79" />

WiFi:


           wifiIndicator = new WiFiIndicator()
           {
               paramOrLevel = "${wifiLevel}",
               size = 10
           },

Battery:

            batteryIndicator = new BatteryIndicator()
            {
                paramOrLevel = "${battery}"
            },

Altimeter:

            altitudeIndicator = new AltitudeIndicator()
            {
                paramOrAltitude = "${altitude}",
                maximumAltitude = 300,
            },
