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
    /// Representa o DTO de senha para usu\u00E1rio
    /// </summary>
    [DataContract]
    public partial class SenhaDTO :  IEquatable<SenhaDTO>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SenhaDTO" /> class.
        /// Initializes a new instance of the <see cref="SenhaDTO" />class.
        /// </summary>
        /// <param name="Senha">Senha que ser\u00E1 utilizada pelo usu\u00E1rio.</param>

        public SenhaDTO(string Senha = null)
        {
            this.Senha = Senha;
            
        }
        
    
        /// <summary>
        /// Senha que ser\u00E1 utilizada pelo usu\u00E1rio
        /// </summary>
        /// <value>Senha que ser\u00E1 utilizada pelo usu\u00E1rio</value>
        [DataMember(Name="senha", EmitDefaultValue=false)]
        public string Senha { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SenhaDTO {\n");
            sb.Append("  Senha: ").Append(Senha).Append("\n");
            
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
            return this.Equals(obj as SenhaDTO);
        }

        /// <summary>
        /// Returns true if SenhaDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of SenhaDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SenhaDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Senha == other.Senha ||
                    this.Senha != null &&
                    this.Senha.Equals(other.Senha)
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
                
                if (this.Senha != null)
                    hash = hash * 59 + this.Senha.GetHashCode();
                
                return hash;
            }
        }

    }
}
