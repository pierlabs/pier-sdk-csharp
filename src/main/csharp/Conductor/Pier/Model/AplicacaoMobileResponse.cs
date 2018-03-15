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
    /// Aplicacao Mobile
    /// </summary>
    [DataContract]
    public partial class AplicacaoMobileResponse :  IEquatable<AplicacaoMobileResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AplicacaoMobileResponse" /> class.
        /// Initializes a new instance of the <see cref="AplicacaoMobileResponse" />class.
        /// </summary>
        /// <param name="Id">Apresenta o identificador da aplicacao..</param>
        /// <param name="IdPlataformaMobile">Apresenta o identificador da plataforma..</param>
        /// <param name="Token">Apresenta o token da aplicacao..</param>
        /// <param name="Cor">Apresenta a cor da mensagem da aplicacao..</param>
        /// <param name="Som">Apresenta o som da mensagem da aplicacao.</param>
        /// <param name="Icone">Apresenta o icone da mensagem da aplica\u00E7\u00E3o..</param>
        /// <param name="CertificadoBase64">Apresenta o certificado da aplica\u00E7\u00E3o..</param>
        /// <param name="Senha">Apresenta a senha da aplica\u00E7\u00E3o..</param>

        public AplicacaoMobileResponse(long? Id = null, long? IdPlataformaMobile = null, string Token = null, string Cor = null, string Som = null, string Icone = null, string CertificadoBase64 = null, string Senha = null)
        {
            this.Id = Id;
            this.IdPlataformaMobile = IdPlataformaMobile;
            this.Token = Token;
            this.Cor = Cor;
            this.Som = Som;
            this.Icone = Icone;
            this.CertificadoBase64 = CertificadoBase64;
            this.Senha = Senha;
            
        }
        
    
        /// <summary>
        /// Apresenta o identificador da aplicacao.
        /// </summary>
        /// <value>Apresenta o identificador da aplicacao.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Apresenta o identificador da plataforma.
        /// </summary>
        /// <value>Apresenta o identificador da plataforma.</value>
        [DataMember(Name="idPlataformaMobile", EmitDefaultValue=false)]
        public long? IdPlataformaMobile { get; set; }
    
        /// <summary>
        /// Apresenta o token da aplicacao.
        /// </summary>
        /// <value>Apresenta o token da aplicacao.</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }
    
        /// <summary>
        /// Apresenta a cor da mensagem da aplicacao.
        /// </summary>
        /// <value>Apresenta a cor da mensagem da aplicacao.</value>
        [DataMember(Name="cor", EmitDefaultValue=false)]
        public string Cor { get; set; }
    
        /// <summary>
        /// Apresenta o som da mensagem da aplicacao
        /// </summary>
        /// <value>Apresenta o som da mensagem da aplicacao</value>
        [DataMember(Name="som", EmitDefaultValue=false)]
        public string Som { get; set; }
    
        /// <summary>
        /// Apresenta o icone da mensagem da aplica\u00E7\u00E3o.
        /// </summary>
        /// <value>Apresenta o icone da mensagem da aplica\u00E7\u00E3o.</value>
        [DataMember(Name="icone", EmitDefaultValue=false)]
        public string Icone { get; set; }
    
        /// <summary>
        /// Apresenta o certificado da aplica\u00E7\u00E3o.
        /// </summary>
        /// <value>Apresenta o certificado da aplica\u00E7\u00E3o.</value>
        [DataMember(Name="certificadoBase64", EmitDefaultValue=false)]
        public string CertificadoBase64 { get; set; }
    
        /// <summary>
        /// Apresenta a senha da aplica\u00E7\u00E3o.
        /// </summary>
        /// <value>Apresenta a senha da aplica\u00E7\u00E3o.</value>
        [DataMember(Name="senha", EmitDefaultValue=false)]
        public string Senha { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AplicacaoMobileResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdPlataformaMobile: ").Append(IdPlataformaMobile).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Cor: ").Append(Cor).Append("\n");
            sb.Append("  Som: ").Append(Som).Append("\n");
            sb.Append("  Icone: ").Append(Icone).Append("\n");
            sb.Append("  CertificadoBase64: ").Append(CertificadoBase64).Append("\n");
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
            return this.Equals(obj as AplicacaoMobileResponse);
        }

        /// <summary>
        /// Returns true if AplicacaoMobileResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AplicacaoMobileResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AplicacaoMobileResponse other)
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
                    this.IdPlataformaMobile == other.IdPlataformaMobile ||
                    this.IdPlataformaMobile != null &&
                    this.IdPlataformaMobile.Equals(other.IdPlataformaMobile)
                ) && 
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
                    this.CertificadoBase64 == other.CertificadoBase64 ||
                    this.CertificadoBase64 != null &&
                    this.CertificadoBase64.Equals(other.CertificadoBase64)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdPlataformaMobile != null)
                    hash = hash * 59 + this.IdPlataformaMobile.GetHashCode();
                
                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
                
                if (this.Cor != null)
                    hash = hash * 59 + this.Cor.GetHashCode();
                
                if (this.Som != null)
                    hash = hash * 59 + this.Som.GetHashCode();
                
                if (this.Icone != null)
                    hash = hash * 59 + this.Icone.GetHashCode();
                
                if (this.CertificadoBase64 != null)
                    hash = hash * 59 + this.CertificadoBase64.GetHashCode();
                
                if (this.Senha != null)
                    hash = hash * 59 + this.Senha.GetHashCode();
                
                return hash;
            }
        }

    }
}
