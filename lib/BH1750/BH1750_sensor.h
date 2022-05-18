//Código BH1750_sensor.h

#ifndef BH1750_sensor_H
#define BH1750_sensor_H
#include <stdint.h>
#include <Wire.h>


void bh1750_init();
uint16_t bh1750_get_light();

#endif