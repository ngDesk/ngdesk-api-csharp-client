/* 
 * ngDesk_Operations
 *
 * ngDesk_Operations
 *
 * OpenAPI spec version: 2.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Application
    /// </summary>
    [DataContract]
    public partial class Application :  IEquatable<Application>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Application" /> class.
        /// </summary>
        /// <param name="ApplicationId">ApplicationId.</param>
        /// <param name="ApplicationName">ApplicationName.</param>
        public Application(int? ApplicationId = default(int?), string ApplicationName = default(string))
        {
            this.ApplicationId = ApplicationId;
            this.ApplicationName = ApplicationName;
        }
        
        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name="ApplicationId", EmitDefaultValue=false)]
        public int? ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationName
        /// </summary>
        [DataMember(Name="ApplicationName", EmitDefaultValue=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Application {\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  ApplicationName: ").Append(ApplicationName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Application);
        }

        /// <summary>
        /// Returns true if Application instances are equal
        /// </summary>
        /// <param name="other">Instance of Application to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Application other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ApplicationId == other.ApplicationId ||
                    this.ApplicationId != null &&
                    this.ApplicationId.Equals(other.ApplicationId)
                ) && 
                (
                    this.ApplicationName == other.ApplicationName ||
                    this.ApplicationName != null &&
                    this.ApplicationName.Equals(other.ApplicationName)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ApplicationId != null)
                    hash = hash * 59 + this.ApplicationId.GetHashCode();
                if (this.ApplicationName != null)
                    hash = hash * 59 + this.ApplicationName.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
