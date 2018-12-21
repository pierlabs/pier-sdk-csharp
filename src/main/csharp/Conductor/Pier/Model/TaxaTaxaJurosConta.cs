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
    /// taxaTaxaJurosConta
    /// </summary>
    [DataContract]
    public partial class TaxaTaxaJurosConta :  IEquatable<TaxaTaxaJurosConta>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxaTaxaJurosConta" /> class.
        /// Initializes a new instance of the <see cref="TaxaTaxaJurosConta" />class.
        /// </summary>
        /// <param name="NumeroMesesCarencia">Number of months of grace period (required).</param>
        /// <param name="TaxaJuros">Interest rate value (required).</param>

        public TaxaTaxaJurosConta(int? NumeroMesesCarencia = null, double? TaxaJuros = null)
        {
            // to ensure "NumeroMesesCarencia" is required (not null)
            if (NumeroMesesCarencia == null)
            {
                throw new InvalidDataException("NumeroMesesCarencia is a required property for TaxaTaxaJurosConta and cannot be null");
            }
            else
            {
                this.NumeroMesesCarencia = NumeroMesesCarencia;
            }
            // to ensure "TaxaJuros" is required (not null)
            if (TaxaJuros == null)
            {
                throw new InvalidDataException("TaxaJuros is a required property for TaxaTaxaJurosConta and cannot be null");
            }
            else
            {
                this.TaxaJuros = TaxaJuros;
            }
            
        }
        
    
        /// <summary>
        /// Number of months of grace period
        /// </summary>
        /// <value>Number of months of grace period</value>
        [DataMember(Name="numeroMesesCarencia", EmitDefaultValue=false)]
        public int? NumeroMesesCarencia { get; set; }
    
        /// <summary>
        /// Interest rate value
        /// </summary>
        /// <value>Interest rate value</value>
        [DataMember(Name="taxaJuros", EmitDefaultValue=false)]
        public double? TaxaJuros { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxaTaxaJurosConta {\n");
            sb.Append("  NumeroMesesCarencia: ").Append(NumeroMesesCarencia).Append("\n");
            sb.Append("  TaxaJuros: ").Append(TaxaJuros).Append("\n");
            
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
            return this.Equals(obj as TaxaTaxaJurosConta);
        }

        /// <summary>
        /// Returns true if TaxaTaxaJurosConta instances are equal
        /// </summary>
        /// <param name="other">Instance of TaxaTaxaJurosConta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxaTaxaJurosConta other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NumeroMesesCarencia == other.NumeroMesesCarencia ||
                    this.NumeroMesesCarencia != null &&
                    this.NumeroMesesCarencia.Equals(other.NumeroMesesCarencia)
                ) && 
                (
                    this.TaxaJuros == other.TaxaJuros ||
                    this.TaxaJuros != null &&
                    this.TaxaJuros.Equals(other.TaxaJuros)
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
                
                if (this.NumeroMesesCarencia != null)
                    hash = hash * 59 + this.NumeroMesesCarencia.GetHashCode();
                
                if (this.TaxaJuros != null)
                    hash = hash * 59 + this.TaxaJuros.GetHashCode();
                
                return hash;
            }
        }

    }
}
