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
    /// Representa\u00E7\u00E3o do recurso para envio de uma notifica\u00E7\u00E3o por email
    /// </summary>
    [DataContract]
    public partial class NotificacaoEmailRequest :  IEquatable<NotificacaoEmailRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificacaoEmailRequest" /> class.
        /// Initializes a new instance of the <see cref="NotificacaoEmailRequest" />class.
        /// </summary>
        /// <param name="IdTemplateNotificacao">ID para o template da notifica\u00E7\u00E3o.</param>
        /// <param name="Destinatarios">Lista de email(s) do(s) destinat\u00E1rio(s).</param>
        /// <param name="Anexos">Lista de ids dos anexos a serem enviados.</param>
        /// <param name="ParametrosConteudo">Mapa de par\u00E2metros para montagem da notifica\u00E7\u00E3o.</param>

        public NotificacaoEmailRequest(long? IdTemplateNotificacao = null, List<string> Destinatarios = null, List<AnexoNotificacaoEmailRequest> Anexos = null, Dictionary<string, Object> ParametrosConteudo = null)
        {
            this.IdTemplateNotificacao = IdTemplateNotificacao;
            this.Destinatarios = Destinatarios;
            this.Anexos = Anexos;
            this.ParametrosConteudo = ParametrosConteudo;
            
        }
        
    
        /// <summary>
        /// ID para o template da notifica\u00E7\u00E3o
        /// </summary>
        /// <value>ID para o template da notifica\u00E7\u00E3o</value>
        [DataMember(Name="idTemplateNotificacao", EmitDefaultValue=false)]
        public long? IdTemplateNotificacao { get; set; }
    
        /// <summary>
        /// Lista de email(s) do(s) destinat\u00E1rio(s)
        /// </summary>
        /// <value>Lista de email(s) do(s) destinat\u00E1rio(s)</value>
        [DataMember(Name="destinatarios", EmitDefaultValue=false)]
        public List<string> Destinatarios { get; set; }
    
        /// <summary>
        /// Lista de ids dos anexos a serem enviados
        /// </summary>
        /// <value>Lista de ids dos anexos a serem enviados</value>
        [DataMember(Name="anexos", EmitDefaultValue=false)]
        public List<AnexoNotificacaoEmailRequest> Anexos { get; set; }
    
        /// <summary>
        /// Mapa de par\u00E2metros para montagem da notifica\u00E7\u00E3o
        /// </summary>
        /// <value>Mapa de par\u00E2metros para montagem da notifica\u00E7\u00E3o</value>
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
