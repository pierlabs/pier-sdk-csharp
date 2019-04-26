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
    /// Objeto para persist\u00EAncia de Configuracao de Controle do Cartao
    /// </summary>
    [DataContract]
    public partial class ConfiguracaoControleCartao :  IEquatable<ConfiguracaoControleCartao>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguracaoControleCartao" /> class.
        /// Initializes a new instance of the <see cref="ConfiguracaoControleCartao" />class.
        /// </summary>
        /// <param name="PermiteEcommerce">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es ecommerce.</param>
        /// <param name="PermiteSaque">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es de saque.</param>
        /// <param name="PermiteWallet">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es por meio wallet.</param>

        public ConfiguracaoControleCartao(int? PermiteEcommerce = null, int? PermiteSaque = null, int? PermiteWallet = null)
        {
            this.PermiteEcommerce = PermiteEcommerce;
            this.PermiteSaque = PermiteSaque;
            this.PermiteWallet = PermiteWallet;
            
        }
        
    
        /// <summary>
        /// Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es ecommerce
        /// </summary>
        /// <value>Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es ecommerce</value>
        [DataMember(Name="permiteEcommerce", EmitDefaultValue=false)]
        public int? PermiteEcommerce { get; set; }
    
        /// <summary>
        /// Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es de saque
        /// </summary>
        /// <value>Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es de saque</value>
        [DataMember(Name="permiteSaque", EmitDefaultValue=false)]
        public int? PermiteSaque { get; set; }
    
        /// <summary>
        /// Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es por meio wallet
        /// </summary>
        /// <value>Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es por meio wallet</value>
        [DataMember(Name="permiteWallet", EmitDefaultValue=false)]
        public int? PermiteWallet { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfiguracaoControleCartao {\n");
            sb.Append("  PermiteEcommerce: ").Append(PermiteEcommerce).Append("\n");
            sb.Append("  PermiteSaque: ").Append(PermiteSaque).Append("\n");
            sb.Append("  PermiteWallet: ").Append(PermiteWallet).Append("\n");
            
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
            return this.Equals(obj as ConfiguracaoControleCartao);
        }

        /// <summary>
        /// Returns true if ConfiguracaoControleCartao instances are equal
        /// </summary>
        /// <param name="other">Instance of ConfiguracaoControleCartao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfiguracaoControleCartao other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PermiteEcommerce == other.PermiteEcommerce ||
                    this.PermiteEcommerce != null &&
                    this.PermiteEcommerce.Equals(other.PermiteEcommerce)
                ) && 
                (
                    this.PermiteSaque == other.PermiteSaque ||
                    this.PermiteSaque != null &&
                    this.PermiteSaque.Equals(other.PermiteSaque)
                ) && 
                (
                    this.PermiteWallet == other.PermiteWallet ||
                    this.PermiteWallet != null &&
                    this.PermiteWallet.Equals(other.PermiteWallet)
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
                
                if (this.PermiteEcommerce != null)
                    hash = hash * 59 + this.PermiteEcommerce.GetHashCode();
                
                if (this.PermiteSaque != null)
                    hash = hash * 59 + this.PermiteSaque.GetHashCode();
                
                if (this.PermiteWallet != null)
                    hash = hash * 59 + this.PermiteWallet.GetHashCode();
                
                return hash;
            }
        }

    }
}
