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
    /// Representa a requisi\u00E7\u00E3o do recurso de cadastro de controle de limites para um cart\u00E3o
    /// </summary>
    [DataContract]
    public partial class ControleLimitesCartaoPersist :  IEquatable<ControleLimitesCartaoPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ControleLimitesCartaoPersist" /> class.
        /// Initializes a new instance of the <see cref="ControleLimitesCartaoPersist" />class.
        /// </summary>
        /// <param name="LimiteMensal">Valor do limite mensal.</param>
        /// <param name="LimiteSemanal">Valor do limite semanal.</param>
        /// <param name="LimiteDiario">Valor do limite di\u00E1rio.</param>

        public ControleLimitesCartaoPersist(double? LimiteMensal = null, double? LimiteSemanal = null, double? LimiteDiario = null)
        {
            this.LimiteMensal = LimiteMensal;
            this.LimiteSemanal = LimiteSemanal;
            this.LimiteDiario = LimiteDiario;
            
        }
        
    
        /// <summary>
        /// Valor do limite mensal
        /// </summary>
        /// <value>Valor do limite mensal</value>
        [DataMember(Name="limiteMensal", EmitDefaultValue=false)]
        public double? LimiteMensal { get; set; }
    
        /// <summary>
        /// Valor do limite semanal
        /// </summary>
        /// <value>Valor do limite semanal</value>
        [DataMember(Name="limiteSemanal", EmitDefaultValue=false)]
        public double? LimiteSemanal { get; set; }
    
        /// <summary>
        /// Valor do limite di\u00E1rio
        /// </summary>
        /// <value>Valor do limite di\u00E1rio</value>
        [DataMember(Name="limiteDiario", EmitDefaultValue=false)]
        public double? LimiteDiario { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ControleLimitesCartaoPersist {\n");
            sb.Append("  LimiteMensal: ").Append(LimiteMensal).Append("\n");
            sb.Append("  LimiteSemanal: ").Append(LimiteSemanal).Append("\n");
            sb.Append("  LimiteDiario: ").Append(LimiteDiario).Append("\n");
            
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
            return this.Equals(obj as ControleLimitesCartaoPersist);
        }

        /// <summary>
        /// Returns true if ControleLimitesCartaoPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of ControleLimitesCartaoPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ControleLimitesCartaoPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LimiteMensal == other.LimiteMensal ||
                    this.LimiteMensal != null &&
                    this.LimiteMensal.Equals(other.LimiteMensal)
                ) && 
                (
                    this.LimiteSemanal == other.LimiteSemanal ||
                    this.LimiteSemanal != null &&
                    this.LimiteSemanal.Equals(other.LimiteSemanal)
                ) && 
                (
                    this.LimiteDiario == other.LimiteDiario ||
                    this.LimiteDiario != null &&
                    this.LimiteDiario.Equals(other.LimiteDiario)
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
                
                if (this.LimiteMensal != null)
                    hash = hash * 59 + this.LimiteMensal.GetHashCode();
                
                if (this.LimiteSemanal != null)
                    hash = hash * 59 + this.LimiteSemanal.GetHashCode();
                
                if (this.LimiteDiario != null)
                    hash = hash * 59 + this.LimiteDiario.GetHashCode();
                
                return hash;
            }
        }

    }
}
