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
    /// Objeto de Requisi\u00C3\u00A7\u00C3\u00A3o de Autoriza\u00C3\u00A7\u00C3\u00A3o
    /// </summary>
    [DataContract]
    public partial class AutorizacaoOnUsRequest :  IEquatable<AutorizacaoOnUsRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AutorizacaoOnUsRequest" /> class.
        /// Initializes a new instance of the <see cref="AutorizacaoOnUsRequest" />class.
        /// </summary>
        /// <param name="NsuOrigem">N\u00C3\u00BAmero Sequencial \u00C3\u009Anico que identifica a transa\u00C3\u00A7\u00C3\u00A3o no sistema que a originou..</param>
        /// <param name="CodigoProcessamento">C\u00C3\u00B3digo de Processamento que identifica o Tipo da Transa\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="ValorTransacao">Valor da transa\u00C3\u00A7\u00C3\u00A3o com duas casas decimais para os centavos..</param>
        /// <param name="NumeroRealCartao">N\u00C3\u00BAmero Real do Cart\u00C3\u00A3o..</param>
        /// <param name="DataValidadeCartao">Data de Validade do Cart\u00C3\u00A3o. Ex: AAMM.</param>
        /// <param name="NumeroEstabelecimento">N\u00C3\u00BAmero do Estabelecimento (N\u00C3\u00BAmero+DV)..</param>
        /// <param name="DataHoraTerminal">Apresenta a data e hora local da consulta yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00.</param>
        /// <param name="TerminalRequisitante">Apresenta a identifica\u00C3\u00A7\u00C3\u00A3o do terminal requisitante.</param>
        /// <param name="NumeroParcelas">N\u00C3\u00BAmero de Parcelas..</param>
        /// <param name="CodigoSegurancaCartao">C\u00C3\u00B3digo de Seguran\u00C3\u00A7a do Cart\u00C3\u00A3o..</param>

        public AutorizacaoOnUsRequest(string NsuOrigem = null, string CodigoProcessamento = null, double? ValorTransacao = null, string NumeroRealCartao = null, string DataValidadeCartao = null, long? NumeroEstabelecimento = null, DateTime? DataHoraTerminal = null, string TerminalRequisitante = null, long? NumeroParcelas = null, long? CodigoSegurancaCartao = null)
        {
            this.NsuOrigem = NsuOrigem;
            this.CodigoProcessamento = CodigoProcessamento;
            this.ValorTransacao = ValorTransacao;
            this.NumeroRealCartao = NumeroRealCartao;
            this.DataValidadeCartao = DataValidadeCartao;
            this.NumeroEstabelecimento = NumeroEstabelecimento;
            this.DataHoraTerminal = DataHoraTerminal;
            this.TerminalRequisitante = TerminalRequisitante;
            this.NumeroParcelas = NumeroParcelas;
            this.CodigoSegurancaCartao = CodigoSegurancaCartao;
            
        }
        
    
        /// <summary>
        /// N\u00C3\u00BAmero Sequencial \u00C3\u009Anico que identifica a transa\u00C3\u00A7\u00C3\u00A3o no sistema que a originou.
        /// </summary>
        /// <value>N\u00C3\u00BAmero Sequencial \u00C3\u009Anico que identifica a transa\u00C3\u00A7\u00C3\u00A3o no sistema que a originou.</value>
        [DataMember(Name="nsuOrigem", EmitDefaultValue=false)]
        public string NsuOrigem { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Processamento que identifica o Tipo da Transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Processamento que identifica o Tipo da Transa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="codigoProcessamento", EmitDefaultValue=false)]
        public string CodigoProcessamento { get; set; }
    
        /// <summary>
        /// Valor da transa\u00C3\u00A7\u00C3\u00A3o com duas casas decimais para os centavos.
        /// </summary>
        /// <value>Valor da transa\u00C3\u00A7\u00C3\u00A3o com duas casas decimais para os centavos.</value>
        [DataMember(Name="valorTransacao", EmitDefaultValue=false)]
        public double? ValorTransacao { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero Real do Cart\u00C3\u00A3o.
        /// </summary>
        /// <value>N\u00C3\u00BAmero Real do Cart\u00C3\u00A3o.</value>
        [DataMember(Name="numeroRealCartao", EmitDefaultValue=false)]
        public string NumeroRealCartao { get; set; }
    
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
        public long? NumeroEstabelecimento { get; set; }
    
        /// <summary>
        /// Apresenta a data e hora local da consulta yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00
        /// </summary>
        /// <value>Apresenta a data e hora local da consulta yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ. Ex: 2000-10-31T01:30:00.000-05:00</value>
        [DataMember(Name="dataHoraTerminal", EmitDefaultValue=false)]
        public DateTime? DataHoraTerminal { get; set; }
    
        /// <summary>
        /// Apresenta a identifica\u00C3\u00A7\u00C3\u00A3o do terminal requisitante
        /// </summary>
        /// <value>Apresenta a identifica\u00C3\u00A7\u00C3\u00A3o do terminal requisitante</value>
        [DataMember(Name="terminalRequisitante", EmitDefaultValue=false)]
        public string TerminalRequisitante { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero de Parcelas.
        /// </summary>
        /// <value>N\u00C3\u00BAmero de Parcelas.</value>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public long? NumeroParcelas { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Seguran\u00C3\u00A7a do Cart\u00C3\u00A3o.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Seguran\u00C3\u00A7a do Cart\u00C3\u00A3o.</value>
        [DataMember(Name="codigoSegurancaCartao", EmitDefaultValue=false)]
        public long? CodigoSegurancaCartao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutorizacaoOnUsRequest {\n");
            sb.Append("  NsuOrigem: ").Append(NsuOrigem).Append("\n");
            sb.Append("  CodigoProcessamento: ").Append(CodigoProcessamento).Append("\n");
            sb.Append("  ValorTransacao: ").Append(ValorTransacao).Append("\n");
            sb.Append("  NumeroRealCartao: ").Append(NumeroRealCartao).Append("\n");
            sb.Append("  DataValidadeCartao: ").Append(DataValidadeCartao).Append("\n");
            sb.Append("  NumeroEstabelecimento: ").Append(NumeroEstabelecimento).Append("\n");
            sb.Append("  DataHoraTerminal: ").Append(DataHoraTerminal).Append("\n");
            sb.Append("  TerminalRequisitante: ").Append(TerminalRequisitante).Append("\n");
            sb.Append("  NumeroParcelas: ").Append(NumeroParcelas).Append("\n");
            sb.Append("  CodigoSegurancaCartao: ").Append(CodigoSegurancaCartao).Append("\n");
            
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
            return this.Equals(obj as AutorizacaoOnUsRequest);
        }

        /// <summary>
        /// Returns true if AutorizacaoOnUsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AutorizacaoOnUsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutorizacaoOnUsRequest other)
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
                    this.CodigoProcessamento == other.CodigoProcessamento ||
                    this.CodigoProcessamento != null &&
                    this.CodigoProcessamento.Equals(other.CodigoProcessamento)
                ) && 
                (
                    this.ValorTransacao == other.ValorTransacao ||
                    this.ValorTransacao != null &&
                    this.ValorTransacao.Equals(other.ValorTransacao)
                ) && 
                (
                    this.NumeroRealCartao == other.NumeroRealCartao ||
                    this.NumeroRealCartao != null &&
                    this.NumeroRealCartao.Equals(other.NumeroRealCartao)
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
                ) && 
                (
                    this.CodigoSegurancaCartao == other.CodigoSegurancaCartao ||
                    this.CodigoSegurancaCartao != null &&
                    this.CodigoSegurancaCartao.Equals(other.CodigoSegurancaCartao)
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
                
                if (this.CodigoProcessamento != null)
                    hash = hash * 59 + this.CodigoProcessamento.GetHashCode();
                
                if (this.ValorTransacao != null)
                    hash = hash * 59 + this.ValorTransacao.GetHashCode();
                
                if (this.NumeroRealCartao != null)
                    hash = hash * 59 + this.NumeroRealCartao.GetHashCode();
                
                if (this.DataValidadeCartao != null)
                    hash = hash * 59 + this.DataValidadeCartao.GetHashCode();
                
                if (this.NumeroEstabelecimento != null)
                    hash = hash * 59 + this.NumeroEstabelecimento.GetHashCode();
                
                if (this.DataHoraTerminal != null)
                    hash = hash * 59 + this.DataHoraTerminal.GetHashCode();
                
                if (this.TerminalRequisitante != null)
                    hash = hash * 59 + this.TerminalRequisitante.GetHashCode();
                
                if (this.NumeroParcelas != null)
                    hash = hash * 59 + this.NumeroParcelas.GetHashCode();
                
                if (this.CodigoSegurancaCartao != null)
                    hash = hash * 59 + this.CodigoSegurancaCartao.GetHashCode();
                
                return hash;
            }
        }

    }
}
