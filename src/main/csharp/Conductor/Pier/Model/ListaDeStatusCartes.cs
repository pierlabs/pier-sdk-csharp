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
    /// Lista de Status Cart\u00C3\u00B5es
    /// </summary>
    [DataContract]
    public partial class ListaDeStatusCartes :  IEquatable<ListaDeStatusCartes>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ListaDeStatusCartes" /> class.
        /// Initializes a new instance of the <see cref="ListaDeStatusCartes" />class.
        /// </summary>
        /// <param name="StatusCartoes">Lista de status cart\u00C3\u00B5es.</param>

        public ListaDeStatusCartes(List<EstgioCarto> StatusCartoes = null)
        {
            this.StatusCartoes = StatusCartoes;
            
        }
        
    
        /// <summary>
        /// Lista de status cart\u00C3\u00B5es
        /// </summary>
        /// <value>Lista de status cart\u00C3\u00B5es</value>
        [DataMember(Name="statusCartoes", EmitDefaultValue=false)]
        public List<EstgioCarto> StatusCartoes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListaDeStatusCartes {\n");
            sb.Append("  StatusCartoes: ").Append(StatusCartoes).Append("\n");
            
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
            return this.Equals(obj as ListaDeStatusCartes);
        }

        /// <summary>
        /// Returns true if ListaDeStatusCartes instances are equal
        /// </summary>
        /// <param name="other">Instance of ListaDeStatusCartes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListaDeStatusCartes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.StatusCartoes == other.StatusCartoes ||
                    this.StatusCartoes != null &&
                    this.StatusCartoes.SequenceEqual(other.StatusCartoes)
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
                
                if (this.StatusCartoes != null)
                    hash = hash * 59 + this.StatusCartoes.GetHashCode();
                
                return hash;
            }
        }

    }
}
