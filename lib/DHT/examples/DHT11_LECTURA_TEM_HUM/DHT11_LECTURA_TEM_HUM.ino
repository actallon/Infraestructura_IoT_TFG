#include <DHT.h>           //Cargamos la librería DHT
#define DHTTYPE   DHT11   //Definimos el modelo del sensor (hay //otros DHT)
#define DHTPIN    2     // Se define el pin 2 del Arduino para conectar el sensor DHT11

DHT dht(DHTPIN, DHTTYPE, 11); 
void setup()
{
  Serial.begin(9600);   //Se inicia la comunicación serial 
  dht.begin(); 
}
void loop()
{
 float h = dht.readHumidity(); //Se lee la humedad
 float t = dht.readTemperature(); //Se lee la temperatura

 //Se imprimen las variables
  Serial.println("Humedad: "); 
  Serial.println(h);
  Serial.println("Temperatura: ");
  Serial.println(t);
  delay(2000); //Se espera 2 segundos para seguir leyendo datos
}
