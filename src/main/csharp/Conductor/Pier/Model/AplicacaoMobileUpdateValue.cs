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
    /// {{{aplicacao_mobile_update_description}}}
    /// </summary>
    [DataContract]
    public partial class AplicacaoMobileUpdateValue :  IEquatable<AplicacaoMobileUpdateValue>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AplicacaoMobileUpdateValue" /> class.
        /// Initializes a new instance of the <see cref="AplicacaoMobileUpdateValue" />class.
        /// </summary>
        /// <param name="Token">{{{aplicacao_mobile_update_token_value}}}.</param>
        /// <param name="Cor">{{{aplicacao_mobile_update_cor_value}}}.</param>
        /// <param name="Som">{{{aplicacao_mobile_update_som_value}}}.</param>
        /// <param name="Icone">{{{aplicacao_mobile_update_icone_value}}}.</param>
        /// <param name="Certificado">{{{aplicacao_mobile_update_certificado_value}}}.</param>
        /// <param name="Senha">{{{aplicacao_mobile_update_senha_value}}}.</param>

        public AplicacaoMobileUpdateValue(string Token = null, string Cor = null, string Som = null, string Icone = null, string Certificado = null, string Senha = null)
        {
            this.Token = Token;
            this.Cor = Cor;
            this.Som = Som;
            this.Icone = Icone;
            this.Certificado = Certificado;
            this.Senha = Senha;
            
        }
        
    
        /// <summary>
        /// {{{aplicacao_mobile_update_token_value}}}
        /// </summary>
        /// <value>{{{aplicacao_mobile_update_token_value}}}</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }
    
        /// <summary>
        /// {{{aplicacao_mobile_update_cor_value}}}
        /// </summary>
        /// <value>{{{aplicacao_mobile_update_cor_value}}}</value>
        [DataMember(Name="cor", EmitDefaultValue=false)]
        public string Cor { get; set; }
    
        /// <summary>
        /// {{{aplicacao_mobile_update_som_value}}}
        /// </summary>
        /// <value>{{{aplicacao_mobile_update_som_value}}}</value>
        [DataMember(Name="som", EmitDefaultValue=false)]
        public string Som { get; set; }
    
        /// <summary>
        /// {{{aplicacao_mobile_update_icone_value}}}
        /// </summary>
        /// <value>{{{aplicacao_mobile_update_icone_value}}}</value>
        [DataMember(Name="icone", EmitDefaultValue=false)]
        public string Icone { get; set; }
    
        /// <summary>
        /// {{{aplicacao_mobile_update_certificado_value}}}
        /// </summary>
        /// <value>{{{aplicacao_mobile_update_certificado_value}}}</value>
        [DataMember(Name="certificado", EmitDefaultValue=false)]
        public string Certificado { get; set; }
    
        /// <summary>
        /// {{{aplicacao_mobile_update_senha_value}}}
        /// </summary>
        /// <value>{{{aplicacao_mobile_update_senha_value}}}</value>
        [DataMember(Name="senha", EmitDefaultValue=false)]
        public string Senha { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AplicacaoMobileUpdateValue {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Cor: ").Append(Cor).Append("\n");
            sb.Append("  Som: ").Append(Som).Append("\n");
            sb.Append("  Icone: ").Append(Icone).Append("\n");
            sb.Append("  Certificado: ").Append(Certificado).Append("\n");
            sb.Append("  Senha: ").Append(Senha).Append("\n");
            
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
            return this.Equals(obj as AplicacaoMobileUpdateValue);
        }

        /// <summary>
        /// Returns true if AplicacaoMobileUpdateValue instances are equal
        /// </summary>
        /// <param name="other">Instance of AplicacaoMobileUpdateValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AplicacaoMobileUpdateValue other)
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
                    this.Cor == other.Cor ||
                    this.Cor != null &&
                    this.Cor.Equals(other.Cor)
                ) && 
                (
                    this.Som == other.Som ||
                    this.Som != null &&
                    this.Som.Equals(other.Som)
                ) && 
                (
                    this.Icone == other.Icone ||
                    this.Icone != null &&
                    this.Icone.Equals(other.Icone)
                ) && 
                (
                    this.Certificado == other.Certificado ||
                    this.Certificado != null &&
                    this.Certificado.Equals(other.Certificado)
                ) && 
                (
                    this.Senha == other.Senha ||
                    this.Senha != null &&
                    this.Senha.Equals(other.Senha)
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
                
                if (this.Cor != null)
                    hash = hash * 59 + this.Cor.GetHashCode();
                
                if (this.Som != null)
                    hash = hash * 59 + this.Som.GetHashCode();
                
                if (this.Icone != null)
                    hash = hash * 59 + this.Icone.GetHashCode();
                
                if (this.Certificado != null)
                    hash = hash * 59 + this.Certificado.GetHashCode();
                
                if (this.Senha != null)
                    hash = hash * 59 + this.Senha.GetHashCode();
                
                return hash;
            }
        }

    }
}
