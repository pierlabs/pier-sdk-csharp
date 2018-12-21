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
    /// Response Representation of the details of Simulated Antecipation Resource
    /// </summary>
    [DataContract]
    public partial class AntecipacaoSimuladaDetalhesResponse :  IEquatable<AntecipacaoSimuladaDetalhesResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AntecipacaoSimuladaDetalhesResponse" /> class.
        /// Initializes a new instance of the <see cref="AntecipacaoSimuladaDetalhesResponse" />class.
        /// </summary>
        /// <param name="QuantidadeParcelas">Quantity of parcel of the installment plan simulated.</param>
        /// <param name="ValorParcelas">Total value of the parcel.</param>
        /// <param name="ValorDesconto">Value of the discount for the installment plan.</param>
        /// <param name="ValorParcelasDesconto">Total value of the parcel after the discount application.</param>

        public AntecipacaoSimuladaDetalhesResponse(int? QuantidadeParcelas = null, double? ValorParcelas = null, double? ValorDesconto = null, double? ValorParcelasDesconto = null)
        {
            this.QuantidadeParcelas = QuantidadeParcelas;
            this.ValorParcelas = ValorParcelas;
            this.ValorDesconto = ValorDesconto;
            this.ValorParcelasDesconto = ValorParcelasDesconto;
            
        }
        
    
        /// <summary>
        /// Quantity of parcel of the installment plan simulated
        /// </summary>
        /// <value>Quantity of parcel of the installment plan simulated</value>
        [DataMember(Name="quantidadeParcelas", EmitDefaultValue=false)]
        public int? QuantidadeParcelas { get; set; }
    
        /// <summary>
        /// Total value of the parcel
        /// </summary>
        /// <value>Total value of the parcel</value>
        [DataMember(Name="valorParcelas", EmitDefaultValue=false)]
        public double? ValorParcelas { get; set; }
    
        /// <summary>
        /// Value of the discount for the installment plan
        /// </summary>
        /// <value>Value of the discount for the installment plan</value>
        [DataMember(Name="valorDesconto", EmitDefaultValue=false)]
        public double? ValorDesconto { get; set; }
    
        /// <summary>
        /// Total value of the parcel after the discount application
        /// </summary>
        /// <value>Total value of the parcel after the discount application</value>
        [DataMember(Name="valorParcelasDesconto", EmitDefaultValue=false)]
        public double? ValorParcelasDesconto { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AntecipacaoSimuladaDetalhesResponse {\n");
            sb.Append("  QuantidadeParcelas: ").Append(QuantidadeParcelas).Append("\n");
            sb.Append("  ValorParcelas: ").Append(ValorParcelas).Append("\n");
            sb.Append("  ValorDesconto: ").Append(ValorDesconto).Append("\n");
            sb.Append("  ValorParcelasDesconto: ").Append(ValorParcelasDesconto).Append("\n");
            
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
            return this.Equals(obj as AntecipacaoSimuladaDetalhesResponse);
        }

        /// <summary>
        /// Returns true if AntecipacaoSimuladaDetalhesResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AntecipacaoSimuladaDetalhesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AntecipacaoSimuladaDetalhesResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.QuantidadeParcelas == other.QuantidadeParcelas ||
                    this.QuantidadeParcelas != null &&
                    this.QuantidadeParcelas.Equals(other.QuantidadeParcelas)
                ) && 
                (
                    this.ValorParcelas == other.ValorParcelas ||
                    this.ValorParcelas != null &&
                    this.ValorParcelas.Equals(other.ValorParcelas)
                ) && 
                (
                    this.ValorDesconto == other.ValorDesconto ||
                    this.ValorDesconto != null &&
                    this.ValorDesconto.Equals(other.ValorDesconto)
                ) && 
                (
                    this.ValorParcelasDesconto == other.ValorParcelasDesconto ||
                    this.ValorParcelasDesconto != null &&
                    this.ValorParcelasDesconto.Equals(other.ValorParcelasDesconto)
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
                
                if (this.QuantidadeParcelas != null)
                    hash = hash * 59 + this.QuantidadeParcelas.GetHashCode();
                
                if (this.ValorParcelas != null)
                    hash = hash * 59 + this.ValorParcelas.GetHashCode();
                
                if (this.ValorDesconto != null)
                    hash = hash * 59 + this.ValorDesconto.GetHashCode();
                
                if (this.ValorParcelasDesconto != null)
                    hash = hash * 59 + this.ValorParcelasDesconto.GetHashCode();
                
                return hash;
            }
        }

    }
}
