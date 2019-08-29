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
    /// Representa\u00E7\u00E3o da requisi\u00E7\u00E3o de cadastro do motivo fraude
    /// </summary>
    [DataContract]
    public partial class MotivoFraudePersist :  IEquatable<MotivoFraudePersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MotivoFraudePersist" /> class.
        /// Initializes a new instance of the <see cref="MotivoFraudePersist" />class.
        /// </summary>
        /// <param name="Descricao">Descri\u00E7\u00E3o motivo fraude.</param>

        public MotivoFraudePersist(string Descricao = null)
        {
            this.Descricao = Descricao;
            
        }
        
    
        /// <summary>
        /// Descri\u00E7\u00E3o motivo fraude
        /// </summary>
        /// <value>Descri\u00E7\u00E3o motivo fraude</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MotivoFraudePersist {\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            
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
            return this.Equals(obj as MotivoFraudePersist);
        }

        /// <summary>
        /// Returns true if MotivoFraudePersist instances are equal
        /// </summary>
        /// <param name="other">Instance of MotivoFraudePersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MotivoFraudePersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
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
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                return hash;
            }
        }

    }
}
