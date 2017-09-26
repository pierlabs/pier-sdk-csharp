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
    /// Detalhe da resposta do recurso de simular empr\u00C3\u00A9stimos/financiamentos
    /// </summary>
    [DataContract]
    public partial class PlanoParcelamentoEmprestimoResponse :  IEquatable<PlanoParcelamentoEmprestimoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanoParcelamentoEmprestimoResponse" /> class.
        /// Initializes a new instance of the <see cref="PlanoParcelamentoEmprestimoResponse" />class.
        /// </summary>
        /// <param name="NumeroParcelas">N\u00C3\u00BAmeros de parcelas do empr\u00C3\u00A9stimo/financiamento.</param>
        /// <param name="ValorParcelas">Valor da parcela.</param>
        /// <param name="TaxaJuros">Taxa de juros aplicado no empr\u00C3\u00A9stimo/financiamento.</param>
        /// <param name="ValorTributosIOF">valor total estimado dos tributos do Imposto sobre Opera\u00C3\u00A7\u00C3\u00B5es Financeiras.</param>
        /// <param name="ValorPercentualCET">valor percentual do Custo Efetivo Total, ao ano, do empr\u00C3\u00A9stimo / financiamento.</param>

        public PlanoParcelamentoEmprestimoResponse(int? NumeroParcelas = null, double? ValorParcelas = null, double? TaxaJuros = null, double? ValorTributosIOF = null, double? ValorPercentualCET = null)
        {
            this.NumeroParcelas = NumeroParcelas;
            this.ValorParcelas = ValorParcelas;
            this.TaxaJuros = TaxaJuros;
            this.ValorTributosIOF = ValorTributosIOF;
            this.ValorPercentualCET = ValorPercentualCET;
            
        }
        
    
        /// <summary>
        /// N\u00C3\u00BAmeros de parcelas do empr\u00C3\u00A9stimo/financiamento
        /// </summary>
        /// <value>N\u00C3\u00BAmeros de parcelas do empr\u00C3\u00A9stimo/financiamento</value>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public int? NumeroParcelas { get; set; }
    
        /// <summary>
        /// Valor da parcela
        /// </summary>
        /// <value>Valor da parcela</value>
        [DataMember(Name="valorParcelas", EmitDefaultValue=false)]
        public double? ValorParcelas { get; set; }
    
        /// <summary>
        /// Taxa de juros aplicado no empr\u00C3\u00A9stimo/financiamento
        /// </summary>
        /// <value>Taxa de juros aplicado no empr\u00C3\u00A9stimo/financiamento</value>
        [DataMember(Name="taxaJuros", EmitDefaultValue=false)]
        public double? TaxaJuros { get; set; }
    
        /// <summary>
        /// valor total estimado dos tributos do Imposto sobre Opera\u00C3\u00A7\u00C3\u00B5es Financeiras
        /// </summary>
        /// <value>valor total estimado dos tributos do Imposto sobre Opera\u00C3\u00A7\u00C3\u00B5es Financeiras</value>
        [DataMember(Name="valorTributosIOF", EmitDefaultValue=false)]
        public double? ValorTributosIOF { get; set; }
    
        /// <summary>
        /// valor percentual do Custo Efetivo Total, ao ano, do empr\u00C3\u00A9stimo / financiamento
        /// </summary>
        /// <value>valor percentual do Custo Efetivo Total, ao ano, do empr\u00C3\u00A9stimo / financiamento</value>
        [DataMember(Name="valorPercentualCET", EmitDefaultValue=false)]
        public double? ValorPercentualCET { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlanoParcelamentoEmprestimoResponse {\n");
            sb.Append("  NumeroParcelas: ").Append(NumeroParcelas).Append("\n");
            sb.Append("  ValorParcelas: ").Append(ValorParcelas).Append("\n");
            sb.Append("  TaxaJuros: ").Append(TaxaJuros).Append("\n");
            sb.Append("  ValorTributosIOF: ").Append(ValorTributosIOF).Append("\n");
            sb.Append("  ValorPercentualCET: ").Append(ValorPercentualCET).Append("\n");
            
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
            return this.Equals(obj as PlanoParcelamentoEmprestimoResponse);
        }

        /// <summary>
        /// Returns true if PlanoParcelamentoEmprestimoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PlanoParcelamentoEmprestimoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlanoParcelamentoEmprestimoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NumeroParcelas == other.NumeroParcelas ||
                    this.NumeroParcelas != null &&
                    this.NumeroParcelas.Equals(other.NumeroParcelas)
                ) && 
                (
                    this.ValorParcelas == other.ValorParcelas ||
                    this.ValorParcelas != null &&
                    this.ValorParcelas.Equals(other.ValorParcelas)
                ) && 
                (
                    this.TaxaJuros == other.TaxaJuros ||
                    this.TaxaJuros != null &&
                    this.TaxaJuros.Equals(other.TaxaJuros)
                ) && 
                (
                    this.ValorTributosIOF == other.ValorTributosIOF ||
                    this.ValorTributosIOF != null &&
                    this.ValorTributosIOF.Equals(other.ValorTributosIOF)
                ) && 
                (
                    this.ValorPercentualCET == other.ValorPercentualCET ||
                    this.ValorPercentualCET != null &&
                    this.ValorPercentualCET.Equals(other.ValorPercentualCET)
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
                
                if (this.NumeroParcelas != null)
                    hash = hash * 59 + this.NumeroParcelas.GetHashCode();
                
                if (this.ValorParcelas != null)
                    hash = hash * 59 + this.ValorParcelas.GetHashCode();
                
                if (this.TaxaJuros != null)
                    hash = hash * 59 + this.TaxaJuros.GetHashCode();
                
                if (this.ValorTributosIOF != null)
                    hash = hash * 59 + this.ValorTributosIOF.GetHashCode();
                
                if (this.ValorPercentualCET != null)
                    hash = hash * 59 + this.ValorPercentualCET.GetHashCode();
                
                return hash;
            }
        }

    }
}
