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
    /// Cell
    /// </summary>
    [DataContract]
    public partial class Cell : IEquatable<Cell>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cell" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="links">links.</param>
        /// <param name="x">x.</param>
        /// <param name="y">y.</param>
        /// <param name="w">w.</param>
        /// <param name="h">h.</param>
        /// <param name="viewID">The reference to a view from the views API..</param>
        public Cell(string id = default, CellLinks links = default, int? x = default, int? y = default,
            int? w = default, int? h = default, string viewID = default)
        {
            Id = id;
            Links = links;
            X = x;
            Y = y;
            W = w;
            H = h;
            ViewID = viewID;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public CellLinks Links { get; set; }

        /// <summary>
        /// Gets or Sets X
        /// </summary>
        [DataMember(Name = "x", EmitDefaultValue = false)]
        public int? X { get; set; }

        /// <summary>
        /// Gets or Sets Y
        /// </summary>
        [DataMember(Name = "y", EmitDefaultValue = false)]
        public int? Y { get; set; }

        /// <summary>
        /// Gets or Sets W
        /// </summary>
        [DataMember(Name = "w", EmitDefaultValue = false)]
        public int? W { get; set; }

        /// <summary>
        /// Gets or Sets H
        /// </summary>
        [DataMember(Name = "h", EmitDefaultValue = false)]
        public int? H { get; set; }

        /// <summary>
        /// The reference to a view from the views API.
        /// </summary>
        /// <value>The reference to a view from the views API.</value>
        [DataMember(Name = "viewID", EmitDefaultValue = false)]
        public string ViewID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cell {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  W: ").Append(W).Append("\n");
            sb.Append("  H: ").Append(H).Append("\n");
            sb.Append("  ViewID: ").Append(ViewID).Append("\n");
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
            return Equals(input as Cell);
        }

        /// <summary>
        /// Returns true if Cell instances are equal
        /// </summary>
        /// <param name="input">Instance of Cell to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cell input)
        {
            if (input == null)
            {
                return false;
            }

            return
            (
                Id == input.Id ||
                Id != null && Id.Equals(input.Id)
            ) && Links != null && Links.Equals(input.Links) && (
                X == input.X ||
                X != null && X.Equals(input.X)
            ) && (
                Y == input.Y ||
                Y != null && Y.Equals(input.Y)
            ) && (
                W == input.W ||
                W != null && W.Equals(input.W)
            ) && (
                H == input.H ||
                H != null && H.Equals(input.H)
            ) && (
                ViewID == input.ViewID ||
                ViewID != null && ViewID.Equals(input.ViewID)
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

                if (Id != null)
                {
                    hashCode = hashCode * 59 + Id.GetHashCode();
                }

                if (Links != null)
                {
                    hashCode = hashCode * 59 + Links.GetHashCode();
                }

                if (X != null)
                {
                    hashCode = hashCode * 59 + X.GetHashCode();
                }

                if (Y != null)
                {
                    hashCode = hashCode * 59 + Y.GetHashCode();
                }

                if (W != null)
                {
                    hashCode = hashCode * 59 + W.GetHashCode();
                }

                if (H != null)
                {
                    hashCode = hashCode * 59 + H.GetHashCode();
                }

                if (ViewID != null)
                {
                    hashCode = hashCode * 59 + ViewID.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}