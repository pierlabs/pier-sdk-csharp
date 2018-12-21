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
    /// Cancellation request object of the transaction per idCard
    /// </summary>
    [DataContract]
    public partial class CancelamentoTransacaoPorIdCartaoRequest :  IEquatable<CancelamentoTransacaoPorIdCartaoRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelamentoTransacaoPorIdCartaoRequest" /> class.
        /// Initializes a new instance of the <see cref="CancelamentoTransacaoPorIdCartaoRequest" />class.
        /// </summary>
        /// <param name="NsuOrigem">Unique Sequel Number that identifies the transaction in the system that originated it (required).</param>
        /// <param name="NsuOrigemTransacaoCancelada">Unique Sequel Number that identifies the transaction in the system to be canceled (required).</param>
        /// <param name="CodigoProcessamento">Code of Processing that identifies the type of transaction (required).</param>
        /// <param name="DataHoraTransacaoCancelada">Show the date and local time of the Transaction to be canceled yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (required).</param>
        /// <param name="NsuAutorizacaoTransacaoCancelada">Unique Sequel Number of HOST that identifies the transactionin the system that was authorized (required).</param>
        /// <param name="ValorTransacao">Value of the transaction with two decimal places for the cents (required).</param>
        /// <param name="NumeroEstabelecimento">Number of the Establishment (Number+DV) (required).</param>
        /// <param name="NomeEstabelecimento">Establishment Name.</param>
        /// <param name="DataHoraTerminal">Show the date and local time of the retrievement yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00 (required).</param>
        /// <param name="TerminalRequisitante">Show the identification of the terminal applicant (required).</param>
        /// <param name="NumeroParcelas">Number of Parcels (required).</param>

        public CancelamentoTransacaoPorIdCartaoRequest(string NsuOrigem = null, string NsuOrigemTransacaoCancelada = null, string CodigoProcessamento = null, string DataHoraTransacaoCancelada = null, string NsuAutorizacaoTransacaoCancelada = null, double? ValorTransacao = null, long? NumeroEstabelecimento = null, string NomeEstabelecimento = null, string DataHoraTerminal = null, string TerminalRequisitante = null, long? NumeroParcelas = null)
        {
            // to ensure "NsuOrigem" is required (not null)
            if (NsuOrigem == null)
            {
                throw new InvalidDataException("NsuOrigem is a required property for CancelamentoTransacaoPorIdCartaoRequest and cannot be null");
            }
            else
            {
                this.NsuOrigem = NsuOrigem;
            }
            // to ensure "NsuOrigemTransacaoCancelada" is required (not null)
            if (NsuOrigemTransacaoCancelada == null)
            {
                throw new InvalidDataException("NsuOrigemTransacaoCancelada is a required property for CancelamentoTransacaoPorIdCartaoRequest and cannot be null");
            }
            else
            {
                this.NsuOrigemTransacaoCancelada = NsuOrigemTransacaoCancelada;
            }
            // to ensure "CodigoProcessamento" is required (not null)
            if (CodigoProcessamento == null)
            {
                throw new InvalidDataException("CodigoProcessamento is a required property for CancelamentoTransacaoPorIdCartaoRequest and cannot be null");
            }
            else
            {
                this.CodigoProcessamento = CodigoProcessamento;
            }
            // to ensure "DataHoraTransacaoCancelada" is required (not null)
            if (DataHoraTransacaoCancelada == null)
            {
                throw new InvalidDataException("DataHoraTransacaoCancelada is a required property for CancelamentoTransacaoPorIdCartaoRequest and cannot be null");
            }
            else
            {
                this.DataHoraTransacaoCancelada = DataHoraTransacaoCancelada;
            }
            // to ensure "NsuAutorizacaoTransacaoCancelada" is required (not null)
            if (NsuAutorizacaoTransacaoCancelada == null)
            {
                throw new InvalidDataException("NsuAutorizacaoTransacaoCancelada is a required property for CancelamentoTransacaoPorIdCartaoRequest and cannot be null");
            }
            else
            {
                this.NsuAutorizacaoTransacaoCancelada = NsuAutorizacaoTransacaoCancelada;
            }
            // to ensure "ValorTransacao" is required (not null)
            if (ValorTransacao == null)
            {
                throw new InvalidDataException("ValorTransacao is a required property for CancelamentoTransacaoPorIdCartaoRequest and cannot be null");
            }
            else
            {
                this.ValorTransacao = ValorTransacao;
            }
            // to ensure "NumeroEstabelecimento" is required (not null)
            if (NumeroEstabelecimento == null)
            {
                throw new InvalidDataException("NumeroEstabelecimento is a required property for CancelamentoTransacaoPorIdCartaoRequest and cannot be null");
            }
            else
            {
                this.NumeroEstabelecimento = NumeroEstabelecimento;
            }
            // to ensure "DataHoraTerminal" is required (not null)
            if (DataHoraTerminal == null)
            {
                throw new InvalidDataException("DataHoraTerminal is a required property for CancelamentoTransacaoPorIdCartaoRequest and cannot be null");
            }
            else
            {
                this.DataHoraTerminal = DataHoraTerminal;
            }
            // to ensure "TerminalRequisitante" is required (not null)
            if (TerminalRequisitante == null)
            {
                throw new InvalidDataException("TerminalRequisitante is a required property for CancelamentoTransacaoPorIdCartaoRequest and cannot be null");
            }
            else
            {
                this.TerminalRequisitante = TerminalRequisitante;
            }
            // to ensure "NumeroParcelas" is required (not null)
            if (NumeroParcelas == null)
            {
                throw new InvalidDataException("NumeroParcelas is a required property for CancelamentoTransacaoPorIdCartaoRequest and cannot be null");
            }
            else
            {
                this.NumeroParcelas = NumeroParcelas;
            }
            this.NomeEstabelecimento = NomeEstabelecimento;
            
        }
        
    
        /// <summary>
        /// Unique Sequel Number that identifies the transaction in the system that originated it
        /// </summary>
        /// <value>Unique Sequel Number that identifies the transaction in the system that originated it</value>
        [DataMember(Name="nsuOrigem", EmitDefaultValue=false)]
        public string NsuOrigem { get; set; }
    
        /// <summary>
        /// Unique Sequel Number that identifies the transaction in the system to be canceled
        /// </summary>
        /// <value>Unique Sequel Number that identifies the transaction in the system to be canceled</value>
        [DataMember(Name="nsuOrigemTransacaoCancelada", EmitDefaultValue=false)]
        public string NsuOrigemTransacaoCancelada { get; set; }
    
        /// <summary>
        /// Code of Processing that identifies the type of transaction
        /// </summary>
        /// <value>Code of Processing that identifies the type of transaction</value>
        [DataMember(Name="codigoProcessamento", EmitDefaultValue=false)]
        public string CodigoProcessamento { get; set; }
    
        /// <summary>
        /// Show the date and local time of the Transaction to be canceled yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00
        /// </summary>
        /// <value>Show the date and local time of the Transaction to be canceled yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00</value>
        [DataMember(Name="dataHoraTransacaoCancelada", EmitDefaultValue=false)]
        public string DataHoraTransacaoCancelada { get; set; }
    
        /// <summary>
        /// Unique Sequel Number of HOST that identifies the transactionin the system that was authorized
        /// </summary>
        /// <value>Unique Sequel Number of HOST that identifies the transactionin the system that was authorized</value>
        [DataMember(Name="nsuAutorizacaoTransacaoCancelada", EmitDefaultValue=false)]
        public string NsuAutorizacaoTransacaoCancelada { get; set; }
    
        /// <summary>
        /// Value of the transaction with two decimal places for the cents
        /// </summary>
        /// <value>Value of the transaction with two decimal places for the cents</value>
        [DataMember(Name="valorTransacao", EmitDefaultValue=false)]
        public double? ValorTransacao { get; set; }
    
        /// <summary>
        /// Number of the Establishment (Number+DV)
        /// </summary>
        /// <value>Number of the Establishment (Number+DV)</value>
        [DataMember(Name="numeroEstabelecimento", EmitDefaultValue=false)]
        public long? NumeroEstabelecimento { get; set; }
    
        /// <summary>
        /// Establishment Name
        /// </summary>
        /// <value>Establishment Name</value>
        [DataMember(Name="nomeEstabelecimento", EmitDefaultValue=false)]
        public string NomeEstabelecimento { get; set; }
    
        /// <summary>
        /// Show the date and local time of the retrievement yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00
        /// </summary>
        /// <value>Show the date and local time of the retrievement yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00</value>
        [DataMember(Name="dataHoraTerminal", EmitDefaultValue=false)]
        public string DataHoraTerminal { get; set; }
    
        /// <summary>
        /// Show the identification of the terminal applicant
        /// </summary>
        /// <value>Show the identification of the terminal applicant</value>
        [DataMember(Name="terminalRequisitante", EmitDefaultValue=false)]
        public string TerminalRequisitante { get; set; }
    
        /// <summary>
        /// Number of Parcels
        /// </summary>
        /// <value>Number of Parcels</value>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public long? NumeroParcelas { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CancelamentoTransacaoPorIdCartaoRequest {\n");
            sb.Append("  NsuOrigem: ").Append(NsuOrigem).Append("\n");
            sb.Append("  NsuOrigemTransacaoCancelada: ").Append(NsuOrigemTransacaoCancelada).Append("\n");
            sb.Append("  CodigoProcessamento: ").Append(CodigoProcessamento).Append("\n");
            sb.Append("  DataHoraTransacaoCancelada: ").Append(DataHoraTransacaoCancelada).Append("\n");
            sb.Append("  NsuAutorizacaoTransacaoCancelada: ").Append(NsuAutorizacaoTransacaoCancelada).Append("\n");
            sb.Append("  ValorTransacao: ").Append(ValorTransacao).Append("\n");
            sb.Append("  NumeroEstabelecimento: ").Append(NumeroEstabelecimento).Append("\n");
            sb.Append("  NomeEstabelecimento: ").Append(NomeEstabelecimento).Append("\n");
            sb.Append("  DataHoraTerminal: ").Append(DataHoraTerminal).Append("\n");
            sb.Append("  TerminalRequisitante: ").Append(TerminalRequisitante).Append("\n");
            sb.Append("  NumeroParcelas: ").Append(NumeroParcelas).Append("\n");
            
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
            return this.Equals(obj as CancelamentoTransacaoPorIdCartaoRequest);
        }

        /// <summary>
        /// Returns true if CancelamentoTransacaoPorIdCartaoRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CancelamentoTransacaoPorIdCartaoRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CancelamentoTransacaoPorIdCartaoRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NsuOrigem == other.NsuOrigem ||
                    this.NsuOrigem != null &&
                    this.NsuOrigem.Equals(other.NsuOrigem)
                ) && 
                (
                    this.NsuOrigemTransacaoCancelada == other.NsuOrigemTransacaoCancelada ||
                    this.NsuOrigemTransacaoCancelada != null &&
                    this.NsuOrigemTransacaoCancelada.Equals(other.NsuOrigemTransacaoCancelada)
                ) && 
                (
                    this.CodigoProcessamento == other.CodigoProcessamento ||
                    this.CodigoProcessamento != null &&
                    this.CodigoProcessamento.Equals(other.CodigoProcessamento)
                ) && 
                (
                    this.DataHoraTransacaoCancelada == other.DataHoraTransacaoCancelada ||
                    this.DataHoraTransacaoCancelada != null &&
                    this.DataHoraTransacaoCancelada.Equals(other.DataHoraTransacaoCancelada)
                ) && 
                (
                    this.NsuAutorizacaoTransacaoCancelada == other.NsuAutorizacaoTransacaoCancelada ||
                    this.NsuAutorizacaoTransacaoCancelada != null &&
                    this.NsuAutorizacaoTransacaoCancelada.Equals(other.NsuAutorizacaoTransacaoCancelada)
                ) && 
                (
                    this.ValorTransacao == other.ValorTransacao ||
                    this.ValorTransacao != null &&
                    this.ValorTransacao.Equals(other.ValorTransacao)
                ) && 
                (
                    this.NumeroEstabelecimento == other.NumeroEstabelecimento ||
                    this.NumeroEstabelecimento != null &&
                    this.NumeroEstabelecimento.Equals(other.NumeroEstabelecimento)
                ) && 
                (
                    this.NomeEstabelecimento == other.NomeEstabelecimento ||
                    this.NomeEstabelecimento != null &&
                    this.NomeEstabelecimento.Equals(other.NomeEstabelecimento)
                ) && 
                (
                    this.DataHoraTerminal == other.DataHoraTerminal ||
                    this.DataHoraTerminal != null &&
                    this.DataHoraTerminal.Equals(other.DataHoraTerminal)
                ) && 
                (
                    this.TerminalRequisitante == other.TerminalRequisitante ||
                    this.TerminalRequisitante != null &&
                    this.TerminalRequisitante.Equals(other.TerminalRequisitante)
                ) && 
                (
                    this.NumeroParcelas == other.NumeroParcelas ||
                    this.NumeroParcelas != null &&
                    this.NumeroParcelas.Equals(other.NumeroParcelas)
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
                
                if (this.NsuOrigem != null)
                    hash = hash * 59 + this.NsuOrigem.GetHashCode();
                
                if (this.NsuOrigemTransacaoCancelada != null)
                    hash = hash * 59 + this.NsuOrigemTransacaoCancelada.GetHashCode();
                
                if (this.CodigoProcessamento != null)
                    hash = hash * 59 + this.CodigoProcessamento.GetHashCode();
                
                if (this.DataHoraTransacaoCancelada != null)
                    hash = hash * 59 + this.DataHoraTransacaoCancelada.GetHashCode();
                
                if (this.NsuAutorizacaoTransacaoCancelada != null)
                    hash = hash * 59 + this.NsuAutorizacaoTransacaoCancelada.GetHashCode();
                
                if (this.ValorTransacao != null)
                    hash = hash * 59 + this.ValorTransacao.GetHashCode();
                
                if (this.NumeroEstabelecimento != null)
                    hash = hash * 59 + this.NumeroEstabelecimento.GetHashCode();
                
                if (this.NomeEstabelecimento != null)
                    hash = hash * 59 + this.NomeEstabelecimento.GetHashCode();
                
                if (this.DataHoraTerminal != null)
                    hash = hash * 59 + this.DataHoraTerminal.GetHashCode();
                
                if (this.TerminalRequisitante != null)
                    hash = hash * 59 + this.TerminalRequisitante.GetHashCode();
                
                if (this.NumeroParcelas != null)
                    hash = hash * 59 + this.NumeroParcelas.GetHashCode();
                
                return hash;
            }
        }

    }
}
