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
    /// Objeto transacoes correntes
    /// </summary>
    [DataContract]
    public partial class TransacoesCorrentes :  IEquatable<TransacoesCorrentes>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransacoesCorrentes" /> class.
        /// Initializes a new instance of the <see cref="TransacoesCorrentes" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id)..</param>
        /// <param name="TipoTransacao">Descri\u00C3\u00A7\u00C3\u00A3o do Tipo da Transa\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="StatusTransacao">Status de Processamento da Transa\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="IdEvento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Evento que originou a Transa\u00C3\u00A7\u00C3\u00A3o (id)..</param>
        /// <param name="TipoEvento">Descri\u00C3\u00A7\u00C3\u00A3o do Evento que representa a Transa\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="IdConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id)..</param>
        /// <param name="CartaoMascarado">N\u00C3\u00BAmero do Cart\u00C3\u00A3o em Formato 0000XXXXXXXX0000..</param>
        /// <param name="NomePortador">Nome completo do Portador do Cart\u00C3\u00A3o..</param>
        /// <param name="DataTransacaoUTC">Data em que a Transa\u00C3\u00A7\u00C3\u00A3o foi realizada sob o padr\u00C3\u00A3o de Tempo Universal Coordenado (UTC)..</param>
        /// <param name="DataFaturamento">Data de Faturamento da Transa\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="DataVencimento">Data de Vencimento da Fatura..</param>
        /// <param name="ModoEntradaTransacao">Descreve o modo utilizado para realizar a leitura dos dados do cart\u00C3\u00A3o para realizar a Transa\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="ValorTaxaEmbarque">Valor da Taxa de Embarque em Real (BRL) quando a transa\u00C3\u00A7\u00C3\u00A3o for relacionada a Compra de Passagens A\u00C3\u00A9reas..</param>
        /// <param name="ValorEntrada">Valor da Entrada em Real (BRL) quando a transa\u00C3\u00A7\u00C3\u00A3o for do tipo Parcelada com o pagamento de um valor de Entrada..</param>
        /// <param name="ValorBRL">Valor da Transa\u00C3\u00A7\u00C3\u00A3o em Real (BRL)..</param>
        /// <param name="CotacaoUSD">Valor do D\u00C3\u00B3lar Americano (USD) convertido em Real (BRL)..</param>
        /// <param name="ValorUSD">Valor da Transa\u00C3\u00A7\u00C3\u00A3o em D\u00C3\u00B3lar Americano (USD)..</param>
        /// <param name="DataCotacaoUSD">Data de Fechamento da Cota\u00C3\u00A7\u00C3\u00A3o do D\u00C3\u00B3lar Americano (USD)..</param>
        /// <param name="CodigoMoedaOrigem">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Moeda utilizada na Transa\u00C3\u00A7\u00C3\u00A3o, seguindo padr\u00C3\u00A3o ISO 4217..</param>
        /// <param name="CodigoMoedaDestino">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Moeda da Transa\u00C3\u00A7\u00C3\u00A3o ap\u00C3\u00B3s a convers\u00C3\u00A3o, seguindo padr\u00C3\u00A3o ISO 4217..</param>
        /// <param name="CodigoAutorizacao">C\u00C3\u00B3digo de Autoriza\u00C3\u00A7\u00C3\u00A3o da Transa\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="CodigoReferencia">C\u00C3\u00B3digo de Refer\u00C3\u00AAncia da Transa\u00C3\u00A7\u00C3\u00A3o quando utilizado Cart\u00C3\u00A3o Bandeirado..</param>
        /// <param name="CodigoTerminal">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da origem da captura da Transa\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="CodigoMCC">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da categoria do Estabelecimento..</param>
        /// <param name="IdEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento (id)..</param>
        /// <param name="NomeEstabelecimento">Nome do Estabelecimento..</param>
        /// <param name="LocalidadeEstabelecimento">Localidade do Estabelecimento..</param>
        /// <param name="PlanoParcelamento">Quando a Transa\u00C3\u00A7\u00C3\u00A3o for do tipo Parcelada, apresenta o n\u00C3\u00BAmero total de Parcelas..</param>
        /// <param name="NumeroParcela">Quando a Transa\u00C3\u00A7\u00C3\u00A3o for do tipo Parcelada, apresenta o n\u00C3\u00BAmero da Parcela..</param>
        /// <param name="DetalhesTransacao">Detalhes complementares a respeito da Transa\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="FlagCredito">Quando ativa, indica que a Transa\u00C3\u00A7\u00C3\u00A3o \u00C3\u00A9 do Tipo &#39;Cr\u00C3\u00A9dito&#39;..</param>
        /// <param name="FlagFaturado">Quando ativa, indica que a Transa\u00C3\u00A7\u00C3\u00A3o foi consolidada em uma Fatura..</param>
        /// <param name="FlagEstorno">Quando ativa, indica que a Transa\u00C3\u00A7\u00C3\u00A3o foi estornada..</param>
        /// <param name="IdTransacaoEstorno">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Transa\u00C3\u00A7\u00C3\u00A3o (id) que gerou o estorno..</param>

        public TransacoesCorrentes(long? Id = null, string TipoTransacao = null, string StatusTransacao = null, long? IdEvento = null, string TipoEvento = null, long? IdConta = null, string CartaoMascarado = null, string NomePortador = null, string DataTransacaoUTC = null, DateTime? DataFaturamento = null, string DataVencimento = null, string ModoEntradaTransacao = null, double? ValorTaxaEmbarque = null, double? ValorEntrada = null, double? ValorBRL = null, double? CotacaoUSD = null, double? ValorUSD = null, DateTime? DataCotacaoUSD = null, string CodigoMoedaOrigem = null, string CodigoMoedaDestino = null, string CodigoAutorizacao = null, string CodigoReferencia = null, string CodigoTerminal = null, long? CodigoMCC = null, long? IdEstabelecimento = null, string NomeEstabelecimento = null, string LocalidadeEstabelecimento = null, long? PlanoParcelamento = null, long? NumeroParcela = null, string DetalhesTransacao = null, int? FlagCredito = null, int? FlagFaturado = null, int? FlagEstorno = null, long? IdTransacaoEstorno = null)
        {
            this.Id = Id;
            this.TipoTransacao = TipoTransacao;
            this.StatusTransacao = StatusTransacao;
            this.IdEvento = IdEvento;
            this.TipoEvento = TipoEvento;
            this.IdConta = IdConta;
            this.CartaoMascarado = CartaoMascarado;
            this.NomePortador = NomePortador;
            this.DataTransacaoUTC = DataTransacaoUTC;
            this.DataFaturamento = DataFaturamento;
            this.DataVencimento = DataVencimento;
            this.ModoEntradaTransacao = ModoEntradaTransacao;
            this.ValorTaxaEmbarque = ValorTaxaEmbarque;
            this.ValorEntrada = ValorEntrada;
            this.ValorBRL = ValorBRL;
            this.CotacaoUSD = CotacaoUSD;
            this.ValorUSD = ValorUSD;
            this.DataCotacaoUSD = DataCotacaoUSD;
            this.CodigoMoedaOrigem = CodigoMoedaOrigem;
            this.CodigoMoedaDestino = CodigoMoedaDestino;
            this.CodigoAutorizacao = CodigoAutorizacao;
            this.CodigoReferencia = CodigoReferencia;
            this.CodigoTerminal = CodigoTerminal;
            this.CodigoMCC = CodigoMCC;
            this.IdEstabelecimento = IdEstabelecimento;
            this.NomeEstabelecimento = NomeEstabelecimento;
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
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da transfer\u00C3\u00AAncia (id).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Descri\u00C3\u00A7\u00C3\u00A3o do Tipo da Transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Descri\u00C3\u00A7\u00C3\u00A3o do Tipo da Transa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="tipoTransacao", EmitDefaultValue=false)]
        public string TipoTransacao { get; set; }
    
        /// <summary>
        /// Status de Processamento da Transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Status de Processamento da Transa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="statusTransacao", EmitDefaultValue=false)]
        public string StatusTransacao { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Evento que originou a Transa\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Evento que originou a Transa\u00C3\u00A7\u00C3\u00A3o (id).</value>
        [DataMember(Name="idEvento", EmitDefaultValue=false)]
        public long? IdEvento { get; set; }
    
        /// <summary>
        /// Descri\u00C3\u00A7\u00C3\u00A3o do Evento que representa a Transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Descri\u00C3\u00A7\u00C3\u00A3o do Evento que representa a Transa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="tipoEvento", EmitDefaultValue=false)]
        public string TipoEvento { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id).</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero do Cart\u00C3\u00A3o em Formato 0000XXXXXXXX0000.
        /// </summary>
        /// <value>N\u00C3\u00BAmero do Cart\u00C3\u00A3o em Formato 0000XXXXXXXX0000.</value>
        [DataMember(Name="cartaoMascarado", EmitDefaultValue=false)]
        public string CartaoMascarado { get; set; }
    
        /// <summary>
        /// Nome completo do Portador do Cart\u00C3\u00A3o.
        /// </summary>
        /// <value>Nome completo do Portador do Cart\u00C3\u00A3o.</value>
        [DataMember(Name="nomePortador", EmitDefaultValue=false)]
        public string NomePortador { get; set; }
    
        /// <summary>
        /// Data em que a Transa\u00C3\u00A7\u00C3\u00A3o foi realizada sob o padr\u00C3\u00A3o de Tempo Universal Coordenado (UTC).
        /// </summary>
        /// <value>Data em que a Transa\u00C3\u00A7\u00C3\u00A3o foi realizada sob o padr\u00C3\u00A3o de Tempo Universal Coordenado (UTC).</value>
        [DataMember(Name="dataTransacaoUTC", EmitDefaultValue=false)]
        public string DataTransacaoUTC { get; set; }
    
        /// <summary>
        /// Data de Faturamento da Transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Data de Faturamento da Transa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="dataFaturamento", EmitDefaultValue=false)]
        public DateTime? DataFaturamento { get; set; }
    
        /// <summary>
        /// Data de Vencimento da Fatura.
        /// </summary>
        /// <value>Data de Vencimento da Fatura.</value>
        [DataMember(Name="dataVencimento", EmitDefaultValue=false)]
        public string DataVencimento { get; set; }
    
        /// <summary>
        /// Descreve o modo utilizado para realizar a leitura dos dados do cart\u00C3\u00A3o para realizar a Transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Descreve o modo utilizado para realizar a leitura dos dados do cart\u00C3\u00A3o para realizar a Transa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="modoEntradaTransacao", EmitDefaultValue=false)]
        public string ModoEntradaTransacao { get; set; }
    
        /// <summary>
        /// Valor da Taxa de Embarque em Real (BRL) quando a transa\u00C3\u00A7\u00C3\u00A3o for relacionada a Compra de Passagens A\u00C3\u00A9reas.
        /// </summary>
        /// <value>Valor da Taxa de Embarque em Real (BRL) quando a transa\u00C3\u00A7\u00C3\u00A3o for relacionada a Compra de Passagens A\u00C3\u00A9reas.</value>
        [DataMember(Name="valorTaxaEmbarque", EmitDefaultValue=false)]
        public double? ValorTaxaEmbarque { get; set; }
    
        /// <summary>
        /// Valor da Entrada em Real (BRL) quando a transa\u00C3\u00A7\u00C3\u00A3o for do tipo Parcelada com o pagamento de um valor de Entrada.
        /// </summary>
        /// <value>Valor da Entrada em Real (BRL) quando a transa\u00C3\u00A7\u00C3\u00A3o for do tipo Parcelada com o pagamento de um valor de Entrada.</value>
        [DataMember(Name="valorEntrada", EmitDefaultValue=false)]
        public double? ValorEntrada { get; set; }
    
        /// <summary>
        /// Valor da Transa\u00C3\u00A7\u00C3\u00A3o em Real (BRL).
        /// </summary>
        /// <value>Valor da Transa\u00C3\u00A7\u00C3\u00A3o em Real (BRL).</value>
        [DataMember(Name="valorBRL", EmitDefaultValue=false)]
        public double? ValorBRL { get; set; }
    
        /// <summary>
        /// Valor do D\u00C3\u00B3lar Americano (USD) convertido em Real (BRL).
        /// </summary>
        /// <value>Valor do D\u00C3\u00B3lar Americano (USD) convertido em Real (BRL).</value>
        [DataMember(Name="cotacaoUSD", EmitDefaultValue=false)]
        public double? CotacaoUSD { get; set; }
    
        /// <summary>
        /// Valor da Transa\u00C3\u00A7\u00C3\u00A3o em D\u00C3\u00B3lar Americano (USD).
        /// </summary>
        /// <value>Valor da Transa\u00C3\u00A7\u00C3\u00A3o em D\u00C3\u00B3lar Americano (USD).</value>
        [DataMember(Name="valorUSD", EmitDefaultValue=false)]
        public double? ValorUSD { get; set; }
    
        /// <summary>
        /// Data de Fechamento da Cota\u00C3\u00A7\u00C3\u00A3o do D\u00C3\u00B3lar Americano (USD).
        /// </summary>
        /// <value>Data de Fechamento da Cota\u00C3\u00A7\u00C3\u00A3o do D\u00C3\u00B3lar Americano (USD).</value>
        [DataMember(Name="dataCotacaoUSD", EmitDefaultValue=false)]
        public DateTime? DataCotacaoUSD { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Moeda utilizada na Transa\u00C3\u00A7\u00C3\u00A3o, seguindo padr\u00C3\u00A3o ISO 4217.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Moeda utilizada na Transa\u00C3\u00A7\u00C3\u00A3o, seguindo padr\u00C3\u00A3o ISO 4217.</value>
        [DataMember(Name="codigoMoedaOrigem", EmitDefaultValue=false)]
        public string CodigoMoedaOrigem { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Moeda da Transa\u00C3\u00A7\u00C3\u00A3o ap\u00C3\u00B3s a convers\u00C3\u00A3o, seguindo padr\u00C3\u00A3o ISO 4217.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Moeda da Transa\u00C3\u00A7\u00C3\u00A3o ap\u00C3\u00B3s a convers\u00C3\u00A3o, seguindo padr\u00C3\u00A3o ISO 4217.</value>
        [DataMember(Name="codigoMoedaDestino", EmitDefaultValue=false)]
        public string CodigoMoedaDestino { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Autoriza\u00C3\u00A7\u00C3\u00A3o da Transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Autoriza\u00C3\u00A7\u00C3\u00A3o da Transa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="codigoAutorizacao", EmitDefaultValue=false)]
        public string CodigoAutorizacao { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Refer\u00C3\u00AAncia da Transa\u00C3\u00A7\u00C3\u00A3o quando utilizado Cart\u00C3\u00A3o Bandeirado.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Refer\u00C3\u00AAncia da Transa\u00C3\u00A7\u00C3\u00A3o quando utilizado Cart\u00C3\u00A3o Bandeirado.</value>
        [DataMember(Name="codigoReferencia", EmitDefaultValue=false)]
        public string CodigoReferencia { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da origem da captura da Transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da origem da captura da Transa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="codigoTerminal", EmitDefaultValue=false)]
        public string CodigoTerminal { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da categoria do Estabelecimento.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da categoria do Estabelecimento.</value>
        [DataMember(Name="codigoMCC", EmitDefaultValue=false)]
        public long? CodigoMCC { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento (id).</value>
        [DataMember(Name="idEstabelecimento", EmitDefaultValue=false)]
        public long? IdEstabelecimento { get; set; }
    
        /// <summary>
        /// Nome do Estabelecimento.
        /// </summary>
        /// <value>Nome do Estabelecimento.</value>
        [DataMember(Name="nomeEstabelecimento", EmitDefaultValue=false)]
        public string NomeEstabelecimento { get; set; }
    
        /// <summary>
        /// Localidade do Estabelecimento.
        /// </summary>
        /// <value>Localidade do Estabelecimento.</value>
        [DataMember(Name="localidadeEstabelecimento", EmitDefaultValue=false)]
        public string LocalidadeEstabelecimento { get; set; }
    
        /// <summary>
        /// Quando a Transa\u00C3\u00A7\u00C3\u00A3o for do tipo Parcelada, apresenta o n\u00C3\u00BAmero total de Parcelas.
        /// </summary>
        /// <value>Quando a Transa\u00C3\u00A7\u00C3\u00A3o for do tipo Parcelada, apresenta o n\u00C3\u00BAmero total de Parcelas.</value>
        [DataMember(Name="planoParcelamento", EmitDefaultValue=false)]
        public long? PlanoParcelamento { get; set; }
    
        /// <summary>
        /// Quando a Transa\u00C3\u00A7\u00C3\u00A3o for do tipo Parcelada, apresenta o n\u00C3\u00BAmero da Parcela.
        /// </summary>
        /// <value>Quando a Transa\u00C3\u00A7\u00C3\u00A3o for do tipo Parcelada, apresenta o n\u00C3\u00BAmero da Parcela.</value>
        [DataMember(Name="numeroParcela", EmitDefaultValue=false)]
        public long? NumeroParcela { get; set; }
    
        /// <summary>
        /// Detalhes complementares a respeito da Transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Detalhes complementares a respeito da Transa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="detalhesTransacao", EmitDefaultValue=false)]
        public string DetalhesTransacao { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que a Transa\u00C3\u00A7\u00C3\u00A3o \u00C3\u00A9 do Tipo &#39;Cr\u00C3\u00A9dito&#39;.
        /// </summary>
        /// <value>Quando ativa, indica que a Transa\u00C3\u00A7\u00C3\u00A3o \u00C3\u00A9 do Tipo &#39;Cr\u00C3\u00A9dito&#39;.</value>
        [DataMember(Name="flagCredito", EmitDefaultValue=false)]
        public int? FlagCredito { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que a Transa\u00C3\u00A7\u00C3\u00A3o foi consolidada em uma Fatura.
        /// </summary>
        /// <value>Quando ativa, indica que a Transa\u00C3\u00A7\u00C3\u00A3o foi consolidada em uma Fatura.</value>
        [DataMember(Name="flagFaturado", EmitDefaultValue=false)]
        public int? FlagFaturado { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que a Transa\u00C3\u00A7\u00C3\u00A3o foi estornada.
        /// </summary>
        /// <value>Quando ativa, indica que a Transa\u00C3\u00A7\u00C3\u00A3o foi estornada.</value>
        [DataMember(Name="flagEstorno", EmitDefaultValue=false)]
        public int? FlagEstorno { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Transa\u00C3\u00A7\u00C3\u00A3o (id) que gerou o estorno.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Transa\u00C3\u00A7\u00C3\u00A3o (id) que gerou o estorno.</value>
        [DataMember(Name="idTransacaoEstorno", EmitDefaultValue=false)]
        public long? IdTransacaoEstorno { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransacoesCorrentes {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TipoTransacao: ").Append(TipoTransacao).Append("\n");
            sb.Append("  StatusTransacao: ").Append(StatusTransacao).Append("\n");
            sb.Append("  IdEvento: ").Append(IdEvento).Append("\n");
            sb.Append("  TipoEvento: ").Append(TipoEvento).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  CartaoMascarado: ").Append(CartaoMascarado).Append("\n");
            sb.Append("  NomePortador: ").Append(NomePortador).Append("\n");
            sb.Append("  DataTransacaoUTC: ").Append(DataTransacaoUTC).Append("\n");
            sb.Append("  DataFaturamento: ").Append(DataFaturamento).Append("\n");
            sb.Append("  DataVencimento: ").Append(DataVencimento).Append("\n");
            sb.Append("  ModoEntradaTransacao: ").Append(ModoEntradaTransacao).Append("\n");
            sb.Append("  ValorTaxaEmbarque: ").Append(ValorTaxaEmbarque).Append("\n");
            sb.Append("  ValorEntrada: ").Append(ValorEntrada).Append("\n");
            sb.Append("  ValorBRL: ").Append(ValorBRL).Append("\n");
            sb.Append("  CotacaoUSD: ").Append(CotacaoUSD).Append("\n");
            sb.Append("  ValorUSD: ").Append(ValorUSD).Append("\n");
            sb.Append("  DataCotacaoUSD: ").Append(DataCotacaoUSD).Append("\n");
            sb.Append("  CodigoMoedaOrigem: ").Append(CodigoMoedaOrigem).Append("\n");
            sb.Append("  CodigoMoedaDestino: ").Append(CodigoMoedaDestino).Append("\n");
            sb.Append("  CodigoAutorizacao: ").Append(CodigoAutorizacao).Append("\n");
            sb.Append("  CodigoReferencia: ").Append(CodigoReferencia).Append("\n");
            sb.Append("  CodigoTerminal: ").Append(CodigoTerminal).Append("\n");
            sb.Append("  CodigoMCC: ").Append(CodigoMCC).Append("\n");
            sb.Append("  IdEstabelecimento: ").Append(IdEstabelecimento).Append("\n");
            sb.Append("  NomeEstabelecimento: ").Append(NomeEstabelecimento).Append("\n");
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
            return this.Equals(obj as TransacoesCorrentes);
        }

        /// <summary>
        /// Returns true if TransacoesCorrentes instances are equal
        /// </summary>
        /// <param name="other">Instance of TransacoesCorrentes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransacoesCorrentes other)
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
                    this.TipoTransacao == other.TipoTransacao ||
                    this.TipoTransacao != null &&
                    this.TipoTransacao.Equals(other.TipoTransacao)
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
                    this.DataTransacaoUTC == other.DataTransacaoUTC ||
                    this.DataTransacaoUTC != null &&
                    this.DataTransacaoUTC.Equals(other.DataTransacaoUTC)
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
                    this.CotacaoUSD == other.CotacaoUSD ||
                    this.CotacaoUSD != null &&
                    this.CotacaoUSD.Equals(other.CotacaoUSD)
                ) && 
                (
                    this.ValorUSD == other.ValorUSD ||
                    this.ValorUSD != null &&
                    this.ValorUSD.Equals(other.ValorUSD)
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
                
                if (this.TipoTransacao != null)
                    hash = hash * 59 + this.TipoTransacao.GetHashCode();
                
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
                
                if (this.DataTransacaoUTC != null)
                    hash = hash * 59 + this.DataTransacaoUTC.GetHashCode();
                
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
                
                if (this.CotacaoUSD != null)
                    hash = hash * 59 + this.CotacaoUSD.GetHashCode();
                
                if (this.ValorUSD != null)
                    hash = hash * 59 + this.ValorUSD.GetHashCode();
                
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
                
                if (this.IdEstabelecimento != null)
                    hash = hash * 59 + this.IdEstabelecimento.GetHashCode();
                
                if (this.NomeEstabelecimento != null)
                    hash = hash * 59 + this.NomeEstabelecimento.GetHashCode();
                
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
