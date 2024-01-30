# UDP_Network_VuMeter
![snapshot](https://github.com/sinool/Network_VuMeter/assets/96464777/878cc5e1-ee2d-4b68-b882-aaeadfddf9b0)

**Hi guys! :wave:**

when i was working in a robotics and artificial intelligence competition called [RAINO CUP](https://rainocup.com/en/) , we had some building models that need some lighting for every layer and due to my passion for music and optical stuff , i decided to make a VU Meter for them by inspiring of other projects without to much information (that's why my code in like noobies :slightly_smiling_face:) . most of the vu meters in web use an extra circuit for microphone and leveling the sound but thanks to esp8266 we can do it with less components by using **UDP** protocol . now we can make everything musical if it has levels(one time i make a musical servo and its so easy to make)
I think this project is too easy but it can come handy some times and make aweasome stuff.

#REQUIRMENTS

***1.ws2811/ws2812(or anything that have many states***

***2.esp8266***

***SCHEMATIC***

![schematic](https://github.com/sinool/Network_VuMeter/assets/96464777/786c6fcb-c794-46e5-8dc4-94aca7a1ce52)

***HOW TO USE ? ***
Choose one of the codes in [ESP8266_CODE](https://github.com/sinool/Network_VuMeter/tree/main/ESP8266_CODE) and change it to your desired network credential then upload it.

connect your pc to esp wifi then open [VU_meter.exe](https://github.com/sinool/Network_VuMeter/blob/main/VU_METER/bin/Debug/net8.0-windows/VU_METER.exe) and play your music

***NOTES***

although its a easy code  by it can be more intresting to have a android app or reacting to microphone ( i use *listen to this device* option in windows) and ...

***SAMPLES***
  
https://github.com/sinool/Network_VuMeter/assets/96464777/72c34cf7-44a7-420b-acbf-73e2a39dfc43

https://github.com/sinool/Network_VuMeter/assets/96464777/10fa48ae-716e-4bf2-873e-7b83fb255e98

https://github.com/sinool/Network_VuMeter/assets/96464777/febb08eb-c149-4bca-85c1-1bcdb60968f7

(after this videos motions get smoother by make level steps from 1/10 to 1/100 with a little change in codes)

