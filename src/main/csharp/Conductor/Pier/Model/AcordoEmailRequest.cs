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
    /// Par\u00E2metros para envio do termo por e-mail
    /// </summary>
    [DataContract]
    public partial class AcordoEmailRequest :  IEquatable<AcordoEmailRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AcordoEmailRequest" /> class.
        /// Initializes a new instance of the <see cref="AcordoEmailRequest" />class.
        /// </summary>
        /// <param name="Email">Email do destinat\u00E1rio.</param>
        /// <param name="IdTemplateNotificacao">Identificador do modelo de e-email.</param>
        /// <param name="Parametros">Par\u00E2metros para substitui\u00E7\u00E3o no modelo do e-mail..</param>

        public AcordoEmailRequest(string Email = null, long? IdTemplateNotificacao = null, Object Parametros = null)
        {
            this.Email = Email;
            this.IdTemplateNotificacao = IdTemplateNotificacao;
            this.Parametros = Parametros;
            
        }
        
    
        /// <summary>
        /// Email do destinat\u00E1rio
        /// </summary>
        /// <value>Email do destinat\u00E1rio</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Identificador do modelo de e-email
        /// </summary>
        /// <value>Identificador do modelo de e-email</value>
        [DataMember(Name="idTemplateNotificacao", EmitDefaultValue=false)]
        public long? IdTemplateNotificacao { get; set; }
    
        /// <summary>
        /// Par\u00E2metros para substitui\u00E7\u00E3o no modelo do e-mail.
        /// </summary>
        /// <value>Par\u00E2metros para substitui\u00E7\u00E3o no modelo do e-mail.</value>
        [DataMember(Name="parametros", EmitDefaultValue=false)]
        public Object Parametros { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AcordoEmailRequest {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  IdTemplateNotificacao: ").Append(IdTemplateNotificacao).Append("\n");
            sb.Append("  Parametros: ").Append(Parametros).Append("\n");
            
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
            return this.Equals(obj as AcordoEmailRequest);
        }

        /// <summary>
        /// Returns true if AcordoEmailRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AcordoEmailRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AcordoEmailRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.IdTemplateNotificacao == other.IdTemplateNotificacao ||
                    this.IdTemplateNotificacao != null &&
                    this.IdTemplateNotificacao.Equals(other.IdTemplateNotificacao)
                ) && 
                (
                    this.Parametros == other.Parametros ||
                    this.Parametros != null &&
                    this.Parametros.Equals(other.Parametros)
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
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.IdTemplateNotificacao != null)
                    hash = hash * 59 + this.IdTemplateNotificacao.GetHashCode();
                
                if (this.Parametros != null)
                    hash = hash * 59 + this.Parametros.GetHashCode();
                
                return hash;
            }
        }

    }
}
