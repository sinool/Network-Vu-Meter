#include <ESP8266WiFi.h>
#include <WiFiUdp.h>
#include <FastLED.h>

#define DATA_PIN    4

#define LED_TYPE    WS2811
#define COLOR_ORDER GRB
#define NUM_LEDS    100
#define BRIGHTNESS    255

CRGB leds[NUM_LEDS];

// Initialize your wifi
 
const char* ssid = "YOUR_NETWORK_SSID";
const char* password = "YOUR_NETWORK_PASSWORD";

WiFiUDP Udp;
unsigned int localUdpPort = 8080;  // local port to listen on
char incomingPacket[255];  // buffer for incoming packets

void setup()
{  
 FastLED.addLeds<LED_TYPE,DATA_PIN,COLOR_ORDER>(leds, NUM_LEDS);
 FastLED.setBrightness(BRIGHTNESS);

 WiFi.softAP(ssid, password);
 IPAddress IP = WiFi.softAPIP();

 Udp.begin(localUdpPort);
}

void loop()
{
  int packetSize = Udp.parsePacket();
  if (packetSize)
  {
    int len = Udp.read(incomingPacket, 255);
    if (len > 0)
    {
      incomingPacket[len] = 0;
    }
    String rec=incomingPacket;
    int scale=rec.toInt();
    for (int i=0;i<100;i++)
    {
    leds[i]= CRGB :: Black;
    }

    for (int i=0;i<scale;i++)
    {
     leds[i].setHue(i);
    }}
 FastLED.show();

 Udp.flush();
 }


