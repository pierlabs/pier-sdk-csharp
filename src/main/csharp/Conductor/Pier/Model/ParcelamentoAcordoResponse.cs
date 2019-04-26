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
    /// Objeto de resposta para o parcelamento de acordo
    /// </summary>
    [DataContract]
    public partial class ParcelamentoAcordoResponse :  IEquatable<ParcelamentoAcordoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ParcelamentoAcordoResponse" /> class.
        /// Initializes a new instance of the <see cref="ParcelamentoAcordoResponse" />class.
        /// </summary>
        /// <param name="PercentualEntrada">Valor do percentual de entrada do acordo.</param>
        /// <param name="PercentualDesconto">Valor do percentual de desconto do acordo.</param>
        /// <param name="ValorDesconto">Valor do desconto atribuido.</param>
        /// <param name="ValorLiquido">Valor liquido do acordo.</param>
        /// <param name="ValorEntrada">Valor da entrada do acordo.</param>
        /// <param name="ValorParcela">Valor da parcela do acordo.</param>
        /// <param name="ValorPrimeiraParcela">Valor da primeira parcela do acordo.</param>

        public ParcelamentoAcordoResponse(double? PercentualEntrada = null, double? PercentualDesconto = null, double? ValorDesconto = null, double? ValorLiquido = null, double? ValorEntrada = null, double? ValorParcela = null, double? ValorPrimeiraParcela = null)
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
        /// Valor do percentual de entrada do acordo
        /// </summary>
        /// <value>Valor do percentual de entrada do acordo</value>
        [DataMember(Name="percentualEntrada", EmitDefaultValue=false)]
        public double? PercentualEntrada { get; set; }
    
        /// <summary>
        /// Valor do percentual de desconto do acordo
        /// </summary>
        /// <value>Valor do percentual de desconto do acordo</value>
        [DataMember(Name="percentualDesconto", EmitDefaultValue=false)]
        public double? PercentualDesconto { get; set; }
    
        /// <summary>
        /// Valor do desconto atribuido
        /// </summary>
        /// <value>Valor do desconto atribuido</value>
        [DataMember(Name="valorDesconto", EmitDefaultValue=false)]
        public double? ValorDesconto { get; set; }
    
        /// <summary>
        /// Valor liquido do acordo
        /// </summary>
        /// <value>Valor liquido do acordo</value>
        [DataMember(Name="valorLiquido", EmitDefaultValue=false)]
        public double? ValorLiquido { get; set; }
    
        /// <summary>
        /// Valor da entrada do acordo
        /// </summary>
        /// <value>Valor da entrada do acordo</value>
        [DataMember(Name="valorEntrada", EmitDefaultValue=false)]
        public double? ValorEntrada { get; set; }
    
        /// <summary>
        /// Valor da parcela do acordo
        /// </summary>
        /// <value>Valor da parcela do acordo</value>
        [DataMember(Name="valorParcela", EmitDefaultValue=false)]
        public double? ValorParcela { get; set; }
    
        /// <summary>
        /// Valor da primeira parcela do acordo
        /// </summary>
        /// <value>Valor da primeira parcela do acordo</value>
        [DataMember(Name="valorPrimeiraParcela", EmitDefaultValue=false)]
        public double? ValorPrimeiraParcela { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParcelamentoAcordoResponse {\n");
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
            return this.Equals(obj as ParcelamentoAcordoResponse);
        }

        /// <summary>
        /// Returns true if ParcelamentoAcordoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ParcelamentoAcordoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParcelamentoAcordoResponse other)
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
