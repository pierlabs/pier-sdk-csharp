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
    /// {{{token_response_description}}}
    /// </summary>
    [DataContract]
    public partial class TokenResponse :  IEquatable<TokenResponse>
    { 
    
        /// <summary>
        /// {{{token_dto_status_value}}}
        /// </summary>
        /// <value>{{{token_dto_status_value}}}</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "ACTIVE")]
            Active,
            
            [EnumMember(Value = "REVOKED")]
            Revoked,
            
            [EnumMember(Value = "DELETED")]
            Deleted
        }

    
        /// <summary>
        /// {{{token_dto_status_value}}}
        /// </summary>
        /// <value>{{{token_dto_status_value}}}</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenResponse" /> class.
        /// Initializes a new instance of the <see cref="TokenResponse" />class.
        /// </summary>
        /// <param name="Id">{{{token_dto_id_value}}}.</param>
        /// <param name="_Base">{{{token_dto_base_value}}}.</param>
        /// <param name="Owner">{{{token_dto_owner_value}}}.</param>
        /// <param name="Status">{{{token_dto_status_value}}}.</param>
        /// <param name="CriadoPor">{{{token_dto_criado_por_value}}}.</param>
        /// <param name="DataCriacao">{{{token_dto_data_criacao_value}}}.</param>
        /// <param name="AlteradoPor">{{{token_dto_alterado_por_value}}}.</param>
        /// <param name="DataModificacao">{{{token_dto_data_modificacao_value}}}.</param>

        public TokenResponse(long? Id = null, long? _Base = null, string Owner = null, StatusEnum? Status = null, string CriadoPor = null, string DataCriacao = null, string AlteradoPor = null, string DataModificacao = null)
        {
            this.Id = Id;
            this._Base = _Base;
            this.Owner = Owner;
            this.Status = Status;
            this.CriadoPor = CriadoPor;
            this.DataCriacao = DataCriacao;
            this.AlteradoPor = AlteradoPor;
            this.DataModificacao = DataModificacao;
            
        }
        
    
        /// <summary>
        /// {{{token_dto_id_value}}}
        /// </summary>
        /// <value>{{{token_dto_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{token_dto_base_value}}}
        /// </summary>
        /// <value>{{{token_dto_base_value}}}</value>
        [DataMember(Name="base", EmitDefaultValue=false)]
        public long? _Base { get; set; }
    
        /// <summary>
        /// {{{token_dto_owner_value}}}
        /// </summary>
        /// <value>{{{token_dto_owner_value}}}</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public string Owner { get; set; }
    
        /// <summary>
        /// {{{token_dto_criado_por_value}}}
        /// </summary>
        /// <value>{{{token_dto_criado_por_value}}}</value>
        [DataMember(Name="criadoPor", EmitDefaultValue=false)]
        public string CriadoPor { get; set; }
    
        /// <summary>
        /// {{{token_dto_data_criacao_value}}}
        /// </summary>
        /// <value>{{{token_dto_data_criacao_value}}}</value>
        [DataMember(Name="dataCriacao", EmitDefaultValue=false)]
        public string DataCriacao { get; set; }
    
        /// <summary>
        /// {{{token_dto_alterado_por_value}}}
        /// </summary>
        /// <value>{{{token_dto_alterado_por_value}}}</value>
        [DataMember(Name="alteradoPor", EmitDefaultValue=false)]
        public string AlteradoPor { get; set; }
    
        /// <summary>
        /// {{{token_dto_data_modificacao_value}}}
        /// </summary>
        /// <value>{{{token_dto_data_modificacao_value}}}</value>
        [DataMember(Name="dataModificacao", EmitDefaultValue=false)]
        public string DataModificacao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  _Base: ").Append(_Base).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CriadoPor: ").Append(CriadoPor).Append("\n");
            sb.Append("  DataCriacao: ").Append(DataCriacao).Append("\n");
            sb.Append("  AlteradoPor: ").Append(AlteradoPor).Append("\n");
            sb.Append("  DataModificacao: ").Append(DataModificacao).Append("\n");
            
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
            return this.Equals(obj as TokenResponse);
        }

        /// <summary>
        /// Returns true if TokenResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TokenResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenResponse other)
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
                    this._Base == other._Base ||
                    this._Base != null &&
                    this._Base.Equals(other._Base)
                ) && 
                (
                    this.Owner == other.Owner ||
                    this.Owner != null &&
                    this.Owner.Equals(other.Owner)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.CriadoPor == other.CriadoPor ||
                    this.CriadoPor != null &&
                    this.CriadoPor.Equals(other.CriadoPor)
                ) && 
                (
                    this.DataCriacao == other.DataCriacao ||
                    this.DataCriacao != null &&
                    this.DataCriacao.Equals(other.DataCriacao)
                ) && 
                (
                    this.AlteradoPor == other.AlteradoPor ||
                    this.AlteradoPor != null &&
                    this.AlteradoPor.Equals(other.AlteradoPor)
                ) && 
                (
                    this.DataModificacao == other.DataModificacao ||
                    this.DataModificacao != null &&
                    this.DataModificacao.Equals(other.DataModificacao)
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
                
                if (this._Base != null)
                    hash = hash * 59 + this._Base.GetHashCode();
                
                if (this.Owner != null)
                    hash = hash * 59 + this.Owner.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.CriadoPor != null)
                    hash = hash * 59 + this.CriadoPor.GetHashCode();
                
                if (this.DataCriacao != null)
                    hash = hash * 59 + this.DataCriacao.GetHashCode();
                
                if (this.AlteradoPor != null)
                    hash = hash * 59 + this.AlteradoPor.GetHashCode();
                
                if (this.DataModificacao != null)
                    hash = hash * 59 + this.DataModificacao.GetHashCode();
                
                return hash;
            }
        }

    }
}
