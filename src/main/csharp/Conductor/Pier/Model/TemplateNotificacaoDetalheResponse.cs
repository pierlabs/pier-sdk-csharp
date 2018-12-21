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
    /// Object of details of the Notification Template
    /// </summary>
    [DataContract]
    public partial class TemplateNotificacaoDetalheResponse :  IEquatable<TemplateNotificacaoDetalheResponse>
    { 
    
        /// <summary>
        /// Layout type of the e-mail
        /// </summary>
        /// <value>Layout type of the e-mail</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TipoLayoutEnum {
            
            [EnumMember(Value = "RECUPERAR_SENHA")]
            RecuperarSenha,
            
            [EnumMember(Value = "FATURA_POR_EMAIL")]
            FaturaPorEmail,
            
            [EnumMember(Value = "VALIDAR_DISPOSITIVO")]
            ValidarDispositivo,
            
            [EnumMember(Value = "NOTIFICACAO_EMAIL")]
            NotificacaoEmail,
            
            [EnumMember(Value = "OTP_3D_SECURE")]
            Otp3dSecure
        }

    
        /// <summary>
        /// Notification type
        /// </summary>
        /// <value>Notification type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TipoNotificacaoEnum {
            
            [EnumMember(Value = "SMS")]
            Sms,
            
            [EnumMember(Value = "PUSH_APNS")]
            PushApns,
            
            [EnumMember(Value = "PUSH_FCM")]
            PushFcm,
            
            [EnumMember(Value = "PUSH_GCM")]
            PushGcm,
            
            [EnumMember(Value = "WEBHOOK")]
            Webhook,
            
            [EnumMember(Value = "EMAIL")]
            Email
        }

    
        /// <summary>
        /// Layout type of the e-mail
        /// </summary>
        /// <value>Layout type of the e-mail</value>
        [DataMember(Name="tipoLayout", EmitDefaultValue=false)]
        public TipoLayoutEnum? TipoLayout { get; set; }
    
        /// <summary>
        /// Notification type
        /// </summary>
        /// <value>Notification type</value>
        [DataMember(Name="tipoNotificacao", EmitDefaultValue=false)]
        public TipoNotificacaoEnum? TipoNotificacao { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateNotificacaoDetalheResponse" /> class.
        /// Initializes a new instance of the <see cref="TemplateNotificacaoDetalheResponse" />class.
        /// </summary>
        /// <param name="Id">Identifier Code.</param>
        /// <param name="IdConfiguracaoEmail">Identification Code of the E-mail Configuration.</param>
        /// <param name="TipoLayout">Layout type of the e-mail.</param>
        /// <param name="TipoNotificacao">Notification type.</param>
        /// <param name="TemplatePadrao">Standard Template.</param>
        /// <param name="Remetente">Sender.</param>
        /// <param name="Assunto">Email subject.</param>
        /// <param name="DataInclusao">Inclusion date.</param>
        /// <param name="DataAlteracao">Update date.</param>
        /// <param name="Conteudo">E-mail content.</param>

        public TemplateNotificacaoDetalheResponse(long? Id = null, long? IdConfiguracaoEmail = null, TipoLayoutEnum? TipoLayout = null, TipoNotificacaoEnum? TipoNotificacao = null, string TemplatePadrao = null, string Remetente = null, string Assunto = null, string DataInclusao = null, string DataAlteracao = null, string Conteudo = null)
        {
            this.Id = Id;
            this.IdConfiguracaoEmail = IdConfiguracaoEmail;
            this.TipoLayout = TipoLayout;
            this.TipoNotificacao = TipoNotificacao;
            this.TemplatePadrao = TemplatePadrao;
            this.Remetente = Remetente;
            this.Assunto = Assunto;
            this.DataInclusao = DataInclusao;
            this.DataAlteracao = DataAlteracao;
            this.Conteudo = Conteudo;
            
        }
        
    
        /// <summary>
        /// Identifier Code
        /// </summary>
        /// <value>Identifier Code</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Identification Code of the E-mail Configuration
        /// </summary>
        /// <value>Identification Code of the E-mail Configuration</value>
        [DataMember(Name="idConfiguracaoEmail", EmitDefaultValue=false)]
        public long? IdConfiguracaoEmail { get; set; }
    
        /// <summary>
        /// Standard Template
        /// </summary>
        /// <value>Standard Template</value>
        [DataMember(Name="templatePadrao", EmitDefaultValue=false)]
        public string TemplatePadrao { get; set; }
    
        /// <summary>
        /// Sender
        /// </summary>
        /// <value>Sender</value>
        [DataMember(Name="remetente", EmitDefaultValue=false)]
        public string Remetente { get; set; }
    
        /// <summary>
        /// Email subject
        /// </summary>
        /// <value>Email subject</value>
        [DataMember(Name="assunto", EmitDefaultValue=false)]
        public string Assunto { get; set; }
    
        /// <summary>
        /// Inclusion date
        /// </summary>
        /// <value>Inclusion date</value>
        [DataMember(Name="dataInclusao", EmitDefaultValue=false)]
        public string DataInclusao { get; set; }
    
        /// <summary>
        /// Update date
        /// </summary>
        /// <value>Update date</value>
        [DataMember(Name="dataAlteracao", EmitDefaultValue=false)]
        public string DataAlteracao { get; set; }
    
        /// <summary>
        /// E-mail content
        /// </summary>
        /// <value>E-mail content</value>
        [DataMember(Name="conteudo", EmitDefaultValue=false)]
        public string Conteudo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateNotificacaoDetalheResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConfiguracaoEmail: ").Append(IdConfiguracaoEmail).Append("\n");
            sb.Append("  TipoLayout: ").Append(TipoLayout).Append("\n");
            sb.Append("  TipoNotificacao: ").Append(TipoNotificacao).Append("\n");
            sb.Append("  TemplatePadrao: ").Append(TemplatePadrao).Append("\n");
            sb.Append("  Remetente: ").Append(Remetente).Append("\n");
            sb.Append("  Assunto: ").Append(Assunto).Append("\n");
            sb.Append("  DataInclusao: ").Append(DataInclusao).Append("\n");
            sb.Append("  DataAlteracao: ").Append(DataAlteracao).Append("\n");
            sb.Append("  Conteudo: ").Append(Conteudo).Append("\n");
            
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
            return this.Equals(obj as TemplateNotificacaoDetalheResponse);
        }

        /// <summary>
        /// Returns true if TemplateNotificacaoDetalheResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TemplateNotificacaoDetalheResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateNotificacaoDetalheResponse other)
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
                    this.IdConfiguracaoEmail == other.IdConfiguracaoEmail ||
                    this.IdConfiguracaoEmail != null &&
                    this.IdConfiguracaoEmail.Equals(other.IdConfiguracaoEmail)
                ) && 
                (
                    this.TipoLayout == other.TipoLayout ||
                    this.TipoLayout != null &&
                    this.TipoLayout.Equals(other.TipoLayout)
                ) && 
                (
                    this.TipoNotificacao == other.TipoNotificacao ||
                    this.TipoNotificacao != null &&
                    this.TipoNotificacao.Equals(other.TipoNotificacao)
                ) && 
                (
                    this.TemplatePadrao == other.TemplatePadrao ||
                    this.TemplatePadrao != null &&
                    this.TemplatePadrao.Equals(other.TemplatePadrao)
                ) && 
                (
                    this.Remetente == other.Remetente ||
                    this.Remetente != null &&
                    this.Remetente.Equals(other.Remetente)
                ) && 
                (
                    this.Assunto == other.Assunto ||
                    this.Assunto != null &&
                    this.Assunto.Equals(other.Assunto)
                ) && 
                (
                    this.DataInclusao == other.DataInclusao ||
                    this.DataInclusao != null &&
                    this.DataInclusao.Equals(other.DataInclusao)
                ) && 
                (
                    this.DataAlteracao == other.DataAlteracao ||
                    this.DataAlteracao != null &&
                    this.DataAlteracao.Equals(other.DataAlteracao)
                ) && 
                (
                    this.Conteudo == other.Conteudo ||
                    this.Conteudo != null &&
                    this.Conteudo.Equals(other.Conteudo)
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
                
                if (this.IdConfiguracaoEmail != null)
                    hash = hash * 59 + this.IdConfiguracaoEmail.GetHashCode();
                
                if (this.TipoLayout != null)
                    hash = hash * 59 + this.TipoLayout.GetHashCode();
                
                if (this.TipoNotificacao != null)
                    hash = hash * 59 + this.TipoNotificacao.GetHashCode();
                
                if (this.TemplatePadrao != null)
                    hash = hash * 59 + this.TemplatePadrao.GetHashCode();
                
                if (this.Remetente != null)
                    hash = hash * 59 + this.Remetente.GetHashCode();
                
                if (this.Assunto != null)
                    hash = hash * 59 + this.Assunto.GetHashCode();
                
                if (this.DataInclusao != null)
                    hash = hash * 59 + this.DataInclusao.GetHashCode();
                
                if (this.DataAlteracao != null)
                    hash = hash * 59 + this.DataAlteracao.GetHashCode();
                
                if (this.Conteudo != null)
                    hash = hash * 59 + this.Conteudo.GetHashCode();
                
                return hash;
            }
        }

    }
}
