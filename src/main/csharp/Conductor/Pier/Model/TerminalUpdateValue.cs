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
    /// {{{terminal_update_description}}}
    /// </summary>
    [DataContract]
    public partial class TerminalUpdateValue :  IEquatable<TerminalUpdateValue>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TerminalUpdateValue" /> class.
        /// Initializes a new instance of the <see cref="TerminalUpdateValue" />class.
        /// </summary>
        /// <param name="FlagConsultaExtrato">{{{terminal_update_flag_consulta_extrato_value}}} (required).</param>
        /// <param name="FlagTerminalVirtual">{{{terminal_update_flag_terminal_virtual_value}}} (required).</param>

        public TerminalUpdateValue(bool? FlagConsultaExtrato = null, bool? FlagTerminalVirtual = null)
        {
            // to ensure "FlagConsultaExtrato" is required (not null)
            if (FlagConsultaExtrato == null)
            {
                throw new InvalidDataException("FlagConsultaExtrato is a required property for TerminalUpdateValue and cannot be null");
            }
            else
            {
                this.FlagConsultaExtrato = FlagConsultaExtrato;
            }
            // to ensure "FlagTerminalVirtual" is required (not null)
            if (FlagTerminalVirtual == null)
            {
                throw new InvalidDataException("FlagTerminalVirtual is a required property for TerminalUpdateValue and cannot be null");
            }
            else
            {
                this.FlagTerminalVirtual = FlagTerminalVirtual;
            }
            
        }
        
    
        /// <summary>
        /// {{{terminal_update_flag_consulta_extrato_value}}}
        /// </summary>
        /// <value>{{{terminal_update_flag_consulta_extrato_value}}}</value>
        [DataMember(Name="flagConsultaExtrato", EmitDefaultValue=false)]
        public bool? FlagConsultaExtrato { get; set; }
    
        /// <summary>
        /// {{{terminal_update_flag_terminal_virtual_value}}}
        /// </summary>
        /// <value>{{{terminal_update_flag_terminal_virtual_value}}}</value>
        [DataMember(Name="flagTerminalVirtual", EmitDefaultValue=false)]
        public bool? FlagTerminalVirtual { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TerminalUpdateValue {\n");
            sb.Append("  FlagConsultaExtrato: ").Append(FlagConsultaExtrato).Append("\n");
            sb.Append("  FlagTerminalVirtual: ").Append(FlagTerminalVirtual).Append("\n");
            
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
            return this.Equals(obj as TerminalUpdateValue);
        }

        /// <summary>
        /// Returns true if TerminalUpdateValue instances are equal
        /// </summary>
        /// <param name="other">Instance of TerminalUpdateValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TerminalUpdateValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FlagConsultaExtrato == other.FlagConsultaExtrato ||
                    this.FlagConsultaExtrato != null &&
                    this.FlagConsultaExtrato.Equals(other.FlagConsultaExtrato)
                ) && 
                (
                    this.FlagTerminalVirtual == other.FlagTerminalVirtual ||
                    this.FlagTerminalVirtual != null &&
                    this.FlagTerminalVirtual.Equals(other.FlagTerminalVirtual)
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
                
                if (this.FlagConsultaExtrato != null)
                    hash = hash * 59 + this.FlagConsultaExtrato.GetHashCode();
                
                if (this.FlagTerminalVirtual != null)
                    hash = hash * 59 + this.FlagTerminalVirtual.GetHashCode();
                
                return hash;
            }
        }

    }
}
