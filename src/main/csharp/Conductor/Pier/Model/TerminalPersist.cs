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
    /// Objeto Terminal
    /// </summary>
    [DataContract]
    public partial class TerminalPersist :  IEquatable<TerminalPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TerminalPersist" /> class.
        /// Initializes a new instance of the <see cref="TerminalPersist" />class.
        /// </summary>
        /// <param name="IdEstabelecimento">Apresenta o id do estabelecimento. (required).</param>
        /// <param name="FlagConsultaExtrato">Flag indicando se permite consultar extrato, sendo: (true: Sim), (false: N\u00C3\u00A3o)). (required).</param>
        /// <param name="FlagTerminalVirtual">Flag indicando se o terminal \u00C3\u00A9 f\u00C3\u00ADsico ou virtual, sendo: (true: Sim), (false: N\u00C3\u00A3o)). (required).</param>

        public TerminalPersist(long? IdEstabelecimento = null, bool? FlagConsultaExtrato = null, bool? FlagTerminalVirtual = null)
        {
            // to ensure "IdEstabelecimento" is required (not null)
            if (IdEstabelecimento == null)
            {
                throw new InvalidDataException("IdEstabelecimento is a required property for TerminalPersist and cannot be null");
            }
            else
            {
                this.IdEstabelecimento = IdEstabelecimento;
            }
            // to ensure "FlagConsultaExtrato" is required (not null)
            if (FlagConsultaExtrato == null)
            {
                throw new InvalidDataException("FlagConsultaExtrato is a required property for TerminalPersist and cannot be null");
            }
            else
            {
                this.FlagConsultaExtrato = FlagConsultaExtrato;
            }
            // to ensure "FlagTerminalVirtual" is required (not null)
            if (FlagTerminalVirtual == null)
            {
                throw new InvalidDataException("FlagTerminalVirtual is a required property for TerminalPersist and cannot be null");
            }
            else
            {
                this.FlagTerminalVirtual = FlagTerminalVirtual;
            }
            
        }
        
    
        /// <summary>
        /// Apresenta o id do estabelecimento.
        /// </summary>
        /// <value>Apresenta o id do estabelecimento.</value>
        [DataMember(Name="idEstabelecimento", EmitDefaultValue=false)]
        public long? IdEstabelecimento { get; set; }
    
        /// <summary>
        /// Flag indicando se permite consultar extrato, sendo: (true: Sim), (false: N\u00C3\u00A3o)).
        /// </summary>
        /// <value>Flag indicando se permite consultar extrato, sendo: (true: Sim), (false: N\u00C3\u00A3o)).</value>
        [DataMember(Name="flagConsultaExtrato", EmitDefaultValue=false)]
        public bool? FlagConsultaExtrato { get; set; }
    
        /// <summary>
        /// Flag indicando se o terminal \u00C3\u00A9 f\u00C3\u00ADsico ou virtual, sendo: (true: Sim), (false: N\u00C3\u00A3o)).
        /// </summary>
        /// <value>Flag indicando se o terminal \u00C3\u00A9 f\u00C3\u00ADsico ou virtual, sendo: (true: Sim), (false: N\u00C3\u00A3o)).</value>
        [DataMember(Name="flagTerminalVirtual", EmitDefaultValue=false)]
        public bool? FlagTerminalVirtual { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TerminalPersist {\n");
            sb.Append("  IdEstabelecimento: ").Append(IdEstabelecimento).Append("\n");
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
            return this.Equals(obj as TerminalPersist);
        }

        /// <summary>
        /// Returns true if TerminalPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of TerminalPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TerminalPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdEstabelecimento == other.IdEstabelecimento ||
                    this.IdEstabelecimento != null &&
                    this.IdEstabelecimento.Equals(other.IdEstabelecimento)
                ) && 
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
                
                if (this.IdEstabelecimento != null)
                    hash = hash * 59 + this.IdEstabelecimento.GetHashCode();
                
                if (this.FlagConsultaExtrato != null)
                    hash = hash * 59 + this.FlagConsultaExtrato.GetHashCode();
                
                if (this.FlagTerminalVirtual != null)
                    hash = hash * 59 + this.FlagTerminalVirtual.GetHashCode();
                
                return hash;
            }
        }

    }
}
