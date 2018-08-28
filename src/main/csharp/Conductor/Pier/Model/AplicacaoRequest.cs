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
    /// {{{aplicacao_request_description}}}
    /// </summary>
    [DataContract]
    public partial class AplicacaoRequest :  IEquatable<AplicacaoRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AplicacaoRequest" /> class.
        /// Initializes a new instance of the <see cref="AplicacaoRequest" />class.
        /// </summary>
        /// <param name="Nome">{{{aplicacao_dto_nome_value}}}.</param>
        /// <param name="TokenId">{{{aplicacao_dto_token_value}}}.</param>
        /// <param name="Sort">{{{global_menssagem_sort_sort}}}.</param>

        public AplicacaoRequest(string Nome = null, long? TokenId = null, List<string> Sort = null)
        {
            this.Nome = Nome;
            this.TokenId = TokenId;
            this.Sort = Sort;
            
        }
        
    
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
        /// {{{global_menssagem_sort_sort}}}
        /// </summary>
        /// <value>{{{global_menssagem_sort_sort}}}</value>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public List<string> Sort { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AplicacaoRequest {\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            
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
            return this.Equals(obj as AplicacaoRequest);
        }

        /// <summary>
        /// Returns true if AplicacaoRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AplicacaoRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AplicacaoRequest other)
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
                    this.TokenId == other.TokenId ||
                    this.TokenId != null &&
                    this.TokenId.Equals(other.TokenId)
                ) && 
                (
                    this.Sort == other.Sort ||
                    this.Sort != null &&
                    this.Sort.SequenceEqual(other.Sort)
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
                
                if (this.TokenId != null)
                    hash = hash * 59 + this.TokenId.GetHashCode();
                
                if (this.Sort != null)
                    hash = hash * 59 + this.Sort.GetHashCode();
                
                return hash;
            }
        }

    }
}
