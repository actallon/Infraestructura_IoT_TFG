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
    /// TemplateApplyRemotes
    /// </summary>
    [DataContract]
    public partial class TemplateApplyRemotes : IEquatable<TemplateApplyRemotes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateApplyRemotes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TemplateApplyRemotes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateApplyRemotes" /> class.
        /// </summary>
        /// <param name="url">url (required).</param>
        /// <param name="contentType">contentType.</param>
        public TemplateApplyRemotes(string url = default, string contentType = default)
        {
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new InvalidDataException(
                    "url is a required property for TemplateApplyRemotes and cannot be null");
            }

            Url = url;
            ContentType = contentType;
        }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name = "contentType", EmitDefaultValue = false)]
        public string ContentType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateApplyRemotes {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
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
            return Equals(input as TemplateApplyRemotes);
        }

        /// <summary>
        /// Returns true if TemplateApplyRemotes instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateApplyRemotes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateApplyRemotes input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    Url == input.Url ||
                    Url != null && Url.Equals(input.Url)
                ) &&
                (
                    ContentType == input.ContentType ||
                    ContentType != null && ContentType.Equals(input.ContentType)
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

                if (Url != null)
                {
                    hashCode = hashCode * 59 + Url.GetHashCode();
                }

                if (ContentType != null)
                {
                    hashCode = hashCode * 59 + ContentType.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}