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
    /// Objeto Cartoes Lotes
    /// </summary>
    [DataContract]
    public partial class CartaoLoteResponse :  IEquatable<CartaoLoteResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoLoteResponse" /> class.
        /// Initializes a new instance of the <see cref="CartaoLoteResponse" />class.
        /// </summary>
        /// <param name="IdCartao">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (IdCartao).</param>
        /// <param name="IdLote">C\u00F3digo de identifica\u00E7\u00E3o do lote (IdLote).</param>
        /// <param name="IdCartaoPai">C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o pai.</param>

        public CartaoLoteResponse(long? IdCartao = null, long? IdLote = null, long? IdCartaoPai = null)
        {
            this.IdCartao = IdCartao;
            this.IdLote = IdLote;
            this.IdCartaoPai = IdCartaoPai;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (IdCartao)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o (IdCartao)</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do lote (IdLote)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do lote (IdLote)</value>
        [DataMember(Name="idLote", EmitDefaultValue=false)]
        public long? IdLote { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o pai
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do cart\u00E3o pai</value>
        [DataMember(Name="idCartaoPai", EmitDefaultValue=false)]
        public long? IdCartaoPai { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartaoLoteResponse {\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  IdLote: ").Append(IdLote).Append("\n");
            sb.Append("  IdCartaoPai: ").Append(IdCartaoPai).Append("\n");
            
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
            return this.Equals(obj as CartaoLoteResponse);
        }

        /// <summary>
        /// Returns true if CartaoLoteResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CartaoLoteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartaoLoteResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.IdLote == other.IdLote ||
                    this.IdLote != null &&
                    this.IdLote.Equals(other.IdLote)
                ) && 
                (
                    this.IdCartaoPai == other.IdCartaoPai ||
                    this.IdCartaoPai != null &&
                    this.IdCartaoPai.Equals(other.IdCartaoPai)
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
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.IdLote != null)
                    hash = hash * 59 + this.IdLote.GetHashCode();
                
                if (this.IdCartaoPai != null)
                    hash = hash * 59 + this.IdCartaoPai.GetHashCode();
                
                return hash;
            }
        }

    }
}
