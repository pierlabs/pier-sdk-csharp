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
    /// PlanCampaign
    /// </summary>
    [DataContract]
    public partial class PlanoCampanhaPersist :  IEquatable<PlanoCampanhaPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanoCampanhaPersist" /> class.
        /// Initializes a new instance of the <see cref="PlanoCampanhaPersist" />class.
        /// </summary>
        /// <param name="Parcelas">Parcelas.</param>
        /// <param name="Taxa">Taxa.</param>
        /// <param name="Usuario">Usuario.</param>

        public PlanoCampanhaPersist(int? Parcelas = null, double? Taxa = null, string Usuario = null)
        {
            this.Parcelas = Parcelas;
            this.Taxa = Taxa;
            this.Usuario = Usuario;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Parcelas
        /// </summary>
        [DataMember(Name="parcelas", EmitDefaultValue=false)]
        public int? Parcelas { get; set; }
    
        /// <summary>
        /// Gets or Sets Taxa
        /// </summary>
        [DataMember(Name="taxa", EmitDefaultValue=false)]
        public double? Taxa { get; set; }
    
        /// <summary>
        /// Gets or Sets Usuario
        /// </summary>
        [DataMember(Name="usuario", EmitDefaultValue=false)]
        public string Usuario { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlanoCampanhaPersist {\n");
            sb.Append("  Parcelas: ").Append(Parcelas).Append("\n");
            sb.Append("  Taxa: ").Append(Taxa).Append("\n");
            sb.Append("  Usuario: ").Append(Usuario).Append("\n");
            
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
            return this.Equals(obj as PlanoCampanhaPersist);
        }

        /// <summary>
        /// Returns true if PlanoCampanhaPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of PlanoCampanhaPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlanoCampanhaPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Parcelas == other.Parcelas ||
                    this.Parcelas != null &&
                    this.Parcelas.Equals(other.Parcelas)
                ) && 
                (
                    this.Taxa == other.Taxa ||
                    this.Taxa != null &&
                    this.Taxa.Equals(other.Taxa)
                ) && 
                (
                    this.Usuario == other.Usuario ||
                    this.Usuario != null &&
                    this.Usuario.Equals(other.Usuario)
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
                
                if (this.Parcelas != null)
                    hash = hash * 59 + this.Parcelas.GetHashCode();
                
                if (this.Taxa != null)
                    hash = hash * 59 + this.Taxa.GetHashCode();
                
                if (this.Usuario != null)
                    hash = hash * 59 + this.Usuario.GetHashCode();
                
                return hash;
            }
        }

    }
}
