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
    /// Response Object for push notification
    /// </summary>
    [DataContract]
    public partial class NotificacaoPushResponse :  IEquatable<NotificacaoPushResponse>
    { 
    
        /// <summary>
        /// TypeEvent name of the notification
        /// </summary>
        /// <value>TypeEvent name of the notification</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TipoEventoEnum {
            
            [EnumMember(Value = "RISCO_FRAUDE")]
            RiscoFraude,
            
            [EnumMember(Value = "CODIGO_SEGURANCA")]
            CodigoSeguranca,
            
            [EnumMember(Value = "OUTROS")]
            Outros,
            
            [EnumMember(Value = "OTP_3D_SECURE")]
            Otp3dSecure,
            
            [EnumMember(Value = "PAGAMENTO")]
            Pagamento,
            
            [EnumMember(Value = "TRANSACAO_COMPRA_AUTORIZADO")]
            TransacaoCompraAutorizado,
            
            [EnumMember(Value = "TRANSACAO_COMPRA_NAO_AUTORIZADO")]
            TransacaoCompraNaoAutorizado,
            
            [EnumMember(Value = "TRANSACAO_SAQUE_AUTORIZADO")]
            TransacaoSaqueAutorizado,
            
            [EnumMember(Value = "TRANSACAO_SAQUE_NAO_AUTORIZADO")]
            TransacaoSaqueNaoAutorizado,
            
            [EnumMember(Value = "TRANSACAO_PAGAMENTO_AUTORIZADO")]
            TransacaoPagamentoAutorizado,
            
            [EnumMember(Value = "TRANSACAO_PAGAMENTO_NAO_AUTORIZADO")]
            TransacaoPagamentoNaoAutorizado,
            
            [EnumMember(Value = "TRANSACAO_ADVICE")]
            TransacaoAdvice,
            
            [EnumMember(Value = "TRANSACAO_ERRO")]
            TransacaoErro,
            
            [EnumMember(Value = "TRANSACAO_SIMULACAO")]
            TransacaoSimulacao,
            
            [EnumMember(Value = "TRANSACAO_SENHA_CHIP")]
            TransacaoSenhaChip,
            
            [EnumMember(Value = "TRANSACAO_CONSULTA_SALDO")]
            TransacaoConsultaSaldo,
            
            [EnumMember(Value = "TRANSACAO_CONSULTA_STATUS_CONTA")]
            TransacaoConsultaStatusConta,
            
            [EnumMember(Value = "TRANSACAO_DESFAZIMENTO")]
            TransacaoDesfazimento,
            
            [EnumMember(Value = "TRANSACAO_CANCELAMENTO")]
            TransacaoCancelamento,
            
            [EnumMember(Value = "TRANSACAO_RESPOSTA_SONDA")]
            TransacaoRespostaSonda,
            
            [EnumMember(Value = "TRANSACAO_TOKEN")]
            TransacaoToken
        }

    
        /// <summary>
        /// Status of the notification sending
        /// </summary>
        /// <value>Status of the notification sending</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "PENDENTE")]
            Pendente,
            
            [EnumMember(Value = "ENCAMINHADO")]
            Encaminhado,
            
            [EnumMember(Value = "ENVIADO")]
            Enviado,
            
            [EnumMember(Value = "RESPONDIDO")]
            Respondido,
            
            [EnumMember(Value = "ERRO")]
            Erro,
            
            [EnumMember(Value = "ERRO_RESPOSTA")]
            ErroResposta,
            
            [EnumMember(Value = "SUCESSO_RESPOSTA")]
            SucessoResposta
        }

    
        /// <summary>
        /// Name of the Operational System which was sent the Push
        /// </summary>
        /// <value>Name of the Operational System which was sent the Push</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PlataformaEnum {
            
            [EnumMember(Value = "APNS")]
            Apns,
            
            [EnumMember(Value = "FCM")]
            Fcm,
            
            [EnumMember(Value = "GCM")]
            Gcm
        }

    
        /// <summary>
        /// TypeEvent name of the notification
        /// </summary>
        /// <value>TypeEvent name of the notification</value>
        [DataMember(Name="tipoEvento", EmitDefaultValue=false)]
        public TipoEventoEnum? TipoEvento { get; set; }
    
        /// <summary>
        /// Status of the notification sending
        /// </summary>
        /// <value>Status of the notification sending</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Name of the Operational System which was sent the Push
        /// </summary>
        /// <value>Name of the Operational System which was sent the Push</value>
        [DataMember(Name="plataforma", EmitDefaultValue=false)]
        public PlataformaEnum? Plataforma { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificacaoPushResponse" /> class.
        /// Initializes a new instance of the <see cref="NotificacaoPushResponse" />class.
        /// </summary>
        /// <param name="DataEnvio">Show the date and in order the register was sent to the device.</param>
        /// <param name="IdEmissor">Identification Code of the issuer (id).</param>
        /// <param name="TipoEvento">TypeEvent name of the notification.</param>
        /// <param name="Status">Status of the notification sending.</param>
        /// <param name="IdPessoa">Identified Code of the person (required).</param>
        /// <param name="IdConta">Identifier Code of the Account (required).</param>
        /// <param name="TokenDispositivo">Token of the device which was destined the notificatio (device_token) (required).</param>
        /// <param name="Titulo">Sending Notification Title (required).</param>
        /// <param name="Conteudo">Content of the sent notification (required).</param>
        /// <param name="Plataforma">Name of the Operational System which was sent the Push.</param>
        /// <param name="Protocolo">Protocol number of the notification sending.</param>

        public NotificacaoPushResponse(string DataEnvio = null, long? IdEmissor = null, TipoEventoEnum? TipoEvento = null, StatusEnum? Status = null, long? IdPessoa = null, long? IdConta = null, string TokenDispositivo = null, string Titulo = null, string Conteudo = null, PlataformaEnum? Plataforma = null, string Protocolo = null)
        {
            // to ensure "IdPessoa" is required (not null)
            if (IdPessoa == null)
            {
                throw new InvalidDataException("IdPessoa is a required property for NotificacaoPushResponse and cannot be null");
            }
            else
            {
                this.IdPessoa = IdPessoa;
            }
            // to ensure "IdConta" is required (not null)
            if (IdConta == null)
            {
                throw new InvalidDataException("IdConta is a required property for NotificacaoPushResponse and cannot be null");
            }
            else
            {
                this.IdConta = IdConta;
            }
            // to ensure "TokenDispositivo" is required (not null)
            if (TokenDispositivo == null)
            {
                throw new InvalidDataException("TokenDispositivo is a required property for NotificacaoPushResponse and cannot be null");
            }
            else
            {
                this.TokenDispositivo = TokenDispositivo;
            }
            // to ensure "Titulo" is required (not null)
            if (Titulo == null)
            {
                throw new InvalidDataException("Titulo is a required property for NotificacaoPushResponse and cannot be null");
            }
            else
            {
                this.Titulo = Titulo;
            }
            // to ensure "Conteudo" is required (not null)
            if (Conteudo == null)
            {
                throw new InvalidDataException("Conteudo is a required property for NotificacaoPushResponse and cannot be null");
            }
            else
            {
                this.Conteudo = Conteudo;
            }
            this.DataEnvio = DataEnvio;
            this.IdEmissor = IdEmissor;
            this.TipoEvento = TipoEvento;
            this.Status = Status;
            this.Plataforma = Plataforma;
            this.Protocolo = Protocolo;
            
        }
        
    
        /// <summary>
        /// Show the date and in order the register was sent to the device
        /// </summary>
        /// <value>Show the date and in order the register was sent to the device</value>
        [DataMember(Name="dataEnvio", EmitDefaultValue=false)]
        public string DataEnvio { get; set; }
    
        /// <summary>
        /// Identification Code of the issuer (id)
        /// </summary>
        /// <value>Identification Code of the issuer (id)</value>
        [DataMember(Name="idEmissor", EmitDefaultValue=false)]
        public long? IdEmissor { get; set; }
    
        /// <summary>
        /// Identified Code of the person
        /// </summary>
        /// <value>Identified Code of the person</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// Identifier Code of the Account
        /// </summary>
        /// <value>Identifier Code of the Account</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Token of the device which was destined the notificatio (device_token)
        /// </summary>
        /// <value>Token of the device which was destined the notificatio (device_token)</value>
        [DataMember(Name="tokenDispositivo", EmitDefaultValue=false)]
        public string TokenDispositivo { get; set; }
    
        /// <summary>
        /// Sending Notification Title
        /// </summary>
        /// <value>Sending Notification Title</value>
        [DataMember(Name="titulo", EmitDefaultValue=false)]
        public string Titulo { get; set; }
    
        /// <summary>
        /// Content of the sent notification
        /// </summary>
        /// <value>Content of the sent notification</value>
        [DataMember(Name="conteudo", EmitDefaultValue=false)]
        public string Conteudo { get; set; }
    
        /// <summary>
        /// Protocol number of the notification sending
        /// </summary>
        /// <value>Protocol number of the notification sending</value>
        [DataMember(Name="protocolo", EmitDefaultValue=false)]
        public string Protocolo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificacaoPushResponse {\n");
            sb.Append("  DataEnvio: ").Append(DataEnvio).Append("\n");
            sb.Append("  IdEmissor: ").Append(IdEmissor).Append("\n");
            sb.Append("  TipoEvento: ").Append(TipoEvento).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  TokenDispositivo: ").Append(TokenDispositivo).Append("\n");
            sb.Append("  Titulo: ").Append(Titulo).Append("\n");
            sb.Append("  Conteudo: ").Append(Conteudo).Append("\n");
            sb.Append("  Plataforma: ").Append(Plataforma).Append("\n");
            sb.Append("  Protocolo: ").Append(Protocolo).Append("\n");
            
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
            return this.Equals(obj as NotificacaoPushResponse);
        }

        /// <summary>
        /// Returns true if NotificacaoPushResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of NotificacaoPushResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificacaoPushResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DataEnvio == other.DataEnvio ||
                    this.DataEnvio != null &&
                    this.DataEnvio.Equals(other.DataEnvio)
                ) && 
                (
                    this.IdEmissor == other.IdEmissor ||
                    this.IdEmissor != null &&
                    this.IdEmissor.Equals(other.IdEmissor)
                ) && 
                (
                    this.TipoEvento == other.TipoEvento ||
                    this.TipoEvento != null &&
                    this.TipoEvento.Equals(other.TipoEvento)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.TokenDispositivo == other.TokenDispositivo ||
                    this.TokenDispositivo != null &&
                    this.TokenDispositivo.Equals(other.TokenDispositivo)
                ) && 
                (
                    this.Titulo == other.Titulo ||
                    this.Titulo != null &&
                    this.Titulo.Equals(other.Titulo)
                ) && 
                (
                    this.Conteudo == other.Conteudo ||
                    this.Conteudo != null &&
                    this.Conteudo.Equals(other.Conteudo)
                ) && 
                (
                    this.Plataforma == other.Plataforma ||
                    this.Plataforma != null &&
                    this.Plataforma.Equals(other.Plataforma)
                ) && 
                (
                    this.Protocolo == other.Protocolo ||
                    this.Protocolo != null &&
                    this.Protocolo.Equals(other.Protocolo)
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
                
                if (this.DataEnvio != null)
                    hash = hash * 59 + this.DataEnvio.GetHashCode();
                
                if (this.IdEmissor != null)
                    hash = hash * 59 + this.IdEmissor.GetHashCode();
                
                if (this.TipoEvento != null)
                    hash = hash * 59 + this.TipoEvento.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.TokenDispositivo != null)
                    hash = hash * 59 + this.TokenDispositivo.GetHashCode();
                
                if (this.Titulo != null)
                    hash = hash * 59 + this.Titulo.GetHashCode();
                
                if (this.Conteudo != null)
                    hash = hash * 59 + this.Conteudo.GetHashCode();
                
                if (this.Plataforma != null)
                    hash = hash * 59 + this.Plataforma.GetHashCode();
                
                if (this.Protocolo != null)
                    hash = hash * 59 + this.Protocolo.GetHashCode();
                
                return hash;
            }
        }

    }
}
