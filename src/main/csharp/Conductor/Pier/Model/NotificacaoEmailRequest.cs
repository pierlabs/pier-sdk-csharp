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
    /// {{{notificacao_email_request_description}}}
    /// </summary>
    [DataContract]
    public partial class NotificacaoEmailRequest :  IEquatable<NotificacaoEmailRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificacaoEmailRequest" /> class.
        /// Initializes a new instance of the <see cref="NotificacaoEmailRequest" />class.
        /// </summary>
        /// <param name="IdTemplateNotificacao">{{{notificacao_email_request_id_template_notificacao_value}}}.</param>
        /// <param name="Destinatarios">{{{notificacao_email_request_destinatarios_value}}}.</param>
        /// <param name="Anexos">{{{notificacao_email_request_anexos_value}}}.</param>
        /// <param name="ParametrosConteudo">{{{notificacao_email_request_parametros_conteudo_value}}}.</param>

        public NotificacaoEmailRequest(long? IdTemplateNotificacao = null, List<string> Destinatarios = null, List<AnexoNotificacaoEmailRequest> Anexos = null, Dictionary<string, Object> ParametrosConteudo = null)
        {
            this.IdTemplateNotificacao = IdTemplateNotificacao;
            this.Destinatarios = Destinatarios;
            this.Anexos = Anexos;
            this.ParametrosConteudo = ParametrosConteudo;
            
        }
        
    
        /// <summary>
        /// {{{notificacao_email_request_id_template_notificacao_value}}}
        /// </summary>
        /// <value>{{{notificacao_email_request_id_template_notificacao_value}}}</value>
        [DataMember(Name="idTemplateNotificacao", EmitDefaultValue=false)]
        public long? IdTemplateNotificacao { get; set; }
    
        /// <summary>
        /// {{{notificacao_email_request_destinatarios_value}}}
        /// </summary>
        /// <value>{{{notificacao_email_request_destinatarios_value}}}</value>
        [DataMember(Name="destinatarios", EmitDefaultValue=false)]
        public List<string> Destinatarios { get; set; }
    
        /// <summary>
        /// {{{notificacao_email_request_anexos_value}}}
        /// </summary>
        /// <value>{{{notificacao_email_request_anexos_value}}}</value>
        [DataMember(Name="anexos", EmitDefaultValue=false)]
        public List<AnexoNotificacaoEmailRequest> Anexos { get; set; }
    
        /// <summary>
        /// {{{notificacao_email_request_parametros_conteudo_value}}}
        /// </summary>
        /// <value>{{{notificacao_email_request_parametros_conteudo_value}}}</value>
        [DataMember(Name="parametrosConteudo", EmitDefaultValue=false)]
        public Dictionary<string, Object> ParametrosConteudo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificacaoEmailRequest {\n");
            sb.Append("  IdTemplateNotificacao: ").Append(IdTemplateNotificacao).Append("\n");
            sb.Append("  Destinatarios: ").Append(Destinatarios).Append("\n");
            sb.Append("  Anexos: ").Append(Anexos).Append("\n");
            sb.Append("  ParametrosConteudo: ").Append(ParametrosConteudo).Append("\n");
            
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
            return this.Equals(obj as NotificacaoEmailRequest);
        }

        /// <summary>
        /// Returns true if NotificacaoEmailRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of NotificacaoEmailRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificacaoEmailRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdTemplateNotificacao == other.IdTemplateNotificacao ||
                    this.IdTemplateNotificacao != null &&
                    this.IdTemplateNotificacao.Equals(other.IdTemplateNotificacao)
                ) && 
                (
                    this.Destinatarios == other.Destinatarios ||
                    this.Destinatarios != null &&
                    this.Destinatarios.SequenceEqual(other.Destinatarios)
                ) && 
                (
                    this.Anexos == other.Anexos ||
                    this.Anexos != null &&
                    this.Anexos.SequenceEqual(other.Anexos)
                ) && 
                (
                    this.ParametrosConteudo == other.ParametrosConteudo ||
                    this.ParametrosConteudo != null &&
                    this.ParametrosConteudo.SequenceEqual(other.ParametrosConteudo)
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
                
                if (this.IdTemplateNotificacao != null)
                    hash = hash * 59 + this.IdTemplateNotificacao.GetHashCode();
                
                if (this.Destinatarios != null)
                    hash = hash * 59 + this.Destinatarios.GetHashCode();
                
                if (this.Anexos != null)
                    hash = hash * 59 + this.Anexos.GetHashCode();
                
                if (this.ParametrosConteudo != null)
                    hash = hash * 59 + this.ParametrosConteudo.GetHashCode();
                
                return hash;
            }
        }

    }
}
