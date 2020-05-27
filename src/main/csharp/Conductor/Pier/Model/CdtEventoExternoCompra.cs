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
    /// 
    /// </summary>
    [DataContract]
    public partial class CdtEventoExternoCompra :  IEquatable<CdtEventoExternoCompra>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CdtEventoExternoCompra" /> class.
        /// Initializes a new instance of the <see cref="CdtEventoExternoCompra" />class.
        /// </summary>
        /// <param name="AcquireReferenceNumber">AcquireReferenceNumber.</param>
        /// <param name="Autorizacao">Autorizacao.</param>
        /// <param name="Carencia">Carencia.</param>
        /// <param name="Cartao">Cartao.</param>
        /// <param name="CodigoAutorizacao">CodigoAutorizacao.</param>
        /// <param name="DataCompra">DataCompra.</param>
        /// <param name="DataEntradaCompra">DataEntradaCompra.</param>
        /// <param name="DataFinanciamento">DataFinanciamento.</param>
        /// <param name="DataMovimento">DataMovimento.</param>
        /// <param name="DataVencimentoCompraFinal">DataVencimentoCompraFinal.</param>
        /// <param name="DataVencimentoCompraInicial">DataVencimentoCompraInicial.</param>
        /// <param name="DataVencimentoPadrao">DataVencimentoPadrao.</param>
        /// <param name="DataVencimentoReal">DataVencimentoReal.</param>
        /// <param name="Descricao">Descricao.</param>
        /// <param name="DvnumeroEstabelecimento">DvnumeroEstabelecimento.</param>
        /// <param name="FatorBancoAjustado">FatorBancoAjustado.</param>
        /// <param name="FatorComissaoGarantia">FatorComissaoGarantia.</param>
        /// <param name="FatorTaxaAdministracao">FatorTaxaAdministracao.</param>
        /// <param name="FatorTotal">FatorTotal.</param>
        /// <param name="FatorTotalAjustado">FatorTotalAjustado.</param>
        /// <param name="FlagRefinanciamento">FlagRefinanciamento.</param>
        /// <param name="FlagSelecionado">FlagSelecionado.</param>
        /// <param name="Id">Id.</param>
        /// <param name="IdCartao">IdCartao.</param>
        /// <param name="IdConta">IdConta.</param>
        /// <param name="IdContaPortador">IdContaPortador.</param>
        /// <param name="IdCredor">IdCredor.</param>
        /// <param name="IdEstabelecimento">IdEstabelecimento.</param>
        /// <param name="IdEstabelecimentoExterno">IdEstabelecimentoExterno.</param>
        /// <param name="IdEstabelecimentoVISA">IdEstabelecimentoVISA.</param>
        /// <param name="IdIncoming">IdIncoming.</param>
        /// <param name="IdMovimento">IdMovimento.</param>
        /// <param name="IdOrigem">IdOrigem.</param>
        /// <param name="IdRemessa">IdRemessa.</param>
        /// <param name="Lote">Lote.</param>
        /// <param name="Mcc">Mcc.</param>
        /// <param name="NomeEstabelecimentoVISA">NomeEstabelecimentoVISA.</param>
        /// <param name="NumeroContrato">NumeroContrato.</param>
        /// <param name="NumeroEstabelecimento">NumeroEstabelecimento.</param>
        /// <param name="NumeroParcelas">NumeroParcelas.</param>
        /// <param name="Operacao">Operacao.</param>
        /// <param name="Origem">Origem.</param>
        /// <param name="OrigemResolucao">OrigemResolucao.</param>
        /// <param name="QuantidadeMoeda">QuantidadeMoeda.</param>
        /// <param name="Status">Status.</param>
        /// <param name="TaxaJuros">TaxaJuros.</param>
        /// <param name="TipoCalculoPrestacao">TipoCalculoPrestacao.</param>
        /// <param name="TipoCompra">TipoCompra.</param>
        /// <param name="TipoEntrada">TipoEntrada.</param>
        /// <param name="TipoLiquidacao">TipoLiquidacao.</param>
        /// <param name="TipoPagamento">TipoPagamento.</param>
        /// <param name="ValorAgenciamento">ValorAgenciamento.</param>
        /// <param name="ValorComissao">ValorComissao.</param>
        /// <param name="ValorCompra">ValorCompra.</param>
        /// <param name="ValorContrato">ValorContrato.</param>
        /// <param name="ValorEncargosBancarios">ValorEncargosBancarios.</param>
        /// <param name="ValorEncargosTotais">ValorEncargosTotais.</param>
        /// <param name="ValorEntrada">ValorEntrada.</param>
        /// <param name="ValorGarantias">ValorGarantias.</param>
        /// <param name="ValorIOF">ValorIOF.</param>
        /// <param name="ValorLiquido">ValorLiquido.</param>
        /// <param name="ValorOrigem">ValorOrigem.</param>
        /// <param name="ValorParcela">ValorParcela.</param>
        /// <param name="ValorTAC">ValorTAC.</param>

        public CdtEventoExternoCompra(string AcquireReferenceNumber = null, CdtAutorizacao Autorizacao = null, int? Carencia = null, string Cartao = null, string CodigoAutorizacao = null, string DataCompra = null, string DataEntradaCompra = null, string DataFinanciamento = null, string DataMovimento = null, string DataVencimentoCompraFinal = null, string DataVencimentoCompraInicial = null, string DataVencimentoPadrao = null, string DataVencimentoReal = null, string Descricao = null, int? DvnumeroEstabelecimento = null, double? FatorBancoAjustado = null, double? FatorComissaoGarantia = null, double? FatorTaxaAdministracao = null, double? FatorTotal = null, double? FatorTotalAjustado = null, bool? FlagRefinanciamento = null, bool? FlagSelecionado = null, long? Id = null, long? IdCartao = null, long? IdConta = null, long? IdContaPortador = null, long? IdCredor = null, long? IdEstabelecimento = null, long? IdEstabelecimentoExterno = null, long? IdEstabelecimentoVISA = null, long? IdIncoming = null, long? IdMovimento = null, long? IdOrigem = null, long? IdRemessa = null, int? Lote = null, long? Mcc = null, string NomeEstabelecimentoVISA = null, string NumeroContrato = null, int? NumeroEstabelecimento = null, int? NumeroParcelas = null, CdtTipoOperacao Operacao = null, string Origem = null, string OrigemResolucao = null, double? QuantidadeMoeda = null, long? Status = null, double? TaxaJuros = null, int? TipoCalculoPrestacao = null, int? TipoCompra = null, string TipoEntrada = null, int? TipoLiquidacao = null, int? TipoPagamento = null, double? ValorAgenciamento = null, double? ValorComissao = null, double? ValorCompra = null, double? ValorContrato = null, double? ValorEncargosBancarios = null, double? ValorEncargosTotais = null, double? ValorEntrada = null, double? ValorGarantias = null, double? ValorIOF = null, double? ValorLiquido = null, double? ValorOrigem = null, double? ValorParcela = null, double? ValorTAC = null)
        {
            this.AcquireReferenceNumber = AcquireReferenceNumber;
            this.Autorizacao = Autorizacao;
            this.Carencia = Carencia;
            this.Cartao = Cartao;
            this.CodigoAutorizacao = CodigoAutorizacao;
            this.DataCompra = DataCompra;
            this.DataEntradaCompra = DataEntradaCompra;
            this.DataFinanciamento = DataFinanciamento;
            this.DataMovimento = DataMovimento;
            this.DataVencimentoCompraFinal = DataVencimentoCompraFinal;
            this.DataVencimentoCompraInicial = DataVencimentoCompraInicial;
            this.DataVencimentoPadrao = DataVencimentoPadrao;
            this.DataVencimentoReal = DataVencimentoReal;
            this.Descricao = Descricao;
            this.DvnumeroEstabelecimento = DvnumeroEstabelecimento;
            this.FatorBancoAjustado = FatorBancoAjustado;
            this.FatorComissaoGarantia = FatorComissaoGarantia;
            this.FatorTaxaAdministracao = FatorTaxaAdministracao;
            this.FatorTotal = FatorTotal;
            this.FatorTotalAjustado = FatorTotalAjustado;
            this.FlagRefinanciamento = FlagRefinanciamento;
            this.FlagSelecionado = FlagSelecionado;
            this.Id = Id;
            this.IdCartao = IdCartao;
            this.IdConta = IdConta;
            this.IdContaPortador = IdContaPortador;
            this.IdCredor = IdCredor;
            this.IdEstabelecimento = IdEstabelecimento;
            this.IdEstabelecimentoExterno = IdEstabelecimentoExterno;
            this.IdEstabelecimentoVISA = IdEstabelecimentoVISA;
            this.IdIncoming = IdIncoming;
            this.IdMovimento = IdMovimento;
            this.IdOrigem = IdOrigem;
            this.IdRemessa = IdRemessa;
            this.Lote = Lote;
            this.Mcc = Mcc;
            this.NomeEstabelecimentoVISA = NomeEstabelecimentoVISA;
            this.NumeroContrato = NumeroContrato;
            this.NumeroEstabelecimento = NumeroEstabelecimento;
            this.NumeroParcelas = NumeroParcelas;
            this.Operacao = Operacao;
            this.Origem = Origem;
            this.OrigemResolucao = OrigemResolucao;
            this.QuantidadeMoeda = QuantidadeMoeda;
            this.Status = Status;
            this.TaxaJuros = TaxaJuros;
            this.TipoCalculoPrestacao = TipoCalculoPrestacao;
            this.TipoCompra = TipoCompra;
            this.TipoEntrada = TipoEntrada;
            this.TipoLiquidacao = TipoLiquidacao;
            this.TipoPagamento = TipoPagamento;
            this.ValorAgenciamento = ValorAgenciamento;
            this.ValorComissao = ValorComissao;
            this.ValorCompra = ValorCompra;
            this.ValorContrato = ValorContrato;
            this.ValorEncargosBancarios = ValorEncargosBancarios;
            this.ValorEncargosTotais = ValorEncargosTotais;
            this.ValorEntrada = ValorEntrada;
            this.ValorGarantias = ValorGarantias;
            this.ValorIOF = ValorIOF;
            this.ValorLiquido = ValorLiquido;
            this.ValorOrigem = ValorOrigem;
            this.ValorParcela = ValorParcela;
            this.ValorTAC = ValorTAC;
            
        }
        
    
        /// <summary>
        /// Gets or Sets AcquireReferenceNumber
        /// </summary>
        [DataMember(Name="acquireReferenceNumber", EmitDefaultValue=false)]
        public string AcquireReferenceNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets Autorizacao
        /// </summary>
        [DataMember(Name="autorizacao", EmitDefaultValue=false)]
        public CdtAutorizacao Autorizacao { get; set; }
    
        /// <summary>
        /// Gets or Sets Carencia
        /// </summary>
        [DataMember(Name="carencia", EmitDefaultValue=false)]
        public int? Carencia { get; set; }
    
        /// <summary>
        /// Gets or Sets Cartao
        /// </summary>
        [DataMember(Name="cartao", EmitDefaultValue=false)]
        public string Cartao { get; set; }
    
        /// <summary>
        /// Gets or Sets CodigoAutorizacao
        /// </summary>
        [DataMember(Name="codigoAutorizacao", EmitDefaultValue=false)]
        public string CodigoAutorizacao { get; set; }
    
        /// <summary>
        /// Gets or Sets DataCompra
        /// </summary>
        [DataMember(Name="dataCompra", EmitDefaultValue=false)]
        public string DataCompra { get; set; }
    
        /// <summary>
        /// Gets or Sets DataEntradaCompra
        /// </summary>
        [DataMember(Name="dataEntradaCompra", EmitDefaultValue=false)]
        public string DataEntradaCompra { get; set; }
    
        /// <summary>
        /// Gets or Sets DataFinanciamento
        /// </summary>
        [DataMember(Name="dataFinanciamento", EmitDefaultValue=false)]
        public string DataFinanciamento { get; set; }
    
        /// <summary>
        /// Gets or Sets DataMovimento
        /// </summary>
        [DataMember(Name="dataMovimento", EmitDefaultValue=false)]
        public string DataMovimento { get; set; }
    
        /// <summary>
        /// Gets or Sets DataVencimentoCompraFinal
        /// </summary>
        [DataMember(Name="dataVencimentoCompraFinal", EmitDefaultValue=false)]
        public string DataVencimentoCompraFinal { get; set; }
    
        /// <summary>
        /// Gets or Sets DataVencimentoCompraInicial
        /// </summary>
        [DataMember(Name="dataVencimentoCompraInicial", EmitDefaultValue=false)]
        public string DataVencimentoCompraInicial { get; set; }
    
        /// <summary>
        /// Gets or Sets DataVencimentoPadrao
        /// </summary>
        [DataMember(Name="dataVencimentoPadrao", EmitDefaultValue=false)]
        public string DataVencimentoPadrao { get; set; }
    
        /// <summary>
        /// Gets or Sets DataVencimentoReal
        /// </summary>
        [DataMember(Name="dataVencimentoReal", EmitDefaultValue=false)]
        public string DataVencimentoReal { get; set; }
    
        /// <summary>
        /// Gets or Sets Descricao
        /// </summary>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Gets or Sets DvnumeroEstabelecimento
        /// </summary>
        [DataMember(Name="dvnumeroEstabelecimento", EmitDefaultValue=false)]
        public int? DvnumeroEstabelecimento { get; set; }
    
        /// <summary>
        /// Gets or Sets FatorBancoAjustado
        /// </summary>
        [DataMember(Name="fatorBancoAjustado", EmitDefaultValue=false)]
        public double? FatorBancoAjustado { get; set; }
    
        /// <summary>
        /// Gets or Sets FatorComissaoGarantia
        /// </summary>
        [DataMember(Name="fatorComissaoGarantia", EmitDefaultValue=false)]
        public double? FatorComissaoGarantia { get; set; }
    
        /// <summary>
        /// Gets or Sets FatorTaxaAdministracao
        /// </summary>
        [DataMember(Name="fatorTaxaAdministracao", EmitDefaultValue=false)]
        public double? FatorTaxaAdministracao { get; set; }
    
        /// <summary>
        /// Gets or Sets FatorTotal
        /// </summary>
        [DataMember(Name="fatorTotal", EmitDefaultValue=false)]
        public double? FatorTotal { get; set; }
    
        /// <summary>
        /// Gets or Sets FatorTotalAjustado
        /// </summary>
        [DataMember(Name="fatorTotalAjustado", EmitDefaultValue=false)]
        public double? FatorTotalAjustado { get; set; }
    
        /// <summary>
        /// Gets or Sets FlagRefinanciamento
        /// </summary>
        [DataMember(Name="flagRefinanciamento", EmitDefaultValue=false)]
        public bool? FlagRefinanciamento { get; set; }
    
        /// <summary>
        /// Gets or Sets FlagSelecionado
        /// </summary>
        [DataMember(Name="flagSelecionado", EmitDefaultValue=false)]
        public bool? FlagSelecionado { get; set; }
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Gets or Sets IdCartao
        /// </summary>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// Gets or Sets IdConta
        /// </summary>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Gets or Sets IdContaPortador
        /// </summary>
        [DataMember(Name="idContaPortador", EmitDefaultValue=false)]
        public long? IdContaPortador { get; set; }
    
        /// <summary>
        /// Gets or Sets IdCredor
        /// </summary>
        [DataMember(Name="idCredor", EmitDefaultValue=false)]
        public long? IdCredor { get; set; }
    
        /// <summary>
        /// Gets or Sets IdEstabelecimento
        /// </summary>
        [DataMember(Name="idEstabelecimento", EmitDefaultValue=false)]
        public long? IdEstabelecimento { get; set; }
    
        /// <summary>
        /// Gets or Sets IdEstabelecimentoExterno
        /// </summary>
        [DataMember(Name="idEstabelecimentoExterno", EmitDefaultValue=false)]
        public long? IdEstabelecimentoExterno { get; set; }
    
        /// <summary>
        /// Gets or Sets IdEstabelecimentoVISA
        /// </summary>
        [DataMember(Name="idEstabelecimentoVISA", EmitDefaultValue=false)]
        public long? IdEstabelecimentoVISA { get; set; }
    
        /// <summary>
        /// Gets or Sets IdIncoming
        /// </summary>
        [DataMember(Name="idIncoming", EmitDefaultValue=false)]
        public long? IdIncoming { get; set; }
    
        /// <summary>
        /// Gets or Sets IdMovimento
        /// </summary>
        [DataMember(Name="idMovimento", EmitDefaultValue=false)]
        public long? IdMovimento { get; set; }
    
        /// <summary>
        /// Gets or Sets IdOrigem
        /// </summary>
        [DataMember(Name="idOrigem", EmitDefaultValue=false)]
        public long? IdOrigem { get; set; }
    
        /// <summary>
        /// Gets or Sets IdRemessa
        /// </summary>
        [DataMember(Name="idRemessa", EmitDefaultValue=false)]
        public long? IdRemessa { get; set; }
    
        /// <summary>
        /// Gets or Sets Lote
        /// </summary>
        [DataMember(Name="lote", EmitDefaultValue=false)]
        public int? Lote { get; set; }
    
        /// <summary>
        /// Gets or Sets Mcc
        /// </summary>
        [DataMember(Name="mcc", EmitDefaultValue=false)]
        public long? Mcc { get; set; }
    
        /// <summary>
        /// Gets or Sets NomeEstabelecimentoVISA
        /// </summary>
        [DataMember(Name="nomeEstabelecimentoVISA", EmitDefaultValue=false)]
        public string NomeEstabelecimentoVISA { get; set; }
    
        /// <summary>
        /// Gets or Sets NumeroContrato
        /// </summary>
        [DataMember(Name="numeroContrato", EmitDefaultValue=false)]
        public string NumeroContrato { get; set; }
    
        /// <summary>
        /// Gets or Sets NumeroEstabelecimento
        /// </summary>
        [DataMember(Name="numeroEstabelecimento", EmitDefaultValue=false)]
        public int? NumeroEstabelecimento { get; set; }
    
        /// <summary>
        /// Gets or Sets NumeroParcelas
        /// </summary>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public int? NumeroParcelas { get; set; }
    
        /// <summary>
        /// Gets or Sets Operacao
        /// </summary>
        [DataMember(Name="operacao", EmitDefaultValue=false)]
        public CdtTipoOperacao Operacao { get; set; }
    
        /// <summary>
        /// Gets or Sets Origem
        /// </summary>
        [DataMember(Name="origem", EmitDefaultValue=false)]
        public string Origem { get; set; }
    
        /// <summary>
        /// Gets or Sets OrigemResolucao
        /// </summary>
        [DataMember(Name="origemResolucao", EmitDefaultValue=false)]
        public string OrigemResolucao { get; set; }
    
        /// <summary>
        /// Gets or Sets QuantidadeMoeda
        /// </summary>
        [DataMember(Name="quantidadeMoeda", EmitDefaultValue=false)]
        public double? QuantidadeMoeda { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public long? Status { get; set; }
    
        /// <summary>
        /// Gets or Sets TaxaJuros
        /// </summary>
        [DataMember(Name="taxaJuros", EmitDefaultValue=false)]
        public double? TaxaJuros { get; set; }
    
        /// <summary>
        /// Gets or Sets TipoCalculoPrestacao
        /// </summary>
        [DataMember(Name="tipoCalculoPrestacao", EmitDefaultValue=false)]
        public int? TipoCalculoPrestacao { get; set; }
    
        /// <summary>
        /// Gets or Sets TipoCompra
        /// </summary>
        [DataMember(Name="tipoCompra", EmitDefaultValue=false)]
        public int? TipoCompra { get; set; }
    
        /// <summary>
        /// Gets or Sets TipoEntrada
        /// </summary>
        [DataMember(Name="tipoEntrada", EmitDefaultValue=false)]
        public string TipoEntrada { get; set; }
    
        /// <summary>
        /// Gets or Sets TipoLiquidacao
        /// </summary>
        [DataMember(Name="tipoLiquidacao", EmitDefaultValue=false)]
        public int? TipoLiquidacao { get; set; }
    
        /// <summary>
        /// Gets or Sets TipoPagamento
        /// </summary>
        [DataMember(Name="tipoPagamento", EmitDefaultValue=false)]
        public int? TipoPagamento { get; set; }
    
        /// <summary>
        /// Gets or Sets ValorAgenciamento
        /// </summary>
        [DataMember(Name="valorAgenciamento", EmitDefaultValue=false)]
        public double? ValorAgenciamento { get; set; }
    
        /// <summary>
        /// Gets or Sets ValorComissao
        /// </summary>
        [DataMember(Name="valorComissao", EmitDefaultValue=false)]
        public double? ValorComissao { get; set; }
    
        /// <summary>
        /// Gets or Sets ValorCompra
        /// </summary>
        [DataMember(Name="valorCompra", EmitDefaultValue=false)]
        public double? ValorCompra { get; set; }
    
        /// <summary>
        /// Gets or Sets ValorContrato
        /// </summary>
        [DataMember(Name="valorContrato", EmitDefaultValue=false)]
        public double? ValorContrato { get; set; }
    
        /// <summary>
        /// Gets or Sets ValorEncargosBancarios
        /// </summary>
        [DataMember(Name="valorEncargosBancarios", EmitDefaultValue=false)]
        public double? ValorEncargosBancarios { get; set; }
    
        /// <summary>
        /// Gets or Sets ValorEncargosTotais
        /// </summary>
        [DataMember(Name="valorEncargosTotais", EmitDefaultValue=false)]
        public double? ValorEncargosTotais { get; set; }
    
        /// <summary>
        /// Gets or Sets ValorEntrada
        /// </summary>
        [DataMember(Name="valorEntrada", EmitDefaultValue=false)]
        public double? ValorEntrada { get; set; }
    
        /// <summary>
        /// Gets or Sets ValorGarantias
        /// </summary>
        [DataMember(Name="valorGarantias", EmitDefaultValue=false)]
        public double? ValorGarantias { get; set; }
    
        /// <summary>
        /// Gets or Sets ValorIOF
        /// </summary>
        [DataMember(Name="valorIOF", EmitDefaultValue=false)]
        public double? ValorIOF { get; set; }
    
        /// <summary>
        /// Gets or Sets ValorLiquido
        /// </summary>
        [DataMember(Name="valorLiquido", EmitDefaultValue=false)]
        public double? ValorLiquido { get; set; }
    
        /// <summary>
        /// Gets or Sets ValorOrigem
        /// </summary>
        [DataMember(Name="valorOrigem", EmitDefaultValue=false)]
        public double? ValorOrigem { get; set; }
    
        /// <summary>
        /// Gets or Sets ValorParcela
        /// </summary>
        [DataMember(Name="valorParcela", EmitDefaultValue=false)]
        public double? ValorParcela { get; set; }
    
        /// <summary>
        /// Gets or Sets ValorTAC
        /// </summary>
        [DataMember(Name="valorTAC", EmitDefaultValue=false)]
        public double? ValorTAC { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CdtEventoExternoCompra {\n");
            sb.Append("  AcquireReferenceNumber: ").Append(AcquireReferenceNumber).Append("\n");
            sb.Append("  Autorizacao: ").Append(Autorizacao).Append("\n");
            sb.Append("  Carencia: ").Append(Carencia).Append("\n");
            sb.Append("  Cartao: ").Append(Cartao).Append("\n");
            sb.Append("  CodigoAutorizacao: ").Append(CodigoAutorizacao).Append("\n");
            sb.Append("  DataCompra: ").Append(DataCompra).Append("\n");
            sb.Append("  DataEntradaCompra: ").Append(DataEntradaCompra).Append("\n");
            sb.Append("  DataFinanciamento: ").Append(DataFinanciamento).Append("\n");
            sb.Append("  DataMovimento: ").Append(DataMovimento).Append("\n");
            sb.Append("  DataVencimentoCompraFinal: ").Append(DataVencimentoCompraFinal).Append("\n");
            sb.Append("  DataVencimentoCompraInicial: ").Append(DataVencimentoCompraInicial).Append("\n");
            sb.Append("  DataVencimentoPadrao: ").Append(DataVencimentoPadrao).Append("\n");
            sb.Append("  DataVencimentoReal: ").Append(DataVencimentoReal).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  DvnumeroEstabelecimento: ").Append(DvnumeroEstabelecimento).Append("\n");
            sb.Append("  FatorBancoAjustado: ").Append(FatorBancoAjustado).Append("\n");
            sb.Append("  FatorComissaoGarantia: ").Append(FatorComissaoGarantia).Append("\n");
            sb.Append("  FatorTaxaAdministracao: ").Append(FatorTaxaAdministracao).Append("\n");
            sb.Append("  FatorTotal: ").Append(FatorTotal).Append("\n");
            sb.Append("  FatorTotalAjustado: ").Append(FatorTotalAjustado).Append("\n");
            sb.Append("  FlagRefinanciamento: ").Append(FlagRefinanciamento).Append("\n");
            sb.Append("  FlagSelecionado: ").Append(FlagSelecionado).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdContaPortador: ").Append(IdContaPortador).Append("\n");
            sb.Append("  IdCredor: ").Append(IdCredor).Append("\n");
            sb.Append("  IdEstabelecimento: ").Append(IdEstabelecimento).Append("\n");
            sb.Append("  IdEstabelecimentoExterno: ").Append(IdEstabelecimentoExterno).Append("\n");
            sb.Append("  IdEstabelecimentoVISA: ").Append(IdEstabelecimentoVISA).Append("\n");
            sb.Append("  IdIncoming: ").Append(IdIncoming).Append("\n");
            sb.Append("  IdMovimento: ").Append(IdMovimento).Append("\n");
            sb.Append("  IdOrigem: ").Append(IdOrigem).Append("\n");
            sb.Append("  IdRemessa: ").Append(IdRemessa).Append("\n");
            sb.Append("  Lote: ").Append(Lote).Append("\n");
            sb.Append("  Mcc: ").Append(Mcc).Append("\n");
            sb.Append("  NomeEstabelecimentoVISA: ").Append(NomeEstabelecimentoVISA).Append("\n");
            sb.Append("  NumeroContrato: ").Append(NumeroContrato).Append("\n");
            sb.Append("  NumeroEstabelecimento: ").Append(NumeroEstabelecimento).Append("\n");
            sb.Append("  NumeroParcelas: ").Append(NumeroParcelas).Append("\n");
            sb.Append("  Operacao: ").Append(Operacao).Append("\n");
            sb.Append("  Origem: ").Append(Origem).Append("\n");
            sb.Append("  OrigemResolucao: ").Append(OrigemResolucao).Append("\n");
            sb.Append("  QuantidadeMoeda: ").Append(QuantidadeMoeda).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TaxaJuros: ").Append(TaxaJuros).Append("\n");
            sb.Append("  TipoCalculoPrestacao: ").Append(TipoCalculoPrestacao).Append("\n");
            sb.Append("  TipoCompra: ").Append(TipoCompra).Append("\n");
            sb.Append("  TipoEntrada: ").Append(TipoEntrada).Append("\n");
            sb.Append("  TipoLiquidacao: ").Append(TipoLiquidacao).Append("\n");
            sb.Append("  TipoPagamento: ").Append(TipoPagamento).Append("\n");
            sb.Append("  ValorAgenciamento: ").Append(ValorAgenciamento).Append("\n");
            sb.Append("  ValorComissao: ").Append(ValorComissao).Append("\n");
            sb.Append("  ValorCompra: ").Append(ValorCompra).Append("\n");
            sb.Append("  ValorContrato: ").Append(ValorContrato).Append("\n");
            sb.Append("  ValorEncargosBancarios: ").Append(ValorEncargosBancarios).Append("\n");
            sb.Append("  ValorEncargosTotais: ").Append(ValorEncargosTotais).Append("\n");
            sb.Append("  ValorEntrada: ").Append(ValorEntrada).Append("\n");
            sb.Append("  ValorGarantias: ").Append(ValorGarantias).Append("\n");
            sb.Append("  ValorIOF: ").Append(ValorIOF).Append("\n");
            sb.Append("  ValorLiquido: ").Append(ValorLiquido).Append("\n");
            sb.Append("  ValorOrigem: ").Append(ValorOrigem).Append("\n");
            sb.Append("  ValorParcela: ").Append(ValorParcela).Append("\n");
            sb.Append("  ValorTAC: ").Append(ValorTAC).Append("\n");
            
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
            return this.Equals(obj as CdtEventoExternoCompra);
        }

        /// <summary>
        /// Returns true if CdtEventoExternoCompra instances are equal
        /// </summary>
        /// <param name="other">Instance of CdtEventoExternoCompra to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CdtEventoExternoCompra other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AcquireReferenceNumber == other.AcquireReferenceNumber ||
                    this.AcquireReferenceNumber != null &&
                    this.AcquireReferenceNumber.Equals(other.AcquireReferenceNumber)
                ) && 
                (
                    this.Autorizacao == other.Autorizacao ||
                    this.Autorizacao != null &&
                    this.Autorizacao.Equals(other.Autorizacao)
                ) && 
                (
                    this.Carencia == other.Carencia ||
                    this.Carencia != null &&
                    this.Carencia.Equals(other.Carencia)
                ) && 
                (
                    this.Cartao == other.Cartao ||
                    this.Cartao != null &&
                    this.Cartao.Equals(other.Cartao)
                ) && 
                (
                    this.CodigoAutorizacao == other.CodigoAutorizacao ||
                    this.CodigoAutorizacao != null &&
                    this.CodigoAutorizacao.Equals(other.CodigoAutorizacao)
                ) && 
                (
                    this.DataCompra == other.DataCompra ||
                    this.DataCompra != null &&
                    this.DataCompra.Equals(other.DataCompra)
                ) && 
                (
                    this.DataEntradaCompra == other.DataEntradaCompra ||
                    this.DataEntradaCompra != null &&
                    this.DataEntradaCompra.Equals(other.DataEntradaCompra)
                ) && 
                (
                    this.DataFinanciamento == other.DataFinanciamento ||
                    this.DataFinanciamento != null &&
                    this.DataFinanciamento.Equals(other.DataFinanciamento)
                ) && 
                (
                    this.DataMovimento == other.DataMovimento ||
                    this.DataMovimento != null &&
                    this.DataMovimento.Equals(other.DataMovimento)
                ) && 
                (
                    this.DataVencimentoCompraFinal == other.DataVencimentoCompraFinal ||
                    this.DataVencimentoCompraFinal != null &&
                    this.DataVencimentoCompraFinal.Equals(other.DataVencimentoCompraFinal)
                ) && 
                (
                    this.DataVencimentoCompraInicial == other.DataVencimentoCompraInicial ||
                    this.DataVencimentoCompraInicial != null &&
                    this.DataVencimentoCompraInicial.Equals(other.DataVencimentoCompraInicial)
                ) && 
                (
                    this.DataVencimentoPadrao == other.DataVencimentoPadrao ||
                    this.DataVencimentoPadrao != null &&
                    this.DataVencimentoPadrao.Equals(other.DataVencimentoPadrao)
                ) && 
                (
                    this.DataVencimentoReal == other.DataVencimentoReal ||
                    this.DataVencimentoReal != null &&
                    this.DataVencimentoReal.Equals(other.DataVencimentoReal)
                ) && 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.DvnumeroEstabelecimento == other.DvnumeroEstabelecimento ||
                    this.DvnumeroEstabelecimento != null &&
                    this.DvnumeroEstabelecimento.Equals(other.DvnumeroEstabelecimento)
                ) && 
                (
                    this.FatorBancoAjustado == other.FatorBancoAjustado ||
                    this.FatorBancoAjustado != null &&
                    this.FatorBancoAjustado.Equals(other.FatorBancoAjustado)
                ) && 
                (
                    this.FatorComissaoGarantia == other.FatorComissaoGarantia ||
                    this.FatorComissaoGarantia != null &&
                    this.FatorComissaoGarantia.Equals(other.FatorComissaoGarantia)
                ) && 
                (
                    this.FatorTaxaAdministracao == other.FatorTaxaAdministracao ||
                    this.FatorTaxaAdministracao != null &&
                    this.FatorTaxaAdministracao.Equals(other.FatorTaxaAdministracao)
                ) && 
                (
                    this.FatorTotal == other.FatorTotal ||
                    this.FatorTotal != null &&
                    this.FatorTotal.Equals(other.FatorTotal)
                ) && 
                (
                    this.FatorTotalAjustado == other.FatorTotalAjustado ||
                    this.FatorTotalAjustado != null &&
                    this.FatorTotalAjustado.Equals(other.FatorTotalAjustado)
                ) && 
                (
                    this.FlagRefinanciamento == other.FlagRefinanciamento ||
                    this.FlagRefinanciamento != null &&
                    this.FlagRefinanciamento.Equals(other.FlagRefinanciamento)
                ) && 
                (
                    this.FlagSelecionado == other.FlagSelecionado ||
                    this.FlagSelecionado != null &&
                    this.FlagSelecionado.Equals(other.FlagSelecionado)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdContaPortador == other.IdContaPortador ||
                    this.IdContaPortador != null &&
                    this.IdContaPortador.Equals(other.IdContaPortador)
                ) && 
                (
                    this.IdCredor == other.IdCredor ||
                    this.IdCredor != null &&
                    this.IdCredor.Equals(other.IdCredor)
                ) && 
                (
                    this.IdEstabelecimento == other.IdEstabelecimento ||
                    this.IdEstabelecimento != null &&
                    this.IdEstabelecimento.Equals(other.IdEstabelecimento)
                ) && 
                (
                    this.IdEstabelecimentoExterno == other.IdEstabelecimentoExterno ||
                    this.IdEstabelecimentoExterno != null &&
                    this.IdEstabelecimentoExterno.Equals(other.IdEstabelecimentoExterno)
                ) && 
                (
                    this.IdEstabelecimentoVISA == other.IdEstabelecimentoVISA ||
                    this.IdEstabelecimentoVISA != null &&
                    this.IdEstabelecimentoVISA.Equals(other.IdEstabelecimentoVISA)
                ) && 
                (
                    this.IdIncoming == other.IdIncoming ||
                    this.IdIncoming != null &&
                    this.IdIncoming.Equals(other.IdIncoming)
                ) && 
                (
                    this.IdMovimento == other.IdMovimento ||
                    this.IdMovimento != null &&
                    this.IdMovimento.Equals(other.IdMovimento)
                ) && 
                (
                    this.IdOrigem == other.IdOrigem ||
                    this.IdOrigem != null &&
                    this.IdOrigem.Equals(other.IdOrigem)
                ) && 
                (
                    this.IdRemessa == other.IdRemessa ||
                    this.IdRemessa != null &&
                    this.IdRemessa.Equals(other.IdRemessa)
                ) && 
                (
                    this.Lote == other.Lote ||
                    this.Lote != null &&
                    this.Lote.Equals(other.Lote)
                ) && 
                (
                    this.Mcc == other.Mcc ||
                    this.Mcc != null &&
                    this.Mcc.Equals(other.Mcc)
                ) && 
                (
                    this.NomeEstabelecimentoVISA == other.NomeEstabelecimentoVISA ||
                    this.NomeEstabelecimentoVISA != null &&
                    this.NomeEstabelecimentoVISA.Equals(other.NomeEstabelecimentoVISA)
                ) && 
                (
                    this.NumeroContrato == other.NumeroContrato ||
                    this.NumeroContrato != null &&
                    this.NumeroContrato.Equals(other.NumeroContrato)
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
                    this.Operacao == other.Operacao ||
                    this.Operacao != null &&
                    this.Operacao.Equals(other.Operacao)
                ) && 
                (
                    this.Origem == other.Origem ||
                    this.Origem != null &&
                    this.Origem.Equals(other.Origem)
                ) && 
                (
                    this.OrigemResolucao == other.OrigemResolucao ||
                    this.OrigemResolucao != null &&
                    this.OrigemResolucao.Equals(other.OrigemResolucao)
                ) && 
                (
                    this.QuantidadeMoeda == other.QuantidadeMoeda ||
                    this.QuantidadeMoeda != null &&
                    this.QuantidadeMoeda.Equals(other.QuantidadeMoeda)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.TaxaJuros == other.TaxaJuros ||
                    this.TaxaJuros != null &&
                    this.TaxaJuros.Equals(other.TaxaJuros)
                ) && 
                (
                    this.TipoCalculoPrestacao == other.TipoCalculoPrestacao ||
                    this.TipoCalculoPrestacao != null &&
                    this.TipoCalculoPrestacao.Equals(other.TipoCalculoPrestacao)
                ) && 
                (
                    this.TipoCompra == other.TipoCompra ||
                    this.TipoCompra != null &&
                    this.TipoCompra.Equals(other.TipoCompra)
                ) && 
                (
                    this.TipoEntrada == other.TipoEntrada ||
                    this.TipoEntrada != null &&
                    this.TipoEntrada.Equals(other.TipoEntrada)
                ) && 
                (
                    this.TipoLiquidacao == other.TipoLiquidacao ||
                    this.TipoLiquidacao != null &&
                    this.TipoLiquidacao.Equals(other.TipoLiquidacao)
                ) && 
                (
                    this.TipoPagamento == other.TipoPagamento ||
                    this.TipoPagamento != null &&
                    this.TipoPagamento.Equals(other.TipoPagamento)
                ) && 
                (
                    this.ValorAgenciamento == other.ValorAgenciamento ||
                    this.ValorAgenciamento != null &&
                    this.ValorAgenciamento.Equals(other.ValorAgenciamento)
                ) && 
                (
                    this.ValorComissao == other.ValorComissao ||
                    this.ValorComissao != null &&
                    this.ValorComissao.Equals(other.ValorComissao)
                ) && 
                (
                    this.ValorCompra == other.ValorCompra ||
                    this.ValorCompra != null &&
                    this.ValorCompra.Equals(other.ValorCompra)
                ) && 
                (
                    this.ValorContrato == other.ValorContrato ||
                    this.ValorContrato != null &&
                    this.ValorContrato.Equals(other.ValorContrato)
                ) && 
                (
                    this.ValorEncargosBancarios == other.ValorEncargosBancarios ||
                    this.ValorEncargosBancarios != null &&
                    this.ValorEncargosBancarios.Equals(other.ValorEncargosBancarios)
                ) && 
                (
                    this.ValorEncargosTotais == other.ValorEncargosTotais ||
                    this.ValorEncargosTotais != null &&
                    this.ValorEncargosTotais.Equals(other.ValorEncargosTotais)
                ) && 
                (
                    this.ValorEntrada == other.ValorEntrada ||
                    this.ValorEntrada != null &&
                    this.ValorEntrada.Equals(other.ValorEntrada)
                ) && 
                (
                    this.ValorGarantias == other.ValorGarantias ||
                    this.ValorGarantias != null &&
                    this.ValorGarantias.Equals(other.ValorGarantias)
                ) && 
                (
                    this.ValorIOF == other.ValorIOF ||
                    this.ValorIOF != null &&
                    this.ValorIOF.Equals(other.ValorIOF)
                ) && 
                (
                    this.ValorLiquido == other.ValorLiquido ||
                    this.ValorLiquido != null &&
                    this.ValorLiquido.Equals(other.ValorLiquido)
                ) && 
                (
                    this.ValorOrigem == other.ValorOrigem ||
                    this.ValorOrigem != null &&
                    this.ValorOrigem.Equals(other.ValorOrigem)
                ) && 
                (
                    this.ValorParcela == other.ValorParcela ||
                    this.ValorParcela != null &&
                    this.ValorParcela.Equals(other.ValorParcela)
                ) && 
                (
                    this.ValorTAC == other.ValorTAC ||
                    this.ValorTAC != null &&
                    this.ValorTAC.Equals(other.ValorTAC)
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
                
                if (this.AcquireReferenceNumber != null)
                    hash = hash * 59 + this.AcquireReferenceNumber.GetHashCode();
                
                if (this.Autorizacao != null)
                    hash = hash * 59 + this.Autorizacao.GetHashCode();
                
                if (this.Carencia != null)
                    hash = hash * 59 + this.Carencia.GetHashCode();
                
                if (this.Cartao != null)
                    hash = hash * 59 + this.Cartao.GetHashCode();
                
                if (this.CodigoAutorizacao != null)
                    hash = hash * 59 + this.CodigoAutorizacao.GetHashCode();
                
                if (this.DataCompra != null)
                    hash = hash * 59 + this.DataCompra.GetHashCode();
                
                if (this.DataEntradaCompra != null)
                    hash = hash * 59 + this.DataEntradaCompra.GetHashCode();
                
                if (this.DataFinanciamento != null)
                    hash = hash * 59 + this.DataFinanciamento.GetHashCode();
                
                if (this.DataMovimento != null)
                    hash = hash * 59 + this.DataMovimento.GetHashCode();
                
                if (this.DataVencimentoCompraFinal != null)
                    hash = hash * 59 + this.DataVencimentoCompraFinal.GetHashCode();
                
                if (this.DataVencimentoCompraInicial != null)
                    hash = hash * 59 + this.DataVencimentoCompraInicial.GetHashCode();
                
                if (this.DataVencimentoPadrao != null)
                    hash = hash * 59 + this.DataVencimentoPadrao.GetHashCode();
                
                if (this.DataVencimentoReal != null)
                    hash = hash * 59 + this.DataVencimentoReal.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.DvnumeroEstabelecimento != null)
                    hash = hash * 59 + this.DvnumeroEstabelecimento.GetHashCode();
                
                if (this.FatorBancoAjustado != null)
                    hash = hash * 59 + this.FatorBancoAjustado.GetHashCode();
                
                if (this.FatorComissaoGarantia != null)
                    hash = hash * 59 + this.FatorComissaoGarantia.GetHashCode();
                
                if (this.FatorTaxaAdministracao != null)
                    hash = hash * 59 + this.FatorTaxaAdministracao.GetHashCode();
                
                if (this.FatorTotal != null)
                    hash = hash * 59 + this.FatorTotal.GetHashCode();
                
                if (this.FatorTotalAjustado != null)
                    hash = hash * 59 + this.FatorTotalAjustado.GetHashCode();
                
                if (this.FlagRefinanciamento != null)
                    hash = hash * 59 + this.FlagRefinanciamento.GetHashCode();
                
                if (this.FlagSelecionado != null)
                    hash = hash * 59 + this.FlagSelecionado.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdContaPortador != null)
                    hash = hash * 59 + this.IdContaPortador.GetHashCode();
                
                if (this.IdCredor != null)
                    hash = hash * 59 + this.IdCredor.GetHashCode();
                
                if (this.IdEstabelecimento != null)
                    hash = hash * 59 + this.IdEstabelecimento.GetHashCode();
                
                if (this.IdEstabelecimentoExterno != null)
                    hash = hash * 59 + this.IdEstabelecimentoExterno.GetHashCode();
                
                if (this.IdEstabelecimentoVISA != null)
                    hash = hash * 59 + this.IdEstabelecimentoVISA.GetHashCode();
                
                if (this.IdIncoming != null)
                    hash = hash * 59 + this.IdIncoming.GetHashCode();
                
                if (this.IdMovimento != null)
                    hash = hash * 59 + this.IdMovimento.GetHashCode();
                
                if (this.IdOrigem != null)
                    hash = hash * 59 + this.IdOrigem.GetHashCode();
                
                if (this.IdRemessa != null)
                    hash = hash * 59 + this.IdRemessa.GetHashCode();
                
                if (this.Lote != null)
                    hash = hash * 59 + this.Lote.GetHashCode();
                
                if (this.Mcc != null)
                    hash = hash * 59 + this.Mcc.GetHashCode();
                
                if (this.NomeEstabelecimentoVISA != null)
                    hash = hash * 59 + this.NomeEstabelecimentoVISA.GetHashCode();
                
                if (this.NumeroContrato != null)
                    hash = hash * 59 + this.NumeroContrato.GetHashCode();
                
                if (this.NumeroEstabelecimento != null)
                    hash = hash * 59 + this.NumeroEstabelecimento.GetHashCode();
                
                if (this.NumeroParcelas != null)
                    hash = hash * 59 + this.NumeroParcelas.GetHashCode();
                
                if (this.Operacao != null)
                    hash = hash * 59 + this.Operacao.GetHashCode();
                
                if (this.Origem != null)
                    hash = hash * 59 + this.Origem.GetHashCode();
                
                if (this.OrigemResolucao != null)
                    hash = hash * 59 + this.OrigemResolucao.GetHashCode();
                
                if (this.QuantidadeMoeda != null)
                    hash = hash * 59 + this.QuantidadeMoeda.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.TaxaJuros != null)
                    hash = hash * 59 + this.TaxaJuros.GetHashCode();
                
                if (this.TipoCalculoPrestacao != null)
                    hash = hash * 59 + this.TipoCalculoPrestacao.GetHashCode();
                
                if (this.TipoCompra != null)
                    hash = hash * 59 + this.TipoCompra.GetHashCode();
                
                if (this.TipoEntrada != null)
                    hash = hash * 59 + this.TipoEntrada.GetHashCode();
                
                if (this.TipoLiquidacao != null)
                    hash = hash * 59 + this.TipoLiquidacao.GetHashCode();
                
                if (this.TipoPagamento != null)
                    hash = hash * 59 + this.TipoPagamento.GetHashCode();
                
                if (this.ValorAgenciamento != null)
                    hash = hash * 59 + this.ValorAgenciamento.GetHashCode();
                
                if (this.ValorComissao != null)
                    hash = hash * 59 + this.ValorComissao.GetHashCode();
                
                if (this.ValorCompra != null)
                    hash = hash * 59 + this.ValorCompra.GetHashCode();
                
                if (this.ValorContrato != null)
                    hash = hash * 59 + this.ValorContrato.GetHashCode();
                
                if (this.ValorEncargosBancarios != null)
                    hash = hash * 59 + this.ValorEncargosBancarios.GetHashCode();
                
                if (this.ValorEncargosTotais != null)
                    hash = hash * 59 + this.ValorEncargosTotais.GetHashCode();
                
                if (this.ValorEntrada != null)
                    hash = hash * 59 + this.ValorEntrada.GetHashCode();
                
                if (this.ValorGarantias != null)
                    hash = hash * 59 + this.ValorGarantias.GetHashCode();
                
                if (this.ValorIOF != null)
                    hash = hash * 59 + this.ValorIOF.GetHashCode();
                
                if (this.ValorLiquido != null)
                    hash = hash * 59 + this.ValorLiquido.GetHashCode();
                
                if (this.ValorOrigem != null)
                    hash = hash * 59 + this.ValorOrigem.GetHashCode();
                
                if (this.ValorParcela != null)
                    hash = hash * 59 + this.ValorParcela.GetHashCode();
                
                if (this.ValorTAC != null)
                    hash = hash * 59 + this.ValorTAC.GetHashCode();
                
                return hash;
            }
        }

    }
}
