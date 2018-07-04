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
    /// {{{transacao_pay_secure_request_description}}}
    /// </summary>
    [DataContract]
    public partial class TransacaoPaySecureRequest :  IEquatable<TransacaoPaySecureRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransacaoPaySecureRequest" /> class.
        /// Initializes a new instance of the <see cref="TransacaoPaySecureRequest" />class.
        /// </summary>
        /// <param name="DataHoraTransacao">{{{transacao_pay_secure_request_data_hora_transacao_value}}}.</param>
        /// <param name="NumeroCartao">{{{transacao_pay_generic_request_numero_cartao_value}}}.</param>
        /// <param name="IdCartao">{{{transacao_pay_generic_request_id_cartao_value}}}.</param>
        /// <param name="Valor">{{{transacao_pay_secure_request_valor_value}}}.</param>
        /// <param name="NsuOrigem">{{{transacao_pay_secure_request_nsu_origem_value}}}.</param>
        /// <param name="NomePortadorCartao">{{{transacao_pay_secure_request_nome_portador_cartao_value}}}.</param>
        /// <param name="Origem">{{{transacao_pay_generic_request_origem_value}}}.</param>
        /// <param name="TerminalRequisitante">{{{transacao_pay_secure_request_terminal_requisitante_value}}} (required).</param>
        /// <param name="CodigoProcessamento">{{{transacao_pay_secure_request_codigo_processamento_value}}} (required).</param>
        /// <param name="DataValidadeCartao">{{{transacao_pay_secure_request_data_validade_cartao_value}}} (required).</param>
        /// <param name="NumeroEstabelecimento">{{{transacao_pay_secure_request_numero_estabelecimento_value}}} (required).</param>
        /// <param name="NumeroParcelas">{{{transacao_pay_secure_request_numero_parcelas_value}}} (required).</param>
        /// <param name="CodigoSegurancaCartao">{{{transacao_pay_secure_request_codigo_seguranca_cartao_value}}} (required).</param>
        /// <param name="Sort">{{{global_menssagem_sort_sort}}}.</param>

        public TransacaoPaySecureRequest(string DataHoraTransacao = null, string NumeroCartao = null, long? IdCartao = null, double? Valor = null, string NsuOrigem = null, string NomePortadorCartao = null, string Origem = null, string TerminalRequisitante = null, string CodigoProcessamento = null, string DataValidadeCartao = null, string NumeroEstabelecimento = null, long? NumeroParcelas = null, string CodigoSegurancaCartao = null, List<string> Sort = null)
        {
            // to ensure "TerminalRequisitante" is required (not null)
            if (TerminalRequisitante == null)
            {
                throw new InvalidDataException("TerminalRequisitante is a required property for TransacaoPaySecureRequest and cannot be null");
            }
            else
            {
                this.TerminalRequisitante = TerminalRequisitante;
            }
            // to ensure "CodigoProcessamento" is required (not null)
            if (CodigoProcessamento == null)
            {
                throw new InvalidDataException("CodigoProcessamento is a required property for TransacaoPaySecureRequest and cannot be null");
            }
            else
            {
                this.CodigoProcessamento = CodigoProcessamento;
            }
            // to ensure "DataValidadeCartao" is required (not null)
            if (DataValidadeCartao == null)
            {
                throw new InvalidDataException("DataValidadeCartao is a required property for TransacaoPaySecureRequest and cannot be null");
            }
            else
            {
                this.DataValidadeCartao = DataValidadeCartao;
            }
            // to ensure "NumeroEstabelecimento" is required (not null)
            if (NumeroEstabelecimento == null)
            {
                throw new InvalidDataException("NumeroEstabelecimento is a required property for TransacaoPaySecureRequest and cannot be null");
            }
            else
            {
                this.NumeroEstabelecimento = NumeroEstabelecimento;
            }
            // to ensure "NumeroParcelas" is required (not null)
            if (NumeroParcelas == null)
            {
                throw new InvalidDataException("NumeroParcelas is a required property for TransacaoPaySecureRequest and cannot be null");
            }
            else
            {
                this.NumeroParcelas = NumeroParcelas;
            }
            // to ensure "CodigoSegurancaCartao" is required (not null)
            if (CodigoSegurancaCartao == null)
            {
                throw new InvalidDataException("CodigoSegurancaCartao is a required property for TransacaoPaySecureRequest and cannot be null");
            }
            else
            {
                this.CodigoSegurancaCartao = CodigoSegurancaCartao;
            }
            this.DataHoraTransacao = DataHoraTransacao;
            this.NumeroCartao = NumeroCartao;
            this.IdCartao = IdCartao;
            this.Valor = Valor;
            this.NsuOrigem = NsuOrigem;
            this.NomePortadorCartao = NomePortadorCartao;
            this.Origem = Origem;
            this.Sort = Sort;
            
        }
        
    
        /// <summary>
        /// {{{transacao_pay_secure_request_data_hora_transacao_value}}}
        /// </summary>
        /// <value>{{{transacao_pay_secure_request_data_hora_transacao_value}}}</value>
        [DataMember(Name="dataHoraTransacao", EmitDefaultValue=false)]
        public string DataHoraTransacao { get; set; }
    
        /// <summary>
        /// {{{transacao_pay_generic_request_numero_cartao_value}}}
        /// </summary>
        /// <value>{{{transacao_pay_generic_request_numero_cartao_value}}}</value>
        [DataMember(Name="numeroCartao", EmitDefaultValue=false)]
        public string NumeroCartao { get; set; }
    
        /// <summary>
        /// {{{transacao_pay_generic_request_id_cartao_value}}}
        /// </summary>
        /// <value>{{{transacao_pay_generic_request_id_cartao_value}}}</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// {{{transacao_pay_secure_request_valor_value}}}
        /// </summary>
        /// <value>{{{transacao_pay_secure_request_valor_value}}}</value>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }
    
        /// <summary>
        /// {{{transacao_pay_secure_request_nsu_origem_value}}}
        /// </summary>
        /// <value>{{{transacao_pay_secure_request_nsu_origem_value}}}</value>
        [DataMember(Name="nsuOrigem", EmitDefaultValue=false)]
        public string NsuOrigem { get; set; }
    
        /// <summary>
        /// {{{transacao_pay_secure_request_nome_portador_cartao_value}}}
        /// </summary>
        /// <value>{{{transacao_pay_secure_request_nome_portador_cartao_value}}}</value>
        [DataMember(Name="nomePortadorCartao", EmitDefaultValue=false)]
        public string NomePortadorCartao { get; set; }
    
        /// <summary>
        /// {{{transacao_pay_generic_request_origem_value}}}
        /// </summary>
        /// <value>{{{transacao_pay_generic_request_origem_value}}}</value>
        [DataMember(Name="origem", EmitDefaultValue=false)]
        public string Origem { get; set; }
    
        /// <summary>
        /// {{{transacao_pay_secure_request_terminal_requisitante_value}}}
        /// </summary>
        /// <value>{{{transacao_pay_secure_request_terminal_requisitante_value}}}</value>
        [DataMember(Name="terminalRequisitante", EmitDefaultValue=false)]
        public string TerminalRequisitante { get; set; }
    
        /// <summary>
        /// {{{transacao_pay_secure_request_codigo_processamento_value}}}
        /// </summary>
        /// <value>{{{transacao_pay_secure_request_codigo_processamento_value}}}</value>
        [DataMember(Name="codigoProcessamento", EmitDefaultValue=false)]
        public string CodigoProcessamento { get; set; }
    
        /// <summary>
        /// {{{transacao_pay_secure_request_data_validade_cartao_value}}}
        /// </summary>
        /// <value>{{{transacao_pay_secure_request_data_validade_cartao_value}}}</value>
        [DataMember(Name="dataValidadeCartao", EmitDefaultValue=false)]
        public string DataValidadeCartao { get; set; }
    
        /// <summary>
        /// {{{transacao_pay_secure_request_numero_estabelecimento_value}}}
        /// </summary>
        /// <value>{{{transacao_pay_secure_request_numero_estabelecimento_value}}}</value>
        [DataMember(Name="numeroEstabelecimento", EmitDefaultValue=false)]
        public string NumeroEstabelecimento { get; set; }
    
        /// <summary>
        /// {{{transacao_pay_secure_request_numero_parcelas_value}}}
        /// </summary>
        /// <value>{{{transacao_pay_secure_request_numero_parcelas_value}}}</value>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public long? NumeroParcelas { get; set; }
    
        /// <summary>
        /// {{{transacao_pay_secure_request_codigo_seguranca_cartao_value}}}
        /// </summary>
        /// <value>{{{transacao_pay_secure_request_codigo_seguranca_cartao_value}}}</value>
        [DataMember(Name="codigoSegurancaCartao", EmitDefaultValue=false)]
        public string CodigoSegurancaCartao { get; set; }
    
        /// <summary>
        /// {{{global_menssagem_sort_sort}}}
        /// </summary>
        /// <value>{{{global_menssagem_sort_sort}}}</value>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public List<string> Sort { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransacaoPaySecureRequest {\n");
            sb.Append("  DataHoraTransacao: ").Append(DataHoraTransacao).Append("\n");
            sb.Append("  NumeroCartao: ").Append(NumeroCartao).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  NsuOrigem: ").Append(NsuOrigem).Append("\n");
            sb.Append("  NomePortadorCartao: ").Append(NomePortadorCartao).Append("\n");
            sb.Append("  Origem: ").Append(Origem).Append("\n");
            sb.Append("  TerminalRequisitante: ").Append(TerminalRequisitante).Append("\n");
            sb.Append("  CodigoProcessamento: ").Append(CodigoProcessamento).Append("\n");
            sb.Append("  DataValidadeCartao: ").Append(DataValidadeCartao).Append("\n");
            sb.Append("  NumeroEstabelecimento: ").Append(NumeroEstabelecimento).Append("\n");
            sb.Append("  NumeroParcelas: ").Append(NumeroParcelas).Append("\n");
            sb.Append("  CodigoSegurancaCartao: ").Append(CodigoSegurancaCartao).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            
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
            return this.Equals(obj as TransacaoPaySecureRequest);
        }

        /// <summary>
        /// Returns true if TransacaoPaySecureRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of TransacaoPaySecureRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransacaoPaySecureRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DataHoraTransacao == other.DataHoraTransacao ||
                    this.DataHoraTransacao != null &&
                    this.DataHoraTransacao.Equals(other.DataHoraTransacao)
                ) && 
                (
                    this.NumeroCartao == other.NumeroCartao ||
                    this.NumeroCartao != null &&
                    this.NumeroCartao.Equals(other.NumeroCartao)
                ) && 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.Valor == other.Valor ||
                    this.Valor != null &&
                    this.Valor.Equals(other.Valor)
                ) && 
                (
                    this.NsuOrigem == other.NsuOrigem ||
                    this.NsuOrigem != null &&
                    this.NsuOrigem.Equals(other.NsuOrigem)
                ) && 
                (
                    this.NomePortadorCartao == other.NomePortadorCartao ||
                    this.NomePortadorCartao != null &&
                    this.NomePortadorCartao.Equals(other.NomePortadorCartao)
                ) && 
                (
                    this.Origem == other.Origem ||
                    this.Origem != null &&
                    this.Origem.Equals(other.Origem)
                ) && 
                (
                    this.TerminalRequisitante == other.TerminalRequisitante ||
                    this.TerminalRequisitante != null &&
                    this.TerminalRequisitante.Equals(other.TerminalRequisitante)
                ) && 
                (
                    this.CodigoProcessamento == other.CodigoProcessamento ||
                    this.CodigoProcessamento != null &&
                    this.CodigoProcessamento.Equals(other.CodigoProcessamento)
                ) && 
                (
                    this.DataValidadeCartao == other.DataValidadeCartao ||
                    this.DataValidadeCartao != null &&
                    this.DataValidadeCartao.Equals(other.DataValidadeCartao)
                ) && 
                (
                    this.NumeroEstabelecimento == other.NumeroEstabelecimento ||
                    this.NumeroEstabelecimento != null &&
                    this.NumeroEstabelecimento.Equals(other.NumeroEstabelecimento)
                ) && 
                (
                    this.NumeroParcelas == other.NumeroParcelas ||
                    this.NumeroParcelas != null &&
                    this.NumeroParcelas.Equals(other.NumeroParcelas)
                ) && 
                (
                    this.CodigoSegurancaCartao == other.CodigoSegurancaCartao ||
                    this.CodigoSegurancaCartao != null &&
                    this.CodigoSegurancaCartao.Equals(other.CodigoSegurancaCartao)
                ) && 
                (
                    this.Sort == other.Sort ||
                    this.Sort != null &&
                    this.Sort.SequenceEqual(other.Sort)
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
                
                if (this.DataHoraTransacao != null)
                    hash = hash * 59 + this.DataHoraTransacao.GetHashCode();
                
                if (this.NumeroCartao != null)
                    hash = hash * 59 + this.NumeroCartao.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
                if (this.NsuOrigem != null)
                    hash = hash * 59 + this.NsuOrigem.GetHashCode();
                
                if (this.NomePortadorCartao != null)
                    hash = hash * 59 + this.NomePortadorCartao.GetHashCode();
                
                if (this.Origem != null)
                    hash = hash * 59 + this.Origem.GetHashCode();
                
                if (this.TerminalRequisitante != null)
                    hash = hash * 59 + this.TerminalRequisitante.GetHashCode();
                
                if (this.CodigoProcessamento != null)
                    hash = hash * 59 + this.CodigoProcessamento.GetHashCode();
                
                if (this.DataValidadeCartao != null)
                    hash = hash * 59 + this.DataValidadeCartao.GetHashCode();
                
                if (this.NumeroEstabelecimento != null)
                    hash = hash * 59 + this.NumeroEstabelecimento.GetHashCode();
                
                if (this.NumeroParcelas != null)
                    hash = hash * 59 + this.NumeroParcelas.GetHashCode();
                
                if (this.CodigoSegurancaCartao != null)
                    hash = hash * 59 + this.CodigoSegurancaCartao.GetHashCode();
                
                if (this.Sort != null)
                    hash = hash * 59 + this.Sort.GetHashCode();
                
                return hash;
            }
        }

    }
}
