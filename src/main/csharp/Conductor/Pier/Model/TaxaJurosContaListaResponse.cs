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
    /// Representa\u00E7\u00E3o da resposta da listagem da taxa de juros
    /// </summary>
    [DataContract]
    public partial class TaxaJurosContaListaResponse :  IEquatable<TaxaJurosContaListaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxaJurosContaListaResponse" /> class.
        /// Initializes a new instance of the <see cref="TaxaJurosContaListaResponse" />class.
        /// </summary>
        /// <param name="Plano">Numero da parcela do plano de taxa.</param>
        /// <param name="Taxa">Valor da taxa de juros.</param>

        public TaxaJurosContaListaResponse(int? Plano = null, double? Taxa = null)
        {
            this.Plano = Plano;
            this.Taxa = Taxa;
            
        }
        
    
        /// <summary>
        /// Numero da parcela do plano de taxa
        /// </summary>
        /// <value>Numero da parcela do plano de taxa</value>
        [DataMember(Name="plano", EmitDefaultValue=false)]
        public int? Plano { get; set; }
    
        /// <summary>
        /// Valor da taxa de juros
        /// </summary>
        /// <value>Valor da taxa de juros</value>
        [DataMember(Name="taxa", EmitDefaultValue=false)]
        public double? Taxa { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxaJurosContaListaResponse {\n");
            sb.Append("  Plano: ").Append(Plano).Append("\n");
            sb.Append("  Taxa: ").Append(Taxa).Append("\n");
            
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
            return this.Equals(obj as TaxaJurosContaListaResponse);
        }

        /// <summary>
        /// Returns true if TaxaJurosContaListaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TaxaJurosContaListaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxaJurosContaListaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Plano == other.Plano ||
                    this.Plano != null &&
                    this.Plano.Equals(other.Plano)
                ) && 
                (
                    this.Taxa == other.Taxa ||
                    this.Taxa != null &&
                    this.Taxa.Equals(other.Taxa)
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
                
                if (this.Plano != null)
                    hash = hash * 59 + this.Plano.GetHashCode();
                
                if (this.Taxa != null)
                    hash = hash * 59 + this.Taxa.GetHashCode();
                
                return hash;
            }
        }

    }
}
