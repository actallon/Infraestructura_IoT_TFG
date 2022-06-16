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
    /// TemplateSummaryDiffLabelMappings
    /// </summary>
    [DataContract]
    public partial class TemplateSummaryDiffLabelMappings : IEquatable<TemplateSummaryDiffLabelMappings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateSummaryDiffLabelMappings" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="resourceType">resourceType.</param>
        /// <param name="resourceID">resourceID.</param>
        /// <param name="resourceTemplateMetaName">resourceTemplateMetaName.</param>
        /// <param name="resourceName">resourceName.</param>
        /// <param name="labelID">labelID.</param>
        /// <param name="labelTemplateMetaName">labelTemplateMetaName.</param>
        /// <param name="labelName">labelName.</param>
        public TemplateSummaryDiffLabelMappings(string status = default, string resourceType = default,
            string resourceID = default, string resourceTemplateMetaName = default, string resourceName = default,
            string labelID = default, string labelTemplateMetaName = default, string labelName = default)
        {
            Status = status;
            ResourceType = resourceType;
            ResourceID = resourceID;
            ResourceTemplateMetaName = resourceTemplateMetaName;
            ResourceName = resourceName;
            LabelID = labelID;
            LabelTemplateMetaName = labelTemplateMetaName;
            LabelName = labelName;
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets ResourceType
        /// </summary>
        [DataMember(Name = "resourceType", EmitDefaultValue = false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Gets or Sets ResourceID
        /// </summary>
        [DataMember(Name = "resourceID", EmitDefaultValue = false)]
        public string ResourceID { get; set; }

        /// <summary>
        /// Gets or Sets ResourceTemplateMetaName
        /// </summary>
        [DataMember(Name = "resourceTemplateMetaName", EmitDefaultValue = false)]
        public string ResourceTemplateMetaName { get; set; }

        /// <summary>
        /// Gets or Sets ResourceName
        /// </summary>
        [DataMember(Name = "resourceName", EmitDefaultValue = false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// Gets or Sets LabelID
        /// </summary>
        [DataMember(Name = "labelID", EmitDefaultValue = false)]
        public string LabelID { get; set; }

        /// <summary>
        /// Gets or Sets LabelTemplateMetaName
        /// </summary>
        [DataMember(Name = "labelTemplateMetaName", EmitDefaultValue = false)]
        public string LabelTemplateMetaName { get; set; }

        /// <summary>
        /// Gets or Sets LabelName
        /// </summary>
        [DataMember(Name = "labelName", EmitDefaultValue = false)]
        public string LabelName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateSummaryDiffLabelMappings {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  ResourceID: ").Append(ResourceID).Append("\n");
            sb.Append("  ResourceTemplateMetaName: ").Append(ResourceTemplateMetaName).Append("\n");
            sb.Append("  ResourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  LabelID: ").Append(LabelID).Append("\n");
            sb.Append("  LabelTemplateMetaName: ").Append(LabelTemplateMetaName).Append("\n");
            sb.Append("  LabelName: ").Append(LabelName).Append("\n");
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
            return Equals(input as TemplateSummaryDiffLabelMappings);
        }

        /// <summary>
        /// Returns true if TemplateSummaryDiffLabelMappings instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateSummaryDiffLabelMappings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateSummaryDiffLabelMappings input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    Status == input.Status ||
                    Status != null && Status.Equals(input.Status)
                ) &&
                (
                    ResourceType == input.ResourceType ||
                    ResourceType != null && ResourceType.Equals(input.ResourceType)
                ) &&
                (
                    ResourceID == input.ResourceID ||
                    ResourceID != null && ResourceID.Equals(input.ResourceID)
                ) &&
                (
                    ResourceTemplateMetaName == input.ResourceTemplateMetaName ||
                    ResourceTemplateMetaName != null && ResourceTemplateMetaName.Equals(input.ResourceTemplateMetaName)
                ) &&
                (
                    ResourceName == input.ResourceName ||
                    ResourceName != null && ResourceName.Equals(input.ResourceName)
                ) &&
                (
                    LabelID == input.LabelID ||
                    LabelID != null && LabelID.Equals(input.LabelID)
                ) &&
                (
                    LabelTemplateMetaName == input.LabelTemplateMetaName ||
                    LabelTemplateMetaName != null && LabelTemplateMetaName.Equals(input.LabelTemplateMetaName)
                ) &&
                (
                    LabelName == input.LabelName ||
                    LabelName != null && LabelName.Equals(input.LabelName)
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

                if (Status != null)
                {
                    hashCode = hashCode * 59 + Status.GetHashCode();
                }

                if (ResourceType != null)
                {
                    hashCode = hashCode * 59 + ResourceType.GetHashCode();
                }

                if (ResourceID != null)
                {
                    hashCode = hashCode * 59 + ResourceID.GetHashCode();
                }

                if (ResourceTemplateMetaName != null)
                {
                    hashCode = hashCode * 59 + ResourceTemplateMetaName.GetHashCode();
                }

                if (ResourceName != null)
                {
                    hashCode = hashCode * 59 + ResourceName.GetHashCode();
                }

                if (LabelID != null)
                {
                    hashCode = hashCode * 59 + LabelID.GetHashCode();
                }

                if (LabelTemplateMetaName != null)
                {
                    hashCode = hashCode * 59 + LabelTemplateMetaName.GetHashCode();
                }

                if (LabelName != null)
                {
                    hashCode = hashCode * 59 + LabelName.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}