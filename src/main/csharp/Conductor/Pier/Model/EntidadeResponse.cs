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
    /// Objeto de Resposta da Entidade
    /// </summary>
    [DataContract]
    public partial class EntidadeResponse :  IEquatable<EntidadeResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EntidadeResponse" /> class.
        /// Initializes a new instance of the <see cref="EntidadeResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo de Identifica\u00E7\u00E3o da entidade..</param>
        /// <param name="Descricao">Descri\u00E7\u00E3o da entidade..</param>
        /// <param name="FlagAtivo">Flag que indica se a entidade est\u00E1 ativa..</param>

        public EntidadeResponse(long? Id = null, string Descricao = null, bool? FlagAtivo = null)
        {
            this.Id = Id;
            this.Descricao = Descricao;
            this.FlagAtivo = FlagAtivo;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da entidade.
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da entidade.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o da entidade.
        /// </summary>
        /// <value>Descri\u00E7\u00E3o da entidade.</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Flag que indica se a entidade est\u00E1 ativa.
        /// </summary>
        /// <value>Flag que indica se a entidade est\u00E1 ativa.</value>
        [DataMember(Name="flagAtivo", EmitDefaultValue=false)]
        public bool? FlagAtivo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EntidadeResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  FlagAtivo: ").Append(FlagAtivo).Append("\n");
            
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
            return this.Equals(obj as EntidadeResponse);
        }

        /// <summary>
        /// Returns true if EntidadeResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of EntidadeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntidadeResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.FlagAtivo == other.FlagAtivo ||
                    this.FlagAtivo != null &&
                    this.FlagAtivo.Equals(other.FlagAtivo)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.FlagAtivo != null)
                    hash = hash * 59 + this.FlagAtivo.GetHashCode();
                
                return hash;
            }
        }

    }
}
