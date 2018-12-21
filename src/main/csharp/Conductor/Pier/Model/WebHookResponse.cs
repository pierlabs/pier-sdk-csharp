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
    /// Representation webhook resource
    /// </summary>
    [DataContract]
    public partial class WebHookResponse :  IEquatable<WebHookResponse>
    { 
    
        /// <summary>
        /// TypoEvent to be called by the WebHook
        /// </summary>
        /// <value>TypoEvent to be called by the WebHook</value>
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
        /// Method to be called by the WebHook
        /// </summary>
        /// <value>Method to be called by the WebHook</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MetodoEnum {
            
            [EnumMember(Value = "GET")]
            Get,
            
            [EnumMember(Value = "POST")]
            Post,
            
            [EnumMember(Value = "PUT")]
            Put,
            
            [EnumMember(Value = "DELETE")]
            Delete
        }

    
        /// <summary>
        /// Status of the WebHook
        /// </summary>
        /// <value>Status of the WebHook</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "INATIVO")]
            Inativo,
            
            [EnumMember(Value = "ATIVO")]
            Ativo
        }

    
        /// <summary>
        /// TypoEvent to be called by the WebHook
        /// </summary>
        /// <value>TypoEvent to be called by the WebHook</value>
        [DataMember(Name="tipoEvento", EmitDefaultValue=false)]
        public TipoEventoEnum? TipoEvento { get; set; }
    
        /// <summary>
        /// Method to be called by the WebHook
        /// </summary>
        /// <value>Method to be called by the WebHook</value>
        [DataMember(Name="metodo", EmitDefaultValue=false)]
        public MetodoEnum? Metodo { get; set; }
    
        /// <summary>
        /// Status of the WebHook
        /// </summary>
        /// <value>Status of the WebHook</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebHookResponse" /> class.
        /// Initializes a new instance of the <see cref="WebHookResponse" />class.
        /// </summary>
        /// <param name="Id">Id of the WebHook (required).</param>
        /// <param name="TipoEvento">TypoEvent to be called by the WebHook (required).</param>
        /// <param name="Metodo">Method to be called by the WebHook (required).</param>
        /// <param name="Url">URL to be consumed by the WebHook (required).</param>
        /// <param name="Status">Status of the WebHook (required).</param>

        public WebHookResponse(long? Id = null, TipoEventoEnum? TipoEvento = null, MetodoEnum? Metodo = null, string Url = null, StatusEnum? Status = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for WebHookResponse and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "TipoEvento" is required (not null)
            if (TipoEvento == null)
            {
                throw new InvalidDataException("TipoEvento is a required property for WebHookResponse and cannot be null");
            }
            else
            {
                this.TipoEvento = TipoEvento;
            }
            // to ensure "Metodo" is required (not null)
            if (Metodo == null)
            {
                throw new InvalidDataException("Metodo is a required property for WebHookResponse and cannot be null");
            }
            else
            {
                this.Metodo = Metodo;
            }
            // to ensure "Url" is required (not null)
            if (Url == null)
            {
                throw new InvalidDataException("Url is a required property for WebHookResponse and cannot be null");
            }
            else
            {
                this.Url = Url;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for WebHookResponse and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            
        }
        
    
        /// <summary>
        /// Id of the WebHook
        /// </summary>
        /// <value>Id of the WebHook</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// URL to be consumed by the WebHook
        /// </summary>
        /// <value>URL to be consumed by the WebHook</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebHookResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TipoEvento: ").Append(TipoEvento).Append("\n");
            sb.Append("  Metodo: ").Append(Metodo).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            
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
            return this.Equals(obj as WebHookResponse);
        }

        /// <summary>
        /// Returns true if WebHookResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of WebHookResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebHookResponse other)
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
                    this.TipoEvento == other.TipoEvento ||
                    this.TipoEvento != null &&
                    this.TipoEvento.Equals(other.TipoEvento)
                ) && 
                (
                    this.Metodo == other.Metodo ||
                    this.Metodo != null &&
                    this.Metodo.Equals(other.Metodo)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                
                if (this.TipoEvento != null)
                    hash = hash * 59 + this.TipoEvento.GetHashCode();
                
                if (this.Metodo != null)
                    hash = hash * 59 + this.Metodo.GetHashCode();
                
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }
}
