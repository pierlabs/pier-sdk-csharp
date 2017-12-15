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
        /// <param name="ValorPrimeiraParcela">Valor da primeira parcela..</param>
        /// <param name="ValorDemaisParcelas">Valor das demais parcelas..</param>
        /// <param name="TaxaJuros">Valor da taxa de juros..</param>
        /// <param name="CetAnual">CET anual..</param>

        public ParcelamentoTransferenciaResponse(string NumeroParcela = null, double? ValorPrimeiraParcela = null, double? ValorDemaisParcelas = null, double? TaxaJuros = null, double? CetAnual = null)
        {
            this.NumeroParcela = NumeroParcela;
            this.ValorPrimeiraParcela = ValorPrimeiraParcela;
            this.ValorDemaisParcelas = ValorDemaisParcelas;
            this.TaxaJuros = TaxaJuros;
            this.CetAnual = CetAnual;
            
        }
        
    
        /// <summary>
        /// N\u00C3\u00BAmero de parcelas dispon\u00C3\u00ADveis.
        /// </summary>
        /// <value>N\u00C3\u00BAmero de parcelas dispon\u00C3\u00ADveis.</value>
        [DataMember(Name="numeroParcela", EmitDefaultValue=false)]
        public string NumeroParcela { get; set; }
    
        /// <summary>
        /// Valor da primeira parcela.
        /// </summary>
        /// <value>Valor da primeira parcela.</value>
        [DataMember(Name="valorPrimeiraParcela", EmitDefaultValue=false)]
        public double? ValorPrimeiraParcela { get; set; }
    
        /// <summary>
        /// Valor das demais parcelas.
        /// </summary>
        /// <value>Valor das demais parcelas.</value>
        [DataMember(Name="valorDemaisParcelas", EmitDefaultValue=false)]
        public double? ValorDemaisParcelas { get; set; }
    
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
            sb.Append("  ValorPrimeiraParcela: ").Append(ValorPrimeiraParcela).Append("\n");
            sb.Append("  ValorDemaisParcelas: ").Append(ValorDemaisParcelas).Append("\n");
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
                    this.ValorPrimeiraParcela == other.ValorPrimeiraParcela ||
                    this.ValorPrimeiraParcela != null &&
                    this.ValorPrimeiraParcela.Equals(other.ValorPrimeiraParcela)
                ) && 
                (
                    this.ValorDemaisParcelas == other.ValorDemaisParcelas ||
                    this.ValorDemaisParcelas != null &&
                    this.ValorDemaisParcelas.Equals(other.ValorDemaisParcelas)
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
                
                if (this.ValorPrimeiraParcela != null)
                    hash = hash * 59 + this.ValorPrimeiraParcela.GetHashCode();
                
                if (this.ValorDemaisParcelas != null)
                    hash = hash * 59 + this.ValorDemaisParcelas.GetHashCode();
                
                if (this.TaxaJuros != null)
                    hash = hash * 59 + this.TaxaJuros.GetHashCode();
                
                if (this.CetAnual != null)
                    hash = hash * 59 + this.CetAnual.GetHashCode();
                
                return hash;
            }
        }

    }
}