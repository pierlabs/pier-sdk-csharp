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
    /// {{{cartao_impressao_multiapp_response_description}}}
    /// </summary>
    [DataContract]
    public partial class CartaoMultiAppImpressaoResponse :  IEquatable<CartaoMultiAppImpressaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoMultiAppImpressaoResponse" /> class.
        /// Initializes a new instance of the <see cref="CartaoMultiAppImpressaoResponse" />class.
        /// </summary>
        /// <param name="CartaoPai">{{{cartao_impressao_multiapp_response_cartao_pai_value}}}.</param>
        /// <param name="Cartao">{{{cartao_impressao_multiapp_response_cartao_filho_value}}}.</param>

        public CartaoMultiAppImpressaoResponse(CartaoImpressaoResponse CartaoPai = null, CartaoImpressaoResponse Cartao = null)
        {
            this.CartaoPai = CartaoPai;
            this.Cartao = Cartao;
            
        }
        
    
        /// <summary>
        /// {{{cartao_impressao_multiapp_response_cartao_pai_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_multiapp_response_cartao_pai_value}}}</value>
        [DataMember(Name="cartaoPai", EmitDefaultValue=false)]
        public CartaoImpressaoResponse CartaoPai { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_multiapp_response_cartao_filho_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_multiapp_response_cartao_filho_value}}}</value>
        [DataMember(Name="cartao", EmitDefaultValue=false)]
        public CartaoImpressaoResponse Cartao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartaoMultiAppImpressaoResponse {\n");
            sb.Append("  CartaoPai: ").Append(CartaoPai).Append("\n");
            sb.Append("  Cartao: ").Append(Cartao).Append("\n");
            
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
            return this.Equals(obj as CartaoMultiAppImpressaoResponse);
        }

        /// <summary>
        /// Returns true if CartaoMultiAppImpressaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CartaoMultiAppImpressaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartaoMultiAppImpressaoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CartaoPai == other.CartaoPai ||
                    this.CartaoPai != null &&
                    this.CartaoPai.Equals(other.CartaoPai)
                ) && 
                (
                    this.Cartao == other.Cartao ||
                    this.Cartao != null &&
                    this.Cartao.Equals(other.Cartao)
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
                
                if (this.CartaoPai != null)
                    hash = hash * 59 + this.CartaoPai.GetHashCode();
                
                if (this.Cartao != null)
                    hash = hash * 59 + this.Cartao.GetHashCode();
                
                return hash;
            }
        }

    }
}
