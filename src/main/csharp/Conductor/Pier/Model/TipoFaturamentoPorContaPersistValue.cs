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
    /// {{{tipo_faturamento_por_conta_persist_description}}}
    /// </summary>
    [DataContract]
    public partial class TipoFaturamentoPorContaPersistValue :  IEquatable<TipoFaturamentoPorContaPersistValue>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoFaturamentoPorContaPersistValue" /> class.
        /// Initializes a new instance of the <see cref="TipoFaturamentoPorContaPersistValue" />class.
        /// </summary>
        /// <param name="IdConta">{{{tipo_faturamento_por_conta_persist_id_conta_value}}} (required).</param>
        /// <param name="IdTipoFaturamento">{{{tipo_faturamento_por_conta_persist_id_tipo_faturamento_value}}} (required).</param>

        public TipoFaturamentoPorContaPersistValue(long? IdConta = null, long? IdTipoFaturamento = null)
        {
            // to ensure "IdConta" is required (not null)
            if (IdConta == null)
            {
                throw new InvalidDataException("IdConta is a required property for TipoFaturamentoPorContaPersistValue and cannot be null");
            }
            else
            {
                this.IdConta = IdConta;
            }
            // to ensure "IdTipoFaturamento" is required (not null)
            if (IdTipoFaturamento == null)
            {
                throw new InvalidDataException("IdTipoFaturamento is a required property for TipoFaturamentoPorContaPersistValue and cannot be null");
            }
            else
            {
                this.IdTipoFaturamento = IdTipoFaturamento;
            }
            
        }
        
    
        /// <summary>
        /// {{{tipo_faturamento_por_conta_persist_id_conta_value}}}
        /// </summary>
        /// <value>{{{tipo_faturamento_por_conta_persist_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{tipo_faturamento_por_conta_persist_id_tipo_faturamento_value}}}
        /// </summary>
        /// <value>{{{tipo_faturamento_por_conta_persist_id_tipo_faturamento_value}}}</value>
        [DataMember(Name="idTipoFaturamento", EmitDefaultValue=false)]
        public long? IdTipoFaturamento { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoFaturamentoPorContaPersistValue {\n");
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
            return this.Equals(obj as TipoFaturamentoPorContaPersistValue);
        }

        /// <summary>
        /// Returns true if TipoFaturamentoPorContaPersistValue instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoFaturamentoPorContaPersistValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoFaturamentoPorContaPersistValue other)
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
