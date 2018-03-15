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
    /// Objeto transacao N\u00E3o Processada
    /// </summary>
    [DataContract]
    public partial class TransacaoNaoProcessadaResponse :  IEquatable<TransacaoNaoProcessadaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransacaoNaoProcessadaResponse" /> class.
        /// Initializes a new instance of the <see cref="TransacaoNaoProcessadaResponse" />class.
        /// </summary>
        /// <param name="IdTipoTransacaoNaoProcessada">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo da Transa\u00E7\u00E3o..</param>
        /// <param name="DescricaoTipoTransacaoNaoProcessada">Descri\u00E7\u00E3o do Tipo da Transa\u00E7\u00E3o n\u00E3o Processada..</param>
        /// <param name="DescricaoAbreviada">Descri\u00E7\u00E3o Abreviada da Transa\u00E7\u00E3o..</param>
        /// <param name="IdConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id)..</param>
        /// <param name="CartaoMascarado">N\u00FAmero do Cart\u00E3o em Formato 0000XXXXXXXX0000..</param>
        /// <param name="NomePortador">Nome completo do Portador do Cart\u00E3o..</param>
        /// <param name="DataOrigem">Data em que a Transa\u00E7\u00E3o foi realizada..</param>
        /// <param name="DataFaturamento">Data de Faturamento da Transa\u00E7\u00E3o..</param>
        /// <param name="DataVencimento">Data de Vencimento da Fatura..</param>
        /// <param name="ModoEntradaTransacao">Descreve o modo utilizado para realizar a leitura dos dados do cart\u00E3o para realizar a Transa\u00E7\u00E3o..</param>
        /// <param name="ValorTaxaEmbarque">Valor da Taxa de Embarque em Real (BRL) quando a transa\u00E7\u00E3o for relacionada a Compra de Passagens A\u00E9reas..</param>
        /// <param name="ValorEntrada">Valor da Entrada em Real (BRL) quando a transa\u00E7\u00E3o for do tipo Parcelada com o pagamento de um valor de Entrada..</param>
        /// <param name="ValorBRL">Valor da Transa\u00E7\u00E3o em Real (BRL)..</param>
        /// <param name="ValorUSD">Valor da Transa\u00E7\u00E3o em D\u00F3lar Americano (USD)..</param>
        /// <param name="CotacaoUSD">Valor do D\u00F3lar Americano (USD) convertido em Real (BRL)..</param>
        /// <param name="DataCotacaoUSD">Data de Fechamento da Cota\u00E7\u00E3o do D\u00F3lar Americano (USD)..</param>
        /// <param name="CodigoMoedaOrigem">C\u00F3digo de Identifica\u00E7\u00E3o da Moeda utilizada na Transa\u00E7\u00E3o, seguindo padr\u00E3o ISO 4217..</param>
        /// <param name="CodigoMoedaDestino">C\u00F3digo de Identifica\u00E7\u00E3o da Moeda da Transa\u00E7\u00E3o ap\u00F3s a convers\u00E3o, seguindo padr\u00E3o ISO 4217..</param>
        /// <param name="CodigoAutorizacao">C\u00F3digo de Autoriza\u00E7\u00E3o da Transa\u00E7\u00E3o..</param>
        /// <param name="CodigoReferencia">C\u00F3digo de Refer\u00EAncia da Transa\u00E7\u00E3o quando utilizado Cart\u00E3o Bandeirado..</param>
        /// <param name="CodigoTerminal">C\u00F3digo de Identifica\u00E7\u00E3o da origem da captura da Transa\u00E7\u00E3o..</param>
        /// <param name="CodigoMCC">C\u00F3digo de identifica\u00E7\u00E3o da categoria do Estabelecimento..</param>
        /// <param name="GrupoMCC">C\u00F3digo de identifica\u00E7\u00E3o do grupo do Estabelecimento..</param>
        /// <param name="GrupoDescricaoMCC">Descri\u00E7\u00E3o do grupo do Estabelecimento..</param>
        /// <param name="IdEstabelecimento">C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento (id)..</param>
        /// <param name="NomeEstabelecimento">Nome do Estabelecimento..</param>
        /// <param name="NomeFantasiaEstabelecimento">Nome Fantasia do Estabelecimento..</param>
        /// <param name="LocalidadeEstabelecimento">Localidade do Estabelecimento..</param>
        /// <param name="PlanoParcelamento">Quando a Transa\u00E7\u00E3o for do tipo Parcelada, apresenta o n\u00FAmero total de Parcelas..</param>
        /// <param name="NumeroParcela">Quando a Transa\u00E7\u00E3o for do tipo Parcelada, apresenta o n\u00FAmero da Parcela..</param>
        /// <param name="DetalhesTransacao">Detalhes complementares a respeito da Transa\u00E7\u00E3o..</param>
        /// <param name="FlagCredito">Quando ativa, indica que a Transa\u00E7\u00E3o \u00E9 do Tipo &#39;Cr\u00E9dito&#39;..</param>
        /// <param name="FlagFaturado">Quando ativa, indica que a Transa\u00E7\u00E3o foi consolidada em uma Fatura..</param>
        /// <param name="FlagEstorno">Quando ativa, indica que a Transa\u00E7\u00E3o foi estornada..</param>
        /// <param name="IdTransacaoEstorno">C\u00F3digo de Identifica\u00E7\u00E3o da Transa\u00E7\u00E3o (id) que gerou o estorno..</param>
        /// <param name="Status">Atributo que representa o c\u00F3digo identificador do status da transa\u00E7\u00E3o..</param>

        public TransacaoNaoProcessadaResponse(long? IdTipoTransacaoNaoProcessada = null, string DescricaoTipoTransacaoNaoProcessada = null, string DescricaoAbreviada = null, long? IdConta = null, string CartaoMascarado = null, string NomePortador = null, string DataOrigem = null, string DataFaturamento = null, string DataVencimento = null, string ModoEntradaTransacao = null, double? ValorTaxaEmbarque = null, double? ValorEntrada = null, double? ValorBRL = null, double? ValorUSD = null, double? CotacaoUSD = null, string DataCotacaoUSD = null, string CodigoMoedaOrigem = null, string CodigoMoedaDestino = null, string CodigoAutorizacao = null, string CodigoReferencia = null, string CodigoTerminal = null, long? CodigoMCC = null, long? GrupoMCC = null, string GrupoDescricaoMCC = null, long? IdEstabelecimento = null, string NomeEstabelecimento = null, string NomeFantasiaEstabelecimento = null, string LocalidadeEstabelecimento = null, long? PlanoParcelamento = null, long? NumeroParcela = null, string DetalhesTransacao = null, int? FlagCredito = null, int? FlagFaturado = null, int? FlagEstorno = null, long? IdTransacaoEstorno = null, int? Status = null)
        {
            this.IdTipoTransacaoNaoProcessada = IdTipoTransacaoNaoProcessada;
            this.DescricaoTipoTransacaoNaoProcessada = DescricaoTipoTransacaoNaoProcessada;
            this.DescricaoAbreviada = DescricaoAbreviada;
            this.IdConta = IdConta;
            this.CartaoMascarado = CartaoMascarado;
            this.NomePortador = NomePortador;
            this.DataOrigem = DataOrigem;
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
            this.Status = Status;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do Tipo da Transa\u00E7\u00E3o.
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do Tipo da Transa\u00E7\u00E3o.</value>
        [DataMember(Name="idTipoTransacaoNaoProcessada", EmitDefaultValue=false)]
        public long? IdTipoTransacaoNaoProcessada { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do Tipo da Transa\u00E7\u00E3o n\u00E3o Processada.
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do Tipo da Transa\u00E7\u00E3o n\u00E3o Processada.</value>
        [DataMember(Name="descricaoTipoTransacaoNaoProcessada", EmitDefaultValue=false)]
        public string DescricaoTipoTransacaoNaoProcessada { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o Abreviada da Transa\u00E7\u00E3o.
        /// </summary>
        /// <value>Descri\u00E7\u00E3o Abreviada da Transa\u00E7\u00E3o.</value>
        [DataMember(Name="descricaoAbreviada", EmitDefaultValue=false)]
        public string DescricaoAbreviada { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id).
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da Conta (id).</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// N\u00FAmero do Cart\u00E3o em Formato 0000XXXXXXXX0000.
        /// </summary>
        /// <value>N\u00FAmero do Cart\u00E3o em Formato 0000XXXXXXXX0000.</value>
        [DataMember(Name="cartaoMascarado", EmitDefaultValue=false)]
        public string CartaoMascarado { get; set; }
    
        /// <summary>
        /// Nome completo do Portador do Cart\u00E3o.
        /// </summary>
        /// <value>Nome completo do Portador do Cart\u00E3o.</value>
        [DataMember(Name="nomePortador", EmitDefaultValue=false)]
        public string NomePortador { get; set; }
    
        /// <summary>
        /// Data em que a Transa\u00E7\u00E3o foi realizada.
        /// </summary>
        /// <value>Data em que a Transa\u00E7\u00E3o foi realizada.</value>
        [DataMember(Name="dataOrigem", EmitDefaultValue=false)]
        public string DataOrigem { get; set; }
    
        /// <summary>
        /// Data de Faturamento da Transa\u00E7\u00E3o.
        /// </summary>
        /// <value>Data de Faturamento da Transa\u00E7\u00E3o.</value>
        [DataMember(Name="dataFaturamento", EmitDefaultValue=false)]
        public string DataFaturamento { get; set; }
    
        /// <summary>
        /// Data de Vencimento da Fatura.
        /// </summary>
        /// <value>Data de Vencimento da Fatura.</value>
        [DataMember(Name="dataVencimento", EmitDefaultValue=false)]
        public string DataVencimento { get; set; }
    
        /// <summary>
        /// Descreve o modo utilizado para realizar a leitura dos dados do cart\u00E3o para realizar a Transa\u00E7\u00E3o.
        /// </summary>
        /// <value>Descreve o modo utilizado para realizar a leitura dos dados do cart\u00E3o para realizar a Transa\u00E7\u00E3o.</value>
        [DataMember(Name="modoEntradaTransacao", EmitDefaultValue=false)]
        public string ModoEntradaTransacao { get; set; }
    
        /// <summary>
        /// Valor da Taxa de Embarque em Real (BRL) quando a transa\u00E7\u00E3o for relacionada a Compra de Passagens A\u00E9reas.
        /// </summary>
        /// <value>Valor da Taxa de Embarque em Real (BRL) quando a transa\u00E7\u00E3o for relacionada a Compra de Passagens A\u00E9reas.</value>
        [DataMember(Name="valorTaxaEmbarque", EmitDefaultValue=false)]
        public double? ValorTaxaEmbarque { get; set; }
    
        /// <summary>
        /// Valor da Entrada em Real (BRL) quando a transa\u00E7\u00E3o for do tipo Parcelada com o pagamento de um valor de Entrada.
        /// </summary>
        /// <value>Valor da Entrada em Real (BRL) quando a transa\u00E7\u00E3o for do tipo Parcelada com o pagamento de um valor de Entrada.</value>
        [DataMember(Name="valorEntrada", EmitDefaultValue=false)]
        public double? ValorEntrada { get; set; }
    
        /// <summary>
        /// Valor da Transa\u00E7\u00E3o em Real (BRL).
        /// </summary>
        /// <value>Valor da Transa\u00E7\u00E3o em Real (BRL).</value>
        [DataMember(Name="valorBRL", EmitDefaultValue=false)]
        public double? ValorBRL { get; set; }
    
        /// <summary>
        /// Valor da Transa\u00E7\u00E3o em D\u00F3lar Americano (USD).
        /// </summary>
        /// <value>Valor da Transa\u00E7\u00E3o em D\u00F3lar Americano (USD).</value>
        [DataMember(Name="valorUSD", EmitDefaultValue=false)]
        public double? ValorUSD { get; set; }
    
        /// <summary>
        /// Valor do D\u00F3lar Americano (USD) convertido em Real (BRL).
        /// </summary>
        /// <value>Valor do D\u00F3lar Americano (USD) convertido em Real (BRL).</value>
        [DataMember(Name="cotacaoUSD", EmitDefaultValue=false)]
        public double? CotacaoUSD { get; set; }
    
        /// <summary>
        /// Data de Fechamento da Cota\u00E7\u00E3o do D\u00F3lar Americano (USD).
        /// </summary>
        /// <value>Data de Fechamento da Cota\u00E7\u00E3o do D\u00F3lar Americano (USD).</value>
        [DataMember(Name="dataCotacaoUSD", EmitDefaultValue=false)]
        public string DataCotacaoUSD { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da Moeda utilizada na Transa\u00E7\u00E3o, seguindo padr\u00E3o ISO 4217.
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da Moeda utilizada na Transa\u00E7\u00E3o, seguindo padr\u00E3o ISO 4217.</value>
        [DataMember(Name="codigoMoedaOrigem", EmitDefaultValue=false)]
        public string CodigoMoedaOrigem { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da Moeda da Transa\u00E7\u00E3o ap\u00F3s a convers\u00E3o, seguindo padr\u00E3o ISO 4217.
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da Moeda da Transa\u00E7\u00E3o ap\u00F3s a convers\u00E3o, seguindo padr\u00E3o ISO 4217.</value>
        [DataMember(Name="codigoMoedaDestino", EmitDefaultValue=false)]
        public string CodigoMoedaDestino { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Autoriza\u00E7\u00E3o da Transa\u00E7\u00E3o.
        /// </summary>
        /// <value>C\u00F3digo de Autoriza\u00E7\u00E3o da Transa\u00E7\u00E3o.</value>
        [DataMember(Name="codigoAutorizacao", EmitDefaultValue=false)]
        public string CodigoAutorizacao { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Refer\u00EAncia da Transa\u00E7\u00E3o quando utilizado Cart\u00E3o Bandeirado.
        /// </summary>
        /// <value>C\u00F3digo de Refer\u00EAncia da Transa\u00E7\u00E3o quando utilizado Cart\u00E3o Bandeirado.</value>
        [DataMember(Name="codigoReferencia", EmitDefaultValue=false)]
        public string CodigoReferencia { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da origem da captura da Transa\u00E7\u00E3o.
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da origem da captura da Transa\u00E7\u00E3o.</value>
        [DataMember(Name="codigoTerminal", EmitDefaultValue=false)]
        public string CodigoTerminal { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da categoria do Estabelecimento.
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da categoria do Estabelecimento.</value>
        [DataMember(Name="codigoMCC", EmitDefaultValue=false)]
        public long? CodigoMCC { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do grupo do Estabelecimento.
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do grupo do Estabelecimento.</value>
        [DataMember(Name="grupoMCC", EmitDefaultValue=false)]
        public long? GrupoMCC { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do grupo do Estabelecimento.
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do grupo do Estabelecimento.</value>
        [DataMember(Name="grupoDescricaoMCC", EmitDefaultValue=false)]
        public string GrupoDescricaoMCC { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento (id).
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do Estabelecimento (id).</value>
        [DataMember(Name="idEstabelecimento", EmitDefaultValue=false)]
        public long? IdEstabelecimento { get; set; }
    
        /// <summary>
        /// Nome do Estabelecimento.
        /// </summary>
        /// <value>Nome do Estabelecimento.</value>
        [DataMember(Name="nomeEstabelecimento", EmitDefaultValue=false)]
        public string NomeEstabelecimento { get; set; }
    
        /// <summary>
        /// Nome Fantasia do Estabelecimento.
        /// </summary>
        /// <value>Nome Fantasia do Estabelecimento.</value>
        [DataMember(Name="nomeFantasiaEstabelecimento", EmitDefaultValue=false)]
        public string NomeFantasiaEstabelecimento { get; set; }
    
        /// <summary>
        /// Localidade do Estabelecimento.
        /// </summary>
        /// <value>Localidade do Estabelecimento.</value>
        [DataMember(Name="localidadeEstabelecimento", EmitDefaultValue=false)]
        public string LocalidadeEstabelecimento { get; set; }
    
        /// <summary>
        /// Quando a Transa\u00E7\u00E3o for do tipo Parcelada, apresenta o n\u00FAmero total de Parcelas.
        /// </summary>
        /// <value>Quando a Transa\u00E7\u00E3o for do tipo Parcelada, apresenta o n\u00FAmero total de Parcelas.</value>
        [DataMember(Name="planoParcelamento", EmitDefaultValue=false)]
        public long? PlanoParcelamento { get; set; }
    
        /// <summary>
        /// Quando a Transa\u00E7\u00E3o for do tipo Parcelada, apresenta o n\u00FAmero da Parcela.
        /// </summary>
        /// <value>Quando a Transa\u00E7\u00E3o for do tipo Parcelada, apresenta o n\u00FAmero da Parcela.</value>
        [DataMember(Name="numeroParcela", EmitDefaultValue=false)]
        public long? NumeroParcela { get; set; }
    
        /// <summary>
        /// Detalhes complementares a respeito da Transa\u00E7\u00E3o.
        /// </summary>
        /// <value>Detalhes complementares a respeito da Transa\u00E7\u00E3o.</value>
        [DataMember(Name="detalhesTransacao", EmitDefaultValue=false)]
        public string DetalhesTransacao { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que a Transa\u00E7\u00E3o \u00E9 do Tipo &#39;Cr\u00E9dito&#39;.
        /// </summary>
        /// <value>Quando ativa, indica que a Transa\u00E7\u00E3o \u00E9 do Tipo &#39;Cr\u00E9dito&#39;.</value>
        [DataMember(Name="flagCredito", EmitDefaultValue=false)]
        public int? FlagCredito { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que a Transa\u00E7\u00E3o foi consolidada em uma Fatura.
        /// </summary>
        /// <value>Quando ativa, indica que a Transa\u00E7\u00E3o foi consolidada em uma Fatura.</value>
        [DataMember(Name="flagFaturado", EmitDefaultValue=false)]
        public int? FlagFaturado { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que a Transa\u00E7\u00E3o foi estornada.
        /// </summary>
        /// <value>Quando ativa, indica que a Transa\u00E7\u00E3o foi estornada.</value>
        [DataMember(Name="flagEstorno", EmitDefaultValue=false)]
        public int? FlagEstorno { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da Transa\u00E7\u00E3o (id) que gerou o estorno.
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da Transa\u00E7\u00E3o (id) que gerou o estorno.</value>
        [DataMember(Name="idTransacaoEstorno", EmitDefaultValue=false)]
        public long? IdTransacaoEstorno { get; set; }
    
        /// <summary>
        /// Atributo que representa o c\u00F3digo identificador do status da transa\u00E7\u00E3o.
        /// </summary>
        /// <value>Atributo que representa o c\u00F3digo identificador do status da transa\u00E7\u00E3o.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransacaoNaoProcessadaResponse {\n");
            sb.Append("  IdTipoTransacaoNaoProcessada: ").Append(IdTipoTransacaoNaoProcessada).Append("\n");
            sb.Append("  DescricaoTipoTransacaoNaoProcessada: ").Append(DescricaoTipoTransacaoNaoProcessada).Append("\n");
            sb.Append("  DescricaoAbreviada: ").Append(DescricaoAbreviada).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  CartaoMascarado: ").Append(CartaoMascarado).Append("\n");
            sb.Append("  NomePortador: ").Append(NomePortador).Append("\n");
            sb.Append("  DataOrigem: ").Append(DataOrigem).Append("\n");
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
            sb.Append("  Status: ").Append(Status).Append("\n");
            
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
                    this.IdTipoTransacaoNaoProcessada == other.IdTipoTransacaoNaoProcessada ||
                    this.IdTipoTransacaoNaoProcessada != null &&
                    this.IdTipoTransacaoNaoProcessada.Equals(other.IdTipoTransacaoNaoProcessada)
                ) && 
                (
                    this.DescricaoTipoTransacaoNaoProcessada == other.DescricaoTipoTransacaoNaoProcessada ||
                    this.DescricaoTipoTransacaoNaoProcessada != null &&
                    this.DescricaoTipoTransacaoNaoProcessada.Equals(other.DescricaoTipoTransacaoNaoProcessada)
                ) && 
                (
                    this.DescricaoAbreviada == other.DescricaoAbreviada ||
                    this.DescricaoAbreviada != null &&
                    this.DescricaoAbreviada.Equals(other.DescricaoAbreviada)
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
                    this.DataOrigem == other.DataOrigem ||
                    this.DataOrigem != null &&
                    this.DataOrigem.Equals(other.DataOrigem)
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
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                
                if (this.IdTipoTransacaoNaoProcessada != null)
                    hash = hash * 59 + this.IdTipoTransacaoNaoProcessada.GetHashCode();
                
                if (this.DescricaoTipoTransacaoNaoProcessada != null)
                    hash = hash * 59 + this.DescricaoTipoTransacaoNaoProcessada.GetHashCode();
                
                if (this.DescricaoAbreviada != null)
                    hash = hash * 59 + this.DescricaoAbreviada.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.CartaoMascarado != null)
                    hash = hash * 59 + this.CartaoMascarado.GetHashCode();
                
                if (this.NomePortador != null)
                    hash = hash * 59 + this.NomePortador.GetHashCode();
                
                if (this.DataOrigem != null)
                    hash = hash * 59 + this.DataOrigem.GetHashCode();
                
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
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }
}
