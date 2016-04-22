using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Conductor.CaaS.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class DesbloquearCartaoResponse :  IEquatable<DesbloquearCartaoResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DesbloquearCartaoResponse" /> class.
        /// </summary>
        public DesbloquearCartaoResponse()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets CodigoRetorno
        /// </summary>
        [DataMember(Name="codigoRetorno", EmitDefaultValue=false)]
        public int? CodigoRetorno { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DescricaoRetorno
        /// </summary>
        [DataMember(Name="descricaoRetorno", EmitDefaultValue=false)]
        public string DescricaoRetorno { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesbloquearCartaoResponse {\n");
            sb.Append("  CodigoRetorno: ").Append(CodigoRetorno).Append("\n");
            sb.Append("  DescricaoRetorno: ").Append(DescricaoRetorno).Append("\n");
            
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
            return this.Equals(obj as DesbloquearCartaoResponse);
        }

        /// <summary>
        /// Returns true if DesbloquearCartaoResponse instances are equal
        /// </summary>
        /// <param name="obj">Instance of DesbloquearCartaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DesbloquearCartaoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CodigoRetorno == other.CodigoRetorno ||
                    this.CodigoRetorno != null &&
                    this.CodigoRetorno.Equals(other.CodigoRetorno)
                ) && 
                (
                    this.DescricaoRetorno == other.DescricaoRetorno ||
                    this.DescricaoRetorno != null &&
                    this.DescricaoRetorno.Equals(other.DescricaoRetorno)
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
                
                if (this.CodigoRetorno != null)
                    hash = hash * 57 + this.CodigoRetorno.GetHashCode();
                
                if (this.DescricaoRetorno != null)
                    hash = hash * 57 + this.DescricaoRetorno.GetHashCode();
                
                return hash;
            }
        }

    }
}
