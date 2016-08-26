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
    /// Lista de Pessoas
    /// </summary>
    [DataContract]
    public partial class ListaDePessoas :  IEquatable<ListaDePessoas>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ListaDePessoas" /> class.
        /// Initializes a new instance of the <see cref="ListaDePessoas" />class.
        /// </summary>
        /// <param name="Pessoas">Lista de pessoas.</param>

        public ListaDePessoas(List<Pessoa> Pessoas = null)
        {
            this.Pessoas = Pessoas;
            
        }
        
    
        /// <summary>
        /// Lista de pessoas
        /// </summary>
        /// <value>Lista de pessoas</value>
        [DataMember(Name="pessoas", EmitDefaultValue=false)]
        public List<Pessoa> Pessoas { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListaDePessoas {\n");
            sb.Append("  Pessoas: ").Append(Pessoas).Append("\n");
            
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
            return this.Equals(obj as ListaDePessoas);
        }

        /// <summary>
        /// Returns true if ListaDePessoas instances are equal
        /// </summary>
        /// <param name="other">Instance of ListaDePessoas to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListaDePessoas other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Pessoas == other.Pessoas ||
                    this.Pessoas != null &&
                    this.Pessoas.SequenceEqual(other.Pessoas)
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
                
                if (this.Pessoas != null)
                    hash = hash * 59 + this.Pessoas.GetHashCode();
                
                return hash;
            }
        }

    }
}
