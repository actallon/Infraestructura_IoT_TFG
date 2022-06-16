//#include </Users/arancarnero/Desktop/OneDrive/TFG/TFG_iot/lib/influxdb-cxx/0.4.0>
#include </Users/arancarnero/Desktop/OneDrive/TFG/TFG_iot/lib/influxdb-cxx/0.4.0/include/InfluxDB.h>
#include </Users/arancarnero/Desktop/OneDrive/TFG/TFG_iot/lib/influxdb-cxx/0.4.0/include/InfluxDBFactory.h>
#include </Users/arancarnero/Desktop/OneDrive/TFG/TFG_iot/lib/influxdb-cxx/0.4.0/include/Point.h>
#include </Users/arancarnero/Desktop/OneDrive/TFG/TFG_iot/lib/influxdb-cxx/0.4.0/include/Transport.h>

#include <INFLUX.h>
#include <iostream>
#include <string>
#include <fstream>
#include <boost/algorithm/string.hpp>
#include <InfluxDBFactory.h>
#include “pbPlots.h”
#include “supportLib.h”
#include <chrono>

int main(int argc,char *argv[]) {
    auto db = influxdb::InfluxDBFactory::Get("http://localhost:8086");
    db-&gt;write(influxdb::Point{“temperature”}.addTag(“city”,“DALLAS”).addTag(“device”,“companyX”));
    return 0;
}


