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
    /// Dashboards
    /// </summary>
    [DataContract]
    public partial class Dashboards : IEquatable<Dashboards>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dashboards" /> class.
        /// </summary>
        /// <param name="links">links.</param>
        /// <param name="dashboards">dashboards.</param>
        public Dashboards(Links links = default, List<Dashboard> dashboards = default)
        {
            Links = links;
            _Dashboards = dashboards;
        }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public Links Links { get; set; }

        /// <summary>
        /// Gets or Sets _Dashboards
        /// </summary>
        [DataMember(Name = "dashboards", EmitDefaultValue = false)]
        public List<Dashboard> _Dashboards { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Dashboards {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  _Dashboards: ").Append(_Dashboards).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as Dashboards);
        }

        /// <summary>
        /// Returns true if Dashboards instances are equal
        /// </summary>
        /// <param name="input">Instance of Dashboards to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Dashboards input)
        {
            if (input == null)
            {
                return false;
            }

            return
                Links != null && Links.Equals(input.Links) &&
                (
                    _Dashboards == input._Dashboards ||
                    _Dashboards != null &&
                    _Dashboards.SequenceEqual(input._Dashboards)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;

                if (Links != null)
                {
                    hashCode = hashCode * 59 + Links.GetHashCode();
                }

                if (_Dashboards != null)
                {
                    hashCode = hashCode * 59 + _Dashboards.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}