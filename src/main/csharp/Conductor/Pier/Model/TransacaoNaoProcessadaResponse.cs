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
    /// Object transaction not processed
    /// </summary>
    [DataContract]
    public partial class TransacaoNaoProcessadaResponse :  IEquatable<TransacaoNaoProcessadaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransacaoNaoProcessadaResponse" /> class.
        /// Initializes a new instance of the <see cref="TransacaoNaoProcessadaResponse" />class.
        /// </summary>
        /// <param name="CartaoMascarado">Card Number in format 0000XXXXXXXX0000.</param>
        /// <param name="CodigoAutorizacao">Authorization Code of the transaction.</param>
        /// <param name="CodigoMCC">Identification Code of the Merchant Category.</param>
        /// <param name="CodigoMoedaDestino">Identification Code of the transaction currency after the conversion, following standard ISO 4217.</param>
        /// <param name="CodigoMoedaOrigem">Identification Code of the Currency used in the transaction, following standard ISO 4217.</param>
        /// <param name="CodigoReferencia">Reference Code of the Transaction when used Flagged Card.</param>
        /// <param name="CodigoTerminal">Identification Code of the Transaction Capture Source.</param>
        /// <param name="CotacaoUSD">Value of the American Dollar (USD) converted in Real (BRL).</param>
        /// <param name="DataCotacaoUSD">Closing date of quotation of the American Dollar (USD).</param>
        /// <param name="DataFaturamento">Billing date of the transaction.</param>
        /// <param name="DataOrigem">Date which the transaction was made.</param>
        /// <param name="DataVencimentoReal">Expiration date of the invoice.</param>
        /// <param name="DescricaoAbreviada">Abbreviated Description of the transactions.</param>
        /// <param name="DescricaoTipoTransacaoNaoProcessada">Description of the transaction type not processed.</param>
        /// <param name="DetalhesTransacao">Complementary details regarding the transaction.</param>
        /// <param name="FlagCredito">When it is activate, indicate that the transaction is the credit type.</param>
        /// <param name="FlagFaturado">When it is activate, indicates that the transaction was consolidated in an invoice.</param>
        /// <param name="GrupoDescricaoMCC">Description of the Merchant Group.</param>
        /// <param name="GrupoMCC">Identification Code of the Merchant Group.</param>
        /// <param name="IdConta">Identification Code of the Account (id).</param>
        /// <param name="IdEstabelecimento">Identification Code of the Merchant (id).</param>
        /// <param name="IdTipoTransacaoNaoProcessada">Identification Code of the Transaction type.</param>
        /// <param name="IdTransacaoEstorno">Identification Code of the Transaction (id) that generated the reversal.</param>
        /// <param name="LocalidadeEstabelecimento">Merchant location.</param>
        /// <param name="ModoEntradaTransacao">Describe the mode used to perform the card dates reading to make the transaction.</param>
        /// <param name="NomeEstabelecimento">Merchant Name.</param>
        /// <param name="NomeFantasiaEstabelecimento">Fantasy name of the Merchant.</param>
        /// <param name="NomePortador">Full name of the Cardholder.</param>
        /// <param name="Parcela">When the transaction is the installment type, show the number of the Parcels.</param>
        /// <param name="Plano">When the transaction is the Installment type, show the total number of the parcels.</param>
        /// <param name="Status">Attributed that represents the identifier code of the transaction status.</param>
        /// <param name="TaxaEmbarque">Value of the Boarding fee in Real (BRL) when the transaction is related to the purchase of airline tickets.</param>
        /// <param name="ValorBRL">Transaction value in Real (BRL).</param>
        /// <param name="ValorEntrada">Entrance value in Real (BRL) when the transaction is installment type with the payment of an entrance value.</param>
        /// <param name="ValorUSD">Transaction value in American Dollar (USD).</param>

        public TransacaoNaoProcessadaResponse(string CartaoMascarado = null, string CodigoAutorizacao = null, long? CodigoMCC = null, string CodigoMoedaDestino = null, string CodigoMoedaOrigem = null, string CodigoReferencia = null, string CodigoTerminal = null, double? CotacaoUSD = null, string DataCotacaoUSD = null, string DataFaturamento = null, string DataOrigem = null, string DataVencimentoReal = null, string DescricaoAbreviada = null, string DescricaoTipoTransacaoNaoProcessada = null, string DetalhesTransacao = null, int? FlagCredito = null, int? FlagFaturado = null, string GrupoDescricaoMCC = null, long? GrupoMCC = null, long? IdConta = null, long? IdEstabelecimento = null, long? IdTipoTransacaoNaoProcessada = null, long? IdTransacaoEstorno = null, string LocalidadeEstabelecimento = null, string ModoEntradaTransacao = null, string NomeEstabelecimento = null, string NomeFantasiaEstabelecimento = null, string NomePortador = null, long? Parcela = null, long? Plano = null, int? Status = null, double? TaxaEmbarque = null, double? ValorBRL = null, double? ValorEntrada = null, double? ValorUSD = null)
        {
            this.CartaoMascarado = CartaoMascarado;
            this.CodigoAutorizacao = CodigoAutorizacao;
            this.CodigoMCC = CodigoMCC;
            this.CodigoMoedaDestino = CodigoMoedaDestino;
            this.CodigoMoedaOrigem = CodigoMoedaOrigem;
            this.CodigoReferencia = CodigoReferencia;
            this.CodigoTerminal = CodigoTerminal;
            this.CotacaoUSD = CotacaoUSD;
            this.DataCotacaoUSD = DataCotacaoUSD;
            this.DataFaturamento = DataFaturamento;
            this.DataOrigem = DataOrigem;
            this.DataVencimentoReal = DataVencimentoReal;
            this.DescricaoAbreviada = DescricaoAbreviada;
            this.DescricaoTipoTransacaoNaoProcessada = DescricaoTipoTransacaoNaoProcessada;
            this.DetalhesTransacao = DetalhesTransacao;
            this.FlagCredito = FlagCredito;
            this.FlagFaturado = FlagFaturado;
            this.GrupoDescricaoMCC = GrupoDescricaoMCC;
            this.GrupoMCC = GrupoMCC;
            this.IdConta = IdConta;
            this.IdEstabelecimento = IdEstabelecimento;
            this.IdTipoTransacaoNaoProcessada = IdTipoTransacaoNaoProcessada;
            this.IdTransacaoEstorno = IdTransacaoEstorno;
            this.LocalidadeEstabelecimento = LocalidadeEstabelecimento;
            this.ModoEntradaTransacao = ModoEntradaTransacao;
            this.NomeEstabelecimento = NomeEstabelecimento;
            this.NomeFantasiaEstabelecimento = NomeFantasiaEstabelecimento;
            this.NomePortador = NomePortador;
            this.Parcela = Parcela;
            this.Plano = Plano;
            this.Status = Status;
            this.TaxaEmbarque = TaxaEmbarque;
            this.ValorBRL = ValorBRL;
            this.ValorEntrada = ValorEntrada;
            this.ValorUSD = ValorUSD;
            
        }
        
    
        /// <summary>
        /// Card Number in format 0000XXXXXXXX0000
        /// </summary>
        /// <value>Card Number in format 0000XXXXXXXX0000</value>
        [DataMember(Name="cartaoMascarado", EmitDefaultValue=false)]
        public string CartaoMascarado { get; set; }
    
        /// <summary>
        /// Authorization Code of the transaction
        /// </summary>
        /// <value>Authorization Code of the transaction</value>
        [DataMember(Name="codigoAutorizacao", EmitDefaultValue=false)]
        public string CodigoAutorizacao { get; set; }
    
        /// <summary>
        /// Identification Code of the Merchant Category
        /// </summary>
        /// <value>Identification Code of the Merchant Category</value>
        [DataMember(Name="codigoMCC", EmitDefaultValue=false)]
        public long? CodigoMCC { get; set; }
    
        /// <summary>
        /// Identification Code of the transaction currency after the conversion, following standard ISO 4217
        /// </summary>
        /// <value>Identification Code of the transaction currency after the conversion, following standard ISO 4217</value>
        [DataMember(Name="codigoMoedaDestino", EmitDefaultValue=false)]
        public string CodigoMoedaDestino { get; set; }
    
        /// <summary>
        /// Identification Code of the Currency used in the transaction, following standard ISO 4217
        /// </summary>
        /// <value>Identification Code of the Currency used in the transaction, following standard ISO 4217</value>
        [DataMember(Name="codigoMoedaOrigem", EmitDefaultValue=false)]
        public string CodigoMoedaOrigem { get; set; }
    
        /// <summary>
        /// Reference Code of the Transaction when used Flagged Card
        /// </summary>
        /// <value>Reference Code of the Transaction when used Flagged Card</value>
        [DataMember(Name="codigoReferencia", EmitDefaultValue=false)]
        public string CodigoReferencia { get; set; }
    
        /// <summary>
        /// Identification Code of the Transaction Capture Source
        /// </summary>
        /// <value>Identification Code of the Transaction Capture Source</value>
        [DataMember(Name="codigoTerminal", EmitDefaultValue=false)]
        public string CodigoTerminal { get; set; }
    
        /// <summary>
        /// Value of the American Dollar (USD) converted in Real (BRL)
        /// </summary>
        /// <value>Value of the American Dollar (USD) converted in Real (BRL)</value>
        [DataMember(Name="cotacaoUSD", EmitDefaultValue=false)]
        public double? CotacaoUSD { get; set; }
    
        /// <summary>
        /// Closing date of quotation of the American Dollar (USD)
        /// </summary>
        /// <value>Closing date of quotation of the American Dollar (USD)</value>
        [DataMember(Name="dataCotacaoUSD", EmitDefaultValue=false)]
        public string DataCotacaoUSD { get; set; }
    
        /// <summary>
        /// Billing date of the transaction
        /// </summary>
        /// <value>Billing date of the transaction</value>
        [DataMember(Name="dataFaturamento", EmitDefaultValue=false)]
        public string DataFaturamento { get; set; }
    
        /// <summary>
        /// Date which the transaction was made
        /// </summary>
        /// <value>Date which the transaction was made</value>
        [DataMember(Name="dataOrigem", EmitDefaultValue=false)]
        public string DataOrigem { get; set; }
    
        /// <summary>
        /// Expiration date of the invoice
        /// </summary>
        /// <value>Expiration date of the invoice</value>
        [DataMember(Name="dataVencimentoReal", EmitDefaultValue=false)]
        public string DataVencimentoReal { get; set; }
    
        /// <summary>
        /// Abbreviated Description of the transactions
        /// </summary>
        /// <value>Abbreviated Description of the transactions</value>
        [DataMember(Name="descricaoAbreviada", EmitDefaultValue=false)]
        public string DescricaoAbreviada { get; set; }
    
        /// <summary>
        /// Description of the transaction type not processed
        /// </summary>
        /// <value>Description of the transaction type not processed</value>
        [DataMember(Name="descricaoTipoTransacaoNaoProcessada", EmitDefaultValue=false)]
        public string DescricaoTipoTransacaoNaoProcessada { get; set; }
    
        /// <summary>
        /// Complementary details regarding the transaction
        /// </summary>
        /// <value>Complementary details regarding the transaction</value>
        [DataMember(Name="detalhesTransacao", EmitDefaultValue=false)]
        public string DetalhesTransacao { get; set; }
    
        /// <summary>
        /// When it is activate, indicate that the transaction is the credit type
        /// </summary>
        /// <value>When it is activate, indicate that the transaction is the credit type</value>
        [DataMember(Name="flagCredito", EmitDefaultValue=false)]
        public int? FlagCredito { get; set; }
    
        /// <summary>
        /// When it is activate, indicates that the transaction was consolidated in an invoice
        /// </summary>
        /// <value>When it is activate, indicates that the transaction was consolidated in an invoice</value>
        [DataMember(Name="flagFaturado", EmitDefaultValue=false)]
        public int? FlagFaturado { get; set; }
    
        /// <summary>
        /// Description of the Merchant Group
        /// </summary>
        /// <value>Description of the Merchant Group</value>
        [DataMember(Name="grupoDescricaoMCC", EmitDefaultValue=false)]
        public string GrupoDescricaoMCC { get; set; }
    
        /// <summary>
        /// Identification Code of the Merchant Group
        /// </summary>
        /// <value>Identification Code of the Merchant Group</value>
        [DataMember(Name="grupoMCC", EmitDefaultValue=false)]
        public long? GrupoMCC { get; set; }
    
        /// <summary>
        /// Identification Code of the Account (id)
        /// </summary>
        /// <value>Identification Code of the Account (id)</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Identification Code of the Merchant (id)
        /// </summary>
        /// <value>Identification Code of the Merchant (id)</value>
        [DataMember(Name="idEstabelecimento", EmitDefaultValue=false)]
        public long? IdEstabelecimento { get; set; }
    
        /// <summary>
        /// Identification Code of the Transaction type
        /// </summary>
        /// <value>Identification Code of the Transaction type</value>
        [DataMember(Name="idTipoTransacaoNaoProcessada", EmitDefaultValue=false)]
        public long? IdTipoTransacaoNaoProcessada { get; set; }
    
        /// <summary>
        /// Identification Code of the Transaction (id) that generated the reversal
        /// </summary>
        /// <value>Identification Code of the Transaction (id) that generated the reversal</value>
        [DataMember(Name="idTransacaoEstorno", EmitDefaultValue=false)]
        public long? IdTransacaoEstorno { get; set; }
    
        /// <summary>
        /// Merchant location
        /// </summary>
        /// <value>Merchant location</value>
        [DataMember(Name="localidadeEstabelecimento", EmitDefaultValue=false)]
        public string LocalidadeEstabelecimento { get; set; }
    
        /// <summary>
        /// Describe the mode used to perform the card dates reading to make the transaction
        /// </summary>
        /// <value>Describe the mode used to perform the card dates reading to make the transaction</value>
        [DataMember(Name="modoEntradaTransacao", EmitDefaultValue=false)]
        public string ModoEntradaTransacao { get; set; }
    
        /// <summary>
        /// Merchant Name
        /// </summary>
        /// <value>Merchant Name</value>
        [DataMember(Name="nomeEstabelecimento", EmitDefaultValue=false)]
        public string NomeEstabelecimento { get; set; }
    
        /// <summary>
        /// Fantasy name of the Merchant
        /// </summary>
        /// <value>Fantasy name of the Merchant</value>
        [DataMember(Name="nomeFantasiaEstabelecimento", EmitDefaultValue=false)]
        public string NomeFantasiaEstabelecimento { get; set; }
    
        /// <summary>
        /// Full name of the Cardholder
        /// </summary>
        /// <value>Full name of the Cardholder</value>
        [DataMember(Name="nomePortador", EmitDefaultValue=false)]
        public string NomePortador { get; set; }
    
        /// <summary>
        /// When the transaction is the installment type, show the number of the Parcels
        /// </summary>
        /// <value>When the transaction is the installment type, show the number of the Parcels</value>
        [DataMember(Name="parcela", EmitDefaultValue=false)]
        public long? Parcela { get; set; }
    
        /// <summary>
        /// When the transaction is the Installment type, show the total number of the parcels
        /// </summary>
        /// <value>When the transaction is the Installment type, show the total number of the parcels</value>
        [DataMember(Name="plano", EmitDefaultValue=false)]
        public long? Plano { get; set; }
    
        /// <summary>
        /// Attributed that represents the identifier code of the transaction status
        /// </summary>
        /// <value>Attributed that represents the identifier code of the transaction status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
    
        /// <summary>
        /// Value of the Boarding fee in Real (BRL) when the transaction is related to the purchase of airline tickets
        /// </summary>
        /// <value>Value of the Boarding fee in Real (BRL) when the transaction is related to the purchase of airline tickets</value>
        [DataMember(Name="taxaEmbarque", EmitDefaultValue=false)]
        public double? TaxaEmbarque { get; set; }
    
        /// <summary>
        /// Transaction value in Real (BRL)
        /// </summary>
        /// <value>Transaction value in Real (BRL)</value>
        [DataMember(Name="valorBRL", EmitDefaultValue=false)]
        public double? ValorBRL { get; set; }
    
        /// <summary>
        /// Entrance value in Real (BRL) when the transaction is installment type with the payment of an entrance value
        /// </summary>
        /// <value>Entrance value in Real (BRL) when the transaction is installment type with the payment of an entrance value</value>
        [DataMember(Name="valorEntrada", EmitDefaultValue=false)]
        public double? ValorEntrada { get; set; }
    
        /// <summary>
        /// Transaction value in American Dollar (USD)
        /// </summary>
        /// <value>Transaction value in American Dollar (USD)</value>
        [DataMember(Name="valorUSD", EmitDefaultValue=false)]
        public double? ValorUSD { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransacaoNaoProcessadaResponse {\n");
            sb.Append("  CartaoMascarado: ").Append(CartaoMascarado).Append("\n");
            sb.Append("  CodigoAutorizacao: ").Append(CodigoAutorizacao).Append("\n");
            sb.Append("  CodigoMCC: ").Append(CodigoMCC).Append("\n");
            sb.Append("  CodigoMoedaDestino: ").Append(CodigoMoedaDestino).Append("\n");
            sb.Append("  CodigoMoedaOrigem: ").Append(CodigoMoedaOrigem).Append("\n");
            sb.Append("  CodigoReferencia: ").Append(CodigoReferencia).Append("\n");
            sb.Append("  CodigoTerminal: ").Append(CodigoTerminal).Append("\n");
            sb.Append("  CotacaoUSD: ").Append(CotacaoUSD).Append("\n");
            sb.Append("  DataCotacaoUSD: ").Append(DataCotacaoUSD).Append("\n");
            sb.Append("  DataFaturamento: ").Append(DataFaturamento).Append("\n");
            sb.Append("  DataOrigem: ").Append(DataOrigem).Append("\n");
            sb.Append("  DataVencimentoReal: ").Append(DataVencimentoReal).Append("\n");
            sb.Append("  DescricaoAbreviada: ").Append(DescricaoAbreviada).Append("\n");
            sb.Append("  DescricaoTipoTransacaoNaoProcessada: ").Append(DescricaoTipoTransacaoNaoProcessada).Append("\n");
            sb.Append("  DetalhesTransacao: ").Append(DetalhesTransacao).Append("\n");
            sb.Append("  FlagCredito: ").Append(FlagCredito).Append("\n");
            sb.Append("  FlagFaturado: ").Append(FlagFaturado).Append("\n");
            sb.Append("  GrupoDescricaoMCC: ").Append(GrupoDescricaoMCC).Append("\n");
            sb.Append("  GrupoMCC: ").Append(GrupoMCC).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdEstabelecimento: ").Append(IdEstabelecimento).Append("\n");
            sb.Append("  IdTipoTransacaoNaoProcessada: ").Append(IdTipoTransacaoNaoProcessada).Append("\n");
            sb.Append("  IdTransacaoEstorno: ").Append(IdTransacaoEstorno).Append("\n");
            sb.Append("  LocalidadeEstabelecimento: ").Append(LocalidadeEstabelecimento).Append("\n");
            sb.Append("  ModoEntradaTransacao: ").Append(ModoEntradaTransacao).Append("\n");
            sb.Append("  NomeEstabelecimento: ").Append(NomeEstabelecimento).Append("\n");
            sb.Append("  NomeFantasiaEstabelecimento: ").Append(NomeFantasiaEstabelecimento).Append("\n");
            sb.Append("  NomePortador: ").Append(NomePortador).Append("\n");
            sb.Append("  Parcela: ").Append(Parcela).Append("\n");
            sb.Append("  Plano: ").Append(Plano).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TaxaEmbarque: ").Append(TaxaEmbarque).Append("\n");
            sb.Append("  ValorBRL: ").Append(ValorBRL).Append("\n");
            sb.Append("  ValorEntrada: ").Append(ValorEntrada).Append("\n");
            sb.Append("  ValorUSD: ").Append(ValorUSD).Append("\n");
            
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
            return this.Equals(obj as TransacaoNaoProcessadaResponse);
        }

        /// <summary>
        /// Returns true if TransacaoNaoProcessadaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TransacaoNaoProcessadaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransacaoNaoProcessadaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CartaoMascarado == other.CartaoMascarado ||
                    this.CartaoMascarado != null &&
                    this.CartaoMascarado.Equals(other.CartaoMascarado)
                ) && 
                (
                    this.CodigoAutorizacao == other.CodigoAutorizacao ||
                    this.CodigoAutorizacao != null &&
                    this.CodigoAutorizacao.Equals(other.CodigoAutorizacao)
                ) && 
                (
                    this.CodigoMCC == other.CodigoMCC ||
                    this.CodigoMCC != null &&
                    this.CodigoMCC.Equals(other.CodigoMCC)
                ) && 
                (
                    this.CodigoMoedaDestino == other.CodigoMoedaDestino ||
                    this.CodigoMoedaDestino != null &&
                    this.CodigoMoedaDestino.Equals(other.CodigoMoedaDestino)
                ) && 
                (
                    this.CodigoMoedaOrigem == other.CodigoMoedaOrigem ||
                    this.CodigoMoedaOrigem != null &&
                    this.CodigoMoedaOrigem.Equals(other.CodigoMoedaOrigem)
                ) && 
                (
                    this.CodigoReferencia == other.CodigoReferencia ||
                    this.CodigoReferencia != null &&
                    this.CodigoReferencia.Equals(other.CodigoReferencia)
                ) && 
                (
                    this.CodigoTerminal == other.CodigoTerminal ||
                    this.CodigoTerminal != null &&
                    this.CodigoTerminal.Equals(other.CodigoTerminal)
                ) && 
                (
                    this.CotacaoUSD == other.CotacaoUSD ||
                    this.CotacaoUSD != null &&
                    this.CotacaoUSD.Equals(other.CotacaoUSD)
                ) && 
                (
                    this.DataCotacaoUSD == other.DataCotacaoUSD ||
                    this.DataCotacaoUSD != null &&
                    this.DataCotacaoUSD.Equals(other.DataCotacaoUSD)
                ) && 
                (
                    this.DataFaturamento == other.DataFaturamento ||
                    this.DataFaturamento != null &&
                    this.DataFaturamento.Equals(other.DataFaturamento)
                ) && 
                (
                    this.DataOrigem == other.DataOrigem ||
                    this.DataOrigem != null &&
                    this.DataOrigem.Equals(other.DataOrigem)
                ) && 
                (
                    this.DataVencimentoReal == other.DataVencimentoReal ||
                    this.DataVencimentoReal != null &&
                    this.DataVencimentoReal.Equals(other.DataVencimentoReal)
                ) && 
                (
                    this.DescricaoAbreviada == other.DescricaoAbreviada ||
                    this.DescricaoAbreviada != null &&
                    this.DescricaoAbreviada.Equals(other.DescricaoAbreviada)
                ) && 
                (
                    this.DescricaoTipoTransacaoNaoProcessada == other.DescricaoTipoTransacaoNaoProcessada ||
                    this.DescricaoTipoTransacaoNaoProcessada != null &&
                    this.DescricaoTipoTransacaoNaoProcessada.Equals(other.DescricaoTipoTransacaoNaoProcessada)
                ) && 
                (
                    this.DetalhesTransacao == other.DetalhesTransacao ||
                    this.DetalhesTransacao != null &&
                    this.DetalhesTransacao.Equals(other.DetalhesTransacao)
                ) && 
                (
                    this.FlagCredito == other.FlagCredito ||
                    this.FlagCredito != null &&
                    this.FlagCredito.Equals(other.FlagCredito)
                ) && 
                (
                    this.FlagFaturado == other.FlagFaturado ||
                    this.FlagFaturado != null &&
                    this.FlagFaturado.Equals(other.FlagFaturado)
                ) && 
                (
                    this.GrupoDescricaoMCC == other.GrupoDescricaoMCC ||
                    this.GrupoDescricaoMCC != null &&
                    this.GrupoDescricaoMCC.Equals(other.GrupoDescricaoMCC)
                ) && 
                (
                    this.GrupoMCC == other.GrupoMCC ||
                    this.GrupoMCC != null &&
                    this.GrupoMCC.Equals(other.GrupoMCC)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdEstabelecimento == other.IdEstabelecimento ||
                    this.IdEstabelecimento != null &&
                    this.IdEstabelecimento.Equals(other.IdEstabelecimento)
                ) && 
                (
                    this.IdTipoTransacaoNaoProcessada == other.IdTipoTransacaoNaoProcessada ||
                    this.IdTipoTransacaoNaoProcessada != null &&
                    this.IdTipoTransacaoNaoProcessada.Equals(other.IdTipoTransacaoNaoProcessada)
                ) && 
                (
                    this.IdTransacaoEstorno == other.IdTransacaoEstorno ||
                    this.IdTransacaoEstorno != null &&
                    this.IdTransacaoEstorno.Equals(other.IdTransacaoEstorno)
                ) && 
                (
                    this.LocalidadeEstabelecimento == other.LocalidadeEstabelecimento ||
                    this.LocalidadeEstabelecimento != null &&
                    this.LocalidadeEstabelecimento.Equals(other.LocalidadeEstabelecimento)
                ) && 
                (
                    this.ModoEntradaTransacao == other.ModoEntradaTransacao ||
                    this.ModoEntradaTransacao != null &&
                    this.ModoEntradaTransacao.Equals(other.ModoEntradaTransacao)
                ) && 
                (
                    this.NomeEstabelecimento == other.NomeEstabelecimento ||
                    this.NomeEstabelecimento != null &&
                    this.NomeEstabelecimento.Equals(other.NomeEstabelecimento)
                ) && 
                (
                    this.NomeFantasiaEstabelecimento == other.NomeFantasiaEstabelecimento ||
                    this.NomeFantasiaEstabelecimento != null &&
                    this.NomeFantasiaEstabelecimento.Equals(other.NomeFantasiaEstabelecimento)
                ) && 
                (
                    this.NomePortador == other.NomePortador ||
                    this.NomePortador != null &&
                    this.NomePortador.Equals(other.NomePortador)
                ) && 
                (
                    this.Parcela == other.Parcela ||
                    this.Parcela != null &&
                    this.Parcela.Equals(other.Parcela)
                ) && 
                (
                    this.Plano == other.Plano ||
                    this.Plano != null &&
                    this.Plano.Equals(other.Plano)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.TaxaEmbarque == other.TaxaEmbarque ||
                    this.TaxaEmbarque != null &&
                    this.TaxaEmbarque.Equals(other.TaxaEmbarque)
                ) && 
                (
                    this.ValorBRL == other.ValorBRL ||
                    this.ValorBRL != null &&
                    this.ValorBRL.Equals(other.ValorBRL)
                ) && 
                (
                    this.ValorEntrada == other.ValorEntrada ||
                    this.ValorEntrada != null &&
                    this.ValorEntrada.Equals(other.ValorEntrada)
                ) && 
                (
                    this.ValorUSD == other.ValorUSD ||
                    this.ValorUSD != null &&
                    this.ValorUSD.Equals(other.ValorUSD)
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
                
                if (this.CartaoMascarado != null)
                    hash = hash * 59 + this.CartaoMascarado.GetHashCode();
                
                if (this.CodigoAutorizacao != null)
                    hash = hash * 59 + this.CodigoAutorizacao.GetHashCode();
                
                if (this.CodigoMCC != null)
                    hash = hash * 59 + this.CodigoMCC.GetHashCode();
                
                if (this.CodigoMoedaDestino != null)
                    hash = hash * 59 + this.CodigoMoedaDestino.GetHashCode();
                
                if (this.CodigoMoedaOrigem != null)
                    hash = hash * 59 + this.CodigoMoedaOrigem.GetHashCode();
                
                if (this.CodigoReferencia != null)
                    hash = hash * 59 + this.CodigoReferencia.GetHashCode();
                
                if (this.CodigoTerminal != null)
                    hash = hash * 59 + this.CodigoTerminal.GetHashCode();
                
                if (this.CotacaoUSD != null)
                    hash = hash * 59 + this.CotacaoUSD.GetHashCode();
                
                if (this.DataCotacaoUSD != null)
                    hash = hash * 59 + this.DataCotacaoUSD.GetHashCode();
                
                if (this.DataFaturamento != null)
                    hash = hash * 59 + this.DataFaturamento.GetHashCode();
                
                if (this.DataOrigem != null)
                    hash = hash * 59 + this.DataOrigem.GetHashCode();
                
                if (this.DataVencimentoReal != null)
                    hash = hash * 59 + this.DataVencimentoReal.GetHashCode();
                
                if (this.DescricaoAbreviada != null)
                    hash = hash * 59 + this.DescricaoAbreviada.GetHashCode();
                
                if (this.DescricaoTipoTransacaoNaoProcessada != null)
                    hash = hash * 59 + this.DescricaoTipoTransacaoNaoProcessada.GetHashCode();
                
                if (this.DetalhesTransacao != null)
                    hash = hash * 59 + this.DetalhesTransacao.GetHashCode();
                
                if (this.FlagCredito != null)
                    hash = hash * 59 + this.FlagCredito.GetHashCode();
                
                if (this.FlagFaturado != null)
                    hash = hash * 59 + this.FlagFaturado.GetHashCode();
                
                if (this.GrupoDescricaoMCC != null)
                    hash = hash * 59 + this.GrupoDescricaoMCC.GetHashCode();
                
                if (this.GrupoMCC != null)
                    hash = hash * 59 + this.GrupoMCC.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdEstabelecimento != null)
                    hash = hash * 59 + this.IdEstabelecimento.GetHashCode();
                
                if (this.IdTipoTransacaoNaoProcessada != null)
                    hash = hash * 59 + this.IdTipoTransacaoNaoProcessada.GetHashCode();
                
                if (this.IdTransacaoEstorno != null)
                    hash = hash * 59 + this.IdTransacaoEstorno.GetHashCode();
                
                if (this.LocalidadeEstabelecimento != null)
                    hash = hash * 59 + this.LocalidadeEstabelecimento.GetHashCode();
                
                if (this.ModoEntradaTransacao != null)
                    hash = hash * 59 + this.ModoEntradaTransacao.GetHashCode();
                
                if (this.NomeEstabelecimento != null)
                    hash = hash * 59 + this.NomeEstabelecimento.GetHashCode();
                
                if (this.NomeFantasiaEstabelecimento != null)
                    hash = hash * 59 + this.NomeFantasiaEstabelecimento.GetHashCode();
                
                if (this.NomePortador != null)
                    hash = hash * 59 + this.NomePortador.GetHashCode();
                
                if (this.Parcela != null)
                    hash = hash * 59 + this.Parcela.GetHashCode();
                
                if (this.Plano != null)
                    hash = hash * 59 + this.Plano.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.TaxaEmbarque != null)
                    hash = hash * 59 + this.TaxaEmbarque.GetHashCode();
                
                if (this.ValorBRL != null)
                    hash = hash * 59 + this.ValorBRL.GetHashCode();
                
                if (this.ValorEntrada != null)
                    hash = hash * 59 + this.ValorEntrada.GetHashCode();
                
                if (this.ValorUSD != null)
                    hash = hash * 59 + this.ValorUSD.GetHashCode();
                
                return hash;
            }
        }

    }
}
