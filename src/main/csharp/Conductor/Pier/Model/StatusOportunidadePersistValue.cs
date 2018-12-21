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
    /// {{{status_oportunidade_persist_description}}}
    /// </summary>
    [DataContract]
    public partial class StatusOportunidadePersistValue :  IEquatable<StatusOportunidadePersistValue>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusOportunidadePersistValue" /> class.
        /// Initializes a new instance of the <see cref="StatusOportunidadePersistValue" />class.
        /// </summary>
        /// <param name="Nome">{{{status_oportunidade_persist_nome_value}}}.</param>
        /// <param name="Descricao">{{{status_oportunidade_persist_descricao_value}}} (required).</param>
        /// <param name="FlagAtivo">{{{status_oportunidade_persist_flag_ativo_value}}} (required).</param>

        public StatusOportunidadePersistValue(string Nome = null, string Descricao = null, bool? FlagAtivo = null)
        {
            // to ensure "Descricao" is required (not null)
            if (Descricao == null)
            {
                throw new InvalidDataException("Descricao is a required property for StatusOportunidadePersistValue and cannot be null");
            }
            else
            {
                this.Descricao = Descricao;
            }
            // to ensure "FlagAtivo" is required (not null)
            if (FlagAtivo == null)
            {
                throw new InvalidDataException("FlagAtivo is a required property for StatusOportunidadePersistValue and cannot be null");
            }
            else
            {
                this.FlagAtivo = FlagAtivo;
            }
            this.Nome = Nome;
            
        }
        
    
        /// <summary>
        /// {{{status_oportunidade_persist_nome_value}}}
        /// </summary>
        /// <value>{{{status_oportunidade_persist_nome_value}}}</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// {{{status_oportunidade_persist_descricao_value}}}
        /// </summary>
        /// <value>{{{status_oportunidade_persist_descricao_value}}}</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// {{{status_oportunidade_persist_flag_ativo_value}}}
        /// </summary>
        /// <value>{{{status_oportunidade_persist_flag_ativo_value}}}</value>
        [DataMember(Name="flagAtivo", EmitDefaultValue=false)]
        public bool? FlagAtivo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusOportunidadePersistValue {\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
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
            return this.Equals(obj as StatusOportunidadePersistValue);
        }

        /// <summary>
        /// Returns true if StatusOportunidadePersistValue instances are equal
        /// </summary>
        /// <param name="other">Instance of StatusOportunidadePersistValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusOportunidadePersistValue other)
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
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.FlagAtivo != null)
                    hash = hash * 59 + this.FlagAtivo.GetHashCode();
                
                return hash;
            }
        }

    }
}
