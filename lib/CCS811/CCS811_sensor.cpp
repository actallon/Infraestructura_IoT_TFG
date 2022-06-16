// Código CCS811_sensor.cpp

#include "CCS811_sensor.h"
#include <Wire.h> 
#include<WebServer.h>
//#include <ccs811.h>
#include "Adafruit_CCS811.h"

//CCS811 ccs811(23);
Adafruit_CCS811 sensor;

void ccs_init() {
  Serial.begin(9600);
  Wire.begin();
  sensor.begin();
}
int ccs_get_co2() {
  int co2 = sensor.geteCO2();
  return co2;
}
