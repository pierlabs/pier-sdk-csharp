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
    /// {{{token_partial_update_description}}}
    /// </summary>
    [DataContract]
    public partial class TokenPartialUpdateValue :  IEquatable<TokenPartialUpdateValue>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenPartialUpdateValue" /> class.
        /// Initializes a new instance of the <see cref="TokenPartialUpdateValue" />class.
        /// </summary>
        /// <param name="_Base">{{{token_dto_base_value}}}.</param>
        /// <param name="Owner">{{{token_dto_owner_value}}}.</param>
        /// <param name="CriadoPor">{{{token_dto_criado_por_value}}}.</param>
        /// <param name="AlteradoPor">{{{token_dto_alterado_por_value}}}.</param>
        /// <param name="IdAplicacao">{{{token_dto_id_application_value}}}.</param>

        public TokenPartialUpdateValue(long? _Base = null, string Owner = null, string CriadoPor = null, string AlteradoPor = null, long? IdAplicacao = null)
        {
            this._Base = _Base;
            this.Owner = Owner;
            this.CriadoPor = CriadoPor;
            this.AlteradoPor = AlteradoPor;
            this.IdAplicacao = IdAplicacao;
            
        }
        
    
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
        /// {{{token_dto_alterado_por_value}}}
        /// </summary>
        /// <value>{{{token_dto_alterado_por_value}}}</value>
        [DataMember(Name="alteradoPor", EmitDefaultValue=false)]
        public string AlteradoPor { get; set; }
    
        /// <summary>
        /// {{{token_dto_id_application_value}}}
        /// </summary>
        /// <value>{{{token_dto_id_application_value}}}</value>
        [DataMember(Name="idAplicacao", EmitDefaultValue=false)]
        public long? IdAplicacao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenPartialUpdateValue {\n");
            sb.Append("  _Base: ").Append(_Base).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  CriadoPor: ").Append(CriadoPor).Append("\n");
            sb.Append("  AlteradoPor: ").Append(AlteradoPor).Append("\n");
            sb.Append("  IdAplicacao: ").Append(IdAplicacao).Append("\n");
            
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
            return this.Equals(obj as TokenPartialUpdateValue);
        }

        /// <summary>
        /// Returns true if TokenPartialUpdateValue instances are equal
        /// </summary>
        /// <param name="other">Instance of TokenPartialUpdateValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenPartialUpdateValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.CriadoPor == other.CriadoPor ||
                    this.CriadoPor != null &&
                    this.CriadoPor.Equals(other.CriadoPor)
                ) && 
                (
                    this.AlteradoPor == other.AlteradoPor ||
                    this.AlteradoPor != null &&
                    this.AlteradoPor.Equals(other.AlteradoPor)
                ) && 
                (
                    this.IdAplicacao == other.IdAplicacao ||
                    this.IdAplicacao != null &&
                    this.IdAplicacao.Equals(other.IdAplicacao)
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
                
                if (this._Base != null)
                    hash = hash * 59 + this._Base.GetHashCode();
                
                if (this.Owner != null)
                    hash = hash * 59 + this.Owner.GetHashCode();
                
                if (this.CriadoPor != null)
                    hash = hash * 59 + this.CriadoPor.GetHashCode();
                
                if (this.AlteradoPor != null)
                    hash = hash * 59 + this.AlteradoPor.GetHashCode();
                
                if (this.IdAplicacao != null)
                    hash = hash * 59 + this.IdAplicacao.GetHashCode();
                
                return hash;
            }
        }

    }
}
