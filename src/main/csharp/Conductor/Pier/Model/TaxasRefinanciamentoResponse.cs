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
    /// Object of response for the validation of the refinancing taxes
    /// </summary>
    [DataContract]
    public partial class TaxasRefinanciamentoResponse :  IEquatable<TaxasRefinanciamentoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxasRefinanciamentoResponse" /> class.
        /// Initializes a new instance of the <see cref="TaxasRefinanciamentoResponse" />class.
        /// </summary>
        /// <param name="Id">ID of the taxes.</param>
        /// <param name="IdConta">ID of the account.</param>
        /// <param name="IdProduto">ID of the product.</param>
        /// <param name="IdPlanoConta">ID of the account plan.</param>
        /// <param name="IdPlanoPct">ID of the PCT plan.</param>
        /// <param name="IdPlanoCreditoTaxa">ID plan taxe credit.</param>
        /// <param name="DataEntrada">Entrance date.</param>
        /// <param name="Vencimento">Expiration of the taxes.</param>
        /// <param name="RecuperacaoEncargosFinanceiros">Retrieve of the financial charges.</param>
        /// <param name="ComissaoGarantia">Description of the guarantee commission.</param>
        /// <param name="Agenciamento">Description of the management.</param>
        /// <param name="TaxaMaximaProximoPeriodo">Maximum taxe of the next period.</param>
        /// <param name="TaxaEncargosFinanciamento">Taxe of the financing charges.</param>
        /// <param name="TaxaMaximaSaque">Maximum taxe of the withdrawal.</param>
        /// <param name="TaxaSaque">Withdrawal taxe.</param>
        /// <param name="TaxaMaximaCompraJuros">Maximum taxe of shop interest.</param>
        /// <param name="TaxaCompraJuros">Shop interest taxes.</param>
        /// <param name="TaxaPermanencia">Remaining Taxe.</param>
        /// <param name="TaxaRefinanciamento">Remaining taxe.</param>
        /// <param name="TaxaRecuperacaoRefinanciamento">Taxe of remaining.</param>
        /// <param name="TaxaPercCalcPagamentoMinimo">Taxe of Installment for Minimum payment.</param>
        /// <param name="PlanoTaxaDefault">Plan of the standard taxe.</param>

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
        /// ID of the taxes
        /// </summary>
        /// <value>ID of the taxes</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// ID of the account
        /// </summary>
        /// <value>ID of the account</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// ID of the product
        /// </summary>
        /// <value>ID of the product</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// ID of the account plan
        /// </summary>
        /// <value>ID of the account plan</value>
        [DataMember(Name="idPlanoConta", EmitDefaultValue=false)]
        public long? IdPlanoConta { get; set; }
    
        /// <summary>
        /// ID of the PCT plan
        /// </summary>
        /// <value>ID of the PCT plan</value>
        [DataMember(Name="idPlanoPct", EmitDefaultValue=false)]
        public long? IdPlanoPct { get; set; }
    
        /// <summary>
        /// ID plan taxe credit
        /// </summary>
        /// <value>ID plan taxe credit</value>
        [DataMember(Name="idPlanoCreditoTaxa", EmitDefaultValue=false)]
        public long? IdPlanoCreditoTaxa { get; set; }
    
        /// <summary>
        /// Entrance date
        /// </summary>
        /// <value>Entrance date</value>
        [DataMember(Name="dataEntrada", EmitDefaultValue=false)]
        public string DataEntrada { get; set; }
    
        /// <summary>
        /// Expiration of the taxes
        /// </summary>
        /// <value>Expiration of the taxes</value>
        [DataMember(Name="vencimento", EmitDefaultValue=false)]
        public string Vencimento { get; set; }
    
        /// <summary>
        /// Retrieve of the financial charges
        /// </summary>
        /// <value>Retrieve of the financial charges</value>
        [DataMember(Name="recuperacaoEncargosFinanceiros", EmitDefaultValue=false)]
        public double? RecuperacaoEncargosFinanceiros { get; set; }
    
        /// <summary>
        /// Description of the guarantee commission
        /// </summary>
        /// <value>Description of the guarantee commission</value>
        [DataMember(Name="comissaoGarantia", EmitDefaultValue=false)]
        public double? ComissaoGarantia { get; set; }
    
        /// <summary>
        /// Description of the management
        /// </summary>
        /// <value>Description of the management</value>
        [DataMember(Name="agenciamento", EmitDefaultValue=false)]
        public double? Agenciamento { get; set; }
    
        /// <summary>
        /// Maximum taxe of the next period
        /// </summary>
        /// <value>Maximum taxe of the next period</value>
        [DataMember(Name="taxaMaximaProximoPeriodo", EmitDefaultValue=false)]
        public double? TaxaMaximaProximoPeriodo { get; set; }
    
        /// <summary>
        /// Taxe of the financing charges
        /// </summary>
        /// <value>Taxe of the financing charges</value>
        [DataMember(Name="taxaEncargosFinanciamento", EmitDefaultValue=false)]
        public double? TaxaEncargosFinanciamento { get; set; }
    
        /// <summary>
        /// Maximum taxe of the withdrawal
        /// </summary>
        /// <value>Maximum taxe of the withdrawal</value>
        [DataMember(Name="taxaMaximaSaque", EmitDefaultValue=false)]
        public double? TaxaMaximaSaque { get; set; }
    
        /// <summary>
        /// Withdrawal taxe
        /// </summary>
        /// <value>Withdrawal taxe</value>
        [DataMember(Name="taxaSaque", EmitDefaultValue=false)]
        public double? TaxaSaque { get; set; }
    
        /// <summary>
        /// Maximum taxe of shop interest
        /// </summary>
        /// <value>Maximum taxe of shop interest</value>
        [DataMember(Name="taxaMaximaCompraJuros", EmitDefaultValue=false)]
        public double? TaxaMaximaCompraJuros { get; set; }
    
        /// <summary>
        /// Shop interest taxes
        /// </summary>
        /// <value>Shop interest taxes</value>
        [DataMember(Name="taxaCompraJuros", EmitDefaultValue=false)]
        public double? TaxaCompraJuros { get; set; }
    
        /// <summary>
        /// Remaining Taxe
        /// </summary>
        /// <value>Remaining Taxe</value>
        [DataMember(Name="taxaPermanencia", EmitDefaultValue=false)]
        public double? TaxaPermanencia { get; set; }
    
        /// <summary>
        /// Remaining taxe
        /// </summary>
        /// <value>Remaining taxe</value>
        [DataMember(Name="taxaRefinanciamento", EmitDefaultValue=false)]
        public double? TaxaRefinanciamento { get; set; }
    
        /// <summary>
        /// Taxe of remaining
        /// </summary>
        /// <value>Taxe of remaining</value>
        [DataMember(Name="taxaRecuperacaoRefinanciamento", EmitDefaultValue=false)]
        public double? TaxaRecuperacaoRefinanciamento { get; set; }
    
        /// <summary>
        /// Taxe of Installment for Minimum payment
        /// </summary>
        /// <value>Taxe of Installment for Minimum payment</value>
        [DataMember(Name="taxaPercCalcPagamentoMinimo", EmitDefaultValue=false)]
        public double? TaxaPercCalcPagamentoMinimo { get; set; }
    
        /// <summary>
        /// Plan of the standard taxe
        /// </summary>
        /// <value>Plan of the standard taxe</value>
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
