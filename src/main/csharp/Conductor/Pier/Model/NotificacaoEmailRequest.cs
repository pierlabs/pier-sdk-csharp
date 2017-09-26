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
    /// Representa\u00C3\u00A7\u00C3\u00A3o do recurso para envio de uma notifica\u00C3\u00A7\u00C3\u00A3o por email.
    /// </summary>
    [DataContract]
    public partial class NotificacaoEmailRequest :  IEquatable<NotificacaoEmailRequest>
    { 
    
        /// <summary>
        /// Tipo de layout para o template da notifica\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Tipo de layout para o template da notifica\u00C3\u00A7\u00C3\u00A3o.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TipoLayoutEnum {
            
            [EnumMember(Value = "RECUPERAR_SENHA")]
            RecuperarSenha,
            
            [EnumMember(Value = "FATURA_POR_EMAIL")]
            FaturaPorEmail,
            
            [EnumMember(Value = "VALIDAR_DISPOSITIVO")]
            ValidarDispositivo,
            
            [EnumMember(Value = "NOTIFICACAO_EMAIL")]
            NotificacaoEmail
        }

    
        /// <summary>
        /// Tipo de layout para o template da notifica\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Tipo de layout para o template da notifica\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="tipoLayout", EmitDefaultValue=false)]
        public TipoLayoutEnum? TipoLayout { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificacaoEmailRequest" /> class.
        /// Initializes a new instance of the <see cref="NotificacaoEmailRequest" />class.
        /// </summary>
        /// <param name="IdDocumento">ID para o documento a ser enviado..</param>
        /// <param name="IdTemplateNotificacao">ID para o template da notifica\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="Destinatario">Email do destinat\u00C3\u00A1rio..</param>
        /// <param name="TipoLayout">Tipo de layout para o template da notifica\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="ParametrosConteudo">Mapa de par\u00C3\u00A2metros para montagem da notifica\u00C3\u00A7\u00C3\u00A3o..</param>

        public NotificacaoEmailRequest(long? IdDocumento = null, long? IdTemplateNotificacao = null, string Destinatario = null, TipoLayoutEnum? TipoLayout = null, Dictionary<string, Object> ParametrosConteudo = null)
        {
            this.IdDocumento = IdDocumento;
            this.IdTemplateNotificacao = IdTemplateNotificacao;
            this.Destinatario = Destinatario;
            this.TipoLayout = TipoLayout;
            this.ParametrosConteudo = ParametrosConteudo;
            
        }
        
    
        /// <summary>
        /// ID para o documento a ser enviado.
        /// </summary>
        /// <value>ID para o documento a ser enviado.</value>
        [DataMember(Name="idDocumento", EmitDefaultValue=false)]
        public long? IdDocumento { get; set; }
    
        /// <summary>
        /// ID para o template da notifica\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>ID para o template da notifica\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="idTemplateNotificacao", EmitDefaultValue=false)]
        public long? IdTemplateNotificacao { get; set; }
    
        /// <summary>
        /// Email do destinat\u00C3\u00A1rio.
        /// </summary>
        /// <value>Email do destinat\u00C3\u00A1rio.</value>
        [DataMember(Name="destinatario", EmitDefaultValue=false)]
        public string Destinatario { get; set; }
    
        /// <summary>
        /// Mapa de par\u00C3\u00A2metros para montagem da notifica\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Mapa de par\u00C3\u00A2metros para montagem da notifica\u00C3\u00A7\u00C3\u00A3o.</value>
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
            sb.Append("  IdDocumento: ").Append(IdDocumento).Append("\n");
            sb.Append("  IdTemplateNotificacao: ").Append(IdTemplateNotificacao).Append("\n");
            sb.Append("  Destinatario: ").Append(Destinatario).Append("\n");
            sb.Append("  TipoLayout: ").Append(TipoLayout).Append("\n");
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
                    this.IdDocumento == other.IdDocumento ||
                    this.IdDocumento != null &&
                    this.IdDocumento.Equals(other.IdDocumento)
                ) && 
                (
                    this.IdTemplateNotificacao == other.IdTemplateNotificacao ||
                    this.IdTemplateNotificacao != null &&
                    this.IdTemplateNotificacao.Equals(other.IdTemplateNotificacao)
                ) && 
                (
                    this.Destinatario == other.Destinatario ||
                    this.Destinatario != null &&
                    this.Destinatario.Equals(other.Destinatario)
                ) && 
                (
                    this.TipoLayout == other.TipoLayout ||
                    this.TipoLayout != null &&
                    this.TipoLayout.Equals(other.TipoLayout)
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
                
                if (this.IdDocumento != null)
                    hash = hash * 59 + this.IdDocumento.GetHashCode();
                
                if (this.IdTemplateNotificacao != null)
                    hash = hash * 59 + this.IdTemplateNotificacao.GetHashCode();
                
                if (this.Destinatario != null)
                    hash = hash * 59 + this.Destinatario.GetHashCode();
                
                if (this.TipoLayout != null)
                    hash = hash * 59 + this.TipoLayout.GetHashCode();
                
                if (this.ParametrosConteudo != null)
                    hash = hash * 59 + this.ParametrosConteudo.GetHashCode();
                
                return hash;
            }
        }

    }
}
