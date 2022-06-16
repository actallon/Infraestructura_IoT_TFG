/* 
 * InfluxDB OSS API Service
 *
 * The InfluxDB v2 API provides a programmatic interface for all interactions with InfluxDB. Access the InfluxDB API using the `/api/v2/` endpoint. 
 *
 * OpenAPI spec version: 2.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = InfluxDB.Client.Api.Client.OpenAPIDateConverter;

namespace InfluxDB.Client.Api.Domain
{
    /// <summary>
    /// The state to record if check matches a criteria.
    /// </summary>
    /// <value>The state to record if check matches a criteria.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CheckStatusLevel
    {
        /// <summary>
        /// Enum UNKNOWN for value: UNKNOWN
        /// </summary>
        [EnumMember(Value = "UNKNOWN")] UNKNOWN = 1,

        /// <summary>
        /// Enum OK for value: OK
        /// </summary>
        [EnumMember(Value = "OK")] OK = 2,

        /// <summary>
        /// Enum INFO for value: INFO
        /// </summary>
        [EnumMember(Value = "INFO")] INFO = 3,

        /// <summary>
        /// Enum CRIT for value: CRIT
        /// </summary>
        [EnumMember(Value = "CRIT")] CRIT = 4,

        /// <summary>
        /// Enum WARN for value: WARN
        /// </summary>
        [EnumMember(Value = "WARN")] WARN = 5
    }
}