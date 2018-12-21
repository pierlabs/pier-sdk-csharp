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
    /// Invoice
    /// </summary>
    [DataContract]
    public partial class FaturaFechadaResponse :  IEquatable<FaturaFechadaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FaturaFechadaResponse" /> class.
        /// Initializes a new instance of the <see cref="FaturaFechadaResponse" />class.
        /// </summary>
        /// <param name="Id">Identifier Code of the invoice.</param>
        /// <param name="IdConta">Identifier code of the account.</param>
        /// <param name="FlagEmiteFatura">Identifier Code of the account which the invoice refers to.</param>
        /// <param name="DataVencimentoFatura">Expiration date of the invoice.</param>
        /// <param name="ValorTotalFatura">Value for the total payment of the invoice.</param>
        /// <param name="ValorFaturaAnterior">Total value of the previous invoice.</param>
        /// <param name="ValorPagamentoMinimo">Minimum value for payment of the invoice.</param>
        /// <param name="TotalComprasNacionais">Total value of the national shops launched in the invoice.</param>
        /// <param name="TotalComprasInternacionas">Total value of the internatitional shops launched in the invoice.</param>
        /// <param name="TotalSaquesNacionais">Total value of the national Withdrawals launched in the invoice.</param>
        /// <param name="TotalSaquesInternacionais">Total value of the international Withdrawals launched in the invoice.</param>
        /// <param name="TotalDebitosNacionais">Total Value of the national debits launched in the invoice.</param>
        /// <param name="TotalDebitosRecorrentes">Total Value of the recurrent debits launched in the invoice.</param>
        /// <param name="TotalDebitosInternacionais">Total value of the international debits launched in the invoice.</param>
        /// <param name="TotalDebitosDiversosNacionais">Total Value of the Several National Debits launched in the invoice.</param>
        /// <param name="TotalDebitosOpcionais">Total value of the Several Optional Debits launched in the invoice.</param>
        /// <param name="TotalPagamentos">total value of the payments launched in the invoice.</param>
        /// <param name="TotalCreditosNacionais">Total value of the national credits launched in the invoice.</param>
        /// <param name="TotalAjustes">Total value of the adjustments launched in the invoice.</param>
        /// <param name="TotalTarifas">Total value of the fees launched in the invoice.</param>
        /// <param name="TotalMulta">Total Value of the fine launched in the invoice.</param>
        /// <param name="TotalJuros">Total value of the interest launched in the invoice.</param>
        /// <param name="TaxaRotativo">Percentage value of the revolving interest taxes.</param>
        /// <param name="TaxaSaque">Percentage value of the Withdrawal taxe.</param>
        /// <param name="TaxaMaximaProximoPeriodo">Maximum percentage value of the charges for the next period.</param>
        /// <param name="TotalServicos">Show the sum of all the charged insurances in the invoice of the client (required).</param>
        /// <param name="TotalParceladoNacionais">Show the sum of all parceled values + national shops (required).</param>
        /// <param name="TotalParceladoInternacionais">Show the sum of all the parceled values + international shops (required).</param>

        public FaturaFechadaResponse(long? Id = null, long? IdConta = null, int? FlagEmiteFatura = null, string DataVencimentoFatura = null, double? ValorTotalFatura = null, double? ValorFaturaAnterior = null, double? ValorPagamentoMinimo = null, double? TotalComprasNacionais = null, double? TotalComprasInternacionas = null, double? TotalSaquesNacionais = null, double? TotalSaquesInternacionais = null, double? TotalDebitosNacionais = null, double? TotalDebitosRecorrentes = null, double? TotalDebitosInternacionais = null, double? TotalDebitosDiversosNacionais = null, double? TotalDebitosOpcionais = null, double? TotalPagamentos = null, double? TotalCreditosNacionais = null, double? TotalAjustes = null, double? TotalTarifas = null, double? TotalMulta = null, double? TotalJuros = null, double? TaxaRotativo = null, double? TaxaSaque = null, double? TaxaMaximaProximoPeriodo = null, double? TotalServicos = null, double? TotalParceladoNacionais = null, double? TotalParceladoInternacionais = null)
        {
            // to ensure "TotalServicos" is required (not null)
            if (TotalServicos == null)
            {
                throw new InvalidDataException("TotalServicos is a required property for FaturaFechadaResponse and cannot be null");
            }
            else
            {
                this.TotalServicos = TotalServicos;
            }
            // to ensure "TotalParceladoNacionais" is required (not null)
            if (TotalParceladoNacionais == null)
            {
                throw new InvalidDataException("TotalParceladoNacionais is a required property for FaturaFechadaResponse and cannot be null");
            }
            else
            {
                this.TotalParceladoNacionais = TotalParceladoNacionais;
            }
            // to ensure "TotalParceladoInternacionais" is required (not null)
            if (TotalParceladoInternacionais == null)
            {
                throw new InvalidDataException("TotalParceladoInternacionais is a required property for FaturaFechadaResponse and cannot be null");
            }
            else
            {
                this.TotalParceladoInternacionais = TotalParceladoInternacionais;
            }
            this.Id = Id;
            this.IdConta = IdConta;
            this.FlagEmiteFatura = FlagEmiteFatura;
            this.DataVencimentoFatura = DataVencimentoFatura;
            this.ValorTotalFatura = ValorTotalFatura;
            this.ValorFaturaAnterior = ValorFaturaAnterior;
            this.ValorPagamentoMinimo = ValorPagamentoMinimo;
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
        /// Identifier Code of the invoice
        /// </summary>
        /// <value>Identifier Code of the invoice</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Identifier code of the account
        /// </summary>
        /// <value>Identifier code of the account</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Identifier Code of the account which the invoice refers to
        /// </summary>
        /// <value>Identifier Code of the account which the invoice refers to</value>
        [DataMember(Name="flagEmiteFatura", EmitDefaultValue=false)]
        public int? FlagEmiteFatura { get; set; }
    
        /// <summary>
        /// Expiration date of the invoice
        /// </summary>
        /// <value>Expiration date of the invoice</value>
        [DataMember(Name="dataVencimentoFatura", EmitDefaultValue=false)]
        public string DataVencimentoFatura { get; set; }
    
        /// <summary>
        /// Value for the total payment of the invoice
        /// </summary>
        /// <value>Value for the total payment of the invoice</value>
        [DataMember(Name="valorTotalFatura", EmitDefaultValue=false)]
        public double? ValorTotalFatura { get; set; }
    
        /// <summary>
        /// Total value of the previous invoice
        /// </summary>
        /// <value>Total value of the previous invoice</value>
        [DataMember(Name="valorFaturaAnterior", EmitDefaultValue=false)]
        public double? ValorFaturaAnterior { get; set; }
    
        /// <summary>
        /// Minimum value for payment of the invoice
        /// </summary>
        /// <value>Minimum value for payment of the invoice</value>
        [DataMember(Name="valorPagamentoMinimo", EmitDefaultValue=false)]
        public double? ValorPagamentoMinimo { get; set; }
    
        /// <summary>
        /// Total value of the national shops launched in the invoice
        /// </summary>
        /// <value>Total value of the national shops launched in the invoice</value>
        [DataMember(Name="totalComprasNacionais", EmitDefaultValue=false)]
        public double? TotalComprasNacionais { get; set; }
    
        /// <summary>
        /// Total value of the internatitional shops launched in the invoice
        /// </summary>
        /// <value>Total value of the internatitional shops launched in the invoice</value>
        [DataMember(Name="totalComprasInternacionas", EmitDefaultValue=false)]
        public double? TotalComprasInternacionas { get; set; }
    
        /// <summary>
        /// Total value of the national Withdrawals launched in the invoice
        /// </summary>
        /// <value>Total value of the national Withdrawals launched in the invoice</value>
        [DataMember(Name="totalSaquesNacionais", EmitDefaultValue=false)]
        public double? TotalSaquesNacionais { get; set; }
    
        /// <summary>
        /// Total value of the international Withdrawals launched in the invoice
        /// </summary>
        /// <value>Total value of the international Withdrawals launched in the invoice</value>
        [DataMember(Name="totalSaquesInternacionais", EmitDefaultValue=false)]
        public double? TotalSaquesInternacionais { get; set; }
    
        /// <summary>
        /// Total Value of the national debits launched in the invoice
        /// </summary>
        /// <value>Total Value of the national debits launched in the invoice</value>
        [DataMember(Name="totalDebitosNacionais", EmitDefaultValue=false)]
        public double? TotalDebitosNacionais { get; set; }
    
        /// <summary>
        /// Total Value of the recurrent debits launched in the invoice
        /// </summary>
        /// <value>Total Value of the recurrent debits launched in the invoice</value>
        [DataMember(Name="totalDebitosRecorrentes", EmitDefaultValue=false)]
        public double? TotalDebitosRecorrentes { get; set; }
    
        /// <summary>
        /// Total value of the international debits launched in the invoice
        /// </summary>
        /// <value>Total value of the international debits launched in the invoice</value>
        [DataMember(Name="totalDebitosInternacionais", EmitDefaultValue=false)]
        public double? TotalDebitosInternacionais { get; set; }
    
        /// <summary>
        /// Total Value of the Several National Debits launched in the invoice
        /// </summary>
        /// <value>Total Value of the Several National Debits launched in the invoice</value>
        [DataMember(Name="totalDebitosDiversosNacionais", EmitDefaultValue=false)]
        public double? TotalDebitosDiversosNacionais { get; set; }
    
        /// <summary>
        /// Total value of the Several Optional Debits launched in the invoice
        /// </summary>
        /// <value>Total value of the Several Optional Debits launched in the invoice</value>
        [DataMember(Name="totalDebitosOpcionais", EmitDefaultValue=false)]
        public double? TotalDebitosOpcionais { get; set; }
    
        /// <summary>
        /// total value of the payments launched in the invoice
        /// </summary>
        /// <value>total value of the payments launched in the invoice</value>
        [DataMember(Name="totalPagamentos", EmitDefaultValue=false)]
        public double? TotalPagamentos { get; set; }
    
        /// <summary>
        /// Total value of the national credits launched in the invoice
        /// </summary>
        /// <value>Total value of the national credits launched in the invoice</value>
        [DataMember(Name="totalCreditosNacionais", EmitDefaultValue=false)]
        public double? TotalCreditosNacionais { get; set; }
    
        /// <summary>
        /// Total value of the adjustments launched in the invoice
        /// </summary>
        /// <value>Total value of the adjustments launched in the invoice</value>
        [DataMember(Name="totalAjustes", EmitDefaultValue=false)]
        public double? TotalAjustes { get; set; }
    
        /// <summary>
        /// Total value of the fees launched in the invoice
        /// </summary>
        /// <value>Total value of the fees launched in the invoice</value>
        [DataMember(Name="totalTarifas", EmitDefaultValue=false)]
        public double? TotalTarifas { get; set; }
    
        /// <summary>
        /// Total Value of the fine launched in the invoice
        /// </summary>
        /// <value>Total Value of the fine launched in the invoice</value>
        [DataMember(Name="totalMulta", EmitDefaultValue=false)]
        public double? TotalMulta { get; set; }
    
        /// <summary>
        /// Total value of the interest launched in the invoice
        /// </summary>
        /// <value>Total value of the interest launched in the invoice</value>
        [DataMember(Name="totalJuros", EmitDefaultValue=false)]
        public double? TotalJuros { get; set; }
    
        /// <summary>
        /// Percentage value of the revolving interest taxes
        /// </summary>
        /// <value>Percentage value of the revolving interest taxes</value>
        [DataMember(Name="taxaRotativo", EmitDefaultValue=false)]
        public double? TaxaRotativo { get; set; }
    
        /// <summary>
        /// Percentage value of the Withdrawal taxe
        /// </summary>
        /// <value>Percentage value of the Withdrawal taxe</value>
        [DataMember(Name="taxaSaque", EmitDefaultValue=false)]
        public double? TaxaSaque { get; set; }
    
        /// <summary>
        /// Maximum percentage value of the charges for the next period
        /// </summary>
        /// <value>Maximum percentage value of the charges for the next period</value>
        [DataMember(Name="taxaMaximaProximoPeriodo", EmitDefaultValue=false)]
        public double? TaxaMaximaProximoPeriodo { get; set; }
    
        /// <summary>
        /// Show the sum of all the charged insurances in the invoice of the client
        /// </summary>
        /// <value>Show the sum of all the charged insurances in the invoice of the client</value>
        [DataMember(Name="totalServicos", EmitDefaultValue=false)]
        public double? TotalServicos { get; set; }
    
        /// <summary>
        /// Show the sum of all parceled values + national shops
        /// </summary>
        /// <value>Show the sum of all parceled values + national shops</value>
        [DataMember(Name="totalParceladoNacionais", EmitDefaultValue=false)]
        public double? TotalParceladoNacionais { get; set; }
    
        /// <summary>
        /// Show the sum of all the parceled values + international shops
        /// </summary>
        /// <value>Show the sum of all the parceled values + international shops</value>
        [DataMember(Name="totalParceladoInternacionais", EmitDefaultValue=false)]
        public double? TotalParceladoInternacionais { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FaturaFechadaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  FlagEmiteFatura: ").Append(FlagEmiteFatura).Append("\n");
            sb.Append("  DataVencimentoFatura: ").Append(DataVencimentoFatura).Append("\n");
            sb.Append("  ValorTotalFatura: ").Append(ValorTotalFatura).Append("\n");
            sb.Append("  ValorFaturaAnterior: ").Append(ValorFaturaAnterior).Append("\n");
            sb.Append("  ValorPagamentoMinimo: ").Append(ValorPagamentoMinimo).Append("\n");
            sb.Append("  TotalComprasNacionais: ").Append(TotalComprasNacionais).Append("\n");
            sb.Append("  TotalComprasInternacionas: ").Append(TotalComprasInternacionas).Append("\n");
            sb.Append("  TotalSaquesNacionais: ").Append(TotalSaquesNacionais).Append("\n");
            sb.Append("  TotalSaquesInternacionais: ").Append(TotalSaquesInternacionais).Append("\n");
            sb.Append("  TotalDebitosNacionais: ").Append(TotalDebitosNacionais).Append("\n");
            sb.Append("  TotalDebitosRecorrentes: ").Append(TotalDebitosRecorrentes).Append("\n");
            sb.Append("  TotalDebitosInternacionais: ").Append(TotalDebitosInternacionais).Append("\n");
            sb.Append("  TotalDebitosDiversosNacionais: ").Append(TotalDebitosDiversosNacionais).Append("\n");
            sb.Append("  TotalDebitosOpcionais: ").Append(TotalDebitosOpcionais).Append("\n");
            sb.Append("  TotalPagamentos: ").Append(TotalPagamentos).Append("\n");
            sb.Append("  TotalCreditosNacionais: ").Append(TotalCreditosNacionais).Append("\n");
            sb.Append("  TotalAjustes: ").Append(TotalAjustes).Append("\n");
            sb.Append("  TotalTarifas: ").Append(TotalTarifas).Append("\n");
            sb.Append("  TotalMulta: ").Append(TotalMulta).Append("\n");
            sb.Append("  TotalJuros: ").Append(TotalJuros).Append("\n");
            sb.Append("  TaxaRotativo: ").Append(TaxaRotativo).Append("\n");
            sb.Append("  TaxaSaque: ").Append(TaxaSaque).Append("\n");
            sb.Append("  TaxaMaximaProximoPeriodo: ").Append(TaxaMaximaProximoPeriodo).Append("\n");
            sb.Append("  TotalServicos: ").Append(TotalServicos).Append("\n");
            sb.Append("  TotalParceladoNacionais: ").Append(TotalParceladoNacionais).Append("\n");
            sb.Append("  TotalParceladoInternacionais: ").Append(TotalParceladoInternacionais).Append("\n");
            
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
            return this.Equals(obj as FaturaFechadaResponse);
        }

        /// <summary>
        /// Returns true if FaturaFechadaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of FaturaFechadaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FaturaFechadaResponse other)
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
                    this.FlagEmiteFatura == other.FlagEmiteFatura ||
                    this.FlagEmiteFatura != null &&
                    this.FlagEmiteFatura.Equals(other.FlagEmiteFatura)
                ) && 
                (
                    this.DataVencimentoFatura == other.DataVencimentoFatura ||
                    this.DataVencimentoFatura != null &&
                    this.DataVencimentoFatura.Equals(other.DataVencimentoFatura)
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
                    this.TotalComprasNacionais == other.TotalComprasNacionais ||
                    this.TotalComprasNacionais != null &&
                    this.TotalComprasNacionais.Equals(other.TotalComprasNacionais)
                ) && 
                (
                    this.TotalComprasInternacionas == other.TotalComprasInternacionas ||
                    this.TotalComprasInternacionas != null &&
                    this.TotalComprasInternacionas.Equals(other.TotalComprasInternacionas)
                ) && 
                (
                    this.TotalSaquesNacionais == other.TotalSaquesNacionais ||
                    this.TotalSaquesNacionais != null &&
                    this.TotalSaquesNacionais.Equals(other.TotalSaquesNacionais)
                ) && 
                (
                    this.TotalSaquesInternacionais == other.TotalSaquesInternacionais ||
                    this.TotalSaquesInternacionais != null &&
                    this.TotalSaquesInternacionais.Equals(other.TotalSaquesInternacionais)
                ) && 
                (
                    this.TotalDebitosNacionais == other.TotalDebitosNacionais ||
                    this.TotalDebitosNacionais != null &&
                    this.TotalDebitosNacionais.Equals(other.TotalDebitosNacionais)
                ) && 
                (
                    this.TotalDebitosRecorrentes == other.TotalDebitosRecorrentes ||
                    this.TotalDebitosRecorrentes != null &&
                    this.TotalDebitosRecorrentes.Equals(other.TotalDebitosRecorrentes)
                ) && 
                (
                    this.TotalDebitosInternacionais == other.TotalDebitosInternacionais ||
                    this.TotalDebitosInternacionais != null &&
                    this.TotalDebitosInternacionais.Equals(other.TotalDebitosInternacionais)
                ) && 
                (
                    this.TotalDebitosDiversosNacionais == other.TotalDebitosDiversosNacionais ||
                    this.TotalDebitosDiversosNacionais != null &&
                    this.TotalDebitosDiversosNacionais.Equals(other.TotalDebitosDiversosNacionais)
                ) && 
                (
                    this.TotalDebitosOpcionais == other.TotalDebitosOpcionais ||
                    this.TotalDebitosOpcionais != null &&
                    this.TotalDebitosOpcionais.Equals(other.TotalDebitosOpcionais)
                ) && 
                (
                    this.TotalPagamentos == other.TotalPagamentos ||
                    this.TotalPagamentos != null &&
                    this.TotalPagamentos.Equals(other.TotalPagamentos)
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
                    this.TotalJuros == other.TotalJuros ||
                    this.TotalJuros != null &&
                    this.TotalJuros.Equals(other.TotalJuros)
                ) && 
                (
                    this.TaxaRotativo == other.TaxaRotativo ||
                    this.TaxaRotativo != null &&
                    this.TaxaRotativo.Equals(other.TaxaRotativo)
                ) && 
                (
                    this.TaxaSaque == other.TaxaSaque ||
                    this.TaxaSaque != null &&
                    this.TaxaSaque.Equals(other.TaxaSaque)
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
                ) && 
                (
                    this.TotalParceladoNacionais == other.TotalParceladoNacionais ||
                    this.TotalParceladoNacionais != null &&
                    this.TotalParceladoNacionais.Equals(other.TotalParceladoNacionais)
                ) && 
                (
                    this.TotalParceladoInternacionais == other.TotalParceladoInternacionais ||
                    this.TotalParceladoInternacionais != null &&
                    this.TotalParceladoInternacionais.Equals(other.TotalParceladoInternacionais)
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
                
                if (this.FlagEmiteFatura != null)
                    hash = hash * 59 + this.FlagEmiteFatura.GetHashCode();
                
                if (this.DataVencimentoFatura != null)
                    hash = hash * 59 + this.DataVencimentoFatura.GetHashCode();
                
                if (this.ValorTotalFatura != null)
                    hash = hash * 59 + this.ValorTotalFatura.GetHashCode();
                
                if (this.ValorFaturaAnterior != null)
                    hash = hash * 59 + this.ValorFaturaAnterior.GetHashCode();
                
                if (this.ValorPagamentoMinimo != null)
                    hash = hash * 59 + this.ValorPagamentoMinimo.GetHashCode();
                
                if (this.TotalComprasNacionais != null)
                    hash = hash * 59 + this.TotalComprasNacionais.GetHashCode();
                
                if (this.TotalComprasInternacionas != null)
                    hash = hash * 59 + this.TotalComprasInternacionas.GetHashCode();
                
                if (this.TotalSaquesNacionais != null)
                    hash = hash * 59 + this.TotalSaquesNacionais.GetHashCode();
                
                if (this.TotalSaquesInternacionais != null)
                    hash = hash * 59 + this.TotalSaquesInternacionais.GetHashCode();
                
                if (this.TotalDebitosNacionais != null)
                    hash = hash * 59 + this.TotalDebitosNacionais.GetHashCode();
                
                if (this.TotalDebitosRecorrentes != null)
                    hash = hash * 59 + this.TotalDebitosRecorrentes.GetHashCode();
                
                if (this.TotalDebitosInternacionais != null)
                    hash = hash * 59 + this.TotalDebitosInternacionais.GetHashCode();
                
                if (this.TotalDebitosDiversosNacionais != null)
                    hash = hash * 59 + this.TotalDebitosDiversosNacionais.GetHashCode();
                
                if (this.TotalDebitosOpcionais != null)
                    hash = hash * 59 + this.TotalDebitosOpcionais.GetHashCode();
                
                if (this.TotalPagamentos != null)
                    hash = hash * 59 + this.TotalPagamentos.GetHashCode();
                
                if (this.TotalCreditosNacionais != null)
                    hash = hash * 59 + this.TotalCreditosNacionais.GetHashCode();
                
                if (this.TotalAjustes != null)
                    hash = hash * 59 + this.TotalAjustes.GetHashCode();
                
                if (this.TotalTarifas != null)
                    hash = hash * 59 + this.TotalTarifas.GetHashCode();
                
                if (this.TotalMulta != null)
                    hash = hash * 59 + this.TotalMulta.GetHashCode();
                
                if (this.TotalJuros != null)
                    hash = hash * 59 + this.TotalJuros.GetHashCode();
                
                if (this.TaxaRotativo != null)
                    hash = hash * 59 + this.TaxaRotativo.GetHashCode();
                
                if (this.TaxaSaque != null)
                    hash = hash * 59 + this.TaxaSaque.GetHashCode();
                
                if (this.TaxaMaximaProximoPeriodo != null)
                    hash = hash * 59 + this.TaxaMaximaProximoPeriodo.GetHashCode();
                
                if (this.TotalServicos != null)
                    hash = hash * 59 + this.TotalServicos.GetHashCode();
                
                if (this.TotalParceladoNacionais != null)
                    hash = hash * 59 + this.TotalParceladoNacionais.GetHashCode();
                
                if (this.TotalParceladoInternacionais != null)
                    hash = hash * 59 + this.TotalParceladoInternacionais.GetHashCode();
                
                return hash;
            }
        }

    }
}
