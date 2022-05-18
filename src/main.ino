#include <DHT22.h>
#include <BH1750_sensor.h>
#include <HardwareSerial.h>
#include <WiFi.h>
#include <WebServer.h>

//CONFIGURACIÓN DEL TEMPORIZADOR PARA EL DEEP SLEEP:
#define uS_TO_S_FACTOR 1000000  //Conversión de microsegundos a segundos
#define TIME_TO_SLEEP  5   //Tiempo de Deep Sleep
RTC_DATA_ATTR int bootCount = 0;

#define USE_DHT22 true
#define USE_BH1750 true


void setup()
{
  Serial.begin(9600);
  delay(1000);   // tiempo para abrir el monitor serie

  #if USE_DHT22
  dht22_init();   //iniciar sensor DHT22
  #endif

  #if USE_BH1750
  bh1750_init();   //iniciar sensor BH1750
  #endif

  setup_TimerWakeUp();   //Configuración Deep Sleep
}

void loop() {}

void setup_TimerWakeUp()
{
  ++bootCount;   //Número de lectura
  Serial.println("Boot number: " + String(bootCount));
  print_wakeup_reason();   //Motivo por el que se ha interrumpido el Deep Sleep
  esp_sleep_enable_timer_wakeup(TIME_TO_SLEEP * uS_TO_S_FACTOR);   //Configuración del tiempo de Deep Sleep
  Serial.println("Setup ESP32 to sleep for every " + String(TIME_TO_SLEEP) + " Seconds");

  #if USE_DHT22
  float temp = 0;
  float hum = 0;
  temp = dht22_get_temperature();   //obtener datos de temperatura del DHT22
  hum = dht22_get_humidity();   //obtener datos de la humedad del DHT22
  Serial.println("Temperature: \t\t" + String(temp) + " C");
  Serial.println("Humidity:    \t\t" + String(hum) + " %");
  #endif

  #if USE_BH1750
  uint16_t light = 0;
  light = bh1750_get_light();   //obtener datos de la luminosidad del BH1750
  Serial.println("Light:    \t\t" + String(light) + " lux");
  #endif

  Serial.println("Going to sleep now");   //Vuelta al modo Deep Sleep
  delay(1000);
  Serial.flush(); 
  esp_deep_sleep_start();
}


//MÉTODO PARA IMPRIMIR EL MOTIVO POR EL CUAL EL SENSOR SE HA DESPERTADO
void print_wakeup_reason(){
  esp_sleep_wakeup_cause_t wakeup_reason;

  wakeup_reason = esp_sleep_get_wakeup_cause();

  switch(wakeup_reason)
  {
    case ESP_SLEEP_WAKEUP_EXT0 : Serial.println("Wakeup caused by external signal using RTC_IO"); break;
    case ESP_SLEEP_WAKEUP_EXT1 : Serial.println("Wakeup caused by external signal using RTC_CNTL"); break;
    case ESP_SLEEP_WAKEUP_TIMER : Serial.println("Wakeup caused by timer"); break;
    case ESP_SLEEP_WAKEUP_TOUCHPAD : Serial.println("Wakeup caused by touchpad"); break;
    case ESP_SLEEP_WAKEUP_ULP : Serial.println("Wakeup caused by ULP program"); break;
    default : Serial.printf("Wakeup was not caused by deep sleep: %d\n",wakeup_reason); break;
  }
}
