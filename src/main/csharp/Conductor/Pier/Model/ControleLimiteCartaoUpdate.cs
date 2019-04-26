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
    /// Objeto para altera\u00E7\u00E3o de controle de limites de um cart\u00E3o. Nenhum dos campos s\u00E3o obrigat\u00F3rios. Devem ser informados apenas os campos que deseja modificar
    /// </summary>
    [DataContract]
    public partial class ControleLimiteCartaoUpdate :  IEquatable<ControleLimiteCartaoUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ControleLimiteCartaoUpdate" /> class.
        /// Initializes a new instance of the <see cref="ControleLimiteCartaoUpdate" />class.
        /// </summary>
        /// <param name="LimiteMensal">Valor do limite mensal.</param>
        /// <param name="LimiteSemanal">Valor do limite semanal.</param>
        /// <param name="LimiteDiario">Valor do limite di\u00E1rio.</param>

        public ControleLimiteCartaoUpdate(double? LimiteMensal = null, double? LimiteSemanal = null, double? LimiteDiario = null)
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
            sb.Append("class ControleLimiteCartaoUpdate {\n");
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
            return this.Equals(obj as ControleLimiteCartaoUpdate);
        }

        /// <summary>
        /// Returns true if ControleLimiteCartaoUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of ControleLimiteCartaoUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ControleLimiteCartaoUpdate other)
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
