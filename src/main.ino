//Código main.ino

#include <WiFiMulti.h>
WiFiMulti wifiMulti;

#include <DHT22.h>
#include <CCS811_sensor.h>
#include <BH1750_sensor.h>

#include <InfluxDbClient.h>
#include <InfluxDbCloud.h>

//Credenciales del wifi
#define WIFI_SSID "SSID DEL WIFI"
#define WIFI_KEY "CONTRASEÑA DEL WIFI"

//Credenciales del InfluxDB Cloud
#define INFLUXDB_CLOUD_URL "https://europe-west1-1.gcp.cloud2.influxdata.com"
#define INFLUXDB_CLOUD_TOKEN "TOKEN DEL USUARIO"
#define INFLUXDB_CLOUD_ORG "ORGANIZACIÓN DEL USUARIO DE INFLUXDB"
#define INFLUXDB_CLOUD_BUCKET "BUCKET DE ALMACENAMIENTO"
#define DEVICE_ID "CLASE EN LA QUE ESTÁ SITUADO EL SENSOR"

#define SLEEP_S 30 // Tiempo de deep sleep entre lecturas

// Cliente InfluxDB Cloud
InfluxDBClient client_cloud(INFLUXDB_CLOUD_URL, INFLUXDB_CLOUD_ORG, INFLUXDB_CLOUD_BUCKET, INFLUXDB_CLOUD_TOKEN, InfluxDbCloud2CACert);

void setup() {
  
  Serial.begin(9600);
  ccs.begin();
  bh1750_init();
  dht22_init();
  ccs_init();
  
  Serial.println("Starting setup");
  delay(100);
  wifiConnect(WIFI_SSID, WIFI_KEY);


  //ESCRITURA EN INFLUXDB CLOUD----------------------------------------------------------------------------------------------------------
  Point pointDevice("medidas"); // Nuevo punto de medidas
  pointDevice.addTag("device", DEVICE_ID);  // Añadir Tags a la toma de datos

  // Añadir valores a la toma de datos
  pointDevice.addField("temperatura", dht22_get_temperatura());
  pointDevice.addField("humedad", dht22_get_humedad());
  pointDevice.addField("luminosidad", bh1750_get_luminosidad());
  pointDevice.addField("CO2", ccs_get_co2());

  //IMPRIMIR POR LA TERMINAL LOS DATOS DE LOS SENSORES-----------------------------------------------------------------------------------
  Serial.print("\ndatos sensores:\n");
  float temp=0, hum =0, luz =0, co2 =0;
  temp= dht22_get_temperatura();
  hum=dht22_get_humedad();
  luz=bh1750_get_luminosidad();
  co2=ccs_get_co2();


  Serial.println("Temperatura: \t\t" + String(temp) + " C");
  Serial.println("Humedad:    \t\t" + String(hum) + " %");
  Serial.println("luminosidad: \t\t" + String(luz)+ " lux");
  Serial.println("co2:    \t\t" + String(co2)+ " ppm");
  Serial.print("written to InfluxDB Cloud: ");
  Serial.println(client_cloud.writePoint(pointDevice)); // Si la escritura ha sido correcta, devuelve un 1 al terminal

  WiFi.disconnect();


  //COMIENZA TIEMPO DE DEEP SLEEP HASTA LA PRÓXIMA LECTURA------------------------------------------------------------------------------
  ESP.deepSleep(SLEEP_S * 1000000 - millis()*1000); // Conversión de ms a µs
}

void loop() {}

// Conexión al wifi
void wifiConnect(const char* ssid, const char* key) {
  WiFi.begin(ssid, key);
  Serial.print("Waiting for WiFi connection..");
  while (WiFi.status() != WL_CONNECTED) {
    Serial.print(".");
    delay(500);
  }
  Serial.println(".");
  Serial.print("Successfully connected to ");
  Serial.println(WiFi.SSID());
}
