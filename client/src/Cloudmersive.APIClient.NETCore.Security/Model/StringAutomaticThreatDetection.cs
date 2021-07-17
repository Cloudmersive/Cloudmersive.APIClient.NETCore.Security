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
    public partial class StringAutomaticThreatDetection :  IEquatable<StringAutomaticThreatDetection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StringAutomaticThreatDetection" /> class.
        /// </summary>
        /// <param name="successful">True if the operation was successful, false otherwise.</param>
        /// <param name="cleanResult">cleanResult.</param>
        /// <param name="containedJsonInsecureDeserializationAttack">True if the input contained Insecure Deserialization JSON, false otherwise.</param>
        /// <param name="containedXssThreat">True if the input contained XSS attack, false otherwise.</param>
        /// <param name="containedXxeThreat">True if the input contained XXE attack, false otherwise.</param>
        /// <param name="containedSqlInjectionThreat">True if the input contained SQL Injection attack, false otherwise.</param>
        /// <param name="containedSsrfThreat">True if the input contained an Server-Side Request Forgery (SSRF) URL attack, false otherwise.</param>
        /// <param name="isXML">True if the input string is XML, false otherwise.</param>
        /// <param name="isJSON">True if the input string is JSON, false otherwise.</param>
        /// <param name="isURL">True if the input string is a URL, false otherwise.</param>
        /// <param name="originalInput">Original input string.</param>
        public StringAutomaticThreatDetection(bool? successful = default(bool?), bool? cleanResult = default(bool?), bool? containedJsonInsecureDeserializationAttack = default(bool?), bool? containedXssThreat = default(bool?), bool? containedXxeThreat = default(bool?), bool? containedSqlInjectionThreat = default(bool?), bool? containedSsrfThreat = default(bool?), bool? isXML = default(bool?), bool? isJSON = default(bool?), bool? isURL = default(bool?), string originalInput = default(string))
        {
            this.Successful = successful;
            this.CleanResult = cleanResult;
            this.ContainedJsonInsecureDeserializationAttack = containedJsonInsecureDeserializationAttack;
            this.ContainedXssThreat = containedXssThreat;
            this.ContainedXxeThreat = containedXxeThreat;
            this.ContainedSqlInjectionThreat = containedSqlInjectionThreat;
            this.ContainedSsrfThreat = containedSsrfThreat;
            this.IsXML = isXML;
            this.IsJSON = isJSON;
            this.IsURL = isURL;
            this.OriginalInput = originalInput;
        }
        
        /// <summary>
        /// True if the operation was successful, false otherwise
        /// </summary>
        /// <value>True if the operation was successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Gets or Sets CleanResult
        /// </summary>
        [DataMember(Name="CleanResult", EmitDefaultValue=false)]
        public bool? CleanResult { get; set; }

        /// <summary>
        /// True if the input contained Insecure Deserialization JSON, false otherwise
        /// </summary>
        /// <value>True if the input contained Insecure Deserialization JSON, false otherwise</value>
        [DataMember(Name="ContainedJsonInsecureDeserializationAttack", EmitDefaultValue=false)]
        public bool? ContainedJsonInsecureDeserializationAttack { get; set; }

        /// <summary>
        /// True if the input contained XSS attack, false otherwise
        /// </summary>
        /// <value>True if the input contained XSS attack, false otherwise</value>
        [DataMember(Name="ContainedXssThreat", EmitDefaultValue=false)]
        public bool? ContainedXssThreat { get; set; }

        /// <summary>
        /// True if the input contained XXE attack, false otherwise
        /// </summary>
        /// <value>True if the input contained XXE attack, false otherwise</value>
        [DataMember(Name="ContainedXxeThreat", EmitDefaultValue=false)]
        public bool? ContainedXxeThreat { get; set; }

        /// <summary>
        /// True if the input contained SQL Injection attack, false otherwise
        /// </summary>
        /// <value>True if the input contained SQL Injection attack, false otherwise</value>
        [DataMember(Name="ContainedSqlInjectionThreat", EmitDefaultValue=false)]
        public bool? ContainedSqlInjectionThreat { get; set; }

        /// <summary>
        /// True if the input contained an Server-Side Request Forgery (SSRF) URL attack, false otherwise
        /// </summary>
        /// <value>True if the input contained an Server-Side Request Forgery (SSRF) URL attack, false otherwise</value>
        [DataMember(Name="ContainedSsrfThreat", EmitDefaultValue=false)]
        public bool? ContainedSsrfThreat { get; set; }

        /// <summary>
        /// True if the input string is XML, false otherwise
        /// </summary>
        /// <value>True if the input string is XML, false otherwise</value>
        [DataMember(Name="IsXML", EmitDefaultValue=false)]
        public bool? IsXML { get; set; }

        /// <summary>
        /// True if the input string is JSON, false otherwise
        /// </summary>
        /// <value>True if the input string is JSON, false otherwise</value>
        [DataMember(Name="IsJSON", EmitDefaultValue=false)]
        public bool? IsJSON { get; set; }

        /// <summary>
        /// True if the input string is a URL, false otherwise
        /// </summary>
        /// <value>True if the input string is a URL, false otherwise</value>
        [DataMember(Name="IsURL", EmitDefaultValue=false)]
        public bool? IsURL { get; set; }

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
            sb.Append("class StringAutomaticThreatDetection {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  CleanResult: ").Append(CleanResult).Append("\n");
            sb.Append("  ContainedJsonInsecureDeserializationAttack: ").Append(ContainedJsonInsecureDeserializationAttack).Append("\n");
            sb.Append("  ContainedXssThreat: ").Append(ContainedXssThreat).Append("\n");
            sb.Append("  ContainedXxeThreat: ").Append(ContainedXxeThreat).Append("\n");
            sb.Append("  ContainedSqlInjectionThreat: ").Append(ContainedSqlInjectionThreat).Append("\n");
            sb.Append("  ContainedSsrfThreat: ").Append(ContainedSsrfThreat).Append("\n");
            sb.Append("  IsXML: ").Append(IsXML).Append("\n");
            sb.Append("  IsJSON: ").Append(IsJSON).Append("\n");
            sb.Append("  IsURL: ").Append(IsURL).Append("\n");
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
            return this.Equals(input as StringAutomaticThreatDetection);
        }

        /// <summary>
        /// Returns true if StringAutomaticThreatDetection instances are equal
        /// </summary>
        /// <param name="input">Instance of StringAutomaticThreatDetection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StringAutomaticThreatDetection input)
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
                    this.CleanResult == input.CleanResult ||
                    (this.CleanResult != null &&
                    this.CleanResult.Equals(input.CleanResult))
                ) && 
                (
                    this.ContainedJsonInsecureDeserializationAttack == input.ContainedJsonInsecureDeserializationAttack ||
                    (this.ContainedJsonInsecureDeserializationAttack != null &&
                    this.ContainedJsonInsecureDeserializationAttack.Equals(input.ContainedJsonInsecureDeserializationAttack))
                ) && 
                (
                    this.ContainedXssThreat == input.ContainedXssThreat ||
                    (this.ContainedXssThreat != null &&
                    this.ContainedXssThreat.Equals(input.ContainedXssThreat))
                ) && 
                (
                    this.ContainedXxeThreat == input.ContainedXxeThreat ||
                    (this.ContainedXxeThreat != null &&
                    this.ContainedXxeThreat.Equals(input.ContainedXxeThreat))
                ) && 
                (
                    this.ContainedSqlInjectionThreat == input.ContainedSqlInjectionThreat ||
                    (this.ContainedSqlInjectionThreat != null &&
                    this.ContainedSqlInjectionThreat.Equals(input.ContainedSqlInjectionThreat))
                ) && 
                (
                    this.ContainedSsrfThreat == input.ContainedSsrfThreat ||
                    (this.ContainedSsrfThreat != null &&
                    this.ContainedSsrfThreat.Equals(input.ContainedSsrfThreat))
                ) && 
                (
                    this.IsXML == input.IsXML ||
                    (this.IsXML != null &&
                    this.IsXML.Equals(input.IsXML))
                ) && 
                (
                    this.IsJSON == input.IsJSON ||
                    (this.IsJSON != null &&
                    this.IsJSON.Equals(input.IsJSON))
                ) && 
                (
                    this.IsURL == input.IsURL ||
                    (this.IsURL != null &&
                    this.IsURL.Equals(input.IsURL))
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
                if (this.CleanResult != null)
                    hashCode = hashCode * 59 + this.CleanResult.GetHashCode();
                if (this.ContainedJsonInsecureDeserializationAttack != null)
                    hashCode = hashCode * 59 + this.ContainedJsonInsecureDeserializationAttack.GetHashCode();
                if (this.ContainedXssThreat != null)
                    hashCode = hashCode * 59 + this.ContainedXssThreat.GetHashCode();
                if (this.ContainedXxeThreat != null)
                    hashCode = hashCode * 59 + this.ContainedXxeThreat.GetHashCode();
                if (this.ContainedSqlInjectionThreat != null)
                    hashCode = hashCode * 59 + this.ContainedSqlInjectionThreat.GetHashCode();
                if (this.ContainedSsrfThreat != null)
                    hashCode = hashCode * 59 + this.ContainedSsrfThreat.GetHashCode();
                if (this.IsXML != null)
                    hashCode = hashCode * 59 + this.IsXML.GetHashCode();
                if (this.IsJSON != null)
                    hashCode = hashCode * 59 + this.IsJSON.GetHashCode();
                if (this.IsURL != null)
                    hashCode = hashCode * 59 + this.IsURL.GetHashCode();
                if (this.OriginalInput != null)
                    hashCode = hashCode * 59 + this.OriginalInput.GetHashCode();
                return hashCode;
            }
        }
    }

}