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
    /// Object current transactions
    /// </summary>
    [DataContract]
    public partial class TransacoesCorrentesResponse :  IEquatable<TransacoesCorrentesResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransacoesCorrentesResponse" /> class.
        /// Initializes a new instance of the <see cref="TransacoesCorrentesResponse" />class.
        /// </summary>
        /// <param name="Id">Indentification Code of the transfer (id).</param>
        /// <param name="IdTipoTransacao">Identification Code of the Transaction Type.</param>
        /// <param name="DescricaoAbreviada">Abbreviated description of the transaction.</param>
        /// <param name="StatusTransacao">Processing Status of the Transaction.</param>
        /// <param name="IdEvento">Identification Code of the Event that originated the transaction (id).</param>
        /// <param name="TipoEvento">Description of the Event that represents the transaction.</param>
        /// <param name="IdConta">Identifcation Code of the Account (id).</param>
        /// <param name="CartaoMascarado">Number of the card in format 0000XXXXXXXX0000.</param>
        /// <param name="NomePortador">Full name of the card holder.</param>
        /// <param name="DataTransacao">Date which the transaction was made.</param>
        /// <param name="DataFaturamento">Billing date of the transaction.</param>
        /// <param name="DataVencimento">Expiration date of the invoice.</param>
        /// <param name="ModoEntradaTransacao">Describe the mode used to do the card dates reading to make the transaction.</param>
        /// <param name="ValorTaxaEmbarque">Value of the Boarding fee in Real (BRL) when the transaction is related to a purchase of airline tickets.</param>
        /// <param name="ValorEntrada">Value of the entrance in Real (BRL) when the transaction if the transaction is the installment type with the payment of an entrance value.</param>
        /// <param name="ValorBRL">Value of the Transaction in Real (BRL).</param>
        /// <param name="ValorUSD">Value of the transaction in American Dollar (USD).</param>
        /// <param name="CotacaoUSD">Value of the American Dollar (USD) converted in Real (BRL).</param>
        /// <param name="DataCotacaoUSD">Closing date quotation of the American Dollar (USD).</param>
        /// <param name="CodigoMoedaOrigem">Identification Code of the currency used in the transaction, following the standard ISO 4217.</param>
        /// <param name="CodigoMoedaDestino">Identification Code of the transaction currency after the conversion, sollowing the standard ISO 4217.</param>
        /// <param name="CodigoAutorizacao">Authorization Code of the Transaction.</param>
        /// <param name="CodigoReferencia">Reference Code of the Transaction when it is used a Flagged Card.</param>
        /// <param name="CodigoTerminal">Identification Code of the transaction capture source.</param>
        /// <param name="CodigoMCC">Identification Code of the Merchant category.</param>
        /// <param name="GrupoMCC">Identification Code of the Merchant Group.</param>
        /// <param name="GrupoDescricaoMCC">Description of the Merchant Group.</param>
        /// <param name="IdEstabelecimento">Identification Code of the Merchant (id).</param>
        /// <param name="NomeEstabelecimento">Merchant name.</param>
        /// <param name="NomeFantasiaEstabelecimento">Fantasy Name of the Merchant.</param>
        /// <param name="LocalidadeEstabelecimento">Merchant Location.</param>
        /// <param name="PlanoParcelamento">When the transaction is the installment type, show the total number of the parcels.</param>
        /// <param name="NumeroParcela">When the transaction is the istallment type, show the number of Parcels.</param>
        /// <param name="DetalhesTransacao">Complementary details regard to the transaction.</param>
        /// <param name="FlagCredito">When it is activate, indicate that the transaction is the &#39;Credit&#39; type.</param>
        /// <param name="FlagFaturado">When it is activate, indicate that the transaction was consolidated in an invoice.</param>
        /// <param name="FlagEstorno">When it is activate, indicates that the transaction was reversed.</param>
        /// <param name="IdTransacaoEstorno">Identification Code of the transaction (id) that generated the reversal.</param>

        public TransacoesCorrentesResponse(long? Id = null, long? IdTipoTransacao = null, string DescricaoAbreviada = null, string StatusTransacao = null, long? IdEvento = null, string TipoEvento = null, long? IdConta = null, string CartaoMascarado = null, string NomePortador = null, string DataTransacao = null, string DataFaturamento = null, string DataVencimento = null, string ModoEntradaTransacao = null, double? ValorTaxaEmbarque = null, double? ValorEntrada = null, double? ValorBRL = null, double? ValorUSD = null, double? CotacaoUSD = null, string DataCotacaoUSD = null, string CodigoMoedaOrigem = null, string CodigoMoedaDestino = null, string CodigoAutorizacao = null, string CodigoReferencia = null, string CodigoTerminal = null, long? CodigoMCC = null, long? GrupoMCC = null, string GrupoDescricaoMCC = null, long? IdEstabelecimento = null, string NomeEstabelecimento = null, string NomeFantasiaEstabelecimento = null, string LocalidadeEstabelecimento = null, long? PlanoParcelamento = null, long? NumeroParcela = null, string DetalhesTransacao = null, int? FlagCredito = null, int? FlagFaturado = null, int? FlagEstorno = null, long? IdTransacaoEstorno = null)
        {
            this.Id = Id;
            this.IdTipoTransacao = IdTipoTransacao;
            this.DescricaoAbreviada = DescricaoAbreviada;
            this.StatusTransacao = StatusTransacao;
            this.IdEvento = IdEvento;
            this.TipoEvento = TipoEvento;
            this.IdConta = IdConta;
            this.CartaoMascarado = CartaoMascarado;
            this.NomePortador = NomePortador;
            this.DataTransacao = DataTransacao;
            this.DataFaturamento = DataFaturamento;
            this.DataVencimento = DataVencimento;
            this.ModoEntradaTransacao = ModoEntradaTransacao;
            this.ValorTaxaEmbarque = ValorTaxaEmbarque;
            this.ValorEntrada = ValorEntrada;
            this.ValorBRL = ValorBRL;
            this.ValorUSD = ValorUSD;
            this.CotacaoUSD = CotacaoUSD;
            this.DataCotacaoUSD = DataCotacaoUSD;
            this.CodigoMoedaOrigem = CodigoMoedaOrigem;
            this.CodigoMoedaDestino = CodigoMoedaDestino;
            this.CodigoAutorizacao = CodigoAutorizacao;
            this.CodigoReferencia = CodigoReferencia;
            this.CodigoTerminal = CodigoTerminal;
            this.CodigoMCC = CodigoMCC;
            this.GrupoMCC = GrupoMCC;
            this.GrupoDescricaoMCC = GrupoDescricaoMCC;
            this.IdEstabelecimento = IdEstabelecimento;
            this.NomeEstabelecimento = NomeEstabelecimento;
            this.NomeFantasiaEstabelecimento = NomeFantasiaEstabelecimento;
            this.LocalidadeEstabelecimento = LocalidadeEstabelecimento;
            this.PlanoParcelamento = PlanoParcelamento;
            this.NumeroParcela = NumeroParcela;
            this.DetalhesTransacao = DetalhesTransacao;
            this.FlagCredito = FlagCredito;
            this.FlagFaturado = FlagFaturado;
            this.FlagEstorno = FlagEstorno;
            this.IdTransacaoEstorno = IdTransacaoEstorno;
            
        }
        
    
        /// <summary>
        /// Indentification Code of the transfer (id)
        /// </summary>
        /// <value>Indentification Code of the transfer (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Identification Code of the Transaction Type
        /// </summary>
        /// <value>Identification Code of the Transaction Type</value>
        [DataMember(Name="idTipoTransacao", EmitDefaultValue=false)]
        public long? IdTipoTransacao { get; set; }
    
        /// <summary>
        /// Abbreviated description of the transaction
        /// </summary>
        /// <value>Abbreviated description of the transaction</value>
        [DataMember(Name="descricaoAbreviada", EmitDefaultValue=false)]
        public string DescricaoAbreviada { get; set; }
    
        /// <summary>
        /// Processing Status of the Transaction
        /// </summary>
        /// <value>Processing Status of the Transaction</value>
        [DataMember(Name="statusTransacao", EmitDefaultValue=false)]
        public string StatusTransacao { get; set; }
    
        /// <summary>
        /// Identification Code of the Event that originated the transaction (id)
        /// </summary>
        /// <value>Identification Code of the Event that originated the transaction (id)</value>
        [DataMember(Name="idEvento", EmitDefaultValue=false)]
        public long? IdEvento { get; set; }
    
        /// <summary>
        /// Description of the Event that represents the transaction
        /// </summary>
        /// <value>Description of the Event that represents the transaction</value>
        [DataMember(Name="tipoEvento", EmitDefaultValue=false)]
        public string TipoEvento { get; set; }
    
        /// <summary>
        /// Identifcation Code of the Account (id)
        /// </summary>
        /// <value>Identifcation Code of the Account (id)</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Number of the card in format 0000XXXXXXXX0000
        /// </summary>
        /// <value>Number of the card in format 0000XXXXXXXX0000</value>
        [DataMember(Name="cartaoMascarado", EmitDefaultValue=false)]
        public string CartaoMascarado { get; set; }
    
        /// <summary>
        /// Full name of the card holder
        /// </summary>
        /// <value>Full name of the card holder</value>
        [DataMember(Name="nomePortador", EmitDefaultValue=false)]
        public string NomePortador { get; set; }
    
        /// <summary>
        /// Date which the transaction was made
        /// </summary>
        /// <value>Date which the transaction was made</value>
        [DataMember(Name="dataTransacao", EmitDefaultValue=false)]
        public string DataTransacao { get; set; }
    
        /// <summary>
        /// Billing date of the transaction
        /// </summary>
        /// <value>Billing date of the transaction</value>
        [DataMember(Name="dataFaturamento", EmitDefaultValue=false)]
        public string DataFaturamento { get; set; }
    
        /// <summary>
        /// Expiration date of the invoice
        /// </summary>
        /// <value>Expiration date of the invoice</value>
        [DataMember(Name="dataVencimento", EmitDefaultValue=false)]
        public string DataVencimento { get; set; }
    
        /// <summary>
        /// Describe the mode used to do the card dates reading to make the transaction
        /// </summary>
        /// <value>Describe the mode used to do the card dates reading to make the transaction</value>
        [DataMember(Name="modoEntradaTransacao", EmitDefaultValue=false)]
        public string ModoEntradaTransacao { get; set; }
    
        /// <summary>
        /// Value of the Boarding fee in Real (BRL) when the transaction is related to a purchase of airline tickets
        /// </summary>
        /// <value>Value of the Boarding fee in Real (BRL) when the transaction is related to a purchase of airline tickets</value>
        [DataMember(Name="valorTaxaEmbarque", EmitDefaultValue=false)]
        public double? ValorTaxaEmbarque { get; set; }
    
        /// <summary>
        /// Value of the entrance in Real (BRL) when the transaction if the transaction is the installment type with the payment of an entrance value
        /// </summary>
        /// <value>Value of the entrance in Real (BRL) when the transaction if the transaction is the installment type with the payment of an entrance value</value>
        [DataMember(Name="valorEntrada", EmitDefaultValue=false)]
        public double? ValorEntrada { get; set; }
    
        /// <summary>
        /// Value of the Transaction in Real (BRL)
        /// </summary>
        /// <value>Value of the Transaction in Real (BRL)</value>
        [DataMember(Name="valorBRL", EmitDefaultValue=false)]
        public double? ValorBRL { get; set; }
    
        /// <summary>
        /// Value of the transaction in American Dollar (USD)
        /// </summary>
        /// <value>Value of the transaction in American Dollar (USD)</value>
        [DataMember(Name="valorUSD", EmitDefaultValue=false)]
        public double? ValorUSD { get; set; }
    
        /// <summary>
        /// Value of the American Dollar (USD) converted in Real (BRL)
        /// </summary>
        /// <value>Value of the American Dollar (USD) converted in Real (BRL)</value>
        [DataMember(Name="cotacaoUSD", EmitDefaultValue=false)]
        public double? CotacaoUSD { get; set; }
    
        /// <summary>
        /// Closing date quotation of the American Dollar (USD)
        /// </summary>
        /// <value>Closing date quotation of the American Dollar (USD)</value>
        [DataMember(Name="dataCotacaoUSD", EmitDefaultValue=false)]
        public string DataCotacaoUSD { get; set; }
    
        /// <summary>
        /// Identification Code of the currency used in the transaction, following the standard ISO 4217
        /// </summary>
        /// <value>Identification Code of the currency used in the transaction, following the standard ISO 4217</value>
        [DataMember(Name="codigoMoedaOrigem", EmitDefaultValue=false)]
        public string CodigoMoedaOrigem { get; set; }
    
        /// <summary>
        /// Identification Code of the transaction currency after the conversion, sollowing the standard ISO 4217
        /// </summary>
        /// <value>Identification Code of the transaction currency after the conversion, sollowing the standard ISO 4217</value>
        [DataMember(Name="codigoMoedaDestino", EmitDefaultValue=false)]
        public string CodigoMoedaDestino { get; set; }
    
        /// <summary>
        /// Authorization Code of the Transaction
        /// </summary>
        /// <value>Authorization Code of the Transaction</value>
        [DataMember(Name="codigoAutorizacao", EmitDefaultValue=false)]
        public string CodigoAutorizacao { get; set; }
    
        /// <summary>
        /// Reference Code of the Transaction when it is used a Flagged Card
        /// </summary>
        /// <value>Reference Code of the Transaction when it is used a Flagged Card</value>
        [DataMember(Name="codigoReferencia", EmitDefaultValue=false)]
        public string CodigoReferencia { get; set; }
    
        /// <summary>
        /// Identification Code of the transaction capture source
        /// </summary>
        /// <value>Identification Code of the transaction capture source</value>
        [DataMember(Name="codigoTerminal", EmitDefaultValue=false)]
        public string CodigoTerminal { get; set; }
    
        /// <summary>
        /// Identification Code of the Merchant category
        /// </summary>
        /// <value>Identification Code of the Merchant category</value>
        [DataMember(Name="codigoMCC", EmitDefaultValue=false)]
        public long? CodigoMCC { get; set; }
    
        /// <summary>
        /// Identification Code of the Merchant Group
        /// </summary>
        /// <value>Identification Code of the Merchant Group</value>
        [DataMember(Name="grupoMCC", EmitDefaultValue=false)]
        public long? GrupoMCC { get; set; }
    
        /// <summary>
        /// Description of the Merchant Group
        /// </summary>
        /// <value>Description of the Merchant Group</value>
        [DataMember(Name="grupoDescricaoMCC", EmitDefaultValue=false)]
        public string GrupoDescricaoMCC { get; set; }
    
        /// <summary>
        /// Identification Code of the Merchant (id)
        /// </summary>
        /// <value>Identification Code of the Merchant (id)</value>
        [DataMember(Name="idEstabelecimento", EmitDefaultValue=false)]
        public long? IdEstabelecimento { get; set; }
    
        /// <summary>
        /// Merchant name
        /// </summary>
        /// <value>Merchant name</value>
        [DataMember(Name="nomeEstabelecimento", EmitDefaultValue=false)]
        public string NomeEstabelecimento { get; set; }
    
        /// <summary>
        /// Fantasy Name of the Merchant
        /// </summary>
        /// <value>Fantasy Name of the Merchant</value>
        [DataMember(Name="nomeFantasiaEstabelecimento", EmitDefaultValue=false)]
        public string NomeFantasiaEstabelecimento { get; set; }
    
        /// <summary>
        /// Merchant Location
        /// </summary>
        /// <value>Merchant Location</value>
        [DataMember(Name="localidadeEstabelecimento", EmitDefaultValue=false)]
        public string LocalidadeEstabelecimento { get; set; }
    
        /// <summary>
        /// When the transaction is the installment type, show the total number of the parcels
        /// </summary>
        /// <value>When the transaction is the installment type, show the total number of the parcels</value>
        [DataMember(Name="planoParcelamento", EmitDefaultValue=false)]
        public long? PlanoParcelamento { get; set; }
    
        /// <summary>
        /// When the transaction is the istallment type, show the number of Parcels
        /// </summary>
        /// <value>When the transaction is the istallment type, show the number of Parcels</value>
        [DataMember(Name="numeroParcela", EmitDefaultValue=false)]
        public long? NumeroParcela { get; set; }
    
        /// <summary>
        /// Complementary details regard to the transaction
        /// </summary>
        /// <value>Complementary details regard to the transaction</value>
        [DataMember(Name="detalhesTransacao", EmitDefaultValue=false)]
        public string DetalhesTransacao { get; set; }
    
        /// <summary>
        /// When it is activate, indicate that the transaction is the &#39;Credit&#39; type
        /// </summary>
        /// <value>When it is activate, indicate that the transaction is the &#39;Credit&#39; type</value>
        [DataMember(Name="flagCredito", EmitDefaultValue=false)]
        public int? FlagCredito { get; set; }
    
        /// <summary>
        /// When it is activate, indicate that the transaction was consolidated in an invoice
        /// </summary>
        /// <value>When it is activate, indicate that the transaction was consolidated in an invoice</value>
        [DataMember(Name="flagFaturado", EmitDefaultValue=false)]
        public int? FlagFaturado { get; set; }
    
        /// <summary>
        /// When it is activate, indicates that the transaction was reversed
        /// </summary>
        /// <value>When it is activate, indicates that the transaction was reversed</value>
        [DataMember(Name="flagEstorno", EmitDefaultValue=false)]
        public int? FlagEstorno { get; set; }
    
        /// <summary>
        /// Identification Code of the transaction (id) that generated the reversal
        /// </summary>
        /// <value>Identification Code of the transaction (id) that generated the reversal</value>
        [DataMember(Name="idTransacaoEstorno", EmitDefaultValue=false)]
        public long? IdTransacaoEstorno { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransacoesCorrentesResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdTipoTransacao: ").Append(IdTipoTransacao).Append("\n");
            sb.Append("  DescricaoAbreviada: ").Append(DescricaoAbreviada).Append("\n");
            sb.Append("  StatusTransacao: ").Append(StatusTransacao).Append("\n");
            sb.Append("  IdEvento: ").Append(IdEvento).Append("\n");
            sb.Append("  TipoEvento: ").Append(TipoEvento).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  CartaoMascarado: ").Append(CartaoMascarado).Append("\n");
            sb.Append("  NomePortador: ").Append(NomePortador).Append("\n");
            sb.Append("  DataTransacao: ").Append(DataTransacao).Append("\n");
            sb.Append("  DataFaturamento: ").Append(DataFaturamento).Append("\n");
            sb.Append("  DataVencimento: ").Append(DataVencimento).Append("\n");
            sb.Append("  ModoEntradaTransacao: ").Append(ModoEntradaTransacao).Append("\n");
            sb.Append("  ValorTaxaEmbarque: ").Append(ValorTaxaEmbarque).Append("\n");
            sb.Append("  ValorEntrada: ").Append(ValorEntrada).Append("\n");
            sb.Append("  ValorBRL: ").Append(ValorBRL).Append("\n");
            sb.Append("  ValorUSD: ").Append(ValorUSD).Append("\n");
            sb.Append("  CotacaoUSD: ").Append(CotacaoUSD).Append("\n");
            sb.Append("  DataCotacaoUSD: ").Append(DataCotacaoUSD).Append("\n");
            sb.Append("  CodigoMoedaOrigem: ").Append(CodigoMoedaOrigem).Append("\n");
            sb.Append("  CodigoMoedaDestino: ").Append(CodigoMoedaDestino).Append("\n");
            sb.Append("  CodigoAutorizacao: ").Append(CodigoAutorizacao).Append("\n");
            sb.Append("  CodigoReferencia: ").Append(CodigoReferencia).Append("\n");
            sb.Append("  CodigoTerminal: ").Append(CodigoTerminal).Append("\n");
            sb.Append("  CodigoMCC: ").Append(CodigoMCC).Append("\n");
            sb.Append("  GrupoMCC: ").Append(GrupoMCC).Append("\n");
            sb.Append("  GrupoDescricaoMCC: ").Append(GrupoDescricaoMCC).Append("\n");
            sb.Append("  IdEstabelecimento: ").Append(IdEstabelecimento).Append("\n");
            sb.Append("  NomeEstabelecimento: ").Append(NomeEstabelecimento).Append("\n");
            sb.Append("  NomeFantasiaEstabelecimento: ").Append(NomeFantasiaEstabelecimento).Append("\n");
            sb.Append("  LocalidadeEstabelecimento: ").Append(LocalidadeEstabelecimento).Append("\n");
            sb.Append("  PlanoParcelamento: ").Append(PlanoParcelamento).Append("\n");
            sb.Append("  NumeroParcela: ").Append(NumeroParcela).Append("\n");
            sb.Append("  DetalhesTransacao: ").Append(DetalhesTransacao).Append("\n");
            sb.Append("  FlagCredito: ").Append(FlagCredito).Append("\n");
            sb.Append("  FlagFaturado: ").Append(FlagFaturado).Append("\n");
            sb.Append("  FlagEstorno: ").Append(FlagEstorno).Append("\n");
            sb.Append("  IdTransacaoEstorno: ").Append(IdTransacaoEstorno).Append("\n");
            
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
            return this.Equals(obj as TransacoesCorrentesResponse);
        }

        /// <summary>
        /// Returns true if TransacoesCorrentesResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TransacoesCorrentesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransacoesCorrentesResponse other)
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
                    this.IdTipoTransacao == other.IdTipoTransacao ||
                    this.IdTipoTransacao != null &&
                    this.IdTipoTransacao.Equals(other.IdTipoTransacao)
                ) && 
                (
                    this.DescricaoAbreviada == other.DescricaoAbreviada ||
                    this.DescricaoAbreviada != null &&
                    this.DescricaoAbreviada.Equals(other.DescricaoAbreviada)
                ) && 
                (
                    this.StatusTransacao == other.StatusTransacao ||
                    this.StatusTransacao != null &&
                    this.StatusTransacao.Equals(other.StatusTransacao)
                ) && 
                (
                    this.IdEvento == other.IdEvento ||
                    this.IdEvento != null &&
                    this.IdEvento.Equals(other.IdEvento)
                ) && 
                (
                    this.TipoEvento == other.TipoEvento ||
                    this.TipoEvento != null &&
                    this.TipoEvento.Equals(other.TipoEvento)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.CartaoMascarado == other.CartaoMascarado ||
                    this.CartaoMascarado != null &&
                    this.CartaoMascarado.Equals(other.CartaoMascarado)
                ) && 
                (
                    this.NomePortador == other.NomePortador ||
                    this.NomePortador != null &&
                    this.NomePortador.Equals(other.NomePortador)
                ) && 
                (
                    this.DataTransacao == other.DataTransacao ||
                    this.DataTransacao != null &&
                    this.DataTransacao.Equals(other.DataTransacao)
                ) && 
                (
                    this.DataFaturamento == other.DataFaturamento ||
                    this.DataFaturamento != null &&
                    this.DataFaturamento.Equals(other.DataFaturamento)
                ) && 
                (
                    this.DataVencimento == other.DataVencimento ||
                    this.DataVencimento != null &&
                    this.DataVencimento.Equals(other.DataVencimento)
                ) && 
                (
                    this.ModoEntradaTransacao == other.ModoEntradaTransacao ||
                    this.ModoEntradaTransacao != null &&
                    this.ModoEntradaTransacao.Equals(other.ModoEntradaTransacao)
                ) && 
                (
                    this.ValorTaxaEmbarque == other.ValorTaxaEmbarque ||
                    this.ValorTaxaEmbarque != null &&
                    this.ValorTaxaEmbarque.Equals(other.ValorTaxaEmbarque)
                ) && 
                (
                    this.ValorEntrada == other.ValorEntrada ||
                    this.ValorEntrada != null &&
                    this.ValorEntrada.Equals(other.ValorEntrada)
                ) && 
                (
                    this.ValorBRL == other.ValorBRL ||
                    this.ValorBRL != null &&
                    this.ValorBRL.Equals(other.ValorBRL)
                ) && 
                (
                    this.ValorUSD == other.ValorUSD ||
                    this.ValorUSD != null &&
                    this.ValorUSD.Equals(other.ValorUSD)
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
                    this.CodigoMoedaOrigem == other.CodigoMoedaOrigem ||
                    this.CodigoMoedaOrigem != null &&
                    this.CodigoMoedaOrigem.Equals(other.CodigoMoedaOrigem)
                ) && 
                (
                    this.CodigoMoedaDestino == other.CodigoMoedaDestino ||
                    this.CodigoMoedaDestino != null &&
                    this.CodigoMoedaDestino.Equals(other.CodigoMoedaDestino)
                ) && 
                (
                    this.CodigoAutorizacao == other.CodigoAutorizacao ||
                    this.CodigoAutorizacao != null &&
                    this.CodigoAutorizacao.Equals(other.CodigoAutorizacao)
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
                    this.CodigoMCC == other.CodigoMCC ||
                    this.CodigoMCC != null &&
                    this.CodigoMCC.Equals(other.CodigoMCC)
                ) && 
                (
                    this.GrupoMCC == other.GrupoMCC ||
                    this.GrupoMCC != null &&
                    this.GrupoMCC.Equals(other.GrupoMCC)
                ) && 
                (
                    this.GrupoDescricaoMCC == other.GrupoDescricaoMCC ||
                    this.GrupoDescricaoMCC != null &&
                    this.GrupoDescricaoMCC.Equals(other.GrupoDescricaoMCC)
                ) && 
                (
                    this.IdEstabelecimento == other.IdEstabelecimento ||
                    this.IdEstabelecimento != null &&
                    this.IdEstabelecimento.Equals(other.IdEstabelecimento)
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
                    this.LocalidadeEstabelecimento == other.LocalidadeEstabelecimento ||
                    this.LocalidadeEstabelecimento != null &&
                    this.LocalidadeEstabelecimento.Equals(other.LocalidadeEstabelecimento)
                ) && 
                (
                    this.PlanoParcelamento == other.PlanoParcelamento ||
                    this.PlanoParcelamento != null &&
                    this.PlanoParcelamento.Equals(other.PlanoParcelamento)
                ) && 
                (
                    this.NumeroParcela == other.NumeroParcela ||
                    this.NumeroParcela != null &&
                    this.NumeroParcela.Equals(other.NumeroParcela)
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
                    this.FlagEstorno == other.FlagEstorno ||
                    this.FlagEstorno != null &&
                    this.FlagEstorno.Equals(other.FlagEstorno)
                ) && 
                (
                    this.IdTransacaoEstorno == other.IdTransacaoEstorno ||
                    this.IdTransacaoEstorno != null &&
                    this.IdTransacaoEstorno.Equals(other.IdTransacaoEstorno)
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
                
                if (this.IdTipoTransacao != null)
                    hash = hash * 59 + this.IdTipoTransacao.GetHashCode();
                
                if (this.DescricaoAbreviada != null)
                    hash = hash * 59 + this.DescricaoAbreviada.GetHashCode();
                
                if (this.StatusTransacao != null)
                    hash = hash * 59 + this.StatusTransacao.GetHashCode();
                
                if (this.IdEvento != null)
                    hash = hash * 59 + this.IdEvento.GetHashCode();
                
                if (this.TipoEvento != null)
                    hash = hash * 59 + this.TipoEvento.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.CartaoMascarado != null)
                    hash = hash * 59 + this.CartaoMascarado.GetHashCode();
                
                if (this.NomePortador != null)
                    hash = hash * 59 + this.NomePortador.GetHashCode();
                
                if (this.DataTransacao != null)
                    hash = hash * 59 + this.DataTransacao.GetHashCode();
                
                if (this.DataFaturamento != null)
                    hash = hash * 59 + this.DataFaturamento.GetHashCode();
                
                if (this.DataVencimento != null)
                    hash = hash * 59 + this.DataVencimento.GetHashCode();
                
                if (this.ModoEntradaTransacao != null)
                    hash = hash * 59 + this.ModoEntradaTransacao.GetHashCode();
                
                if (this.ValorTaxaEmbarque != null)
                    hash = hash * 59 + this.ValorTaxaEmbarque.GetHashCode();
                
                if (this.ValorEntrada != null)
                    hash = hash * 59 + this.ValorEntrada.GetHashCode();
                
                if (this.ValorBRL != null)
                    hash = hash * 59 + this.ValorBRL.GetHashCode();
                
                if (this.ValorUSD != null)
                    hash = hash * 59 + this.ValorUSD.GetHashCode();
                
                if (this.CotacaoUSD != null)
                    hash = hash * 59 + this.CotacaoUSD.GetHashCode();
                
                if (this.DataCotacaoUSD != null)
                    hash = hash * 59 + this.DataCotacaoUSD.GetHashCode();
                
                if (this.CodigoMoedaOrigem != null)
                    hash = hash * 59 + this.CodigoMoedaOrigem.GetHashCode();
                
                if (this.CodigoMoedaDestino != null)
                    hash = hash * 59 + this.CodigoMoedaDestino.GetHashCode();
                
                if (this.CodigoAutorizacao != null)
                    hash = hash * 59 + this.CodigoAutorizacao.GetHashCode();
                
                if (this.CodigoReferencia != null)
                    hash = hash * 59 + this.CodigoReferencia.GetHashCode();
                
                if (this.CodigoTerminal != null)
                    hash = hash * 59 + this.CodigoTerminal.GetHashCode();
                
                if (this.CodigoMCC != null)
                    hash = hash * 59 + this.CodigoMCC.GetHashCode();
                
                if (this.GrupoMCC != null)
                    hash = hash * 59 + this.GrupoMCC.GetHashCode();
                
                if (this.GrupoDescricaoMCC != null)
                    hash = hash * 59 + this.GrupoDescricaoMCC.GetHashCode();
                
                if (this.IdEstabelecimento != null)
                    hash = hash * 59 + this.IdEstabelecimento.GetHashCode();
                
                if (this.NomeEstabelecimento != null)
                    hash = hash * 59 + this.NomeEstabelecimento.GetHashCode();
                
                if (this.NomeFantasiaEstabelecimento != null)
                    hash = hash * 59 + this.NomeFantasiaEstabelecimento.GetHashCode();
                
                if (this.LocalidadeEstabelecimento != null)
                    hash = hash * 59 + this.LocalidadeEstabelecimento.GetHashCode();
                
                if (this.PlanoParcelamento != null)
                    hash = hash * 59 + this.PlanoParcelamento.GetHashCode();
                
                if (this.NumeroParcela != null)
                    hash = hash * 59 + this.NumeroParcela.GetHashCode();
                
                if (this.DetalhesTransacao != null)
                    hash = hash * 59 + this.DetalhesTransacao.GetHashCode();
                
                if (this.FlagCredito != null)
                    hash = hash * 59 + this.FlagCredito.GetHashCode();
                
                if (this.FlagFaturado != null)
                    hash = hash * 59 + this.FlagFaturado.GetHashCode();
                
                if (this.FlagEstorno != null)
                    hash = hash * 59 + this.FlagEstorno.GetHashCode();
                
                if (this.IdTransacaoEstorno != null)
                    hash = hash * 59 + this.IdTransacaoEstorno.GetHashCode();
                
                return hash;
            }
        }

    }
}
