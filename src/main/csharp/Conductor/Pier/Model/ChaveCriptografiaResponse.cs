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
    /// Represeta o objeto resposta de Chave Criptografia
    /// </summary>
    [DataContract]
    public partial class ChaveCriptografiaResponse :  IEquatable<ChaveCriptografiaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChaveCriptografiaResponse" /> class.
        /// Initializes a new instance of the <see cref="ChaveCriptografiaResponse" />class.
        /// </summary>
        /// <param name="Conteudo">texto.</param>

        public ChaveCriptografiaResponse(string Conteudo = null)
        {
            this.Conteudo = Conteudo;
            
        }
        
    
        /// <summary>
        /// texto
        /// </summary>
        /// <value>texto</value>
        [DataMember(Name="conteudo", EmitDefaultValue=false)]
        public string Conteudo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChaveCriptografiaResponse {\n");
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
            return this.Equals(obj as ChaveCriptografiaResponse);
        }

        /// <summary>
        /// Returns true if ChaveCriptografiaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ChaveCriptografiaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChaveCriptografiaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                
                if (this.Conteudo != null)
                    hash = hash * 59 + this.Conteudo.GetHashCode();
                
                return hash;
            }
        }

    }
}
