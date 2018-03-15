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
    /// Representa\u00E7\u00E3o do recurso de atualiza\u00E7\u00E3o de chave
    /// </summary>
    [DataContract]
    public partial class CartaoPayKeyUpdate :  IEquatable<CartaoPayKeyUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoPayKeyUpdate" /> class.
        /// Initializes a new instance of the <see cref="CartaoPayKeyUpdate" />class.
        /// </summary>
        /// <param name="ChaveCriptograma">Chave de gera\u00E7\u00E3o de transa\u00E7\u00E3o criptografada (required).</param>

        public CartaoPayKeyUpdate(string ChaveCriptograma = null)
        {
            // to ensure "ChaveCriptograma" is required (not null)
            if (ChaveCriptograma == null)
            {
                throw new InvalidDataException("ChaveCriptograma is a required property for CartaoPayKeyUpdate and cannot be null");
            }
            else
            {
                this.ChaveCriptograma = ChaveCriptograma;
            }
            
        }
        
    
        /// <summary>
        /// Chave de gera\u00E7\u00E3o de transa\u00E7\u00E3o criptografada
        /// </summary>
        /// <value>Chave de gera\u00E7\u00E3o de transa\u00E7\u00E3o criptografada</value>
        [DataMember(Name="chaveCriptograma", EmitDefaultValue=false)]
        public string ChaveCriptograma { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartaoPayKeyUpdate {\n");
            sb.Append("  ChaveCriptograma: ").Append(ChaveCriptograma).Append("\n");
            
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
            return this.Equals(obj as CartaoPayKeyUpdate);
        }

        /// <summary>
        /// Returns true if CartaoPayKeyUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of CartaoPayKeyUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartaoPayKeyUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ChaveCriptograma == other.ChaveCriptograma ||
                    this.ChaveCriptograma != null &&
                    this.ChaveCriptograma.Equals(other.ChaveCriptograma)
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
                
                if (this.ChaveCriptograma != null)
                    hash = hash * 59 + this.ChaveCriptograma.GetHashCode();
                
                return hash;
            }
        }

    }
}
