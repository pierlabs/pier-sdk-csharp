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
    /// {{{taxas_refinanciamento_response_description}}}
    /// </summary>
    [DataContract]
    public partial class TaxasRefinanciamentoResponse :  IEquatable<TaxasRefinanciamentoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxasRefinanciamentoResponse" /> class.
        /// Initializes a new instance of the <see cref="TaxasRefinanciamentoResponse" />class.
        /// </summary>
        /// <param name="Id">{{{taxas_refinanciamento_response_id_value}}}.</param>
        /// <param name="IdConta">{{{taxas_refinanciamento_response_id_conta_value}}}.</param>
        /// <param name="IdProduto">{{{taxas_refinanciamento_response_id_produto_value}}}.</param>
        /// <param name="IdPlanoConta">{{{taxas_refinanciamento_response_id_plano_conta_value}}}.</param>
        /// <param name="IdPlanoPct">{{{taxas_refinanciamento_response_id_plano_pct_value}}}.</param>
        /// <param name="IdPlanoCreditoTaxa">{{{taxas_refinanciamento_response_id_plano_credito_taxa_value}}}.</param>
        /// <param name="DataEntrada">{{{taxas_refinanciamento_response_data_entrada_value}}}.</param>
        /// <param name="Vencimento">{{{taxas_refinanciamento_response_vencimento_value}}}.</param>
        /// <param name="RecuperacaoEncargosFinanceiros">{{{taxas_refinanciamento_response_recuperacao_encargos_financeiros_value}}}.</param>
        /// <param name="ComissaoGarantia">{{{taxas_refinanciamento_response_comissao_garantia_value}}}.</param>
        /// <param name="Agenciamento">{{{taxas_refinanciamento_response_agenciamento_value}}}.</param>
        /// <param name="TaxaMaximaProximoPeriodo">{{{taxas_refinanciamento_response_taxa_maxima_proximo_periodo_value}}}.</param>
        /// <param name="TaxaEncargosFinanciamento">{{{taxas_refinanciamento_response_taxa_encargos_financiamento_value}}}.</param>
        /// <param name="TaxaMaximaSaque">{{{taxas_refinanciamento_response_taxa_maxima_saque_value}}}.</param>
        /// <param name="TaxaSaque">{{{taxas_refinanciamento_response_taxa_saque_value}}}.</param>
        /// <param name="TaxaMaximaCompraJuros">{{{taxas_refinanciamento_response_taxa_maxima_compra_juros_value}}}.</param>
        /// <param name="TaxaCompraJuros">{{{taxas_refinanciamento_response_taxa_compra_juros_value}}}.</param>
        /// <param name="TaxaPermanencia">{{{taxas_refinanciamento_response_taxa_permanencia_value}}}.</param>
        /// <param name="TaxaRefinanciamento">{{{taxas_refinanciamento_response_taxa_refinanciamento_value}}}.</param>
        /// <param name="TaxaRecuperacaoRefinanciamento">{{{taxas_refinanciamento_response_taxa_recuperacao_refinanciamento_value}}}.</param>
        /// <param name="TaxaPercCalcPagamentoMinimo">{{{taxas_refinanciamento_response_taxa_perc_calc_pagamento_minimo_value}}}.</param>
        /// <param name="PlanoTaxaDefault">{{{taxas_refinanciamento_response_plano_taxa_default_value}}}.</param>

        public TaxasRefinanciamentoResponse(long? Id = null, long? IdConta = null, long? IdProduto = null, long? IdPlanoConta = null, long? IdPlanoPct = null, long? IdPlanoCreditoTaxa = null, string DataEntrada = null, string Vencimento = null, double? RecuperacaoEncargosFinanceiros = null, double? ComissaoGarantia = null, double? Agenciamento = null, double? TaxaMaximaProximoPeriodo = null, double? TaxaEncargosFinanciamento = null, double? TaxaMaximaSaque = null, double? TaxaSaque = null, double? TaxaMaximaCompraJuros = null, double? TaxaCompraJuros = null, double? TaxaPermanencia = null, double? TaxaRefinanciamento = null, double? TaxaRecuperacaoRefinanciamento = null, double? TaxaPercCalcPagamentoMinimo = null, int? PlanoTaxaDefault = null)
        {
            this.Id = Id;
            this.IdConta = IdConta;
            this.IdProduto = IdProduto;
            this.IdPlanoConta = IdPlanoConta;
            this.IdPlanoPct = IdPlanoPct;
            this.IdPlanoCreditoTaxa = IdPlanoCreditoTaxa;
            this.DataEntrada = DataEntrada;
            this.Vencimento = Vencimento;
            this.RecuperacaoEncargosFinanceiros = RecuperacaoEncargosFinanceiros;
            this.ComissaoGarantia = ComissaoGarantia;
            this.Agenciamento = Agenciamento;
            this.TaxaMaximaProximoPeriodo = TaxaMaximaProximoPeriodo;
            this.TaxaEncargosFinanciamento = TaxaEncargosFinanciamento;
            this.TaxaMaximaSaque = TaxaMaximaSaque;
            this.TaxaSaque = TaxaSaque;
            this.TaxaMaximaCompraJuros = TaxaMaximaCompraJuros;
            this.TaxaCompraJuros = TaxaCompraJuros;
            this.TaxaPermanencia = TaxaPermanencia;
            this.TaxaRefinanciamento = TaxaRefinanciamento;
            this.TaxaRecuperacaoRefinanciamento = TaxaRecuperacaoRefinanciamento;
            this.TaxaPercCalcPagamentoMinimo = TaxaPercCalcPagamentoMinimo;
            this.PlanoTaxaDefault = PlanoTaxaDefault;
            
        }
        
    
        /// <summary>
        /// {{{taxas_refinanciamento_response_id_value}}}
        /// </summary>
        /// <value>{{{taxas_refinanciamento_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{taxas_refinanciamento_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{taxas_refinanciamento_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{taxas_refinanciamento_response_id_produto_value}}}
        /// </summary>
        /// <value>{{{taxas_refinanciamento_response_id_produto_value}}}</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// {{{taxas_refinanciamento_response_id_plano_conta_value}}}
        /// </summary>
        /// <value>{{{taxas_refinanciamento_response_id_plano_conta_value}}}</value>
        [DataMember(Name="idPlanoConta", EmitDefaultValue=false)]
        public long? IdPlanoConta { get; set; }
    
        /// <summary>
        /// {{{taxas_refinanciamento_response_id_plano_pct_value}}}
        /// </summary>
        /// <value>{{{taxas_refinanciamento_response_id_plano_pct_value}}}</value>
        [DataMember(Name="idPlanoPct", EmitDefaultValue=false)]
        public long? IdPlanoPct { get; set; }
    
        /// <summary>
        /// {{{taxas_refinanciamento_response_id_plano_credito_taxa_value}}}
        /// </summary>
        /// <value>{{{taxas_refinanciamento_response_id_plano_credito_taxa_value}}}</value>
        [DataMember(Name="idPlanoCreditoTaxa", EmitDefaultValue=false)]
        public long? IdPlanoCreditoTaxa { get; set; }
    
        /// <summary>
        /// {{{taxas_refinanciamento_response_data_entrada_value}}}
        /// </summary>
        /// <value>{{{taxas_refinanciamento_response_data_entrada_value}}}</value>
        [DataMember(Name="dataEntrada", EmitDefaultValue=false)]
        public string DataEntrada { get; set; }
    
        /// <summary>
        /// {{{taxas_refinanciamento_response_vencimento_value}}}
        /// </summary>
        /// <value>{{{taxas_refinanciamento_response_vencimento_value}}}</value>
        [DataMember(Name="vencimento", EmitDefaultValue=false)]
        public string Vencimento { get; set; }
    
        /// <summary>
        /// {{{taxas_refinanciamento_response_recuperacao_encargos_financeiros_value}}}
        /// </summary>
        /// <value>{{{taxas_refinanciamento_response_recuperacao_encargos_financeiros_value}}}</value>
        [DataMember(Name="recuperacaoEncargosFinanceiros", EmitDefaultValue=false)]
        public double? RecuperacaoEncargosFinanceiros { get; set; }
    
        /// <summary>
        /// {{{taxas_refinanciamento_response_comissao_garantia_value}}}
        /// </summary>
        /// <value>{{{taxas_refinanciamento_response_comissao_garantia_value}}}</value>
        [DataMember(Name="comissaoGarantia", EmitDefaultValue=false)]
        public double? ComissaoGarantia { get; set; }
    
        /// <summary>
        /// {{{taxas_refinanciamento_response_agenciamento_value}}}
        /// </summary>
        /// <value>{{{taxas_refinanciamento_response_agenciamento_value}}}</value>
        [DataMember(Name="agenciamento", EmitDefaultValue=false)]
        public double? Agenciamento { get; set; }
    
        /// <summary>
        /// {{{taxas_refinanciamento_response_taxa_maxima_proximo_periodo_value}}}
        /// </summary>
        /// <value>{{{taxas_refinanciamento_response_taxa_maxima_proximo_periodo_value}}}</value>
        [DataMember(Name="taxaMaximaProximoPeriodo", EmitDefaultValue=false)]
        public double? TaxaMaximaProximoPeriodo { get; set; }
    
        /// <summary>
        /// {{{taxas_refinanciamento_response_taxa_encargos_financiamento_value}}}
        /// </summary>
        /// <value>{{{taxas_refinanciamento_response_taxa_encargos_financiamento_value}}}</value>
        [DataMember(Name="taxaEncargosFinanciamento", EmitDefaultValue=false)]
        public double? TaxaEncargosFinanciamento { get; set; }
    
        /// <summary>
        /// {{{taxas_refinanciamento_response_taxa_maxima_saque_value}}}
        /// </summary>
        /// <value>{{{taxas_refinanciamento_response_taxa_maxima_saque_value}}}</value>
        [DataMember(Name="taxaMaximaSaque", EmitDefaultValue=false)]
        public double? TaxaMaximaSaque { get; set; }
    
        /// <summary>
        /// {{{taxas_refinanciamento_response_taxa_saque_value}}}
        /// </summary>
        /// <value>{{{taxas_refinanciamento_response_taxa_saque_value}}}</value>
        [DataMember(Name="taxaSaque", EmitDefaultValue=false)]
        public double? TaxaSaque { get; set; }
    
        /// <summary>
        /// {{{taxas_refinanciamento_response_taxa_maxima_compra_juros_value}}}
        /// </summary>
        /// <value>{{{taxas_refinanciamento_response_taxa_maxima_compra_juros_value}}}</value>
        [DataMember(Name="taxaMaximaCompraJuros", EmitDefaultValue=false)]
        public double? TaxaMaximaCompraJuros { get; set; }
    
        /// <summary>
        /// {{{taxas_refinanciamento_response_taxa_compra_juros_value}}}
        /// </summary>
        /// <value>{{{taxas_refinanciamento_response_taxa_compra_juros_value}}}</value>
        [DataMember(Name="taxaCompraJuros", EmitDefaultValue=false)]
        public double? TaxaCompraJuros { get; set; }
    
        /// <summary>
        /// {{{taxas_refinanciamento_response_taxa_permanencia_value}}}
        /// </summary>
        /// <value>{{{taxas_refinanciamento_response_taxa_permanencia_value}}}</value>
        [DataMember(Name="taxaPermanencia", EmitDefaultValue=false)]
        public double? TaxaPermanencia { get; set; }
    
        /// <summary>
        /// {{{taxas_refinanciamento_response_taxa_refinanciamento_value}}}
        /// </summary>
        /// <value>{{{taxas_refinanciamento_response_taxa_refinanciamento_value}}}</value>
        [DataMember(Name="taxaRefinanciamento", EmitDefaultValue=false)]
        public double? TaxaRefinanciamento { get; set; }
    
        /// <summary>
        /// {{{taxas_refinanciamento_response_taxa_recuperacao_refinanciamento_value}}}
        /// </summary>
        /// <value>{{{taxas_refinanciamento_response_taxa_recuperacao_refinanciamento_value}}}</value>
        [DataMember(Name="taxaRecuperacaoRefinanciamento", EmitDefaultValue=false)]
        public double? TaxaRecuperacaoRefinanciamento { get; set; }
    
        /// <summary>
        /// {{{taxas_refinanciamento_response_taxa_perc_calc_pagamento_minimo_value}}}
        /// </summary>
        /// <value>{{{taxas_refinanciamento_response_taxa_perc_calc_pagamento_minimo_value}}}</value>
        [DataMember(Name="taxaPercCalcPagamentoMinimo", EmitDefaultValue=false)]
        public double? TaxaPercCalcPagamentoMinimo { get; set; }
    
        /// <summary>
        /// {{{taxas_refinanciamento_response_plano_taxa_default_value}}}
        /// </summary>
        /// <value>{{{taxas_refinanciamento_response_plano_taxa_default_value}}}</value>
        [DataMember(Name="planoTaxaDefault", EmitDefaultValue=false)]
        public int? PlanoTaxaDefault { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxasRefinanciamentoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  IdPlanoConta: ").Append(IdPlanoConta).Append("\n");
            sb.Append("  IdPlanoPct: ").Append(IdPlanoPct).Append("\n");
            sb.Append("  IdPlanoCreditoTaxa: ").Append(IdPlanoCreditoTaxa).Append("\n");
            sb.Append("  DataEntrada: ").Append(DataEntrada).Append("\n");
            sb.Append("  Vencimento: ").Append(Vencimento).Append("\n");
            sb.Append("  RecuperacaoEncargosFinanceiros: ").Append(RecuperacaoEncargosFinanceiros).Append("\n");
            sb.Append("  ComissaoGarantia: ").Append(ComissaoGarantia).Append("\n");
            sb.Append("  Agenciamento: ").Append(Agenciamento).Append("\n");
            sb.Append("  TaxaMaximaProximoPeriodo: ").Append(TaxaMaximaProximoPeriodo).Append("\n");
            sb.Append("  TaxaEncargosFinanciamento: ").Append(TaxaEncargosFinanciamento).Append("\n");
            sb.Append("  TaxaMaximaSaque: ").Append(TaxaMaximaSaque).Append("\n");
            sb.Append("  TaxaSaque: ").Append(TaxaSaque).Append("\n");
            sb.Append("  TaxaMaximaCompraJuros: ").Append(TaxaMaximaCompraJuros).Append("\n");
            sb.Append("  TaxaCompraJuros: ").Append(TaxaCompraJuros).Append("\n");
            sb.Append("  TaxaPermanencia: ").Append(TaxaPermanencia).Append("\n");
            sb.Append("  TaxaRefinanciamento: ").Append(TaxaRefinanciamento).Append("\n");
            sb.Append("  TaxaRecuperacaoRefinanciamento: ").Append(TaxaRecuperacaoRefinanciamento).Append("\n");
            sb.Append("  TaxaPercCalcPagamentoMinimo: ").Append(TaxaPercCalcPagamentoMinimo).Append("\n");
            sb.Append("  PlanoTaxaDefault: ").Append(PlanoTaxaDefault).Append("\n");
            
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
            return this.Equals(obj as TaxasRefinanciamentoResponse);
        }

        /// <summary>
        /// Returns true if TaxasRefinanciamentoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TaxasRefinanciamentoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxasRefinanciamentoResponse other)
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
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.IdPlanoConta == other.IdPlanoConta ||
                    this.IdPlanoConta != null &&
                    this.IdPlanoConta.Equals(other.IdPlanoConta)
                ) && 
                (
                    this.IdPlanoPct == other.IdPlanoPct ||
                    this.IdPlanoPct != null &&
                    this.IdPlanoPct.Equals(other.IdPlanoPct)
                ) && 
                (
                    this.IdPlanoCreditoTaxa == other.IdPlanoCreditoTaxa ||
                    this.IdPlanoCreditoTaxa != null &&
                    this.IdPlanoCreditoTaxa.Equals(other.IdPlanoCreditoTaxa)
                ) && 
                (
                    this.DataEntrada == other.DataEntrada ||
                    this.DataEntrada != null &&
                    this.DataEntrada.Equals(other.DataEntrada)
                ) && 
                (
                    this.Vencimento == other.Vencimento ||
                    this.Vencimento != null &&
                    this.Vencimento.Equals(other.Vencimento)
                ) && 
                (
                    this.RecuperacaoEncargosFinanceiros == other.RecuperacaoEncargosFinanceiros ||
                    this.RecuperacaoEncargosFinanceiros != null &&
                    this.RecuperacaoEncargosFinanceiros.Equals(other.RecuperacaoEncargosFinanceiros)
                ) && 
                (
                    this.ComissaoGarantia == other.ComissaoGarantia ||
                    this.ComissaoGarantia != null &&
                    this.ComissaoGarantia.Equals(other.ComissaoGarantia)
                ) && 
                (
                    this.Agenciamento == other.Agenciamento ||
                    this.Agenciamento != null &&
                    this.Agenciamento.Equals(other.Agenciamento)
                ) && 
                (
                    this.TaxaMaximaProximoPeriodo == other.TaxaMaximaProximoPeriodo ||
                    this.TaxaMaximaProximoPeriodo != null &&
                    this.TaxaMaximaProximoPeriodo.Equals(other.TaxaMaximaProximoPeriodo)
                ) && 
                (
                    this.TaxaEncargosFinanciamento == other.TaxaEncargosFinanciamento ||
                    this.TaxaEncargosFinanciamento != null &&
                    this.TaxaEncargosFinanciamento.Equals(other.TaxaEncargosFinanciamento)
                ) && 
                (
                    this.TaxaMaximaSaque == other.TaxaMaximaSaque ||
                    this.TaxaMaximaSaque != null &&
                    this.TaxaMaximaSaque.Equals(other.TaxaMaximaSaque)
                ) && 
                (
                    this.TaxaSaque == other.TaxaSaque ||
                    this.TaxaSaque != null &&
                    this.TaxaSaque.Equals(other.TaxaSaque)
                ) && 
                (
                    this.TaxaMaximaCompraJuros == other.TaxaMaximaCompraJuros ||
                    this.TaxaMaximaCompraJuros != null &&
                    this.TaxaMaximaCompraJuros.Equals(other.TaxaMaximaCompraJuros)
                ) && 
                (
                    this.TaxaCompraJuros == other.TaxaCompraJuros ||
                    this.TaxaCompraJuros != null &&
                    this.TaxaCompraJuros.Equals(other.TaxaCompraJuros)
                ) && 
                (
                    this.TaxaPermanencia == other.TaxaPermanencia ||
                    this.TaxaPermanencia != null &&
                    this.TaxaPermanencia.Equals(other.TaxaPermanencia)
                ) && 
                (
                    this.TaxaRefinanciamento == other.TaxaRefinanciamento ||
                    this.TaxaRefinanciamento != null &&
                    this.TaxaRefinanciamento.Equals(other.TaxaRefinanciamento)
                ) && 
                (
                    this.TaxaRecuperacaoRefinanciamento == other.TaxaRecuperacaoRefinanciamento ||
                    this.TaxaRecuperacaoRefinanciamento != null &&
                    this.TaxaRecuperacaoRefinanciamento.Equals(other.TaxaRecuperacaoRefinanciamento)
                ) && 
                (
                    this.TaxaPercCalcPagamentoMinimo == other.TaxaPercCalcPagamentoMinimo ||
                    this.TaxaPercCalcPagamentoMinimo != null &&
                    this.TaxaPercCalcPagamentoMinimo.Equals(other.TaxaPercCalcPagamentoMinimo)
                ) && 
                (
                    this.PlanoTaxaDefault == other.PlanoTaxaDefault ||
                    this.PlanoTaxaDefault != null &&
                    this.PlanoTaxaDefault.Equals(other.PlanoTaxaDefault)
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
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.IdPlanoConta != null)
                    hash = hash * 59 + this.IdPlanoConta.GetHashCode();
                
                if (this.IdPlanoPct != null)
                    hash = hash * 59 + this.IdPlanoPct.GetHashCode();
                
                if (this.IdPlanoCreditoTaxa != null)
                    hash = hash * 59 + this.IdPlanoCreditoTaxa.GetHashCode();
                
                if (this.DataEntrada != null)
                    hash = hash * 59 + this.DataEntrada.GetHashCode();
                
                if (this.Vencimento != null)
                    hash = hash * 59 + this.Vencimento.GetHashCode();
                
                if (this.RecuperacaoEncargosFinanceiros != null)
                    hash = hash * 59 + this.RecuperacaoEncargosFinanceiros.GetHashCode();
                
                if (this.ComissaoGarantia != null)
                    hash = hash * 59 + this.ComissaoGarantia.GetHashCode();
                
                if (this.Agenciamento != null)
                    hash = hash * 59 + this.Agenciamento.GetHashCode();
                
                if (this.TaxaMaximaProximoPeriodo != null)
                    hash = hash * 59 + this.TaxaMaximaProximoPeriodo.GetHashCode();
                
                if (this.TaxaEncargosFinanciamento != null)
                    hash = hash * 59 + this.TaxaEncargosFinanciamento.GetHashCode();
                
                if (this.TaxaMaximaSaque != null)
                    hash = hash * 59 + this.TaxaMaximaSaque.GetHashCode();
                
                if (this.TaxaSaque != null)
                    hash = hash * 59 + this.TaxaSaque.GetHashCode();
                
                if (this.TaxaMaximaCompraJuros != null)
                    hash = hash * 59 + this.TaxaMaximaCompraJuros.GetHashCode();
                
                if (this.TaxaCompraJuros != null)
                    hash = hash * 59 + this.TaxaCompraJuros.GetHashCode();
                
                if (this.TaxaPermanencia != null)
                    hash = hash * 59 + this.TaxaPermanencia.GetHashCode();
                
                if (this.TaxaRefinanciamento != null)
                    hash = hash * 59 + this.TaxaRefinanciamento.GetHashCode();
                
                if (this.TaxaRecuperacaoRefinanciamento != null)
                    hash = hash * 59 + this.TaxaRecuperacaoRefinanciamento.GetHashCode();
                
                if (this.TaxaPercCalcPagamentoMinimo != null)
                    hash = hash * 59 + this.TaxaPercCalcPagamentoMinimo.GetHashCode();
                
                if (this.PlanoTaxaDefault != null)
                    hash = hash * 59 + this.PlanoTaxaDefault.GetHashCode();
                
                return hash;
            }
        }

    }
}
