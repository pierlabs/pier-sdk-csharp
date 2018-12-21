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
    /// Object Notification
    /// </summary>
    [DataContract]
    public partial class NotificationSMSBody :  IEquatable<NotificationSMSBody>
    { 
    
        /// <summary>
        /// Show the typeEvent which belongs the notification
        /// </summary>
        /// <value>Show the typeEvent which belongs the notification</value>
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
        /// Show the typeEvent which belongs the notification
        /// </summary>
        /// <value>Show the typeEvent which belongs the notification</value>
        [DataMember(Name="tipoEvento", EmitDefaultValue=false)]
        public TipoEventoEnum? TipoEvento { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationSMSBody" /> class.
        /// Initializes a new instance of the <see cref="NotificationSMSBody" />class.
        /// </summary>
        /// <param name="Nsu">Unique Sequel Number.</param>
        /// <param name="IdPessoa">Identified code of the person.</param>
        /// <param name="IdConta">Identifier Code of the account.</param>
        /// <param name="Celular">Represent the cell phone to be sent the SMS in the format 5588999999999 ou 5588999999999 (required).</param>
        /// <param name="Conteudo">Show the text of SMS to be sent (required).</param>
        /// <param name="DataAgendamento">Show the time and date which will be send the notification.</param>
        /// <param name="TipoEvento">Show the typeEvent which belongs the notification (required).</param>

        public NotificationSMSBody(long? Nsu = null, long? IdPessoa = null, long? IdConta = null, string Celular = null, string Conteudo = null, string DataAgendamento = null, TipoEventoEnum? TipoEvento = null)
        {
            // to ensure "Celular" is required (not null)
            if (Celular == null)
            {
                throw new InvalidDataException("Celular is a required property for NotificationSMSBody and cannot be null");
            }
            else
            {
                this.Celular = Celular;
            }
            // to ensure "Conteudo" is required (not null)
            if (Conteudo == null)
            {
                throw new InvalidDataException("Conteudo is a required property for NotificationSMSBody and cannot be null");
            }
            else
            {
                this.Conteudo = Conteudo;
            }
            // to ensure "TipoEvento" is required (not null)
            if (TipoEvento == null)
            {
                throw new InvalidDataException("TipoEvento is a required property for NotificationSMSBody and cannot be null");
            }
            else
            {
                this.TipoEvento = TipoEvento;
            }
            this.Nsu = Nsu;
            this.IdPessoa = IdPessoa;
            this.IdConta = IdConta;
            this.DataAgendamento = DataAgendamento;
            
        }
        
    
        /// <summary>
        /// Unique Sequel Number
        /// </summary>
        /// <value>Unique Sequel Number</value>
        [DataMember(Name="nsu", EmitDefaultValue=false)]
        public long? Nsu { get; set; }
    
        /// <summary>
        /// Identified code of the person
        /// </summary>
        /// <value>Identified code of the person</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// Identifier Code of the account
        /// </summary>
        /// <value>Identifier Code of the account</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Represent the cell phone to be sent the SMS in the format 5588999999999 ou 5588999999999
        /// </summary>
        /// <value>Represent the cell phone to be sent the SMS in the format 5588999999999 ou 5588999999999</value>
        [DataMember(Name="celular", EmitDefaultValue=false)]
        public string Celular { get; set; }
    
        /// <summary>
        /// Show the text of SMS to be sent
        /// </summary>
        /// <value>Show the text of SMS to be sent</value>
        [DataMember(Name="conteudo", EmitDefaultValue=false)]
        public string Conteudo { get; set; }
    
        /// <summary>
        /// Show the time and date which will be send the notification
        /// </summary>
        /// <value>Show the time and date which will be send the notification</value>
        [DataMember(Name="dataAgendamento", EmitDefaultValue=false)]
        public string DataAgendamento { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationSMSBody {\n");
            sb.Append("  Nsu: ").Append(Nsu).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  Celular: ").Append(Celular).Append("\n");
            sb.Append("  Conteudo: ").Append(Conteudo).Append("\n");
            sb.Append("  DataAgendamento: ").Append(DataAgendamento).Append("\n");
            sb.Append("  TipoEvento: ").Append(TipoEvento).Append("\n");
            
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
            return this.Equals(obj as NotificationSMSBody);
        }

        /// <summary>
        /// Returns true if NotificationSMSBody instances are equal
        /// </summary>
        /// <param name="other">Instance of NotificationSMSBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationSMSBody other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Nsu == other.Nsu ||
                    this.Nsu != null &&
                    this.Nsu.Equals(other.Nsu)
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
                    this.Celular == other.Celular ||
                    this.Celular != null &&
                    this.Celular.Equals(other.Celular)
                ) && 
                (
                    this.Conteudo == other.Conteudo ||
                    this.Conteudo != null &&
                    this.Conteudo.Equals(other.Conteudo)
                ) && 
                (
                    this.DataAgendamento == other.DataAgendamento ||
                    this.DataAgendamento != null &&
                    this.DataAgendamento.Equals(other.DataAgendamento)
                ) && 
                (
                    this.TipoEvento == other.TipoEvento ||
                    this.TipoEvento != null &&
                    this.TipoEvento.Equals(other.TipoEvento)
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
                
                if (this.Nsu != null)
                    hash = hash * 59 + this.Nsu.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.Celular != null)
                    hash = hash * 59 + this.Celular.GetHashCode();
                
                if (this.Conteudo != null)
                    hash = hash * 59 + this.Conteudo.GetHashCode();
                
                if (this.DataAgendamento != null)
                    hash = hash * 59 + this.DataAgendamento.GetHashCode();
                
                if (this.TipoEvento != null)
                    hash = hash * 59 + this.TipoEvento.GetHashCode();
                
                return hash;
            }
        }

    }
}
