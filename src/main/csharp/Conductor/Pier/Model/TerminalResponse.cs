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
    /// ObjetoTerminal
    /// </summary>
    [DataContract]
    public partial class TerminalResponse :  IEquatable<TerminalResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TerminalResponse" /> class.
        /// Initializes a new instance of the <see cref="TerminalResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo de Identifica\u00E7\u00E3o do Terminal (id)..</param>
        /// <param name="Terminal">N\u00FAmero \u00FAnico do terminal..</param>
        /// <param name="NumeroEstabelecimento">N\u00FAmero do estabelecimento a qual o terminal pertence..</param>
        /// <param name="IdEstabelecimento">N\u00FAmero de identifica\u00E7\u00E3o do estabelecimento a qual o terminal pertence..</param>
        /// <param name="FlagConsultaExtrato">Flag indicando se o terminal \u00E9 f\u00EDsico ou virtual, sendo: (true: Sim), (false: N\u00E3o))..</param>
        /// <param name="FlagTerminalVirtual">Flag indicando se o terminal permite consultar extrato, sendo: (true: Sim), (false: N\u00E3o))..</param>

        public TerminalResponse(long? Id = null, string Terminal = null, long? NumeroEstabelecimento = null, long? IdEstabelecimento = null, bool? FlagConsultaExtrato = null, bool? FlagTerminalVirtual = null)
        {
            this.Id = Id;
            this.Terminal = Terminal;
            this.NumeroEstabelecimento = NumeroEstabelecimento;
            this.IdEstabelecimento = IdEstabelecimento;
            this.FlagConsultaExtrato = FlagConsultaExtrato;
            this.FlagTerminalVirtual = FlagTerminalVirtual;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do Terminal (id).
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do Terminal (id).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// N\u00FAmero \u00FAnico do terminal.
        /// </summary>
        /// <value>N\u00FAmero \u00FAnico do terminal.</value>
        [DataMember(Name="terminal", EmitDefaultValue=false)]
        public string Terminal { get; set; }
    
        /// <summary>
        /// N\u00FAmero do estabelecimento a qual o terminal pertence.
        /// </summary>
        /// <value>N\u00FAmero do estabelecimento a qual o terminal pertence.</value>
        [DataMember(Name="numeroEstabelecimento", EmitDefaultValue=false)]
        public long? NumeroEstabelecimento { get; set; }
    
        /// <summary>
        /// N\u00FAmero de identifica\u00E7\u00E3o do estabelecimento a qual o terminal pertence.
        /// </summary>
        /// <value>N\u00FAmero de identifica\u00E7\u00E3o do estabelecimento a qual o terminal pertence.</value>
        [DataMember(Name="idEstabelecimento", EmitDefaultValue=false)]
        public long? IdEstabelecimento { get; set; }
    
        /// <summary>
        /// Flag indicando se o terminal \u00E9 f\u00EDsico ou virtual, sendo: (true: Sim), (false: N\u00E3o)).
        /// </summary>
        /// <value>Flag indicando se o terminal \u00E9 f\u00EDsico ou virtual, sendo: (true: Sim), (false: N\u00E3o)).</value>
        [DataMember(Name="flagConsultaExtrato", EmitDefaultValue=false)]
        public bool? FlagConsultaExtrato { get; set; }
    
        /// <summary>
        /// Flag indicando se o terminal permite consultar extrato, sendo: (true: Sim), (false: N\u00E3o)).
        /// </summary>
        /// <value>Flag indicando se o terminal permite consultar extrato, sendo: (true: Sim), (false: N\u00E3o)).</value>
        [DataMember(Name="flagTerminalVirtual", EmitDefaultValue=false)]
        public bool? FlagTerminalVirtual { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TerminalResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Terminal: ").Append(Terminal).Append("\n");
            sb.Append("  NumeroEstabelecimento: ").Append(NumeroEstabelecimento).Append("\n");
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
            return this.Equals(obj as TerminalResponse);
        }

        /// <summary>
        /// Returns true if TerminalResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TerminalResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TerminalResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Terminal == other.Terminal ||
                    this.Terminal != null &&
                    this.Terminal.Equals(other.Terminal)
                ) && 
                (
                    this.NumeroEstabelecimento == other.NumeroEstabelecimento ||
                    this.NumeroEstabelecimento != null &&
                    this.NumeroEstabelecimento.Equals(other.NumeroEstabelecimento)
                ) && 
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Terminal != null)
                    hash = hash * 59 + this.Terminal.GetHashCode();
                
                if (this.NumeroEstabelecimento != null)
                    hash = hash * 59 + this.NumeroEstabelecimento.GetHashCode();
                
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
