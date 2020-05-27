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
    public partial class ConfiguracaoControleCartaoPersist :  IEquatable<ConfiguracaoControleCartaoPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguracaoControleCartaoPersist" /> class.
        /// Initializes a new instance of the <see cref="ConfiguracaoControleCartaoPersist" />class.
        /// </summary>
        /// <param name="PermiteEcommerce">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es ecommerce.</param>
        /// <param name="PermiteSaque">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es de saque.</param>
        /// <param name="PermiteWallet">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es por meio wallet.</param>
        /// <param name="PermiteControleMCC">Indica se o cart\u00E3o est\u00E1 ativo para controle por grupos de MCCs.</param>
        /// <param name="PermiteCompraInternacional">Indica se o cart\u00E3o est\u00E1 habilitado/desabilitado para transa\u00E7\u00F5es internacionais.</param>
        /// <param name="PermiteTarjaMagnetica">Indica se o cart\u00E3o est\u00E1 habilitado/desabilitado para transa\u00E7\u00F5es por tarja magnetica.</param>
        /// <param name="PermiteContactless">Indica se o cart\u00E3o est\u00E1 habilitado/desabilitado para transa\u00E7\u00F5es via contactless.</param>
        /// <param name="LimiteContactlessSemSenha">Indica o limite usado em transa\u00E7\u00F5es com a fun\u00E7\u00E3o contactless sem senha. O valor m\u00E1ximo \u00E9 50 e o m\u00EDnimo \u00E9 1..</param>
        /// <param name="FuncaoAtiva">Indica o tipo de fun\u00E7\u00E3o ativa.</param>

        public ConfiguracaoControleCartaoPersist(bool? PermiteEcommerce = null, bool? PermiteSaque = null, bool? PermiteWallet = null, bool? PermiteControleMCC = null, bool? PermiteCompraInternacional = null, bool? PermiteTarjaMagnetica = null, bool? PermiteContactless = null, double? LimiteContactlessSemSenha = null, string FuncaoAtiva = null)
        {
            this.PermiteEcommerce = PermiteEcommerce;
            this.PermiteSaque = PermiteSaque;
            this.PermiteWallet = PermiteWallet;
            this.PermiteControleMCC = PermiteControleMCC;
            this.PermiteCompraInternacional = PermiteCompraInternacional;
            this.PermiteTarjaMagnetica = PermiteTarjaMagnetica;
            this.PermiteContactless = PermiteContactless;
            this.LimiteContactlessSemSenha = LimiteContactlessSemSenha;
            this.FuncaoAtiva = FuncaoAtiva;
            
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
        /// Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es por meio wallet
        /// </summary>
        /// <value>Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es por meio wallet</value>
        [DataMember(Name="permiteWallet", EmitDefaultValue=false)]
        public bool? PermiteWallet { get; set; }
    
        /// <summary>
        /// Indica se o cart\u00E3o est\u00E1 ativo para controle por grupos de MCCs
        /// </summary>
        /// <value>Indica se o cart\u00E3o est\u00E1 ativo para controle por grupos de MCCs</value>
        [DataMember(Name="permiteControleMCC", EmitDefaultValue=false)]
        public bool? PermiteControleMCC { get; set; }
    
        /// <summary>
        /// Indica se o cart\u00E3o est\u00E1 habilitado/desabilitado para transa\u00E7\u00F5es internacionais
        /// </summary>
        /// <value>Indica se o cart\u00E3o est\u00E1 habilitado/desabilitado para transa\u00E7\u00F5es internacionais</value>
        [DataMember(Name="permiteCompraInternacional", EmitDefaultValue=false)]
        public bool? PermiteCompraInternacional { get; set; }
    
        /// <summary>
        /// Indica se o cart\u00E3o est\u00E1 habilitado/desabilitado para transa\u00E7\u00F5es por tarja magnetica
        /// </summary>
        /// <value>Indica se o cart\u00E3o est\u00E1 habilitado/desabilitado para transa\u00E7\u00F5es por tarja magnetica</value>
        [DataMember(Name="permiteTarjaMagnetica", EmitDefaultValue=false)]
        public bool? PermiteTarjaMagnetica { get; set; }
    
        /// <summary>
        /// Indica se o cart\u00E3o est\u00E1 habilitado/desabilitado para transa\u00E7\u00F5es via contactless
        /// </summary>
        /// <value>Indica se o cart\u00E3o est\u00E1 habilitado/desabilitado para transa\u00E7\u00F5es via contactless</value>
        [DataMember(Name="permiteContactless", EmitDefaultValue=false)]
        public bool? PermiteContactless { get; set; }
    
        /// <summary>
        /// Indica o limite usado em transa\u00E7\u00F5es com a fun\u00E7\u00E3o contactless sem senha. O valor m\u00E1ximo \u00E9 50 e o m\u00EDnimo \u00E9 1.
        /// </summary>
        /// <value>Indica o limite usado em transa\u00E7\u00F5es com a fun\u00E7\u00E3o contactless sem senha. O valor m\u00E1ximo \u00E9 50 e o m\u00EDnimo \u00E9 1.</value>
        [DataMember(Name="limiteContactlessSemSenha", EmitDefaultValue=false)]
        public double? LimiteContactlessSemSenha { get; set; }
    
        /// <summary>
        /// Indica o tipo de fun\u00E7\u00E3o ativa
        /// </summary>
        /// <value>Indica o tipo de fun\u00E7\u00E3o ativa</value>
        [DataMember(Name="funcaoAtiva", EmitDefaultValue=false)]
        public string FuncaoAtiva { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfiguracaoControleCartaoPersist {\n");
            sb.Append("  PermiteEcommerce: ").Append(PermiteEcommerce).Append("\n");
            sb.Append("  PermiteSaque: ").Append(PermiteSaque).Append("\n");
            sb.Append("  PermiteWallet: ").Append(PermiteWallet).Append("\n");
            sb.Append("  PermiteControleMCC: ").Append(PermiteControleMCC).Append("\n");
            sb.Append("  PermiteCompraInternacional: ").Append(PermiteCompraInternacional).Append("\n");
            sb.Append("  PermiteTarjaMagnetica: ").Append(PermiteTarjaMagnetica).Append("\n");
            sb.Append("  PermiteContactless: ").Append(PermiteContactless).Append("\n");
            sb.Append("  LimiteContactlessSemSenha: ").Append(LimiteContactlessSemSenha).Append("\n");
            sb.Append("  FuncaoAtiva: ").Append(FuncaoAtiva).Append("\n");
            
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
            return this.Equals(obj as ConfiguracaoControleCartaoPersist);
        }

        /// <summary>
        /// Returns true if ConfiguracaoControleCartaoPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of ConfiguracaoControleCartaoPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfiguracaoControleCartaoPersist other)
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
                ) && 
                (
                    this.PermiteCompraInternacional == other.PermiteCompraInternacional ||
                    this.PermiteCompraInternacional != null &&
                    this.PermiteCompraInternacional.Equals(other.PermiteCompraInternacional)
                ) && 
                (
                    this.PermiteTarjaMagnetica == other.PermiteTarjaMagnetica ||
                    this.PermiteTarjaMagnetica != null &&
                    this.PermiteTarjaMagnetica.Equals(other.PermiteTarjaMagnetica)
                ) && 
                (
                    this.PermiteContactless == other.PermiteContactless ||
                    this.PermiteContactless != null &&
                    this.PermiteContactless.Equals(other.PermiteContactless)
                ) && 
                (
                    this.LimiteContactlessSemSenha == other.LimiteContactlessSemSenha ||
                    this.LimiteContactlessSemSenha != null &&
                    this.LimiteContactlessSemSenha.Equals(other.LimiteContactlessSemSenha)
                ) && 
                (
                    this.FuncaoAtiva == other.FuncaoAtiva ||
                    this.FuncaoAtiva != null &&
                    this.FuncaoAtiva.Equals(other.FuncaoAtiva)
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
                
                if (this.PermiteCompraInternacional != null)
                    hash = hash * 59 + this.PermiteCompraInternacional.GetHashCode();
                
                if (this.PermiteTarjaMagnetica != null)
                    hash = hash * 59 + this.PermiteTarjaMagnetica.GetHashCode();
                
                if (this.PermiteContactless != null)
                    hash = hash * 59 + this.PermiteContactless.GetHashCode();
                
                if (this.LimiteContactlessSemSenha != null)
                    hash = hash * 59 + this.LimiteContactlessSemSenha.GetHashCode();
                
                if (this.FuncaoAtiva != null)
                    hash = hash * 59 + this.FuncaoAtiva.GetHashCode();
                
                return hash;
            }
        }

    }
}
