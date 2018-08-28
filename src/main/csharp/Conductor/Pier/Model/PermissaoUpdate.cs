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
    /// {{{permissao_update_object_description}}}
    /// </summary>
    [DataContract]
    public partial class PermissaoUpdate :  IEquatable<PermissaoUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissaoUpdate" /> class.
        /// Initializes a new instance of the <see cref="PermissaoUpdate" />class.
        /// </summary>
        /// <param name="Nome">{{{permissao_update_nome_value}}}.</param>

        public PermissaoUpdate(string Nome = null)
        {
            this.Nome = Nome;
            
        }
        
    
        /// <summary>
        /// {{{permissao_update_nome_value}}}
        /// </summary>
        /// <value>{{{permissao_update_nome_value}}}</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermissaoUpdate {\n");
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
            return this.Equals(obj as PermissaoUpdate);
        }

        /// <summary>
        /// Returns true if PermissaoUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of PermissaoUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PermissaoUpdate other)
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