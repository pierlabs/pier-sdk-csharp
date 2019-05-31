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
    /// Representa\u00E7\u00E3o de objeto para altera\u00E7\u00E3o de dados de Configuracao de Controle do Cartao
    /// </summary>
    [DataContract]
    public partial class ConfiguracaoControleCartaoUpdate :  IEquatable<ConfiguracaoControleCartaoUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguracaoControleCartaoUpdate" /> class.
        /// Initializes a new instance of the <see cref="ConfiguracaoControleCartaoUpdate" />class.
        /// </summary>
        /// <param name="PermiteEcommerce">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es ecommerce.</param>
        /// <param name="PermiteSaque">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es de saque.</param>
        /// <param name="PermiteWallet">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es por wallet.</param>
        /// <param name="PermiteControleMCC">Indica se o cart\u00E3o est\u00E1 ativo para controle por grupos de MCCs.</param>

        public ConfiguracaoControleCartaoUpdate(bool? PermiteEcommerce = null, bool? PermiteSaque = null, bool? PermiteWallet = null, bool? PermiteControleMCC = null)
        {
            this.PermiteEcommerce = PermiteEcommerce;
            this.PermiteSaque = PermiteSaque;
            this.PermiteWallet = PermiteWallet;
            this.PermiteControleMCC = PermiteControleMCC;
            
        }
        
    
        /// <summary>
        /// Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es ecommerce
        /// </summary>
        /// <value>Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es ecommerce</value>
        [DataMember(Name="permiteEcommerce", EmitDefaultValue=false)]
        public bool? PermiteEcommerce { get; set; }
    
        /// <summary>
        /// Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es de saque
        /// </summary>
        /// <value>Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es de saque</value>
        [DataMember(Name="permiteSaque", EmitDefaultValue=false)]
        public bool? PermiteSaque { get; set; }
    
        /// <summary>
        /// Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es por wallet
        /// </summary>
        /// <value>Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es por wallet</value>
        [DataMember(Name="permiteWallet", EmitDefaultValue=false)]
        public bool? PermiteWallet { get; set; }
    
        /// <summary>
        /// Indica se o cart\u00E3o est\u00E1 ativo para controle por grupos de MCCs
        /// </summary>
        /// <value>Indica se o cart\u00E3o est\u00E1 ativo para controle por grupos de MCCs</value>
        [DataMember(Name="permiteControleMCC", EmitDefaultValue=false)]
        public bool? PermiteControleMCC { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfiguracaoControleCartaoUpdate {\n");
            sb.Append("  PermiteEcommerce: ").Append(PermiteEcommerce).Append("\n");
            sb.Append("  PermiteSaque: ").Append(PermiteSaque).Append("\n");
            sb.Append("  PermiteWallet: ").Append(PermiteWallet).Append("\n");
            sb.Append("  PermiteControleMCC: ").Append(PermiteControleMCC).Append("\n");
            
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
            return this.Equals(obj as ConfiguracaoControleCartaoUpdate);
        }

        /// <summary>
        /// Returns true if ConfiguracaoControleCartaoUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of ConfiguracaoControleCartaoUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfiguracaoControleCartaoUpdate other)
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
                ) && 
                (
                    this.PermiteControleMCC == other.PermiteControleMCC ||
                    this.PermiteControleMCC != null &&
                    this.PermiteControleMCC.Equals(other.PermiteControleMCC)
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
                
                if (this.PermiteControleMCC != null)
                    hash = hash * 59 + this.PermiteControleMCC.GetHashCode();
                
                return hash;
            }
        }

    }
}
