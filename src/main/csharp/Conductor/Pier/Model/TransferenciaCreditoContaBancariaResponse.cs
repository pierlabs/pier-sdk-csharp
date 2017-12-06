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
    /// Transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para contas banc\u00C3\u00A1rias
    /// </summary>
    [DataContract]
    public partial class TransferenciaCreditoContaBancariaResponse :  IEquatable<TransferenciaCreditoContaBancariaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferenciaCreditoContaBancariaResponse" /> class.
        /// Initializes a new instance of the <see cref="TransferenciaCreditoContaBancariaResponse" />class.
        /// </summary>
        /// <param name="IdTransferencia">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transferencia..</param>
        /// <param name="ValorCET">Taxa de custo efetivo total..</param>
        /// <param name="IdAutorizacao">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da autoriza\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="CodigoAutorizacao">C\u00C3\u00B3digo da autoriza\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="NsuOrigem">NSU de origem..</param>
        /// <param name="IdConta">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta..</param>
        /// <param name="IdCartao">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o..</param>
        /// <param name="IdOperacao">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de opera\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="ValorCompra">Valor da transfer\u00C3\u00AAncia..</param>
        /// <param name="ValorParcela">Valor da parcela..</param>
        /// <param name="ValorContrato">Valor da transfer\u00C3\u00AAncia acrescido do valor da tarifa de saque se houver tarifa de saque..</param>
        /// <param name="NumeroParcelas">N\u00C3\u00BAmero de parcelas..</param>
        /// <param name="ValorIOF">Valor do IOF..</param>
        /// <param name="ValorTAC">Valor da TAC..</param>
        /// <param name="ValorTaxaSaque">Valor da taxa saque..</param>
        /// <param name="TaxaJuros">Percentual de juros..</param>
        /// <param name="DataCompra">Data da transfer\u00C3\u00AAncia..</param>
        /// <param name="DataMovimento">Data do movimento..</param>
        /// <param name="DataVencimentoReal">Data do vencimento real da fatura..</param>
        /// <param name="DataVencimentoPadrao">Dia do vencimento padr\u00C3\u00A3o da fatura..</param>
        /// <param name="DataAutorizacao">Data da autoriza\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="Banco">C\u00C3\u00B3digo do Banco..</param>
        /// <param name="NumeroAgencia">N\u00C3\u00BAmero da Ag\u00C3\u00AAncia..</param>
        /// <param name="DigitoAgencia">D\u00C3\u00ADgito da Ag\u00C3\u00AAncia..</param>
        /// <param name="NumeroConta">N\u00C3\u00BAmero da Conta..</param>
        /// <param name="DigitoConta">D\u00C3\u00ADgito da Conta..</param>
        /// <param name="FlagContaPoupanca">Tipo da Conta..</param>
        /// <param name="DocumentoFavorecido">Documento do Favorecido..</param>
        /// <param name="NomeFavorecido">Nome do Favorecido..</param>
        /// <param name="Status">C\u00C3\u00B3digo do Status.</param>
        /// <param name="StatusProcessamento">Status Processamento..</param>

        public TransferenciaCreditoContaBancariaResponse(long? IdTransferencia = null, double? ValorCET = null, long? IdAutorizacao = null, string CodigoAutorizacao = null, long? NsuOrigem = null, long? IdConta = null, long? IdCartao = null, long? IdOperacao = null, double? ValorCompra = null, double? ValorParcela = null, double? ValorContrato = null, int? NumeroParcelas = null, double? ValorIOF = null, double? ValorTAC = null, double? ValorTaxaSaque = null, double? TaxaJuros = null, string DataCompra = null, string DataMovimento = null, string DataVencimentoReal = null, string DataVencimentoPadrao = null, string DataAutorizacao = null, long? Banco = null, string NumeroAgencia = null, string DigitoAgencia = null, string NumeroConta = null, string DigitoConta = null, bool? FlagContaPoupanca = null, string DocumentoFavorecido = null, string NomeFavorecido = null, string Status = null, string StatusProcessamento = null)
        {
            this.IdTransferencia = IdTransferencia;
            this.ValorCET = ValorCET;
            this.IdAutorizacao = IdAutorizacao;
            this.CodigoAutorizacao = CodigoAutorizacao;
            this.NsuOrigem = NsuOrigem;
            this.IdConta = IdConta;
            this.IdCartao = IdCartao;
            this.IdOperacao = IdOperacao;
            this.ValorCompra = ValorCompra;
            this.ValorParcela = ValorParcela;
            this.ValorContrato = ValorContrato;
            this.NumeroParcelas = NumeroParcelas;
            this.ValorIOF = ValorIOF;
            this.ValorTAC = ValorTAC;
            this.ValorTaxaSaque = ValorTaxaSaque;
            this.TaxaJuros = TaxaJuros;
            this.DataCompra = DataCompra;
            this.DataMovimento = DataMovimento;
            this.DataVencimentoReal = DataVencimentoReal;
            this.DataVencimentoPadrao = DataVencimentoPadrao;
            this.DataAutorizacao = DataAutorizacao;
            this.Banco = Banco;
            this.NumeroAgencia = NumeroAgencia;
            this.DigitoAgencia = DigitoAgencia;
            this.NumeroConta = NumeroConta;
            this.DigitoConta = DigitoConta;
            this.FlagContaPoupanca = FlagContaPoupanca;
            this.DocumentoFavorecido = DocumentoFavorecido;
            this.NomeFavorecido = NomeFavorecido;
            this.Status = Status;
            this.StatusProcessamento = StatusProcessamento;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transferencia.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transferencia.</value>
        [DataMember(Name="idTransferencia", EmitDefaultValue=false)]
        public long? IdTransferencia { get; set; }
    
        /// <summary>
        /// Taxa de custo efetivo total.
        /// </summary>
        /// <value>Taxa de custo efetivo total.</value>
        [DataMember(Name="valorCET", EmitDefaultValue=false)]
        public double? ValorCET { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da autoriza\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da autoriza\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="idAutorizacao", EmitDefaultValue=false)]
        public long? IdAutorizacao { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo da autoriza\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>C\u00C3\u00B3digo da autoriza\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="codigoAutorizacao", EmitDefaultValue=false)]
        public string CodigoAutorizacao { get; set; }
    
        /// <summary>
        /// NSU de origem.
        /// </summary>
        /// <value>NSU de origem.</value>
        [DataMember(Name="nsuOrigem", EmitDefaultValue=false)]
        public long? NsuOrigem { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta.</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do cart\u00C3\u00A3o.</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de opera\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo de opera\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="idOperacao", EmitDefaultValue=false)]
        public long? IdOperacao { get; set; }
    
        /// <summary>
        /// Valor da transfer\u00C3\u00AAncia.
        /// </summary>
        /// <value>Valor da transfer\u00C3\u00AAncia.</value>
        [DataMember(Name="valorCompra", EmitDefaultValue=false)]
        public double? ValorCompra { get; set; }
    
        /// <summary>
        /// Valor da parcela.
        /// </summary>
        /// <value>Valor da parcela.</value>
        [DataMember(Name="valorParcela", EmitDefaultValue=false)]
        public double? ValorParcela { get; set; }
    
        /// <summary>
        /// Valor da transfer\u00C3\u00AAncia acrescido do valor da tarifa de saque se houver tarifa de saque.
        /// </summary>
        /// <value>Valor da transfer\u00C3\u00AAncia acrescido do valor da tarifa de saque se houver tarifa de saque.</value>
        [DataMember(Name="valorContrato", EmitDefaultValue=false)]
        public double? ValorContrato { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero de parcelas.
        /// </summary>
        /// <value>N\u00C3\u00BAmero de parcelas.</value>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public int? NumeroParcelas { get; set; }
    
        /// <summary>
        /// Valor do IOF.
        /// </summary>
        /// <value>Valor do IOF.</value>
        [DataMember(Name="valorIOF", EmitDefaultValue=false)]
        public double? ValorIOF { get; set; }
    
        /// <summary>
        /// Valor da TAC.
        /// </summary>
        /// <value>Valor da TAC.</value>
        [DataMember(Name="valorTAC", EmitDefaultValue=false)]
        public double? ValorTAC { get; set; }
    
        /// <summary>
        /// Valor da taxa saque.
        /// </summary>
        /// <value>Valor da taxa saque.</value>
        [DataMember(Name="valorTaxaSaque", EmitDefaultValue=false)]
        public double? ValorTaxaSaque { get; set; }
    
        /// <summary>
        /// Percentual de juros.
        /// </summary>
        /// <value>Percentual de juros.</value>
        [DataMember(Name="taxaJuros", EmitDefaultValue=false)]
        public double? TaxaJuros { get; set; }
    
        /// <summary>
        /// Data da transfer\u00C3\u00AAncia.
        /// </summary>
        /// <value>Data da transfer\u00C3\u00AAncia.</value>
        [DataMember(Name="dataCompra", EmitDefaultValue=false)]
        public string DataCompra { get; set; }
    
        /// <summary>
        /// Data do movimento.
        /// </summary>
        /// <value>Data do movimento.</value>
        [DataMember(Name="dataMovimento", EmitDefaultValue=false)]
        public string DataMovimento { get; set; }
    
        /// <summary>
        /// Data do vencimento real da fatura.
        /// </summary>
        /// <value>Data do vencimento real da fatura.</value>
        [DataMember(Name="dataVencimentoReal", EmitDefaultValue=false)]
        public string DataVencimentoReal { get; set; }
    
        /// <summary>
        /// Dia do vencimento padr\u00C3\u00A3o da fatura.
        /// </summary>
        /// <value>Dia do vencimento padr\u00C3\u00A3o da fatura.</value>
        [DataMember(Name="dataVencimentoPadrao", EmitDefaultValue=false)]
        public string DataVencimentoPadrao { get; set; }
    
        /// <summary>
        /// Data da autoriza\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Data da autoriza\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="dataAutorizacao", EmitDefaultValue=false)]
        public string DataAutorizacao { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo do Banco.
        /// </summary>
        /// <value>C\u00C3\u00B3digo do Banco.</value>
        [DataMember(Name="banco", EmitDefaultValue=false)]
        public long? Banco { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero da Ag\u00C3\u00AAncia.
        /// </summary>
        /// <value>N\u00C3\u00BAmero da Ag\u00C3\u00AAncia.</value>
        [DataMember(Name="numeroAgencia", EmitDefaultValue=false)]
        public string NumeroAgencia { get; set; }
    
        /// <summary>
        /// D\u00C3\u00ADgito da Ag\u00C3\u00AAncia.
        /// </summary>
        /// <value>D\u00C3\u00ADgito da Ag\u00C3\u00AAncia.</value>
        [DataMember(Name="digitoAgencia", EmitDefaultValue=false)]
        public string DigitoAgencia { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero da Conta.
        /// </summary>
        /// <value>N\u00C3\u00BAmero da Conta.</value>
        [DataMember(Name="numeroConta", EmitDefaultValue=false)]
        public string NumeroConta { get; set; }
    
        /// <summary>
        /// D\u00C3\u00ADgito da Conta.
        /// </summary>
        /// <value>D\u00C3\u00ADgito da Conta.</value>
        [DataMember(Name="digitoConta", EmitDefaultValue=false)]
        public string DigitoConta { get; set; }
    
        /// <summary>
        /// Tipo da Conta.
        /// </summary>
        /// <value>Tipo da Conta.</value>
        [DataMember(Name="flagContaPoupanca", EmitDefaultValue=false)]
        public bool? FlagContaPoupanca { get; set; }
    
        /// <summary>
        /// Documento do Favorecido.
        /// </summary>
        /// <value>Documento do Favorecido.</value>
        [DataMember(Name="documentoFavorecido", EmitDefaultValue=false)]
        public string DocumentoFavorecido { get; set; }
    
        /// <summary>
        /// Nome do Favorecido.
        /// </summary>
        /// <value>Nome do Favorecido.</value>
        [DataMember(Name="nomeFavorecido", EmitDefaultValue=false)]
        public string NomeFavorecido { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo do Status
        /// </summary>
        /// <value>C\u00C3\u00B3digo do Status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Status Processamento.
        /// </summary>
        /// <value>Status Processamento.</value>
        [DataMember(Name="statusProcessamento", EmitDefaultValue=false)]
        public string StatusProcessamento { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferenciaCreditoContaBancariaResponse {\n");
            sb.Append("  IdTransferencia: ").Append(IdTransferencia).Append("\n");
            sb.Append("  ValorCET: ").Append(ValorCET).Append("\n");
            sb.Append("  IdAutorizacao: ").Append(IdAutorizacao).Append("\n");
            sb.Append("  CodigoAutorizacao: ").Append(CodigoAutorizacao).Append("\n");
            sb.Append("  NsuOrigem: ").Append(NsuOrigem).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  IdOperacao: ").Append(IdOperacao).Append("\n");
            sb.Append("  ValorCompra: ").Append(ValorCompra).Append("\n");
            sb.Append("  ValorParcela: ").Append(ValorParcela).Append("\n");
            sb.Append("  ValorContrato: ").Append(ValorContrato).Append("\n");
            sb.Append("  NumeroParcelas: ").Append(NumeroParcelas).Append("\n");
            sb.Append("  ValorIOF: ").Append(ValorIOF).Append("\n");
            sb.Append("  ValorTAC: ").Append(ValorTAC).Append("\n");
            sb.Append("  ValorTaxaSaque: ").Append(ValorTaxaSaque).Append("\n");
            sb.Append("  TaxaJuros: ").Append(TaxaJuros).Append("\n");
            sb.Append("  DataCompra: ").Append(DataCompra).Append("\n");
            sb.Append("  DataMovimento: ").Append(DataMovimento).Append("\n");
            sb.Append("  DataVencimentoReal: ").Append(DataVencimentoReal).Append("\n");
            sb.Append("  DataVencimentoPadrao: ").Append(DataVencimentoPadrao).Append("\n");
            sb.Append("  DataAutorizacao: ").Append(DataAutorizacao).Append("\n");
            sb.Append("  Banco: ").Append(Banco).Append("\n");
            sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
            sb.Append("  DigitoAgencia: ").Append(DigitoAgencia).Append("\n");
            sb.Append("  NumeroConta: ").Append(NumeroConta).Append("\n");
            sb.Append("  DigitoConta: ").Append(DigitoConta).Append("\n");
            sb.Append("  FlagContaPoupanca: ").Append(FlagContaPoupanca).Append("\n");
            sb.Append("  DocumentoFavorecido: ").Append(DocumentoFavorecido).Append("\n");
            sb.Append("  NomeFavorecido: ").Append(NomeFavorecido).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusProcessamento: ").Append(StatusProcessamento).Append("\n");
            
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
            return this.Equals(obj as TransferenciaCreditoContaBancariaResponse);
        }

        /// <summary>
        /// Returns true if TransferenciaCreditoContaBancariaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TransferenciaCreditoContaBancariaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferenciaCreditoContaBancariaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdTransferencia == other.IdTransferencia ||
                    this.IdTransferencia != null &&
                    this.IdTransferencia.Equals(other.IdTransferencia)
                ) && 
                (
                    this.ValorCET == other.ValorCET ||
                    this.ValorCET != null &&
                    this.ValorCET.Equals(other.ValorCET)
                ) && 
                (
                    this.IdAutorizacao == other.IdAutorizacao ||
                    this.IdAutorizacao != null &&
                    this.IdAutorizacao.Equals(other.IdAutorizacao)
                ) && 
                (
                    this.CodigoAutorizacao == other.CodigoAutorizacao ||
                    this.CodigoAutorizacao != null &&
                    this.CodigoAutorizacao.Equals(other.CodigoAutorizacao)
                ) && 
                (
                    this.NsuOrigem == other.NsuOrigem ||
                    this.NsuOrigem != null &&
                    this.NsuOrigem.Equals(other.NsuOrigem)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.IdOperacao == other.IdOperacao ||
                    this.IdOperacao != null &&
                    this.IdOperacao.Equals(other.IdOperacao)
                ) && 
                (
                    this.ValorCompra == other.ValorCompra ||
                    this.ValorCompra != null &&
                    this.ValorCompra.Equals(other.ValorCompra)
                ) && 
                (
                    this.ValorParcela == other.ValorParcela ||
                    this.ValorParcela != null &&
                    this.ValorParcela.Equals(other.ValorParcela)
                ) && 
                (
                    this.ValorContrato == other.ValorContrato ||
                    this.ValorContrato != null &&
                    this.ValorContrato.Equals(other.ValorContrato)
                ) && 
                (
                    this.NumeroParcelas == other.NumeroParcelas ||
                    this.NumeroParcelas != null &&
                    this.NumeroParcelas.Equals(other.NumeroParcelas)
                ) && 
                (
                    this.ValorIOF == other.ValorIOF ||
                    this.ValorIOF != null &&
                    this.ValorIOF.Equals(other.ValorIOF)
                ) && 
                (
                    this.ValorTAC == other.ValorTAC ||
                    this.ValorTAC != null &&
                    this.ValorTAC.Equals(other.ValorTAC)
                ) && 
                (
                    this.ValorTaxaSaque == other.ValorTaxaSaque ||
                    this.ValorTaxaSaque != null &&
                    this.ValorTaxaSaque.Equals(other.ValorTaxaSaque)
                ) && 
                (
                    this.TaxaJuros == other.TaxaJuros ||
                    this.TaxaJuros != null &&
                    this.TaxaJuros.Equals(other.TaxaJuros)
                ) && 
                (
                    this.DataCompra == other.DataCompra ||
                    this.DataCompra != null &&
                    this.DataCompra.Equals(other.DataCompra)
                ) && 
                (
                    this.DataMovimento == other.DataMovimento ||
                    this.DataMovimento != null &&
                    this.DataMovimento.Equals(other.DataMovimento)
                ) && 
                (
                    this.DataVencimentoReal == other.DataVencimentoReal ||
                    this.DataVencimentoReal != null &&
                    this.DataVencimentoReal.Equals(other.DataVencimentoReal)
                ) && 
                (
                    this.DataVencimentoPadrao == other.DataVencimentoPadrao ||
                    this.DataVencimentoPadrao != null &&
                    this.DataVencimentoPadrao.Equals(other.DataVencimentoPadrao)
                ) && 
                (
                    this.DataAutorizacao == other.DataAutorizacao ||
                    this.DataAutorizacao != null &&
                    this.DataAutorizacao.Equals(other.DataAutorizacao)
                ) && 
                (
                    this.Banco == other.Banco ||
                    this.Banco != null &&
                    this.Banco.Equals(other.Banco)
                ) && 
                (
                    this.NumeroAgencia == other.NumeroAgencia ||
                    this.NumeroAgencia != null &&
                    this.NumeroAgencia.Equals(other.NumeroAgencia)
                ) && 
                (
                    this.DigitoAgencia == other.DigitoAgencia ||
                    this.DigitoAgencia != null &&
                    this.DigitoAgencia.Equals(other.DigitoAgencia)
                ) && 
                (
                    this.NumeroConta == other.NumeroConta ||
                    this.NumeroConta != null &&
                    this.NumeroConta.Equals(other.NumeroConta)
                ) && 
                (
                    this.DigitoConta == other.DigitoConta ||
                    this.DigitoConta != null &&
                    this.DigitoConta.Equals(other.DigitoConta)
                ) && 
                (
                    this.FlagContaPoupanca == other.FlagContaPoupanca ||
                    this.FlagContaPoupanca != null &&
                    this.FlagContaPoupanca.Equals(other.FlagContaPoupanca)
                ) && 
                (
                    this.DocumentoFavorecido == other.DocumentoFavorecido ||
                    this.DocumentoFavorecido != null &&
                    this.DocumentoFavorecido.Equals(other.DocumentoFavorecido)
                ) && 
                (
                    this.NomeFavorecido == other.NomeFavorecido ||
                    this.NomeFavorecido != null &&
                    this.NomeFavorecido.Equals(other.NomeFavorecido)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.StatusProcessamento == other.StatusProcessamento ||
                    this.StatusProcessamento != null &&
                    this.StatusProcessamento.Equals(other.StatusProcessamento)
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
                
                if (this.IdTransferencia != null)
                    hash = hash * 59 + this.IdTransferencia.GetHashCode();
                
                if (this.ValorCET != null)
                    hash = hash * 59 + this.ValorCET.GetHashCode();
                
                if (this.IdAutorizacao != null)
                    hash = hash * 59 + this.IdAutorizacao.GetHashCode();
                
                if (this.CodigoAutorizacao != null)
                    hash = hash * 59 + this.CodigoAutorizacao.GetHashCode();
                
                if (this.NsuOrigem != null)
                    hash = hash * 59 + this.NsuOrigem.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.IdOperacao != null)
                    hash = hash * 59 + this.IdOperacao.GetHashCode();
                
                if (this.ValorCompra != null)
                    hash = hash * 59 + this.ValorCompra.GetHashCode();
                
                if (this.ValorParcela != null)
                    hash = hash * 59 + this.ValorParcela.GetHashCode();
                
                if (this.ValorContrato != null)
                    hash = hash * 59 + this.ValorContrato.GetHashCode();
                
                if (this.NumeroParcelas != null)
                    hash = hash * 59 + this.NumeroParcelas.GetHashCode();
                
                if (this.ValorIOF != null)
                    hash = hash * 59 + this.ValorIOF.GetHashCode();
                
                if (this.ValorTAC != null)
                    hash = hash * 59 + this.ValorTAC.GetHashCode();
                
                if (this.ValorTaxaSaque != null)
                    hash = hash * 59 + this.ValorTaxaSaque.GetHashCode();
                
                if (this.TaxaJuros != null)
                    hash = hash * 59 + this.TaxaJuros.GetHashCode();
                
                if (this.DataCompra != null)
                    hash = hash * 59 + this.DataCompra.GetHashCode();
                
                if (this.DataMovimento != null)
                    hash = hash * 59 + this.DataMovimento.GetHashCode();
                
                if (this.DataVencimentoReal != null)
                    hash = hash * 59 + this.DataVencimentoReal.GetHashCode();
                
                if (this.DataVencimentoPadrao != null)
                    hash = hash * 59 + this.DataVencimentoPadrao.GetHashCode();
                
                if (this.DataAutorizacao != null)
                    hash = hash * 59 + this.DataAutorizacao.GetHashCode();
                
                if (this.Banco != null)
                    hash = hash * 59 + this.Banco.GetHashCode();
                
                if (this.NumeroAgencia != null)
                    hash = hash * 59 + this.NumeroAgencia.GetHashCode();
                
                if (this.DigitoAgencia != null)
                    hash = hash * 59 + this.DigitoAgencia.GetHashCode();
                
                if (this.NumeroConta != null)
                    hash = hash * 59 + this.NumeroConta.GetHashCode();
                
                if (this.DigitoConta != null)
                    hash = hash * 59 + this.DigitoConta.GetHashCode();
                
                if (this.FlagContaPoupanca != null)
                    hash = hash * 59 + this.FlagContaPoupanca.GetHashCode();
                
                if (this.DocumentoFavorecido != null)
                    hash = hash * 59 + this.DocumentoFavorecido.GetHashCode();
                
                if (this.NomeFavorecido != null)
                    hash = hash * 59 + this.NomeFavorecido.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.StatusProcessamento != null)
                    hash = hash * 59 + this.StatusProcessamento.GetHashCode();
                
                return hash;
            }
        }

    }
}
