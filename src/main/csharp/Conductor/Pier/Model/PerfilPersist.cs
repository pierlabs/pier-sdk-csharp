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
    /// {{{perfil_persist_object_description}}}
    /// </summary>
    [DataContract]
    public partial class PerfilPersist :  IEquatable<PerfilPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PerfilPersist" /> class.
        /// Initializes a new instance of the <see cref="PerfilPersist" />class.
        /// </summary>
        /// <param name="Nome">{{{perfil_persist_nome_value}}}.</param>
        /// <param name="Permissoes">{{{perfil_persist_permissoes_value}}}.</param>

        public PerfilPersist(string Nome = null, List<ReferenciaIdPersist> Permissoes = null)
        {
            this.Nome = Nome;
            this.Permissoes = Permissoes;
            
        }
        
    
        /// <summary>
        /// {{{perfil_persist_nome_value}}}
        /// </summary>
        /// <value>{{{perfil_persist_nome_value}}}</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// {{{perfil_persist_permissoes_value}}}
        /// </summary>
        /// <value>{{{perfil_persist_permissoes_value}}}</value>
        [DataMember(Name="permissoes", EmitDefaultValue=false)]
        public List<ReferenciaIdPersist> Permissoes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PerfilPersist {\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Permissoes: ").Append(Permissoes).Append("\n");
            
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
            return this.Equals(obj as PerfilPersist);
        }

        /// <summary>
        /// Returns true if PerfilPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of PerfilPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PerfilPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.Permissoes == other.Permissoes ||
                    this.Permissoes != null &&
                    this.Permissoes.SequenceEqual(other.Permissoes)
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
                
                if (this.Permissoes != null)
                    hash = hash * 59 + this.Permissoes.GetHashCode();
                
                return hash;
            }
        }

    }
}
