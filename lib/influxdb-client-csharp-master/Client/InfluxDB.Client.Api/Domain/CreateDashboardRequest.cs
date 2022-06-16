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
    /// CreateDashboardRequest
    /// </summary>
    [DataContract]
    public partial class CreateDashboardRequest : IEquatable<CreateDashboardRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDashboardRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateDashboardRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDashboardRequest" /> class.
        /// </summary>
        /// <param name="orgID">The ID of the organization that owns the dashboard. (required).</param>
        /// <param name="name">The user-facing name of the dashboard. (required).</param>
        /// <param name="description">The user-facing description of the dashboard..</param>
        public CreateDashboardRequest(string orgID = default, string name = default, string description = default)
        {
            // to ensure "orgID" is required (not null)
            if (orgID == null)
            {
                throw new InvalidDataException(
                    "orgID is a required property for CreateDashboardRequest and cannot be null");
            }

            OrgID = orgID;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException(
                    "name is a required property for CreateDashboardRequest and cannot be null");
            }

            Name = name;
            Description = description;
        }

        /// <summary>
        /// The ID of the organization that owns the dashboard.
        /// </summary>
        /// <value>The ID of the organization that owns the dashboard.</value>
        [DataMember(Name = "orgID", EmitDefaultValue = false)]
        public string OrgID { get; set; }

        /// <summary>
        /// The user-facing name of the dashboard.
        /// </summary>
        /// <value>The user-facing name of the dashboard.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The user-facing description of the dashboard.
        /// </summary>
        /// <value>The user-facing description of the dashboard.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDashboardRequest {\n");
            sb.Append("  OrgID: ").Append(OrgID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return Equals(input as CreateDashboardRequest);
        }

        /// <summary>
        /// Returns true if CreateDashboardRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateDashboardRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateDashboardRequest input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    OrgID == input.OrgID ||
                    OrgID != null && OrgID.Equals(input.OrgID)
                ) &&
                (
                    Name == input.Name ||
                    Name != null && Name.Equals(input.Name)
                ) &&
                (
                    Description == input.Description ||
                    Description != null && Description.Equals(input.Description)
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

                if (OrgID != null)
                {
                    hashCode = hashCode * 59 + OrgID.GetHashCode();
                }

                if (Name != null)
                {
                    hashCode = hashCode * 59 + Name.GetHashCode();
                }

                if (Description != null)
                {
                    hashCode = hashCode * 59 + Description.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}