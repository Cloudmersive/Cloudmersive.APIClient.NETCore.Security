/* 
 * securityapi
 *
 * The security APIs help you detect and block security threats.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Cloudmersive.APIClient.NETCore.Security.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NETCore.Security.Model
{
    /// <summary>
    /// Result of performing an Insecure Deserialization JSON protection operation
    /// </summary>
    [DataContract]
    public partial class StringInsecureDeserializationJsonDetection :  IEquatable<StringInsecureDeserializationJsonDetection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StringInsecureDeserializationJsonDetection" /> class.
        /// </summary>
        /// <param name="successful">True if the operation was successful, false otherwise.</param>
        /// <param name="containedJsonInsecureDeserializationAttack">True if the input contained Insecure Deserialization JSON, false otherwise.</param>
        /// <param name="originalInput">Original input string.</param>
        public StringInsecureDeserializationJsonDetection(bool? successful = default(bool?), bool? containedJsonInsecureDeserializationAttack = default(bool?), string originalInput = default(string))
        {
            this.Successful = successful;
            this.ContainedJsonInsecureDeserializationAttack = containedJsonInsecureDeserializationAttack;
            this.OriginalInput = originalInput;
        }
        
        /// <summary>
        /// True if the operation was successful, false otherwise
        /// </summary>
        /// <value>True if the operation was successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// True if the input contained Insecure Deserialization JSON, false otherwise
        /// </summary>
        /// <value>True if the input contained Insecure Deserialization JSON, false otherwise</value>
        [DataMember(Name="ContainedJsonInsecureDeserializationAttack", EmitDefaultValue=false)]
        public bool? ContainedJsonInsecureDeserializationAttack { get; set; }

        /// <summary>
        /// Original input string
        /// </summary>
        /// <value>Original input string</value>
        [DataMember(Name="OriginalInput", EmitDefaultValue=false)]
        public string OriginalInput { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StringInsecureDeserializationJsonDetection {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  ContainedJsonInsecureDeserializationAttack: ").Append(ContainedJsonInsecureDeserializationAttack).Append("\n");
            sb.Append("  OriginalInput: ").Append(OriginalInput).Append("\n");
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
            return this.Equals(input as StringInsecureDeserializationJsonDetection);
        }

        /// <summary>
        /// Returns true if StringInsecureDeserializationJsonDetection instances are equal
        /// </summary>
        /// <param name="input">Instance of StringInsecureDeserializationJsonDetection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StringInsecureDeserializationJsonDetection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Successful == input.Successful ||
                    (this.Successful != null &&
                    this.Successful.Equals(input.Successful))
                ) && 
                (
                    this.ContainedJsonInsecureDeserializationAttack == input.ContainedJsonInsecureDeserializationAttack ||
                    (this.ContainedJsonInsecureDeserializationAttack != null &&
                    this.ContainedJsonInsecureDeserializationAttack.Equals(input.ContainedJsonInsecureDeserializationAttack))
                ) && 
                (
                    this.OriginalInput == input.OriginalInput ||
                    (this.OriginalInput != null &&
                    this.OriginalInput.Equals(input.OriginalInput))
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
                int hashCode = 41;
                if (this.Successful != null)
                    hashCode = hashCode * 59 + this.Successful.GetHashCode();
                if (this.ContainedJsonInsecureDeserializationAttack != null)
                    hashCode = hashCode * 59 + this.ContainedJsonInsecureDeserializationAttack.GetHashCode();
                if (this.OriginalInput != null)
                    hashCode = hashCode * 59 + this.OriginalInput.GetHashCode();
                return hashCode;
            }
        }
    }

}