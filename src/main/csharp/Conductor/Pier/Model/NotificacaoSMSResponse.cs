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
    /// {{{notificacao_s_m_s_response_description}}}
    /// </summary>
    [DataContract]
    public partial class NotificacaoSMSResponse :  IEquatable<NotificacaoSMSResponse>
    { 
    
        /// <summary>
        /// {{{notificacao_s_m_s_response_tipo_evento_value}}}
        /// </summary>
        /// <value>{{{notificacao_s_m_s_response_tipo_evento_value}}}</value>
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
        /// {{{notificacao_s_m_s_response_status_value}}}
        /// </summary>
        /// <value>{{{notificacao_s_m_s_response_status_value}}}</value>
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
        /// {{{notificacao_s_m_s_response_tipo_evento_value}}}
        /// </summary>
        /// <value>{{{notificacao_s_m_s_response_tipo_evento_value}}}</value>
        [DataMember(Name="tipoEvento", EmitDefaultValue=false)]
        public TipoEventoEnum? TipoEvento { get; set; }
    
        /// <summary>
        /// {{{notificacao_s_m_s_response_status_value}}}
        /// </summary>
        /// <value>{{{notificacao_s_m_s_response_status_value}}}</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificacaoSMSResponse" /> class.
        /// Initializes a new instance of the <see cref="NotificacaoSMSResponse" />class.
        /// </summary>
        /// <param name="Id">{{{notificacao_s_m_s_response_id_value}}}.</param>
        /// <param name="Nsu">{{{notificacao_s_m_s_response_nsu_value}}}.</param>
        /// <param name="IdEmissor">{{{notificacao_s_m_s_response_id_emissor_value}}}.</param>
        /// <param name="TipoEvento">{{{notificacao_s_m_s_response_tipo_evento_value}}}.</param>
        /// <param name="Status">{{{notificacao_s_m_s_response_status_value}}} (required).</param>
        /// <param name="DescricaoStatus">{{{notificacao_s_m_s_response_descricao_status_value}}} (required).</param>
        /// <param name="IdPessoa">{{{notificacao_s_m_s_response_id_pessoa_value}}} (required).</param>
        /// <param name="IdConta">{{{notificacao_s_m_s_response_id_conta_value}}} (required).</param>
        /// <param name="Celular">{{{notificacao_s_m_s_response_celular_value}}} (required).</param>
        /// <param name="Operadora">{{{notificacao_s_m_s_response_operadora_value}}} (required).</param>
        /// <param name="Conteudo">{{{notificacao_s_m_s_response_conteudo_value}}} (required).</param>
        /// <param name="Resposta">{{{notificacao_s_m_s_response_resposta_value}}} (required).</param>
        /// <param name="DataAgendamento">{{{notificacao_s_m_s_response_data_agendamento_value}}} (required).</param>
        /// <param name="QuantidadeTentativasEnvio">{{{notificacao_s_m_s_response_quantidade_tentativas_envio_value}}} (required).</param>
        /// <param name="DataInclusao">{{{notificacao_s_m_s_response_data_inclusao_value}}} (required).</param>
        /// <param name="DataAlteracaoStatus">{{{notificacao_s_m_s_response_data_alteracao_status_value}}} (required).</param>
        /// <param name="Protocolo">{{{notificacao_s_m_s_response_protocolo_value}}}.</param>

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
        /// {{{notificacao_s_m_s_response_id_value}}}
        /// </summary>
        /// <value>{{{notificacao_s_m_s_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{notificacao_s_m_s_response_nsu_value}}}
        /// </summary>
        /// <value>{{{notificacao_s_m_s_response_nsu_value}}}</value>
        [DataMember(Name="nsu", EmitDefaultValue=false)]
        public long? Nsu { get; set; }
    
        /// <summary>
        /// {{{notificacao_s_m_s_response_id_emissor_value}}}
        /// </summary>
        /// <value>{{{notificacao_s_m_s_response_id_emissor_value}}}</value>
        [DataMember(Name="idEmissor", EmitDefaultValue=false)]
        public long? IdEmissor { get; set; }
    
        /// <summary>
        /// {{{notificacao_s_m_s_response_descricao_status_value}}}
        /// </summary>
        /// <value>{{{notificacao_s_m_s_response_descricao_status_value}}}</value>
        [DataMember(Name="descricaoStatus", EmitDefaultValue=false)]
        public string DescricaoStatus { get; set; }
    
        /// <summary>
        /// {{{notificacao_s_m_s_response_id_pessoa_value}}}
        /// </summary>
        /// <value>{{{notificacao_s_m_s_response_id_pessoa_value}}}</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// {{{notificacao_s_m_s_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{notificacao_s_m_s_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{notificacao_s_m_s_response_celular_value}}}
        /// </summary>
        /// <value>{{{notificacao_s_m_s_response_celular_value}}}</value>
        [DataMember(Name="celular", EmitDefaultValue=false)]
        public string Celular { get; set; }
    
        /// <summary>
        /// {{{notificacao_s_m_s_response_operadora_value}}}
        /// </summary>
        /// <value>{{{notificacao_s_m_s_response_operadora_value}}}</value>
        [DataMember(Name="operadora", EmitDefaultValue=false)]
        public string Operadora { get; set; }
    
        /// <summary>
        /// {{{notificacao_s_m_s_response_conteudo_value}}}
        /// </summary>
        /// <value>{{{notificacao_s_m_s_response_conteudo_value}}}</value>
        [DataMember(Name="conteudo", EmitDefaultValue=false)]
        public string Conteudo { get; set; }
    
        /// <summary>
        /// {{{notificacao_s_m_s_response_resposta_value}}}
        /// </summary>
        /// <value>{{{notificacao_s_m_s_response_resposta_value}}}</value>
        [DataMember(Name="resposta", EmitDefaultValue=false)]
        public string Resposta { get; set; }
    
        /// <summary>
        /// {{{notificacao_s_m_s_response_data_agendamento_value}}}
        /// </summary>
        /// <value>{{{notificacao_s_m_s_response_data_agendamento_value}}}</value>
        [DataMember(Name="dataAgendamento", EmitDefaultValue=false)]
        public string DataAgendamento { get; set; }
    
        /// <summary>
        /// {{{notificacao_s_m_s_response_quantidade_tentativas_envio_value}}}
        /// </summary>
        /// <value>{{{notificacao_s_m_s_response_quantidade_tentativas_envio_value}}}</value>
        [DataMember(Name="quantidadeTentativasEnvio", EmitDefaultValue=false)]
        public int? QuantidadeTentativasEnvio { get; set; }
    
        /// <summary>
        /// {{{notificacao_s_m_s_response_data_inclusao_value}}}
        /// </summary>
        /// <value>{{{notificacao_s_m_s_response_data_inclusao_value}}}</value>
        [DataMember(Name="dataInclusao", EmitDefaultValue=false)]
        public string DataInclusao { get; set; }
    
        /// <summary>
        /// {{{notificacao_s_m_s_response_data_alteracao_status_value}}}
        /// </summary>
        /// <value>{{{notificacao_s_m_s_response_data_alteracao_status_value}}}</value>
        [DataMember(Name="dataAlteracaoStatus", EmitDefaultValue=false)]
        public string DataAlteracaoStatus { get; set; }
    
        /// <summary>
        /// {{{notificacao_s_m_s_response_protocolo_value}}}
        /// </summary>
        /// <value>{{{notificacao_s_m_s_response_protocolo_value}}}</value>
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
