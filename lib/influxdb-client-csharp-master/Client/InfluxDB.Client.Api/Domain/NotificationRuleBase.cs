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
    /// NotificationRuleBase
    /// </summary>
    [DataContract]
    public partial class NotificationRuleBase : IEquatable<NotificationRuleBase>
    {
        /// <summary>
        /// Defines LastRunStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LastRunStatusEnum
        {
            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")] Failed = 1,

            /// <summary>
            /// Enum Success for value: success
            /// </summary>
            [EnumMember(Value = "success")] Success = 2,

            /// <summary>
            /// Enum Canceled for value: canceled
            /// </summary>
            [EnumMember(Value = "canceled")] Canceled = 3
        }

        /// <summary>
        /// Gets or Sets LastRunStatus
        /// </summary>
        [DataMember(Name = "lastRunStatus", EmitDefaultValue = false)]
        public LastRunStatusEnum? LastRunStatus { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public TaskStatusType Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationRuleBase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NotificationRuleBase()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationRuleBase" /> class.
        /// </summary>
        /// <param name="endpointID">endpointID (required).</param>
        /// <param name="orgID">The ID of the organization that owns this notification rule. (required).</param>
        /// <param name="taskID">The ID of the task associated with this notification rule..</param>
        /// <param name="status">status (required).</param>
        /// <param name="name">Human-readable name describing the notification rule. (required).</param>
        /// <param name="sleepUntil">sleepUntil.</param>
        /// <param name="every">The notification repetition interval..</param>
        /// <param name="offset">Duration to delay after the schedule, before executing check..</param>
        /// <param name="runbookLink">runbookLink.</param>
        /// <param name="limitEvery">Don&#39;t notify me more than &lt;limit&gt; times every &lt;limitEvery&gt; seconds. If set, limit cannot be empty..</param>
        /// <param name="limit">Don&#39;t notify me more than &lt;limit&gt; times every &lt;limitEvery&gt; seconds. If set, limitEvery cannot be empty..</param>
        /// <param name="tagRules">List of tag rules the notification rule attempts to match..</param>
        /// <param name="description">An optional description of the notification rule..</param>
        /// <param name="statusRules">List of status rules the notification rule attempts to match. (required).</param>
        /// <param name="labels">labels.</param>
        /// <param name="links">links.</param>
        public NotificationRuleBase(string endpointID = default, string orgID = default, string taskID = default,
            TaskStatusType status = default, string name = default, string sleepUntil = default, string every = default,
            string offset = default, string runbookLink = default, int? limitEvery = default, int? limit = default,
            List<TagRule> tagRules = default, string description = default, List<StatusRule> statusRules = default,
            List<Label> labels = default, NotificationRuleBaseLinks links = default)
        {
            // to ensure "endpointID" is required (not null)
            if (endpointID == null)
            {
                throw new InvalidDataException(
                    "endpointID is a required property for NotificationRuleBase and cannot be null");
            }

            EndpointID = endpointID;
            // to ensure "orgID" is required (not null)
            if (orgID == null)
            {
                throw new InvalidDataException(
                    "orgID is a required property for NotificationRuleBase and cannot be null");
            }

            OrgID = orgID;
            // to ensure "status" is required (not null)
            Status = status;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException(
                    "name is a required property for NotificationRuleBase and cannot be null");
            }

            Name = name;
            // to ensure "statusRules" is required (not null)
            if (statusRules == null)
            {
                throw new InvalidDataException(
                    "statusRules is a required property for NotificationRuleBase and cannot be null");
            }

            StatusRules = statusRules;
            TaskID = taskID;
            SleepUntil = sleepUntil;
            Every = every;
            Offset = offset;
            RunbookLink = runbookLink;
            LimitEvery = limitEvery;
            Limit = limit;
            TagRules = tagRules;
            Description = description;
            Labels = labels;
            Links = links;
        }

        /// <summary>
        /// Timestamp (in RFC3339 date/time format](https://datatracker.ietf.org/doc/html/rfc3339)) of the latest scheduled and completed run.
        /// </summary>
        /// <value>Timestamp (in RFC3339 date/time format](https://datatracker.ietf.org/doc/html/rfc3339)) of the latest scheduled and completed run.</value>
        [DataMember(Name = "latestCompleted", EmitDefaultValue = false)]
        public DateTime? LatestCompleted { get; private set; }


        /// <summary>
        /// Gets or Sets LastRunError
        /// </summary>
        [DataMember(Name = "lastRunError", EmitDefaultValue = false)]
        public string LastRunError { get; private set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or Sets EndpointID
        /// </summary>
        [DataMember(Name = "endpointID", EmitDefaultValue = false)]
        public string EndpointID { get; set; }

        /// <summary>
        /// The ID of the organization that owns this notification rule.
        /// </summary>
        /// <value>The ID of the organization that owns this notification rule.</value>
        [DataMember(Name = "orgID", EmitDefaultValue = false)]
        public string OrgID { get; set; }

        /// <summary>
        /// The ID of the task associated with this notification rule.
        /// </summary>
        /// <value>The ID of the task associated with this notification rule.</value>
        [DataMember(Name = "taskID", EmitDefaultValue = false)]
        public string TaskID { get; set; }

        /// <summary>
        /// The ID of creator used to create this notification rule.
        /// </summary>
        /// <value>The ID of creator used to create this notification rule.</value>
        [DataMember(Name = "ownerID", EmitDefaultValue = false)]
        public string OwnerID { get; private set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime? UpdatedAt { get; private set; }


        /// <summary>
        /// Human-readable name describing the notification rule.
        /// </summary>
        /// <value>Human-readable name describing the notification rule.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SleepUntil
        /// </summary>
        [DataMember(Name = "sleepUntil", EmitDefaultValue = false)]
        public string SleepUntil { get; set; }

        /// <summary>
        /// The notification repetition interval.
        /// </summary>
        /// <value>The notification repetition interval.</value>
        [DataMember(Name = "every", EmitDefaultValue = false)]
        public string Every { get; set; }

        /// <summary>
        /// Duration to delay after the schedule, before executing check.
        /// </summary>
        /// <value>Duration to delay after the schedule, before executing check.</value>
        [DataMember(Name = "offset", EmitDefaultValue = false)]
        public string Offset { get; set; }

        /// <summary>
        /// Gets or Sets RunbookLink
        /// </summary>
        [DataMember(Name = "runbookLink", EmitDefaultValue = false)]
        public string RunbookLink { get; set; }

        /// <summary>
        /// Don&#39;t notify me more than &lt;limit&gt; times every &lt;limitEvery&gt; seconds. If set, limit cannot be empty.
        /// </summary>
        /// <value>Don&#39;t notify me more than &lt;limit&gt; times every &lt;limitEvery&gt; seconds. If set, limit cannot be empty.</value>
        [DataMember(Name = "limitEvery", EmitDefaultValue = false)]
        public int? LimitEvery { get; set; }

        /// <summary>
        /// Don&#39;t notify me more than &lt;limit&gt; times every &lt;limitEvery&gt; seconds. If set, limitEvery cannot be empty.
        /// </summary>
        /// <value>Don&#39;t notify me more than &lt;limit&gt; times every &lt;limitEvery&gt; seconds. If set, limitEvery cannot be empty.</value>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public int? Limit { get; set; }

        /// <summary>
        /// List of tag rules the notification rule attempts to match.
        /// </summary>
        /// <value>List of tag rules the notification rule attempts to match.</value>
        [DataMember(Name = "tagRules", EmitDefaultValue = false)]
        public List<TagRule> TagRules { get; set; }

        /// <summary>
        /// An optional description of the notification rule.
        /// </summary>
        /// <value>An optional description of the notification rule.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// List of status rules the notification rule attempts to match.
        /// </summary>
        /// <value>List of status rules the notification rule attempts to match.</value>
        [DataMember(Name = "statusRules", EmitDefaultValue = false)]
        public List<StatusRule> StatusRules { get; set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public NotificationRuleBaseLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationRuleBase {\n");
            sb.Append("  LatestCompleted: ").Append(LatestCompleted).Append("\n");
            sb.Append("  LastRunStatus: ").Append(LastRunStatus).Append("\n");
            sb.Append("  LastRunError: ").Append(LastRunError).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EndpointID: ").Append(EndpointID).Append("\n");
            sb.Append("  OrgID: ").Append(OrgID).Append("\n");
            sb.Append("  TaskID: ").Append(TaskID).Append("\n");
            sb.Append("  OwnerID: ").Append(OwnerID).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SleepUntil: ").Append(SleepUntil).Append("\n");
            sb.Append("  Every: ").Append(Every).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  RunbookLink: ").Append(RunbookLink).Append("\n");
            sb.Append("  LimitEvery: ").Append(LimitEvery).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  TagRules: ").Append(TagRules).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  StatusRules: ").Append(StatusRules).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
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
            return Equals(input as NotificationRuleBase);
        }

        /// <summary>
        /// Returns true if NotificationRuleBase instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationRuleBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationRuleBase input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    LatestCompleted == input.LatestCompleted ||
                    LatestCompleted != null && LatestCompleted.Equals(input.LatestCompleted)
                ) &&
                (
                    LastRunStatus == input.LastRunStatus ||
                    LastRunStatus.Equals(input.LastRunStatus)
                ) &&
                (
                    LastRunError == input.LastRunError ||
                    LastRunError != null && LastRunError.Equals(input.LastRunError)
                ) &&
                (
                    Id == input.Id ||
                    Id != null && Id.Equals(input.Id)
                ) &&
                (
                    EndpointID == input.EndpointID ||
                    EndpointID != null && EndpointID.Equals(input.EndpointID)
                ) &&
                (
                    OrgID == input.OrgID ||
                    OrgID != null && OrgID.Equals(input.OrgID)
                ) &&
                (
                    TaskID == input.TaskID ||
                    TaskID != null && TaskID.Equals(input.TaskID)
                ) &&
                (
                    OwnerID == input.OwnerID ||
                    OwnerID != null && OwnerID.Equals(input.OwnerID)
                ) &&
                (
                    CreatedAt == input.CreatedAt ||
                    CreatedAt != null && CreatedAt.Equals(input.CreatedAt)
                ) &&
                (
                    UpdatedAt == input.UpdatedAt ||
                    UpdatedAt != null && UpdatedAt.Equals(input.UpdatedAt)
                ) &&
                (
                    Status == input.Status ||
                    Status.Equals(input.Status)
                ) &&
                (
                    Name == input.Name ||
                    Name != null && Name.Equals(input.Name)
                ) &&
                (
                    SleepUntil == input.SleepUntil ||
                    SleepUntil != null && SleepUntil.Equals(input.SleepUntil)
                ) &&
                (
                    Every == input.Every ||
                    Every != null && Every.Equals(input.Every)
                ) &&
                (
                    Offset == input.Offset ||
                    Offset != null && Offset.Equals(input.Offset)
                ) &&
                (
                    RunbookLink == input.RunbookLink ||
                    RunbookLink != null && RunbookLink.Equals(input.RunbookLink)
                ) &&
                (
                    LimitEvery == input.LimitEvery ||
                    LimitEvery != null && LimitEvery.Equals(input.LimitEvery)
                ) &&
                (
                    Limit == input.Limit ||
                    Limit != null && Limit.Equals(input.Limit)
                ) &&
                (
                    TagRules == input.TagRules ||
                    TagRules != null &&
                    TagRules.SequenceEqual(input.TagRules)
                ) &&
                (
                    Description == input.Description ||
                    Description != null && Description.Equals(input.Description)
                ) &&
                (
                    StatusRules == input.StatusRules ||
                    StatusRules != null &&
                    StatusRules.SequenceEqual(input.StatusRules)
                ) &&
                (
                    Labels == input.Labels ||
                    Labels != null &&
                    Labels.SequenceEqual(input.Labels)
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

                if (LatestCompleted != null)
                {
                    hashCode = hashCode * 59 + LatestCompleted.GetHashCode();
                }

                hashCode = hashCode * 59 + LastRunStatus.GetHashCode();
                if (LastRunError != null)
                {
                    hashCode = hashCode * 59 + LastRunError.GetHashCode();
                }

                if (Id != null)
                {
                    hashCode = hashCode * 59 + Id.GetHashCode();
                }

                if (EndpointID != null)
                {
                    hashCode = hashCode * 59 + EndpointID.GetHashCode();
                }

                if (OrgID != null)
                {
                    hashCode = hashCode * 59 + OrgID.GetHashCode();
                }

                if (TaskID != null)
                {
                    hashCode = hashCode * 59 + TaskID.GetHashCode();
                }

                if (OwnerID != null)
                {
                    hashCode = hashCode * 59 + OwnerID.GetHashCode();
                }

                if (CreatedAt != null)
                {
                    hashCode = hashCode * 59 + CreatedAt.GetHashCode();
                }

                if (UpdatedAt != null)
                {
                    hashCode = hashCode * 59 + UpdatedAt.GetHashCode();
                }

                hashCode = hashCode * 59 + Status.GetHashCode();
                if (Name != null)
                {
                    hashCode = hashCode * 59 + Name.GetHashCode();
                }

                if (SleepUntil != null)
                {
                    hashCode = hashCode * 59 + SleepUntil.GetHashCode();
                }

                if (Every != null)
                {
                    hashCode = hashCode * 59 + Every.GetHashCode();
                }

                if (Offset != null)
                {
                    hashCode = hashCode * 59 + Offset.GetHashCode();
                }

                if (RunbookLink != null)
                {
                    hashCode = hashCode * 59 + RunbookLink.GetHashCode();
                }

                if (LimitEvery != null)
                {
                    hashCode = hashCode * 59 + LimitEvery.GetHashCode();
                }

                if (Limit != null)
                {
                    hashCode = hashCode * 59 + Limit.GetHashCode();
                }

                if (TagRules != null)
                {
                    hashCode = hashCode * 59 + TagRules.GetHashCode();
                }

                if (Description != null)
                {
                    hashCode = hashCode * 59 + Description.GetHashCode();
                }

                if (StatusRules != null)
                {
                    hashCode = hashCode * 59 + StatusRules.GetHashCode();
                }

                if (Labels != null)
                {
                    hashCode = hashCode * 59 + Labels.GetHashCode();
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