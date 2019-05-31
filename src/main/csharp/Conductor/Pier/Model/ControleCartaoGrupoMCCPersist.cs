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
    /// Objeto para persist\u00EAncia de Controle de Cartao por mcc.
    /// </summary>
    [DataContract]
    public partial class ControleCartaoGrupoMCCPersist :  IEquatable<ControleCartaoGrupoMCCPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ControleCartaoGrupoMCCPersist" /> class.
        /// Initializes a new instance of the <see cref="ControleCartaoGrupoMCCPersist" />class.
        /// </summary>
        /// <param name="IdsGruposMCC">idGrupoMCC (required).</param>

        public ControleCartaoGrupoMCCPersist(List<long?> IdsGruposMCC = null)
        {
            // to ensure "IdsGruposMCC" is required (not null)
            if (IdsGruposMCC == null)
            {
                throw new InvalidDataException("IdsGruposMCC is a required property for ControleCartaoGrupoMCCPersist and cannot be null");
            }
            else
            {
                this.IdsGruposMCC = IdsGruposMCC;
            }
            
        }
        
    
        /// <summary>
        /// idGrupoMCC
        /// </summary>
        /// <value>idGrupoMCC</value>
        [DataMember(Name="idsGruposMCC", EmitDefaultValue=false)]
        public List<long?> IdsGruposMCC { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ControleCartaoGrupoMCCPersist {\n");
            sb.Append("  IdsGruposMCC: ").Append(IdsGruposMCC).Append("\n");
            
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
            return this.Equals(obj as ControleCartaoGrupoMCCPersist);
        }

        /// <summary>
        /// Returns true if ControleCartaoGrupoMCCPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of ControleCartaoGrupoMCCPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ControleCartaoGrupoMCCPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdsGruposMCC == other.IdsGruposMCC ||
                    this.IdsGruposMCC != null &&
                    this.IdsGruposMCC.SequenceEqual(other.IdsGruposMCC)
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
                
                if (this.IdsGruposMCC != null)
                    hash = hash * 59 + this.IdsGruposMCC.GetHashCode();
                
                return hash;
            }
        }

    }
}
