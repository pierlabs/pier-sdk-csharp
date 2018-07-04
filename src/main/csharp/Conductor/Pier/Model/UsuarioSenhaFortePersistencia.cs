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
    /// {{{usuario_senha_forte_persistencia_descricao}}}
    /// </summary>
    [DataContract]
    public partial class UsuarioSenhaFortePersistencia :  IEquatable<UsuarioSenhaFortePersistencia>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsuarioSenhaFortePersistencia" /> class.
        /// Initializes a new instance of the <see cref="UsuarioSenhaFortePersistencia" />class.
        /// </summary>
        /// <param name="IdPlataforma">{{{usuario_senha_forte_persistencia_id_plataforma_descricao}}}.</param>

        public UsuarioSenhaFortePersistencia(int? IdPlataforma = null)
        {
            this.IdPlataforma = IdPlataforma;
            
        }
        
    
        /// <summary>
        /// {{{usuario_senha_forte_persistencia_id_plataforma_descricao}}}
        /// </summary>
        /// <value>{{{usuario_senha_forte_persistencia_id_plataforma_descricao}}}</value>
        [DataMember(Name="idPlataforma", EmitDefaultValue=false)]
        public int? IdPlataforma { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsuarioSenhaFortePersistencia {\n");
            sb.Append("  IdPlataforma: ").Append(IdPlataforma).Append("\n");
            
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
            return this.Equals(obj as UsuarioSenhaFortePersistencia);
        }

        /// <summary>
        /// Returns true if UsuarioSenhaFortePersistencia instances are equal
        /// </summary>
        /// <param name="other">Instance of UsuarioSenhaFortePersistencia to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsuarioSenhaFortePersistencia other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdPlataforma == other.IdPlataforma ||
                    this.IdPlataforma != null &&
                    this.IdPlataforma.Equals(other.IdPlataforma)
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
                
                if (this.IdPlataforma != null)
                    hash = hash * 59 + this.IdPlataforma.GetHashCode();
                
                return hash;
            }
        }

    }
}
