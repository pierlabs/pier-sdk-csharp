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
    /// {{{transacao_processada_nao_processada_response_description}}}
    /// </summary>
    [DataContract]
    public partial class TransacaoProcessadaNaoProcessadaResponse :  IEquatable<TransacaoProcessadaNaoProcessadaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransacaoProcessadaNaoProcessadaResponse" /> class.
        /// Initializes a new instance of the <see cref="TransacaoProcessadaNaoProcessadaResponse" />class.
        /// </summary>
        /// <param name="CartaoMascarado">{{{transacao_nao_processada_response_cartao_mascarado_value}}}.</param>
        /// <param name="CodigoAutorizacao">{{{transacao_nao_processada_response_codigo_autorizacao_value}}}.</param>
        /// <param name="CodigoMCC">{{{transacao_nao_processada_response_codigo_mcc_value}}}.</param>
        /// <param name="CodigoMoedaDestino">{{{transacao_nao_processada_response_codigo_moeda_destino_value}}}.</param>
        /// <param name="CodigoMoedaOrigem">{{{transacao_nao_processada_response_codigo_moeda_origem_value}}}.</param>
        /// <param name="CodigoReferencia">{{{transacao_nao_processada_response_codigo_referencia_value}}}.</param>
        /// <param name="CodigoTerminal">{{{transacao_nao_processada_response_codigo_terminal_value}}}.</param>
        /// <param name="CotacaoUSD">{{{transacao_nao_processada_response_cotacao_usd_value}}}.</param>
        /// <param name="DataCotacaoUSD">{{{transacao_nao_processada_response_data_cotacao_usd_value}}}.</param>
        /// <param name="DataFaturamento">{{{transacao_nao_processada_response_data_faturamento_value}}}.</param>
        /// <param name="DataOrigem">{{{transacao_nao_processada_response_data_origem_value}}}.</param>
        /// <param name="DataVencimentoReal">{{{transacao_nao_processada_response_data_vencimento_value}}}.</param>
        /// <param name="DescricaoAbreviada">{{{transacao_nao_processada_response_descricao_abreviada_value}}}.</param>
        /// <param name="DescricaoTipoTransacaoNaoProcessada">{{{transacao_nao_processada_response_descricao_tipo_transacao_nao_processada_value}}}.</param>
        /// <param name="FlagCredito">{{{transacao_nao_processada_response_flag_credito_value}}}.</param>
        /// <param name="FlagFaturado">{{{transacao_nao_processada_response_flag_faturado_value}}}.</param>
        /// <param name="GrupoDescricaoMCC">{{{transacao_nao_processada_response_grupo_descricao_mcc_value}}}.</param>
        /// <param name="GrupoMCC">{{{transacao_nao_processada_response_grupo_mcc_value}}}.</param>
        /// <param name="IdConta">{{{transacao_nao_processada_response_id_conta_value}}}.</param>
        /// <param name="IdEstabelecimento">{{{transacao_nao_processada_response_id_estabelecimento_value}}}.</param>
        /// <param name="IdTipoTransacaoNaoProcessada">{{{transacao_nao_processada_response_id_tipo_transacao_nao_processada_value}}}.</param>
        /// <param name="IdTransacaoEstorno">{{{transacao_nao_processada_response_id_transacao_estorno_value}}}.</param>
        /// <param name="LocalidadeEstabelecimento">{{{transacao_nao_processada_response_localidade_estabelecimento_value}}}.</param>
        /// <param name="ModoEntradaTransacao">{{{transacao_nao_processada_response_modo_entrada_transacao_value}}}.</param>
        /// <param name="NomeEstabelecimento">{{{transacao_nao_processada_response_nome_estabelecimento_value}}}.</param>
        /// <param name="NomeFantasiaEstabelecimento">{{{transacao_nao_processada_response_nome_fantasia_estabelecimento_value}}}.</param>
        /// <param name="NomePortador">{{{transacao_nao_processada_response_nome_portador_value}}}.</param>
        /// <param name="Parcela">{{{transacao_nao_processada_response_numero_parcela_value}}}.</param>
        /// <param name="Plano">{{{transacao_nao_processada_response_plano_parcelamento_value}}}.</param>
        /// <param name="Status">{{{transacao_nao_processada_response_status_value}}}.</param>
        /// <param name="TaxaEmbarque">{{{transacao_nao_processada_response_valor_taxa_embarque_value}}}.</param>
        /// <param name="ValorBRL">{{{transacao_nao_processada_response_valor_brl_value}}}.</param>
        /// <param name="ValorEntrada">{{{transacao_nao_processada_response_valor_entrada_value}}}.</param>
        /// <param name="ValorUSD">{{{transacao_nao_processada_response_valor_usd_value}}}.</param>

        public TransacaoProcessadaNaoProcessadaResponse(string CartaoMascarado = null, string CodigoAutorizacao = null, long? CodigoMCC = null, string CodigoMoedaDestino = null, string CodigoMoedaOrigem = null, string CodigoReferencia = null, string CodigoTerminal = null, double? CotacaoUSD = null, string DataCotacaoUSD = null, string DataFaturamento = null, string DataOrigem = null, string DataVencimentoReal = null, string DescricaoAbreviada = null, string DescricaoTipoTransacaoNaoProcessada = null, int? FlagCredito = null, int? FlagFaturado = null, string GrupoDescricaoMCC = null, long? GrupoMCC = null, long? IdConta = null, long? IdEstabelecimento = null, long? IdTipoTransacaoNaoProcessada = null, long? IdTransacaoEstorno = null, string LocalidadeEstabelecimento = null, string ModoEntradaTransacao = null, string NomeEstabelecimento = null, string NomeFantasiaEstabelecimento = null, string NomePortador = null, long? Parcela = null, long? Plano = null, int? Status = null, double? TaxaEmbarque = null, double? ValorBRL = null, double? ValorEntrada = null, double? ValorUSD = null)
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
        /// {{{transacao_nao_processada_response_cartao_mascarado_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_cartao_mascarado_value}}}</value>
        [DataMember(Name="cartaoMascarado", EmitDefaultValue=false)]
        public string CartaoMascarado { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_codigo_autorizacao_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_codigo_autorizacao_value}}}</value>
        [DataMember(Name="codigoAutorizacao", EmitDefaultValue=false)]
        public string CodigoAutorizacao { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_codigo_mcc_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_codigo_mcc_value}}}</value>
        [DataMember(Name="codigoMCC", EmitDefaultValue=false)]
        public long? CodigoMCC { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_codigo_moeda_destino_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_codigo_moeda_destino_value}}}</value>
        [DataMember(Name="codigoMoedaDestino", EmitDefaultValue=false)]
        public string CodigoMoedaDestino { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_codigo_moeda_origem_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_codigo_moeda_origem_value}}}</value>
        [DataMember(Name="codigoMoedaOrigem", EmitDefaultValue=false)]
        public string CodigoMoedaOrigem { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_codigo_referencia_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_codigo_referencia_value}}}</value>
        [DataMember(Name="codigoReferencia", EmitDefaultValue=false)]
        public string CodigoReferencia { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_codigo_terminal_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_codigo_terminal_value}}}</value>
        [DataMember(Name="codigoTerminal", EmitDefaultValue=false)]
        public string CodigoTerminal { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_cotacao_usd_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_cotacao_usd_value}}}</value>
        [DataMember(Name="cotacaoUSD", EmitDefaultValue=false)]
        public double? CotacaoUSD { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_data_cotacao_usd_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_data_cotacao_usd_value}}}</value>
        [DataMember(Name="dataCotacaoUSD", EmitDefaultValue=false)]
        public string DataCotacaoUSD { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_data_faturamento_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_data_faturamento_value}}}</value>
        [DataMember(Name="dataFaturamento", EmitDefaultValue=false)]
        public string DataFaturamento { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_data_origem_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_data_origem_value}}}</value>
        [DataMember(Name="dataOrigem", EmitDefaultValue=false)]
        public string DataOrigem { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_data_vencimento_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_data_vencimento_value}}}</value>
        [DataMember(Name="dataVencimentoReal", EmitDefaultValue=false)]
        public string DataVencimentoReal { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_descricao_abreviada_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_descricao_abreviada_value}}}</value>
        [DataMember(Name="descricaoAbreviada", EmitDefaultValue=false)]
        public string DescricaoAbreviada { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_descricao_tipo_transacao_nao_processada_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_descricao_tipo_transacao_nao_processada_value}}}</value>
        [DataMember(Name="descricaoTipoTransacaoNaoProcessada", EmitDefaultValue=false)]
        public string DescricaoTipoTransacaoNaoProcessada { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_flag_credito_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_flag_credito_value}}}</value>
        [DataMember(Name="flagCredito", EmitDefaultValue=false)]
        public int? FlagCredito { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_flag_faturado_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_flag_faturado_value}}}</value>
        [DataMember(Name="flagFaturado", EmitDefaultValue=false)]
        public int? FlagFaturado { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_grupo_descricao_mcc_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_grupo_descricao_mcc_value}}}</value>
        [DataMember(Name="grupoDescricaoMCC", EmitDefaultValue=false)]
        public string GrupoDescricaoMCC { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_grupo_mcc_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_grupo_mcc_value}}}</value>
        [DataMember(Name="grupoMCC", EmitDefaultValue=false)]
        public long? GrupoMCC { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_id_estabelecimento_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_id_estabelecimento_value}}}</value>
        [DataMember(Name="idEstabelecimento", EmitDefaultValue=false)]
        public long? IdEstabelecimento { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_id_tipo_transacao_nao_processada_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_id_tipo_transacao_nao_processada_value}}}</value>
        [DataMember(Name="idTipoTransacaoNaoProcessada", EmitDefaultValue=false)]
        public long? IdTipoTransacaoNaoProcessada { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_id_transacao_estorno_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_id_transacao_estorno_value}}}</value>
        [DataMember(Name="idTransacaoEstorno", EmitDefaultValue=false)]
        public long? IdTransacaoEstorno { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_localidade_estabelecimento_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_localidade_estabelecimento_value}}}</value>
        [DataMember(Name="localidadeEstabelecimento", EmitDefaultValue=false)]
        public string LocalidadeEstabelecimento { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_modo_entrada_transacao_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_modo_entrada_transacao_value}}}</value>
        [DataMember(Name="modoEntradaTransacao", EmitDefaultValue=false)]
        public string ModoEntradaTransacao { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_nome_estabelecimento_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_nome_estabelecimento_value}}}</value>
        [DataMember(Name="nomeEstabelecimento", EmitDefaultValue=false)]
        public string NomeEstabelecimento { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_nome_fantasia_estabelecimento_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_nome_fantasia_estabelecimento_value}}}</value>
        [DataMember(Name="nomeFantasiaEstabelecimento", EmitDefaultValue=false)]
        public string NomeFantasiaEstabelecimento { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_nome_portador_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_nome_portador_value}}}</value>
        [DataMember(Name="nomePortador", EmitDefaultValue=false)]
        public string NomePortador { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_numero_parcela_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_numero_parcela_value}}}</value>
        [DataMember(Name="parcela", EmitDefaultValue=false)]
        public long? Parcela { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_plano_parcelamento_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_plano_parcelamento_value}}}</value>
        [DataMember(Name="plano", EmitDefaultValue=false)]
        public long? Plano { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_status_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_status_value}}}</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_valor_taxa_embarque_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_valor_taxa_embarque_value}}}</value>
        [DataMember(Name="taxaEmbarque", EmitDefaultValue=false)]
        public double? TaxaEmbarque { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_valor_brl_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_valor_brl_value}}}</value>
        [DataMember(Name="valorBRL", EmitDefaultValue=false)]
        public double? ValorBRL { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_valor_entrada_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_valor_entrada_value}}}</value>
        [DataMember(Name="valorEntrada", EmitDefaultValue=false)]
        public double? ValorEntrada { get; set; }
    
        /// <summary>
        /// {{{transacao_nao_processada_response_valor_usd_value}}}
        /// </summary>
        /// <value>{{{transacao_nao_processada_response_valor_usd_value}}}</value>
        [DataMember(Name="valorUSD", EmitDefaultValue=false)]
        public double? ValorUSD { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransacaoProcessadaNaoProcessadaResponse {\n");
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
            return this.Equals(obj as TransacaoProcessadaNaoProcessadaResponse);
        }

        /// <summary>
        /// Returns true if TransacaoProcessadaNaoProcessadaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TransacaoProcessadaNaoProcessadaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransacaoProcessadaNaoProcessadaResponse other)
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
