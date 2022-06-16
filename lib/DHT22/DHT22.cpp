// Código DHT22_sensor.cpp

#include "DHT22.h"
#include "DHT.h"        //Carga de la librería DHT

#define DHTTYPE   DHT22   //Definición del modelo DHT22
#define DHTPIN    4     // Se define el pin D4 del ESP32 para conectar el DHT22


DHT dht(DHTPIN, DHTTYPE, 22); 

void dht22_init() {
  dht.begin(); 
}
float dht22_get_temperatura() {
  return dht.readTemperature();
}
float dht22_get_humedad() {
  return dht.readHumidity();;
}
