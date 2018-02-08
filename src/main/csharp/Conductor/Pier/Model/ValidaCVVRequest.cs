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
    /// Representa\u00C3\u00A7\u00C3\u00A3o da requisi\u00C3\u00A7\u00C3\u00A3o de valida\u00C3\u00A7\u00C3\u00A3o do CVV.
    /// </summary>
    [DataContract]
    public partial class ValidaCVVRequest :  IEquatable<ValidaCVVRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidaCVVRequest" /> class.
        /// Initializes a new instance of the <see cref="ValidaCVVRequest" />class.
        /// </summary>
        /// <param name="IdChaveCriptografia">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do chave de criptografia..</param>
        /// <param name="Cvv">Valor de Verifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (CVV)..</param>

        public ValidaCVVRequest(long? IdChaveCriptografia = null, string Cvv = null)
        {
            this.IdChaveCriptografia = IdChaveCriptografia;
            this.Cvv = Cvv;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do chave de criptografia.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do chave de criptografia.</value>
        [DataMember(Name="idChaveCriptografia", EmitDefaultValue=false)]
        public long? IdChaveCriptografia { get; set; }
    
        /// <summary>
        /// Valor de Verifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (CVV).
        /// </summary>
        /// <value>Valor de Verifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (CVV).</value>
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
