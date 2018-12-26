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
    /// Representa\u00E7\u00E3o da requisi\u00E7\u00E3o do recurso gerar c\u00F3digo de seguran\u00E7a
    /// </summary>
    [DataContract]
    public partial class CodigoSegurancaSMSPersist :  IEquatable<CodigoSegurancaSMSPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CodigoSegurancaSMSPersist" /> class.
        /// Initializes a new instance of the <see cref="CodigoSegurancaSMSPersist" />class.
        /// </summary>
        /// <param name="Ddd">DDD do telefone.</param>
        /// <param name="Telefone">telefone para envio.</param>

        public CodigoSegurancaSMSPersist(string Ddd = null, string Telefone = null)
        {
            this.Ddd = Ddd;
            this.Telefone = Telefone;
            
        }
        
    
        /// <summary>
        /// DDD do telefone
        /// </summary>
        /// <value>DDD do telefone</value>
        [DataMember(Name="ddd", EmitDefaultValue=false)]
        public string Ddd { get; set; }
    
        /// <summary>
        /// telefone para envio
        /// </summary>
        /// <value>telefone para envio</value>
        [DataMember(Name="telefone", EmitDefaultValue=false)]
        public string Telefone { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CodigoSegurancaSMSPersist {\n");
            sb.Append("  Ddd: ").Append(Ddd).Append("\n");
            sb.Append("  Telefone: ").Append(Telefone).Append("\n");
            
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
            return this.Equals(obj as CodigoSegurancaSMSPersist);
        }

        /// <summary>
        /// Returns true if CodigoSegurancaSMSPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of CodigoSegurancaSMSPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CodigoSegurancaSMSPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Ddd == other.Ddd ||
                    this.Ddd != null &&
                    this.Ddd.Equals(other.Ddd)
                ) && 
                (
                    this.Telefone == other.Telefone ||
                    this.Telefone != null &&
                    this.Telefone.Equals(other.Telefone)
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
                
                if (this.Ddd != null)
                    hash = hash * 59 + this.Ddd.GetHashCode();
                
                if (this.Telefone != null)
                    hash = hash * 59 + this.Telefone.GetHashCode();
                
                return hash;
            }
        }

    }
}
