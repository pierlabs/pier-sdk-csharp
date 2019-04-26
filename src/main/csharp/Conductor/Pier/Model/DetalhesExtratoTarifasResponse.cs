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
    /// Objeto response dos detalhes do extrato de tarifas
    /// </summary>
    [DataContract]
    public partial class DetalhesExtratoTarifasResponse :  IEquatable<DetalhesExtratoTarifasResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DetalhesExtratoTarifasResponse" /> class.
        /// Initializes a new instance of the <see cref="DetalhesExtratoTarifasResponse" />class.
        /// </summary>
        /// <param name="DataVencimentoPadrao">Data de vencimento padr\u00E3o da fatura.</param>
        /// <param name="Iof">Valor do IOF pago na fatura.</param>
        /// <param name="Juros">Valor de juros pago na fatura.</param>
        /// <param name="Tarifas">Valor de tarifas pago na fatura.</param>
        /// <param name="Multas">Valor de multas pago na fatura.</param>
        /// <param name="Mora">Valor de mora pago na fatura.</param>
        /// <param name="Total">Valor total de taxas pagas na fatura.</param>

        public DetalhesExtratoTarifasResponse(string DataVencimentoPadrao = null, double? Iof = null, double? Juros = null, double? Tarifas = null, double? Multas = null, double? Mora = null, double? Total = null)
        {
            this.DataVencimentoPadrao = DataVencimentoPadrao;
            this.Iof = Iof;
            this.Juros = Juros;
            this.Tarifas = Tarifas;
            this.Multas = Multas;
            this.Mora = Mora;
            this.Total = Total;
            
        }
        
    
        /// <summary>
        /// Data de vencimento padr\u00E3o da fatura
        /// </summary>
        /// <value>Data de vencimento padr\u00E3o da fatura</value>
        [DataMember(Name="dataVencimentoPadrao", EmitDefaultValue=false)]
        public string DataVencimentoPadrao { get; set; }
    
        /// <summary>
        /// Valor do IOF pago na fatura
        /// </summary>
        /// <value>Valor do IOF pago na fatura</value>
        [DataMember(Name="iof", EmitDefaultValue=false)]
        public double? Iof { get; set; }
    
        /// <summary>
        /// Valor de juros pago na fatura
        /// </summary>
        /// <value>Valor de juros pago na fatura</value>
        [DataMember(Name="juros", EmitDefaultValue=false)]
        public double? Juros { get; set; }
    
        /// <summary>
        /// Valor de tarifas pago na fatura
        /// </summary>
        /// <value>Valor de tarifas pago na fatura</value>
        [DataMember(Name="tarifas", EmitDefaultValue=false)]
        public double? Tarifas { get; set; }
    
        /// <summary>
        /// Valor de multas pago na fatura
        /// </summary>
        /// <value>Valor de multas pago na fatura</value>
        [DataMember(Name="multas", EmitDefaultValue=false)]
        public double? Multas { get; set; }
    
        /// <summary>
        /// Valor de mora pago na fatura
        /// </summary>
        /// <value>Valor de mora pago na fatura</value>
        [DataMember(Name="mora", EmitDefaultValue=false)]
        public double? Mora { get; set; }
    
        /// <summary>
        /// Valor total de taxas pagas na fatura
        /// </summary>
        /// <value>Valor total de taxas pagas na fatura</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public double? Total { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetalhesExtratoTarifasResponse {\n");
            sb.Append("  DataVencimentoPadrao: ").Append(DataVencimentoPadrao).Append("\n");
            sb.Append("  Iof: ").Append(Iof).Append("\n");
            sb.Append("  Juros: ").Append(Juros).Append("\n");
            sb.Append("  Tarifas: ").Append(Tarifas).Append("\n");
            sb.Append("  Multas: ").Append(Multas).Append("\n");
            sb.Append("  Mora: ").Append(Mora).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            
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
            return this.Equals(obj as DetalhesExtratoTarifasResponse);
        }

        /// <summary>
        /// Returns true if DetalhesExtratoTarifasResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DetalhesExtratoTarifasResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetalhesExtratoTarifasResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DataVencimentoPadrao == other.DataVencimentoPadrao ||
                    this.DataVencimentoPadrao != null &&
                    this.DataVencimentoPadrao.Equals(other.DataVencimentoPadrao)
                ) && 
                (
                    this.Iof == other.Iof ||
                    this.Iof != null &&
                    this.Iof.Equals(other.Iof)
                ) && 
                (
                    this.Juros == other.Juros ||
                    this.Juros != null &&
                    this.Juros.Equals(other.Juros)
                ) && 
                (
                    this.Tarifas == other.Tarifas ||
                    this.Tarifas != null &&
                    this.Tarifas.Equals(other.Tarifas)
                ) && 
                (
                    this.Multas == other.Multas ||
                    this.Multas != null &&
                    this.Multas.Equals(other.Multas)
                ) && 
                (
                    this.Mora == other.Mora ||
                    this.Mora != null &&
                    this.Mora.Equals(other.Mora)
                ) && 
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
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
                
                if (this.DataVencimentoPadrao != null)
                    hash = hash * 59 + this.DataVencimentoPadrao.GetHashCode();
                
                if (this.Iof != null)
                    hash = hash * 59 + this.Iof.GetHashCode();
                
                if (this.Juros != null)
                    hash = hash * 59 + this.Juros.GetHashCode();
                
                if (this.Tarifas != null)
                    hash = hash * 59 + this.Tarifas.GetHashCode();
                
                if (this.Multas != null)
                    hash = hash * 59 + this.Multas.GetHashCode();
                
                if (this.Mora != null)
                    hash = hash * 59 + this.Mora.GetHashCode();
                
                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                
                return hash;
            }
        }

    }
}
