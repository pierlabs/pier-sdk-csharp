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
    /// Detalhe do plano de parcelamento para Transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para contas banc\u00C3\u00A1rias
    /// </summary>
    [DataContract]
    public partial class ParcelamentoTransferenciaResponse :  IEquatable<ParcelamentoTransferenciaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ParcelamentoTransferenciaResponse" /> class.
        /// Initializes a new instance of the <see cref="ParcelamentoTransferenciaResponse" />class.
        /// </summary>
        /// <param name="NumeroParcela">N\u00C3\u00BAmero de parcelas dispon\u00C3\u00ADveis..</param>
        /// <param name="ValorParcelas">Valor das demais parcelas..</param>
        /// <param name="ValorTotal">Valor total do financiamento..</param>
        /// <param name="ValorTAC">Valor da tarifa de contrata\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="ValorIOF">IOF.</param>
        /// <param name="TaxaJuros">Valor da taxa de juros..</param>
        /// <param name="CetAnual">CET anual..</param>

        public ParcelamentoTransferenciaResponse(int? NumeroParcela = null, double? ValorParcelas = null, double? ValorTotal = null, double? ValorTAC = null, double? ValorIOF = null, double? TaxaJuros = null, double? CetAnual = null)
        {
            this.NumeroParcela = NumeroParcela;
            this.ValorParcelas = ValorParcelas;
            this.ValorTotal = ValorTotal;
            this.ValorTAC = ValorTAC;
            this.ValorIOF = ValorIOF;
            this.TaxaJuros = TaxaJuros;
            this.CetAnual = CetAnual;
            
        }
        
    
        /// <summary>
        /// N\u00C3\u00BAmero de parcelas dispon\u00C3\u00ADveis.
        /// </summary>
        /// <value>N\u00C3\u00BAmero de parcelas dispon\u00C3\u00ADveis.</value>
        [DataMember(Name="numeroParcela", EmitDefaultValue=false)]
        public int? NumeroParcela { get; set; }
    
        /// <summary>
        /// Valor das demais parcelas.
        /// </summary>
        /// <value>Valor das demais parcelas.</value>
        [DataMember(Name="valorParcelas", EmitDefaultValue=false)]
        public double? ValorParcelas { get; set; }
    
        /// <summary>
        /// Valor total do financiamento.
        /// </summary>
        /// <value>Valor total do financiamento.</value>
        [DataMember(Name="valorTotal", EmitDefaultValue=false)]
        public double? ValorTotal { get; set; }
    
        /// <summary>
        /// Valor da tarifa de contrata\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Valor da tarifa de contrata\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="valorTAC", EmitDefaultValue=false)]
        public double? ValorTAC { get; set; }
    
        /// <summary>
        /// IOF
        /// </summary>
        /// <value>IOF</value>
        [DataMember(Name="valorIOF", EmitDefaultValue=false)]
        public double? ValorIOF { get; set; }
    
        /// <summary>
        /// Valor da taxa de juros.
        /// </summary>
        /// <value>Valor da taxa de juros.</value>
        [DataMember(Name="taxaJuros", EmitDefaultValue=false)]
        public double? TaxaJuros { get; set; }
    
        /// <summary>
        /// CET anual.
        /// </summary>
        /// <value>CET anual.</value>
        [DataMember(Name="cetAnual", EmitDefaultValue=false)]
        public double? CetAnual { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParcelamentoTransferenciaResponse {\n");
            sb.Append("  NumeroParcela: ").Append(NumeroParcela).Append("\n");
            sb.Append("  ValorParcelas: ").Append(ValorParcelas).Append("\n");
            sb.Append("  ValorTotal: ").Append(ValorTotal).Append("\n");
            sb.Append("  ValorTAC: ").Append(ValorTAC).Append("\n");
            sb.Append("  ValorIOF: ").Append(ValorIOF).Append("\n");
            sb.Append("  TaxaJuros: ").Append(TaxaJuros).Append("\n");
            sb.Append("  CetAnual: ").Append(CetAnual).Append("\n");
            
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
            return this.Equals(obj as ParcelamentoTransferenciaResponse);
        }

        /// <summary>
        /// Returns true if ParcelamentoTransferenciaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ParcelamentoTransferenciaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParcelamentoTransferenciaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NumeroParcela == other.NumeroParcela ||
                    this.NumeroParcela != null &&
                    this.NumeroParcela.Equals(other.NumeroParcela)
                ) && 
                (
                    this.ValorParcelas == other.ValorParcelas ||
                    this.ValorParcelas != null &&
                    this.ValorParcelas.Equals(other.ValorParcelas)
                ) && 
                (
                    this.ValorTotal == other.ValorTotal ||
                    this.ValorTotal != null &&
                    this.ValorTotal.Equals(other.ValorTotal)
                ) && 
                (
                    this.ValorTAC == other.ValorTAC ||
                    this.ValorTAC != null &&
                    this.ValorTAC.Equals(other.ValorTAC)
                ) && 
                (
                    this.ValorIOF == other.ValorIOF ||
                    this.ValorIOF != null &&
                    this.ValorIOF.Equals(other.ValorIOF)
                ) && 
                (
                    this.TaxaJuros == other.TaxaJuros ||
                    this.TaxaJuros != null &&
                    this.TaxaJuros.Equals(other.TaxaJuros)
                ) && 
                (
                    this.CetAnual == other.CetAnual ||
                    this.CetAnual != null &&
                    this.CetAnual.Equals(other.CetAnual)
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
                
                if (this.NumeroParcela != null)
                    hash = hash * 59 + this.NumeroParcela.GetHashCode();
                
                if (this.ValorParcelas != null)
                    hash = hash * 59 + this.ValorParcelas.GetHashCode();
                
                if (this.ValorTotal != null)
                    hash = hash * 59 + this.ValorTotal.GetHashCode();
                
                if (this.ValorTAC != null)
                    hash = hash * 59 + this.ValorTAC.GetHashCode();
                
                if (this.ValorIOF != null)
                    hash = hash * 59 + this.ValorIOF.GetHashCode();
                
                if (this.TaxaJuros != null)
                    hash = hash * 59 + this.TaxaJuros.GetHashCode();
                
                if (this.CetAnual != null)
                    hash = hash * 59 + this.CetAnual.GetHashCode();
                
                return hash;
            }
        }

    }
}
