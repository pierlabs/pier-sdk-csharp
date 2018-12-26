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
    /// Representa\u00E7\u00E3o da requisi\u00E7\u00E3o da descriptografia de conteudo
    /// </summary>
    [DataContract]
    public partial class ChaveCriptografiaRequest :  IEquatable<ChaveCriptografiaRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChaveCriptografiaRequest" /> class.
        /// Initializes a new instance of the <see cref="ChaveCriptografiaRequest" />class.
        /// </summary>
        /// <param name="IdChave">Identificador da chave de descriptografia (required).</param>
        /// <param name="Conteudo">Conteudo a ser descriptografado (required).</param>

        public ChaveCriptografiaRequest(long? IdChave = null, string Conteudo = null)
        {
            // to ensure "IdChave" is required (not null)
            if (IdChave == null)
            {
                throw new InvalidDataException("IdChave is a required property for ChaveCriptografiaRequest and cannot be null");
            }
            else
            {
                this.IdChave = IdChave;
            }
            // to ensure "Conteudo" is required (not null)
            if (Conteudo == null)
            {
                throw new InvalidDataException("Conteudo is a required property for ChaveCriptografiaRequest and cannot be null");
            }
            else
            {
                this.Conteudo = Conteudo;
            }
            
        }
        
    
        /// <summary>
        /// Identificador da chave de descriptografia
        /// </summary>
        /// <value>Identificador da chave de descriptografia</value>
        [DataMember(Name="idChave", EmitDefaultValue=false)]
        public long? IdChave { get; set; }
    
        /// <summary>
        /// Conteudo a ser descriptografado
        /// </summary>
        /// <value>Conteudo a ser descriptografado</value>
        [DataMember(Name="conteudo", EmitDefaultValue=false)]
        public string Conteudo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChaveCriptografiaRequest {\n");
            sb.Append("  IdChave: ").Append(IdChave).Append("\n");
            sb.Append("  Conteudo: ").Append(Conteudo).Append("\n");
            
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
            return this.Equals(obj as ChaveCriptografiaRequest);
        }

        /// <summary>
        /// Returns true if ChaveCriptografiaRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ChaveCriptografiaRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChaveCriptografiaRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdChave == other.IdChave ||
                    this.IdChave != null &&
                    this.IdChave.Equals(other.IdChave)
                ) && 
                (
                    this.Conteudo == other.Conteudo ||
                    this.Conteudo != null &&
                    this.Conteudo.Equals(other.Conteudo)
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
                
                if (this.IdChave != null)
                    hash = hash * 59 + this.IdChave.GetHashCode();
                
                if (this.Conteudo != null)
                    hash = hash * 59 + this.Conteudo.GetHashCode();
                
                return hash;
            }
        }

    }
}
