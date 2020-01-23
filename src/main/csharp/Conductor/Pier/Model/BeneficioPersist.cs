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
    /// Objeto para persist\u00EAncia do benef\u00EDcio
    /// </summary>
    [DataContract]
    public partial class BeneficioPersist :  IEquatable<BeneficioPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BeneficioPersist" /> class.
        /// Initializes a new instance of the <see cref="BeneficioPersist" />class.
        /// </summary>
        /// <param name="NumeroBeneficio">N\u00FAmero do benef\u00EDcio.</param>
        /// <param name="MesProvaVida">M\u00EAs de prova de vida do benefici\u00E1rio.</param>
        /// <param name="TipoBeneficio">Tipo do benef\u00EDcio.</param>

        public BeneficioPersist(string NumeroBeneficio = null, int? MesProvaVida = null, string TipoBeneficio = null)
        {
            this.NumeroBeneficio = NumeroBeneficio;
            this.MesProvaVida = MesProvaVida;
            this.TipoBeneficio = TipoBeneficio;
            
        }
        
    
        /// <summary>
        /// N\u00FAmero do benef\u00EDcio
        /// </summary>
        /// <value>N\u00FAmero do benef\u00EDcio</value>
        [DataMember(Name="numeroBeneficio", EmitDefaultValue=false)]
        public string NumeroBeneficio { get; set; }
    
        /// <summary>
        /// M\u00EAs de prova de vida do benefici\u00E1rio
        /// </summary>
        /// <value>M\u00EAs de prova de vida do benefici\u00E1rio</value>
        [DataMember(Name="mesProvaVida", EmitDefaultValue=false)]
        public int? MesProvaVida { get; set; }
    
        /// <summary>
        /// Tipo do benef\u00EDcio
        /// </summary>
        /// <value>Tipo do benef\u00EDcio</value>
        [DataMember(Name="tipoBeneficio", EmitDefaultValue=false)]
        public string TipoBeneficio { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BeneficioPersist {\n");
            sb.Append("  NumeroBeneficio: ").Append(NumeroBeneficio).Append("\n");
            sb.Append("  MesProvaVida: ").Append(MesProvaVida).Append("\n");
            sb.Append("  TipoBeneficio: ").Append(TipoBeneficio).Append("\n");
            
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
            return this.Equals(obj as BeneficioPersist);
        }

        /// <summary>
        /// Returns true if BeneficioPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of BeneficioPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BeneficioPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NumeroBeneficio == other.NumeroBeneficio ||
                    this.NumeroBeneficio != null &&
                    this.NumeroBeneficio.Equals(other.NumeroBeneficio)
                ) && 
                (
                    this.MesProvaVida == other.MesProvaVida ||
                    this.MesProvaVida != null &&
                    this.MesProvaVida.Equals(other.MesProvaVida)
                ) && 
                (
                    this.TipoBeneficio == other.TipoBeneficio ||
                    this.TipoBeneficio != null &&
                    this.TipoBeneficio.Equals(other.TipoBeneficio)
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
                
                if (this.NumeroBeneficio != null)
                    hash = hash * 59 + this.NumeroBeneficio.GetHashCode();
                
                if (this.MesProvaVida != null)
                    hash = hash * 59 + this.MesProvaVida.GetHashCode();
                
                if (this.TipoBeneficio != null)
                    hash = hash * 59 + this.TipoBeneficio.GetHashCode();
                
                return hash;
            }
        }

    }
}
