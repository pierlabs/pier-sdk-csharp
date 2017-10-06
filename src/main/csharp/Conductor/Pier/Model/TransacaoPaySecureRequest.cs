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
    /// Representa\u00C3\u00A7\u00C3\u00A3o da requisi\u00C3\u00A7\u00C3\u00A3o do recurso de transa\u00C3\u00A7\u00C3\u00A3o segura conductorPay
    /// </summary>
    [DataContract]
    public partial class TransacaoPaySecureRequest :  IEquatable<TransacaoPaySecureRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransacaoPaySecureRequest" /> class.
        /// Initializes a new instance of the <see cref="TransacaoPaySecureRequest" />class.
        /// </summary>
        /// <param name="DataHoraTransacao">Data e hora utilizado na gera\u00C3\u00A7\u00C3\u00A3o do criptograma em GMT - 0.</param>
        /// <param name="NumeroCartao">Numero do cartao (criptografado).</param>
        /// <param name="IdCartao">Id do cart\u00C3\u00A3o.</param>
        /// <param name="Valor">Valor da transa\u00C3\u00A7\u00C3\u00A3o em moeda local.</param>
        /// <param name="NsuOrigem">N\u00C3\u00BAmero Sequencial \u00C3\u009Anico que identifica a transa\u00C3\u00A7\u00C3\u00A3o no sistema que a originou (critografado)..</param>
        /// <param name="NomePortadorCartao">Nome do Portador do Cart\u00C3\u00A3o que originou a transa\u00C3\u00A7\u00C3\u00A3o (criptografado)..</param>
        /// <param name="Origem">Origem da transa\u00C3\u00A7\u00C3\u00A3o.</param>
        /// <param name="TerminalRequisitante">Apresenta a identifica\u00C3\u00A7\u00C3\u00A3o do terminal requisitante (required).</param>
        /// <param name="CodigoProcessamento">C\u00C3\u00B3digo de Processamento que identifica o Tipo da Transa\u00C3\u00A7\u00C3\u00A3o. (required).</param>
        /// <param name="DataValidadeCartao">Data de Validade do Cart\u00C3\u00A3o. Ex: AAMM (required).</param>
        /// <param name="NumeroEstabelecimento">N\u00C3\u00BAmero do Estabelecimento (N\u00C3\u00BAmero+DV). (required).</param>
        /// <param name="NumeroParcelas">N\u00C3\u00BAmero de Parcelas. (required).</param>
        /// <param name="CodigoSegurancaCartao">C\u00C3\u00B3digo de Seguran\u00C3\u00A7a do Cart\u00C3\u00A3o (criptografado). (required).</param>
        /// <param name="Sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros..</param>

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
        /// Data e hora utilizado na gera\u00C3\u00A7\u00C3\u00A3o do criptograma em GMT - 0
        /// </summary>
        /// <value>Data e hora utilizado na gera\u00C3\u00A7\u00C3\u00A3o do criptograma em GMT - 0</value>
        [DataMember(Name="dataHoraTransacao", EmitDefaultValue=false)]
        public string DataHoraTransacao { get; set; }
    
        /// <summary>
        /// Numero do cartao (criptografado)
        /// </summary>
        /// <value>Numero do cartao (criptografado)</value>
        [DataMember(Name="numeroCartao", EmitDefaultValue=false)]
        public string NumeroCartao { get; set; }
    
        /// <summary>
        /// Id do cart\u00C3\u00A3o
        /// </summary>
        /// <value>Id do cart\u00C3\u00A3o</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// Valor da transa\u00C3\u00A7\u00C3\u00A3o em moeda local
        /// </summary>
        /// <value>Valor da transa\u00C3\u00A7\u00C3\u00A3o em moeda local</value>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero Sequencial \u00C3\u009Anico que identifica a transa\u00C3\u00A7\u00C3\u00A3o no sistema que a originou (critografado).
        /// </summary>
        /// <value>N\u00C3\u00BAmero Sequencial \u00C3\u009Anico que identifica a transa\u00C3\u00A7\u00C3\u00A3o no sistema que a originou (critografado).</value>
        [DataMember(Name="nsuOrigem", EmitDefaultValue=false)]
        public string NsuOrigem { get; set; }
    
        /// <summary>
        /// Nome do Portador do Cart\u00C3\u00A3o que originou a transa\u00C3\u00A7\u00C3\u00A3o (criptografado).
        /// </summary>
        /// <value>Nome do Portador do Cart\u00C3\u00A3o que originou a transa\u00C3\u00A7\u00C3\u00A3o (criptografado).</value>
        [DataMember(Name="nomePortadorCartao", EmitDefaultValue=false)]
        public string NomePortadorCartao { get; set; }
    
        /// <summary>
        /// Origem da transa\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <value>Origem da transa\u00C3\u00A7\u00C3\u00A3o</value>
        [DataMember(Name="origem", EmitDefaultValue=false)]
        public string Origem { get; set; }
    
        /// <summary>
        /// Apresenta a identifica\u00C3\u00A7\u00C3\u00A3o do terminal requisitante
        /// </summary>
        /// <value>Apresenta a identifica\u00C3\u00A7\u00C3\u00A3o do terminal requisitante</value>
        [DataMember(Name="terminalRequisitante", EmitDefaultValue=false)]
        public string TerminalRequisitante { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Processamento que identifica o Tipo da Transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Processamento que identifica o Tipo da Transa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="codigoProcessamento", EmitDefaultValue=false)]
        public string CodigoProcessamento { get; set; }
    
        /// <summary>
        /// Data de Validade do Cart\u00C3\u00A3o. Ex: AAMM
        /// </summary>
        /// <value>Data de Validade do Cart\u00C3\u00A3o. Ex: AAMM</value>
        [DataMember(Name="dataValidadeCartao", EmitDefaultValue=false)]
        public string DataValidadeCartao { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero do Estabelecimento (N\u00C3\u00BAmero+DV).
        /// </summary>
        /// <value>N\u00C3\u00BAmero do Estabelecimento (N\u00C3\u00BAmero+DV).</value>
        [DataMember(Name="numeroEstabelecimento", EmitDefaultValue=false)]
        public string NumeroEstabelecimento { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero de Parcelas.
        /// </summary>
        /// <value>N\u00C3\u00BAmero de Parcelas.</value>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public long? NumeroParcelas { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Seguran\u00C3\u00A7a do Cart\u00C3\u00A3o (criptografado).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Seguran\u00C3\u00A7a do Cart\u00C3\u00A3o (criptografado).</value>
        [DataMember(Name="codigoSegurancaCartao", EmitDefaultValue=false)]
        public string CodigoSegurancaCartao { get; set; }
    
        /// <summary>
        /// Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros.
        /// </summary>
        /// <value>Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros.</value>
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
