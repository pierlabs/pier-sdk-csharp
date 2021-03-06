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
    /// Objeto PlataformaMobile
    /// </summary>
    [DataContract]
    public partial class PlataformaMobileUpdate :  IEquatable<PlataformaMobileUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PlataformaMobileUpdate" /> class.
        /// Initializes a new instance of the <see cref="PlataformaMobileUpdate" />class.
        /// </summary>
        /// <param name="Nome">Nome da Plataforma (required).</param>

        public PlataformaMobileUpdate(string Nome = null)
        {
            // to ensure "Nome" is required (not null)
            if (Nome == null)
            {
                throw new InvalidDataException("Nome is a required property for PlataformaMobileUpdate and cannot be null");
            }
            else
            {
                this.Nome = Nome;
            }
            
        }
        
    
        /// <summary>
        /// Nome da Plataforma
        /// </summary>
        /// <value>Nome da Plataforma</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlataformaMobileUpdate {\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            
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
            return this.Equals(obj as PlataformaMobileUpdate);
        }

        /// <summary>
        /// Returns true if PlataformaMobileUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of PlataformaMobileUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlataformaMobileUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
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
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                return hash;
            }
        }

    }
}
