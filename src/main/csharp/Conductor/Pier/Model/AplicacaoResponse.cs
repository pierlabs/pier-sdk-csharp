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
    /// {{{aplicacao_response_description}}}
    /// </summary>
    [DataContract]
    public partial class AplicacaoResponse :  IEquatable<AplicacaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AplicacaoResponse" /> class.
        /// Initializes a new instance of the <see cref="AplicacaoResponse" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Nome">{{{aplicacao_dto_nome_value}}}.</param>
        /// <param name="TokenId">{{{aplicacao_dto_token_value}}}.</param>

        public AplicacaoResponse(long? Id = null, string Nome = null, long? TokenId = null)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.TokenId = TokenId;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{aplicacao_dto_nome_value}}}
        /// </summary>
        /// <value>{{{aplicacao_dto_nome_value}}}</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// {{{aplicacao_dto_token_value}}}
        /// </summary>
        /// <value>{{{aplicacao_dto_token_value}}}</value>
        [DataMember(Name="tokenId", EmitDefaultValue=false)]
        public long? TokenId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AplicacaoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            
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
            return this.Equals(obj as AplicacaoResponse);
        }

        /// <summary>
        /// Returns true if AplicacaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AplicacaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AplicacaoResponse other)
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
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.TokenId == other.TokenId ||
                    this.TokenId != null &&
                    this.TokenId.Equals(other.TokenId)
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
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.TokenId != null)
                    hash = hash * 59 + this.TokenId.GetHashCode();
                
                return hash;
            }
        }

    }
}
