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
    /// Objeto de resposta para a valida\u00C3\u00A7\u00C3\u00A3o das Taxas de Refinanciamento
    /// </summary>
    [DataContract]
    public partial class TaxasRefinanciamento :  IEquatable<TaxasRefinanciamento>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxasRefinanciamento" /> class.
        /// Initializes a new instance of the <see cref="TaxasRefinanciamento" />class.
        /// </summary>
        /// <param name="Id">ID das taxas.</param>
        /// <param name="IdConta">ID da conta.</param>
        /// <param name="IdProduto">ID do produto.</param>
        /// <param name="IdPlanoConta">ID do plano de contas.</param>
        /// <param name="IdPlanoPct">ID do plano PCT.</param>
        /// <param name="IdPlanoCreditoTaxa">ID do plano credito taxa.</param>
        /// <param name="DataEntrada">Data de entrada.</param>
        /// <param name="Vencimento">Vencimento das taxas.</param>
        /// <param name="RecuperacaoEncargosFinanceiros">Recupera\u00C3\u00A7\u00C3\u00A3o de encargos financeiro.</param>
        /// <param name="ComissaoGarantia">Descri\u00C3\u00A7\u00C3\u00A3o da comiss\u00C3\u00A3o de garantia.</param>
        /// <param name="Agenciamento">Descri\u00C3\u00A7\u00C3\u00A3o do agenciamento.</param>
        /// <param name="TaxaMaximaProximoPeriodo">Taxa m\u00C3\u00A1xima do proximo per\u00C3\u00ADodo.</param>
        /// <param name="TaxaEncargosFinanciamento">Taxa de encargos do financiamento.</param>
        /// <param name="TaxaMaximaSaque">Taxa m\u00C3\u00A1xima de saque.</param>
        /// <param name="TaxaSaque">Taxa de saque.</param>
        /// <param name="TaxaMaximaCompraJuros">Taxa m\u00C3\u00A1xima de compras juros.</param>
        /// <param name="TaxaCompraJuros">Taxa de juros compra.</param>
        /// <param name="TaxaPermanencia">Taxa de permanencia.</param>
        /// <param name="TaxaRefinanciamento">Taxa de permanencia.</param>
        /// <param name="TaxaRecuperacaoRefinanciamento">Taxa de permanencia.</param>
        /// <param name="TaxaPercCalcPagamentoMinimo">Taxa Percelamento pagamento minimo.</param>
        /// <param name="PlanoTaxaDefault">Plano de taxa padr\u00C3\u00A3o.</param>

        public TaxasRefinanciamento(long? Id = null, long? IdConta = null, long? IdProduto = null, long? IdPlanoConta = null, long? IdPlanoPct = null, long? IdPlanoCreditoTaxa = null, string DataEntrada = null, string Vencimento = null, double? RecuperacaoEncargosFinanceiros = null, double? ComissaoGarantia = null, double? Agenciamento = null, double? TaxaMaximaProximoPeriodo = null, double? TaxaEncargosFinanciamento = null, double? TaxaMaximaSaque = null, double? TaxaSaque = null, double? TaxaMaximaCompraJuros = null, double? TaxaCompraJuros = null, double? TaxaPermanencia = null, double? TaxaRefinanciamento = null, double? TaxaRecuperacaoRefinanciamento = null, double? TaxaPercCalcPagamentoMinimo = null, int? PlanoTaxaDefault = null)
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
        /// ID das taxas
        /// </summary>
        /// <value>ID das taxas</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// ID da conta
        /// </summary>
        /// <value>ID da conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// ID do produto
        /// </summary>
        /// <value>ID do produto</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// ID do plano de contas
        /// </summary>
        /// <value>ID do plano de contas</value>
        [DataMember(Name="idPlanoConta", EmitDefaultValue=false)]
        public long? IdPlanoConta { get; set; }
    
        /// <summary>
        /// ID do plano PCT
        /// </summary>
        /// <value>ID do plano PCT</value>
        [DataMember(Name="idPlanoPct", EmitDefaultValue=false)]
        public long? IdPlanoPct { get; set; }
    
        /// <summary>
        /// ID do plano credito taxa
        /// </summary>
        /// <value>ID do plano credito taxa</value>
        [DataMember(Name="idPlanoCreditoTaxa", EmitDefaultValue=false)]
        public long? IdPlanoCreditoTaxa { get; set; }
    
        /// <summary>
        /// Data de entrada
        /// </summary>
        /// <value>Data de entrada</value>
        [DataMember(Name="dataEntrada", EmitDefaultValue=false)]
        public string DataEntrada { get; set; }
    
        /// <summary>
        /// Vencimento das taxas
        /// </summary>
        /// <value>Vencimento das taxas</value>
        [DataMember(Name="vencimento", EmitDefaultValue=false)]
        public string Vencimento { get; set; }
    
        /// <summary>
        /// Recupera\u00C3\u00A7\u00C3\u00A3o de encargos financeiro
        /// </summary>
        /// <value>Recupera\u00C3\u00A7\u00C3\u00A3o de encargos financeiro</value>
        [DataMember(Name="recuperacaoEncargosFinanceiros", EmitDefaultValue=false)]
        public double? RecuperacaoEncargosFinanceiros { get; set; }
    
        /// <summary>
        /// Descri\u00C3\u00A7\u00C3\u00A3o da comiss\u00C3\u00A3o de garantia
        /// </summary>
        /// <value>Descri\u00C3\u00A7\u00C3\u00A3o da comiss\u00C3\u00A3o de garantia</value>
        [DataMember(Name="comissaoGarantia", EmitDefaultValue=false)]
        public double? ComissaoGarantia { get; set; }
    
        /// <summary>
        /// Descri\u00C3\u00A7\u00C3\u00A3o do agenciamento
        /// </summary>
        /// <value>Descri\u00C3\u00A7\u00C3\u00A3o do agenciamento</value>
        [DataMember(Name="agenciamento", EmitDefaultValue=false)]
        public double? Agenciamento { get; set; }
    
        /// <summary>
        /// Taxa m\u00C3\u00A1xima do proximo per\u00C3\u00ADodo
        /// </summary>
        /// <value>Taxa m\u00C3\u00A1xima do proximo per\u00C3\u00ADodo</value>
        [DataMember(Name="taxaMaximaProximoPeriodo", EmitDefaultValue=false)]
        public double? TaxaMaximaProximoPeriodo { get; set; }
    
        /// <summary>
        /// Taxa de encargos do financiamento
        /// </summary>
        /// <value>Taxa de encargos do financiamento</value>
        [DataMember(Name="taxaEncargosFinanciamento", EmitDefaultValue=false)]
        public double? TaxaEncargosFinanciamento { get; set; }
    
        /// <summary>
        /// Taxa m\u00C3\u00A1xima de saque
        /// </summary>
        /// <value>Taxa m\u00C3\u00A1xima de saque</value>
        [DataMember(Name="taxaMaximaSaque", EmitDefaultValue=false)]
        public double? TaxaMaximaSaque { get; set; }
    
        /// <summary>
        /// Taxa de saque
        /// </summary>
        /// <value>Taxa de saque</value>
        [DataMember(Name="taxaSaque", EmitDefaultValue=false)]
        public double? TaxaSaque { get; set; }
    
        /// <summary>
        /// Taxa m\u00C3\u00A1xima de compras juros
        /// </summary>
        /// <value>Taxa m\u00C3\u00A1xima de compras juros</value>
        [DataMember(Name="taxaMaximaCompraJuros", EmitDefaultValue=false)]
        public double? TaxaMaximaCompraJuros { get; set; }
    
        /// <summary>
        /// Taxa de juros compra
        /// </summary>
        /// <value>Taxa de juros compra</value>
        [DataMember(Name="taxaCompraJuros", EmitDefaultValue=false)]
        public double? TaxaCompraJuros { get; set; }
    
        /// <summary>
        /// Taxa de permanencia
        /// </summary>
        /// <value>Taxa de permanencia</value>
        [DataMember(Name="taxaPermanencia", EmitDefaultValue=false)]
        public double? TaxaPermanencia { get; set; }
    
        /// <summary>
        /// Taxa de permanencia
        /// </summary>
        /// <value>Taxa de permanencia</value>
        [DataMember(Name="taxaRefinanciamento", EmitDefaultValue=false)]
        public double? TaxaRefinanciamento { get; set; }
    
        /// <summary>
        /// Taxa de permanencia
        /// </summary>
        /// <value>Taxa de permanencia</value>
        [DataMember(Name="taxaRecuperacaoRefinanciamento", EmitDefaultValue=false)]
        public double? TaxaRecuperacaoRefinanciamento { get; set; }
    
        /// <summary>
        /// Taxa Percelamento pagamento minimo
        /// </summary>
        /// <value>Taxa Percelamento pagamento minimo</value>
        [DataMember(Name="taxaPercCalcPagamentoMinimo", EmitDefaultValue=false)]
        public double? TaxaPercCalcPagamentoMinimo { get; set; }
    
        /// <summary>
        /// Plano de taxa padr\u00C3\u00A3o
        /// </summary>
        /// <value>Plano de taxa padr\u00C3\u00A3o</value>
        [DataMember(Name="planoTaxaDefault", EmitDefaultValue=false)]
        public int? PlanoTaxaDefault { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxasRefinanciamento {\n");
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
            return this.Equals(obj as TaxasRefinanciamento);
        }

        /// <summary>
        /// Returns true if TaxasRefinanciamento instances are equal
        /// </summary>
        /// <param name="other">Instance of TaxasRefinanciamento to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxasRefinanciamento other)
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
