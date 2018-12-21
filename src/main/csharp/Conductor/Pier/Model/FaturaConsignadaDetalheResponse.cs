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
    /// {{{fatura_consignada_detalhe_response_description}}}
    /// </summary>
    [DataContract]
    public partial class FaturaConsignadaDetalheResponse :  IEquatable<FaturaConsignadaDetalheResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FaturaConsignadaDetalheResponse" /> class.
        /// Initializes a new instance of the <see cref="FaturaConsignadaDetalheResponse" />class.
        /// </summary>
        /// <param name="Id">{{{fatura_consignada_detalhe_response_id_value}}}.</param>
        /// <param name="IdConta">{{{fatura_consignada_detalhe_response_id_conta_value}}}.</param>
        /// <param name="LimiteGlobal">{{{fatura_consignada_detalhe_response_limite_global_value}}} (required).</param>
        /// <param name="FlagEmiteFatura">{{{fatura_consignada_detalhe_response_flag_emite_fatura_value}}}.</param>
        /// <param name="LimiteCompra">{{{fatura_consignada_detalhe_response_limite_compra_value}}} (required).</param>
        /// <param name="DataVencimentoFatura">{{{fatura_consignada_detalhe_response_data_vencimento_fatura_value}}}.</param>
        /// <param name="LimiteParcelado">{{{fatura_consignada_detalhe_response_limite_parcelado_value}}} (required).</param>
        /// <param name="LimiteParcelas">{{{fatura_consignada_detalhe_response_limite_parcelas_value}}} (required).</param>
        /// <param name="ValorTotalFatura">{{{fatura_consignada_detalhe_response_valor_total_fatura_value}}}.</param>
        /// <param name="ValorFaturaAnterior">{{{fatura_consignada_detalhe_response_valor_fatura_anterior_value}}}.</param>
        /// <param name="ValorPagamentoMinimo">{{{fatura_consignada_detalhe_response_valor_pagamento_minimo_value}}}.</param>
        /// <param name="ValorPagamentoConsignado">{{{fatura_consignada_detalhe_response_valor_pagamento_consignado_value}}}.</param>
        /// <param name="LimiteSaqueGlobal">{{{fatura_consignada_detalhe_response_limite_saque_global_value}}} (required).</param>
        /// <param name="ValorPagamentoComplementar">{{{fatura_consignada_detalhe_response_valor_pagamento_complementar_value}}}.</param>
        /// <param name="LimiteSaquePeriodo">{{{fatura_consignada_detalhe_response_limite_saque_periodo_value}}} (required).</param>
        /// <param name="TotalComprasNacionais">{{{fatura_consignada_detalhe_response_total_compras_nacionais_value}}}.</param>
        /// <param name="LimiteConsignado">{{{fatura_consignada_detalhe_response_limite_consignado_value}}} (required).</param>
        /// <param name="TotalComprasInternacionas">{{{fatura_consignada_detalhe_response_total_compras_internacionas_value}}}.</param>
        /// <param name="LimiteInternacionalCompra">{{{fatura_consignada_detalhe_response_limite_internacional_compra_value}}} (required).</param>
        /// <param name="TotalSaquesNacionais">{{{fatura_consignada_detalhe_response_total_saques_nacionais_value}}}.</param>
        /// <param name="LimiteInternacionalParcelado">{{{fatura_consignada_detalhe_response_limite_internacional_parcelado_value}}} (required).</param>
        /// <param name="TotalSaquesInternacionais">{{{fatura_consignada_detalhe_response_total_saques_internacionais_value}}}.</param>
        /// <param name="LimiteInternacionalParcelas">{{{fatura_consignada_detalhe_response_limite_internacional_parcelas_value}}} (required).</param>
        /// <param name="TotalDebitosNacionais">{{{fatura_consignada_detalhe_response_total_debitos_nacionais_value}}}.</param>
        /// <param name="LimiteInternacionalSaqueGlobal">{{{fatura_consignada_detalhe_response_limite_internacional_saque_global_value}}} (required).</param>
        /// <param name="TotalDebitosRecorrentes">{{{fatura_consignada_detalhe_response_total_debitos_recorrentes_value}}}.</param>
        /// <param name="LimiteInternacionalSaquePeriodo">{{{fatura_consignada_detalhe_response_limite_internacional_saque_periodo_value}}} (required).</param>
        /// <param name="TotalDebitosInternacionais">{{{fatura_consignada_detalhe_response_total_debitos_internacionais_value}}}.</param>
        /// <param name="SaldoDisponivelGlobal">{{{fatura_consignada_detalhe_response_saldo_disponivel_global_value}}} (required).</param>
        /// <param name="TotalDebitosDiversosNacionais">{{{fatura_consignada_detalhe_response_total_debitos_diversos_nacionais_value}}}.</param>
        /// <param name="SaldoDisponivelCompra">{{{fatura_consignada_detalhe_response_saldo_disponivel_compra_value}}} (required).</param>
        /// <param name="TotalDebitosOpcionais">{{{fatura_consignada_detalhe_response_total_debitos_opcionais_value}}}.</param>
        /// <param name="SaldoDisponivelParcelado">{{{fatura_consignada_detalhe_response_saldo_disponivel_parcelado_value}}} (required).</param>
        /// <param name="TotalPagamentos">{{{fatura_consignada_detalhe_response_total_pagamentos_value}}}.</param>
        /// <param name="SaldoDisponivelParcelas">{{{fatura_consignada_detalhe_response_saldo_disponivel_parcelas_value}}} (required).</param>
        /// <param name="TotalCreditosNacionais">{{{fatura_consignada_detalhe_response_total_creditos_nacionais_value}}}.</param>
        /// <param name="TotalAjustes">{{{fatura_consignada_detalhe_response_total_ajustes_value}}}.</param>
        /// <param name="TotalTarifas">{{{fatura_consignada_detalhe_response_total_tarifas_value}}}.</param>
        /// <param name="TotalMulta">{{{fatura_consignada_detalhe_response_total_multa_value}}}.</param>
        /// <param name="SaldoDisponivelSaque">{{{fatura_consignada_detalhe_response_saldo_disponivel_saque_value}}} (required).</param>
        /// <param name="TotalJuros">{{{fatura_consignada_detalhe_response_total_juros_value}}}.</param>
        /// <param name="SaldoPontosFidelidade">{{{fatura_consignada_detalhe_response_saldo_pontos_fidelidade_value}}} (required).</param>
        /// <param name="TaxaRotativo">{{{fatura_consignada_detalhe_response_taxa_rotativo_value}}}.</param>
        /// <param name="SaldoDisponivelCompraInternacional">{{{fatura_consignada_detalhe_response_saldo_disponivel_compra_internacional_value}}} (required).</param>
        /// <param name="TaxaSaque">{{{fatura_consignada_detalhe_response_taxa_saque_value}}}.</param>
        /// <param name="SaldoDisponivelSaqueInternacional">{{{fatura_consignada_detalhe_response_saldo_disponivel_saque_internacional_value}}} (required).</param>
        /// <param name="TaxaMaximaProximoPeriodo">{{{fatura_consignada_detalhe_response_taxa_maxima_proximo_periodo_value}}}.</param>
        /// <param name="TotalServicos">{{{fatura_consignada_detalhe_response_total_servicos_value}}} (required).</param>

        public FaturaConsignadaDetalheResponse(long? Id = null, long? IdConta = null, double? LimiteGlobal = null, int? FlagEmiteFatura = null, double? LimiteCompra = null, string DataVencimentoFatura = null, double? LimiteParcelado = null, double? LimiteParcelas = null, double? ValorTotalFatura = null, double? ValorFaturaAnterior = null, double? ValorPagamentoMinimo = null, double? ValorPagamentoConsignado = null, double? LimiteSaqueGlobal = null, double? ValorPagamentoComplementar = null, double? LimiteSaquePeriodo = null, double? TotalComprasNacionais = null, double? LimiteConsignado = null, double? TotalComprasInternacionas = null, double? LimiteInternacionalCompra = null, double? TotalSaquesNacionais = null, double? LimiteInternacionalParcelado = null, double? TotalSaquesInternacionais = null, double? LimiteInternacionalParcelas = null, double? TotalDebitosNacionais = null, double? LimiteInternacionalSaqueGlobal = null, double? TotalDebitosRecorrentes = null, double? LimiteInternacionalSaquePeriodo = null, double? TotalDebitosInternacionais = null, double? SaldoDisponivelGlobal = null, double? TotalDebitosDiversosNacionais = null, double? SaldoDisponivelCompra = null, double? TotalDebitosOpcionais = null, double? SaldoDisponivelParcelado = null, double? TotalPagamentos = null, double? SaldoDisponivelParcelas = null, double? TotalCreditosNacionais = null, double? TotalAjustes = null, double? TotalTarifas = null, double? TotalMulta = null, double? SaldoDisponivelSaque = null, double? TotalJuros = null, double? SaldoPontosFidelidade = null, double? TaxaRotativo = null, double? SaldoDisponivelCompraInternacional = null, double? TaxaSaque = null, double? SaldoDisponivelSaqueInternacional = null, double? TaxaMaximaProximoPeriodo = null, double? TotalServicos = null)
        {
            // to ensure "LimiteGlobal" is required (not null)
            if (LimiteGlobal == null)
            {
                throw new InvalidDataException("LimiteGlobal is a required property for FaturaConsignadaDetalheResponse and cannot be null");
            }
            else
            {
                this.LimiteGlobal = LimiteGlobal;
            }
            // to ensure "LimiteCompra" is required (not null)
            if (LimiteCompra == null)
            {
                throw new InvalidDataException("LimiteCompra is a required property for FaturaConsignadaDetalheResponse and cannot be null");
            }
            else
            {
                this.LimiteCompra = LimiteCompra;
            }
            // to ensure "LimiteParcelado" is required (not null)
            if (LimiteParcelado == null)
            {
                throw new InvalidDataException("LimiteParcelado is a required property for FaturaConsignadaDetalheResponse and cannot be null");
            }
            else
            {
                this.LimiteParcelado = LimiteParcelado;
            }
            // to ensure "LimiteParcelas" is required (not null)
            if (LimiteParcelas == null)
            {
                throw new InvalidDataException("LimiteParcelas is a required property for FaturaConsignadaDetalheResponse and cannot be null");
            }
            else
            {
                this.LimiteParcelas = LimiteParcelas;
            }
            // to ensure "LimiteSaqueGlobal" is required (not null)
            if (LimiteSaqueGlobal == null)
            {
                throw new InvalidDataException("LimiteSaqueGlobal is a required property for FaturaConsignadaDetalheResponse and cannot be null");
            }
            else
            {
                this.LimiteSaqueGlobal = LimiteSaqueGlobal;
            }
            // to ensure "LimiteSaquePeriodo" is required (not null)
            if (LimiteSaquePeriodo == null)
            {
                throw new InvalidDataException("LimiteSaquePeriodo is a required property for FaturaConsignadaDetalheResponse and cannot be null");
            }
            else
            {
                this.LimiteSaquePeriodo = LimiteSaquePeriodo;
            }
            // to ensure "LimiteConsignado" is required (not null)
            if (LimiteConsignado == null)
            {
                throw new InvalidDataException("LimiteConsignado is a required property for FaturaConsignadaDetalheResponse and cannot be null");
            }
            else
            {
                this.LimiteConsignado = LimiteConsignado;
            }
            // to ensure "LimiteInternacionalCompra" is required (not null)
            if (LimiteInternacionalCompra == null)
            {
                throw new InvalidDataException("LimiteInternacionalCompra is a required property for FaturaConsignadaDetalheResponse and cannot be null");
            }
            else
            {
                this.LimiteInternacionalCompra = LimiteInternacionalCompra;
            }
            // to ensure "LimiteInternacionalParcelado" is required (not null)
            if (LimiteInternacionalParcelado == null)
            {
                throw new InvalidDataException("LimiteInternacionalParcelado is a required property for FaturaConsignadaDetalheResponse and cannot be null");
            }
            else
            {
                this.LimiteInternacionalParcelado = LimiteInternacionalParcelado;
            }
            // to ensure "LimiteInternacionalParcelas" is required (not null)
            if (LimiteInternacionalParcelas == null)
            {
                throw new InvalidDataException("LimiteInternacionalParcelas is a required property for FaturaConsignadaDetalheResponse and cannot be null");
            }
            else
            {
                this.LimiteInternacionalParcelas = LimiteInternacionalParcelas;
            }
            // to ensure "LimiteInternacionalSaqueGlobal" is required (not null)
            if (LimiteInternacionalSaqueGlobal == null)
            {
                throw new InvalidDataException("LimiteInternacionalSaqueGlobal is a required property for FaturaConsignadaDetalheResponse and cannot be null");
            }
            else
            {
                this.LimiteInternacionalSaqueGlobal = LimiteInternacionalSaqueGlobal;
            }
            // to ensure "LimiteInternacionalSaquePeriodo" is required (not null)
            if (LimiteInternacionalSaquePeriodo == null)
            {
                throw new InvalidDataException("LimiteInternacionalSaquePeriodo is a required property for FaturaConsignadaDetalheResponse and cannot be null");
            }
            else
            {
                this.LimiteInternacionalSaquePeriodo = LimiteInternacionalSaquePeriodo;
            }
            // to ensure "SaldoDisponivelGlobal" is required (not null)
            if (SaldoDisponivelGlobal == null)
            {
                throw new InvalidDataException("SaldoDisponivelGlobal is a required property for FaturaConsignadaDetalheResponse and cannot be null");
            }
            else
            {
                this.SaldoDisponivelGlobal = SaldoDisponivelGlobal;
            }
            // to ensure "SaldoDisponivelCompra" is required (not null)
            if (SaldoDisponivelCompra == null)
            {
                throw new InvalidDataException("SaldoDisponivelCompra is a required property for FaturaConsignadaDetalheResponse and cannot be null");
            }
            else
            {
                this.SaldoDisponivelCompra = SaldoDisponivelCompra;
            }
            // to ensure "SaldoDisponivelParcelado" is required (not null)
            if (SaldoDisponivelParcelado == null)
            {
                throw new InvalidDataException("SaldoDisponivelParcelado is a required property for FaturaConsignadaDetalheResponse and cannot be null");
            }
            else
            {
                this.SaldoDisponivelParcelado = SaldoDisponivelParcelado;
            }
            // to ensure "SaldoDisponivelParcelas" is required (not null)
            if (SaldoDisponivelParcelas == null)
            {
                throw new InvalidDataException("SaldoDisponivelParcelas is a required property for FaturaConsignadaDetalheResponse and cannot be null");
            }
            else
            {
                this.SaldoDisponivelParcelas = SaldoDisponivelParcelas;
            }
            // to ensure "SaldoDisponivelSaque" is required (not null)
            if (SaldoDisponivelSaque == null)
            {
                throw new InvalidDataException("SaldoDisponivelSaque is a required property for FaturaConsignadaDetalheResponse and cannot be null");
            }
            else
            {
                this.SaldoDisponivelSaque = SaldoDisponivelSaque;
            }
            // to ensure "SaldoPontosFidelidade" is required (not null)
            if (SaldoPontosFidelidade == null)
            {
                throw new InvalidDataException("SaldoPontosFidelidade is a required property for FaturaConsignadaDetalheResponse and cannot be null");
            }
            else
            {
                this.SaldoPontosFidelidade = SaldoPontosFidelidade;
            }
            // to ensure "SaldoDisponivelCompraInternacional" is required (not null)
            if (SaldoDisponivelCompraInternacional == null)
            {
                throw new InvalidDataException("SaldoDisponivelCompraInternacional is a required property for FaturaConsignadaDetalheResponse and cannot be null");
            }
            else
            {
                this.SaldoDisponivelCompraInternacional = SaldoDisponivelCompraInternacional;
            }
            // to ensure "SaldoDisponivelSaqueInternacional" is required (not null)
            if (SaldoDisponivelSaqueInternacional == null)
            {
                throw new InvalidDataException("SaldoDisponivelSaqueInternacional is a required property for FaturaConsignadaDetalheResponse and cannot be null");
            }
            else
            {
                this.SaldoDisponivelSaqueInternacional = SaldoDisponivelSaqueInternacional;
            }
            // to ensure "TotalServicos" is required (not null)
            if (TotalServicos == null)
            {
                throw new InvalidDataException("TotalServicos is a required property for FaturaConsignadaDetalheResponse and cannot be null");
            }
            else
            {
                this.TotalServicos = TotalServicos;
            }
            this.Id = Id;
            this.IdConta = IdConta;
            this.FlagEmiteFatura = FlagEmiteFatura;
            this.DataVencimentoFatura = DataVencimentoFatura;
            this.ValorTotalFatura = ValorTotalFatura;
            this.ValorFaturaAnterior = ValorFaturaAnterior;
            this.ValorPagamentoMinimo = ValorPagamentoMinimo;
            this.ValorPagamentoConsignado = ValorPagamentoConsignado;
            this.ValorPagamentoComplementar = ValorPagamentoComplementar;
            this.TotalComprasNacionais = TotalComprasNacionais;
            this.TotalComprasInternacionas = TotalComprasInternacionas;
            this.TotalSaquesNacionais = TotalSaquesNacionais;
            this.TotalSaquesInternacionais = TotalSaquesInternacionais;
            this.TotalDebitosNacionais = TotalDebitosNacionais;
            this.TotalDebitosRecorrentes = TotalDebitosRecorrentes;
            this.TotalDebitosInternacionais = TotalDebitosInternacionais;
            this.TotalDebitosDiversosNacionais = TotalDebitosDiversosNacionais;
            this.TotalDebitosOpcionais = TotalDebitosOpcionais;
            this.TotalPagamentos = TotalPagamentos;
            this.TotalCreditosNacionais = TotalCreditosNacionais;
            this.TotalAjustes = TotalAjustes;
            this.TotalTarifas = TotalTarifas;
            this.TotalMulta = TotalMulta;
            this.TotalJuros = TotalJuros;
            this.TaxaRotativo = TaxaRotativo;
            this.TaxaSaque = TaxaSaque;
            this.TaxaMaximaProximoPeriodo = TaxaMaximaProximoPeriodo;
            
        }
        
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_id_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_limite_global_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_limite_global_value}}}</value>
        [DataMember(Name="limiteGlobal", EmitDefaultValue=false)]
        public double? LimiteGlobal { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_flag_emite_fatura_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_flag_emite_fatura_value}}}</value>
        [DataMember(Name="flagEmiteFatura", EmitDefaultValue=false)]
        public int? FlagEmiteFatura { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_limite_compra_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_limite_compra_value}}}</value>
        [DataMember(Name="limiteCompra", EmitDefaultValue=false)]
        public double? LimiteCompra { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_data_vencimento_fatura_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_data_vencimento_fatura_value}}}</value>
        [DataMember(Name="dataVencimentoFatura", EmitDefaultValue=false)]
        public string DataVencimentoFatura { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_limite_parcelado_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_limite_parcelado_value}}}</value>
        [DataMember(Name="limiteParcelado", EmitDefaultValue=false)]
        public double? LimiteParcelado { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_limite_parcelas_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_limite_parcelas_value}}}</value>
        [DataMember(Name="limiteParcelas", EmitDefaultValue=false)]
        public double? LimiteParcelas { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_valor_total_fatura_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_valor_total_fatura_value}}}</value>
        [DataMember(Name="valorTotalFatura", EmitDefaultValue=false)]
        public double? ValorTotalFatura { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_valor_fatura_anterior_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_valor_fatura_anterior_value}}}</value>
        [DataMember(Name="valorFaturaAnterior", EmitDefaultValue=false)]
        public double? ValorFaturaAnterior { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_valor_pagamento_minimo_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_valor_pagamento_minimo_value}}}</value>
        [DataMember(Name="valorPagamentoMinimo", EmitDefaultValue=false)]
        public double? ValorPagamentoMinimo { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_valor_pagamento_consignado_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_valor_pagamento_consignado_value}}}</value>
        [DataMember(Name="valorPagamentoConsignado", EmitDefaultValue=false)]
        public double? ValorPagamentoConsignado { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_limite_saque_global_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_limite_saque_global_value}}}</value>
        [DataMember(Name="limiteSaqueGlobal", EmitDefaultValue=false)]
        public double? LimiteSaqueGlobal { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_valor_pagamento_complementar_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_valor_pagamento_complementar_value}}}</value>
        [DataMember(Name="valorPagamentoComplementar", EmitDefaultValue=false)]
        public double? ValorPagamentoComplementar { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_limite_saque_periodo_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_limite_saque_periodo_value}}}</value>
        [DataMember(Name="limiteSaquePeriodo", EmitDefaultValue=false)]
        public double? LimiteSaquePeriodo { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_total_compras_nacionais_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_total_compras_nacionais_value}}}</value>
        [DataMember(Name="totalComprasNacionais", EmitDefaultValue=false)]
        public double? TotalComprasNacionais { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_limite_consignado_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_limite_consignado_value}}}</value>
        [DataMember(Name="limiteConsignado", EmitDefaultValue=false)]
        public double? LimiteConsignado { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_total_compras_internacionas_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_total_compras_internacionas_value}}}</value>
        [DataMember(Name="totalComprasInternacionas", EmitDefaultValue=false)]
        public double? TotalComprasInternacionas { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_limite_internacional_compra_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_limite_internacional_compra_value}}}</value>
        [DataMember(Name="limiteInternacionalCompra", EmitDefaultValue=false)]
        public double? LimiteInternacionalCompra { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_total_saques_nacionais_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_total_saques_nacionais_value}}}</value>
        [DataMember(Name="totalSaquesNacionais", EmitDefaultValue=false)]
        public double? TotalSaquesNacionais { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_limite_internacional_parcelado_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_limite_internacional_parcelado_value}}}</value>
        [DataMember(Name="limiteInternacionalParcelado", EmitDefaultValue=false)]
        public double? LimiteInternacionalParcelado { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_total_saques_internacionais_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_total_saques_internacionais_value}}}</value>
        [DataMember(Name="totalSaquesInternacionais", EmitDefaultValue=false)]
        public double? TotalSaquesInternacionais { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_limite_internacional_parcelas_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_limite_internacional_parcelas_value}}}</value>
        [DataMember(Name="limiteInternacionalParcelas", EmitDefaultValue=false)]
        public double? LimiteInternacionalParcelas { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_total_debitos_nacionais_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_total_debitos_nacionais_value}}}</value>
        [DataMember(Name="totalDebitosNacionais", EmitDefaultValue=false)]
        public double? TotalDebitosNacionais { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_limite_internacional_saque_global_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_limite_internacional_saque_global_value}}}</value>
        [DataMember(Name="limiteInternacionalSaqueGlobal", EmitDefaultValue=false)]
        public double? LimiteInternacionalSaqueGlobal { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_total_debitos_recorrentes_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_total_debitos_recorrentes_value}}}</value>
        [DataMember(Name="totalDebitosRecorrentes", EmitDefaultValue=false)]
        public double? TotalDebitosRecorrentes { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_limite_internacional_saque_periodo_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_limite_internacional_saque_periodo_value}}}</value>
        [DataMember(Name="limiteInternacionalSaquePeriodo", EmitDefaultValue=false)]
        public double? LimiteInternacionalSaquePeriodo { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_total_debitos_internacionais_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_total_debitos_internacionais_value}}}</value>
        [DataMember(Name="totalDebitosInternacionais", EmitDefaultValue=false)]
        public double? TotalDebitosInternacionais { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_saldo_disponivel_global_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_saldo_disponivel_global_value}}}</value>
        [DataMember(Name="saldoDisponivelGlobal", EmitDefaultValue=false)]
        public double? SaldoDisponivelGlobal { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_total_debitos_diversos_nacionais_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_total_debitos_diversos_nacionais_value}}}</value>
        [DataMember(Name="totalDebitosDiversosNacionais", EmitDefaultValue=false)]
        public double? TotalDebitosDiversosNacionais { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_saldo_disponivel_compra_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_saldo_disponivel_compra_value}}}</value>
        [DataMember(Name="saldoDisponivelCompra", EmitDefaultValue=false)]
        public double? SaldoDisponivelCompra { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_total_debitos_opcionais_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_total_debitos_opcionais_value}}}</value>
        [DataMember(Name="totalDebitosOpcionais", EmitDefaultValue=false)]
        public double? TotalDebitosOpcionais { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_saldo_disponivel_parcelado_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_saldo_disponivel_parcelado_value}}}</value>
        [DataMember(Name="saldoDisponivelParcelado", EmitDefaultValue=false)]
        public double? SaldoDisponivelParcelado { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_total_pagamentos_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_total_pagamentos_value}}}</value>
        [DataMember(Name="totalPagamentos", EmitDefaultValue=false)]
        public double? TotalPagamentos { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_saldo_disponivel_parcelas_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_saldo_disponivel_parcelas_value}}}</value>
        [DataMember(Name="saldoDisponivelParcelas", EmitDefaultValue=false)]
        public double? SaldoDisponivelParcelas { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_total_creditos_nacionais_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_total_creditos_nacionais_value}}}</value>
        [DataMember(Name="totalCreditosNacionais", EmitDefaultValue=false)]
        public double? TotalCreditosNacionais { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_total_ajustes_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_total_ajustes_value}}}</value>
        [DataMember(Name="totalAjustes", EmitDefaultValue=false)]
        public double? TotalAjustes { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_total_tarifas_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_total_tarifas_value}}}</value>
        [DataMember(Name="totalTarifas", EmitDefaultValue=false)]
        public double? TotalTarifas { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_total_multa_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_total_multa_value}}}</value>
        [DataMember(Name="totalMulta", EmitDefaultValue=false)]
        public double? TotalMulta { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_saldo_disponivel_saque_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_saldo_disponivel_saque_value}}}</value>
        [DataMember(Name="saldoDisponivelSaque", EmitDefaultValue=false)]
        public double? SaldoDisponivelSaque { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_total_juros_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_total_juros_value}}}</value>
        [DataMember(Name="totalJuros", EmitDefaultValue=false)]
        public double? TotalJuros { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_saldo_pontos_fidelidade_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_saldo_pontos_fidelidade_value}}}</value>
        [DataMember(Name="saldoPontosFidelidade", EmitDefaultValue=false)]
        public double? SaldoPontosFidelidade { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_taxa_rotativo_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_taxa_rotativo_value}}}</value>
        [DataMember(Name="taxaRotativo", EmitDefaultValue=false)]
        public double? TaxaRotativo { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_saldo_disponivel_compra_internacional_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_saldo_disponivel_compra_internacional_value}}}</value>
        [DataMember(Name="saldoDisponivelCompraInternacional", EmitDefaultValue=false)]
        public double? SaldoDisponivelCompraInternacional { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_taxa_saque_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_taxa_saque_value}}}</value>
        [DataMember(Name="taxaSaque", EmitDefaultValue=false)]
        public double? TaxaSaque { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_saldo_disponivel_saque_internacional_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_saldo_disponivel_saque_internacional_value}}}</value>
        [DataMember(Name="saldoDisponivelSaqueInternacional", EmitDefaultValue=false)]
        public double? SaldoDisponivelSaqueInternacional { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_taxa_maxima_proximo_periodo_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_taxa_maxima_proximo_periodo_value}}}</value>
        [DataMember(Name="taxaMaximaProximoPeriodo", EmitDefaultValue=false)]
        public double? TaxaMaximaProximoPeriodo { get; set; }
    
        /// <summary>
        /// {{{fatura_consignada_detalhe_response_total_servicos_value}}}
        /// </summary>
        /// <value>{{{fatura_consignada_detalhe_response_total_servicos_value}}}</value>
        [DataMember(Name="totalServicos", EmitDefaultValue=false)]
        public double? TotalServicos { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FaturaConsignadaDetalheResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  LimiteGlobal: ").Append(LimiteGlobal).Append("\n");
            sb.Append("  FlagEmiteFatura: ").Append(FlagEmiteFatura).Append("\n");
            sb.Append("  LimiteCompra: ").Append(LimiteCompra).Append("\n");
            sb.Append("  DataVencimentoFatura: ").Append(DataVencimentoFatura).Append("\n");
            sb.Append("  LimiteParcelado: ").Append(LimiteParcelado).Append("\n");
            sb.Append("  LimiteParcelas: ").Append(LimiteParcelas).Append("\n");
            sb.Append("  ValorTotalFatura: ").Append(ValorTotalFatura).Append("\n");
            sb.Append("  ValorFaturaAnterior: ").Append(ValorFaturaAnterior).Append("\n");
            sb.Append("  ValorPagamentoMinimo: ").Append(ValorPagamentoMinimo).Append("\n");
            sb.Append("  ValorPagamentoConsignado: ").Append(ValorPagamentoConsignado).Append("\n");
            sb.Append("  LimiteSaqueGlobal: ").Append(LimiteSaqueGlobal).Append("\n");
            sb.Append("  ValorPagamentoComplementar: ").Append(ValorPagamentoComplementar).Append("\n");
            sb.Append("  LimiteSaquePeriodo: ").Append(LimiteSaquePeriodo).Append("\n");
            sb.Append("  TotalComprasNacionais: ").Append(TotalComprasNacionais).Append("\n");
            sb.Append("  LimiteConsignado: ").Append(LimiteConsignado).Append("\n");
            sb.Append("  TotalComprasInternacionas: ").Append(TotalComprasInternacionas).Append("\n");
            sb.Append("  LimiteInternacionalCompra: ").Append(LimiteInternacionalCompra).Append("\n");
            sb.Append("  TotalSaquesNacionais: ").Append(TotalSaquesNacionais).Append("\n");
            sb.Append("  LimiteInternacionalParcelado: ").Append(LimiteInternacionalParcelado).Append("\n");
            sb.Append("  TotalSaquesInternacionais: ").Append(TotalSaquesInternacionais).Append("\n");
            sb.Append("  LimiteInternacionalParcelas: ").Append(LimiteInternacionalParcelas).Append("\n");
            sb.Append("  TotalDebitosNacionais: ").Append(TotalDebitosNacionais).Append("\n");
            sb.Append("  LimiteInternacionalSaqueGlobal: ").Append(LimiteInternacionalSaqueGlobal).Append("\n");
            sb.Append("  TotalDebitosRecorrentes: ").Append(TotalDebitosRecorrentes).Append("\n");
            sb.Append("  LimiteInternacionalSaquePeriodo: ").Append(LimiteInternacionalSaquePeriodo).Append("\n");
            sb.Append("  TotalDebitosInternacionais: ").Append(TotalDebitosInternacionais).Append("\n");
            sb.Append("  SaldoDisponivelGlobal: ").Append(SaldoDisponivelGlobal).Append("\n");
            sb.Append("  TotalDebitosDiversosNacionais: ").Append(TotalDebitosDiversosNacionais).Append("\n");
            sb.Append("  SaldoDisponivelCompra: ").Append(SaldoDisponivelCompra).Append("\n");
            sb.Append("  TotalDebitosOpcionais: ").Append(TotalDebitosOpcionais).Append("\n");
            sb.Append("  SaldoDisponivelParcelado: ").Append(SaldoDisponivelParcelado).Append("\n");
            sb.Append("  TotalPagamentos: ").Append(TotalPagamentos).Append("\n");
            sb.Append("  SaldoDisponivelParcelas: ").Append(SaldoDisponivelParcelas).Append("\n");
            sb.Append("  TotalCreditosNacionais: ").Append(TotalCreditosNacionais).Append("\n");
            sb.Append("  TotalAjustes: ").Append(TotalAjustes).Append("\n");
            sb.Append("  TotalTarifas: ").Append(TotalTarifas).Append("\n");
            sb.Append("  TotalMulta: ").Append(TotalMulta).Append("\n");
            sb.Append("  SaldoDisponivelSaque: ").Append(SaldoDisponivelSaque).Append("\n");
            sb.Append("  TotalJuros: ").Append(TotalJuros).Append("\n");
            sb.Append("  SaldoPontosFidelidade: ").Append(SaldoPontosFidelidade).Append("\n");
            sb.Append("  TaxaRotativo: ").Append(TaxaRotativo).Append("\n");
            sb.Append("  SaldoDisponivelCompraInternacional: ").Append(SaldoDisponivelCompraInternacional).Append("\n");
            sb.Append("  TaxaSaque: ").Append(TaxaSaque).Append("\n");
            sb.Append("  SaldoDisponivelSaqueInternacional: ").Append(SaldoDisponivelSaqueInternacional).Append("\n");
            sb.Append("  TaxaMaximaProximoPeriodo: ").Append(TaxaMaximaProximoPeriodo).Append("\n");
            sb.Append("  TotalServicos: ").Append(TotalServicos).Append("\n");
            
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
            return this.Equals(obj as FaturaConsignadaDetalheResponse);
        }

        /// <summary>
        /// Returns true if FaturaConsignadaDetalheResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of FaturaConsignadaDetalheResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FaturaConsignadaDetalheResponse other)
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
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.LimiteGlobal == other.LimiteGlobal ||
                    this.LimiteGlobal != null &&
                    this.LimiteGlobal.Equals(other.LimiteGlobal)
                ) && 
                (
                    this.FlagEmiteFatura == other.FlagEmiteFatura ||
                    this.FlagEmiteFatura != null &&
                    this.FlagEmiteFatura.Equals(other.FlagEmiteFatura)
                ) && 
                (
                    this.LimiteCompra == other.LimiteCompra ||
                    this.LimiteCompra != null &&
                    this.LimiteCompra.Equals(other.LimiteCompra)
                ) && 
                (
                    this.DataVencimentoFatura == other.DataVencimentoFatura ||
                    this.DataVencimentoFatura != null &&
                    this.DataVencimentoFatura.Equals(other.DataVencimentoFatura)
                ) && 
                (
                    this.LimiteParcelado == other.LimiteParcelado ||
                    this.LimiteParcelado != null &&
                    this.LimiteParcelado.Equals(other.LimiteParcelado)
                ) && 
                (
                    this.LimiteParcelas == other.LimiteParcelas ||
                    this.LimiteParcelas != null &&
                    this.LimiteParcelas.Equals(other.LimiteParcelas)
                ) && 
                (
                    this.ValorTotalFatura == other.ValorTotalFatura ||
                    this.ValorTotalFatura != null &&
                    this.ValorTotalFatura.Equals(other.ValorTotalFatura)
                ) && 
                (
                    this.ValorFaturaAnterior == other.ValorFaturaAnterior ||
                    this.ValorFaturaAnterior != null &&
                    this.ValorFaturaAnterior.Equals(other.ValorFaturaAnterior)
                ) && 
                (
                    this.ValorPagamentoMinimo == other.ValorPagamentoMinimo ||
                    this.ValorPagamentoMinimo != null &&
                    this.ValorPagamentoMinimo.Equals(other.ValorPagamentoMinimo)
                ) && 
                (
                    this.ValorPagamentoConsignado == other.ValorPagamentoConsignado ||
                    this.ValorPagamentoConsignado != null &&
                    this.ValorPagamentoConsignado.Equals(other.ValorPagamentoConsignado)
                ) && 
                (
                    this.LimiteSaqueGlobal == other.LimiteSaqueGlobal ||
                    this.LimiteSaqueGlobal != null &&
                    this.LimiteSaqueGlobal.Equals(other.LimiteSaqueGlobal)
                ) && 
                (
                    this.ValorPagamentoComplementar == other.ValorPagamentoComplementar ||
                    this.ValorPagamentoComplementar != null &&
                    this.ValorPagamentoComplementar.Equals(other.ValorPagamentoComplementar)
                ) && 
                (
                    this.LimiteSaquePeriodo == other.LimiteSaquePeriodo ||
                    this.LimiteSaquePeriodo != null &&
                    this.LimiteSaquePeriodo.Equals(other.LimiteSaquePeriodo)
                ) && 
                (
                    this.TotalComprasNacionais == other.TotalComprasNacionais ||
                    this.TotalComprasNacionais != null &&
                    this.TotalComprasNacionais.Equals(other.TotalComprasNacionais)
                ) && 
                (
                    this.LimiteConsignado == other.LimiteConsignado ||
                    this.LimiteConsignado != null &&
                    this.LimiteConsignado.Equals(other.LimiteConsignado)
                ) && 
                (
                    this.TotalComprasInternacionas == other.TotalComprasInternacionas ||
                    this.TotalComprasInternacionas != null &&
                    this.TotalComprasInternacionas.Equals(other.TotalComprasInternacionas)
                ) && 
                (
                    this.LimiteInternacionalCompra == other.LimiteInternacionalCompra ||
                    this.LimiteInternacionalCompra != null &&
                    this.LimiteInternacionalCompra.Equals(other.LimiteInternacionalCompra)
                ) && 
                (
                    this.TotalSaquesNacionais == other.TotalSaquesNacionais ||
                    this.TotalSaquesNacionais != null &&
                    this.TotalSaquesNacionais.Equals(other.TotalSaquesNacionais)
                ) && 
                (
                    this.LimiteInternacionalParcelado == other.LimiteInternacionalParcelado ||
                    this.LimiteInternacionalParcelado != null &&
                    this.LimiteInternacionalParcelado.Equals(other.LimiteInternacionalParcelado)
                ) && 
                (
                    this.TotalSaquesInternacionais == other.TotalSaquesInternacionais ||
                    this.TotalSaquesInternacionais != null &&
                    this.TotalSaquesInternacionais.Equals(other.TotalSaquesInternacionais)
                ) && 
                (
                    this.LimiteInternacionalParcelas == other.LimiteInternacionalParcelas ||
                    this.LimiteInternacionalParcelas != null &&
                    this.LimiteInternacionalParcelas.Equals(other.LimiteInternacionalParcelas)
                ) && 
                (
                    this.TotalDebitosNacionais == other.TotalDebitosNacionais ||
                    this.TotalDebitosNacionais != null &&
                    this.TotalDebitosNacionais.Equals(other.TotalDebitosNacionais)
                ) && 
                (
                    this.LimiteInternacionalSaqueGlobal == other.LimiteInternacionalSaqueGlobal ||
                    this.LimiteInternacionalSaqueGlobal != null &&
                    this.LimiteInternacionalSaqueGlobal.Equals(other.LimiteInternacionalSaqueGlobal)
                ) && 
                (
                    this.TotalDebitosRecorrentes == other.TotalDebitosRecorrentes ||
                    this.TotalDebitosRecorrentes != null &&
                    this.TotalDebitosRecorrentes.Equals(other.TotalDebitosRecorrentes)
                ) && 
                (
                    this.LimiteInternacionalSaquePeriodo == other.LimiteInternacionalSaquePeriodo ||
                    this.LimiteInternacionalSaquePeriodo != null &&
                    this.LimiteInternacionalSaquePeriodo.Equals(other.LimiteInternacionalSaquePeriodo)
                ) && 
                (
                    this.TotalDebitosInternacionais == other.TotalDebitosInternacionais ||
                    this.TotalDebitosInternacionais != null &&
                    this.TotalDebitosInternacionais.Equals(other.TotalDebitosInternacionais)
                ) && 
                (
                    this.SaldoDisponivelGlobal == other.SaldoDisponivelGlobal ||
                    this.SaldoDisponivelGlobal != null &&
                    this.SaldoDisponivelGlobal.Equals(other.SaldoDisponivelGlobal)
                ) && 
                (
                    this.TotalDebitosDiversosNacionais == other.TotalDebitosDiversosNacionais ||
                    this.TotalDebitosDiversosNacionais != null &&
                    this.TotalDebitosDiversosNacionais.Equals(other.TotalDebitosDiversosNacionais)
                ) && 
                (
                    this.SaldoDisponivelCompra == other.SaldoDisponivelCompra ||
                    this.SaldoDisponivelCompra != null &&
                    this.SaldoDisponivelCompra.Equals(other.SaldoDisponivelCompra)
                ) && 
                (
                    this.TotalDebitosOpcionais == other.TotalDebitosOpcionais ||
                    this.TotalDebitosOpcionais != null &&
                    this.TotalDebitosOpcionais.Equals(other.TotalDebitosOpcionais)
                ) && 
                (
                    this.SaldoDisponivelParcelado == other.SaldoDisponivelParcelado ||
                    this.SaldoDisponivelParcelado != null &&
                    this.SaldoDisponivelParcelado.Equals(other.SaldoDisponivelParcelado)
                ) && 
                (
                    this.TotalPagamentos == other.TotalPagamentos ||
                    this.TotalPagamentos != null &&
                    this.TotalPagamentos.Equals(other.TotalPagamentos)
                ) && 
                (
                    this.SaldoDisponivelParcelas == other.SaldoDisponivelParcelas ||
                    this.SaldoDisponivelParcelas != null &&
                    this.SaldoDisponivelParcelas.Equals(other.SaldoDisponivelParcelas)
                ) && 
                (
                    this.TotalCreditosNacionais == other.TotalCreditosNacionais ||
                    this.TotalCreditosNacionais != null &&
                    this.TotalCreditosNacionais.Equals(other.TotalCreditosNacionais)
                ) && 
                (
                    this.TotalAjustes == other.TotalAjustes ||
                    this.TotalAjustes != null &&
                    this.TotalAjustes.Equals(other.TotalAjustes)
                ) && 
                (
                    this.TotalTarifas == other.TotalTarifas ||
                    this.TotalTarifas != null &&
                    this.TotalTarifas.Equals(other.TotalTarifas)
                ) && 
                (
                    this.TotalMulta == other.TotalMulta ||
                    this.TotalMulta != null &&
                    this.TotalMulta.Equals(other.TotalMulta)
                ) && 
                (
                    this.SaldoDisponivelSaque == other.SaldoDisponivelSaque ||
                    this.SaldoDisponivelSaque != null &&
                    this.SaldoDisponivelSaque.Equals(other.SaldoDisponivelSaque)
                ) && 
                (
                    this.TotalJuros == other.TotalJuros ||
                    this.TotalJuros != null &&
                    this.TotalJuros.Equals(other.TotalJuros)
                ) && 
                (
                    this.SaldoPontosFidelidade == other.SaldoPontosFidelidade ||
                    this.SaldoPontosFidelidade != null &&
                    this.SaldoPontosFidelidade.Equals(other.SaldoPontosFidelidade)
                ) && 
                (
                    this.TaxaRotativo == other.TaxaRotativo ||
                    this.TaxaRotativo != null &&
                    this.TaxaRotativo.Equals(other.TaxaRotativo)
                ) && 
                (
                    this.SaldoDisponivelCompraInternacional == other.SaldoDisponivelCompraInternacional ||
                    this.SaldoDisponivelCompraInternacional != null &&
                    this.SaldoDisponivelCompraInternacional.Equals(other.SaldoDisponivelCompraInternacional)
                ) && 
                (
                    this.TaxaSaque == other.TaxaSaque ||
                    this.TaxaSaque != null &&
                    this.TaxaSaque.Equals(other.TaxaSaque)
                ) && 
                (
                    this.SaldoDisponivelSaqueInternacional == other.SaldoDisponivelSaqueInternacional ||
                    this.SaldoDisponivelSaqueInternacional != null &&
                    this.SaldoDisponivelSaqueInternacional.Equals(other.SaldoDisponivelSaqueInternacional)
                ) && 
                (
                    this.TaxaMaximaProximoPeriodo == other.TaxaMaximaProximoPeriodo ||
                    this.TaxaMaximaProximoPeriodo != null &&
                    this.TaxaMaximaProximoPeriodo.Equals(other.TaxaMaximaProximoPeriodo)
                ) && 
                (
                    this.TotalServicos == other.TotalServicos ||
                    this.TotalServicos != null &&
                    this.TotalServicos.Equals(other.TotalServicos)
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
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.LimiteGlobal != null)
                    hash = hash * 59 + this.LimiteGlobal.GetHashCode();
                
                if (this.FlagEmiteFatura != null)
                    hash = hash * 59 + this.FlagEmiteFatura.GetHashCode();
                
                if (this.LimiteCompra != null)
                    hash = hash * 59 + this.LimiteCompra.GetHashCode();
                
                if (this.DataVencimentoFatura != null)
                    hash = hash * 59 + this.DataVencimentoFatura.GetHashCode();
                
                if (this.LimiteParcelado != null)
                    hash = hash * 59 + this.LimiteParcelado.GetHashCode();
                
                if (this.LimiteParcelas != null)
                    hash = hash * 59 + this.LimiteParcelas.GetHashCode();
                
                if (this.ValorTotalFatura != null)
                    hash = hash * 59 + this.ValorTotalFatura.GetHashCode();
                
                if (this.ValorFaturaAnterior != null)
                    hash = hash * 59 + this.ValorFaturaAnterior.GetHashCode();
                
                if (this.ValorPagamentoMinimo != null)
                    hash = hash * 59 + this.ValorPagamentoMinimo.GetHashCode();
                
                if (this.ValorPagamentoConsignado != null)
                    hash = hash * 59 + this.ValorPagamentoConsignado.GetHashCode();
                
                if (this.LimiteSaqueGlobal != null)
                    hash = hash * 59 + this.LimiteSaqueGlobal.GetHashCode();
                
                if (this.ValorPagamentoComplementar != null)
                    hash = hash * 59 + this.ValorPagamentoComplementar.GetHashCode();
                
                if (this.LimiteSaquePeriodo != null)
                    hash = hash * 59 + this.LimiteSaquePeriodo.GetHashCode();
                
                if (this.TotalComprasNacionais != null)
                    hash = hash * 59 + this.TotalComprasNacionais.GetHashCode();
                
                if (this.LimiteConsignado != null)
                    hash = hash * 59 + this.LimiteConsignado.GetHashCode();
                
                if (this.TotalComprasInternacionas != null)
                    hash = hash * 59 + this.TotalComprasInternacionas.GetHashCode();
                
                if (this.LimiteInternacionalCompra != null)
                    hash = hash * 59 + this.LimiteInternacionalCompra.GetHashCode();
                
                if (this.TotalSaquesNacionais != null)
                    hash = hash * 59 + this.TotalSaquesNacionais.GetHashCode();
                
                if (this.LimiteInternacionalParcelado != null)
                    hash = hash * 59 + this.LimiteInternacionalParcelado.GetHashCode();
                
                if (this.TotalSaquesInternacionais != null)
                    hash = hash * 59 + this.TotalSaquesInternacionais.GetHashCode();
                
                if (this.LimiteInternacionalParcelas != null)
                    hash = hash * 59 + this.LimiteInternacionalParcelas.GetHashCode();
                
                if (this.TotalDebitosNacionais != null)
                    hash = hash * 59 + this.TotalDebitosNacionais.GetHashCode();
                
                if (this.LimiteInternacionalSaqueGlobal != null)
                    hash = hash * 59 + this.LimiteInternacionalSaqueGlobal.GetHashCode();
                
                if (this.TotalDebitosRecorrentes != null)
                    hash = hash * 59 + this.TotalDebitosRecorrentes.GetHashCode();
                
                if (this.LimiteInternacionalSaquePeriodo != null)
                    hash = hash * 59 + this.LimiteInternacionalSaquePeriodo.GetHashCode();
                
                if (this.TotalDebitosInternacionais != null)
                    hash = hash * 59 + this.TotalDebitosInternacionais.GetHashCode();
                
                if (this.SaldoDisponivelGlobal != null)
                    hash = hash * 59 + this.SaldoDisponivelGlobal.GetHashCode();
                
                if (this.TotalDebitosDiversosNacionais != null)
                    hash = hash * 59 + this.TotalDebitosDiversosNacionais.GetHashCode();
                
                if (this.SaldoDisponivelCompra != null)
                    hash = hash * 59 + this.SaldoDisponivelCompra.GetHashCode();
                
                if (this.TotalDebitosOpcionais != null)
                    hash = hash * 59 + this.TotalDebitosOpcionais.GetHashCode();
                
                if (this.SaldoDisponivelParcelado != null)
                    hash = hash * 59 + this.SaldoDisponivelParcelado.GetHashCode();
                
                if (this.TotalPagamentos != null)
                    hash = hash * 59 + this.TotalPagamentos.GetHashCode();
                
                if (this.SaldoDisponivelParcelas != null)
                    hash = hash * 59 + this.SaldoDisponivelParcelas.GetHashCode();
                
                if (this.TotalCreditosNacionais != null)
                    hash = hash * 59 + this.TotalCreditosNacionais.GetHashCode();
                
                if (this.TotalAjustes != null)
                    hash = hash * 59 + this.TotalAjustes.GetHashCode();
                
                if (this.TotalTarifas != null)
                    hash = hash * 59 + this.TotalTarifas.GetHashCode();
                
                if (this.TotalMulta != null)
                    hash = hash * 59 + this.TotalMulta.GetHashCode();
                
                if (this.SaldoDisponivelSaque != null)
                    hash = hash * 59 + this.SaldoDisponivelSaque.GetHashCode();
                
                if (this.TotalJuros != null)
                    hash = hash * 59 + this.TotalJuros.GetHashCode();
                
                if (this.SaldoPontosFidelidade != null)
                    hash = hash * 59 + this.SaldoPontosFidelidade.GetHashCode();
                
                if (this.TaxaRotativo != null)
                    hash = hash * 59 + this.TaxaRotativo.GetHashCode();
                
                if (this.SaldoDisponivelCompraInternacional != null)
                    hash = hash * 59 + this.SaldoDisponivelCompraInternacional.GetHashCode();
                
                if (this.TaxaSaque != null)
                    hash = hash * 59 + this.TaxaSaque.GetHashCode();
                
                if (this.SaldoDisponivelSaqueInternacional != null)
                    hash = hash * 59 + this.SaldoDisponivelSaqueInternacional.GetHashCode();
                
                if (this.TaxaMaximaProximoPeriodo != null)
                    hash = hash * 59 + this.TaxaMaximaProximoPeriodo.GetHashCode();
                
                if (this.TotalServicos != null)
                    hash = hash * 59 + this.TotalServicos.GetHashCode();
                
                return hash;
            }
        }

    }
}
