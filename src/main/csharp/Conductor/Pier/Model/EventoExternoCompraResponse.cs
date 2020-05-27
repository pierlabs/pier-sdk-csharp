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
    /// Objeto de retorno de um evento externo de compras n\u00E3o processadas
    /// </summary>
    [DataContract]
    public partial class EventoExternoCompraResponse :  IEquatable<EventoExternoCompraResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EventoExternoCompraResponse" /> class.
        /// Initializes a new instance of the <see cref="EventoExternoCompraResponse" />class.
        /// </summary>
        /// <param name="DvnumeroEstabelecimento">DvnumeroEstabelecimento.</param>
        /// <param name="Mcc">Mcc.</param>
        /// <param name="TipoEntrada">TipoEntrada.</param>
        /// <param name="Id">C\u00F3digo do evento.</param>
        /// <param name="IdEstabelecimento">C\u00F3digo do estabelecimento.</param>
        /// <param name="IdConta">C\u00F3digo da conta.</param>
        /// <param name="IdCartao">C\u00F3digo do cart\u00E3o.</param>
        /// <param name="Status">Status do evento.</param>
        /// <param name="NumeroParcelas">N\u00FAmero de parcelas.</param>
        /// <param name="ValorParcela">Valor da parcela.</param>
        /// <param name="ValorEntrada">Valor da primeira parcela.</param>
        /// <param name="ValorCompra">Valor da compra.</param>
        /// <param name="ValorContrato">Valor do contrato.</param>
        /// <param name="ValorEncargosTotais">Valor dos encargos totais.</param>
        /// <param name="DataCompra">Data da compra.</param>
        /// <param name="IdOperacao">C\u00F3digo do tipo de opera\u00E7\u00E3o.</param>
        /// <param name="TaxaJuros">Valor da taxa de juros.</param>
        /// <param name="ValorIOF">Valor IOF.</param>
        /// <param name="ValorTAC">Valor TAC.</param>
        /// <param name="Origem">Origem do evento.</param>
        /// <param name="DataEntradaCompra">Data de entrada do evento.</param>
        /// <param name="DataVencimentoPadrao">Data de vencimento padr\u00E3o.</param>
        /// <param name="DataVencimentoReal">Data de vencimento real.</param>
        /// <param name="Carencia">Car\u00EAncia.</param>
        /// <param name="Descricao">Descri\u00E7\u00E3o do evento.</param>
        /// <param name="Cartao">N\u00FAmero do cart\u00E3o.</param>
        /// <param name="ValorOrigem">Valor de origem.</param>
        /// <param name="IdIncoming">C\u00F3digo de entrada.</param>
        /// <param name="IdEstabelecimentoVISA">C\u00F3digo do estabelecimento VISA.</param>
        /// <param name="NomeEstabelecimentoVISA">Nome do estabelecimento VISA.</param>
        /// <param name="IdEstabelecimentoExterno">C\u00F3digo do estabelecimento externo.</param>
        /// <param name="IdAutorizacao">Identificador de autoriza\u00E7\u00E3o.</param>
        /// <param name="IdMovimento">C\u00F3digo de movimento.</param>
        /// <param name="IdRemessa">C\u00F3digo de remessa.</param>
        /// <param name="CodigoAutorizacao">C\u00F3digo de autorizac\u00E3o.</param>
        /// <param name="NumeroContrato">N\u00FAmero do contrato.</param>
        /// <param name="IdContaPortador">C\u00F3digo da conta do portador.</param>
        /// <param name="DataMovimento">Data de movimento.</param>
        /// <param name="Lote">N\u00FAmero do lote.</param>
        /// <param name="NumeroEstabelecimento">N\u00FAmero do estabelecimento.</param>
        /// <param name="QuantidadeMoeda">Quantidade de moeda.</param>
        /// <param name="FatorTotalAjustado">Fator total ajustado.</param>
        /// <param name="FatorBancoAjustado">Fator de banco ajustado.</param>
        /// <param name="FatorTaxaAdministracao">Fator da taxa de administra\u00E7\u00E3o.</param>
        /// <param name="FatorComissaoGarantia">Fator da comiss\u00E3o de garantia.</param>
        /// <param name="FatorTotal">Fator total.</param>
        /// <param name="DataFinanciamento">Data de financiamento.</param>
        /// <param name="DataVencimentoCompraInicial">Data de vencimento de compra inicial.</param>
        /// <param name="DataVencimentoCompraFinal">Data de vencimento de compra final.</param>
        /// <param name="FlagSelecionado">Flag de sele\u00E7\u00E3o.</param>
        /// <param name="FlagRefinanciamento">Flag de refinanciamento.</param>
        /// <param name="TipoCompra">Tipo de compra.</param>
        /// <param name="TipoPagamento">Tipo de pagamento.</param>
        /// <param name="TipoCalculoPrestacao">Tipo de c\u00E1lculo de presta\u00E7\u00E3o.</param>
        /// <param name="TipoLiquidacao">Tipo de liquida\u00E7\u00E3o.</param>
        /// <param name="IdCredor">C\u00F3digo do credor.</param>
        /// <param name="ValorComissao">Valor da comiss\u00E3o.</param>
        /// <param name="ValorLiquido">Valor l\u00EDquido.</param>
        /// <param name="ValorEncargosBancarios">Valor dos encargos banc\u00E1rios.</param>
        /// <param name="ValorGarantias">Valor das garantias.</param>
        /// <param name="ValorAgenciamento">Valor do agenciamento.</param>
        /// <param name="OrigemResolucao">Origem da resolu\u00E7\u00E3o.</param>
        /// <param name="IdOrigem">Identificador de origem.</param>
        /// <param name="AcquireReferenceNumber">N\u00FAmero de refer\u00EAncia de aquisi\u00E7\u00E3o.</param>
        /// <param name="Autorizacao">Informa\u00E7\u00F5es de autoriza\u00E7\u00E3o.</param>

        public EventoExternoCompraResponse(int? DvnumeroEstabelecimento = null, long? Mcc = null, string TipoEntrada = null, long? Id = null, long? IdEstabelecimento = null, long? IdConta = null, long? IdCartao = null, long? Status = null, int? NumeroParcelas = null, double? ValorParcela = null, double? ValorEntrada = null, double? ValorCompra = null, double? ValorContrato = null, double? ValorEncargosTotais = null, string DataCompra = null, long? IdOperacao = null, double? TaxaJuros = null, double? ValorIOF = null, double? ValorTAC = null, string Origem = null, string DataEntradaCompra = null, string DataVencimentoPadrao = null, string DataVencimentoReal = null, int? Carencia = null, string Descricao = null, string Cartao = null, double? ValorOrigem = null, long? IdIncoming = null, long? IdEstabelecimentoVISA = null, string NomeEstabelecimentoVISA = null, long? IdEstabelecimentoExterno = null, long? IdAutorizacao = null, long? IdMovimento = null, long? IdRemessa = null, string CodigoAutorizacao = null, string NumeroContrato = null, long? IdContaPortador = null, string DataMovimento = null, int? Lote = null, int? NumeroEstabelecimento = null, double? QuantidadeMoeda = null, double? FatorTotalAjustado = null, double? FatorBancoAjustado = null, double? FatorTaxaAdministracao = null, double? FatorComissaoGarantia = null, double? FatorTotal = null, string DataFinanciamento = null, string DataVencimentoCompraInicial = null, string DataVencimentoCompraFinal = null, bool? FlagSelecionado = null, bool? FlagRefinanciamento = null, int? TipoCompra = null, int? TipoPagamento = null, int? TipoCalculoPrestacao = null, int? TipoLiquidacao = null, long? IdCredor = null, double? ValorComissao = null, double? ValorLiquido = null, double? ValorEncargosBancarios = null, double? ValorGarantias = null, double? ValorAgenciamento = null, string OrigemResolucao = null, long? IdOrigem = null, string AcquireReferenceNumber = null, AutorizacaoResponse Autorizacao = null)
        {
            this.DvnumeroEstabelecimento = DvnumeroEstabelecimento;
            this.Mcc = Mcc;
            this.TipoEntrada = TipoEntrada;
            this.Id = Id;
            this.IdEstabelecimento = IdEstabelecimento;
            this.IdConta = IdConta;
            this.IdCartao = IdCartao;
            this.Status = Status;
            this.NumeroParcelas = NumeroParcelas;
            this.ValorParcela = ValorParcela;
            this.ValorEntrada = ValorEntrada;
            this.ValorCompra = ValorCompra;
            this.ValorContrato = ValorContrato;
            this.ValorEncargosTotais = ValorEncargosTotais;
            this.DataCompra = DataCompra;
            this.IdOperacao = IdOperacao;
            this.TaxaJuros = TaxaJuros;
            this.ValorIOF = ValorIOF;
            this.ValorTAC = ValorTAC;
            this.Origem = Origem;
            this.DataEntradaCompra = DataEntradaCompra;
            this.DataVencimentoPadrao = DataVencimentoPadrao;
            this.DataVencimentoReal = DataVencimentoReal;
            this.Carencia = Carencia;
            this.Descricao = Descricao;
            this.Cartao = Cartao;
            this.ValorOrigem = ValorOrigem;
            this.IdIncoming = IdIncoming;
            this.IdEstabelecimentoVISA = IdEstabelecimentoVISA;
            this.NomeEstabelecimentoVISA = NomeEstabelecimentoVISA;
            this.IdEstabelecimentoExterno = IdEstabelecimentoExterno;
            this.IdAutorizacao = IdAutorizacao;
            this.IdMovimento = IdMovimento;
            this.IdRemessa = IdRemessa;
            this.CodigoAutorizacao = CodigoAutorizacao;
            this.NumeroContrato = NumeroContrato;
            this.IdContaPortador = IdContaPortador;
            this.DataMovimento = DataMovimento;
            this.Lote = Lote;
            this.NumeroEstabelecimento = NumeroEstabelecimento;
            this.QuantidadeMoeda = QuantidadeMoeda;
            this.FatorTotalAjustado = FatorTotalAjustado;
            this.FatorBancoAjustado = FatorBancoAjustado;
            this.FatorTaxaAdministracao = FatorTaxaAdministracao;
            this.FatorComissaoGarantia = FatorComissaoGarantia;
            this.FatorTotal = FatorTotal;
            this.DataFinanciamento = DataFinanciamento;
            this.DataVencimentoCompraInicial = DataVencimentoCompraInicial;
            this.DataVencimentoCompraFinal = DataVencimentoCompraFinal;
            this.FlagSelecionado = FlagSelecionado;
            this.FlagRefinanciamento = FlagRefinanciamento;
            this.TipoCompra = TipoCompra;
            this.TipoPagamento = TipoPagamento;
            this.TipoCalculoPrestacao = TipoCalculoPrestacao;
            this.TipoLiquidacao = TipoLiquidacao;
            this.IdCredor = IdCredor;
            this.ValorComissao = ValorComissao;
            this.ValorLiquido = ValorLiquido;
            this.ValorEncargosBancarios = ValorEncargosBancarios;
            this.ValorGarantias = ValorGarantias;
            this.ValorAgenciamento = ValorAgenciamento;
            this.OrigemResolucao = OrigemResolucao;
            this.IdOrigem = IdOrigem;
            this.AcquireReferenceNumber = AcquireReferenceNumber;
            this.Autorizacao = Autorizacao;
            
        }
        
    
        /// <summary>
        /// Gets or Sets DvnumeroEstabelecimento
        /// </summary>
        [DataMember(Name="dvnumeroEstabelecimento", EmitDefaultValue=false)]
        public int? DvnumeroEstabelecimento { get; set; }
    
        /// <summary>
        /// Gets or Sets Mcc
        /// </summary>
        [DataMember(Name="mcc", EmitDefaultValue=false)]
        public long? Mcc { get; set; }
    
        /// <summary>
        /// Gets or Sets TipoEntrada
        /// </summary>
        [DataMember(Name="tipoEntrada", EmitDefaultValue=false)]
        public string TipoEntrada { get; set; }
    
        /// <summary>
        /// C\u00F3digo do evento
        /// </summary>
        /// <value>C\u00F3digo do evento</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00F3digo do estabelecimento
        /// </summary>
        /// <value>C\u00F3digo do estabelecimento</value>
        [DataMember(Name="idEstabelecimento", EmitDefaultValue=false)]
        public long? IdEstabelecimento { get; set; }
    
        /// <summary>
        /// C\u00F3digo da conta
        /// </summary>
        /// <value>C\u00F3digo da conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// C\u00F3digo do cart\u00E3o
        /// </summary>
        /// <value>C\u00F3digo do cart\u00E3o</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// Status do evento
        /// </summary>
        /// <value>Status do evento</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public long? Status { get; set; }
    
        /// <summary>
        /// N\u00FAmero de parcelas
        /// </summary>
        /// <value>N\u00FAmero de parcelas</value>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public int? NumeroParcelas { get; set; }
    
        /// <summary>
        /// Valor da parcela
        /// </summary>
        /// <value>Valor da parcela</value>
        [DataMember(Name="valorParcela", EmitDefaultValue=false)]
        public double? ValorParcela { get; set; }
    
        /// <summary>
        /// Valor da primeira parcela
        /// </summary>
        /// <value>Valor da primeira parcela</value>
        [DataMember(Name="valorEntrada", EmitDefaultValue=false)]
        public double? ValorEntrada { get; set; }
    
        /// <summary>
        /// Valor da compra
        /// </summary>
        /// <value>Valor da compra</value>
        [DataMember(Name="valorCompra", EmitDefaultValue=false)]
        public double? ValorCompra { get; set; }
    
        /// <summary>
        /// Valor do contrato
        /// </summary>
        /// <value>Valor do contrato</value>
        [DataMember(Name="valorContrato", EmitDefaultValue=false)]
        public double? ValorContrato { get; set; }
    
        /// <summary>
        /// Valor dos encargos totais
        /// </summary>
        /// <value>Valor dos encargos totais</value>
        [DataMember(Name="valorEncargosTotais", EmitDefaultValue=false)]
        public double? ValorEncargosTotais { get; set; }
    
        /// <summary>
        /// Data da compra
        /// </summary>
        /// <value>Data da compra</value>
        [DataMember(Name="dataCompra", EmitDefaultValue=false)]
        public string DataCompra { get; set; }
    
        /// <summary>
        /// C\u00F3digo do tipo de opera\u00E7\u00E3o
        /// </summary>
        /// <value>C\u00F3digo do tipo de opera\u00E7\u00E3o</value>
        [DataMember(Name="idOperacao", EmitDefaultValue=false)]
        public long? IdOperacao { get; set; }
    
        /// <summary>
        /// Valor da taxa de juros
        /// </summary>
        /// <value>Valor da taxa de juros</value>
        [DataMember(Name="taxaJuros", EmitDefaultValue=false)]
        public double? TaxaJuros { get; set; }
    
        /// <summary>
        /// Valor IOF
        /// </summary>
        /// <value>Valor IOF</value>
        [DataMember(Name="valorIOF", EmitDefaultValue=false)]
        public double? ValorIOF { get; set; }
    
        /// <summary>
        /// Valor TAC
        /// </summary>
        /// <value>Valor TAC</value>
        [DataMember(Name="valorTAC", EmitDefaultValue=false)]
        public double? ValorTAC { get; set; }
    
        /// <summary>
        /// Origem do evento
        /// </summary>
        /// <value>Origem do evento</value>
        [DataMember(Name="origem", EmitDefaultValue=false)]
        public string Origem { get; set; }
    
        /// <summary>
        /// Data de entrada do evento
        /// </summary>
        /// <value>Data de entrada do evento</value>
        [DataMember(Name="dataEntradaCompra", EmitDefaultValue=false)]
        public string DataEntradaCompra { get; set; }
    
        /// <summary>
        /// Data de vencimento padr\u00E3o
        /// </summary>
        /// <value>Data de vencimento padr\u00E3o</value>
        [DataMember(Name="dataVencimentoPadrao", EmitDefaultValue=false)]
        public string DataVencimentoPadrao { get; set; }
    
        /// <summary>
        /// Data de vencimento real
        /// </summary>
        /// <value>Data de vencimento real</value>
        [DataMember(Name="dataVencimentoReal", EmitDefaultValue=false)]
        public string DataVencimentoReal { get; set; }
    
        /// <summary>
        /// Car\u00EAncia
        /// </summary>
        /// <value>Car\u00EAncia</value>
        [DataMember(Name="carencia", EmitDefaultValue=false)]
        public int? Carencia { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do evento
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do evento</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// N\u00FAmero do cart\u00E3o
        /// </summary>
        /// <value>N\u00FAmero do cart\u00E3o</value>
        [DataMember(Name="cartao", EmitDefaultValue=false)]
        public string Cartao { get; set; }
    
        /// <summary>
        /// Valor de origem
        /// </summary>
        /// <value>Valor de origem</value>
        [DataMember(Name="valorOrigem", EmitDefaultValue=false)]
        public double? ValorOrigem { get; set; }
    
        /// <summary>
        /// C\u00F3digo de entrada
        /// </summary>
        /// <value>C\u00F3digo de entrada</value>
        [DataMember(Name="idIncoming", EmitDefaultValue=false)]
        public long? IdIncoming { get; set; }
    
        /// <summary>
        /// C\u00F3digo do estabelecimento VISA
        /// </summary>
        /// <value>C\u00F3digo do estabelecimento VISA</value>
        [DataMember(Name="idEstabelecimentoVISA", EmitDefaultValue=false)]
        public long? IdEstabelecimentoVISA { get; set; }
    
        /// <summary>
        /// Nome do estabelecimento VISA
        /// </summary>
        /// <value>Nome do estabelecimento VISA</value>
        [DataMember(Name="nomeEstabelecimentoVISA", EmitDefaultValue=false)]
        public string NomeEstabelecimentoVISA { get; set; }
    
        /// <summary>
        /// C\u00F3digo do estabelecimento externo
        /// </summary>
        /// <value>C\u00F3digo do estabelecimento externo</value>
        [DataMember(Name="idEstabelecimentoExterno", EmitDefaultValue=false)]
        public long? IdEstabelecimentoExterno { get; set; }
    
        /// <summary>
        /// Identificador de autoriza\u00E7\u00E3o
        /// </summary>
        /// <value>Identificador de autoriza\u00E7\u00E3o</value>
        [DataMember(Name="idAutorizacao", EmitDefaultValue=false)]
        public long? IdAutorizacao { get; set; }
    
        /// <summary>
        /// C\u00F3digo de movimento
        /// </summary>
        /// <value>C\u00F3digo de movimento</value>
        [DataMember(Name="idMovimento", EmitDefaultValue=false)]
        public long? IdMovimento { get; set; }
    
        /// <summary>
        /// C\u00F3digo de remessa
        /// </summary>
        /// <value>C\u00F3digo de remessa</value>
        [DataMember(Name="idRemessa", EmitDefaultValue=false)]
        public long? IdRemessa { get; set; }
    
        /// <summary>
        /// C\u00F3digo de autorizac\u00E3o
        /// </summary>
        /// <value>C\u00F3digo de autorizac\u00E3o</value>
        [DataMember(Name="codigoAutorizacao", EmitDefaultValue=false)]
        public string CodigoAutorizacao { get; set; }
    
        /// <summary>
        /// N\u00FAmero do contrato
        /// </summary>
        /// <value>N\u00FAmero do contrato</value>
        [DataMember(Name="numeroContrato", EmitDefaultValue=false)]
        public string NumeroContrato { get; set; }
    
        /// <summary>
        /// C\u00F3digo da conta do portador
        /// </summary>
        /// <value>C\u00F3digo da conta do portador</value>
        [DataMember(Name="idContaPortador", EmitDefaultValue=false)]
        public long? IdContaPortador { get; set; }
    
        /// <summary>
        /// Data de movimento
        /// </summary>
        /// <value>Data de movimento</value>
        [DataMember(Name="dataMovimento", EmitDefaultValue=false)]
        public string DataMovimento { get; set; }
    
        /// <summary>
        /// N\u00FAmero do lote
        /// </summary>
        /// <value>N\u00FAmero do lote</value>
        [DataMember(Name="lote", EmitDefaultValue=false)]
        public int? Lote { get; set; }
    
        /// <summary>
        /// N\u00FAmero do estabelecimento
        /// </summary>
        /// <value>N\u00FAmero do estabelecimento</value>
        [DataMember(Name="numeroEstabelecimento", EmitDefaultValue=false)]
        public int? NumeroEstabelecimento { get; set; }
    
        /// <summary>
        /// Quantidade de moeda
        /// </summary>
        /// <value>Quantidade de moeda</value>
        [DataMember(Name="quantidadeMoeda", EmitDefaultValue=false)]
        public double? QuantidadeMoeda { get; set; }
    
        /// <summary>
        /// Fator total ajustado
        /// </summary>
        /// <value>Fator total ajustado</value>
        [DataMember(Name="fatorTotalAjustado", EmitDefaultValue=false)]
        public double? FatorTotalAjustado { get; set; }
    
        /// <summary>
        /// Fator de banco ajustado
        /// </summary>
        /// <value>Fator de banco ajustado</value>
        [DataMember(Name="fatorBancoAjustado", EmitDefaultValue=false)]
        public double? FatorBancoAjustado { get; set; }
    
        /// <summary>
        /// Fator da taxa de administra\u00E7\u00E3o
        /// </summary>
        /// <value>Fator da taxa de administra\u00E7\u00E3o</value>
        [DataMember(Name="fatorTaxaAdministracao", EmitDefaultValue=false)]
        public double? FatorTaxaAdministracao { get; set; }
    
        /// <summary>
        /// Fator da comiss\u00E3o de garantia
        /// </summary>
        /// <value>Fator da comiss\u00E3o de garantia</value>
        [DataMember(Name="fatorComissaoGarantia", EmitDefaultValue=false)]
        public double? FatorComissaoGarantia { get; set; }
    
        /// <summary>
        /// Fator total
        /// </summary>
        /// <value>Fator total</value>
        [DataMember(Name="fatorTotal", EmitDefaultValue=false)]
        public double? FatorTotal { get; set; }
    
        /// <summary>
        /// Data de financiamento
        /// </summary>
        /// <value>Data de financiamento</value>
        [DataMember(Name="dataFinanciamento", EmitDefaultValue=false)]
        public string DataFinanciamento { get; set; }
    
        /// <summary>
        /// Data de vencimento de compra inicial
        /// </summary>
        /// <value>Data de vencimento de compra inicial</value>
        [DataMember(Name="dataVencimentoCompraInicial", EmitDefaultValue=false)]
        public string DataVencimentoCompraInicial { get; set; }
    
        /// <summary>
        /// Data de vencimento de compra final
        /// </summary>
        /// <value>Data de vencimento de compra final</value>
        [DataMember(Name="dataVencimentoCompraFinal", EmitDefaultValue=false)]
        public string DataVencimentoCompraFinal { get; set; }
    
        /// <summary>
        /// Flag de sele\u00E7\u00E3o
        /// </summary>
        /// <value>Flag de sele\u00E7\u00E3o</value>
        [DataMember(Name="flagSelecionado", EmitDefaultValue=false)]
        public bool? FlagSelecionado { get; set; }
    
        /// <summary>
        /// Flag de refinanciamento
        /// </summary>
        /// <value>Flag de refinanciamento</value>
        [DataMember(Name="flagRefinanciamento", EmitDefaultValue=false)]
        public bool? FlagRefinanciamento { get; set; }
    
        /// <summary>
        /// Tipo de compra
        /// </summary>
        /// <value>Tipo de compra</value>
        [DataMember(Name="tipoCompra", EmitDefaultValue=false)]
        public int? TipoCompra { get; set; }
    
        /// <summary>
        /// Tipo de pagamento
        /// </summary>
        /// <value>Tipo de pagamento</value>
        [DataMember(Name="tipoPagamento", EmitDefaultValue=false)]
        public int? TipoPagamento { get; set; }
    
        /// <summary>
        /// Tipo de c\u00E1lculo de presta\u00E7\u00E3o
        /// </summary>
        /// <value>Tipo de c\u00E1lculo de presta\u00E7\u00E3o</value>
        [DataMember(Name="tipoCalculoPrestacao", EmitDefaultValue=false)]
        public int? TipoCalculoPrestacao { get; set; }
    
        /// <summary>
        /// Tipo de liquida\u00E7\u00E3o
        /// </summary>
        /// <value>Tipo de liquida\u00E7\u00E3o</value>
        [DataMember(Name="tipoLiquidacao", EmitDefaultValue=false)]
        public int? TipoLiquidacao { get; set; }
    
        /// <summary>
        /// C\u00F3digo do credor
        /// </summary>
        /// <value>C\u00F3digo do credor</value>
        [DataMember(Name="idCredor", EmitDefaultValue=false)]
        public long? IdCredor { get; set; }
    
        /// <summary>
        /// Valor da comiss\u00E3o
        /// </summary>
        /// <value>Valor da comiss\u00E3o</value>
        [DataMember(Name="valorComissao", EmitDefaultValue=false)]
        public double? ValorComissao { get; set; }
    
        /// <summary>
        /// Valor l\u00EDquido
        /// </summary>
        /// <value>Valor l\u00EDquido</value>
        [DataMember(Name="valorLiquido", EmitDefaultValue=false)]
        public double? ValorLiquido { get; set; }
    
        /// <summary>
        /// Valor dos encargos banc\u00E1rios
        /// </summary>
        /// <value>Valor dos encargos banc\u00E1rios</value>
        [DataMember(Name="valorEncargosBancarios", EmitDefaultValue=false)]
        public double? ValorEncargosBancarios { get; set; }
    
        /// <summary>
        /// Valor das garantias
        /// </summary>
        /// <value>Valor das garantias</value>
        [DataMember(Name="valorGarantias", EmitDefaultValue=false)]
        public double? ValorGarantias { get; set; }
    
        /// <summary>
        /// Valor do agenciamento
        /// </summary>
        /// <value>Valor do agenciamento</value>
        [DataMember(Name="valorAgenciamento", EmitDefaultValue=false)]
        public double? ValorAgenciamento { get; set; }
    
        /// <summary>
        /// Origem da resolu\u00E7\u00E3o
        /// </summary>
        /// <value>Origem da resolu\u00E7\u00E3o</value>
        [DataMember(Name="origemResolucao", EmitDefaultValue=false)]
        public string OrigemResolucao { get; set; }
    
        /// <summary>
        /// Identificador de origem
        /// </summary>
        /// <value>Identificador de origem</value>
        [DataMember(Name="idOrigem", EmitDefaultValue=false)]
        public long? IdOrigem { get; set; }
    
        /// <summary>
        /// N\u00FAmero de refer\u00EAncia de aquisi\u00E7\u00E3o
        /// </summary>
        /// <value>N\u00FAmero de refer\u00EAncia de aquisi\u00E7\u00E3o</value>
        [DataMember(Name="acquireReferenceNumber", EmitDefaultValue=false)]
        public string AcquireReferenceNumber { get; set; }
    
        /// <summary>
        /// Informa\u00E7\u00F5es de autoriza\u00E7\u00E3o
        /// </summary>
        /// <value>Informa\u00E7\u00F5es de autoriza\u00E7\u00E3o</value>
        [DataMember(Name="autorizacao", EmitDefaultValue=false)]
        public AutorizacaoResponse Autorizacao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventoExternoCompraResponse {\n");
            sb.Append("  DvnumeroEstabelecimento: ").Append(DvnumeroEstabelecimento).Append("\n");
            sb.Append("  Mcc: ").Append(Mcc).Append("\n");
            sb.Append("  TipoEntrada: ").Append(TipoEntrada).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdEstabelecimento: ").Append(IdEstabelecimento).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  NumeroParcelas: ").Append(NumeroParcelas).Append("\n");
            sb.Append("  ValorParcela: ").Append(ValorParcela).Append("\n");
            sb.Append("  ValorEntrada: ").Append(ValorEntrada).Append("\n");
            sb.Append("  ValorCompra: ").Append(ValorCompra).Append("\n");
            sb.Append("  ValorContrato: ").Append(ValorContrato).Append("\n");
            sb.Append("  ValorEncargosTotais: ").Append(ValorEncargosTotais).Append("\n");
            sb.Append("  DataCompra: ").Append(DataCompra).Append("\n");
            sb.Append("  IdOperacao: ").Append(IdOperacao).Append("\n");
            sb.Append("  TaxaJuros: ").Append(TaxaJuros).Append("\n");
            sb.Append("  ValorIOF: ").Append(ValorIOF).Append("\n");
            sb.Append("  ValorTAC: ").Append(ValorTAC).Append("\n");
            sb.Append("  Origem: ").Append(Origem).Append("\n");
            sb.Append("  DataEntradaCompra: ").Append(DataEntradaCompra).Append("\n");
            sb.Append("  DataVencimentoPadrao: ").Append(DataVencimentoPadrao).Append("\n");
            sb.Append("  DataVencimentoReal: ").Append(DataVencimentoReal).Append("\n");
            sb.Append("  Carencia: ").Append(Carencia).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  Cartao: ").Append(Cartao).Append("\n");
            sb.Append("  ValorOrigem: ").Append(ValorOrigem).Append("\n");
            sb.Append("  IdIncoming: ").Append(IdIncoming).Append("\n");
            sb.Append("  IdEstabelecimentoVISA: ").Append(IdEstabelecimentoVISA).Append("\n");
            sb.Append("  NomeEstabelecimentoVISA: ").Append(NomeEstabelecimentoVISA).Append("\n");
            sb.Append("  IdEstabelecimentoExterno: ").Append(IdEstabelecimentoExterno).Append("\n");
            sb.Append("  IdAutorizacao: ").Append(IdAutorizacao).Append("\n");
            sb.Append("  IdMovimento: ").Append(IdMovimento).Append("\n");
            sb.Append("  IdRemessa: ").Append(IdRemessa).Append("\n");
            sb.Append("  CodigoAutorizacao: ").Append(CodigoAutorizacao).Append("\n");
            sb.Append("  NumeroContrato: ").Append(NumeroContrato).Append("\n");
            sb.Append("  IdContaPortador: ").Append(IdContaPortador).Append("\n");
            sb.Append("  DataMovimento: ").Append(DataMovimento).Append("\n");
            sb.Append("  Lote: ").Append(Lote).Append("\n");
            sb.Append("  NumeroEstabelecimento: ").Append(NumeroEstabelecimento).Append("\n");
            sb.Append("  QuantidadeMoeda: ").Append(QuantidadeMoeda).Append("\n");
            sb.Append("  FatorTotalAjustado: ").Append(FatorTotalAjustado).Append("\n");
            sb.Append("  FatorBancoAjustado: ").Append(FatorBancoAjustado).Append("\n");
            sb.Append("  FatorTaxaAdministracao: ").Append(FatorTaxaAdministracao).Append("\n");
            sb.Append("  FatorComissaoGarantia: ").Append(FatorComissaoGarantia).Append("\n");
            sb.Append("  FatorTotal: ").Append(FatorTotal).Append("\n");
            sb.Append("  DataFinanciamento: ").Append(DataFinanciamento).Append("\n");
            sb.Append("  DataVencimentoCompraInicial: ").Append(DataVencimentoCompraInicial).Append("\n");
            sb.Append("  DataVencimentoCompraFinal: ").Append(DataVencimentoCompraFinal).Append("\n");
            sb.Append("  FlagSelecionado: ").Append(FlagSelecionado).Append("\n");
            sb.Append("  FlagRefinanciamento: ").Append(FlagRefinanciamento).Append("\n");
            sb.Append("  TipoCompra: ").Append(TipoCompra).Append("\n");
            sb.Append("  TipoPagamento: ").Append(TipoPagamento).Append("\n");
            sb.Append("  TipoCalculoPrestacao: ").Append(TipoCalculoPrestacao).Append("\n");
            sb.Append("  TipoLiquidacao: ").Append(TipoLiquidacao).Append("\n");
            sb.Append("  IdCredor: ").Append(IdCredor).Append("\n");
            sb.Append("  ValorComissao: ").Append(ValorComissao).Append("\n");
            sb.Append("  ValorLiquido: ").Append(ValorLiquido).Append("\n");
            sb.Append("  ValorEncargosBancarios: ").Append(ValorEncargosBancarios).Append("\n");
            sb.Append("  ValorGarantias: ").Append(ValorGarantias).Append("\n");
            sb.Append("  ValorAgenciamento: ").Append(ValorAgenciamento).Append("\n");
            sb.Append("  OrigemResolucao: ").Append(OrigemResolucao).Append("\n");
            sb.Append("  IdOrigem: ").Append(IdOrigem).Append("\n");
            sb.Append("  AcquireReferenceNumber: ").Append(AcquireReferenceNumber).Append("\n");
            sb.Append("  Autorizacao: ").Append(Autorizacao).Append("\n");
            
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
            return this.Equals(obj as EventoExternoCompraResponse);
        }

        /// <summary>
        /// Returns true if EventoExternoCompraResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of EventoExternoCompraResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventoExternoCompraResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DvnumeroEstabelecimento == other.DvnumeroEstabelecimento ||
                    this.DvnumeroEstabelecimento != null &&
                    this.DvnumeroEstabelecimento.Equals(other.DvnumeroEstabelecimento)
                ) && 
                (
                    this.Mcc == other.Mcc ||
                    this.Mcc != null &&
                    this.Mcc.Equals(other.Mcc)
                ) && 
                (
                    this.TipoEntrada == other.TipoEntrada ||
                    this.TipoEntrada != null &&
                    this.TipoEntrada.Equals(other.TipoEntrada)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdEstabelecimento == other.IdEstabelecimento ||
                    this.IdEstabelecimento != null &&
                    this.IdEstabelecimento.Equals(other.IdEstabelecimento)
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
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.NumeroParcelas == other.NumeroParcelas ||
                    this.NumeroParcelas != null &&
                    this.NumeroParcelas.Equals(other.NumeroParcelas)
                ) && 
                (
                    this.ValorParcela == other.ValorParcela ||
                    this.ValorParcela != null &&
                    this.ValorParcela.Equals(other.ValorParcela)
                ) && 
                (
                    this.ValorEntrada == other.ValorEntrada ||
                    this.ValorEntrada != null &&
                    this.ValorEntrada.Equals(other.ValorEntrada)
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
                    this.ValorEncargosTotais == other.ValorEncargosTotais ||
                    this.ValorEncargosTotais != null &&
                    this.ValorEncargosTotais.Equals(other.ValorEncargosTotais)
                ) && 
                (
                    this.DataCompra == other.DataCompra ||
                    this.DataCompra != null &&
                    this.DataCompra.Equals(other.DataCompra)
                ) && 
                (
                    this.IdOperacao == other.IdOperacao ||
                    this.IdOperacao != null &&
                    this.IdOperacao.Equals(other.IdOperacao)
                ) && 
                (
                    this.TaxaJuros == other.TaxaJuros ||
                    this.TaxaJuros != null &&
                    this.TaxaJuros.Equals(other.TaxaJuros)
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
                    this.Origem == other.Origem ||
                    this.Origem != null &&
                    this.Origem.Equals(other.Origem)
                ) && 
                (
                    this.DataEntradaCompra == other.DataEntradaCompra ||
                    this.DataEntradaCompra != null &&
                    this.DataEntradaCompra.Equals(other.DataEntradaCompra)
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
                    this.Carencia == other.Carencia ||
                    this.Carencia != null &&
                    this.Carencia.Equals(other.Carencia)
                ) && 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.Cartao == other.Cartao ||
                    this.Cartao != null &&
                    this.Cartao.Equals(other.Cartao)
                ) && 
                (
                    this.ValorOrigem == other.ValorOrigem ||
                    this.ValorOrigem != null &&
                    this.ValorOrigem.Equals(other.ValorOrigem)
                ) && 
                (
                    this.IdIncoming == other.IdIncoming ||
                    this.IdIncoming != null &&
                    this.IdIncoming.Equals(other.IdIncoming)
                ) && 
                (
                    this.IdEstabelecimentoVISA == other.IdEstabelecimentoVISA ||
                    this.IdEstabelecimentoVISA != null &&
                    this.IdEstabelecimentoVISA.Equals(other.IdEstabelecimentoVISA)
                ) && 
                (
                    this.NomeEstabelecimentoVISA == other.NomeEstabelecimentoVISA ||
                    this.NomeEstabelecimentoVISA != null &&
                    this.NomeEstabelecimentoVISA.Equals(other.NomeEstabelecimentoVISA)
                ) && 
                (
                    this.IdEstabelecimentoExterno == other.IdEstabelecimentoExterno ||
                    this.IdEstabelecimentoExterno != null &&
                    this.IdEstabelecimentoExterno.Equals(other.IdEstabelecimentoExterno)
                ) && 
                (
                    this.IdAutorizacao == other.IdAutorizacao ||
                    this.IdAutorizacao != null &&
                    this.IdAutorizacao.Equals(other.IdAutorizacao)
                ) && 
                (
                    this.IdMovimento == other.IdMovimento ||
                    this.IdMovimento != null &&
                    this.IdMovimento.Equals(other.IdMovimento)
                ) && 
                (
                    this.IdRemessa == other.IdRemessa ||
                    this.IdRemessa != null &&
                    this.IdRemessa.Equals(other.IdRemessa)
                ) && 
                (
                    this.CodigoAutorizacao == other.CodigoAutorizacao ||
                    this.CodigoAutorizacao != null &&
                    this.CodigoAutorizacao.Equals(other.CodigoAutorizacao)
                ) && 
                (
                    this.NumeroContrato == other.NumeroContrato ||
                    this.NumeroContrato != null &&
                    this.NumeroContrato.Equals(other.NumeroContrato)
                ) && 
                (
                    this.IdContaPortador == other.IdContaPortador ||
                    this.IdContaPortador != null &&
                    this.IdContaPortador.Equals(other.IdContaPortador)
                ) && 
                (
                    this.DataMovimento == other.DataMovimento ||
                    this.DataMovimento != null &&
                    this.DataMovimento.Equals(other.DataMovimento)
                ) && 
                (
                    this.Lote == other.Lote ||
                    this.Lote != null &&
                    this.Lote.Equals(other.Lote)
                ) && 
                (
                    this.NumeroEstabelecimento == other.NumeroEstabelecimento ||
                    this.NumeroEstabelecimento != null &&
                    this.NumeroEstabelecimento.Equals(other.NumeroEstabelecimento)
                ) && 
                (
                    this.QuantidadeMoeda == other.QuantidadeMoeda ||
                    this.QuantidadeMoeda != null &&
                    this.QuantidadeMoeda.Equals(other.QuantidadeMoeda)
                ) && 
                (
                    this.FatorTotalAjustado == other.FatorTotalAjustado ||
                    this.FatorTotalAjustado != null &&
                    this.FatorTotalAjustado.Equals(other.FatorTotalAjustado)
                ) && 
                (
                    this.FatorBancoAjustado == other.FatorBancoAjustado ||
                    this.FatorBancoAjustado != null &&
                    this.FatorBancoAjustado.Equals(other.FatorBancoAjustado)
                ) && 
                (
                    this.FatorTaxaAdministracao == other.FatorTaxaAdministracao ||
                    this.FatorTaxaAdministracao != null &&
                    this.FatorTaxaAdministracao.Equals(other.FatorTaxaAdministracao)
                ) && 
                (
                    this.FatorComissaoGarantia == other.FatorComissaoGarantia ||
                    this.FatorComissaoGarantia != null &&
                    this.FatorComissaoGarantia.Equals(other.FatorComissaoGarantia)
                ) && 
                (
                    this.FatorTotal == other.FatorTotal ||
                    this.FatorTotal != null &&
                    this.FatorTotal.Equals(other.FatorTotal)
                ) && 
                (
                    this.DataFinanciamento == other.DataFinanciamento ||
                    this.DataFinanciamento != null &&
                    this.DataFinanciamento.Equals(other.DataFinanciamento)
                ) && 
                (
                    this.DataVencimentoCompraInicial == other.DataVencimentoCompraInicial ||
                    this.DataVencimentoCompraInicial != null &&
                    this.DataVencimentoCompraInicial.Equals(other.DataVencimentoCompraInicial)
                ) && 
                (
                    this.DataVencimentoCompraFinal == other.DataVencimentoCompraFinal ||
                    this.DataVencimentoCompraFinal != null &&
                    this.DataVencimentoCompraFinal.Equals(other.DataVencimentoCompraFinal)
                ) && 
                (
                    this.FlagSelecionado == other.FlagSelecionado ||
                    this.FlagSelecionado != null &&
                    this.FlagSelecionado.Equals(other.FlagSelecionado)
                ) && 
                (
                    this.FlagRefinanciamento == other.FlagRefinanciamento ||
                    this.FlagRefinanciamento != null &&
                    this.FlagRefinanciamento.Equals(other.FlagRefinanciamento)
                ) && 
                (
                    this.TipoCompra == other.TipoCompra ||
                    this.TipoCompra != null &&
                    this.TipoCompra.Equals(other.TipoCompra)
                ) && 
                (
                    this.TipoPagamento == other.TipoPagamento ||
                    this.TipoPagamento != null &&
                    this.TipoPagamento.Equals(other.TipoPagamento)
                ) && 
                (
                    this.TipoCalculoPrestacao == other.TipoCalculoPrestacao ||
                    this.TipoCalculoPrestacao != null &&
                    this.TipoCalculoPrestacao.Equals(other.TipoCalculoPrestacao)
                ) && 
                (
                    this.TipoLiquidacao == other.TipoLiquidacao ||
                    this.TipoLiquidacao != null &&
                    this.TipoLiquidacao.Equals(other.TipoLiquidacao)
                ) && 
                (
                    this.IdCredor == other.IdCredor ||
                    this.IdCredor != null &&
                    this.IdCredor.Equals(other.IdCredor)
                ) && 
                (
                    this.ValorComissao == other.ValorComissao ||
                    this.ValorComissao != null &&
                    this.ValorComissao.Equals(other.ValorComissao)
                ) && 
                (
                    this.ValorLiquido == other.ValorLiquido ||
                    this.ValorLiquido != null &&
                    this.ValorLiquido.Equals(other.ValorLiquido)
                ) && 
                (
                    this.ValorEncargosBancarios == other.ValorEncargosBancarios ||
                    this.ValorEncargosBancarios != null &&
                    this.ValorEncargosBancarios.Equals(other.ValorEncargosBancarios)
                ) && 
                (
                    this.ValorGarantias == other.ValorGarantias ||
                    this.ValorGarantias != null &&
                    this.ValorGarantias.Equals(other.ValorGarantias)
                ) && 
                (
                    this.ValorAgenciamento == other.ValorAgenciamento ||
                    this.ValorAgenciamento != null &&
                    this.ValorAgenciamento.Equals(other.ValorAgenciamento)
                ) && 
                (
                    this.OrigemResolucao == other.OrigemResolucao ||
                    this.OrigemResolucao != null &&
                    this.OrigemResolucao.Equals(other.OrigemResolucao)
                ) && 
                (
                    this.IdOrigem == other.IdOrigem ||
                    this.IdOrigem != null &&
                    this.IdOrigem.Equals(other.IdOrigem)
                ) && 
                (
                    this.AcquireReferenceNumber == other.AcquireReferenceNumber ||
                    this.AcquireReferenceNumber != null &&
                    this.AcquireReferenceNumber.Equals(other.AcquireReferenceNumber)
                ) && 
                (
                    this.Autorizacao == other.Autorizacao ||
                    this.Autorizacao != null &&
                    this.Autorizacao.Equals(other.Autorizacao)
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
                
                if (this.DvnumeroEstabelecimento != null)
                    hash = hash * 59 + this.DvnumeroEstabelecimento.GetHashCode();
                
                if (this.Mcc != null)
                    hash = hash * 59 + this.Mcc.GetHashCode();
                
                if (this.TipoEntrada != null)
                    hash = hash * 59 + this.TipoEntrada.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdEstabelecimento != null)
                    hash = hash * 59 + this.IdEstabelecimento.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.NumeroParcelas != null)
                    hash = hash * 59 + this.NumeroParcelas.GetHashCode();
                
                if (this.ValorParcela != null)
                    hash = hash * 59 + this.ValorParcela.GetHashCode();
                
                if (this.ValorEntrada != null)
                    hash = hash * 59 + this.ValorEntrada.GetHashCode();
                
                if (this.ValorCompra != null)
                    hash = hash * 59 + this.ValorCompra.GetHashCode();
                
                if (this.ValorContrato != null)
                    hash = hash * 59 + this.ValorContrato.GetHashCode();
                
                if (this.ValorEncargosTotais != null)
                    hash = hash * 59 + this.ValorEncargosTotais.GetHashCode();
                
                if (this.DataCompra != null)
                    hash = hash * 59 + this.DataCompra.GetHashCode();
                
                if (this.IdOperacao != null)
                    hash = hash * 59 + this.IdOperacao.GetHashCode();
                
                if (this.TaxaJuros != null)
                    hash = hash * 59 + this.TaxaJuros.GetHashCode();
                
                if (this.ValorIOF != null)
                    hash = hash * 59 + this.ValorIOF.GetHashCode();
                
                if (this.ValorTAC != null)
                    hash = hash * 59 + this.ValorTAC.GetHashCode();
                
                if (this.Origem != null)
                    hash = hash * 59 + this.Origem.GetHashCode();
                
                if (this.DataEntradaCompra != null)
                    hash = hash * 59 + this.DataEntradaCompra.GetHashCode();
                
                if (this.DataVencimentoPadrao != null)
                    hash = hash * 59 + this.DataVencimentoPadrao.GetHashCode();
                
                if (this.DataVencimentoReal != null)
                    hash = hash * 59 + this.DataVencimentoReal.GetHashCode();
                
                if (this.Carencia != null)
                    hash = hash * 59 + this.Carencia.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.Cartao != null)
                    hash = hash * 59 + this.Cartao.GetHashCode();
                
                if (this.ValorOrigem != null)
                    hash = hash * 59 + this.ValorOrigem.GetHashCode();
                
                if (this.IdIncoming != null)
                    hash = hash * 59 + this.IdIncoming.GetHashCode();
                
                if (this.IdEstabelecimentoVISA != null)
                    hash = hash * 59 + this.IdEstabelecimentoVISA.GetHashCode();
                
                if (this.NomeEstabelecimentoVISA != null)
                    hash = hash * 59 + this.NomeEstabelecimentoVISA.GetHashCode();
                
                if (this.IdEstabelecimentoExterno != null)
                    hash = hash * 59 + this.IdEstabelecimentoExterno.GetHashCode();
                
                if (this.IdAutorizacao != null)
                    hash = hash * 59 + this.IdAutorizacao.GetHashCode();
                
                if (this.IdMovimento != null)
                    hash = hash * 59 + this.IdMovimento.GetHashCode();
                
                if (this.IdRemessa != null)
                    hash = hash * 59 + this.IdRemessa.GetHashCode();
                
                if (this.CodigoAutorizacao != null)
                    hash = hash * 59 + this.CodigoAutorizacao.GetHashCode();
                
                if (this.NumeroContrato != null)
                    hash = hash * 59 + this.NumeroContrato.GetHashCode();
                
                if (this.IdContaPortador != null)
                    hash = hash * 59 + this.IdContaPortador.GetHashCode();
                
                if (this.DataMovimento != null)
                    hash = hash * 59 + this.DataMovimento.GetHashCode();
                
                if (this.Lote != null)
                    hash = hash * 59 + this.Lote.GetHashCode();
                
                if (this.NumeroEstabelecimento != null)
                    hash = hash * 59 + this.NumeroEstabelecimento.GetHashCode();
                
                if (this.QuantidadeMoeda != null)
                    hash = hash * 59 + this.QuantidadeMoeda.GetHashCode();
                
                if (this.FatorTotalAjustado != null)
                    hash = hash * 59 + this.FatorTotalAjustado.GetHashCode();
                
                if (this.FatorBancoAjustado != null)
                    hash = hash * 59 + this.FatorBancoAjustado.GetHashCode();
                
                if (this.FatorTaxaAdministracao != null)
                    hash = hash * 59 + this.FatorTaxaAdministracao.GetHashCode();
                
                if (this.FatorComissaoGarantia != null)
                    hash = hash * 59 + this.FatorComissaoGarantia.GetHashCode();
                
                if (this.FatorTotal != null)
                    hash = hash * 59 + this.FatorTotal.GetHashCode();
                
                if (this.DataFinanciamento != null)
                    hash = hash * 59 + this.DataFinanciamento.GetHashCode();
                
                if (this.DataVencimentoCompraInicial != null)
                    hash = hash * 59 + this.DataVencimentoCompraInicial.GetHashCode();
                
                if (this.DataVencimentoCompraFinal != null)
                    hash = hash * 59 + this.DataVencimentoCompraFinal.GetHashCode();
                
                if (this.FlagSelecionado != null)
                    hash = hash * 59 + this.FlagSelecionado.GetHashCode();
                
                if (this.FlagRefinanciamento != null)
                    hash = hash * 59 + this.FlagRefinanciamento.GetHashCode();
                
                if (this.TipoCompra != null)
                    hash = hash * 59 + this.TipoCompra.GetHashCode();
                
                if (this.TipoPagamento != null)
                    hash = hash * 59 + this.TipoPagamento.GetHashCode();
                
                if (this.TipoCalculoPrestacao != null)
                    hash = hash * 59 + this.TipoCalculoPrestacao.GetHashCode();
                
                if (this.TipoLiquidacao != null)
                    hash = hash * 59 + this.TipoLiquidacao.GetHashCode();
                
                if (this.IdCredor != null)
                    hash = hash * 59 + this.IdCredor.GetHashCode();
                
                if (this.ValorComissao != null)
                    hash = hash * 59 + this.ValorComissao.GetHashCode();
                
                if (this.ValorLiquido != null)
                    hash = hash * 59 + this.ValorLiquido.GetHashCode();
                
                if (this.ValorEncargosBancarios != null)
                    hash = hash * 59 + this.ValorEncargosBancarios.GetHashCode();
                
                if (this.ValorGarantias != null)
                    hash = hash * 59 + this.ValorGarantias.GetHashCode();
                
                if (this.ValorAgenciamento != null)
                    hash = hash * 59 + this.ValorAgenciamento.GetHashCode();
                
                if (this.OrigemResolucao != null)
                    hash = hash * 59 + this.OrigemResolucao.GetHashCode();
                
                if (this.IdOrigem != null)
                    hash = hash * 59 + this.IdOrigem.GetHashCode();
                
                if (this.AcquireReferenceNumber != null)
                    hash = hash * 59 + this.AcquireReferenceNumber.GetHashCode();
                
                if (this.Autorizacao != null)
                    hash = hash * 59 + this.Autorizacao.GetHashCode();
                
                return hash;
            }
        }

    }
}
