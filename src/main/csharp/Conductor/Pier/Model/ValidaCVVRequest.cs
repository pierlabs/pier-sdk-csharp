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

namespace Conductor.Pier.Model
{
    /// <summary>
    /// Request Representation of the CVV validation
    /// </summary>
    [DataContract]
    public partial class ValidaCVVRequest :  IEquatable<ValidaCVVRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidaCVVRequest" /> class.
        /// Initializes a new instance of the <see cref="ValidaCVVRequest" />class.
        /// </summary>
        /// <param name="IdChaveCriptografia">Identification Code of the encrypted key.</param>
        /// <param name="Cvv">Value of the Card Checking (CVV).</param>

        public ValidaCVVRequest(long? IdChaveCriptografia = null, string Cvv = null)
        {
            this.IdChaveCriptografia = IdChaveCriptografia;
            this.Cvv = Cvv;
            
        }
        
    
        /// <summary>
        /// Identification Code of the encrypted key
        /// </summary>
        /// <value>Identification Code of the encrypted key</value>
        [DataMember(Name="idChaveCriptografia", EmitDefaultValue=false)]
        public long? IdChaveCriptografia { get; set; }
    
        /// <summary>
        /// Value of the Card Checking (CVV)
        /// </summary>
        /// <value>Value of the Card Checking (CVV)</value>
        [DataMember(Name="cvv", EmitDefaultValue=false)]
        public string Cvv { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidaCVVRequest {\n");
            sb.Append("  IdChaveCriptografia: ").Append(IdChaveCriptografia).Append("\n");
            sb.Append("  Cvv: ").Append(Cvv).Append("\n");
            
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
            return this.Equals(obj as ValidaCVVRequest);
        }

        /// <summary>
        /// Returns true if ValidaCVVRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ValidaCVVRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidaCVVRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdChaveCriptografia == other.IdChaveCriptografia ||
                    this.IdChaveCriptografia != null &&
                    this.IdChaveCriptografia.Equals(other.IdChaveCriptografia)
                ) && 
                (
                    this.Cvv == other.Cvv ||
                    this.Cvv != null &&
                    this.Cvv.Equals(other.Cvv)
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
                
                if (this.IdChaveCriptografia != null)
                    hash = hash * 59 + this.IdChaveCriptografia.GetHashCode();
                
                if (this.Cvv != null)
                    hash = hash * 59 + this.Cvv.GetHashCode();
                
                return hash;
            }
        }

    }
}
