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
    /// Representa\u00C3\u00A7\u00C3\u00A3o do recurso validar c\u00C3\u00B3digo de seguran\u00C3\u00A7a.
    /// </summary>
    [DataContract]
    public partial class CodigoSegurancaEMAILPersist :  IEquatable<CodigoSegurancaEMAILPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CodigoSegurancaEMAILPersist" /> class.
        /// Initializes a new instance of the <see cref="CodigoSegurancaEMAILPersist" />class.
        /// </summary>
        /// <param name="Email">E-mail usado para envio do c\u00C3\u00B3digo de seguran\u00C3\u00A7a..</param>
        /// <param name="CodigoSeguranca">Token para valida\u00C3\u00A7\u00C3\u00A3o..</param>

        public CodigoSegurancaEMAILPersist(string Email = null, string CodigoSeguranca = null)
        {
            this.Email = Email;
            this.CodigoSeguranca = CodigoSeguranca;
            
        }
        
    
        /// <summary>
        /// E-mail usado para envio do c\u00C3\u00B3digo de seguran\u00C3\u00A7a.
        /// </summary>
        /// <value>E-mail usado para envio do c\u00C3\u00B3digo de seguran\u00C3\u00A7a.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Token para valida\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Token para valida\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="codigoSeguranca", EmitDefaultValue=false)]
        public string CodigoSeguranca { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CodigoSegurancaEMAILPersist {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  CodigoSeguranca: ").Append(CodigoSeguranca).Append("\n");
            
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
            return this.Equals(obj as CodigoSegurancaEMAILPersist);
        }

        /// <summary>
        /// Returns true if CodigoSegurancaEMAILPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of CodigoSegurancaEMAILPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CodigoSegurancaEMAILPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.CodigoSeguranca == other.CodigoSeguranca ||
                    this.CodigoSeguranca != null &&
                    this.CodigoSeguranca.Equals(other.CodigoSeguranca)
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
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.CodigoSeguranca != null)
                    hash = hash * 59 + this.CodigoSeguranca.GetHashCode();
                
                return hash;
            }
        }

    }
}
