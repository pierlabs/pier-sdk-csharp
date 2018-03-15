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
    /// ObjetoTipoTerminal
    /// </summary>
    [DataContract]
    public partial class TipoTerminalResponse :  IEquatable<TipoTerminalResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoTerminalResponse" /> class.
        /// Initializes a new instance of the <see cref="TipoTerminalResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo Terminal (id)..</param>
        /// <param name="DescricaoTerminal">Descri\u00E7\u00E3o do Tipo Terminal..</param>

        public TipoTerminalResponse(long? Id = null, string DescricaoTerminal = null)
        {
            this.Id = Id;
            this.DescricaoTerminal = DescricaoTerminal;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do Tipo Terminal (id).
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do Tipo Terminal (id).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do Tipo Terminal.
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do Tipo Terminal.</value>
        [DataMember(Name="descricaoTerminal", EmitDefaultValue=false)]
        public string DescricaoTerminal { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoTerminalResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DescricaoTerminal: ").Append(DescricaoTerminal).Append("\n");
            
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
            return this.Equals(obj as TipoTerminalResponse);
        }

        /// <summary>
        /// Returns true if TipoTerminalResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoTerminalResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoTerminalResponse other)
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
                    this.DescricaoTerminal == other.DescricaoTerminal ||
                    this.DescricaoTerminal != null &&
                    this.DescricaoTerminal.Equals(other.DescricaoTerminal)
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
                
                if (this.DescricaoTerminal != null)
                    hash = hash * 59 + this.DescricaoTerminal.GetHashCode();
                
                return hash;
            }
        }

    }
}
