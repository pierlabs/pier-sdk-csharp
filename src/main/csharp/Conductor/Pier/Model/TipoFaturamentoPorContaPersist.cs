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
    /// TipoFaturamentoPorContaPersist
    /// </summary>
    [DataContract]
    public partial class TipoFaturamentoPorContaPersist :  IEquatable<TipoFaturamentoPorContaPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoFaturamentoPorContaPersist" /> class.
        /// Initializes a new instance of the <see cref="TipoFaturamentoPorContaPersist" />class.
        /// </summary>
        /// <param name="IdConta">C\u00F3digo de identifica\u00E7\u00E3o da conta relacionada (required).</param>
        /// <param name="IdTipoFaturamento">C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento relacionada (required).</param>

        public TipoFaturamentoPorContaPersist(long? IdConta = null, long? IdTipoFaturamento = null)
        {
            // to ensure "IdConta" is required (not null)
            if (IdConta == null)
            {
                throw new InvalidDataException("IdConta is a required property for TipoFaturamentoPorContaPersist and cannot be null");
            }
            else
            {
                this.IdConta = IdConta;
            }
            // to ensure "IdTipoFaturamento" is required (not null)
            if (IdTipoFaturamento == null)
            {
                throw new InvalidDataException("IdTipoFaturamento is a required property for TipoFaturamentoPorContaPersist and cannot be null");
            }
            else
            {
                this.IdTipoFaturamento = IdTipoFaturamento;
            }
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da conta relacionada
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da conta relacionada</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento relacionada
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do tipo de faturamento relacionada</value>
        [DataMember(Name="idTipoFaturamento", EmitDefaultValue=false)]
        public long? IdTipoFaturamento { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoFaturamentoPorContaPersist {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdTipoFaturamento: ").Append(IdTipoFaturamento).Append("\n");
            
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
            return this.Equals(obj as TipoFaturamentoPorContaPersist);
        }

        /// <summary>
        /// Returns true if TipoFaturamentoPorContaPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoFaturamentoPorContaPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoFaturamentoPorContaPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdTipoFaturamento == other.IdTipoFaturamento ||
                    this.IdTipoFaturamento != null &&
                    this.IdTipoFaturamento.Equals(other.IdTipoFaturamento)
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
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdTipoFaturamento != null)
                    hash = hash * 59 + this.IdTipoFaturamento.GetHashCode();
                
                return hash;
            }
        }

    }
}
