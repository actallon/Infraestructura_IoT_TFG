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
    /// StackResources
    /// </summary>
    [DataContract]
    public partial class StackResources : IEquatable<StackResources>
    {
        /// <summary>
        /// Gets or Sets Kind
        /// </summary>
        [DataMember(Name = "kind", EmitDefaultValue = false)]
        public TemplateKind? Kind { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackResources" /> class.
        /// </summary>
        /// <param name="apiVersion">apiVersion.</param>
        /// <param name="resourceID">resourceID.</param>
        /// <param name="kind">kind.</param>
        /// <param name="templateMetaName">templateMetaName.</param>
        /// <param name="associations">associations.</param>
        /// <param name="links">links.</param>
        public StackResources(string apiVersion = default, string resourceID = default, TemplateKind? kind = default,
            string templateMetaName = default, List<StackAssociations> associations = default,
            StackLinks links = default)
        {
            ApiVersion = apiVersion;
            ResourceID = resourceID;
            Kind = kind;
            TemplateMetaName = templateMetaName;
            Associations = associations;
            Links = links;
        }

        /// <summary>
        /// Gets or Sets ApiVersion
        /// </summary>
        [DataMember(Name = "apiVersion", EmitDefaultValue = false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or Sets ResourceID
        /// </summary>
        [DataMember(Name = "resourceID", EmitDefaultValue = false)]
        public string ResourceID { get; set; }


        /// <summary>
        /// Gets or Sets TemplateMetaName
        /// </summary>
        [DataMember(Name = "templateMetaName", EmitDefaultValue = false)]
        public string TemplateMetaName { get; set; }

        /// <summary>
        /// Gets or Sets Associations
        /// </summary>
        [DataMember(Name = "associations", EmitDefaultValue = false)]
        public List<StackAssociations> Associations { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public StackLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StackResources {\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  ResourceID: ").Append(ResourceID).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  TemplateMetaName: ").Append(TemplateMetaName).Append("\n");
            sb.Append("  Associations: ").Append(Associations).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return Equals(input as StackResources);
        }

        /// <summary>
        /// Returns true if StackResources instances are equal
        /// </summary>
        /// <param name="input">Instance of StackResources to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StackResources input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    ApiVersion == input.ApiVersion ||
                    ApiVersion != null && ApiVersion.Equals(input.ApiVersion)
                ) &&
                (
                    ResourceID == input.ResourceID ||
                    ResourceID != null && ResourceID.Equals(input.ResourceID)
                ) &&
                (
                    Kind == input.Kind ||
                    Kind.Equals(input.Kind)
                ) &&
                (
                    TemplateMetaName == input.TemplateMetaName ||
                    TemplateMetaName != null && TemplateMetaName.Equals(input.TemplateMetaName)
                ) &&
                (
                    Associations == input.Associations ||
                    Associations != null &&
                    Associations.SequenceEqual(input.Associations)
                ) && Links != null && Links.Equals(input.Links);
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

                if (ApiVersion != null)
                {
                    hashCode = hashCode * 59 + ApiVersion.GetHashCode();
                }

                if (ResourceID != null)
                {
                    hashCode = hashCode * 59 + ResourceID.GetHashCode();
                }

                hashCode = hashCode * 59 + Kind.GetHashCode();
                if (TemplateMetaName != null)
                {
                    hashCode = hashCode * 59 + TemplateMetaName.GetHashCode();
                }

                if (Associations != null)
                {
                    hashCode = hashCode * 59 + Associations.GetHashCode();
                }

                if (Links != null)
                {
                    hashCode = hashCode * 59 + Links.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}