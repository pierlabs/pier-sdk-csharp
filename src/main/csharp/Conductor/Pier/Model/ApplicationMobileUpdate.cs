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
    /// Object ApplicationMobile
    /// </summary>
    [DataContract]
    public partial class ApplicationMobileUpdate :  IEquatable<ApplicationMobileUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationMobileUpdate" /> class.
        /// Initializes a new instance of the <see cref="ApplicationMobileUpdate" />class.
        /// </summary>
        /// <param name="Token">Token of the Mobile Application.</param>
        /// <param name="Cor">Color of the Mobile App Message.</param>
        /// <param name="Som">Message Sound of the Mobile Application.</param>
        /// <param name="Icone">Icon of the Message Mobile Application.</param>
        /// <param name="Certificado">Certificate of the Mobile Application.</param>
        /// <param name="Senha">Password of the Application Mobile.</param>

        public ApplicationMobileUpdate(string Token = null, string Cor = null, string Som = null, string Icone = null, string Certificado = null, string Senha = null)
        {
            this.Token = Token;
            this.Cor = Cor;
            this.Som = Som;
            this.Icone = Icone;
            this.Certificado = Certificado;
            this.Senha = Senha;
            
        }
        
    
        /// <summary>
        /// Token of the Mobile Application
        /// </summary>
        /// <value>Token of the Mobile Application</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }
    
        /// <summary>
        /// Color of the Mobile App Message
        /// </summary>
        /// <value>Color of the Mobile App Message</value>
        [DataMember(Name="cor", EmitDefaultValue=false)]
        public string Cor { get; set; }
    
        /// <summary>
        /// Message Sound of the Mobile Application
        /// </summary>
        /// <value>Message Sound of the Mobile Application</value>
        [DataMember(Name="som", EmitDefaultValue=false)]
        public string Som { get; set; }
    
        /// <summary>
        /// Icon of the Message Mobile Application
        /// </summary>
        /// <value>Icon of the Message Mobile Application</value>
        [DataMember(Name="icone", EmitDefaultValue=false)]
        public string Icone { get; set; }
    
        /// <summary>
        /// Certificate of the Mobile Application
        /// </summary>
        /// <value>Certificate of the Mobile Application</value>
        [DataMember(Name="certificado", EmitDefaultValue=false)]
        public string Certificado { get; set; }
    
        /// <summary>
        /// Password of the Application Mobile
        /// </summary>
        /// <value>Password of the Application Mobile</value>
        [DataMember(Name="senha", EmitDefaultValue=false)]
        public string Senha { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationMobileUpdate {\n");
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
            return this.Equals(obj as ApplicationMobileUpdate);
        }

        /// <summary>
        /// Returns true if ApplicationMobileUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of ApplicationMobileUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationMobileUpdate other)
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
