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
    /// Objeto SMS
    /// </summary>
    [DataContract]
    public partial class NotificacaoSMSResponse :  IEquatable<NotificacaoSMSResponse>
    { 
    
        /// <summary>
        /// TipoEvento de notifica\u00E7\u00E3o
        /// </summary>
        /// <value>TipoEvento de notifica\u00E7\u00E3o</value>
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
        /// Status de envio da notifica\u00E7\u00E3o
        /// </summary>
        /// <value>Status de envio da notifica\u00E7\u00E3o</value>
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
        /// TipoEvento de notifica\u00E7\u00E3o
        /// </summary>
        /// <value>TipoEvento de notifica\u00E7\u00E3o</value>
        [DataMember(Name="tipoEvento", EmitDefaultValue=false)]
        public TipoEventoEnum? TipoEvento { get; set; }
    
        /// <summary>
        /// Status de envio da notifica\u00E7\u00E3o
        /// </summary>
        /// <value>Status de envio da notifica\u00E7\u00E3o</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificacaoSMSResponse" /> class.
        /// Initializes a new instance of the <see cref="NotificacaoSMSResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo Identificador.</param>
        /// <param name="Nsu">N\u00FAmero sequencial \u00FAnico.</param>
        /// <param name="IdEmissor">C\u00F3digo de identifica\u00E7\u00E3o do emissor (id).</param>
        /// <param name="TipoEvento">TipoEvento de notifica\u00E7\u00E3o.</param>
        /// <param name="Status">Status de envio da notifica\u00E7\u00E3o (required).</param>
        /// <param name="DescricaoStatus">Descri\u00E7\u00E3o do status de envio da notifica\u00E7\u00E3o (required).</param>
        /// <param name="IdPessoa">C\u00F3digo identificado da pessoa (required).</param>
        /// <param name="IdConta">C\u00F3digo identificador da conta (required).</param>
        /// <param name="Celular">Apresenta o celular a ser eviado o SMS no formato 5588999999999 ou 5588999999999 (required).</param>
        /// <param name="Operadora">Apresenta a operadora do celular a ser eviado o SMS (required).</param>
        /// <param name="Conteudo">Apresenta o texto da notifica\u00E7\u00E3o a ser enviado (required).</param>
        /// <param name="Resposta">Apresenta o texto da resposta da notifica\u00E7\u00E3o que foi enviada (required).</param>
        /// <param name="DataAgendamento">Apresenta a data e hora em que ser\u00E1 enviado a notifica\u00E7\u00E3o (required).</param>
        /// <param name="QuantidadeTentativasEnvio">Quantidade de tentativas e envio da notifica\u00E7\u00E3o (required).</param>
        /// <param name="DataInclusao">Apresenta a data e em que o registro foi inclu\u00EDdo na base para ser enviado (required).</param>
        /// <param name="DataAlteracaoStatus">Apresenta a data e em que o Stattjus do registro foi modificado (required).</param>
        /// <param name="Protocolo">N\u00FAmero do protocolo de envio de notifica\u00E7\u00F5es.</param>

        public NotificacaoSMSResponse(long? Id = null, long? Nsu = null, long? IdEmissor = null, TipoEventoEnum? TipoEvento = null, StatusEnum? Status = null, string DescricaoStatus = null, long? IdPessoa = null, long? IdConta = null, string Celular = null, string Operadora = null, string Conteudo = null, string Resposta = null, string DataAgendamento = null, int? QuantidadeTentativasEnvio = null, string DataInclusao = null, string DataAlteracaoStatus = null, string Protocolo = null)
        {
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for NotificacaoSMSResponse and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            // to ensure "DescricaoStatus" is required (not null)
            if (DescricaoStatus == null)
            {
                throw new InvalidDataException("DescricaoStatus is a required property for NotificacaoSMSResponse and cannot be null");
            }
            else
            {
                this.DescricaoStatus = DescricaoStatus;
            }
            // to ensure "IdPessoa" is required (not null)
            if (IdPessoa == null)
            {
                throw new InvalidDataException("IdPessoa is a required property for NotificacaoSMSResponse and cannot be null");
            }
            else
            {
                this.IdPessoa = IdPessoa;
            }
            // to ensure "IdConta" is required (not null)
            if (IdConta == null)
            {
                throw new InvalidDataException("IdConta is a required property for NotificacaoSMSResponse and cannot be null");
            }
            else
            {
                this.IdConta = IdConta;
            }
            // to ensure "Celular" is required (not null)
            if (Celular == null)
            {
                throw new InvalidDataException("Celular is a required property for NotificacaoSMSResponse and cannot be null");
            }
            else
            {
                this.Celular = Celular;
            }
            // to ensure "Operadora" is required (not null)
            if (Operadora == null)
            {
                throw new InvalidDataException("Operadora is a required property for NotificacaoSMSResponse and cannot be null");
            }
            else
            {
                this.Operadora = Operadora;
            }
            // to ensure "Conteudo" is required (not null)
            if (Conteudo == null)
            {
                throw new InvalidDataException("Conteudo is a required property for NotificacaoSMSResponse and cannot be null");
            }
            else
            {
                this.Conteudo = Conteudo;
            }
            // to ensure "Resposta" is required (not null)
            if (Resposta == null)
            {
                throw new InvalidDataException("Resposta is a required property for NotificacaoSMSResponse and cannot be null");
            }
            else
            {
                this.Resposta = Resposta;
            }
            // to ensure "DataAgendamento" is required (not null)
            if (DataAgendamento == null)
            {
                throw new InvalidDataException("DataAgendamento is a required property for NotificacaoSMSResponse and cannot be null");
            }
            else
            {
                this.DataAgendamento = DataAgendamento;
            }
            // to ensure "QuantidadeTentativasEnvio" is required (not null)
            if (QuantidadeTentativasEnvio == null)
            {
                throw new InvalidDataException("QuantidadeTentativasEnvio is a required property for NotificacaoSMSResponse and cannot be null");
            }
            else
            {
                this.QuantidadeTentativasEnvio = QuantidadeTentativasEnvio;
            }
            // to ensure "DataInclusao" is required (not null)
            if (DataInclusao == null)
            {
                throw new InvalidDataException("DataInclusao is a required property for NotificacaoSMSResponse and cannot be null");
            }
            else
            {
                this.DataInclusao = DataInclusao;
            }
            // to ensure "DataAlteracaoStatus" is required (not null)
            if (DataAlteracaoStatus == null)
            {
                throw new InvalidDataException("DataAlteracaoStatus is a required property for NotificacaoSMSResponse and cannot be null");
            }
            else
            {
                this.DataAlteracaoStatus = DataAlteracaoStatus;
            }
            this.Id = Id;
            this.Nsu = Nsu;
            this.IdEmissor = IdEmissor;
            this.TipoEvento = TipoEvento;
            this.Protocolo = Protocolo;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo Identificador
        /// </summary>
        /// <value>C\u00F3digo Identificador</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// N\u00FAmero sequencial \u00FAnico
        /// </summary>
        /// <value>N\u00FAmero sequencial \u00FAnico</value>
        [DataMember(Name="nsu", EmitDefaultValue=false)]
        public long? Nsu { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do emissor (id)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do emissor (id)</value>
        [DataMember(Name="idEmissor", EmitDefaultValue=false)]
        public long? IdEmissor { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do status de envio da notifica\u00E7\u00E3o
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do status de envio da notifica\u00E7\u00E3o</value>
        [DataMember(Name="descricaoStatus", EmitDefaultValue=false)]
        public string DescricaoStatus { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificado da pessoa
        /// </summary>
        /// <value>C\u00F3digo identificado da pessoa</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador da conta
        /// </summary>
        /// <value>C\u00F3digo identificador da conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Apresenta o celular a ser eviado o SMS no formato 5588999999999 ou 5588999999999
        /// </summary>
        /// <value>Apresenta o celular a ser eviado o SMS no formato 5588999999999 ou 5588999999999</value>
        [DataMember(Name="celular", EmitDefaultValue=false)]
        public string Celular { get; set; }
    
        /// <summary>
        /// Apresenta a operadora do celular a ser eviado o SMS
        /// </summary>
        /// <value>Apresenta a operadora do celular a ser eviado o SMS</value>
        [DataMember(Name="operadora", EmitDefaultValue=false)]
        public string Operadora { get; set; }
    
        /// <summary>
        /// Apresenta o texto da notifica\u00E7\u00E3o a ser enviado
        /// </summary>
        /// <value>Apresenta o texto da notifica\u00E7\u00E3o a ser enviado</value>
        [DataMember(Name="conteudo", EmitDefaultValue=false)]
        public string Conteudo { get; set; }
    
        /// <summary>
        /// Apresenta o texto da resposta da notifica\u00E7\u00E3o que foi enviada
        /// </summary>
        /// <value>Apresenta o texto da resposta da notifica\u00E7\u00E3o que foi enviada</value>
        [DataMember(Name="resposta", EmitDefaultValue=false)]
        public string Resposta { get; set; }
    
        /// <summary>
        /// Apresenta a data e hora em que ser\u00E1 enviado a notifica\u00E7\u00E3o
        /// </summary>
        /// <value>Apresenta a data e hora em que ser\u00E1 enviado a notifica\u00E7\u00E3o</value>
        [DataMember(Name="dataAgendamento", EmitDefaultValue=false)]
        public string DataAgendamento { get; set; }
    
        /// <summary>
        /// Quantidade de tentativas e envio da notifica\u00E7\u00E3o
        /// </summary>
        /// <value>Quantidade de tentativas e envio da notifica\u00E7\u00E3o</value>
        [DataMember(Name="quantidadeTentativasEnvio", EmitDefaultValue=false)]
        public int? QuantidadeTentativasEnvio { get; set; }
    
        /// <summary>
        /// Apresenta a data e em que o registro foi inclu\u00EDdo na base para ser enviado
        /// </summary>
        /// <value>Apresenta a data e em que o registro foi inclu\u00EDdo na base para ser enviado</value>
        [DataMember(Name="dataInclusao", EmitDefaultValue=false)]
        public string DataInclusao { get; set; }
    
        /// <summary>
        /// Apresenta a data e em que o Stattjus do registro foi modificado
        /// </summary>
        /// <value>Apresenta a data e em que o Stattjus do registro foi modificado</value>
        [DataMember(Name="dataAlteracaoStatus", EmitDefaultValue=false)]
        public string DataAlteracaoStatus { get; set; }
    
        /// <summary>
        /// N\u00FAmero do protocolo de envio de notifica\u00E7\u00F5es
        /// </summary>
        /// <value>N\u00FAmero do protocolo de envio de notifica\u00E7\u00F5es</value>
        [DataMember(Name="protocolo", EmitDefaultValue=false)]
        public string Protocolo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificacaoSMSResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Nsu: ").Append(Nsu).Append("\n");
            sb.Append("  IdEmissor: ").Append(IdEmissor).Append("\n");
            sb.Append("  TipoEvento: ").Append(TipoEvento).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DescricaoStatus: ").Append(DescricaoStatus).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  Celular: ").Append(Celular).Append("\n");
            sb.Append("  Operadora: ").Append(Operadora).Append("\n");
            sb.Append("  Conteudo: ").Append(Conteudo).Append("\n");
            sb.Append("  Resposta: ").Append(Resposta).Append("\n");
            sb.Append("  DataAgendamento: ").Append(DataAgendamento).Append("\n");
            sb.Append("  QuantidadeTentativasEnvio: ").Append(QuantidadeTentativasEnvio).Append("\n");
            sb.Append("  DataInclusao: ").Append(DataInclusao).Append("\n");
            sb.Append("  DataAlteracaoStatus: ").Append(DataAlteracaoStatus).Append("\n");
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
            return this.Equals(obj as NotificacaoSMSResponse);
        }

        /// <summary>
        /// Returns true if NotificacaoSMSResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of NotificacaoSMSResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificacaoSMSResponse other)
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
                    this.Nsu == other.Nsu ||
                    this.Nsu != null &&
                    this.Nsu.Equals(other.Nsu)
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
                    this.DescricaoStatus == other.DescricaoStatus ||
                    this.DescricaoStatus != null &&
                    this.DescricaoStatus.Equals(other.DescricaoStatus)
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
                    this.Operadora == other.Operadora ||
                    this.Operadora != null &&
                    this.Operadora.Equals(other.Operadora)
                ) && 
                (
                    this.Conteudo == other.Conteudo ||
                    this.Conteudo != null &&
                    this.Conteudo.Equals(other.Conteudo)
                ) && 
                (
                    this.Resposta == other.Resposta ||
                    this.Resposta != null &&
                    this.Resposta.Equals(other.Resposta)
                ) && 
                (
                    this.DataAgendamento == other.DataAgendamento ||
                    this.DataAgendamento != null &&
                    this.DataAgendamento.Equals(other.DataAgendamento)
                ) && 
                (
                    this.QuantidadeTentativasEnvio == other.QuantidadeTentativasEnvio ||
                    this.QuantidadeTentativasEnvio != null &&
                    this.QuantidadeTentativasEnvio.Equals(other.QuantidadeTentativasEnvio)
                ) && 
                (
                    this.DataInclusao == other.DataInclusao ||
                    this.DataInclusao != null &&
                    this.DataInclusao.Equals(other.DataInclusao)
                ) && 
                (
                    this.DataAlteracaoStatus == other.DataAlteracaoStatus ||
                    this.DataAlteracaoStatus != null &&
                    this.DataAlteracaoStatus.Equals(other.DataAlteracaoStatus)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Nsu != null)
                    hash = hash * 59 + this.Nsu.GetHashCode();
                
                if (this.IdEmissor != null)
                    hash = hash * 59 + this.IdEmissor.GetHashCode();
                
                if (this.TipoEvento != null)
                    hash = hash * 59 + this.TipoEvento.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.DescricaoStatus != null)
                    hash = hash * 59 + this.DescricaoStatus.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.Celular != null)
                    hash = hash * 59 + this.Celular.GetHashCode();
                
                if (this.Operadora != null)
                    hash = hash * 59 + this.Operadora.GetHashCode();
                
                if (this.Conteudo != null)
                    hash = hash * 59 + this.Conteudo.GetHashCode();
                
                if (this.Resposta != null)
                    hash = hash * 59 + this.Resposta.GetHashCode();
                
                if (this.DataAgendamento != null)
                    hash = hash * 59 + this.DataAgendamento.GetHashCode();
                
                if (this.QuantidadeTentativasEnvio != null)
                    hash = hash * 59 + this.QuantidadeTentativasEnvio.GetHashCode();
                
                if (this.DataInclusao != null)
                    hash = hash * 59 + this.DataInclusao.GetHashCode();
                
                if (this.DataAlteracaoStatus != null)
                    hash = hash * 59 + this.DataAlteracaoStatus.GetHashCode();
                
                if (this.Protocolo != null)
                    hash = hash * 59 + this.Protocolo.GetHashCode();
                
                return hash;
            }
        }

    }
}
