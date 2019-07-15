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
    /// Objeto de refer\u00EAncia para os dados do boleto de entrada
    /// </summary>
    [DataContract]
    public partial class AcordoBoletoPersist :  IEquatable<AcordoBoletoPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AcordoBoletoPersist" /> class.
        /// Initializes a new instance of the <see cref="AcordoBoletoPersist" />class.
        /// </summary>
        /// <param name="IdConvenio">C\u00F3digo de identifia\u00E7\u00E3o do conv\u00EAnio.</param>

        public AcordoBoletoPersist(long? IdConvenio = null)
        {
            this.IdConvenio = IdConvenio;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de identifia\u00E7\u00E3o do conv\u00EAnio
        /// </summary>
        /// <value>C\u00F3digo de identifia\u00E7\u00E3o do conv\u00EAnio</value>
        [DataMember(Name="idConvenio", EmitDefaultValue=false)]
        public long? IdConvenio { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AcordoBoletoPersist {\n");
            sb.Append("  IdConvenio: ").Append(IdConvenio).Append("\n");
            
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
            return this.Equals(obj as AcordoBoletoPersist);
        }

        /// <summary>
        /// Returns true if AcordoBoletoPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of AcordoBoletoPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AcordoBoletoPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdConvenio == other.IdConvenio ||
                    this.IdConvenio != null &&
                    this.IdConvenio.Equals(other.IdConvenio)
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
                
                if (this.IdConvenio != null)
                    hash = hash * 59 + this.IdConvenio.GetHashCode();
                
                return hash;
            }
        }

    }
}
