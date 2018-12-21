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
    /// TerminalUpdate
    /// </summary>
    [DataContract]
    public partial class TerminalUpdate :  IEquatable<TerminalUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TerminalUpdate" /> class.
        /// Initializes a new instance of the <see cref="TerminalUpdate" />class.
        /// </summary>
        /// <param name="FlagConsultaExtrato">Flag indicating if the terminal allows to retrieve the bank statement, being: (true: yes), (false: No)) (required).</param>
        /// <param name="FlagTerminalVirtual">Flag indicating if the termina is physical or virtual, being: (true: Yes), (false: No)) (required).</param>

        public TerminalUpdate(bool? FlagConsultaExtrato = null, bool? FlagTerminalVirtual = null)
        {
            // to ensure "FlagConsultaExtrato" is required (not null)
            if (FlagConsultaExtrato == null)
            {
                throw new InvalidDataException("FlagConsultaExtrato is a required property for TerminalUpdate and cannot be null");
            }
            else
            {
                this.FlagConsultaExtrato = FlagConsultaExtrato;
            }
            // to ensure "FlagTerminalVirtual" is required (not null)
            if (FlagTerminalVirtual == null)
            {
                throw new InvalidDataException("FlagTerminalVirtual is a required property for TerminalUpdate and cannot be null");
            }
            else
            {
                this.FlagTerminalVirtual = FlagTerminalVirtual;
            }
            
        }
        
    
        /// <summary>
        /// Flag indicating if the terminal allows to retrieve the bank statement, being: (true: yes), (false: No))
        /// </summary>
        /// <value>Flag indicating if the terminal allows to retrieve the bank statement, being: (true: yes), (false: No))</value>
        [DataMember(Name="flagConsultaExtrato", EmitDefaultValue=false)]
        public bool? FlagConsultaExtrato { get; set; }
    
        /// <summary>
        /// Flag indicating if the termina is physical or virtual, being: (true: Yes), (false: No))
        /// </summary>
        /// <value>Flag indicating if the termina is physical or virtual, being: (true: Yes), (false: No))</value>
        [DataMember(Name="flagTerminalVirtual", EmitDefaultValue=false)]
        public bool? FlagTerminalVirtual { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TerminalUpdate {\n");
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
            return this.Equals(obj as TerminalUpdate);
        }

        /// <summary>
        /// Returns true if TerminalUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of TerminalUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TerminalUpdate other)
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
