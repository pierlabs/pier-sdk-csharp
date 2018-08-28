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
    /// {{{sensibilizar_saldo_global_update_description}}}
    /// </summary>
    [DataContract]
    public partial class SensibilizarSaldoGlobalUpdateValue :  IEquatable<SensibilizarSaldoGlobalUpdateValue>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SensibilizarSaldoGlobalUpdateValue" /> class.
        /// Initializes a new instance of the <see cref="SensibilizarSaldoGlobalUpdateValue" />class.
        /// </summary>
        /// <param name="Valor">{{{sensibilizar_saldo_global_update_valor_value}}} (required).</param>

        public SensibilizarSaldoGlobalUpdateValue(double? Valor = null)
        {
            // to ensure "Valor" is required (not null)
            if (Valor == null)
            {
                throw new InvalidDataException("Valor is a required property for SensibilizarSaldoGlobalUpdateValue and cannot be null");
            }
            else
            {
                this.Valor = Valor;
            }
            
        }
        
    
        /// <summary>
        /// {{{sensibilizar_saldo_global_update_valor_value}}}
        /// </summary>
        /// <value>{{{sensibilizar_saldo_global_update_valor_value}}}</value>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SensibilizarSaldoGlobalUpdateValue {\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            
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
            return this.Equals(obj as SensibilizarSaldoGlobalUpdateValue);
        }

        /// <summary>
        /// Returns true if SensibilizarSaldoGlobalUpdateValue instances are equal
        /// </summary>
        /// <param name="other">Instance of SensibilizarSaldoGlobalUpdateValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SensibilizarSaldoGlobalUpdateValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Valor == other.Valor ||
                    this.Valor != null &&
                    this.Valor.Equals(other.Valor)
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
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
                return hash;
            }
        }

    }
}
