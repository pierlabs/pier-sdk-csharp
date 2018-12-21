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
    /// {{{proposta_parcial_update_description}}}
    /// </summary>
    [DataContract]
    public partial class PropostaParcialUpdate :  IEquatable<PropostaParcialUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PropostaParcialUpdate" /> class.
        /// Initializes a new instance of the <see cref="PropostaParcialUpdate" />class.
        /// </summary>
        /// <param name="Correspondencia">{{{proposta_parcial_update_correspondencia_value}}}.</param>

        public PropostaParcialUpdate(int? Correspondencia = null)
        {
            this.Correspondencia = Correspondencia;
            
        }
        
    
        /// <summary>
        /// {{{proposta_parcial_update_correspondencia_value}}}
        /// </summary>
        /// <value>{{{proposta_parcial_update_correspondencia_value}}}</value>
        [DataMember(Name="correspondencia", EmitDefaultValue=false)]
        public int? Correspondencia { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropostaParcialUpdate {\n");
            sb.Append("  Correspondencia: ").Append(Correspondencia).Append("\n");
            
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
            return this.Equals(obj as PropostaParcialUpdate);
        }

        /// <summary>
        /// Returns true if PropostaParcialUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of PropostaParcialUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropostaParcialUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Correspondencia == other.Correspondencia ||
                    this.Correspondencia != null &&
                    this.Correspondencia.Equals(other.Correspondencia)
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
                
                if (this.Correspondencia != null)
                    hash = hash * 59 + this.Correspondencia.GetHashCode();
                
                return hash;
            }
        }

    }
}
