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
    /// Objeto de persist\u00EAncia de um limite para o portador
    /// </summary>
    [DataContract]
    public partial class LimitePortadorPersist :  IEquatable<LimitePortadorPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LimitePortadorPersist" /> class.
        /// Initializes a new instance of the <see cref="LimitePortadorPersist" />class.
        /// </summary>
        /// <param name="LimiteGlobal">Limite do portador (required).</param>
        /// <param name="SaldoDisponivelGlobal">Saldo dispon\u00EDvel do portador (required).</param>

        public LimitePortadorPersist(double? LimiteGlobal = null, double? SaldoDisponivelGlobal = null)
        {
            // to ensure "LimiteGlobal" is required (not null)
            if (LimiteGlobal == null)
            {
                throw new InvalidDataException("LimiteGlobal is a required property for LimitePortadorPersist and cannot be null");
            }
            else
            {
                this.LimiteGlobal = LimiteGlobal;
            }
            // to ensure "SaldoDisponivelGlobal" is required (not null)
            if (SaldoDisponivelGlobal == null)
            {
                throw new InvalidDataException("SaldoDisponivelGlobal is a required property for LimitePortadorPersist and cannot be null");
            }
            else
            {
                this.SaldoDisponivelGlobal = SaldoDisponivelGlobal;
            }
            
        }
        
    
        /// <summary>
        /// Limite do portador
        /// </summary>
        /// <value>Limite do portador</value>
        [DataMember(Name="limiteGlobal", EmitDefaultValue=false)]
        public double? LimiteGlobal { get; set; }
    
        /// <summary>
        /// Saldo dispon\u00EDvel do portador
        /// </summary>
        /// <value>Saldo dispon\u00EDvel do portador</value>
        [DataMember(Name="saldoDisponivelGlobal", EmitDefaultValue=false)]
        public double? SaldoDisponivelGlobal { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LimitePortadorPersist {\n");
            sb.Append("  LimiteGlobal: ").Append(LimiteGlobal).Append("\n");
            sb.Append("  SaldoDisponivelGlobal: ").Append(SaldoDisponivelGlobal).Append("\n");
            
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
            return this.Equals(obj as LimitePortadorPersist);
        }

        /// <summary>
        /// Returns true if LimitePortadorPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of LimitePortadorPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LimitePortadorPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LimiteGlobal == other.LimiteGlobal ||
                    this.LimiteGlobal != null &&
                    this.LimiteGlobal.Equals(other.LimiteGlobal)
                ) && 
                (
                    this.SaldoDisponivelGlobal == other.SaldoDisponivelGlobal ||
                    this.SaldoDisponivelGlobal != null &&
                    this.SaldoDisponivelGlobal.Equals(other.SaldoDisponivelGlobal)
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
                
                if (this.LimiteGlobal != null)
                    hash = hash * 59 + this.LimiteGlobal.GetHashCode();
                
                if (this.SaldoDisponivelGlobal != null)
                    hash = hash * 59 + this.SaldoDisponivelGlobal.GetHashCode();
                
                return hash;
            }
        }

    }
}
