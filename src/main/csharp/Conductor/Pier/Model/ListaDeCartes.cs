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
    /// Lista de Cart\u00C3\u00B5es
    /// </summary>
    [DataContract]
    public partial class ListaDeCartes :  IEquatable<ListaDeCartes>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ListaDeCartes" /> class.
        /// Initializes a new instance of the <see cref="ListaDeCartes" />class.
        /// </summary>
        /// <param name="Cartoes">Lista de cart\u00C3\u00B5es.</param>

        public ListaDeCartes(List<CartaoResponse> Cartoes = null)
        {
            this.Cartoes = Cartoes;
            
        }
        
    
        /// <summary>
        /// Lista de cart\u00C3\u00B5es
        /// </summary>
        /// <value>Lista de cart\u00C3\u00B5es</value>
        [DataMember(Name="cartoes", EmitDefaultValue=false)]
        public List<CartaoResponse> Cartoes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListaDeCartes {\n");
            sb.Append("  Cartoes: ").Append(Cartoes).Append("\n");
            
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
            return this.Equals(obj as ListaDeCartes);
        }

        /// <summary>
        /// Returns true if ListaDeCartes instances are equal
        /// </summary>
        /// <param name="other">Instance of ListaDeCartes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListaDeCartes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Cartoes == other.Cartoes ||
                    this.Cartoes != null &&
                    this.Cartoes.SequenceEqual(other.Cartoes)
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
                
                if (this.Cartoes != null)
                    hash = hash * 59 + this.Cartoes.GetHashCode();
                
                return hash;
            }
        }

    }
}
