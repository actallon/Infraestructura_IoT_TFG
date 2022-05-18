//Código BH1750_sensor.cpp

#include <BH1750_sensor.h>    //Cargar librería BH1750_sensor particular
#include <BH1750.h>           //Cargar librería BH1750 genérica
#include <Wire.h>

BH1750 lightMeter;

void bh1750_init()
{
  Serial.begin(9600);
  Wire.begin();
  lightMeter.begin();
}

uint16_t bh1750_get_light()
{
  return lightMeter.readLightLevel();
}