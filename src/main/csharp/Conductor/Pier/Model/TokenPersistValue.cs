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
    /// {{{token_persist_description}}}
    /// </summary>
    [DataContract]
    public partial class TokenPersistValue :  IEquatable<TokenPersistValue>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenPersistValue" /> class.
        /// Initializes a new instance of the <see cref="TokenPersistValue" />class.
        /// </summary>
        /// <param name="Token">{{{token_dto_token_value}}} (required).</param>
        /// <param name="_Base">{{{token_dto_base_value}}} (required).</param>
        /// <param name="Owner">{{{token_dto_owner_value}}} (required).</param>
        /// <param name="CriadoPor">{{{token_dto_criado_por_value}}} (required).</param>

        public TokenPersistValue(string Token = null, long? _Base = null, string Owner = null, string CriadoPor = null)
        {
            // to ensure "Token" is required (not null)
            if (Token == null)
            {
                throw new InvalidDataException("Token is a required property for TokenPersistValue and cannot be null");
            }
            else
            {
                this.Token = Token;
            }
            // to ensure "_Base" is required (not null)
            if (_Base == null)
            {
                throw new InvalidDataException("_Base is a required property for TokenPersistValue and cannot be null");
            }
            else
            {
                this._Base = _Base;
            }
            // to ensure "Owner" is required (not null)
            if (Owner == null)
            {
                throw new InvalidDataException("Owner is a required property for TokenPersistValue and cannot be null");
            }
            else
            {
                this.Owner = Owner;
            }
            // to ensure "CriadoPor" is required (not null)
            if (CriadoPor == null)
            {
                throw new InvalidDataException("CriadoPor is a required property for TokenPersistValue and cannot be null");
            }
            else
            {
                this.CriadoPor = CriadoPor;
            }
            
        }
        
    
        /// <summary>
        /// {{{token_dto_token_value}}}
        /// </summary>
        /// <value>{{{token_dto_token_value}}}</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }
    
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenPersistValue {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  _Base: ").Append(_Base).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  CriadoPor: ").Append(CriadoPor).Append("\n");
            
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
            return this.Equals(obj as TokenPersistValue);
        }

        /// <summary>
        /// Returns true if TokenPersistValue instances are equal
        /// </summary>
        /// <param name="other">Instance of TokenPersistValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenPersistValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
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
                    this.CriadoPor == other.CriadoPor ||
                    this.CriadoPor != null &&
                    this.CriadoPor.Equals(other.CriadoPor)
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
                
                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
                
                if (this._Base != null)
                    hash = hash * 59 + this._Base.GetHashCode();
                
                if (this.Owner != null)
                    hash = hash * 59 + this.Owner.GetHashCode();
                
                if (this.CriadoPor != null)
                    hash = hash * 59 + this.CriadoPor.GetHashCode();
                
                return hash;
            }
        }

    }
}
