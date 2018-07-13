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
    /// {{{parcelamento_transferencia_response_description}}}
    /// </summary>
    [DataContract]
    public partial class ParcelamentoTransferenciaResponse :  IEquatable<ParcelamentoTransferenciaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ParcelamentoTransferenciaResponse" /> class.
        /// Initializes a new instance of the <see cref="ParcelamentoTransferenciaResponse" />class.
        /// </summary>
        /// <param name="NumeroParcela">{{{parcelamento_transferencia_response_numero_parcela_value}}}.</param>
        /// <param name="ValorParcelas">{{{parcelamento_transferencia_response_valor_parcelas_value}}}.</param>
        /// <param name="ValorTotal">{{{parcelamento_transferencia_response_valor_total_value}}}.</param>
        /// <param name="ValorTAC">{{{parcelamento_transferencia_response_valor_t_a_c_value}}}.</param>
        /// <param name="ValorIOF">{{{parcelamento_transferencia_response_valor_i_o_f_value}}}.</param>
        /// <param name="TaxaJuros">{{{parcelamento_transferencia_response_taxa_juros_value}}}.</param>
        /// <param name="CetAnual">{{{parcelamento_transferencia_response_cet_anual_value}}}.</param>

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
        /// {{{parcelamento_transferencia_response_numero_parcela_value}}}
        /// </summary>
        /// <value>{{{parcelamento_transferencia_response_numero_parcela_value}}}</value>
        [DataMember(Name="numeroParcela", EmitDefaultValue=false)]
        public int? NumeroParcela { get; set; }
    
        /// <summary>
        /// {{{parcelamento_transferencia_response_valor_parcelas_value}}}
        /// </summary>
        /// <value>{{{parcelamento_transferencia_response_valor_parcelas_value}}}</value>
        [DataMember(Name="valorParcelas", EmitDefaultValue=false)]
        public double? ValorParcelas { get; set; }
    
        /// <summary>
        /// {{{parcelamento_transferencia_response_valor_total_value}}}
        /// </summary>
        /// <value>{{{parcelamento_transferencia_response_valor_total_value}}}</value>
        [DataMember(Name="valorTotal", EmitDefaultValue=false)]
        public double? ValorTotal { get; set; }
    
        /// <summary>
        /// {{{parcelamento_transferencia_response_valor_t_a_c_value}}}
        /// </summary>
        /// <value>{{{parcelamento_transferencia_response_valor_t_a_c_value}}}</value>
        [DataMember(Name="valorTAC", EmitDefaultValue=false)]
        public double? ValorTAC { get; set; }
    
        /// <summary>
        /// {{{parcelamento_transferencia_response_valor_i_o_f_value}}}
        /// </summary>
        /// <value>{{{parcelamento_transferencia_response_valor_i_o_f_value}}}</value>
        [DataMember(Name="valorIOF", EmitDefaultValue=false)]
        public double? ValorIOF { get; set; }
    
        /// <summary>
        /// {{{parcelamento_transferencia_response_taxa_juros_value}}}
        /// </summary>
        /// <value>{{{parcelamento_transferencia_response_taxa_juros_value}}}</value>
        [DataMember(Name="taxaJuros", EmitDefaultValue=false)]
        public double? TaxaJuros { get; set; }
    
        /// <summary>
        /// {{{parcelamento_transferencia_response_cet_anual_value}}}
        /// </summary>
        /// <value>{{{parcelamento_transferencia_response_cet_anual_value}}}</value>
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
