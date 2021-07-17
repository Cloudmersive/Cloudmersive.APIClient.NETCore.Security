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
    /// Request to determine if a URL is an SSRF threat check
    /// </summary>
    [DataContract]
    public partial class UrlSsrfThreatDetectionRequestFull :  IEquatable<UrlSsrfThreatDetectionRequestFull>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UrlSsrfThreatDetectionRequestFull" /> class.
        /// </summary>
        /// <param name="uRL">URL to validate.</param>
        /// <param name="blockedDomains">Top level domains that you do not want to allow access to, e.g. mydomain.com - will block all subdomains as well.</param>
        public UrlSsrfThreatDetectionRequestFull(string uRL = default(string), List<string> blockedDomains = default(List<string>))
        {
            this.URL = uRL;
            this.BlockedDomains = blockedDomains;
        }
        
        /// <summary>
        /// URL to validate
        /// </summary>
        /// <value>URL to validate</value>
        [DataMember(Name="URL", EmitDefaultValue=false)]
        public string URL { get; set; }

        /// <summary>
        /// Top level domains that you do not want to allow access to, e.g. mydomain.com - will block all subdomains as well
        /// </summary>
        /// <value>Top level domains that you do not want to allow access to, e.g. mydomain.com - will block all subdomains as well</value>
        [DataMember(Name="BlockedDomains", EmitDefaultValue=false)]
        public List<string> BlockedDomains { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UrlSsrfThreatDetectionRequestFull {\n");
            sb.Append("  URL: ").Append(URL).Append("\n");
            sb.Append("  BlockedDomains: ").Append(BlockedDomains).Append("\n");
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
            return this.Equals(input as UrlSsrfThreatDetectionRequestFull);
        }

        /// <summary>
        /// Returns true if UrlSsrfThreatDetectionRequestFull instances are equal
        /// </summary>
        /// <param name="input">Instance of UrlSsrfThreatDetectionRequestFull to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UrlSsrfThreatDetectionRequestFull input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.URL == input.URL ||
                    (this.URL != null &&
                    this.URL.Equals(input.URL))
                ) && 
                (
                    this.BlockedDomains == input.BlockedDomains ||
                    this.BlockedDomains != null &&
                    this.BlockedDomains.SequenceEqual(input.BlockedDomains)
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
                if (this.URL != null)
                    hashCode = hashCode * 59 + this.URL.GetHashCode();
                if (this.BlockedDomains != null)
                    hashCode = hashCode * 59 + this.BlockedDomains.GetHashCode();
                return hashCode;
            }
        }
    }

}
