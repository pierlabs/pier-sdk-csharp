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
    /// {{{conta_detalhe_response_description}}}
    /// </summary>
    [DataContract]
    public partial class ContaDetalheResponse :  IEquatable<ContaDetalheResponse>
    { 
    
        /// <summary>
        /// {{{conta_response_funcao_ativa_value}}}
        /// </summary>
        /// <value>{{{conta_response_funcao_ativa_value}}}</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FuncaoAtivaEnum {
            
            [EnumMember(Value = "DEBITO_CREDITO")]
            DebitoCredito,
            
            [EnumMember(Value = "CREDITO")]
            Credito
        }

    
        /// <summary>
        /// {{{conta_response_funcao_ativa_value}}}
        /// </summary>
        /// <value>{{{conta_response_funcao_ativa_value}}}</value>
        [DataMember(Name="funcaoAtiva", EmitDefaultValue=false)]
        public FuncaoAtivaEnum? FuncaoAtiva { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaDetalheResponse" /> class.
        /// Initializes a new instance of the <see cref="ContaDetalheResponse" />class.
        /// </summary>
        /// <param name="Id">{{{conta_detalhe_response_id_value}}}.</param>
        /// <param name="IdPessoa">{{{conta_detalhe_response_id_pessoa_value}}}.</param>
        /// <param name="Nome">{{{conta_detalhe_response_nome_value}}}.</param>
        /// <param name="IdProduto">{{{conta_detalhe_response_id_produto_value}}}.</param>
        /// <param name="IdOrigemComercial">{{{conta_detalhe_response_id_origem_comercial_value}}}.</param>
        /// <param name="NomeOrigemComercial">{{{conta_detalhe_response_nome_origem_comercial_value}}}.</param>
        /// <param name="IdFantasiaBasica">{{{conta_detalhe_response_id_fantasia_basica_value}}}.</param>
        /// <param name="NomeFantasiaBasica">{{{conta_detalhe_response_nome_fantasia_basica_value}}}.</param>
        /// <param name="IdStatusConta">{{{conta_detalhe_response_id_status_conta_value}}}.</param>
        /// <param name="StatusConta">{{{conta_detalhe_response_status_conta_value}}}.</param>
        /// <param name="DiaVencimento">{{{conta_detalhe_response_dia_vencimento_value}}}.</param>
        /// <param name="MelhorDiaCompra">{{{conta_detalhe_response_melhor_dia_compra_value}}}.</param>
        /// <param name="DataStatusConta">{{{conta_detalhe_response_data_status_conta_value}}}.</param>
        /// <param name="DataCadastro">{{{conta_detalhe_response_data_cadastro_value}}}.</param>
        /// <param name="DataUltimaAlteracaoVencimento">{{{conta_detalhe_response_data_ultima_alteracao_vencimento_value}}}.</param>
        /// <param name="DataHoraUltimaCompra">{{{conta_detalhe_response_data_hora_ultima_compra_value}}}.</param>
        /// <param name="NumeroAgencia">{{{conta_detalhe_response_numero_agencia_value}}}.</param>
        /// <param name="NumeroContaCorrente">{{{conta_detalhe_response_numero_conta_corrente_value}}}.</param>
        /// <param name="ValorRenda">{{{conta_detalhe_response_valor_renda_value}}}.</param>
        /// <param name="FormaEnvioFatura">{{{conta_detalhe_response_forma_envio_fatura_value}}}.</param>
        /// <param name="Titular">{{{conta_detalhe_response_titular_value}}}.</param>
        /// <param name="LimiteGlobal">{{{conta_detalhe_response_limite_global_value}}}.</param>
        /// <param name="LimiteSaqueGlobal">{{{conta_detalhe_response_limite_saque_global_value}}}.</param>
        /// <param name="SaldoDisponivelGlobal">{{{conta_detalhe_response_saldo_disponivel_global_value}}}.</param>
        /// <param name="SaldoDisponivelSaque">{{{conta_detalhe_response_saldo_disponivel_saque_value}}}.</param>
        /// <param name="ImpedidoFinanciamento">{{{conta_detalhe_response_impedido_de_financiamento_value}}}.</param>
        /// <param name="DiasAtraso">{{{conta_detalhe_response_dias_atraso_value}}}.</param>
        /// <param name="ProximoVencimentoPadrao">{{{conta_response_proximo_vencimento_padrao_value}}}.</param>
        /// <param name="IdProposta">{{{conta_detalhe_response_id_proposta_value}}}.</param>
        /// <param name="QuantidadePagamentos">{{{conta_detalhe_response_quantidade_pagamentos_value}}}.</param>
        /// <param name="Correspondencia">{{{conta_detalhe_response_correspondencia_value}}}.</param>
        /// <param name="DataInicioAtraso">{{{conta_detalhe_response_data_inicio_atraso_value}}}.</param>
        /// <param name="RotativoPagaJuros">{{{estado_conta_response_rotativo_paga_juros_value}}}.</param>
        /// <param name="TotalPosProx">{{{estado_conta_response_total_pos_proximo_value}}}.</param>
        /// <param name="SaldoAtualFinal">{{{estado_conta_response_saldo_atual_final_value}}}.</param>
        /// <param name="SaldoExtratoAnterior">{{{estado_conta_response_saldo_extrato_anterior_value}}}.</param>
        /// <param name="AceitaNovaContaPorGrupoProduto">{{{conta_detalhe_response_aceita_nova_conta_grupo_produto_value}}}.</param>
        /// <param name="FuncaoAtiva">{{{conta_response_funcao_ativa_value}}}.</param>

        public ContaDetalheResponse(long? Id = null, long? IdPessoa = null, string Nome = null, long? IdProduto = null, long? IdOrigemComercial = null, string NomeOrigemComercial = null, long? IdFantasiaBasica = null, string NomeFantasiaBasica = null, long? IdStatusConta = null, string StatusConta = null, int? DiaVencimento = null, int? MelhorDiaCompra = null, string DataStatusConta = null, string DataCadastro = null, string DataUltimaAlteracaoVencimento = null, string DataHoraUltimaCompra = null, int? NumeroAgencia = null, string NumeroContaCorrente = null, double? ValorRenda = null, string FormaEnvioFatura = null, bool? Titular = null, double? LimiteGlobal = null, double? LimiteSaqueGlobal = null, double? SaldoDisponivelGlobal = null, double? SaldoDisponivelSaque = null, bool? ImpedidoFinanciamento = null, long? DiasAtraso = null, string ProximoVencimentoPadrao = null, long? IdProposta = null, int? QuantidadePagamentos = null, long? Correspondencia = null, string DataInicioAtraso = null, double? RotativoPagaJuros = null, double? TotalPosProx = null, double? SaldoAtualFinal = null, double? SaldoExtratoAnterior = null, bool? AceitaNovaContaPorGrupoProduto = null, FuncaoAtivaEnum? FuncaoAtiva = null)
        {
            this.Id = Id;
            this.IdPessoa = IdPessoa;
            this.Nome = Nome;
            this.IdProduto = IdProduto;
            this.IdOrigemComercial = IdOrigemComercial;
            this.NomeOrigemComercial = NomeOrigemComercial;
            this.IdFantasiaBasica = IdFantasiaBasica;
            this.NomeFantasiaBasica = NomeFantasiaBasica;
            this.IdStatusConta = IdStatusConta;
            this.StatusConta = StatusConta;
            this.DiaVencimento = DiaVencimento;
            this.MelhorDiaCompra = MelhorDiaCompra;
            this.DataStatusConta = DataStatusConta;
            this.DataCadastro = DataCadastro;
            this.DataUltimaAlteracaoVencimento = DataUltimaAlteracaoVencimento;
            this.DataHoraUltimaCompra = DataHoraUltimaCompra;
            this.NumeroAgencia = NumeroAgencia;
            this.NumeroContaCorrente = NumeroContaCorrente;
            this.ValorRenda = ValorRenda;
            this.FormaEnvioFatura = FormaEnvioFatura;
            this.Titular = Titular;
            this.LimiteGlobal = LimiteGlobal;
            this.LimiteSaqueGlobal = LimiteSaqueGlobal;
            this.SaldoDisponivelGlobal = SaldoDisponivelGlobal;
            this.SaldoDisponivelSaque = SaldoDisponivelSaque;
            this.ImpedidoFinanciamento = ImpedidoFinanciamento;
            this.DiasAtraso = DiasAtraso;
            this.ProximoVencimentoPadrao = ProximoVencimentoPadrao;
            this.IdProposta = IdProposta;
            this.QuantidadePagamentos = QuantidadePagamentos;
            this.Correspondencia = Correspondencia;
            this.DataInicioAtraso = DataInicioAtraso;
            this.RotativoPagaJuros = RotativoPagaJuros;
            this.TotalPosProx = TotalPosProx;
            this.SaldoAtualFinal = SaldoAtualFinal;
            this.SaldoExtratoAnterior = SaldoExtratoAnterior;
            this.AceitaNovaContaPorGrupoProduto = AceitaNovaContaPorGrupoProduto;
            this.FuncaoAtiva = FuncaoAtiva;
            
        }
        
    
        /// <summary>
        /// {{{conta_detalhe_response_id_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_id_pessoa_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_id_pessoa_value}}}</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_nome_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_nome_value}}}</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_id_produto_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_id_produto_value}}}</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_id_origem_comercial_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_id_origem_comercial_value}}}</value>
        [DataMember(Name="idOrigemComercial", EmitDefaultValue=false)]
        public long? IdOrigemComercial { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_nome_origem_comercial_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_nome_origem_comercial_value}}}</value>
        [DataMember(Name="nomeOrigemComercial", EmitDefaultValue=false)]
        public string NomeOrigemComercial { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_id_fantasia_basica_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_id_fantasia_basica_value}}}</value>
        [DataMember(Name="idFantasiaBasica", EmitDefaultValue=false)]
        public long? IdFantasiaBasica { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_nome_fantasia_basica_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_nome_fantasia_basica_value}}}</value>
        [DataMember(Name="nomeFantasiaBasica", EmitDefaultValue=false)]
        public string NomeFantasiaBasica { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_id_status_conta_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_id_status_conta_value}}}</value>
        [DataMember(Name="idStatusConta", EmitDefaultValue=false)]
        public long? IdStatusConta { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_status_conta_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_status_conta_value}}}</value>
        [DataMember(Name="statusConta", EmitDefaultValue=false)]
        public string StatusConta { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_dia_vencimento_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_dia_vencimento_value}}}</value>
        [DataMember(Name="diaVencimento", EmitDefaultValue=false)]
        public int? DiaVencimento { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_melhor_dia_compra_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_melhor_dia_compra_value}}}</value>
        [DataMember(Name="melhorDiaCompra", EmitDefaultValue=false)]
        public int? MelhorDiaCompra { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_data_status_conta_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_data_status_conta_value}}}</value>
        [DataMember(Name="dataStatusConta", EmitDefaultValue=false)]
        public string DataStatusConta { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_data_cadastro_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_data_cadastro_value}}}</value>
        [DataMember(Name="dataCadastro", EmitDefaultValue=false)]
        public string DataCadastro { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_data_ultima_alteracao_vencimento_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_data_ultima_alteracao_vencimento_value}}}</value>
        [DataMember(Name="dataUltimaAlteracaoVencimento", EmitDefaultValue=false)]
        public string DataUltimaAlteracaoVencimento { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_data_hora_ultima_compra_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_data_hora_ultima_compra_value}}}</value>
        [DataMember(Name="dataHoraUltimaCompra", EmitDefaultValue=false)]
        public string DataHoraUltimaCompra { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_numero_agencia_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_numero_agencia_value}}}</value>
        [DataMember(Name="numeroAgencia", EmitDefaultValue=false)]
        public int? NumeroAgencia { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_numero_conta_corrente_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_numero_conta_corrente_value}}}</value>
        [DataMember(Name="numeroContaCorrente", EmitDefaultValue=false)]
        public string NumeroContaCorrente { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_valor_renda_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_valor_renda_value}}}</value>
        [DataMember(Name="valorRenda", EmitDefaultValue=false)]
        public double? ValorRenda { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_forma_envio_fatura_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_forma_envio_fatura_value}}}</value>
        [DataMember(Name="formaEnvioFatura", EmitDefaultValue=false)]
        public string FormaEnvioFatura { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_titular_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_titular_value}}}</value>
        [DataMember(Name="titular", EmitDefaultValue=false)]
        public bool? Titular { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_limite_global_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_limite_global_value}}}</value>
        [DataMember(Name="limiteGlobal", EmitDefaultValue=false)]
        public double? LimiteGlobal { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_limite_saque_global_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_limite_saque_global_value}}}</value>
        [DataMember(Name="limiteSaqueGlobal", EmitDefaultValue=false)]
        public double? LimiteSaqueGlobal { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_saldo_disponivel_global_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_saldo_disponivel_global_value}}}</value>
        [DataMember(Name="saldoDisponivelGlobal", EmitDefaultValue=false)]
        public double? SaldoDisponivelGlobal { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_saldo_disponivel_saque_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_saldo_disponivel_saque_value}}}</value>
        [DataMember(Name="saldoDisponivelSaque", EmitDefaultValue=false)]
        public double? SaldoDisponivelSaque { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_impedido_de_financiamento_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_impedido_de_financiamento_value}}}</value>
        [DataMember(Name="impedidoFinanciamento", EmitDefaultValue=false)]
        public bool? ImpedidoFinanciamento { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_dias_atraso_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_dias_atraso_value}}}</value>
        [DataMember(Name="diasAtraso", EmitDefaultValue=false)]
        public long? DiasAtraso { get; set; }
    
        /// <summary>
        /// {{{conta_response_proximo_vencimento_padrao_value}}}
        /// </summary>
        /// <value>{{{conta_response_proximo_vencimento_padrao_value}}}</value>
        [DataMember(Name="proximoVencimentoPadrao", EmitDefaultValue=false)]
        public string ProximoVencimentoPadrao { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_id_proposta_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_id_proposta_value}}}</value>
        [DataMember(Name="idProposta", EmitDefaultValue=false)]
        public long? IdProposta { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_quantidade_pagamentos_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_quantidade_pagamentos_value}}}</value>
        [DataMember(Name="quantidadePagamentos", EmitDefaultValue=false)]
        public int? QuantidadePagamentos { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_correspondencia_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_correspondencia_value}}}</value>
        [DataMember(Name="correspondencia", EmitDefaultValue=false)]
        public long? Correspondencia { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_data_inicio_atraso_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_data_inicio_atraso_value}}}</value>
        [DataMember(Name="dataInicioAtraso", EmitDefaultValue=false)]
        public string DataInicioAtraso { get; set; }
    
        /// <summary>
        /// {{{estado_conta_response_rotativo_paga_juros_value}}}
        /// </summary>
        /// <value>{{{estado_conta_response_rotativo_paga_juros_value}}}</value>
        [DataMember(Name="rotativoPagaJuros", EmitDefaultValue=false)]
        public double? RotativoPagaJuros { get; set; }
    
        /// <summary>
        /// {{{estado_conta_response_total_pos_proximo_value}}}
        /// </summary>
        /// <value>{{{estado_conta_response_total_pos_proximo_value}}}</value>
        [DataMember(Name="totalPosProx", EmitDefaultValue=false)]
        public double? TotalPosProx { get; set; }
    
        /// <summary>
        /// {{{estado_conta_response_saldo_atual_final_value}}}
        /// </summary>
        /// <value>{{{estado_conta_response_saldo_atual_final_value}}}</value>
        [DataMember(Name="saldoAtualFinal", EmitDefaultValue=false)]
        public double? SaldoAtualFinal { get; set; }
    
        /// <summary>
        /// {{{estado_conta_response_saldo_extrato_anterior_value}}}
        /// </summary>
        /// <value>{{{estado_conta_response_saldo_extrato_anterior_value}}}</value>
        [DataMember(Name="saldoExtratoAnterior", EmitDefaultValue=false)]
        public double? SaldoExtratoAnterior { get; set; }
    
        /// <summary>
        /// {{{conta_detalhe_response_aceita_nova_conta_grupo_produto_value}}}
        /// </summary>
        /// <value>{{{conta_detalhe_response_aceita_nova_conta_grupo_produto_value}}}</value>
        [DataMember(Name="aceitaNovaContaPorGrupoProduto", EmitDefaultValue=false)]
        public bool? AceitaNovaContaPorGrupoProduto { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContaDetalheResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  IdOrigemComercial: ").Append(IdOrigemComercial).Append("\n");
            sb.Append("  NomeOrigemComercial: ").Append(NomeOrigemComercial).Append("\n");
            sb.Append("  IdFantasiaBasica: ").Append(IdFantasiaBasica).Append("\n");
            sb.Append("  NomeFantasiaBasica: ").Append(NomeFantasiaBasica).Append("\n");
            sb.Append("  IdStatusConta: ").Append(IdStatusConta).Append("\n");
            sb.Append("  StatusConta: ").Append(StatusConta).Append("\n");
            sb.Append("  DiaVencimento: ").Append(DiaVencimento).Append("\n");
            sb.Append("  MelhorDiaCompra: ").Append(MelhorDiaCompra).Append("\n");
            sb.Append("  DataStatusConta: ").Append(DataStatusConta).Append("\n");
            sb.Append("  DataCadastro: ").Append(DataCadastro).Append("\n");
            sb.Append("  DataUltimaAlteracaoVencimento: ").Append(DataUltimaAlteracaoVencimento).Append("\n");
            sb.Append("  DataHoraUltimaCompra: ").Append(DataHoraUltimaCompra).Append("\n");
            sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
            sb.Append("  NumeroContaCorrente: ").Append(NumeroContaCorrente).Append("\n");
            sb.Append("  ValorRenda: ").Append(ValorRenda).Append("\n");
            sb.Append("  FormaEnvioFatura: ").Append(FormaEnvioFatura).Append("\n");
            sb.Append("  Titular: ").Append(Titular).Append("\n");
            sb.Append("  LimiteGlobal: ").Append(LimiteGlobal).Append("\n");
            sb.Append("  LimiteSaqueGlobal: ").Append(LimiteSaqueGlobal).Append("\n");
            sb.Append("  SaldoDisponivelGlobal: ").Append(SaldoDisponivelGlobal).Append("\n");
            sb.Append("  SaldoDisponivelSaque: ").Append(SaldoDisponivelSaque).Append("\n");
            sb.Append("  ImpedidoFinanciamento: ").Append(ImpedidoFinanciamento).Append("\n");
            sb.Append("  DiasAtraso: ").Append(DiasAtraso).Append("\n");
            sb.Append("  ProximoVencimentoPadrao: ").Append(ProximoVencimentoPadrao).Append("\n");
            sb.Append("  IdProposta: ").Append(IdProposta).Append("\n");
            sb.Append("  QuantidadePagamentos: ").Append(QuantidadePagamentos).Append("\n");
            sb.Append("  Correspondencia: ").Append(Correspondencia).Append("\n");
            sb.Append("  DataInicioAtraso: ").Append(DataInicioAtraso).Append("\n");
            sb.Append("  RotativoPagaJuros: ").Append(RotativoPagaJuros).Append("\n");
            sb.Append("  TotalPosProx: ").Append(TotalPosProx).Append("\n");
            sb.Append("  SaldoAtualFinal: ").Append(SaldoAtualFinal).Append("\n");
            sb.Append("  SaldoExtratoAnterior: ").Append(SaldoExtratoAnterior).Append("\n");
            sb.Append("  AceitaNovaContaPorGrupoProduto: ").Append(AceitaNovaContaPorGrupoProduto).Append("\n");
            sb.Append("  FuncaoAtiva: ").Append(FuncaoAtiva).Append("\n");
            
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
            return this.Equals(obj as ContaDetalheResponse);
        }

        /// <summary>
        /// Returns true if ContaDetalheResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ContaDetalheResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContaDetalheResponse other)
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
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.IdOrigemComercial == other.IdOrigemComercial ||
                    this.IdOrigemComercial != null &&
                    this.IdOrigemComercial.Equals(other.IdOrigemComercial)
                ) && 
                (
                    this.NomeOrigemComercial == other.NomeOrigemComercial ||
                    this.NomeOrigemComercial != null &&
                    this.NomeOrigemComercial.Equals(other.NomeOrigemComercial)
                ) && 
                (
                    this.IdFantasiaBasica == other.IdFantasiaBasica ||
                    this.IdFantasiaBasica != null &&
                    this.IdFantasiaBasica.Equals(other.IdFantasiaBasica)
                ) && 
                (
                    this.NomeFantasiaBasica == other.NomeFantasiaBasica ||
                    this.NomeFantasiaBasica != null &&
                    this.NomeFantasiaBasica.Equals(other.NomeFantasiaBasica)
                ) && 
                (
                    this.IdStatusConta == other.IdStatusConta ||
                    this.IdStatusConta != null &&
                    this.IdStatusConta.Equals(other.IdStatusConta)
                ) && 
                (
                    this.StatusConta == other.StatusConta ||
                    this.StatusConta != null &&
                    this.StatusConta.Equals(other.StatusConta)
                ) && 
                (
                    this.DiaVencimento == other.DiaVencimento ||
                    this.DiaVencimento != null &&
                    this.DiaVencimento.Equals(other.DiaVencimento)
                ) && 
                (
                    this.MelhorDiaCompra == other.MelhorDiaCompra ||
                    this.MelhorDiaCompra != null &&
                    this.MelhorDiaCompra.Equals(other.MelhorDiaCompra)
                ) && 
                (
                    this.DataStatusConta == other.DataStatusConta ||
                    this.DataStatusConta != null &&
                    this.DataStatusConta.Equals(other.DataStatusConta)
                ) && 
                (
                    this.DataCadastro == other.DataCadastro ||
                    this.DataCadastro != null &&
                    this.DataCadastro.Equals(other.DataCadastro)
                ) && 
                (
                    this.DataUltimaAlteracaoVencimento == other.DataUltimaAlteracaoVencimento ||
                    this.DataUltimaAlteracaoVencimento != null &&
                    this.DataUltimaAlteracaoVencimento.Equals(other.DataUltimaAlteracaoVencimento)
                ) && 
                (
                    this.DataHoraUltimaCompra == other.DataHoraUltimaCompra ||
                    this.DataHoraUltimaCompra != null &&
                    this.DataHoraUltimaCompra.Equals(other.DataHoraUltimaCompra)
                ) && 
                (
                    this.NumeroAgencia == other.NumeroAgencia ||
                    this.NumeroAgencia != null &&
                    this.NumeroAgencia.Equals(other.NumeroAgencia)
                ) && 
                (
                    this.NumeroContaCorrente == other.NumeroContaCorrente ||
                    this.NumeroContaCorrente != null &&
                    this.NumeroContaCorrente.Equals(other.NumeroContaCorrente)
                ) && 
                (
                    this.ValorRenda == other.ValorRenda ||
                    this.ValorRenda != null &&
                    this.ValorRenda.Equals(other.ValorRenda)
                ) && 
                (
                    this.FormaEnvioFatura == other.FormaEnvioFatura ||
                    this.FormaEnvioFatura != null &&
                    this.FormaEnvioFatura.Equals(other.FormaEnvioFatura)
                ) && 
                (
                    this.Titular == other.Titular ||
                    this.Titular != null &&
                    this.Titular.Equals(other.Titular)
                ) && 
                (
                    this.LimiteGlobal == other.LimiteGlobal ||
                    this.LimiteGlobal != null &&
                    this.LimiteGlobal.Equals(other.LimiteGlobal)
                ) && 
                (
                    this.LimiteSaqueGlobal == other.LimiteSaqueGlobal ||
                    this.LimiteSaqueGlobal != null &&
                    this.LimiteSaqueGlobal.Equals(other.LimiteSaqueGlobal)
                ) && 
                (
                    this.SaldoDisponivelGlobal == other.SaldoDisponivelGlobal ||
                    this.SaldoDisponivelGlobal != null &&
                    this.SaldoDisponivelGlobal.Equals(other.SaldoDisponivelGlobal)
                ) && 
                (
                    this.SaldoDisponivelSaque == other.SaldoDisponivelSaque ||
                    this.SaldoDisponivelSaque != null &&
                    this.SaldoDisponivelSaque.Equals(other.SaldoDisponivelSaque)
                ) && 
                (
                    this.ImpedidoFinanciamento == other.ImpedidoFinanciamento ||
                    this.ImpedidoFinanciamento != null &&
                    this.ImpedidoFinanciamento.Equals(other.ImpedidoFinanciamento)
                ) && 
                (
                    this.DiasAtraso == other.DiasAtraso ||
                    this.DiasAtraso != null &&
                    this.DiasAtraso.Equals(other.DiasAtraso)
                ) && 
                (
                    this.ProximoVencimentoPadrao == other.ProximoVencimentoPadrao ||
                    this.ProximoVencimentoPadrao != null &&
                    this.ProximoVencimentoPadrao.Equals(other.ProximoVencimentoPadrao)
                ) && 
                (
                    this.IdProposta == other.IdProposta ||
                    this.IdProposta != null &&
                    this.IdProposta.Equals(other.IdProposta)
                ) && 
                (
                    this.QuantidadePagamentos == other.QuantidadePagamentos ||
                    this.QuantidadePagamentos != null &&
                    this.QuantidadePagamentos.Equals(other.QuantidadePagamentos)
                ) && 
                (
                    this.Correspondencia == other.Correspondencia ||
                    this.Correspondencia != null &&
                    this.Correspondencia.Equals(other.Correspondencia)
                ) && 
                (
                    this.DataInicioAtraso == other.DataInicioAtraso ||
                    this.DataInicioAtraso != null &&
                    this.DataInicioAtraso.Equals(other.DataInicioAtraso)
                ) && 
                (
                    this.RotativoPagaJuros == other.RotativoPagaJuros ||
                    this.RotativoPagaJuros != null &&
                    this.RotativoPagaJuros.Equals(other.RotativoPagaJuros)
                ) && 
                (
                    this.TotalPosProx == other.TotalPosProx ||
                    this.TotalPosProx != null &&
                    this.TotalPosProx.Equals(other.TotalPosProx)
                ) && 
                (
                    this.SaldoAtualFinal == other.SaldoAtualFinal ||
                    this.SaldoAtualFinal != null &&
                    this.SaldoAtualFinal.Equals(other.SaldoAtualFinal)
                ) && 
                (
                    this.SaldoExtratoAnterior == other.SaldoExtratoAnterior ||
                    this.SaldoExtratoAnterior != null &&
                    this.SaldoExtratoAnterior.Equals(other.SaldoExtratoAnterior)
                ) && 
                (
                    this.AceitaNovaContaPorGrupoProduto == other.AceitaNovaContaPorGrupoProduto ||
                    this.AceitaNovaContaPorGrupoProduto != null &&
                    this.AceitaNovaContaPorGrupoProduto.Equals(other.AceitaNovaContaPorGrupoProduto)
                ) && 
                (
                    this.FuncaoAtiva == other.FuncaoAtiva ||
                    this.FuncaoAtiva != null &&
                    this.FuncaoAtiva.Equals(other.FuncaoAtiva)
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
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.IdOrigemComercial != null)
                    hash = hash * 59 + this.IdOrigemComercial.GetHashCode();
                
                if (this.NomeOrigemComercial != null)
                    hash = hash * 59 + this.NomeOrigemComercial.GetHashCode();
                
                if (this.IdFantasiaBasica != null)
                    hash = hash * 59 + this.IdFantasiaBasica.GetHashCode();
                
                if (this.NomeFantasiaBasica != null)
                    hash = hash * 59 + this.NomeFantasiaBasica.GetHashCode();
                
                if (this.IdStatusConta != null)
                    hash = hash * 59 + this.IdStatusConta.GetHashCode();
                
                if (this.StatusConta != null)
                    hash = hash * 59 + this.StatusConta.GetHashCode();
                
                if (this.DiaVencimento != null)
                    hash = hash * 59 + this.DiaVencimento.GetHashCode();
                
                if (this.MelhorDiaCompra != null)
                    hash = hash * 59 + this.MelhorDiaCompra.GetHashCode();
                
                if (this.DataStatusConta != null)
                    hash = hash * 59 + this.DataStatusConta.GetHashCode();
                
                if (this.DataCadastro != null)
                    hash = hash * 59 + this.DataCadastro.GetHashCode();
                
                if (this.DataUltimaAlteracaoVencimento != null)
                    hash = hash * 59 + this.DataUltimaAlteracaoVencimento.GetHashCode();
                
                if (this.DataHoraUltimaCompra != null)
                    hash = hash * 59 + this.DataHoraUltimaCompra.GetHashCode();
                
                if (this.NumeroAgencia != null)
                    hash = hash * 59 + this.NumeroAgencia.GetHashCode();
                
                if (this.NumeroContaCorrente != null)
                    hash = hash * 59 + this.NumeroContaCorrente.GetHashCode();
                
                if (this.ValorRenda != null)
                    hash = hash * 59 + this.ValorRenda.GetHashCode();
                
                if (this.FormaEnvioFatura != null)
                    hash = hash * 59 + this.FormaEnvioFatura.GetHashCode();
                
                if (this.Titular != null)
                    hash = hash * 59 + this.Titular.GetHashCode();
                
                if (this.LimiteGlobal != null)
                    hash = hash * 59 + this.LimiteGlobal.GetHashCode();
                
                if (this.LimiteSaqueGlobal != null)
                    hash = hash * 59 + this.LimiteSaqueGlobal.GetHashCode();
                
                if (this.SaldoDisponivelGlobal != null)
                    hash = hash * 59 + this.SaldoDisponivelGlobal.GetHashCode();
                
                if (this.SaldoDisponivelSaque != null)
                    hash = hash * 59 + this.SaldoDisponivelSaque.GetHashCode();
                
                if (this.ImpedidoFinanciamento != null)
                    hash = hash * 59 + this.ImpedidoFinanciamento.GetHashCode();
                
                if (this.DiasAtraso != null)
                    hash = hash * 59 + this.DiasAtraso.GetHashCode();
                
                if (this.ProximoVencimentoPadrao != null)
                    hash = hash * 59 + this.ProximoVencimentoPadrao.GetHashCode();
                
                if (this.IdProposta != null)
                    hash = hash * 59 + this.IdProposta.GetHashCode();
                
                if (this.QuantidadePagamentos != null)
                    hash = hash * 59 + this.QuantidadePagamentos.GetHashCode();
                
                if (this.Correspondencia != null)
                    hash = hash * 59 + this.Correspondencia.GetHashCode();
                
                if (this.DataInicioAtraso != null)
                    hash = hash * 59 + this.DataInicioAtraso.GetHashCode();
                
                if (this.RotativoPagaJuros != null)
                    hash = hash * 59 + this.RotativoPagaJuros.GetHashCode();
                
                if (this.TotalPosProx != null)
                    hash = hash * 59 + this.TotalPosProx.GetHashCode();
                
                if (this.SaldoAtualFinal != null)
                    hash = hash * 59 + this.SaldoAtualFinal.GetHashCode();
                
                if (this.SaldoExtratoAnterior != null)
                    hash = hash * 59 + this.SaldoExtratoAnterior.GetHashCode();
                
                if (this.AceitaNovaContaPorGrupoProduto != null)
                    hash = hash * 59 + this.AceitaNovaContaPorGrupoProduto.GetHashCode();
                
                if (this.FuncaoAtiva != null)
                    hash = hash * 59 + this.FuncaoAtiva.GetHashCode();
                
                return hash;
            }
        }

    }
}
