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
    /// {{{parcelamento_acordo_response_description}}}
    /// </summary>
    [DataContract]
    public partial class ParcelamentoAcordoResponseValue :  IEquatable<ParcelamentoAcordoResponseValue>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ParcelamentoAcordoResponseValue" /> class.
        /// Initializes a new instance of the <see cref="ParcelamentoAcordoResponseValue" />class.
        /// </summary>
        /// <param name="PercentualEntrada">{{{parcelamento_acordo_response_percentual_entrada_value}}}.</param>
        /// <param name="PercentualDesconto">{{{parcelamento_acordo_response_percentual_desconto_value}}}.</param>
        /// <param name="ValorDesconto">{{{parcelamento_acordo_response_valor_desconto_value}}}.</param>
        /// <param name="ValorLiquido">{{{parcelamento_acordo_response_valor_liquido_value}}}.</param>
        /// <param name="ValorEntrada">{{{parcelamento_acordo_response_valor_entrada_value}}}.</param>
        /// <param name="ValorParcela">{{{parcelamento_acordo_response_valor_parcela_value}}}.</param>
        /// <param name="ValorPrimeiraParcela">{{{parcelamento_acordo_response_valor_primeira_parcela_value}}}.</param>

        public ParcelamentoAcordoResponseValue(double? PercentualEntrada = null, double? PercentualDesconto = null, double? ValorDesconto = null, double? ValorLiquido = null, double? ValorEntrada = null, double? ValorParcela = null, double? ValorPrimeiraParcela = null)
        {
            this.PercentualEntrada = PercentualEntrada;
            this.PercentualDesconto = PercentualDesconto;
            this.ValorDesconto = ValorDesconto;
            this.ValorLiquido = ValorLiquido;
            this.ValorEntrada = ValorEntrada;
            this.ValorParcela = ValorParcela;
            this.ValorPrimeiraParcela = ValorPrimeiraParcela;
            
        }
        
    
        /// <summary>
        /// {{{parcelamento_acordo_response_percentual_entrada_value}}}
        /// </summary>
        /// <value>{{{parcelamento_acordo_response_percentual_entrada_value}}}</value>
        [DataMember(Name="percentualEntrada", EmitDefaultValue=false)]
        public double? PercentualEntrada { get; set; }
    
        /// <summary>
        /// {{{parcelamento_acordo_response_percentual_desconto_value}}}
        /// </summary>
        /// <value>{{{parcelamento_acordo_response_percentual_desconto_value}}}</value>
        [DataMember(Name="percentualDesconto", EmitDefaultValue=false)]
        public double? PercentualDesconto { get; set; }
    
        /// <summary>
        /// {{{parcelamento_acordo_response_valor_desconto_value}}}
        /// </summary>
        /// <value>{{{parcelamento_acordo_response_valor_desconto_value}}}</value>
        [DataMember(Name="valorDesconto", EmitDefaultValue=false)]
        public double? ValorDesconto { get; set; }
    
        /// <summary>
        /// {{{parcelamento_acordo_response_valor_liquido_value}}}
        /// </summary>
        /// <value>{{{parcelamento_acordo_response_valor_liquido_value}}}</value>
        [DataMember(Name="valorLiquido", EmitDefaultValue=false)]
        public double? ValorLiquido { get; set; }
    
        /// <summary>
        /// {{{parcelamento_acordo_response_valor_entrada_value}}}
        /// </summary>
        /// <value>{{{parcelamento_acordo_response_valor_entrada_value}}}</value>
        [DataMember(Name="valorEntrada", EmitDefaultValue=false)]
        public double? ValorEntrada { get; set; }
    
        /// <summary>
        /// {{{parcelamento_acordo_response_valor_parcela_value}}}
        /// </summary>
        /// <value>{{{parcelamento_acordo_response_valor_parcela_value}}}</value>
        [DataMember(Name="valorParcela", EmitDefaultValue=false)]
        public double? ValorParcela { get; set; }
    
        /// <summary>
        /// {{{parcelamento_acordo_response_valor_primeira_parcela_value}}}
        /// </summary>
        /// <value>{{{parcelamento_acordo_response_valor_primeira_parcela_value}}}</value>
        [DataMember(Name="valorPrimeiraParcela", EmitDefaultValue=false)]
        public double? ValorPrimeiraParcela { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParcelamentoAcordoResponseValue {\n");
            sb.Append("  PercentualEntrada: ").Append(PercentualEntrada).Append("\n");
            sb.Append("  PercentualDesconto: ").Append(PercentualDesconto).Append("\n");
            sb.Append("  ValorDesconto: ").Append(ValorDesconto).Append("\n");
            sb.Append("  ValorLiquido: ").Append(ValorLiquido).Append("\n");
            sb.Append("  ValorEntrada: ").Append(ValorEntrada).Append("\n");
            sb.Append("  ValorParcela: ").Append(ValorParcela).Append("\n");
            sb.Append("  ValorPrimeiraParcela: ").Append(ValorPrimeiraParcela).Append("\n");
            
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
            return this.Equals(obj as ParcelamentoAcordoResponseValue);
        }

        /// <summary>
        /// Returns true if ParcelamentoAcordoResponseValue instances are equal
        /// </summary>
        /// <param name="other">Instance of ParcelamentoAcordoResponseValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParcelamentoAcordoResponseValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PercentualEntrada == other.PercentualEntrada ||
                    this.PercentualEntrada != null &&
                    this.PercentualEntrada.Equals(other.PercentualEntrada)
                ) && 
                (
                    this.PercentualDesconto == other.PercentualDesconto ||
                    this.PercentualDesconto != null &&
                    this.PercentualDesconto.Equals(other.PercentualDesconto)
                ) && 
                (
                    this.ValorDesconto == other.ValorDesconto ||
                    this.ValorDesconto != null &&
                    this.ValorDesconto.Equals(other.ValorDesconto)
                ) && 
                (
                    this.ValorLiquido == other.ValorLiquido ||
                    this.ValorLiquido != null &&
                    this.ValorLiquido.Equals(other.ValorLiquido)
                ) && 
                (
                    this.ValorEntrada == other.ValorEntrada ||
                    this.ValorEntrada != null &&
                    this.ValorEntrada.Equals(other.ValorEntrada)
                ) && 
                (
                    this.ValorParcela == other.ValorParcela ||
                    this.ValorParcela != null &&
                    this.ValorParcela.Equals(other.ValorParcela)
                ) && 
                (
                    this.ValorPrimeiraParcela == other.ValorPrimeiraParcela ||
                    this.ValorPrimeiraParcela != null &&
                    this.ValorPrimeiraParcela.Equals(other.ValorPrimeiraParcela)
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
                
                if (this.PercentualEntrada != null)
                    hash = hash * 59 + this.PercentualEntrada.GetHashCode();
                
                if (this.PercentualDesconto != null)
                    hash = hash * 59 + this.PercentualDesconto.GetHashCode();
                
                if (this.ValorDesconto != null)
                    hash = hash * 59 + this.ValorDesconto.GetHashCode();
                
                if (this.ValorLiquido != null)
                    hash = hash * 59 + this.ValorLiquido.GetHashCode();
                
                if (this.ValorEntrada != null)
                    hash = hash * 59 + this.ValorEntrada.GetHashCode();
                
                if (this.ValorParcela != null)
                    hash = hash * 59 + this.ValorParcela.GetHashCode();
                
                if (this.ValorPrimeiraParcela != null)
                    hash = hash * 59 + this.ValorPrimeiraParcela.GetHashCode();
                
                return hash;
            }
        }

    }
}
