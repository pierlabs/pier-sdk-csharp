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
    /// Representa\u00E7\u00E3o para resposta de dados de Configuracao de Controle do Cartao
    /// </summary>
    [DataContract]
    public partial class ConfiguracaoControleCartaoResponse :  IEquatable<ConfiguracaoControleCartaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguracaoControleCartaoResponse" /> class.
        /// Initializes a new instance of the <see cref="ConfiguracaoControleCartaoResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo Identificador da configura\u00E7\u00E3o na base (id).</param>
        /// <param name="IdCartao">C\u00F3digo Identificador do cart\u00E3o na base (id).</param>
        /// <param name="PermiteEcommerce">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es ecommerce.</param>
        /// <param name="PermiteSaque">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es de saque.</param>
        /// <param name="PermiteWallet">Flag para autoriza\u00E7\u00E3o de transa\u00E7\u00F5es por wallet.</param>
        /// <param name="PermiteControleMCC">Indica se o cart\u00E3o est\u00E1 ativo para controle por grupos de MCCs.</param>
        /// <param name="PermiteCompraInternacional">Indica se o cart\u00E3o est\u00E1 habilitado/desabilitado para transa\u00E7\u00F5es internacionais.</param>
        /// <param name="PermiteTarjaMagnetica">Indica se o cart\u00E3o est\u00E1 habilitado/desabilitado para transa\u00E7\u00F5es por tarja magnetica.</param>
        /// <param name="PermiteContactless">Indica se o cart\u00E3o est\u00E1 habilitado/desabilitado para transa\u00E7\u00F5es via contactless.</param>
        /// <param name="LimiteContactlessSemSenha">Indica o limite usado em transa\u00E7\u00F5es com a fun\u00E7\u00E3o contactless sem senha. O valor m\u00E1ximo \u00E9 50 e o m\u00EDnimo \u00E9 1..</param>

        public ConfiguracaoControleCartaoResponse(long? Id = null, long? IdCartao = null, bool? PermiteEcommerce = null, bool? PermiteSaque = null, bool? PermiteWallet = null, bool? PermiteControleMCC = null, bool? PermiteCompraInternacional = null, bool? PermiteTarjaMagnetica = null, bool? PermiteContactless = null, double? LimiteContactlessSemSenha = null)
        {
            this.Id = Id;
            this.IdCartao = IdCartao;
            this.PermiteEcommerce = PermiteEcommerce;
            this.PermiteSaque = PermiteSaque;
            this.PermiteWallet = PermiteWallet;
            this.PermiteControleMCC = PermiteControleMCC;
            this.PermiteCompraInternacional = PermiteCompraInternacional;
            this.PermiteTarjaMagnetica = PermiteTarjaMagnetica;
            this.PermiteContactless = PermiteContactless;
            this.LimiteContactlessSemSenha = LimiteContactlessSemSenha;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo Identificador da configura\u00E7\u00E3o na base (id)
        /// </summary>
        /// <value>C\u00F3digo Identificador da configura\u00E7\u00E3o na base (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00F3digo Identificador do cart\u00E3o na base (id)
        /// </summary>
        /// <value>C\u00F3digo Identificador do cart\u00E3o na base (id)</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfiguracaoControleCartaoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  PermiteEcommerce: ").Append(PermiteEcommerce).Append("\n");
            sb.Append("  PermiteSaque: ").Append(PermiteSaque).Append("\n");
            sb.Append("  PermiteWallet: ").Append(PermiteWallet).Append("\n");
            sb.Append("  PermiteControleMCC: ").Append(PermiteControleMCC).Append("\n");
            sb.Append("  PermiteCompraInternacional: ").Append(PermiteCompraInternacional).Append("\n");
            sb.Append("  PermiteTarjaMagnetica: ").Append(PermiteTarjaMagnetica).Append("\n");
            sb.Append("  PermiteContactless: ").Append(PermiteContactless).Append("\n");
            sb.Append("  LimiteContactlessSemSenha: ").Append(LimiteContactlessSemSenha).Append("\n");
            
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
            return this.Equals(obj as ConfiguracaoControleCartaoResponse);
        }

        /// <summary>
        /// Returns true if ConfiguracaoControleCartaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ConfiguracaoControleCartaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfiguracaoControleCartaoResponse other)
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
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
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
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
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
                
                return hash;
            }
        }

    }
}
