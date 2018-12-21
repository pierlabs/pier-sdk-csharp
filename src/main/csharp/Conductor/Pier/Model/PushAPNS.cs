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
    /// Object Push Notification APNS
    /// </summary>
    [DataContract]
    public partial class PushAPNS :  IEquatable<PushAPNS>
    { 
    
        /// <summary>
        /// Show the typeEvent which the notification belongs
        /// </summary>
        /// <value>Show the typeEvent which the notification belongs</value>
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
        /// Show the typeEvent which the notification belongs
        /// </summary>
        /// <value>Show the typeEvent which the notification belongs</value>
        [DataMember(Name="tipoEvento", EmitDefaultValue=false)]
        public TipoEventoEnum? TipoEvento { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PushAPNS" /> class.
        /// Initializes a new instance of the <see cref="PushAPNS" />class.
        /// </summary>
        /// <param name="IdPessoa">Identification Code of the Person (required).</param>
        /// <param name="IdConta">Identifier Code of the account (required).</param>
        /// <param name="TokenDispositivo">show the token of the device that must recieve the push (required).</param>
        /// <param name="Certificado">Show the certificate APNs that is registered to the applicative in the apple store. This certificate must be sent in the format Base64 (required).</param>
        /// <param name="Senha">Show the password for the certificate APNs registered to the app in the Apple store (required).</param>
        /// <param name="Titulo">Show the title of the notification (required).</param>
        /// <param name="Conteudo">Show the notification text to be sent (required).</param>
        /// <param name="TipoEvento">Show the typeEvent which the notification belongs (required).</param>
        /// <param name="Icone">Show the Icon name to be presented in the push.</param>
        /// <param name="Som">Show the icon color to be presented on the push.</param>

        public PushAPNS(long? IdPessoa = null, long? IdConta = null, string TokenDispositivo = null, string Certificado = null, string Senha = null, string Titulo = null, string Conteudo = null, TipoEventoEnum? TipoEvento = null, string Icone = null, string Som = null)
        {
            // to ensure "IdPessoa" is required (not null)
            if (IdPessoa == null)
            {
                throw new InvalidDataException("IdPessoa is a required property for PushAPNS and cannot be null");
            }
            else
            {
                this.IdPessoa = IdPessoa;
            }
            // to ensure "IdConta" is required (not null)
            if (IdConta == null)
            {
                throw new InvalidDataException("IdConta is a required property for PushAPNS and cannot be null");
            }
            else
            {
                this.IdConta = IdConta;
            }
            // to ensure "TokenDispositivo" is required (not null)
            if (TokenDispositivo == null)
            {
                throw new InvalidDataException("TokenDispositivo is a required property for PushAPNS and cannot be null");
            }
            else
            {
                this.TokenDispositivo = TokenDispositivo;
            }
            // to ensure "Certificado" is required (not null)
            if (Certificado == null)
            {
                throw new InvalidDataException("Certificado is a required property for PushAPNS and cannot be null");
            }
            else
            {
                this.Certificado = Certificado;
            }
            // to ensure "Senha" is required (not null)
            if (Senha == null)
            {
                throw new InvalidDataException("Senha is a required property for PushAPNS and cannot be null");
            }
            else
            {
                this.Senha = Senha;
            }
            // to ensure "Titulo" is required (not null)
            if (Titulo == null)
            {
                throw new InvalidDataException("Titulo is a required property for PushAPNS and cannot be null");
            }
            else
            {
                this.Titulo = Titulo;
            }
            // to ensure "Conteudo" is required (not null)
            if (Conteudo == null)
            {
                throw new InvalidDataException("Conteudo is a required property for PushAPNS and cannot be null");
            }
            else
            {
                this.Conteudo = Conteudo;
            }
            // to ensure "TipoEvento" is required (not null)
            if (TipoEvento == null)
            {
                throw new InvalidDataException("TipoEvento is a required property for PushAPNS and cannot be null");
            }
            else
            {
                this.TipoEvento = TipoEvento;
            }
            this.Icone = Icone;
            this.Som = Som;
            
        }
        
    
        /// <summary>
        /// Identification Code of the Person
        /// </summary>
        /// <value>Identification Code of the Person</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// Identifier Code of the account
        /// </summary>
        /// <value>Identifier Code of the account</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// show the token of the device that must recieve the push
        /// </summary>
        /// <value>show the token of the device that must recieve the push</value>
        [DataMember(Name="tokenDispositivo", EmitDefaultValue=false)]
        public string TokenDispositivo { get; set; }
    
        /// <summary>
        /// Show the certificate APNs that is registered to the applicative in the apple store. This certificate must be sent in the format Base64
        /// </summary>
        /// <value>Show the certificate APNs that is registered to the applicative in the apple store. This certificate must be sent in the format Base64</value>
        [DataMember(Name="certificado", EmitDefaultValue=false)]
        public string Certificado { get; set; }
    
        /// <summary>
        /// Show the password for the certificate APNs registered to the app in the Apple store
        /// </summary>
        /// <value>Show the password for the certificate APNs registered to the app in the Apple store</value>
        [DataMember(Name="senha", EmitDefaultValue=false)]
        public string Senha { get; set; }
    
        /// <summary>
        /// Show the title of the notification
        /// </summary>
        /// <value>Show the title of the notification</value>
        [DataMember(Name="titulo", EmitDefaultValue=false)]
        public string Titulo { get; set; }
    
        /// <summary>
        /// Show the notification text to be sent
        /// </summary>
        /// <value>Show the notification text to be sent</value>
        [DataMember(Name="conteudo", EmitDefaultValue=false)]
        public string Conteudo { get; set; }
    
        /// <summary>
        /// Show the Icon name to be presented in the push
        /// </summary>
        /// <value>Show the Icon name to be presented in the push</value>
        [DataMember(Name="icone", EmitDefaultValue=false)]
        public string Icone { get; set; }
    
        /// <summary>
        /// Show the icon color to be presented on the push
        /// </summary>
        /// <value>Show the icon color to be presented on the push</value>
        [DataMember(Name="som", EmitDefaultValue=false)]
        public string Som { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PushAPNS {\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  TokenDispositivo: ").Append(TokenDispositivo).Append("\n");
            sb.Append("  Certificado: ").Append(Certificado).Append("\n");
            sb.Append("  Senha: ").Append(Senha).Append("\n");
            sb.Append("  Titulo: ").Append(Titulo).Append("\n");
            sb.Append("  Conteudo: ").Append(Conteudo).Append("\n");
            sb.Append("  TipoEvento: ").Append(TipoEvento).Append("\n");
            sb.Append("  Icone: ").Append(Icone).Append("\n");
            sb.Append("  Som: ").Append(Som).Append("\n");
            
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
            return this.Equals(obj as PushAPNS);
        }

        /// <summary>
        /// Returns true if PushAPNS instances are equal
        /// </summary>
        /// <param name="other">Instance of PushAPNS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PushAPNS other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.Certificado == other.Certificado ||
                    this.Certificado != null &&
                    this.Certificado.Equals(other.Certificado)
                ) && 
                (
                    this.Senha == other.Senha ||
                    this.Senha != null &&
                    this.Senha.Equals(other.Senha)
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
                    this.TipoEvento == other.TipoEvento ||
                    this.TipoEvento != null &&
                    this.TipoEvento.Equals(other.TipoEvento)
                ) && 
                (
                    this.Icone == other.Icone ||
                    this.Icone != null &&
                    this.Icone.Equals(other.Icone)
                ) && 
                (
                    this.Som == other.Som ||
                    this.Som != null &&
                    this.Som.Equals(other.Som)
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
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.TokenDispositivo != null)
                    hash = hash * 59 + this.TokenDispositivo.GetHashCode();
                
                if (this.Certificado != null)
                    hash = hash * 59 + this.Certificado.GetHashCode();
                
                if (this.Senha != null)
                    hash = hash * 59 + this.Senha.GetHashCode();
                
                if (this.Titulo != null)
                    hash = hash * 59 + this.Titulo.GetHashCode();
                
                if (this.Conteudo != null)
                    hash = hash * 59 + this.Conteudo.GetHashCode();
                
                if (this.TipoEvento != null)
                    hash = hash * 59 + this.TipoEvento.GetHashCode();
                
                if (this.Icone != null)
                    hash = hash * 59 + this.Icone.GetHashCode();
                
                if (this.Som != null)
                    hash = hash * 59 + this.Som.GetHashCode();
                
                return hash;
            }
        }

    }
}
