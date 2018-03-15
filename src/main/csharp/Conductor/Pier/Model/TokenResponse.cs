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
    /// Representa\u00E7\u00E3o do recurso token
    /// </summary>
    [DataContract]
    public partial class TokenResponse :  IEquatable<TokenResponse>
    { 
    
        /// <summary>
        /// Status do token
        /// </summary>
        /// <value>Status do token</value>
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
        /// Status do token
        /// </summary>
        /// <value>Status do token</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenResponse" /> class.
        /// Initializes a new instance of the <see cref="TokenResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo identificador do token.</param>
        /// <param name="_Base">C\u00F3digo identificador da base.</param>
        /// <param name="Owner">Owner do token.</param>
        /// <param name="Status">Status do token.</param>
        /// <param name="CriadoPor">Descri\u00E7\u00E3o de quem criou o token.</param>
        /// <param name="DataCriacao">Data de cria\u00E7\u00E3o do token.</param>
        /// <param name="AlteradoPor">Descri\u00E7\u00E3o de quem alterou o token.</param>
        /// <param name="DataModificacao">Data de modifica\u00E7\u00E3o do token.</param>

        public TokenResponse(long? Id = null, long? _Base = null, string Owner = null, StatusEnum? Status = null, string CriadoPor = null, DateTime? DataCriacao = null, string AlteradoPor = null, DateTime? DataModificacao = null)
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
        /// C\u00F3digo identificador do token
        /// </summary>
        /// <value>C\u00F3digo identificador do token</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador da base
        /// </summary>
        /// <value>C\u00F3digo identificador da base</value>
        [DataMember(Name="base", EmitDefaultValue=false)]
        public long? _Base { get; set; }
    
        /// <summary>
        /// Owner do token
        /// </summary>
        /// <value>Owner do token</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public string Owner { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o de quem criou o token
        /// </summary>
        /// <value>Descri\u00E7\u00E3o de quem criou o token</value>
        [DataMember(Name="criadoPor", EmitDefaultValue=false)]
        public string CriadoPor { get; set; }
    
        /// <summary>
        /// Data de cria\u00E7\u00E3o do token
        /// </summary>
        /// <value>Data de cria\u00E7\u00E3o do token</value>
        [DataMember(Name="dataCriacao", EmitDefaultValue=false)]
        public DateTime? DataCriacao { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o de quem alterou o token
        /// </summary>
        /// <value>Descri\u00E7\u00E3o de quem alterou o token</value>
        [DataMember(Name="alteradoPor", EmitDefaultValue=false)]
        public string AlteradoPor { get; set; }
    
        /// <summary>
        /// Data de modifica\u00E7\u00E3o do token
        /// </summary>
        /// <value>Data de modifica\u00E7\u00E3o do token</value>
        [DataMember(Name="dataModificacao", EmitDefaultValue=false)]
        public DateTime? DataModificacao { get; set; }
    
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
