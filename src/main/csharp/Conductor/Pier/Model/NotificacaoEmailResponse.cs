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
    /// Notifica\u00C3\u00A7\u00C3\u00A3o do envio do email
    /// </summary>
    [DataContract]
    public partial class NotificacaoEmailResponse :  IEquatable<NotificacaoEmailResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificacaoEmailResponse" /> class.
        /// Initializes a new instance of the <see cref="NotificacaoEmailResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da notifica\u00C3\u00A7\u00C3\u00A3o gerada..</param>
        /// <param name="IdTemplateNotificacao">C\u00C3\u00B3digo identificador do template da notifica\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="IdDocumento">C\u00C3\u00B3digo identificador do Documento..</param>
        /// <param name="Destinatario">Email do destinat\u00C3\u00A1rio da notifica\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="Remetente">Email do remetente da notifica\u00C3\u00A7\u00C3\u00A3o..</param>

        public NotificacaoEmailResponse(long? Id = null, long? IdTemplateNotificacao = null, long? IdDocumento = null, string Destinatario = null, string Remetente = null)
        {
            this.Id = Id;
            this.IdTemplateNotificacao = IdTemplateNotificacao;
            this.IdDocumento = IdDocumento;
            this.Destinatario = Destinatario;
            this.Remetente = Remetente;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da notifica\u00C3\u00A7\u00C3\u00A3o gerada.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da notifica\u00C3\u00A7\u00C3\u00A3o gerada.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador do template da notifica\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador do template da notifica\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="idTemplateNotificacao", EmitDefaultValue=false)]
        public long? IdTemplateNotificacao { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador do Documento.
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador do Documento.</value>
        [DataMember(Name="idDocumento", EmitDefaultValue=false)]
        public long? IdDocumento { get; set; }
    
        /// <summary>
        /// Email do destinat\u00C3\u00A1rio da notifica\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Email do destinat\u00C3\u00A1rio da notifica\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="destinatario", EmitDefaultValue=false)]
        public string Destinatario { get; set; }
    
        /// <summary>
        /// Email do remetente da notifica\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Email do remetente da notifica\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="remetente", EmitDefaultValue=false)]
        public string Remetente { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificacaoEmailResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdTemplateNotificacao: ").Append(IdTemplateNotificacao).Append("\n");
            sb.Append("  IdDocumento: ").Append(IdDocumento).Append("\n");
            sb.Append("  Destinatario: ").Append(Destinatario).Append("\n");
            sb.Append("  Remetente: ").Append(Remetente).Append("\n");
            
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
            return this.Equals(obj as NotificacaoEmailResponse);
        }

        /// <summary>
        /// Returns true if NotificacaoEmailResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of NotificacaoEmailResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificacaoEmailResponse other)
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
                    this.IdTemplateNotificacao == other.IdTemplateNotificacao ||
                    this.IdTemplateNotificacao != null &&
                    this.IdTemplateNotificacao.Equals(other.IdTemplateNotificacao)
                ) && 
                (
                    this.IdDocumento == other.IdDocumento ||
                    this.IdDocumento != null &&
                    this.IdDocumento.Equals(other.IdDocumento)
                ) && 
                (
                    this.Destinatario == other.Destinatario ||
                    this.Destinatario != null &&
                    this.Destinatario.Equals(other.Destinatario)
                ) && 
                (
                    this.Remetente == other.Remetente ||
                    this.Remetente != null &&
                    this.Remetente.Equals(other.Remetente)
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
                
                if (this.IdTemplateNotificacao != null)
                    hash = hash * 59 + this.IdTemplateNotificacao.GetHashCode();
                
                if (this.IdDocumento != null)
                    hash = hash * 59 + this.IdDocumento.GetHashCode();
                
                if (this.Destinatario != null)
                    hash = hash * 59 + this.Destinatario.GetHashCode();
                
                if (this.Remetente != null)
                    hash = hash * 59 + this.Remetente.GetHashCode();
                
                return hash;
            }
        }

    }
}
